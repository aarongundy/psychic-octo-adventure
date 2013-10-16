Imports System.Drawing

Public Class Level_Design
    Public Lbl_Array As Label() = New Label(64) {} ' Set the number you labels need
    Public Lbl_Array_Copy As Label() = New Label(64) {}
    Dim addLine As System.IO.StreamWriter
    Dim addFile As System.IO.Stream
    Dim Block(8, 8) As Boolean
    Dim Blinking(8, 8) As Boolean
    Public DoubleJump(8, 8) As Boolean
    Dim checkNumber, x, y As Integer
    Dim levelCheck As Integer = -1
    Dim startingSquare, winningSquare, time As Integer
    Dim count As Integer = 3
    Dim timecount As Double = 0
    Dim trigger As Integer = 1

    Private Sub Level_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Level " & userlevel

        y = LblCharacter.Top \ 50
        x = LblCharacter.Left \ 50

        For i = 1 To 64
            cmbbxLevel.Items.Add(i)
        Next

        Label1.Text = "Row: " & y & " " & "Column: " & x

        Select Case userlevel
            Case 1 : level_1()
            Case 2 : level_2()
            Case 3 : level_3()
            Case 4 : level_4()
            Case 5 : level_5()
            Case 6 : level_6()
            Case 7 : level_7()
            Case 8 : level_8()
            Case 9 : level_9()
            Case 10 : level_10()
            Case 11 : level_11()
            Case 12 : level_12()
            Case 13 : level_13()
            Case 14 : level_14()
            Case 15 : level_15()
            Case 16 : level_16()
            Case 17 : level_17()
            Case 18 : level_18()
            Case 19 : level_19()
            Case 20 : level_20()
            Case 21 : level_21()
            Case 22 : level_22()
            Case 23 : level_23()
            Case 24 : level_24()
            Case 25 : level_25()
            Case 26 : level_26()
            Case 27 : level_27()
            Case 28 : level_28()
            Case 29 : level_29()
            Case 30 : level_30()
            Case 31 : level_31()
            Case 32 : level_32()
            Case 33 : level_33()
            Case 34 : level_34()
            Case 35 : level_35()
            Case 36 : level_36()
            Case 37 : level_37()
            Case 38 : level_38()
            Case 39 : level_39()
            Case 40 : level_40()
            Case 41 : level_41()
            Case 42 : level_42()
            Case 43 : level_43()
            Case 44 : level_44()
            Case 45 : level_45()
            Case 46 : level_46()
            Case 47 : level_47()
            Case 48 : level_48()
            Case 49 : level_49()
            Case 50 : level_50()
            Case 51 : level_51()
            Case 52 : level_52()
            Case 53 : level_53()
            Case 54 : level_54()
            Case 55 : level_55()
            Case 56 : level_56()
            Case 57 : level_57()
            Case 58 : level_58()
            Case 59 : level_59()
            Case 60 : level_60()
            Case 61 : level_61()
            Case 62 : level_62()
            Case 63 : level_63()
            Case 64 : level_64()
        End Select

        Me.BackColor = backgroundColor
        Me.ForeColor = textColor

        refreshTiles()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Design_Output As New Design_Output
        Dim start As Integer

        Dim r As Integer
        Dim c As Integer
        Design_Output.Show()
        Design_Output.RichTextBox1.AppendText("Level:" & userlevel & vbNewLine & vbNewLine)

        Dim i As Integer = 1

        Do
            If Lbl_Array(i).Visible = False Then
                start = i
                Do Until Lbl_Array(i).Visible = True
                    If i <= 64 Then
                        i += 1
                    End If
                    If i = 65 Then
                        Exit Do
                    End If
                Loop
                If i = start Then
                    Design_Output.RichTextBox1.AppendText("For i = " & start & " To " & (i) & vbNewLine)
                    Design_Output.RichTextBox1.AppendText(vbTab & "Lbl_Array(i).Visible = False" & vbNewLine)
                    Design_Output.RichTextBox1.AppendText(vbTab & "Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True" & vbNewLine)
                    Design_Output.RichTextBox1.AppendText("Next" & vbNewLine & vbNewLine)
                Else
                    Design_Output.RichTextBox1.AppendText("For i = " & start & " To " & (i - 1) & vbNewLine)
                    Design_Output.RichTextBox1.AppendText(vbTab & "Lbl_Array(i).Visible = False" & vbNewLine)
                    Design_Output.RichTextBox1.AppendText(vbTab & "Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True" & vbNewLine)
                    Design_Output.RichTextBox1.AppendText("Next" & vbNewLine & vbNewLine)
                End If
            End If
            If i <= 64 Then
                i += 1
            End If
        Loop Until i > 64


        Design_Output.RichTextBox1.AppendText("startingSquare = " & startingSquare & vbNewLine)
        Design_Output.RichTextBox1.AppendText("winningSquare = " & winningSquare & vbNewLine)
        Design_Output.RichTextBox1.AppendText(vbNewLine)

        For r = 1 To 8
            For c = 1 To 8
                If Blinking(c, r) = True Then
                    Design_Output.RichTextBox1.AppendText("Blinking(" &c & "," & r & ") = True " & vbNewLine)
                End If
                If DoubleJump(c, r) = True Then
                    Design_Output.RichTextBox1.AppendText("DoubleJump(" & c & "," & r & ") = True " & vbNewLine)
                End If
            Next
        Next

    End Sub

    Private Sub lblCharacter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LblCharacter.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
            'timerStop()
            MessageBox.Show("Paused.", "Game Paused", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'timerStart()
        ElseIf e.KeyChar = "a" Or e.KeyChar = "d" Or e.KeyChar = "s" Or e.KeyChar = "w" Then
            changeColor(LblCharacter.Left \ 50, LblCharacter.Top \ 50)
            count = 3

            'Me.AxWindowsMediaPlayer1.URL = moveChar

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

            y = LblCharacter.Top \ 50
            x = LblCharacter.Left \ 50

            check(x, y)

            Label1.Text = "Column: " & x & " " & "Row: " & y
        End If
    End Sub

    Private Sub check(ByVal x As Integer, ByVal y As Integer)
        If (y * 8 - (8 - x)) = winningSquare And checkNumber = levelcheck Then
            'timerEnd()
            If timecount < timeArray(userlevel) Or timeArray(userlevel) = 0 Then
                timeArray(userlevel) = timecount
                'writeTime()
            End If

            MessageBox.Show("You win!", "YEEAAAHH!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Lbl_Array(x * 8 - (8 - y)).BackColor = Color.Green
            nextLevel()
        ElseIf x <= 0 OrElse x > 8 OrElse y <= 0 OrElse y > 8 OrElse Block(x, y) = True Then
            gameOver()
        ElseIf (y * 8 - (8 - x)) = winningSquare And checkNumber <> levelCheck Then
            'timerEnd()
            MessageBox.Show("Game Over!! You must hit all of the tiles before the Finish tile", "BOOOM!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            reset()
        End If
    End Sub

    Private Sub changeColor(ByVal x As Integer, ByVal y As Integer)
        If Block(x, y) = False Then
            Lbl_Array(y * 8 - (8 - x)).Visible = False
            Block(x, y) = True
            Blinking(x, y) = False
            checkNumber += 1
        End If
    End Sub

    Private Sub nextLevel()
        'timerEnd()
        userlevel += 1
        Me.Hide()
        Dim level As New Level
        level.Show()
    End Sub

    Private Sub gameOver()
        'timerEnd()
        MessageBox.Show("Game Over!!", "BOOOM!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        reset()
    End Sub

    Private Sub reset() ' 
        For row = 1 To 8
            For column = 1 To 8
                Block(row, column) = False
            Next
        Next
        newGame()
    End Sub

    Private Sub newGame()
        'timerEnd()
        Dim level As New Level
        Me.Hide()
        level.Show()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nextLevel()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' timerEnd()
        userlevel -= 1
        Me.Hide()
        Dim level As New Level
        level.Show()
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        newGame()
    End Sub

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        Dim userpick As New UserPick
        userpick.Show()
    End Sub

    Private Sub level_1()
        winningSquare = 40
        startingSquare = 32
        'btnBack.Enabled = False
    End Sub

    Private Sub level_2()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_3()
        winningSquare = 38
        startingSquare = 3
    End Sub

    Private Sub level_4()
        startingSquare = 18
        winningSquare = 37
    End Sub

    Private Sub level_5()
        winningSquare = 24
        startingSquare = 25
    End Sub

    Private Sub level_6()
        startingSquare = 35
        winningSquare = 37
    End Sub

    Private Sub level_7()
        winningSquare = 24
        startingSquare = 25
    End Sub

    Private Sub level_8()
        startingSquare = 56
        winningSquare = 48
    End Sub

    Private Sub level_9()
        winningSquare = 24
        startingSquare = 0
    End Sub

    Private Sub level_10()
        winningSquare = 64
        startingSquare = 56
    End Sub

    Private Sub level_11()
        winningSquare = 8
        startingSquare = 0
    End Sub

    Private Sub level_12()
        startingSquare = 18
        winningSquare = 54
    End Sub

    Private Sub level_13()
        startingSquare = 50
        winningSquare = 52
    End Sub

    Private Sub level_14()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_15()
        winningSquare = 54
        startingSquare = 0
    End Sub

    Private Sub level_16()
        startingSquare = 0
        winningSquare = 58
    End Sub

    Private Sub level_17()
        winningSquare = 40
        startingSquare = 32

        Blinking(3, 5) = True
    End Sub

    Private Sub level_18()
        startingSquare = 32
        winningSquare = 40

        Blinking(3, 3) = True
    End Sub

    Private Sub level_19()
        startingSquare = 39
        winningSquare = 1

        Blinking(2, 6) = True
    End Sub

    Private Sub level_20()
        startingSquare = 32
        winningSquare = 40

        Blinking(5, 4) = True
        Blinking(3, 5) = True
        Blinking(5, 6) = True
    End Sub

    Private Sub level_21()
        startingSquare = 19
        winningSquare = 40

        DoubleJump(7, 4) = True
        Blinking(2, 8) = True
    End Sub

    Private Sub level_22()
        startingSquare = 32
        winningSquare = 40

        Blinking(7, 5) = True
        Blinking(2, 6) = True
    End Sub

    Private Sub level_23()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_24()

        startingSquare = 39
        winningSquare = 58

        Blinking(7, 5) = True
        Blinking(6, 6) = True
        Blinking(2, 7) = True
        Blinking(4, 8) = True
    End Sub

    Private Sub level_25()
        startingSquare = 32
        winningSquare = 40

        DoubleJump(4, 5) = True
    End Sub

    Private Sub level_26()
        startingSquare = 57
        winningSquare = 4

        DoubleJump(2, 4) = True
        DoubleJump(3, 4) = True
        DoubleJump(2, 6) = True
        DoubleJump(2, 7) = True
    End Sub

    Private Sub level_27()
        startingSquare = 2
        winningSquare = 4

        DoubleJump(5, 1) = True
        DoubleJump(3, 3) = True
        DoubleJump(7, 3) = True
        DoubleJump(5, 5) = True
    End Sub

    Private Sub level_28()
        startingSquare = 9
        winningSquare = 11

        DoubleJump(5, 2) = True
        DoubleJump(6, 2) = True
        DoubleJump(5, 3) = True
        DoubleJump(5, 4) = True
        DoubleJump(5, 5) = True
        DoubleJump(5, 6) = True

    End Sub

    Private Sub level_29()
        startingSquare = 0
        winningSquare = 2

        DoubleJump(3, 1) = True
        DoubleJump(7, 1) = True
        DoubleJump(1, 3) = True
        DoubleJump(6, 4) = True
        DoubleJump(3, 5) = True
        DoubleJump(6, 8) = True
    End Sub

    Private Sub level_30()

        startingSquare = 32
        winningSquare = 40

        DoubleJump(2, 4) = True
        Blinking(2, 5) = True
        DoubleJump(4, 5) = True
        DoubleJump(2, 6) = True
        DoubleJump(3, 6) = True
    End Sub

    Private Sub level_31()
        startingSquare = 32
        winningSquare = 40

        DoubleJump(5, 1) = True
        DoubleJump(6, 1) = True
        DoubleJump(7, 1) = True
        DoubleJump(5, 2) = True
        DoubleJump(5, 3) = True
        DoubleJump(5, 4) = True
        DoubleJump(5, 5) = True
        DoubleJump(2, 8) = True
        DoubleJump(3, 8) = True
        DoubleJump(4, 8) = True
        DoubleJump(5, 8) = True
    End Sub

    Private Sub level_32()
        startingSquare = 32
        winningSquare = 40

        Blinking(1, 1) = True
        DoubleJump(4, 1) = True
        DoubleJump(5, 1) = True
        DoubleJump(1, 2) = True
        DoubleJump(1, 3) = True
        DoubleJump(1, 5) = True
        Blinking(3, 5) = True
        DoubleJump(4, 5) = True
        DoubleJump(5, 5) = True
        Blinking(7, 5) = True
        Blinking(1, 8) = True
    End Sub

    Private Sub level_33()
        startingSquare = 32
        winningSquare = 40

        Blinking(3, 4) = True
        Blinking(5, 4) = True
        Blinking(2, 5) = True
        DoubleJump(3, 5) = True
        DoubleJump(4, 5) = True
        DoubleJump(5, 5) = True
        Blinking(6, 5) = True
        Blinking(4, 6) = True

    End Sub

    Private Sub level_34()
        startingSquare = 32
        winningSquare = 40

        DoubleJump(5, 4) = True
        DoubleJump(5, 5) = True
    End Sub

    Private Sub level_35()
        startingSquare = 16
        winningSquare = 64

        DoubleJump(2, 1) = True
        DoubleJump(3, 1) = True
        DoubleJump(4, 1) = True
        DoubleJump(5, 1) = True
        DoubleJump(6, 1) = True
        DoubleJump(7, 1) = True
        Blinking(5, 4) = True
        DoubleJump(2, 5) = True
        DoubleJump(3, 5) = True
        DoubleJump(4, 5) = True
        DoubleJump(5, 5) = True
        Blinking(5, 6) = True
        DoubleJump(4, 7) = True
        DoubleJump(5, 7) = True
        DoubleJump(2, 8) = True
        DoubleJump(3, 8) = True
        DoubleJump(4, 8) = True
    End Sub

    Private Sub level_36()
        startingSquare = 32
        winningSquare = 58

        Blinking(3, 2) = True
        DoubleJump(2, 3) = True
        Blinking(3, 3) = True
        DoubleJump(2, 4) = True
        Blinking(3, 6) = True
        Blinking(3, 7) = True
    End Sub

    Private Sub level_37()
        startingSquare = 32
        winningSquare = 41

        DoubleJump(7, 2) = True
        DoubleJump(7, 4) = True
        DoubleJump(7, 6) = True
        DoubleJump(8, 2) = True
        DoubleJump(8, 4) = True
        DoubleJump(8, 6) = True
        Blinking(8, 3) = True
        Blinking(8, 5) = True
        Blinking(8, 7) = True
    End Sub

    Private Sub level_38()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_39()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_40()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_41()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_42()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_43()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_44()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_45()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_46()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_47()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_48()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_49()
        startingSquare = 32
        winningSquare = 40

        Blinking(2, 4) = True
        DoubleJump(2, 4) = True

    End Sub

    Private Sub level_50()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_51()
        startingSquare = 32
        winningSquare = 29

        Blinking(4, 4) = True
        DoubleJump(4, 4) = True

    End Sub

    Private Sub level_52()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_53()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_54()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_55()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_56()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_57()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_58()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_59()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_60()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_61()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_62()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_63()
        winningSquare = 40
        startingSquare = 32
    End Sub

    Private Sub level_64()
        winningSquare = 40
        startingSquare = 32
        'btnNext.Enabled = False
    End Sub


    Private Sub Mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim c, r As Integer

        trigger += 1

        If trigger Mod 2 = 0 Then
            For r = 1 To 8
                For c = 1 To 8
                    If Blinking(c, r) = True Then
                        Lbl_Array(r * 8 - (8 - c)).Visible = False
                        Block(c, r) = True
                    End If
                Next
            Next
        Else
            For r = 1 To 8
                For c = 1 To 8
                    If Blinking(c, r) = True Then
                        Lbl_Array(r * 8 - (8 - c)).Visible = True
                        Block(c, r) = False
                    End If
                Next
            Next
        End If


        check(LblCharacter.Left \ 50, LblCharacter.Top \ 50)
    End Sub

    Private Sub refreshTiles()
        imgStartImage.Visible = False
        LblCharacter.Visible = True
        'timerBegin()

        LblCharacter.Top = ((startingSquare \ 8) * 50) + 60
        LblCharacter.Left = ((startingSquare Mod 8) * 50) + 60
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
        For r = 1 To 8
            X = Lbl_Master.Location.X
            For c = 1 To 8
                Lbl_Array(CNT) = New Label
                Lbl_Array(CNT).Location = New System.Drawing.Point(X, Y)
                Lbl_Array(CNT).Size = New System.Drawing.Size(W, H)
                Lbl_Array(CNT).AutoSize = Lbl_Master.AutoSize
                Lbl_Array(CNT).BackColor = Lbl_Master.BackColor
                Lbl_Array(CNT).BorderStyle = Lbl_Master.BorderStyle
                Lbl_Array(CNT).TextAlign = Lbl_Master.TextAlign
                Lbl_Array(CNT).ForeColor = Lbl_Master.ForeColor
                Lbl_Array(CNT).Font = Lbl_Master.Font
                Lbl_Array(CNT).Tag = CNT ' This is the clever bit so that we can find the index!
                Lbl_Array(CNT).Visible = True
                Lbl_Array(CNT).BringToFront()
                AddHandler Lbl_Array(CNT).Click, AddressOf lblArray_click
                Panel1.Controls.Add(Lbl_Array(CNT))
                X = (X + W) + 10
                CNT += 1
            Next
            Y = (Y + H) + 10
        Next

        ' Copy of array

        Y = Lbl_Master.Location.Y
        H = Lbl_Master.Height
        W = Lbl_Master.Width

        CNT = 1
        For r = 1 To 8
            X = Lbl_Master.Location.X
            For c = 1 To 8
                Lbl_Array_Copy(CNT) = New Label
                Lbl_Array_Copy(CNT).Location = New System.Drawing.Point(X, Y)
                Lbl_Array_Copy(CNT).Size = New System.Drawing.Size(W, H)
                Lbl_Array_Copy(CNT).AutoSize = Lbl_Master.AutoSize
                Lbl_Array_Copy(CNT).BackColor = Color.Black
                Lbl_Array_Copy(CNT).BorderStyle = Lbl_Master.BorderStyle
                Lbl_Array_Copy(CNT).TextAlign = Lbl_Master.TextAlign
                Lbl_Array_Copy(CNT).ForeColor = Lbl_Master.ForeColor
                Lbl_Array_Copy(CNT).Font = Lbl_Master.Font
                Lbl_Array_Copy(CNT).Tag = CNT ' This is the clever bit so that we can find the index!
                Lbl_Array_Copy(CNT).Visible = True
                Lbl_Array_Copy(CNT).SendToBack()
                AddHandler Lbl_Array_Copy(CNT).Click, AddressOf Lbl_Array_Copy_click
                Panel1.Controls.Add(Lbl_Array_Copy(CNT))
                X = (X + W) + 10
                CNT += 1
            Next
            Y = (Y + H) + 10
        Next

        Select Case userlevel
            Case 1
                For i = 1 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 2
                For i = 1 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 36 To 37
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 42
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 3
                For i = 1 To 3
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 5 To 11
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 13 To 19
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 21 To 27
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 29 To 35
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 39 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 52
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 55 To 60
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 63 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 4
                For i = 1 To 18
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 34
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 38 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 5
                For i = 1 To 6
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 6
                For i = 1 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 31 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 42 To 42
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 47
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 52 To 53
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 57 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 7
                For i = 1 To 6
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 8

                For i = 3 To 8
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 11 To 16
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 27 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 51 To 56
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 59 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 9
                For i = 3 To 6
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 10
                For i = 3 To 3
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 11 To 11
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 14 To 15
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 19
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 23
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 27 To 27
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 31
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 38 To 39
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 47
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 51 To 51
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 54 To 55
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 59 To 59
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 62 To 63
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 11
                For i = 11 To 14
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 22
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 27 To 30
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 38
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 12
                For i = 1 To 12
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 15 To 18
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 23 To 29
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 31 To 35
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 39 To 42
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 50
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 55 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 13
                For i = 10 To 11
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 14 To 15
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 25 To 27
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 33 To 34
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 37 To 37
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 39 To 42
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 44 To 45
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 50
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 55 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 14 : level_14()
            Case 15
                For i = 19 To 22
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 27 To 30
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 38
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 16
                For i = 15 To 15
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 21 To 22
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 29 To 30
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 36
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 51
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 57 To 57
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 17
                For i = 1 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 18
                For i = 1 To 18
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 24 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 28 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 32 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 36 To 36
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 19
                For i = 12 To 14
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 20 To 22
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 28 To 30
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 34 To 34
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 36 To 38
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 44 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 54
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 57 To 62
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 20
                For i = 1 To 27
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 32 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 21
                For i = 10 To 15
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 18 To 19
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 26 To 29
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 34 To 38
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 42 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 48 To 48
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 50 To 54
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 56 To 56
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 64 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 22
                For i = 6 To 8
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 10 To 10
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 14 To 16
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 18 To 18
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 26 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 34 To 34
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 48
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 50 To 50
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 54 To 56
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 62 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 23

                For i = 1 To 25
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 39
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                startingSquare = 32
                winningSquare = 40

                Blinking(3, 4) = True
                Blinking(4, 4) = True
                Blinking(6, 4) = True
                Blinking(7, 4) = True
                Blinking(2, 5) = True
            Case 24
                For i = 1 To 25
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 32 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 44 To 45
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 47 To 49
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 52 To 53
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 56 To 57
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 64 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next


            Case 25
                For i = 1 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 43
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 45 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 26
                For i = 1 To 1
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 5 To 9
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 11 To 17
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 25
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 29 To 33
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 41
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 49
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 51 To 57
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 59 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 27
                For i = 1 To 2
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 8 To 10
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 12 To 12
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 14 To 14
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 16 To 18
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 21 To 21
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 24 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 28 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 30
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 32 To 34
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 40 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 28
                For i = 1 To 9
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 16 To 17
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 20
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 25
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 27 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 33
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 35 To 36
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 38 To 41
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 43 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 49
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 54 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 29
                For i = 10 To 10
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 19 To 19
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 28 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 37 To 37
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 55 To 55
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 30
                For i = 1 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 29 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 31
                For i = 14 To 20
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 38 To 39
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 47
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 52
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 54 To 55
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 32
                For i = 10 To 15
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 18 To 23
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 26 To 31
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 42 To 46
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 50 To 55
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 33
                For i = 1 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 28 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 43
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 45 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 34
                For i = 1 To 3
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 6 To 11
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 14 To 19
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 22 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 43
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 51
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 54 To 59
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 62 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 35
                For i = 9 To 11
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 13 To 14
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 25 To 28
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 30 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 38 To 44
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 51
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 55 To 56
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 61 To 61
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 36
                For i = 1 To 9
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 13 To 17
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 21 To 24
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 29 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 41 To 41
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 49 To 49
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 57 To 57
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 61 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 37
                For i = 10 To 13
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 18 To 23
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 26 To 29
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 34 To 39
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 42 To 45
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 50 To 55
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next
            Case 38 : level_38()
            Case 39 : level_39()
            Case 40 : level_40()
            Case 41 : level_41()
            Case 42 : level_42()
            Case 43 : level_43()
            Case 44 : level_44()
            Case 45 : level_45()
            Case 46 : level_46()
            Case 47 : level_47()
            Case 48 : level_48()
            Case 49 : level_49()
            Case 50 : level_50()
            Case 51
                For i = 1 To 26
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 31 To 32
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 39 To 42
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

                For i = 46 To 64
                    Lbl_Array(i).Visible = False
                    Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True
                Next

            Case 52 : level_52()
            Case 53 : level_53()
            Case 54 : level_54()
            Case 55 : level_55()
            Case 56 : level_56()
            Case 57 : level_57()
            Case 58 : level_58()
            Case 59 : level_59()
            Case 60 : level_60()
            Case 61 : level_61()
            Case 62 : level_62()
            Case 63 : level_63()
            Case 64 : level_64()
        End Select

        For i = 1 To 64
            If Block(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = False Then
                levelCheck += 1
            End If

            If DoubleJump(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True Then
                Lbl_Array(i).BackColor = Color.Purple
                levelCheck += 1
            End If

            If Blinking(Lbl_Array(i).Left \ 50, Lbl_Array(i).Top \ 50) = True Then
                Lbl_Array(i).BackColor = Color.Blue
            End If
        Next


        Label1.Visible = True
        Try
            Lbl_Array(winningSquare).Text = "Finish"
        Catch ex As Exception
            winningSquare = 64
        End Try

        LblCharacter.Focus()
    End Sub

    'Private Sub writeTime()
    '    addFile = System.IO.File.Create("./saved_games/" + userName + "_times.txt")
    '    addFile.Close()

    '    addLine = System.IO.File.AppendText("./saved_games/" + userName + "_times.txt")

    '    For i = 1 To 64
    '        addLine.WriteLine(timeArray(i))
    '    Next

    '    addLine.Close()
    'End Sub

    Private Sub cmbbxLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbxLevel.SelectedIndexChanged
        userlevel = Val(cmbbxLevel.SelectedIndex) + 1
        Dim Level_Design As New Level_Design
        Me.Hide()
        Level_Design.Show()
        cmbbxLevel.SelectedIndex = (userlevel - 1)
    End Sub

    Private Sub lblArray_click(sender As Object, e As EventArgs)
        lblPick.Text = sender.Tag
        Dim pick As Integer = sender.Tag

        If editOption = "Visible" Then                                                      ' When you want to change the visibility of something
            If Lbl_Array(pick).Visible = False Then
                Lbl_Array(pick).Visible = True
            Else
                Lbl_Array(pick).Visible = False
            End If
        ElseIf editOption = "Start Square" Then
            startingSquare = pick - 1

            LblCharacter.Top = ((startingSquare \ 8) * 50) + 60
            LblCharacter.Left = ((startingSquare Mod 8) * 50) + 60
        ElseIf editOption = "Finish" Then
            winningSquare = pick
            Lbl_Array(pick).Text += "Finish"
        ElseIf editOption = "Blinking" Then
            Dim c As Integer = pick Mod 8
            Dim r As Integer = (pick \ 8) + 1

            If Blinking(c, r) = True Then
                Blinking(c, r) = False
                Lbl_Array(pick).BackColor = Color.Lime
            Else
                Blinking(c, r) = True
                Lbl_Array(pick).BackColor = Color.Blue
            End If
        ElseIf editOption = "Double" Then
            Dim c As Integer = pick Mod 8
            Dim r As Integer = (pick \ 8) + 1

            If DoubleJump(c, r) = True Then
                DoubleJump(c, r) = False
                Lbl_Array(pick).BackColor = Color.Lime
            Else
                DoubleJump(c, r) = True
                Lbl_Array(pick).BackColor = Color.Purple
            End If

        End If
    End Sub

    Private Sub cmbbxOption_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbbxOption.SelectedIndexChanged
        editOption = cmbbxOption.Text
        lblMode.Text = editOption

    End Sub

    Private Sub Lbl_Array_Copy_click(sender As Object, e As EventArgs)
        lblPick.Text = sender.Tag
        Dim pick As Integer = sender.Tag

        If editOption = "Visible" Then
            If Lbl_Array(pick).Visible = False Then
                Lbl_Array(pick).Visible = True
            Else
                Lbl_Array(pick).Visible = False
            End If
        End If
    End Sub
End Class