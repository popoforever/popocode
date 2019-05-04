Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_发运任务
    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()
        With gbop
            .Left = Me.Left
            .Top = Me.Top
            .Width = Me.Width - 10
        End With

        With gbdfb
            .Left = Me.Left
            .Top = gbop.Bottom
            .Width = Me.Width / 2.5 * 1.5
            .Height = Me.Height - gbop.Height - 15
        End With

        With gbyfb
            .Left = gbdfb.Right + 5
            .Top = gbop.Bottom
            .Width = Me.Width - gbdfb.Width - 10
            .Height = gbdfb.Height
        End With

        With dgdfb
            .Left = Me.Left
            .Top = Me.Top + 45
            .Width = gbdfb.Width - 10
            .Height = gbdfb.Height - 45 - bpublic.Height
        End With

        With dgyfb
            .Left = Me.Left
            .Top = Me.Top + 45
            .Width = gbyfb.Width - 10
            .Height = (gbyfb.Height - 45) / 3 * 2 - 15
        End With
        With dgreject
            .Left = dgyfb.Left
            .Top = dgyfb.Bottom + 10
            .Width = dgyfb.Width
            .Height = gbyfb.Height - dgyfb.Height - 65
        End With


        With dgpart

            .Left = cbpartno.Left
            .Top = gbop.Bottom
            .Width = 300
            .Height = 200

        End With

        With byfbrefresh
            .Left = dgyfb.Right - byfbrefresh.Width
            .Top = dgyfb.Top - byfbrefresh.Height - 5
        End With

        With lrefreshmsg
            .Top = Me.Top + 30
            .Left = Me.Right - lrefreshmsg.Width - 30
        End With

        '    MsgBox(Me.Height & ", " & Me.Width & ", " & gbop.Height)

        dt1.Value = Now.Date.AddDays(10)

        If 主界面.lan.Text = "English" Then
            gbop.Text = "Order"
            gbdfb.Text = "Order Detail"
            gbyfb.Text = "Publish"
            lkh.Text = "Customer:"
            lddh.Text = "Order No.:"
            llj.Text = "Part No.:"
            lxs.Text = "Box:"
            lsl.Text = "Qty:"
            lss.Text = "Search:"
            lyjdhrq.Text = "Demand Date:"

            bsc.Text = "Generate"
            badd.Text = "Add"
            breset.Text = "Reset"
            bpublic.Text = "Public"

            byfbrefresh.Text = "Refresh"
            bimport.Text = "Import"
            ltrans.Text = "Transport"

        End If

    End Sub
    Public Sub dgyfb_refresh()
        db.sel("select order_no,status,ship_type,ship_datetime_plan,confirm from ship_info where status <>'Reject'  group by order_no order by status, ship_type desc,ship_datetime_plan,order_no limit 0,20", dgtemp)
        db.dgadd(dgtemp, dgyfb, 5)
        db.sel("select order_no,status,ship_type,ship_datetime_plan,confirm from ship_info where status ='Reject'  group by order_no order by status,ship_type desc, ship_datetime_plan,order_no limit 0,20", dgtemp)
        db.dgadd(dgtemp, dgreject, 5)
    End Sub
    Public Sub gbopinitial()
        torderno.Text = ""
        cbpartno.Text = ""
        numbox.Value = 0
        dt1.Value = Now.Date
        tsearch.Text = ""
        bsc.Enabled = True
        dgpart.Visible = False
        cbsp.Enabled = True
        dt1.Enabled = True
    End Sub

    Private Sub WMS_发运任务_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        cbcustomer.Text = 主界面.lfactory.Text
        db.sel("select customer from customer_info order by id", dgtemp)
        db.comboboxaddin(dgtemp, cbcustomer)
        '填充cbpartno
        db.sel("select part_no,part_desc from part_info order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbpartno.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cbpartno.Items.Add(dgtemp.Rows(i).Cells(0).Value & "/" & dgtemp.Rows(i).Cells(1).Value)
            Next
        End If
        If 主界面.lan.Text = "English" Then
            dgdfb.Columns.Add("0", "Shpping No.")
            dgdfb.Columns.Add("1", "Customer")
            dgdfb.Columns.Add("2", "Part No.")
            dgdfb.Columns.Add("3", "Part Name")
            dgdfb.Columns.Add("4", "Box Qty")
            dgdfb.Columns.Add("5", "Unit Qty")
            dgdfb.Columns.Add("6", "Qty")
            dgdfb.Columns.Add("7", "Unit")

            dghis.Columns.Add("0", "Req.Date")
            dghis.Columns.Add("1", "Shipping No.")
            dghis.Columns.Add("2", "Part No.")
            dghis.Columns.Add("3", "Part Name")
            dghis.Columns.Add("4", "Box Qty")
            dghis.Columns.Add("5", "Qty")
            dghis.Columns.Add("6", "Create Datetime")

            dgyfb.Columns.Add("0", "Shipping No.")
            dgyfb.Columns.Add("1", "Status")
            dgyfb.Columns.Add("2", "Type")
            dgyfb.Columns.Add("3", "Datetime Plan")
            dgyfb.Columns.Add("4", "Confirm")

            dgreject.Columns.Add("0", "Shipping No.")
            dgreject.Columns.Add("1", "Status")
            dgreject.Columns.Add("2", "Type")
            dgreject.Columns.Add("3", "Datetime Plan")
            dgreject.Columns.Add("4", "Confirm")
        Else
            dgdfb.Columns.Add("0", "发运号")
            dgdfb.Columns.Add("1", "客户")
            dgdfb.Columns.Add("2", "零件号")
            dgdfb.Columns.Add("3", "名称")
            dgdfb.Columns.Add("4", "箱数")
            dgdfb.Columns.Add("5", "包装单位")
            dgdfb.Columns.Add("6", "数量")
            dgdfb.Columns.Add("7", "内部单位")


            dghis.Columns.Add("0", "要货日期")
            dghis.Columns.Add("1", "发运号")
            dghis.Columns.Add("2", "零件号")
            dghis.Columns.Add("3", "名称")
            dghis.Columns.Add("4", "箱数")
            dghis.Columns.Add("5", "数量")
            dghis.Columns.Add("6", "创建时间")

            dgyfb.Columns.Add("0", "发运号")
            dgyfb.Columns.Add("1", "状态")
            dgyfb.Columns.Add("2", "类型")
            dgyfb.Columns.Add("3", "需求时间")
            dgyfb.Columns.Add("4", "是否确认")

            dgreject.Columns.Add("0", "发运号")
            dgreject.Columns.Add("1", "状态")
            dgreject.Columns.Add("2", "类型")
            dgreject.Columns.Add("3", "需求时间")
            dgreject.Columns.Add("4", "是否确认")
        End If

        db.dgsortdisable(dgdfb)

        dgyfb_refresh()
        db.dgsortdisable(dgyfb)
        db.dgsortdisable(dgreject)
        cbsp.Items.Add("Ship")
        cbsp.Items.Add("Air")
        cbsp.Text = cbsp.Items(0)
        dghis_refresh()

        If 主界面.lhwddh.Text = "N" Then
            bsc_Click(1, e)
        Else
            torderno.Text = 主界面.lhwddh.Text
        End If
        yfbrefresh_Tick(1, e)
        dt1_refresh()
    End Sub

    Private Sub bsc_Click(sender As Object, e As EventArgs) Handles bsc.Click
        'If cbcustomer.Text = "" Then
        '    db.rsmsg("请选择要发运的客户", "Please select the customer to ship")
        '    Exit Sub
        'End If



        '订单号规则 FY + 四位年 + 两位月 + 两位日 + 4位流水号
        '流水号每天从0001开始
        Dim seq As String = "xxxx"
        Dim code As String = 0

        db.sel("select ship_no from ship_order where TO_DAYS(create_datetime) =TO_DAYS(now()) order by id desc limit 0,1  ", dgtemp)
        If dgtemp.RowCount = 0 Then
            seq = "0001"
        Else
            Dim dno As String = dgtemp.Rows(0).Cells(0).Value
            seq = Format((Val(dno.Remove(0, dno.Length - 4)) + 1), "0000")

        End If
        db.sel("select DATE_SUB(curdate(),INTERVAL 0 DAY)", dgtemp)

        code = "FY" & Format(dgtemp.Rows(0).Cells(0).Value, "yyyyMMdd") & seq
        torderno.Text = code
        '插入数据库ship_order表，先占用单号
        db.sqlcmd("insert into ship_order (ship_no,customer,create_datetime,uid,ship_type) values ('" & torderno.Text & "','" & cbcustomer.Text & "',now(),'" & 主界面.uid.Text & "','" & cbsp.Text & "')")
        bsc.Enabled = False
        cbpartno.Enabled = True
        numbox.Enabled = True

        badd.Enabled = True
        breset.Enabled = True
        cbpartno.Enabled = True
        tsearch.Enabled = True
        ' cbsp.Enabled = False
        主界面.lhwddh.Text = torderno.Text
    End Sub

    Private Sub tsearch_EditValueChanged(sender As Object, e As EventArgs) Handles tsearch.TextChanged

        db.sel("select part_no as 零件号,part_desc as 名称 from part_info where part_no like '%" & tsearch.Text & "%' or part_desc like '%" & tsearch.Text & "%'", dgpart)
        dgpart.Visible = True
        If tsearch.Text = "" Then
            dgpart.Visible = False
        End If
    End Sub

    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        If cbcustomer.Text = "" Then
            db.rsmsg("请选择客户", "Please select customer.")
            Exit Sub
        ElseIf torderno.Text = "" Then
            db.rsmsg("请生成发运单号", "Please create shipping No.")
            Exit Sub
        End If

        Dim partdesc As String = 0
        '检查零件号是否正确
        db.sel("select part_desc,package from part_info where part_no = '" & lpartno.Text & "'", dgtemp)
        If dgtemp.RowCount > 0 Then
            partdesc = dgtemp.Rows(0).Cells(0).Value
        Else
            db.rsmsg("零件号错误，请检查", "The part number is wrong, please check")
            Exit Sub
        End If
        If numea.Text = 0 Then
            db.rsmsg("数量不能为0", "Qty can not be zero.")
            Exit Sub
        End If
        Dim package As String = dgtemp.Rows(0).Cells(1).Value
        If numea.Text Mod package = 0 Then
            numbox.Value = numea.Text \ package
        Else
            numbox.Value = numea.Text \ package + 1
        End If

        '如果待发布里有相同零件号，则提示是否更新数量，否则新增
        If dgdfb.RowCount > 0 Then
            For i = 0 To dgdfb.RowCount - 1
                If dgdfb.Rows(i).Cells(2).Value = lpartno.Text Then
                    db.rsmsg("待发布队列中已有此物料", "PartNo is exsit")
                    'If MsgBox("待发布队列中已有此物料，确认修改数量么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                    'Else
                    '    Exit Sub
                    'End If
                    'dgdfb.Rows(i).Cells(4).Value = numbox.Value
                    'cbpartno.Text = ""
                    'bpublic.Visible = True
                    'numbox.Value = 0
                    Exit Sub
                End If
            Next
            dgdfb.Rows.Add(torderno.Text, cbcustomer.Text, lpartno.Text, partdesc, numbox.Value, lunit.Text, numea.Text, linnerunit.Text)
        Else
            dgdfb.Rows.Add(torderno.Text, cbcustomer.Text, lpartno.Text, partdesc, numbox.Value, lunit.Text, numea.Text, linnerunit.Text)
        End If
        cbpartno.Text = ""
        numbox.Value = 0
        numea.Text = 0
        bpublic.Visible = True
        lpartno.Text = "001001"
        dgpart.Visible = False
    End Sub

    Private Sub cbpartno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpartno.SelectedIndexChanged
        Dim partno(5) As String
        partno = cbpartno.Text.Split("/")
        cbpartno.Text = partno(0)
        Try
            db.sel("select unit,inner_unit,package from part_info where part_no ='" & partno(0) & "'", dgtemp)
            If dgtemp.RowCount > 0 Then
                lunit.Text = dgtemp.Rows(0).Cells(0).Value
                linnerunit.Text = dgtemp.Rows(0).Cells(1).Value
                lpackage.Text = dgtemp.Rows(0).Cells(2).Value
                lpartno.Text = partno(0)
                'lunit.Visible = True
                'linnerunit.Visible = True
            End If
            linnernum.Text = numbox.Value * Val(lpackage.Text)
        Catch ex As Exception

        End Try

        numea.Select()
        numea.Focus()

    End Sub
    Private Sub dgpart_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpart.CellDoubleClick
        If dgpart.RowCount > 0 Then
        Else
            Exit Sub
        End If
        Dim index As String = dgpart.CurrentCell.RowIndex
        cbpartno.Text = dgpart.Rows(index).Cells(0).Value

        tsearch.Text = ""
        dgpart.Visible = False
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        'gbop重置，dgdfb重置，如果有生成过送货单号，则在delivery_order表里删除该单
        If torderno.Text.Length > 0 Then
            db.sqlcmd("delete from ship_order where ship_no ='" & torderno.Text & "'")
        End If
        dgdfb.Rows.Clear()
        gbopinitial()
    End Sub

    Private Sub bpublic_Click(sender As Object, e As EventArgs) Handles bpublic.Click


        If dgdfb.RowCount = 0 Then
            db.rsmsg("待发布列表为空，请检查", "The list to be published is empty, please check")
            Exit Sub
        End If

        'Air订单可以选择到一周内，Ship订单只能选择一周以外时间。
        db.sel("select date(now())", dgtemp)
        If cbsp.Text = "Ship" Then
            ' MsgBox(DateDiff(DateInterval.Day, dgtemp.Rows(0).Cells(0).Value, dt1.Value.Date))
            If DateDiff(DateInterval.Day, dgtemp.Rows(0).Cells(0).Value, dt1.Value.Date) < 7 Then
                db.rsmsg("普通订单最快1周后才能送达，请修改到货日期", "Ordinary orders can be delivered as soon as 1 week later. Please modify the arrival date.")
                Exit Sub

            End If
        ElseIf cbsp.Text = "Air" Then
            If DateDiff(DateInterval.Day, dgtemp.Rows(0).Cells(0).Value, dt1.Value.Date) < 3 Then
                db.rsmsg("普通订单最快3天后才能送达，请修改到货日期", "Ordinary orders can be delivered as soon as 3 days later. Please modify the arrival date.")
                Exit Sub

            End If
        End If

        '确认发运，插入ship_info表
        If MsgBox("确认发布如下的发运单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        Dim fyd, kh, ljh, ljm, sl As String
        Dim que As String = Format(1, "000")
        For i = 0 To dgdfb.RowCount - 1
            fyd = dgdfb.Rows(i).Cells(0).Value
            kh = dgdfb.Rows(i).Cells(1).Value
            ljh = dgdfb.Rows(i).Cells(2).Value
            ljm = dgdfb.Rows(i).Cells(3).Value
            sl = Val(dgdfb.Rows(i).Cells(6).Value) / Val(dgdfb.Rows(i).Cells(4).Value)


            db.sqlcmd("insert into ship_info (order_no,part_no,qty_plan,qty_plan_piece,customer,ship_datetime_plan,status,create_datetime,ship_type,part_desc) values " _
                      & "('" & fyd & "','" & ljh & "','" & dgdfb.Rows(i).Cells(4).Value & "','" & dgdfb.Rows(i).Cells(6).Value & "','" & kh & "','" & dt1.Value & "','Publish',now(),'" & cbsp.Text & "','" & dgdfb.Rows(i).Cells(3).Value & "')")

        Next

        dgdfb.Rows.Clear()
        dgyfb_refresh()
        gbopinitial()

        dghis_refresh()

        bsc_Click(1, e)
        dt1_refresh()
    End Sub

    Private Sub num1_ValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles numea.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbpartno.Text = "" Then
                numbox.Value = 0
                Exit Sub
            End If
            If (Val(numea.Text) > 0 And Val(numea.Text) < 9999) Or IsNumeric(numea.Text) = True Then
                linnernum.Text = numbox.Value * Val(lpackage.Text)
                badd.Focus()
                'MsgBox(Format(numea.Text, "0.00"))
            Else
                db.rsmsg("数量格式错误或者大于9999", "Num Format Error")
            End If
        
        End If

    End Sub

 
    Private Sub dgyfb_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgyfb.CellDoubleClick
        Dim index As String = dgyfb.CurrentCell.RowIndex

        客户要货单详情.lorder.Text = dgyfb.Rows(index).Cells(0).Value
        db.sel("select part_no,part_desc,qty_plan,qty_plan_piece,ship_datetime_plan,status from ship_info where order_no ='" & dgyfb.Rows(index).Cells(0).Value & "'", 客户要货单详情.dgdetail)
        客户要货单详情.ShowDialog()

    End Sub

    Private Sub trefresh_Tick(sender As Object, e As EventArgs) Handles trefresh.Tick
        If 主界面.lfydrefresh.Text = "Y" Then
            yfbrefresh_Tick(1, e)
            主界面.lfydrefresh.Text = "N"
        End If
    End Sub

    Private Sub cbsp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsp.SelectedIndexChanged
        If torderno.Text = "" Then
        Else
            db.sqlcmd("update ship_order set ship_type ='" & cbsp.Text & "' where ship_no ='" & torderno.Text & "'")

        End If
        dt1_refresh()
    End Sub
    Public Sub dt1_refresh()
        If cbsp.Text = "Ship" Then
            dt1.Value = Now.Date.AddDays(10)
        Else
            dt1.Value = Now.Date.AddDays(3)
        End If
    End Sub

    Private Sub bimport_Click(sender As Object, e As EventArgs) Handles bimport.Click

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
        ProgressBar1.Value = 0.3
        ProgressBar1.Visible = True

        Try

            Dim objAdapter1 As New OleDbDataAdapter("SELECT * FROM [orderinput$] where PartNo is not null", objConn) ' 打开指定sheet的数据
            Dim objDataset1 As New DataSet()
            objAdapter1.Fill(objDataset1) '将打开的数据放在dataset中
            dgimport.DataSource = objDataset1.Tables(0) '将数据传给DataGrid1控件' Clean up objects.
            objConn.Close()

            ProgressBar1.Value = 0.7
            '检查导入的零件号是否在主数据中，零件号是否有重复
            If dgimport.RowCount > 0 Then
            Else
                Exit Sub
            End If

            For i = 0 To dgimport.RowCount - 1
                db.sel("select part_no,part_desc from part_info where part_no ='" & dgimport.Rows(i).Cells(0).Value & "'", dgtemp)
                If dgtemp.RowCount > 0 Then

                Else
                    db.rsmsg("请检查第" & i + 1 & "行，导入的零件号错误", "PartNo error at Row " & i + 1 & "")
                    ProgressBar1.Visible = False
                    Exit Sub
                End If
            Next
            '检查重复
            If dgimport.RowCount > 1 Then
                For i = 0 To dgimport.RowCount - 2
                    For j = i + 1 To dgimport.RowCount - 1
                        If dgimport.Rows(i).Cells(0).Value = dgimport.Rows(j).Cells(0).Value Then
                            db.rsmsg("第" & i + 1 & "行与" & j + 1 & "行存在重复零件号:" & dgimport.Rows(i).Cells(0).Value & "", "PartNo repeat at Row " & i + 1 & " and " & j + 1 & ",PartNo:" & dgimport.Rows(i).Cells(0).Value & "")
                            ProgressBar1.Visible = False
                            Exit Sub
                        End If
                    Next
                Next
            End If
        
            '检查正确，填入信息至dgdfb
            dgdfb.Rows.Clear()
            Dim packagenum As String = 0
            For i = 0 To dgimport.RowCount - 1
                db.sel("select part_desc,package,unit,inner_unit from part_info where part_no ='" & dgimport.Rows(i).Cells(0).Value & "'", dgtemp)
                If dgimport.Rows(i).Cells(1).Value Mod dgtemp.Rows(0).Cells(1).Value = 0 Then
                    packagenum = dgimport.Rows(i).Cells(1).Value \ dgtemp.Rows(0).Cells(1).Value
                Else

                    packagenum = dgimport.Rows(i).Cells(1).Value \ dgtemp.Rows(0).Cells(1).Value + 1
                End If

                dgdfb.Rows.Add(torderno.Text, cbcustomer.Text, dgimport.Rows(i).Cells(0).Value, dgtemp.Rows(0).Cells(0).Value, packagenum, dgtemp.Rows(0).Cells(2).Value, dgimport.Rows(i).Cells(1).Value, dgtemp.Rows(0).Cells(3).Value)
            Next

            ProgressBar1.Value = 1
            ProgressBar1.Visible = False
            cbpartno.Text = ""
            numbox.Value = 0
            bpublic.Visible = True

            dgpart.Visible = False
        Catch ex As Exception

            db.rsmsg("模板错误", "Wrong Template")
            ProgressBar1.Visible = False
        End Try


    End Sub


    Private Sub yfbrefresh_Tick(sender As Object, e As EventArgs) Handles yfbrefresh.Tick
        '实时刷新已发布的信息，如果有为确认的更新信息，则提示
        dgyfb_refresh()
        Dim ifmsg As String = 0
        If dgyfb.RowCount > 0 Then
            For i = 0 To dgyfb.RowCount - 1
                If dgyfb.Rows(i).Cells(4).Value = "Not Yet" Then
                    dgyfb.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
                    ifmsg = 1
                End If
            Next
        End If

        If dgreject.RowCount > 0 Then
            For i = 0 To dgreject.RowCount - 1
                If dgreject.Rows(i).Cells(4).Value = "Not Yet" Then
                    dgreject.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
                    ifmsg = 1
                End If
            Next
        End If

        If ifmsg = 1 Then
            lrefreshmsg.Visible = True
        Else
            lrefreshmsg.Visible = False
        End If
    End Sub

    
    Private Sub dgreject_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgreject.CellDoubleClick
        Dim index As String = dgreject.CurrentCell.RowIndex

        客户要货单详情.lorder.Text = dgreject.Rows(index).Cells(0).Value
        db.sel("select part_no,part_desc,qty_plan,qty_plan_piece,create_datetime,status from ship_info where order_no ='" & dgreject.Rows(index).Cells(0).Value & "'", 客户要货单详情.dgdetail)
        客户要货单详情.ShowDialog()
    End Sub

  

    Private Sub dgdfb_KeyDown(sender As Object, e As KeyEventArgs) Handles dgdfb.KeyDown
        If e.KeyCode = Keys.Delete Then

        End If
    End Sub

    Public Sub dghis_refresh()
        db.sel("select ship_datetime_plan,order_no,part_no,part_desc,qty_plan,qty_plan_piece,create_datetime from ship_info order by id desc limit 0,100", dgtemp)

        db.dgadd(dgtemp, dghis, 7)
    End Sub

    Private Sub gbdfb_Enter(sender As Object, e As EventArgs) Handles gbdfb.Enter

    End Sub

    Private Sub numea_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            badd.Focus()
        End If
    End Sub


    Private Sub numea_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numea.KeyPress
        db.textbox_only_num(numea, e)

    End Sub
End Class
