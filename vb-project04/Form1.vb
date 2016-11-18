Public Class Form1
    'Si la coma esta actualment en el textbox
    Dim comma As Boolean = False
    'Conte els valors de les divises
    Dim currencies As New Dictionary(Of String, Double)
    'Introducció dels valors númerics menys el 0
    Private Sub Button_Numeric_Click(sender As Object, e As EventArgs) Handles Button_1.Click, Button_2.Click, Button_3.Click, Button_4.Click, Button_5.Click, Button_6.Click, Button_7.Click, Button_8.Click, Button_9.Click
        deleteEuroAtEnd()
        If comma Then
            If TextBox_Input.Text.Split(",")(1).Length = 2 Then
                addEuroAtEnd()
                Return
            End If
        End If

        If TextBox_Input.Text.Equals("0") Then
            TextBox_Input.Text = ""
        End If
        TextBox_Input.Text += CType(sender, Button).Text
        addEuroAtEnd()
    End Sub
    'Introducció del valor 0 i comporvació de la coma i altres.
    Private Sub Button_0_Click(sender As Object, e As EventArgs) Handles Button_0.Click
        deleteEuroAtEnd()
        If comma Then
            If TextBox_Input.Text.Split(",")(1).Length = 2 Then
                addEuroAtEnd()
                Return
            End If
        End If

        If comma OrElse Not TextBox_Input.Text.Equals("0") Then
            TextBox_Input.Text += CType(sender, Button).Text
        End If
        addEuroAtEnd()
    End Sub
    'Introducció de la coma, es canvia el boolea d'adalt.
    Private Sub Button_Comma_Click(sender As Object, e As EventArgs) Handles Button_Comma.Click
        deleteEuroAtEnd()
        If Not comma Then
            TextBox_Input.Text += CType(sender, Button).Text
            comma = True
        End If
        addEuroAtEnd()
    End Sub
    'Elimina tots els valors per pantalla
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        deleteEuroAtEnd()
        If TextBox_Input.Text.Contains(",") Then
            comma = False
        End If
        TextBox_Input.Text = "0"
        addEuroAtEnd()
    End Sub
    'Elimina nomes l'ultim valor per pantalla.
    Private Sub Button_DeleteLast_Click(sender As Object, e As EventArgs) Handles Button_DeleteLast.Click
        deleteEuroAtEnd()
        If TextBox_Input.Text.Length > 1 Then
            If TextBox_Input.Text.Substring(TextBox_Input.Text.Length - 1, 1).Equals(",") Then
                comma = False
            End If
            TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 1)
        Else
            TextBox_Input.Text = "0"
        End If
        addEuroAtEnd()
    End Sub
    'Elimina l'euro final si es pot
    Private Sub deleteEuroAtEnd()
        If TextBox_Input.Text.Substring(TextBox_Input.Text.Length - 1, 1).Equals("€") Then
            TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 1)
        End If
    End Sub
    'Afegeix l'euro final si no hi ha ningun
    Private Sub addEuroAtEnd()
        If Not TextBox_Input.Text.Substring(TextBox_Input.Text.Length - 1, 1).Equals("€") Then
            TextBox_Input.Text += "€"
        End If
    End Sub
    'Botó per convertir les divises
    Private Sub Button_Convert_Click(sender As Object, e As EventArgs) Handles Button_Convert.Click
        If ComboBox.Text.Length = 0 Then
            MsgBox("Has d'introduir una moneda valida.", MsgBoxStyle.Critical)
            Return
        End If

        If Not ComboBox.Items.Contains(ComboBox.Text) Then
            ComboBox.Items.Add(ComboBox.Text)
        End If

        If Not currencies.ContainsKey(ComboBox.Text) Then
            Dim inputCurrency As String = InputBox("asdd")
            If IsNumeric(inputCurrency) Then
                currencies.Add(ComboBox.Text, Decimal.Parse(inputCurrency))
            Else
                MsgBox("Has d'introduir una valor númeric.", MsgBoxStyle.Critical)
                Return
            End If
        End If
        Dim result As Decimal = Decimal.Parse(TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 1)) * Decimal.Parse(currencies.Item(ComboBox.Text))
        TextBox_Converted.Text = CStr(result)
    End Sub
End Class