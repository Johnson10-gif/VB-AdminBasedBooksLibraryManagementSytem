<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnRegisterUser = New System.Windows.Forms.Button()
        Me.btnRegisterBook = New System.Windows.Forms.Button()
        Me.btnPermitBorrowing = New System.Windows.Forms.Button()
        Me.btnViewBookStatus = New System.Windows.Forms.Button()
        Me.btnPermitReturn = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(128, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(560, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ADMIN DASHBOARD"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Gray
        Me.lblWelcome.Location = New System.Drawing.Point(109, 97)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(560, 30)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, Admin"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegisterUser
        '
        Me.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegisterUser.ForeColor = System.Drawing.Color.White
        Me.btnRegisterUser.Location = New System.Drawing.Point(227, 148)
        Me.btnRegisterUser.Name = "btnRegisterUser"
        Me.btnRegisterUser.Size = New System.Drawing.Size(337, 60)
        Me.btnRegisterUser.TabIndex = 2
        Me.btnRegisterUser.Text = "REGISTER USER"
        Me.btnRegisterUser.UseVisualStyleBackColor = False
        '
        'btnRegisterBook
        '
        Me.btnRegisterBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnRegisterBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterBook.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegisterBook.ForeColor = System.Drawing.Color.White
        Me.btnRegisterBook.Location = New System.Drawing.Point(227, 214)
        Me.btnRegisterBook.Name = "btnRegisterBook"
        Me.btnRegisterBook.Size = New System.Drawing.Size(337, 60)
        Me.btnRegisterBook.TabIndex = 3
        Me.btnRegisterBook.Text = "REGISTER BOOK"
        Me.btnRegisterBook.UseVisualStyleBackColor = False
        '
        'btnPermitBorrowing
        '
        Me.btnPermitBorrowing.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnPermitBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermitBorrowing.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPermitBorrowing.ForeColor = System.Drawing.Color.White
        Me.btnPermitBorrowing.Location = New System.Drawing.Point(227, 342)
        Me.btnPermitBorrowing.Name = "btnPermitBorrowing"
        Me.btnPermitBorrowing.Size = New System.Drawing.Size(337, 60)
        Me.btnPermitBorrowing.TabIndex = 4
        Me.btnPermitBorrowing.Text = "PERMIT BORROWING"
        Me.btnPermitBorrowing.UseVisualStyleBackColor = False
        '
        'btnViewBookStatus
        '
        Me.btnViewBookStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnViewBookStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBookStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewBookStatus.ForeColor = System.Drawing.Color.White
        Me.btnViewBookStatus.Location = New System.Drawing.Point(227, 280)
        Me.btnViewBookStatus.Name = "btnViewBookStatus"
        Me.btnViewBookStatus.Size = New System.Drawing.Size(337, 56)
        Me.btnViewBookStatus.TabIndex = 5
        Me.btnViewBookStatus.Text = "VIEW BOOK STATUS"
        Me.btnViewBookStatus.UseVisualStyleBackColor = False
        '
        'btnPermitReturn
        '
        Me.btnPermitReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnPermitReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermitReturn.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnPermitReturn.ForeColor = System.Drawing.Color.White
        Me.btnPermitReturn.Location = New System.Drawing.Point(227, 408)
        Me.btnPermitReturn.Name = "btnPermitReturn"
        Me.btnPermitReturn.Size = New System.Drawing.Size(337, 60)
        Me.btnPermitReturn.TabIndex = 6
        Me.btnPermitReturn.Text = "PERMIT RETURN"
        Me.btnPermitReturn.UseVisualStyleBackColor = False
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Location = New System.Drawing.Point(227, 474)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(337, 60)
        Me.btnGenerateReport.TabIndex = 7
        Me.btnGenerateReport.Text = "GENERATE REPORT"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(299, 540)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 40)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 667)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnPermitReturn)
        Me.Controls.Add(Me.btnViewBookStatus)
        Me.Controls.Add(Me.btnPermitBorrowing)
        Me.Controls.Add(Me.btnRegisterBook)
        Me.Controls.Add(Me.btnRegisterUser)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard - Library Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnRegisterUser As Button
    Friend WithEvents btnRegisterBook As Button
    Friend WithEvents btnPermitBorrowing As Button
    Friend WithEvents btnViewBookStatus As Button
    Friend WithEvents btnPermitReturn As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnLogout As Button
End Class
