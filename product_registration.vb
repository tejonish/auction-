Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class product_registration
    Sub SaveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1Var = "insert into productTab("
        q2Var = "Values("
        q1Var = q1Var & "regno" & ","
        q2Var = q2Var & "'" & TextBox1.Text & "',"
        q1Var = q1Var & "name" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "gender" & ","
        q2Var = q2Var & "'" & ComboBox1.Text & "',"
        q1Var = q1Var & "address" & ","
        q2Var = q2Var & "'" & TextBox3.Text & "',"
        q1Var = q1Var & "phno" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "Email" & ","
        q2Var = q2Var & "'" & TextBox5.Text & "',"
        q1Var = q1Var & "productname" & ","
        q2Var = q2Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "productseller" & ","
        q2Var = q2Var & "'" & TextBox7.Text & "',"
        q1Var = q1Var & "productprize" & ")"
        q2Var = q2Var & "'" & TextBox9.Text & "')"
       
        
        Dim cmd1 As New SqlCommand(q1Var & q2Var, conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select *from  productTab order by regno", conn)
        adp.Fill(DS1)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Private Sub product_registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select max(regno) from productTab", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox1.Text = IIf(IsDBNull(d1(0)), 2000, d1(0)) + 1
        Else
            TextBox1.Enabled = "2001"
        End If
        TextBox1.Enabled = False
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            TextBox2.Text = ""
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.None).Success Then
            MessageBox.Show("Please Enter Digits Only!")
            TextBox4.Text = ""
            TextBox4.Focus()
        End If
    End Sub

   

    Private Sub BUTSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTSUBMIT.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox5.Focus()
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("Please type the data!")
            ComboBox1.Focus()

        Else
            SaveRecord()
            BUTSUBMIT.Enabled = False
            MsgBox("THE DATA HAS SAVED SUCCEFFULLY! ", vbInformation, vbOKCancel)
            Me.Close()
        End If
    End Sub

    Private Sub Butcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcancel.Click
        Me.Close()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox2.Focus()
        ComboBox1.Text = ""
    End Sub

End Class