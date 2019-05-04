Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class update
    Dim mysqllj As String
    Dim t As Thread
    Public Sub mysql_conn()
        Dim ip As String = 0
        Dim db As String = 0
        Dim id As String = 0
        Dim pw As String = 0
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            Using sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\dbset.ini", System.Text.Encoding.Default)
                Dim line As String
                Do
                    line = sr.ReadLine()
                    If line.Trim.Contains("IP") = True Then
                        ip = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("DB") = True Then
                        db = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("ID") = True Then
                        id = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("PW") = True Then
                        pw = line.Remove(0, 3)
                        Exit Do
                    Else
                    End If
                Loop Until line Is Nothing
                sr.Close()
            End Using

            mysqllj = "server=" & ip & ";uid=" & id & ";pwd=" & pw & ";database=" & db & "; pooling=false;charset=utf8"

            'MsgBox(mysqllj)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub sel(ByVal a As String, ByVal b As DataGridView)
        'Try
        Dim sqlconn As MySqlConnection = New MySqlConnection(mysqllj)
        Dim sqldpt1 As MySqlDataAdapter = New MySqlDataAdapter(a, sqlconn)
        Dim sqldataset1 As DataSet = New DataSet
        sqldataset1.Clear()
        sqldpt1.Fill(sqldataset1)
        b.DataSource = sqldataset1.Tables(0)
        'Catch ex As Exception

        'End Try

    End Sub
    Public Sub sqlcmd(ByVal cmdtext)
        Dim sqlconn As New MySqlConnection
        sqlconn.ConnectionString = mysqllj
        Dim sqlcom As MySqlCommand = New MySqlCommand()
        sqlcom.Connection = sqlconn
        sqlcom.CommandText = cmdtext
        sqlconn.Open()
        sqlcom.ExecuteNonQuery()
        sqlconn.Close()
    End Sub

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        sel("select version from version order by id desc limit 1", dgtemp)
        t1.Text = dgtemp.Rows(0).Cells(0).Value
        t3.Text = "MES Thailand.exe"
        t4.Text = "\\10.178.188.50\mes"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Confirm to update？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If
        sqlcmd("insert into version (version,mark,datetime) values ('" & t1.Text & "','" & t2.Text & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")
        MsgBox("新版本描述更新完成")
        sel("select * from version order by id desc", dgtemp)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sel("select mark from version order by id desc limit 1", dgtemp)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Confirm to update？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If
        CheckForIllegalCrossThreadCalls = False
        ProgressBar1.Visible = True
        Label1.Text = "更新中，请稍后"
        ProgressBar1.Value = 35%
        ' Label1.Left = Me.Width / 2 - Label1.Width / 2
        t = New Thread(AddressOf testA)
        t.Start()

    End Sub
    Public Sub testA()
        File.Delete(t4.Text & "\" & t3.Text)
        ProgressBar1.Value = 60%
        ' MsgBox(1)
        'Dim documentURL
        'Dim dlFileName
        'documentURL = "http://p2qmogkyo.bkt.clouddn.com/MES%20Thailand.exe"
        'dlFileName = Application.StartupPath & "\" & app
        'Dim wc As New System.Net.WebClient
        'wc.DownloadFile(documentURL, dlFileName)
        'ProgressBar1.Value = 100%


        File.Copy(Application.StartupPath & "\" & t3.Text, t4.Text & "\" & t3.Text, True)
        ProgressBar1.Value = 100%
        MsgBox("done")



    End Sub
End Class