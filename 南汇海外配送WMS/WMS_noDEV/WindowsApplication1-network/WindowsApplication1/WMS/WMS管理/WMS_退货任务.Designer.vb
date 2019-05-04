<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_退货任务
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

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbyfb = New System.Windows.Forms.GroupBox()
        Me.dgyfb = New System.Windows.Forms.DataGridView()
        Me.byfbrefresh = New System.Windows.Forms.Button()
        Me.gbdfb = New System.Windows.Forms.GroupBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdfb = New System.Windows.Forms.DataGridView()
        Me.bpublic = New System.Windows.Forms.Button()
        Me.bimport = New System.Windows.Forms.Button()
        Me.bdel = New System.Windows.Forms.Button()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.cbpartno = New System.Windows.Forms.ComboBox()
        Me.cbfactory = New System.Windows.Forms.ComboBox()
        Me.torderno = New System.Windows.Forms.TextBox()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.num1 = New System.Windows.Forms.NumericUpDown()
        Me.breset = New System.Windows.Forms.Button()
        Me.bsc = New System.Windows.Forms.Button()
        Me.badd = New System.Windows.Forms.Button()
        Me.lunit = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.gbyfb.SuspendLayout()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdfb.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbyfb
        '
        Me.gbyfb.Controls.Add(Me.dgyfb)
        Me.gbyfb.Controls.Add(Me.byfbrefresh)
        Me.gbyfb.Location = New System.Drawing.Point(911, 138)
        Me.gbyfb.Name = "gbyfb"
        Me.gbyfb.Size = New System.Drawing.Size(303, 510)
        Me.gbyfb.TabIndex = 7
        Me.gbyfb.TabStop = False
        Me.gbyfb.Text = "已发布"
        '
        'dgyfb
        '
        Me.dgyfb.AllowUserToAddRows = False
        Me.dgyfb.AllowUserToDeleteRows = False
        Me.dgyfb.AllowUserToResizeColumns = False
        Me.dgyfb.AllowUserToResizeRows = False
        Me.dgyfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgyfb.BackgroundColor = System.Drawing.Color.White
        Me.dgyfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgyfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgyfb.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgyfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgyfb.Location = New System.Drawing.Point(24, 68)
        Me.dgyfb.Margin = New System.Windows.Forms.Padding(4)
        Me.dgyfb.MultiSelect = False
        Me.dgyfb.Name = "dgyfb"
        Me.dgyfb.ReadOnly = True
        Me.dgyfb.RowHeadersVisible = False
        Me.dgyfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgyfb.Size = New System.Drawing.Size(839, 343)
        Me.dgyfb.TabIndex = 18
        '
        'byfbrefresh
        '
        Me.byfbrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.byfbrefresh.Location = New System.Drawing.Point(24, 30)
        Me.byfbrefresh.Name = "byfbrefresh"
        Me.byfbrefresh.Size = New System.Drawing.Size(88, 31)
        Me.byfbrefresh.TabIndex = 1
        Me.byfbrefresh.Text = "刷新"
        Me.byfbrefresh.UseVisualStyleBackColor = False
        '
        'gbdfb
        '
        Me.gbdfb.Controls.Add(Me.dgtemp)
        Me.gbdfb.Controls.Add(Me.dgdfb)
        Me.gbdfb.Controls.Add(Me.bpublic)
        Me.gbdfb.Controls.Add(Me.bimport)
        Me.gbdfb.Controls.Add(Me.bdel)
        Me.gbdfb.Location = New System.Drawing.Point(3, 233)
        Me.gbdfb.Name = "gbdfb"
        Me.gbdfb.Size = New System.Drawing.Size(902, 415)
        Me.gbdfb.TabIndex = 6
        Me.gbdfb.TabStop = False
        Me.gbdfb.Text = "待发布"
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.AllowUserToResizeColumns = False
        Me.dgtemp.AllowUserToResizeRows = False
        Me.dgtemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp.BackgroundColor = System.Drawing.Color.White
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgtemp.Location = New System.Drawing.Point(606, 208)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(241, 105)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'dgdfb
        '
        Me.dgdfb.AllowUserToAddRows = False
        Me.dgdfb.AllowUserToDeleteRows = False
        Me.dgdfb.AllowUserToResizeColumns = False
        Me.dgdfb.AllowUserToResizeRows = False
        Me.dgdfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdfb.BackgroundColor = System.Drawing.Color.White
        Me.dgdfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdfb.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgdfb.Location = New System.Drawing.Point(24, 68)
        Me.dgdfb.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdfb.MultiSelect = False
        Me.dgdfb.Name = "dgdfb"
        Me.dgdfb.ReadOnly = True
        Me.dgdfb.RowHeadersVisible = False
        Me.dgdfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdfb.Size = New System.Drawing.Size(839, 343)
        Me.dgdfb.TabIndex = 18
        '
        'bpublic
        '
        Me.bpublic.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bpublic.Location = New System.Drawing.Point(24, 30)
        Me.bpublic.Name = "bpublic"
        Me.bpublic.Size = New System.Drawing.Size(88, 31)
        Me.bpublic.TabIndex = 1
        Me.bpublic.Text = "发布"
        Me.bpublic.UseVisualStyleBackColor = False
        Me.bpublic.Visible = False
        '
        'bimport
        '
        Me.bimport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bimport.Location = New System.Drawing.Point(740, 30)
        Me.bimport.Name = "bimport"
        Me.bimport.Size = New System.Drawing.Size(88, 31)
        Me.bimport.TabIndex = 1
        Me.bimport.Text = "导入"
        Me.bimport.UseVisualStyleBackColor = False
        Me.bimport.Visible = False
        '
        'bdel
        '
        Me.bdel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bdel.Location = New System.Drawing.Point(139, 30)
        Me.bdel.Name = "bdel"
        Me.bdel.Size = New System.Drawing.Size(88, 31)
        Me.bdel.TabIndex = 1
        Me.bdel.Text = "删除"
        Me.bdel.UseVisualStyleBackColor = False
        Me.bdel.Visible = False
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.cbpartno)
        Me.gbop.Controls.Add(Me.cbfactory)
        Me.gbop.Controls.Add(Me.torderno)
        Me.gbop.Controls.Add(Me.dt1)
        Me.gbop.Controls.Add(Me.num1)
        Me.gbop.Controls.Add(Me.breset)
        Me.gbop.Controls.Add(Me.bsc)
        Me.gbop.Controls.Add(Me.badd)
        Me.gbop.Controls.Add(Me.lunit)
        Me.gbop.Controls.Add(Me.Label4)
        Me.gbop.Controls.Add(Me.Label5)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label6)
        Me.gbop.Controls.Add(Me.Label2)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 151)
        Me.gbop.TabIndex = 5
        Me.gbop.TabStop = False
        Me.gbop.Text = "退货新增"
        '
        'cbpartno
        '
        Me.cbpartno.FormattingEnabled = True
        Me.cbpartno.Location = New System.Drawing.Point(420, 35)
        Me.cbpartno.Name = "cbpartno"
        Me.cbpartno.Size = New System.Drawing.Size(192, 24)
        Me.cbpartno.TabIndex = 27
        '
        'cbfactory
        '
        Me.cbfactory.FormattingEnabled = True
        Me.cbfactory.Location = New System.Drawing.Point(125, 35)
        Me.cbfactory.Name = "cbfactory"
        Me.cbfactory.Size = New System.Drawing.Size(178, 24)
        Me.cbfactory.TabIndex = 26
        '
        'torderno
        '
        Me.torderno.Location = New System.Drawing.Point(125, 82)
        Me.torderno.Name = "torderno"
        Me.torderno.Size = New System.Drawing.Size(178, 22)
        Me.torderno.TabIndex = 25
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(758, 75)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(200, 22)
        Me.dt1.TabIndex = 23
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(420, 80)
        Me.num1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(75, 22)
        Me.num1.TabIndex = 22
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(731, 110)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(72, 28)
        Me.breset.TabIndex = 21
        Me.breset.Text = "取消"
        Me.breset.UseVisualStyleBackColor = False
        '
        'bsc
        '
        Me.bsc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bsc.Location = New System.Drawing.Point(231, 110)
        Me.bsc.Name = "bsc"
        Me.bsc.Size = New System.Drawing.Size(72, 28)
        Me.bsc.TabIndex = 21
        Me.bsc.Text = "生成"
        Me.bsc.UseVisualStyleBackColor = False
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(637, 110)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(72, 28)
        Me.badd.TabIndex = 21
        Me.badd.Text = "确认"
        Me.badd.UseVisualStyleBackColor = False
        '
        'lunit
        '
        Me.lunit.AutoSize = True
        Me.lunit.Location = New System.Drawing.Point(516, 85)
        Me.lunit.Name = "lunit"
        Me.lunit.Size = New System.Drawing.Size(22, 17)
        Me.lunit.TabIndex = 2
        Me.lunit.Text = "箱"
        Me.lunit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "数量："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(634, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "计划退货日期："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(690, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "搜索："
        Me.Label3.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "零件："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "退货号："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "工厂："
        '
        'dgpart
        '
        Me.dgpart.AllowUserToAddRows = False
        Me.dgpart.AllowUserToDeleteRows = False
        Me.dgpart.AllowUserToResizeColumns = False
        Me.dgpart.AllowUserToResizeRows = False
        Me.dgpart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgpart.BackgroundColor = System.Drawing.Color.White
        Me.dgpart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgpart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpart.Location = New System.Drawing.Point(521, 178)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(219, 49)
        Me.dgpart.TabIndex = 23
        Me.dgpart.Visible = False
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(758, 35)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(200, 22)
        Me.tsearch.TabIndex = 28
        '
        'WMS_退货任务
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgpart)
        Me.Controls.Add(Me.gbyfb)
        Me.Controls.Add(Me.gbdfb)
        Me.Controls.Add(Me.gbop)
        Me.Name = "WMS_退货任务"
        Me.Size = New System.Drawing.Size(1324, 648)
        Me.gbyfb.ResumeLayout(False)
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdfb.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbyfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgyfb As System.Windows.Forms.DataGridView
    Friend WithEvents byfbrefresh As System.Windows.Forms.Button
    Friend WithEvents gbdfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdfb As System.Windows.Forms.DataGridView
    Friend WithEvents bpublic As System.Windows.Forms.Button
    Friend WithEvents bimport As System.Windows.Forms.Button
    Friend WithEvents bdel As System.Windows.Forms.Button
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents num1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bsc As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents lunit As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents torderno As System.Windows.Forms.TextBox
    Friend WithEvents cbfactory As System.Windows.Forms.ComboBox
    Friend WithEvents cbpartno As System.Windows.Forms.ComboBox
    Friend WithEvents tsearch As System.Windows.Forms.TextBox

End Class
