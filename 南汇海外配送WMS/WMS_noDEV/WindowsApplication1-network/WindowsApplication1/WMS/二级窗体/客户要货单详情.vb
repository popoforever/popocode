Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class 客户要货单详情
    Dim db As DBconfig = New DBconfig
    Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
        If dgdetail.Rows(0).Cells(5).Value = "Modify" Then
            db.sqlcmd("update ship_info set status ='Process' where order_no='" & lorder.Text & "'")
        End If
        db.sqlcmd("update ship_info set confirm ='Yes' where order_no='" & lorder.Text & "'")
        主界面.lfydrefresh.Text = "Y"
        Me.Dispose()
    End Sub

  
End Class