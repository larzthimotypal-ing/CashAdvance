Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_authorizerSalaryLoan
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Public Property StringPassSL As Integer

    Private Sub frm_authorizerSalaryLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.salary_loan' table. You can move, or remove it, as needed.
        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)

        Dim conn As New OleDbConnection(cs)

        'Fill up the SalaryLoanPending DataGrid
        Dim dataSLP As String = "SELECT * FROM salary_loan WHERE sal_loan_status='Pending'"
        Dim datafetchSLP As New OleDbCommand(dataSLP, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLP As New OleDbDataAdapter(datafetchSLP)
        Dim tableSLP As New DataTable()
        adapterSLP.Fill(tableSLP)

        'Puts it on the datagrid using data source and adapter command
        dgv_pendingSalaryLoan.DataSource = tableSLP.DefaultView


        'Fill up the SalaryLoanApproved DataGrid
        Dim dataSLA As String = "SELECT * FROM salary_loan WHERE sal_loan_status='Approved'"
        Dim datafetchSLA As New OleDbCommand(dataSLA, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLA As New OleDbDataAdapter(datafetchSLA)
        Dim tableSLA As New DataTable()
        adapterSLA.Fill(tableSLA)

        'Puts it on the datagrid using data source and adapter command
        dgv_approvedSalaryLoan.DataSource = tableSLA.DefaultView


        'Fill up the SalaryLoanRejected DataGrid
        Dim dataSLR As String = "SELECT * FROM salary_loan WHERE sal_loan_status='Rejected'"
        Dim datafetchSLR As New OleDbCommand(dataSLR, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterSLR As New OleDbDataAdapter(datafetchSLR)
        Dim tableSLR As New DataTable()
        adapterSLR.Fill(tableSLR)

        'Puts it on the datagrid using data source and adapter command
        dgv_rejectedSalaryLoan.DataSource = tableSLR.DefaultView
    End Sub

    Private Sub dgv_pendingSalaryLoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendingSalaryLoan.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingSalaryLoan.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingSalaryLoan.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingSalaryLoan.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingSalaryLoan.Item(8, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)


        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim SelectData As String = "SELECT first_name, last_name, middle_initial FROM employee WHERE employee_id=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_employeeID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        Else
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()

            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        End If

        conn.Close()
    End Sub

    Private Sub dgv_approvedSalaryLoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_approvedSalaryLoan.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingSalaryLoan.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingSalaryLoan.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingSalaryLoan.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingSalaryLoan.Item(8, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)


        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim SelectData As String = "SELECT first_name, last_name, middle_initial FROM employee WHERE employee_id=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_employeeID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        Else
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()

            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        End If

        conn.Close()
    End Sub

    Private Sub dgv_rejectedSalaryLoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rejectedSalaryLoan.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingSalaryLoan.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingSalaryLoan.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingSalaryLoan.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingSalaryLoan.Item(8, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)


        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim SelectData As String = "SELECT first_name, last_name, middle_initial FROM employee WHERE employee_id=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()
        cmdfetch.Parameters.AddWithValue("@EmpID", txt_employeeID.Text) 'EmpID fetch rule
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        Else
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()

            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
            End While
        End If
    End Sub

    Private Sub cmb_decision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_decision.SelectedIndexChanged
        'If expression to enable submit button
        If cmb_decision.Text = "Approved" Or cmb_decision.Text = "Rejected" Then
            btn_submit.Enabled = True
        End If
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        'Passes the EmpID value to Profile Form
        Dim obj As New frm_profileExpand
        obj.StringPassSL = txt_employeeID.Text
        obj.Show()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE salary_loan SET sal_loan_status=@status WHERE salary_loan_id=@SL_ID" 'database query

        If txt_refID.Text = Nothing Or txt_loanAmount.Text = Nothing Or cmb_decision.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@status", cmb_decision.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@SL_ID", txt_refID.Text) 'Gives a parameter for database column name
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("                Submit? " + Environment.NewLine + "(Uneditable after submission)", "Salary Loan Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_authorizerSalaryLoan_Load(e, e) 'Reloads the Form
            Refresh()
        End If
    End Sub

    Private Sub dgv_pendingSalaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_pendingSalaryLoan.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_pendingSalaryLoan.Rows
            If row.Cells(7).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next
    End Sub

    Private Sub dgv_approvedSalaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_approvedSalaryLoan.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_approvedSalaryLoan.Rows
            If row.Cells(7).Value Is "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub dgv_rejectedSalaryLoan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_rejectedSalaryLoan.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_rejectedSalaryLoan.Rows
            If row.Cells(7).Value Is "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_pendingSLSortLatest_Click(sender As Object, e As EventArgs) Handles btn_pendingSLSortLatest.Click
        dgv_pendingSalaryLoan.Sort(dgv_pendingSalaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_approvedSLsortLatest_Click(sender As Object, e As EventArgs) Handles btn_approvedSLsortLatest.Click
        dgv_approvedSalaryLoan.Sort(dgv_approvedSalaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_rejectedSLsortLatest_Click(sender As Object, e As EventArgs) Handles btn_rejectedSLsortLatest.Click
        dgv_rejectedSalaryLoan.Sort(dgv_rejectedSalaryLoan.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class