Public Class mainPage
    Dim menuForm As MenuForm

    Private Sub menuButton_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        menuForm = New MenuForm()
        ' Me.Hide()
        menuForm.Show()
    End Sub

End Class
