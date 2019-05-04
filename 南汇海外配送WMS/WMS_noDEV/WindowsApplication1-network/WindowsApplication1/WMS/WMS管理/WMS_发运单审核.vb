Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_发运单审核
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
            .Width = Me.Width / 2
            .Height = Me.Height - gbop.Height - 15
        End With


        With gbconfirm
            .Left = gbdfb.Right + 5
            .Top = gbdfb.Top
            .Width = Me.Width / 2 - 15
            .Height = gbdfb.Height
        End With

        With dgorder
            .Left = Me.Left + 10
            .Top = Me.Top + 30
            .Width = gbdfb.Width - 20
            .Height = gbdfb.Height - 60
        End With

        'With lxqrq
        '    .Left = +10
        '    .Top = Me.Top + 30
        'End With
        'With dt1
        '    .Left = lxqrq.Right + 20
        '    .Top = lxqrq.Top
        'End With

        'With dgyfb
        '    .Left = Me.Left + 10
        '    .Top = dt1.Bottom + 30
        '    .Width = gbconfirm.Width - 20

        'End With

        With premark
            .Left = dgyfb.Left
            .Top = dgyfb.Bottom + 15
            .Width = dgyfb.Width
            .Height = gbconfirm.Height - dgyfb.Height - dt1.Height
        End With

        lxg.Top = dt1.Top
        lxg.Left = dt1.Right + 5

        dt1.Value = Now.Date
    End Sub
    Private Sub WMS_发运单审核_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        dgorder.Columns.Add("0", "订单")
        dgorder.Columns.Add("1", "客户")
        dgorder.Columns.Add("2", "要求时间")
        dgorder.Columns.Add("3", "订单类型")
        dgorder.Columns.Add("4", "状态")
        dgorder.Columns("1").Visible = False


        dgyfb.Columns.Add("0", "物料号")
        dgyfb.Columns.Add("1", "箱数")
        dgyfb.Columns.Add("2", "要货数量")
        dgyfb.Columns.Add("3", "物料名")
        dgorder_refresh()

        db.sel("select customer from customer_info order by id", dgtemp)
        db.comboboxaddin(dgtemp, cbcustomer)
        cbcustomer.Items.Add("")
    End Sub

    Public Sub dgorder_refresh()
        '刷新订单的内容
        db.sel("select order_no as 订单,customer as 客户,ship_datetime_plan as 要求时间,ship_type as 订单类型,status as 状态 from ship_info where (status ='Publish' or status='Modify')  and part_no like '%" & cbpartno.Text & "%' group by order_no order by ship_type desc,status,order_no,ship_datetime_plan", dgtemp)
        db.dgadd(dgtemp, dgorder, 5)
        db.dgsortdisable(dgorder)
        '区分urgent和normal订单颜色
        If dgorder.RowCount > 0 Then
            For i = 0 To dgorder.RowCount - 1
                If dgorder.Rows(i).Cells(3).Value = "Urgent" Then
                    dgorder.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                End If
            Next
        End If

    End Sub

  

    Private Sub dgorder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgorder.CellClick
        '点击从订单列表里选择，把详细的物料信息显示在右边的框中。并且把审核通过和审核驳回按钮激活。

        Dim index As String = dgorder.CurrentCell.RowIndex
        db.sel("select part_no,qty_plan,qty_plan_piece,part_desc,ship_datetime_plan from ship_info where order_no ='" & dgorder.Rows(index).Cells(0).Value & "'", dgtemp)
        db.dgadd(dgtemp, dgyfb, 4)
        dt1.Value = dgorder.Rows(index).Cells(2).Value
        dt2.Value = dt1.Value
        dt1.Enabled = False
        bconfirm.Enabled = True
        breject.Enabled = True
        lorder.Text = dgorder.Rows(index).Cells(0).Value

        lordertime.Text = dgorder.Rows(index).Cells(4).Value
        dttemp.Value = dt1.Value
    End Sub

    Private Sub bconfirm_Click(sender As Object, e As EventArgs) Handles bconfirm.Click
        If MsgBox("确认审核通过订单:" & lorder.Text & "？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sqlcmd("update ship_info set status='Process',remark='" & tremark.Text & "' where order_no='" & lorder.Text & "'")
        dgorder_refresh()
        lorder.Text = ""
        dgyfb.Rows.Clear()
        tremark.Text = ""
        bconfirm.Enabled = False
        breject.Enabled = False
    End Sub

    Private Sub breject_Click(sender As Object, e As EventArgs) Handles breject.Click
        If MsgBox("确认审核驳回订单:" & lorder.Text & "？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sqlcmd("update ship_info set status='Reject',remark='" & tremark.Text & "',confirm='Not Yet' where order_no='" & lorder.Text & "'")
        dgorder_refresh()
        lorder.Text = ""
        dgyfb.Rows.Clear()
        tremark.Text = ""
        bconfirm.Enabled = False
        breject.Enabled = False
    End Sub

    Private Sub lxg_Click(sender As Object, e As EventArgs) Handles lxg.Click
        dt1.Enabled = True
        bconfirm.Enabled = False
        bmodify.Enabled = True
    End Sub

    Private Sub bmodify_Click(sender As Object, e As EventArgs) Handles bmodify.Click
        If dt1.Value.Date = dt2.Value Then
            db.rsmsg("日期没有修改，请确认。", "Date has not been modified, please confirm.")
            Exit Sub
        End If
        If MsgBox("确认修改订单交期:" & lorder.Text & "？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sqlcmd("update ship_info set status='Modify',ship_datetime_plan='" & dt1.Value & "',remark='" & tremark.Text & "',confirm ='Not Yet' where order_no='" & lorder.Text & "'")
        dgorder_refresh()
        lorder.Text = ""
        dgyfb.Rows.Clear()
        tremark.Text = ""
        bconfirm.Enabled = False
        breject.Enabled = False
        bmodify.Enabled = False
    End Sub

  
    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged, dttemp.ValueChanged
        If dt1.Value.Date < dttemp.Value.Date Then
            db.rsmsg("修改时间只允许往后", "")
            dt1.Value = dttemp.Value
        End If
    End Sub

    Private Sub brefresh_Click(sender As Object, e As EventArgs) Handles brefresh.Click
        dgorder_refresh()
    End Sub
End Class
