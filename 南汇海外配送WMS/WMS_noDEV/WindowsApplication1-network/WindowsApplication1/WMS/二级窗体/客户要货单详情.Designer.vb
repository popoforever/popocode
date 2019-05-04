<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 客户要货单详情
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.bok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lorder = New System.Windows.Forms.Label()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdetail
        '
        Me.dgdetail.AllowUserToAddRows = False
        Me.dgdetail.AllowUserToDeleteRows = False
        Me.dgdetail.AllowUserToResizeColumns = False
        Me.dgdetail.AllowUserToResizeRows = False
        Me.dgdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgdetail.BackgroundColor = System.Drawing.Color.White
        Me.dgdetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdetail.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgdetail.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgdetail.Location = New System.Drawing.Point(15, 128)
        Me.dgdetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgdetail.MultiSelect = False
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.ReadOnly = True
        Me.dgdetail.RowHeadersVisible = False
        Me.dgdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgdetail.Size = New System.Drawing.Size(775, 332)
        Me.dgdetail.TabIndex = 19
        '
        'bok
        '
        Me.bok.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bok.Location = New System.Drawing.Point(353, 490)
        Me.bok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(99, 39)
        Me.bok.TabIndex = 20
        Me.bok.Text = "OK"
        Me.bok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Order No.:"
        '
        'lorder
        '
        Me.lorder.AutoSize = True
        Me.lorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lorder.Location = New System.Drawing.Point(136, 58)
        Me.lorder.Name = "lorder"
        Me.lorder.Size = New System.Drawing.Size(103, 25)
        Me.lorder.TabIndex = 21
        Me.lorder.Text = "Order No.:"
        '
        '客户要货单详情
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(804, 571)
        Me.Controls.Add(Me.lorder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bok)
        Me.Controls.Add(Me.dgdetail)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "客户要货单详情"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail"
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdetail As System.Windows.Forms.DataGridView
    Friend WithEvents bok As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lorder As System.Windows.Forms.Label
End Class
