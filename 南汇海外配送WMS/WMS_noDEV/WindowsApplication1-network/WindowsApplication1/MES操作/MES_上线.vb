Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient

Public Class MES_上线
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
    Dim sqlconn As MySqlConnection
    Public Sub sel(ByVal a As String, ByVal b As DataGridView)
        'Try

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
    Private Sub MES_上线_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        sqlconn = New MySqlConnection(mysqllj)
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

        pb1.Height = Me.Height - Button1.Bottom - 15
        pb1.Width = dg2.Width * 4 / 3
        pb1.Left = Me.Width - (dg2.Width / 2 + 15) - pb1.Width / 2
        pb1.Top = Button1.Bottom + 10

        cbox1.Checked = True

        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and station = 'preassembly'  order by id ", dg1)
        sel("select a.barcode,a.cus_partno,a.description,a.parttype,a.cartype from record a join transaction_info_mes b where a.barcode = b.barcode and a.seattype = 'F' and b.transaction = 'online' order by b.id desc limit 0,20 ", dg2)
        t1.Text = ""
        t1.Focus()
        t1.Select()
        barlabel.Visible = False
        partlabel.Visible = False
        deslabel.Visible = False
        parttypelabel.Visible = False
        cartypelabel.Visible = False
    End Sub



    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles t1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sel("select datetime from transaction_info_mes where barcode = '" & t1.Text & "' and transaction = 'online'", dgtemp)
            If dgtemp.RowCount > 0 Then

                msg1.Text = "The barcode has finished this operation at " & dgtemp.Rows(0).Cells(0).Value & " , please check"
                Panel1.BackColor = Color.Brown
                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                t1.Text = ""
                t1.Select()
                Exit Sub
            End If
            If dg1.RowCount = 0 Then
                msg1.Text = "No Online order, please check"
                Panel1.BackColor = Color.Brown
                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                t1.Text = ""
                t1.Select()
                Exit Sub
            End If
            If cbox1.Checked = True Then ' 排序按钮开启，则只允许当前第一个座椅上线。
                If t1.Text = dg1.Rows(0).Cells(0).Value Then

                    sqlcmd("update record set status = 1,station = 'online' where barcode = '" & t1.Text & "'")
                    msg1.Text = "The barcode ( " & t1.Text & " ) is ok, please do next"
                    sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','online','front_online','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

                    sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and station = 'preassembly'  order by id ", dg1)
                    sel("select a.barcode,a.cus_partno,a.description,a.parttype,a.cartype from record a join transaction_info_mes b where a.barcode = b.barcode and a.seattype = 'F' and b.transaction = 'online' order by b.id desc limit 0,20 ", dg2)

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

                    If File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.png") Then
                        pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.png"
                    ElseIf File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.jpg") Then
                        pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.jpg"
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
            Else ' 排序按钮不勾起，只需在队列中即可
                Dim index As String = 0
                For i = 0 To dg1.RowCount - 1
                    If t1.Text = dg1.Rows(i).Cells(0).Value Then
                        index = i
                        GoTo 1
                    End If
                Next
                msg1.Text = "The product ( " & t1.Text & " ) is not in online plan, please check"

                barlabel.Visible = False
                partlabel.Visible = False
                deslabel.Visible = False
                parttypelabel.Visible = False
                cartypelabel.Visible = False
                Panel1.BackColor = Color.Brown
                t1.Text = ""
                t1.Select()
                Exit Sub


1:              sqlcmd("update record set status = 1,station = 'online' where barcode = '" & t1.Text & "'")
                msg1.Text = "The barcode ( " & t1.Text & " ) is ok, please do next"
                sqlcmd("insert into transaction_info_MES (barcode,transaction,station,datetime,user_id) values ('" & t1.Text & "','online','front_online','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & WMSmain.uid.Text & "')")

                sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and station = 'preassembly'  order by id ", dg1)
                sel("select a.barcode,a.cus_partno,a.description,a.parttype,a.cartype from record a join transaction_info_mes b where a.barcode = b.barcode and a.seattype = 'F' and b.transaction = 'online' order by b.id desc limit 0,20 ", dg2)

                Panel1.BackColor = Color.Green
                t1.Text = ""
                t1.Select()
                barlabel.Visible = True
                partlabel.Visible = True
                deslabel.Visible = True
                parttypelabel.Visible = True
                cartypelabel.Visible = True
                barlabel.Text = dg2.Rows(index).Cells(0).Value
                partlabel.Text = dg2.Rows(index).Cells(1).Value
                deslabel.Text = dg2.Rows(index).Cells(2).Value
                parttypelabel.Text = dg2.Rows(index).Cells(3).Value
                cartypelabel.Text = dg2.Rows(index).Cells(4).Value

                If File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.png") Then
                    pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.png"
                ElseIf File.Exists(Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.jpg") Then
                    pb1.ImageLocation = Application.StartupPath & "\pic\" & partlabel.Text & "_" & "online.jpg"
                End If

            End If
        End If
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sel("select barcode,cus_partno,description,parttype,cartype from record where seattype = 'F' and station = 'preassembly'  order by id ", dg1)
        sel("select a.barcode,a.cus_partno,a.description,a.parttype,a.cartype from record a join transaction_info_mes b where a.barcode = b.barcode and a.seattype = 'F' and b.transaction = 'online' order by b.id desc limit 0,20 ", dg2)
        t1.Focus()
        t1.SelectAll()
    End Sub


    Private Sub cbox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox1.CheckedChanged
        t1.Focus()
        t1.SelectAll()
    End Sub

   
End Class
