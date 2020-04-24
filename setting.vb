' Author: Nguyen Trung Nhan
' Contact: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201/Download-Manager-360
Public Class setting
    Private myCoolFile As String = Application.StartupPath & "\data\setting.dw360" '// your file.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            fbd.ShowDialog()
            pathmd.Text = fbd.SelectedPath
            Dim myWriter As New IO.StreamWriter(myCoolFile)

            myWriter.WriteLine(pathmd.Text) '// write Item and SubItem.

            myWriter.Close()
        Catch
            MsgBox("Có lỗi xảy ra trong quá trình thiết lập!")
            Me.Hide()
            Form1.Show()
        End Try
    End Sub


    Private Sub setting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Enabled = True
    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If IO.File.Exists(myCoolFile) Then '// check if file exists.
                Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile) '// load your file as a string array.
                For Each line As String In myCoolFileLines '// loop thru array list.
                    pathmd.Text = line

                Next
            End If
        Catch
            MsgBox("Có lỗi xảy ra trong quá trình thiết lập!")
            Me.Hide()
            Form1.Show()
        End Try
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim updata As String = New System.Net.WebClient().DownloadString("http://download-manager-360.luutru360.com/update/ver")
            news.Text = updata
            If cu.Text = news.Text Then
                MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất!")
            Else
                MessageBox.Show("Đã có phiên bản mới vui lòng cập nhật !")
                download.txtURL.Text = "http://download-manager-360.luutru360.com/update/" & news.Text & ".exe"
                taive.trangthai.Text = "Đang tải bản cập nhật, vui lòng đợi..."
                download.txtDownloadTo.Text = Application.StartupPath & "\"
                taive.Show()
                taive.Enabled = False
                Me.Hide()

            End If
        Catch
            MsgBox("Có lỗi xảy ra trong quá trình thiết lập!")
            Me.Hide()
            Form1.Show()
        End Try
    End Sub
End Class