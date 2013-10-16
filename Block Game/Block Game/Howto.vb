Public Class Howto

    Private Sub btnUserPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserPick.Click
        Dim userpick As New UserPick
        Me.Hide()
        userpick.Show()
    End Sub
End Class