Imports System.Net
Imports System.IO
Imports IWshRuntimeLibrary
Imports System.Environment
Imports System.Runtime.InteropServices

Public Class Form1
    Dim a As String
    Dim InstallRev As String
    Dim InstallTo As String




    '
   




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then
            MsgBox("Bạn chưa chọn đường dẫn !")
        Else
            a = FolderBrowserDialog1.SelectedPath
            urll.Text = FolderBrowserDialog1.SelectedPath
            Button1.Enabled = True
        End If
    End Sub
    Public Function FExists(OrigFile As String)
        Dim fs
        fs = CreateObject("Scripting.FileSystemObject")
        FExists = fs.fileexists(OrigFile)
    End Function
    'Returns a boolean - True if the file exists


    Public Function DirExists(OrigFile As String)
        Dim fs
        fs = CreateObject("Scripting.FileSystemObject")
        DirExists = fs.folderexists(OrigFile)
    End Function
    'Returns a boolean - True if the folder exists


    Public Function DExists(OrigFile As String)
        Dim fs, d
        fs = CreateObject("Scripting.FileSystemObject")
        If fs.driveexists(OrigFile) = True Then
            d = fs.getdrive(OrigFile)
            DExists = 1
            If d.isready = True Then
                DExists = 2
                Exit Function
            End If
        Else
            DExists = 0
        End If
    End Function


       Private Sub CreateShortCut(ByVal FileName As String, ByVal Title As String)
        Try
            Dim WshShell As New WshShell
            ' short cut files have a .lnk extension
            Dim shortCut As IWshRuntimeLibrary.IWshShortcut = DirectCast(WshShell.CreateShortcut(FileName), IWshRuntimeLibrary.IWshShortcut)

            ' set the shortcut properties
            With shortCut
                .TargetPath = urll.Text & "\Download Manager 360\Download Manager 360.exe"
                .WindowStyle = 1I
                .Description = "Download Manager 360"
                .WorkingDirectory = urll.Text
                ' the next line gets the first Icon from the executing program
                .IconLocation = Application.ExecutablePath & ", 0"
                .Arguments = String.Empty
                .Save() ' save the shortcut file
            End With
        Catch ex As System.Exception

        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InstallTo = urll.Text

    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Try

            Label1.Text = "Đang tạo khóa..."
            ' Timer1.Enabled = True
            '  UnZip(urll.Text & "\Download Manager 360\setup.zip", urll.Text & "\Download Manager 360")
            'If FExists(a & "\Download Manager 360\setup.zip") = True Then
            'Kill(a & "\Download Manager 360\setup.zip")
            '  Else

            ' End If
            'My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\Download Manager 360", urll.Text & "\Download Manager 360", True)
            Process.Start(a & "\Download Manager 360\Download Manager 360.exe")
            CreateShortCut(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Download Manager 360.lnk"), "Download Manager 360")
            ' InstallToSYSaRUN()
            End
        Catch
            MsgBox("Có lỗi xảy ra , tạo khóa thất bại!")
            Me.Close()
        End Try
    End Sub

    Sub InstallToSYSaRUN()

     
        Try

            My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "DisplayName", "Download Manager 360")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "DisplayIcon", InstallTo + "\Download Manager 360.exe,0")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "DisplayVersion", InstallRev)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "HelpLink", "mailto:trungnhan21.12@gmail.com")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "Publisher", "Download Manager 360 - Nguyễn Trung Nhẫn")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "UninstallString", InstallTo + "\Uninstall.exe")
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360", "URLInfoAbout", "http://download-manager-360.luutru360.com/")
            '  MsgBox("Cài đặt thành công!")
            'Shell(InstallTo & "\Download Manager 360.exe")
            'Me.Close()
        Catch ex As Exception

            Me.Close()
        End Try
    End Sub


    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        pro.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fd As String = DirExists(a & "\Download Manager 360")


            If fd = True Then

                MessageBox.Show("Thư mục Download Manager 360 đã tồn tại !")

            ElseIf fd = False Then
                Label1.Text = "Đang cài đặt ... Vui lòng đợi trong giây lác..."
                pro.Visible = True
                Button2.Enabled = False
                Button1.Enabled = False
                If Not Directory.Exists(a & "\Download Manager 360") Then
                    Directory.CreateDirectory(a & "\Download Manager 360")
                    '  Directory.CreateDirectory(Application.StartupPath & "\Download Manager 360")
                    Dim client As WebClient = New WebClient
                    Dim client2 As WebClient = New WebClient
                    Dim client3 As WebClient = New WebClient
                    Dim client4 As WebClient = New WebClient
                    AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
                    AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                    '  client.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/install/zip"), Application.StartupPath & "\Download Manager 360\setup.zip")
                    client.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/Download Manager 360.exe"), urll.Text & "\Download Manager 360\Download Manager 360.exe")
                    client2.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/Download Manager 360.pdb"), urll.Text & "\Download Manager 360\Download Manager 360.pdb")
                    client3.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/Download Manager 360.vshost.exe"), urll.Text & "\Download Manager 360\Download Manager 360.vshost.exe")
                    client4.DownloadFileAsync(New Uri("http://download-manager-360.luutru360.com/install/Download Manager 360.vshost.exe.manifest"), urll.Text & "\Download Manager 360\Download Manager 360.vshost.exe.manifest")
                End If
            End If
        Catch
            MsgBox("Có lỗi xảy ra , không thể cài đặt!")
            End
        End Try
    End Sub

    '   Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
    ' Sub UnZip(zipfile As String, outfolder As String)

    'Dim output As Object = shObj.NameSpace((outfolder))
    ' Dim input As Object = shObj.NameSpace((zipfile))
    '      output.CopyHere((input.Items), 4)
    '  End Sub
    Private Sub pro_Click(sender As Object, e As EventArgs) Handles pro.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Process.Start(a & "\Download Manager 360\Download Manager 360.exe")
        End
        Timer1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
