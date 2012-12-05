'Option Strict On
Imports System.Drawing

Public Class Level_2
    Public Lbl_Array As Label() = New Label(64) {} ' Set the number you labels need
    Dim Block(8, 8) As Boolean
    Dim checkNumber As Integer
    Dim startingSquare, winningSquare As Integer
    Dim count As Integer = 3

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        imgStartImage.Visible = False
        LblCharacter.Visible = True
        LblCharacter.Top = ((startingSquare \ 8) * 50) + 60
        LblCharacter.Left = ((startingSquare Mod 8) * 50) + 60
        CountdownTimer.Enabled = True

        Dim CNT As Integer

        Dim X As Integer
        Dim Y As Integer
        Dim H As Integer
        Dim W As Integer
        Dim r, c As Integer

        Y = Lbl_Master.Location.Y
        H = Lbl_Master.Height
        W = Lbl_Master.Width

        CNT = 1
        For c = 1 To 8
            X = Lbl_Master.Location.X
            For r = 1 To 8
                Lbl_Array(CNT) = New Label
                Lbl_Array(CNT).Location = New System.Drawing.Point(X, Y)
                Lbl_Array(CNT).Size = New System.Drawing.Size(W, H)
                Lbl_Array(CNT).AutoSize = Lbl_Master.AutoSize
                Lbl_Array(CNT).BackColor = Lbl_Master.BackColor
                Lbl_Array(CNT).BorderStyle = Lbl_Master.BorderStyle
                Lbl_Array(CNT).TextAlign = Lbl_Master.TextAlign
                Lbl_Array(CNT).ForeColor = Lbl_Master.ForeColor
                Lbl_Array(CNT).Font = Lbl_Master.Font
                'Lbl_Array(CNT).Font.Bold = Lbl_Master.Font.Bold
                Lbl_Array(CNT).Tag = CNT ' This is the bit so that we can find the index
                Lbl_Array(CNT).Visible = True
                Lbl_Array(CNT).BringToFront()
                'AddHandler Lbl_Array(CNT).Click, AddressOf lblArray_click
                Panel1.Controls.Add(Lbl_Array(CNT))
                X = (X + W) + 10
                CNT += 1
            Next
            Y = (Y + H) + 10
        Next

        Label1.Visible = True
        Lbl_Array(winningSquare).Text = "Finish"
        LblCharacter.Focus()
    End Sub

    Private Sub lblCharacter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LblCharacter.KeyPress
        changeColor(LblCharacter.Top \ 50, LblCharacter.Left \ 50)
        count = 3

        If e.KeyChar = "a" Then
            e.Handled = True
            LblCharacter.Left -= 50
        ElseIf e.KeyChar = "d" Then
            e.Handled = True
            LblCharacter.Left += 50
        ElseIf e.KeyChar = "s" Then
            e.Handled = True
            LblCharacter.Top += 50
        ElseIf e.KeyChar = "w" Then
            e.Handled = True
            LblCharacter.Top -= 50
        End If

        check(LblCharacter.Top \ 50, LblCharacter.Left \ 50)

        Label1.Text = "Row: " & LblCharacter.Top \ 50 & " " & "Column: " & LblCharacter.Left \ 50
    End Sub

    Private Sub check(ByVal row As Integer, ByVal col As Integer)
        If (row * 8 - (8 - col)) = winningSquare And checkNumber = 63 Then
            MessageBox.Show("You win!", "YEEAAAHH!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Lbl_Array(row * 8 - (8 - col)).BackColor = Color.Green
            CountdownTimer.Enabled = False
            reset()
        ElseIf row <= 0 OrElse row > 8 OrElse col <= 0 OrElse col > 8 OrElse Block(row, col) = True Then
            gameOver()
            reset()
        ElseIf (row * 8 - (8 - col)) = winningSquare And checkNumber <> 63 Then
            MessageBox.Show("Game Over!! You must hit all of the tiles before the Finish tile", "BOOOM!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            reset()
            CountdownTimer.Enabled = False
        End If
    End Sub

    Private Sub changeColor(ByVal row As Integer, ByVal col As Integer)
        If Block(row, col) = False Then
            Lbl_Array(row * 8 - (8 - col)).BackColor = Color.Red
            Block(row, col) = True
            checkNumber += 1
        End If
    End Sub

    Private Sub newForm()
        Dim Form2 As New Level_2
        Me.Hide()
        Form2.Show()
        imgStartImage.Visible = True
    End Sub

    Private Sub reset()
        For row = 1 To 8
            For column = 1 To 8
                Block(row, column) = False
            Next
        Next
        newForm()
    End Sub

    'Private Sub lblArray_click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim Lbl_tmp As Label = CType(sender, Label)
    '    Dim i As Integer = CInt(Lbl_tmp.Tag)

    '    Lbl_Array(i).BackColor = Color.Aqua
    'End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Level_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        winningSquare = 54
        startingSquare = 0
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        Dim Level_2 As New Level_2
        Level_2.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim Level_1 As New Level_1
        Level_1.Show()
        Me.Hide()
    End Sub

    Private Sub gameOver()
        MessageBox.Show("Game Over!!", "BOOOM!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        CountdownTimer.Enabled = False
        reset()
    End Sub

    Private Sub CountdownTimer_Tick(sender As System.Object, e As System.EventArgs) Handles CountdownTimer.Tick
        lblTime.Text = "Time: " & count

        If count = 0 Then
            count = 3
            CountdownTimer.Enabled = False
            gameOver()
        End If

        count -= 1
    End Sub
End Class