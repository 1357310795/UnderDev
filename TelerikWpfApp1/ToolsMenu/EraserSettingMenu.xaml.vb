﻿Imports System.Globalization
Imports System.Windows.Ink

Public Class EraserSettingMenu
    Inherits UserControl
    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub
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
End Class
