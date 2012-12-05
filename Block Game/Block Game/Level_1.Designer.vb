<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level_1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level_1))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.imgStartImage = New System.Windows.Forms.PictureBox()
        Me.LblCharacter = New System.Windows.Forms.Label()
        Me.Lbl_Master = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.imgStartImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(316, 552)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 11
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(154, 552)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 10
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(235, 552)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Start"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.imgStartImage)
        Me.Panel1.Controls.Add(Me.LblCharacter)
        Me.Panel1.Controls.Add(Me.Lbl_Master)
        Me.Panel1.Location = New System.Drawing.Point(26, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 500)
        Me.Panel1.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(412, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 25)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "Time: "
        '
        'imgStartImage
        '
        Me.imgStartImage.BackgroundImage = CType(resources.GetObject("imgStartImage.BackgroundImage"), System.Drawing.Image)
        Me.imgStartImage.Location = New System.Drawing.Point(0, 0)
        Me.imgStartImage.Name = "imgStartImage"
        Me.imgStartImage.Size = New System.Drawing.Size(500, 500)
        Me.imgStartImage.TabIndex = 4
        Me.imgStartImage.TabStop = False
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
        Me.Lbl_Master.Location = New System.Drawing.Point(50, 50)
        Me.Lbl_Master.Name = "Lbl_Master"
        Me.Lbl_Master.Size = New System.Drawing.Size(40, 40)
        Me.Lbl_Master.TabIndex = 2
        Me.Lbl_Master.Text = "Label1"
        Me.Lbl_Master.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(397, 552)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next Problem"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(73, 552)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'CountdownTimer
        '
        Me.CountdownTimer.Interval = 1000
        '
        'Level_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 598)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Level_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgStartImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents imgStartImage As System.Windows.Forms.PictureBox
    Friend WithEvents LblCharacter As System.Windows.Forms.Label
    Friend WithEvents Lbl_Master As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents CountdownTimer As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
