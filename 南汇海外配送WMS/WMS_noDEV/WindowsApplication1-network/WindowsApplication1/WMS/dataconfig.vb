Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Public Class dataconfig
    Dim mysqllj As String
    Dim id_max As Integer = 0

    Public Sub mysql_conn()
        Dim ip As String = 0
        Dim db As String = 0
        Dim id As String = 0
        Dim pw As String = 0
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
        sqldpt1.Fill(sqldataset1, "0")
        b.DataSource = sqldataset1.Tables(0)
        'Catch ex As Exception

        'End Try

    End Sub
    Public Sub sqlcmd(ByVal cmdtext)
        Try
            Dim sqlconn As New MySqlConnection
            sqlconn.ConnectionString = mysqllj
            Dim sqlcom As MySqlCommand = New MySqlCommand()
            sqlcom.Connection = sqlconn
            sqlcom.CommandText = cmdtext
            sqlconn.Open()
            sqlcom.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception

            Exit Sub
        End Try
     
    End Sub
    Public Sub dataconfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mysql_conn()
        dgmain.Width = Me.Width - 60
        dgmain.Left = Me.Left + 30
        dgmain.Top = Me.Height / 4
        dgmain.Height = Me.Height / 1.5
        Select Case 主界面.buttonlabel.Text
            Case "零件信息维护"
                sel("select part_no,part_desc,supplier,package,type,unit,default_bin,id from part_info order by id", dgmain)

                Button1.Visible = False
                Button2.Visible = False
            Case "库位信息维护"

                sel("select * from bin_info order by id", dgmain)
                Button1.Visible = False
                Button2.Visible = False
        End Select


    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case Button2.Text ' 根据按钮名称不同，使用不同功能
            Case "导入数据库"
                If dgmain.RowCount < 1 Then
                    MsgBox("无导入的主数据，请确认")
                    Exit Sub
                End If

                If MsgBox("确认导入数据库么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then

                Else
                    Exit Sub
                End If


                Dim i As Integer = 0

                Select Case 主界面.buttonlabel.Text
                    Case "零件信息维护"
                        sqlcmd("truncate table part_info")
                        For i = 0 To dgmain.RowCount - 1
                            sqlcmd("insert into part_info (part_no,part_desc,supplier,package,type,unit,default_bin) values ('" & dgmain.Rows(i).Cells(0).Value & "','" & dgmain.Rows(i).Cells(1).Value & "','" & dgmain.Rows(i).Cells(2).Value & "','" & dgmain.Rows(i).Cells(3).Value & "','" & dgmain.Rows(i).Cells(4).Value & "','" & dgmain.Rows(i).Cells(5).Value & "','" & dgmain.Rows(i).Cells(6).Value & "')")
                        Next
                        MsgBox("导入数据库完毕")
                        sel("select part_no,part_desc,supplier,package,type,unit,default_bin,id from part_info order by id", dgmain)
                        Button2.Visible = False
                    Case "库位信息维护"
                        sqlcmd("truncate table bin_info")
                        For i = 0 To dgmain.RowCount - 1

                            sqlcmd("insert into bin_info (inventory_no,area_no,bin_no,bin_desc,bin_type,part_no,line_info) values ('" & dgmain.Rows(i).Cells(0).Value & "','" & dgmain.Rows(i).Cells(1).Value & "','" & dgmain.Rows(i).Cells(2).Value & "','" & dgmain.Rows(i).Cells(3).Value & "','" & dgmain.Rows(i).Cells(4).Value & "','" & dgmain.Rows(i).Cells(5).Value & "','" & dgmain.Rows(i).Cells(6).Value & "')")
                        Next
                        MsgBox("导入数据库完毕")
                        sel("select * from bin_info order by id", dgmain)
                        Button2.Visible = False
                End Select


            Case "确认修改"
                dgmain.AllowUserToAddRows = False
                dgmain.AllowUserToDeleteRows = False
                If MsgBox("确认修改么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                Else
                    Exit Sub
                End If
                Dim i As Integer = 0
                Dim j As Integer = 0
                '检查是否有空的值
                For i = 0 To dgmain.RowCount - 1
                    For j = 0 To 5
                        If IsDBNull(dgmain.Rows(i).Cells(j).Value) Then
                            MsgBox("第" & i & "行存在空值，请确认")
                            Exit Sub
                        End If
                    Next
                Next
                dgmain.AllowUserToAddRows = False

                Select Case 主界面.buttonlabel.Text

                    Case "零件信息维护"
                        sqlcmd("truncate table part_info")

                        For i = 0 To dgmain.RowCount - 1
                            sqlcmd("insert into part_info (part_no,part_desc,supplier,package,type,unit,default_bin) values ('" & dgmain.Rows(i).Cells(0).Value & "','" & dgmain.Rows(i).Cells(1).Value & "','" & dgmain.Rows(i).Cells(2).Value & "','" & dgmain.Rows(i).Cells(3).Value & "','" & dgmain.Rows(i).Cells(4).Value & "','" & dgmain.Rows(i).Cells(5).Value & "','" & dgmain.Rows(i).Cells(6).Value & "')")
                        Next
                        MsgBox("修改完毕")
                        sel("select part_no,part_desc,supplier,package,type,unit,default_bin,id from part_info order by id", dgmain)
                        Button2.Visible = False
                    Case "库位信息维护"
                        sqlcmd("truncate table bin_info")

                        For i = 0 To dgmain.RowCount - 1
                            sqlcmd("insert into bin_info (inventory_no,area_no,bin_no,bin_desc,bin_type,part_no,line_info) values ('" & dgmain.Rows(i).Cells(0).Value & "','" & dgmain.Rows(i).Cells(1).Value & "','" & dgmain.Rows(i).Cells(2).Value & "','" & dgmain.Rows(i).Cells(3).Value & "','" & dgmain.Rows(i).Cells(4).Value & "','" & dgmain.Rows(i).Cells(5).Value & "','" & dgmain.Rows(i).Cells(6).Value & "')")
                        Next
                        MsgBox("修改完毕")
                        sel("select * from bin_info order by id", dgmain)
                        Button2.Visible = False
                End Select
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim file_path As String
        Dim file_name As String
        open_excel.Filter = "Excel文件(*.xlsx)|*.xlsx|(*.xls)|*.xls"
        '若点击了打开按钮，则

        If open_excel.ShowDialog() = DialogResult.OK Then
            file_path = open_excel.FileName
            file_name = Mid(file_path, file_path.Length - 4, 5) ' 取路径的后五位用于判断xlsx还是xls

        Else
            MsgBox("文件格式错误")
            Exit Sub
        End If
        '获取选中的路径
        Dim sConnectionString As String
        If file_path.Contains("xlsx") Then
            sConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;" & "Data Source=" & file_path & ";" & "Extended Properties=Excel 12.0;"
        Else
            sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & file_path & ";" & "Extended Properties=Excel 8.0;"

        End If

        'Dim sConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Application.StartupPath & "\basicdata.xls;" & "Extended Properties=Excel 8.0;"

        Dim objConn As New OleDbConnection(sConnectionString)
        objConn.Open()
        'MsgBox("成功打开连接")

        '下面将建立查询命令
        'Dim objCmdSelect As New OleDbCommand("SELECT * FROM [121$] '", objConn)

        '下面将根据查询条件打开连接。 

        Try
            Select Case 主界面.buttonlabel.Text
                Case "零件信息维护"
                    Dim objAdapter1 As New OleDbDataAdapter("SELECT * FROM [零件主数据$]", objConn) ' 打开指定sheet的数据
                    Dim objDataset1 As New DataSet()
                    objAdapter1.Fill(objDataset1) '将打开的数据放在dataset中
                    dgmain.DataSource = objDataset1.Tables(0) '将数据传给DataGrid1控件' Clean up objects.
                    objConn.Close()
                Case "库位信息维护"
                    Dim objAdapter1 As New OleDbDataAdapter("SELECT * FROM [库位主数据$]", objConn) ' 打开指定sheet的数据
                    Dim objDataset1 As New DataSet()
                    objAdapter1.Fill(objDataset1) '将打开的数据放在dataset中
                    dgmain.DataSource = objDataset1.Tables(0) '将数据传给DataGrid1控件' Clean up objects.
                    objConn.Close()
                Case Else
            End Select
        Catch ex As Exception
            MsgBox("导入模板选择错误，请确认")
        End Try


        Button2.Visible = True

        Button2.Text = "导入数据库"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button2.Visible = True

        Button2.Text = "确认修改"
        dgmain.AllowUserToAddRows = True
        dgmain.AllowUserToDeleteRows = True
    End Sub

End Class
