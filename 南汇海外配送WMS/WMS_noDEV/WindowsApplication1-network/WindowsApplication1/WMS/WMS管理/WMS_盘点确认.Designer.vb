<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_盘点确认
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
        Me.dgtemp2 = New System.Windows.Forms.DataGridView()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgtab1 = New System.Windows.Forms.DataGridView()
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.cbpdd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bok = New System.Windows.Forms.Button()
        Me.dgtab2 = New System.Windows.Forms.DataGridView()
        Me.tab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbop.SuspendLayout()
        CType(Me.dgtab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgtemp2
        '
        Me.dgtemp2.AllowUserToAddRows = False
        Me.dgtemp2.AllowUserToDeleteRows = False
        Me.dgtemp2.AllowUserToResizeColumns = False
        Me.dgtemp2.AllowUserToResizeRows = False
        Me.dgtemp2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp2.BackgroundColor = System.Drawing.Color.White
        Me.dgtemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp2.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgtemp2.Location = New System.Drawing.Point(604, 7)
        Me.dgtemp2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp2.Name = "dgtemp2"
        Me.dgtemp2.RowHeadersVisible = False
        Me.dgtemp2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp2.Size = New System.Drawing.Size(241, 105)
        Me.dgtemp2.TabIndex = 21
        Me.dgtemp2.Visible = False
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
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgtemp.Location = New System.Drawing.Point(885, 64)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(241, 105)
        Me.dgtemp.TabIndex = 21
        Me.dgtemp.Visible = False
        '
        'dgtab1
        '
        Me.dgtab1.AllowUserToAddRows = False
        Me.dgtab1.AllowUserToDeleteRows = False
        Me.dgtab1.AllowUserToResizeColumns = False
        Me.dgtab1.AllowUserToResizeRows = False
        Me.dgtab1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtab1.BackgroundColor = System.Drawing.Color.White
        Me.dgtab1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgtab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtab1.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgtab1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgtab1.Location = New System.Drawing.Point(25, 48)
        Me.dgtab1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtab1.MultiSelect = False
        Me.dgtab1.Name = "dgtab1"
        Me.dgtab1.ReadOnly = True
        Me.dgtab1.RowHeadersVisible = False
        Me.dgtab1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgtab1.Size = New System.Drawing.Size(494, 155)
        Me.dgtab1.TabIndex = 20
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.cbpdd)
        Me.gbop.Controls.Add(Me.dgtemp)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 151)
        Me.gbop.TabIndex = 6
        Me.gbop.TabStop = False
        Me.gbop.Text = "盘点确认"
        '
        'cbpdd
        '
        Me.cbpdd.FormattingEnabled = True
        Me.cbpdd.Location = New System.Drawing.Point(117, 35)
        Me.cbpdd.Name = "cbpdd"
        Me.cbpdd.Size = New System.Drawing.Size(233, 24)
        Me.cbpdd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "盘点单："
        '
        'bok
        '
        Me.bok.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bok.Location = New System.Drawing.Point(0, 157)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(72, 28)
        Me.bok.TabIndex = 21
        Me.bok.Text = "确认"
        Me.bok.UseVisualStyleBackColor = False
        Me.bok.Visible = False
        '
        'dgtab2
        '
        Me.dgtab2.AllowUserToAddRows = False
        Me.dgtab2.AllowUserToDeleteRows = False
        Me.dgtab2.AllowUserToResizeColumns = False
        Me.dgtab2.AllowUserToResizeRows = False
        Me.dgtab2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtab2.BackgroundColor = System.Drawing.Color.White
        Me.dgtab2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgtab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtab2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgtab2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgtab2.Location = New System.Drawing.Point(214, 56)
        Me.dgtab2.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtab2.MultiSelect = False
        Me.dgtab2.Name = "dgtab2"
        Me.dgtab2.ReadOnly = True
        Me.dgtab2.RowHeadersVisible = False
        Me.dgtab2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgtab2.Size = New System.Drawing.Size(602, 105)
        Me.dgtab2.TabIndex = 19
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.TabPage1)
        Me.tab1.Controls.Add(Me.TabPage2)
        Me.tab1.Location = New System.Drawing.Point(16, 240)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(1040, 228)
        Me.tab1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgtemp2)
        Me.TabPage1.Controls.Add(Me.dgtab1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1032, 199)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgtab2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1032, 199)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WMS_盘点确认
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.gbop)
        Me.Controls.Add(Me.bok)
        Me.Name = "WMS_盘点确认"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        CType(Me.dgtab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents bok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgtab1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp2 As System.Windows.Forms.DataGridView
    Friend WithEvents cbpdd As System.Windows.Forms.ComboBox
    Friend WithEvents dgtab2 As System.Windows.Forms.DataGridView
    Friend WithEvents tab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

End Class
