Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Imports System.Threading

Public Class barcode
    Dim db As DBconfig = New DBconfig
    Public order As WMS_国内订单 = New WMS_国内订单
    Public Sub loadsize()
        'With gborder
        '    .Left = Me.Left
        '    .Top = gbop.Bottom
        '    .Width = (Me.Width - 10) / 4
        '    .Height = Me.Height - 15 - gbop.Height
        'End With
        With gbbarcode
            .Left = gborder.Right + 10
            .Top = gborder.Top
            .Width = Me.Width - gborder.Width - 20
            .Height = Me.Height - 10
        End With
        With Panel4
            .Left = Me.Left
            .Top = Panel3.Bottom
            .Width = Panel3.Width
            .Height = Me.Height - Panel3.Height - 15
        End With
        'With dgorder
        '    .Left = Me.Left
        '    .Top = Me.Top + 60
        '    .Height = gborder.Height - 75
        '    .Width = gborder.Width
        'End With
        'With dgbarcode
        '    .Left = Me.Left
        '    .Top = Me.Top + 60
        '    .Height = gbbarcode.Height - 75
        '    .Width = gbbarcode.Width
        'End With
        'With bprint
        '    .Left = Me.Left
        'End With
    End Sub
   
    Public Sub dgcolor(ByVal b As DataGridView)
        Try
            For i = 0 To b.RowCount - 1
                If b.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.LightGray = False Then
                    b.Rows(i + 1).DefaultCellStyle.BackColor = Drawing.Color.LightGray
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub dgorder_refresh()
     
        db.sel("select order_no,status from order_info where status < 3 group by order_no order by create_datetime desc", dgtemp)
        db.dgadd(dgtemp, dgorder, 2)
        If dgorder.RowCount > 0 Then
            For i = 0 To dgorder.RowCount - 1
                If dgorder.Rows(i).Cells(1).Value = 1 Then
                    dgorder.Rows(i).Cells(1).Value = "待收货"
                ElseIf dgorder.Rows(i).Cells(1).Value = 2 Then
                    dgorder.Rows(i).Cells(1).Value = "收货中"
                End If
            Next
        End If
    End Sub
    Private Sub barcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsize()
        dgorder.Columns.Add("0", "送货单号")
        dgorder.Columns.Add("1", "状态")
        db.dgsortdisable(dgorder)
        dgbarcode.Columns.Add("0", "条码")
        dgbarcode.Columns.Add("1", "零件号")
        dgbarcode.Columns.Add("2", "名称")
        dgbarcode.Columns.Add("3", "数量")
        dgbarcode.Columns.Add("4", "采购单号")
        dgbarcode.Columns.Add("5", "供应商")
        db.dgsortdisable(dgbarcode)

        dgorder_refresh()
        'db.sel("select order_no from order_info where status < 2 group by order_no order by id desc", dgtemp)
        dgorder.ContextMenuStrip = ContextMenuStrip1


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprint.Click

    
        '打印条码,不同供应商 分开打印
        For k = 0 To listtemp.Items.Count - 1
            'ProgressBar1.Visible = True
            ProgressBar1.Value = 50

            Thread.Sleep(2000)
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", "", False)
            Dim arrivetime As String = 0
            db.sel("select arrivedate_plan from order_info where order_no ='" & dgbarcode.Rows(0).Cells(4).Value & "' ", dgtemp)
            arrivetime = dgtemp.Rows(0).Cells(0).Value
            '   db.sel("select barcode,part_no,part_desc,order_no,inner_qty,supplier from barcode_info where order_no = '" & dgdfb.Rows(0).Cells(1).Value & "' and supplier ='" & listtemp.Items(k) & "'", dgtemp)
            For i = 0 To dgbarcode.RowCount - 1
                Try
                    If dgbarcode.Rows(i).Cells(5).Value = listtemp.Items(k) Then
                        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.txt", dgbarcode.Rows(i).Cells(0).Value & "," & dgbarcode.Rows(i).Cells(1).Value & "," & dgbarcode.Rows(i).Cells(2).Value & "," & dgbarcode.Rows(i).Cells(4).Value & "," & dgbarcode.Rows(i).Cells(3).Value & "," & dgbarcode.Rows(i).Cells(5).Value & "," & arrivetime & "," & i + 1 & "," & dgbarcode.RowCount & "," & Format(Now, "yyyy-MM-dd HH:mm:ss") & vbCrLf, True)

                    End If
                Catch ex As Exception

                End Try
            Next

            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\PartBar.CMD", Application.StartupPath & "\BAR\bartend.exe /F=" & Application.StartupPath & "\PartBar.BTW" & " /p /x", False, System.Text.Encoding.Default)
            If My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\PartBar.txt").Contains(",") = True Then
                Shell("cmd.exe /C " & Application.StartupPath & "\PartBar.cmd", AppWinStyle.Hide, False)
            End If
            If k = listtemp.Items.Count - 1 Then
            Else
                Thread.Sleep(5000)
                MsgBox("请等待打印完成后，再点击进行下一张打印")
            End If

        Next
        ProgressBar1.Value = 100
       


    End Sub
  

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        db.sel("select barcode as 零件条码,part_no as 零件号,part_desc as 零件描述,qty_plan as 数量,order_no as 订单号,create_datetime as 创建时间 from barcode_info where status =0 and (part_no like '" & TextBox1.Text & "%' or order_no like '" & TextBox1.Text & "%')order by id", dgbarcode)
    End Sub

 
  
    'Private Sub cborder_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    db.sel("select barcode as 零件条码,part_no as 零件号,part_desc as 零件描述,qty_plan as 数量,order_no as 订单号,create_datetime as 创建时间 from barcode_info where order_no ='" & cborder.Text & "' order by id", dgbarcode)
    'End Sub

    Private Sub dgorder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgorder.CellClick

        Dim index As String = dgorder.CurrentCell.RowIndex
        db.sel("select barcode as 条码,part_no as 零件号,part_desc as 零件描述,inner_qty as 数量,order_no as 采购单号,supplier as 供应商 from barcode_info where order_no ='" & dgorder.Rows(index).Cells(0).Value & "' order by id", dgtemp)
        db.dgadd(dgtemp, dgbarcode, 6)
        bprint.Visible = True


        '不同供应商分类,将dgdfb里的供应商种类填入listtemp listbox
        listtemp.Items.Clear()

        If dgtemp.RowCount > 1 Then
            listtemp.Items.Add(dgtemp.Rows(0).Cells(5).Value)
            For i = 1 To dgtemp.RowCount - 1

                For j = 0 To listtemp.Items.Count - 1
                    If dgtemp.Rows(i).Cells(5).Value = listtemp.Items(j) Then
                        Exit For
                    Else

                    End If
                    If j = listtemp.Items.Count - 1 Then
                        listtemp.Items.Add(dgtemp.Rows(i).Cells(5).Value)
                    End If
                Next
          
            Next
        Else
            listtemp.Items.Add(dgtemp.Rows(0).Cells(5).Value)
        End If
    End Sub

    Private Sub 关闭ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关闭ToolStripMenuItem.Click
        Try
            Dim index As String = dgorder.CurrentCell.RowIndex
            If MsgBox("确认关闭选中订单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
            db.sqlcmd("update order_info set status = 3 where order_no ='" & dgorder.Rows(index).Cells(0).Value & "'")
            dgorder_refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click
        dgorder_refresh()
    End Sub

    Private Sub bcx_Click(sender As Object, e As EventArgs) Handles bcx.Click

        If cbkcd.Text = "待收货" Then
            db.sel("select order_no,status from order_info where status =1 group by order_no order by create_datetime desc", dgtemp)
        Else
            db.sel("select order_no,status from order_info where status =2 group by order_no order by create_datetime desc", dgtemp)

        End If
        db.dgadd(dgtemp, dgorder, 2)
        If dgorder.RowCount > 0 Then
            For i = 0 To dgorder.RowCount - 1
                If dgorder.Rows(i).Cells(1).Value = 1 Then
                    dgorder.Rows(i).Cells(1).Value = "待收货"
                ElseIf dgorder.Rows(i).Cells(1).Value = 2 Then
                    dgorder.Rows(i).Cells(1).Value = "收货中"
                End If
            Next
        End If
    End Sub

    Private Sub cbkcd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkcd.SelectedIndexChanged
        bcx_Click(1, e)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
