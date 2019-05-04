Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Configuration
Imports Utility
Public Class user
    Dim db As DBconfig = New DBconfig
  
    Dim keyparttype() As String
    Public Sub loadsize()
        With gbdata
            .Left = Me.Left + 5
            .Top = pbutton.Bottom + 10
            .Width = Me.Width - 10
            .Height = Me.Height - 25 - gbop.Height - pbutton.Height
        End With
        'With gbright
        '    .Left = gbdata.Right + 10
        '    .Top = gbdata.Top
        '    .Width = gbdata.Width / 3 - 10
        '    .Height = gbdata.Height
        'End With
        With dguser
            .Left = Me.Left
            .Top = Me.Top + 30
            .Width = gbdata.Width
            .Height = gbdata.Height - 45
        End With
        With dgright
            .Left = Me.Left
            .Top = Me.Top + 30
            .Width = gbright.Width
            .Height = dgright.Height
        End With
    End Sub

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadsize()
        db.sel("select customer from customer_info order by id", dgtemp)
        db.comboboxaddin(dgtemp, cbcustum)
        dgright.Columns.Add("1", "权限")
        Dim checkboxColumn As New DataGridViewCheckBoxColumn
        dgright.Columns.Add(checkboxColumn)
        bright.Enabled = False
        db.sel("select master_data_wms,master_data_mes,order_plan,check_plan,recieve_op,putin_op,move_op,lingliao_op,check_op,report_op,mes_op from user_info", dgtemp)
        db.sel("select uid as 账号,user_name as 用户,factory as 工厂,email as 邮箱地址,tel as 电话 from user_info", dguser)

        db.dgsortdisable(dguser)
        db.dgsortdisable(dgright)

    End Sub

    Private Sub dguser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.CellClick
      

    End Sub

    Private Sub dgright_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgright.CellValueChanged
        Try
            dgright.Rows(0).Selected = False
            Dim index As String = dgright.CurrentRow.Index
            Dim a As Integer = dgright.Rows(index).Cells(1).Value
            dgright.Rows(index).DefaultCellStyle.BackColor = Color.SandyBrown
        Catch ex As Exception

        End Try
     

    End Sub


    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bcx_Click(sender As Object, e As EventArgs) Handles badd.Click
        If MsgBox("是否确认新增账号？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        If Trim(tuid.Text) = "" Or Trim(cbcustum.Text) = "" Or Trim(temail.Text) = "" Or Trim(ttel.Text) = "" Then
            MsgBox("账号信息不完整，请补充")
            tuid.Focus()
            tuid.SelectAll()
            Exit Sub
        Else
            For i = 0 To dguser.RowCount - 1
                If dguser.Rows(i).Cells(0).Value = tuid.Text Then
                    MsgBox("账号已存在，请不要重复注册")
                    tuid.Focus()
                    tuid.SelectAll()
                    Exit Sub
                End If
            Next
            db.sqlcmd("insert into user_info (uid,pwd,user_name,email,tel,status,factory) values ('" & tuid.Text & "','123456','" & cbcustum.Text & "','" & temail.Text & "','" & ttel.Text & "',1,'" & cbcustum.Text & "')")
            MsgBox("账号" & tuid.Text & "添加成功")
            db.sel("select uid as 账号,user_name as 用户,email as邮箱地址,tel as 电话 from user_info", dguser)
        End If

    End Sub

    Private Sub bright_Click(sender As Object, e As EventArgs) Handles bright.Click
        If MsgBox("是否为" & ltemp.Text & "保存权限？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        db.sel("select master_data_mes,order_plan ,mes_op,report_op,order_create  from user_info", dgtemp)
        For i = 0 To dgright.RowCount - 1
            'MsgBox(dgtemp.Columns(i).Name & "," & dgright.Rows(i).Cells(1).Value)
            If dgright.Rows(i).Cells(1).Value = True Then
                ' MsgBox(dgtemp.Columns(i).Name)
                db.sqlcmd("update user_info set " & dgtemp.Columns(i).Name & " = 1 where uid = '" & ltemp.Text & "'")
            Else
                ' MsgBox(dgtemp.Columns(i).Name)
                db.sqlcmd("update user_info set " & dgtemp.Columns(i).Name & " = 0 where uid = '" & ltemp.Text & "'")
            End If
        Next
        For i = 0 To dgright.RowCount - 1
            dgright.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next
        MsgBox(ltemp.Text & "权限保存完毕")
        db.sel("select master_data_wms,master_data_mes,order_plan,check_plan,recieve_op,putin_op,move_op,lingliao_op,check_op,report_op,mes_op from user_info where uid ='" & 主界面.uid.Text & "'", 主界面.dgtemp)
        pright.Visible = False
    End Sub

    Private Sub ttel_TextChanged(sender As Object, e As EventArgs) Handles ttel.TextChanged

    End Sub

    Private Sub ltel_Click(sender As Object, e As EventArgs) Handles ltel.Click

    End Sub

    Private Sub dguser_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dguser.CellDoubleClick
        Dim index As String = dguser.CurrentRow.Index
        dgright.Rows.Clear()
        'db.sel("select master_data_wms as WMS_Maindata,master_data_mes as MES_Maindata,order_plan as Purchase_order,check_plan as Check_inventory,recieve_op as Receive_goods,putin_op as Put_in_goods,move_op as Move_goods,lingliao_op as Material_to_products,check_op as Check_operator,report_op as Reports,mes_op as MES_operator from user_info where uid='" & dguser.Rows(index).Cells(0).Value & "'", dgtemp)

        'db.sel("select master_data_wms as WMS主数据,master_data_mes as MES主数据,order_plan as 订单管理,check_plan as 盘点计划,recieve_op as 收货操作,putin_op as 入库操作,move_op as 移库操作,lingliao_op as 领料操作,check_op as 盘点操作,report_op as 报表,mes_op as MES操作 from user_info where uid='" & dguser.Rows(index).Cells(0).Value & "'", dgtemp)
        db.sel("select master_data_mes as 主数据,order_plan as 计划管理,mes_op as 现场操作,report_op as 报表,order_create as 海外订单 from user_info where uid='" & dguser.Rows(index).Cells(0).Value & "'", dgtemp)

        For i = 0 To dgtemp.ColumnCount - 1
            dgright.Rows.Add(dgtemp.Columns(i).Name)
        Next
        For i = 0 To dgtemp.ColumnCount - 1
            If dgtemp.Rows(0).Cells(i).Value = 1 Then
                dgright.Rows(i).Cells(1).Value = True
            End If
        Next
        dgright.Rows(0).DefaultCellStyle.BackColor = Color.White
        ltemp.Text = dguser.Rows(index).Cells(0).Value

        bright.Enabled = True
        pright.Left = Me.Left + (Me.Width - pright.Width) / 2
        pright.Top = Me.Top + (Me.Height - pright.Height) / 2
        pright.Visible = True
        pright.BringToFront()
    End Sub


End Class
