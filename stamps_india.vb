Public Class stamps_india

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        product_registration.TextBox6.Text = Label24.Text
        product_registration.PictureBox1.Image = PictureBox6.Image
        product_registration.TextBox7.Text = Label20.Text
        product_registration.TextBox8.Text = Label23.Text
        product_registration.TextBox9.Text = Label25.Text
        product_registration.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        product_registration.TextBox6.Text = Label13.Text
        product_registration.PictureBox1.Image = PictureBox5.Image
        product_registration.TextBox7.Text = Label26.Text
        product_registration.TextBox8.Text = Label11.Text
        product_registration.TextBox9.Text = Label27.Text
        product_registration.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        product_registration.TextBox6.Text = Label19.Text
        product_registration.PictureBox1.Image = PictureBox4.Image
        product_registration.TextBox7.Text = Label28.Text
        product_registration.TextBox8.Text = Label18.Text
        product_registration.TextBox9.Text = Label29.Text
        product_registration.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        asian_antiques.Show()
    End Sub

    
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        music_instruments.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        sculpting.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        pottery.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        stamps_korea.Close()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        stamps_japan.Show()
    End Sub

End Class