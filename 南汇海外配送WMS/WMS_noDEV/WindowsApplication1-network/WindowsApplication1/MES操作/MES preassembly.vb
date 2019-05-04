Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient

Public Class mes_preassembly
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

    Private Sub MES_preassembly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
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

        Label1.Left = gb1.Right + 15
        Label1.Top = Label3.Top
        dg1.Left = Label1.Left
        dg1.Top = Label1.Bottom + 5
        dg1.Width = Me.Width - 45 - gb1.Width
        dg2.Width = dg1.Width
        dg1.Height = (Me.Height - 50 - Label1.Height - Label2.Height) / 3
        dg2.Height = dg1.Height * 2

        dg2.Left = dg1.Left
        Label2.Left = dg1.Left
        Label2.Top = dg1.Bottom + 10
        dg2.Top = Label2.Bottom + 5
        dg2.Visible = False
        Label2.Visible = False
        Button1.Left = dg1.Left
        Button1.Top = dg1.Bottom + 5

        r1.Left = Label1.Right + 100
        r2.Left = r1.Right + 50
        r1.Top = Label1.Top
        r2.Top = r1.Top
        r1.Checked = True


        pb1.Height = Me.Height - Button1.Bottom - 15
        pb1.Width = dg2.Width * 4 / 3
        pb1.Left = Me.Width - (dg2.Width / 2 + 15) - pb1.Width / 2
        pb1.Top = Button1.Bottom + 10

        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 0 order by id ", dg1)
        sel("select a.barcode,a.cus_partno,a.description,a.parttype,a.cartype from record a join transaction_info_mes b where a.barcode = b.barcode and a.seattype = 'F' and a.seq1 = 1 order by b.id desc limit 0,20 ", dg2)

        t1.Text = ""
        t1.Focus()
        t1.Select()
        barlabel.Visible = False
        partlabel.Visible = False
        deslabel.Visible = False
        parttypelabel.Visible = False
        cartypelabel.Visible = False

     

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dg1.RowCount = 0 Then
                msg1.Text = "No preassemble order, please check"
                Panel1.BackColor = Color.Brown
                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                Exit Sub
            End If
            '扫描过程条码，如果符合第一条顺序，则消除队列
           
            If t1.Text = dg1.Rows(0).Cells(0).Value Then
              

                If r1.Checked Then
                    sqlcmd("update record set seq1 = 1,status = 1,station = 'preassembly' where barcode = '" & t1.Text & "'")
                    msg1.Text = "The barcode ( " & t1.Text & " ) is ok, please do next"
                    sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','preassembly','preassembly','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

                    sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 0 order by id ", dg1)
                    sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 1 order by id desc limit 0,20", dg2)
                ElseIf r2.Checked Then

                    sqlcmd("update record set seq2 = 1,status = 1,station = 'preassembly' where keypart5 = '" & t1.Text & "'")
                    msg1.Text = "The barcode ( " & t1.Text & " ) is ok, please do next"
                    sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','preassembly','preassembly','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

                    sel("select keypart5,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq2 = 0 order by id ", dg1)
                    sel("select keypart5,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq2 = 1 order by id desc limit 0,20", dg2)

                End If

                
          

                Panel1.BackColor = Color.Green
                t1.Text = ""
                t1.Select()
                barlabel.Visible = True
                partlabel.Visible = True
                deslabel.Visible = True
                parttypelabel.Visible = True
                cartypelabel.Visible = True
                barlabel.Text = dg2.Rows(0).Cells(0).Value
                partlabel.Text = dg2.Rows(0).Cells(1).Value
                deslabel.Text = dg2.Rows(0).Cells(2).Value
                parttypelabel.Text = dg2.Rows(0).Cells(3).Value
                cartypelabel.Text = dg2.Rows(0).Cells(4).Value

                If File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.png") Then
                    pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.png"
                ElseIf File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.jpg") Then
                    pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "preassembly.jpg"
                End If
            Else
                msg1.Text = "The product ( " & t1.Text & " ) is not the next product, please check"

                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                Panel1.BackColor = Color.Brown
                t1.Text = ""
                t1.Select()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub r1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.CheckedChanged
        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 0 order by id ", dg1)
        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 1 order by id desc limit 0,20 ", dg2)
        t1.Text = ""
        t1.Select()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.CheckedChanged
        sel("select keypart5,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq2 = 0 order by id ", dg1)
        sel("select  keypart5,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq2 = 1 order by id desc limit 0,20", dg2)
        t1.Text = ""
        t1.Select()

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dg2.Visible = True Then
            dg2.Visible = False
            Label2.Visible = False
            pb1.Visible = True
        Else
            dg2.Visible = True
            Label2.Visible = True
            pb1.Visible = False
        End If
        t1.Focus()
        t1.SelectAll()

    End Sub

    Private Sub dg1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellClick
        Dim index As String = dg1.CurrentCell.RowIndex
        If File.Exists(Application.StartupPath & "\pic\" & dg1.Rows(index).Cells(1).Value & "_" & "preassembly.png") Then
            pb1.ImageLocation = Application.StartupPath & "\pic\" & dg1.Rows(index).Cells(1).Value & "_" & "preassembly.png"
        ElseIf File.Exists(Application.StartupPath & "\pic\" & dg1.Rows(index).Cells(1).Value & "_" & "preassembly.jpg") Then
            pb1.ImageLocation = Application.StartupPath & "\pic\" & dg1.Rows(index).Cells(1).Value & "_" & "preassembly.jpg"
        Else
            pb1.ImageLocation = Nothing
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 0 order by id ", dg1)
        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and seq1 = 1 order by id desc limit 0,20 ", dg2)
        t1.Focus()
        t1.SelectAll()
    End Sub


End Class
