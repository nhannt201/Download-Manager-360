Imports Microsoft.Win32

Public Class Form1
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
    'Code to check the state of a drive (returns 0 if the drive does not exist, 1 if the drive exists but contains no media, 2 if the drive exists and contains media.  Hard-drives will always return 2)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360")

            Kill(Application.StartupPath & "\Download Manager 360.exe")

            Kill(Application.StartupPath & "\Download Manager 360.pdb")

            Kill(Application.StartupPath & "\Download Manager 360.vshost.exe")

            Kill(Application.StartupPath & "\Download Manager 360.vshost.exe.manifest")

            System.IO.Directory.Delete(Application.StartupPath & "\data", True)

        Catch
            My.Computer.Registry.CurrentUser.DeleteSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Download Manager 360")

            Kill(Application.StartupPath & "\Download Manager 360.exe")

            Kill(Application.StartupPath & "\Download Manager 360.pdb")

            Kill(Application.StartupPath & "\Download Manager 360.vshost.exe")

            Kill(Application.StartupPath & "\Download Manager 360.vshost.exe.manifest")

            System.IO.Directory.Delete(Application.StartupPath & "\data", True)
            Me.Close()
        End Try
        Timer1.Enabled = False
    End Sub
End Class
