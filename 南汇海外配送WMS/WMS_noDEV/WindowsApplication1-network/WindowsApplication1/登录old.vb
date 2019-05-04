Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Public Class 登录old
    Dim db As DBconfig = New DBconfig
    Dim mysqllj As String
    'Public Sub mysql_conn()
    '    Dim ip As String = 0
    '    Dim db As String = 0
    '    Dim id As String = 0
    '    Dim pw As String = 0
    '    Try
    '        Using sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\dbset.ini", System.Text.Encoding.Default)
    '            Dim line As String
    '            Do
    '                line = sr.ReadLine()
    '                If line.Trim.Contains("IP") = True Then
    '                    ip = line.Remove(0, 3)
    '                ElseIf line.Trim.Contains("DB") = True Then
    '                    db = line.Remove(0, 3)
    '                ElseIf line.Trim.Contains("ID") = True Then
    '                    id = line.Remove(0, 3)
    '                ElseIf line.Trim.Contains("PW") = True Then
    '                    pw = line.Remove(0, 3)
    '                    Exit Do
    '                Else
    '                End If
    '            Loop Until line Is Nothing
    '            sr.Close()
    '        End Using

    '        mysqllj = "server=" & ip & ";uid=" & id & ";pwd=" & pw & ";database=" & db & "; pooling=false;charset=utf8"
    '        'MsgBox(mysqllj)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub 登录_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Label1.Left = Me.Left + Me.Width / 2
        'Label2.Left = Label1.Left
        'uid.Left = Label1.Right + 5
        'pwd.Left = uid.Left
        'uid.Top = Me.Height / 2 - uid.Height - 30
        'Label1.Top = uid.Top
        'pwd.Top = uid.Bottom + 15
        'Label2.Top = pwd.Top

        'Button1.Left = pwd.Right - Button1.Width
        'Button1.Top = pwd.Bottom + 10

        'Button2.Top = Button1.Top
        'Button2.Left = pwd.Left
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        db.sel("select uid,pwd from user_info where uid ='" & uid.Text & "'", dgtemp)
        If dgtemp.RowCount = 0 Then
            MsgBox("Wrong", , "登录错误")
            Exit Sub
        Else
            If dgtemp.Rows(0).Cells(1).Value = pwd.Text Then

                Me.Hide()

                主界面.Show()
                主界面.uid.Text = uid.Text


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
End Class