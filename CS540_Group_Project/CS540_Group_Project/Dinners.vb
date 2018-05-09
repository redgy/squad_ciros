Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading
Imports System.Net
Imports System.IO

Public Class Dinners
    ' ResX file variables
    Dim resx_curr As ResXResourceSet
    Dim resx_enUS As ResXResourceSet = New ResXResourceSet("en-US.resx")
    Dim resx_esMX As ResXResourceSet = New ResXResourceSet("es-MX.resx")
    Dim resx_frFR As ResXResourceSet = New ResXResourceSet("fr-FR.resx")
    Dim resx_zhCHT As ResXResourceSet = New ResXResourceSet("zh-CHT.resx")
    Dim resx_arSA As ResXResourceSet = New ResXResourceSet("ar-SA.resx")


    ' Exchange rate variables
    Dim CNYrate As Double
    Dim EURrate As Double
    Dim MXNrate As Double
    Dim SARrate As Double


    Public Sub setMenuPrices()
        dinner1price.Text = resx_curr.GetString("dinner1price")
        dinner2price.Text = resx_curr.GetString("dinner2price")
        dinner3price.Text = resx_curr.GetString("dinner3price")
        dinner4price.Text = resx_curr.GetString("dinner4price")
    End Sub

    Public Sub setMenuText()
        dinner0.Text = resx_curr.GetString("dinner0")
        dinner0d.Text = resx_curr.GetString("dinner0d")
        dinner1.Text = resx_curr.GetString("dinner1")
        dinner1d.Text = resx_curr.GetString("dinner1d")
        dinner2.Text = resx_curr.GetString("dinner2")
        dinner2d.Text = resx_curr.GetString("dinner2d")
        dinner3.Text = resx_curr.GetString("dinner3")
        dinner3add.Text = resx_curr.GetString("dinner3add")
        dinner3d.Text = resx_curr.GetString("dinner3d")
        dinner4.Text = resx_curr.GetString("dinner4")
        dinner4d.Text = resx_curr.GetString("dinner4d")

        setMenuPrices()
    End Sub




    ''' This method name should be the same name as the form '''
    Private Sub Dinners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        resx_curr = resx_enUS
        setLabelText()
        getExchangeRates()
    End Sub

    ''' --------------------- TEMPLATE CODE THAT IS THE SAME FOR EVERY FORM ----------------------- '''

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
        Return Convert.ToDouble(manipulateStream(ostr))
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