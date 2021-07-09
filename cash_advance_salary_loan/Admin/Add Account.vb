Imports cash_advance_salary_loan.frm_login
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class frm_accountManage
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub frm_accountManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.identity' table. You can move, or remove it, as needed.
        Me.IdentityTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.identity)
        'TODO: This line of code loads data into the 'Cash_advance_salary_loanDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Cash_advance_salary_loanDataSet.employee)

        'To update datagrid after CRUD
        Dim conn As New OleDbConnection(cs)
        dgv_loginList.DataSource = Nothing
        dgv_loginList.Refresh()

        Dim strLogin As String = "SELECT * FROM [identity]"
        Using cmdLogin As New OleDb.OleDbCommand(strLogin, conn)
            Using daLogin As New OleDbDataAdapter(cmdLogin)
                Using newtableLogin As New DataTable
                    daLogin.Fill(newtableLogin)
                    dgv_loginList.DataSource = newtableLogin
                End Using
            End Using
        End Using

        dgv_employeeList.DataSource = Nothing
        dgv_employeeList.Refresh()

        Dim strEmployee As String = "SELECT * FROM employee"
        Using cmdEmployee As New OleDb.OleDbCommand(strEmployee, conn)
            Using daEmployee As New OleDbDataAdapter(cmdEmployee)
                Using newtableEmployee As New DataTable
                    daEmployee.Fill(newtableEmployee)
                    dgv_employeeList.DataSource = newtableEmployee
                End Using
            End Using
        End Using

    End Sub

    Private Sub dgv_loginList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_loginList.CellClick
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        txt_modifyPassword.Enabled = True
        cmb_modifyUserType.Enabled = True
        btn_edit.Enabled = True
        btn_delete.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_loginList.CurrentRow.Index
        Me.txt_identityID.Text = dgv_loginList.Item(0, i).Value
        Me.txt_employeeID.Text = dgv_loginList.Item(1, i).Value
        Me.txt_modifyPassword.Text = dgv_loginList.Item(2, i).Value 'Password Column is hidden but existing (Click arrow icon on dgv to see)
        Me.cmb_modifyUserType.Text = dgv_loginList.Item(3, i).Value
    End Sub

    Private Sub dgv_employeeList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_employeeList.CellClick
        'Another fetch to textbox which will not be used for submitting or updating on database
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Enables button upon clicking a cell data
        txt_modifyPassword.Enabled = True
        cmb_modifyUserType.Enabled = True
        btn_edit.Enabled = True
        btn_delete.Enabled = True

        'Fetch the cell data to textbox value
        i = dgv_employeeList.CurrentRow.Index
        Me.txt_employeeID.Text = dgv_employeeList.Item(0, i).Value
        Me.txt_firstName.Text = dgv_employeeList.Item(1, i).Value
        Me.txt_lastName.Text = dgv_employeeList.Item(2, i).Value
        Me.txt_middleInitial.Text = dgv_employeeList.Item(3, i).Value

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE [identity] SET [password]=@Password, usertype=@UserType WHERE identity_id=@LoginID" 'database query
        'Password is inside [] because its a default entity within the language

        If txt_modifyPassword.Text = Nothing Or cmb_modifyUserType.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        ElseIf cmb_modifyUserType.Text = "Admin" Or cmb_modifyUserType.Text = "Head" Or cmb_modifyUserType.Text = "User" Then
            cmb_modifyUserType.Enabled = True
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            cmd.Parameters.AddWithValue("@Password", txt_modifyPassword.Text) 'Gives a parameter for database column name
            cmd.Parameters.AddWithValue("@UserType", cmb_modifyUserType.Text)
            cmd.Parameters.AddWithValue("@LoginID", txt_identityID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Login Info?", "Edit Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_accountManage_Load(e, e) 'Reloads the Form
            Refresh()
        End If
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO [identity] ([employee_id], [password], [usertype]) VALUES (@EmpID, @Password, @UserType)" 'database query

        If txt_addPassword.Text = Nothing Or cmb_addUserType.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmpID", CType(txt_employeeID.Text, String))) 'Is a OleDbParamter + Ctype because you need to insert data
            cmd.Parameters.Add(New OleDbParameter("[Password]", CType(txt_addPassword.Text, String))) 'Password is inside [] because its a default entity within the language
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(cmb_addUserType.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Employee to Login?", "Add Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frm_accountManage_Load(e, e) 'Reloads the Form
            Refresh()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "DELETE FROM [identity] WHERE identity_id=@LoginID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@LoginID", txt_identityID.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Are you sure to delete?", "Delete Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_accountManage_Load(e, e) 'Reloads the Form
        Refresh()
    End Sub

    Private Sub dgv_loginList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_loginList.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_loginList.Rows
            row.DefaultCellStyle.BackColor = Color.LightYellow
        Next

    End Sub

    Private Sub dgv_employeeList_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_employeeList.CellFormatting
        'Changes the color depending on the status
        For Each row As DataGridViewRow In dgv_employeeList.Rows
            row.DefaultCellStyle.BackColor = Color.LightYellow
        Next
    End Sub

    Private Sub cmb_addUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_addUserType.SelectedIndexChanged
        'If expression to enable submit button
        If cmb_addUserType.Text = "Admin" Or cmb_addUserType.Text = "Head" Or cmb_addUserType.Text = "User" Then
            btn_Add.Enabled = True
        End If
    End Sub

    Private Sub frm_accountManage_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class