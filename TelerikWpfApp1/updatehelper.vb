Imports System.IO
Imports System.IO.Compression
Imports Ionic.Zip

Public Class updatehelper
    Public Shared f As FtpWeb
    Public Shared Sub updatemain()
        Try
            Dim t1 = New DirectoryInfo(System.Environment.CurrentDirectory)
            Dim downini = t1.Parent.FullName & "\tmp.ini"
            Dim localini = t1.Parent.FullName & "\version.ini"
            Dim rootpath = t1.Parent.FullName
            f = New FtpWeb("ftp://10.233.88.2", "user", "2003")
            f.Download("ftp://10.233.88.2/HandyDraw/ver.ini", downini)
            Dim newestver = GetKeyValue("main", "ver", "", downini)
            Dim curver = GetKeyValue("main", "ver", "", localini)
            If newestver = "" Or curver = "" Then
                Exit Sub
            End If
            If curver = newestver Then
                Return
            End If
            f.Download("ftp://10.233.88.2/HandyDraw/" & newestver & ".zip", rootpath & "\" & newestver & ".zip")
            UnPack(rootpath & "\" & newestver & ".zip", rootpath & "\" & newestver & "\")
            SetKeyValue("main", "ver", newestver, localini)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub UnPack(ByVal PackPath As String, ByVal FolerPath As String)
        Dim zip As New ZipFile
        zip = ZipFile.Read(PackPath)
        'zip.Password = Psd  '注意密码一定要放在读取后
        zip.ExtractAll(FolerPath, ExtractExistingFileAction.OverwriteSilently)
        zip.Dispose()
    End Sub
End Class
