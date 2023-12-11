Imports System.Data.SqlClient
Public Class report
    Dim pkvr As Integer
    Dim YPos As Integer
    Dim XPos As Integer
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        YPos = 50
        Dim myfont As New Font("Impact", 20)
        XPos = 10
        e.Graphics.DrawString("AUCTION", myfont, Brushes.Red, XPos, YPos)
        YPos += 50
        XPos = 300
        myfont = New Font("Lucida Console, 7.8pt, style=Bold", 16)
        e.Graphics.DrawString("auctionTab", myfont, Brushes.Blue, XPos, YPos)
        YPos += 50
        XPos = 180
        myfont = New Font("Arial", 14)
        e.Graphics.DrawString("auctionID", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("productname", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("productseller", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("actualprize", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("bidder", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("hammerdamount", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("date", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("time", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50
        e.Graphics.DrawString("finalamount", myfont, Brushes.Black, XPos, YPos)
        YPos = YPos + 50

        'YPos += 50
        'XPos = 100
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("select *from auctionTab where auctionID='" & TextBox1.Text & "'", conn)
        Dim D2 As SqlDataReader = cmd0.ExecuteReader()
        While D2.Read
            YPos = 150
            XPos = XPos + 350
            e.Graphics.DrawString(D2(0).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(1).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(2).ToString, myfont, Brushes.Black, XPos, YPos)

            YPos = YPos + 50
            e.Graphics.DrawString(D2(3).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(4).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(5).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(6).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(7).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            e.Graphics.DrawString(D2(8).ToString, myfont, Brushes.Black, XPos, YPos)
            YPos = YPos + 50
            YPos += 25

        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Show()
    End Sub

End Class