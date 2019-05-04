Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_客户数据
    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()
        gbdata.Left = gbop.Left
        gbdata.Top = gbop.Bottom
        gbdata.Height = Me.Height - gbop.Height - 15
        gbdata.Width = gbop.Width
        dgdata.Left = Me.Left
        dgdata.Top = Me.Top + 60
        dgdata.Width = gbdata.Width
        dgdata.Height = gbdata.Height - 45
    End Sub
    Public Sub gbop_initial()
        tcustomer.Text = ""
        taddress.Text = ""
        ttel.Text = ""
        db.sel("select customer as 客户,customer_address as 地址,tel as 电话 from customer_info order by id", dgtemp)
        db.dgadd(dgtemp, dgdata, 3)
        dgdata.Columns(0).ReadOnly = True
        If dgdata.RowCount > 0 Then
            bdel.Enabled = True
            bok.Enabled = True
        Else
            bdel.Enabled = False
            bok.Enabled = False
        End If
    End Sub
    Private Sub WMS_客户数据_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        dgdata.Columns.Add("0", "客户")
        dgdata.Columns.Add("1", "地址")
        dgdata.Columns.Add("2", "电话")
        db.dgsortdisable(dgdata)
        gbop_initial()
    End Sub

    Private Sub bcx_Click(sender As Object, e As EventArgs) Handles bcx.Click
        If MsgBox("确定新增信息？", MsgBoxStyle.YesNo, "新增确认") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If
        '检查是否有空数据
        If Trim(tcustomer.Text) = "" Or Trim(taddress.Text) = "" Or Trim(ttel.Text) = "" Then
            db.rsmsg("客户数据格式不正确", "Customer data format is incorrect")
            Exit Sub
        End If
        '检查工厂是否重复
        If dgdata.RowCount > 0 Then
            For i = 0 To dgdata.RowCount - 1
                If tcustomer.Text = dgdata.Rows(i).Cells(0).Value Then
                    db.rsmsg("客户名重复", "Duplicate customer name")
                    Exit Sub
                End If
            Next
        End If


        db.sqlcmd("insert into customer_info (customer,customer_address,tel) values ('" & tcustomer.Text & "','" & taddress.Text & "','" & ttel.Text & "')")
        gbop_initial()

        bdel.Enabled = True
        bok.Enabled = True
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        gbop_initial()
    End Sub

    Private Sub dgdata_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgdata.CellValueChanged
        Dim index As String = dgdata.CurrentCell.RowIndex
        dgdata.Rows(index).DefaultCellStyle.BackColor = Color.Yellow
    End Sub

    Private Sub bdel_Click(sender As Object, e As EventArgs) Handles bdel.Click
        Try
            Dim index As String = dgdata.CurrentCell.RowIndex
            dgdata.Rows(index).DefaultCellStyle.BackColor = Color.SandyBrown
            dgdata.ClearSelection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bok_Click(sender As Object, e As EventArgs) Handles bok.Click
        If MsgBox("确定修改信息？", MsgBoxStyle.YesNo, "修改确认") = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If
        For i = 0 To dgdata.RowCount - 1
            '黄底修改，红底删除，蓝底新增
            If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                db.sqlcmd("update customer_info set customer_address = '" & dgdata.Rows(i).Cells(1).Value & "',tel = '" & dgdata.Rows(i).Cells(2).Value & "' where customer ='" & dgdata.Rows(i).Cells(0).Value & "' ")
                dgdata.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen

            End If
            If dgdata.Rows(i).DefaultCellStyle.BackColor = Color.SandyBrown Then
                db.sqlcmd("delete from customer_info where customer = '" & dgdata.Rows(i).Cells(0).Value & "'")

            End If
        Next
        gbop_initial()
    End Sub

End Class
