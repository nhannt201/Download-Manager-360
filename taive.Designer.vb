<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taive
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(taive))
        Me.link = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trangthai = New System.Windows.Forms.Label()
        Me.dungluong = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.datai = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.spp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'link
        '
        Me.link.AutoSize = True
        Me.link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link.Location = New System.Drawing.Point(12, 9)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(32, 16)
        Me.link.TabIndex = 0
        Me.link.Text = "link"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Trạng thái :"
        '
        'trangthai
        '
        Me.trangthai.AutoSize = True
        Me.trangthai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trangthai.ForeColor = System.Drawing.Color.Blue
        Me.trangthai.Location = New System.Drawing.Point(126, 35)
        Me.trangthai.Name = "trangthai"
        Me.trangthai.Size = New System.Drawing.Size(150, 20)
        Me.trangthai.TabIndex = 2
        Me.trangthai.Text = "Đang nhận dữ liệu..."
        '
        'dungluong
        '
        Me.dungluong.AutoSize = True
        Me.dungluong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dungluong.ForeColor = System.Drawing.Color.Blue
        Me.dungluong.Location = New System.Drawing.Point(126, 72)
        Me.dungluong.Name = "dungluong"
        Me.dungluong.Size = New System.Drawing.Size(150, 20)
        Me.dungluong.TabIndex = 4
        Me.dungluong.Text = "Đang nhận dữ liệu..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dung lượng :"
        '
        'datai
        '
        Me.datai.AutoSize = True
        Me.datai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datai.ForeColor = System.Drawing.Color.Blue
        Me.datai.Location = New System.Drawing.Point(126, 109)
        Me.datai.Name = "datai"
        Me.datai.Size = New System.Drawing.Size(150, 20)
        Me.datai.TabIndex = 6
        Me.datai.Text = "Đang nhận dữ liệu..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Đã tải được :"
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(15, 141)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(843, 30)
        Me.ProgBar.TabIndex = 9
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdClose.Location = New System.Drawing.Point(783, 184)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 24)
        Me.cmdClose.TabIndex = 19
        Me.cmdClose.Text = "&Ẩn"
        '
        'cmdDownload
        '
        Me.cmdDownload.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdDownload.Location = New System.Drawing.Point(705, 184)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(72, 24)
        Me.cmdDownload.TabIndex = 18
        Me.cmdDownload.Text = "&Hủy tải về"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'spp
        '
        Me.spp.AutoSize = True
        Me.spp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spp.ForeColor = System.Drawing.Color.Blue
        Me.spp.Location = New System.Drawing.Point(398, 109)
        Me.spp.Name = "spp"
        Me.spp.Size = New System.Drawing.Size(150, 20)
        Me.spp.TabIndex = 21
        Me.spp.Text = "Đang nhận dữ liệu..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tốc độ :"
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'taive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 220)
        Me.Controls.Add(Me.spp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.datai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dungluong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trangthai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.link)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "taive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager 360"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents link As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trangthai As System.Windows.Forms.Label
    Friend WithEvents dungluong As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents datai As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents spp As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
