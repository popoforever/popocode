<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS订单
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dginput = New System.Windows.Forms.DataGridView()
        Me.open_excel = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgorder = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgtemp2 = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pdginput = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pdgorder = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgorder2 = New System.Windows.Forms.DataGridView()
        Me.pdgorder2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dginput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pdginput.SuspendLayout()
        Me.pdgorder.SuspendLayout()
        CType(Me.dgorder2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pdgorder2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dginput
        '
        Me.dginput.AllowUserToAddRows = False
        Me.dginput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dginput.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginput.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dginput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dginput.DefaultCellStyle = DataGridViewCellStyle2
        Me.dginput.Location = New System.Drawing.Point(3, 96)
        Me.dginput.Name = "dginput"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginput.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dginput.RowTemplate.Height = 24
        Me.dginput.Size = New System.Drawing.Size(1318, 240)
        Me.dginput.TabIndex = 1
        '
        'open_excel
        '
        Me.open_excel.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "订单导入"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(3, 355)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "生成订单"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgorder
        '
        Me.dgorder.AllowUserToAddRows = False
        Me.dgorder.AllowUserToDeleteRows = False
        Me.dgorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgorder.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgorder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgorder.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgorder.Location = New System.Drawing.Point(3, 429)
        Me.dgorder.Name = "dgorder"
        Me.dgorder.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgorder.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgorder.RowHeadersVisible = False
        Me.dgorder.RowTemplate.Height = 24
        Me.dgorder.Size = New System.Drawing.Size(529, 240)
        Me.dgorder.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(146, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 28)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "生成物料条码"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp.Location = New System.Drawing.Point(940, 524)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowTemplate.Height = 24
        Me.dgtemp.Size = New System.Drawing.Size(280, 105)
        Me.dgtemp.TabIndex = 8
        Me.dgtemp.Visible = False
        '
        'dgtemp2
        '
        Me.dgtemp2.AllowUserToAddRows = False
        Me.dgtemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtemp2.Location = New System.Drawing.Point(721, 526)
        Me.dgtemp2.Name = "dgtemp2"
        Me.dgtemp2.RowTemplate.Height = 24
        Me.dgtemp2.Size = New System.Drawing.Size(213, 103)
        Me.dgtemp2.TabIndex = 8
        Me.dgtemp2.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(549, 355)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(405, 23)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 355)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "条码生成中，请稍后"
        Me.Label2.Visible = False
        '
        'pdginput
        '
        Me.pdginput.BackColor = System.Drawing.Color.DimGray
        Me.pdginput.Controls.Add(Me.Label4)
        Me.pdginput.Location = New System.Drawing.Point(3, 68)
        Me.pdginput.Name = "pdginput"
        Me.pdginput.Size = New System.Drawing.Size(881, 27)
        Me.pdginput.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "订单导入结果"
        '
        'pdgorder
        '
        Me.pdgorder.BackColor = System.Drawing.Color.DimGray
        Me.pdgorder.Controls.Add(Me.Label1)
        Me.pdgorder.Location = New System.Drawing.Point(3, 399)
        Me.pdgorder.Name = "pdgorder"
        Me.pdgorder.Size = New System.Drawing.Size(529, 27)
        Me.pdgorder.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "待打印订单"
        '
        'dgorder2
        '
        Me.dgorder2.AllowUserToAddRows = False
        Me.dgorder2.AllowUserToDeleteRows = False
        Me.dgorder2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgorder2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgorder2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgorder2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgorder2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgorder2.Location = New System.Drawing.Point(649, 429)
        Me.dgorder2.Name = "dgorder2"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgorder2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgorder2.RowHeadersVisible = False
        Me.dgorder2.RowTemplate.Height = 24
        Me.dgorder2.Size = New System.Drawing.Size(529, 240)
        Me.dgorder2.TabIndex = 6
        '
        'pdgorder2
        '
        Me.pdgorder2.BackColor = System.Drawing.Color.DimGray
        Me.pdgorder2.Controls.Add(Me.Label3)
        Me.pdgorder2.Location = New System.Drawing.Point(649, 399)
        Me.pdgorder2.Name = "pdgorder2"
        Me.pdgorder2.Size = New System.Drawing.Size(529, 27)
        Me.pdgorder2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "订单状态预览"
        '
        'WMS订单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pdgorder2)
        Me.Controls.Add(Me.pdgorder)
        Me.Controls.Add(Me.pdginput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.dgtemp2)
        Me.Controls.Add(Me.dgtemp)
        Me.Controls.Add(Me.dgorder2)
        Me.Controls.Add(Me.dgorder)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dginput)
        Me.Name = "WMS订单"
        Me.Size = New System.Drawing.Size(1324, 648)
        CType(Me.dginput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtemp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pdginput.ResumeLayout(False)
        Me.pdginput.PerformLayout()
        Me.pdgorder.ResumeLayout(False)
        Me.pdgorder.PerformLayout()
        CType(Me.dgorder2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pdgorder2.ResumeLayout(False)
        Me.pdgorder2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dginput As System.Windows.Forms.DataGridView
    Friend WithEvents open_excel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgorder As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgtemp2 As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pdginput As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pdgorder As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgorder2 As System.Windows.Forms.DataGridView
    Friend WithEvents pdgorder2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
