Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class Pizza
    ' ResX file variables
    Dim resx_curr As ResXResourceSet
    Dim resx_enUS As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_esMX As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_frFR As ResXResourceSet = New ResXResourceSet("fr-FR.resx")
    Dim resx_zhCHT As ResXResourceSet = New ResXResourceSet("zh-CHT.resx")
    Dim resx_arSA As ResXResourceSet = New ResXResourceSet("ar-SA.resx")

    Public Sub setMenuText()
        cheese0.Text = resx_curr.GetString("cheese0")
        cheese1.Text = resx_curr.GetString("cheese1")
        cheese1price.Text = resx_curr.GetString("cheese1price")
        cheese2.Text = resx_curr.GetString("cheese2")
        cheese2price.Text = resx_curr.GetString("cheese2price")
        cheese3.Text = resx_curr.GetString("cheese3")
        cheese3price.Text = resx_curr.GetString("cheese3price")
        cheese4.Text = resx_curr.GetString("cheese4")
        cheese4price.Text = resx_curr.GetString("cheese4price")
        cheese5.Text = resx_curr.GetString("cheese5")
        cheese5price.Text = resx_curr.GetString("cheese5price")
        createPizza.Text = resx_curr.GetString("createPizza")
        createPizzaprice1.Text = resx_curr.GetString("createPizzaprice1")
        createPizzaprice2.Text = resx_curr.GetString("createPizzaprice1")

        redPies0.Text = resx_curr.GetString("redPies0")
        redPies1.Text = resx_curr.GetString("redPies1")
        redPies1d.Text = resx_curr.GetString("redPies1d")
        redPies2.Text = resx_curr.GetString("redPies2")
        redPies2d.Text = resx_curr.GetString("redPies2d")
        redPies3.Text = resx_curr.GetString("redPies3")
        redPies3d.Text = resx_curr.GetString("redPies3d")
        redPies4.Text = resx_curr.GetString("redPies4")
        redPies4d.Text = resx_curr.GetString("redPies4d")
        redPies5.Text = resx_curr.GetString("redPies5")
        redPies5d.Text = resx_curr.GetString("redPies5d")

        protein0.Text = resx_curr.GetString("protein0")
        protein1.Text = resx_curr.GetString("protein1")
        protein1price.Text = resx_curr.GetString("protein1price")
        protein2.Text = resx_curr.GetString("protein2")
        protein2price.Text = resx_curr.GetString("protein2price")
        protein3.Text = resx_curr.GetString("protein3")
        protein3price.Text = resx_curr.GetString("protein3price")
        protein4.Text = resx_curr.GetString("protein4")
        protein4price.Text = resx_curr.GetString("protein4price")
        protein5.Text = resx_curr.GetString("protein5")
        protein5price.Text = resx_curr.GetString("protein5price")
        protein6.Text = resx_curr.GetString("protein6")
        protein6price.Text = resx_curr.GetString("protein6price")

        sauce0.Text = resx_curr.GetString("sauce0")
        sauce1.Text = resx_curr.GetString("sauce1")
        sauce2.Text = resx_curr.GetString("sauce2")

        specialtyPizzaprice1.Text = resx_curr.GetString("specialtyPizzaprice1")
        specialtyPizzaprice2.Text = resx_curr.GetString("specialtyPizzaprice2")
        specialtyPizzas.Text = resx_curr.GetString("specialtyPizzas")

        veggie1.Text = resx_curr.GetString("veggie1")
        veggie10.Text = resx_curr.GetString("veggie10")
        veggie10price.Text = resx_curr.GetString("veggie10price")
        veggie11.Text = resx_curr.GetString("veggie11")
        veggie11price.Text = resx_curr.GetString("veggie11price")
        veggie1price.Text = resx_curr.GetString("veggie1price")
        veggie2.Text = resx_curr.GetString("veggie2")
        veggie2price.Text = resx_curr.GetString("veggie2price")
        veggie3.Text = resx_curr.GetString("veggie3")
        veggie3price.Text = resx_curr.GetString("veggie3price")
        veggie4.Text = resx_curr.GetString("veggie4")
        veggie4price.Text = resx_curr.GetString("veggie4price")
        veggie5.Text = resx_curr.GetString("veggie5")
        veggie5price.Text = resx_curr.GetString("veggie5price")
        veggie6.Text = resx_curr.GetString("veggie6")
        veggie6price.Text = resx_curr.GetString("veggie6price")
        veggie7.Text = resx_curr.GetString("veggie7")
        veggie7price.Text = resx_curr.GetString("veggie7price")
        veggie8.Text = resx_curr.GetString("veggie8")
        veggie8price.Text = resx_curr.GetString("veggie8price")
        veggie9.Text = resx_curr.GetString("veggie9")
        veggie9price.Text = resx_curr.GetString("veggie9price")
        veggies0.Text = resx_curr.GetString("veggies0")

        whitePies0.Text = resx_curr.GetString("whitePies")
        whitePies1.Text = resx_curr.GetString("whitePies1")
        whitePies1d.Text = resx_curr.GetString("whitePies1d")
        whitePies2.Text = resx_curr.GetString("whitePies2")
        whitePies2d.Text = resx_curr.GetString("whitePies2d")
        whitePies3.Text = resx_curr.GetString("whitePies3")
        whitePies3d.Text = resx_curr.GetString("whitePies3d")
        whitePies4.Text = resx_curr.GetString("whitePies4")
        whitePies4d.Text = resx_curr.GetString("whitePies4d")
        whitePies5.Text = resx_curr.GetString("whitePies5")
        whitePies5d.Text = resx_curr.GetString("whitePies5d")
        whitePies6.Text = resx_curr.GetString("whitePies6")
        whitePies6d.Text = resx_curr.GetString("whitePies6d")
        whitePies7.Text = resx_curr.GetString("whitePies7")
        whitePies7d.Text = resx_curr.GetString("whitePies7d")
        whitePies8.Text = resx_curr.GetString("whitePies8")
        whitePies8d.Text = resx_curr.GetString("whitePies8d")
    End Sub


    ''' This method name should be the same name as the form '''
    Private Sub Pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resx_curr = resx_enUS
        setLabelText()
    End Sub

    ''' --------------------- TEMPLATE CODE THAT IS THE SAME FOR EVERY FORM ----------------------- '''

    ''' LOAD NEW FORMS METHODS '''
    Private Sub appetizerLabel_Click(sender As Object, e As EventArgs) Handles appetizerLabel.Click
        Dim f As New Appetizers
        f.Show()
        Me.Hide()
    End Sub

    Private Sub saladLabel_Click(sender As Object, e As EventArgs) Handles saladLabel.Click
        Dim f As New Salads
        f.Show()
        Me.Hide()
    End Sub

    Private Sub signatureSubLabel_Click(sender As Object, e As EventArgs) Handles signatureSubLabel.Click
        Dim f As New SignatureSubs
        f.Show()
        Me.Hide()
    End Sub

    Private Sub pizzaLabel_Click(sender As Object, e As EventArgs) Handles pizzaLabel.Click
        Dim f As New Pizza
        f.Show()
        Me.Hide()
    End Sub

    Private Sub stromboliLabel_Click(sender As Object, e As EventArgs) Handles stromboliLabel.Click
        Dim f As New Stromboli(resx_curr)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub dessertDrinkLabel_Click(sender As Object, e As EventArgs) Handles dessertDrinkLabel.Click
        Dim f As New DessertsDrinks(resx_curr)
        f.Show()
        Me.Hide()
    End Sub
    Private Sub dinnersLabel_Click(sender As Object, e As EventArgs) Handles dinnersLabel.Click
        Dim f As New Dinners(resx_curr)
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