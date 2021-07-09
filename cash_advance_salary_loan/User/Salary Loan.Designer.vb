<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userSalaryLoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_userSalaryLoan))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.grpbox_input = New System.Windows.Forms.GroupBox()
        Me.txt_comaker = New System.Windows.Forms.TextBox()
        Me.SalaryloanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_mosToPay = New System.Windows.Forms.TextBox()
        Me.lbl_mosToPay = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.lbl_middleInitial = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_salaryLevel = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_salaryLevel = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_dateToday = New System.Windows.Forms.TextBox()
        Me.lbl_dateToday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_totBal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_monthlyBal = New System.Windows.Forms.TextBox()
        Me.lbl_monthlyBal = New System.Windows.Forms.Label()
        Me.Salary_loanTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter()
        Me.EmployeeTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter()
        Me.lbl_interest = New System.Windows.Forms.Label()
        Me.grpbox_input.SuspendLayout()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_cancel.Location = New System.Drawing.Point(371, 185)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 29)
        Me.btn_cancel.TabIndex = 44
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_submit.Location = New System.Drawing.Point(122, 185)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(72, 29)
        Me.btn_submit.TabIndex = 43
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_new.Location = New System.Drawing.Point(8, 185)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(72, 29)
        Me.btn_new.TabIndex = 42
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'grpbox_input
        '
        Me.grpbox_input.Controls.Add(Me.txt_comaker)
        Me.grpbox_input.Controls.Add(Me.Label2)
        Me.grpbox_input.Controls.Add(Me.txt_mosToPay)
        Me.grpbox_input.Controls.Add(Me.lbl_mosToPay)
        Me.grpbox_input.Controls.Add(Me.txt_amount)
        Me.grpbox_input.Controls.Add(Me.lbl_amount)
        Me.grpbox_input.Location = New System.Drawing.Point(9, 73)
        Me.grpbox_input.Margin = New System.Windows.Forms.Padding(2)
        Me.grpbox_input.Name = "grpbox_input"
        Me.grpbox_input.Padding = New System.Windows.Forms.Padding(2)
        Me.grpbox_input.Size = New System.Drawing.Size(212, 98)
        Me.grpbox_input.TabIndex = 41
        Me.grpbox_input.TabStop = False
        Me.grpbox_input.Text = "Input"
        '
        'txt_comaker
        '
        Me.txt_comaker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "comaker", True))
        Me.txt_comaker.Location = New System.Drawing.Point(91, 67)
        Me.txt_comaker.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_comaker.Name = "txt_comaker"
        Me.txt_comaker.Size = New System.Drawing.Size(111, 20)
        Me.txt_comaker.TabIndex = 21
        '
        'SalaryloanBindingSource
        '
        Me.SalaryloanBindingSource.DataMember = "salary_loan"
        Me.SalaryloanBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Comaker"
        '
        'txt_mosToPay
        '
        Me.txt_mosToPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "months_to_pay", True))
        Me.txt_mosToPay.Location = New System.Drawing.Point(91, 45)
        Me.txt_mosToPay.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mosToPay.Name = "txt_mosToPay"
        Me.txt_mosToPay.Size = New System.Drawing.Size(111, 20)
        Me.txt_mosToPay.TabIndex = 19
        '
        'lbl_mosToPay
        '
        Me.lbl_mosToPay.AutoSize = True
        Me.lbl_mosToPay.Location = New System.Drawing.Point(26, 47)
        Me.lbl_mosToPay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mosToPay.Name = "lbl_mosToPay"
        Me.lbl_mosToPay.Size = New System.Drawing.Size(62, 13)
        Me.lbl_mosToPay.TabIndex = 18
        Me.lbl_mosToPay.Text = "Mos to pay:"
        '
        'txt_amount
        '
        Me.txt_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "sal_loan_amount", True))
        Me.txt_amount.Location = New System.Drawing.Point(91, 24)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(111, 20)
        Me.txt_amount.TabIndex = 15
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(41, 24)
        Me.lbl_amount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(46, 13)
        Me.lbl_amount.TabIndex = 14
        Me.lbl_amount.Text = "Amount:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(278, 50)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.Size = New System.Drawing.Size(43, 20)
        Me.txt_middleInitial.TabIndex = 40
        '
        'lbl_middleInitial
        '
        Me.lbl_middleInitial.AutoSize = True
        Me.lbl_middleInitial.Location = New System.Drawing.Point(206, 54)
        Me.lbl_middleInitial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_middleInitial.Name = "lbl_middleInitial"
        Me.lbl_middleInitial.Size = New System.Drawing.Size(68, 13)
        Me.lbl_middleInitial.TabIndex = 39
        Me.lbl_middleInitial.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(278, 28)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(111, 20)
        Me.txt_lastName.TabIndex = 38
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(213, 30)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 37
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(278, 5)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(111, 20)
        Me.txt_firstName.TabIndex = 36
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(213, 7)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 35
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_salaryLevel
        '
        Me.txt_salaryLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "salary_level_id", True))
        Me.txt_salaryLevel.Enabled = False
        Me.txt_salaryLevel.Location = New System.Drawing.Point(91, 50)
        Me.txt_salaryLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_salaryLevel.Name = "txt_salaryLevel"
        Me.txt_salaryLevel.Size = New System.Drawing.Size(111, 20)
        Me.txt_salaryLevel.TabIndex = 34
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'lbl_salaryLevel
        '
        Me.lbl_salaryLevel.AutoSize = True
        Me.lbl_salaryLevel.Location = New System.Drawing.Point(19, 53)
        Me.lbl_salaryLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_salaryLevel.Name = "lbl_salaryLevel"
        Me.lbl_salaryLevel.Size = New System.Drawing.Size(68, 13)
        Me.lbl_salaryLevel.TabIndex = 33
        Me.lbl_salaryLevel.Text = "Salary Level:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "employee_id", True))
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(91, 5)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(43, 20)
        Me.txt_employeeID.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Employee ID:"
        '
        'txt_dateToday
        '
        Me.txt_dateToday.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "sal_loan_date", True))
        Me.txt_dateToday.Enabled = False
        Me.txt_dateToday.Location = New System.Drawing.Point(91, 28)
        Me.txt_dateToday.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_dateToday.Name = "txt_dateToday"
        Me.txt_dateToday.Size = New System.Drawing.Size(111, 20)
        Me.txt_dateToday.TabIndex = 30
        '
        'lbl_dateToday
        '
        Me.lbl_dateToday.AutoSize = True
        Me.lbl_dateToday.Location = New System.Drawing.Point(22, 30)
        Me.lbl_dateToday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_dateToday.Name = "lbl_dateToday"
        Me.lbl_dateToday.Size = New System.Drawing.Size(66, 13)
        Me.lbl_dateToday.TabIndex = 29
        Me.lbl_dateToday.Text = "Date Today:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_totBal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_monthlyBal)
        Me.GroupBox1.Controls.Add(Me.lbl_monthlyBal)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(212, 98)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computation"
        '
        'txt_status
        '
        Me.txt_status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "sal_loan_status", True))
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(91, 67)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(111, 20)
        Me.txt_status.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Status:"
        '
        'txt_totBal
        '
        Me.txt_totBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "total_amount_to_pay", True))
        Me.txt_totBal.Enabled = False
        Me.txt_totBal.Location = New System.Drawing.Point(91, 45)
        Me.txt_totBal.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_totBal.Name = "txt_totBal"
        Me.txt_totBal.Size = New System.Drawing.Size(111, 20)
        Me.txt_totBal.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total Balance:"
        '
        'txt_monthlyBal
        '
        Me.txt_monthlyBal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalaryloanBindingSource, "monthly_pay_with_interest", True))
        Me.txt_monthlyBal.Enabled = False
        Me.txt_monthlyBal.Location = New System.Drawing.Point(91, 22)
        Me.txt_monthlyBal.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_monthlyBal.Name = "txt_monthlyBal"
        Me.txt_monthlyBal.Size = New System.Drawing.Size(111, 20)
        Me.txt_monthlyBal.TabIndex = 15
        '
        'lbl_monthlyBal
        '
        Me.lbl_monthlyBal.AutoSize = True
        Me.lbl_monthlyBal.Location = New System.Drawing.Point(4, 24)
        Me.lbl_monthlyBal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_monthlyBal.Name = "lbl_monthlyBal"
        Me.lbl_monthlyBal.Size = New System.Drawing.Size(89, 13)
        Me.lbl_monthlyBal.TabIndex = 14
        Me.lbl_monthlyBal.Text = "Monthly Balance:"
        '
        'Salary_loanTableAdapter
        '
        Me.Salary_loanTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lbl_interest
        '
        Me.lbl_interest.AutoSize = True
        Me.lbl_interest.Location = New System.Drawing.Point(124, 171)
        Me.lbl_interest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_interest.Name = "lbl_interest"
        Me.lbl_interest.Size = New System.Drawing.Size(67, 13)
        Me.lbl_interest.TabIndex = 45
        Me.lbl_interest.Text = "2.5% interest"
        '
        'frm_userSalaryLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(458, 228)
        Me.Controls.Add(Me.lbl_interest)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.grpbox_input)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.lbl_middleInitial)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_salaryLevel)
        Me.Controls.Add(Me.lbl_salaryLevel)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_dateToday)
        Me.Controls.Add(Me.lbl_dateToday)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_userSalaryLoan"
        Me.Text = "Salary Loan"
        Me.grpbox_input.ResumeLayout(False)
        Me.grpbox_input.PerformLayout()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents grpbox_input As GroupBox
    Friend WithEvents txt_mosToPay As TextBox
    Friend WithEvents lbl_mosToPay As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents lbl_amount As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents lbl_middleInitial As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_salaryLevel As TextBox
    Friend WithEvents lbl_salaryLevel As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_dateToday As TextBox
    Friend WithEvents lbl_dateToday As Label
    Friend WithEvents txt_comaker As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_totBal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_monthlyBal As TextBox
    Friend WithEvents lbl_monthlyBal As Label
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents SalaryloanBindingSource As BindingSource
    Friend WithEvents Salary_loanTableAdapter As cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents lbl_interest As Label
End Class
