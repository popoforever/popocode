<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barcode
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
        Me.bprint = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.gbbarcode = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bcx = New System.Windows.Forms.Button()
        Me.ltype = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.listtemp = New System.Windows.Forms.ListBox()
        Me.dgbarcode = New System.Windows.Forms.DataGridView()
        Me.gborder = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgorder = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.breset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.关闭ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbkcd = New System.Windows.Forms.ComboBox()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbbarcode.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gborder.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bprint
        '
        Me.bprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.bprint.FlatAppearance.BorderSize = 0
        Me.bprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprint.Location = New System.Drawing.Point(12, 5)
        Me.bprint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bprint.Name = "bprint"
        Me.bprint.Size = New System.Drawing.Size(98, 39)
        Me.bprint.TabIndex = 8
        Me.bprint.Text = "条码打印"
        Me.bprint.UseVisualStyleBackColor = False
        Me.bprint.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(959, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 25)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(3, 137)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(785, 218)
        Me.dgtemp.TabIndex = 11
        Me.dgtemp.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(129, 11)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(391, 27)
        Me.ProgressBar1.TabIndex = 13
        '
        'gbbarcode
        '
        Me.gbbarcode.Controls.Add(Me.Panel3)
        Me.gbbarcode.Controls.Add(Me.Panel4)
        Me.gbbarcode.Location = New System.Drawing.Point(316, 13)
        Me.gbbarcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbbarcode.Name = "gbbarcode"
        Me.gbbarcode.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbbarcode.Size = New System.Drawing.Size(1008, 627)
        Me.gbbarcode.TabIndex = 17
        Me.gbbarcode.TabStop = False
        Me.gbbarcode.Text = "条码列表"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bprint)
        Me.Panel3.Controls.Add(Me.bcx)
        Me.Panel3.Controls.Add(Me.ltype)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1002, 51)
        Me.Panel3.TabIndex = 22
        '
        'bcx
        '
        Me.bcx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcx.Location = New System.Drawing.Point(574, 8)
        Me.bcx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bcx.Name = "bcx"
        Me.bcx.Size = New System.Drawing.Size(72, 33)
        Me.bcx.TabIndex = 21
        Me.bcx.Text = "查询"
        Me.bcx.UseVisualStyleBackColor = False
        Me.bcx.Visible = False
        '
        'ltype
        '
        Me.ltype.AutoSize = True
        Me.ltype.Location = New System.Drawing.Point(720, 15)
        Me.ltype.Name = "ltype"
        Me.ltype.Size = New System.Drawing.Size(79, 20)
        Me.ltype.TabIndex = 18
        Me.ltype.Text = "新条码打印"
        Me.ltype.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.listtemp)
        Me.Panel4.Controls.Add(Me.dgtemp)
        Me.Panel4.Controls.Add(Me.dgbarcode)
        Me.Panel4.Location = New System.Drawing.Point(15, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(949, 381)
        Me.Panel4.TabIndex = 23
        '
        'listtemp
        '
        Me.listtemp.FormattingEnabled = True
        Me.listtemp.ItemHeight = 19
        Me.listtemp.Location = New System.Drawing.Point(339, 137)
        Me.listtemp.Name = "listtemp"
        Me.listtemp.Size = New System.Drawing.Size(182, 137)
        Me.listtemp.TabIndex = 21
        Me.listtemp.Visible = False
        '
        'dgbarcode
        '
        Me.dgbarcode.AllowUserToAddRows = False
        Me.dgbarcode.AllowUserToDeleteRows = False
        Me.dgbarcode.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgbarcode.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgbarcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbarcode.BackgroundColor = System.Drawing.Color.White
        Me.dgbarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgbarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbarcode.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgbarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgbarcode.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgbarcode.Location = New System.Drawing.Point(0, 0)
        Me.dgbarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgbarcode.MultiSelect = False
        Me.dgbarcode.Name = "dgbarcode"
        Me.dgbarcode.ReadOnly = True
        Me.dgbarcode.RowHeadersVisible = False
        Me.dgbarcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgbarcode.Size = New System.Drawing.Size(949, 381)
        Me.dgbarcode.TabIndex = 20
        '
        'gborder
        '
        Me.gborder.Controls.Add(Me.Panel2)
        Me.gborder.Controls.Add(Me.Panel1)
        Me.gborder.Dock = System.Windows.Forms.DockStyle.Left
        Me.gborder.Location = New System.Drawing.Point(0, 0)
        Me.gborder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gborder.Name = "gborder"
        Me.gborder.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gborder.Size = New System.Drawing.Size(310, 770)
        Me.gborder.TabIndex = 1
        Me.gborder.TabStop = False
        Me.gborder.Text = "订单选择"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgorder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 693)
        Me.Panel2.TabIndex = 22
        '
        'dgorder
        '
        Me.dgorder.AllowUserToAddRows = False
        Me.dgorder.AllowUserToDeleteRows = False
        Me.dgorder.AllowUserToResizeColumns = False
        Me.dgorder.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgorder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgorder.BackgroundColor = System.Drawing.Color.White
        Me.dgorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgorder.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgorder.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgorder.Location = New System.Drawing.Point(0, 0)
        Me.dgorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgorder.MultiSelect = False
        Me.dgorder.Name = "dgorder"
        Me.dgorder.ReadOnly = True
        Me.dgorder.RowHeadersVisible = False
        Me.dgorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgorder.Size = New System.Drawing.Size(304, 693)
        Me.dgorder.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbkcd)
        Me.Panel1.Controls.Add(Me.breset)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 51)
        Me.Panel1.TabIndex = 22
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.White
        Me.breset.FlatAppearance.BorderSize = 0
        Me.breset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.breset.Location = New System.Drawing.Point(229, 7)
        Me.breset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(54, 36)
        Me.breset.TabIndex = 21
        Me.breset.Text = "刷新"
        Me.breset.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "状态筛选："
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关闭ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 28)
        '
        '关闭ToolStripMenuItem
        '
        Me.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem"
        Me.关闭ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.关闭ToolStripMenuItem.Text = "关闭"
        '
        'cbkcd
        '
        Me.cbkcd.FormattingEnabled = True
        Me.cbkcd.Location = New System.Drawing.Point(88, 13)
        Me.cbkcd.Name = "cbkcd"
        Me.cbkcd.Size = New System.Drawing.Size(135, 27)
        Me.cbkcd.TabIndex = 22
        '
        'barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gborder)
        Me.Controls.Add(Me.gbbarcode)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "barcode"
        Me.Size = New System.Drawing.Size(1324, 770)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbbarcode.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gborder.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bprint As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents gbbarcode As System.Windows.Forms.GroupBox
    Friend WithEvents ltype As System.Windows.Forms.Label
    Friend WithEvents gborder As System.Windows.Forms.GroupBox
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bcx As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgbarcode As System.Windows.Forms.DataGridView
    Friend WithEvents dgorder As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 关闭ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents listtemp As System.Windows.Forms.ListBox
    Friend WithEvents cbkcd As System.Windows.Forms.ComboBox

End Class
