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
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(427, 31)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ALL LIBRARY BOOKS"
        ' 
        ' lstAllBooks
        ' 
        lstAllBooks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstAllBooks.FormattingEnabled = True
        lstAllBooks.IntegralHeight = False
        lstAllBooks.ItemHeight = 28
        lstAllBooks.Location = New Point(254, 79)
        lstAllBooks.Name = "lstAllBooks"
        lstAllBooks.ScrollAlwaysVisible = True
        lstAllBooks.Size = New Size(617, 340)
        lstAllBooks.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(336, 464)
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
        btnBorrow.Location = New Point(40, 163)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(165, 50)
        btnBorrow.TabIndex = 3
        btnBorrow.Text = "Borrow Book"
        btnBorrow.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Green
        btnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(40, 255)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(165, 50)
        btnReturn.TabIndex = 4
        btnReturn.Text = "Return Book"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.Black
        btnDelete.Location = New Point(649, 464)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(140, 61)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete Book"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' DisplayBooksForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1052, 630)
        Controls.Add(btnDelete)
        Controls.Add(btnReturn)
        Controls.Add(btnBorrow)
        Controls.Add(Button1)
        Controls.Add(lstAllBooks)
        Controls.Add(lblTitle)
        ForeColor = Color.Blue
        Name = "DisplayBooksForm"
        Text = "DisplayBooksForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstAllBooks As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
End Class
