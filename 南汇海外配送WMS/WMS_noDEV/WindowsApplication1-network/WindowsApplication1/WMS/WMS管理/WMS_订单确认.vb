Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_订单确认
    Dim db As DBconfig = New DBconfig

    Private Sub WMS_订单确认_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgyfb.Columns.Add("0", "Shipping No.")
        dgyfb.Columns.Add("1", "Status")
        dgyfb.Columns.Add("2", "Type")
        dgyfb.Columns.Add("3", "Datetime Plan")
        dgyfb.Columns.Add("4", "Confirm")
        dgdfb_refresh()
    End Sub
    Public Sub dgdfb_refresh()
        db.sel("select order_no,status,ship_type,ship_datetime_plan,confirm from ship_info where (status ='Reject' or status = 'Modify') and confirm ='Not Yet'  group by order_no order by status,ship_type desc, ship_datetime_plan,order_no limit 0,20", dgtemp)
        db.dgadd(dgtemp, dgyfb, 5)
    End Sub

    Private Sub dgyfb_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgyfb.CellClick
        Dim index As String = dgyfb.CurrentCell.RowIndex
        lorder.Text = dgyfb.Rows(index).Cells(0).Value
        db.sel("select part_no,part_desc,qty_plan,qty_plan_piece,ship_datetime_plan,status from ship_info where order_no ='" & dgyfb.Rows(index).Cells(0).Value & "'", dgdetail)
        bconfirm.Enabled = True
        breject.Enabled = True
    End Sub

    Private Sub bconfirm_Click(sender As Object, e As EventArgs) Handles bconfirm.Click
        If MsgBox("Confirm order :" & lorder.Text & "？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sqlcmd("update ship_info set confirm='Yes',status='Process' where order_no ='" & lorder.Text & "'")
        dgdfb_refresh()
        dgdetail.DataSource = Nothing
        dgdetail.Refresh()
        bconfirm.Enabled = False
        breject.Enabled = False
    End Sub

    Private Sub breject_Click(sender As Object, e As EventArgs) Handles breject.Click
        If MsgBox("Cancel order :" & lorder.Text & "？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sqlcmd("update ship_info set confirm='Yes',status='Cancel' where order_no ='" & lorder.Text & "'")
        dgdfb_refresh()
        dgdetail.DataSource = Nothing
        dgdetail.Refresh()
        bconfirm.Enabled = False
        breject.Enabled = False

    End Sub
End Class
