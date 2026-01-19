<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtID = New TextBox()
        year = New TextBox()
        txtAuthor = New TextBox()
        txtTittle = New TextBox()
        btnAdd = New Button()
        btnDisplay = New Button()
        btnSave = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblCount = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuLogout = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        mnuBooks = New ToolStripMenuItem()
        mnuAddBook = New ToolStripMenuItem()
        mnuDisplayBooks = New ToolStripMenuItem()
        mnuTransactions = New ToolStripMenuItem()
        mnuBorrow = New ToolStripMenuItem()
        mnuReturn = New ToolStripMenuItem()
        mnuReports = New ToolStripMenuItem()
        mnuTotalBooks = New ToolStripMenuItem()
        mnuBorrowedBooks = New ToolStripMenuItem()
        mnuAvailableBooks = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(442, 144)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(259, 46)
        txtID.TabIndex = 0
        ' 
        ' year
        ' 
        year.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        year.Location = New Point(442, 365)
        year.Multiline = True
        year.Name = "year"
        year.Size = New Size(259, 46)
        year.TabIndex = 1
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtAuthor.Location = New Point(442, 288)
        txtAuthor.Multiline = True
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(259, 46)
        txtAuthor.TabIndex = 2
        ' 
        ' txtTittle
        ' 
        txtTittle.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTittle.Location = New Point(442, 214)
        txtTittle.Multiline = True
        txtTittle.Name = "txtTittle"
        txtTittle.Size = New Size(259, 46)
        txtTittle.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(122, 260)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(171, 41)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add Book"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.Green
        btnDisplay.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.ForeColor = Color.White
        btnDisplay.Location = New Point(814, 260)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(173, 41)
        btnDisplay.TabIndex = 5
        btnDisplay.Text = "Display Books"
        btnDisplay.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Lime
        btnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(500, 489)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 47)
        btnSave.TabIndex = 7
        btnSave.Text = "save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 28)
        Label1.TabIndex = 11
        Label1.Text = "Book ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(323, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 28)
        Label2.TabIndex = 12
        Label2.Text = "Book Tittle"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(323, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 28)
        Label3.TabIndex = 13
        Label3.Text = "Author"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(323, 383)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 28)
        Label4.TabIndex = 14
        Label4.Text = "Year"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount.Location = New Point(831, 215)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(134, 25)
        lblCount.TabIndex = 16
        lblCount.Text = "TOTAL BOOKS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(263, 585)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 31)
        Label5.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(1002, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(113, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.InactiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuBooks, mnuTransactions, mnuReports, mnuHelp})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1115, 33)
        MenuStrip1.TabIndex = 19
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuLogout, mnuExit})
        mnuFile.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuFile.ForeColor = SystemColors.ActiveCaptionText
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(55, 29)
        mnuFile.Text = "File"
        ' 
        ' mnuLogout
        ' 
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(158, 30)
        mnuLogout.Text = "Logout"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(158, 30)
        mnuExit.Text = "Exit"
        ' 
        ' mnuBooks
        ' 
        mnuBooks.DropDownItems.AddRange(New ToolStripItem() {mnuAddBook, mnuDisplayBooks})
        mnuBooks.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuBooks.Name = "mnuBooks"
        mnuBooks.Size = New Size(76, 29)
        mnuBooks.Text = "Books"
        ' 
        ' mnuAddBook
        ' 
        mnuAddBook.Name = "mnuAddBook"
        mnuAddBook.Size = New Size(222, 30)
        mnuAddBook.Text = "Add New Book"
        ' 
        ' mnuDisplayBooks
        ' 
        mnuDisplayBooks.Name = "mnuDisplayBooks"
        mnuDisplayBooks.Size = New Size(222, 30)
        mnuDisplayBooks.Text = "Display Books"
        ' 
        ' mnuTransactions
        ' 
        mnuTransactions.DropDownItems.AddRange(New ToolStripItem() {mnuBorrow, mnuReturn})
        mnuTransactions.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuTransactions.Name = "mnuTransactions"
        mnuTransactions.Size = New Size(118, 29)
        mnuTransactions.Text = "Transactions"
        ' 
        ' mnuBorrow
        ' 
        mnuBorrow.Name = "mnuBorrow"
        mnuBorrow.Size = New Size(193, 28)
        mnuBorrow.Text = "Borrow Book"
        ' 
        ' mnuReturn
        ' 
        mnuReturn.Name = "mnuReturn"
        mnuReturn.Size = New Size(193, 28)
        mnuReturn.Text = "Return Book"
        ' 
        ' mnuReports
        ' 
        mnuReports.DropDownItems.AddRange(New ToolStripItem() {mnuTotalBooks, mnuBorrowedBooks, mnuAvailableBooks})
        mnuReports.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuReports.Name = "mnuReports"
        mnuReports.Size = New Size(83, 29)
        mnuReports.Text = "Reports"
        ' 
        ' mnuTotalBooks
        ' 
        mnuTotalBooks.Name = "mnuTotalBooks"
        mnuTotalBooks.Size = New Size(219, 28)
        mnuTotalBooks.Text = "Total Books"
        ' 
        ' mnuBorrowedBooks
        ' 
        mnuBorrowedBooks.Name = "mnuBorrowedBooks"
        mnuBorrowedBooks.Size = New Size(219, 28)
        mnuBorrowedBooks.Text = "Borrowed Books"
        ' 
        ' mnuAvailableBooks
        ' 
        mnuAvailableBooks.Name = "mnuAvailableBooks"
        mnuAvailableBooks.Size = New Size(219, 28)
        mnuAvailableBooks.Text = "Available Books"
        ' 
        ' mnuHelp
        ' 
        mnuHelp.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
        mnuHelp.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(60, 29)
        mnuHelp.Text = "Help"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(194, 28)
        mnuAbout.Text = "About Sytem"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1115, 726)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(lblCount)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(btnDisplay)
        Controls.Add(btnAdd)
        Controls.Add(txtTittle)
        Controls.Add(txtAuthor)
        Controls.Add(year)
        Controls.Add(txtID)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "HomePageForm.vb"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents year As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtTittle As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuBooks As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAddBook As ToolStripMenuItem
    Friend WithEvents mnuDisplayBooks As ToolStripMenuItem
    Friend WithEvents mnuTransactions As ToolStripMenuItem
    Friend WithEvents mnuBorrow As ToolStripMenuItem
    Friend WithEvents mnuReturn As ToolStripMenuItem
    Friend WithEvents mnuReports As ToolStripMenuItem
    Friend WithEvents mnuTotalBooks As ToolStripMenuItem
    Friend WithEvents mnuBorrowedBooks As ToolStripMenuItem
    Friend WithEvents mnuAvailableBooks As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem

End Class
