<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPick
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewPlayer = New System.Windows.Forms.Label()
        Me.lblDelete_Player = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Master_UserSlot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDesign = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(443, 288)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNewPlayer
        '
        Me.btnNewPlayer.AutoSize = True
        Me.btnNewPlayer.BackColor = System.Drawing.Color.Blue
        Me.btnNewPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPlayer.Location = New System.Drawing.Point(321, 57)
        Me.btnNewPlayer.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnNewPlayer.Name = "btnNewPlayer"
        Me.btnNewPlayer.Size = New System.Drawing.Size(140, 20)
        Me.btnNewPlayer.TabIndex = 10
        Me.btnNewPlayer.Text = "NEW PLAYER"
        Me.btnNewPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDelete_Player
        '
        Me.lblDelete_Player.AutoSize = True
        Me.lblDelete_Player.BackColor = System.Drawing.Color.Blue
        Me.lblDelete_Player.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete_Player.Location = New System.Drawing.Point(321, 114)
        Me.lblDelete_Player.MinimumSize = New System.Drawing.Size(140, 0)
        Me.lblDelete_Player.Name = "lblDelete_Player"
        Me.lblDelete_Player.Size = New System.Drawing.Size(140, 20)
        Me.lblDelete_Player.TabIndex = 15
        Me.lblDelete_Player.Text = "DELETE PLAYER"
        Me.lblDelete_Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Master_UserSlot)
        Me.Panel1.Location = New System.Drawing.Point(31, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 195)
        Me.Panel1.TabIndex = 17
        '
        'Master_UserSlot
        '
        Me.Master_UserSlot.AutoSize = True
        Me.Master_UserSlot.BackColor = System.Drawing.Color.Lime
        Me.Master_UserSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_UserSlot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Master_UserSlot.Location = New System.Drawing.Point(23, 16)
        Me.Master_UserSlot.MinimumSize = New System.Drawing.Size(175, 0)
        Me.Master_UserSlot.Name = "Master_UserSlot"
        Me.Master_UserSlot.Size = New System.Drawing.Size(175, 24)
        Me.Master_UserSlot.TabIndex = 13
        Me.Master_UserSlot.Text = "<BLANKSLOT>"
        Me.Master_UserSlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'btnDesign
        '
        Me.btnDesign.Location = New System.Drawing.Point(315, 288)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(75, 23)
        Me.btnDesign.TabIndex = 19
        Me.btnDesign.Text = "Design Levels"
        Me.btnDesign.UseVisualStyleBackColor = True
        '
        'UserPick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 323)
        Me.Controls.Add(Me.btnDesign)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDelete_Player)
        Me.Controls.Add(Me.btnNewPlayer)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "UserPick"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserPick"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNewPlayer As System.Windows.Forms.Label
    Friend WithEvents lblDelete_Player As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Master_UserSlot As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDesign As System.Windows.Forms.Button
End Class
