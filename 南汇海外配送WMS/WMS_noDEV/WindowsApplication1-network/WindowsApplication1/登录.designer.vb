<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 登录
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(登录))
        Me.uid = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.luser = New System.Windows.Forms.Label()
        Me.lpwd = New System.Windows.Forms.Label()
        Me.blogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.lname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbcn = New System.Windows.Forms.PictureBox()
        Me.pben = New System.Windows.Forms.PictureBox()
        Me.llan = New System.Windows.Forms.Label()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uid
        '
        Me.uid.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.uid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uid.Location = New System.Drawing.Point(120, 117)
        Me.uid.Name = "uid"
        Me.uid.Size = New System.Drawing.Size(167, 28)
        Me.uid.TabIndex = 0
        '
        'pwd
        '
        Me.pwd.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwd.Location = New System.Drawing.Point(120, 170)
        Me.pwd.Name = "pwd"
        Me.pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd.Size = New System.Drawing.Size(167, 28)
        Me.pwd.TabIndex = 1
        '
        'luser
        '
        Me.luser.AutoSize = True
        Me.luser.BackColor = System.Drawing.Color.Transparent
        Me.luser.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.luser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.luser.Location = New System.Drawing.Point(33, 117)
        Me.luser.Name = "luser"
        Me.luser.Size = New System.Drawing.Size(51, 20)
        Me.luser.TabIndex = 2
        Me.luser.Text = "用户名"
        '
        'lpwd
        '
        Me.lpwd.AutoSize = True
        Me.lpwd.BackColor = System.Drawing.Color.Transparent
        Me.lpwd.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lpwd.Location = New System.Drawing.Point(33, 170)
        Me.lpwd.Name = "lpwd"
        Me.lpwd.Size = New System.Drawing.Size(37, 20)
        Me.lpwd.TabIndex = 2
        Me.lpwd.Text = "密码"
        '
        'blogin
        '
        Me.blogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.blogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.blogin.FlatAppearance.BorderSize = 0
        Me.blogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blogin.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blogin.ForeColor = System.Drawing.Color.White
        Me.blogin.Location = New System.Drawing.Point(55, 230)
        Me.blogin.Name = "blogin"
        Me.blogin.Size = New System.Drawing.Size(221, 40)
        Me.blogin.TabIndex = 3
        Me.blogin.Text = "登陆"
        Me.blogin.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(974, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(760, 382)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(223, 90)
        Me.dgtemp.TabIndex = 4
        Me.dgtemp.Visible = False
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.BackColor = System.Drawing.Color.Transparent
        Me.lname.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lname.Location = New System.Drawing.Point(77, 42)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(199, 36)
        Me.lname.TabIndex = 5
        Me.lname.Text = "WMS管理平台"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.uid)
        Me.Panel1.Controls.Add(Me.pwd)
        Me.Panel1.Controls.Add(Me.lname)
        Me.Panel1.Controls.Add(Me.blogin)
        Me.Panel1.Controls.Add(Me.lpwd)
        Me.Panel1.Controls.Add(Me.luser)
        Me.Panel1.Location = New System.Drawing.Point(611, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 309)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.loginbottom
        Me.PictureBox3.Location = New System.Drawing.Point(1, 408)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1025, 195)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.loginimage
        Me.PictureBox2.Location = New System.Drawing.Point(115, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(356, 305)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'pbcn
        '
        Me.pbcn.BackColor = System.Drawing.Color.Transparent
        Me.pbcn.Image = CType(resources.GetObject("pbcn.Image"), System.Drawing.Image)
        Me.pbcn.Location = New System.Drawing.Point(816, 408)
        Me.pbcn.Name = "pbcn"
        Me.pbcn.Size = New System.Drawing.Size(59, 54)
        Me.pbcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbcn.TabIndex = 6
        Me.pbcn.TabStop = False
        '
        'pben
        '
        Me.pben.BackColor = System.Drawing.Color.Transparent
        Me.pben.Image = CType(resources.GetObject("pben.Image"), System.Drawing.Image)
        Me.pben.Location = New System.Drawing.Point(881, 408)
        Me.pben.Name = "pben"
        Me.pben.Size = New System.Drawing.Size(59, 54)
        Me.pben.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pben.TabIndex = 6
        Me.pben.TabStop = False
        '
        'llan
        '
        Me.llan.AutoSize = True
        Me.llan.ForeColor = System.Drawing.Color.White
        Me.llan.Location = New System.Drawing.Point(608, 97)
        Me.llan.Name = "llan"
        Me.llan.Size = New System.Drawing.Size(36, 17)
        Me.llan.TabIndex = 10
        Me.llan.Text = "中文"
        '
        '登录
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.pben)
        Me.Controls.Add(Me.pbcn)
        Me.Controls.Add(Me.llan)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgtemp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "登录"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "测试版"
        Me.TopMost = True
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uid As System.Windows.Forms.TextBox
    Friend WithEvents pwd As System.Windows.Forms.TextBox
    Friend WithEvents luser As System.Windows.Forms.Label
    Friend WithEvents lpwd As System.Windows.Forms.Label
    Friend WithEvents blogin As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents lname As System.Windows.Forms.Label
    Friend WithEvents pbcn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pben As System.Windows.Forms.PictureBox
    Friend WithEvents llan As System.Windows.Forms.Label
End Class
