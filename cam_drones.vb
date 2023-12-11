Public Class cam_drones

    Private Sub cam_drones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        product_registration.TextBox6.Text = Label28.Text
        product_registration.PictureBox1.Image = PictureBox1.Image
        product_registration.TextBox7.Text = Label22.Text
        product_registration.TextBox8.Text = Label23.Text
        product_registration.TextBox9.Text = Label21.Text
        product_registration.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        product_registration.TextBox6.Text = Label24.Text
        product_registration.PictureBox1.Image = PictureBox2.Image
        product_registration.TextBox7.Text = Label26.Text
        product_registration.TextBox8.Text = Label27.Text
        product_registration.TextBox9.Text = Label25.Text
        product_registration.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        product_registration.TextBox6.Text = Label15.Text
        product_registration.PictureBox1.Image = PictureBox3.Image
        product_registration.TextBox7.Text = Label30.Text
        product_registration.TextBox8.Text = Label31.Text
        product_registration.TextBox9.Text = Label24.Text
        product_registration.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        laptop.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        tablets.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        digi_cameras.Show()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
        lens.Show()
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click
        smartphones.Show()
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click
        smartwatches.Show()
    End Sub
End Class