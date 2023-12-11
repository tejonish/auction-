'Imports System.Data.SqlClient
'Imports System.Text.RegularExpressions
'Public Class adminforgotpass
'    Dim pkvar As String
'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'        Me.Close()
'    End Sub

'    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
'        If conn.State = ConnectionState.Open Then conn.Close()
'        conn.Open()
'        Dim cmd1 As New SqlCommand("select password from logintab where username= '" & UCase(TextBox1.Text) & "'", conn)
'        Dim D1 As SqlDataReader = cmd1.ExecuteReader()
'        If D1.HasRows Then
'            MsgBox("To view password click ok", MsgBoxStyle.Exclamation)
'            If conn.State = ConnectionState.Open Then conn.Close()
'            conn.Open()
'            Dim cmd0 As New SqlCommand("select password from logintab where username'" & UCase(TextBox1.Text) & "'", conn)
'            Dim D2 As SqlDataReader = cmd0.ExecuteReader()
'            If D2.HasRows Then
'                D2.Read()
'                Label6.Text = D2(0).ToString
'            Else
'                MsgBox("Invalid UserID ", MsgBoxStyle.Critical)
'                TextBox1.Text = ""
'                TextBox1.Focus()
'            End If
'            If conn.State = ConnectionState.Open Then conn.Close()
'        End If
'    End Sub

'End Class