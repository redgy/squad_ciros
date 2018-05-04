Public Class Pizza
    Private Sub saladLabel_Click(sender As Object, e As EventArgs)
        Dim f As New Salads
        f.Show()
        Me.Hide()
    End Sub

    Private Sub signatureSubLabel_Click(sender As Object, e As EventArgs)
        Dim f As New SignatureSubs
        f.Show()
        Me.Hide()
    End Sub

    Private Sub stromboliLabel_Click(sender As Object, e As EventArgs)
        Dim f As New Stromboli
        f.Show()
        Me.Hide()
    End Sub

    Private Sub dessertDrinkLabel_Click(sender As Object, e As EventArgs)
        Dim f As New DessertsDrinks
        f.Show()
        Me.Hide()
    End Sub

    Private Sub appetizerLabel_Click(sender As Object, e As EventArgs)
        Dim f As New Appetizers
        f.Show()
        Me.Hide()
    End Sub

    Private Sub dinnersLabel_Click(sender As Object, e As EventArgs) Handles dinnersLabel.Click
        Dim f As New Dinners
        f.Show()
        Me.Hide()
    End Sub
End Class