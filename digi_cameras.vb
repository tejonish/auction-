﻿Public Class digi_cameras

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        product_registration.TextBox6.Text = Label13.Text
        product_registration.PictureBox1.Image = PictureBox1.Image
        product_registration.TextBox7.Text = Label2.Text
        product_registration.TextBox8.Text = Label6.Text
        product_registration.TextBox9.Text = Label1.Text
        product_registration.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        product_registration.TextBox6.Text = Label20.Text
        product_registration.PictureBox1.Image = PictureBox2.Image
        product_registration.TextBox7.Text = Label18.Text
        product_registration.TextBox8.Text = Label19.Text
        product_registration.TextBox9.Text = Label17.Text
        product_registration.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        product_registration.TextBox6.Text = Label24.Text
        product_registration.PictureBox1.Image = PictureBox3.Image
        product_registration.TextBox7.Text = Label22.Text
        product_registration.TextBox8.Text = Label23.Text
        product_registration.TextBox9.Text = Label21.Text
        product_registration.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        laptop.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        tablets.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        cam_drones.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        lens.Show()
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        smartphones.Show()
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        smartwatches.Show()
    End Sub
End Class