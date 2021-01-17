Imports MediaFoundation
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports Telerik.Windows.Controls
Imports Telerik.Windows.MediaFoundation

Partial Public Class CamSettingMenu
    Inherits UserControl

    Private Shared ReadOnly SupportedVideoInputTypes As List(Of Guid) = New List(Of Guid)() From {
            MFMediaType.I420,
            MFMediaType.IYUV,
            MFMediaType.NV12,
            MFMediaType.YUY2,
            MFMediaType.YV12
        }

    Public Property Camera As RadWebCam
        Get
            Return CType(GetValue(CameraProperty), RadWebCam)
        End Get
        Set(ByVal value As RadWebCam)
            SetValue(CameraProperty, value)
        End Set
    End Property

    Public Shared ReadOnly CameraProperty As DependencyProperty = DependencyProperty.Register("Camera", GetType(RadWebCam), GetType(CamSettingMenu), New PropertyMetadata(Nothing, AddressOf OnCameraChanged))

    Public Delegate Sub TestHandler(sender As Object, e As EventArgs)
    Public Event RestartCameraEvent As TestHandler

    Private Shared Sub OnCameraChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
        Dim self = CType(d, CamSettingMenu)

        If e.OldValue IsNot Nothing Then
            Dim oldCamera = CType(e.NewValue, RadWebCam)
            RemoveHandler oldCamera.CameraError, AddressOf self.OnCameraError
        End If

        If e.NewValue IsNot Nothing Then
            self.InitializeSettings()
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub InitializeSettings()
        Dim cameraDevices = RadWebCam.GetVideoCaptureDevices()
        cameraDevicesComboBox.ItemsSource = cameraDevices

        If cameraDevices.Count > 0 Then
            Dim defaultCamera = cameraDevices(0)
            Me.cameraDevicesComboBox.SelectedIndex = 0
            'Me.UpdateVideoFormats(defaultCamera)
        End If

        RemoveHandler Me.Camera.CameraError, AddressOf Me.OnCameraError
        'Dim args As EventArgs = New EventArgs()
        'RaiseEvent RestartCameraEvent(Me, args)
    End Sub

    Private Sub OnCameraError(ByVal sender As Object, ByVal e As CameraErrorEventArgs)
        Me.IsEnabled = False
    End Sub

    Private Sub OnStartCameraClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.stopCameraButton.IsEnabled = True
        Me.startCameraButton.IsEnabled = False
        Me.Camera.Start()
    End Sub

    Private Sub OnStopCameraClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Me.stopCameraButton.IsEnabled = False
        Me.startCameraButton.IsEnabled = True
        Me.Camera.[Stop]()
    End Sub

    Private Sub OnVideoFormatComboBoxSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        If Me.videoFormatsComboBox.SelectedItem IsNot Nothing Then
            Me.RestartCamera()
            Dim selectedFormat = CType(Me.videoFormatsComboBox.SelectedItem, MediaFoundationVideoFormatInfo)

            If Not SupportedVideoInputTypes.Contains(selectedFormat.SubType) Then
                Me.Camera.RecordingButtonVisibility = Visibility.Collapsed
            Else
                If Me.Camera.RecordingButtonVisibility = Visibility.Collapsed Then
                    Me.Camera.RecordingButtonVisibility = Visibility.Visible
                End If
            End If
        End If
    End Sub

    Private Sub OnCameraDevicesComboBoxSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        Dim selectedCamera = CType(Me.cameraDevicesComboBox.SelectedItem, MediaFoundationDeviceInfo)
        Me.UpdateVideoFormats(selectedCamera)
        'Me.RestartCamera()
    End Sub

    Friend Sub RestartCamera()
        Console.WriteLine("RestartCamera")
        Dim args As EventArgs = New EventArgs()

        Dim videoDevice = CType(Me.cameraDevicesComboBox.SelectedItem, MediaFoundationDeviceInfo)
        Dim videoFormat = CType(Me.videoFormatsComboBox.SelectedItem, MediaFoundationVideoFormatInfo)

        If videoDevice IsNot Nothing AndAlso videoFormat IsNot Nothing Then
            Me.Camera.Initialize(videoDevice, videoFormat)
            RaiseEvent RestartCameraEvent(Me, args)
            If Me.stopCameraButton.IsEnabled Then
                Me.Camera.Start()
            End If
        End If
    End Sub

    Private Sub UpdateVideoFormats(ByVal defaultCamera As MediaFoundationDeviceInfo)
        Try
            Dim videoFormats = RadWebCam.GetVideoFormats(defaultCamera).OrderByDescending(Function(x) x.FrameSizeHeight).ThenByDescending(Function(x) x.EffectiveFrameRate)
            Me.videoFormatsComboBox.ItemsSource = videoFormats
            Dim defaultFormat = videoFormats.FirstOrDefault(Function(f) SupportedVideoInputTypes.Contains(f.SubType))
            Me.videoFormatsComboBox.SelectedItem = defaultFormat
        Catch __unusedUnauthorizedAccessException1__ As UnauthorizedAccessException
            Me.IsEnabled = False
        End Try
    End Sub

    Private Async Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim w As New Window1
        w.MyCameraSettingsControl.WebCam = Camera
        w.ShowDialog()
    End Sub
End Class