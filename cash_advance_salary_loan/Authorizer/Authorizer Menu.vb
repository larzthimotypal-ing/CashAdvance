Public Class frm_authorizerMenu
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.ActiveControl = Nothing
        frm_login.Show()
        frm_login.txt_employeeID.Clear()
        frm_login.txt_password.Clear()
        frm_login.cmb_userType.SelectedIndex = -1
        Me.Close()
    End Sub

    Private Sub btn_salaryLoan_Click(sender As Object, e As EventArgs) Handles btn_salaryLoan.Click
        Me.ActiveControl = Nothing
        frm_authorizerSalaryLoan.Show()
    End Sub

    Private Sub btn_cashAdvance_Click(sender As Object, e As EventArgs) Handles btn_cashAdvance.Click
        Me.ActiveControl = Nothing
        frm_authorizerCashAdvance.Show()
    End Sub

    Private Sub btn_searchProfile_Click(sender As Object, e As EventArgs) Handles btn_searchProfile.Click
        Me.ActiveControl = Nothing
        frm_profileSearch.Show()
    End Sub

    Private Sub frm_authorizerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class