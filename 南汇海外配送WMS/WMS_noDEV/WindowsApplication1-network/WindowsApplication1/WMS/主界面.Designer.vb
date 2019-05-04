<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 主界面
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(主界面))
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picwmsorder = New System.Windows.Forms.PictureBox()
        Me.lbelong = New System.Windows.Forms.Label()
        Me.pbuser = New System.Windows.Forms.PictureBox()
        Me.lyh = New System.Windows.Forms.Label()
        Me.bquit = New System.Windows.Forms.Button()
        Me.bmin = New System.Windows.Forms.Button()
        Me.lversion = New System.Windows.Forms.Label()
        Me.uid = New System.Windows.Forms.Label()
        Me.ptopmenu = New System.Windows.Forms.Panel()
        Me.ppicgworder = New System.Windows.Forms.Panel()
        Me.ldd = New System.Windows.Forms.Label()
        Me.picgworder = New System.Windows.Forms.PictureBox()
        Me.ppicreport = New System.Windows.Forms.Panel()
        Me.lbb = New System.Windows.Forms.Label()
        Me.picreport = New System.Windows.Forms.PictureBox()
        Me.ppicmes = New System.Windows.Forms.Panel()
        Me.lxccz = New System.Windows.Forms.Label()
        Me.picmes = New System.Windows.Forms.PictureBox()
        Me.ppicorder = New System.Windows.Forms.Panel()
        Me.lgdgl = New System.Windows.Forms.Label()
        Me.picorder = New System.Windows.Forms.PictureBox()
        Me.ppicdata = New System.Windows.Forms.Panel()
        Me.lzsj = New System.Windows.Forms.Label()
        Me.picdata = New System.Windows.Forms.PictureBox()
        Me.Panelleft = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.buttonlabel = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mainlabel = New System.Windows.Forms.Label()
        Me.pmsg = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lan = New System.Windows.Forms.Label()
        Me.cblan = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.切换用户ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pleftlogo = New System.Windows.Forms.Panel()
        Me.lfactory = New System.Windows.Forms.Label()
        Me.llogin = New System.Windows.Forms.Label()
        Me.dgright = New System.Windows.Forms.DataGridView()
        Me.pback = New System.Windows.Forms.PictureBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.lfydrefresh = New System.Windows.Forms.Label()
        Me.lhwddh = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.paneltop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picwmsorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ptopmenu.SuspendLayout()
        Me.ppicgworder.SuspendLayout()
        CType(Me.picgworder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppicreport.SuspendLayout()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppicmes.SuspendLayout()
        CType(Me.picmes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppicorder.SuspendLayout()
        CType(Me.picorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ppicdata.SuspendLayout()
        CType(Me.picdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelleft.SuspendLayout()
        Me.pmsg.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pleftlogo.SuspendLayout()
        CType(Me.dgright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.paneltop.Controls.Add(Me.PictureBox1)
        Me.paneltop.Controls.Add(Me.picwmsorder)
        Me.paneltop.Controls.Add(Me.lbelong)
        Me.paneltop.Controls.Add(Me.pbuser)
        Me.paneltop.Controls.Add(Me.lyh)
        Me.paneltop.Controls.Add(Me.bquit)
        Me.paneltop.Controls.Add(Me.bmin)
        Me.paneltop.Controls.Add(Me.lversion)
        Me.paneltop.Controls.Add(Me.uid)
        Me.paneltop.Controls.Add(Me.ptopmenu)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(1434, 100)
        Me.paneltop.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'picwmsorder
        '
        Me.picwmsorder.Location = New System.Drawing.Point(1349, 80)
        Me.picwmsorder.Name = "picwmsorder"
        Me.picwmsorder.Size = New System.Drawing.Size(99, 104)
        Me.picwmsorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picwmsorder.TabIndex = 0
        Me.picwmsorder.TabStop = False
        '
        'lbelong
        '
        Me.lbelong.AutoSize = True
        Me.lbelong.ForeColor = System.Drawing.Color.White
        Me.lbelong.Location = New System.Drawing.Point(105, 61)
        Me.lbelong.Name = "lbelong"
        Me.lbelong.Size = New System.Drawing.Size(54, 20)
        Me.lbelong.TabIndex = 7
        Me.lbelong.Text = "所属："
        '
        'pbuser
        '
        Me.pbuser.ErrorImage = Nothing
        Me.pbuser.Location = New System.Drawing.Point(12, 46)
        Me.pbuser.Name = "pbuser"
        Me.pbuser.Size = New System.Drawing.Size(200, 46)
        Me.pbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbuser.TabIndex = 21
        Me.pbuser.TabStop = False
        '
        'lyh
        '
        Me.lyh.AutoSize = True
        Me.lyh.ForeColor = System.Drawing.Color.White
        Me.lyh.Location = New System.Drawing.Point(105, 22)
        Me.lyh.Name = "lyh"
        Me.lyh.Size = New System.Drawing.Size(84, 20)
        Me.lyh.TabIndex = 7
        Me.lyh.Text = "当前用户："
        '
        'bquit
        '
        Me.bquit.FlatAppearance.BorderSize = 0
        Me.bquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bquit.ForeColor = System.Drawing.Color.White
        Me.bquit.Location = New System.Drawing.Point(1361, 3)
        Me.bquit.Name = "bquit"
        Me.bquit.Size = New System.Drawing.Size(59, 41)
        Me.bquit.TabIndex = 5
        Me.bquit.Text = "关闭"
        Me.bquit.UseVisualStyleBackColor = True
        '
        'bmin
        '
        Me.bmin.FlatAppearance.BorderSize = 0
        Me.bmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bmin.ForeColor = System.Drawing.Color.White
        Me.bmin.Location = New System.Drawing.Point(1351, 40)
        Me.bmin.Name = "bmin"
        Me.bmin.Size = New System.Drawing.Size(71, 41)
        Me.bmin.TabIndex = 5
        Me.bmin.Text = "最小化"
        Me.bmin.UseVisualStyleBackColor = True
        '
        'lversion
        '
        Me.lversion.AutoSize = True
        Me.lversion.ForeColor = System.Drawing.Color.White
        Me.lversion.Location = New System.Drawing.Point(12, 82)
        Me.lversion.Name = "lversion"
        Me.lversion.Size = New System.Drawing.Size(62, 20)
        Me.lversion.TabIndex = 3
        Me.lversion.Text = "version"
        '
        'uid
        '
        Me.uid.AutoSize = True
        Me.uid.Location = New System.Drawing.Point(34, 99)
        Me.uid.Name = "uid"
        Me.uid.Size = New System.Drawing.Size(54, 20)
        Me.uid.TabIndex = 3
        Me.uid.Text = "admin"
        '
        'ptopmenu
        '
        Me.ptopmenu.Controls.Add(Me.ppicgworder)
        Me.ptopmenu.Controls.Add(Me.ppicreport)
        Me.ptopmenu.Controls.Add(Me.ppicmes)
        Me.ptopmenu.Controls.Add(Me.ppicorder)
        Me.ptopmenu.Controls.Add(Me.ppicdata)
        Me.ptopmenu.Location = New System.Drawing.Point(305, 0)
        Me.ptopmenu.Name = "ptopmenu"
        Me.ptopmenu.Size = New System.Drawing.Size(1052, 100)
        Me.ptopmenu.TabIndex = 22
        '
        'ppicgworder
        '
        Me.ppicgworder.Controls.Add(Me.ldd)
        Me.ppicgworder.Controls.Add(Me.picgworder)
        Me.ppicgworder.Dock = System.Windows.Forms.DockStyle.Left
        Me.ppicgworder.Location = New System.Drawing.Point(800, 0)
        Me.ppicgworder.Name = "ppicgworder"
        Me.ppicgworder.Size = New System.Drawing.Size(200, 100)
        Me.ppicgworder.TabIndex = 25
        '
        'ldd
        '
        Me.ldd.AutoSize = True
        Me.ldd.ForeColor = System.Drawing.Color.White
        Me.ldd.Location = New System.Drawing.Point(64, 72)
        Me.ldd.Name = "ldd"
        Me.ldd.Size = New System.Drawing.Size(69, 20)
        Me.ldd.TabIndex = 16
        Me.ldd.Text = "海外订单"
        '
        'picgworder
        '
        Me.picgworder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picgworder.Image = CType(resources.GetObject("picgworder.Image"), System.Drawing.Image)
        Me.picgworder.Location = New System.Drawing.Point(0, 0)
        Me.picgworder.Name = "picgworder"
        Me.picgworder.Size = New System.Drawing.Size(200, 100)
        Me.picgworder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picgworder.TabIndex = 15
        Me.picgworder.TabStop = False
        '
        'ppicreport
        '
        Me.ppicreport.Controls.Add(Me.lbb)
        Me.ppicreport.Controls.Add(Me.picreport)
        Me.ppicreport.Dock = System.Windows.Forms.DockStyle.Left
        Me.ppicreport.Location = New System.Drawing.Point(600, 0)
        Me.ppicreport.Name = "ppicreport"
        Me.ppicreport.Size = New System.Drawing.Size(200, 100)
        Me.ppicreport.TabIndex = 24
        '
        'lbb
        '
        Me.lbb.AutoSize = True
        Me.lbb.ForeColor = System.Drawing.Color.White
        Me.lbb.Location = New System.Drawing.Point(78, 72)
        Me.lbb.Name = "lbb"
        Me.lbb.Size = New System.Drawing.Size(39, 20)
        Me.lbb.TabIndex = 17
        Me.lbb.Text = "报表"
        '
        'picreport
        '
        Me.picreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picreport.Image = CType(resources.GetObject("picreport.Image"), System.Drawing.Image)
        Me.picreport.Location = New System.Drawing.Point(0, 0)
        Me.picreport.Name = "picreport"
        Me.picreport.Size = New System.Drawing.Size(200, 100)
        Me.picreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picreport.TabIndex = 1
        Me.picreport.TabStop = False
        '
        'ppicmes
        '
        Me.ppicmes.Controls.Add(Me.lxccz)
        Me.ppicmes.Controls.Add(Me.picmes)
        Me.ppicmes.Dock = System.Windows.Forms.DockStyle.Left
        Me.ppicmes.Location = New System.Drawing.Point(400, 0)
        Me.ppicmes.Name = "ppicmes"
        Me.ppicmes.Size = New System.Drawing.Size(200, 100)
        Me.ppicmes.TabIndex = 23
        '
        'lxccz
        '
        Me.lxccz.AutoSize = True
        Me.lxccz.ForeColor = System.Drawing.Color.White
        Me.lxccz.Location = New System.Drawing.Point(63, 72)
        Me.lxccz.Name = "lxccz"
        Me.lxccz.Size = New System.Drawing.Size(69, 20)
        Me.lxccz.TabIndex = 18
        Me.lxccz.Text = "现场操作"
        '
        'picmes
        '
        Me.picmes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picmes.Image = CType(resources.GetObject("picmes.Image"), System.Drawing.Image)
        Me.picmes.Location = New System.Drawing.Point(0, 0)
        Me.picmes.Name = "picmes"
        Me.picmes.Size = New System.Drawing.Size(200, 100)
        Me.picmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picmes.TabIndex = 0
        Me.picmes.TabStop = False
        '
        'ppicorder
        '
        Me.ppicorder.Controls.Add(Me.lgdgl)
        Me.ppicorder.Controls.Add(Me.picorder)
        Me.ppicorder.Dock = System.Windows.Forms.DockStyle.Left
        Me.ppicorder.Location = New System.Drawing.Point(200, 0)
        Me.ppicorder.Name = "ppicorder"
        Me.ppicorder.Size = New System.Drawing.Size(200, 100)
        Me.ppicorder.TabIndex = 22
        '
        'lgdgl
        '
        Me.lgdgl.AutoSize = True
        Me.lgdgl.ForeColor = System.Drawing.Color.White
        Me.lgdgl.Location = New System.Drawing.Point(64, 72)
        Me.lgdgl.Name = "lgdgl"
        Me.lgdgl.Size = New System.Drawing.Size(69, 20)
        Me.lgdgl.TabIndex = 19
        Me.lgdgl.Text = "计划管理"
        '
        'picorder
        '
        Me.picorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picorder.Image = Global.WindowsApplication1.My.Resources.Resources.IE地球
        Me.picorder.Location = New System.Drawing.Point(0, 0)
        Me.picorder.Name = "picorder"
        Me.picorder.Size = New System.Drawing.Size(200, 100)
        Me.picorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picorder.TabIndex = 0
        Me.picorder.TabStop = False
        '
        'ppicdata
        '
        Me.ppicdata.Controls.Add(Me.lzsj)
        Me.ppicdata.Controls.Add(Me.picdata)
        Me.ppicdata.Dock = System.Windows.Forms.DockStyle.Left
        Me.ppicdata.Location = New System.Drawing.Point(0, 0)
        Me.ppicdata.Name = "ppicdata"
        Me.ppicdata.Size = New System.Drawing.Size(200, 100)
        Me.ppicdata.TabIndex = 21
        '
        'lzsj
        '
        Me.lzsj.AutoSize = True
        Me.lzsj.ForeColor = System.Drawing.Color.White
        Me.lzsj.Location = New System.Drawing.Point(60, 72)
        Me.lzsj.Name = "lzsj"
        Me.lzsj.Size = New System.Drawing.Size(84, 20)
        Me.lzsj.TabIndex = 20
        Me.lzsj.Text = "主数据维护"
        '
        'picdata
        '
        Me.picdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picdata.Image = Global.WindowsApplication1.My.Resources.Resources.IE地球
        Me.picdata.Location = New System.Drawing.Point(0, 0)
        Me.picdata.Name = "picdata"
        Me.picdata.Size = New System.Drawing.Size(200, 100)
        Me.picdata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picdata.TabIndex = 2
        Me.picdata.TabStop = False
        '
        'Panelleft
        '
        Me.Panelleft.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panelleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelleft.Controls.Add(Me.Button11)
        Me.Panelleft.Controls.Add(Me.Button10)
        Me.Panelleft.Controls.Add(Me.Button9)
        Me.Panelleft.Controls.Add(Me.buttonlabel)
        Me.Panelleft.Controls.Add(Me.Button8)
        Me.Panelleft.Controls.Add(Me.Button7)
        Me.Panelleft.Controls.Add(Me.Button6)
        Me.Panelleft.Controls.Add(Me.Button5)
        Me.Panelleft.Controls.Add(Me.Button4)
        Me.Panelleft.Controls.Add(Me.Button3)
        Me.Panelleft.Controls.Add(Me.Button2)
        Me.Panelleft.Controls.Add(Me.Button1)
        Me.Panelleft.Location = New System.Drawing.Point(6, 117)
        Me.Panelleft.Name = "Panelleft"
        Me.Panelleft.Size = New System.Drawing.Size(200, 738)
        Me.Panelleft.TabIndex = 1
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(0, 490)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(198, 49)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(0, 441)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(198, 49)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(0, 392)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(198, 49)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'buttonlabel
        '
        Me.buttonlabel.AutoSize = True
        Me.buttonlabel.Location = New System.Drawing.Point(5, 649)
        Me.buttonlabel.Name = "buttonlabel"
        Me.buttonlabel.Size = New System.Drawing.Size(57, 20)
        Me.buttonlabel.TabIndex = 4
        Me.buttonlabel.Text = "Label1"
        Me.buttonlabel.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 343)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(198, 49)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 294)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(198, 49)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 245)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(198, 49)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 196)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(198, 49)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(198, 49)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 49)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mainlabel
        '
        Me.mainlabel.AutoSize = True
        Me.mainlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.Location = New System.Drawing.Point(819, 127)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(86, 29)
        Me.mainlabel.TabIndex = 3
        Me.mainlabel.Text = "Label1"
        Me.mainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pmsg
        '
        Me.pmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.pmsg.Controls.Add(Me.Label1)
        Me.pmsg.Location = New System.Drawing.Point(714, 127)
        Me.pmsg.Name = "pmsg"
        Me.pmsg.Size = New System.Drawing.Size(364, 51)
        Me.pmsg.TabIndex = 12
        Me.pmsg.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "玩命加载中..."
        '
        'lan
        '
        Me.lan.AutoSize = True
        Me.lan.Location = New System.Drawing.Point(365, 142)
        Me.lan.Name = "lan"
        Me.lan.Size = New System.Drawing.Size(51, 20)
        Me.lan.TabIndex = 6
        Me.lan.Text = "Englis"
        Me.lan.Visible = False
        '
        'cblan
        '
        Me.cblan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblan.FormattingEnabled = True
        Me.cblan.Items.AddRange(New Object() {"English", "中文"})
        Me.cblan.Location = New System.Drawing.Point(508, 139)
        Me.cblan.Name = "cblan"
        Me.cblan.Size = New System.Drawing.Size(98, 28)
        Me.cblan.TabIndex = 7
        Me.cblan.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.切换用户ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 28)
        '
        '切换用户ToolStripMenuItem
        '
        Me.切换用户ToolStripMenuItem.Name = "切换用户ToolStripMenuItem"
        Me.切换用户ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.切换用户ToolStripMenuItem.Text = "切换用户"
        '
        'pleftlogo
        '
        Me.pleftlogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.pleftlogo.Controls.Add(Me.lfactory)
        Me.pleftlogo.Controls.Add(Me.llogin)
        Me.pleftlogo.Location = New System.Drawing.Point(7, 102)
        Me.pleftlogo.Name = "pleftlogo"
        Me.pleftlogo.Size = New System.Drawing.Size(200, 17)
        Me.pleftlogo.TabIndex = 13
        '
        'lfactory
        '
        Me.lfactory.AutoSize = True
        Me.lfactory.ForeColor = System.Drawing.Color.White
        Me.lfactory.Location = New System.Drawing.Point(206, 51)
        Me.lfactory.Name = "lfactory"
        Me.lfactory.Size = New System.Drawing.Size(37, 20)
        Me.lfactory.TabIndex = 3
        Me.lfactory.Text = "       "
        '
        'llogin
        '
        Me.llogin.AutoSize = True
        Me.llogin.ForeColor = System.Drawing.Color.White
        Me.llogin.Location = New System.Drawing.Point(240, 15)
        Me.llogin.Name = "llogin"
        Me.llogin.Size = New System.Drawing.Size(25, 20)
        Me.llogin.TabIndex = 3
        Me.llogin.Text = "    "
        '
        'dgright
        '
        Me.dgright.AllowUserToAddRows = False
        Me.dgright.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgright.Location = New System.Drawing.Point(579, 73)
        Me.dgright.Name = "dgright"
        Me.dgright.RowTemplate.Height = 24
        Me.dgright.Size = New System.Drawing.Size(50, 109)
        Me.dgright.TabIndex = 16
        Me.dgright.Visible = False
        '
        'pback
        '
        Me.pback.Image = Global.WindowsApplication1.My.Resources.Resources.welcomeWMS
        Me.pback.Location = New System.Drawing.Point(88, -38)
        Me.pback.Name = "pback"
        Me.pback.Size = New System.Drawing.Size(397, 258)
        Me.pback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pback.TabIndex = 0
        Me.pback.TabStop = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(644, 73)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(50, 109)
        Me.dgtemp.TabIndex = 15
        Me.dgtemp.Visible = False
        '
        'lfydrefresh
        '
        Me.lfydrefresh.AutoSize = True
        Me.lfydrefresh.Location = New System.Drawing.Point(329, 234)
        Me.lfydrefresh.Name = "lfydrefresh"
        Me.lfydrefresh.Size = New System.Drawing.Size(21, 20)
        Me.lfydrefresh.TabIndex = 15
        Me.lfydrefresh.Text = "N"
        Me.lfydrefresh.Visible = False
        '
        'lhwddh
        '
        Me.lhwddh.AutoSize = True
        Me.lhwddh.Location = New System.Drawing.Point(329, 196)
        Me.lhwddh.Name = "lhwddh"
        Me.lhwddh.Size = New System.Drawing.Size(21, 20)
        Me.lhwddh.TabIndex = 16
        Me.lhwddh.Text = "N"
        Me.lhwddh.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(488, 196)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(832, 297)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pback)
        Me.TabPage1.Controls.Add(Me.dgright)
        Me.TabPage1.Controls.Add(Me.dgtemp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(824, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 67)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        '主界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1434, 867)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lhwddh)
        Me.Controls.Add(Me.lfydrefresh)
        Me.Controls.Add(Me.Panelleft)
        Me.Controls.Add(Me.pleftlogo)
        Me.Controls.Add(Me.pmsg)
        Me.Controls.Add(Me.cblan)
        Me.Controls.Add(Me.lan)
        Me.Controls.Add(Me.mainlabel)
        Me.Controls.Add(Me.paneltop)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "主界面"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main v1.03"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picwmsorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ptopmenu.ResumeLayout(False)
        Me.ppicgworder.ResumeLayout(False)
        Me.ppicgworder.PerformLayout()
        CType(Me.picgworder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppicreport.ResumeLayout(False)
        Me.ppicreport.PerformLayout()
        CType(Me.picreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppicmes.ResumeLayout(False)
        Me.ppicmes.PerformLayout()
        CType(Me.picmes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppicorder.ResumeLayout(False)
        Me.ppicorder.PerformLayout()
        CType(Me.picorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ppicdata.ResumeLayout(False)
        Me.ppicdata.PerformLayout()
        CType(Me.picdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelleft.ResumeLayout(False)
        Me.Panelleft.PerformLayout()
        Me.pmsg.ResumeLayout(False)
        Me.pmsg.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pleftlogo.ResumeLayout(False)
        Me.pleftlogo.PerformLayout()
        CType(Me.dgright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paneltop As System.Windows.Forms.Panel
    Friend WithEvents Panelleft As System.Windows.Forms.Panel
    Friend WithEvents picorder As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents mainlabel As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents picreport As System.Windows.Forms.PictureBox
    Friend WithEvents picdata As System.Windows.Forms.PictureBox
    Friend WithEvents buttonlabel As System.Windows.Forms.Label
    Friend WithEvents picwmsorder As System.Windows.Forms.PictureBox
    Friend WithEvents uid As System.Windows.Forms.Label
    Friend WithEvents picmes As System.Windows.Forms.PictureBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents bquit As System.Windows.Forms.Button
    Friend WithEvents lan As System.Windows.Forms.Label
    Friend WithEvents cblan As System.Windows.Forms.ComboBox
    Friend WithEvents lversion As System.Windows.Forms.Label
    Friend WithEvents bmin As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 切换用户ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pmsg As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pleftlogo As System.Windows.Forms.Panel
    Friend WithEvents llogin As System.Windows.Forms.Label
    Friend WithEvents lyh As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pback As System.Windows.Forms.PictureBox
    Friend WithEvents ldd As System.Windows.Forms.Label
    Friend WithEvents lbb As System.Windows.Forms.Label
    Friend WithEvents lxccz As System.Windows.Forms.Label
    Friend WithEvents lgdgl As System.Windows.Forms.Label
    Friend WithEvents lzsj As System.Windows.Forms.Label
    Friend WithEvents picgworder As System.Windows.Forms.PictureBox
    Friend WithEvents pbuser As System.Windows.Forms.PictureBox
    Friend WithEvents dgright As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents lfactory As System.Windows.Forms.Label
    Friend WithEvents lbelong As System.Windows.Forms.Label
    Friend WithEvents lfydrefresh As System.Windows.Forms.Label
    Friend WithEvents ptopmenu As System.Windows.Forms.Panel
    Friend WithEvents ppicdata As System.Windows.Forms.Panel
    Friend WithEvents ppicgworder As System.Windows.Forms.Panel
    Friend WithEvents ppicreport As System.Windows.Forms.Panel
    Friend WithEvents ppicmes As System.Windows.Forms.Panel
    Friend WithEvents ppicorder As System.Windows.Forms.Panel
    Friend WithEvents lhwddh As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
