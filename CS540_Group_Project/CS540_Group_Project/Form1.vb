Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class Form1
    ' ResX file variables
    Dim resx_curr As ResXResourceSet
    Dim resx_enUS As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_esMX As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_frFR As ResXResourceSet = New ResXResourceSet("fr-FR.resx")
    Dim resx_zhCHT As ResXResourceSet = New ResXResourceSet("zh-CHT.resx")
    Dim resx_arSA As ResXResourceSet = New ResXResourceSet("ar-SA.resx")



    ''' Load form click methods '''
    Private Sub appetizerLabel_Click(sender As Object, e As EventArgs) Handles appetizerLabel.Click
        Dim f As New Appetizers
        f.Show()
        Me.Hide()
    End Sub

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
    Private Sub dinnersLabel_Click(sender As Object, e As EventArgs) Handles dinnersLabel.Click
        Dim f As New Dinners
        f.Show()
        Me.Hide()
    End Sub



    ''' Main refresh method '''
    Private Sub myRefresh()
        appetizerLabel.Text = resx_curr.GetString("appetizersLabel")
        saladLabel.Text = resx_curr.GetString("saladsLabel")
        signatureSubLabel.Text = resx_curr.GetString("signatureSubsLabel")
        pizzaLabel.Text = resx_curr.GetString("pizzaLabel")
        stromboliLabel.Text = resx_curr.GetString("stromboliLabel")
        dinnersLabel.Text = resx_curr.GetString("dinnersLabel")
        dessertDrinkLabel.Text = resx_curr.GetString("dessertsDrinksLabel")
    End Sub



    ''' Language button clicks '''
    Private Sub englishLabel_Click(sender As Object, e As EventArgs) Handles englishLabel.Click
        resx_curr = resx_enUS
        myRefresh()
    End Sub

    Private Sub spanishLabel_Click(sender As Object, e As EventArgs) Handles spanishLabel.Click
        resx_curr = resx_esMX
        myRefresh()
    End Sub

    Private Sub frenchLabel_Click(sender As Object, e As EventArgs) Handles frenchLabel.Click
        resx_curr = resx_frFR
        myRefresh()
    End Sub

    Private Sub chineseLabel_Click(sender As Object, e As EventArgs) Handles chineseLabel.Click
        resx_curr = resx_zhCHT
        myRefresh()
    End Sub

    Private Sub saLabel_Click(sender As Object, e As EventArgs) Handles saLabel.Click
        resx_curr = resx_arSA
        myRefresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resx_curr = resx_enUS
        myRefresh()
    End Sub

End Class
