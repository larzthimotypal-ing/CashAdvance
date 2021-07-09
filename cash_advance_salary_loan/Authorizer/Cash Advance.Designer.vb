<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authorizerCashAdvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_authorizerCashAdvance))
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cmb_decision = New System.Windows.Forms.ComboBox()
        Me.lbl_decision = New System.Windows.Forms.Label()
        Me.txt_loanAmount = New System.Windows.Forms.TextBox()
        Me.lbl_loanAmount = New System.Windows.Forms.Label()
        Me.txt_refID = New System.Windows.Forms.TextBox()
        Me.lbl_refID = New System.Windows.Forms.Label()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.btn_profile = New System.Windows.Forms.Button()
        Me.dgv_pendingCashAdvance = New System.Windows.Forms.DataGridView()
        Me.CashadvidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashadvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.lbl_pendingRequest = New System.Windows.Forms.Label()
        Me.btn_pendingCASortLatest = New System.Windows.Forms.Button()
        Me.Cash_advanceTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter()
        Me.btn_approvedCAsortLatest = New System.Windows.Forms.Button()
        Me.dgv_approvedCashAdvance = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_approvedRequest = New System.Windows.Forms.Label()
        Me.btn_rejectedCAsortLatest = New System.Windows.Forms.Button()
        Me.dgv_rejectedCashAdvance = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_rejectedRequest = New System.Windows.Forms.Label()
        CType(Me.dgv_pendingCashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_approvedCashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_rejectedCashAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_submit.Location = New System.Drawing.Point(418, 10)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(83, 70)
        Me.btn_submit.TabIndex = 31
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'cmb_decision
        '
        Me.cmb_decision.FormattingEnabled = True
        Me.cmb_decision.Items.AddRange(New Object() {"Approved", "Rejected"})
        Me.cmb_decision.Location = New System.Drawing.Point(288, 60)
        Me.cmb_decision.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_decision.Name = "cmb_decision"
        Me.cmb_decision.Size = New System.Drawing.Size(116, 21)
        Me.cmb_decision.TabIndex = 30
        '
        'lbl_decision
        '
        Me.lbl_decision.AutoSize = True
        Me.lbl_decision.Location = New System.Drawing.Point(234, 64)
        Me.lbl_decision.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_decision.Name = "lbl_decision"
        Me.lbl_decision.Size = New System.Drawing.Size(51, 13)
        Me.lbl_decision.TabIndex = 29
        Me.lbl_decision.Text = "Decision:"
        '
        'txt_loanAmount
        '
        Me.txt_loanAmount.Enabled = False
        Me.txt_loanAmount.Location = New System.Drawing.Point(288, 37)
        Me.txt_loanAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loanAmount.Name = "txt_loanAmount"
        Me.txt_loanAmount.Size = New System.Drawing.Size(116, 20)
        Me.txt_loanAmount.TabIndex = 28
        '
        'lbl_loanAmount
        '
        Me.lbl_loanAmount.AutoSize = True
        Me.lbl_loanAmount.Location = New System.Drawing.Point(212, 41)
        Me.lbl_loanAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_loanAmount.Name = "lbl_loanAmount"
        Me.lbl_loanAmount.Size = New System.Drawing.Size(73, 13)
        Me.lbl_loanAmount.TabIndex = 27
        Me.lbl_loanAmount.Text = "Loan Amount:"
        '
        'txt_refID
        '
        Me.txt_refID.Enabled = False
        Me.txt_refID.Location = New System.Drawing.Point(288, 14)
        Me.txt_refID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_refID.Name = "txt_refID"
        Me.txt_refID.Size = New System.Drawing.Size(54, 20)
        Me.txt_refID.TabIndex = 26
        '
        'lbl_refID
        '
        Me.lbl_refID.AutoSize = True
        Me.lbl_refID.Location = New System.Drawing.Point(212, 18)
        Me.lbl_refID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_refID.Name = "lbl_refID"
        Me.lbl_refID.Size = New System.Drawing.Size(74, 13)
        Me.lbl_refID.TabIndex = 25
        Me.lbl_refID.Text = "Reference ID:"
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(82, 83)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.Size = New System.Drawing.Size(54, 20)
        Me.txt_middleInitial.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(82, 60)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(116, 20)
        Me.txt_lastName.TabIndex = 22
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(17, 64)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 21
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(82, 37)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(116, 20)
        Me.txt_firstName.TabIndex = 20
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(17, 41)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 19
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(82, 15)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(54, 20)
        Me.txt_employeeID.TabIndex = 18
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(9, 20)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 17
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'btn_profile
        '
        Me.btn_profile.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_profile.Location = New System.Drawing.Point(140, 5)
        Me.btn_profile.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(58, 28)
        Me.btn_profile.TabIndex = 16
        Me.btn_profile.Text = "Profile"
        Me.btn_profile.UseVisualStyleBackColor = False
        '
        'dgv_pendingCashAdvance
        '
        Me.dgv_pendingCashAdvance.AutoGenerateColumns = False
        Me.dgv_pendingCashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pendingCashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CashadvidDataGridViewTextBoxColumn, Me.CashadvamountDataGridViewTextBoxColumn, Me.CashadvdateDataGridViewTextBoxColumn, Me.CashadvstatusDataGridViewTextBoxColumn, Me.employee_id})
        Me.dgv_pendingCashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_pendingCashAdvance.Location = New System.Drawing.Point(9, 144)
        Me.dgv_pendingCashAdvance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_pendingCashAdvance.Name = "dgv_pendingCashAdvance"
        Me.dgv_pendingCashAdvance.RowHeadersWidth = 51
        Me.dgv_pendingCashAdvance.RowTemplate.Height = 24
        Me.dgv_pendingCashAdvance.Size = New System.Drawing.Size(416, 196)
        Me.dgv_pendingCashAdvance.TabIndex = 33
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
        Me.CashadvdateDataGridViewTextBoxColumn.HeaderText = "Date"
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
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "employee_id"
        Me.employee_id.MinimumWidth = 6
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Visible = False
        Me.employee_id.Width = 125
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
        'lbl_pendingRequest
        '
        Me.lbl_pendingRequest.AutoSize = True
        Me.lbl_pendingRequest.Location = New System.Drawing.Point(7, 119)
        Me.lbl_pendingRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_pendingRequest.Name = "lbl_pendingRequest"
        Me.lbl_pendingRequest.Size = New System.Drawing.Size(92, 13)
        Me.lbl_pendingRequest.TabIndex = 32
        Me.lbl_pendingRequest.Text = "Pending Request:"
        '
        'btn_pendingCASortLatest
        '
        Me.btn_pendingCASortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_pendingCASortLatest.Location = New System.Drawing.Point(96, 114)
        Me.btn_pendingCASortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pendingCASortLatest.Name = "btn_pendingCASortLatest"
        Me.btn_pendingCASortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_pendingCASortLatest.TabIndex = 34
        Me.btn_pendingCASortLatest.Text = "Sort Latest"
        Me.btn_pendingCASortLatest.UseVisualStyleBackColor = False
        '
        'Cash_advanceTableAdapter
        '
        Me.Cash_advanceTableAdapter.ClearBeforeFill = True
        '
        'btn_approvedCAsortLatest
        '
        Me.btn_approvedCAsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_approvedCAsortLatest.Location = New System.Drawing.Point(96, 349)
        Me.btn_approvedCAsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_approvedCAsortLatest.Name = "btn_approvedCAsortLatest"
        Me.btn_approvedCAsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_approvedCAsortLatest.TabIndex = 37
        Me.btn_approvedCAsortLatest.Text = "Sort Latest"
        Me.btn_approvedCAsortLatest.UseVisualStyleBackColor = False
        '
        'dgv_approvedCashAdvance
        '
        Me.dgv_approvedCashAdvance.AutoGenerateColumns = False
        Me.dgv_approvedCashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_approvedCashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9})
        Me.dgv_approvedCashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_approvedCashAdvance.Location = New System.Drawing.Point(9, 379)
        Me.dgv_approvedCashAdvance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_approvedCashAdvance.Name = "dgv_approvedCashAdvance"
        Me.dgv_approvedCashAdvance.RowHeadersWidth = 51
        Me.dgv_approvedCashAdvance.RowTemplate.Height = 24
        Me.dgv_approvedCashAdvance.Size = New System.Drawing.Size(416, 116)
        Me.dgv_approvedCashAdvance.TabIndex = 36
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cash_adv_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reference ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cash_adv_amount"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cash_adv_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cash_adv_status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "employee_id"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'lbl_approvedRequest
        '
        Me.lbl_approvedRequest.AutoSize = True
        Me.lbl_approvedRequest.Location = New System.Drawing.Point(0, 354)
        Me.lbl_approvedRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_approvedRequest.Name = "lbl_approvedRequest"
        Me.lbl_approvedRequest.Size = New System.Drawing.Size(99, 13)
        Me.lbl_approvedRequest.TabIndex = 35
        Me.lbl_approvedRequest.Text = "Approved Request:"
        '
        'btn_rejectedCAsortLatest
        '
        Me.btn_rejectedCAsortLatest.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_rejectedCAsortLatest.Location = New System.Drawing.Point(96, 504)
        Me.btn_rejectedCAsortLatest.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_rejectedCAsortLatest.Name = "btn_rejectedCAsortLatest"
        Me.btn_rejectedCAsortLatest.Size = New System.Drawing.Size(101, 24)
        Me.btn_rejectedCAsortLatest.TabIndex = 40
        Me.btn_rejectedCAsortLatest.Text = "Sort Latest"
        Me.btn_rejectedCAsortLatest.UseVisualStyleBackColor = False
        '
        'dgv_rejectedCashAdvance
        '
        Me.dgv_rejectedCashAdvance.AutoGenerateColumns = False
        Me.dgv_rejectedCashAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_rejectedCashAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.dgv_rejectedCashAdvance.DataSource = Me.CashadvanceBindingSource
        Me.dgv_rejectedCashAdvance.Location = New System.Drawing.Point(9, 534)
        Me.dgv_rejectedCashAdvance.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_rejectedCashAdvance.Name = "dgv_rejectedCashAdvance"
        Me.dgv_rejectedCashAdvance.RowHeadersWidth = 51
        Me.dgv_rejectedCashAdvance.RowTemplate.Height = 24
        Me.dgv_rejectedCashAdvance.Size = New System.Drawing.Size(416, 116)
        Me.dgv_rejectedCashAdvance.TabIndex = 39
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cash_adv_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reference ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cash_adv_amount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Loan Amount"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cash_adv_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cash_adv_status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "employee_id"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'lbl_rejectedRequest
        '
        Me.lbl_rejectedRequest.AutoSize = True
        Me.lbl_rejectedRequest.Location = New System.Drawing.Point(4, 509)
        Me.lbl_rejectedRequest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rejectedRequest.Name = "lbl_rejectedRequest"
        Me.lbl_rejectedRequest.Size = New System.Drawing.Size(96, 13)
        Me.lbl_rejectedRequest.TabIndex = 38
        Me.lbl_rejectedRequest.Text = "Rejected Request:"
        '
        'frm_authorizerCashAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(520, 609)
        Me.Controls.Add(Me.btn_rejectedCAsortLatest)
        Me.Controls.Add(Me.dgv_rejectedCashAdvance)
        Me.Controls.Add(Me.lbl_rejectedRequest)
        Me.Controls.Add(Me.btn_approvedCAsortLatest)
        Me.Controls.Add(Me.dgv_approvedCashAdvance)
        Me.Controls.Add(Me.lbl_approvedRequest)
        Me.Controls.Add(Me.btn_pendingCASortLatest)
        Me.Controls.Add(Me.dgv_pendingCashAdvance)
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
        Me.Name = "frm_authorizerCashAdvance"
        Me.Text = "Cash Advance"
        CType(Me.dgv_pendingCashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_approvedCashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_rejectedCashAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_submit As Button
    Friend WithEvents cmb_decision As ComboBox
    Friend WithEvents lbl_decision As Label
    Friend WithEvents txt_loanAmount As TextBox
    Friend WithEvents lbl_loanAmount As Label
    Friend WithEvents txt_refID As TextBox
    Friend WithEvents lbl_refID As Label
    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents btn_profile As Button
    Friend WithEvents dgv_pendingCashAdvance As DataGridView
    Friend WithEvents lbl_pendingRequest As Label
    Friend WithEvents btn_pendingCASortLatest As Button
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents CashadvanceBindingSource As BindingSource
    Friend WithEvents Cash_advanceTableAdapter As cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter
    Friend WithEvents btn_approvedCAsortLatest As Button
    Friend WithEvents dgv_approvedCashAdvance As DataGridView
    Friend WithEvents lbl_approvedRequest As Label
    Friend WithEvents btn_rejectedCAsortLatest As Button
    Friend WithEvents dgv_rejectedCashAdvance As DataGridView
    Friend WithEvents lbl_rejectedRequest As Label
    Friend WithEvents CashadvidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashadvstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
