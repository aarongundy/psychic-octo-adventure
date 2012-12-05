
Public Class Main_Menu

    Private Sub btnLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel1.Click
        Dim Level_1 As New Level_1
        Level_1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel2.Click
        Dim Level_2 As New Level_2
        Level_2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLevel3.Click
        Dim Level_3 As New Level_3
        Level_3.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLevel4_Click(sender As System.Object, e As System.EventArgs) Handles btnLevel4.Click
        Dim Level_4 As New Level_4
        Level_4.Show()
        Me.Hide()
    End Sub
End Class
