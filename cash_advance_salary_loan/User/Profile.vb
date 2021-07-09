Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_profile
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub frm_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.salary_loan' table. You can move, or remove it, as needed.
        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)

        Dim conn As New OleDbConnection(cs)
        Dim SelectDataEmp As String = "SELECT employee.first_name, employee.last_name, employee.middle_initial, department.dept_name, salary_level.level_name, salary_level.salary_amount, [identity].password
                                        FROM ((employee
                                        INNER JOIN department ON employee.dept_id = department.dept_id)
                                        INNER JOIN salary_level ON employee.salary_level_id = salary_level.salary_level_id)
                                        INNER JOIN [identity] ON employee.employee_id = [identity].employee_id
                                        WHERE employee.employee_id=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectDataEmp, conn) 'To use the query SelectDataEmp, then, conn to connect to database

        conn.Open() 'Connection Open

        cmdfetch.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID) 'EmpID fetch rule
        Me.txt_employeeID.Text = FetchEmpID.SavedEmpID 'FetchEmpID is class with variable name SavedEmpID Imported from LogIn Form
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        While reader.Read() 'Automatic User data fetch rule
            'textbox.Text += reader("column name from database").ToString() <- to output to string
            txt_firstName.Text += reader("first_name").ToString()
            txt_lastName.Text += reader("last_name").ToString()
            txt_middleInitial.Text += reader("middle_initial").ToString()
            txt_department.Text += reader("dept_name").ToString()
            txt_jobPos.Text += reader("level_name").ToString()
            txt_monSalary.Text += reader("salary_amount").ToString()
            txt_password.Text += reader("password").ToString()
        End While

        conn.Close() 'Connection Open


        'Fill up the SalaryLoan DataGrid
        Dim dataSL As String = "SELECT * FROM salary_loan WHERE employee_id=@EmpID"
        Dim datafetchSL As New OleDbCommand(dataSL, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchSL.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        'Uses the query to fill data on the Datagrid
        Dim adapterSL As New OleDbDataAdapter(datafetchSL)
        Dim tableSL As New DataTable()
        adapterSL.Fill(tableSL)

        'Puts it on the datagrid using data source and adapter command
        dgv_salaryLoan.DataSource = tableSL.DefaultView

        'Fill up the CashAdvance DataGrid
        Dim dataCA As String = "SELECT * FROM cash_advance WHERE employee_id=@EmpID"
        Dim datafetchCA As New OleDbCommand(dataCA, conn)
        'Uses the EmpID from the Login information to fetch user data
        datafetchCA.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        'Uses the query to fill data on the Datagrid
        Dim adapterCA As New OleDbDataAdapter(datafetchCA)
        Dim tableCA As New DataTable()
        adapterCA.Fill(tableCA)

        'Puts it on the datagrid using data source and adapter command
        dgv_cashAdvance.DataSource = tableCA.DefaultView
    End Sub

    Private Sub btn_SLsortLatest_Click(sender As Object, e As EventArgs) Handles btn_SLsortLatest.Click
        'Upon clicking the button, sorts the date to latest on SL DataGrid
        dgv_salaryLoan.Sort(dgv_salaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_SLsortApproved_Click(sender As Object, e As EventArgs) Handles btn_SLsortApproved.Click
        'Upon clicking the button, sorts the Status to Approved on SL DataGrid
        dgv_salaryLoan.Sort(dgv_salaryLoan.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btn_CAsortLatest_Click(sender As Object, e As EventArgs) Handles btn_CAsortLatest.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_cashAdvance.Sort(dgv_cashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_CAsortApproved_Click(sender As Object, e As EventArgs) Handles btn_CAsortApproved.Click
        'Upon clicking the button, sorts the Status to Approved on CA DataGrid
        dgv_cashAdvance.Sort(dgv_cashAdvance.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub dgv_salaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_salaryLoan.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_salaryLoan.Rows
            If row.Cells(4).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(4).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(4).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub dgv_cashAdvance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_cashAdvance.CellFormatting

        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_cashAdvance.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(3).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(3).Value = "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_changePW_Click(sender As Object, e As EventArgs) Handles btn_changePW.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE [identity] SET [password]=@Password WHERE employee_id=@EmpID" 'database query
        'Password is inside [] because its a default entity within the language

        txt_password.Enabled = True
        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        cmd.Parameters.AddWithValue("@Password", txt_password.Text) 'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Edit Password?", "Password Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_profile_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub
End Class