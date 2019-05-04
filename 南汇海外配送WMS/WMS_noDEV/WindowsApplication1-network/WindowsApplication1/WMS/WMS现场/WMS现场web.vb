
Public Class WMS现场web
    Public Sub loadsize()
        With pweb
            .Left = Me.Left + (Me.Width - web1.Width) / 2
            .Top = Me.Top
            .Height = Me.Height - 15 - bsmall.Height
        End With
        With bsmall
            .Left = pweb.Left
            .Top = pweb.Bottom + 10
        End With
        With bbig
            .Left = pweb.Right - bbig.Width
            .Top = bsmall.Top
        End With
    End Sub
    Private Sub WMS现场web_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsize()

        'web1.Url = New Uri("http://121.204.181.47:82/")
        web1.Url = New Uri("http://localhost:82")
       

    End Sub

    Private Sub Bsmall_Click(sender As Object, e As EventArgs) Handles bsmall.Click
        web1.Focus()
        SendKeys.Send("^-")
    End Sub

    Private Sub Bbig_Click(sender As Object, e As EventArgs) Handles bbig.Click
        web1.Focus()
        SendKeys.Send("^=")
    End Sub
    Dim smalltemp As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If smalltemp < 2 Then
            Bsmall_Click(1, e)
            smalltemp += 1
        Else
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub web1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles web1.DocumentCompleted

    End Sub
End Class
