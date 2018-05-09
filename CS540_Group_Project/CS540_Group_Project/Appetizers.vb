Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class Appetizers
    ' ResX file variables
    Dim resx_curr As ResXResourceSet
    Dim resx_enUS As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_esMX As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_frFR As ResXResourceSet = New ResXResourceSet("fr-FR.resx")
    Dim resx_zhCHT As ResXResourceSet = New ResXResourceSet("zh-CHT.resx")
    Dim resx_arSA As ResXResourceSet = New ResXResourceSet("ar-SA.resx")



    Private Sub setMenuText()
        app1price1.Text = resx_curr.GetString("app1price1")
        app1price2.Text = resx_curr.GetString("app1price2")
        app1price3.Text = resx_curr.GetString("app1price3")
        app2price.Text = resx_curr.GetString("app2price")
        app3price.Text = resx_curr.GetString("app3price")
        app4price.Text = resx_curr.GetString("app4price")
        appetizer0.Text = resx_curr.GetString("appetizer0")
        appetizer1.Text = resx_curr.GetString("appetizer1")
        appetizer1d.Text = resx_curr.GetString("appetizer1d")
        appetizer2.Text = resx_curr.GetString("appetizer2")
        appetizer2d.Text = resx_curr.GetString("appetizer2d")
        appetizer3.Text = resx_curr.GetString("appetizer3")
        appetizer3d.Text = resx_curr.GetString("appetizer3d")
        appetizer4.Text = resx_curr.GetString("appetizer4")
        appetizer4d.Text = resx_curr.GetString("appetizer4d")
    End Sub


    ''' This method name should be the same name as the form '''
    Private Sub Appetizers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resx_curr = resx_enUS
        setLabelText()
    End Sub

    ''' --------------------- TEMPLATE CODE THAT IS THE SAME FOR EVERY FORM ----------------------- '''

    ''' LOAD NEW FORMS METHODS (delete the label click of the current form) '''
    Private Sub saladLabel_Click(sender As Object, e As EventArgs) Handles saladLabel.Click
        Dim f As New Salads
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub

    Private Sub signatureSubLabel_Click(sender As Object, e As EventArgs) Handles signatureSubLabel.Click
        Dim f As New SignatureSubs
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub

    Private Sub pizzaLabel_Click(sender As Object, e As EventArgs) Handles pizzaLabel.Click
        Dim f As New Pizza
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub

    Private Sub stromboliLabel_Click(sender As Object, e As EventArgs) Handles stromboliLabel.Click
        Dim f As New Stromboli
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub

    Private Sub dessertDrinkLabel_Click(sender As Object, e As EventArgs) Handles dessertDrinkLabel.Click
        Dim f As New DessertsDrinks(resx_curr)
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub
    Private Sub dinnersLabel_Click(sender As Object, e As EventArgs) Handles dinnersLabel.Click
        Dim f As New Dinners(resx_curr)
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub


    ''' SET LABEL TEXT METHOD: This method will change labels based off of resx file '''
    Private Sub setLabelText()
        appetizerLabel.Text = resx_curr.GetString("appetizersLabel")
        saladLabel.Text = resx_curr.GetString("saladsLabel")
        signatureSubLabel.Text = resx_curr.GetString("signatureSubsLabel")
        pizzaLabel.Text = resx_curr.GetString("pizzaLabel")
        stromboliLabel.Text = resx_curr.GetString("stromboliLabel")
        dinnersLabel.Text = resx_curr.GetString("dinnersLabel")
        dessertDrinkLabel.Text = resx_curr.GetString("dessertsDrinksLabel")

        resizeFont(appetizerLabel)
        resizeFont(saladLabel)
        resizeFont(signatureSubLabel)
        resizeFont(pizzaLabel)
        resizeFont(stromboliLabel)
        resizeFont(dinnersLabel)
        resizeFont(dessertDrinkLabel)

        setMenuText() '' For the menu which is different on every form
    End Sub


    Private Sub resizeFont(resizeFontLabel As Label)
        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim word As String
        Dim Factor_, FactorX, FactorY As Single

        g2 = resizeFontLabel.CreateGraphics
        word = resizeFontLabel.Text
        s2 = g2.MeasureString(word, resizeFontLabel.Font)
        g2.Dispose()

        FactorX = resizeFontLabel.Width / s2.Width
        FactorY = resizeFontLabel.Height / s2.Height

        If FactorX > FactorY Then
            Factor_ = FactorY
        Else
            Factor_ = FactorX
        End If

        f2 = resizeFontLabel.Font
        resizeFontLabel.Font = New Font(f2.Name, f2.SizeInPoints * Factor_)
        resizeFontLabel.Text = word
        resizeFontLabel.TextAlign = ContentAlignment.MiddleCenter
    End Sub


    ''' LANGUAGE SELECTION BUTTON METHODS '''
    Private Sub englishLabel_Click(sender As Object, e As EventArgs) Handles englishLabel.Click
        resx_curr = resx_enUS
        setLabelText()
    End Sub

    Private Sub spanishLabel_Click(sender As Object, e As EventArgs) Handles spanishLabel.Click
        resx_curr = resx_esMX
        setLabelText()
    End Sub

    Private Sub frenchLabel_Click(sender As Object, e As EventArgs) Handles frenchLabel.Click
        resx_curr = resx_frFR
        setLabelText()
    End Sub

    Private Sub chineseLabel_Click(sender As Object, e As EventArgs) Handles chineseLabel.Click
        resx_curr = resx_zhCHT
        setLabelText()
    End Sub

    Private Sub saLabel_Click(sender As Object, e As EventArgs) Handles saLabel.Click
        resx_curr = resx_arSA
        setLabelText()
    End Sub

End Class