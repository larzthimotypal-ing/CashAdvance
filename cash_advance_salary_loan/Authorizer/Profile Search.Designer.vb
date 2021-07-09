<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profileSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_profileSearch))
        Me.CashadvdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cashAdvanceSortLatest = New System.Windows.Forms.Button()
        Me.lbl_cashAdvance = New System.Windows.Forms.Label()
        Me.CashadvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.Cash_advanceTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter()
        Me.dgv_cashAdvance = New System.Windows.Forms.DataGridView()
        Me.CashadvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_salaryLoan = New System.Windows.Forms.DataGridView()
        Me.SalaryloanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salary_loanTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter()
        Me.btn_salaryLoanSortLatest = New System.Windows.Forms.Button()
        Me.lbl_salaryLoan = New System.Windows.Forms.Label()
        Me.txt_monSalary = New System.Windows.Forms.TextBox()
        Me.lbl_monSalary = New System.Windows.Forms.Label()
        Me.txt_jobPos = New System.Windows.Forms.TextBox()
        Me.lbl_jobPos = New System.Windows.Forms.Label()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.lbl_middleInitial = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.lbl_notice = New System.Windows.Forms.Label()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_salaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CashadvdateDataGridViewTextBoxColumn
        '
        Me.CashadvdateDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_date"
        Me.CashadvdateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.CashadvdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvdateDataGridViewTextBoxColumn.Name = "CashadvdateDataGridViewTextBoxColumn"
        Me.CashadvdateDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "salary_loan_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sal_loan_amount"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "comaker"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comaker"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "months_to_pay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Months to pay"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "monthly_pay_with_interest"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monthly Balance"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total_amount_to_pay"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "sal_loan_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "sal_loan_status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'btn_cashAdvanceSortLatest
        '
        Me.btn_cashAdvanceSortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_cashAdvanceSortLatest.Location = New System.Drawing.Point(95, 337)
        Me.btn_cashAdvanceSortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cashAdvanceSortLatest.Name = "btn_cashAdvanceSortLatest"
        Me.btn_cashAdvanceSortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_cashAdvanceSortLatest.TabIndex = 58
        Me.btn_cashAdvanceSortLatest.Text = "Sort Latest"
        Me.btn_cashAdvanceSortLatest.UseVisualStyleBackColor = False
        '
        'lbl_cashAdvance
        '
        Me.lbl_cashAdvance.AutoSize = True
        Me.lbl_cashAdvance.Location = New System.Drawing.Point(6, 343)
        Me.lbl_cashAdvance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cashAdvance.Name = "lbl_cashAdvance"
        Me.lbl_cashAdvance.Size = New System.Drawing.Size(80, 13)
        Me.lbl_cashAdvance.TabIndex = 57
        Me.lbl_cashAdvance.Text = "Cash Advance:"
        '
        'CashadvanceBindingSource
        '
        Me.CashadvanceBindingSource.DataMember = "cash_advance"
        Me.CashadvanceBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cash_advanceTableAdapter
        '
        Me.Cash_advanceTableAdapter.ClearBeforeFill = True
        '
        'dgv_cashAdvance
        '
        Me.dgv_cashAdvance.AutoGenerateColumns = False
        Me.dgv_cashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CashadvidDataGridViewTextBoxColumn, Me.CashadvamountDataGridViewTextBoxColumn, Me.CashadvdateDataGridViewTextBoxColumn, Me.CashadvstatusDataGridViewTextBoxColumn})
        Me.dgv_cashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_cashAdvance.Location = New System.Drawing.Point(10, 366)
        Me.dgv_cashAdvance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_cashAdvance.Name = "dgv_cashAdvance"
        Me.dgv_cashAdvance.RowHeadersWidth = 51
        Me.dgv_cashAdvance.RowTemplate.Height = 24
        Me.dgv_cashAdvance.Size = New System.Drawing.Size(416, 196)
        Me.dgv_cashAdvance.TabIndex = 59
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
        'CashadvstatusDataGridViewTextBoxColumn
        '
        Me.CashadvstatusDataGridViewTextBoxColumn.DataPropertyName = "cash_adv_status"
        Me.CashadvstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.CashadvstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CashadvstatusDataGridViewTextBoxColumn.Name = "CashadvstatusDataGridViewTextBoxColumn"
        Me.CashadvstatusDataGridViewTextBoxColumn.Width = 125
        '
        'dgv_salaryLoan
        '
        Me.dgv_salaryLoan.AutoGenerateColumns = False
        Me.dgv_salaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_salaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgv_salaryLoan.DataSource = Me.SalaryloanBindingSource
        Me.dgv_salaryLoan.Location = New System.Drawing.Point(10, 132)
        Me.dgv_salaryLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_salaryLoan.Name = "dgv_salaryLoan"
        Me.dgv_salaryLoan.RowHeadersWidth = 51
        Me.dgv_salaryLoan.RowTemplate.Height = 24
        Me.dgv_salaryLoan.Size = New System.Drawing.Size(791, 196)
        Me.dgv_salaryLoan.TabIndex = 56
        '
        'SalaryloanBindingSource
        '
        Me.SalaryloanBindingSource.DataMember = "salary_loan"
        Me.SalaryloanBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Salary_loanTableAdapter
        '
        Me.Salary_loanTableAdapter.ClearBeforeFill = True
        '
        'btn_salaryLoanSortLatest
        '
        Me.btn_salaryLoanSortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_salaryLoanSortLatest.Location = New System.Drawing.Point(95, 103)
        Me.btn_salaryLoanSortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salaryLoanSortLatest.Name = "btn_salaryLoanSortLatest"
        Me.btn_salaryLoanSortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_salaryLoanSortLatest.TabIndex = 55
        Me.btn_salaryLoanSortLatest.Text = "Sort Latest"
        Me.btn_salaryLoanSortLatest.UseVisualStyleBackColor = False
        '
        'lbl_salaryLoan
        '
        Me.lbl_salaryLoan.AutoSize = True
        Me.lbl_salaryLoan.Location = New System.Drawing.Point(10, 109)
        Me.lbl_salaryLoan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_salaryLoan.Name = "lbl_salaryLoan"
        Me.lbl_salaryLoan.Size = New System.Drawing.Size(66, 13)
        Me.lbl_salaryLoan.TabIndex = 54
        Me.lbl_salaryLoan.Text = "Salary Loan:"
        '
        'txt_monSalary
        '
        Me.txt_monSalary.Enabled = False
        Me.txt_monSalary.Location = New System.Drawing.Point(292, 74)
        Me.txt_monSalary.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_monSalary.Name = "txt_monSalary"
        Me.txt_monSalary.ReadOnly = True
        Me.txt_monSalary.Size = New System.Drawing.Size(133, 20)
        Me.txt_monSalary.TabIndex = 53
        '
        'lbl_monSalary
        '
        Me.lbl_monSalary.AutoSize = True
        Me.lbl_monSalary.Location = New System.Drawing.Point(213, 76)
        Me.lbl_monSalary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_monSalary.Name = "lbl_monSalary"
        Me.lbl_monSalary.Size = New System.Drawing.Size(79, 13)
        Me.lbl_monSalary.TabIndex = 52
        Me.lbl_monSalary.Text = "Monthly Salary:"
        '
        'txt_jobPos
        '
        Me.txt_jobPos.Enabled = False
        Me.txt_jobPos.Location = New System.Drawing.Point(292, 51)
        Me.txt_jobPos.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_jobPos.Name = "txt_jobPos"
        Me.txt_jobPos.ReadOnly = True
        Me.txt_jobPos.Size = New System.Drawing.Size(133, 20)
        Me.txt_jobPos.TabIndex = 51
        '
        'lbl_jobPos
        '
        Me.lbl_jobPos.AutoSize = True
        Me.lbl_jobPos.Location = New System.Drawing.Point(227, 54)
        Me.lbl_jobPos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_jobPos.Name = "lbl_jobPos"
        Me.lbl_jobPos.Size = New System.Drawing.Size(67, 13)
        Me.lbl_jobPos.TabIndex = 50
        Me.lbl_jobPos.Text = "Job Position:"
        '
        'txt_department
        '
        Me.txt_department.Enabled = False
        Me.txt_department.Location = New System.Drawing.Point(292, 26)
        Me.txt_department.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_department.Name = "txt_department"
        Me.txt_department.ReadOnly = True
        Me.txt_department.Size = New System.Drawing.Size(133, 20)
        Me.txt_department.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Department:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(82, 71)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(59, 20)
        Me.txt_middleInitial.TabIndex = 47
        '
        'lbl_middleInitial
        '
        Me.lbl_middleInitial.AutoSize = True
        Me.lbl_middleInitial.Location = New System.Drawing.Point(9, 73)
        Me.lbl_middleInitial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_middleInitial.Name = "lbl_middleInitial"
        Me.lbl_middleInitial.Size = New System.Drawing.Size(68, 13)
        Me.lbl_middleInitial.TabIndex = 46
        Me.lbl_middleInitial.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(82, 49)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(133, 20)
        Me.txt_lastName.TabIndex = 45
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(17, 51)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 44
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(82, 26)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.ReadOnly = True
        Me.txt_firstName.Size = New System.Drawing.Size(133, 20)
        Me.txt_firstName.TabIndex = 43
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(17, 28)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 42
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(82, 5)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(59, 20)
        Me.txt_employeeID.TabIndex = 41
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(9, 7)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 40
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'lbl_notice
        '
        Me.lbl_notice.AutoSize = True
        Me.lbl_notice.Location = New System.Drawing.Point(144, 7)
        Me.lbl_notice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_notice.Name = "lbl_notice"
        Me.lbl_notice.Size = New System.Drawing.Size(182, 13)
        Me.lbl_notice.TabIndex = 60
        Me.lbl_notice.Text = "Note: Input a Employee ID to search!"
        '
        'frm_profileSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(818, 578)
        Me.Controls.Add(Me.lbl_notice)
        Me.Controls.Add(Me.btn_cashAdvanceSortLatest)
        Me.Controls.Add(Me.lbl_cashAdvance)
        Me.Controls.Add(Me.dgv_cashAdvance)
        Me.Controls.Add(Me.dgv_salaryLoan)
        Me.Controls.Add(Me.btn_salaryLoanSortLatest)
        Me.Controls.Add(Me.lbl_salaryLoan)
        Me.Controls.Add(Me.txt_monSalary)
        Me.Controls.Add(Me.lbl_monSalary)
        Me.Controls.Add(Me.txt_jobPos)
        Me.Controls.Add(Me.lbl_jobPos)
        Me.Controls.Add(Me.txt_department)
        Me.Controls.Add(Me.Label1)
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
        Me.Name = "frm_profileSearch"
        Me.Text = "Profile Search"
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_salaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CashadvdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btn_cashAdvanceSortLatest As Button
    Friend WithEvents lbl_cashAdvance As Label
    Friend WithEvents CashadvanceBindingSource As BindingSource
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents Cash_advanceTableAdapter As cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter
    Friend WithEvents dgv_cashAdvance As DataGridView
    Friend WithEvents CashadvidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgv_salaryLoan As DataGridView
    Friend WithEvents SalaryloanBindingSource As BindingSource
    Friend WithEvents Salary_loanTableAdapter As cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter
    Friend WithEvents btn_salaryLoanSortLatest As Button
    Friend WithEvents lbl_salaryLoan As Label
    Friend WithEvents txt_monSalary As TextBox
    Friend WithEvents lbl_monSalary As Label
    Friend WithEvents txt_jobPos As TextBox
    Friend WithEvents lbl_jobPos As Label
    Friend WithEvents txt_department As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents lbl_middleInitial As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents lbl_notice As Label
End Class
