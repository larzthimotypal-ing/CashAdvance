<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_profile))
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.lbl_middleInitial = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_changePW = New System.Windows.Forms.Button()
        Me.txt_jobPos = New System.Windows.Forms.TextBox()
        Me.lbl_jobPos = New System.Windows.Forms.Label()
        Me.txt_monSalary = New System.Windows.Forms.TextBox()
        Me.lbl_monSalary = New System.Windows.Forms.Label()
        Me.dgv_salaryLoan = New System.Windows.Forms.DataGridView()
        Me.SalaryloanidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloanamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloandateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloanstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthstopayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalamounttopayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryloanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashadvancesalaryloanDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.Salary_loanTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter()
        Me.lbl_salaryLoan = New System.Windows.Forms.Label()
        Me.lbl_cashAdvance = New System.Windows.Forms.Label()
        Me.btn_SLsortLatest = New System.Windows.Forms.Button()
        Me.btn_SLsortApproved = New System.Windows.Forms.Button()
        Me.btn_CAsortApproved = New System.Windows.Forms.Button()
        Me.btn_CAsortLatest = New System.Windows.Forms.Button()
        Me.dgv_cashAdvance = New System.Windows.Forms.DataGridView()
        Me.CashadvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advanceTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter()
        CType(Me.dgv_salaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashadvancesalaryloanDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(9, 15)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 0
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(82, 13)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.ReadOnly = True
        Me.txt_employeeID.Size = New System.Drawing.Size(59, 20)
        Me.txt_employeeID.TabIndex = 1
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(82, 34)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.ReadOnly = True
        Me.txt_firstName.Size = New System.Drawing.Size(133, 20)
        Me.txt_firstName.TabIndex = 3
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(17, 37)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 2
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(82, 57)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(133, 20)
        Me.txt_lastName.TabIndex = 5
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(17, 59)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 4
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(82, 79)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(59, 20)
        Me.txt_middleInitial.TabIndex = 7
        '
        'lbl_middleInitial
        '
        Me.lbl_middleInitial.AutoSize = True
        Me.lbl_middleInitial.Location = New System.Drawing.Point(9, 81)
        Me.lbl_middleInitial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_middleInitial.Name = "lbl_middleInitial"
        Me.lbl_middleInitial.Size = New System.Drawing.Size(68, 13)
        Me.lbl_middleInitial.TabIndex = 6
        Me.lbl_middleInitial.Text = "Middle Initial:"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(292, 13)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(68, 20)
        Me.txt_password.TabIndex = 9
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(237, 15)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(56, 13)
        Me.lbl_password.TabIndex = 8
        Me.lbl_password.Text = "Password:"
        '
        'txt_department
        '
        Me.txt_department.Enabled = False
        Me.txt_department.Location = New System.Drawing.Point(292, 34)
        Me.txt_department.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.ReadOnly = True
        Me.txt_department.Size = New System.Drawing.Size(133, 20)
        Me.txt_department.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Department:"
        '
        'btn_changePW
        '
        Me.btn_changePW.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_changePW.Location = New System.Drawing.Point(363, 5)
        Me.btn_changePW.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_changePW.Name = "btn_changePW"
        Me.btn_changePW.Size = New System.Drawing.Size(61, 26)
        Me.btn_changePW.TabIndex = 12
        Me.btn_changePW.Text = "Change"
        Me.btn_changePW.UseVisualStyleBackColor = False
        '
        'txt_jobPos
        '
        Me.txt_jobPos.Enabled = False
        Me.txt_jobPos.Location = New System.Drawing.Point(292, 59)
        Me.txt_jobPos.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jobPos.Name = "txt_jobPos"
        Me.txt_jobPos.ReadOnly = True
        Me.txt_jobPos.Size = New System.Drawing.Size(133, 20)
        Me.txt_jobPos.TabIndex = 14
        '
        'lbl_jobPos
        '
        Me.lbl_jobPos.AutoSize = True
        Me.lbl_jobPos.Location = New System.Drawing.Point(227, 62)
        Me.lbl_jobPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_jobPos.Name = "lbl_jobPos"
        Me.lbl_jobPos.Size = New System.Drawing.Size(67, 13)
        Me.lbl_jobPos.TabIndex = 13
        Me.lbl_jobPos.Text = "Job Position:"
        '
        'txt_monSalary
        '
        Me.txt_monSalary.Enabled = False
        Me.txt_monSalary.Location = New System.Drawing.Point(292, 82)
        Me.txt_monSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_monSalary.Name = "txt_monSalary"
        Me.txt_monSalary.ReadOnly = True
        Me.txt_monSalary.Size = New System.Drawing.Size(133, 20)
        Me.txt_monSalary.TabIndex = 16
        '
        'lbl_monSalary
        '
        Me.lbl_monSalary.AutoSize = True
        Me.lbl_monSalary.Location = New System.Drawing.Point(213, 84)
        Me.lbl_monSalary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_monSalary.Name = "lbl_monSalary"
        Me.lbl_monSalary.Size = New System.Drawing.Size(79, 13)
        Me.lbl_monSalary.TabIndex = 15
        Me.lbl_monSalary.Text = "Monthly Salary:"
        '
        'dgv_salaryLoan
        '
        Me.dgv_salaryLoan.AutoGenerateColumns = False
        Me.dgv_salaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_salaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalaryloanidDataGridViewTextBoxColumn, Me.SalloanamountDataGridViewTextBoxColumn, Me.SalloandateDataGridViewTextBoxColumn, Me.ComakerDataGridViewTextBoxColumn, Me.SalloanstatusDataGridViewTextBoxColumn, Me.MonthstopayDataGridViewTextBoxColumn, Me.MonthlypaywithinterestDataGridViewTextBoxColumn, Me.TotalamounttopayDataGridViewTextBoxColumn})
        Me.dgv_salaryLoan.DataSource = Me.SalaryloanBindingSource
        Me.dgv_salaryLoan.Location = New System.Drawing.Point(22, 154)
        Me.dgv_salaryLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_salaryLoan.Name = "dgv_salaryLoan"
        Me.dgv_salaryLoan.RowHeadersWidth = 51
        Me.dgv_salaryLoan.RowTemplate.Height = 24
        Me.dgv_salaryLoan.Size = New System.Drawing.Size(790, 228)
        Me.dgv_salaryLoan.TabIndex = 17
        '
        'SalaryloanidDataGridViewTextBoxColumn
        '
        Me.SalaryloanidDataGridViewTextBoxColumn.DataPropertyName = "salary_loan_id"
        Me.SalaryloanidDataGridViewTextBoxColumn.HeaderText = "Reference ID"
        Me.SalaryloanidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryloanidDataGridViewTextBoxColumn.Name = "SalaryloanidDataGridViewTextBoxColumn"
        Me.SalaryloanidDataGridViewTextBoxColumn.Width = 125
        '
        'SalloanamountDataGridViewTextBoxColumn
        '
        Me.SalloanamountDataGridViewTextBoxColumn.DataPropertyName = "sal_loan_amount"
        Me.SalloanamountDataGridViewTextBoxColumn.HeaderText = "Loan Amount"
        Me.SalloanamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalloanamountDataGridViewTextBoxColumn.Name = "SalloanamountDataGridViewTextBoxColumn"
        Me.SalloanamountDataGridViewTextBoxColumn.Width = 125
        '
        'SalloandateDataGridViewTextBoxColumn
        '
        Me.SalloandateDataGridViewTextBoxColumn.DataPropertyName = "sal_loan_date"
        Me.SalloandateDataGridViewTextBoxColumn.HeaderText = "Loan Date"
        Me.SalloandateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalloandateDataGridViewTextBoxColumn.Name = "SalloandateDataGridViewTextBoxColumn"
        Me.SalloandateDataGridViewTextBoxColumn.Width = 125
        '
        'ComakerDataGridViewTextBoxColumn
        '
        Me.ComakerDataGridViewTextBoxColumn.DataPropertyName = "comaker"
        Me.ComakerDataGridViewTextBoxColumn.HeaderText = "Comaker"
        Me.ComakerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComakerDataGridViewTextBoxColumn.Name = "ComakerDataGridViewTextBoxColumn"
        Me.ComakerDataGridViewTextBoxColumn.Width = 125
        '
        'SalloanstatusDataGridViewTextBoxColumn
        '
        Me.SalloanstatusDataGridViewTextBoxColumn.DataPropertyName = "sal_loan_status"
        Me.SalloanstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.SalloanstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalloanstatusDataGridViewTextBoxColumn.Name = "SalloanstatusDataGridViewTextBoxColumn"
        Me.SalloanstatusDataGridViewTextBoxColumn.Width = 125
        '
        'MonthstopayDataGridViewTextBoxColumn
        '
        Me.MonthstopayDataGridViewTextBoxColumn.DataPropertyName = "months_to_pay"
        Me.MonthstopayDataGridViewTextBoxColumn.HeaderText = "Months to pay"
        Me.MonthstopayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonthstopayDataGridViewTextBoxColumn.Name = "MonthstopayDataGridViewTextBoxColumn"
        Me.MonthstopayDataGridViewTextBoxColumn.Width = 125
        '
        'MonthlypaywithinterestDataGridViewTextBoxColumn
        '
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn.DataPropertyName = "monthly_pay_with_interest"
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn.HeaderText = "Monthly Balance"
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn.Name = "MonthlypaywithinterestDataGridViewTextBoxColumn"
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn.Width = 125
        '
        'TotalamounttopayDataGridViewTextBoxColumn
        '
        Me.TotalamounttopayDataGridViewTextBoxColumn.DataPropertyName = "total_amount_to_pay"
        Me.TotalamounttopayDataGridViewTextBoxColumn.HeaderText = "Total Balance"
        Me.TotalamounttopayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalamounttopayDataGridViewTextBoxColumn.Name = "TotalamounttopayDataGridViewTextBoxColumn"
        Me.TotalamounttopayDataGridViewTextBoxColumn.Width = 125
        '
        'SalaryloanBindingSource
        '
        Me.SalaryloanBindingSource.DataMember = "salary_loan"
        Me.SalaryloanBindingSource.DataSource = Me.CashadvancesalaryloanDataSetBindingSource
        '
        'CashadvancesalaryloanDataSetBindingSource
        '
        Me.CashadvancesalaryloanDataSetBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        Me.CashadvancesalaryloanDataSetBindingSource.Position = 0
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Salary_loanTableAdapter
        '
        Me.Salary_loanTableAdapter.ClearBeforeFill = True
        '
        'lbl_salaryLoan
        '
        Me.lbl_salaryLoan.AutoSize = True
        Me.lbl_salaryLoan.Location = New System.Drawing.Point(20, 130)
        Me.lbl_salaryLoan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_salaryLoan.Name = "lbl_salaryLoan"
        Me.lbl_salaryLoan.Size = New System.Drawing.Size(63, 13)
        Me.lbl_salaryLoan.TabIndex = 18
        Me.lbl_salaryLoan.Text = "Salary Loan"
        '
        'lbl_cashAdvance
        '
        Me.lbl_cashAdvance.AutoSize = True
        Me.lbl_cashAdvance.Location = New System.Drawing.Point(20, 403)
        Me.lbl_cashAdvance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cashAdvance.Name = "lbl_cashAdvance"
        Me.lbl_cashAdvance.Size = New System.Drawing.Size(77, 13)
        Me.lbl_cashAdvance.TabIndex = 19
        Me.lbl_cashAdvance.Text = "Cash Advance"
        '
        'btn_SLsortLatest
        '
        Me.btn_SLsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_SLsortLatest.Location = New System.Drawing.Point(103, 125)
        Me.btn_SLsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_SLsortLatest.Name = "btn_SLsortLatest"
        Me.btn_SLsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_SLsortLatest.TabIndex = 20
        Me.btn_SLsortLatest.Text = "Sort Latest"
        Me.btn_SLsortLatest.UseVisualStyleBackColor = False
        '
        'btn_SLsortApproved
        '
        Me.btn_SLsortApproved.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_SLsortApproved.Location = New System.Drawing.Point(208, 125)
        Me.btn_SLsortApproved.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_SLsortApproved.Name = "btn_SLsortApproved"
        Me.btn_SLsortApproved.Size = New System.Drawing.Size(101, 24)
        Me.btn_SLsortApproved.TabIndex = 21
        Me.btn_SLsortApproved.Text = "Sort Approved"
        Me.btn_SLsortApproved.UseVisualStyleBackColor = False
        '
        'btn_CAsortApproved
        '
        Me.btn_CAsortApproved.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_CAsortApproved.Location = New System.Drawing.Point(208, 397)
        Me.btn_CAsortApproved.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CAsortApproved.Name = "btn_CAsortApproved"
        Me.btn_CAsortApproved.Size = New System.Drawing.Size(101, 24)
        Me.btn_CAsortApproved.TabIndex = 23
        Me.btn_CAsortApproved.Text = "Sort Approved"
        Me.btn_CAsortApproved.UseVisualStyleBackColor = False
        '
        'btn_CAsortLatest
        '
        Me.btn_CAsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_CAsortLatest.Location = New System.Drawing.Point(103, 397)
        Me.btn_CAsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_CAsortLatest.Name = "btn_CAsortLatest"
        Me.btn_CAsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_CAsortLatest.TabIndex = 22
        Me.btn_CAsortLatest.Text = "Sort Latest"
        Me.btn_CAsortLatest.UseVisualStyleBackColor = False
        '
        'dgv_cashAdvance
        '
        Me.dgv_cashAdvance.AutoGenerateColumns = False
        Me.dgv_cashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CashadvidDataGridViewTextBoxColumn, Me.CashadvamountDataGridViewTextBoxColumn, Me.CashadvdateDataGridViewTextBoxColumn, Me.CashadvstatusDataGridViewTextBoxColumn})
        Me.dgv_cashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_cashAdvance.Location = New System.Drawing.Point(22, 427)
        Me.dgv_cashAdvance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_cashAdvance.Name = "dgv_cashAdvance"
        Me.dgv_cashAdvance.RowHeadersWidth = 51
        Me.dgv_cashAdvance.RowTemplate.Height = 24
        Me.dgv_cashAdvance.Size = New System.Drawing.Size(415, 222)
        Me.dgv_cashAdvance.TabIndex = 24
        '
        'CashadvidDataGridViewTextBoxColumn
        '
        Me.CashadvidDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_id"
        Me.CashadvidDataGridViewTextBoxColumn.HeaderText = "Reference ID"
        Me.CashadvidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvidDataGridViewTextBoxColumn.Name = "CashadvidDataGridViewTextBoxColumn"
        Me.CashadvidDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvamountDataGridViewTextBoxColumn
        '
        Me.CashadvamountDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_amount"
        Me.CashadvamountDataGridViewTextBoxColumn.HeaderText = "Loan Amount"
        Me.CashadvamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvamountDataGridViewTextBoxColumn.Name = "CashadvamountDataGridViewTextBoxColumn"
        Me.CashadvamountDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvdateDataGridViewTextBoxColumn
        '
        Me.CashadvdateDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_date"
        Me.CashadvdateDataGridViewTextBoxColumn.HeaderText = "Loan Date"
        Me.CashadvdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvdateDataGridViewTextBoxColumn.Name = "CashadvdateDataGridViewTextBoxColumn"
        Me.CashadvdateDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvstatusDataGridViewTextBoxColumn
        '
        Me.CashadvstatusDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_status"
        Me.CashadvstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.CashadvstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvstatusDataGridViewTextBoxColumn.Name = "CashadvstatusDataGridViewTextBoxColumn"
        Me.CashadvstatusDataGridViewTextBoxColumn.Width = 125
        '
        'CashadvanceBindingSource
        '
        Me.CashadvanceBindingSource.DataMember = "cash_advance"
        Me.CashadvanceBindingSource.DataSource = Me.CashadvancesalaryloanDataSetBindingSource
        '
        'Cash_advanceTableAdapter
        '
        Me.Cash_advanceTableAdapter.ClearBeforeFill = True
        '
        'frm_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(838, 609)
        Me.Controls.Add(Me.dgv_cashAdvance)
        Me.Controls.Add(Me.btn_CAsortApproved)
        Me.Controls.Add(Me.btn_CAsortLatest)
        Me.Controls.Add(Me.btn_SLsortApproved)
        Me.Controls.Add(Me.btn_SLsortLatest)
        Me.Controls.Add(Me.lbl_cashAdvance)
        Me.Controls.Add(Me.lbl_salaryLoan)
        Me.Controls.Add(Me.dgv_salaryLoan)
        Me.Controls.Add(Me.txt_monSalary)
        Me.Controls.Add(Me.lbl_monSalary)
        Me.Controls.Add(Me.txt_jobPos)
        Me.Controls.Add(Me.lbl_jobPos)
        Me.Controls.Add(Me.btn_changePW)
        Me.Controls.Add(Me.txt_department)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.lbl_middleInitial)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_profile"
        Me.Text = "Profile"
        CType(Me.dgv_salaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashadvancesalaryloanDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents lbl_middleInitial As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_department As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_changePW As Button
    Friend WithEvents txt_jobPos As TextBox
    Friend WithEvents lbl_jobPos As Label
    Friend WithEvents txt_monSalary As TextBox
    Friend WithEvents lbl_monSalary As Label
    Friend WithEvents dgv_salaryLoan As DataGridView
    Friend WithEvents CashadvancesalaryloanDataSetBindingSource As BindingSource
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents SalaryloanBindingSource As BindingSource
    Friend WithEvents Salary_loanTableAdapter As cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter
    Friend WithEvents SalaryloanidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloanamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloandateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComakerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloanstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthstopayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlypaywithinterestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalamounttopayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_salaryLoan As Label
    Friend WithEvents lbl_cashAdvance As Label
    Friend WithEvents btn_SLsortLatest As Button
    Friend WithEvents btn_SLsortApproved As Button
    Friend WithEvents btn_CAsortApproved As Button
    Friend WithEvents btn_CAsortLatest As Button
    Friend WithEvents dgv_cashAdvance As DataGridView
    Friend WithEvents CashadvanceBindingSource As BindingSource
    Friend WithEvents Cash_advanceTableAdapter As cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter
    Friend WithEvents CashadvidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
