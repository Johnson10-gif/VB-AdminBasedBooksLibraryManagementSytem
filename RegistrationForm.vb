Public Class RegistrationForm
    Inherits Form

    Private WithEvents txtFullName As TextBox
    Private WithEvents txtUsername As TextBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtConfirmPassword As TextBox
    Private WithEvents btnRegister As Button
    Private WithEvents btnBack As Button
    Private lblTitle As Label
    Private lblFullName As Label
    Private lblUsername As Label
    Private lblPassword As Label
    Private lblConfirmPassword As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(85, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER REGISTRATION"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFullName
        '
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(76, 126)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(100, 20)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name:"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullName.Location = New System.Drawing.Point(80, 160)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(340, 30)
        Me.txtFullName.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(76, 225)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(100, 20)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(80, 258)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(340, 30)
        Me.txtUsername.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(80, 325)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(100, 20)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(80, 348)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(340, 30)
        Me.txtPassword.TabIndex = 6
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(80, 403)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(172, 22)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(84, 437)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(340, 30)
        Me.txtConfirmPassword.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(84, 502)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(160, 35)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(294, 502)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 35)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "BACK TO LOGIN"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'RegistrationForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(627, 596)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System - Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPassword.Clear()
            txtConfirmPassword.Focus()
            Return
        End If

        Try
            DatabaseHelper.RegisterUser(txtFullName.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text)
            MessageBox.Show("Registration successful! You can now login with your credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Go back to login
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        Catch ex As Exception
            If ex.Message.Contains("Duplicate") OrElse ex.Message.Contains("unique") OrElse ex.Message.Contains("exists") Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
            Else
                MessageBox.Show("Registration error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub RegistrationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub

End Class
