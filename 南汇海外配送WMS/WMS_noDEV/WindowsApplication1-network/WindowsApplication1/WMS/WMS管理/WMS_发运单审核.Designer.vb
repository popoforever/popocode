<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_发运单审核
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
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.dttemp = New System.Windows.Forms.DateTimePicker()
        Me.brefresh = New System.Windows.Forms.Button()
        Me.breject = New System.Windows.Forms.Button()
        Me.bmodify = New System.Windows.Forms.Button()
        Me.bconfirm = New System.Windows.Forms.Button()
        Me.cbpartno = New System.Windows.Forms.ComboBox()
        Me.cbcustomer = New System.Windows.Forms.ComboBox()
        Me.lordertime = New System.Windows.Forms.Label()
        Me.lorder = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbdfb = New System.Windows.Forms.GroupBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dt2 = New System.Windows.Forms.DateTimePicker()
        Me.dgorder = New System.Windows.Forms.DataGridView()
        Me.gbconfirm = New System.Windows.Forms.GroupBox()
        Me.pyfb = New System.Windows.Forms.Panel()
        Me.dgyfb = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.premark = New System.Windows.Forms.Panel()
        Me.tremark = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.lxg = New System.Windows.Forms.Label()
        Me.lxqrq = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.gbop.SuspendLayout()
        Me.gbdfb.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbconfirm.SuspendLayout()
        Me.pyfb.SuspendLayout()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.premark.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.dttemp)
        Me.gbop.Controls.Add(Me.brefresh)
        Me.gbop.Controls.Add(Me.breject)
        Me.gbop.Controls.Add(Me.bmodify)
        Me.gbop.Controls.Add(Me.bconfirm)
        Me.gbop.Controls.Add(Me.cbpartno)
        Me.gbop.Controls.Add(Me.cbcustomer)
        Me.gbop.Controls.Add(Me.lordertime)
        Me.gbop.Controls.Add(Me.lorder)
        Me.gbop.Controls.Add(Me.Label6)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Name = "gbop"
        Me.gbop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Size = New System.Drawing.Size(1490, 79)
        Me.gbop.TabIndex = 24
        Me.gbop.TabStop = False
        Me.gbop.Text = "海外订单审核"
        '
        'dttemp
        '
        Me.dttemp.Location = New System.Drawing.Point(1064, 34)
        Me.dttemp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dttemp.Name = "dttemp"
        Me.dttemp.Size = New System.Drawing.Size(168, 27)
        Me.dttemp.TabIndex = 27
        Me.dttemp.Visible = False
        '
        'brefresh
        '
        Me.brefresh.BackColor = System.Drawing.Color.Teal
        Me.brefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.brefresh.ForeColor = System.Drawing.Color.White
        Me.brefresh.Location = New System.Drawing.Point(1397, 24)
        Me.brefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.brefresh.Name = "brefresh"
        Me.brefresh.Size = New System.Drawing.Size(90, 51)
        Me.brefresh.TabIndex = 21
        Me.brefresh.Text = "刷新"
        Me.brefresh.UseVisualStyleBackColor = False
        '
        'breject
        '
        Me.breject.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.breject.Dock = System.Windows.Forms.DockStyle.Left
        Me.breject.Enabled = False
        Me.breject.ForeColor = System.Drawing.Color.White
        Me.breject.Location = New System.Drawing.Point(186, 24)
        Me.breject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breject.Name = "breject"
        Me.breject.Size = New System.Drawing.Size(89, 51)
        Me.breject.TabIndex = 1
        Me.breject.Text = "驳回"
        Me.breject.UseVisualStyleBackColor = False
        '
        'bmodify
        '
        Me.bmodify.BackColor = System.Drawing.Color.Olive
        Me.bmodify.Dock = System.Windows.Forms.DockStyle.Left
        Me.bmodify.Enabled = False
        Me.bmodify.ForeColor = System.Drawing.Color.White
        Me.bmodify.Location = New System.Drawing.Point(98, 24)
        Me.bmodify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bmodify.Name = "bmodify"
        Me.bmodify.Size = New System.Drawing.Size(88, 51)
        Me.bmodify.TabIndex = 1
        Me.bmodify.Text = "修改"
        Me.bmodify.UseVisualStyleBackColor = False
        '
        'bconfirm
        '
        Me.bconfirm.BackColor = System.Drawing.Color.Green
        Me.bconfirm.Dock = System.Windows.Forms.DockStyle.Left
        Me.bconfirm.Enabled = False
        Me.bconfirm.ForeColor = System.Drawing.Color.White
        Me.bconfirm.Location = New System.Drawing.Point(3, 24)
        Me.bconfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bconfirm.Name = "bconfirm"
        Me.bconfirm.Size = New System.Drawing.Size(95, 51)
        Me.bconfirm.TabIndex = 1
        Me.bconfirm.Text = "通过"
        Me.bconfirm.UseVisualStyleBackColor = False
        '
        'cbpartno
        '
        Me.cbpartno.FormattingEnabled = True
        Me.cbpartno.Location = New System.Drawing.Point(643, 53)
        Me.cbpartno.Name = "cbpartno"
        Me.cbpartno.Size = New System.Drawing.Size(199, 28)
        Me.cbpartno.TabIndex = 28
        Me.cbpartno.Visible = False
        '
        'cbcustomer
        '
        Me.cbcustomer.FormattingEnabled = True
        Me.cbcustomer.Location = New System.Drawing.Point(643, 16)
        Me.cbcustomer.Name = "cbcustomer"
        Me.cbcustomer.Size = New System.Drawing.Size(199, 28)
        Me.cbcustomer.TabIndex = 27
        Me.cbcustomer.Visible = False
        '
        'lordertime
        '
        Me.lordertime.AutoSize = True
        Me.lordertime.Location = New System.Drawing.Point(1226, 154)
        Me.lordertime.Name = "lordertime"
        Me.lordertime.Size = New System.Drawing.Size(57, 20)
        Me.lordertime.TabIndex = 26
        Me.lordertime.Text = "Label5"
        Me.lordertime.Visible = False
        '
        'lorder
        '
        Me.lorder.AutoSize = True
        Me.lorder.Location = New System.Drawing.Point(1407, 154)
        Me.lorder.Name = "lorder"
        Me.lorder.Size = New System.Drawing.Size(57, 20)
        Me.lorder.TabIndex = 26
        Me.lorder.Text = "Label5"
        Me.lorder.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(583, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "零件："
        Me.Label6.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(583, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客户："
        Me.Label1.Visible = False
        '
        'gbdfb
        '
        Me.gbdfb.Controls.Add(Me.dgtemp)
        Me.gbdfb.Controls.Add(Me.dt2)
        Me.gbdfb.Controls.Add(Me.dgorder)
        Me.gbdfb.Location = New System.Drawing.Point(3, 196)
        Me.gbdfb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Name = "gbdfb"
        Me.gbdfb.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Size = New System.Drawing.Size(970, 606)
        Me.gbdfb.TabIndex = 26
        Me.gbdfb.TabStop = False
        Me.gbdfb.Text = "订单列表"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgtemp.Location = New System.Drawing.Point(613, 229)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(271, 131)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'dt2
        '
        Me.dt2.Location = New System.Drawing.Point(615, 155)
        Me.dt2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt2.Name = "dt2"
        Me.dt2.Size = New System.Drawing.Size(224, 27)
        Me.dt2.TabIndex = 27
        Me.dt2.Visible = False
        '
        'dgorder
        '
        Me.dgorder.AllowUserToAddRows = False
        Me.dgorder.AllowUserToDeleteRows = False
        Me.dgorder.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgorder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgorder.BackgroundColor = System.Drawing.Color.White
        Me.dgorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgorder.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgorder.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgorder.Location = New System.Drawing.Point(242, 68)
        Me.dgorder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgorder.MultiSelect = False
        Me.dgorder.Name = "dgorder"
        Me.dgorder.ReadOnly = True
        Me.dgorder.RowHeadersVisible = False
        Me.dgorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgorder.Size = New System.Drawing.Size(674, 349)
        Me.dgorder.TabIndex = 18
        '
        'gbconfirm
        '
        Me.gbconfirm.Controls.Add(Me.pyfb)
        Me.gbconfirm.Controls.Add(Me.Panel2)
        Me.gbconfirm.Controls.Add(Me.premark)
        Me.gbconfirm.Controls.Add(Me.Panel1)
        Me.gbconfirm.Location = New System.Drawing.Point(994, 208)
        Me.gbconfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbconfirm.Name = "gbconfirm"
        Me.gbconfirm.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbconfirm.Size = New System.Drawing.Size(470, 638)
        Me.gbconfirm.TabIndex = 25
        Me.gbconfirm.TabStop = False
        Me.gbconfirm.Text = "审核页面"
        '
        'pyfb
        '
        Me.pyfb.Controls.Add(Me.dgyfb)
        Me.pyfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pyfb.Location = New System.Drawing.Point(3, 73)
        Me.pyfb.Name = "pyfb"
        Me.pyfb.Size = New System.Drawing.Size(464, 561)
        Me.pyfb.TabIndex = 31
        '
        'dgyfb
        '
        Me.dgyfb.AllowUserToAddRows = False
        Me.dgyfb.AllowUserToDeleteRows = False
        Me.dgyfb.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgyfb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgyfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgyfb.BackgroundColor = System.Drawing.Color.White
        Me.dgyfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgyfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgyfb.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgyfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgyfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgyfb.Location = New System.Drawing.Point(0, 0)
        Me.dgyfb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgyfb.MultiSelect = False
        Me.dgyfb.Name = "dgyfb"
        Me.dgyfb.ReadOnly = True
        Me.dgyfb.RowHeadersVisible = False
        Me.dgyfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgyfb.Size = New System.Drawing.Size(464, 561)
        Me.dgyfb.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(89, 517)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 38)
        Me.Panel2.TabIndex = 29
        Me.Panel2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "备注："
        '
        'premark
        '
        Me.premark.Controls.Add(Me.tremark)
        Me.premark.Location = New System.Drawing.Point(25, 411)
        Me.premark.Name = "premark"
        Me.premark.Size = New System.Drawing.Size(445, 156)
        Me.premark.TabIndex = 29
        Me.premark.Visible = False
        '
        'tremark
        '
        Me.tremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tremark.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.tremark.Location = New System.Drawing.Point(13, 10)
        Me.tremark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tremark.Name = "tremark"
        Me.tremark.Size = New System.Drawing.Size(426, 142)
        Me.tremark.TabIndex = 19
        Me.tremark.Text = ""
        Me.tremark.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dt1)
        Me.Panel1.Controls.Add(Me.lxg)
        Me.Panel1.Controls.Add(Me.lxqrq)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 49)
        Me.Panel1.TabIndex = 30
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(149, 12)
        Me.dt1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(168, 27)
        Me.dt1.TabIndex = 27
        '
        'lxg
        '
        Me.lxg.AutoSize = True
        Me.lxg.Location = New System.Drawing.Point(347, 17)
        Me.lxg.Name = "lxg"
        Me.lxg.Size = New System.Drawing.Size(39, 20)
        Me.lxg.TabIndex = 26
        Me.lxg.Text = "修改"
        '
        'lxqrq
        '
        Me.lxqrq.AutoSize = True
        Me.lxqrq.Location = New System.Drawing.Point(12, 17)
        Me.lxqrq.Name = "lxqrq"
        Me.lxqrq.Size = New System.Drawing.Size(114, 20)
        Me.lxqrq.TabIndex = 28
        Me.lxqrq.Text = "需求到货日期："
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'WMS_发运单审核
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbconfirm)
        Me.Controls.Add(Me.gbdfb)
        Me.Controls.Add(Me.gbop)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WMS_发运单审核"
        Me.Size = New System.Drawing.Size(1490, 810)
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.gbdfb.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbconfirm.ResumeLayout(False)
        Me.pyfb.ResumeLayout(False)
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.premark.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents brefresh As System.Windows.Forms.Button
    Friend WithEvents gbdfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgorder As System.Windows.Forms.DataGridView
    Friend WithEvents gbconfirm As System.Windows.Forms.GroupBox
    Friend WithEvents dgyfb As System.Windows.Forms.DataGridView
    Friend WithEvents bconfirm As System.Windows.Forms.Button
    Friend WithEvents tremark As System.Windows.Forms.RichTextBox
    Friend WithEvents breject As System.Windows.Forms.Button
    Friend WithEvents bmodify As System.Windows.Forms.Button
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lxqrq As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lorder As System.Windows.Forms.Label
    Friend WithEvents lordertime As System.Windows.Forms.Label
    Friend WithEvents lxg As System.Windows.Forms.Label
    Friend WithEvents dt2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents premark As System.Windows.Forms.Panel
    Friend WithEvents cbpartno As System.Windows.Forms.ComboBox
    Friend WithEvents cbcustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pyfb As System.Windows.Forms.Panel
    Friend WithEvents dttemp As System.Windows.Forms.DateTimePicker

End Class
