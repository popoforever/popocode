Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Configuration
Imports Utility
Public Class DBconfig
    Dim mysqllj As String = DESEncrypt.DesDecrypt(ConfigurationManager.AppSettings("mysqllj"))
    Dim sqlconn As MySqlConnection = New MySqlConnection
    Public Sub sel(ByVal a As String, ByVal b As DataGridView)
        ' Try
        sqlconn.ConnectionString = mysqllj
        Dim sqldpt1 As MySqlDataAdapter = New MySqlDataAdapter(a, sqlconn)
        Dim sqldataset1 As DataSet = New DataSet
        sqldataset1.Clear()
        sqlconn.Open()
        sqldpt1.Fill(sqldataset1, "0")
        b.DataSource = sqldataset1.Tables(0)
        sqlconn.Close()
        'Catch ex As Exception

        'End Try

    End Sub
    Public Sub sqlcmd(ByVal cmdtext)
        Dim sqlconn As New MySqlConnection
        sqlconn.ConnectionString = mysqllj
        Dim sqlcom As MySqlCommand = New MySqlCommand()
        sqlcom.Connection = sqlconn
        sqlcom.CommandText = cmdtext
        sqlconn.Open()
        sqlcom.ExecuteNonQuery()
        sqlconn.Close()
    End Sub
    Public Sub isdgempty(ByVal a As DataGridView)
        If a.RowCount = 0 Then
            Exit Sub
        End If
    End Sub
    Public Sub dgsortdisable(ByVal dg1 As DataGridView)
        If dg1.ColumnCount > 0 Then
            For i = 0 To dg1.ColumnCount - 1
                dg1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End If

    End Sub

    'Public Sub comboboxadd(ByVal dgtemp As DataGridView, ByVal cb1 As DevExpress.XtraEditors.ComboBoxEdit)

    '    If dgtemp.RowCount > 0 Then
    '        cb1.Properties.Items.Clear()
    '        For i = 0 To dgtemp.RowCount - 1
    '            cb1.Properties.Items.Add(dgtemp.Rows(i).Cells(0).Value)
    '        Next
    '    End If
    'End Sub
    Public Sub comboboxaddin(ByVal dgtemp As DataGridView, ByVal cb1 As ComboBox)

        If dgtemp.RowCount > 0 Then
            cb1.Items.Clear()
            For i = 0 To dgtemp.RowCount - 1
                cb1.Items.Add(dgtemp.Rows(i).Cells(0).Value)
            Next
        End If
    End Sub

    Public Sub dgadd(ByVal dgtemp As DataGridView, ByVal dgtarget As DataGridView, ByVal a As Integer)
        If dgtemp.RowCount > 0 Then
            dgtarget.Rows.Clear()
            Try
                For i = 0 To dgtemp.RowCount - 1
                    Select Case a
                        Case 1
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value)
                        Case 2
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value)
                        Case 3
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value)
                        Case 4
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value)
                        Case 5
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value)
                        Case 6
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value, dgtemp.Rows(i).Cells(5).Value)
                        Case 7
                            dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value, dgtemp.Rows(i).Cells(5).Value, dgtemp.Rows(i).Cells(6).Value)

                    End Select

                Next
            Catch ex As Exception

            End Try
           
        Else
            dgtarget.Rows.Clear()
        End If

    End Sub

    Public Sub dgadd_noclear(ByVal dgtemp As DataGridView, ByVal dgtarget As DataGridView, ByVal a As Integer)
        If dgtemp.RowCount > 0 Then
            dgtarget.Rows.Clear()
            For i = 0 To dgtemp.RowCount - 1
                Select Case a
                    Case 1
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value)
                    Case 2
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value)
                    Case 3
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value)
                    Case 4
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value)
                    Case 5
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value)
                    Case 6
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value, dgtemp.Rows(i).Cells(5).Value)
                    Case 7
                        dgtarget.Rows.Add(dgtemp.Rows(i).Cells(0).Value, dgtemp.Rows(i).Cells(1).Value, dgtemp.Rows(i).Cells(2).Value, dgtemp.Rows(i).Cells(3).Value, dgtemp.Rows(i).Cells(4).Value, dgtemp.Rows(i).Cells(5).Value, dgtemp.Rows(i).Cells(6).Value)

                End Select

            Next

        End If

    End Sub

    Public Sub rsmsg(ByVal cn As String, ByVal en As String)
        If 主界面.lan.Text = "English" Then
            MsgBox(en, , "Information")
        Else
            MsgBox(cn, , "提示")
        End If


    End Sub

    Public Sub expo(ByVal dg1 As DataGridView, ByVal a As String)

        Dim SaveFileDialog1 As System.Windows.Forms.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        If dg1 Is Nothing Then
            MessageBox.Show("导出容为空 !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If dg1.Rows.Count > 0 Then
            Dim MyFileName As String
            Dim FileName As String = ""
            With SaveFileDialog1
                .AddExtension = True '如果用户忘记添加扩展名，将自动家上
                .DefaultExt = "xls" '默认扩展名
                .Filter = "Excel(*.xls)|*.xls"
                .Title = "Save file to"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    FileName = .FileName
                End If
            End With
            MyFileName = Microsoft.VisualBasic.Right(FileName, 4)
            If MyFileName = "" Then
                Exit Sub
            End If
            If MyFileName = ".xls" Or MyFileName = ".XLS" Then
                Dim FS As FileStream = New FileStream(FileName, FileMode.Create)
                ' Dim FS As FileStream = New FileStream("1111", FileMode.Create)
                Dim sw As StreamWriter = New StreamWriter(FS, System.Text.Encoding.Default)
                ' sw.WriteLine(vbTab & FileName & vbTab & Date.Now)
                sw.WriteLine(a & vbTab & Date.Now)
                Dim i, j As Integer
                Dim str As String = ""
                For i = 0 To dg1.Columns.Count - 1
                    str = dg1.Columns(i).HeaderText
                    sw.Write(str & vbTab)
                Next
                sw.Write(vbCrLf)
                For j = 0 To dg1.Rows.Count - 1
                    For i = 0 To dg1.Columns.Count - 1
                        Dim strRow As String
                        strRow = Trim(IIf(dg1(i, j).Value Is DBNull.Value, "", dg1(i, j).Value))
                        sw.Write(strRow & vbTab)
                    Next
                    sw.Write(vbLf)
                Next

                sw.Close()
                FS.Close()
                MessageBox.Show("导出完成 ！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If
        Else
            MessageBox.Show("导出为空", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub textbox_only_num(ByVal numea As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            If numea.Text = "0" Then
                numea.Text = ""
            End If
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Public Sub file_open(ByVal filepath As String)
        Dim FileName As String = filepath
        Dim path As String = IO.Path.GetDirectoryName(FileName)
        Process.Start(path)
    End Sub
End Class
