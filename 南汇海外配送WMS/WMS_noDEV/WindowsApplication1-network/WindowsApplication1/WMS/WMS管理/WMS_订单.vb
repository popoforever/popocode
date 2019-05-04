Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_订单
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
            .Width = Me.Width / 4 * 3
            .Height = Me.Height - gbop.Height - 15
        End With

        With gbyfb
            .Left = gbdfb.Right + 5
            .Top = gbop.Bottom
            .Width = Me.Width / 4 - 15
            .Height = gbdfb.Height
        End With

        With dgdfb
            .Left = Me.Left
            .Top = Me.Top + 60
            .Width = gbdfb.Width
            .Height = gbdfb.Height - 45
        End With

        With dgyfb
            .Left = Me.Left
            .Top = Me.Top + 60
            .Width = gbyfb.Width
            .Height = gbyfb.Height - 45
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

        dt1.Value = Now.Date

    End Sub
    Public Sub gbopenable()
        For Each con1 As Control In gbop.Controls
            con1.Enabled = True
        Next
    End Sub
    Public Sub gbopdisable()
        For Each con1 As Control In gbop.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Label") Then
            Else
                con1.Enabled = False
            End If
        Next

    End Sub
    Public Sub gbopinitial()
        torderno.Text = ""
        cbpartno.Text = ""
        num1.Value = 0
        dt1.Value = Now.Date
        tsearch.Text = ""
        gbopdisable()
        bsc.Enabled = True
        dgpart.Visible = False
    End Sub
    Public Sub dgyfb_refresh()
        db.sel("select order_no,status from order_info where status < 3 group by order_no order by create_datetime desc", dgtemp)
        If dgtemp.RowCount > 0 Then
            Dim status As String
            dgyfb.Rows.Clear()
            For i = 0 To dgtemp.RowCount - 1
                status = dgtemp.Rows(i).Cells(1).Value
                Select Case status
                    Case "1"
                        status = "Pubilsh"
                    Case "2"
                        status = "Confirm"
                End Select
                dgyfb.Rows.Add(dgtemp.Rows(i).Cells(0).Value, status)
            Next
        End If
    End Sub
    Private Sub WMS_订单_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        gbopdisable()

        dgdfb.Columns.Add("0", "送货号")
        dgdfb.Columns.Add("1", "工厂")
        dgdfb.Columns.Add("2", "零件号")
        dgdfb.Columns.Add("3", "名称")
        dgdfb.Columns.Add("4", "箱数")
        dgdfb.Columns.Add("5", "包装单位")
        dgdfb.Columns.Add("6", "数量")
        dgdfb.Columns.Add("7", "内部单位")
        db.dgsortdisable(dgdfb)

        dgyfb.Columns.Add("0", "送货号")
        dgyfb.Columns.Add("1", "状态")
        dgyfb_refresh()
        db.dgsortdisable(dgyfb)

        '工厂数据自动根据账号带出
        'db.sel("select factory from user_info where uid = '" & 主界面.uid.Text & "'", dgtemp)
        'If dgtemp.RowCount > 0 Then

        tfactory.Text = 主界面.lfactory.Text
        bsc.Visible = True
        bsc.Enabled = True

        'Else
        'gbopdisable()
        'End If

        '填充cbpartno
        db.sel("select part_no,part_desc from part_info order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbpartno.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cbpartno.Items.Add(dgtemp.Rows(i).Cells(0).Value & "/" & dgtemp.Rows(i).Cells(1).Value)
            Next
        End If

        cbsp.Items.Add("Normal")
        cbsp.Items.Add("Urgent")
        cbsp.Text = cbsp.Items(0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bsc.Click
        '订单号规则 SH + 四位年 + 两位月 + 两位日 + 4位流水号
        '流水号每天从0001开始
        Dim seq As String = "xxxx"
        Dim code As String = 0

        db.sel("select delivery_no from delivery_order where TO_DAYS(createdatetime) =TO_DAYS(now()) order by id desc limit 0,1  ", dgtemp)
        If dgtemp.RowCount = 0 Then
            seq = "0001"
        Else
            Dim dno As String = dgtemp.Rows(0).Cells(0).Value
            seq = Format((Val(dno.Remove(0, dno.Length - 4)) + 1), "0000")

        End If
        db.sel("select DATE_SUB(curdate(),INTERVAL 0 DAY)", dgtemp)

        code = "SH" & Format(dgtemp.Rows(0).Cells(0).Value, "yyyyMMdd") & seq
        torderno.Text = code
        '插入数据库delivery_order表，先占用单号
        db.sqlcmd("insert into delivery_order (delivery_no,factory,createdatetime,uid) values ('" & torderno.Text & "','" & tfactory.Text & "',now(),'" & 主界面.uid.Text & "')")
        bsc.Enabled = False
        cbpartno.Enabled = True
        num1.Enabled = True
        dt1.Enabled = True
        badd.Enabled = True
        breset.Enabled = True
        cbpartno.Enabled = True
        tsearch.Enabled = True
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        'gbop重置，dgdfb重置，如果有生成过送货单号，则在delivery_order表里删除该单
        If torderno.Text.Length > 0 Then
            db.sqlcmd("delete from delivery_order where delivery_no ='" & torderno.Text & "'")
        End If
        dgdfb.Rows.Clear()
        gbopinitial()
    End Sub

    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        Dim partdesc As String = 0
        '检查零件号是否正确
        db.sel("select part_desc from part_info where part_no = '" & cbpartno.Text & "'", dgtemp)
        If dgtemp.RowCount > 0 Then
            partdesc = dgtemp.Rows(0).Cells(0).Value
        Else
            db.rsmsg("零件号错误，请检查", "The part number is wrong, please check")
            Exit Sub
        End If
        If num1.Value = 0 Then
            db.rsmsg("数量不能为0", "Qty can not be zero")
            Exit Sub
        End If

        '如果待发布里有相同零件号，则提示是否更新数量，否则新增
        If dgdfb.RowCount > 0 Then
            For i = 0 To dgdfb.RowCount - 1
                If dgdfb.Rows(i).Cells(2).Value = cbpartno.Text Then
                    If MsgBox("待发布队列中已有此零件，确认修改数量么？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                    dgdfb.Rows(i).Cells(4).Value = num1.Value
                    cbpartno.Text = ""
                    bpublic.Visible = True
                    num1.Value = 0
                    Exit Sub
                End If
            Next
            dgdfb.Rows.Add(torderno.Text, tfactory.Text, cbpartno.Text, partdesc, num1.Value, lunit.Text, linnernum.Text, linnerunit.Text)
        Else
            dgdfb.Rows.Add(torderno.Text, tfactory.Text, cbpartno.Text, partdesc, num1.Value, lunit.Text, linnernum.Text, linnerunit.Text)
        End If
        cbpartno.Text = ""
        num1.Value = 0
        bpublic.Visible = True
        bdel.Visible = True
        dgpart.Visible = False
    End Sub

    Private Sub cbdesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpartno.SelectedIndexChanged
        Dim partno(5) As String
        partno = cbpartno.Text.Split("/")
        cbpartno.Text = partno(0)
        Try
            db.sel("select unit,inner_unit,package from part_info where part_no ='" & cbpartno.Text & "'", dgtemp)
            If dgtemp.RowCount > 0 Then
                lunit.Text = dgtemp.Rows(0).Cells(0).Value
                linnerunit.Text = dgtemp.Rows(0).Cells(1).Value
                lpackage.Text = dgtemp.Rows(0).Cells(2).Value
                lunit.Visible = True
                linnerunit.Visible = True

            End If
            linnernum.Text = num1.Value * Val(lpackage.Text)
        Catch ex As Exception

        End Try

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

    Private Sub bdel_Click(sender As Object, e As EventArgs) Handles bdel.Click
        Try
            Dim index As String = dgdfb.CurrentCell.RowIndex
            dgdfb.Rows.RemoveAt(index)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bpublic_Click(sender As Object, e As EventArgs) Handles bpublic.Click
        If dgdfb.RowCount = 0 Then
            db.rsmsg("待发布列表为空，请检查", "The list to be published is empty, please check.")
            Exit Sub
        End If

        '确认送货，插入order_info表
        If MsgBox("确认发布如下的送货单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        Dim shd, gc, ljh, ljm, sl, barcode As String
        Dim que As String = Format(1, "000")
        For i = 0 To dgdfb.RowCount - 1
            shd = dgdfb.Rows(i).Cells(0).Value
            gc = dgdfb.Rows(i).Cells(1).Value
            ljh = dgdfb.Rows(i).Cells(2).Value
            ljm = dgdfb.Rows(i).Cells(3).Value
            sl = Val(dgdfb.Rows(i).Cells(6).Value) / Val(dgdfb.Rows(i).Cells(4).Value)


            db.sqlcmd("insert into order_info (order_no,part_no,part_qty,supplier,arrivedate_plan,status,create_datetime) values " _
                      & "('" & shd & "','" & ljh & "','" & dgdfb.Rows(i).Cells(4).Value & "','" & gc & "','" & dt1.Value & "',1,now())")

            '生成条码，插入barcode_info表,条码规则：送货单号+流水号(整包条码) , 每一箱一个条码

            'db.sqlcmd("insert into barcode_info (barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime,unit,supplier,inner_unit,inner_qty) values " _
            '          & "('" & barcode & "','" & ljh & "','" & ljm & "','" & shd & "','" & sl & "',1,now(),'" & lunit.Text & "','" & gc & "')")
            'que = Format(Val(que) + 1, "000")
            For j = 0 To Val(dgdfb.Rows(i).Cells(4).Value) - 1
                barcode = shd & que
                db.sqlcmd("insert into barcode_info (barcode,part_no,part_desc,order_no,qty_plan,status,create_datetime,unit,supplier,inner_qty,inner_unit) values " _
                  & "('" & barcode & "','" & ljh & "','" & ljm & "','" & shd & "','1',1,now(),'" & lunit.Text & "','" & gc & "','" & sl & "','" & dgdfb.Rows(i).Cells(7).Value & "')")
                que = Format(Val(que) + 1, "000")
            Next

        Next

        dgdfb.Rows.Clear()
        dgyfb_refresh()
        gbopinitial()
        bpublic.Visible = False
        bdel.Visible = False
    End Sub

   
    Private Sub byfbrefresh_Click(sender As Object, e As EventArgs) Handles byfbrefresh.Click
        dgyfb_refresh()
    End Sub

    Private Sub num1_ValueChanged(sender As Object, e As EventArgs) Handles num1.ValueChanged
        If cbpartno.Text = "" Then

            num1.Value = 0

            Exit Sub
        End If
        linnernum.Text = num1.Value * Val(lpackage.Text)
    End Sub


    Private Sub tsearch_EditValueChanged_1(sender As Object, e As EventArgs) Handles tsearch.TextChanged
        db.sel("select part_no as 零件号,part_desc as 名称 from part_info where part_no like '%" & tsearch.Text & "%' or part_desc like '%" & tsearch.Text & "%'", dgpart)
        dgpart.Visible = True
        If tsearch.Text = "" Then
            dgpart.Visible = False
        End If
    End Sub

 
    Private Sub tfactory_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub torderno_EditValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class
