Public Class product_info
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fashion_click.Click
        fashion.Show()
    End Sub

    Private Sub BUTBACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTBACK.Click
        Me.Close()
    End Sub

    Private Sub electronics_cilck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles electronics_cilck.Click
        electronics.Show()
    End Sub

    Private Sub arts_cilck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arts_cilck.Click
        artsandcollections.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        artsandcollections.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        electronics.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        fashion.Show()
    End Sub
End Class