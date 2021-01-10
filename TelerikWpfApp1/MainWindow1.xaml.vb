Imports System.Threading.Tasks
Imports System.Timers
Imports System.Windows.Ink
Imports System.Windows.Media.Animation

Class MainWindow1

    Public pen As DrawingAttributes
    Public marker As DrawingAttributes
    Public eraser As DrawingAttributes
    Public settingwindow As UserControl
    Public Edit_Mode as Edit_Mode_Enum
    Public App_Mode As App_Mode_Enum

    Private Save_leftclicked As Boolean
    Private InitAniTimer As New Timer

    Private el As Ellipse
    Private r As New Random


    Public Sub New()
        pen = New DrawingAttributes With {
            .Color = Colors.White,
            .Height = 3,
            .Width = 3,
            .FitToCurve = True,
            .IsHighlighter = False,
            .StylusTip = StylusTip.Ellipse
        }
        marker = New DrawingAttributes With {
            .Color = Colors.Yellow,
            .Height = 25,
            .Width = 10,
            .FitToCurve = False,
            .IsHighlighter = True,
            .StylusTip = StylusTip.Rectangle
        }
        eraser = New DrawingAttributes With {
            .Color = Colors.White,
            .Height = 25,
            .Width = 25,
            .FitToCurve = False,
            .IsHighlighter = True,
            .StylusTip = StylusTip.Ellipse
        }

        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        save_queue = New List(Of save_task)


    End Sub

#Region "Init"
    Private Sub init()
        BackCanvas.Background = New SolidColorBrush(backcolors(r.Next(0, backcolors.Length)))
        InitPage.Visibility = Visibility.Visible
        InitAniTimer.Interval = 100
        AddHandler InitAniTimer.Elapsed, AddressOf InitAni
        InitAniTimer.Start()
    End Sub
    Private Sub InitAni(sender As Object, e As EventArgs)
        InitAniTimer.Stop()
        Me.Dispatcher.BeginInvoke(New Action(AddressOf addEllipse))
    End Sub

    Private Sub addEllipse()
        If InitPage.Visibility = Visibility.Collapsed Then Return
        Dim t = 1D
        Dim c As Color = backcolors(r.Next(0, backcolors.Length))
        el = New Ellipse With {.Fill = New SolidColorBrush(c), .Width = 1}
        el.SetBinding(HeightProperty, New Binding() With {.RelativeSource = New RelativeSource(RelativeSourceMode.Self), .Path = New PropertyPath("Width")})
        el.RenderTransform = New TransformGroup
        TryCast(el.RenderTransform, TransformGroup).Children.Add(New ScaleTransform(0, 0))
        TryCast(el.RenderTransform, TransformGroup).Children.Add(New TranslateTransform(r.NextDouble * InitPage.ActualWidth, r.NextDouble * InitPage.ActualHeight))
        el.RenderTransformOrigin = New Point(0.5, 0.5)
        BackCanvas.Children.Add(el)
        'Canvas.SetLeft(el, r.NextDouble * InitPage.ActualWidth)
        'Canvas.SetTop(el, r.NextDouble * InitPage.ActualHeight)

        Dim ani = CubicBezierDoubleAnimation(TimeSpan.FromSeconds(t), 0, 4000, ".67,.01,.85,.53")
        AddHandler ani.Completed, AddressOf aniCompleted
        FindScaleTransform(el.RenderTransform).BeginAnimation(ScaleTransform.ScaleXProperty, ani)
        FindScaleTransform(el.RenderTransform).BeginAnimation(ScaleTransform.ScaleYProperty, ani)
        InitAniTimer.Interval = t * 1000 + 1000
        InitAniTimer.Start()
    End Sub

    Private Sub removeEllipse()
        BackCanvas.Background = el.Fill
        BackCanvas.Children.Remove(el)
    End Sub

    Private Sub aniCompleted(sender As Object, e As EventArgs)
        Me.Dispatcher.BeginInvoke(New Action(AddressOf removeEllipse))
    End Sub
