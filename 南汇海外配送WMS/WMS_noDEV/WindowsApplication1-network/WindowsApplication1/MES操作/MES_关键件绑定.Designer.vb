<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MES_关键件绑定
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.deslabel = New System.Windows.Forms.Label()
        Me.bar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.barlabel = New System.Windows.Forms.Label()
        Me.partlabel = New System.Windows.Forms.Label()
        Me.parttypelabel = New System.Windows.Forms.Label()
        Me.cartypelabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.msg1 = New System.Windows.Forms.Label()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.msglast = New System.Windows.Forms.Label()
        Me.msgnext = New System.Windows.Forms.Label()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.dgtemp2 = New System.Windows.Forms.DataGridView()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gb1.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gb3.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.t1)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Location = New System.Drawing.Point(30, 33)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(572, 120)
        Me.gb1.TabIndex = 29
        Me.gb1.TabStop = False
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.ForeColor = System.Drawing.Color.Black
        Me.t1.Location = New System.Drawing.Point(28, 59)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(460, 38)
        Me.t1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Keypart Scan"
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(41, 69)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(298, 106)
        Me.dgtemp.TabIndex = 0
        Me.dgtemp.Visible = False
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.deslabel)
        Me.gb2.Controls.Add(Me.bar)
        Me.gb2.Controls.Add(Me.Label5)
        Me.gb2.Controls.Add(Me.Label7)
        Me.gb2.Controls.Add(Me.Label9)
        Me.gb2.Controls.Add(Me.Label10)
        Me.gb2.Controls.Add(Me.barlabel)
        Me.gb2.Controls.Add(Me.partlabel)
        Me.gb2.Controls.Add(Me.parttypelabel)
        Me.gb2.Controls.Add(Me.cartypelabel)
        Me.gb2.Location = New System.Drawing.Point(30, 217)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(572, 318)
        Me.gb2.TabIndex = 30
        Me.gb2.TabStop = False
        Me.gb2.Text = "message"
        '
        'deslabel
        '
        Me.deslabel.AutoSize = True
        Me.deslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deslabel.ForeColor = System.Drawing.Color.Black
        Me.deslabel.Location = New System.Drawing.Point(196, 148)
        Me.deslabel.Name = "deslabel"
        Me.deslabel.Size = New System.Drawing.Size(341, 29)
        Me.deslabel.TabIndex = 16
        Me.deslabel.Text = "ASM REAR SEAT CUSHION"
        '
        'bar
        '
        Me.bar.AutoSize = True
        Me.bar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bar.ForeColor = System.Drawing.Color.Black
        Me.bar.Location = New System.Drawing.Point(33, 31)
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(118, 29)
        Me.bar.TabIndex = 12
        Me.bar.Text = "Barcode:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Part No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(33, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Description:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(33, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 29)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Part type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(33, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 29)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Car type:"
        '
        'barlabel
        '
        Me.barlabel.AutoSize = True
        Me.barlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barlabel.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(196, 31)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(258, 29)
        Me.barlabel.TabIndex = 17
        Me.barlabel.Text = "4699-ASI1710092928"
        '
        'partlabel
        '
        Me.partlabel.AutoSize = True
        Me.partlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partlabel.ForeColor = System.Drawing.Color.Black
        Me.partlabel.Location = New System.Drawing.Point(196, 89)
        Me.partlabel.Name = "partlabel"
        Me.partlabel.Size = New System.Drawing.Size(174, 29)
        Me.partlabel.TabIndex = 18
        Me.partlabel.Text = "10154699-ASI"
        '
        'parttypelabel
        '
        Me.parttypelabel.AutoSize = True
        Me.parttypelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parttypelabel.ForeColor = System.Drawing.Color.Black
        Me.parttypelabel.Location = New System.Drawing.Point(196, 201)
        Me.parttypelabel.Name = "parttypelabel"
        Me.parttypelabel.Size = New System.Drawing.Size(315, 29)
        Me.parttypelabel.TabIndex = 14
        Me.parttypelabel.Text = "MG3 Black Leather Luxury"
        '
        'cartypelabel
        '
        Me.cartypelabel.AutoSize = True
        Me.cartypelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartypelabel.ForeColor = System.Drawing.Color.Black
        Me.cartypelabel.Location = New System.Drawing.Point(196, 253)
        Me.cartypelabel.Name = "cartypelabel"
        Me.cartypelabel.Size = New System.Drawing.Size(107, 29)
        Me.cartypelabel.TabIndex = 15
        Me.cartypelabel.Text = "ZP11TT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.msg1)
        Me.Panel1.Location = New System.Drawing.Point(30, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 171)
        Me.Panel1.TabIndex = 26
        '
        'msg1
        '
        Me.msg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg1.ForeColor = System.Drawing.Color.White
        Me.msg1.Location = New System.Drawing.Point(15, 9)
        Me.msg1.Name = "msg1"
        Me.msg1.Size = New System.Drawing.Size(565, 108)
        Me.msg1.TabIndex = 2
        Me.msg1.Text = "Please scan the barcode."
        '
        'gb3
        '
        Me.gb3.Controls.Add(Me.pb1)
        Me.gb3.Controls.Add(Me.msglast)
        Me.gb3.Controls.Add(Me.msgnext)
        Me.gb3.Controls.Add(Me.dgtemp)
        Me.gb3.Location = New System.Drawing.Point(633, 33)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(572, 175)
        Me.gb3.TabIndex = 29
        Me.gb3.TabStop = False
        Me.gb3.Text = "Next keypart"
        '
        'msglast
        '
        Me.msglast.AutoSize = True
        Me.msglast.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msglast.ForeColor = System.Drawing.Color.Black
        Me.msglast.Location = New System.Drawing.Point(21, 114)
        Me.msglast.Name = "msglast"
        Me.msglast.Size = New System.Drawing.Size(197, 32)
        Me.msglast.TabIndex = 11
        Me.msglast.Text = "Keypart Scan"
        Me.msglast.Visible = False
        '
        'msgnext
        '
        Me.msgnext.AutoSize = True
        Me.msgnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgnext.ForeColor = System.Drawing.Color.Black
        Me.msgnext.Location = New System.Drawing.Point(21, 42)
        Me.msgnext.Name = "msgnext"
        Me.msgnext.Size = New System.Drawing.Size(197, 32)
        Me.msgnext.TabIndex = 11
        Me.msgnext.Text = "Keypart Scan"
        Me.msgnext.Visible = False
        '
        'dg2
        '
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dg2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg2.BackgroundColor = System.Drawing.Color.White
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dg2.Location = New System.Drawing.Point(633, 350)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.RowHeadersVisible = False
        Me.dg2.RowTemplate.Height = 24
        Me.dg2.Size = New System.Drawing.Size(540, 162)
        Me.dg2.TabIndex = 31
        '
        'dgtemp2
        '
        Me.dgtemp2.AllowUserToAddRows = False
        Me.dgtemp2.AllowUserToDeleteRows = False
        Me.dgtemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp2.Location = New System.Drawing.Point(674, 217)
        Me.dgtemp2.Name = "dgtemp2"
        Me.dgtemp2.RowTemplate.Height = 24
        Me.dgtemp2.Size = New System.Drawing.Size(298, 106)
        Me.dgtemp2.TabIndex = 12
        Me.dgtemp2.Visible = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(469, 42)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(103, 78)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 12
        Me.pb1.TabStop = False
        '
        'MES_关键件绑定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgtemp2)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.gb3)
        Me.Controls.Add(Me.gb1)
        Me.Name = "MES_关键件绑定"
        Me.Size = New System.Drawing.Size(1324, 648)
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents deslabel As System.Windows.Forms.Label
    Friend WithEvents bar As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents barlabel As System.Windows.Forms.Label
    Friend WithEvents partlabel As System.Windows.Forms.Label
    Friend WithEvents parttypelabel As System.Windows.Forms.Label
    Friend WithEvents cartypelabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents msg1 As System.Windows.Forms.Label
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents msgnext As System.Windows.Forms.Label
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents msglast As System.Windows.Forms.Label
    Friend WithEvents dgtemp2 As System.Windows.Forms.DataGridView
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox

End Class
