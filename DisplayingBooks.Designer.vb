<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstDisplayBooks
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
        Label1 = New Label()
        lstDisplayBook = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(383, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 31)
        Label1.TabIndex = 17
        Label1.Text = "AVAILABLE BOOKS"
        ' 
        ' lstDisplayBook
        ' 
        lstDisplayBook.FormattingEnabled = True
        lstDisplayBook.Location = New Point(370, 125)
        lstDisplayBook.Name = "lstDisplayBook"
        lstDisplayBook.Size = New Size(400, 184)
        lstDisplayBook.TabIndex = 18
        ' 
        ' lstDisplayBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1043, 625)
        Controls.Add(lstDisplayBook)
        Controls.Add(Label1)
        Name = "lstDisplayBooks"
        Text = "DisplayingBooks"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lstDisplayBook As ListBox
End Class
