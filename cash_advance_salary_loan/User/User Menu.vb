Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Public Class frm_userMenu
    Friend Shared txt_EmpID As Object
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub btn_salaryLoan_Click(sender As Object, e As EventArgs) Handles btn_salaryLoan.Click
        Me.ActiveControl = Nothing
        frm_userSalaryLoan.Show()
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        Me.ActiveControl = Nothing
        frm_profile.Show()
    End Sub

    Private Sub btn_cashAdvance_Click(sender As Object, e As EventArgs) Handles btn_cashAdvance.Click
        Me.ActiveControl = Nothing
        frm_userCashAdvance.Show()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.ActiveControl = Nothing
        frm_login.Show()
        frm_login.txt_employeeID.Clear()
        frm_login.txt_password.Clear()
        frm_login.cmb_userType.SelectedIndex = -1
        Me.Close()

    End Sub

    Private Sub frm_userMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class