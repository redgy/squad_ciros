Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading
Imports System.Net
Imports System.IO

Public Class Pizza
    ' ResX file variables
    Dim resx_curr As ResXResourceSet
    Dim resx_enUS As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_esMX As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_frFR As ResXResourceSet = New ResXResourceSet("fr-FR.resx")
    Dim resx_zhCHT As ResXResourceSet = New ResXResourceSet("zh-CHT.resx")
    Dim resx_arSA As ResXResourceSet = New ResXResourceSet("ar-SA.resx")


    ' Culture info variables
    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim mexicoCulture As CultureInfo = New CultureInfo("es-MX")
    Dim frenchCulture As CultureInfo = New CultureInfo("fr-FR")
    Dim chinaCulture As CultureInfo = New CultureInfo("zh-CHT")
    Dim saudiCulture As CultureInfo = New CultureInfo("ar-SA")
    Dim currCulture As CultureInfo



    ' Exchange rate variables
    Dim CNYrate As Double
    Dim EURrate As Double
    Dim MXNrate As Double
    Dim SARrate As Double

    ' Function get the weird pizza label price
    Private Function convertPizza(str As String)
        Dim foundIndex As Integer
        foundIndex = str.IndexOf("$")
        Dim first As String = str.Substring(0, foundIndex)
        Dim second As String = str.Substring(foundIndex + 1)
        Return first + " " + convertPrice(second)
    End Function

    Public Sub setPriceText()
        cheese1price.Text = convertPrice(resx_curr.GetString("cheese1price"))
        cheese2price.Text = convertPrice(resx_curr.GetString("cheese2price"))
        cheese3price.Text = convertPrice(resx_curr.GetString("cheese3price"))
        cheese4price.Text = convertPrice(resx_curr.GetString("cheese4price"))
        cheese5price.Text = convertPrice(resx_curr.GetString("cheese5price"))
        protein1price.Text = convertPrice(resx_curr.GetString("protein1price"))
        protein2price.Text = convertPrice(resx_curr.GetString("protein2price"))
        protein3price.Text = convertPrice(resx_curr.GetString("protein3price"))
        protein4price.Text = convertPrice(resx_curr.GetString("protein4price"))
        protein5price.Text = convertPrice(resx_curr.GetString("protein5price"))
        protein6price.Text = convertPrice(resx_curr.GetString("protein6price"))
        veggie1price.Text = convertPrice(resx_curr.GetString("veggie1price"))
        veggie2price.Text = convertPrice(resx_curr.GetString("veggie2price"))
        veggie3price.Text = convertPrice(resx_curr.GetString("veggie3price"))
        veggie4price.Text = convertPrice(resx_curr.GetString("veggie4price"))
        veggie5price.Text = convertPrice(resx_curr.GetString("veggie5price"))
        veggie6price.Text = convertPrice(resx_curr.GetString("veggie6price"))
        veggie7price.Text = convertPrice(resx_curr.GetString("veggie7price"))
        veggie8price.Text = convertPrice(resx_curr.GetString("veggie8price"))
        veggie9price.Text = convertPrice(resx_curr.GetString("veggie9price"))
        veggie10price.Text = convertPrice(resx_curr.GetString("veggie10price"))
        veggie11price.Text = convertPrice(resx_curr.GetString("veggie11price"))

        resizeFont(cheese1price)
        resizeFont(cheese2price)
        resizeFont(cheese3price)
        resizeFont(cheese4price)
        resizeFont(cheese5price)
        resizeFont(protein1price)
        resizeFont(protein2price)
        resizeFont(protein3price)
        resizeFont(protein4price)
        resizeFont(protein5price)
        resizeFont(protein6price)
        resizeFont(veggie1price)
        resizeFont(veggie2price)
        resizeFont(veggie3price)
        resizeFont(veggie4price)
        resizeFont(veggie5price)
        resizeFont(veggie6price)
        resizeFont(veggie7price)
        resizeFont(veggie8price)
        resizeFont(veggie9price)
        resizeFont(veggie10price)
        resizeFont(veggie11price)

        createPizzaprice1.Text = convertPizza(resx_curr.GetString("createPizzaprice1"))
        createPizzaprice2.Text = convertPizza(resx_curr.GetString("createPizzaprice2"))
        specialtyPizzaprice1.Text = convertPizza(resx_curr.GetString("specialtyPizzaprice1"))
        specialtyPizzaprice2.Text = convertPizza(resx_curr.GetString("specialtyPizzaprice2"))
    End Sub


    Public Sub setMenuText()
        cheese0.Text = resx_curr.GetString("cheese0")
        cheese1.Text = resx_curr.GetString("cheese1")
        cheese2.Text = resx_curr.GetString("cheese2")
        cheese3.Text = resx_curr.GetString("cheese3")
        cheese4.Text = resx_curr.GetString("cheese4")
        cheese5.Text = resx_curr.GetString("cheese5")
        createPizza.Text = resx_curr.GetString("createPizza")

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
        protein2.Text = resx_curr.GetString("protein2")
        protein3.Text = resx_curr.GetString("protein3")
        protein4.Text = resx_curr.GetString("protein4")
        protein5.Text = resx_curr.GetString("protein5")
        protein6.Text = resx_curr.GetString("protein6")

        sauce0.Text = resx_curr.GetString("sauce0")
        sauce1.Text = resx_curr.GetString("sauce1")
        sauce2.Text = resx_curr.GetString("sauce2")

        specialtyPizzas.Text = resx_curr.GetString("specialtyPizzas")

        veggies0.Text = resx_curr.GetString("veggies0")
        veggie1.Text = resx_curr.GetString("veggie1")
        veggie2.Text = resx_curr.GetString("veggie2")
        veggie3.Text = resx_curr.GetString("veggie3")
        veggie4.Text = resx_curr.GetString("veggie4")
        veggie5.Text = resx_curr.GetString("veggie5")
        veggie6.Text = resx_curr.GetString("veggie6")
        veggie7.Text = resx_curr.GetString("veggie7")
        veggie8.Text = resx_curr.GetString("veggie8")
        veggie9.Text = resx_curr.GetString("veggie9")
        veggie10.Text = resx_curr.GetString("veggie10")
        veggie11.Text = resx_curr.GetString("veggie11")

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

        setPriceText()
    End Sub


    ''' This method name should be the same name as the form '''
    Private Sub Pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        resx_curr = resx_enUS
        currCulture = usaCulture
        mexicoCulture.NumberFormat.CurrencySymbol = "Mex$"
        chinaCulture.NumberFormat.CurrencySymbol = "個"
        setLabelText()
        getExchangeRates()
    End Sub

    ''' --------------------- TEMPLATE CODE THAT IS THE SAME FOR EVERY FORM ----------------------- '''

    ''' CONVERT THE EXCHANGE RATES '''
    ' Function to do the conversion rates
    Private Function convertPrice(amount As String)
        Dim number As Double = CDbl(amount)
        If resx_curr.Equals(resx_esMX) Then
            number *= MXNrate
        ElseIf resx_curr.Equals(resx_frFR) Then
            number *= EURrate
        ElseIf resx_curr.Equals(resx_zhCHT) Then
            number *= CNYrate
        ElseIf resx_curr.Equals(resx_arSA) Then
            number *= SARrate
        End If

        Return number.ToString("C", currCulture)
    End Function


    ''' GETTING THE EXCHANGE RATES '''
    ''' Loops through the stream and extracts the conversion '''
    Private Function manipulateStream(ostr As Stream)
        Dim objReader As New StreamReader(ostr)
        Dim sLine As String = ""
        Dim i As Integer = 0
        Dim foundIndex As Integer

        Dim str As String = ""
        Do While Not sLine Is Nothing
            i += 1
            sLine = objReader.ReadLine
            If Not sLine Is Nothing Then
                foundIndex = sLine.IndexOf("uccResultAmount")
                If foundIndex.CompareTo(-1) Then
                    str = sLine.Substring(foundIndex)
                    foundIndex = str.IndexOf(">") '' start of number

                    str = str.Substring(foundIndex)
                    foundIndex = str.IndexOf("<") '' end of number

                    str = str.Substring(1, foundIndex - 1)
                End If
            End If
        Loop
        Return str '' this will be the conversion rate
    End Function


    '' Method will take in the desired currency and grab currency from url ''
    Private Function loadURL(currency As String)
        Dim url As String
        Dim wRequest As WebRequest
        Dim ostr As Stream

        url = "https://xe.com/currencyconverter/convert/?Amount=1&From=USD&To="
        url = url + currency
        wRequest = WebRequest.Create(url)
        wRequest.Proxy = WebProxy.GetDefaultProxy()
        ostr = wRequest.GetResponse.GetResponseStream()
        Return CDbl(manipulateStream(ostr))
    End Function

    ''' Method to grab currencies and do conversions '''
    Private Sub getExchangeRates()
        CNYrate = loadURL("CNY")
        EURrate = loadURL("EUR")
        MXNrate = loadURL("MXN")
        SARrate = loadURL("SAR")
    End Sub


    ''' LOAD NEW FORMS METHODS '''
    Private Sub appetizerLabel_Click(sender As Object, e As EventArgs) Handles appetizerLabel.Click
        Dim f As New Appetizers
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        Me.Hide()
    End Sub

    Private Sub saladLabel_Click(sender As Object, e As EventArgs) Handles saladLabel.Click
        Dim f As New Salads
        f.StartPosition = FormStartPosition.CenterScreen
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
        Dim f As New Stromboli
        f.Show()
        Me.Hide()
    End Sub

    Private Sub dessertDrinkLabel_Click(sender As Object, e As EventArgs) Handles dessertDrinkLabel.Click
        Dim f As New DessertsDrinks
        f.Show()
        Me.Hide()
    End Sub
    Private Sub dinnersLabel_Click(sender As Object, e As EventArgs) Handles dinnersLabel.Click
        Dim f As New Dinners
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
        setMenuText()
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
        currCulture = usaCulture
        setLabelText()
    End Sub

    Private Sub spanishLabel_Click(sender As Object, e As EventArgs) Handles spanishLabel.Click
        resx_curr = resx_esMX
        currCulture = mexicoCulture
        setLabelText()
    End Sub

    Private Sub frenchLabel_Click(sender As Object, e As EventArgs) Handles frenchLabel.Click
        resx_curr = resx_frFR
        currCulture = frenchCulture
        setLabelText()
    End Sub

    Private Sub chineseLabel_Click(sender As Object, e As EventArgs) Handles chineseLabel.Click
        resx_curr = resx_zhCHT
        currCulture = chinaCulture
        setLabelText()
    End Sub

    Private Sub saLabel_Click(sender As Object, e As EventArgs) Handles saLabel.Click
        resx_curr = resx_arSA
        currCulture = saudiCulture
        setLabelText()
    End Sub

    ''' CENTERING THE FORM (be sure to call from Load function) '''
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
End Class