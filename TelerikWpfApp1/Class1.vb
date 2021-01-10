Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Ink
Imports System.Windows.Input

Namespace MultiTouchInkCanvas
    Partial Public Class InkCanvasWrapper
        Inherits UserControl

        Private Const ThreasholdNearbyDistance As Integer = 1
        Private ReadOnly _currentCanvasStrokes As Dictionary(Of Integer, Stroke)
        Private _strokeHitTester As IncrementalStrokeHitTester
        Private _addingStroke As Stroke

        Public Sub New()
            InitializeComponent()
            Loaded += AddressOf OnLoaded
            _currentCanvasStrokes = New Dictionary(Of Integer, Stroke)()
            TouchDown += AddressOf OnTouchDown
            TouchUp += AddressOf OnTouchUp
            TouchMove += AddressOf OnTouchMove
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal routedEventArgs As RoutedEventArgs)
        End Sub

        Private Sub OnTouchDown(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
            Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
            Dim point = touchPoint.Position

            If ControlInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint Then

                If _strokeHitTester Is Nothing Then
                    _strokeHitTester = ControlInkCanvas.Strokes.GetIncrementalStrokeHitTester(New EllipseStylusShape(10, 10))
                    _strokeHitTester.StrokeHit += Function(o, argsHitTester)
                                                      Dim eraseResults = argsHitTester.GetPointEraseResults()
                                                      ControlInkCanvas.Strokes.Remove(argsHitTester.HitStroke)
                                                      ControlInkCanvas.Strokes.Add(eraseResults)
                                                  End Function
                End If

                _strokeHitTester.AddPoint(point)
                Return
            End If

            _addingStroke = New Stroke(New StylusPointCollection(New List(Of Point) From {
                point
            }), ControlInkCanvas.DefaultDrawingAttributes)

            If Not _currentCanvasStrokes.ContainsKey(touchPoint.TouchDevice.Id) Then
                _currentCanvasStrokes.Add(touchPoint.TouchDevice.Id, _addingStroke)
                ControlInkCanvas.Strokes.Add(_addingStroke)
            End If
        End Sub

        Private Sub OnTouchUp(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
            Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
            _currentCanvasStrokes.Remove(touchPoint.TouchDevice.Id)
            _strokeHitTester = Nothing
        End Sub

        Private Sub OnTouchMove(ByVal sender As Object, ByVal touchEventArgs As TouchEventArgs)
            Dim touchPoint = touchEventArgs.GetTouchPoint(Me)
            Dim point = touchPoint.Position

            If ControlInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint Then

                If _strokeHitTester IsNot Nothing Then
                    _strokeHitTester.AddPoint(point)
                End If

                Return
            End If

            If _currentCanvasStrokes.ContainsKey(touchPoint.TouchDevice.Id) Then
                Dim stroke = _currentCanvasStrokes(touchPoint.TouchDevice.Id)
                Dim nearbyPoint = IsNearbyPoint(stroke, point)

                If Not nearbyPoint Then
                    stroke.StylusPoints.Add(New StylusPoint(point.X, point.Y))
                End If
            End If
        End Sub

        Private Shared Function IsNearbyPoint(ByVal stroke As Stroke, ByVal point As Point) As Boolean
            Return stroke.StylusPoints.Any(Function(p) (Math.Abs(p.X - point.X) <= ThreasholdNearbyDistance) AndAlso (Math.Abs(p.Y - point.Y) <= ThreasholdNearbyDistance))
        End Function

        Public Sub SetIsErasingMode(ByVal isErasing As Boolean)
            If isErasing Then
                ControlInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint
                ControlInkCanvas.EraserShape = New EllipseStylusShape(20, 20)
                Return
            End If

            ControlInkCanvas.EditingMode = InkCanvasEditingMode.Ink
        End Sub
    End Class
End Namespace
