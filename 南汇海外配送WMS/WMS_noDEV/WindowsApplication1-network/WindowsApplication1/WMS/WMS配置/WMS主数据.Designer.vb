<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS主数据
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
        Me.gbtype = New System.Windows.Forms.GroupBox()
        Me.ifimp = New System.Windows.Forms.Label()
        Me.bline = New System.Windows.Forms.Button()
        Me.ldatatype = New System.Windows.Forms.Label()
        Me.bbin = New System.Windows.Forms.Button()
        Me.bpart = New System.Windows.Forms.Button()
        Me.gbdata = New System.Windows.Forms.GroupBox()
        Me.bquit = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.bsave = New System.Windows.Forms.Button()
        Me.dgdata = New System.Windows.Forms.DataGridView()
        Me.badd = New System.Windows.Forms.Button()
        Me.bdel = New System.Windows.Forms.Button()
        Me.bimp = New System.Windows.Forms.Button()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.tpart = New System.Windows.Forms.TextBox()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.cbfac = New System.Windows.Forms.ComboBox()
        Me.breset = New System.Windows.Forms.Button()
        Me.bcx = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.open_excel = New System.Windows.Forms.OpenFileDialog()
        Me.gbtype.SuspendLayout()
        Me.gbdata.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbtype
        '
        Me.gbtype.Controls.Add(Me.ifimp)
        Me.gbtype.Controls.Add(Me.bline)
        Me.gbtype.Controls.Add(Me.ldatatype)
        Me.gbtype.Controls.Add(Me.bbin)
        Me.gbtype.Controls.Add(Me.bpart)
        Me.gbtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbtype.Location = New System.Drawing.Point(805, 488)
        Me.gbtype.Name = "gbtype"
        Me.gbtype.Size = New System.Drawing.Size(171, 126)
        Me.gbtype.TabIndex = 0
        Me.gbtype.TabStop = False
        Me.gbtype.Text = "主数据类型"
        Me.gbtype.Visible = False
        '
        'ifimp
        '
        Me.ifimp.AutoSize = True
        Me.ifimp.Location = New System.Drawing.Point(41, 289)
        Me.ifimp.Name = "ifimp"
        Me.ifimp.Size = New System.Drawing.Size(15, 15)
        Me.ifimp.TabIndex = 2
        Me.ifimp.Text = "0"
        '
        'bline
        '
        Me.bline.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bline.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bline.Location = New System.Drawing.Point(29, 349)
        Me.bline.Name = "bline"
        Me.bline.Size = New System.Drawing.Size(117, 46)
        Me.bline.TabIndex = 1
        Me.bline.Text = "产线数据"
        Me.bline.UseVisualStyleBackColor = False
        Me.bline.Visible = False
        '
        'ldatatype
        '
        Me.ldatatype.AutoSize = True
        Me.ldatatype.Location = New System.Drawing.Point(51, 47)
        Me.ldatatype.Name = "ldatatype"
        Me.ldatatype.Size = New System.Drawing.Size(67, 15)
        Me.ldatatype.TabIndex = 0
        Me.ldatatype.Text = "零件数据"
        Me.ldatatype.Visible = False
        '
        'bbin
        '
        Me.bbin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bbin.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bbin.Location = New System.Drawing.Point(29, 210)
        Me.bbin.Name = "bbin"
        Me.bbin.Size = New System.Drawing.Size(117, 46)
        Me.bbin.TabIndex = 1
        Me.bbin.Text = "库位数据"
        Me.bbin.UseVisualStyleBackColor = False
        '
        'bpart
        '
        Me.bpart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bpart.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bpart.Location = New System.Drawing.Point(29, 73)
        Me.bpart.Name = "bpart"
        Me.bpart.Size = New System.Drawing.Size(117, 46)
        Me.bpart.TabIndex = 1
        Me.bpart.Text = "零件数据"
        Me.bpart.UseVisualStyleBackColor = False
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
        Me.gbdata.Location = New System.Drawing.Point(172, 158)
        Me.gbdata.Name = "gbdata"
        Me.gbdata.Size = New System.Drawing.Size(909, 323)
        Me.gbdata.TabIndex = 1
        Me.gbdata.TabStop = False
        Me.gbdata.Text = "数据"
        '
        'bquit
        '
        Me.bquit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bquit.Location = New System.Drawing.Point(305, 28)
        Me.bquit.Name = "bquit"
        Me.bquit.Size = New System.Drawing.Size(88, 29)
        Me.bquit.TabIndex = 20
        Me.bquit.Text = "取消"
        Me.bquit.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgtemp.Location = New System.Drawing.Point(606, 176)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(241, 117)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'bsave
        '
        Me.bsave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bsave.Location = New System.Drawing.Point(399, 28)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(123, 29)
        Me.bsave.TabIndex = 1
        Me.bsave.Text = "确认"
        Me.bsave.UseVisualStyleBackColor = False
        Me.bsave.Visible = False
        '
        'dgdata
        '
        Me.dgdata.AllowUserToAddRows = False
        Me.dgdata.AllowUserToDeleteRows = False
        Me.dgdata.AllowUserToResizeColumns = False
        Me.dgdata.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdata.BackgroundColor = System.Drawing.Color.White
        Me.dgdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdata.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgdata.Location = New System.Drawing.Point(24, 64)
        Me.dgdata.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdata.MultiSelect = False
        Me.dgdata.Name = "dgdata"
        Me.dgdata.RowHeadersVisible = False
        Me.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdata.Size = New System.Drawing.Size(839, 322)
        Me.dgdata.TabIndex = 18
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(6, 27)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(88, 29)
        Me.badd.TabIndex = 1
        Me.badd.Text = "新增"
        Me.badd.UseVisualStyleBackColor = False
        '
        'bdel
        '
        Me.bdel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bdel.Location = New System.Drawing.Point(100, 27)
        Me.bdel.Name = "bdel"
        Me.bdel.Size = New System.Drawing.Size(88, 29)
        Me.bdel.TabIndex = 1
        Me.bdel.Text = "删除"
        Me.bdel.UseVisualStyleBackColor = False
        '
        'bimp
        '
        Me.bimp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bimp.Location = New System.Drawing.Point(201, 27)
        Me.bimp.Name = "bimp"
        Me.bimp.Size = New System.Drawing.Size(88, 29)
        Me.bimp.TabIndex = 1
        Me.bimp.Text = "导入"
        Me.bimp.UseVisualStyleBackColor = False
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.tpart)
        Me.gbop.Controls.Add(Me.cbtype)
        Me.gbop.Controls.Add(Me.cbfac)
        Me.gbop.Controls.Add(Me.breset)
        Me.gbop.Controls.Add(Me.bcx)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label2)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 124)
        Me.gbop.TabIndex = 2
        Me.gbop.TabStop = False
        Me.gbop.Text = "零件主数据"
        '
        'tpart
        '
        Me.tpart.Location = New System.Drawing.Point(125, 31)
        Me.tpart.Name = "tpart"
        Me.tpart.Size = New System.Drawing.Size(178, 25)
        Me.tpart.TabIndex = 3
        '
        'cbtype
        '
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Location = New System.Drawing.Point(423, 31)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(178, 23)
        Me.cbtype.TabIndex = 22
        '
        'cbfac
        '
        Me.cbfac.FormattingEnabled = True
        Me.cbfac.Location = New System.Drawing.Point(125, 68)
        Me.cbfac.Name = "cbfac"
        Me.cbfac.Size = New System.Drawing.Size(178, 23)
        Me.cbfac.TabIndex = 22
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(513, 74)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(72, 26)
        Me.breset.TabIndex = 21
        Me.breset.Text = "重置"
        Me.breset.UseVisualStyleBackColor = False
        '
        'bcx
        '
        Me.bcx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcx.Location = New System.Drawing.Point(423, 74)
        Me.bcx.Name = "bcx"
        Me.bcx.Size = New System.Drawing.Size(72, 26)
        Me.bcx.TabIndex = 21
        Me.bcx.Text = "查询"
        Me.bcx.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "工厂筛选："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "零件类别："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "零件筛选："
        '
        'open_excel
        '
        Me.open_excel.FileName = "OpenFileDialog1"
        '
        'WMS主数据
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbop)
        Me.Controls.Add(Me.gbdata)
        Me.Controls.Add(Me.gbtype)
        Me.Name = "WMS主数据"
        Me.Size = New System.Drawing.Size(1324, 608)
        Me.gbtype.ResumeLayout(False)
        Me.gbtype.PerformLayout()
        Me.gbdata.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents gbtype As System.Windows.Forms.GroupBox
    Friend WithEvents bline As System.Windows.Forms.Button
    Friend WithEvents bbin As System.Windows.Forms.Button
    Friend WithEvents bpart As System.Windows.Forms.Button
    Friend WithEvents gbdata As System.Windows.Forms.GroupBox
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents dgdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents ldatatype As System.Windows.Forms.Label
    Friend WithEvents bsave As System.Windows.Forms.Button
    Friend WithEvents bimp As System.Windows.Forms.Button
    Friend WithEvents bdel As System.Windows.Forms.Button
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents open_excel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ifimp As System.Windows.Forms.Label
    Friend WithEvents bquit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bcx As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbfac As System.Windows.Forms.ComboBox
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents tpart As System.Windows.Forms.TextBox

End Class
