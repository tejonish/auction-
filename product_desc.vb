Imports System.Data.SqlClient

Public Class product_desc
    Sub SaveRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        q1Var = "insert into auctionTab("
        q2Var = "Values("
        q1Var = q1Var & "auctionID" & ","
        q2Var = q2Var & "'" & TextBox2.Text & "',"
        q1Var = q1Var & "productname" & ","
        q2Var = q2Var & "'" & TextBox4.Text & "',"
        q1Var = q1Var & "productseller" & ","
        q2Var = q2Var & "'" & TextBox6.Text & "',"
        q1Var = q1Var & "actualprize" & ","
        q2Var = q2Var & "'" & TextBox7.Text & "',"
        q1Var = q1Var & "bidder" & ","
        q2Var = q2Var & "'" & TextBox8.Text & "',"
        q1Var = q1Var & "hammerdamount" & ","
        q2Var = q2Var & "'" & TextBox9.Text & "',"
        q1Var = q1Var & "date" & ","
        q2Var = q2Var & "'" & TextBox10.Text & "',"
        q1Var = q1Var & "time" & ","
        q2Var = q2Var & "'" & TextBox11.Text & "',"
        q1Var = q1Var & "finalamount" & ")"
        q2Var = q2Var & "'" & TextBox12.Text & "')"


        Dim cmd1 As New SqlCommand(q1Var & q2Var, conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disRecords()
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox4.Focus()
    End Sub

    Sub disRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("select *from  auctionTab order by auctionID", conn)
        adp.Fill(DS1)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox2.Visible = True
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox2.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub product_desc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label9.Text = Val(Label5.Text) * 0.9 + Val(Label5.Text)
        Timer1.Enabled = True
        Panel1.Hide()
        PictureBox2.Visible = False
        TextBox1.Enabled = False

        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select max(auctionID) from auctionTab", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            TextBox2.Text = IIf(IsDBNull(d1(0)), 5000, d1(0)) + 1
        Else
            TextBox2.Enabled = "5001"
        End If
        TextBox2.Enabled = False
        TextBox2.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Show()
        TextBox4.Text = Label3.Text
        TextBox5.Text = TextBox1.Text
        TextBox6.Text = Label4.Text
        TextBox7.Text = Label5.Text
        TextBox8.Text = Label4.Text
        TextBox9.Text = Label9.Text
        TextBox10.Text = Label25.Text
        TextBox11.Text = Label16.Text

        TextBox12.Text = Val(TextBox9.Text) * 0.5 + Val(TextBox9.Text)
    End Sub


    Private Sub Butnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butnext.Click
        MsgBox("ARE YOU SURE DO YOU WANT TO CANCEL THE ORDER :)", vbCritical, vbYesNo)
        Panel1.Hide()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        With Label16
            .ForeColor = Color.DarkSlateBlue
            .Text = TimeOfDay
        End With
        With Label25
            .ForeColor = Color.DarkSlateBlue
            .Text = Date.Today.ToString("dd-MMM-yyyy")
        End With
    End Sub



    Private Sub BUTSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTSUBMIT.Click
        Label26.Visible = True
        If TextBox4.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox5.Focus()
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox6.Focus()
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox7.Focus()
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox8.Focus()
        ElseIf TextBox9.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox9.Focus()
        ElseIf TextBox10.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox10.Focus()
        ElseIf TextBox11.Text = "" Then
            MessageBox.Show("Please type the data!")
            TextBox11.Focus()

        Else
            SaveRecord()
            BUTSUBMIT.Enabled = False
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            MsgBox("THE DATA HAS SAVED SUCCEFFULLY :)", vbInformation, vbOKCancel)
        End If
        Panel1.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel1.Hide()
    End Sub
End Class
