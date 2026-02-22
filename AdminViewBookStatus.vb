Imports System.Data.SqlClient

Public Class AdminViewBookStatus
    Inherits Form

    Private WithEvents dgvBooks As DataGridView
    Private WithEvents btnRefresh As Button
    Private WithEvents btnClose As Button
    Private lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private lblTotal As Label

    Public Sub New()
        InitializeComponent()
        LoadBooks()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(38, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(860, 47)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "VIEW BOOK STATUS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Gray
        Me.lblTotal.Location = New System.Drawing.Point(24, 104)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(860, 20)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total Books: 0"
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.ColumnHeadersHeight = 29
        Me.dgvBooks.Location = New System.Drawing.Point(24, 127)
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
        Me.btnRefresh.Location = New System.Drawing.Point(332, 503)
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
        Me.btnClose.Location = New System.Drawing.Point(479, 503)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 556)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 65)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Location = New System.Drawing.Point(3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 66)
        Me.Panel2.TabIndex = 6
        '
        'AdminViewBookStatus
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 623)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdminViewBookStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin - View Book Status"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub LoadBooks()
        Try
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim query As String = "SELECT BookID, BookCode AS [Book Code], Title, Author, " &
                                     "YearPublished AS [Year Published], Quantity " &
                                     "FROM Books ORDER BY Title"

                Using cmd As New SqlCommand(query, conn)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvBooks.DataSource = dt

                    lblTotal.Text = "Total Books: " & dt.Rows.Count

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
        LoadBooks()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AdminViewBookStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub
End Class
