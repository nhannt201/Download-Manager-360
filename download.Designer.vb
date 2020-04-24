<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class download
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(download))
        Me.cmdGetFolder = New System.Windows.Forms.Button()
        Me.txtDownloadTo = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.dlgFolderBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdGetFolder
        '
        Me.cmdGetFolder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdGetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetFolder.Location = New System.Drawing.Point(655, 64)
        Me.cmdGetFolder.Name = "cmdGetFolder"
        Me.cmdGetFolder.Size = New System.Drawing.Size(32, 20)
        Me.cmdGetFolder.TabIndex = 15
        Me.cmdGetFolder.Text = "..."
        Me.cmdGetFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDownloadTo
        '
        Me.txtDownloadTo.Enabled = False
        Me.txtDownloadTo.Location = New System.Drawing.Point(15, 64)
        Me.txtDownloadTo.Name = "txtDownloadTo"
        Me.txtDownloadTo.Size = New System.Drawing.Size(634, 20)
        Me.txtDownloadTo.TabIndex = 13
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdClose.Location = New System.Drawing.Point(615, 98)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 24)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Đóng"
        '
        'cmdDownload
        '
        Me.cmdDownload.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdDownload.Location = New System.Drawing.Point(537, 98)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(72, 24)
        Me.cmdDownload.TabIndex = 16
        Me.cmdDownload.Text = "&Tải về"
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(15, 90)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(672, 32)
        Me.ProgBar.TabIndex = 14
        Me.ProgBar.Visible = False
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(15, 25)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(672, 20)
        Me.txtURL.TabIndex = 12
        '
        'lblProgress
        '
        Me.lblProgress.Location = New System.Drawing.Point(12, 125)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(272, 16)
        Me.lblProgress.TabIndex = 18
        Me.lblProgress.Text = "#Progress"
        Me.lblProgress.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nhập đường dẫn tải về :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Đường dẫn mặc định hoặc tùy chọn khác :"
        '
        'download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 133)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGetFolder)
        Me.Controls.Add(Me.txtDownloadTo)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.lblProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "download"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager 360 "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGetFolder As System.Windows.Forms.Button
    Friend WithEvents txtDownloadTo As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents dlgFolderBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