#End Region
#Region "listboxTools"
    Public Sub Set_Edit_Mode(e As Edit_Mode_Enum)
        Select Case e
            Case Edit_Mode_Enum.Cursor
                cv.InkCanvas1.EditingMode = InkCanvasEditingMode.None
                CursorRadioButton.IsChecked = True
            Case Edit_Mode_Enum.Pen
                cv.InkCanvas1.EditingMode = InkCanvasEditingMode.None
                cv.InkCanvas1.DefaultDrawingAttributes = pen
                PenRadioButton.IsChecked = True
            Case Edit_Mode_Enum.Selectt
                cv.InkCanvas1.EditingMode = InkCanvasEditingMode.Select
                SelectRadioButton.IsChecked = True
            Case Edit_Mode_Enum.Marker
                cv.InkCanvas1.EditingMode = InkCanvasEditingMode.Ink
                cv.InkCanvas1.DefaultDrawingAttributes = marker
                MarkerRadioButton.IsChecked = True
            Case Edit_Mode_Enum.Eraser
                If cv.InkCanvas1.EditingMode <> InkCanvasEditingMode.EraseByStroke And
                    cv.InkCanvas1.EditingMode <> InkCanvasEditingMode.EraseByPoint Then
                    cv.InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint
                End If
                EraserRadioButton.IsChecked = True
        End Select
        Edit_Mode = e
        cv.Edit_Mode = e
    End Sub
    Private Sub Cursor_Selected(sender As Object, e As RoutedEventArgs)
        Set_Edit_Mode(Edit_Mode_Enum.Cursor)
    End Sub

    Private Sub Pen_Selected(sender As Object, e As RoutedEventArgs)
        Set_Edit_Mode(Edit_Mode_Enum.Pen)
    End Sub

    Private Sub Select_Selected(sender As Object, e As RoutedEventArgs)
        Set_Edit_Mode(Edit_Mode_Enum.Selectt)
    End Sub

    Private Sub Marker_Selected(sender As Object, e As RoutedEventArgs)
        Set_Edit_Mode(Edit_Mode_Enum.Marker)
    End Sub

    Private Sub Eraser_Selected(sender As Object, e As RoutedEventArgs)
        Set_Edit_Mode(Edit_Mode_Enum.Eraser)
    End Sub

    Private Sub Save_MouseUp(sender As Object, e As MouseButtonEventArgs)
        If Not Save_leftclicked Then
            SaveSettingPopup.IsPopupOpen = True
        End If
    End Sub

    Private Sub Save_MouseDown(sender As Object, e As MouseButtonEventArgs)
        If e.RightButton = MouseButtonState.Pressed Then
            'SaveSettingPopup.IsPopupOpen = True
            Save_leftclicked = False
        Else
            Save_leftclicked = True
        End If
    End Sub

    Private Async Sub Save_checked(sender As Object, e As RoutedEventArgs)
        Console.WriteLine("Save_checked")
        If Save_leftclicked Then
            Await create_save_task()
            TryCast(sender, RadioButton).IsChecked = False
        Else
            SaveSettingPopup.IsPopupOpen = True
        End If
    End Sub

    Private Sub Setting_Selected(sender As Object, e As RoutedEventArgs)
        TryCast(sender, RadioButton).IsChecked = False
        SettingPopup.IsPopupOpen = True
        GlobalSetting.bv = cv
    End Sub

    Private Sub ListBoxItem_MouseUp(sender As Object, e As MouseEventArgs)
        'ListboxClickItem.IsSelected = True
    End Sub
    Private Sub ListBoxItem_PreviewMouseUp(sender As Object, e As MouseEventArgs)
        If TryCast(sender, RadioButton).IsChecked Then
            Select Case TryCast(sender, RadioButton).Tag
                Case "Pen"
                    'settingwindow = New PenSetting(pen)
                    PenSettingPopup.IsPopupOpen = True
                    PenSetting.initdrawer(pen)
                    PenSetting.popup = PenSettingPopup
                    Exit Sub
                Case "Marker"
                    MarkerSettingPopup.IsPopupOpen = True
                    MarkerSetting.initdrawer(marker)
                    MarkerSetting.popup = MarkerSettingPopup
                Case "Eraser"
                    EraserSettingPopup.IsPopupOpen = True
                    EraserSetting.initdrawerandcanvas(cv, eraser, Me)
                Case "Cursor"
                    Exit Sub
            End Select
        End If
    End Sub

