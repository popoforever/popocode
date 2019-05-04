<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class spare_part
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.num = New System.Windows.Forms.NumericUpDown()
        Me.dgsel = New System.Windows.Forms.DataGridView()
        Me.dgkanban = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.typesel = New System.Windows.Forms.ComboBox()
        Me.dgprintback = New System.Windows.Forms.DataGridView()
        Me.dgprintfront = New System.Windows.Forms.DataGridView()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.dghis = New System.Windows.Forms.DataGridView()
        CType(Me.num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgsel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgkanban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgprintback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgprintfront, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        CType(Me.dghis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(32, 504)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 50)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Print label"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(516, 38)
        Me.num.Margin = New System.Windows.Forms.Padding(4)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(102, 49)
        Me.num.TabIndex = 32
        Me.num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dgsel
        '
        Me.dgsel.AllowUserToAddRows = False
        Me.dgsel.AllowUserToResizeRows = False
        Me.dgsel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgsel.BackgroundColor = System.Drawing.Color.White
        Me.dgsel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgsel.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgsel.Location = New System.Drawing.Point(32, 147)
        Me.dgsel.Margin = New System.Windows.Forms.Padding(4)
        Me.dgsel.MultiSelect = False
        Me.dgsel.Name = "dgsel"
        Me.dgsel.ReadOnly = True
        Me.dgsel.RowHeadersVisible = False
        Me.dgsel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgsel.Size = New System.Drawing.Size(578, 340)
        Me.dgsel.TabIndex = 25
        '
        'dgkanban
        '
        Me.dgkanban.AllowUserToAddRows = False
        Me.dgkanban.AllowUserToDeleteRows = False
        Me.dgkanban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkanban.Location = New System.Drawing.Point(1051, 159)
        Me.dgkanban.Margin = New System.Windows.Forms.Padding(4)
        Me.dgkanban.Name = "dgkanban"
        Me.dgkanban.Size = New System.Drawing.Size(269, 185)
        Me.dgkanban.TabIndex = 33
        Me.dgkanban.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(861, 484)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 59)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Print Back"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(151, 521)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 59)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Print Front"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(978, 270)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.Size = New System.Drawing.Size(320, 185)
        Me.dgtemp.TabIndex = 27
        Me.dgtemp.Visible = False
        '
        'typesel
        '
        Me.typesel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typesel.FormattingEnabled = True
        Me.typesel.Location = New System.Drawing.Point(15, 57)
        Me.typesel.Margin = New System.Windows.Forms.Padding(4)
        Me.typesel.Name = "typesel"
        Me.typesel.Size = New System.Drawing.Size(461, 32)
        Me.typesel.TabIndex = 26
        '
        'dgprintback
        '
        Me.dgprintback.AllowUserToAddRows = False
        Me.dgprintback.AllowUserToResizeColumns = False
        Me.dgprintback.AllowUserToResizeRows = False
        Me.dgprintback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgprintback.BackgroundColor = System.Drawing.Color.LightYellow
        Me.dgprintback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgprintback.Location = New System.Drawing.Point(822, 234)
        Me.dgprintback.Margin = New System.Windows.Forms.Padding(4)
        Me.dgprintback.Name = "dgprintback"
        Me.dgprintback.ReadOnly = True
        Me.dgprintback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgprintback.Size = New System.Drawing.Size(298, 198)
        Me.dgprintback.TabIndex = 23
        Me.dgprintback.Visible = False
        '
        'dgprintfront
        '
        Me.dgprintfront.AllowUserToAddRows = False
        Me.dgprintfront.AllowUserToResizeColumns = False
        Me.dgprintfront.AllowUserToResizeRows = False
        Me.dgprintfront.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgprintfront.BackgroundColor = System.Drawing.Color.LightYellow
        Me.dgprintfront.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgprintfront.Location = New System.Drawing.Point(1081, 404)
        Me.dgprintfront.Margin = New System.Windows.Forms.Padding(4)
        Me.dgprintfront.Name = "dgprintfront"
        Me.dgprintfront.ReadOnly = True
        Me.dgprintfront.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgprintfront.Size = New System.Drawing.Size(199, 128)
        Me.dgprintfront.TabIndex = 24
        Me.dgprintfront.Visible = False
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.typesel)
        Me.gb1.Controls.Add(Me.num)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(32, 18)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(1074, 122)
        Me.gb1.TabIndex = 34
        Me.gb1.TabStop = False
        Me.gb1.Text = "Spare part"
        '
        'dghis
        '
        Me.dghis.AllowUserToAddRows = False
        Me.dghis.AllowUserToResizeRows = False
        Me.dghis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dghis.BackgroundColor = System.Drawing.Color.White
        Me.dghis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dghis.DefaultCellStyle = DataGridViewCellStyle2
        Me.dghis.Location = New System.Drawing.Point(731, 147)
        Me.dghis.Margin = New System.Windows.Forms.Padding(4)
        Me.dghis.MultiSelect = False
        Me.dghis.Name = "dghis"
        Me.dghis.ReadOnly = True
        Me.dghis.RowHeadersVisible = False
        Me.dghis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dghis.Size = New System.Drawing.Size(489, 340)
        Me.dghis.TabIndex = 25
        '
        'spare_part
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dghis)
        Me.Controls.Add(Me.dgsel)
        Me.Controls.Add(Me.dgkanban)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgtemp)
        Me.Controls.Add(Me.dgprintback)
        Me.Controls.Add(Me.dgprintfront)
        Me.Name = "spare_part"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgsel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgkanban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgprintback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgprintfront, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        CType(Me.dghis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents num As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgsel As System.Windows.Forms.DataGridView
    Friend WithEvents dgkanban As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents typesel As System.Windows.Forms.ComboBox
    Friend WithEvents dgprintback As System.Windows.Forms.DataGridView
    Friend WithEvents dgprintfront As System.Windows.Forms.DataGridView
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents dghis As System.Windows.Forms.DataGridView

End Class
