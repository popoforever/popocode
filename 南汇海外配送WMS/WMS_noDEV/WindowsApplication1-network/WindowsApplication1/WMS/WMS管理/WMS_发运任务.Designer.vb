<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_发运任务
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.gbyfb = New System.Windows.Forms.GroupBox()
        Me.dgreject = New System.Windows.Forms.DataGridView()
        Me.dgyfb = New System.Windows.Forms.DataGridView()
        Me.byfbrefresh = New System.Windows.Forms.Button()
        Me.gbdfb = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dgimport = New System.Windows.Forms.DataGridView()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdfb = New System.Windows.Forms.DataGridView()
        Me.bimport = New System.Windows.Forms.Button()
        Me.bpublic = New System.Windows.Forms.Button()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.numea = New System.Windows.Forms.TextBox()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.torderno = New System.Windows.Forms.TextBox()
        Me.cbcustomer = New System.Windows.Forms.ComboBox()
        Me.cbpartno = New System.Windows.Forms.ComboBox()
        Me.cbsp = New System.Windows.Forms.ComboBox()
        Me.lrefreshmsg = New System.Windows.Forms.Label()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.numbox = New System.Windows.Forms.NumericUpDown()
        Me.breset = New System.Windows.Forms.Button()
        Me.bsc = New System.Windows.Forms.Button()
        Me.badd = New System.Windows.Forms.Button()
        Me.lpackage = New System.Windows.Forms.Label()
        Me.lunit = New System.Windows.Forms.Label()
        Me.linnerunit = New System.Windows.Forms.Label()
        Me.linnernum = New System.Windows.Forms.Label()
        Me.lsl = New System.Windows.Forms.Label()
        Me.lxs = New System.Windows.Forms.Label()
        Me.lyjdhrq = New System.Windows.Forms.Label()
        Me.lss = New System.Windows.Forms.Label()
        Me.llj = New System.Windows.Forms.Label()
        Me.ltrans = New System.Windows.Forms.Label()
        Me.lpartno = New System.Windows.Forms.Label()
        Me.lddh = New System.Windows.Forms.Label()
        Me.lkh = New System.Windows.Forms.Label()
        Me.trefresh = New System.Windows.Forms.Timer(Me.components)
        Me.open_excel = New System.Windows.Forms.OpenFileDialog()
        Me.yfbrefresh = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dghis = New System.Windows.Forms.DataGridView()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbyfb.SuspendLayout()
        CType(Me.dgreject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdfb.SuspendLayout()
        CType(Me.dgimport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        CType(Me.numbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dghis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgpart.Location = New System.Drawing.Point(943, 94)
        Me.dgpart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(246, 39)
        Me.dgpart.TabIndex = 26
        Me.dgpart.Visible = False
        '
        'gbyfb
        '
        Me.gbyfb.Controls.Add(Me.dgreject)
        Me.gbyfb.Controls.Add(Me.dgyfb)
        Me.gbyfb.Controls.Add(Me.byfbrefresh)
        Me.gbyfb.Location = New System.Drawing.Point(1248, 68)
        Me.gbyfb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbyfb.Name = "gbyfb"
        Me.gbyfb.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbyfb.Size = New System.Drawing.Size(176, 70)
        Me.gbyfb.TabIndex = 24
        Me.gbyfb.TabStop = False
        Me.gbyfb.Text = "已发布"
        Me.gbyfb.Visible = False
        '
        'dgreject
        '
        Me.dgreject.AllowUserToAddRows = False
        Me.dgreject.AllowUserToDeleteRows = False
        Me.dgreject.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgreject.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgreject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgreject.BackgroundColor = System.Drawing.Color.White
        Me.dgreject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgreject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgreject.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgreject.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgreject.Location = New System.Drawing.Point(53, 307)
        Me.dgreject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgreject.MultiSelect = False
        Me.dgreject.Name = "dgreject"
        Me.dgreject.ReadOnly = True
        Me.dgreject.RowHeadersVisible = False
        Me.dgreject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgreject.Size = New System.Drawing.Size(246, 148)
        Me.dgreject.TabIndex = 18
        '
        'dgyfb
        '
        Me.dgyfb.AllowUserToAddRows = False
        Me.dgyfb.AllowUserToDeleteRows = False
        Me.dgyfb.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgyfb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgyfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgyfb.BackgroundColor = System.Drawing.Color.White
        Me.dgyfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgyfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgyfb.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgyfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgyfb.Location = New System.Drawing.Point(53, 85)
        Me.dgyfb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgyfb.MultiSelect = False
        Me.dgyfb.Name = "dgyfb"
        Me.dgyfb.ReadOnly = True
        Me.dgyfb.RowHeadersVisible = False
        Me.dgyfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgyfb.Size = New System.Drawing.Size(246, 156)
        Me.dgyfb.TabIndex = 18
        '
        'byfbrefresh
        '
        Me.byfbrefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.byfbrefresh.Location = New System.Drawing.Point(235, 12)
        Me.byfbrefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.byfbrefresh.Name = "byfbrefresh"
        Me.byfbrefresh.Size = New System.Drawing.Size(64, 25)
        Me.byfbrefresh.TabIndex = 1
        Me.byfbrefresh.Text = "刷新"
        Me.byfbrefresh.UseVisualStyleBackColor = False
        '
        'gbdfb
        '
        Me.gbdfb.Controls.Add(Me.ProgressBar1)
        Me.gbdfb.Controls.Add(Me.dgimport)
        Me.gbdfb.Controls.Add(Me.dgtemp)
        Me.gbdfb.Controls.Add(Me.dgdfb)
        Me.gbdfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbdfb.Location = New System.Drawing.Point(0, 0)
        Me.gbdfb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Name = "gbdfb"
        Me.gbdfb.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Size = New System.Drawing.Size(1390, 251)
        Me.gbdfb.TabIndex = 25
        Me.gbdfb.TabStop = False
        Me.gbdfb.Text = "待发布"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(355, -10)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1130, 22)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'dgimport
        '
        Me.dgimport.AllowUserToAddRows = False
        Me.dgimport.AllowUserToDeleteRows = False
        Me.dgimport.AllowUserToResizeColumns = False
        Me.dgimport.AllowUserToResizeRows = False
        Me.dgimport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgimport.BackgroundColor = System.Drawing.Color.White
        Me.dgimport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgimport.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgimport.Location = New System.Drawing.Point(40, 263)
        Me.dgimport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgimport.Name = "dgimport"
        Me.dgimport.RowHeadersVisible = False
        Me.dgimport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgimport.Size = New System.Drawing.Size(554, 153)
        Me.dgimport.TabIndex = 19
        Me.dgimport.Visible = False
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgtemp.Location = New System.Drawing.Point(677, 285)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(271, 131)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'dgdfb
        '
        Me.dgdfb.AllowUserToAddRows = False
        Me.dgdfb.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgdfb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgdfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdfb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgdfb.BackgroundColor = System.Drawing.Color.White
        Me.dgdfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdfb.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgdfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgdfb.Location = New System.Drawing.Point(3, 24)
        Me.dgdfb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgdfb.MultiSelect = False
        Me.dgdfb.Name = "dgdfb"
        Me.dgdfb.ReadOnly = True
        Me.dgdfb.RowHeadersVisible = False
        Me.dgdfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdfb.Size = New System.Drawing.Size(1384, 223)
        Me.dgdfb.TabIndex = 18
        '
        'bimport
        '
        Me.bimport.BackColor = System.Drawing.Color.Green
        Me.bimport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bimport.ForeColor = System.Drawing.Color.White
        Me.bimport.Location = New System.Drawing.Point(863, 28)
        Me.bimport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bimport.Name = "bimport"
        Me.bimport.Size = New System.Drawing.Size(130, 33)
        Me.bimport.TabIndex = 1
        Me.bimport.Text = "Excel 导入"
        Me.bimport.UseVisualStyleBackColor = False
        '
        'bpublic
        '
        Me.bpublic.BackColor = System.Drawing.Color.Gray
        Me.bpublic.Dock = System.Windows.Forms.DockStyle.Left
        Me.bpublic.ForeColor = System.Drawing.Color.White
        Me.bpublic.Location = New System.Drawing.Point(3, 24)
        Me.bpublic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bpublic.Name = "bpublic"
        Me.bpublic.Size = New System.Drawing.Size(109, 105)
        Me.bpublic.TabIndex = 1
        Me.bpublic.Text = "订单发布"
        Me.bpublic.UseVisualStyleBackColor = False
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.numea)
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.torderno)
        Me.gbop.Controls.Add(Me.cbcustomer)
        Me.gbop.Controls.Add(Me.cbpartno)
        Me.gbop.Controls.Add(Me.cbsp)
        Me.gbop.Controls.Add(Me.gbyfb)
        Me.gbop.Controls.Add(Me.lrefreshmsg)
        Me.gbop.Controls.Add(Me.dgpart)
        Me.gbop.Controls.Add(Me.bpublic)
        Me.gbop.Controls.Add(Me.bimport)
        Me.gbop.Controls.Add(Me.dt1)
        Me.gbop.Controls.Add(Me.numbox)
        Me.gbop.Controls.Add(Me.breset)
        Me.gbop.Controls.Add(Me.bsc)
        Me.gbop.Controls.Add(Me.badd)
        Me.gbop.Controls.Add(Me.lpackage)
        Me.gbop.Controls.Add(Me.lunit)
        Me.gbop.Controls.Add(Me.linnerunit)
        Me.gbop.Controls.Add(Me.linnernum)
        Me.gbop.Controls.Add(Me.lsl)
        Me.gbop.Controls.Add(Me.lxs)
        Me.gbop.Controls.Add(Me.lyjdhrq)
        Me.gbop.Controls.Add(Me.lss)
        Me.gbop.Controls.Add(Me.llj)
        Me.gbop.Controls.Add(Me.ltrans)
        Me.gbop.Controls.Add(Me.lpartno)
        Me.gbop.Controls.Add(Me.lddh)
        Me.gbop.Controls.Add(Me.lkh)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Name = "gbop"
        Me.gbop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Size = New System.Drawing.Size(1390, 133)
        Me.gbop.TabIndex = 23
        Me.gbop.TabStop = False
        Me.gbop.Text = "要货计划"
        '
        'numea
        '
        Me.numea.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.numea.Location = New System.Drawing.Point(405, 63)
        Me.numea.Name = "numea"
        Me.numea.Size = New System.Drawing.Size(124, 27)
        Me.numea.TabIndex = 33
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(663, 102)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(188, 27)
        Me.tsearch.TabIndex = 32
        '
        'torderno
        '
        Me.torderno.Location = New System.Drawing.Point(220, 63)
        Me.torderno.Name = "torderno"
        Me.torderno.Size = New System.Drawing.Size(121, 27)
        Me.torderno.TabIndex = 31
        '
        'cbcustomer
        '
        Me.cbcustomer.FormattingEnabled = True
        Me.cbcustomer.Location = New System.Drawing.Point(909, 64)
        Me.cbcustomer.Name = "cbcustomer"
        Me.cbcustomer.Size = New System.Drawing.Size(121, 28)
        Me.cbcustomer.TabIndex = 30
        Me.cbcustomer.Visible = False
        '
        'cbpartno
        '
        Me.cbpartno.FormattingEnabled = True
        Me.cbpartno.Location = New System.Drawing.Point(220, 23)
        Me.cbpartno.Name = "cbpartno"
        Me.cbpartno.Size = New System.Drawing.Size(637, 28)
        Me.cbpartno.TabIndex = 29
        '
        'cbsp
        '
        Me.cbsp.FormattingEnabled = True
        Me.cbsp.Location = New System.Drawing.Point(220, 98)
        Me.cbsp.Name = "cbsp"
        Me.cbsp.Size = New System.Drawing.Size(121, 28)
        Me.cbsp.TabIndex = 28
        '
        'lrefreshmsg
        '
        Me.lrefreshmsg.AutoSize = True
        Me.lrefreshmsg.BackColor = System.Drawing.Color.DarkOrange
        Me.lrefreshmsg.Dock = System.Windows.Forms.DockStyle.Right
        Me.lrefreshmsg.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lrefreshmsg.Location = New System.Drawing.Point(1242, 24)
        Me.lrefreshmsg.Name = "lrefreshmsg"
        Me.lrefreshmsg.Size = New System.Drawing.Size(145, 27)
        Me.lrefreshmsg.TabIndex = 27
        Me.lrefreshmsg.Text = "New Message"
        Me.lrefreshmsg.Visible = False
        '
        'dt1
        '
        Me.dt1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt1.Location = New System.Drawing.Point(663, 65)
        Me.dt1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(188, 27)
        Me.dt1.TabIndex = 23
        '
        'numbox
        '
        Me.numbox.Location = New System.Drawing.Point(909, 16)
        Me.numbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numbox.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numbox.Name = "numbox"
        Me.numbox.Size = New System.Drawing.Size(84, 27)
        Me.numbox.TabIndex = 22
        Me.numbox.Visible = False
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(1149, 36)
        Me.breset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(61, 27)
        Me.breset.TabIndex = 21
        Me.breset.Text = "取消"
        Me.breset.UseVisualStyleBackColor = False
        Me.breset.Visible = False
        '
        'bsc
        '
        Me.bsc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bsc.Location = New System.Drawing.Point(1149, 58)
        Me.bsc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bsc.Name = "bsc"
        Me.bsc.Size = New System.Drawing.Size(78, 25)
        Me.bsc.TabIndex = 21
        Me.bsc.Text = "生成"
        Me.bsc.UseVisualStyleBackColor = False
        Me.bsc.Visible = False
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.Gray
        Me.badd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.badd.ForeColor = System.Drawing.Color.White
        Me.badd.Location = New System.Drawing.Point(405, 98)
        Me.badd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(124, 30)
        Me.badd.TabIndex = 21
        Me.badd.Text = "零件加入清单"
        Me.badd.UseVisualStyleBackColor = False
        '
        'lpackage
        '
        Me.lpackage.AutoSize = True
        Me.lpackage.Location = New System.Drawing.Point(1052, 23)
        Me.lpackage.Name = "lpackage"
        Me.lpackage.Size = New System.Drawing.Size(18, 20)
        Me.lpackage.TabIndex = 2
        Me.lpackage.Text = "0"
        Me.lpackage.Visible = False
        '
        'lunit
        '
        Me.lunit.AutoSize = True
        Me.lunit.Location = New System.Drawing.Point(1010, 23)
        Me.lunit.Name = "lunit"
        Me.lunit.Size = New System.Drawing.Size(24, 20)
        Me.lunit.TabIndex = 2
        Me.lunit.Text = "箱"
        Me.lunit.Visible = False
        '
        'linnerunit
        '
        Me.linnerunit.AutoSize = True
        Me.linnerunit.Location = New System.Drawing.Point(1010, 43)
        Me.linnerunit.Name = "linnerunit"
        Me.linnerunit.Size = New System.Drawing.Size(28, 20)
        Me.linnerunit.TabIndex = 2
        Me.linnerunit.Text = "EA"
        Me.linnerunit.Visible = False
        '
        'linnernum
        '
        Me.linnernum.AutoSize = True
        Me.linnernum.Location = New System.Drawing.Point(1052, 43)
        Me.linnernum.Name = "linnernum"
        Me.linnernum.Size = New System.Drawing.Size(18, 20)
        Me.linnernum.TabIndex = 2
        Me.linnernum.Text = "0"
        Me.linnernum.Visible = False
        '
        'lsl
        '
        Me.lsl.AutoSize = True
        Me.lsl.Location = New System.Drawing.Point(353, 66)
        Me.lsl.Name = "lsl"
        Me.lsl.Size = New System.Drawing.Size(39, 20)
        Me.lsl.TabIndex = 2
        Me.lsl.Text = "数量"
        '
        'lxs
        '
        Me.lxs.AutoSize = True
        Me.lxs.Location = New System.Drawing.Point(849, 24)
        Me.lxs.Name = "lxs"
        Me.lxs.Size = New System.Drawing.Size(54, 20)
        Me.lxs.TabIndex = 2
        Me.lxs.Text = "箱数："
        Me.lxs.Visible = False
        '
        'lyjdhrq
        '
        Me.lyjdhrq.AutoSize = True
        Me.lyjdhrq.Location = New System.Drawing.Point(548, 67)
        Me.lyjdhrq.Name = "lyjdhrq"
        Me.lyjdhrq.Size = New System.Drawing.Size(99, 20)
        Me.lyjdhrq.TabIndex = 2
        Me.lyjdhrq.Text = "预计到货日期"
        '
        'lss
        '
        Me.lss.AutoSize = True
        Me.lss.Location = New System.Drawing.Point(572, 108)
        Me.lss.Name = "lss"
        Me.lss.Size = New System.Drawing.Size(54, 20)
        Me.lss.TabIndex = 2
        Me.lss.Text = "搜索："
        Me.lss.Visible = False
        '
        'llj
        '
        Me.llj.AutoSize = True
        Me.llj.Location = New System.Drawing.Point(174, 29)
        Me.llj.Name = "llj"
        Me.llj.Size = New System.Drawing.Size(39, 20)
        Me.llj.TabIndex = 2
        Me.llj.Text = "零件"
        '
        'ltrans
        '
        Me.ltrans.Location = New System.Drawing.Point(118, 101)
        Me.ltrans.Name = "ltrans"
        Me.ltrans.Size = New System.Drawing.Size(96, 20)
        Me.ltrans.TabIndex = 2
        Me.ltrans.Text = " 运输方式"
        Me.ltrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lpartno
        '
        Me.lpartno.Location = New System.Drawing.Point(841, 103)
        Me.lpartno.Name = "lpartno"
        Me.lpartno.Size = New System.Drawing.Size(96, 20)
        Me.lpartno.TabIndex = 2
        Me.lpartno.Text = "零件号"
        Me.lpartno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lpartno.Visible = False
        '
        'lddh
        '
        Me.lddh.Location = New System.Drawing.Point(118, 63)
        Me.lddh.Name = "lddh"
        Me.lddh.Size = New System.Drawing.Size(96, 20)
        Me.lddh.TabIndex = 2
        Me.lddh.Text = "要货号"
        Me.lddh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lkh
        '
        Me.lkh.Location = New System.Drawing.Point(799, 72)
        Me.lkh.Name = "lkh"
        Me.lkh.Size = New System.Drawing.Size(96, 20)
        Me.lkh.TabIndex = 2
        Me.lkh.Text = "客户"
        Me.lkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lkh.Visible = False
        '
        'trefresh
        '
        Me.trefresh.Enabled = True
        Me.trefresh.Interval = 2000
        '
        'open_excel
        '
        Me.open_excel.FileName = "OpenFileDialog1"
        '
        'yfbrefresh
        '
        Me.yfbrefresh.Enabled = True
        Me.yfbrefresh.Interval = 10000
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 133)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbdfb)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1390, 515)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dghis)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1390, 260)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "已发布"
        '
        'dghis
        '
        Me.dghis.AllowUserToAddRows = False
        Me.dghis.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dghis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dghis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dghis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dghis.BackgroundColor = System.Drawing.Color.White
        Me.dghis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dghis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dghis.DefaultCellStyle = DataGridViewCellStyle10
        Me.dghis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dghis.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dghis.Location = New System.Drawing.Point(3, 24)
        Me.dghis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dghis.MultiSelect = False
        Me.dghis.Name = "dghis"
        Me.dghis.ReadOnly = True
        Me.dghis.RowHeadersVisible = False
        Me.dghis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dghis.Size = New System.Drawing.Size(1384, 232)
        Me.dghis.TabIndex = 18
        '
        'WMS_发运任务
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.gbop)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WMS_发运任务"
        Me.Size = New System.Drawing.Size(1390, 648)
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbyfb.ResumeLayout(False)
        CType(Me.dgreject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdfb.ResumeLayout(False)
        CType(Me.dgimport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        CType(Me.numbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dghis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents gbyfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgyfb As System.Windows.Forms.DataGridView
    Friend WithEvents byfbrefresh As System.Windows.Forms.Button
    Friend WithEvents gbdfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdfb As System.Windows.Forms.DataGridView
    Friend WithEvents bpublic As System.Windows.Forms.Button
    Friend WithEvents bimport As System.Windows.Forms.Button
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents numbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bsc As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents lpackage As System.Windows.Forms.Label
    Friend WithEvents linnernum As System.Windows.Forms.Label
    Friend WithEvents lsl As System.Windows.Forms.Label
    Friend WithEvents lxs As System.Windows.Forms.Label
    Friend WithEvents lyjdhrq As System.Windows.Forms.Label
    Friend WithEvents lss As System.Windows.Forms.Label
    Friend WithEvents llj As System.Windows.Forms.Label
    Friend WithEvents lddh As System.Windows.Forms.Label
    Friend WithEvents lkh As System.Windows.Forms.Label
    Friend WithEvents dgreject As System.Windows.Forms.DataGridView
    Friend WithEvents lunit As System.Windows.Forms.Label
    Friend WithEvents linnerunit As System.Windows.Forms.Label
    Friend WithEvents trefresh As System.Windows.Forms.Timer
    Friend WithEvents open_excel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgimport As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents yfbrefresh As System.Windows.Forms.Timer
    Friend WithEvents lrefreshmsg As System.Windows.Forms.Label
    Friend WithEvents ltrans As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dghis As System.Windows.Forms.DataGridView
    Friend WithEvents cbsp As System.Windows.Forms.ComboBox
    Friend WithEvents cbpartno As System.Windows.Forms.ComboBox
    Friend WithEvents cbcustomer As System.Windows.Forms.ComboBox
    Friend WithEvents torderno As System.Windows.Forms.TextBox
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents lpartno As System.Windows.Forms.Label
    Friend WithEvents numea As System.Windows.Forms.TextBox

End Class