#End Region
#Region "Save"
    Private Async Function create_save_task() As Task
        If CType(GetKeyValue("QuickSave", "enabled", "false", inipath), Boolean) Then
            Dim path = GetKeyValue("QuickSave", "LastSavePath", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inipath)
            Dim i = GetKeyValue("QuickSave", "Size_rb_Checked_index", 0, inipath)
            Dim a = GetKeyValue("QuickSave", "Save_content_rb_Checked_index", 2, inipath)
            Dim w0 = cv.Grid1.ActualWidth
            Dim h0 = cv.Grid1.ActualHeight
            Dim warr = {w0, Int(w0 * cv.scale), Int(w0 * cv.scale / 2), 3840, 2160 / h0 * w0, 1920, 1080 / h0 * w0}
            Dim harr = {h0, Int(h0 * cv.scale), Int(w0 * cv.scale / 2), 3840 / w0 * h0, 2160, 1920 / w0 * h0, 1080}
            save_queue.Add(New save_task() With {.a = a, .h = harr(i), .w = warr(i), .path = path})
            Save_snapshot(save_queue.Item(0))
            save_queue.RemoveAt(0)
        Else
            Dim res As String
            Dim s As SaveDialog = New SaveDialog
            s.init(cv.Grid1.ActualWidth, cv.Grid1.ActualHeight, cv.scale, False)
            res = Await MaterialDesignThemes.Wpf.DialogHost.Show(s, "MainDialogHost1")
            Console.WriteLine(res)
            If res = "OK" Then
                Save_snapshot(save_queue.Item(0))
                save_queue.RemoveAt(0)
            End If
        End If
    End Function

    Private Sub Save_snapshot(ByVal t As save_task)
        Dim a = t.a
        Dim w = t.w
        Dim h = t.h
        Dim path = t.path
        Dim fullpath = path & xiegang(path) & getsnapshotname()
        Try
            Select Case a
                Case 0
                    RenderVisual(cv.InkCanvas1, fullpath, w, h)
                Case 1
                    RenderVisual(cv.MyBackControl, fullpath, w, h)
                Case 2
                    RenderVisual(cv.Grid1, fullpath, w, h)
            End Select

            Dim sn As New SaveNoti1(True, fullpath, Nothing)
            NotiStackPanel.Children.Add(sn)

        Catch ex As Exception
            Dim sn As New SaveNoti1(False, Nothing, ex)
            NotiStackPanel.Children.Add(sn)
        End Try
    End Sub
#End Region
#Region "PageControl"
    Private Sub ButtonPre_Click(sender As Object, e As RoutedEventArgs)
        cv.PrevPage()
        TextPage.Text = cv.getlabel
        If cv.n = cv.s.Count - 1 Then
            PageControlNextIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Add
            PageControlNextText.Text = "加页"
        Else
            PageControlNextIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.KeyboardArrowRight
            PageControlNextText.Text = "下一页"
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As RoutedEventArgs)
        If cv.n = cv.s.Count - 1 Then
            cv.AddPage()
            PageControlNextIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Add
            PageControlNextText.Text = "加页"
        Else
            cv.NextPage()
            If cv.n = cv.s.Count - 1 Then
                PageControlNextIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Add
                PageControlNextText.Text = "加页"
            Else
                PageControlNextIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.KeyboardArrowRight
                PageControlNextText.Text = "下一页"
            End If
        End If
        TextPage.Text = cv.getlabel
    End Sub


    Private Sub BGButton_Click(sender As Object, e As RoutedEventArgs)
        cv.InkCanvas1.Background = CType(sender, Button).Background
        Dim ani = CubicBezierDoubleAnimation(TimeSpan.FromSeconds(0.5), 1, 0, ".82,.17,.85,.53")
        AddHandler ani.Completed, Sub()
                                      InitPage.Visibility = Visibility.Collapsed
                                  End Sub
        InitPage.BeginAnimation(Grid.OpacityProperty, ani)
        If CType(sender, Button) Is WhiteBG Then
            pen.Color = Colors.Black
        End If
    End Sub
#End Region
    Private Async Sub ButtonExit_Click(sender As Object, e As RoutedEventArgs)
        Dim res As String
        res = Await MaterialDesignThemes.Wpf.DialogHost.Show(New YesNoDialog(300, "确定退出？"), "MainDialogHost1")
        Console.WriteLine(res)
        If res = "OK" Then
            Application.Current.Shutdown()
        End If
    End Sub

    Private Sub ButtonMini_Click(sender As Object, e As RoutedEventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub
End Class
