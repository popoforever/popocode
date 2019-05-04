Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
    Public Class 盘点任务
    Dim db As DBconfig = New DBconfig
    Public Sub loadsize()
        With gbtask
            .Top = gbop.Bottom + 10
            .Left = Me.Left
            .Width = Me.Width / 2 - 2
            .Height = Me.Height - 25 - gbop.Height
        End With
        With gbdetail
            .Top = gbtask.Top
            .Left = gbtask.Right + 10
            .Width = gbtask.Width
            .Height = gbtask.Height
        End With
        With dgpandian
            .Top = Me.Top + 30
            .Left = Me.Left
            .Width = gbtask.Width
            .Height = gbtask.Height - 40
        End With
        With dgdetail
            .Top = Me.Top + 30
            .Left = Me.Left
            .Width = gbdetail.Width
            .Height = gbdetail.Height - 40
        End With

    End Sub
    Public Sub checkinitial()
        dgarea.Enabled = True
        blj.Enabled = True
        dgpart.Enabled = False
        dgpart2.Enabled = False
        bljqd.Enabled = False
        tsearch.Visible = False
        dgpart2.Rows.Clear()
        dgpart.DataSource = Nothing
        db.sel("select checklist_no as 盘点单号,create_datetime as 创建时间 from check_info where status < 2 group by checklist_no,create_datetime order by create_datetime desc", dgpandian)
        If dgpandian.RowCount > 0 Then
            db.sel("select checklist_no as 盘点单号,part_no as 盘点零件号,bin_before as 盘点库位号,create_datetime as 创建时间 from check_info where checklist_no ='" & dgpandian.Rows(0).Cells(0).Value & "' order by id", dgdetail)

        End If
     
      
    End Sub
        Private Sub 盘点任务_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
        loadsize()

        db.sel("select area_no as 库区 from bin_info group by area_no", dgarea)

        If dgarea.RowCount = 0 Then
            MsgBox("库区主数据缺失，请检查")
            Exit Sub
        End If
        '  Dim checkboxColumn As New DataGridViewCheckBoxColumn
        dgpart.Columns.Add("1", "库位")
        'dgarea.Columns.Add(checkboxColumn)

        dgarea.BackgroundColor = Color.SkyBlue
        dgarea.Columns(0).ReadOnly = True
        checkinitial()
        'For i = 0 To dgarea.RowCount - 1
        '    dgarea.Rows(i).Cells(1).Value = 1
        'Next
        dgpart2.Columns.Add("1", "零件号")
        dgpart2.Columns.Add("2", "零件描述")

        dgpandian.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkw.Click
        blj.Visible = False

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0

        For i = 0 To dgarea.RowCount - 1
            If dgarea.Rows(i).Cells(0).Value = True Then
                db.sel("select bin_no from bin_info where area_no = '" & dgarea.Rows(i).Cells(1).Value & "'", dgtemp)
                For j = 0 To dgtemp.RowCount - 1
                    Try
                        For k = 0 To dgpart.RowCount - 1
                            If dgpart.Rows(k).Cells(0).Value = dgtemp.Rows(j).Cells(0).Value Then
                                GoTo 1
                            End If
                        Next
                    Catch ex As Exception

                    End Try
                    dgpart.Rows.Add(dgtemp.Rows(j).Cells(0).Value)
