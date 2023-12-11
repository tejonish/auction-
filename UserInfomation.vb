Imports System.Data.SqlClient

Public Class UserInfomation
    Sub SaveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1Var = "insert into UserTab("
        q2Var = "Values("
        q1Var = q1Var & "regno" & ","
        q2Var = q2Var & "'" & ComboBox1.Text & "',"
        q1Var = q1Var & "name" & ","
        q2Var = q2Var & "'" & TextBox1.Text & "',"
        q1Var = q1Var & "gender" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "address" & ","
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q1Var = q1Var & "Phoneno" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "Email" & ","
        q2Var = q2Var & "'" & TextBox5.Text & "',"
        q1Var = q1Var & "password" & ","
        q2Var = q2Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "status" & ")"
        q2Var = q2Var & "'Approved')"
        Dim cmd1 As New SqlCommand(q1Var & q2Var, conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Private Sub UserInfomation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select regno from UserTab order by regno", conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from UserTab where regno=" & ComboBox1.Text & "", conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(1).ToString
            TextBox2.Text = D1(2).ToString
            TextBox3.Text = D1(3).ToString
            TextBox4.Text = D1(4).ToString
            TextBox5.Text = D1(5).ToString
            TextBox6.Text = D1(6).ToString
            ComboBox2.Text = D1(7).ToString

        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            ComboBox2.Text = ""
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Butcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcancel.Click
        Me.Close()
    End Sub
    Private Sub BUTSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTSUBMIT.Click
        If vbNo = MsgBox("Are you sure you want to Approve this user", MsgBoxStyle.YesNo, "Approve User") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("delete from UserTab where regno=" & ComboBox1.Text & "", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        SaveRecord()
        BUTSUBMIT.Enabled = False
    End Sub
End Class