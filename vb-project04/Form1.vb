Public Class Form1
    Dim comma As Boolean = False
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
    Private Sub Button_Comma_Click(sender As Object, e As EventArgs) Handles Button_Comma.Click
        deleteEuroAtEnd()
        If Not comma Then
            TextBox_Input.Text += CType(sender, Button).Text
            comma = True
            addEuroAtEnd()
        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        deleteEuroAtEnd()
        If TextBox_Input.Text.Contains(",") Then
            comma = False
        End If
        TextBox_Input.Text = "0"
        addEuroAtEnd()
    End Sub

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

    Private Sub Button_Convert_Click(sender As Object, e As EventArgs) Handles Button_Convert.Click

    End Sub

    Private Sub deleteEuroAtEnd()
        If TextBox_Input.Text.Substring(TextBox_Input.Text.Length - 1, 1).Equals("€") Then
            TextBox_Input.Text = TextBox_Input.Text.Substring(0, TextBox_Input.Text.Length - 1)
        End If
    End Sub
    Private Sub addEuroAtEnd()
        If Not TextBox_Input.Text.Substring(TextBox_Input.Text.Length - 1, 1).Equals("€") Then
            TextBox_Input.Text += "€"
        End If
    End Sub
End Class