<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listfile = New System.Windows.Forms.ListView()
        Me.linkdw = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.kbb = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 84)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.PeachPuff
        Me.Button4.Location = New System.Drawing.Point(888, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Thông tin "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Goldenrod
        Me.Button3.Location = New System.Drawing.Point(778, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Xóa thẻ "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.GreenYellow
        Me.Button2.Location = New System.Drawing.Point(147, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Thiết lập Và  Cập nhật"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(26, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Thêm tâp tin tải về"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'listfile
        '
        Me.listfile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.linkdw, Me.sv, Me.dy, Me.kbb, Me.tt})
        Me.listfile.FullRowSelect = True
        Me.listfile.Location = New System.Drawing.Point(0, 90)
        Me.listfile.Name = "listfile"
        Me.listfile.Size = New System.Drawing.Size(1019, 347)
        Me.listfile.TabIndex = 1
        Me.listfile.UseCompatibleStateImageBehavior = False
        Me.listfile.View = System.Windows.Forms.View.Details
        '
        'linkdw
        '
        Me.linkdw.Text = "Đường dẫn tải về"
        Me.linkdw.Width = 274
        '
        'sv
        '
        Me.sv.Text = "Nơi lưu tập tin"
        Me.sv.Width = 265
        '
        'dy
        '
        Me.dy.Text = "Thời gian"
        Me.dy.Width = 182
        '
        'kbb
        '
        Me.kbb.Text = "Dung lượng tập tin"
        Me.kbb.Width = 160
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(677, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 35)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "&Hiện thẻ tải về"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'tt
        '
        Me.tt.Text = "Tiến trình"
        Me.tt.Width = 129
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 440)
        Me.Controls.Add(Me.listfile)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Manager 360 - Luutru360.com"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents listfile As System.Windows.Forms.ListView
    Friend WithEvents linkdw As System.Windows.Forms.ColumnHeader
    Friend WithEvents sv As System.Windows.Forms.ColumnHeader
    Friend WithEvents dy As System.Windows.Forms.ColumnHeader
    Friend WithEvents kbb As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tt As System.Windows.Forms.ColumnHeader

End Class
