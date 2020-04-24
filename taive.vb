' Author: Nguyen Trung Nhan
' Contact: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201/Download-Manager-360
Public Class taive
    Dim WithEvents AD As New WebFileDownloader
    Private myCoolFile As String = Application.StartupPath & "\data\listfile.dw360" '// your file.
    Dim sw As New Stopwatch
    Dim ptt As String
    Dim ptt2 As String

    Private Sub taive_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        dungtai()
        End
    End Sub

    Sub dungtai()
        If Not Me.AD Is Nothing Then
            Me.AD = Nothing

        End If
    End Sub

    Private Sub taive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        link.Text = download.txtURL.Text

        Show()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Form1.Show()
        Form1.Button5.Enabled = True
        Me.Hide()
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        dungtai()
        Form1.Show()
        Me.Hide()
    End Sub
    Private Function GetFileNameFromURL(ByVal URL As String) As String
        If URL.IndexOf("/"c) = -1 Then Return String.Empty

        Return "\" & URL.Substring(URL.LastIndexOf("/"c) + 1)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            sw.Start()
            link.Text = download.txtURL.Text

            AD.DownloadFileWithProgress(download.txtURL.Text, download.txtDownloadTo.Text.TrimEnd("\"c) & GetFileNameFromURL(download.txtURL.Text))
            Me.Text = AD.CurrentFile & " - Download Manager 360"
            Timer2.Enabled = True
            Timer3.Enabled = True
            Timer1.Enabled = False
        Catch
            MsgBox("Có lỗi sảy ra , không thể nhận được dữ liệu!")
        End Try
    End Sub

    Private Sub AD_AmountDownloadedChanged(iNewProgress As Long) Handles AD.AmountDownloadedChanged
        Try
            ProgBar.Value = Convert.ToInt32(iNewProgress)
            dungluong.Text = WebFileDownloader.FormatFileSize(ProgBar.Maximum)
            datai.Text = WebFileDownloader.FormatFileSize(iNewProgress)

            Application.DoEvents()
        Catch
            Timer2.Enabled = False
            Timer3.Enabled = False
            MsgBox("Dường như máy chủ không phản hồi , hoặc có lỗi sảy ra!")
        End Try
    End Sub
    Dim speed As Integer
    Dim length As Long
    Private Sub AD_FileDownloadComplete() Handles AD.FileDownloadComplete
        Try
            sw.Stop()
            ProgBar.Value = ProgBar.Maximum

            If trangthai.Text = "Đang tải bản cập nhật, vui lòng đợi..." Then
                Process.Start(download.txtDownloadTo.Text & "\" & AD.CurrentFile)
                End
            End If

            Timer2.Enabled = False
            Timer3.Enabled = False
            With Form1.listfile.Items.Add(download.txtURL.Text)
                .SubItems.Add(download.txtDownloadTo.Text & "\" & AD.CurrentFile)
                .SubItems.Add(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                .SubItems.Add(dungluong.Text)
                .SubItems.Add("Đã tải hoàn tất!")
            End With
            Form1.Show()
            Me.Hide()
        Catch
            MsgBox("Có lỗi sảy ra trong quá trình hoàn tất file! Bạn vui lòng tải lại hoặc xem lại tập tin!")
        End Try
    End Sub

    Private Sub AD_FileDownloadSizeObtained(iFileSize As Long) Handles AD.FileDownloadSizeObtained
        ProgBar.Value = 0
        ProgBar.Maximum = Convert.ToInt32(iFileSize)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim info As New IO.FileInfo(download.txtDownloadTo.Text & "\" & AD.CurrentFile)

            length = (info.Length) / 1024
            speed = length / sw.Elapsed.Seconds
            spp.Text = speed

        Catch
            spp.Text = "Không thể tính được!"
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            ptt2 = ProgBar.Value * 100 / ProgBar.Maximum
            ptt = Math.Round(Val(ptt2), 2)
            Me.Text = ptt & "% - " & AD.CurrentFile & " - Download Manager 360"
        Catch
            Me.Text = AD.CurrentFile & " - Download Manager 360"
        End Try
    End Sub
End Class