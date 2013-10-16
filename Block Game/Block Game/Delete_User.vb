Public Class Delete_User
    Dim readLines As System.IO.StreamReader
    Dim deleteLine As System.IO.Stream
    Dim addUser As System.IO.StreamWriter
    Dim namesArray As New ArrayList
    Dim userFile As String

    Private Sub Delete_User_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim length, i As Integer
        readLines = My.Computer.FileSystem.OpenTextFileReader("users.txt")

        ' Create a names array consisting of the names present in the users.txt file
        While readLines.Peek <> -1
            userFile = readLines.ReadLine
            namesArray.Add(userFile)
        End While

        length = namesArray.Count
        For i = 0 To length - 1
            lstbxUsers.Items.Add(namesArray(i))
        Next
        readLines.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim selected As Integer
        Dim filename As String
        deleteLine = System.IO.File.Create("users.txt")
        deleteLine.Close()


        If lstbxUsers.SelectedIndex <> -1 Then
            selected = lstbxUsers.SelectedIndex
            filename = "./saved_games/" + namesArray(selected) + ".txt"
            My.Computer.FileSystem.DeleteFile(filename)
            namesArray.RemoveAt(selected)
        End If

        addUser = System.IO.File.AppendText("users.txt")

        Dim n As Integer = 0
        While n < namesArray.Count
            addUser.WriteLine(namesArray(n))
            n += 1
        End While

        addUser.Close()

        Dim UserPick As New UserPick
        Me.Close()
        UserPick.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        UserPick.Show()
        Me.Hide()
    End Sub
End Class