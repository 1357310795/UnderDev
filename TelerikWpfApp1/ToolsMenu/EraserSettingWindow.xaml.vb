Imports System.Windows.Ink

Public Class EraserSettingWindow
    Inherits Window
    Public i As InkCanvas
    Public drawer As DrawingAttributes
    Public mw As MainWindow1

    Public Sub initdrawerandcanvas(d As InkCanvas, e As DrawingAttributes, p As MainWindow1)
        i = d
        drawer = e
        mw = p
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        i.EditingMode = InkCanvasEditingMode.EraseByStroke
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        i.EditingMode = InkCanvasEditingMode.EraseByPoint
        i.DefaultDrawingAttributes = drawer
    End Sub

    Private Async Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim res As String
        res = Await MaterialDesignThemes.Wpf.DialogHost.Show(New YesNoDialog(300, "确定要擦除全部墨迹？"), "MainDialogHost1")
        Console.WriteLine(res)
        If res = "OK" Then
            i.Strokes.Clear()
            mw.PenRadioButton.IsChecked = True
        End If
    End Sub

    Private Sub Window_LostFocus(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As EventArgs)
        Dim da1 = CubicBezierDoubleAnimation(TimeSpan.FromSeconds(0.3), 0, 1, "0,.71,.47,1")
        Dim da2 = CubicBezierDoubleAnimation(TimeSpan.FromSeconds(0.2), TimeSpan.FromSeconds(0.5), 0, 1, "0,.71,.47,1")
        Dim da3 = CubicBezierDoubleAnimation(TimeSpan.FromSeconds(0.4), TimeSpan.FromSeconds(0.7), 0, 1, "0,.71,.47,1")
        MyScaleTransform1.BeginAnimation(ScaleTransform.ScaleXProperty, da3)
        MyScaleTransform2.BeginAnimation(ScaleTransform.ScaleXProperty, da2)
        MyScaleTransform3.BeginAnimation(ScaleTransform.ScaleXProperty, da1)
        AddHandler da3.Completed, Sub()
                                      MyScaleTransform1.BeginAnimation(ScaleTransform.ScaleXProperty, Nothing)
                                      MyScaleTransform2.BeginAnimation(ScaleTransform.ScaleXProperty, Nothing)
                                      MyScaleTransform3.BeginAnimation(ScaleTransform.ScaleXProperty, Nothing)
                                  End Sub
    End Sub

    Private Sub Window_Closed(sender As Object, e As EventArgs)
        FlushMemory.Flush()
    End Sub
End Class
