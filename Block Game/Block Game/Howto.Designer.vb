<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Howto
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
        Me.Lbl_Master = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUserPick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Master
        '
        Me.Lbl_Master.BackColor = System.Drawing.Color.Lime
        Me.Lbl_Master.Location = New System.Drawing.Point(53, 166)
        Me.Lbl_Master.Name = "Lbl_Master"
        Me.Lbl_Master.Size = New System.Drawing.Size(40, 40)
        Me.Lbl_Master.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(53, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 40)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(121, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Standard One Jump Square"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(121, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Double Jump"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Move with 'W' 'A' 'S' 'D'"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(286, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 96)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "'W' = Up " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'A' = Left " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'S' = Down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'D' = Right"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 9)
        Me.Label6.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 140)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Welcome to Block Jump." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The purpose of the game is to get from the start square" & _
            " to the finish square. But you must watch out for tricky squares and try not to " & _
            "fall off or stay in one spot too long"
        '
        'btnUserPick
        '
        Me.btnUserPick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserPick.Location = New System.Drawing.Point(169, 362)
        Me.btnUserPick.Name = "btnUserPick"
        Me.btnUserPick.Size = New System.Drawing.Size(75, 23)
        Me.btnUserPick.TabIndex = 20
        Me.btnUserPick.Text = "User Pick"
        Me.btnUserPick.UseVisualStyleBackColor = True
        '
        'Howto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(422, 397)
        Me.Controls.Add(Me.btnUserPick)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Master)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Howto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Howto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Master As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnUserPick As System.Windows.Forms.Button
End Class
