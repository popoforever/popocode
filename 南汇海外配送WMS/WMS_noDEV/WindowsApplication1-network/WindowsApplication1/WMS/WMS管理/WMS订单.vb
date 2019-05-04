Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Public Class WMS订单

    Dim db As DBconfig = New DBconfig
    Public Sub orderinput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dginput.Width = Me.Width - 60
        dginput.Left = Me.Left + 30
        pdginput.Left = dginput.Left
        pdginput.Width = dginput.Width
        pdginput.Top = Button1.Bottom + 15
        dginput.Top = pdginput.Top + pdginput.Height
        dginput.Height = Me.Height / 3

        Button2.Top = dginput.Bottom + 15
        Button3.Top = Button2.Top
        Label2.Top = Button2.Top
        ProgressBar1.Top = Button2.Top

        dgorder.Width = dginput.Width / 1.5
        dgorder.Left = dginput.Left
        pdgorder.Left = dgorder.Left
        pdgorder.Width = dgorder.Width
        pdgorder.Top = Button2.Bottom + 15
        dgorder.Top = pdgorder.Bottom
        dgorder.Height = Me.Height / 3

        dgorder2.Left = dgorder.Right + 15
        dgorder2.Width = dginput.Width - dgorder.Width - 15
        pdgorder2.Left = dgorder2.Left
        pdgorder2.Width = dgorder2.Width
        pdgorder2.Top = Button2.Bottom + 15
        dgorder2.Top = pdgorder2.Bottom
        dgorder2.Height = Me.Height / 3

        Button2.Visible = False
        Button3.Visible = False

        db.sel("select order_no as 订单号,part_no as 零件号,part_qty as 计划数,supplier as 供应商,arrivedate_plan as 预计到货日期,arrivetime_plan as 预计到货时间,id from order_info where status =0 order by id", dgorder)

        db.sel("select supplier as 供应商,order_no as 订单号,arrivedate_plan as 预计交期,status as 状态 from order_info where status < 3 group by order_no,supplier,arrivedate_plan,status", dgorder2)

        If dgorder2.RowCount > 0 Then
            For i = 0 To dgorder2.RowCount - 1
                Select Case dgorder2.Rows(i).Cells(3).Value
                    Case Is = 0
                        dgorder2.Rows(i).Cells(3).Value = "待发布"

                    Case Is = 1

                        dgorder2.Rows(i).Cells(3).Value = "待收货"
                    Case Is = 2
                        dgorder2.Rows(i).Cells(3).Value = "收货中"
                End Select
            Next
        End If

        db.sel("select part_no,package,part_desc from part_info", dgtemp2)
        If dgorder.RowCount = 0 Then
            Button3.Visible = False
        Else
            Button3.Visible = True
        End If

    End Sub

    Private Sub dgorder2_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgorder2.CellFormatting

        Select Case e.Value.ToString
            Case "待发布"
                e.CellStyle.BackColor = Color.SandyBrown
            Case "待收货"
                e.CellStyle.BackColor = Color.SandyBrown
            Case "收货中"
                e.CellStyle.BackColor = Color.FromArgb(204, 255, 153)
        End Select
        Try
            dgorder2.Rows(0).Selected = False
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        db.sel("select order_no from order_info order by id desc limit 0,10000", dgtemp)
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
        Try
            objConn.Open()
            'MsgBox("成功打开连接")

            '下面将建立查询命令
            'Dim objCmdSelect As New OleDbCommand("SELECT * FROM [121$] '", objConn)

            '下面将根据查询条件打开连接。 
        Catch ex As Exception
            MsgBox("打开文件失败，请确认是否文件被占用")
        End Try


        Try
            Dim objAdapter1 As New OleDbDataAdapter("SELECT * FROM [采购订单$] where 订单号 is not null and 零件号 is not null", objConn) ' 打开指定sheet的数据
            Dim objDataset1 As New DataSet()
            objAdapter1.Fill(objDataset1) '将打开的数据放在dataset中
            dginput.DataSource = objDataset1.Tables(0) '将数据传给DataGrid1控件
            ' Clean up objects.
            objConn.Close()
        Catch ex As Exception
            MsgBox("导入模板选择错误，请确认")
        End Try

        Button2.BackColor = Color.SkyBlue
        Button2.Visible = True

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("确认生成订单么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dginput.RowCount < 1 Then
            MsgBox("没有可导入订单数据，请检查")
            Exit Sub
        End If
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim temp As String = 0
        '检查导入项中，订单号和零件号组合值有无重复
        If dginput.RowCount > 1 Then
            For i = 0 To dginput.RowCount - 2
                temp = dginput.Rows(i).Cells(0).Value & dginput.Rows(i).Cells(1).Value
                ' MsgBox(temp)
                For j = i + 1 To dginput.RowCount - 1
                    If temp = dginput.Rows(j).Cells(0).Value & dginput.Rows(j).Cells(1).Value Then '存在重复，报错退出
                        MsgBox("第" & i + 1 & "行与第" & j + 1 & "行存在重复的订单号+零件号行，" & dginput.Rows(j).Cells(0).Value & "," & dginput.Rows(j).Cells(1).Value & "不符合规范，请检查")
                        Exit Sub
                    End If
                Next

            Next
        End If


        '//检查导入项中，订单号和零件号组合值有无重复

        '检查一个月内已关闭订单是否重复，如有重复则报警退出
        For i = 0 To dginput.RowCount - 1
            For j = 0 To dgtemp.RowCount - 1
                If dginput.Rows(i).Cells(0).Value = dgtemp.Rows(j).Cells(0).Value Then
                    MsgBox("第" & i + 1 & "行订单号" & dginput.Rows(i).Cells(0).Value & "已存在，请不要重复")
                    Exit Sub
                Else
                End If
            Next
        Next
        '//检查一个月内已关闭订单是否重复，如有重复则报警退出

        '检查导入的零件号是否在零件清单内
        Dim a As Integer = 0
        For i = 0 To dginput.RowCount - 1
            a = 0
            For j = 0 To dgtemp2.RowCount - 1
                If dginput.Rows(i).Cells(1).Value = dgtemp2.Rows(j).Cells(0).Value Then

                    a = 1
                Else

                End If
            Next
            If a = 1 Then
            Else
                MsgBox("第" & i + 1 & "行零件号" & dginput.Rows(i).Cells(1).Value & "不在系统零件清单内，请检查")
                Exit Sub
            End If
        Next
        '//检查导入的零件号是否在零件清单内



        '检查未开始订单号是否重复，如果有，使用修改。如没有，进行插入

        For i = 0 To dginput.RowCount - 1
            '    For j = 0 To dgorder.RowCount - 1
            '        If dginput.Rows(i).Cells(0).Value = dgorder.Rows(j).Cells(0).Value Then
            '            If MsgBox("第" & i + 1 & "行订单号" & dgorder.Rows(i).Cells(0).Value & "存在重复的未开始的订单，是否需要更新？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
            '            Else
            '                GoTo 1
            '            End If
            '            'MsgBox("第" & i + 1 & "行订单号" & dgorder.Rows(i).Cells(0).Value & "已存在，请不要重复导入")
            '            'db.sqlcmd("update ignore order_info set part_no= '" & dginput.Rows(i).Cells(1).Value & "',part_qty='" & dginput.Rows(i).Cells(2).Value & "' where order_no = '" & dginput.Rows(i).Cells(0).Value & "'")
            '            db.sqlcmd("update ignore order_info set part_no='" & dginput.Rows(i).Cells(1).Value & "',part_qty='" & dginput.Rows(i).Cells(2).Value & "',supplier='" & dginput.Rows(i).Cells(3).Value & "',arrivedate_plan='" & dginput.Rows(i).Cells(4).Value & "',arrivetime_plan='" & dginput.Rows(i).Cells(5).Value & "' where order_no = '" & dginput.Rows(i).Cells(0).Value & "'")

            '            GoTo 1
            '        End If
            '    Next
            db.sqlcmd("insert into order_info(order_no,part_no,part_qty,supplier,arrivedate_plan,arrivetime_plan,status) values ('" & dginput.Rows(i).Cells(0).Value & "','" & dginput.Rows(i).Cells(1).Value & "','" & dginput.Rows(i).Cells(2).Value & "','" & dginput.Rows(i).Cells(3).Value & "','" & dginput.Rows(i).Cells(4).Value & "','" & dginput.Rows(i).Cells(5).Value & "','0')")
            '1:
        Next
        MsgBox("订单导入成功")
        db.sel("select order_no as 订单号,part_no as 零件号,part_qty as 计划数,supplier as 供应商,arrivedate_plan as 预计到货日期,arrivetime_plan as 预计到货时间,id from order_info where status =0 order by id", dgorder)

        db.sel("select order_no from order_info order by id desc limit 0,10000", dgtemp)
        '//检查未开始订单号是否重复，如果有，使用修改。如没有，进行插入

        Dim dataempty As DataSet = New DataSet
        dataempty.Clear()
        dginput.DataSource = dataempty

        Button2.BackColor = Color.White
        Button2.Visible = False
        If dgorder.RowCount = 0 Then
            Button3.Visible = False
        Else
            Button3.BackColor = Color.SkyBlue
            Button3.Visible = True
        End If
        db.sel("select supplier as 供应商,order_no as 订单号,arrivedate_plan as 预计交期,status as 状态 from order_info where status < 3 group by order_no", dgorder2)

        If dgorder2.RowCount > 0 Then
            For i = 0 To dgorder2.RowCount - 1
                Select Case dgorder2.Rows(i).Cells(3).Value
                    Case Is = 0
                        dgorder2.Rows(i).Cells(3).Value = "待发布"

                    Case Is = 1

                        dgorder2.Rows(i).Cells(3).Value = "待收货"
                    Case Is = 2
                        dgorder2.Rows(i).Cells(3).Value = "收货中"
                End Select
            Next
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("确认以下订单生成条码么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If

        Dim bar_count As Integer = 0 '条码箱数
        Dim tail_number As Double = 0  ' 条码中的尾箱数量
        Dim package As String = 0 ' 标包数量
        Dim part_desc As String = 0 '零件描述
        Dim barcode As String = 0

        'bar_count = 21 / 10
        'tail_number = 21 Mod 10
        'MsgBox(bar_count & "，  " & tail_number)

        If dgorder.RowCount = 0 Then
            MsgBox("订单列表为空，无法生成条码，请检查")
            Exit Sub
        End If
        '条码号
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer = 1
        Dim min As Integer = 0
        Dim max As Integer = dgorder.RowCount - 1
        Dim progress As Integer
        ProgressBar1.Visible = True
        Label2.Visible = True
        ProgressBar1.Minimum = min
        ProgressBar1.Maximum = max
        If max = 0 Then
            max = 2
        End If
        ProgressBar1.Value = 1 / max
        For i = 0 To dgorder.RowCount - 1  ' 循环订单清单
            progress = i \ max '计算进度
            ProgressBar1.Value = progress '显示进度
            For j = 0 To dgtemp2.RowCount - 1 ' 循环零件清单
                '获取当前订单行的标包数量
                If dgorder.Rows(i).Cells(1).Value = dgtemp2.Rows(j).Cells(0).Value Then
                    package = dgtemp2.Rows(j).Cells(1).Value
                    part_desc = dgtemp2.Rows(j).Cells(2).Value
                    Exit For
                End If

                '//获取当前订单行的标包数量
            Next
            '计算箱条码数量以及尾箱数字
            'Try
            bar_count = dgorder.Rows(i).Cells(2).Value / package + 1
            tail_number = dgorder.Rows(i).Cells(2).Value Mod package
            'Catch ex As Exception
            '    MsgBox("请检查订单第" & i + 1 & "行的数量是否准确")
            'End Try

            '//计算箱条码数量以及尾箱数字

            '生成条码规则

            If bar_count = 1 And tail_number <> 0 Then ' 如果只有一箱且尾数不为零，则用尾箱数填入改条码
                barcode = dgorder.Rows(i).Cells(0).Value + dgorder.Rows(i).Cells(1).Value + Format(k, "0000")
                db.sqlcmd("insert into barcode_info(barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime) values ('" & barcode & "','" & dgorder.Rows(i).Cells(1).Value & "','" & part_desc & "','" & dgorder.Rows(i).Cells(0).Value & "','" & tail_number & "',0,'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")
                ' //如果只有一箱且尾数不为零，则用尾箱数填入改条码
            ElseIf bar_count = 1 And tail_number = 0 Then
                barcode = dgorder.Rows(i).Cells(0).Value + dgorder.Rows(i).Cells(1).Value + Format(k, "0000")
                db.sqlcmd("insert into barcode_info(barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime) values ('" & barcode & "','" & dgorder.Rows(i).Cells(1).Value & "','" & part_desc & "','" & dgorder.Rows(i).Cells(0).Value & "','" & package & "',0,'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")
            Else
                For k = 1 To bar_count - 1 '整箱赋值
                    barcode = dgorder.Rows(i).Cells(0).Value + dgorder.Rows(i).Cells(1).Value + Format(k, "0000")
                    ' MsgBox(barcode & "," & k)
                    db.sqlcmd("insert into barcode_info(barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime) values ('" & barcode & "','" & dgorder.Rows(i).Cells(1).Value & "','" & part_desc & "','" & dgorder.Rows(i).Cells(0).Value & "','" & package & "',0,'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")

                    'MsgBox(barcode)
                Next   '//整箱赋值

                '尾箱赋值
                If tail_number = 0 Then

                Else
                    barcode = dgorder.Rows(i).Cells(0).Value + dgorder.Rows(i).Cells(1).Value + Format(bar_count, "0000")
                    db.sqlcmd("insert into barcode_info(barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime) values ('" & barcode & "','" & dgorder.Rows(i).Cells(1).Value & "','" & part_desc & "','" & dgorder.Rows(i).Cells(0).Value & "','" & tail_number & "',0,'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")
                End If

                db.sqlcmd("update order_info set status = 1 where id = '" & dgorder.Rows(i).Cells(6).Value & "'")

                '尾箱赋值
            End If
            '//生成条码规则
        Next
        If max = 2 Then
        Else
            ProgressBar1.Value = max

        End If

        MsgBox("条码生成完成")
        '//打印条码到A4



        '//打印条码到A4
        ProgressBar1.Visible = False
        Label2.Visible = False
        db.sel("select * from order_info where status =0 order by id", dgorder)
        Button3.BackColor = Color.White
        Button3.Visible = False

        db.sel("select supplier as 供应商,order_no as 订单号,arrivedate_plan as 预计交期,status as 状态 from order_info where status < 3 group by order_no", dgorder2)

        If dgorder2.RowCount > 0 Then
            For i = 0 To dgorder2.RowCount - 1
                Select Case dgorder2.Rows(i).Cells(3).Value
                    Case Is = 0
                        dgorder2.Rows(i).Cells(3).Value = "待发布"

                    Case Is = 1

                        dgorder2.Rows(i).Cells(3).Value = "待收货"
                    Case Is = 2
                        dgorder2.Rows(i).Cells(3).Value = "收货中"
                End Select
            Next
        End If
    End Sub




End Class
