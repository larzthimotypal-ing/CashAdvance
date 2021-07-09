Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_userSalaryLoan
    Dim connection As New Connection
    Dim cs As String = connection.connectionString

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo, "Cancel") = vbYes Then
            frm_userMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim conn As New OleDbConnection(cs)

        Me.Salary_loanTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.salary_loan)
        Me.EmployeeTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.employee)
        SalaryloanBindingSource.AddNew() 'Bind source from database and trigger when to start adding data

        'Values that are automatically filled into Textbox
        txt_dateToday.Text = Date.Today.ToString("MM/dd/yyyy") 'Date of today, converted into string and shown to textbox
        Dim SLStatus As String = "Pending"
        txt_status.Text = SLStatus.ToString() 'To show Pending on textbox

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

        Dim update As String = "INSERT INTO salary_loan ([employee_id], [salary_level_id], [sal_loan_amount], [sal_loan_date], [comaker], [sal_loan_status], [months_to_pay], [monthly_pay_with_interest], [total_amount_to_pay]) VALUES (@EmpID, @SalLevel, @SalLoanAmt, @SalLoanDate, @Comaker, @SalLoanStatus, @MosToPay, @MonthlyPayment, @TotAmount)" 'database query

        If txt_dateToday.Text = Nothing Or txt_employeeID.Text = Nothing Or txt_salaryLevel.Text = Nothing Or txt_firstName.Text = Nothing Or txt_lastName.Text = Nothing Or txt_middleInitial.Text = Nothing Or txt_amount.Text = Nothing Or txt_mosToPay.Text = Nothing Or txt_monthlyBal.Text = Nothing Or txt_totBal.Text = Nothing Or txt_comaker.Text = Nothing Then
            MsgBox("Enter the information on required fields.", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmpID", CType(txt_employeeID.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
            cmd.Parameters.Add(New OleDbParameter("SalLevel", CType(txt_salaryLevel.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("SalLoanAmt", CType(txt_amount.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("SalLoanDate", CType(txt_dateToday.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Comaker", CType(txt_comaker.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("SalLoanStatus", CType(txt_status.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("MosToPay", CType(txt_mosToPay.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("MonthlyPayment", CType(txt_monthlyBal.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("TotAmount", CType(txt_totBal.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()

            txt_dateToday.Clear()
            txt_employeeID.Clear()
            txt_salaryLevel.Clear()
            txt_firstName.Clear()
            txt_lastName.Clear()
            txt_middleInitial.Clear()
            txt_amount.Clear()
            txt_mosToPay.Clear()
            txt_monthlyBal.Clear()
            txt_totBal.Clear()
            txt_comaker.Clear()

            'Minor action after submitting
            btn_submit.Enabled = False
            btn_new.Enabled = True

            MessageBox.Show("Form sent successfully!", "CONFIRMED", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub txt_mosToPay_TextChanged(sender As Object, e As EventArgs) Handles txt_mosToPay.TextChanged
        Dim BaseAmount As Double
        Dim Interest As Double = "40"
        Dim Month As Double
        Dim MonthlyBal As Double

        'Conversion of String to Double and assigning variable to textbox
        Double.TryParse(txt_amount.Text, BaseAmount)
        Double.TryParse(txt_monthlyBal.Text, MonthlyBal)
        Double.TryParse(txt_mosToPay.Text, Month)

        'After filling up Amount Textbox, it gets disabled
        If BaseAmount = "0" Then
            txt_amount.ReadOnly = False
        Else
            txt_amount.ReadOnly = True
        End If

        'Limiter for Months to pay
        If Month > 15 Then
            MsgBox("15 months max only", MsgBoxStyle.Exclamation)
            txt_mosToPay.Clear()
        End If

        'The monthly amount to pay
        txt_monthlyBal.Text = (BaseAmount + (BaseAmount * (Month / Interest))) / Month
        'The Total balance including the Interest
        txt_totBal.Text = BaseAmount + (BaseAmount * (Month / Interest))
    End Sub

    Private Sub txt_mosToPay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mosToPay.KeyPress
        'Only allows number and dot for MosToPay Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        'Only allows number and dot for Amount Textbox
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_comaker_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_comaker.KeyPress
        'Only allows letters and dot for CoMaker Textbox
        If Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_userSalaryLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class