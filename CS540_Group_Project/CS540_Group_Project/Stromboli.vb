﻿Public Class Stromboli
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

    Private Sub pizzaLabel_Click(sender As Object, e As EventArgs)
        Dim f As New Pizza
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

End Class