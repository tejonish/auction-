Imports System.Windows.Forms

Public Class auctionMDI

    Private Sub RuleAndRegulationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RuleAndRegulationsToolStripMenuItem.Click
        rules_regulation.MdiParent = Me
        rules_regulation.Show()
    End Sub

    Private Sub ProductInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        product_info.MdiParent = Me
        product_info.Show()
    End Sub

    Private Sub FashionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fashion.MdiParent = Me
        fashion.Show()
    End Sub

    Private Sub ElectronicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        electronics.MdiParent = Me
        electronics.Show()
    End Sub

    Private Sub ArtsAndCollectablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        artsandcollections.MdiParent = Me
        artsandcollections.Show()
    End Sub

    Private Sub RegisterHereToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        registration.MdiParent = Me
        registration.Show()
    End Sub


    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        report.MdiParent = Me
        report.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        Dim temp As VariantType
        temp = MsgBox("ARE YOU SURE DO YOU WANT TO LOG OUT?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "ALERT")
        If temp = vbYes Then
            Me.Close()
            accesspage.Show()
        Else
            temp = vbNo
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        product_info.MdiParent = Me
        product_info.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        aboutus.MdiParent = Me
        aboutus.Show()
    End Sub
End Class
