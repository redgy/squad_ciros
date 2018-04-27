<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.navbar = New System.Windows.Forms.Label()
        Me.border = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuButton = New System.Windows.Forms.Label()
        Me.englishButton = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.arabicButton = New System.Windows.Forms.Label()
        Me.frenchButton = New System.Windows.Forms.Label()
        Me.spanishButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'navbar
        '
        Me.navbar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.navbar.Location = New System.Drawing.Point(-1, 1)
        Me.navbar.Name = "navbar"
        Me.navbar.Size = New System.Drawing.Size(1074, 41)
        Me.navbar.TabIndex = 0
        '
        'border
        '
        Me.border.BackColor = System.Drawing.Color.Black
        Me.border.Location = New System.Drawing.Point(-1, 1)
        Me.border.Name = "border"
        Me.border.Size = New System.Drawing.Size(1074, 4)
        Me.border.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1072, 2)
        Me.Label1.TabIndex = 2
        '
        'menuButton
        '
        Me.menuButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.menuButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuButton.ForeColor = System.Drawing.Color.Firebrick
        Me.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.menuButton.Location = New System.Drawing.Point(12, 5)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(111, 37)
        Me.menuButton.TabIndex = 3
        Me.menuButton.Text = "Menu"
        Me.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'englishButton
        '
        Me.englishButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.englishButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.englishButton.ForeColor = System.Drawing.Color.Firebrick
        Me.englishButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.englishButton.Location = New System.Drawing.Point(701, 5)
        Me.englishButton.Name = "englishButton"
        Me.englishButton.Size = New System.Drawing.Size(68, 37)
        Me.englishButton.TabIndex = 8
        Me.englishButton.Text = "English"
        Me.englishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(993, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "普通话"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arabicButton
        '
        Me.arabicButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.arabicButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arabicButton.ForeColor = System.Drawing.Color.Firebrick
        Me.arabicButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.arabicButton.Location = New System.Drawing.Point(923, 5)
        Me.arabicButton.Name = "arabicButton"
        Me.arabicButton.Size = New System.Drawing.Size(68, 30)
        Me.arabicButton.TabIndex = 10
        Me.arabicButton.Text = "عربى"
        Me.arabicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frenchButton
        '
        Me.frenchButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.frenchButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frenchButton.ForeColor = System.Drawing.Color.Firebrick
        Me.frenchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.frenchButton.Location = New System.Drawing.Point(849, 5)
        Me.frenchButton.Name = "frenchButton"
        Me.frenchButton.Size = New System.Drawing.Size(68, 37)
        Me.frenchButton.TabIndex = 11
        Me.frenchButton.Text = "Français"
        Me.frenchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spanishButton
        '
        Me.spanishButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.spanishButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spanishButton.ForeColor = System.Drawing.Color.Firebrick
        Me.spanishButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spanishButton.Location = New System.Drawing.Point(775, 5)
        Me.spanishButton.Name = "spanishButton"
        Me.spanishButton.Size = New System.Drawing.Size(68, 37)
        Me.spanishButton.TabIndex = 12
        Me.spanishButton.Text = "Español"
        Me.spanishButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1073, 660)
        Me.Controls.Add(Me.spanishButton)
        Me.Controls.Add(Me.frenchButton)
        Me.Controls.Add(Me.arabicButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.englishButton)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.border)
        Me.Controls.Add(Me.navbar)
        Me.Name = "mainPage"
        Me.Text = "Ciro's Pizzeria & Beerhouse"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navbar As Label
    Friend WithEvents border As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents menuButton As Label
    Friend WithEvents englishButton As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents arabicButton As Label
    Friend WithEvents frenchButton As Label
    Friend WithEvents spanishButton As Label
End Class
