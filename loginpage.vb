Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class loginpage


    Private Sub Butlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butlogin.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("select *from logintab where username= '" & UCase(textuser.Text) & "' And password= '" & UCase(textpass.Text) & "'", conn)
        Dim D1 As SqlDataReader = cmd1.ExecuteReader()
        If D1.HasRows Then
            accessadmin.Show()
            Me.Close()
            If conn.State = ConnectionState.Open Then conn.Close()
        Else
            MsgBox("INVALID USERNAME AND PASSWORD", MsgBoxStyle.Critical)
            textuser.Text = ""
            textpass.Text = ""
            textuser.Focus()
        End If
    End Sub

    Private Sub Butcancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcancel.Click
        Me.Close()
    End Sub

    Private Sub textuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textuser.TextChanged
        If Not Regex.Match(textuser.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            textuser.Text = ""
            textuser.Focus()
        End If
    End Sub
End Class