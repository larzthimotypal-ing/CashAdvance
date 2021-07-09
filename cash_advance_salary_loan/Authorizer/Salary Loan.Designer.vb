<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authorizerSalaryLoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_authorizerSalaryLoan))
        Me.btn_profile = New System.Windows.Forms.Button()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_refID = New System.Windows.Forms.TextBox()
        Me.lbl_refID = New System.Windows.Forms.Label()
        Me.lbl_loanAmount = New System.Windows.Forms.Label()
        Me.txt_loanAmount = New System.Windows.Forms.TextBox()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.cmb_decision = New System.Windows.Forms.ComboBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.lbl_pendingRequest = New System.Windows.Forms.Label()
        Me.dgv_pendingSalaryLoan = New System.Windows.Forms.DataGridView()
        Me.SalaryloanidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloanamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComakerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthstopayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlypaywithinterestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalamounttopayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloandateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalloanstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryloanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.Salary_loanTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter()
        Me.dgv_approvedSalaryLoan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_approvedRequest = New System.Windows.Forms.Label()
        Me.btn_pendingSLSortLatest = New System.Windows.Forms.Button()
        Me.btn_approvedSLsortLatest = New System.Windows.Forms.Button()
        Me.btn_rejectedSLsortLatest = New System.Windows.Forms.Button()
        Me.dgv_rejectedSalaryLoan = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_rejectedRequest = New System.Windows.Forms.Label()
        CType(Me.dgv_pendingSalaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_approvedSalaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_rejectedSalaryLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_profile
        '
        Me.btn_profile.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_profile.Location = New System.Drawing.Point(140, 5)
        Me.btn_profile.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(58, 28)
        Me.btn_profile.TabIndex = 0
        Me.btn_profile.Text = "Profile"
        Me.btn_profile.UseVisualStyleBackColor = False
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(9, 20)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 1
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(82, 15)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(54, 20)
        Me.txt_employeeID.TabIndex = 2
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(82, 37)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(116, 20)
        Me.txt_firstName.TabIndex = 4
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(17, 41)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 3
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(82, 60)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(116, 20)
        Me.txt_lastName.TabIndex = 6
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(17, 64)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 5
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(82, 83)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.Size = New System.Drawing.Size(54, 20)
        Me.txt_middleInitial.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Middle Initial:"
        '
        'txt_refID
        '
        Me.txt_refID.Enabled = False
        Me.txt_refID.Location = New System.Drawing.Point(288, 14)
        Me.txt_refID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_refID.Name = "txt_refID"
        Me.txt_refID.Size = New System.Drawing.Size(54, 20)
        Me.txt_refID.TabIndex = 10
        '
        'lbl_refID
        '
        Me.lbl_refID.AutoSize = True
        Me.lbl_refID.Location = New System.Drawing.Point(212, 18)
        Me.lbl_refID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_refID.Name = "lbl_refID"
        Me.lbl_refID.Size = New System.Drawing.Size(74, 13)
        Me.lbl_refID.TabIndex = 9
        Me.lbl_refID.Text = "Reference ID:"
        '
        'lbl_loanAmount
        '
        Me.lbl_loanAmount.AutoSize = True
        Me.lbl_loanAmount.Location = New System.Drawing.Point(212, 41)
        Me.lbl_loanAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_loanAmount.Name = "lbl_loanAmount"
        Me.lbl_loanAmount.Size = New System.Drawing.Size(73, 13)
        Me.lbl_loanAmount.TabIndex = 11
        Me.lbl_loanAmount.Text = "Loan Amount:"
        '
        'txt_loanAmount
        '
        Me.txt_loanAmount.Enabled = False
        Me.txt_loanAmount.Location = New System.Drawing.Point(288, 37)
        Me.txt_loanAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loanAmount.Name = "txt_loanAmount"
        Me.txt_loanAmount.Size = New System.Drawing.Size(116, 20)
        Me.txt_loanAmount.TabIndex = 12
        '
        'lbl_decision
        '
        Me.lbl_decision.AutoSize = True
        Me.lbl_decision.Location = New System.Drawing.Point(234, 64)
        Me.lbl_decision.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_decision.Name = "lbl_decision"
        Me.lbl_decision.Size = New System.Drawing.Size(51, 13)
        Me.lbl_decision.TabIndex = 13
        Me.lbl_decision.Text = "Decision:"
        '
        'cmb_decision
        '
        Me.cmb_decision.FormattingEnabled = True
        Me.cmb_decision.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.cmb_decision.Location = New System.Drawing.Point(288, 60)
        Me.cmb_decision.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_decision.Name = "cmb_decision"
        Me.cmb_decision.Size = New System.Drawing.Size(116, 21)
        Me.cmb_decision.TabIndex = 14
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_submit.Location = New System.Drawing.Point(443, 10)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(83, 70)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'lbl_pendingRequest
        '
        Me.lbl_pendingRequest.AutoSize = True
        Me.lbl_pendingRequest.Location = New System.Drawing.Point(10, 125)
        Me.lbl_pendingRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_pendingRequest.Name = "lbl_pendingRequest"
        Me.lbl_pendingRequest.Size = New System.Drawing.Size(92, 13)
        Me.lbl_pendingRequest.TabIndex = 16
        Me.lbl_pendingRequest.Text = "Pending Request:"
        '
        'dgv_pendingSalaryLoan
        '
        Me.dgv_pendingSalaryLoan.AutoGenerateColumns = False
        Me.dgv_pendingSalaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendingSalaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalaryloanidDataGridViewTextBoxColumn, Me.SalloanamountDataGridViewTextBoxColumn, Me.ComakerDataGridViewTextBoxColumn, Me.MonthstopayDataGridViewTextBoxColumn, Me.MonthlypaywithinterestDataGridViewTextBoxColumn, Me.TotalamounttopayDataGridViewTextBoxColumn, Me.SalloandateDataGridViewTextBoxColumn, Me.SalloanstatusDataGridViewTextBoxColumn, Me.employee_id})
        Me.dgv_pendingSalaryLoan.DataSource = Me.SalaryloanBindingSource
        Me.dgv_pendingSalaryLoan.Location = New System.Drawing.Point(13, 150)
        Me.dgv_pendingSalaryLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_pendingSalaryLoan.Name = "dgv_pendingSalaryLoan"
        Me.dgv_pendingSalaryLoan.RowHeadersWidth = 51
        Me.dgv_pendingSalaryLoan.RowTemplate.Height = 24
        Me.dgv_pendingSalaryLoan.Size = New System.Drawing.Size(791, 196)
        Me.dgv_pendingSalaryLoan.TabIndex = 17
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
        'ComakerDataGridViewTextBoxColumn
        '
        Me.ComakerDataGridViewTextBoxColumn.DataPropertyName = "comaker"
        Me.ComakerDataGridViewTextBoxColumn.HeaderText = "Comaker"
        Me.ComakerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComakerDataGridViewTextBoxColumn.Name = "ComakerDataGridViewTextBoxColumn"
        Me.ComakerDataGridViewTextBoxColumn.Width = 125
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
        Me.TotalamounttopayDataGridViewTextBoxColumn.HeaderText = "Total Amount"
        Me.TotalamounttopayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalamounttopayDataGridViewTextBoxColumn.Name = "TotalamounttopayDataGridViewTextBoxColumn"
        Me.TotalamounttopayDataGridViewTextBoxColumn.Width = 125
        '
        'SalloandateDataGridViewTextBoxColumn
        '
        Me.SalloandateDataGridViewTextBoxColumn.DataPropertyName = "sal_loan_date"
        Me.SalloandateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.SalloandateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalloandateDataGridViewTextBoxColumn.Name = "SalloandateDataGridViewTextBoxColumn"
        Me.SalloandateDataGridViewTextBoxColumn.Width = 125
        '
        'SalloanstatusDataGridViewTextBoxColumn
        '
        Me.SalloanstatusDataGridViewTextBoxColumn.DataPropertyName = "sal_loan_status"
        Me.SalloanstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.SalloanstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalloanstatusDataGridViewTextBoxColumn.Name = "SalloanstatusDataGridViewTextBoxColumn"
        Me.SalloanstatusDataGridViewTextBoxColumn.Width = 125
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Employee ID"
        Me.employee_id.MinimumWidth = 6
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Visible = False
        Me.employee_id.Width = 125
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
        'Salary_loanTableAdapter
        '
        Me.Salary_loanTableAdapter.ClearBeforeFill = True
        '
        'dgv_approvedSalaryLoan
        '
        Me.dgv_approvedSalaryLoan.AutoGenerateColumns = False
        Me.dgv_approvedSalaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_approvedSalaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn17})
        Me.dgv_approvedSalaryLoan.DataSource = Me.SalaryloanBindingSource
        Me.dgv_approvedSalaryLoan.Location = New System.Drawing.Point(13, 389)
        Me.dgv_approvedSalaryLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_approvedSalaryLoan.Name = "dgv_approvedSalaryLoan"
        Me.dgv_approvedSalaryLoan.RowHeadersWidth = 51
        Me.dgv_approvedSalaryLoan.RowTemplate.Height = 24
        Me.dgv_approvedSalaryLoan.Size = New System.Drawing.Size(791, 120)
        Me.dgv_approvedSalaryLoan.TabIndex = 19
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
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn17.HeaderText = "employee_id"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'lbl_approvedRequest
        '
        Me.lbl_approvedRequest.AutoSize = True
        Me.lbl_approvedRequest.Location = New System.Drawing.Point(4, 366)
        Me.lbl_approvedRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_approvedRequest.Name = "lbl_approvedRequest"
        Me.lbl_approvedRequest.Size = New System.Drawing.Size(99, 13)
        Me.lbl_approvedRequest.TabIndex = 18
        Me.lbl_approvedRequest.Text = "Approved Request:"
        '
        'btn_pendingSLSortLatest
        '
        Me.btn_pendingSLSortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_pendingSLSortLatest.Location = New System.Drawing.Point(106, 119)
        Me.btn_pendingSLSortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pendingSLSortLatest.Name = "btn_pendingSLSortLatest"
        Me.btn_pendingSLSortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_pendingSLSortLatest.TabIndex = 21
        Me.btn_pendingSLSortLatest.Text = "Sort Latest"
        Me.btn_pendingSLSortLatest.UseVisualStyleBackColor = False
        '
        'btn_approvedSLsortLatest
        '
        Me.btn_approvedSLsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_approvedSLsortLatest.Location = New System.Drawing.Point(106, 360)
        Me.btn_approvedSLsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_approvedSLsortLatest.Name = "btn_approvedSLsortLatest"
        Me.btn_approvedSLsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_approvedSLsortLatest.TabIndex = 22
        Me.btn_approvedSLsortLatest.Text = "Sort Latest"
        Me.btn_approvedSLsortLatest.UseVisualStyleBackColor = False
        '
        'btn_rejectedSLsortLatest
        '
        Me.btn_rejectedSLsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_rejectedSLsortLatest.Location = New System.Drawing.Point(106, 521)
        Me.btn_rejectedSLsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_rejectedSLsortLatest.Name = "btn_rejectedSLsortLatest"
        Me.btn_rejectedSLsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_rejectedSLsortLatest.TabIndex = 25
        Me.btn_rejectedSLsortLatest.Text = "Sort Latest"
        Me.btn_rejectedSLsortLatest.UseVisualStyleBackColor = False
        '
        'dgv_rejectedSalaryLoan
        '
        Me.dgv_rejectedSalaryLoan.AutoGenerateColumns = False
        Me.dgv_rejectedSalaryLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rejectedSalaryLoan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18})
        Me.dgv_rejectedSalaryLoan.DataSource = Me.SalaryloanBindingSource
        Me.dgv_rejectedSalaryLoan.Location = New System.Drawing.Point(13, 550)
        Me.dgv_rejectedSalaryLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_rejectedSalaryLoan.Name = "dgv_rejectedSalaryLoan"
        Me.dgv_rejectedSalaryLoan.RowHeadersWidth = 51
        Me.dgv_rejectedSalaryLoan.RowTemplate.Height = 24
        Me.dgv_rejectedSalaryLoan.Size = New System.Drawing.Size(791, 120)
        Me.dgv_rejectedSalaryLoan.TabIndex = 24
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "salary_loan_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reference ID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "sal_loan_amount"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "comaker"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Comaker"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "months_to_pay"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Months to pay"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "monthly_pay_with_interest"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Monthly Balance"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "total_amount_to_pay"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "sal_loan_date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "sal_loan_status"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn18.HeaderText = "employee_id"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'lbl_rejectedRequest
        '
        Me.lbl_rejectedRequest.AutoSize = True
        Me.lbl_rejectedRequest.Location = New System.Drawing.Point(8, 526)
        Me.lbl_rejectedRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rejectedRequest.Name = "lbl_rejectedRequest"
        Me.lbl_rejectedRequest.Size = New System.Drawing.Size(96, 13)
        Me.lbl_rejectedRequest.TabIndex = 23
        Me.lbl_rejectedRequest.Text = "Rejected Request:"
        '
        'frm_authorizerSalaryLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(820, 609)
        Me.Controls.Add(Me.btn_rejectedSLsortLatest)
        Me.Controls.Add(Me.dgv_rejectedSalaryLoan)
        Me.Controls.Add(Me.lbl_rejectedRequest)
        Me.Controls.Add(Me.btn_approvedSLsortLatest)
        Me.Controls.Add(Me.btn_pendingSLSortLatest)
        Me.Controls.Add(Me.dgv_approvedSalaryLoan)
        Me.Controls.Add(Me.lbl_approvedRequest)
        Me.Controls.Add(Me.dgv_pendingSalaryLoan)
        Me.Controls.Add(Me.lbl_pendingRequest)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.cmb_decision)
        Me.Controls.Add(Me.lbl_decision)
        Me.Controls.Add(Me.txt_loanAmount)
        Me.Controls.Add(Me.lbl_loanAmount)
        Me.Controls.Add(Me.txt_refID)
        Me.Controls.Add(Me.lbl_refID)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Controls.Add(Me.btn_profile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_authorizerSalaryLoan"
        Me.Text = "Salary Loan"
        CType(Me.dgv_pendingSalaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalaryloanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_approvedSalaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_rejectedSalaryLoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_profile As Button
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_refID As TextBox
    Friend WithEvents lbl_refID As Label
    Friend WithEvents lbl_loanAmount As Label
    Friend WithEvents txt_loanAmount As TextBox
    Friend WithEvents lbl_decision As Label
    Friend WithEvents cmb_decision As ComboBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents lbl_pendingRequest As Label
    Friend WithEvents dgv_pendingSalaryLoan As DataGridView
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents SalaryloanBindingSource As BindingSource
    Friend WithEvents Salary_loanTableAdapter As cash_advance_salary_loanDataSetTableAdapters.salary_loanTableAdapter
    Friend WithEvents dgv_approvedSalaryLoan As DataGridView
    Friend WithEvents lbl_approvedRequest As Label
    Friend WithEvents btn_pendingSLSortLatest As Button
    Friend WithEvents btn_approvedSLsortLatest As Button
    Friend WithEvents btn_rejectedSLsortLatest As Button
    Friend WithEvents dgv_rejectedSalaryLoan As DataGridView
    Friend WithEvents lbl_rejectedRequest As Label
    Friend WithEvents SalaryloanidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloanamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComakerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthstopayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlypaywithinterestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalamounttopayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloandateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalloanstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
End Class
