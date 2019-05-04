<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_国内订单
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.cbyhh = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bpublic = New System.Windows.Forms.Button()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.lrefreshmsg = New System.Windows.Forms.Label()
        Me.lrefresh_yhh = New System.Windows.Forms.Label()
        Me.lddh = New System.Windows.Forms.Label()
        Me.lkh = New System.Windows.Forms.Label()
        Me.pbutton = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dt1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbdfb = New System.Windows.Forms.GroupBox()
        Me.listtemp = New System.Windows.Forms.ListBox()
        Me.dgimport = New System.Windows.Forms.DataGridView()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdfb = New System.Windows.Forms.DataGridView()
        Me.pmsg = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbop.SuspendLayout()
        Me.pbutton.SuspendLayout()
        Me.gbdfb.SuspendLayout()
        CType(Me.dgimport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pmsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.cbyhh)
        Me.gbop.Controls.Add(Me.Button1)
        Me.gbop.Controls.Add(Me.bpublic)
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.lrefreshmsg)
        Me.gbop.Controls.Add(Me.lrefresh_yhh)
        Me.gbop.Controls.Add(Me.lddh)
        Me.gbop.Controls.Add(Me.lkh)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Name = "gbop"
        Me.gbop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbop.Size = New System.Drawing.Size(1564, 77)
        Me.gbop.TabIndex = 24
        Me.gbop.TabStop = False
        Me.gbop.Text = "采购订单生成"
        '
        'cbyhh
        '
        Me.cbyhh.FormattingEnabled = True
        Me.cbyhh.Location = New System.Drawing.Point(306, 31)
        Me.cbyhh.Name = "cbyhh"
        Me.cbyhh.Size = New System.Drawing.Size(202, 28)
        Me.cbyhh.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1071, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'bpublic
        '
        Me.bpublic.BackColor = System.Drawing.Color.Gray
        Me.bpublic.Dock = System.Windows.Forms.DockStyle.Left
        Me.bpublic.ForeColor = System.Drawing.Color.White
        Me.bpublic.Location = New System.Drawing.Point(3, 24)
        Me.bpublic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bpublic.Name = "bpublic"
        Me.bpublic.Size = New System.Drawing.Size(98, 49)
        Me.bpublic.TabIndex = 1
        Me.bpublic.Text = "生成订单"
        Me.bpublic.UseVisualStyleBackColor = False
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(661, 30)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(211, 27)
        Me.tsearch.TabIndex = 28
        '
        'lrefreshmsg
        '
        Me.lrefreshmsg.AutoSize = True
        Me.lrefreshmsg.BackColor = System.Drawing.Color.DarkOrange
        Me.lrefreshmsg.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lrefreshmsg.Location = New System.Drawing.Point(903, 27)
        Me.lrefreshmsg.Name = "lrefreshmsg"
        Me.lrefreshmsg.Size = New System.Drawing.Size(145, 27)
        Me.lrefreshmsg.TabIndex = 27
        Me.lrefreshmsg.Text = "New Message"
        Me.lrefreshmsg.Visible = False
        '
        'lrefresh_yhh
        '
        Me.lrefresh_yhh.AutoSize = True
        Me.lrefresh_yhh.Location = New System.Drawing.Point(514, 37)
        Me.lrefresh_yhh.Name = "lrefresh_yhh"
        Me.lrefresh_yhh.Size = New System.Drawing.Size(39, 20)
        Me.lrefresh_yhh.TabIndex = 2
        Me.lrefresh_yhh.Text = "刷新"
        '
        'lddh
        '
        Me.lddh.AutoSize = True
        Me.lddh.Location = New System.Drawing.Point(231, 31)
        Me.lddh.Name = "lddh"
        Me.lddh.Size = New System.Drawing.Size(69, 20)
        Me.lddh.TabIndex = 2
        Me.lddh.Text = "要货号："
        '
        'lkh
        '
        Me.lkh.AutoSize = True
        Me.lkh.Location = New System.Drawing.Point(590, 37)
        Me.lkh.Name = "lkh"
        Me.lkh.Size = New System.Drawing.Size(54, 20)
        Me.lkh.TabIndex = 2
        Me.lkh.Text = "搜索："
        '
        'pbutton
        '
        Me.pbutton.Controls.Add(Me.ProgressBar1)
        Me.pbutton.Controls.Add(Me.dt1)
        Me.pbutton.Controls.Add(Me.Label2)
        Me.pbutton.Controls.Add(Me.Label1)
        Me.pbutton.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbutton.Location = New System.Drawing.Point(0, 77)
        Me.pbutton.Name = "pbutton"
        Me.pbutton.Size = New System.Drawing.Size(1564, 45)
        Me.pbutton.TabIndex = 28
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(285, 11)
        Me.ProgressBar1.Minimum = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(509, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Value = 1
        Me.ProgressBar1.Visible = False
        '
        'dt1
        '
        Me.dt1.Location = New System.Drawing.Point(3, 11)
        Me.dt1.Name = "dt1"
        Me.dt1.Size = New System.Drawing.Size(176, 27)
        Me.dt1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "确认"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "修改"
        '
        'gbdfb
        '
        Me.gbdfb.Controls.Add(Me.pmsg)
        Me.gbdfb.Controls.Add(Me.listtemp)
        Me.gbdfb.Controls.Add(Me.dgimport)
        Me.gbdfb.Controls.Add(Me.dgtemp)
        Me.gbdfb.Controls.Add(Me.dgdfb)
        Me.gbdfb.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbdfb.Location = New System.Drawing.Point(0, 122)
        Me.gbdfb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Name = "gbdfb"
        Me.gbdfb.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbdfb.Size = New System.Drawing.Size(1564, 606)
        Me.gbdfb.TabIndex = 29
        Me.gbdfb.TabStop = False
        Me.gbdfb.Text = "待发布"
        '
        'listtemp
        '
        Me.listtemp.FormattingEnabled = True
        Me.listtemp.ItemHeight = 20
        Me.listtemp.Location = New System.Drawing.Point(686, 94)
        Me.listtemp.Name = "listtemp"
        Me.listtemp.Size = New System.Drawing.Size(182, 144)
        Me.listtemp.TabIndex = 20
        Me.listtemp.Visible = False
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
        Me.dgdfb.RowHeadersVisible = False
        Me.dgdfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdfb.Size = New System.Drawing.Size(1558, 578)
        Me.dgdfb.TabIndex = 18
        '
        'pmsg
        '
        Me.pmsg.Controls.Add(Me.Label3)
        Me.pmsg.Location = New System.Drawing.Point(442, 130)
        Me.pmsg.Name = "pmsg"
        Me.pmsg.Size = New System.Drawing.Size(546, 172)
        Me.pmsg.TabIndex = 21
        Me.pmsg.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "玩命生成订单中，请稍候"
        '
        'WMS_国内订单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbdfb)
        Me.Controls.Add(Me.pbutton)
        Me.Controls.Add(Me.gbop)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WMS_国内订单"
        Me.Size = New System.Drawing.Size(1564, 810)
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.pbutton.ResumeLayout(False)
        Me.pbutton.PerformLayout()
        Me.gbdfb.ResumeLayout(False)
        CType(Me.dgimport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pmsg.ResumeLayout(False)
        Me.pmsg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents lrefreshmsg As System.Windows.Forms.Label
    Friend WithEvents lddh As System.Windows.Forms.Label
    Friend WithEvents lkh As System.Windows.Forms.Label
    Friend WithEvents pbutton As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents bpublic As System.Windows.Forms.Button
    Friend WithEvents gbdfb As System.Windows.Forms.GroupBox
    Friend WithEvents dgimport As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdfb As System.Windows.Forms.DataGridView
    Friend WithEvents dt1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listtemp As System.Windows.Forms.ListBox
    Friend WithEvents lrefresh_yhh As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbyhh As System.Windows.Forms.ComboBox
    Friend WithEvents pmsg As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
