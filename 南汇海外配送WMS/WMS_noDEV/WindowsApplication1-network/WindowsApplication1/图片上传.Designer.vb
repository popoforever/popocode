<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 图片上传
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.dgpic = New System.Windows.Forms.DataGridView()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ljms = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ljh = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgtemp2 = New System.Windows.Forms.DataGridView()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgpart
        '
        Me.dgpart.AllowUserToAddRows = False
        Me.dgpart.AllowUserToDeleteRows = False
        Me.dgpart.AllowUserToResizeRows = False
        Me.dgpart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpart.BackgroundColor = System.Drawing.Color.White
        Me.dgpart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpart.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgpart.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgpart.Location = New System.Drawing.Point(0, 0)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(283, 648)
        Me.dgpart.TabIndex = 2
        '
        'dgpic
        '
        Me.dgpic.AllowUserToAddRows = False
        Me.dgpic.AllowUserToDeleteRows = False
        Me.dgpic.AllowUserToResizeRows = False
        Me.dgpic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpic.BackgroundColor = System.Drawing.Color.White
        Me.dgpic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpic.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgpic.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgpic.Location = New System.Drawing.Point(283, 0)
        Me.dgpic.Name = "dgpic"
        Me.dgpic.ReadOnly = True
        Me.dgpic.RowHeadersVisible = False
        Me.dgpic.RowTemplate.Height = 24
        Me.dgpic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpic.Size = New System.Drawing.Size(382, 648)
        Me.dgpic.TabIndex = 3
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(749, 248)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(480, 360)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 4
        Me.pb1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(19, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "选择图片"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.cb1)
        Me.gb1.Controls.Add(Me.Button2)
        Me.gb1.Controls.Add(Me.Button1)
        Me.gb1.Controls.Add(Me.ljms)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.ljh)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.gb1.Location = New System.Drawing.Point(665, 0)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(659, 171)
        Me.gb1.TabIndex = 7
        Me.gb1.TabStop = False
        Me.gb1.Text = "New picture"
        '
        'cb1
        '
        Me.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(388, 27)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(121, 24)
        Me.cb1.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(197, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "上传图片"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ljms
        '
        Me.ljms.AutoSize = True
        Me.ljms.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ljms.Location = New System.Drawing.Point(143, 75)
        Me.ljms.Name = "ljms"
        Me.ljms.Size = New System.Drawing.Size(69, 20)
        Me.ljms.TabIndex = 6
        Me.ljms.Text = "零件描述"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "零件描述："
        '
        'ljh
        '
        Me.ljh.AutoSize = True
        Me.ljh.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ljh.Location = New System.Drawing.Point(143, 31)
        Me.ljh.Name = "ljh"
        Me.ljh.Size = New System.Drawing.Size(99, 20)
        Me.ljh.TabIndex = 6
        Me.ljh.Text = "请选择零件号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "零件号："
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(1004, 187)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(188, 92)
        Me.dgtemp.TabIndex = 8
        Me.dgtemp.Visible = False
        '
        'dgtemp2
        '
        Me.dgtemp2.AllowUserToAddRows = False
        Me.dgtemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp2.Location = New System.Drawing.Point(763, 187)
        Me.dgtemp2.Name = "dgtemp2"
        Me.dgtemp2.RowTemplate.Height = 24
        Me.dgtemp2.Size = New System.Drawing.Size(188, 92)
        Me.dgtemp2.TabIndex = 8
        Me.dgtemp2.Visible = False
        '
        '图片上传
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgtemp2)
        Me.Controls.Add(Me.dgtemp)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.dgpic)
        Me.Controls.Add(Me.dgpart)
        Me.Name = "图片上传"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents dgpic As System.Windows.Forms.DataGridView
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ljms As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ljh As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp2 As System.Windows.Forms.DataGridView

End Class
