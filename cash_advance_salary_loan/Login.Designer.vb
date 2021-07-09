<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_employeeID = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_usertype = New System.Windows.Forms.Label()
        Me.cmb_userType = New System.Windows.Forms.ComboBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_employeeID
        '
        Me.lbl_employeeID.AutoSize = True
        Me.lbl_employeeID.Location = New System.Drawing.Point(42, 146)
        Me.lbl_employeeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_employeeID.Name = "lbl_employeeID"
        Me.lbl_employeeID.Size = New System.Drawing.Size(70, 13)
        Me.lbl_employeeID.TabIndex = 0
        Me.lbl_employeeID.Text = "Employee ID:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.Location = New System.Drawing.Point(115, 143)
        Me.txt_employeeID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(73, 20)
        Me.txt_employeeID.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(115, 166)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(140, 20)
        Me.txt_password.TabIndex = 3
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(56, 169)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(56, 13)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Password:"
        '
        'lbl_usertype
        '
        Me.lbl_usertype.AutoSize = True
        Me.lbl_usertype.Location = New System.Drawing.Point(52, 191)
        Me.lbl_usertype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usertype.Name = "lbl_usertype"
        Me.lbl_usertype.Size = New System.Drawing.Size(59, 13)
        Me.lbl_usertype.TabIndex = 4
        Me.lbl_usertype.Text = "User Type:"
        '
        'cmb_userType
        '
        Me.cmb_userType.FormattingEnabled = True
        Me.cmb_userType.Items.AddRange(New Object() {"Admin", "Authorizer", "User"})
        Me.cmb_userType.Location = New System.Drawing.Point(115, 189)
        Me.cmb_userType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_userType.Name = "cmb_userType"
        Me.cmb_userType.Size = New System.Drawing.Size(140, 21)
        Me.cmb_userType.TabIndex = 6
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_login.Location = New System.Drawing.Point(126, 221)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(107, 34)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(115, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(344, 298)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.cmb_userType)
        Me.Controls.Add(Me.lbl_usertype)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.lbl_employeeID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_employeeID As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_usertype As Label
    Friend WithEvents cmb_userType As ComboBox
    Friend WithEvents btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
