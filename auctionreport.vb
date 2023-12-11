Imports System.Data.SqlClient

Public Class auctionreport


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select auctionID,productname,productseller,actualprize,hammerdamount from auctionTab where auctionID=" & ComboBox1.Text & "", conn)
        Dim D1 As SqlDataReader = cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(1).ToString
            TextBox2.Text = D1(2).ToString
            TextBox3.Text = D1(3).ToString
            TextBox4.Text = D1(4).ToString

        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""

        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub auctionreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select auctionID from auctionTab order by auctionID", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        While d1.Read
            ComboBox1.Items.Add(d1(0).ToString)
        End While
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class