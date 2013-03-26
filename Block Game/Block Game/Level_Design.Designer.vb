<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level_Design
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
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbbxOption = New System.Windows.Forms.ComboBox()
        Me.LblCharacter = New System.Windows.Forms.Label()
        Me.Lbl_Master = New System.Windows.Forms.Label()
        Me.imgStartImage = New System.Windows.Forms.PictureBox()
        Me.cmbbxLevel = New System.Windows.Forms.ComboBox()
        Me.lblPick = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.imgStartImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMainMenu.Location = New System.Drawing.Point(317, 555)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 10
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(459, 527)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(236, 555)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbbxOption)
        Me.Panel1.Controls.Add(Me.LblCharacter)
        Me.Panel1.Controls.Add(Me.cmbbxLevel)
        Me.Panel1.Controls.Add(Me.Lbl_Master)
        Me.Panel1.Controls.Add(Me.imgStartImage)
        Me.Panel1.Location = New System.Drawing.Point(27, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 500)
        Me.Panel1.TabIndex = 12
        '
        'cmbbxOption
        '
        Me.cmbbxOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbbxOption.FormattingEnabled = True
        Me.cmbbxOption.IntegralHeight = False
        Me.cmbbxOption.Items.AddRange(New Object() {"Start Square", "Finish", "Visible", "Blinking", "Double"})
        Me.cmbbxOption.Location = New System.Drawing.Point(376, 3)
        Me.cmbbxOption.Name = "cmbbxOption"
        Me.cmbbxOption.Size = New System.Drawing.Size(121, 21)
        Me.cmbbxOption.TabIndex = 15
        '
        'LblCharacter
        '
        Me.LblCharacter.BackColor = System.Drawing.Color.Blue
        Me.LblCharacter.Location = New System.Drawing.Point(60, 60)
        Me.LblCharacter.Name = "LblCharacter"
        Me.LblCharacter.Size = New System.Drawing.Size(20, 20)
        Me.LblCharacter.TabIndex = 3
        Me.LblCharacter.Visible = False
        '
        'Lbl_Master
        '
        Me.Lbl_Master.BackColor = System.Drawing.Color.Lime
        Me.Lbl_Master.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Master.Location = New System.Drawing.Point(50, 50)
        Me.Lbl_Master.Name = "Lbl_Master"
        Me.Lbl_Master.Size = New System.Drawing.Size(40, 40)
        Me.Lbl_Master.TabIndex = 2
        Me.Lbl_Master.Text = "Label1"
        Me.Lbl_Master.Visible = False
        '
        'imgStartImage
        '
        Me.imgStartImage.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Start_Screen
        Me.imgStartImage.Location = New System.Drawing.Point(0, 0)
        Me.imgStartImage.Name = "imgStartImage"
        Me.imgStartImage.Size = New System.Drawing.Size(500, 500)
        Me.imgStartImage.TabIndex = 4
        Me.imgStartImage.TabStop = False
        '
        'cmbbxLevel
        '
        Me.cmbbxLevel.FormattingEnabled = True
        Me.cmbbxLevel.Location = New System.Drawing.Point(249, 3)
        Me.cmbbxLevel.Name = "cmbbxLevel"
        Me.cmbbxLevel.Size = New System.Drawing.Size(121, 21)
        Me.cmbbxLevel.TabIndex = 14
        '
        'lblPick
        '
        Me.lblPick.AutoSize = True
        Me.lblPick.Location = New System.Drawing.Point(36, 531)
        Me.lblPick.Name = "lblPick"
        Me.lblPick.Size = New System.Drawing.Size(39, 13)
        Me.lblPick.TabIndex = 15
        Me.lblPick.Text = "Label2"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(36, 555)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(39, 13)
        Me.lblMode.TabIndex = 16
        Me.lblMode.Text = "Label2"
        '
        'Level_Design
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 602)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblPick)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Level_Design"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level"
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgStartImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblCharacter As System.Windows.Forms.Label
    Friend WithEvents Lbl_Master As System.Windows.Forms.Label
    Friend WithEvents imgStartImage As System.Windows.Forms.PictureBox
    Friend WithEvents cmbbxLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbxOption As System.Windows.Forms.ComboBox
    Friend WithEvents lblPick As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
End Class
