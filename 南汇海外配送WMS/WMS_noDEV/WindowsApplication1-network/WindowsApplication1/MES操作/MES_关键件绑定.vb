Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient

Public Class MES_关键件绑定
    Dim mysqllj As String
    Dim op As String = 0
    Dim sta As String = 0
 
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
    Public Sub station()
       
        Try
            Using sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\station.ini", System.Text.Encoding.Default)
                Dim line As String
                Do
                    line = sr.ReadLine()
                    If line.Trim.Contains("station") = True Then
                        sta = line.Remove(0, 8)
                    ElseIf line.Trim.Contains("operator") = True Then
                        op = line.Remove(0, 9)
                        Exit Do
                    Else
                    End If
                Loop Until line Is Nothing
                sr.Close()
            End Using

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

    Private Sub MES_关键件绑定_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        station()

        gb1.Left = Me.Left + 15
        gb2.Left = gb1.Left
        gb1.Top = Me.Top + 15
        gb2.Top = gb1.Bottom + 10
        gb1.Width = (Me.Width - 30) / 2 - 10
        gb2.Width = gb1.Width
        Panel1.Top = gb2.Bottom + 10
        Panel1.Left = gb1.Left
        Panel1.Width = gb1.Width
        Panel1.Height = Me.Height - gb2.Height - gb1.Height - 45

        gb3.Left = gb1.Right + 15
        gb3.Top = Me.Top + 15
        gb3.Width = Me.Width - 45 - gb1.Width

        dg2.Left = gb3.Left
        dg2.Top = gb3.Bottom + 30
        dg2.Width = gb3.Width
        dg2.Height = Me.Height - 15 - 30 - 15 - gb3.Height

        barlabel.Visible = False
        partlabel.Visible = False
        deslabel.Visible = False
        parttypelabel.Visible = False
        cartypelabel.Visible = False

        msgnext.Left = Me.Left + 15
        msgnext.Top = Me.Top + 20
        msglast.Left = Me.Left + 15
        msglast.Top = msgnext.Top + 60

        pb1.Height = gb3.Height / 1.2
        pb1.Width = gb3.Height * 4 / 3
        pb1.Left = Me.Left + gb3.Width - pb1.Width - 5
        pb1.Top = gb3.Top + 5
    End Sub
    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.Enter Then
            msglast.Visible = False
            sel("select barcode,cus_partno,description,parttype,cartype,status from record where barcode = '" & t1.Text & "'", dgtemp)
            If dgtemp.RowCount = 0 Then
                msg1.Text = "The barcode is not exist, please check"
                Panel1.BackColor = Color.Brown
                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                t1.Focus()
                t1.SelectAll()
                Exit Sub
            End If
            barlabel.Visible = True
            partlabel.Visible = True
            deslabel.Visible = True
            parttypelabel.Visible = True
            cartypelabel.Visible = True
            barlabel.Text = dgtemp.Rows(0).Cells(0).Value
            partlabel.Text = dgtemp.Rows(0).Cells(1).Value
            deslabel.Text = dgtemp.Rows(0).Cells(2).Value
            parttypelabel.Text = dgtemp.Rows(0).Cells(3).Value
            cartypelabel.Text = dgtemp.Rows(0).Cells(4).Value

            If File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.png") Then
                pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.png"
            ElseIf File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.jpg") Then
                pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.jpg"
            End If

            sel("select type,typebarcode,create_datetime from keypart_record where barcode ='" & t1.Text & "'", dg2)
            If dgtemp.Rows(0).Cells(5).Value > 1 Then
                msg1.Text = "The barcode has been done in this station"
                Panel1.BackColor = Color.Blue
                t1.Focus()
                t1.SelectAll()
                Exit Sub
            End If


            sel("select barcode,type from keypart_record where barcode = '" & t1.Text & "' order by id", dgtemp)
            If dgtemp.RowCount = 0 Then
            Else
                msglast.Visible = True
                msglast.Text = dgtemp.Rows(0).Cells(1).Value
            End If
            Dim test As String = op '根据station.ini文件里的operator中"/" 分割出需要绑定的关键件类型
            Dim arr As String() = test.Split(New String() {"/"}, StringSplitOptions.RemoveEmptyEntries)
            Dim a As Integer = 0
            Dim keybar As String = 0
            For Each s As String In arr
                sel("select type,typebarcode,create_datetime from keypart_record where barcode ='" & t1.Text & "'", dg2)
                Console.WriteLine(s)
                sel("select type from keypart_record where barcode='" & t1.Text & "' and type = '" & s.ToUpper & "'", dgtemp)
                If dgtemp.RowCount > 0 Then
                    '判断该关键件是否绑定完成
                    msglast.Visible = True
                    msglast.Text = "Last keypart: " & dgtemp.Rows(0).Cells(0).Value
                Else
                    sel("select cus_partno,keypartchar,keypartname from keypartmodel where keypartname = '" & s.ToUpper & "' and cus_partno = '" & partlabel.Text & "'", dgtemp)
                    If dgtemp.RowCount = 0 Then
                        '如果该零件没有绑定主数据，则跳过
                    Else
                        msgnext.Visible = True
                        msgnext.Text = "Next keypart: " & dgtemp.Rows(0).Cells(2).Value
                        keybar = InputBox(dgtemp.Rows(0).Cells(2).Value, "请扫描关键零件条码")
                        If keybar = "000" Then
                            t1.Focus()
                            t1.SelectAll()
                            msg1.Text = dgtemp.Rows(0).Cells(2).Value & " canceled"
                            Exit Sub
                        End If
                    
                        If keybar.Contains(dgtemp.Rows(0).Cells(1).Value) Then
                            '符合绑定规则，通过
                            '去重复
                            sel("select typebarcode,barcode from keypart_record where typebarcode = '" & keybar & "'", dgtemp2)
                            If dgtemp2.RowCount > 0 Then
                                msg1.Text = "The keypart " & keybar & " has been matched by " & dgtemp2.Rows(0).Cells(1).Value & ""
                                Panel1.BackColor = Color.Brown
                                t1.Focus()
                                t1.SelectAll()
                                Exit Sub
                            End If
                            sqlcmd("insert into keypart_record (barcode,type,typebarcode,create_datetime) values ('" & t1.Text & "','" & dgtemp.Rows(0).Cells(2).Value & "','" & keybar & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")
                            Panel1.BackColor = Color.Green
                            msg1.Text = dgtemp.Rows(0).Cells(2).Value & " match OK"
                        Else
                            '关键件特征码不符合，报错
                            msg1.Text = "The keypart is not correct, please check"
                            Panel1.BackColor = Color.Brown
                            t1.Focus()
                            t1.SelectAll()
                            Exit Sub
                        End If

                    End If
                End If
            Next
            '所有零件绑定完成
            Panel1.BackColor = Color.Green
            sel("select type,typebarcode,create_datetime from keypart_record where barcode ='" & t1.Text & "'", dg2)
            Try
                msglast.Visible = True
                msg1.Text = dgtemp.Rows(0).Cells(2).Value & " match OK" & vbCrLf & " ALL keyparts have matched OK"
                msglast.Text = "Last keypart: " & dgtemp.Rows(0).Cells(2).Value
            Catch ex As Exception
                msglast.Visible = True
                msglast.Text = "The part no need keypart"
            End Try
       
            msgnext.Text = "ALL keyparts have matched OK"

            '生产报工
            sel("select ecn_no from bom_info where f_part ='" & partlabel.Text & "' and status = 1 limit 0,1", dgtemp)
            If dgtemp.RowCount = 0 Then
                msg1.Text = "The part_no : " & partlabel.Text & " has not a BOM, Please have check"

                Panel1.BackColor = Color.Blue
                sqlcmd("update record set station = 'offline',status = 2,bom_ecn = 'empty',offlinedatetime = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where barcode = '" & t1.Text & "'")
                sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','offline','offline','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

            Else
                sqlcmd("update record set station = 'offline',status = 2,bom_ecn = '" & dgtemp.Rows(0).Cells(0).Value & "',offlinedatetime = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where barcode = '" & t1.Text & "'")
                sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','offline','offline','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

            End If
            t1.Text = ""
            t1.Focus()
            t1.Select()
        End If


    End Sub
End Class
