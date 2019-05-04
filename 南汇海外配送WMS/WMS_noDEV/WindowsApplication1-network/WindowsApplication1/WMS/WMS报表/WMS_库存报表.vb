Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class WMS_库存报表
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
    Private Sub WMS_库存报表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()
        db.sel("select area_no from bin_info group by area_no", dgtemp)
        db.comboboxaddin(dgtemp, cbkq)
        cbkq.Items.Add("")
        'cbkq.SelectedItem = cbkq.Properties.Items(cbkq.Properties.Items.Count - 1)

        '填充cbpartno
        db.sel("select part_no,part_desc from part_info order by id", dgtemp)
        If dgtemp.RowCount > 0 Then
            cbpartno.Items.Clear()
            cbpartno.Items.Add("")
            For i = 0 To dgtemp.RowCount - 1
                cbpartno.Items.Add(dgtemp.Rows(i).Cells(0).Value & "/" & dgtemp.Rows(i).Cells(1).Value)
            Next
        End If
    End Sub

    Private Sub cbkq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkq.SelectedIndexChanged, cbkw.SelectedIndexChanged
        If cbkq.Text = "" Then
            db.sel("select bin_no from bin_info order by area_no", dgtemp)
            db.comboboxaddin(dgtemp, cbkw)
            cbkw.Items.Add("")
        Else
            db.sel("select bin_no from bin_info where area_no ='" & cbkq.Text & "' order by id", dgtemp)
            db.comboboxaddin(dgtemp, cbkw)
            cbkw.Items.Add("")
        End If
    End Sub

    Private Sub tsearch_EditValueChanged(sender As Object, e As EventArgs) Handles tsearch.TextChanged
        db.sel("select part_no as 零件号,part_desc as 名称 from part_info where part_no like '%" & tsearch.Text & "%' or part_desc like '%" & tsearch.Text & "%'", dgpart)
        If tsearch.Text = "" Then
            dgpart.Visible = False
        Else
            dgpart.Visible = True
        End If
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
    Private Sub cbpartno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpartno.SelectedIndexChanged
        Dim partno(5) As String
        partno = cbpartno.Text.Split("/")
        cbpartno.Text = partno(0)
    End Sub

    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        If cbpartno.Text = "" Or cbkq.Text = "" Or cbkw.Text = "" Then
            If MsgBox("查询条件包含无条件查询，查询速度可能较慢，是否继续？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        End If
        db.sel("select barcode as 条码,part_no as 物料号,part_desc as 名称,area_no as 库区,bin_no as 库位,inner_qty as 内部数量 from current_stock " _
               & "where part_no like '%" & cbpartno.Text & "%' and area_no like '%" & cbkq.Text & "%' and bin_no like '%" & cbkw.Text & "%'", dgdetail)
        db.sel("select part_no as 物料号,bin_no as 库位,count(barcode) as 箱数,sum(inner_qty) as 总数量 from current_stock " _
       & "where part_no like '%" & cbpartno.Text & "%' and area_no like '%" & cbkq.Text & "%' and bin_no like '%" & cbkw.Text & "%' group by part_no,bin_no", dgsum)

    End Sub

 
    Private Sub cbkw_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
