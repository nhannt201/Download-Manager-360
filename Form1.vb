Imports System.IO

Public Class Form1

    Private myCoolFile As String = Application.StartupPath & "\data\listfile.dw360" '// your file.
    Private myCoolFile2 As String = Application.StartupPath & "\data\setting.dw360" '// your file.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim myWriter As New IO.StreamWriter(myCoolFile)
        For Each myItem As ListViewItem In listfile.Items
            myWriter.WriteLine(myItem.Text & "#" & myItem.SubItems(1).Text & "#" & myItem.SubItems(2).Text & "#" & myItem.SubItems(3).Text) '// write Item and SubItem.
        Next
        myWriter.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fd As String = DirExists(Application.StartupPath & "\data\")
            If fd = True Then
                If IO.File.Exists(myCoolFile) Then '// check if file exists.
                    Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile) '// load your file as a string array.
                    For Each line As String In myCoolFileLines '// loop thru array list.
                        Dim lineArray() As String = line.Split("#") '// separate by "#" character.
                        Dim newItem As New ListViewItem(lineArray(0)) '// add text Item.
                        newItem.SubItems.Add(lineArray(1)) '// add SubItem.
                        newItem.SubItems.Add(lineArray(2))
                        newItem.SubItems.Add(lineArray(3))

                        listfile.Items.Add(newItem) '// add Item to ListView.
                    Next
                End If
            ElseIf fd = False Then
                If Not Directory.Exists(Application.StartupPath & "\data\") Then
                    Directory.CreateDirectory(Application.StartupPath & "\data\")
                End If
            End If
        Catch
            MsgBox("Có lỗi xảy ra khi mở danh sách tập tin!")
          
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If IO.File.Exists(myCoolFile2) Then '// check if file exists.
                Dim myCoolFileLines() As String = IO.File.ReadAllLines(myCoolFile2) '// load your file as a string array.
                For Each line As String In myCoolFileLines '// loop thru array list.
                    download.txtDownloadTo.Text = line

                Next
            End If
            download.Show()
            Me.Enabled = False
        Catch
            MsgBox("Không thể mở tải về!")
        End Try
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
    'Code to check the state of a drive (returns 0 if the drive does not exist, 1 if the drive exists but contains no media, 2 if the drive exists and contains media.  Hard-drives will always return 2)


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            For Each item As ListViewItem In listfile.SelectedItems
                item.Remove()
            Next
            MsgBox("Thẻ đã được loại bỏ!")
        Catch
            MsgBox("Vui lòng chọn đường dẫn để xóa thẻ !")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        setting.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Download Manager 360" & vbNewLine & "Phiên bản : " & setting.cu.Text & vbNewLine & "Tác giả : Nguyễn Trung Nhẫn" & vbNewLine & "Website: http://luutru360.com")
    End Sub

  

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        taive.Show()
        Button5.Enabled = False
        Me.Hide()
    End Sub
End Class
