Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_订单查看
    Dim db As DBconfig = New DBconfig
    Public Sub dgorder_refresh()
        db.sel("select order_no,status,ship_type,ship_datetime_plan from ship_info where status like  '%" & cbstatus.Text & "%' and ship_type like '%" & cbtype.Text & "%' group by order_no  order by create_datetime desc limit 0,300 ", dgtemp)
        db.dgadd(dgtemp, dgorder, 4)
    End Sub
    Private Sub WMS_订单查看_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgorder.Columns.Add("0", "Order No.")
        dgorder.Columns.Add("1", "Status")
        dgorder.Columns.Add("2", "Ship Type")
        dgorder.Columns.Add("3", "Demand Date")

   
        dgdetail.Columns.Add("0", "Part No.")
        dgdetail.Columns.Add("1", "Part Name")
        dgdetail.Columns.Add("2", "Qty")

        dgorder_refresh()

    End Sub

    Private Sub dgorder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgorder.CellClick
        Dim index As String = dgorder.CurrentCell.RowIndex
        Try
            db.sel("select part_no,part_desc,qty_plan_piece from ship_info where order_no ='" & dgorder.Rows(index).Cells(0).Value & "'", dgtemp)
            db.dgadd(dgtemp, dgdetail, 3)
        Catch ex As Exception

        End Try


    End Sub

   
    Private Sub bsearch_Click(sender As Object, e As EventArgs) Handles bsearch.Click
        dgorder_refresh()
        dgdetail.Rows.Clear()
    End Sub
End Class
