Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_authorizerCashAdvance
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Public Property StringPassCA As Integer
    Private Sub frm_authorizerCashAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)

        Dim conn As New OleDbConnection(cs)
        'Fill up the SalaryLoanPending DataGrid
        Dim dataCAP As String = "SELECT * FROM cash_advance WHERE cash_adv_status='Pending'"
        Dim datafetchCAP As New OleDbCommand(dataCAP, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAP As New OleDbDataAdapter(datafetchCAP)
        Dim tableCAP As New DataTable()
        adapterCAP.Fill(tableCAP)

        'Puts it on the datagrid using data source and adapter command
        dgv_pendingCashAdvance.DataSource = tableCAP.DefaultView


        'Fill up the SalaryLoanApproved DataGrid
        Dim dataCAA As String = "SELECT * FROM cash_advance WHERE cash_adv_status='Approved'"
        Dim datafetchCAA As New OleDbCommand(dataCAA, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAA As New OleDbDataAdapter(datafetchCAA)
        Dim tableCAA As New DataTable()
        adapterCAA.Fill(tableCAA)

        'Puts it on the datagrid using data source and adapter command
        dgv_approvedCashAdvance.DataSource = tableCAA.DefaultView


        'Fill up the SalaryLoanRejected DataGrid
        Dim dataCAR As String = "SELECT * FROM cash_advance WHERE cash_adv_status='Rejected'"
        Dim datafetchCAR As New OleDbCommand(dataCAR, conn)
        'Uses the query to fill data on the Datagrid
        Dim adapterCAR As New OleDbDataAdapter(datafetchCAR)
        Dim tableCAR As New DataTable()
        adapterCAR.Fill(tableCAR)

        'Puts it on the datagrid using data source and adapter command
        dgv_rejectedCashAdvance.DataSource = tableCAR.DefaultView
    End Sub

    Private Sub dgv_pendingCashAdvance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pendingCashAdvance.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingCashAdvance.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingCashAdvance.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingCashAdvance.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingCashAdvance.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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

    Private Sub dgv_approvedCashAdvance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_approvedCashAdvance.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingCashAdvance.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingCashAdvance.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingCashAdvance.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingCashAdvance.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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

    Private Sub dgv_rejectedCashAdvance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rejectedCashAdvance.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        btn_profile.Enabled = True
        cmb_decision.Enabled = True
        btn_submit.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_pendingCashAdvance.CurrentRow.Index
        Me.txt_refID.Text = dgv_pendingCashAdvance.Item(0, i).Value
        Me.txt_loanAmount.Text = dgv_pendingCashAdvance.Item(1, i).Value
        Me.txt_employeeID.Text = dgv_pendingCashAdvance.Item(4, i).Value 'EmpID Column is hidden but existing (Click arrow icon on dgv to see)

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

    Private Sub cmb_decision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_decision.SelectedIndexChanged
        'If expression to enable submit button
        If cmb_decision.Text = "Approved" Or cmb_decision.Text = "Rejected" Then
            btn_submit.Enabled = True
        End If
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        'Passes the EmpID value to Profile Form
        Dim obj As New frm_profileExpand
        obj.StringPassCA = txt_employeeID.Text
        obj.Show()
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE cash_advance SET cash_adv_status=@status WHERE cash_adv_id=@CA_ID" 'database query

        If txt_refID.Text = Nothing Or txt_loanAmount.Text = Nothing Or cmb_decision.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()
            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@status", cmb_decision.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@CA_ID", txt_refID.Text) 'Gives a parameter for database column name
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("                Submit? " + Environment.NewLine + "(Uneditable after submission)", "Cash Advance Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_authorizerCashAdvance_Load(e, e) 'Reloads the Form
            Refresh()
        End If
    End Sub

    Private Sub dgv_pendingCashAdvance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_pendingCashAdvance.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_pendingCashAdvance.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.BackColor = Color.LightYellow
            End If
        Next
    End Sub

    Private Sub dgv_approvedCashAdvance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_approvedCashAdvance.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_approvedCashAdvance.Rows
            If row.Cells(3).Value Is "Approved" Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub

    Private Sub dgv_rejectedCashAdvance_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_rejectedCashAdvance.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_rejectedCashAdvance.Rows
            If row.Cells(3).Value Is "Rejected" Then
                row.DefaultCellStyle.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub btn_pendingCASortLatest_Click(sender As Object, e As EventArgs) Handles btn_pendingCASortLatest.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_pendingCashAdvance.Sort(dgv_pendingCashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_approvedCAsortLatest_Click(sender As Object, e As EventArgs) Handles btn_approvedCAsortLatest.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_approvedCashAdvance.Sort(dgv_approvedCashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub btn_rejectedCAsortLatest_Click(sender As Object, e As EventArgs) Handles btn_rejectedCAsortLatest.Click
        'Upon clicking the button, sorts the date to latest on CA DataGrid
        dgv_rejectedCashAdvance.Sort(dgv_rejectedCashAdvance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class