Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_盘点确认

    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()

        With bok
            bok.Top = gbop.Bottom + 5
            bok.Left = Me.Left
        End With
        With tab1
            .Top = bok.Bottom + 10
            .Left = Me.Left
            .Height = Me.Height - gbop.Height - 30
            .Width = Me.Width
        End With
        With dgtab1
            .Top = Me.Top
            .Left = Me.Left
            .Width = tabpage1.Width
            .Height = tabpage1.Height - 15
        End With


    End Sub
    Public Sub gbop_initial()
        db.sel("select checklist_no from check_info where status < 3 group by checklist_no order by create_datetime desc", dgtemp)
        db.comboboxaddin(dgtemp, cbpdd)

        dgtab1.Rows.Clear()
        dgtab2.DataSource = Nothing
    End Sub
    Private Sub WMS_盘点确认_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        tabpage1.Text = "盘点结果"
        tabpage2.Text = "明细信息"
        dgtab1.Columns.Add("0", "物料号")
        dgtab1.Columns.Add("1", "名称")
        dgtab1.Columns.Add("2", "原箱数")
        dgtab1.Columns.Add("3", "原内部数")
        dgtab1.Columns.Add("4", "盘点箱数")
        dgtab1.Columns.Add("5", "盘点内部数")
        db.dgsortdisable(dgtab1)
        gbop_initial()
    End Sub

    Private Sub cbpdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpdd.SelectedIndexChanged
        'dgtab1填写
        '填写物料号,物料名,原箱数汇总，原内部数量汇总
        dgtab1.Rows.Clear()
        db.sel("select part_no from check_info where checklist_no ='" & cbpdd.Text & "' order by id", dgtemp2)
        For i = 0 To dgtemp2.Rows.Count - 1
            db.sel("select part_no,part_desc,bar_count,qty_sum from check_count where part_no ='" & dgtemp2.Rows(i).Cells(0).Value & "'", dgtemp)
            db.dgadd_noclear(dgtemp, dgtab1, 4)
        Next
        '填写盘点箱数，盘点内部数
        db.sel("select part_no,count(barcode),sum(inner_qty) from check_result where checklist_no ='" & cbpdd.Text & "' group by part_no", dgtemp)
        For i = 0 To dgtab1.Rows.Count - 1
            If dgtemp.RowCount > 0 Then
                For j = 0 To dgtemp.Rows.Count - 1
                    If dgtemp.Rows(j).Cells(0).Value = dgtab1.Rows(i).Cells(0).Value Then
                        dgtab1.Rows(i).Cells(4).Value = dgtemp.Rows(j).Cells(1).Value
                        dgtab1.Rows(i).Cells(5).Value = dgtemp.Rows(j).Cells(2).Value
                    End If
                Next
            Else
                dgtab1.Rows(i).Cells(4).Value = 0
                dgtab1.Rows(i).Cells(5).Value = 0
            End If

        Next
        '盘点明细信息填写
        db.sel("select barcode as 条码,part_no as 物料号,part_desc as 名称,inner_qty as 内部数量,bin_no as 库位 from check_result where checklist_no = '" & cbpdd.Text & "' order by part_no", dgtab2)
        db.dgsortdisable(dgtab2)
        bok.Visible = True
    End Sub

    Private Sub tabpage2_Paint(sender As Object, e As PaintEventArgs)
        With dgtab2
            .Top = Me.Top
            .Left = Me.Left
            .Width = TabPage2.Width
            .Height = TabPage2.Height - 15
        End With
    End Sub
    Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
        If MsgBox("确认调整如下的盘点结果？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If



        '确定调整差异。check_result，当前盘点单所对应的条码在barcode_info表里解冻，if_freeze = 0,状态为在库状态status=2,bin_no库位更新
        If dgtab2.RowCount > 0 Then
            For i = 0 To dgtab2.RowCount - 1
                db.sqlcmd("update barcode_info set if_freeze = 0,status=2,bin_no ='" & dgtab2.Rows(i).Cells(4).Value & "' where barcode ='" & dgtab2.Rows(i).Cells(0).Value & "'")
            Next
        Else
            db.rsmsg("盘点结果不能为空", "Counting results cannot be empty.")
            Exit Sub
        End If

        'check_info表里，该盘点单号的status=3
        db.sqlcmd("update check_info set status =3 where checklist_no ='" & cbpdd.Text & "'")
        db.rsmsg("盘点单" & cbpdd.Text & "调整完成", "Checklist" & cbpdd.Text & "adjust ok.")
        gbop_initial()

    End Sub

  
End Class
