Imports System
Imports AForge.Video.DirectShow
Imports AForge.Controls
Imports System.Windows
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Namespace AForgeTest
    Class CameraHelper
        Private Shared _cameraDevices As FilterInfoCollection
        Private Shared div As VideoCaptureDevice = Nothing
        Private Shared _sourcePlayer As VideoSourcePlayer = New VideoSourcePlayer()
        Private Shared _isDisplay As Boolean = False
        Private Shared isSet As Boolean = False

        Public Shared Property CameraDevices As FilterInfoCollection
            Get
                Return _cameraDevices
            End Get
            Set(ByVal value As FilterInfoCollection)
                _cameraDevices = value
            End Set
        End Property

        Public Shared Property IsDisplay As Boolean
            Get
                Return _isDisplay
            End Get
            Set(ByVal value As Boolean)
                _isDisplay = value
            End Set
        End Property

        Public Shared Property SourcePlayer As VideoSourcePlayer
            Get
                Return _sourcePlayer
            End Get
            Set(ByVal value As VideoSourcePlayer)

                If _isDisplay Then
                    _sourcePlayer = value
                    isSet = True
                End If
            End Set
        End Property

        Shared Sub UpdateCameraDevices()
            _cameraDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        End Sub

        Shared Function SetCameraDevice(ByVal index As Integer) As Boolean
            If Not isSet Then _isDisplay = False
            If _cameraDevices.Count <= 0 OrElse index < 0 Then Return False
            If index > _cameraDevices.Count - 1 Then Return False
            div = New VideoCaptureDevice(_cameraDevices(index).MonikerString)
            SourcePlayer.VideoSource = div
            div.Start()
            SourcePlayer.Start()
            Return True
        End Function

        Sub CaptureImage(ByVal filePath As String, ByVal Optional fileName As String = Nothing)
            If sourcePlayer.VideoSource Is Nothing Then Return

            If Not Directory.Exists(filePath) Then
                Directory.CreateDirectory(filePath)
            End If

            Try
                Dim bitmap As Image = _sourcePlayer.GetCurrentVideoFrame()
                If fileName Is Nothing Then fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")
                bitmap.Save(filePath & "\" & fileName & "-cap.jpg", ImageFormat.Jpeg)
                bitmap.Dispose()
            Catch e As Exception
                MessageBox.Show(e.Message.ToString())
            End Try
        End Sub

        Sub CloseDevice()
            If div IsNot Nothing AndAlso div.IsRunning Then
                sourcePlayer.[Stop]()
                div.SignalToStop()
                div = Nothing
                _cameraDevices = Nothing
            End If
        End Sub
    End Class
End Namespace
