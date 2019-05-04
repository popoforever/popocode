<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_库位
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
        Me.open_excel = New System.Windows.Forms.OpenFileDialog()
        Me.bcx = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bquit = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.bsave = New System.Windows.Forms.Button()
        Me.dgdata = New System.Windows.Forms.DataGridView()
        Me.breset = New System.Windows.Forms.Button()
        Me.gbdata = New System.Windows.Forms.GroupBox()
        Me.badd = New System.Windows.Forms.Button()
        Me.bdel = New System.Windows.Forms.Button()
        Me.bimp = New System.Windows.Forms.Button()
        Me.ifimp = New System.Windows.Forms.Label()
        Me.bline = New System.Windows.Forms.Button()
        Me.ldatatype = New System.Windows.Forms.Label()
        Me.bbin = New System.Windows.Forms.Button()
        Me.bpart = New System.Windows.Forms.Button()
        Me.gbtype = New System.Windows.Forms.GroupBox()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.cbkwlx = New System.Windows.Forms.ComboBox()
        Me.cbkq = New System.Windows.Forms.ComboBox()
        Me.cbkcd = New System.Windows.Forms.ComboBox()
        CType(Me.dgtemp,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgdata,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbdata.SuspendLayout
        Me.gbtype.SuspendLayout
        Me.gbop.SuspendLayout
        Me.SuspendLayout
        '
        'open_excel
        '
        Me.open_excel.FileName = "OpenFileDialog1"
        '
        'bcx
        '
        Me.bcx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcx.Location = New System.Drawing.Point(434, 79)
        Me.bcx.Name = "bcx"
        Me.bcx.Size = New System.Drawing.Size(72, 28)
        Me.bcx.TabIndex = 21
        Me.bcx.Text = "查询"
        Me.bcx.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(35, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "库区筛选："
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(359, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "库位类型："
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "库存地筛选："
        '
        'bquit
        '
        Me.bquit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bquit.Location = New System.Drawing.Point(305, 30)
        Me.bquit.Name = "bquit"
        Me.bquit.Size = New System.Drawing.Size(88, 31)
        Me.bquit.TabIndex = 20
        Me.bquit.Text = "取消"
        Me.bquit.UseVisualStyleBackColor = false
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = false
        Me.dgtemp.AllowUserToDeleteRows = false
        Me.dgtemp.AllowUserToResizeColumns = false
        Me.dgtemp.AllowUserToResizeRows = false
        Me.dgtemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp.BackgroundColor = System.Drawing.Color.White
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgtemp.Location = New System.Drawing.Point(606, 188)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = false
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(241, 125)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = false
        '
        'bsave
        '
        Me.bsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bsave.Location = New System.Drawing.Point(399, 30)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(123, 31)
        Me.bsave.TabIndex = 1
        Me.bsave.Text = "确认"
        Me.bsave.UseVisualStyleBackColor = false
        Me.bsave.Visible = false
        '
        'dgdata
        '
        Me.dgdata.AllowUserToAddRows = false
        Me.dgdata.AllowUserToDeleteRows = false
        Me.dgdata.AllowUserToResizeColumns = false
        Me.dgdata.AllowUserToResizeRows = false
        Me.dgdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdata.BackgroundColor = System.Drawing.Color.White
        Me.dgdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdata.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgdata.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.dgdata.Location = New System.Drawing.Point(24, 68)
        Me.dgdata.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdata.MultiSelect = false
        Me.dgdata.Name = "dgdata"
        Me.dgdata.RowHeadersVisible = false
        Me.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdata.Size = New System.Drawing.Size(839, 343)
        Me.dgdata.TabIndex = 18
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(540, 79)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(72, 28)
        Me.breset.TabIndex = 21
        Me.breset.Text = "重置"
        Me.breset.UseVisualStyleBackColor = false
        '
        'gbdata
        '
        Me.gbdata.Controls.Add(Me.bquit)
        Me.gbdata.Controls.Add(Me.dgtemp)
        Me.gbdata.Controls.Add(Me.bsave)
        Me.gbdata.Controls.Add(Me.dgdata)
        Me.gbdata.Controls.Add(Me.badd)
        Me.gbdata.Controls.Add(Me.bdel)
        Me.gbdata.Controls.Add(Me.bimp)
        Me.gbdata.Location = New System.Drawing.Point(172, 166)
        Me.gbdata.Name = "gbdata"
        Me.gbdata.Size = New System.Drawing.Size(909, 345)
        Me.gbdata.TabIndex = 4
        Me.gbdata.TabStop = false
        Me.gbdata.Text = "数据"
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(6, 29)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(88, 31)
        Me.badd.TabIndex = 1
        Me.badd.Text = "新增"
        Me.badd.UseVisualStyleBackColor = false
        '
        'bdel
        '
        Me.bdel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bdel.Location = New System.Drawing.Point(100, 29)
        Me.bdel.Name = "bdel"
        Me.bdel.Size = New System.Drawing.Size(88, 31)
        Me.bdel.TabIndex = 1
        Me.bdel.Text = "删除"
        Me.bdel.UseVisualStyleBackColor = false
        '
        'bimp
        '
        Me.bimp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bimp.Location = New System.Drawing.Point(201, 29)
        Me.bimp.Name = "bimp"
        Me.bimp.Size = New System.Drawing.Size(88, 31)
        Me.bimp.TabIndex = 1
        Me.bimp.Text = "导入"
        Me.bimp.UseVisualStyleBackColor = false
        '
        'ifimp
        '
        Me.ifimp.AutoSize = true
        Me.ifimp.Location = New System.Drawing.Point(41, 308)
        Me.ifimp.Name = "ifimp"
        Me.ifimp.Size = New System.Drawing.Size(16, 17)
        Me.ifimp.TabIndex = 2
        Me.ifimp.Text = "0"
        '
        'bline
        '
        Me.bline.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bline.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.bline.Location = New System.Drawing.Point(29, 372)
        Me.bline.Name = "bline"
        Me.bline.Size = New System.Drawing.Size(117, 49)
        Me.bline.TabIndex = 1
        Me.bline.Text = "产线数据"
        Me.bline.UseVisualStyleBackColor = false
        Me.bline.Visible = false
        '
        'ldatatype
        '
        Me.ldatatype.AutoSize = true
        Me.ldatatype.Location = New System.Drawing.Point(51, 50)
        Me.ldatatype.Name = "ldatatype"
        Me.ldatatype.Size = New System.Drawing.Size(64, 17)
        Me.ldatatype.TabIndex = 0
        Me.ldatatype.Text = "零件数据"
        Me.ldatatype.Visible = false
        '
        'bbin
        '
        Me.bbin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bbin.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.bbin.Location = New System.Drawing.Point(29, 224)
        Me.bbin.Name = "bbin"
        Me.bbin.Size = New System.Drawing.Size(117, 49)
        Me.bbin.TabIndex = 1
        Me.bbin.Text = "库位数据"
        Me.bbin.UseVisualStyleBackColor = false
        '
        'bpart
        '
        Me.bpart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bpart.Font = New System.Drawing.Font("微软雅黑", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
        Me.bpart.Location = New System.Drawing.Point(29, 78)
        Me.bpart.Name = "bpart"
        Me.bpart.Size = New System.Drawing.Size(117, 49)
        Me.bpart.TabIndex = 1
        Me.bpart.Text = "零件数据"
        Me.bpart.UseVisualStyleBackColor = false
        '
        'gbtype
        '
        Me.gbtype.Controls.Add(Me.ifimp)
        Me.gbtype.Controls.Add(Me.bline)
        Me.gbtype.Controls.Add(Me.ldatatype)
        Me.gbtype.Controls.Add(Me.bbin)
        Me.gbtype.Controls.Add(Me.bpart)
        Me.gbtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbtype.Location = New System.Drawing.Point(805, 517)
        Me.gbtype.Name = "gbtype"
        Me.gbtype.Size = New System.Drawing.Size(171, 134)
        Me.gbtype.TabIndex = 3
        Me.gbtype.TabStop = false
        Me.gbtype.Text = "主数据类型"
        Me.gbtype.Visible = false
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.cbkwlx)
        Me.gbop.Controls.Add(Me.cbkq)
        Me.gbop.Controls.Add(Me.cbkcd)
        Me.gbop.Controls.Add(Me.breset)
        Me.gbop.Controls.Add(Me.bcx)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label2)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 132)
        Me.gbop.TabIndex = 5
        Me.gbop.TabStop = false
        Me.gbop.Text = "库位主数据"
        '
        'cbkwlx
        '
        Me.cbkwlx.FormattingEnabled = true
        Me.cbkwlx.Location = New System.Drawing.Point(434, 35)
        Me.cbkwlx.Name = "cbkwlx"
        Me.cbkwlx.Size = New System.Drawing.Size(178, 24)
        Me.cbkwlx.TabIndex = 22
        '
        'cbkq
        '
        Me.cbkq.FormattingEnabled = true
        Me.cbkq.Location = New System.Drawing.Point(141, 76)
        Me.cbkq.Name = "cbkq"
        Me.cbkq.Size = New System.Drawing.Size(178, 24)
        Me.cbkq.TabIndex = 22
        '
        'cbkcd
        '
        Me.cbkcd.FormattingEnabled = true
        Me.cbkcd.Location = New System.Drawing.Point(141, 35)
        Me.cbkcd.Name = "cbkcd"
        Me.cbkcd.Size = New System.Drawing.Size(178, 24)
        Me.cbkcd.TabIndex = 22
        '
        'WMS_库位
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbdata)
        Me.Controls.Add(Me.gbtype)
        Me.Controls.Add(Me.gbop)
        Me.Name = "WMS_库位"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.dgtemp,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgdata,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbdata.ResumeLayout(false)
        Me.gbtype.ResumeLayout(false)
        Me.gbtype.PerformLayout
        Me.gbop.ResumeLayout(false)
        Me.gbop.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents open_excel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bcx As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bquit As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents dgdata As System.Windows.Forms.DataGridView
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents gbdata As System.Windows.Forms.GroupBox
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents bdel As System.Windows.Forms.Button
    Friend WithEvents bimp As System.Windows.Forms.Button
    Friend WithEvents ifimp As System.Windows.Forms.Label
    Friend WithEvents bline As System.Windows.Forms.Button
    Friend WithEvents ldatatype As System.Windows.Forms.Label
    Friend WithEvents bbin As System.Windows.Forms.Button
    Friend WithEvents bpart As System.Windows.Forms.Button
    Friend WithEvents gbtype As System.Windows.Forms.GroupBox
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents cbkcd As System.Windows.Forms.ComboBox
    Friend WithEvents cbkwlx As System.Windows.Forms.ComboBox
    Friend WithEvents cbkq As System.Windows.Forms.ComboBox

End Class
