Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports Utility
Public Class 主界面
    Dim db As DBconfig = New DBconfig
    Dim mysqllj As String
    Dim a As String = 0
    Dim uc As UserControl = New UserControl
    Dim uidright(10) As String
   
    Public Sub dgcolor(ByVal b As DataGridView)
        Try
            For i = 0 To b.RowCount - 1
                If b.Rows(i).DefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke = False Then
                    b.Rows(i + 1).DefaultCellStyle.BackColor = Drawing.Color.WhiteSmoke
                End If
            Next
        Catch ex As Exception

        End Try


    End Sub

    Public Sub loadsize()
        '语言选择
        If lan.Text = "中文" Then
            label_cn()
        ElseIf lan.Text = "English" Then
            label_en()
        Else
            MsgBox("语言错误，默认中文")
            label_cn()
        End If


        pleftlogo.Left = Panelleft.Left
        pleftlogo.Top = paneltop.Bottom
        Panelleft.Top = pleftlogo.Bottom
        Panelleft.Height = Me.Height - paneltop.Height - pleftlogo.Height
        TabControl1.Left = Panelleft.Right + 5
        TabControl1.Top = paneltop.Bottom + 10
        TabControl1.Width = Me.Width - Panelleft.Width - 25
        TabControl1.Height = Me.Height - paneltop.Height - 15
        picdata.Left = Panelleft.Right
        'picdata.Top = Me.Top + 10
        picorder.Left = picdata.Right
        picorder.Top = picdata.Top
        picorder.Width = picdata.Width
        picmes.Left = picorder.Right
        picmes.Top = picdata.Top
        picmes.Width = picdata.Width
        picreport.Left = picmes.Right
        picreport.Top = picdata.Top
        picreport.Width = picdata.Width
        picgworder.Left = picreport.Right
        picgworder.Top = picdata.Top
        picgworder.Width = picdata.Width

        bquit.Top = Me.Top + 15
        bquit.Left = Me.Right - bquit.Width - 15
        bmin.Top = bquit.Bottom
        bmin.Left = Me.Right - bmin.Width - 15

        pback.Left = Me.Left + 15
        pback.Top = Me.Top + 10
        pback.Width = TabPage1.Width - 30
        pback.Height = TabPage1.Height - 10

        lzsj.Left = picdata.Left + (picdata.Width - lzsj.Width) / 2
        lzsj.Top = picdata.Bottom - lzsj.Height - 5

        lgdgl.Left = picorder.Left + (picorder.Width - lgdgl.Width) / 2
        lgdgl.Top = picorder.Bottom - lgdgl.Height - 5
        lxccz.Left = picmes.Left + (picmes.Width - lxccz.Width) / 2
        lxccz.Top = picmes.Bottom - lxccz.Height - 5
        lbb.Left = picreport.Left + (picreport.Width - lbb.Width) / 2
        lbb.Top = picreport.Bottom - lbb.Height - 5
        ldd.Left = picgworder.Left + (picgworder.Width - ldd.Width) / 2
        ldd.Top = picgworder.Bottom - ldd.Height - 5



    End Sub

    Public Sub dgreadonly(ByVal b As DataGridView, ByVal d As Integer)
        If b.RowCount > 0 Then
            For i = 0 To b.RowCount - 1
                b.Rows(i).Cells(d).ReadOnly = True
            Next
        End If

    End Sub
    Public Sub functionbutton(ByVal a As String, ByVal b As UserControl)
        For Each con1 As Control In TabControl1.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.TabPage") Then
                If con1.Text = a Then
                    TabControl1.SelectedTab = con1
                    Exit Sub
                End If
            End If
        Next
        Dim tab As TabPage = New TabPage
        Dim o1 As UserControl = New UserControl
        o1 = b
        o1.Size = TabPage1.Size
        TabControl1.TabPages.Add(tab)
        o1.Parent = tab
        tab.Text = a
        buttonlabel.Text = a

        TabControl1.SelectedTab = tab
        tab.BorderStyle = BorderStyle.Fixed3D
        tab.BackColor = Color.White
        o1.BringToFront()
    End Sub
    Public Const HTCAPTION = 2
    Dim barray(10) As Button
    Public Sub userright()
        db.sel("select master_data_mes,order_plan,mes_op,report_op,order_create from user_info where uid ='" & uid.Text & "'", dgright)
        If dgright.RowCount > 0 Then
            uidright(0) = dgright.Rows(0).Cells(0).Value 'MES主数据
            uidright(1) = dgright.Rows(0).Cells(1).Value 'MES工单
            uidright(2) = dgright.Rows(0).Cells(2).Value ' MES操作
            uidright(3) = dgright.Rows(0).Cells(3).Value 'MES报表
            uidright(4) = dgright.Rows(0).Cells(4).Value '海外订单

            If uidright(0) = 0 Then
                ppicdata.Visible = False
            End If
        End If


    End Sub
    Public Sub WMSmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lversion.Text = Me.Text

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
                'con1.BackColor = Color.SkyBlue
            End If
        Next
        TabControl1.TabPages.Remove(TabPage2)
        TabPage1.Text = ""

        mainlabel.Text = ""
        'XtraTabPage1.BackColor = Color.White

        loadsize()
        If lan.Text = "English" Then
            bquit.Text = "End"
            bmin.Text = "Minimize"
            lyh.Text = "User:"
            lbelong.Text = "By:"
        Else
            bquit.Text = "关闭"
        End If

        db.sel("select version from version order by id desc limit 0,1", dgtemp)
        If Me.Text.Contains(dgtemp.Rows(0).Cells(0).Value) Then
        Else
            db.sel("select mark from version order by id desc limit 1", dgtemp)
            Dim a As String = 0
            If lan.Text = "English" Then
                a = "New Version has been published,Please update？" & vbCrLf & "Update content:" & vbCrLf & dgtemp.Rows(0).Cells(0).Value
            Else
                a = "有新版本发布，是否立即更新？" & vbCrLf & "更新内容:" & vbCrLf & dgtemp.Rows(0).Cells(0).Value
            End If
            If MsgBox(a, MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
                Process.Start(Application.StartupPath & "\update.exe")
                End
            Else

            End If
        End If

        userright()
        TabPage1.Text = "Welcome"
        pbuser.ContextMenuStrip = ContextMenuStrip1

        barray(0) = Button1
        barray(1) = Button2
        barray(2) = Button3
        barray(3) = Button4
        barray(4) = Button5
        barray(5) = Button6
        barray(6) = Button7
        barray(7) = Button8
        barray(8) = Button9
        barray(9) = Button10
        picdata_Click(1, e)
    End Sub
    Private Sub picorder_mouseon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picorder.MouseMove
        picorder.BackColor = Color.White

        ' picorder.Image = Global.WindowsApplication1.My.Resources.Resources.工单管理2
        '  picorder.SizeMode = PictureBoxSizeMode.Zoom
        If lan.Text = "English" Then
            mainlabel.Text = "Material Order"
        Else
            mainlabel.Text = "MES工单"
        End If
        lgdgl.BackColor = Color.White
        lgdgl.ForeColor = paneltop.BackColor
    End Sub
    Private Sub picorder_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picorder.MouseLeave
        picorder.BackColor = Color.Transparent
        ' picorder.Image = Global.WindowsApplication1.My.Resources.Resources.工单管理
        mainlabel.Text = ""
        lgdgl.ForeColor = Color.White
        lgdgl.BackColor = paneltop.BackColor
    End Sub
    Private Sub picdata_mouseon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdata.MouseMove
        picdata.BackColor = Color.White
        ' picdata.Image = Global.WindowsApplication1.My.Resources.Resources.主数据维护2

        If lan.Text = "English" Then
            mainlabel.Text = "Master data"
        Else
            mainlabel.Text = "主数据维护"
        End If
        lzsj.BackColor = Color.White
        lzsj.ForeColor = paneltop.BackColor
    End Sub
    Private Sub picdata_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdata.MouseLeave
        picdata.BackColor = Color.Transparent
        ' picdata.Image = Global.WindowsApplication1.My.Resources.Resources.主数据维护
        mainlabel.Text = ""
        lzsj.ForeColor = Color.White
        lzsj.BackColor = paneltop.BackColor
    End Sub
    Private Sub picwms_mouseon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picgworder.MouseMove
        picgworder.BackColor = Color.White
        ' picgworder.Image = Global.WindowsApplication1.My.Resources.Resources.物料管理2
        If lan.Text = "English" Then
            mainlabel.Text = "Material Operation"
        Else
            mainlabel.Text = "物料操作"
        End If

        ldd.BackColor = Color.White
        ldd.ForeColor = paneltop.BackColor
    End Sub
    Private Sub picwms_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picgworder.MouseLeave
        picgworder.BackColor = Color.Transparent
        ' picgworder.Image = Global.WindowsApplication1.My.Resources.Resources.物料管理
        mainlabel.Text = ""
        ldd.ForeColor = Color.White
        ldd.BackColor = paneltop.BackColor
    End Sub
    Private Sub picreport_mouseon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picreport.MouseMove
        picreport.BackColor = Color.White
        ' picreport.Image = Global.WindowsApplication1.My.Resources.Resources.报表_看板2
        If lan.Text = "English" Then
            mainlabel.Text = "Report"
        Else
            mainlabel.Text = "报表"
        End If
        lbb.BackColor = Color.White
        lbb.ForeColor = paneltop.BackColor
    End Sub
    Private Sub picreport_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picreport.MouseLeave
        picreport.BackColor = Color.Transparent
        ' picreport.Image = Global.WindowsApplication1.My.Resources.Resources.报表_看板
        mainlabel.Text = ""
        lbb.ForeColor = Color.White
        lbb.BackColor = paneltop.BackColor
    End Sub
    Private Sub picmes_mouseon(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmes.MouseMove
        picmes.BackColor = Color.White
        ' picmes.Image = Global.WindowsApplication1.My.Resources.Resources.现场验收操作2
        If lan.Text = "English" Then
            mainlabel.Text = "MES Operator"
        Else
            mainlabel.Text = "MES操作"
        End If
        lxccz.BackColor = Color.White
        lxccz.ForeColor = paneltop.BackColor
    End Sub
    Private Sub picmes_mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmes.MouseLeave
        picmes.BackColor = Color.Transparent
        ' picmes.Image = Global.WindowsApplication1.My.Resources.Resources.现场验收操作
        mainlabel.Text = ""
        lxccz.ForeColor = Color.White
        lxccz.BackColor = paneltop.BackColor
    End Sub

    Public Sub picorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picorder.Click
        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
            End If
        Next
        userright()
        If uidright(1) = 1 Then
            Button1.Visible = True
            Button1.Text = "海外订单审核"
            Button2.Visible = True
            Button2.Text = "国内采购订单"
            Button3.Visible = True
            Button3.Text = "物料条码管理"
            Button4.Visible = True
            Button4.Text = "退货单管理"
            Button5.Visible = True
            Button5.Text = "盘点任务"
            Button6.Visible = True
            Button6.Text = "盘点确认"
        End If


    End Sub
    Private Sub picdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picdata.Click

        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
            End If
        Next
        userright()
        If uidright(0) = 1 Then
            Button1.Visible = True
            Button1.Text = "零件数据"
            Button2.Visible = True
            Button2.Text = "库位数据"
            Button3.Visible = True
            Button3.Text = "工厂数据"
            Button4.Visible = True
            Button4.Text = "客户数据"
            Button6.Visible = True
            Button6.Text = "用户管理"
        End If

    End Sub
    Private Sub picoperator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picwmsorder.Click
        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
            End If
        Next
        Button1.Visible = True
        Button1.Text = "WMS订单管理"
        Button2.Visible = True
        Button2.Text = "条码打印"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If a = "WMS订单管理" Or a = "Purchase order" Then
            uc = New WMS订单
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "零件数据" Or a = "Part Config" Then
            uc = New WMS主数据
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "库位数据" Or a = "Part Config" Then
            uc = New WMS_库位
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "工厂数据" Or a = "Part Config" Then
            uc = New WMS_工厂数据
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "客户数据" Or a = "Part Config" Then
            uc = New WMS_客户数据
            functionbutton(a, uc)
            Exit Sub

        ElseIf a = "条码打印" Or a = "Barcode Print" Then
            uc = New barcode
            functionbutton(a, uc)
            Exit Sub

        ElseIf a = "库位信息维护" Or a = "Storage-location config" Then
            uc = New dataconfig
            functionbutton(a, uc)

        ElseIf a = "盘点任务" Then
            uc = New 盘点任务
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "库存报表" Then
            uc = New WMS_库存报表
            functionbutton(a, uc)
            Exit Sub

        ElseIf a = "用户管理" Or a = "User config" Then
            uc = New user
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "发运单管理" Then
            Dim o1 As WMS_发运任务 = New WMS_发运任务
            functionbutton(a, o1)
            Exit Sub
        ElseIf a = "订单下达" Or a = "Order" Then
            uc = New WMS_发运任务
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "退货单管理" Then
            uc = New WMS_退货任务
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "盘点确认" Then
            uc = New WMS_盘点确认
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "物料条码管理" Then
            uc = New barcode
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "事务报表" Then
            uc = New WMS_事务报表
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "海外订单审核" Then
            uc = New WMS_发运单审核
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "国内采购订单" Then
            uc = New WMS_国内订单
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "订单确认" Or a = "Order Confirm" Then
            uc = New WMS_订单确认
            functionbutton(a, uc)
            Exit Sub
        ElseIf a = "订单查看" Or a = "Order Report" Then
            uc = New WMS_订单查看
            functionbutton(a, uc)
            Exit Sub
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Button1.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = Button2.Text
        Button1_Click(1, e)
    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = Button3.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = Button4.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        a = Button5.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        a = Button7.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        a = Button6.Text
        Button1_Click(1, e)
    End Sub
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        登录old.Close()
    End Sub

    Private Sub picreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picreport.Click
        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
            End If
        Next
        userright()
        If uidright(3) = 1 Then
            Button1.Visible = True
            Button2.Visible = True
            Button1.Text = "事务报表"
            Button2.Text = "库存报表"
        End If



    End Sub

    Private Sub picmes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picmes.Click
        'For Each con1 As Control In Panelleft.Controls
        '    If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
        '        con1.Visible = False
        '    End If
        'Next
        'userright()
        'If uidright(2) = 1 Then
        '    db.sel("select station_name from station_info where status = 'enable' order by id", dgtemp)
        '    If dgtemp.RowCount > 0 Then
        '        For i = 0 To dgtemp.RowCount - 1
        '            barray(i).Visible = True
        '            barray(i).Text = dgtemp.Rows(i).Cells(0).Value
        '        Next
        '    End If
        'End If
        a = "WMS操作"
        uc = New WMS现场web
        functionbutton(a, uc)


    End Sub


    Private Sub XtraTabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.DoubleClick
        If TabControl1.TabPages.Count = 1 Then
        Else
            Me.TabControl1.SelectedTab.Dispose()
            'Me.XtraTabControl1.TabPages.Remove(Me.XtraTabControl1.SelectedTab)

        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        db.sqlcmd("update version set mark = '1.BOM更新\n2.看板更新\n3....' where version = '1.01'")
        db.sel("select mark from version where version = '1.01'", dgtemp)
        MsgBox(dgtemp.Rows(0).Cells(0).Value)
    End Sub

    Private Sub bquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bquit.Click
        If lhwddh.Text <> "N" Then
            db.sqlcmd("delete from ship_order where ship_no ='" & lhwddh.Text & "'")
        End If
        End
    End Sub

    Private Sub cblan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cblan.SelectedIndexChanged
        lan.Text = cblan.Text
        If lan.Text = "中文" Then
            If MsgBox("Confirm Language to Chinese？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        Else
            If MsgBox("是否更改系统语言为英文？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        End If
        If TabControl1.TabPages.Count > 0 Then
            If lan.Text = "English" Then
                If MsgBox("Need to close all window , please confirm？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                Else
                    Exit Sub
                End If
            Else
                If MsgBox("切换语言需要关闭现有窗口，请确认？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
                Else
                    Exit Sub
                End If
            End If
            For Each o1 As TabPage In TabControl1.TabPages
                If o1.Text = "Welcome" Then
                Else
                    Me.TabControl1.TabPages.Remove(o1)
                End If

            Next
        End If
        lan.Text = cblan.Text
        WMSmain_Load(1, e)
    End Sub



    Private Sub bmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub





    Private Sub 切换用户ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 切换用户ToolStripMenuItem.Click
        If MsgBox("是否切换账户，切换账户会关闭所有已开的窗口，请确认？", MsgBoxStyle.YesNo, "Message") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        Shell(Application.StartupPath & "\MES_taoci.exe", vbNormalFocus)
        End

    End Sub
    Dim movecolors As Color = Color.DarkSeaGreen
    Dim outcolors As Color = Color.FromArgb(74, 107, 90)
    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = movecolors
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = outcolors
    End Sub
    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = movecolors
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = outcolors
    End Sub
    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        Button3.BackColor = movecolors
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = outcolors
    End Sub
    Private Sub Button4_MouseMove(sender As Object, e As MouseEventArgs) Handles Button4.MouseMove
        Button4.BackColor = movecolors
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = outcolors
    End Sub
    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = movecolors
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = outcolors
    End Sub
    Private Sub Button6_MouseMove(sender As Object, e As MouseEventArgs) Handles Button6.MouseMove
        Button6.BackColor = movecolors
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = outcolors
    End Sub
    Private Sub Button7_MouseMove(sender As Object, e As MouseEventArgs) Handles Button7.MouseMove
        Button7.BackColor = movecolors
    End Sub
    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = outcolors
    End Sub
    Private Sub Button8_MouseMove(sender As Object, e As MouseEventArgs) Handles Button8.MouseMove
        Button1.BackColor = movecolors
    End Sub
    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.BackColor = outcolors
    End Sub
    Private Sub Button9_MouseMove(sender As Object, e As MouseEventArgs) Handles Button9.MouseMove
        Button9.BackColor = movecolors
    End Sub
    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Button9.BackColor = outcolors
    End Sub
    Private Sub lzsj_MouseMove(sender As Object, e As MouseEventArgs) Handles lzsj.MouseMove
        picdata_mouseon(1, e)
    End Sub

    Private Sub lgdgl_MouseMove(sender As Object, e As MouseEventArgs) Handles lgdgl.MouseMove
        picorder_mouseon(1, e)
    End Sub

    Private Sub lxccz_MouseMove(sender As Object, e As MouseEventArgs) Handles lxccz.MouseMove
        picmes_mouseon(1, e)
    End Sub

    Private Sub lbb_MouseMove(sender As Object, e As MouseEventArgs) Handles lbb.MouseMove
        picreport_mouseon(1, e)
    End Sub

    Private Sub lzsj_Click(sender As Object, e As EventArgs) Handles lzsj.Click
        picdata_Click(1, e)
    End Sub

    Private Sub lgdgl_Click(sender As Object, e As EventArgs) Handles lgdgl.Click
        picorder_Click(1, e)
    End Sub

    Private Sub lxccz_Click(sender As Object, e As EventArgs) Handles lxccz.Click
        picmes_Click(1, e)
    End Sub

    Private Sub lbb_Click(sender As Object, e As EventArgs) Handles lbb.Click
        picreport_Click(1, e)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("是否注销？", MsgBoxStyle.YesNo, "系统注销") = MsgBoxResult.Yes Then
        Else
            Exit Sub
        End If
        Process.Start(Application.StartupPath & "\RSWMS.exe")
        End

    End Sub

    Private Sub lwms_Click(sender As Object, e As EventArgs) Handles ldd.Click
        picwms_Click(1, e)
    End Sub

    Private Sub lwms_MouseMove(sender As Object, e As MouseEventArgs) Handles ldd.MouseMove
        picwms_mouseon(1, e)
    End Sub

    Private Sub lwms_MouseLeave(sender As Object, e As EventArgs) Handles ldd.MouseLeave
        picwms_mouseleave(1, e)
    End Sub

    Private Sub picwms_Click(sender As Object, e As EventArgs) Handles picgworder.Click
        For Each con1 As Control In Panelleft.Controls
            If con1.GetType.ToString.Equals("System.Windows.Forms.Button") Then
                con1.Visible = False
            End If
        Next
        userright()
        If uidright(4) = 1 Then
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            If lan.Text = "English" Then
                Button1.Text = "Order"
                Button2.Text = "Order Confirm"
                Button3.Text = "Order Report"
            Else
                Button1.Text = "订单下达"
                Button2.Text = "订单确认"
                Button3.Text = "订单查看"
            End If


        End If

    End Sub
    Private Sub XtraTabControl1_CloseButtonClick(sender As Object, e As EventArgs)
        If TabControl1.TabPages.Count = 1 Then
        Else
            Me.TabControl1.SelectedTab.Dispose()
            'Me.XtraTabControl1.TabPages.Remove(Me.XtraTabControl1.SelectedTab)

        End If
    End Sub

    Public Sub label_cn()
        ldd.Text = "海外订单"
    End Sub
    Public Sub label_en()
        ldd.Text = "Order"
    End Sub

   
   
End Class