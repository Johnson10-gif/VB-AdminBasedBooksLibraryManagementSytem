Imports MySql.Data.MySqlClient

Public Class UserViewBooks
    Inherits Form

    Private WithEvents dgvBooks As DataGridView
    Private WithEvents btnRefresh As Button
    Private WithEvents btnClose As Button
    Private lblTitle As Label
    Private lblInfo As Label

    Public Sub New()
        InitializeComponent()
        LoadAvailableBooks()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(860, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "AVAILABLE BOOKS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblInfo.Location = New System.Drawing.Point(20, 65)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(860, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Books available for borrowing (Quantity > 0)"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.ColumnHeadersHeight = 29
        Me.dgvBooks.Location = New System.Drawing.Point(20, 100)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersWidth = 51
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(860, 370)
        Me.dgvBooks.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(340, 480)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 35)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(480, 480)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'UserViewBooks
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(974, 582)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UserViewBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User - View Books"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub LoadAvailableBooks()
        Try
            Using conn As MySqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT BookID, BookCode AS `Book Code`, Title, Author, " &
                                     "YearPublished AS `Year Published`, Quantity " &
                                     "FROM Books WHERE Quantity > 0 ORDER BY Title"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvBooks.DataSource = dt

                    lblInfo.Text = "Books available for borrowing: " & dt.Rows.Count

                    ' Hide BookID
                    If dgvBooks.Columns.Count > 0 Then
                        dgvBooks.Columns("BookID").Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAvailableBooks()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
