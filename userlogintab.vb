Imports System.Data.SqlClient

Public Class userlogintab

    Private Sub Butcancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butusrcancel.Click
        Me.Close()
    End Sub


    Private Sub Butusrlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butusrlogin.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("select *from UserTab where regno= '" & UCase(usrlogintxt.Text) & "' And password= '" & UCase(usrpasslogintxt.Text) & "' And status= 'Approved'", conn)
        Dim D1 As SqlDataReader = cmd1.ExecuteReader()
        If D1.HasRows Then
            auctionMDI.Show()
            Me.Close()
            If conn.State = ConnectionState.Open Then conn.Close()
        Else
            MsgBox("INVALID USER ID AND PASSWORD", MsgBoxStyle.Critical)
            usrpasslogintxt.Text = ""
            usrpasslogintxt.Focus()
        End If
    End Sub

    Private Sub usrlogintxt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles usrlogintxt.LostFocus
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("select regno,name,gender from UserTab where regno=" & UCase(usrlogintxt.Text) & "", conn)
        Dim D1 As SqlDataReader = cmd1.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            Label5.Text = D1(1).ToString
            Label4.Text = D1(2).ToString

        Else
            Label5.Text = ""
            Label4.Text = ""
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        If Label4.Text = "MALE" Then
            PictureBox1.Image = Image.FromFile("D:\Male.gif")
        Else
            PictureBox1.Image = Image.FromFile("D:\Female.gif")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        oldpassword.Show()
    End Sub

    Private Sub userlogintab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class