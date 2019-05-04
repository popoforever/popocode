Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_退货任务
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
 
    Public Sub gbopinitial()
        cbfactory.Text = ""
        torderno.Text = ""
        cbpartno.Text = ""
        num1.Value = 0
        dt1.Value = Now.Date
        tsearch.Text = ""

        bsc.Enabled = True
        dgpart.Visible = False
    End Sub
    Private Sub WMS_退货任务_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()

        dgdfb.Columns.Add("0", "退货号")
        dgdfb.Columns.Add("1", "工厂")
        dgdfb.Columns.Add("2", "零件号")
        dgdfb.Columns.Add("3", "名称")
        dgdfb.Columns.Add("4", "数量")
        dgdfb.Columns.Add("5", "单位")
        db.dgsortdisable(dgdfb)

        dgyfb.Columns.Add("0", "退货号")
        dgyfb.Columns.Add("1", "状态")
        'dgyfb_refresh()
        db.dgsortdisable(dgyfb)

        db.sel("select factory from factory_info group by factory", dgtemp)
        db.comboboxaddin(dgtemp, cbfactory)
        dgyfb_refresh()
      
    End Sub

    Private Sub cbpartno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpartno.SelectedIndexChanged
        If cbpartno.Items.Count > 0 Then
        Else
            Exit Sub
        End If
        Dim partno(5) As String
        partno = cbpartno.Text.Split("/")
        cbpartno.Text = partno(0)
        Try
            db.sel("select unit from part_info where part_no ='" & cbpartno.Text & "'", dgtemp)
            If dgtemp.RowCount > 0 Then
                lunit.Text = dgtemp.Rows(0).Cells(0).Value
                lunit.Visible = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbfactory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbfactory.SelectedIndexChanged
        '填充cbpartno
        db.sel("select part_no,part_desc from part_factory where supplier ='" & cbfactory.Text & "'", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbpartno.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cbpartno.Items.Add(dgtemp.Rows(i).Cells(0).Value & "/" & dgtemp.Rows(i).Cells(1).Value)
            Next
        Else
            cbpartno.Items.Clear()
        End If
    End Sub

    Private Sub bsc_Click(sender As Object, e As EventArgs) Handles bsc.Click
        If cbfactory.Text = "" Or cbpartno.Text = "" Then
            db.rsmsg("请正确选择工厂和要退货的零件", "Please select the factory and the parts to be returned correctly.")
            Exit Sub
        End If

        '订单号规则 TH + 四位年 + 两位月 + 两位日 + 4位流水号
        '流水号每天从0001开始
        Dim seq As String = "xxxx"
        Dim code As String = 0

        db.sel("select return_no from return_order where TO_DAYS(create_datetime) =TO_DAYS(now()) order by id desc limit 0,1  ", dgtemp)
        If dgtemp.RowCount = 0 Then
            seq = "0001"
        Else
            Dim dno As String = dgtemp.Rows(0).Cells(0).Value
            seq = Format((Val(dno.Remove(0, dno.Length - 4)) + 1), "0000")

        End If
        db.sel("select DATE_SUB(curdate(),INTERVAL 0 DAY)", dgtemp)

        code = "TH" & Format(dgtemp.Rows(0).Cells(0).Value, "yyyyMMdd") & seq
        torderno.Text = code
        '插入数据库delivery_order表，先占用单号
        db.sqlcmd("begin;insert into return_order (return_no,factory,create_datetime,uid) values ('" & torderno.Text & "','" & cbfactory.Text & "',now(),'" & 主界面.uid.Text & "');commit;")
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
            db.sqlcmd("delete from return_order where return_no ='" & torderno.Text & "'")
        End If
        dgdfb.Rows.Clear()
        gbopinitial()
    End Sub

    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        If torderno.Text = "" Then
            db.rsmsg("请生成退货单", "Please generate a return order.")
            Exit Sub
        End If

        Dim partdesc As String = 0
        '检查零件号是否正确
        db.sel("select part_desc from part_info where part_no = '" & cbpartno.Text & "'", dgtemp)
        If dgtemp.RowCount > 0 Then
            partdesc = dgtemp.Rows(0).Cells(0).Value
        Else
            db.rsmsg("零件号错误，请检查", "The part number is wrong, please check.")
            Exit Sub
        End If
        If num1.Value = 0 Then
            db.rsmsg("数量不能为0", "Qty can not be zero.")
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
            dgdfb.Rows.Add(torderno.Text, cbfactory.Text, cbpartno.Text, partdesc, num1.Value, lunit.Text)
        Else
            dgdfb.Rows.Add(torderno.Text, cbfactory.Text, cbpartno.Text, partdesc, num1.Value, lunit.Text)
        End If
        cbpartno.Text = ""
        num1.Value = 0
        bpublic.Visible = True
        bdel.Visible = True
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
        Dim thd, gc, ljh, ljm, sl As String
        Dim que As String = Format(1, "000")
        For i = 0 To dgdfb.RowCount - 1
            thd = dgdfb.Rows(i).Cells(0).Value
            gc = dgdfb.Rows(i).Cells(1).Value
            ljh = dgdfb.Rows(i).Cells(2).Value
            ljm = dgdfb.Rows(i).Cells(3).Value
            sl = dgdfb.Rows(i).Cells(4).Value


            db.sqlcmd("insert into returnorder_info (order_no,part_no,part_qty,supplier,plan_datetime,status,create_datetime) values " _
                      & "('" & thd & "','" & ljh & "','" & sl & "','" & gc & "','" & dt1.Value & "',1,now())")
        Next

        dgdfb.Rows.Clear()
        dgyfb_refresh()
        gbopinitial()
        bpublic.Visible = False
        bdel.Visible = False
    End Sub
    Public Sub dgyfb_refresh()
        db.sel("select order_no,status from returnorder_info where status < 3 group by order_no order by create_datetime desc", dgtemp)
        If dgtemp.RowCount > 0 Then
            Dim status As String
            dgyfb.Rows.Clear()
            For i = 0 To dgtemp.RowCount - 1
                status = dgtemp.Rows(i).Cells(1).Value
                Select Case status
                    Case "1"
                        status = "待退货"
                    Case "2"
                        status = "退货中"
                End Select
                dgyfb.Rows.Add(dgtemp.Rows(i).Cells(0).Value, status)
            Next
        End If
    End Sub

    Private Sub cbfactory_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    

End Class
