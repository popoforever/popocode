<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 盘点任务
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.dgarea = New System.Windows.Forms.DataGridView()
        Me.dgpandian = New System.Windows.Forms.DataGridView()
        Me.bkw = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.bkwqd = New System.Windows.Forms.Button()
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.blj = New System.Windows.Forms.Button()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.dgpart2 = New System.Windows.Forms.DataGridView()
        Me.bljqd = New System.Windows.Forms.Button()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbtask = New System.Windows.Forms.GroupBox()
        Me.gbdetail = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.取消盘点单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgarea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpandian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        Me.gbtask.SuspendLayout()
        Me.gbdetail.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgpart
        '
        Me.dgpart.AllowUserToAddRows = False
        Me.dgpart.AllowUserToDeleteRows = False
        Me.dgpart.AllowUserToResizeRows = False
        Me.dgpart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpart.BackgroundColor = System.Drawing.Color.White
        Me.dgpart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgpart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpart.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgpart.Enabled = False
        Me.dgpart.Location = New System.Drawing.Point(548, 55)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(387, 180)
        Me.dgpart.TabIndex = 0
        '
        'dgarea
        '
        Me.dgarea.AllowUserToAddRows = False
        Me.dgarea.AllowUserToDeleteRows = False
        Me.dgarea.AllowUserToResizeColumns = False
        Me.dgarea.AllowUserToResizeRows = False
        Me.dgarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgarea.BackgroundColor = System.Drawing.Color.White
        Me.dgarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgarea.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgarea.Location = New System.Drawing.Point(6, 55)
        Me.dgarea.Name = "dgarea"
        Me.dgarea.RowHeadersVisible = False
        Me.dgarea.RowTemplate.Height = 24
        Me.dgarea.Size = New System.Drawing.Size(361, 180)
        Me.dgarea.TabIndex = 2
        '
        'dgpandian
        '
        Me.dgpandian.AllowUserToAddRows = False
        Me.dgpandian.AllowUserToDeleteRows = False
        Me.dgpandian.AllowUserToResizeRows = False
        Me.dgpandian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpandian.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgpandian.BackgroundColor = System.Drawing.Color.White
        Me.dgpandian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgpandian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpandian.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgpandian.Location = New System.Drawing.Point(4, 56)
        Me.dgpandian.MultiSelect = False
        Me.dgpandian.Name = "dgpandian"
        Me.dgpandian.ReadOnly = True
        Me.dgpandian.RowHeadersVisible = False
        Me.dgpandian.RowTemplate.Height = 24
        Me.dgpandian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpandian.Size = New System.Drawing.Size(520, 286)
        Me.dgpandian.TabIndex = 2
        '
        'bkw
        '
        Me.bkw.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bkw.Location = New System.Drawing.Point(394, 142)
        Me.bkw.Name = "bkw"
        Me.bkw.Size = New System.Drawing.Size(127, 34)
        Me.bkw.TabIndex = 3
        Me.bkw.Text = "按库位盘点"
        Me.bkw.UseVisualStyleBackColor = False
        Me.bkw.Visible = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.AllowUserToDeleteRows = False
        Me.dgtemp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(989, 413)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(387, 180)
        Me.dgtemp.TabIndex = 0
        Me.dgtemp.Visible = False
        '
        'bkwqd
        '
        Me.bkwqd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bkwqd.Location = New System.Drawing.Point(850, 14)
        Me.bkwqd.Name = "bkwqd"
        Me.bkwqd.Size = New System.Drawing.Size(91, 34)
        Me.bkwqd.TabIndex = 3
        Me.bkwqd.Text = "确定库位"
        Me.bkwqd.UseVisualStyleBackColor = True
        Me.bkwqd.Visible = False
        '
        'dgdetail
        '
        Me.dgdetail.AllowUserToAddRows = False
        Me.dgdetail.AllowUserToDeleteRows = False
        Me.dgdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgdetail.BackgroundColor = System.Drawing.Color.White
        Me.dgdetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgdetail.Location = New System.Drawing.Point(6, 56)
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.ReadOnly = True
        Me.dgdetail.RowHeadersVisible = False
        Me.dgdetail.RowTemplate.Height = 24
        Me.dgdetail.Size = New System.Drawing.Size(849, 286)
        Me.dgdetail.TabIndex = 2
        '
        'blj
        '
        Me.blj.BackColor = System.Drawing.Color.WhiteSmoke
        Me.blj.Enabled = False
        Me.blj.Location = New System.Drawing.Point(394, 55)
        Me.blj.Name = "blj"
        Me.blj.Size = New System.Drawing.Size(127, 34)
        Me.blj.TabIndex = 3
        Me.blj.Text = "按零件盘点"
        Me.blj.UseVisualStyleBackColor = False
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(591, 20)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(132, 22)
        Me.tsearch.TabIndex = 5
        Me.tsearch.Visible = False
        '
        'dgpart2
        '
        Me.dgpart2.AllowUserToAddRows = False
        Me.dgpart2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpart2.BackgroundColor = System.Drawing.Color.White
        Me.dgpart2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgpart2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpart2.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgpart2.Enabled = False
        Me.dgpart2.Location = New System.Drawing.Point(962, 55)
        Me.dgpart2.Name = "dgpart2"
        Me.dgpart2.ReadOnly = True
        Me.dgpart2.RowHeadersVisible = False
        Me.dgpart2.RowTemplate.Height = 24
        Me.dgpart2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart2.Size = New System.Drawing.Size(387, 184)
        Me.dgpart2.TabIndex = 0
        '
        'bljqd
        '
        Me.bljqd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bljqd.Enabled = False
        Me.bljqd.Location = New System.Drawing.Point(1258, 15)
        Me.bljqd.Name = "bljqd"
        Me.bljqd.Size = New System.Drawing.Size(91, 34)
        Me.bljqd.TabIndex = 3
        Me.bljqd.Text = "确定零件"
        Me.bljqd.UseVisualStyleBackColor = False
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Controls.Add(Me.dgarea)
        Me.gbop.Controls.Add(Me.bljqd)
        Me.gbop.Controls.Add(Me.dgpart)
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.dgpart2)
        Me.gbop.Controls.Add(Me.bkw)
        Me.gbop.Controls.Add(Me.blj)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1500, 254)
        Me.gbop.TabIndex = 17
        Me.gbop.TabStop = False
        Me.gbop.Text = "创建盘点单"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "搜索:"
        '
        'gbtask
        '
        Me.gbtask.Controls.Add(Me.dgpandian)
        Me.gbtask.Location = New System.Drawing.Point(6, 269)
        Me.gbtask.Name = "gbtask"
        Me.gbtask.Size = New System.Drawing.Size(530, 365)
        Me.gbtask.TabIndex = 18
        Me.gbtask.TabStop = False
        Me.gbtask.Text = "盘点任务"
        '
        'gbdetail
        '
        Me.gbdetail.Controls.Add(Me.dgdetail)
        Me.gbdetail.Location = New System.Drawing.Point(542, 269)
        Me.gbdetail.Name = "gbdetail"
        Me.gbdetail.Size = New System.Drawing.Size(895, 376)
        Me.gbdetail.TabIndex = 19
        Me.gbdetail.TabStop = False
        Me.gbdetail.Text = "明细信息"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.取消盘点单ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 28)
        '
        '取消盘点单ToolStripMenuItem
        '
        Me.取消盘点单ToolStripMenuItem.Name = "取消盘点单ToolStripMenuItem"
        Me.取消盘点单ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.取消盘点单ToolStripMenuItem.Text = "取消盘点单"
        '
        '盘点任务
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgtemp)
        Me.Controls.Add(Me.bkwqd)
        Me.Controls.Add(Me.gbop)
        Me.Controls.Add(Me.gbtask)
        Me.Controls.Add(Me.gbdetail)
        Me.Name = "盘点任务"
        Me.Size = New System.Drawing.Size(1500, 648)
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgarea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpandian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.gbtask.ResumeLayout(False)
        Me.gbdetail.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents dgarea As System.Windows.Forms.DataGridView
    Friend WithEvents dgpandian As System.Windows.Forms.DataGridView
    Friend WithEvents bkw As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents bkwqd As System.Windows.Forms.Button
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents blj As System.Windows.Forms.Button
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgpart2 As System.Windows.Forms.DataGridView
    Friend WithEvents bljqd As System.Windows.Forms.Button
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents gbtask As System.Windows.Forms.GroupBox
    Friend WithEvents gbdetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 取消盘点单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
