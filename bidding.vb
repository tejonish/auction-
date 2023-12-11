Imports System.Text.RegularExpressions

Public Class bidding

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim large As Integer
        large = Val(TextBox1.Text)
        If Val(TextBox2.Text) > large Then
            large = Val(TextBox2.Text)
        ElseIf Val(TextBox3.Text) > large Then
            large = Val(TextBox3.Text)
        Else
            TextBox4.Text = large
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Not Regex.Match(TextBox1.Text, "^[0-9]*$", RegexOptions.None).Success Then
            MessageBox.Show("Please Enter Digits Only!")
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[0-9]*$", RegexOptions.None).Success Then
            MessageBox.Show("Please Enter Digits Only!")
            TextBox2.Text = ""
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If Not Regex.Match(TextBox3.Text, "^[0-9]*$", RegexOptions.None).Success Then
            MessageBox.Show("Please Enter Digits Only!")
            TextBox3.Text = ""
            TextBox3.Focus()
        End If
    End Sub
End Class