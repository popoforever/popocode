Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Public Class MES_order
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
    Private Sub order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()

        gb1.Top = Me.Top + 15
        gb1.Left = Me.Left + 15
        gb1.Width = (Me.Width - 80) / 2

        dgsel.Top = gb1.Bottom + 15
        dgsel.Left = gb1.Left
        dgsel.Width = gb1.Width
        dgsel.Height = Me.Height - 55 - gb1.Height - Button1.Height
        Button1.Left = dgsel.Left
        Button1.Top = dgsel.Bottom + 10

        dgprintfront.Left = gb1.Right + 50
        dgprintfront.Top = gb1.Top
        dgprintfront.Width = dgsel.Width
        dgprintfront.Height = (Me.Height - 65 - Button2.Height - Button3.Height) / 2
        Button2.Top = dgprintfront.Bottom + 10
        Button2.Left = dgprintfront.Left
        dgprintback.Left = dgprintfront.Left
        dgprintback.Top = Button2.Bottom + 15
        dgprintback.Width = dgprintfront.Width
        dgprintback.Height = dgprintfront.Height
        Button3.Left = dgprintback.Left
        Button3.Top = dgprintback.Bottom + 10


        kanbaninput.Select()
        'typesel.Enabled = False
        'sel("select jci_partno,description,cardescription,parttype,description2,cartype from model", dgsel)
        sel("select parttype from model group by parttype", dgtemp)
        Dim i As Integer
        For i = 0 To dgtemp.RowCount - 1
            typesel.Items.Add(dgtemp.Rows(i).Cells(0).Value)
        Next

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

        'sel("select barcode from orderlist where createdate between '" & Now.Date & " 00:00" & "' and '" & Now.Date & " 23:59" & "'order by id desc ", dgtemp)

    End Sub

    Private Sub typesel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typesel.SelectedIndexChanged

        sel("select cus_partno,jci_partno,description,parttype,description2,cartype from model where parttype like '%" & typesel.Text & "%' and spare = 0 ", dgsel)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox(" Confirm to add parts to printlist？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If
        Dim i As Integer
        Dim j As Integer
        Try
            For j = 1 To num.Value
                For i = 0 To dgsel.RowCount - 1
                    If dgsel.Rows(i).Cells(4).Value.contains("REAR") Or dgsel.Rows(i).Cells(4).Value.contains("rear") = True Then
                        dgprintback.Rows.Add(dgsel.Rows(i).Cells(0).Value, dgsel.Rows(i).Cells(1).Value, dgsel.Rows(i).Cells(2).Value, dgsel.Rows(i).Cells(3).Value, dgsel.Rows(i).Cells(4).Value, dgsel.Rows(i).Cells(5).Value)
                    Else
                        dgprintfront.Rows.Add(dgsel.Rows(i).Cells(0).Value, dgsel.Rows(i).Cells(1).Value, dgsel.Rows(i).Cells(2).Value, dgsel.Rows(i).Cells(3).Value, dgsel.Rows(i).Cells(4).Value, dgsel.Rows(i).Cells(5).Value)

                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox("Print number wrong")
        End Try


    End Sub

    Private Sub dgsel_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgsel.CellContentDoubleClick
        If MsgBox("Confirm to add parts to printlist？", MsgBoxStyle.YesNo, "MSG") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If

        Dim i As Integer
        Try
            Dim index As String = dgsel.CurrentCell.RowIndex
            For i = 1 To num.Value

                If dgsel.Rows(index).Cells(4).Value.contains("REAR") Or dgsel.Rows(index).Cells(4).Value.contains("rear") = True Then
                    dgprintback.Rows.Add(dgsel.Rows(index).Cells(0).Value, dgsel.Rows(index).Cells(1).Value, dgsel.Rows(index).Cells(2).Value, dgsel.Rows(index).Cells(3).Value, dgsel.Rows(index).Cells(4).Value, dgsel.Rows(index).Cells(5).Value)
                Else
                    dgprintfront.Rows.Add(dgsel.Rows(index).Cells(0).Value, dgsel.Rows(index).Cells(1).Value, dgsel.Rows(index).Cells(2).Value, dgsel.Rows(index).Cells(3).Value, dgsel.Rows(index).Cells(4).Value, dgsel.Rows(index).Cells(5).Value)

                End If
            Next
        Catch ex As Exception
            MsgBox("Print number wrong")
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' sqlcmd("insert into orderlist(createdate) values ('" & Now.Date & " 10:27" & "')")
        If MsgBox("Confirm to print front part bacode?？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dgprintfront.RowCount = 0 Then
            MsgBox(" The print list can not be empty !")
            Exit Sub
        End If

        Dim code As String = ""
        Dim que As Integer = 1
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSfront.txt", "", False)

        For i = 0 To dgprintfront.RowCount - 1
            sel("select barcode from record order by id desc limit 0,1 ", dgtemp)
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
            code = dgprintfront.Rows(i).Cells(0).Value.remove(0, dgprintfront.Rows(i).Cells(0).Value.length - 8) & Format(Now, "yyMMdd") & Format(que, "0000")

            'MsgBox(code)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSfront.txt", code & "," & dgprintfront.Rows(i).Cells(0).Value & "," & dgprintfront.Rows(i).Cells(1).Value & "," & dgprintfront.Rows(i).Cells(2).Value & "," & dgprintfront.Rows(i).Cells(3).Value & "," & dgprintfront.Rows(i).Cells(4).Value & "," & dgprintfront.Rows(i).Cells(5).Value & "," & Format(Now, "yyyy-MM-dd HH:mm:ss" & vbCrLf), True)
            sqlcmd("insert into record(barcode,cus_partno,jci_partno,description,parttype,description2,cartype,printdatetime,status,keypart5,seattype,station) values('" & code & "','" & dgprintfront.Rows(i).Cells(0).Value & "','" & dgprintfront.Rows(i).Cells(1).Value & "','" & dgprintfront.Rows(i).Cells(2).Value & "','" & dgprintfront.Rows(i).Cells(3).Value & "','" & dgprintfront.Rows(i).Cells(4).Value & "' , '" & dgprintfront.Rows(i).Cells(5).Value & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','0','" & code & "X" & "','F','order')")
            sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & code & "','order','order','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")
            'Catch ex As Exception

            'End Try
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSfront.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\BSfront.BTW" & " /p /x", False, System.Text.Encoding.Default)
        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\BSfront.txt").Contains(",") = True Then
            Shell("cmd.exe /C " & Application.StartupPath & "\BSfront.cmd", AppWinStyle.Hide, False)
        End If

        dgprintfront.Rows.Clear()
        kanbaninput.Text = ""
        kanbaninput.Select()




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox("Confirm to print rear part bacode？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dgprintback.RowCount = 0 Then
            MsgBox("The print list can not be empty !")
            Exit Sub
        End If

        Dim code As String = ""
        Dim que As Integer = 1
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSback.txt", "", False)

        For i = 0 To dgprintback.RowCount - 1
            sel("select barcode from record order by id desc limit 0,200", dgtemp)
            Try
                If dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) = 9999 Then
                    que = 1
                Else
                    que = dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) + 1
                End If
            Catch ex As Exception

            End Try

            'Try
            code = dgprintback.Rows(i).Cells(0).Value.remove(0, dgprintback.Rows(i).Cells(0).Value.length - 8) & Format(Now, "yyMMdd") & Format(que, "0000")

            'MsgBox(code)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSback.txt", code & "," & dgprintback.Rows(i).Cells(0).Value & "," & dgprintback.Rows(i).Cells(1).Value & "," & dgprintback.Rows(i).Cells(2).Value & "," & dgprintback.Rows(i).Cells(3).Value & "," & dgprintback.Rows(i).Cells(4).Value & "," & dgprintback.Rows(i).Cells(5).Value & "," & Format(Now, "yyyy-MM-dd HH:mm:ss" & vbCrLf), True)
            sqlcmd("insert into record(barcode,cus_partno,jci_partno,description,parttype,description2,cartype,printdatetime,status,seattype,station) values('" & code & "','" & dgprintback.Rows(i).Cells(0).Value & "','" & dgprintback.Rows(i).Cells(1).Value & "','" & dgprintback.Rows(i).Cells(2).Value & "','" & dgprintback.Rows(i).Cells(3).Value & "','" & dgprintback.Rows(i).Cells(4).Value & "' , '" & dgprintback.Rows(i).Cells(5).Value & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','0','R','order')")
            sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & code & "','order','order','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

            'Catch ex As Exception
            'End Try
        Next
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\BSback.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\BSback.BTW" & " /p /x", False, System.Text.Encoding.Default)
        If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\BSback.txt").Contains(",") = True Then
            Shell("cmd.exe /C " & Application.StartupPath & "\BSback.cmd", AppWinStyle.Hide, False)
        End If
        dgprintback.Rows.Clear()
        kanbaninput.Text = ""
        kanbaninput.Select()
    End Sub


    Private Sub kanbaninput_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles kanbaninput.KeyDown

        If e.KeyCode = Keys.Enter Then

            sel("select * from model where KANBANlabel like '" & kanbaninput.Text & "' and spare = 0", dgkanban)
            dgprintfront.Rows.Clear()
            dgprintback.Rows.Clear()

            Dim i As Integer
            Dim j As Integer
            For j = 1 To num.Value

                For i = 0 To dgkanban.RowCount - 1
                    If dgkanban.Rows(i).Cells(4).Value.contains("REAR") Or dgkanban.Rows(i).Cells(4).Value.contains("rear") = True Then
                        dgprintback.Rows.Add(dgkanban.Rows(i).Cells(0).Value, dgkanban.Rows(i).Cells(1).Value, dgkanban.Rows(i).Cells(2).Value, dgkanban.Rows(i).Cells(3).Value, dgkanban.Rows(i).Cells(4).Value, dgkanban.Rows(i).Cells(5).Value)
                    Else
                        dgprintfront.Rows.Add(dgkanban.Rows(i).Cells(0).Value, dgkanban.Rows(i).Cells(1).Value, dgkanban.Rows(i).Cells(2).Value, dgkanban.Rows(i).Cells(3).Value, dgkanban.Rows(i).Cells(4).Value, dgkanban.Rows(i).Cells(5).Value)
                    End If

                Next

            Next
            kanbaninput.SelectAll()
            kanbaninput.Focus()

        End If



    End Sub


    Private Sub pw1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pw1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If pw1.Text = "123123" Then
                typesel.Enabled = True
                pw1.Visible = False
                Label3.Visible = False
            Else
                MsgBox("wrong password")
                pw1.SelectAll()

                Exit Sub
            End If

        End If

    End Sub



End Class
