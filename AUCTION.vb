Public Class AUCTION
    Dim X As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If X < ProgressBar1.Maximum.ToString Then
            ProgressBar1.Value() = X
            X = X + 1
            Label4.Text = X & "%"
        Else
            Timer1.Enabled = False
            accesspage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AUCTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
