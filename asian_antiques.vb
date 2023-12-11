Public Class asian_antiques
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        stamps_india.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        stamps_korea.Show()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        stamps_korea.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        product_registration.TextBox6.Text = Label2.Text
        product_registration.PictureBox1.Image = PictureBox1.Image
        product_registration.TextBox7.Text = Label4.Text
        product_registration.TextBox8.Text = Label3.Text
        product_registration.TextBox9.Text = Label9.Text
        product_registration.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        product_registration.TextBox6.Text = Label17.Text
        product_registration.PictureBox1.Image = PictureBox2.Image
        product_registration.TextBox7.Text = Label13.Text
        product_registration.TextBox8.Text = Label16.Text
        product_registration.TextBox9.Text = Label11.Text
        product_registration.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        product_registration.TextBox6.Text = Label21.Text
        product_registration.PictureBox1.Image = PictureBox3.Image
        product_registration.TextBox7.Text = Label19.Text
        product_registration.TextBox8.Text = Label20.Text
        product_registration.TextBox9.Text = Label18.Text
        product_registration.Show()
    End Sub

    Private Sub Panel4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick
        
        product_desc.PictureBox1.Image = PictureBox1.Image
        product_desc.PictureBox2.Image = PictureBox1.Image
        product_desc.Label3.Text = Label2.Text
        product_desc.TextBox1.Text = Label3.Text
        product_desc.Label4.Text = Label4.Text
        product_desc.Label5.Text = Label9.Text
        product_desc.Show()
    End Sub

    Private Sub Panel2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        product_desc.PictureBox1.Image = PictureBox2.Image
        product_desc.PictureBox2.Image = PictureBox2.Image
        product_desc.Label3.Text = Label17.Text
        product_desc.TextBox1.Text = Label16.Text
        product_desc.Label4.Text = Label13.Text
        product_desc.Label5.Text = Label11.Text
        product_desc.Show()
    End Sub

    Private Sub Panel3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick
        product_desc.PictureBox1.Image = PictureBox3.Image
        product_desc.PictureBox2.Image = PictureBox3.Image
        product_desc.Label3.Text = Label21.Text
        product_desc.TextBox1.Text = Label20.Text
        product_desc.Label4.Text = Label19.Text
        product_desc.Label5.Text = Label18.Text
        product_desc.Show()
    End Sub

    Private Sub asian_antiques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class