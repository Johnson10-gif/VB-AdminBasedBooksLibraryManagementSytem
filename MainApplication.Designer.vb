<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApplication
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pnlRegister As Panel
    Friend WithEvents pnlAdminDashboard As Panel
    Friend WithEvents pnlAdminRegisterUser As Panel
    Friend WithEvents pnlAdminRegisterBook As Panel
    Friend WithEvents pnlAdminPermitBorrowing As Panel
    Friend WithEvents pnlAdminViewBookStatus As Panel
    Friend WithEvents pnlAdminPermitReturn As Panel
    Friend WithEvents pnlAdminGenerateReport As Panel
    Friend WithEvents pnlUserDashboard As Panel
    Friend WithEvents pnlUserViewBooks As Panel
    Friend WithEvents pnlUserRequestBook As Panel
    Friend WithEvents pnlUserReturnBook As Panel

    Friend WithEvents txtLoginUsername As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnExitLogin As Button
    Friend WithEvents txtRegFullName As TextBox
    Friend WithEvents txtRegUsername As TextBox
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents txtRegConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBackRegister As Button
    Friend WithEvents lblAdminWelcome As Label
    Friend WithEvents btnAdminRegisterUser As Button
    Friend WithEvents btnAdminRegisterBook As Button
    Friend WithEvents btnAdminPermitBorrowing As Button
    Friend WithEvents btnAdminViewBookStatus As Button
    Friend WithEvents btnAdminPermitReturn As Button
    Friend WithEvents btnAdminGenerateReport As Button
    Friend WithEvents btnAdminLogout As Button
    Friend WithEvents txtAdminUserName As TextBox
    Friend WithEvents txtAdminUserPassword As TextBox
    Friend WithEvents btnAdminSaveUser As Button
    Friend WithEvents btnAdminBackUser As Button
    Friend WithEvents txtAdminBookCode As TextBox
    Friend WithEvents txtAdminBookTitle As TextBox
    Friend WithEvents txtAdminBookAuthor As TextBox
    Friend WithEvents txtAdminBookYear As TextBox
    Friend WithEvents txtAdminBookQuantity As TextBox
    Friend WithEvents btnAdminSaveBook As Button
    Friend WithEvents btnAdminBackBook As Button
    Friend WithEvents dgvBorrowRequests As DataGridView
    Friend WithEvents btnApproveRequest As Button
    Friend WithEvents btnAdminBackBorrow As Button
    Friend WithEvents dgvBookStatus As DataGridView
    Friend WithEvents btnAdminBackStatus As Button
    Friend WithEvents dgvReturnRequests As DataGridView
    Friend WithEvents btnApproveReturn As Button
    Friend WithEvents btnAdminBackReturn As Button
    Friend WithEvents txtAdminReport As TextBox
    Friend WithEvents btnAdminBackReport As Button
    Friend WithEvents lblUserWelcome As Label
    Friend WithEvents btnUserViewBooks As Button
    Friend WithEvents btnUserRequestBook As Button
    Friend WithEvents btnUserReturnBook As Button
    Friend WithEvents btnUserLogout As Button
    Friend WithEvents dgvUserAvailableBooks As DataGridView
    Friend WithEvents btnUserBackViewBooks As Button
    Friend WithEvents txtUserBookID As TextBox
    Friend WithEvents btnUserSubmitRequest As Button
    Friend WithEvents btnUserBackRequest As Button
    Friend WithEvents dgvUserBooks As DataGridView
    Friend WithEvents btnUserSubmitReturn As Button
    Friend WithEvents btnUserBackReturn As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.txtLoginUsername = New System.Windows.Forms.TextBox()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnExitLogin = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.txtRegFullName = New System.Windows.Forms.TextBox()
        Me.txtRegUsername = New System.Windows.Forms.TextBox()
        Me.txtRegPassword = New System.Windows.Forms.TextBox()
        Me.txtRegConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBackRegister = New System.Windows.Forms.Button()
        Me.pnlAdminDashboard = New System.Windows.Forms.Panel()
        Me.lblAdminWelcome = New System.Windows.Forms.Label()
        Me.btnAdminRegisterUser = New System.Windows.Forms.Button()
        Me.btnAdminRegisterBook = New System.Windows.Forms.Button()
        Me.btnAdminPermitBorrowing = New System.Windows.Forms.Button()
        Me.btnAdminViewBookStatus = New System.Windows.Forms.Button()
        Me.btnAdminPermitReturn = New System.Windows.Forms.Button()
        Me.btnAdminGenerateReport = New System.Windows.Forms.Button()
        Me.btnAdminLogout = New System.Windows.Forms.Button()
        Me.pnlAdminRegisterUser = New System.Windows.Forms.Panel()
        Me.txtAdminUserName = New System.Windows.Forms.TextBox()
        Me.txtAdminUserPassword = New System.Windows.Forms.TextBox()
        Me.btnAdminSaveUser = New System.Windows.Forms.Button()
        Me.btnAdminBackUser = New System.Windows.Forms.Button()
        Me.pnlAdminRegisterBook = New System.Windows.Forms.Panel()
        Me.txtAdminBookCode = New System.Windows.Forms.TextBox()
        Me.txtAdminBookTitle = New System.Windows.Forms.TextBox()
        Me.txtAdminBookAuthor = New System.Windows.Forms.TextBox()
        Me.txtAdminBookYear = New System.Windows.Forms.TextBox()
        Me.txtAdminBookQuantity = New System.Windows.Forms.TextBox()
        Me.btnAdminSaveBook = New System.Windows.Forms.Button()
        Me.btnAdminBackBook = New System.Windows.Forms.Button()
        Me.pnlAdminPermitBorrowing = New System.Windows.Forms.Panel()
        Me.dgvBorrowRequests = New System.Windows.Forms.DataGridView()
        Me.btnApproveRequest = New System.Windows.Forms.Button()
        Me.btnAdminBackBorrow = New System.Windows.Forms.Button()
        Me.pnlAdminViewBookStatus = New System.Windows.Forms.Panel()
        Me.dgvBookStatus = New System.Windows.Forms.DataGridView()
        Me.btnAdminBackStatus = New System.Windows.Forms.Button()
        Me.pnlAdminPermitReturn = New System.Windows.Forms.Panel()
        Me.dgvReturnRequests = New System.Windows.Forms.DataGridView()
        Me.btnApproveReturn = New System.Windows.Forms.Button()
        Me.btnAdminBackReturn = New System.Windows.Forms.Button()
        Me.pnlAdminGenerateReport = New System.Windows.Forms.Panel()
        Me.txtAdminReport = New System.Windows.Forms.TextBox()
        Me.btnAdminBackReport = New System.Windows.Forms.Button()
        Me.pnlUserDashboard = New System.Windows.Forms.Panel()
        Me.lblUserWelcome = New System.Windows.Forms.Label()
        Me.btnUserViewBooks = New System.Windows.Forms.Button()
        Me.btnUserRequestBook = New System.Windows.Forms.Button()
        Me.btnUserReturnBook = New System.Windows.Forms.Button()
        Me.btnUserLogout = New System.Windows.Forms.Button()
        Me.pnlUserViewBooks = New System.Windows.Forms.Panel()
        Me.dgvUserAvailableBooks = New System.Windows.Forms.DataGridView()
        Me.btnUserBackViewBooks = New System.Windows.Forms.Button()
        Me.pnlUserRequestBook = New System.Windows.Forms.Panel()
        Me.txtUserBookID = New System.Windows.Forms.TextBox()
        Me.btnUserSubmitRequest = New System.Windows.Forms.Button()
        Me.btnUserBackRequest = New System.Windows.Forms.Button()
        Me.pnlUserReturnBook = New System.Windows.Forms.Panel()
        Me.dgvUserBooks = New System.Windows.Forms.DataGridView()
        Me.btnUserSubmitReturn = New System.Windows.Forms.Button()
        Me.btnUserBackReturn = New System.Windows.Forms.Button()
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.pnlAdminDashboard.SuspendLayout()
        Me.pnlAdminRegisterUser.SuspendLayout()
        Me.pnlAdminRegisterBook.SuspendLayout()
        Me.pnlAdminPermitBorrowing.SuspendLayout()
        CType(Me.dgvBorrowRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdminViewBookStatus.SuspendLayout()
        CType(Me.dgvBookStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdminPermitReturn.SuspendLayout()
        CType(Me.dgvReturnRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdminGenerateReport.SuspendLayout()
        Me.pnlUserDashboard.SuspendLayout()
        Me.pnlUserViewBooks.SuspendLayout()
        CType(Me.dgvUserAvailableBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserRequestBook.SuspendLayout()
        Me.pnlUserReturnBook.SuspendLayout()
        CType(Me.dgvUserBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.txtLoginUsername)
        Me.pnlLogin.Controls.Add(Me.txtLoginPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.btnCreateAccount)
        Me.pnlLogin.Controls.Add(Me.btnExitLogin)
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(1000, 600)
        Me.pnlLogin.TabIndex = 0
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Location = New System.Drawing.Point(350, 200)
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(300, 22)
        Me.txtLoginUsername.TabIndex = 0
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(350, 250)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(300, 22)
        Me.txtLoginPassword.TabIndex = 1
        Me.txtLoginPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(350, 300)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 30)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(460, 300)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(100, 30)
        Me.btnCreateAccount.TabIndex = 3
        Me.btnCreateAccount.Text = "Register"
        '
        'btnExitLogin
        '
        Me.btnExitLogin.Location = New System.Drawing.Point(350, 350)
        Me.btnExitLogin.Name = "btnExitLogin"
        Me.btnExitLogin.Size = New System.Drawing.Size(210, 30)
        Me.btnExitLogin.TabIndex = 4
        Me.btnExitLogin.Text = "Exit"
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.txtRegFullName)
        Me.pnlRegister.Controls.Add(Me.txtRegUsername)
        Me.pnlRegister.Controls.Add(Me.txtRegPassword)
        Me.pnlRegister.Controls.Add(Me.txtRegConfirmPassword)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.btnBackRegister)
        Me.pnlRegister.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(1000, 600)
        Me.pnlRegister.TabIndex = 1
        Me.pnlRegister.Visible = False
        '
        'txtRegFullName
        '
        Me.txtRegFullName.Location = New System.Drawing.Point(350, 150)
        Me.txtRegFullName.Name = "txtRegFullName"
        Me.txtRegFullName.Size = New System.Drawing.Size(300, 22)
        Me.txtRegFullName.TabIndex = 0
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Location = New System.Drawing.Point(350, 200)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.Size = New System.Drawing.Size(300, 22)
        Me.txtRegUsername.TabIndex = 1
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Location = New System.Drawing.Point(350, 250)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.Size = New System.Drawing.Size(300, 22)
        Me.txtRegPassword.TabIndex = 2
        Me.txtRegPassword.UseSystemPasswordChar = True
        '
        'txtRegConfirmPassword
        '
        Me.txtRegConfirmPassword.Location = New System.Drawing.Point(350, 300)
        Me.txtRegConfirmPassword.Name = "txtRegConfirmPassword"
        Me.txtRegConfirmPassword.Size = New System.Drawing.Size(300, 22)
        Me.txtRegConfirmPassword.TabIndex = 3
        Me.txtRegConfirmPassword.UseSystemPasswordChar = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(350, 350)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(140, 30)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        '
        'btnBackRegister
        '
        Me.btnBackRegister.Location = New System.Drawing.Point(510, 350)
        Me.btnBackRegister.Name = "btnBackRegister"
        Me.btnBackRegister.Size = New System.Drawing.Size(140, 30)
        Me.btnBackRegister.TabIndex = 5
        Me.btnBackRegister.Text = "Back"
        '
        'pnlAdminDashboard
        '
        Me.pnlAdminDashboard.Controls.Add(Me.lblAdminWelcome)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminRegisterUser)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminRegisterBook)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminPermitBorrowing)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminViewBookStatus)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminPermitReturn)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminGenerateReport)
        Me.pnlAdminDashboard.Controls.Add(Me.btnAdminLogout)
        Me.pnlAdminDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminDashboard.Name = "pnlAdminDashboard"
        Me.pnlAdminDashboard.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminDashboard.TabIndex = 2
        Me.pnlAdminDashboard.Visible = False
        '
        'lblAdminWelcome
        '
        Me.lblAdminWelcome.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdminWelcome.Location = New System.Drawing.Point(20, 20)
        Me.lblAdminWelcome.Name = "lblAdminWelcome"
        Me.lblAdminWelcome.Size = New System.Drawing.Size(400, 30)
        Me.lblAdminWelcome.TabIndex = 0
        Me.lblAdminWelcome.Text = "Welcome Admin"
        '
        'btnAdminRegisterUser
        '
        Me.btnAdminRegisterUser.Location = New System.Drawing.Point(50, 80)
        Me.btnAdminRegisterUser.Name = "btnAdminRegisterUser"
        Me.btnAdminRegisterUser.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminRegisterUser.TabIndex = 1
        Me.btnAdminRegisterUser.Text = "Register User"
        '
        'btnAdminRegisterBook
        '
        Me.btnAdminRegisterBook.Location = New System.Drawing.Point(250, 80)
        Me.btnAdminRegisterBook.Name = "btnAdminRegisterBook"
        Me.btnAdminRegisterBook.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminRegisterBook.TabIndex = 2
        Me.btnAdminRegisterBook.Text = "Register Book"
        '
        'btnAdminPermitBorrowing
        '
        Me.btnAdminPermitBorrowing.Location = New System.Drawing.Point(450, 80)
        Me.btnAdminPermitBorrowing.Name = "btnAdminPermitBorrowing"
        Me.btnAdminPermitBorrowing.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminPermitBorrowing.TabIndex = 3
        Me.btnAdminPermitBorrowing.Text = "Permit Borrowing"
        '
        'btnAdminViewBookStatus
        '
        Me.btnAdminViewBookStatus.Location = New System.Drawing.Point(650, 80)
        Me.btnAdminViewBookStatus.Name = "btnAdminViewBookStatus"
        Me.btnAdminViewBookStatus.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminViewBookStatus.TabIndex = 4
        Me.btnAdminViewBookStatus.Text = "View Book Status"
        '
        'btnAdminPermitReturn
        '
        Me.btnAdminPermitReturn.Location = New System.Drawing.Point(50, 150)
        Me.btnAdminPermitReturn.Name = "btnAdminPermitReturn"
        Me.btnAdminPermitReturn.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminPermitReturn.TabIndex = 5
        Me.btnAdminPermitReturn.Text = "Permit Return"
        '
        'btnAdminGenerateReport
        '
        Me.btnAdminGenerateReport.Location = New System.Drawing.Point(250, 150)
        Me.btnAdminGenerateReport.Name = "btnAdminGenerateReport"
        Me.btnAdminGenerateReport.Size = New System.Drawing.Size(150, 50)
        Me.btnAdminGenerateReport.TabIndex = 6
        Me.btnAdminGenerateReport.Text = "Generate Report"
        '
        'btnAdminLogout
        '
        Me.btnAdminLogout.Location = New System.Drawing.Point(50, 530)
        Me.btnAdminLogout.Name = "btnAdminLogout"
        Me.btnAdminLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnAdminLogout.TabIndex = 7
        Me.btnAdminLogout.Text = "Logout"
        '
        'pnlAdminRegisterUser
        '
        Me.pnlAdminRegisterUser.Controls.Add(Me.txtAdminUserName)
        Me.pnlAdminRegisterUser.Controls.Add(Me.txtAdminUserPassword)
        Me.pnlAdminRegisterUser.Controls.Add(Me.btnAdminSaveUser)
        Me.pnlAdminRegisterUser.Controls.Add(Me.btnAdminBackUser)
        Me.pnlAdminRegisterUser.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminRegisterUser.Name = "pnlAdminRegisterUser"
        Me.pnlAdminRegisterUser.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminRegisterUser.TabIndex = 3
        Me.pnlAdminRegisterUser.Visible = False
        '
        'txtAdminUserName
        '
        Me.txtAdminUserName.Location = New System.Drawing.Point(350, 150)
        Me.txtAdminUserName.Name = "txtAdminUserName"
        Me.txtAdminUserName.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminUserName.TabIndex = 0
        '
        'txtAdminUserPassword
        '
        Me.txtAdminUserPassword.Location = New System.Drawing.Point(350, 200)
        Me.txtAdminUserPassword.Name = "txtAdminUserPassword"
        Me.txtAdminUserPassword.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminUserPassword.TabIndex = 1
        '
        'btnAdminSaveUser
        '
        Me.btnAdminSaveUser.Location = New System.Drawing.Point(350, 250)
        Me.btnAdminSaveUser.Name = "btnAdminSaveUser"
        Me.btnAdminSaveUser.Size = New System.Drawing.Size(140, 30)
        Me.btnAdminSaveUser.TabIndex = 2
        Me.btnAdminSaveUser.Text = "Save"
        '
        'btnAdminBackUser
        '
        Me.btnAdminBackUser.Location = New System.Drawing.Point(510, 250)
        Me.btnAdminBackUser.Name = "btnAdminBackUser"
        Me.btnAdminBackUser.Size = New System.Drawing.Size(140, 30)
        Me.btnAdminBackUser.TabIndex = 3
        Me.btnAdminBackUser.Text = "Back"
        '
        'pnlAdminRegisterBook
        '
        Me.pnlAdminRegisterBook.Controls.Add(Me.txtAdminBookCode)
        Me.pnlAdminRegisterBook.Controls.Add(Me.txtAdminBookTitle)
        Me.pnlAdminRegisterBook.Controls.Add(Me.txtAdminBookAuthor)
        Me.pnlAdminRegisterBook.Controls.Add(Me.txtAdminBookYear)
        Me.pnlAdminRegisterBook.Controls.Add(Me.txtAdminBookQuantity)
        Me.pnlAdminRegisterBook.Controls.Add(Me.btnAdminSaveBook)
        Me.pnlAdminRegisterBook.Controls.Add(Me.btnAdminBackBook)
        Me.pnlAdminRegisterBook.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminRegisterBook.Name = "pnlAdminRegisterBook"
        Me.pnlAdminRegisterBook.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminRegisterBook.TabIndex = 4
        Me.pnlAdminRegisterBook.Visible = False
        '
        'txtAdminBookCode
        '
        Me.txtAdminBookCode.Location = New System.Drawing.Point(350, 100)
        Me.txtAdminBookCode.Name = "txtAdminBookCode"
        Me.txtAdminBookCode.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminBookCode.TabIndex = 0
        '
        'txtAdminBookTitle
        '
        Me.txtAdminBookTitle.Location = New System.Drawing.Point(350, 150)
        Me.txtAdminBookTitle.Name = "txtAdminBookTitle"
        Me.txtAdminBookTitle.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminBookTitle.TabIndex = 1
        '
        'txtAdminBookAuthor
        '
        Me.txtAdminBookAuthor.Location = New System.Drawing.Point(350, 200)
        Me.txtAdminBookAuthor.Name = "txtAdminBookAuthor"
        Me.txtAdminBookAuthor.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminBookAuthor.TabIndex = 2
        '
        'txtAdminBookYear
        '
        Me.txtAdminBookYear.Location = New System.Drawing.Point(350, 250)
        Me.txtAdminBookYear.Name = "txtAdminBookYear"
        Me.txtAdminBookYear.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminBookYear.TabIndex = 3
        '
        'txtAdminBookQuantity
        '
        Me.txtAdminBookQuantity.Location = New System.Drawing.Point(350, 300)
        Me.txtAdminBookQuantity.Name = "txtAdminBookQuantity"
        Me.txtAdminBookQuantity.Size = New System.Drawing.Size(300, 22)
        Me.txtAdminBookQuantity.TabIndex = 4
        '
        'btnAdminSaveBook
        '
        Me.btnAdminSaveBook.Location = New System.Drawing.Point(350, 350)
        Me.btnAdminSaveBook.Name = "btnAdminSaveBook"
        Me.btnAdminSaveBook.Size = New System.Drawing.Size(140, 30)
        Me.btnAdminSaveBook.TabIndex = 5
        Me.btnAdminSaveBook.Text = "Save"
        '
        'btnAdminBackBook
        '
        Me.btnAdminBackBook.Location = New System.Drawing.Point(510, 350)
        Me.btnAdminBackBook.Name = "btnAdminBackBook"
        Me.btnAdminBackBook.Size = New System.Drawing.Size(140, 30)
        Me.btnAdminBackBook.TabIndex = 6
        Me.btnAdminBackBook.Text = "Back"
        '
        'pnlAdminPermitBorrowing
        '
        Me.pnlAdminPermitBorrowing.Controls.Add(Me.dgvBorrowRequests)
        Me.pnlAdminPermitBorrowing.Controls.Add(Me.btnApproveRequest)
        Me.pnlAdminPermitBorrowing.Controls.Add(Me.btnAdminBackBorrow)
        Me.pnlAdminPermitBorrowing.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminPermitBorrowing.Name = "pnlAdminPermitBorrowing"
        Me.pnlAdminPermitBorrowing.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminPermitBorrowing.TabIndex = 5
        Me.pnlAdminPermitBorrowing.Visible = False
        '
        'dgvBorrowRequests
        '
        Me.dgvBorrowRequests.ColumnHeadersHeight = 29
        Me.dgvBorrowRequests.Location = New System.Drawing.Point(20, 50)
        Me.dgvBorrowRequests.Name = "dgvBorrowRequests"
        Me.dgvBorrowRequests.RowHeadersWidth = 51
        Me.dgvBorrowRequests.Size = New System.Drawing.Size(700, 400)
        Me.dgvBorrowRequests.TabIndex = 0
        '
        'btnApproveRequest
        '
        Me.btnApproveRequest.Location = New System.Drawing.Point(750, 100)
        Me.btnApproveRequest.Name = "btnApproveRequest"
        Me.btnApproveRequest.Size = New System.Drawing.Size(100, 30)
        Me.btnApproveRequest.TabIndex = 1
        Me.btnApproveRequest.Text = "Approve"
        '
        'btnAdminBackBorrow
        '
        Me.btnAdminBackBorrow.Location = New System.Drawing.Point(20, 530)
        Me.btnAdminBackBorrow.Name = "btnAdminBackBorrow"
        Me.btnAdminBackBorrow.Size = New System.Drawing.Size(100, 30)
        Me.btnAdminBackBorrow.TabIndex = 2
        Me.btnAdminBackBorrow.Text = "Back"
        '
        'pnlAdminViewBookStatus
        '
        Me.pnlAdminViewBookStatus.Controls.Add(Me.dgvBookStatus)
        Me.pnlAdminViewBookStatus.Controls.Add(Me.btnAdminBackStatus)
        Me.pnlAdminViewBookStatus.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminViewBookStatus.Name = "pnlAdminViewBookStatus"
        Me.pnlAdminViewBookStatus.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminViewBookStatus.TabIndex = 6
        Me.pnlAdminViewBookStatus.Visible = False
        '
        'dgvBookStatus
        '
        Me.dgvBookStatus.ColumnHeadersHeight = 29
        Me.dgvBookStatus.Location = New System.Drawing.Point(20, 50)
        Me.dgvBookStatus.Name = "dgvBookStatus"
        Me.dgvBookStatus.RowHeadersWidth = 51
        Me.dgvBookStatus.Size = New System.Drawing.Size(900, 450)
        Me.dgvBookStatus.TabIndex = 0
        '
        'btnAdminBackStatus
        '
        Me.btnAdminBackStatus.Location = New System.Drawing.Point(20, 530)
        Me.btnAdminBackStatus.Name = "btnAdminBackStatus"
        Me.btnAdminBackStatus.Size = New System.Drawing.Size(100, 30)
        Me.btnAdminBackStatus.TabIndex = 1
        Me.btnAdminBackStatus.Text = "Back"
        '
        'pnlAdminPermitReturn
        '
        Me.pnlAdminPermitReturn.Controls.Add(Me.dgvReturnRequests)
        Me.pnlAdminPermitReturn.Controls.Add(Me.btnApproveReturn)
        Me.pnlAdminPermitReturn.Controls.Add(Me.btnAdminBackReturn)
        Me.pnlAdminPermitReturn.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminPermitReturn.Name = "pnlAdminPermitReturn"
        Me.pnlAdminPermitReturn.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminPermitReturn.TabIndex = 7
        Me.pnlAdminPermitReturn.Visible = False
        '
        'dgvReturnRequests
        '
        Me.dgvReturnRequests.ColumnHeadersHeight = 29
        Me.dgvReturnRequests.Location = New System.Drawing.Point(20, 50)
        Me.dgvReturnRequests.Name = "dgvReturnRequests"
        Me.dgvReturnRequests.RowHeadersWidth = 51
        Me.dgvReturnRequests.Size = New System.Drawing.Size(700, 400)
        Me.dgvReturnRequests.TabIndex = 0
        '
        'btnApproveReturn
        '
        Me.btnApproveReturn.Location = New System.Drawing.Point(750, 100)
        Me.btnApproveReturn.Name = "btnApproveReturn"
        Me.btnApproveReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnApproveReturn.TabIndex = 1
        Me.btnApproveReturn.Text = "Approve"
        '
        'btnAdminBackReturn
        '
        Me.btnAdminBackReturn.Location = New System.Drawing.Point(20, 530)
        Me.btnAdminBackReturn.Name = "btnAdminBackReturn"
        Me.btnAdminBackReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnAdminBackReturn.TabIndex = 2
        Me.btnAdminBackReturn.Text = "Back"
        '
        'pnlAdminGenerateReport
        '
        Me.pnlAdminGenerateReport.Controls.Add(Me.txtAdminReport)
        Me.pnlAdminGenerateReport.Controls.Add(Me.btnAdminBackReport)
        Me.pnlAdminGenerateReport.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminGenerateReport.Name = "pnlAdminGenerateReport"
        Me.pnlAdminGenerateReport.Size = New System.Drawing.Size(1000, 600)
        Me.pnlAdminGenerateReport.TabIndex = 8
        Me.pnlAdminGenerateReport.Visible = False
        '
        'txtAdminReport
        '
        Me.txtAdminReport.Location = New System.Drawing.Point(50, 50)
        Me.txtAdminReport.Multiline = True
        Me.txtAdminReport.Name = "txtAdminReport"
        Me.txtAdminReport.ReadOnly = True
        Me.txtAdminReport.Size = New System.Drawing.Size(800, 450)
        Me.txtAdminReport.TabIndex = 0
        '
        'btnAdminBackReport
        '
        Me.btnAdminBackReport.Location = New System.Drawing.Point(50, 530)
        Me.btnAdminBackReport.Name = "btnAdminBackReport"
        Me.btnAdminBackReport.Size = New System.Drawing.Size(100, 30)
        Me.btnAdminBackReport.TabIndex = 1
        Me.btnAdminBackReport.Text = "Back"
        '
        'pnlUserDashboard
        '
        Me.pnlUserDashboard.Controls.Add(Me.lblUserWelcome)
        Me.pnlUserDashboard.Controls.Add(Me.btnUserViewBooks)
        Me.pnlUserDashboard.Controls.Add(Me.btnUserRequestBook)
        Me.pnlUserDashboard.Controls.Add(Me.btnUserReturnBook)
        Me.pnlUserDashboard.Controls.Add(Me.btnUserLogout)
        Me.pnlUserDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserDashboard.Name = "pnlUserDashboard"
        Me.pnlUserDashboard.Size = New System.Drawing.Size(1000, 600)
        Me.pnlUserDashboard.TabIndex = 9
        Me.pnlUserDashboard.Visible = False
        '
        'lblUserWelcome
        '
        Me.lblUserWelcome.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserWelcome.Location = New System.Drawing.Point(20, 20)
        Me.lblUserWelcome.Name = "lblUserWelcome"
        Me.lblUserWelcome.Size = New System.Drawing.Size(400, 30)
        Me.lblUserWelcome.TabIndex = 0
        Me.lblUserWelcome.Text = "Welcome User"
        '
        'btnUserViewBooks
        '
        Me.btnUserViewBooks.Location = New System.Drawing.Point(50, 80)
        Me.btnUserViewBooks.Name = "btnUserViewBooks"
        Me.btnUserViewBooks.Size = New System.Drawing.Size(150, 50)
        Me.btnUserViewBooks.TabIndex = 1
        Me.btnUserViewBooks.Text = "View Books"
        '
        'btnUserRequestBook
        '
        Me.btnUserRequestBook.Location = New System.Drawing.Point(250, 80)
        Me.btnUserRequestBook.Name = "btnUserRequestBook"
        Me.btnUserRequestBook.Size = New System.Drawing.Size(150, 50)
        Me.btnUserRequestBook.TabIndex = 2
        Me.btnUserRequestBook.Text = "Request Book"
        '
        'btnUserReturnBook
        '
        Me.btnUserReturnBook.Location = New System.Drawing.Point(450, 80)
        Me.btnUserReturnBook.Name = "btnUserReturnBook"
        Me.btnUserReturnBook.Size = New System.Drawing.Size(150, 50)
        Me.btnUserReturnBook.TabIndex = 3
        Me.btnUserReturnBook.Text = "Return Book"
        '
        'btnUserLogout
        '
        Me.btnUserLogout.Location = New System.Drawing.Point(50, 530)
        Me.btnUserLogout.Name = "btnUserLogout"
        Me.btnUserLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnUserLogout.TabIndex = 4
        Me.btnUserLogout.Text = "Logout"
        '
        'pnlUserViewBooks
        '
        Me.pnlUserViewBooks.Controls.Add(Me.dgvUserAvailableBooks)
        Me.pnlUserViewBooks.Controls.Add(Me.btnUserBackViewBooks)
        Me.pnlUserViewBooks.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserViewBooks.Name = "pnlUserViewBooks"
        Me.pnlUserViewBooks.Size = New System.Drawing.Size(1000, 600)
        Me.pnlUserViewBooks.TabIndex = 10
        Me.pnlUserViewBooks.Visible = False
        '
        'dgvUserAvailableBooks
        '
        Me.dgvUserAvailableBooks.ColumnHeadersHeight = 29
        Me.dgvUserAvailableBooks.Location = New System.Drawing.Point(20, 50)
        Me.dgvUserAvailableBooks.Name = "dgvUserAvailableBooks"
        Me.dgvUserAvailableBooks.RowHeadersWidth = 51
        Me.dgvUserAvailableBooks.Size = New System.Drawing.Size(900, 450)
        Me.dgvUserAvailableBooks.TabIndex = 0
        '
        'btnUserBackViewBooks
        '
        Me.btnUserBackViewBooks.Location = New System.Drawing.Point(20, 530)
        Me.btnUserBackViewBooks.Name = "btnUserBackViewBooks"
        Me.btnUserBackViewBooks.Size = New System.Drawing.Size(100, 30)
        Me.btnUserBackViewBooks.TabIndex = 1
        Me.btnUserBackViewBooks.Text = "Back"
        '
        'pnlUserRequestBook
        '
        Me.pnlUserRequestBook.Controls.Add(Me.txtUserBookID)
        Me.pnlUserRequestBook.Controls.Add(Me.btnUserSubmitRequest)
        Me.pnlUserRequestBook.Controls.Add(Me.btnUserBackRequest)
        Me.pnlUserRequestBook.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserRequestBook.Name = "pnlUserRequestBook"
        Me.pnlUserRequestBook.Size = New System.Drawing.Size(1000, 600)
        Me.pnlUserRequestBook.TabIndex = 11
        Me.pnlUserRequestBook.Visible = False
        '
        'txtUserBookID
        '
        Me.txtUserBookID.Location = New System.Drawing.Point(350, 200)
        Me.txtUserBookID.Name = "txtUserBookID"
        Me.txtUserBookID.Size = New System.Drawing.Size(300, 22)
        Me.txtUserBookID.TabIndex = 0
        '
        'btnUserSubmitRequest
        '
        Me.btnUserSubmitRequest.Location = New System.Drawing.Point(350, 250)
        Me.btnUserSubmitRequest.Name = "btnUserSubmitRequest"
        Me.btnUserSubmitRequest.Size = New System.Drawing.Size(140, 30)
        Me.btnUserSubmitRequest.TabIndex = 1
        Me.btnUserSubmitRequest.Text = "Submit"
        '
        'btnUserBackRequest
        '
        Me.btnUserBackRequest.Location = New System.Drawing.Point(510, 250)
        Me.btnUserBackRequest.Name = "btnUserBackRequest"
        Me.btnUserBackRequest.Size = New System.Drawing.Size(140, 30)
        Me.btnUserBackRequest.TabIndex = 2
        Me.btnUserBackRequest.Text = "Back"
        '
        'pnlUserReturnBook
        '
        Me.pnlUserReturnBook.Controls.Add(Me.dgvUserBooks)
        Me.pnlUserReturnBook.Controls.Add(Me.btnUserSubmitReturn)
        Me.pnlUserReturnBook.Controls.Add(Me.btnUserBackReturn)
        Me.pnlUserReturnBook.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserReturnBook.Name = "pnlUserReturnBook"
        Me.pnlUserReturnBook.Size = New System.Drawing.Size(1000, 600)
        Me.pnlUserReturnBook.TabIndex = 12
        Me.pnlUserReturnBook.Visible = False
        '
        'dgvUserBooks
        '
        Me.dgvUserBooks.ColumnHeadersHeight = 29
        Me.dgvUserBooks.Location = New System.Drawing.Point(20, 50)
        Me.dgvUserBooks.Name = "dgvUserBooks"
        Me.dgvUserBooks.RowHeadersWidth = 51
        Me.dgvUserBooks.Size = New System.Drawing.Size(700, 400)
        Me.dgvUserBooks.TabIndex = 0
        '
        'btnUserSubmitReturn
        '
        Me.btnUserSubmitReturn.Location = New System.Drawing.Point(750, 100)
        Me.btnUserSubmitReturn.Name = "btnUserSubmitReturn"
        Me.btnUserSubmitReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnUserSubmitReturn.TabIndex = 1
        Me.btnUserSubmitReturn.Text = "Return"
        '
        'btnUserBackReturn
        '
        Me.btnUserBackReturn.Location = New System.Drawing.Point(20, 530)
        Me.btnUserBackReturn.Name = "btnUserBackReturn"
        Me.btnUserBackReturn.Size = New System.Drawing.Size(100, 30)
        Me.btnUserBackReturn.TabIndex = 2
        Me.btnUserBackReturn.Text = "Back"
        '
        'MainApplication
        '
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlAdminDashboard)
        Me.Controls.Add(Me.pnlAdminRegisterUser)
        Me.Controls.Add(Me.pnlAdminRegisterBook)
        Me.Controls.Add(Me.pnlAdminPermitBorrowing)
        Me.Controls.Add(Me.pnlAdminViewBookStatus)
        Me.Controls.Add(Me.pnlAdminPermitReturn)
        Me.Controls.Add(Me.pnlAdminGenerateReport)
        Me.Controls.Add(Me.pnlUserDashboard)
        Me.Controls.Add(Me.pnlUserViewBooks)
        Me.Controls.Add(Me.pnlUserRequestBook)
        Me.Controls.Add(Me.pnlUserReturnBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.pnlAdminDashboard.ResumeLayout(False)
        Me.pnlAdminRegisterUser.ResumeLayout(False)
        Me.pnlAdminRegisterUser.PerformLayout()
        Me.pnlAdminRegisterBook.ResumeLayout(False)
        Me.pnlAdminRegisterBook.PerformLayout()
        Me.pnlAdminPermitBorrowing.ResumeLayout(False)
        CType(Me.dgvBorrowRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdminViewBookStatus.ResumeLayout(False)
        CType(Me.dgvBookStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdminPermitReturn.ResumeLayout(False)
        CType(Me.dgvReturnRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdminGenerateReport.ResumeLayout(False)
        Me.pnlAdminGenerateReport.PerformLayout()
        Me.pnlUserDashboard.ResumeLayout(False)
        Me.pnlUserViewBooks.ResumeLayout(False)
        CType(Me.dgvUserAvailableBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserRequestBook.ResumeLayout(False)
        Me.pnlUserRequestBook.PerformLayout()
        Me.pnlUserReturnBook.ResumeLayout(False)
        CType(Me.dgvUserBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
