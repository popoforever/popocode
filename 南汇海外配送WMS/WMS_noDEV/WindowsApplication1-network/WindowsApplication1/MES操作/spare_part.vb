Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient

Public Class spare_part
    Dim mysqllj As String
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

    Private Sub spare_part_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        gb1.Left = Me.Left + 15
        gb1.Top = Me.Top + 15
        gb1.Width = Me.Width - 30
        gb1.Height = Me.Height / 4
        dgsel.Left = gb1.Left
        dgsel.Top = gb1.Bottom + 15
        dgsel.Width = (gb1.Width - 30) * 2 / 3
        dgsel.Height = Me.Height / 2
        Button1.Top = dgsel.Bottom + 10
        Button1.Left = dgsel.Left
        dghis.Left = dgsel.Right + 30
        dghis.Top = dgsel.Top
        dghis.Width = dgsel.Width / 2
        dghis.Height = dgsel.Height

        sel("select cus_partno from model where spare = 1", dgtemp)
        sel("select barcode,cus_partno,description,parttype,description2 from record where spare = 1 order by id desc limit 0,20", dghis)

        Dim i As Integer
        For i = 0 To dgtemp.RowCount - 1
            typesel.Items.Add(dgtemp.Rows(i).Cells(0).Value)
        Next
        typesel.Items.Add("please select a spare partno")
        typesel.Text = "please select a spare partno"
        dgprintfront.Columns.Add("1", "cus_partno")
        dgprintfront.Columns.Add("2", "jci_partno")
        dgprintfront.Columns.Add("3", "description")
        dgprintfront.Columns.Add("4", "parttype")
        dgprintfront.Columns.Add("5", "description2")
        dgprintfront.Columns.Add("6", "cartype")
        dgprintback.Columns.Add("1", "cus_partno")
        dgprintback.Columns.Add("2", "jci_partno")
        dgprintback.Columns.Add("3", "description")
        dgprintback.Columns.Add("4", "parttype")
        dgprintback.Columns.Add("5", "description2")
        dgprintback.Columns.Add("6", "cartype")
    End Sub
    Private Sub typesel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typesel.SelectedIndexChanged
        sel("select cus_partno,jci_partno,description,parttype,description2,cartype from model where cus_partno like '%" & typesel.Text & "%' and spare = 1  ", dgsel)
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Confirm to print spare part bacode?？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dgsel.RowCount = 0 Then
            MsgBox(" The print list can not be empty !")
            Exit Sub
        End If

        Dim code As String = ""
        Dim que As Integer = 1
        Dim j As Integer = 1
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSspare.txt", "", False)
        For j = 1 To num.Value


            For i = 0 To dgsel.RowCount - 1
                sel("select barcode from record order by id desc limit 0,100", dgtemp)
                Try
                    If dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) = 9999 Then
                        que = 1
                    Else
                        que = dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) + 1
                    End If
                Catch ex As Exception
                    que = 1
                End Try

                'Try
                code = dgsel.Rows(i).Cells(0).Value.remove(0, dgsel.Rows(i).Cells(0).Value.length - 8) & Format(Now, "yyMMdd") & Format(que, "0000")

                'MsgBox(code)
                My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSspare.txt", code & "," & dgsel.Rows(i).Cells(0).Value & "," & dgsel.Rows(i).Cells(1).Value & "," & dgsel.Rows(i).Cells(2).Value & "," & dgsel.Rows(i).Cells(3).Value & "," & dgsel.Rows(i).Cells(4).Value & "," & dgsel.Rows(i).Cells(5).Value & "," & Format(Now, "yyyy-MM-dd HH:mm:ss" & vbCrLf), True)
                sqlcmd("insert into record(barcode,cus_partno,jci_partno,description,parttype,description2,cartype,printdatetime,status,spare,station) values('" & code & "','" & dgsel.Rows(i).Cells(0).Value & "','" & dgsel.Rows(i).Cells(1).Value & "','" & dgsel.Rows(i).Cells(2).Value & "','" & dgsel.Rows(i).Cells(3).Value & "','" & dgsel.Rows(i).Cells(4).Value & "' , '" & dgsel.Rows(i).Cells(5).Value & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','0','1','order')")
                sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & code & "','spare_order','spare_order','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")


                'Catch ex As Exception

                'End Try
            Next
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSspare.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\BSspare.BTW" & " /p /x", False, System.Text.Encoding.Default)
        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\BSspare.txt").Contains(",") = True Then
            Shell("cmd.exe /C " & Application.StartupPath & "\BSspare.cmd", AppWinStyle.Hide, False)
        End If

        typesel.Text = "please select a spare partno"
        sel("select cus_partno,jci_partno,description,parttype,description2,cartype from model where cus_partno like '%" & typesel.Text & "%'  ", dgsel)
        sel("select barcode,cus_partno,description,parttype,description2 from record where spare = 1 order by id desc limit 0,20", dghis)

    End Sub
End Class
