<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_事务报表
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
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.ldt2 = New System.Windows.Forms.Label()
        Me.ldt1 = New System.Windows.Forms.Label()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.badd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbsum = New System.Windows.Forms.GroupBox()
        Me.dgsum = New System.Windows.Forms.DataGridView()
        Me.gbdetail = New System.Windows.Forms.GroupBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.menudgdetail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.导出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menudgsum = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbop = New System.Windows.Forms.ComboBox()
        Me.cbpartno = New System.Windows.Forms.ComboBox()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.gbop.SuspendLayout()
        Me.gbsum.SuspendLayout()
        CType(Me.dgsum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetail.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menudgdetail.SuspendLayout()
        Me.menudgsum.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.cbpartno)
        Me.gbop.Controls.Add(Me.cbop)
        Me.gbop.Controls.Add(Me.ldt2)
        Me.gbop.Controls.Add(Me.ldt1)
        Me.gbop.Controls.Add(Me.dt2)
        Me.gbop.Controls.Add(Me.dt1)
        Me.gbop.Controls.Add(Me.Label2)
        Me.gbop.Controls.Add(Me.badd)
        Me.gbop.Controls.Add(Me.Label5)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label6)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 151)
        Me.gbop.TabIndex = 6
        Me.gbop.TabStop = False
        Me.gbop.Text = "事务查询"
        '
        'ldt2
        '
        Me.ldt2.AutoSize = True
        Me.ldt2.Location = New System.Drawing.Point(417, 120)
        Me.ldt2.Name = "ldt2"
        Me.ldt2.Size = New System.Drawing.Size(51, 17)
        Me.ldt2.TabIndex = 25
        Me.ldt2.Text = "Label4"
        Me.ldt2.Visible = False
        '
        'ldt1
        '
        Me.ldt1.AutoSize = True
        Me.ldt1.Location = New System.Drawing.Point(122, 120)
        Me.ldt1.Name = "ldt1"
        Me.ldt1.Size = New System.Drawing.Size(51, 17)
        Me.ldt1.TabIndex = 25
        Me.ldt1.Text = "Label4"
        Me.ldt1.Visible = False
        '
        'dt2
        '
        Me.dt2.Location = New System.Drawing.Point(473, 80)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(178, 22)
        Me.dt2.TabIndex = 23
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(125, 80)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(178, 22)
        Me.dt1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "结束日期："
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(776, 73)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(72, 28)
        Me.badd.TabIndex = 21
        Me.badd.Text = "查询"
        Me.badd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "开始日期："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(773, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "搜索："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "零件："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "事务："
        '
        'gbsum
        '
        Me.gbsum.Controls.Add(Me.dgsum)
        Me.gbsum.Location = New System.Drawing.Point(911, 161)
        Me.gbsum.Name = "gbsum"
        Me.gbsum.Size = New System.Drawing.Size(303, 510)
        Me.gbsum.TabIndex = 26
        Me.gbsum.TabStop = False
        Me.gbsum.Text = "汇总"
        '
        'dgsum
        '
        Me.dgsum.AllowUserToAddRows = False
        Me.dgsum.AllowUserToDeleteRows = False
        Me.dgsum.AllowUserToResizeColumns = False
        Me.dgsum.AllowUserToResizeRows = False
        Me.dgsum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgsum.BackgroundColor = System.Drawing.Color.White
        Me.dgsum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgsum.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgsum.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgsum.Location = New System.Drawing.Point(26, 22)
        Me.dgsum.Margin = New System.Windows.Forms.Padding(4)
        Me.dgsum.Name = "dgsum"
        Me.dgsum.ReadOnly = True
        Me.dgsum.RowHeadersVisible = False
        Me.dgsum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgsum.Size = New System.Drawing.Size(258, 380)
        Me.dgsum.TabIndex = 18
        '
        'gbdetail
        '
        Me.gbdetail.Controls.Add(Me.dgtemp)
        Me.gbdetail.Controls.Add(Me.dgdetail)
        Me.gbdetail.Location = New System.Drawing.Point(3, 250)
        Me.gbdetail.Name = "gbdetail"
        Me.gbdetail.Size = New System.Drawing.Size(902, 421)
        Me.gbdetail.TabIndex = 25
        Me.gbdetail.TabStop = False
        Me.gbdetail.Text = "明细"
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
        'dgdetail
        '
        Me.dgdetail.AllowUserToAddRows = False
        Me.dgdetail.AllowUserToDeleteRows = False
        Me.dgdetail.AllowUserToResizeRows = False
        Me.dgdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgdetail.BackgroundColor = System.Drawing.Color.White
        Me.dgdetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdetail.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdetail.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgdetail.Location = New System.Drawing.Point(24, 22)
        Me.dgdetail.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.ReadOnly = True
        Me.dgdetail.RowHeadersVisible = False
        Me.dgdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdetail.Size = New System.Drawing.Size(839, 389)
        Me.dgdetail.TabIndex = 18
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
        Me.dgpart.Location = New System.Drawing.Point(420, 173)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(219, 31)
        Me.dgpart.TabIndex = 26
        Me.dgpart.Visible = False
        '
        'menudgdetail
        '
        Me.menudgdetail.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menudgdetail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导出ToolStripMenuItem})
        Me.menudgdetail.Name = "menudgdetail"
        Me.menudgdetail.Size = New System.Drawing.Size(109, 28)
        '
        '导出ToolStripMenuItem
        '
        Me.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem"
        Me.导出ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.导出ToolStripMenuItem.Text = "导出"
        '
        'menudgsum
        '
        Me.menudgsum.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menudgsum.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.menudgsum.Name = "menudgdetail"
        Me.menudgsum.Size = New System.Drawing.Size(109, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 24)
        Me.ToolStripMenuItem1.Text = "导出"
        '
        'cbop
        '
        Me.cbop.FormattingEnabled = True
        Me.cbop.Location = New System.Drawing.Point(125, 36)
        Me.cbop.Name = "cbop"
        Me.cbop.Size = New System.Drawing.Size(178, 24)
        Me.cbop.TabIndex = 26
        '
        'cbpartno
        '
        Me.cbpartno.FormattingEnabled = True
        Me.cbpartno.Location = New System.Drawing.Point(473, 35)
        Me.cbpartno.Name = "cbpartno"
        Me.cbpartno.Size = New System.Drawing.Size(178, 24)
        Me.cbpartno.TabIndex = 27
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(842, 37)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(164, 22)
        Me.tsearch.TabIndex = 28
        '
        'WMS_事务报表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgpart)
        Me.Controls.Add(Me.gbsum)
        Me.Controls.Add(Me.gbop)
        Me.Controls.Add(Me.gbdetail)
        Me.Name = "WMS_事务报表"
        Me.Size = New System.Drawing.Size(1324, 648)
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.gbsum.ResumeLayout(False)
        CType(Me.dgsum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetail.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menudgdetail.ResumeLayout(False)
        Me.menudgsum.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbsum As System.Windows.Forms.GroupBox
    Friend WithEvents dgsum As System.Windows.Forms.DataGridView
    Friend WithEvents gbdetail As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ldt2 As System.Windows.Forms.Label
    Friend WithEvents ldt1 As System.Windows.Forms.Label
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents menudgdetail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 导出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menudgsum As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbop As System.Windows.Forms.ComboBox
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents cbpartno As System.Windows.Forms.ComboBox

End Class
