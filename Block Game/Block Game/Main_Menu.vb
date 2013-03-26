Public Class Main_Menu
    Public Lbl_Array As Label() = New Label(64) {}
    Dim fileReader As System.IO.StreamReader
    Dim time As Double

    Private Sub Main_Menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'imgStartImage.Visible = False
        timesLoad()

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
                Lbl_Array(CNT).Text = CNT & vbNewLine & timeArray(CNT)
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

        lblUser.Text = "User: " & userName

        'For i = 1 To 32
        '    Lbl_Array(i).Visible = False
        'Next

        'For i = 41 To 64
        '    Lbl_Array(i).Visible = False
        'Next

        'Label1.Visible = True
        'Lbl_Array(winningSquare).Text = "Finish"
        'LblCharacter.Focus()
    End Sub

    Private Sub lblArray_click(ByVal sender As Object, ByVal e As EventArgs)
        'Dim selectedForm As Form
        'selectedForm = "Level_" & sender.Tag
        'Dim levelload As New selectedForm
        'levelload.show()
        userlevel = Val(sender.Tag)
        Dim Level As New Level
        Me.Hide()
        Level.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim UserPick As New UserPick
        Me.Hide()
        UserPick.Show()
    End Sub

    Private Sub timesLoad()
        fileReader = My.Computer.FileSystem.OpenTextFileReader(".\saved_games\" & userName & "_times.txt")

        For i = 1 To 64
            time = fileReader.ReadLine

            timeArray(i) = time
        Next

        fileReader.Close()
    End Sub
End Class