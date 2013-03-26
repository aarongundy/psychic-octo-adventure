Imports System.Drawing

Public Class UserPick
    Dim userFile As String
    Dim readLine As String ' System.IO.StreamReader
    Dim objStreamReader As System.IO.StreamReader
    Dim addUser As System.IO.StreamWriter
    Dim makeFile As System.IO.Stream
    Dim userLabelArray As Label() = New Label(4) {}
    Dim namesArray As New ArrayList

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub UserPick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim X, Y, W, H, CNT As Integer

        objStreamReader = My.Computer.FileSystem.OpenTextFileReader("users.txt")

        ' Create a names array consisting of the names present in the users.txt file
        While objStreamReader.Peek <> -1
            userFile = objStreamReader.ReadLine
            namesArray.Add(userFile)
        End While

        'Define the Size and location of the master label
        X = Master_UserSlot.Location.X
        Y = Master_UserSlot.Location.Y
        W = Master_UserSlot.Width
        H = Master_UserSlot.Height

        CNT = 1

        For i = 0 To 3                                                          ' Build the labe array
            userLabelArray(CNT) = New Label
            userLabelArray(CNT).Location = New System.Drawing.Point(X, Y)
            userLabelArray(CNT).Size = New System.Drawing.Size(W, H)
            userLabelArray(CNT).AutoSize = Master_UserSlot.AutoSize
            userLabelArray(CNT).Font = Master_UserSlot.Font
            userLabelArray(CNT).TextAlign = Master_UserSlot.TextAlign
            userLabelArray(CNT).MinimumSize = Master_UserSlot.MinimumSize
            userLabelArray(CNT).ForeColor = Master_UserSlot.ForeColor
            userLabelArray(CNT).BackColor = Master_UserSlot.BackColor
            userLabelArray(CNT).BringToFront()
            userLabelArray(CNT).Tag = CNT
            userLabelArray(CNT).Visible = True
            AddHandler userLabelArray(CNT).Click, AddressOf userLabelArray_click
            Panel1.Controls.Add(userLabelArray(CNT))

            If namesArray.Count < CNT Then
                userLabelArray(CNT).Text = "<BLANKSLOT>"
            Else
                userLabelArray(CNT).Text = namesArray(i)
            End If

            CNT += 1
            Y += 10 + H
        Next

        Master_UserSlot.Visible = False

        Me.BackColor = backgroundColor
        Me.ForeColor = textColor
        objStreamReader.Close()
        Label3.Text = namesArray.Count
    End Sub

    Private Sub updateForm()
        Dim UserPick As New UserPick
        Me.Hide()
        UserPick.Show()
    End Sub

    Private Sub lblDelete_Player_Click(sender As System.Object, e As System.EventArgs) Handles lblDelete_Player.Click
        Dim Delete_User As New Delete_User
        Me.Hide()
        Delete_User.Show()
    End Sub

    Private Sub btnNewPlayer_Click(sender As System.Object, e As System.EventArgs) Handles btnNewPlayer.Click
        newUser()
    End Sub

    Private Sub userLabelArray_click(ByVal sender As Object, ByVal e As EventArgs) 'Handles userLabelArray.Click
        Label3.Text = sender.text


        If sender.text = "<BLANKSLOT>" Then
            newUser()
        Else
            userName = sender.text
            Dim Main_Menu2 As New Main_Menu
            Me.Hide()
            Main_Menu2.Show()
        End If
    End Sub

    Private Sub newUser()
        objStreamReader = My.Computer.FileSystem.OpenTextFileReader(".\users.txt")

        ' Create a names array consisting of the names present in the users.txt file
        'While objStreamReader.Peek <> -1
        '    userFile = objStreamReader.ReadLine
        '    namesArray.Add(userFile)
        'End While

        objStreamReader.Close()

        If namesArray.Count >= 4 Then
            MessageBox.Show("Please delete a username or play as an already existing player.", "Reached Max Saved Game Amount", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            userName = InputBox("New Username", "Enter your new username")

            If userName <> "" Then                                  ' Only write a line if there is some text
                addUser = System.IO.File.AppendText("users.txt")
                addUser.WriteLine(userName)
                addUser.Close()
                makeFile = System.IO.File.Create(".\saved_games\" & userName & ".txt")
                makeFile.Close()
                makeFile = System.IO.File.Create(".\saved_games\" & userName & "_times.txt")
                makeFile.Close()
                addUser = System.IO.File.AppendText(".\saved_games\" & userName & ".txt")
                addUser.WriteLine(userName)
                addUser.Close()
            End If

            Dim Main_Menu2 As New Main_Menu
            Me.Hide()
            Main_Menu2.Show()
        End If
    End Sub

    Private Sub btnDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesign.Click
        Dim Design_Level As New Level_Design
        Me.Hide()
        Design_Level.Show()
    End Sub
End Class