1:
                Next

            End If
        Next
        If dgpart.ColumnCount > 1 Then
        Else
            Dim checkboxColumn As New DataGridViewCheckBoxColumn
            dgpart.Columns.Add(checkboxColumn)
        End If
        Try
            For i = 0 To dgpart.RowCount - 1
                dgpart.Rows(i).Cells(1).Value = True
            Next
        Catch ex As Exception

        End Try
        dgpart.Visible = True
        dgpart.Columns(0).ReadOnly = True
        bkw.BackColor = Color.WhiteSmoke
        bkw.Visible = False
        dgpart.BackgroundColor = Color.SkyBlue
        bkwqd.BackColor = Color.SkyBlue
        bkwqd.Visible = True
        dgarea.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bkwqd.Click
        If MsgBox("是否生成盘点单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        For i = 0 To dgpart.RowCount - 1
            If dgpart.Rows(i).Cells(1).Value = True Then
                GoTo 1
            End If
        Next
        MsgBox("请至少选择一个盘点库位")
        Exit Sub
1:
        Dim seq As String = 0
        db.sel("select checklist_no from check_info where date(create_datetime) = curdate() order by id desc", dgtemp)
        If dgtemp.RowCount = 0 Then
            seq = "0001"
        Else
            seq = Format(dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) + 1, "0000")
        End If
        Dim pd_no As String = "PD" & Format(Now.Date, "yyyyMMdd") & seq  '盘点单号 PD+日期+流水号

        For i = 0 To dgpart.RowCount - 1
            If dgpart.Rows(i).Cells(1).Value = True Then
                db.sqlcmd("insert into check_info (checklist_no,bin_before,create_datetime) values ('" & pd_no & "','" & dgpart.Rows(i).Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')")

            End If
        Next
        MsgBox("盘点单" & pd_no & "生成完毕")

        db.sel("select checklist_no as 盘点单号,create_datetime as 创建时间 from check_info where status <2 group by checklist_no,create_datetime order by create_datetime", dgpandian)
        db.sel("select checklist_no as 盘点单号,part_no as 盘点零件号,bin_before as 盘点库位号,create_datetime as 创建时间 from check_info where checklist_no ='" & dgpandian.Rows(0).Cells(0).Value & "' order by id", dgdetail)
        bkwqd.BackColor = Color.WhiteSmoke
        bkwqd.Visible = False
        dgpart.BackgroundColor = Color.SkyBlue
        For i = 0 To dgarea.RowCount - 1
            dgarea.Rows(i).Cells(0).Value = False
        Next
        dgpart.Rows.Clear()
        dgpart.Visible = False
        tsearch.Visible = False
        dgarea.Enabled = True
    End Sub

    Private Sub dgpandian_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpandian.CellClick
        Dim index As String = dgpandian.CurrentRow.Index
        db.sel("select checklist_no as 盘点单号,part_no as 盘点零件号,bin_before as 盘点库位号,create_datetime as 创建时间 from check_info where checklist_no ='" & dgpandian.Rows(index).Cells(0).Value & "' order by id", dgdetail)
    End Sub

    Private Sub dgarea_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgarea.CellContentClick
        dgarea.BackgroundColor = Color.WhiteSmoke
        'bkw.Visible = True
        'bkw.BackColor = Color.SkyBlue
        blj.Enabled = True
        blj.BackColor = Color.SkyBlue
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blj.Click
        bkw.Visible = False
        dgpart.Columns.Clear()
        db.sel("select part_no as 盘点零件号,part_desc as 零件描述 from part_info order by id", dgpart)
        dgpart.Columns(0).ReadOnly = True
        dgpart.Columns(1).ReadOnly = True
        dgpart.Enabled = True
        dgpart2.Enabled = True
        tsearch.Visible = True
        blj.BackColor = Color.WhiteSmoke
        blj.Enabled = False
        bljqd.Enabled = True
        dgarea.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsearch.TextChanged
        db.sel("select part_no as 盘点零件号,part_desc as 零件描述 from part_info where part_no like '%" & tsearch.Text & "%'", dgpart)
    End Sub

    Private Sub dgpart_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpart.CellDoubleClick
        Dim index As String = dgpart.CurrentRow.Index

        Dim i As Integer = 0
        If dgpart2.RowCount > 0 Then  '避免重复添加零件号到盘点列表
            For i = 0 To dgpart2.RowCount - 1
                If dgpart.Rows(index).Cells(0).Value = dgpart2.Rows(i).Cells(0).Value Then
                    GoTo 1
                End If
            Next

            dgpart2.Rows.Add(dgpart.Rows(index).Cells(0).Value, dgpart.Rows(index).Cells(1).Value)
1:
        Else
            dgpart2.Rows.Add(dgpart.Rows(index).Cells(0).Value, dgpart.Rows(index).Cells(1).Value)
        End If



    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bljqd.Click
        If MsgBox("是否生成盘点单？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If dgpart2.RowCount = 0 Then
            MsgBox("请至少选择一个盘点零件")
            Exit Sub
        End If

        '检查未关闭的盘点任务中，是否有本次的零件，如果有，则提示报错，取消本次指令
        db.sel("select part_no,checklist_no from check_info where status < 3 order by create_datetime desc", dgtemp)
        If dgtemp.RowCount > 0 Then
            For i = 0 To dgtemp.RowCount - 1
                For j = 0 To dgpart2.RowCount - 1
                    If dgpart2.Rows(j).Cells(0).Value = dgtemp.Rows(i).Cells(0).Value Then
                        db.rsmsg(dgpart2.Rows(j).Cells(0).Value & ",该零件有未完成的盘点单", dgpart2.Rows(j).Cells(0).Value & "The part has an uncompleted order")
                        checkinitial()
                        Exit Sub
                    End If
                Next
            Next
        End If
    

        Dim seq As String = 0
        db.sel("select checklist_no from check_info where date(create_datetime) = curdate() order by id desc", dgtemp)
        If dgtemp.RowCount = 0 Then
            seq = "0001"
        Else
            seq = Format(dgtemp.Rows(0).Cells(0).Value.remove(0, dgtemp.Rows(0).Cells(0).Value.length - 4) + 1, "0000")
        End If
        Dim pd_no As String = "PD" & Format(Now.Date, "yyyyMMdd") & seq  '盘点单号 PD+日期+流水号

        For i = 0 To dgpart2.RowCount - 1
            db.sqlcmd("insert into check_info (checklist_no,part_no,part_desc,create_datetime,status) values ('" & pd_no & "','" & dgpart2.Rows(i).Cells(0).Value & "','" & dgpart2.Rows(i).Cells(1).Value & "',now(),'1')")
        Next

        '冻结零件，barcode_info表中的相关零件的if_freeze = 1
        For i = 0 To dgpart2.RowCount - 1
            db.sqlcmd("update barcode_info set if_freeze =1 where part_no = '" & dgpart2.Rows(i).Cells(0).Value & "' and (status > 1 and status < 5)")
        Next

        MsgBox("盘点单" & pd_no & "生成完毕,盘点单中的零件已冻结")

        'db.sel("select checklist_no as 盘点单号,create_datetime as 创建时间 from check_info where status <2 group by checklist_no,create_datetime order by id", dgpandian)
        'db.sel("select checklist_no as 盘点单号,part_no as 盘点零件号,bin_before as 盘点库位号,create_datetime as 创建时间 from check_info where checklist_no ='" & dgpandian.Rows(0).Cells(0).Value & "' order by id", dgdetail)
        bkwqd.BackColor = Color.WhiteSmoke
        bkwqd.Visible = False
        'For i = 0 To dgarea.RowCount - 1
        '    dgarea.Rows(i).Cells(0).Value = False
        'Next
        checkinitial()
    End Sub

    Private Sub 取消盘点单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 取消盘点单ToolStripMenuItem.Click
        '取消盘点单，check_info里盘点单的状态status= 3, barcode_info中，对应的零件if_freeze字段=0

        ' Try
        Dim index As String = dgpandian.CurrentCell.RowIndex
        db.sqlcmd("update check_info set status =3 where checklist_no ='" & dgpandian.Rows(index).Cells(0).Value & "'")
        db.sel("select part_no from check_info where checklist_no='" & dgpandian.Rows(index).Cells(0).Value & "'", dgtemp)
        If dgtemp.RowCount > 0 Then
            For i = 0 To dgtemp.RowCount - 1
                db.sqlcmd("update barcode_info set if_freeze = 0 where part_no ='" & dgtemp.Rows(i).Cells(0).Value & "'")
            Next
        End If
        checkinitial()
        dgdetail.DataSource = Nothing
        'Catch ex As Exception

        ' End Try
    End Sub
End Class

