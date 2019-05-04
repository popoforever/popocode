Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient

Public Class 图片上传
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

    Private Sub 图片上传_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        sel("select cus_partno,description from model order by id", dgpart)
        sel("select transaction as 事务 from transaction_info_mes group by transaction", dgtemp)
        cb1.Items.Clear()
        For i = 0 To dgtemp.RowCount - 1
            cb1.Items.Add(dgtemp.Rows(i).Cells(0).Value)
        Next
        cb1.Enabled = False

        pb1.Width = gb1.Width / 1.5
        pb1.Height = pb1.Width * 3 / 4
        pb1.Top = gb1.Bottom + 30
        pb1.Left = Me.Right - (Me.Right - dgpic.Right) / 2 - pb1.Width / 2

    End Sub

    Private Sub dgpart_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpart.CellClick
        Dim index As String = dgpart.CurrentCell.RowIndex
        sel("select operator from pic_info where part_no ='" & dgpart.Rows(index).Cells(0).Value & "'", dgpic)
        sel("select pic_path,pic_name,operator from pic_info where part_no ='" & dgpart.Rows(index).Cells(0).Value & "'", dgtemp2)
        ljh.Text = dgpart.Rows(index).Cells(0).Value
        ljms.Text = dgpart.Rows(index).Cells(1).Value
        cb1.Enabled = True
        Try
            dgpic_CellContentClick(1, e)
        Catch ex As Exception
            pb1.ImageLocation = Nothing
        End Try
   
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cb1.Text = "" Then
            MsgBox("请选择零件")
            Exit Sub
        End If
        'pb1.Visible = True
        'pb1.ImageLocation = Nothing
        'pb1.Image = Nothing

        Dim filename As String
        OpenFileDialog1.Filter = "picture files (*.png)|*.png|(*.jpg)|*.jpg"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            filename = OpenFileDialog1.FileName

            
        Else
            Exit Sub
        End If
        If Not (pb1.Image Is Nothing) Then
            pb1.Image.Dispose()
            pb1.Image = Nothing
        End If
        pb1.ImageLocation = filename
        'PictureBox1.Image = System.Drawing.Image.FromFile(filename)
        Label1.Text = filename

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If pb1.Image Is Nothing Then
            MsgBox("上传之前，请先选择图片")
            Exit Sub
        End If

        sel("select pic_path,pic_name from pic_info where part_no = '" & ljh.Text & "' and operator = '" & cb1.Text & "'", dgtemp)

        Dim a As String = "\\\\10.178.188.50\\mes\\picdata\\" & ljh.Text & "_" & cb1.Text & Label1.Text.Remove(0, Label1.Text.Length - 4)
        Dim b As String = ljh.Text & "_" & cb1.Text & Label1.Text.Remove(0, Label1.Text.Length - 4)
        If dgtemp.RowCount > 0 Then
            If MsgBox("此零件的这个操作已经有图片，是否覆盖？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                File.Copy(Label1.Text, a, True)
                File.Copy(Label1.Text, Application.StartupPath & "\pic\" & b, True)
                ' MsgBox(Application.StartupPath & "\pic\" & b)
                'MsgBox(a)
                sqlcmd("update pic_info set pic_path = '" & a & "',pic_name = '" & b & "' where part_no = '" & ljh.Text & "' and operator = '" & cb1.Text & "'")
                MsgBox("图片上传成功")
            Else
                Exit Sub
            End If
        Else
            If MsgBox("是否新增图片？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                File.Copy(Label1.Text, a, True)
                File.Copy(Label1.Text, Application.StartupPath & "\pic\" & b, True)
                ' MsgBox(a)
                sqlcmd("insert into pic_info (part_no,pic_path,operator,pic_name) values ('" & ljh.Text & "','" & a & "','" & cb1.Text & "','" & b & "')")
                MsgBox("图片上传成功")

            Else
                Exit Sub
            End If

        End If
    
        Dim index As String = dgpart.CurrentCell.RowIndex
        sel("select operator from pic_info where part_no ='" & dgpart.Rows(index).Cells(0).Value & "'", dgpic)
        sel("select pic_path,pic_name,operator from pic_info where part_no ='" & dgpart.Rows(index).Cells(0).Value & "'", dgtemp2)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        sel("select pic_path from pic_info where part_no = '" & ljh.Text & "' and operator = '" & cb1.Text & "'", dgtemp)
        If dgtemp.RowCount = 0 Then
            pb1.ImageLocation = Nothing
        End If
    End Sub

  
    Private Sub dgpic_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpic.CellClick
        Dim index As String = dgpic.CurrentCell.RowIndex
        If File.Exists(Application.StartupPath & "\pic\" & dgtemp2.Rows(index).Cells(1).Value) Then
            pb1.ImageLocation = Application.StartupPath & "\pic\" & dgtemp2.Rows(index).Cells(1).Value
        Else
            pb1.ImageLocation = dgtemp2.Rows(index).Cells(0).Value
        End If

        cb1.Text = dgtemp2.Rows(index).Cells(2).Value
    End Sub

   
    Private Sub gb1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb1.Enter

    End Sub
End Class
