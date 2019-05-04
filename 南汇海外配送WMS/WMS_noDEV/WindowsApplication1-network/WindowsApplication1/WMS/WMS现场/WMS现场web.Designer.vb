<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMS现场web
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
        Me.pweb = New System.Windows.Forms.Panel()
        Me.web1 = New System.Windows.Forms.WebBrowser()
        Me.bsmall = New System.Windows.Forms.Button()
        Me.bbig = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pweb.SuspendLayout()
        Me.SuspendLayout()
        '
        'pweb
        '
        Me.pweb.Controls.Add(Me.web1)
        Me.pweb.Location = New System.Drawing.Point(297, 4)
        Me.pweb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pweb.Name = "pweb"
        Me.pweb.Size = New System.Drawing.Size(534, 685)
        Me.pweb.TabIndex = 0
        '
        'web1
        '
        Me.web1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.web1.Location = New System.Drawing.Point(0, 0)
        Me.web1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.web1.MinimumSize = New System.Drawing.Size(20, 24)
        Me.web1.Name = "web1"
        Me.web1.Size = New System.Drawing.Size(534, 685)
        Me.web1.TabIndex = 0
        Me.web1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'bsmall
        '
        Me.bsmall.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bsmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsmall.Location = New System.Drawing.Point(1181, 20)
        Me.bsmall.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bsmall.Name = "bsmall"
        Me.bsmall.Size = New System.Drawing.Size(112, 43)
        Me.bsmall.TabIndex = 1
        Me.bsmall.Text = "缩小"
        Me.bsmall.UseVisualStyleBackColor = False
        '
        'bbig
        '
        Me.bbig.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bbig.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbig.Location = New System.Drawing.Point(1181, 100)
        Me.bbig.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bbig.Name = "bbig"
        Me.bbig.Size = New System.Drawing.Size(111, 41)
        Me.bbig.TabIndex = 1
        Me.bbig.Text = "放大"
        Me.bbig.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'WMS现场web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.bbig)
        Me.Controls.Add(Me.bsmall)
        Me.Controls.Add(Me.pweb)
        Me.Font = New System.Drawing.Font("微软雅黑", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WMS现场web"
        Me.Size = New System.Drawing.Size(1324, 770)
        Me.pweb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pweb As System.Windows.Forms.Panel
    Friend WithEvents web1 As System.Windows.Forms.WebBrowser
    Friend WithEvents bsmall As System.Windows.Forms.Button
    Friend WithEvents bbig As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
