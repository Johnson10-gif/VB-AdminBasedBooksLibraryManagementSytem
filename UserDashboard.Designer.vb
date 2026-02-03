<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboard
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
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.btnViewBooks = New System.Windows.Forms.Button()
        Me.btnRequestBook = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.panelHeader.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(879, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER DASHBOARD"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 50)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(879, 35)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, User"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(0, 85)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(879, 25)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Manage your book borrowing activities"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewBooks
        '
        Me.btnViewBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnViewBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewBooks.FlatAppearance.BorderSize = 0
        Me.btnViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBooks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewBooks.ForeColor = System.Drawing.Color.White
        Me.btnViewBooks.Location = New System.Drawing.Point(307, 74)
        Me.btnViewBooks.Name = "btnViewBooks"
        Me.btnViewBooks.Size = New System.Drawing.Size(280, 65)
        Me.btnViewBooks.TabIndex = 0
        Me.btnViewBooks.Text = "VIEW AVAILABLE BOOKS"
        Me.btnViewBooks.UseVisualStyleBackColor = False
        '
        'btnRequestBook
        '
        Me.btnRequestBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRequestBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequestBook.FlatAppearance.BorderSize = 0
        Me.btnRequestBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestBook.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRequestBook.ForeColor = System.Drawing.Color.White
        Me.btnRequestBook.Location = New System.Drawing.Point(307, 201)
        Me.btnRequestBook.Name = "btnRequestBook"
        Me.btnRequestBook.Size = New System.Drawing.Size(280, 65)
        Me.btnRequestBook.TabIndex = 1
        Me.btnRequestBook.Text = " REQUEST TO BORROW"
        Me.btnRequestBook.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturnBook.FlatAppearance.BorderSize = 0
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReturnBook.ForeColor = System.Drawing.Color.White
        Me.btnReturnBook.Location = New System.Drawing.Point(307, 318)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(280, 65)
        Me.btnReturnBook.TabIndex = 2
        Me.btnReturnBook.Text = "REQUEST TO RETURN"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(357, 425)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(160, 40)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.lblSubtitle)
        Me.panelHeader.Controls.Add(Me.lblWelcome)
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(879, 120)
        Me.panelHeader.TabIndex = 3
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelButtons.Controls.Add(Me.btnLogout)
        Me.panelButtons.Controls.Add(Me.btnReturnBook)
        Me.panelButtons.Controls.Add(Me.btnRequestBook)
        Me.panelButtons.Controls.Add(Me.btnViewBooks)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelButtons.Location = New System.Drawing.Point(0, 120)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(879, 530)
        Me.panelButtons.TabIndex = 4
        '
        'UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 650)
        Me.Controls.Add(Me.panelButtons)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Dashboard - Library Management System"
        Me.panelHeader.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents btnViewBooks As Button
    Friend WithEvents btnRequestBook As Button
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelButtons As Panel
End Class
