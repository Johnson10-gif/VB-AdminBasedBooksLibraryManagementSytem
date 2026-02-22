Imports System.Data.SqlClient

Public Class AdminRegisterBook
    Inherits Form

    Private WithEvents txtBookCode As TextBox
    Private WithEvents txtTitle As TextBox
    Private WithEvents txtAuthor As TextBox
    Private WithEvents txtYear As TextBox
    Private WithEvents txtQuantity As TextBox
    Private WithEvents btnSave As Button
    Private WithEvents btnCancel As Button
    Friend WithEvents lblBookCode As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private lblTitle As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBookCode = New System.Windows.Forms.Label()
        Me.txtBookCode = New System.Windows.Forms.TextBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(91, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(460, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REGISTER NEW BOOK"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBookCode
        '
        Me.lblBookCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCode.Location = New System.Drawing.Point(57, 173)
        Me.lblBookCode.Name = "lblBookCode"
        Me.lblBookCode.Size = New System.Drawing.Size(129, 32)
        Me.lblBookCode.TabIndex = 1
        Me.lblBookCode.Text = "Book Code:"
        '
        'txtBookCode
        '
        Me.txtBookCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtBookCode.Location = New System.Drawing.Point(192, 162)
        Me.txtBookCode.Multiline = True
        Me.txtBookCode.Name = "txtBookCode"
        Me.txtBookCode.Size = New System.Drawing.Size(340, 43)
        Me.txtBookCode.TabIndex = 2
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(99, 270)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(100, 20)
        Me.lblBookTitle.TabIndex = 3
        Me.lblBookTitle.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTitle.Location = New System.Drawing.Point(192, 248)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(340, 42)
        Me.txtTitle.TabIndex = 4
        '
        'lblAuthor
        '
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(99, 351)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(100, 20)
        Me.lblAuthor.TabIndex = 5
        Me.lblAuthor.Text = "Author:"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAuthor.Location = New System.Drawing.Point(192, 331)
        Me.txtAuthor.Multiline = True
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(340, 40)
        Me.txtAuthor.TabIndex = 6
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(160, 393)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 20)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Year Published:"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtYear.Location = New System.Drawing.Point(155, 430)
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(150, 40)
        Me.txtYear.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(368, 393)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 20)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtQuantity.Location = New System.Drawing.Point(382, 430)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 40)
        Me.txtQuantity.TabIndex = 10
        Me.txtQuantity.Text = "1"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(185, 505)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE BOOK"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(382, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 546)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 59)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Location = New System.Drawing.Point(6, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(673, 111)
        Me.Panel2.TabIndex = 14
        '
        'AdminRegisterBook
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 605)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblBookCode)
        Me.Controls.Add(Me.txtBookCode)
        Me.Controls.Add(Me.lblBookTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminRegisterBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin - Register Book"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtBookCode.Text) Then
            MessageBox.Show("Please enter book code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBookCode.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Please enter book title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            Return
        End If

        Dim year As Integer = 0
        If Not String.IsNullOrWhiteSpace(txtYear.Text) Then
            If Not Integer.TryParse(txtYear.Text, year) OrElse year < 1000 OrElse year > DateTime.Now.Year + 1 Then
                MessageBox.Show("Please enter a valid year (1000 - " & (DateTime.Now.Year + 1) & ").", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtYear.Focus()
                Return
            End If
        End If

        Dim quantity As Integer = 1
        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity < 1 Then
            MessageBox.Show("Please enter a valid quantity (minimum 1).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            Return
        End If

        Try
            DatabaseHelper.RegisterBook(txtBookCode.Text.Trim(), txtTitle.Text.Trim(),
                                       txtAuthor.Text.Trim(), year, quantity)
            MessageBox.Show("Book registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
