Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_事务报表
    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()
        With gbop
            .Left = Me.Left
            .Top = Me.Top
            .Width = Me.Width - 10
        End With

        With gbdetail
            .Left = Me.Left
            .Top = gbop.Bottom
            .Width = Me.Width / 4 * 3
            .Height = Me.Height - gbop.Height - 15
        End With

        With gbsum
            .Left = gbdetail.Right + 5
            .Top = gbop.Bottom
            .Width = Me.Width / 4 - 15
            .Height = gbdetail.Height
        End With

        With dgdetail
            .Left = Me.Left
            .Top = Me.Top
            .Width = gbdetail.Width
            .Height = gbdetail.Height - 45
        End With

        With dgsum
            .Left = Me.Left
            .Top = Me.Top
            .Width = gbsum.Width
            .Height = gbsum.Height - 45
        End With

        With dgpart

            .Left = cbpartno.Left
            .Top = gbop.Bottom
            .Width = 300
            .Height = 200

        End With
    End Sub
    Private Sub WMS事务报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        dt1.Value = Now.Date
        dt2.Value = Now.Date
        ldt1.Text = Format(dt1.Value.Date, "yyyy-MM-dd") & " 00:00:00"
        ldt2.Text = Format(dt2.Value.Date, "yyyy-MM-dd") & " 23:59:59"


        '填充cbpartno
        db.sel("select part_no,part_desc from part_info order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbpartno.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cbpartno.Items.Add(dgtemp.Rows(i).Cells(0).Value & "/" & dgtemp.Rows(i).Cells(1).Value)
            Next
        End If

        dgdetail.ContextMenuStrip = menudgdetail
        dgsum.ContextMenuStrip = menudgsum
    End Sub

    Private Sub dt1_ValueChanged(sender As Object, e As EventArgs) Handles dt1.ValueChanged
        ldt1.Text = Format(dt1.Value.Date, "yyyy-MM-dd") & " 00:00:00"
    End Sub

    Private Sub dt2_ValueChanged(sender As Object, e As EventArgs) Handles dt2.ValueChanged
        ldt2.Text = Format(dt2.Value.Date, "yyyy-MM-dd") & " 23:59:59"
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


    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        '检查查询选项是否为空
        If cbop.Text = "" Then
            db.rsmsg("请选择查询的事务", "Please select the transaction for the query.")
            Exit Sub
        ElseIf dt1.Value > dt2.Value Then
            db.rsmsg("开始日期不能晚于结束日期", "Start date cannot be later than the end date")
            Exit Sub
        End If
        db.sel("select barcode as 条码,part_no as 物料号,part_desc as 名称,qty_actual as 内部数量,transaction as 操作,bin_no as 库位,date_time as 操作时间,user_id as 操作人,task_no as 任务单号 from transaction_info " _
               & "where transaction ='" & cbop.Text & "' and part_no like '%" & cbpartno.Text & "%' and (unix_timestamp(date_time) > unix_timestamp( '" & ldt1.Text & "') and unix_timestamp(date_time) < unix_timestamp( '" & ldt2.Text & "'))", dgdetail)
        db.dgsortdisable(dgdetail)

        db.sel("select part_no as 物料号,count(barcode) as 箱数,sum(qty_actual) as 内部总数 from transaction_info " _
               & "where transaction ='" & cbop.Text & "' and part_no like '%" & cbpartno.Text & "%' and (unix_timestamp(date_time) > unix_timestamp( '" & ldt1.Text & "') and unix_timestamp(date_time) < unix_timestamp( '" & ldt2.Text & "')) group by part_no", dgsum)
        db.dgsortdisable(dgsum)
    End Sub

    Private Sub cbpartno_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim partno(5) As String
        partno = cbpartno.Text.Split("/")
        cbpartno.Text = partno(0)
    End Sub



    Private Sub 导出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导出ToolStripMenuItem.Click
        db.expo(dgdetail, "事务明细")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        db.expo(dgsum, "事务汇总")
    End Sub

    Private Sub tsearch_EditValueChanged(sender As Object, e As EventArgs)
        db.sel("select part_no as 零件号,part_desc as 名称 from part_info where part_no like '%" & tsearch.Text & "%' or part_desc like '%" & tsearch.Text & "%'", dgpart)
        If tsearch.Text = "" Then
            dgpart.Visible = False
        Else
            dgpart.Visible = True
        End If
    End Sub


End Class
