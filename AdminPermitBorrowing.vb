Imports MySql.Data.MySqlClient

Public Class AdminPermitBorrowing
    Inherits Form

    Private WithEvents dgvRequests As DataGridView
    Private WithEvents btnApprove As Button
    Private WithEvents btnRefresh As Button
    Private WithEvents btnClose As Button
    Friend WithEvents lblInfo As Label
    Private lblTitle As Label

    Public Sub New()
        InitializeComponent()
        LoadBorrowRequests()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(860, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PERMIT BOOK BORROWING"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblInfo.Location = New System.Drawing.Point(20, 65)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(860, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Select a pending borrow request and click 'Approve Request' to approve it."
        '
        'dgvRequests
        '
        Me.dgvRequests.AllowUserToAddRows = False
        Me.dgvRequests.AllowUserToDeleteRows = False
        Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequests.ColumnHeadersHeight = 29
        Me.dgvRequests.Location = New System.Drawing.Point(20, 100)
        Me.dgvRequests.MultiSelect = False
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.ReadOnly = True
        Me.dgvRequests.RowHeadersWidth = 51
        Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRequests.Size = New System.Drawing.Size(860, 350)
        Me.dgvRequests.TabIndex = 2
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(250, 465)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(150, 35)
        Me.btnApprove.TabIndex = 3
        Me.btnApprove.Text = "APPROVE REQUEST"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(420, 465)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 35)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(560, 465)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'AdminPermitBorrowing
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 603)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdminPermitBorrowing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin - Permit Book Borrowing"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub LoadBorrowRequests()
        Try
            Using conn As MySqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT br.BorrowRequestID, br.UserID, u.FullName AS `User Name`, " &
                                     "br.BookID, b.Title AS `Book Title`, b.Author, " &
                                     "br.RequestDate AS `Request Date`, br.Status " &
                                     "FROM BorrowRequests br " &
                                     "INNER JOIN Users u ON br.UserID = u.UserID " &
                                     "INNER JOIN Books b ON br.BookID = b.BookID " &
                                     "WHERE br.Status = 'Pending' " &
                                     "ORDER BY br.RequestDate"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvRequests.DataSource = dt

                    ' Hide ID columns
                    If dgvRequests.Columns.Count > 0 Then
                        dgvRequests.Columns("BorrowRequestID").Visible = True
                        dgvRequests.Columns("UserID").Visible = False
                        dgvRequests.Columns("BookID").Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading borrow requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvRequests.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim requestId As Integer = Convert.ToInt32(dgvRequests.SelectedRows(0).Cells("BorrowRequestID").Value)
        Dim userName As String = dgvRequests.SelectedRows(0).Cells("User Name").Value.ToString()
        Dim bookTitle As String = dgvRequests.SelectedRows(0).Cells("Book Title").Value.ToString()

        Dim result As DialogResult = MessageBox.Show("Approve borrow request?" & vbCrLf & vbCrLf &
                                                     "User: " & userName & vbCrLf &
                                                     "Book: " & bookTitle,
                                                     "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                DatabaseHelper.ApproveBorrowRequest(requestId)
                MessageBox.Show("Borrow request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBorrowRequests()
            Catch ex As Exception
                MessageBox.Show("Error approving request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBorrowRequests()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
