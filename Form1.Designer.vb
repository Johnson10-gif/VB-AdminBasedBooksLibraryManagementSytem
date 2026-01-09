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
        btnReturn = New Button()
        btnBorrow = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lstBooks = New ListBox()
        lblCount = New Label()
        Label5 = New Label()
        VScrollBar1 = New VScrollBar()
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
        btnAdd.Location = New Point(101, 144)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(148, 41)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add Book"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.Green
        btnDisplay.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDisplay.ForeColor = Color.White
        btnDisplay.Location = New Point(101, 206)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(148, 41)
        btnDisplay.TabIndex = 5
        btnDisplay.Text = "Display Books"
        btnDisplay.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Lime
        btnSave.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(565, 499)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 47)
        btnSave.TabIndex = 7
        btnSave.Text = "save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Green
        btnReturn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(101, 333)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(148, 47)
        btnReturn.TabIndex = 8
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnBorrow
        ' 
        btnBorrow.BackColor = Color.Green
        btnBorrow.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBorrow.ForeColor = Color.White
        btnBorrow.Location = New Point(101, 263)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(148, 47)
        btnBorrow.TabIndex = 9
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(340, 499)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(148, 47)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
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
        ' lstBooks
        ' 
        lstBooks.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstBooks.FormattingEnabled = True
        lstBooks.ItemHeight = 23
        lstBooks.Location = New Point(707, 144)
        lstBooks.Name = "lstBooks"
        lstBooks.Size = New Size(396, 257)
        lstBooks.TabIndex = 15
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount.Location = New Point(815, 416)
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
        Label5.Location = New Point(216, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(607, 31)
        Label5.TabIndex = 17
        Label5.Text = "WELCOME TO LIBRARY BOOKS MANAGEMENT SYSTEM"
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(1077, 144)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(26, 257)
        VScrollBar1.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1115, 726)
        Controls.Add(VScrollBar1)
        Controls.Add(Label5)
        Controls.Add(lblCount)
        Controls.Add(lstBooks)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnBorrow)
        Controls.Add(btnReturn)
        Controls.Add(btnSave)
        Controls.Add(btnDisplay)
        Controls.Add(btnAdd)
        Controls.Add(txtTittle)
        Controls.Add(txtAuthor)
        Controls.Add(year)
        Controls.Add(txtID)
        Name = "Form1"
        Text = "Form1"
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
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents lblCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents VScrollBar1 As VScrollBar

End Class
