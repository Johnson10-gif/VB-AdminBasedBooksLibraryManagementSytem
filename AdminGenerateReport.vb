Imports MySql.Data.MySqlClient

Public Class AdminGenerateReport
    Inherits Form

    Private WithEvents txtReport As TextBox
    Private WithEvents btnGenerate As Button
    Private WithEvents btnClose As Button
    Private lblTitle As Label

    Public Sub New()
        InitializeComponent()
        GenerateReport()
    End Sub

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(660, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "LIBRARY MANAGEMENT REPORT"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReport
        '
        Me.txtReport.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txtReport.Location = New System.Drawing.Point(20, 70)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(660, 440)
        Me.txtReport.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(220, 520)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(130, 35)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "REFRESH REPORT"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(370, 520)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 35)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'AdminGenerateReport
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 641)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdminGenerateReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin - Generate Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub GenerateReport()
        Try
            Dim report As New System.Text.StringBuilder()
            report.AppendLine("_______________________________________________________________")
            report.AppendLine("           LIBRARY MANAGEMENT SYSTEM - REPORT")
            report.AppendLine("_______________________________________________________________")
            report.AppendLine()
            report.AppendLine("Generated: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            report.AppendLine()
            report.AppendLine("_______________________________________________________________")
            report.AppendLine("SUMMARY STATISTICS")
            report.AppendLine("_______________________________________________________________")
            report.AppendLine()

            Using conn As MySqlConnection = DatabaseHelper.GetConnection()
                conn.Open()

                ' Total Books
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Books", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Total Books in Library:              " & count)
                End Using

                ' Total Book Copies
                Using cmd As New MySqlCommand("SELECT IFNULL(SUM(Quantity), 0) FROM Books", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Total Book Copies:                   " & count)
                End Using

                ' Available Books
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Books WHERE Quantity > 0", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Books Currently Available:           " & count)
                End Using

                ' Total Users
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM Users WHERE Role='User'", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Total Registered Users:              " & count)
                End Using

                ' Pending Borrow Requests
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM BorrowRequests WHERE Status='Pending'", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Pending Borrow Requests:             " & count)
                End Using

                ' Approved Borrow Requests
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM BorrowRequests WHERE Status='Approved'", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Approved Borrow Requests:            " & count)
                End Using

                ' Pending Return Requests
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM ReturnRequests WHERE Status='Pending'", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Pending Return Requests:             " & count)
                End Using

                ' Approved Return Requests
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM ReturnRequests WHERE Status='Approved'", conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    report.AppendLine("Approved Return Requests:            " & count)
                End Using

                report.AppendLine()
                report.AppendLine("_______________________________________________________________")
                report.AppendLine("TOP 5 MOST REQUESTED BOOKS")
                report.AppendLine("_______________________________________________________________")
                report.AppendLine()

                Dim topBooksQuery As String = "SELECT b.Title, b.Author, COUNT(*) AS RequestCount " &
                                              "FROM BorrowRequests br " &
                                              "INNER JOIN Books b ON br.BookID = b.BookID " &
                                              "GROUP BY b.Title, b.Author " &
                                              "ORDER BY RequestCount DESC LIMIT 5"

                Using cmd As New MySqlCommand(topBooksQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rank As Integer = 1
                        If reader.HasRows Then
                            While reader.Read()
                                report.AppendLine(rank & ". " & reader("Title").ToString())
                                report.AppendLine("   Author: " & If(IsDBNull(reader("Author")), "Unknown", reader("Author").ToString()))
                                report.AppendLine("   Requests: " & reader("RequestCount").ToString())
                                report.AppendLine()
                                rank += 1
                            End While
                        Else
                            report.AppendLine("No borrow requests found.")
                            report.AppendLine()
                        End If
                    End Using
                End Using

                report.AppendLine("_______________________________________________________________")
                report.AppendLine("BOOKS WITH LOW QUANTITY (< 3)")
                report.AppendLine("_______________________________________________________________")
                report.AppendLine()

                Dim lowQtyQuery As String = "SELECT BookCode, Title, Author, Quantity " &
                                            "FROM Books " &
                                            "WHERE Quantity < 3 AND Quantity >= 0 " &
                                            "ORDER BY Quantity"

                Using cmd As New MySqlCommand(lowQtyQuery, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                report.AppendLine("Book: " & reader("Title").ToString())
                                report.AppendLine("Code: " & If(IsDBNull(reader("BookCode")), "N/A", reader("BookCode").ToString()) &
                                                " | Quantity: " & reader("Quantity").ToString())
                                report.AppendLine()
                            End While
                        Else
                            report.AppendLine("All books have sufficient quantity.")
                            report.AppendLine()
                        End If
                    End Using
                End Using

                report.AppendLine("_______________________________________________________________")
                report.AppendLine("                    END OF REPORT")
                report.AppendLine("_______________________________________________________________")
            End Using

            txtReport.Text = report.ToString()
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtReport_TextChanged(sender As Object, e As EventArgs) Handles txtReport.TextChanged

    End Sub
End Class
