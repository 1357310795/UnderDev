Imports System.Windows.Ink
Public Class CameraView
    Inherits UserControl
    Public Edit_Mode As Edit_Mode_Enum
    Public scale = 1
    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        InkCanvas1.EraserShape = New Ink.RectangleStylusShape(30, 50)
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        s = New List(Of StrokeCollection)
        s.Add(New StrokeCollection())
        n = 0

        _currentCanvasStrokes = New Dictionary(Of Integer, Stroke)()
        _lasttimestamp = New Dictionary(Of Integer, Double)
        _lastpoint = New Dictionary(Of Integer, StylusPoint)
        AddHandler InkCanvas1.TouchDown, AddressOf OnTouchDown
        AddHandler InkCanvas1.TouchUp, AddressOf OnTouchUp
        AddHandler InkCanvas1.TouchMove, AddressOf OnTouchMove
        AddHandler InkCanvas1.PreviewMouseDown, AddressOf OnMouseDown
        AddHandler InkCanvas1.MouseUp, AddressOf OnMouseUp
        AddHandler InkCanvas1.MouseLeave, AddressOf OnMouseUp
    End Sub

#Region "Scale&Move"

    Private Sub Canvas1_ManipulationStarting(ByVal sender As Object, ByVal e As ManipulationStartingEventArgs)
        e.ManipulationContainer = Canvas1
    End Sub

    Private Sub Canvas1_ManipulationStarted(ByVal sender As Object, ByVal e As ManipulationStartedEventArgs)
    End Sub

    Private Sub Canvas1_ManipulationDelta(ByVal sender As Object, ByVal e As ManipulationDeltaEventArgs)
        If Edit_Mode <> Edit_Mode_Enum.Cursor Then Exit Sub
        Dim scale = e.DeltaManipulation.Scale
        Dim expansion = e.DeltaManipulation.Expansion
        Dim rotation = e.DeltaManipulation.Rotation
        Dim translation = e.DeltaManipulation.Translation
        Dim cumulativeScale = e.CumulativeManipulation.Scale
        Dim cumulativeExpansion = e.CumulativeManipulation.Expansion
        Dim cumulativeRotation = e.CumulativeManipulation.Rotation
        Dim cumulativeRranslation = e.CumulativeManipulation.Translation

        ScaleTransform.ScaleX *= scale.X
        ScaleTransform.ScaleY *= scale.Y
        RotateTransform.Angle += rotation
        TranslateTransform.X += translation.X
        TranslateTransform.Y += translation.Y
    End Sub

    Private Sub Canvas1_ManipulationCompleted(ByVal sender As Object, ByVal e As ManipulationCompletedEventArgs)

    End Sub
#End Region

#Region "page_control"
    Public s As List(Of StrokeCollection)
    Public n As Int32
    Public Sub ChangePage(x As StrokeCollection)
        InkCanvas1.Strokes = x
    End Sub

    Public Sub AddPage()
        s(n) = InkCanvas1.Strokes
        s.Add(New StrokeCollection)
        n = s.Count - 1
        ChangePage(s(n))
    End Sub

    Public Sub PrevPage()
        If n = 0 Then
            Exit Sub
        End If
        s(n) = InkCanvas1.Strokes
        n = n - 1
        ChangePage(s(n))
    End Sub

    Public Sub NextPage()
        If n = s.Count - 1 Then
            Exit Sub
        End If
        s(n) = InkCanvas1.Strokes
        n = n + 1
        'cv.InkCanvas1.Strokes = s(n)
        ChangePage(s(n))
    End Sub

    Public Function getlabel() As String
        Return CStr(n + 1) + "/" + CStr(s.Count)
    End Function
#End Region
    Private Sub InkCanvas1_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles InkCanvas1.SizeChanged
        If e.NewSize.Width <> webCam.Width Then
            InkCanvas1.Width = webCam.Width
        End If
        If e.NewSize.Height <> webCam.Height Then
            InkCanvas1.Height = webCam.Height
        End If
    End Sub
