<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_订单确认
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbdfb = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dgyfb = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.breject = New System.Windows.Forms.Button()
        Me.bconfirm = New System.Windows.Forms.Button()
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.lorder = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbdfb.SuspendLayout()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1564, 864)
        Me.SplitContainer1.SplitterDistance = 320
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 27
        '
        'gbdfb
        '
        Me.gbdfb.Controls.Add(Me.lorder)
        Me.gbdfb.Controls.Add(Me.ProgressBar1)
        Me.gbdfb.Controls.Add(Me.dgyfb)
        Me.gbdfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbdfb.Location = New System.Drawing.Point(0, 0)
        Me.gbdfb.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.gbdfb.Name = "gbdfb"
        Me.gbdfb.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.gbdfb.Size = New System.Drawing.Size(1564, 320)
        Me.gbdfb.TabIndex = 25
        Me.gbdfb.TabStop = False
        Me.gbdfb.Text = "Order"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(399, -13)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1271, 29)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'dgyfb
        '
        Me.dgyfb.AllowUserToAddRows = False
        Me.dgyfb.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgyfb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgyfb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgyfb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgyfb.BackgroundColor = System.Drawing.Color.White
        Me.dgyfb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgyfb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgyfb.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgyfb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgyfb.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgyfb.Location = New System.Drawing.Point(3, 25)
        Me.dgyfb.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dgyfb.MultiSelect = False
        Me.dgyfb.Name = "dgyfb"
        Me.dgyfb.ReadOnly = True
        Me.dgyfb.RowHeadersVisible = False
        Me.dgyfb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgyfb.Size = New System.Drawing.Size(1558, 290)
        Me.dgyfb.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.dgdetail)
        Me.GroupBox1.Controls.Add(Me.dgtemp)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1564, 539)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.breject)
        Me.Panel1.Controls.Add(Me.bconfirm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 465)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1558, 69)
        Me.Panel1.TabIndex = 20
        '
        'breject
        '
        Me.breject.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.breject.Dock = System.Windows.Forms.DockStyle.Left
        Me.breject.Enabled = False
        Me.breject.ForeColor = System.Drawing.Color.White
        Me.breject.Location = New System.Drawing.Point(95, 0)
        Me.breject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breject.Name = "breject"
        Me.breject.Size = New System.Drawing.Size(89, 69)
        Me.breject.TabIndex = 2
        Me.breject.Text = "Cancel Order"
        Me.breject.UseVisualStyleBackColor = False
        '
        'bconfirm
        '
        Me.bconfirm.BackColor = System.Drawing.Color.Green
        Me.bconfirm.Dock = System.Windows.Forms.DockStyle.Left
        Me.bconfirm.Enabled = False
        Me.bconfirm.ForeColor = System.Drawing.Color.White
        Me.bconfirm.Location = New System.Drawing.Point(0, 0)
        Me.bconfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bconfirm.Name = "bconfirm"
        Me.bconfirm.Size = New System.Drawing.Size(95, 69)
        Me.bconfirm.TabIndex = 3
        Me.bconfirm.Text = "Confirm Order"
        Me.bconfirm.UseVisualStyleBackColor = False
        '
        'dgdetail
        '
        Me.dgdetail.AllowUserToAddRows = False
        Me.dgdetail.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgdetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgdetail.BackgroundColor = System.Drawing.Color.White
        Me.dgdetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdetail.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgdetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgdetail.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgdetail.Location = New System.Drawing.Point(3, 25)
        Me.dgdetail.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dgdetail.MultiSelect = False
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.ReadOnly = True
        Me.dgdetail.RowHeadersVisible = False
        Me.dgdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdetail.Size = New System.Drawing.Size(1558, 429)
        Me.dgdetail.TabIndex = 18
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgtemp.Location = New System.Drawing.Point(1108, 117)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(305, 175)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'lorder
        '
        Me.lorder.AutoSize = True
        Me.lorder.Location = New System.Drawing.Point(6, 283)
        Me.lorder.Name = "lorder"
        Me.lorder.Size = New System.Drawing.Size(57, 20)
        Me.lorder.TabIndex = 19
        Me.lorder.Text = "Label1"
        Me.lorder.Visible = False
        '
        'WMS_订单确认
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WMS_订单确认"
        Me.Size = New System.Drawing.Size(1564, 864)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbdfb.ResumeLayout(False)
        Me.gbdfb.PerformLayout()
        CType(Me.dgyfb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbdfb As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dgyfb As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents breject As System.Windows.Forms.Button
    Friend WithEvents bconfirm As System.Windows.Forms.Button
    Friend WithEvents lorder As System.Windows.Forms.Label

End Class
