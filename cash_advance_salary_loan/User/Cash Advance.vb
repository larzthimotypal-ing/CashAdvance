Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_userCashAdvance
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub lbl_comaker_Click(sender As Object, e As EventArgs) Handles lbl_status.Click

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel") = vbYes Then
            frm_userMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim conn As New OleDbConnection(cs)

        'Values that are automatically filled into Textbox
        txt_dateToday.Text = Date.Today.ToString("MM/dd/yyyy") 'Date of today, converted into string and shown to textbox
        Dim CAStatus As String = "Pending"
        txt_status.Text = CAStatus.ToString() 'To show Pending on textbox

        Dim SelectData As String = "SELECT first_name, last_name, middle_initial, salary_level_id FROM employee WHERE employee_id=@EmpID"
        Dim cmdfetch As New OleDbCommand(SelectData, conn) 'To use the query SelectData, then, conn to connect to database

        conn.Open()

        cmdfetch.Parameters.AddWithValue("@EmpID", FetchEmpID.SavedEmpID) 'EmpID fetch rule
        Me.txt_employeeID.Text = FetchEmpID.SavedEmpID 'FetchEmpID is class with variable name SavedEmpID Imported from LogIn Form
        Dim reader As OleDbDataReader = cmdfetch.ExecuteReader() 'To read the database data

        If txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Then
            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
                txt_salaryLevel.Text += reader("salary_level_id").ToString()
            End While
        Else
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()
            txt_salaryLevel.Clear()

            While reader.Read() 'Automatic User data fetch rule
                'textbox.Text += reader("column name from database").ToString() <- to output to string
                txt_firstName.Text += reader("first_name").ToString()
                txt_lastName.Text += reader("last_name").ToString()
                txt_middleInitial.Text += reader("middle_initial").ToString()
                txt_salaryLevel.Text += reader("salary_level_id").ToString()
            End While
        End If

        conn.Close()

        MsgBox("Fill up carefully, no EDITS after SUBMIT", MsgBoxStyle.Exclamation) 'Pops-up after clicking addNew button

        'Minor action after clicking add new
        txt_amount.ReadOnly = False
        btn_new.Enabled = False
        btn_submit.Enabled = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim conn As New OleDbConnection(cs)

        Dim update As String = "INSERT INTO cash_advance ([employee_id], [salary_level_id], [cash_adv_status], [cash_adv_date], [cash_adv_amount]) VALUES (@EmpID, @SalLevel, @CashAdvStatus, @CashAdvDate, @CashAdvAmount)" 'database query

        If txt_dateToday.Text = Nothing Or txt_employeeID.Text = Nothing Or txt_salaryLevel.Text = Nothing Or txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Or txt_amount.Text = Nothing Then
            MsgBox("Enter the information on required fields.", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmpID", CType(txt_employeeID.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
            cmd.Parameters.Add(New OleDbParameter("SalLevel", CType(txt_salaryLevel.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("CashAdvStatus", CType(txt_status.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("CashAdvDate", CType(txt_dateToday.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("CashAdvAmount", CType(txt_amount.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()

            txt_dateToday.Clear()
            txt_employeeID.Clear()
            txt_salaryLevel.Clear()
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()
            txt_amount.Clear()

            'Minor action after submitting
            btn_submit.Enabled = False
            btn_new.Enabled = True

            MessageBox.Show("Form sent successfully!", "CONFIRMED", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub txt_amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        'Only allows number and dot for Amount Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub frm_userCashAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.cash_advance' table. You can move, or remove it, as needed.
        Me.Cash_advanceTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.cash_advance)

    End Sub
End Class