#Region "MultiTouch"
    Private Const ThreasholdNearbyDistance As Double = 0.01
    Private ReadOnly _currentCanvasStrokes As Dictionary(Of Integer, Stroke)
    Private ReadOnly _lasttimestamp As Dictionary(Of Integer, Double)
    Private ReadOnly _lastpoint As Dictionary(Of Integer, StylusPoint)
    Private _strokeHitTester As IncrementalStrokeHitTester
    Private _addingStroke As Stroke
    Private maxv As Double = 200
    Private Sub StrokeHit(sender As Object, argsHitTester As StrokeHitEventArgs)
        Dim eraseResults = argsHitTester.GetPointEraseResults()
        InkCanvas1.Strokes.Remove(argsHitTester.HitStroke)
        InkCanvas1.Strokes.Add(eraseResults)
    End Sub

    Private Sub OnTouchDown(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
        Console.WriteLine("OnTouchDown")
        Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
        Dim point = touchPoint.Position

        If InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint Then
            If _strokeHitTester Is Nothing Then
                _strokeHitTester = InkCanvas1.Strokes.GetIncrementalStrokeHitTester(InkCanvas1.EraserShape)
                AddHandler _strokeHitTester.StrokeHit, AddressOf StrokeHit
            End If
            _strokeHitTester.AddPoint(point)
            Return
        End If

        If Edit_Mode = Edit_Mode_Enum.Pen Then
            _addingStroke = New Stroke(New StylusPointCollection(New List(Of StylusPoint) From {
                New StylusPoint(point.X, point.Y, 0.5)
            }), InkCanvas1.DefaultDrawingAttributes.Clone)

            If Not _currentCanvasStrokes.ContainsKey(touchPoint.TouchDevice.Id) Then
                _currentCanvasStrokes.Add(touchPoint.TouchDevice.Id, _addingStroke)
                InkCanvas1.Strokes.Add(_addingStroke)
                _lasttimestamp.Add(touchPoint.TouchDevice.Id, DateTime.Now.Ticks / 1000000D)
                _lastpoint.Add(touchPoint.TouchDevice.Id, _addingStroke.StylusPoints(0))
            End If
        End If
    End Sub

    Private Sub OnTouchUp(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
        Console.WriteLine("OnTouchUp")

        If InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint Then
            _strokeHitTester = Nothing
            Return
        End If

        If Edit_Mode = Edit_Mode_Enum.Pen Then
            Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
            Dim spc As StylusPointCollection = _currentCanvasStrokes(touchPoint.TouchDevice.Id).StylusPoints
            Console.WriteLine(spc.Count)
            If (spc.Count > 5) Then
                If (spc(spc.Count - 2).PressureFactor < 0.8) Then
                    For i = 1 To 1 Step -1
                        Dim t As StylusPoint = spc(spc.Count - i)
                        t.PressureFactor = 0.1F + (spc(spc.Count - 2).PressureFactor - 0.1F) * (i - 1) / 2
                        spc(spc.Count - i) = t
                    Next
                End If
            End If
            _currentCanvasStrokes.Remove(touchPoint.TouchDevice.Id)
            _lasttimestamp.Remove(touchPoint.TouchDevice.Id)
            _lastpoint.Remove(touchPoint.TouchDevice.Id)
        End If
    End Sub

    Private Sub OnTouchMove(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
        'Console.WriteLine("OnTouchMove")
        Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
        Dim point = touchPoint.Position

        If InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint Then
            If _strokeHitTester IsNot Nothing Then
                _strokeHitTester.AddPoint(point)
            End If
            Return
        End If

        If Edit_Mode = Edit_Mode_Enum.Pen Then
            If _currentCanvasStrokes.ContainsKey(touchPoint.TouchDevice.Id) Then
                Dim stroke = _currentCanvasStrokes(touchPoint.TouchDevice.Id)
                Dim nearbyPoint = IsNearbyPoint(stroke, point)

                If Not nearbyPoint Then
                    Dim sp As StylusPoint = New StylusPoint(point.X, point.Y)
                    Dim nowtime As Double = DateTime.Now.Ticks / 1000000D
                    Dim v = (point - _lastpoint(touchPoint.TouchDevice.Id).ToPoint).Length / (nowtime - _lasttimestamp(touchPoint.TouchDevice.Id))
                    If (Double.IsNaN(v) Or v > maxv) Then
                        sp.PressureFactor = 0.2F
                    Else
                        sp.PressureFactor = CType((0.8F - (0.6F / maxv) * v), Single)
                    End If
                    stroke.StylusPoints.Add(sp)
                    _lastpoint(touchPoint.TouchDevice.Id) = sp
                    _lasttimestamp(touchPoint.TouchDevice.Id) = nowtime
                    Application.Current.Resources("speed") = v.ToString()
                    If (Not Double.IsNaN(v) And Not Double.IsPositiveInfinity(v)) Then
                        Application.Current.Resources("speedint") = v
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Console.WriteLine("OnMouseDown")
        If e.StylusDevice IsNot Nothing Then Return
        Dim point = e.GetPosition(InkCanvas1)
        If Edit_Mode = Edit_Mode_Enum.Pen Then
            InkCanvas1.EditingMode = InkCanvasEditingMode.Ink
            InkCanvas1.CaptureMouse()
        End If
    End Sub

    Private Sub OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Console.WriteLine("OnMouseUp")
        If e.StylusDevice IsNot Nothing Then Return
        If Edit_Mode = Edit_Mode_Enum.Pen Then
            InkCanvas1.EditingMode = InkCanvasEditingMode.None
            InkCanvas1.ReleaseMouseCapture()
        End If
    End Sub


    Private Shared Function IsNearbyPoint(ByVal stroke As Stroke, ByVal point As Point) As Boolean
        Return stroke.StylusPoints.Any(Function(p) (Math.Abs(p.X - point.X) <= ThreasholdNearbyDistance) AndAlso (Math.Abs(p.Y - point.Y) <= ThreasholdNearbyDistance))
    End Function
#End Region
End Class
