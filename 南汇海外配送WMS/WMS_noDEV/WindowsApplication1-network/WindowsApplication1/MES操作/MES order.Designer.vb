<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MES_order
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pw1 = New System.Windows.Forms.TextBox()
        Me.dgkanban = New System.Windows.Forms.DataGridView()
        Me.kanbaninput = New System.Windows.Forms.TextBox()
        Me.num = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.typesel = New System.Windows.Forms.ComboBox()
        Me.dgprintback = New System.Windows.Forms.DataGridView()
        Me.dgprintfront = New System.Windows.Forms.DataGridView()
        Me.dgsel = New System.Windows.Forms.DataGridView()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgkanban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgprintback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgprintfront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgsel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Password"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "KANBAN CARD"
        '
        'pw1
        '
        Me.pw1.Location = New System.Drawing.Point(99, 176)
        Me.pw1.Margin = New System.Windows.Forms.Padding(4)
        Me.pw1.Name = "pw1"
        Me.pw1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw1.Size = New System.Drawing.Size(132, 22)
        Me.pw1.TabIndex = 25
        Me.pw1.Visible = False
        '
        'dgkanban
        '
        Me.dgkanban.AllowUserToAddRows = False
        Me.dgkanban.AllowUserToDeleteRows = False
        Me.dgkanban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkanban.Location = New System.Drawing.Point(466, 715)
        Me.dgkanban.Margin = New System.Windows.Forms.Padding(4)
        Me.dgkanban.Name = "dgkanban"
        Me.dgkanban.Size = New System.Drawing.Size(381, 185)
        Me.dgkanban.TabIndex = 24
        Me.dgkanban.Visible = False
        '
        'kanbaninput
        '
        Me.kanbaninput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kanbaninput.Location = New System.Drawing.Point(37, 110)
        Me.kanbaninput.Margin = New System.Windows.Forms.Padding(4)
        Me.kanbaninput.Name = "kanbaninput"
        Me.kanbaninput.Size = New System.Drawing.Size(368, 37)
        Me.kanbaninput.TabIndex = 23
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(455, 200)
        Me.num.Margin = New System.Windows.Forms.Padding(4)
        Me.num.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(78, 38)
        Me.num.TabIndex = 22
        Me.num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 42)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Production order"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(781, 581)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 38)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Print Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(781, 317)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 37)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Print Front"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(37, 594)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 50)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add to print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(430, 715)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.Size = New System.Drawing.Size(320, 185)
        Me.dgtemp.TabIndex = 17
        Me.dgtemp.Visible = False
        '
        'typesel
        '
        Me.typesel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typesel.FormattingEnabled = True
        Me.typesel.Location = New System.Drawing.Point(26, 206)
        Me.typesel.Margin = New System.Windows.Forms.Padding(4)
        Me.typesel.Name = "typesel"
        Me.typesel.Size = New System.Drawing.Size(403, 32)
        Me.typesel.TabIndex = 16
        '
        'dgprintback
        '
        Me.dgprintback.AllowUserToAddRows = False
        Me.dgprintback.AllowUserToResizeColumns = False
        Me.dgprintback.AllowUserToResizeRows = False
        Me.dgprintback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgprintback.BackgroundColor = System.Drawing.Color.White
        Me.dgprintback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgprintback.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgprintback.Location = New System.Drawing.Point(781, 384)
        Me.dgprintback.Margin = New System.Windows.Forms.Padding(4)
        Me.dgprintback.Name = "dgprintback"
        Me.dgprintback.ReadOnly = True
        Me.dgprintback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgprintback.Size = New System.Drawing.Size(515, 189)
        Me.dgprintback.TabIndex = 13
        '
        'dgprintfront
        '
        Me.dgprintfront.AllowUserToAddRows = False
        Me.dgprintfront.AllowUserToResizeColumns = False
        Me.dgprintfront.AllowUserToResizeRows = False
        Me.dgprintfront.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgprintfront.BackgroundColor = System.Drawing.Color.White
        Me.dgprintfront.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgprintfront.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgprintfront.Location = New System.Drawing.Point(781, 20)
        Me.dgprintfront.Margin = New System.Windows.Forms.Padding(4)
        Me.dgprintfront.Name = "dgprintfront"
        Me.dgprintfront.ReadOnly = True
        Me.dgprintfront.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgprintfront.Size = New System.Drawing.Size(515, 289)
        Me.dgprintfront.TabIndex = 14
        '
        'dgsel
        '
        Me.dgsel.AllowUserToAddRows = False
        Me.dgsel.AllowUserToDeleteRows = False
        Me.dgsel.AllowUserToResizeColumns = False
        Me.dgsel.AllowUserToResizeRows = False
        Me.dgsel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgsel.BackgroundColor = System.Drawing.Color.White
        Me.dgsel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgsel.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgsel.Location = New System.Drawing.Point(37, 291)
        Me.dgsel.Margin = New System.Windows.Forms.Padding(4)
        Me.dgsel.MultiSelect = False
        Me.dgsel.Name = "dgsel"
        Me.dgsel.ReadOnly = True
        Me.dgsel.RowHeadersVisible = False
        Me.dgsel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgsel.Size = New System.Drawing.Size(654, 292)
        Me.dgsel.TabIndex = 15
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.kanbaninput)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Controls.Add(Me.Label1)
        Me.gb1.Controls.Add(Me.pw1)
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.typesel)
        Me.gb1.Controls.Add(Me.num)
        Me.gb1.Location = New System.Drawing.Point(37, 3)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(654, 264)
        Me.gb1.TabIndex = 28
        Me.gb1.TabStop = False
        '
        'MES_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgkanban)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgtemp)
        Me.Controls.Add(Me.dgprintback)
        Me.Controls.Add(Me.dgprintfront)
        Me.Controls.Add(Me.dgsel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "MES_order"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.dgkanban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgprintback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgprintfront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgsel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pw1 As System.Windows.Forms.TextBox
    Friend WithEvents dgkanban As System.Windows.Forms.DataGridView
    Friend WithEvents kanbaninput As System.Windows.Forms.TextBox
    Friend WithEvents num As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents typesel As System.Windows.Forms.ComboBox
    Friend WithEvents dgprintback As System.Windows.Forms.DataGridView
    Friend WithEvents dgprintfront As System.Windows.Forms.DataGridView
    Friend WithEvents dgsel As System.Windows.Forms.DataGridView
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox

End Class
