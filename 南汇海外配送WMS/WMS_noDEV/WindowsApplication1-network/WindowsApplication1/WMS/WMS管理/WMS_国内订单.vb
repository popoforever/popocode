Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Imports System.Threading
Imports Microsoft.Office.Interop
Public Class WMS_国内订单
    Dim db As DBconfig = New DBconfig
    Dim dgcom_supplier As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
    Dim t As Thread
    Public Delegate Sub print_thread()

    Private Sub WMS_国内订单_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '将已经审批完成的国外要货单号，加入到cbyhh

        db.sel("select order_no from ship_info where status ='process'  group by order_no order by ship_type desc, id", dgtemp)
        db.comboboxaddin(dgtemp, cbyhh)
        '初始化订单内容datagridview


        With dgcom_supplier
            .Name = "供应商"
            .FlatStyle = FlatStyle.Flat

        End With

        dgdfb.Columns.Add("0", "国外单号")
        dgdfb.Columns.Add("1", "采购订单号")
        dgdfb.Columns.Add("2", "零件号")
        dgdfb.Columns.Add("3", "名称")
        dgdfb.Columns.Add("4", "数量")
        dgdfb.Columns.Add("5", "供应商")
        dgdfb.Columns.Add("6", "国外需求日期")
        dgdfb.Columns.Add("7", "需求方")
        dt1.Value = Now.Date
        dgdfb.Columns(0).ReadOnly = True
        dgdfb.Columns(1).ReadOnly = True
        dgdfb.Columns(2).ReadOnly = True
        dgdfb.Columns(3).ReadOnly = True
        dgdfb.Columns(0).ReadOnly = True
        dgdfb.Columns(6).ReadOnly = True
        dgdfb.Columns(7).ReadOnly = True

    End Sub
    Public Sub dgdfb_supplier_check()
        If dgdfb.RowCount > 0 Then
            For i = 0 To dgdfb.RowCount - 1
                If dgdfb.Rows(i).Cells(5).Value = "" Then
                    dgdfb.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
                Else
                    dgdfb.Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            Next
        End If
    End Sub
    Private Sub cbyhh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbyhh.SelectedIndexChanged
        '将国外要货单号的信息，加入到dgdfb (除供应商以外)
        db.sel("select order_no,part_no,part_desc,qty_plan_piece,ship_datetime_plan,customer from ship_info where order_no ='" & cbyhh.Text & "' order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
        Else
            Exit Sub
        End If
        dgdfb.Rows.Clear()
        For i = 0 To dgtemp.RowCount - 1
            dgdfb.Rows.Add(dgtemp.Rows(i).Cells(0).Value, "", dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, "", dgtemp.Rows(i).Cells(4).Value, dgtemp.Rows(i).Cells(5).Value)
        Next

        '生成采购订单，DD
        Dim shd As String = 0
        For i = 0 To dgdfb.RowCount - 1
            shd = dgdfb.Rows(i).Cells(0).Value
            dgdfb.Rows(i).Cells(1).Value = "DD" & shd.Remove(0, 2)
        Next

        '在combobox列填写供应商信息，如果供应商唯一，则填入，如果不唯一，需要选择
        Dim supplier(10) As String

        For i = 0 To dgdfb.RowCount - 1
            dgdfb.Rows(i).Cells(5).ReadOnly = False
            Dim dgcom As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
            dgcom.FlatStyle = FlatStyle.Flat
            db.sel("select supplier from part_info where part_no = '" & dgdfb.Rows(i).Cells(2).Value & "'", dgtemp)
            If dgtemp.Rows(0).Cells(0).Value.contains("/") Then
                dgcom.Items.Clear()
                supplier = dgtemp.Rows(0).Cells(0).Value.ToString.Split("/")
                For j = 0 To supplier.Count - 1
                    dgcom.Items.Add(supplier(j))
                Next
                dgdfb.Rows(i).Cells(5) = dgcom
            Else
                dgcom.Items.Clear()
                dgcom.Items.Add(dgtemp.Rows(0).Cells(0).Value)
                dgdfb.Rows(i).Cells(5) = dgcom
                dgdfb.Rows(i).Cells(5).Value = dgcom.Items(0)
            End If

        Next



        db.dgsortdisable(dgdfb)
        dgdfb_supplier_check()
        dt1.Enabled = True
    End Sub

    Private Sub dgdfb_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgdfb.CellValueChanged
        dgdfb_supplier_check()

    End Sub

    Private Sub bpublic_Click(sender As Object, e As EventArgs) Handles bpublic.Click
        '判断dgdfb是否有内容.
        If dgdfb.RowCount > 0 Then
        Else
            db.rsmsg("请先选择要货单", "Please select Order")
            Exit Sub
        End If
        '判断是否存在没有选择供应商的列。
        For i = 0 To dgdfb.RowCount - 1
            If dgdfb.Rows(i).Cells(5).Value = "" Then
                db.rsmsg("供应商没有选择完整，请检查", "Please select supplier")
                Exit Sub
            End If
        Next
        '判断需求到货日期选择是否完成
        If dt1.Enabled = True Then
            db.rsmsg("请确认需求到货日期", "Please confirm arrive date")
            Exit Sub
        End If

        If MsgBox("确认发布如下的采购订单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If

        ProgressBar1.Value = 30
        ProgressBar1.Visible = True
        Application.DoEvents()
        '不同供应商分类,将dgdfb里的供应商种类填入listtemp listbox
        listtemp.Items.Clear()

        If dgdfb.RowCount > 1 Then
            listtemp.Items.Add(dgdfb.Rows(0).Cells(5).Value)
            For i = 1 To dgdfb.RowCount - 1

                For j = 0 To listtemp.Items.Count - 1
                    If dgdfb.Rows(i).Cells(5).Value = listtemp.Items(j) Then
                        Exit For
                    Else

                    End If
                    If j = listtemp.Items.Count - 1 Then
                        listtemp.Items.Add(dgdfb.Rows(i).Cells(5).Value)
                    End If
                Next

            Next
        Else
            listtemp.Items.Add(dgdfb.Rows(0).Cells(5).Value)
        End If
        '根据不同的供应商，生成采购订单
        Dim shd, cgdd, gys, ljh, ljm, sl, barcode, package As String

      
        Dim que As String = Format(1, "000")
        For k = 0 To listtemp.Items.Count - 1
            ' ProgressBar1.Value = (k + 1) / (listtemp.Items.Count)



            For i = 0 To dgdfb.RowCount - 1
                If dgdfb.Rows(i).Cells(5).Value = listtemp.Items(k) Then
                Else
                    GoTo 1
                End If
                shd = dgdfb.Rows(i).Cells(0).Value
                ' dgdfb.Rows(i).Cells(1).Value = "DD" & shd.Remove(0, 2)
               
                cgdd = dgdfb.Rows(i).Cells(1).Value
                ljh = dgdfb.Rows(i).Cells(2).Value
                ljm = dgdfb.Rows(i).Cells(3).Value
                sl = dgdfb.Rows(i).Cells(4).Value
                gys = dgdfb.Rows(i).Cells(5).Value
                '获取单位包装
                db.sel("select package from part_info where part_no ='" & ljh & "'", dgtemp)
                package = dgtemp.Rows(0).Cells(0).Value
                'MsgBox(dt1.Value.Date)
                Dim packagenum As Integer = 0
                If sl Mod package = 0 Then
                    packagenum = sl \ package
                Else
                    packagenum = sl \ package + 1
                End If

                For j = 0 To packagenum - 1

                    barcode = cgdd & que
                    db.sqlcmd("insert into barcode_info (barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime,supplier,inner_qty) values " _
                      & "('" & barcode & "','" & ljh & "','" & ljm & "','" & cgdd & "','1',1,now(),'" & gys & "','" & package & "')")
                    que = Format(Val(que) + 1, "000")
                Next


                db.sqlcmd("insert into order_info (ship_no,order_no,part_no,part_qty,supplier,arrivedate_plan,status,create_datetime) values " _
          & "('" & shd & "','" & cgdd & "','" & ljh & "','" & package * packagenum & "','" & gys & "','" & dt1.Value.Date & "',1,now())")


1:
            Next

           
        Next
        ProgressBar1.Value = 70
        Application.DoEvents()
        t = New Thread(AddressOf testA)
        t.Start()

        ' Application.DoEvents()

        ''打印条码,不同供应商 分开打印
        'For k = 0 To listtemp.Items.Count - 1


        '    Thread.Sleep(2000)
        '    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", "", False)

        '    db.sel("select barcode,part_no,part_desc,order_no,inner_qty,supplier from barcode_info where order_no = '" & dgdfb.Rows(0).Cells(1).Value & "' and supplier ='" & listtemp.Items(k) & "'", dgtemp)
        '    For i = 0 To dgtemp.RowCount - 1
        '        Try
        '            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", dgtemp.Rows(i).Cells(0).Value & "," & dgtemp.Rows(i).Cells(1).Value & "," & dgtemp.Rows(i).Cells(2).Value & "," & dgtemp.Rows(i).Cells(3).Value & "," & dgtemp.Rows(i).Cells(4).Value & "," & dgtemp.Rows(i).Cells(5).Value & "," & dt1.Value & "," & i + 1 & "," & dgtemp.RowCount & "," & Format(Now, "yyyy-MM-dd HH:mm:ss") & vbCrLf, True)
        '        Catch ex As Exception

        '        End Try
        '    Next

        '    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\PartBar.BTW" & " /p /x", False, System.Text.Encoding.Default)
        '    If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\PartBar.txt").Contains(",") = True Then
        '        Shell("cmd.exe /C " & Application.StartupPath & "\PartBar.cmd", AppWinStyle.Hide, False)
        '    End If
        '    If k = listtemp.Items.Count - 1 Then
        '    Else
        '        Thread.Sleep(5000)
        '        MsgBox("请等待打印完成后，再点击进行下一张打印")
        '    End If

        'Next

        ''生成EXCEL订单
        'orderoutput()


        '将发运单状态改成order
        db.sqlcmd("update ship_info set status ='Order' where order_no ='" & cbyhh.Text & "'")


        'db.rsmsg("订单生成成功", "Order complete")
        pmsg.Visible = True

       



    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        dt1.Enabled = True
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        Label2_Click(1, e)
    End Sub
    Public Sub progressbarstatus()
        ProgressBar1.Value = 30
    End Sub

    Private Sub lrefresh_yhh_Click(sender As Object, e As EventArgs) Handles lrefresh_yhh.Click
        cbyhh.Items.Clear()
        db.sel("select order_no from ship_info where status ='process'  group by order_no order by ship_type desc, id", dgtemp)
        db.comboboxaddin(dgtemp, cbyhh)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If dt1.Value < Now.Date Then
            db.rsmsg("日期不能小于当前日期", "")
            dt1.Value = Now.Date
            dt1.Enabled = True
            Exit Sub
        End If
        dt1.Enabled = False
    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        orderoutput()
    End Sub
    Public Sub orderoutput()

       
        '不同供应商分类,将dgdfb里的供应商种类填入listtemp listbox
        listtemp.Items.Clear()

        If dgdfb.RowCount > 1 Then
            listtemp.Items.Add(dgdfb.Rows(0).Cells(5).Value)
            For i = 1 To dgdfb.RowCount - 1

                For j = 0 To listtemp.Items.Count - 1
                    If dgdfb.Rows(i).Cells(5).Value = listtemp.Items(j) Then
                        Exit For
                    Else

                    End If
                    If j = listtemp.Items.Count - 1 Then
                        listtemp.Items.Add(dgdfb.Rows(i).Cells(5).Value)
                    End If
                Next

            Next
        Else
            listtemp.Items.Add(dgdfb.Rows(0).Cells(5).Value)
        End If
    
        Me.Refresh()
        '生成EXCEL订单
        '拷贝订单模板到C:\order文件夹，并且以order年月日时分来命名
      
        '多个供应商，分别生成多个订单
        For k = 0 To listtemp.Items.Count - 1
            Dim xlapp As Excel.Application
            Dim xlbook As Excel.Workbook
            Dim xlsheet As Excel.Worksheet
            Dim filename As String = 0
            filename = dgdfb.Rows(0).Cells(1).Value & "_" & listtemp.Items(k) & "_" & Format(Now, "yyyyMMddHHmm") & ".xlsx"
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\exceltemplate\订单模板.xlsx", "C:\order\" & listtemp.Items(k) & "\" & filename.ToString)

            xlapp = CreateObject("Excel.Application")
            xlbook = xlapp.Workbooks.Open("C:\order\" & listtemp.Items(k) & "\" & filename.ToString)
            xlsheet = xlbook.Worksheets("order")
            '填写供应商
            xlsheet.Cells(6, 3) = listtemp.Items(k)
            '填写零件,不同供应商分开
            Dim itemp As Integer = 0
            For i = 0 To dgdfb.RowCount - 1
                If dgdfb.Rows(i).Cells(5).Value = listtemp.Items(k) Then
                    xlsheet.Cells(i + 18 - itemp, 2) = dgdfb.Rows(i).Cells(2).Value
                    xlsheet.Cells(i + 18 - itemp, 3) = dgdfb.Rows(i).Cells(3).Value
                    xlsheet.Cells(i + 18 - itemp, 4) = "EA"
                    '计算实际数量（条码的数量总和）
                    db.sel("select sum(inner_qty) from barcode_info where order_no ='" & dgdfb.Rows(0).Cells(1).Value & "' and part_no='" & dgdfb.Rows(i).Cells(2).Value & "'", dgtemp)
                    xlsheet.Cells(i + 18 - itemp, 8) = dgtemp.Rows(0).Cells(0).Value
                Else
                    itemp += 1
                End If

            Next
            xlsheet.Cells(dgdfb.RowCount + 18 - itemp, 2) = "订单底部"
            '  xlsheet.Range("A1:A2").Merge() 
            xlbook.Save()
            xlbook.Close()
            xlapp.Quit()
            db.file_open("C:\order\" & listtemp.Items(k) & "\")
        Next
        cbyhh.Items.Clear()
        db.sel("select order_no from ship_info where status ='process'  group by order_no order by ship_type desc, id", dgtemp)
        db.comboboxaddin(dgtemp, cbyhh)

        dgdfb.Rows.Clear()
        cbyhh.Text = ""
        ProgressBar1.Value = 100
        Application.DoEvents()
        ProgressBar1.Visible = False
        pmsg.Visible = False


    End Sub

    '用线程打印条码
    Public Sub testA()
        Dim ivo As New print_thread(AddressOf updateui)
        Invoke(ivo)
        t.Abort()
    End Sub
    Public Sub updateui()
        ''打印条码,不同供应商 分开打印
        'For k = 0 To listtemp.Items.Count - 1

        '    Thread.Sleep(2000)
        '    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", "", False)

        '    db.sel("select barcode,part_no,part_desc,order_no,inner_qty,supplier from barcode_info where order_no = '" & dgdfb.Rows(0).Cells(1).Value & "' and supplier ='" & listtemp.Items(k) & "'", dgtemp)
        '    For i = 0 To dgtemp.RowCount - 1
        '        Try
        '            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", dgtemp.Rows(i).Cells(0).Value & "," & dgtemp.Rows(i).Cells(1).Value & "," & dgtemp.Rows(i).Cells(2).Value & "," & dgtemp.Rows(i).Cells(3).Value & "," & dgtemp.Rows(i).Cells(4).Value & "," & dgtemp.Rows(i).Cells(5).Value & "," & dt1.Value & "," & i + 1 & "," & dgtemp.RowCount & "," & Format(Now, "yyyy-MM-dd HH:mm:ss") & vbCrLf, True)
        '        Catch ex As Exception

        '        End Try
        '    Next

        '    My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\PartBar.BTW" & " /p /x", False, System.Text.Encoding.Default)
        '    If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\PartBar.txt").Contains(",") = True Then
        '        Shell("cmd.exe /C " & Application.StartupPath & "\PartBar.cmd", AppWinStyle.Hide, False)
        '    End If
        '    If k = listtemp.Items.Count - 1 Then
        '    Else
        '        Thread.Sleep(5000)
        '        MsgBox("请等待打印完成后，再点击进行下一张打印")
        '    End If

        'Next

        '生成EXCEL订单
        orderoutput()
    End Sub
End Class
