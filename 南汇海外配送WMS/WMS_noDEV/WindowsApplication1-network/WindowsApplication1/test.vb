Imports System.IO
Imports System.Data.OleDb
Imports Microsoft
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Configuration
Imports Microsoft.Office.Interop


Public Class test
    Dim mysqllj As String
    Dim db As DBconfig = New DBconfig


    Public Sub mysql_conn()
        Dim ip As String = 0
        Dim db As String = 0
        Dim id As String = 0
        Dim pw As String = 0
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            Using sr As StreamReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\dbset.ini", System.Text.Encoding.Default)
                Dim line As String
                Do
                    line = sr.ReadLine()
                    If line.Trim.Contains("IP") = True Then
                        ip = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("DB") = True Then
                        db = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("ID") = True Then
                        id = line.Remove(0, 3)
                    ElseIf line.Trim.Contains("PW") = True Then
                        pw = line.Remove(0, 3)
                        Exit Do
                    Else
                    End If
                Loop Until line Is Nothing
                sr.Close()
            End Using

            mysqllj = "server=" & ip & ";uid=" & id & ";pwd=" & pw & ";database=" & db & "; pooling=false;charset=utf8"

            'MsgBox(mysqllj)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub sel(ByVal a As String, ByVal b As DataGridView)
        'Try
        Dim sqlconn As MySqlConnection = New MySqlConnection(mysqllj)
        Dim sqldpt1 As MySqlDataAdapter = New MySqlDataAdapter(a, sqlconn)
        Dim sqldataset1 As DataSet = New DataSet
        sqldataset1.Clear()
        sqldpt1.Fill(sqldataset1)
        b.DataSource = sqldataset1.Tables(0)
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

    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(ConfigurationManager.AppSettings("ip"))



        Dim dt As DataTable = New DataTable

        dt.Columns.Add("零件号")

        dt.Columns.Add("包装数")

        For i = 0 To dg1.RowCount - 1
            dt.Rows.Add(New Object() {dg1.Rows(i).Cells(0).Value, dg1.Rows(i).Cells(1).Value})
        Next
        With Me.Chart1
            .DataSource = dt    'dt作为chart1的数据源
            .Series.Clear()
            .Legends.Clear()
            .Legends.Add("包装")
            .Series.Add("包装")
            .Series("包装").Legend = "包装"                 '指定Legend所属Series
            .Series("包装").LegendToolTip = "包装图例"
            .Series("包装").IsValueShownAsLabel = True    '标签显示数据值


        End With

        With (Chart1.Series(0))
            '指定x、y轴数据列
            .YValueMembers = "包装数"
            .XValueMember = "零件号"


            '图表类型
            '.ChartType = DataVisualization.Charting.SeriesChartType.Column

        End With
        'MsgBox(2)
        Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        xlapp = CreateObject("Excel.Application")
        xlbook = xlapp.Workbooks.Open("C:\Debug\test.xlsx")
        xlsheet = xlbook.Worksheets("Sheet1")
        xlsheet.Cells(1, 1) = "你好EXCEL2"
        xlsheet.Cells(1, 2) = "张三"
        xlsheet.Cells(2, 2) = "李四"
        xlsheet.Range("A1:A2").Merge()
        xlbook.Close()
        xlapp.Quit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(t1.Text \ t2.Text + 1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProgressBar1.Value = 30
    End Sub

  
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FileName As String = "C:\order\"
        Dim path As String = IO.Path.GetDirectoryName(FileName)
        Process.Start(path)
    End Sub
End Class