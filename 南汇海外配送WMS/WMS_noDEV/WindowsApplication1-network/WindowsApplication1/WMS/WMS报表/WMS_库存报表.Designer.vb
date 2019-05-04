<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_库存报表
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
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.cbpartno = New System.Windows.Forms.ComboBox()
        Me.cbkw = New System.Windows.Forms.ComboBox()
        Me.cbkq = New System.Windows.Forms.ComboBox()
        Me.badd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbsum = New System.Windows.Forms.GroupBox()
        Me.dgsum = New System.Windows.Forms.DataGridView()
        Me.gbdetail = New System.Windows.Forms.GroupBox()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.dgpart = New System.Windows.Forms.DataGridView()
        Me.tsearch = New System.Windows.Forms.TextBox()
        Me.gbop.SuspendLayout()
        Me.gbsum.SuspendLayout()
        CType(Me.dgsum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetail.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.tsearch)
        Me.gbop.Controls.Add(Me.cbpartno)
        Me.gbop.Controls.Add(Me.cbkw)
        Me.gbop.Controls.Add(Me.cbkq)
        Me.gbop.Controls.Add(Me.badd)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label6)
        Me.gbop.Controls.Add(Me.Label4)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 151)
        Me.gbop.TabIndex = 7
        Me.gbop.TabStop = False
        Me.gbop.Text = "库存查询"
        '
        'cbpartno
        '
        Me.cbpartno.FormattingEnabled = True
        Me.cbpartno.Location = New System.Drawing.Point(463, 33)
        Me.cbpartno.Name = "cbpartno"
        Me.cbpartno.Size = New System.Drawing.Size(168, 24)
        Me.cbpartno.TabIndex = 26
        '
        'cbkw
        '
        Me.cbkw.FormattingEnabled = True
        Me.cbkw.Location = New System.Drawing.Point(125, 79)
        Me.cbkw.Name = "cbkw"
        Me.cbkw.Size = New System.Drawing.Size(178, 24)
        Me.cbkw.TabIndex = 25
        '
        'cbkq
        '
        Me.cbkq.FormattingEnabled = True
        Me.cbkq.Location = New System.Drawing.Point(125, 33)
        Me.cbkq.Name = "cbkq"
        Me.cbkq.Size = New System.Drawing.Size(178, 24)
        Me.cbkq.TabIndex = 25
        '
        'badd
        '
        Me.badd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.badd.Location = New System.Drawing.Point(387, 79)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(72, 28)
        Me.badd.TabIndex = 21
        Me.badd.Text = "查询"
        Me.badd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(730, 39)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "库位："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "库区："
        '
        'gbsum
        '
        Me.gbsum.Controls.Add(Me.dgsum)
        Me.gbsum.Location = New System.Drawing.Point(920, 169)
        Me.gbsum.Name = "gbsum"
        Me.gbsum.Size = New System.Drawing.Size(303, 510)
        Me.gbsum.TabIndex = 28
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
        Me.gbdetail.Location = New System.Drawing.Point(12, 227)
        Me.gbdetail.Name = "gbdetail"
        Me.gbdetail.Size = New System.Drawing.Size(902, 421)
        Me.gbdetail.TabIndex = 27
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
        Me.dgpart.Location = New System.Drawing.Point(473, 157)
        Me.dgpart.MultiSelect = False
        Me.dgpart.Name = "dgpart"
        Me.dgpart.ReadOnly = True
        Me.dgpart.RowHeadersVisible = False
        Me.dgpart.RowTemplate.Height = 24
        Me.dgpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgpart.Size = New System.Drawing.Size(219, 31)
        Me.dgpart.TabIndex = 27
        Me.dgpart.Visible = False
        '
        'tsearch
        '
        Me.tsearch.Location = New System.Drawing.Point(786, 33)
        Me.tsearch.Name = "tsearch"
        Me.tsearch.Size = New System.Drawing.Size(156, 22)
        Me.tsearch.TabIndex = 27
        '
        'WMS_库存报表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgpart)
        Me.Controls.Add(Me.gbsum)
        Me.Controls.Add(Me.gbdetail)
        Me.Controls.Add(Me.gbop)
        Me.Name = "WMS_库存报表"
        Me.Size = New System.Drawing.Size(1324, 648)
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.gbsum.ResumeLayout(False)
        CType(Me.dgsum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetail.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents badd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbsum As System.Windows.Forms.GroupBox
    Friend WithEvents dgsum As System.Windows.Forms.DataGridView
    Friend WithEvents gbdetail As System.Windows.Forms.GroupBox
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents dgpart As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbkq As System.Windows.Forms.ComboBox
    Friend WithEvents cbkw As System.Windows.Forms.ComboBox
    Friend WithEvents cbpartno As System.Windows.Forms.ComboBox
    Friend WithEvents tsearch As System.Windows.Forms.TextBox

End Class
