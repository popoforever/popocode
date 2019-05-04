<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dguser = New System.Windows.Forms.DataGridView()
        Me.dgright = New System.Windows.Forms.DataGridView()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.ttel = New System.Windows.Forms.TextBox()
        Me.tuid = New System.Windows.Forms.TextBox()
        Me.lusername = New System.Windows.Forms.Label()
        Me.ltel = New System.Windows.Forms.Label()
        Me.lemail = New System.Windows.Forms.Label()
        Me.luid = New System.Windows.Forms.Label()
        Me.breset = New System.Windows.Forms.Button()
        Me.badd = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.ltemp = New System.Windows.Forms.Label()
        Me.dgtempright = New System.Windows.Forms.DataGridView()
        Me.gbdata = New System.Windows.Forms.GroupBox()
        Me.gbright = New System.Windows.Forms.GroupBox()
        Me.bright = New System.Windows.Forms.Button()
        Me.pbutton = New System.Windows.Forms.Panel()
        Me.pright = New System.Windows.Forms.Panel()
        Me.cbcustum = New System.Windows.Forms.ComboBox()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtempright, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdata.SuspendLayout()
        Me.gbright.SuspendLayout()
        Me.pbutton.SuspendLayout()
        Me.pright.SuspendLayout()
        Me.SuspendLayout()
        '
        'dguser
        '
        Me.dguser.AllowUserToAddRows = False
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.AllowUserToResizeRows = False
        Me.dguser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dguser.BackgroundColor = System.Drawing.Color.White
        Me.dguser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dguser.DefaultCellStyle = DataGridViewCellStyle1
        Me.dguser.Location = New System.Drawing.Point(37, 26)
        Me.dguser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.RowHeadersVisible = False
        Me.dguser.RowTemplate.Height = 24
        Me.dguser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dguser.Size = New System.Drawing.Size(820, 472)
        Me.dguser.TabIndex = 8
        '
        'dgright
        '
        Me.dgright.AllowUserToAddRows = False
        Me.dgright.AllowUserToDeleteRows = False
        Me.dgright.AllowUserToResizeColumns = False
        Me.dgright.AllowUserToResizeRows = False
        Me.dgright.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgright.BackgroundColor = System.Drawing.Color.White
        Me.dgright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgright.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgright.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgright.Location = New System.Drawing.Point(6, 19)
        Me.dgright.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgright.Name = "dgright"
        Me.dgright.RowHeadersVisible = False
        Me.dgright.RowTemplate.Height = 24
        Me.dgright.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgright.Size = New System.Drawing.Size(538, 256)
        Me.dgright.TabIndex = 8
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.cbcustum)
        Me.gbop.Controls.Add(Me.temail)
        Me.gbop.Controls.Add(Me.ttel)
        Me.gbop.Controls.Add(Me.tuid)
        Me.gbop.Controls.Add(Me.lusername)
        Me.gbop.Controls.Add(Me.ltel)
        Me.gbop.Controls.Add(Me.lemail)
        Me.gbop.Controls.Add(Me.luid)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Name = "gbop"
        Me.gbop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Size = New System.Drawing.Size(1490, 99)
        Me.gbop.TabIndex = 14
        Me.gbop.TabStop = False
        Me.gbop.Text = "新用户申请"
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(389, 49)
        Me.temail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(181, 27)
        Me.temail.TabIndex = 9
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(930, 47)
        Me.ttel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(181, 27)
        Me.ttel.TabIndex = 7
        '
        'tuid
        '
        Me.tuid.Location = New System.Drawing.Point(108, 49)
        Me.tuid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tuid.Name = "tuid"
        Me.tuid.Size = New System.Drawing.Size(181, 27)
        Me.tuid.TabIndex = 6
        '
        'lusername
        '
        Me.lusername.AutoSize = True
        Me.lusername.Location = New System.Drawing.Point(602, 51)
        Me.lusername.Name = "lusername"
        Me.lusername.Size = New System.Drawing.Size(39, 20)
        Me.lusername.TabIndex = 2
        Me.lusername.Text = "工厂"
        '
        'ltel
        '
        Me.ltel.AutoSize = True
        Me.ltel.Location = New System.Drawing.Point(885, 50)
        Me.ltel.Name = "ltel"
        Me.ltel.Size = New System.Drawing.Size(39, 20)
        Me.ltel.TabIndex = 2
        Me.ltel.Text = "电话"
        '
        'lemail
        '
        Me.lemail.AutoSize = True
        Me.lemail.Location = New System.Drawing.Point(342, 52)
        Me.lemail.Name = "lemail"
        Me.lemail.Size = New System.Drawing.Size(39, 20)
        Me.lemail.TabIndex = 2
        Me.lemail.Text = "邮箱"
        '
        'luid
        '
        Me.luid.AutoSize = True
        Me.luid.Location = New System.Drawing.Point(60, 51)
        Me.luid.Name = "luid"
        Me.luid.Size = New System.Drawing.Size(39, 20)
        Me.luid.TabIndex = 2
        Me.luid.Text = "账号"
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(116, 6)
        Me.breset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(81, 35)
        Me.breset.TabIndex = 22
        Me.breset.Text = "重置"
        Me.breset.UseVisualStyleBackColor = False
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(12, 6)
        Me.badd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(81, 35)
        Me.badd.TabIndex = 23
        Me.badd.Text = "新增"
        Me.badd.UseVisualStyleBackColor = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp.BackgroundColor = System.Drawing.Color.White
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(569, 266)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.ReadOnly = True
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(220, 98)
        Me.dgtemp.TabIndex = 15
        Me.dgtemp.Visible = False
        '
        'ltemp
        '
        Me.ltemp.AutoSize = True
        Me.ltemp.Location = New System.Drawing.Point(759, 276)
        Me.ltemp.Name = "ltemp"
        Me.ltemp.Size = New System.Drawing.Size(57, 20)
        Me.ltemp.TabIndex = 17
        Me.ltemp.Text = "Label3"
        Me.ltemp.Visible = False
        '
        'dgtempright
        '
        Me.dgtempright.AllowUserToAddRows = False
        Me.dgtempright.AllowUserToDeleteRows = False
        Me.dgtempright.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtempright.BackgroundColor = System.Drawing.Color.White
        Me.dgtempright.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtempright.Location = New System.Drawing.Point(100, 318)
        Me.dgtempright.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgtempright.Name = "dgtempright"
        Me.dgtempright.ReadOnly = True
        Me.dgtempright.RowHeadersVisible = False
        Me.dgtempright.RowTemplate.Height = 24
        Me.dgtempright.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtempright.Size = New System.Drawing.Size(309, 154)
        Me.dgtempright.TabIndex = 15
        Me.dgtempright.Visible = False
        '
        'gbdata
        '
        Me.gbdata.Controls.Add(Me.dgtemp)
        Me.gbdata.Controls.Add(Me.dguser)
        Me.gbdata.Location = New System.Drawing.Point(3, 208)
        Me.gbdata.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdata.Name = "gbdata"
        Me.gbdata.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdata.Size = New System.Drawing.Size(886, 555)
        Me.gbdata.TabIndex = 18
        Me.gbdata.TabStop = False
        Me.gbdata.Text = "用户信息"
        '
        'gbright
        '
        Me.gbright.Controls.Add(Me.dgright)
        Me.gbright.Location = New System.Drawing.Point(20, 20)
        Me.gbright.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbright.Name = "gbright"
        Me.gbright.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbright.Size = New System.Drawing.Size(550, 283)
        Me.gbright.TabIndex = 19
        Me.gbright.TabStop = False
        Me.gbright.Text = "权限"
        '
        'bright
        '
        Me.bright.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bright.FlatAppearance.BorderSize = 0
        Me.bright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bright.Location = New System.Drawing.Point(20, 305)
        Me.bright.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bright.Name = "bright"
        Me.bright.Size = New System.Drawing.Size(66, 25)
        Me.bright.TabIndex = 22
        Me.bright.Text = "确认"
        Me.bright.UseVisualStyleBackColor = False
        '
        'pbutton
        '
        Me.pbutton.Controls.Add(Me.badd)
        Me.pbutton.Controls.Add(Me.breset)
        Me.pbutton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbutton.Location = New System.Drawing.Point(0, 99)
        Me.pbutton.Name = "pbutton"
        Me.pbutton.Size = New System.Drawing.Size(1490, 55)
        Me.pbutton.TabIndex = 24
        '
        'pright
        '
        Me.pright.Controls.Add(Me.bright)
        Me.pright.Controls.Add(Me.gbright)
        Me.pright.Location = New System.Drawing.Point(911, 219)
        Me.pright.Name = "pright"
        Me.pright.Size = New System.Drawing.Size(590, 340)
        Me.pright.TabIndex = 25
        Me.pright.Visible = False
        '
        'cbcustum
        '
        Me.cbcustum.FormattingEnabled = True
        Me.cbcustum.Location = New System.Drawing.Point(659, 47)
        Me.cbcustum.Name = "cbcustum"
        Me.cbcustum.Size = New System.Drawing.Size(201, 28)
        Me.cbcustum.TabIndex = 10
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pright)
        Me.Controls.Add(Me.pbutton)
        Me.Controls.Add(Me.gbdata)
        Me.Controls.Add(Me.ltemp)
        Me.Controls.Add(Me.dgtempright)
        Me.Controls.Add(Me.gbop)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "user"
        Me.Size = New System.Drawing.Size(1490, 810)
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgright, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtempright, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdata.ResumeLayout(False)
        Me.gbright.ResumeLayout(False)
        Me.pbutton.ResumeLayout(False)
        Me.pright.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dguser As System.Windows.Forms.DataGridView
    Friend WithEvents dgright As System.Windows.Forms.DataGridView
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents ltemp As System.Windows.Forms.Label
    Friend WithEvents luid As System.Windows.Forms.Label
    Friend WithEvents lusername As System.Windows.Forms.Label
    Friend WithEvents ltel As System.Windows.Forms.Label
    Friend WithEvents lemail As System.Windows.Forms.Label
    Friend WithEvents temail As System.Windows.Forms.TextBox
    Friend WithEvents ttel As System.Windows.Forms.TextBox
    Friend WithEvents tuid As System.Windows.Forms.TextBox
    Friend WithEvents dgtempright As System.Windows.Forms.DataGridView
    Friend WithEvents gbdata As System.Windows.Forms.GroupBox
    Friend WithEvents gbright As System.Windows.Forms.GroupBox
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents bright As System.Windows.Forms.Button
    Friend WithEvents pbutton As System.Windows.Forms.Panel
    Friend WithEvents pright As System.Windows.Forms.Panel
    Friend WithEvents cbcustum As System.Windows.Forms.ComboBox

End Class
