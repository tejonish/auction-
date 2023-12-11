Public Class accesspage

    
    
    Private Sub but_acc_signup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_acc_signup.Click
        registration.Show()
    End Sub

    Private Sub but_acc_usrlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_acc_usrlogin.Click
        userlogintab.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        statuspage.Show()
    End Sub

    Private Sub but_acc_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_acc_admin.Click
        loginpage.Show()
    End Sub

End Class