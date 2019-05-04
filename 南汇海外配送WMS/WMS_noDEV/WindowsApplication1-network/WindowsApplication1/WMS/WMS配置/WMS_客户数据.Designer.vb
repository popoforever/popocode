<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS_客户数据
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
        Me.gbop = New System.Windows.Forms.GroupBox()
        Me.breset = New System.Windows.Forms.Button()
        Me.bcx = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbdata = New System.Windows.Forms.GroupBox()
        Me.bok = New System.Windows.Forms.Button()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.dgdata = New System.Windows.Forms.DataGridView()
        Me.bdel = New System.Windows.Forms.Button()
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.tcustomer = New System.Windows.Forms.TextBox()
        Me.ttel = New System.Windows.Forms.TextBox()
        Me.gbop.SuspendLayout()
        Me.gbdata.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbop
        '
        Me.gbop.Controls.Add(Me.ttel)
        Me.gbop.Controls.Add(Me.tcustomer)
        Me.gbop.Controls.Add(Me.taddress)
        Me.gbop.Controls.Add(Me.breset)
        Me.gbop.Controls.Add(Me.bcx)
        Me.gbop.Controls.Add(Me.Label3)
        Me.gbop.Controls.Add(Me.Label2)
        Me.gbop.Controls.Add(Me.Label1)
        Me.gbop.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbop.Location = New System.Drawing.Point(0, 0)
        Me.gbop.Name = "gbop"
        Me.gbop.Size = New System.Drawing.Size(1324, 132)
        Me.gbop.TabIndex = 6
        Me.gbop.TabStop = False
        Me.gbop.Text = "客户主数据"
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.breset.Location = New System.Drawing.Point(513, 79)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(72, 28)
        Me.breset.TabIndex = 21
        Me.breset.Text = "重置"
        Me.breset.UseVisualStyleBackColor = False
        '
        'bcx
        '
        Me.bcx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bcx.Location = New System.Drawing.Point(423, 79)
        Me.bcx.Name = "bcx"
        Me.bcx.Size = New System.Drawing.Size(72, 28)
        Me.bcx.TabIndex = 21
        Me.bcx.Text = "新增"
        Me.bcx.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "电话："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "地址："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "客户名："
        '
        'gbdata
        '
        Me.gbdata.Controls.Add(Me.bok)
        Me.gbdata.Controls.Add(Me.dgtemp)
        Me.gbdata.Controls.Add(Me.dgdata)
        Me.gbdata.Controls.Add(Me.bdel)
        Me.gbdata.Location = New System.Drawing.Point(3, 217)
        Me.gbdata.Name = "gbdata"
        Me.gbdata.Size = New System.Drawing.Size(909, 345)
        Me.gbdata.TabIndex = 5
        Me.gbdata.TabStop = False
        Me.gbdata.Text = "数据"
        '
        'bok
        '
        Me.bok.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bok.Location = New System.Drawing.Point(122, 30)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(96, 31)
        Me.bok.TabIndex = 20
        Me.bok.Text = "确定修改"
        Me.bok.UseVisualStyleBackColor = False
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
        Me.dgtemp.Location = New System.Drawing.Point(606, 188)
        Me.dgtemp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgtemp.Name = "dgtemp"
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtemp.Size = New System.Drawing.Size(241, 125)
        Me.dgtemp.TabIndex = 19
        Me.dgtemp.Visible = False
        '
        'dgdata
        '
        Me.dgdata.AllowUserToAddRows = False
        Me.dgdata.AllowUserToDeleteRows = False
        Me.dgdata.AllowUserToResizeColumns = False
        Me.dgdata.AllowUserToResizeRows = False
        Me.dgdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgdata.BackgroundColor = System.Drawing.Color.White
        Me.dgdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdata.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgdata.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.dgdata.Location = New System.Drawing.Point(24, 68)
        Me.dgdata.Margin = New System.Windows.Forms.Padding(4)
        Me.dgdata.MultiSelect = False
        Me.dgdata.Name = "dgdata"
        Me.dgdata.RowHeadersVisible = False
        Me.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdata.Size = New System.Drawing.Size(839, 343)
        Me.dgdata.TabIndex = 18
        '
        'bdel
        '
        Me.bdel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bdel.Location = New System.Drawing.Point(22, 30)
        Me.bdel.Name = "bdel"
        Me.bdel.Size = New System.Drawing.Size(88, 31)
        Me.bdel.TabIndex = 1
        Me.bdel.Text = "删除"
        Me.bdel.UseVisualStyleBackColor = False
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(423, 35)
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(162, 22)
        Me.taddress.TabIndex = 22
        '
        'tcustomer
        '
        Me.tcustomer.Location = New System.Drawing.Point(125, 35)
        Me.tcustomer.Name = "tcustomer"
        Me.tcustomer.Size = New System.Drawing.Size(178, 22)
        Me.tcustomer.TabIndex = 22
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(125, 79)
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(178, 22)
        Me.ttel.TabIndex = 22
        '
        'WMS_客户数据
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.gbop)
        Me.Controls.Add(Me.gbdata)
        Me.Name = "WMS_客户数据"
        Me.Size = New System.Drawing.Size(1324, 648)
        Me.gbop.ResumeLayout(False)
        Me.gbop.PerformLayout()
        Me.gbdata.ResumeLayout(False)
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbop As System.Windows.Forms.GroupBox
    Friend WithEvents breset As System.Windows.Forms.Button
    Friend WithEvents bcx As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbdata As System.Windows.Forms.GroupBox
    Friend WithEvents bok As System.Windows.Forms.Button
    Friend WithEvents dgtemp As System.Windows.Forms.DataGridView
    Friend WithEvents dgdata As System.Windows.Forms.DataGridView
    Friend WithEvents bdel As System.Windows.Forms.Button
    Friend WithEvents ttel As System.Windows.Forms.TextBox
    Friend WithEvents tcustomer As System.Windows.Forms.TextBox
    Friend WithEvents taddress As System.Windows.Forms.TextBox

End Class
