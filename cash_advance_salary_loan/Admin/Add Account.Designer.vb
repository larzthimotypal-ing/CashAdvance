<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accountManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accountManage))
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.cmb_addUserType = New System.Windows.Forms.ComboBox()
        Me.lbl_addUsertype = New System.Windows.Forms.Label()
        Me.txt_addPassword = New System.Windows.Forms.TextBox()
        Me.lbl_addPassword = New System.Windows.Forms.Label()
        Me.dgv_employeeList = New System.Windows.Forms.DataGridView()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleinitialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.EmployeeTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter()
        Me.lbl_employeeList = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.cmb_modifyUserType = New System.Windows.Forms.ComboBox()
        Me.lbl_modifyUserType = New System.Windows.Forms.Label()
        Me.lbl_identity = New System.Windows.Forms.Label()
        Me.txt_identityID = New System.Windows.Forms.TextBox()
        Me.lbl_modifyPassword = New System.Windows.Forms.Label()
        Me.txt_modifyPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_loginList = New System.Windows.Forms.DataGridView()
        Me.identity_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usertype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentityidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdentityTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.identityTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_employeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_loginList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdentityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Location = New System.Drawing.Point(85, 89)
        Me.txt_middleInitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.ReadOnly = True
        Me.txt_middleInitial.Size = New System.Drawing.Size(54, 20)
        Me.txt_middleInitial.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Location = New System.Drawing.Point(85, 67)
        Me.txt_lastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.ReadOnly = True
        Me.txt_lastName.Size = New System.Drawing.Size(116, 20)
        Me.txt_lastName.TabIndex = 30
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(20, 71)
        Me.lbl_lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(61, 13)
        Me.lbl_lastName.TabIndex = 29
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Location = New System.Drawing.Point(85, 44)
        Me.txt_firstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.ReadOnly = True
        Me.txt_firstName.Size = New System.Drawing.Size(116, 20)
        Me.txt_firstName.TabIndex = 28
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(20, 48)
        Me.lbl_firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(60, 13)
        Me.lbl_firstName.TabIndex = 27
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(85, 22)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(54, 20)
        Me.txt_employeeID.TabIndex = 26
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(12, 26)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 25
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Add)
        Me.GroupBox1.Controls.Add(Me.cmb_addUserType)
        Me.GroupBox1.Controls.Add(Me.lbl_addUsertype)
        Me.GroupBox1.Controls.Add(Me.txt_addPassword)
        Me.GroupBox1.Controls.Add(Me.lbl_addPassword)
        Me.GroupBox1.Controls.Add(Me.lbl_employeeID)
        Me.GroupBox1.Controls.Add(Me.txt_middleInitial)
        Me.GroupBox1.Controls.Add(Me.txt_employeeID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_firstName)
        Me.GroupBox1.Controls.Add(Me.txt_lastName)
        Me.GroupBox1.Controls.Add(Me.txt_firstName)
        Me.GroupBox1.Controls.Add(Me.lbl_lastName)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(214, 205)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Employee to Login"
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_Add.Location = New System.Drawing.Point(75, 163)
        Me.btn_Add.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(72, 29)
        Me.btn_Add.TabIndex = 43
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'cmb_addUserType
        '
        Me.cmb_addUserType.FormattingEnabled = True
        Me.cmb_addUserType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_addUserType.Location = New System.Drawing.Point(85, 135)
        Me.cmb_addUserType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_addUserType.Name = "cmb_addUserType"
        Me.cmb_addUserType.Size = New System.Drawing.Size(116, 21)
        Me.cmb_addUserType.TabIndex = 36
        '
        'lbl_addUsertype
        '
        Me.lbl_addUsertype.AutoSize = True
        Me.lbl_addUsertype.Location = New System.Drawing.Point(22, 137)
        Me.lbl_addUsertype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_addUsertype.Name = "lbl_addUsertype"
        Me.lbl_addUsertype.Size = New System.Drawing.Size(59, 13)
        Me.lbl_addUsertype.TabIndex = 35
        Me.lbl_addUsertype.Text = "User Type:"
        '
        'txt_addPassword
        '
        Me.txt_addPassword.Location = New System.Drawing.Point(85, 112)
        Me.txt_addPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_addPassword.Name = "txt_addPassword"
        Me.txt_addPassword.Size = New System.Drawing.Size(116, 20)
        Me.txt_addPassword.TabIndex = 34
        '
        'lbl_addPassword
        '
        Me.lbl_addPassword.AutoSize = True
        Me.lbl_addPassword.Location = New System.Drawing.Point(26, 116)
        Me.lbl_addPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_addPassword.Name = "lbl_addPassword"
        Me.lbl_addPassword.Size = New System.Drawing.Size(56, 13)
        Me.lbl_addPassword.TabIndex = 33
        Me.lbl_addPassword.Text = "Password:"
        '
        'dgv_employeeList
        '
        Me.dgv_employeeList.AutoGenerateColumns = False
        Me.dgv_employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeidDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.MiddleinitialDataGridViewTextBoxColumn})
        Me.dgv_employeeList.DataSource = Me.EmployeeBindingSource
        Me.dgv_employeeList.Location = New System.Drawing.Point(9, 35)
        Me.dgv_employeeList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_employeeList.Name = "dgv_employeeList"
        Me.dgv_employeeList.RowHeadersWidth = 51
        Me.dgv_employeeList.RowTemplate.Height = 24
        Me.dgv_employeeList.Size = New System.Drawing.Size(415, 205)
        Me.dgv_employeeList.TabIndex = 34
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Width = 125
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 125
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 125
        '
        'MiddleinitialDataGridViewTextBoxColumn
        '
        Me.MiddleinitialDataGridViewTextBoxColumn.DataPropertyName = "middle_initial"
        Me.MiddleinitialDataGridViewTextBoxColumn.HeaderText = "Middle Initial"
        Me.MiddleinitialDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MiddleinitialDataGridViewTextBoxColumn.Name = "MiddleinitialDataGridViewTextBoxColumn"
        Me.MiddleinitialDataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lbl_employeeList
        '
        Me.lbl_employeeList.AutoSize = True
        Me.lbl_employeeList.Location = New System.Drawing.Point(7, 10)
        Me.lbl_employeeList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeList.Name = "lbl_employeeList"
        Me.lbl_employeeList.Size = New System.Drawing.Size(75, 13)
        Me.lbl_employeeList.TabIndex = 37
        Me.lbl_employeeList.Text = "Employee List:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.cmb_modifyUserType)
        Me.GroupBox2.Controls.Add(Me.lbl_modifyUserType)
        Me.GroupBox2.Controls.Add(Me.lbl_identity)
        Me.GroupBox2.Controls.Add(Me.txt_identityID)
        Me.GroupBox2.Controls.Add(Me.lbl_modifyPassword)
        Me.GroupBox2.Controls.Add(Me.txt_modifyPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 280)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(214, 146)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit or Delete Account to Login"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_delete.Location = New System.Drawing.Point(128, 102)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(72, 29)
        Me.btn_delete.TabIndex = 45
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_edit.Location = New System.Drawing.Point(24, 102)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(72, 29)
        Me.btn_edit.TabIndex = 44
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'cmb_modifyUserType
        '
        Me.cmb_modifyUserType.FormattingEnabled = True
        Me.cmb_modifyUserType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_modifyUserType.Location = New System.Drawing.Point(85, 67)
        Me.cmb_modifyUserType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_modifyUserType.Name = "cmb_modifyUserType"
        Me.cmb_modifyUserType.Size = New System.Drawing.Size(116, 21)
        Me.cmb_modifyUserType.TabIndex = 36
        '
        'lbl_modifyUserType
        '
        Me.lbl_modifyUserType.AutoSize = True
        Me.lbl_modifyUserType.Location = New System.Drawing.Point(22, 69)
        Me.lbl_modifyUserType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_modifyUserType.Name = "lbl_modifyUserType"
        Me.lbl_modifyUserType.Size = New System.Drawing.Size(59, 13)
        Me.lbl_modifyUserType.TabIndex = 35
        Me.lbl_modifyUserType.Text = "User Type:"
        '
        'lbl_identity
        '
        Me.lbl_identity.AutoSize = True
        Me.lbl_identity.Location = New System.Drawing.Point(25, 26)
        Me.lbl_identity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_identity.Name = "lbl_identity"
        Me.lbl_identity.Size = New System.Drawing.Size(58, 13)
        Me.lbl_identity.TabIndex = 25
        Me.lbl_identity.Text = "Identity ID:"
        '
        'txt_identityID
        '
        Me.txt_identityID.Location = New System.Drawing.Point(85, 22)
        Me.txt_identityID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_identityID.Name = "txt_identityID"
        Me.txt_identityID.ReadOnly = True
        Me.txt_identityID.Size = New System.Drawing.Size(54, 20)
        Me.txt_identityID.TabIndex = 26
        '
        'lbl_modifyPassword
        '
        Me.lbl_modifyPassword.AutoSize = True
        Me.lbl_modifyPassword.Location = New System.Drawing.Point(25, 48)
        Me.lbl_modifyPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_modifyPassword.Name = "lbl_modifyPassword"
        Me.lbl_modifyPassword.Size = New System.Drawing.Size(56, 13)
        Me.lbl_modifyPassword.TabIndex = 27
        Me.lbl_modifyPassword.Text = "Password:"
        '
        'txt_modifyPassword
        '
        Me.txt_modifyPassword.Location = New System.Drawing.Point(85, 44)
        Me.txt_modifyPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_modifyPassword.Name = "txt_modifyPassword"
        Me.txt_modifyPassword.Size = New System.Drawing.Size(116, 20)
        Me.txt_modifyPassword.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 254)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Login List:"
        '
        'dgv_loginList
        '
        Me.dgv_loginList.AutoGenerateColumns = False
        Me.dgv_loginList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_loginList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.identity_id, Me.employee_id, Me.password, Me.usertype, Me.IdentityidDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn1, Me.PasswordDataGridViewTextBoxColumn, Me.UsertypeDataGridViewTextBoxColumn})
        Me.dgv_loginList.DataSource = Me.IdentityBindingSource
        Me.dgv_loginList.Location = New System.Drawing.Point(9, 280)
        Me.dgv_loginList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_loginList.Name = "dgv_loginList"
        Me.dgv_loginList.RowHeadersWidth = 51
        Me.dgv_loginList.RowTemplate.Height = 24
        Me.dgv_loginList.Size = New System.Drawing.Size(415, 205)
        Me.dgv_loginList.TabIndex = 38
        '
        'identity_id
        '
        Me.identity_id.DataPropertyName = "identity_id"
        Me.identity_id.HeaderText = "Identity ID"
        Me.identity_id.MinimumWidth = 6
        Me.identity_id.Name = "identity_id"
        Me.identity_id.Width = 125
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Employee ID"
        Me.employee_id.MinimumWidth = 6
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Width = 125
        '
        'password
        '
        Me.password.DataPropertyName = "password"
        Me.password.HeaderText = "password"
        Me.password.MinimumWidth = 6
        Me.password.Name = "password"
        Me.password.Visible = False
        Me.password.Width = 125
        '
        'usertype
        '
        Me.usertype.DataPropertyName = "usertype"
        Me.usertype.HeaderText = "usertype"
        Me.usertype.MinimumWidth = 6
        Me.usertype.Name = "usertype"
        Me.usertype.Width = 125
        '
        'IdentityidDataGridViewTextBoxColumn
        '
        Me.IdentityidDataGridViewTextBoxColumn.DataPropertyName = "identity_id"
        Me.IdentityidDataGridViewTextBoxColumn.HeaderText = "identity_id"
        Me.IdentityidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdentityidDataGridViewTextBoxColumn.Name = "IdentityidDataGridViewTextBoxColumn"
        Me.IdentityidDataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeidDataGridViewTextBoxColumn1
        '
        Me.EmployeeidDataGridViewTextBoxColumn1.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn1.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.EmployeeidDataGridViewTextBoxColumn1.Name = "EmployeeidDataGridViewTextBoxColumn1"
        Me.EmployeeidDataGridViewTextBoxColumn1.Width = 125
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 125
        '
        'UsertypeDataGridViewTextBoxColumn
        '
        Me.UsertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.HeaderText = "usertype"
        Me.UsertypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsertypeDataGridViewTextBoxColumn.Name = "UsertypeDataGridViewTextBoxColumn"
        Me.UsertypeDataGridViewTextBoxColumn.Width = 125
        '
        'IdentityBindingSource
        '
        Me.IdentityBindingSource.DataMember = "identity"
        Me.IdentityBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'IdentityTableAdapter
        '
        Me.IdentityTableAdapter.ClearBeforeFill = True
        '
        'frm_accountManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(667, 498)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_loginList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_employeeList)
        Me.Controls.Add(Me.dgv_employeeList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_accountManage"
        Me.Text = "Account Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_employeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_loginList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdentityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_addPassword As TextBox
    Friend WithEvents lbl_addPassword As Label
    Friend WithEvents cmb_addUserType As ComboBox
    Friend WithEvents lbl_addUsertype As Label
    Friend WithEvents dgv_employeeList As DataGridView
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As cash_advance_salary_loanDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleinitialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lbl_employeeList As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_modifyUserType As ComboBox
    Friend WithEvents lbl_modifyUserType As Label
    Friend WithEvents lbl_identity As Label
    Friend WithEvents txt_identityID As TextBox
    Friend WithEvents lbl_modifyPassword As Label
    Friend WithEvents txt_modifyPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_loginList As DataGridView
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents IdentityBindingSource As BindingSource
    Friend WithEvents IdentityTableAdapter As cash_advance_salary_loanDataSetTableAdapters.identityTableAdapter
    Friend WithEvents identity_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents usertype As DataGridViewTextBoxColumn
    Friend WithEvents IdentityidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
