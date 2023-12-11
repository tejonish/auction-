Imports System.Data.SqlClient

Public Class statuspage
    
    Private Sub ButOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOK.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from UserTab where regno= '" & UCase(TextBox1.Text) & "' And password= '" & UCase(TextBox2.Text) & "'", conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(6).ToString
            TextBox3.Text = D1(7).ToString
        Else
            MsgBox("INVALID REG NO", MsgBoxStyle.Critical)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

   
    Private Sub Butcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcancel.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub statuspage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "Approved" Then
            BackColor = Color.GreenYellow
        ElseIf TextBox3.Text = "Pending" Then
            BackColor = Color.Yellow
        Else
            BackColor = Color.LightSkyBlue

        End If
    End Sub
End Class