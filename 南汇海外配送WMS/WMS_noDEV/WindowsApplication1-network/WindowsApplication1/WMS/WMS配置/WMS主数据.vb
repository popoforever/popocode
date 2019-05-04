Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS主数据
    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()
      
        gbop.Left = Me.Left + 15
        gbop.Top = Me.Top + 15
        gbop.Width = Me.Width - 45
        gbdata.Left = gbop.Left
        gbdata.Top = gbop.Bottom
        gbdata.Height = Me.Height - gbop.Height - 15
        gbdata.Width = gbop.Width
        dgdata.Left = Me.Left
        dgdata.Top = Me.Top + 60
        dgdata.Width = gbdata.Width
        dgdata.Height = gbdata.Height - 45
        badd.Left = Me.Left + 5
        badd.Top = dgdata.Top - 35
        bdel.Left = badd.Right + 5
        bdel.Top = badd.Top
        bimp.Top = badd.Top
        bimp.Left = bdel.Right + 5
        bquit.Left = bimp.Right + 5
        bquit.Top = badd.Top
        bsave.Left = bquit.Right + 5
        bsave.Top = badd.Top

    End Sub
    Public Sub partdata()
        db.sel("select part_no as 零件号,part_desc as 描述,supplier as 工厂,package as 包装数量,per_price as 单价,unit as 包装单位,inner_unit as 内部单位,package_length as 长cm,package_width as 宽cm,package_height as 高cm from part_info order by id", dgdata)
        If dgdata.RowCount > 0 Then
            For i = 0 To dgdata.RowCount - 1
                dgdata.Rows(i).Cells(0).ReadOnly = True
            Next
        End If
        dgdata.AllowUserToAddRows = False
        db.dgsortdisable(dgdata)
        dgdata.Columns(0).ReadOnly = True
    End Sub
   
    Private Sub WMS主数据_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadsize()
        partdata()
        db.sel("select supplier from part_info group by supplier", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbfac.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cbfac.Items.Add(dgtemp.Rows(i).Cells(0).Value)
            Next
        End If
        dgdata.ImeMode = Windows.Forms.ImeMode.OnHalf

    End Sub

    Private Sub bpart_Click(sender As System.Object, e As System.EventArgs) Handles bpart.Click
        ldatatype.Text = bpart.Text
        partdata()

    End Sub

    Private Sub badd_Click(sender As System.Object, e As System.EventArgs) Handles badd.Click
        If dgdata.RowCount > 0 Then
            dgdata.AllowUserToAddRows = True
            dgdata.Rows(dgdata.RowCount - 1).DefaultCellStyle.BackColor = Color.LightBlue
            dgdata.Rows(dgdata.RowCount - 1).Cells(0).ReadOnly = False
            bsave.Visible = True
            bsave.Text = "操作确认"
        Else
            dgdata.AllowUserToAddRows = True
            dgdata.Rows(0).DefaultCellStyle.BackColor = Color.LightBlue
            dgdata.Rows(0).Cells(0).ReadOnly = False
            bsave.Visible = True
            bsave.Text = "操作确认"
        End If
   
    End Sub

    Private Sub bdel_Click(sender As System.Object, e As System.EventArgs) Handles bdel.Click
        Try
            Dim index As String = dgdata.CurrentCell.RowIndex
            dgdata.Rows(index).DefaultCellStyle.BackColor = Color.SandyBrown
            dgdata.ClearSelection()
            bsave.Visible = True
            bsave.Text = "操作确认"
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub dgdata_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdata.CellValueChanged
        Dim index As String = dgdata.CurrentCell.RowIndex
        Dim cindex As String = dgdata.CurrentCell.ColumnIndex
        If dgdata.Rows(index).DefaultCellStyle.BackColor = Color.LightBlue Then
        Else
            dgdata.Rows(index).DefaultCellStyle.BackColor = Color.Yellow
        End If
        dgdata.ClearSelection()
        bsave.Text = "修改确认"
        bsave.Visible = True
        dgdata.AllowUserToAddRows = False
    End Sub

    Private Sub bimp_Click(sender As System.Object, e As System.EventArgs) Handles bimp.Click
        'If MsgBox("确定导入信息？", MsgBoxStyle.YesNo, "导入确认") = MsgBoxResult.Yes Then

        'Else
        '    Exit Sub
        'End If
        bsave.Visible = False
        Dim file_path As String
        Dim file_name As String
        open_excel.Filter = "Excel File(*.xlsx)|*.xlsx|(*.xls)|*.xls"
        '若点击了打开按钮，则

        If open_excel.ShowDialog() = DialogResult.OK Then
            file_path = open_excel.FileName
            file_name = Mid(file_path, file_path.Length - 4, 5) ' 取路径的后五位用于判断xlsx还是xls
        Else
            MsgBox("导入文件格式错误")
            Exit Sub
        End If
        '获取选中的路径
        Dim sConnectionString As String
        If file_path.Contains("xlsx") Then
            sConnectionString = "Provider=Microsoft.Ace.OleDb.12.0;" & "Data Source=" & file_path & ";" & "Extended Properties=Excel 12.0;"
        Else
            sConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & file_path & ";" & "Extended Properties=Excel 8.0;"

        End If
        Dim objConn As New OleDbConnection(sConnectionString)
        objConn.Open()
        Try
          
                    Dim objAdapter1 As New OleDbDataAdapter("SELECT * FROM [零件主数据$] where 零件号 is not null", objConn) ' 打开指定sheet的数据
                    Dim objDataset1 As New DataSet()
                    objAdapter1.Fill(objDataset1) '将打开的数据放在dataset中
                    dgdata.DataSource = objDataset1.Tables(0) '将数据传给DataGrid1控件' Clean up objects.
                    objConn.Close()
          
        Catch ex As Exception
            MsgBox("数据导入模板错误，请检查")

        End Try
        bsave.Visible = True
        bsave.Text = "导入确认"
        ifimp.Text = 1

    End Sub

    Private Sub bsave_Click(sender As System.Object, e As System.EventArgs)
        If MsgBox("确定保存更改？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If

        db.isdgempty(dgdata)
      

                For i = 0 To dgdata.RowCount - 1
                    '黄底修改，红底删除，蓝底新增
                    If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                db.sqlcmd("update part_info set part_desc = '" & dgdata.Rows(i).Cells(1).Value & "',supplier = '" & dgdata.Rows(i).Cells(2).Value & "',package = '" & dgdata.Rows(i).Cells(3).Value & "',per_price ='" & dgdata.Rows(i).Cells(4).Value & "',unit='" & dgdata.Rows(i).Cells(5).Value & "',inner_unit='" & dgdata.Rows(i).Cells(6).Value & "',package_length='" & dgdata.Rows(i).Cells(7).Value & "',package_width='" & dgdata.Rows(i).Cells(8).Value & "',package_height='" & dgdata.Rows(i).Cells(9).Value & "' " _
                          & "where part_no ='" & dgdata.Rows(i).Cells(0).Value & "'")
                        dgdata.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                    If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.SandyBrown Then
                        db.sqlcmd("delete from part_info where part_no = '" & dgdata.Rows(i).Cells(0).Value & "'")
                    End If
                    If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue Then
                Try

                    db.sqlcmd("insert into part_info (part_no,part_desc,supplier,package,per_price,unit,inner_unit,package_length,package_width,package_height) values ('" & dgdata.Rows(i).Cells(0).Value & "','" & dgdata.Rows(i).Cells(1).Value & "','" & dgdata.Rows(i).Cells(2).Value & "','" & dgdata.Rows(i).Cells(3).Value & "','" & dgdata.Rows(i).Cells(4).Value & "','" & dgdata.Rows(i).Cells(5).Value & "','" & dgdata.Rows(i).Cells(6).Value & "','" & dgdata.Rows(i).Cells(7).Value & "','" & dgdata.Rows(i).Cells(8).Value & "','" & dgdata.Rows(i).Cells(9).Value & "')")
                Catch ex As Exception
                    MsgBox("数据格式不正确")
                    dgdata.AllowUserToAddRows = False
                    Exit Sub
                End Try
            End If
                Next
                partdata()
         

        MsgBox("保存成功!", 0, "零件数据")
    End Sub

    Private Sub bimpok_Click(sender As System.Object, e As System.EventArgs)
        '检查导入零件是否与现有零件重复
        If dgdata.RowCount > 0 Then
        Else
            MsgBox("导入列表为空，请检查")
            Exit Sub
        End If

        db.sel("select part_no from part_info order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
            For i = 0 To dgdata.RowCount - 1
                For j = 0 To dgtemp.RowCount - 1
                    If dgdata.Rows(i).Cells(0).Value = dgtemp.Rows(j).Cells(0).Value Then
                        MsgBox("本次导入不成功，导入零件号中存在与现有零件号相同的零件。")
                        partdata()
                        Exit Sub
                    End If
                Next
            Next
        End If

        '检查成功，导入系统

        Try
            For i = 0 To dgdata.RowCount - 1
                db.sqlcmd("insert into part_info (part_no,part_desc,supplier,package,per_price,unit,inner_unit,package_length,package_width,package_height) values ('" & dgdata.Rows(i).Cells(0).Value & "','" & dgdata.Rows(i).Cells(1).Value & "','" & dgdata.Rows(i).Cells(2).Value & "','" & dgdata.Rows(i).Cells(3).Value & "','" & dgdata.Rows(i).Cells(4).Value & "','" & dgdata.Rows(i).Cells(5).Value & "','" & dgdata.Rows(i).Cells(6).Value & "','" & dgdata.Rows(i).Cells(7).Value & "','" & dgdata.Rows(i).Cells(8).Value & "','" & dgdata.Rows(i).Cells(9).Value & "')")

            Next
        Catch ex As Exception
            MsgBox("数据格式不正确")
            dgdata.AllowUserToAddRows = False
            Exit Sub
        End Try
        MsgBox("零件数据导入成功", 0, "零件主数据")
        partdata()
    End Sub

    Private Sub bsave_Click_1(sender As Object, e As EventArgs) Handles bsave.Click
        If ifimp.Text = 0 Then
            '检查新增或者修改的零件号这一列是否为空
            If dgdata.RowCount > 0 Then
                For i = 0 To dgdata.RowCount - 1
                    If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue Then
                        If dgdata.Rows(i).Cells(0).Value = "" Then
                            MsgBox("新增零件号不允许为空", 0, "主数据维护错误")
                            Exit Sub
                        End If
                    ElseIf dgdata.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                        If dgdata.Rows(i).Cells(0).Value = "" Then
                            MsgBox("修改零件号不允许为空", 0, "主数据维护错误")
                            Exit Sub
                        End If
                    End If
                Next
            End If
            '触发保存
            bsave_Click(1, e)
            Exit Sub
        ElseIf ifimp.Text = 1 Then

            bimpok_Click(1, e)
            ifimp.Text = 0
            Exit Sub
        End If
        bsave.Visible = False
    End Sub

    Private Sub bquit_Click(sender As Object, e As EventArgs) Handles bquit.Click
        partdata()
        bsave.Visible = False
    End Sub


    Private Sub bcx_Click(sender As Object, e As EventArgs) Handles bcx.Click
        db.sel("select part_no as 零件号,part_desc as 描述,supplier as 工厂,package as 包装数量,per_price as 单价,unit as 包装单位,inner_unit as 内部单位,package_length as 长cm,package_width as 宽cm,package_height as 高cm from part_info where part_no like '%" & tpart.Text & "%' and type like '%" & cbtype.Text & "%' and supplier like '%" & cbfac.Text & "%' order by id", dgdata)

    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        tpart.Text = ""
        cbtype.Text = ""
        cbfac.Text = ""
        partdata()

    End Sub

End Class
