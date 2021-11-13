Imports System.Net

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("Download Manager 360") 'start kill
            For Each p As Process In pProcess
                p.Kill()
            Next ' end kill
        Catch

        End Try
    End Sub
    Public Function FExists(OrigFile As String)
        Dim fs
        fs = CreateObject("Scripting.FileSystemObject")
        FExists = fs.fileexists(OrigFile)
    End Function
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        pro.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Try
            Process.Start(Application.StartupPath & "\Download Manager 360.exe")
            Dim FILE_NAME As String = Application.StartupPath & "\del.bat"

            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

                objWriter.Write(TextBox1.Text)
                objWriter.Close()
                Process.Start(Application.StartupPath & "\del.bat")
                End

            Else

                End

            End If
            End
        Catch
            MsgBox("Có lỗi xảy ra , tạo khóa thất bại!")
            Me.Close()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ' If FExists(Application.StartupPath & "\1.1.zip") = False Then
            Dim client As WebClient = New WebClient
            Dim client2 As WebClient = New WebClient
            Dim client3 As WebClient = New WebClient
            Dim client4 As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            '  client.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/install/zip"), Application.StartupPath & "\Download Manager 360\setup.zip")
            client.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/update/Download Manager 360.exe"), Application.StartupPath & "\Download Manager 360.exe")
            client2.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/update/Download Manager 360.pdb"), Application.StartupPath & "\Download Manager 360.pdb")
            client3.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/update/Download Manager 360.vshost.exe"), Application.StartupPath & "\Download Manager 360.vshost.exe")
            client4.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/update/Download Manager 360.vshost.exe.manifest"), Application.StartupPath & "\Download Manager 360.vshost.exe.manifest")
            ' Else
            '  Kill(Application.StartupPath & "\1.1.zip")
            '  Process.Start(Application.StartupPath & "\Download Manager 360.exe")
            '  End
            '   End If
        Catch
            Timer1.Enabled = False
            MsgBox("Nâng cấp thất bại ! Vui lòng thử lại sau!")
            End
        End Try
        Timer1.Enabled = False
        'Download Manager 360.exe
    End Sub
    ' Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))

    ' Sub UnZip(zipfile As String, outfolder As String)
    '     Dim output As Object = shObj.NameSpace((outfolder))
    'Dim input As Object = shObj.NameSpace((zipfile))
    '  output.CopyHere((input.Items), 4)
    ' End Sub
End Class
