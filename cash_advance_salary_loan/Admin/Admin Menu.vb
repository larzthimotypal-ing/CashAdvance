Public Class frm_adminMenu
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.ActiveControl = Nothing
        frm_login.Show()
        frm_login.txt_employeeID.Clear()
        frm_login.txt_password.Clear()
        frm_login.cmb_userType.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub btn_manageAccounts_Click(sender As Object, e As EventArgs) Handles btn_manageAccounts.Click
        Me.ActiveControl = Nothing
        frm_accountManage.Show()
    End Sub

End Class