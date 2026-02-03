<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayBooksForm
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
        lblTitle = New Label()
        lstAllBooks = New ListBox()
        Button1 = New Button()
        btnBorrow = New Button()
        btnReturn = New Button()
        btnDelete = New Button()
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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Ivory
        lblTitle.Image = My.Resources.Resources.images3
        lblTitle.Location = New Point(450, 83)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(309, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ALL LIBRARY BOOKS"
        ' 
        ' lstAllBooks
        ' 
        lstAllBooks.BackColor = Color.DarkSlateGray
        lstAllBooks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstAllBooks.ForeColor = Color.White
        lstAllBooks.FormattingEnabled = True
        lstAllBooks.IntegralHeight = False
        lstAllBooks.ItemHeight = 28
        lstAllBooks.Location = New Point(208, 136)
        lstAllBooks.Name = "lstAllBooks"
        lstAllBooks.ScrollAlwaysVisible = True
        lstAllBooks.Size = New Size(794, 426)
        lstAllBooks.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(353, 568)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 61)
        Button1.TabIndex = 2
        Button1.Text = "close"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.Green
        btnBorrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(12, 187)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(152, 50)
        btnBorrow.TabIndex = 3
        btnBorrow.Text = "Borrow Book"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Green
        btnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(7, 305)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(157, 50)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return Book"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(709, 568)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(140, 61)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete Book"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DarkSeaGreen
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuBooks, mnuTransactions, mnuReports, mnuHelp})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1185, 33)
        MenuStrip1.TabIndex = 20
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
        mnuLogout.BackgroundImageLayout = ImageLayout.None
        mnuLogout.Image = My.Resources.Resources.images__1_
        mnuLogout.ImageAlign = ContentAlignment.MiddleLeft
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(158, 30)
        mnuLogout.Text = "Logout"
        ' 
        ' mnuExit
        ' 
        mnuExit.Image = My.Resources.Resources.images__1_1
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(158, 30)
        mnuExit.Text = "Exit"
        ' 
        ' mnuBooks
        ' 
        mnuBooks.DropDownItems.AddRange(New ToolStripItem() {mnuAddBook, mnuDisplayBooks})
        mnuBooks.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mnuBooks.ForeColor = Color.Black
        mnuBooks.Name = "mnuBooks"
        mnuBooks.Size = New Size(76, 29)
        mnuBooks.Text = "Books"
        ' 
        ' mnuAddBook
        ' 
        mnuAddBook.Image = My.Resources.Resources.add_book1
        mnuAddBook.Name = "mnuAddBook"
        mnuAddBook.Size = New Size(222, 30)
        mnuAddBook.Text = "Add New Book"
        ' 
        ' mnuDisplayBooks
        ' 
        mnuDisplayBooks.Image = My.Resources.Resources.images__2_
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
        mnuReturn.Image = My.Resources.Resources.return_book
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
        mnuTotalBooks.Image = My.Resources.Resources.images__2_1
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
        ' DisplayBooksForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = My.Resources.Resources.images3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1185, 654)
        Controls.Add(MenuStrip1)
        Controls.Add(btnDelete)
        Controls.Add(btnReturn)
        Controls.Add(btnBorrow)
        Controls.Add(Button1)
        Controls.Add(lstAllBooks)
        Controls.Add(lblTitle)
        ForeColor = Color.Blue
        Name = "DisplayBooksForm"
        Text = "DisplayBooksForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstAllBooks As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuBooks As ToolStripMenuItem
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
