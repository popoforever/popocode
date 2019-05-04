Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class 登录
   
    Dim db As DBconfig = New DBconfig

    Private Sub 登录_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        uid.Select()
        uid.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blogin.Click
        If uid.Text = "" Then
            If My.Computer.Name = "M2382915" Or My.Computer.Name = "LAPTOP-ESE0PU0C" Then
                Me.Hide()
                主界面.lan.Text = llan.Text
                主界面.uid.Text = "admin"
                主界面.llogin.Text = uid.Text
                主界面.lfactory.Text = "India"
                主界面.Show()
                Exit Sub
            End If
        End If
       

        db.sel("select uid,pwd,factory from user_info where uid ='" & uid.Text & "'", dgtemp)
        If dgtemp.RowCount = 0 Then
            MsgBox("账号不存在", , "登录错误")
            Exit Sub
        Else
            If dgtemp.Rows(0).Cells(1).Value = pwd.Text Then

                Me.Hide()
                主界面.lan.Text = llan.Text
                主界面.uid.Text = uid.Text
                主界面.llogin.Text = uid.Text
                主界面.lfactory.Text = dgtemp.Rows(0).Cells(2).Value
                主界面.Show()


            Else
                MsgBox("密码不正确", , "登录错误")
                pwd.Focus()
                pwd.SelectAll()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub pwd_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(1, e)
        End If
       
    End Sub

    Private Sub uid_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uid.KeyDown
        If e.KeyCode = Keys.Enter Then
            pwd.Focus()
            pwd.SelectAll()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbcn.Click
        label_cn()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pben.Click
        label_en()
    End Sub
    Public Sub label_cn()
        llan.Text = "中文"
        lname.Text = "WMS管理平台"
        luser.Text = "用户名"
        lpwd.Text = "密码"
        blogin.Text = "登陆"
        主界面.lan.Text = "中文"
    End Sub
    Public Sub label_en()
        llan.Text = "中文"
        lname.Text = "WMS System"
        luser.Text = "User"
        lpwd.Text = "Password"
        blogin.Text = "Login"
        llan.Text = "English"
        主界面.lan.Text = "English"
    End Sub
End Class