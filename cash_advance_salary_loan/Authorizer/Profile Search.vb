Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_profileSearch
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub frm_profileSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgv_salaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_salaryLoan.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_salaryLoan.Rows
            If row.Cells(7).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow

            ElseIf row.Cells(7).Value = "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen

            ElseIf row.Cells(7).Value = "Rejected" Then
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

    Private Sub btn_salaryLoanSortLatest_Click(sender As Object, e As EventArgs) Handles btn_salaryLoanSortLatest.Click
        'Upon clicking the button, sorts the date to latest on SL DataGrid
        dgv_salaryLoan.Sort(dgv_salaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_cashAdvanceSortLatest_Click(sender As Object, e As EventArgs) Handles btn_cashAdvanceSortLatest.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_cashAdvance.Sort(dgv_cashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub txt_employeeID_TextChanged(sender As Object, e As EventArgs) Handles txt_employeeID.TextChanged
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.salary_loan' table. You can move, or remove it, as needed.
        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)

        If txt_employeeID.Text = "" Then
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()
            txt_jobPos.Clear()
            txt_department.Clear()
            txt_monSalary.Clear()
            dgv_salaryLoan.DataSource = DBNull.Value
            dgv_cashAdvance.DataSource = DBNull.Value
        Else
            If txt_employeeID.Text <> Nothing Then
                txt_firstName.Clear()
                txt_lastName.Clear()
                txt_middleInitial.Clear()
                txt_jobPos.Clear()
                txt_department.Clear()
                txt_monSalary.Clear()
            End If

            Dim conn As New OleDbConnection(cs)
            'Database query as Variable
            Dim SelectDataEmp As String = "SELECT employee.first_name, employee.last_name, employee.middle_initial, department.dept_name, salary_level.level_name, salary_level.salary_amount
                                        FROM (employee
                                        INNER JOIN department ON employee.dept_id = department.dept_id)
                                        INNER JOIN salary_level ON employee.salary_level_id = salary_level.salary_level_id
                                        WHERE employee.employee_id=@EmpID"
            Dim cmdfetch As New OleDbCommand(SelectDataEmp, conn) 'To use the query SelectDataEmp, then, conn to connect to database

            conn.Open() 'Connection Open


            cmdfetch.Parameters.AddWithValue("@EmpID", txt_employeeID.Text) 'EmpID fetch rule
            Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
                txt_department.Text += reader("dept_name").ToString()
                txt_jobPos.Text += reader("level_name").ToString()
                txt_monSalary.Text += reader("salary_amount").ToString()
            End While

            Dim dataSL As String = "SELECT * FROM salary_loan WHERE employee_id=@EmpID"
            Dim datafetchSL As New OleDbCommand(dataSL, conn)
            'Uses the EmpID from the Login information to fetch user data
            datafetchSL.Parameters.AddWithValue("@EmpID", txt_employeeID.Text)
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
            datafetchCA.Parameters.AddWithValue("@EmpID", txt_employeeID.Text)
            'Uses the query to fill data on the Datagrid
            Dim adapterCA As New OleDbDataAdapter(datafetchCA)
            Dim tableCA As New DataTable()
            adapterCA.Fill(tableCA)

            'Puts it on the datagrid using data source and adapter command
            dgv_cashAdvance.DataSource = tableCA.DefaultView

            conn.Close()
        End If
    End Sub
End Class