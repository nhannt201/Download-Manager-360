' Author: Nguyen Trung Nhan
' Contact: trungnhan21.12@gmail.com
' Github: https://github.com/nhannt201/Download-Manager-360
Public Class download

    Private myCoolFile As String = Application.StartupPath & "\data\setting.dw360" '// your file.



    'THESE ARE JUST FOR GUI TO MAKE IT LOOK A LITTLE MORE NICE

    'CLOSE PROGRAM
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        txtURL.Text = ""
        Form1.Enabled = True
        Me.Hide()
    End Sub

    Private Sub cmdDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDownload.Click
        Try
            If txtURL.Text = "" Then
                MsgBox("Bạn chưa nhập đường dẫn tải về!")

            Else
                'VERIFY A DIRECTORY WAS PICKED AND THAT IT EXISTS
                If Not IO.Directory.Exists(txtDownloadTo.Text) Then
                    MessageBox.Show("Không phải là một thư mục hợp lệ để tải về, hãy chọn một thư mục hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Form1.Enabled = True
                taive.Show()
                Form1.Hide()
                Me.Hide()
            End If
        Catch
            MsgBox("Không thể mở trình tải vui lòng thử lại sau!")
        End Try
    End Sub


    'GET A FOLDER TO DOWNLOAD THE FILE TO
    Private Sub cmdGetFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetFolder.Click
        If dlgFolderBrowse.ShowDialog(Me) <> DialogResult.Cancel Then
            txtDownloadTo.Text = dlgFolderBrowse.SelectedPath
        End If
    End Sub

    Private Sub download_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Enabled = True
    End Sub



    Private Sub download_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If IO.File.Exists(myCoolFile) Then '// check if file exists.
                Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile) '// load your file as a string array.
                For Each line As String In myCoolFileLines '// loop thru array list.
                    txtDownloadTo.Text = line

                Next
            End If

        Catch
            MsgBox("Có lỗi xảy ra!")
        End Try
    End Sub


End Class