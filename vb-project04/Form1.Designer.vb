<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox_Input = New System.Windows.Forms.TextBox()
        Me.TextBox_Converted = New System.Windows.Forms.TextBox()
        Me.Button_7 = New System.Windows.Forms.Button()
        Me.Button_8 = New System.Windows.Forms.Button()
        Me.Button_9 = New System.Windows.Forms.Button()
        Me.Button_6 = New System.Windows.Forms.Button()
        Me.Button_5 = New System.Windows.Forms.Button()
        Me.Button_4 = New System.Windows.Forms.Button()
        Me.Button_3 = New System.Windows.Forms.Button()
        Me.Button_2 = New System.Windows.Forms.Button()
        Me.Button_1 = New System.Windows.Forms.Button()
        Me.Button_0 = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Button_Comma = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_DeleteLast = New System.Windows.Forms.Button()
        Me.Button_Convert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Input
        '
        Me.TextBox_Input.Location = New System.Drawing.Point(13, 13)
        Me.TextBox_Input.Name = "TextBox_Input"
        Me.TextBox_Input.ReadOnly = True
        Me.TextBox_Input.Size = New System.Drawing.Size(108, 20)
        Me.TextBox_Input.TabIndex = 0
        Me.TextBox_Input.Text = "0€"
        '
        'TextBox_Converted
        '
        Me.TextBox_Converted.Location = New System.Drawing.Point(127, 13)
        Me.TextBox_Converted.Name = "TextBox_Converted"
        Me.TextBox_Converted.ReadOnly = True
        Me.TextBox_Converted.Size = New System.Drawing.Size(108, 20)
        Me.TextBox_Converted.TabIndex = 1
        '
        'Button_7
        '
        Me.Button_7.Location = New System.Drawing.Point(13, 77)
        Me.Button_7.Name = "Button_7"
        Me.Button_7.Size = New System.Drawing.Size(32, 32)
        Me.Button_7.TabIndex = 2
        Me.Button_7.Text = "7"
        Me.Button_7.UseVisualStyleBackColor = True
        '
        'Button_8
        '
        Me.Button_8.Location = New System.Drawing.Point(51, 77)
        Me.Button_8.Name = "Button_8"
        Me.Button_8.Size = New System.Drawing.Size(32, 32)
        Me.Button_8.TabIndex = 3
        Me.Button_8.Text = "8"
        Me.Button_8.UseVisualStyleBackColor = True
        '
        'Button_9
        '
        Me.Button_9.Location = New System.Drawing.Point(89, 77)
        Me.Button_9.Name = "Button_9"
        Me.Button_9.Size = New System.Drawing.Size(32, 32)
        Me.Button_9.TabIndex = 4
        Me.Button_9.Text = "9"
        Me.Button_9.UseVisualStyleBackColor = True
        '
        'Button_6
        '
        Me.Button_6.Location = New System.Drawing.Point(89, 115)
        Me.Button_6.Name = "Button_6"
        Me.Button_6.Size = New System.Drawing.Size(32, 32)
        Me.Button_6.TabIndex = 7
        Me.Button_6.Text = "6"
        Me.Button_6.UseVisualStyleBackColor = True
        '
        'Button_5
        '
        Me.Button_5.Location = New System.Drawing.Point(51, 115)
        Me.Button_5.Name = "Button_5"
        Me.Button_5.Size = New System.Drawing.Size(32, 32)
        Me.Button_5.TabIndex = 6
        Me.Button_5.Text = "5"
        Me.Button_5.UseVisualStyleBackColor = True
        '
        'Button_4
        '
        Me.Button_4.Location = New System.Drawing.Point(13, 115)
        Me.Button_4.Name = "Button_4"
        Me.Button_4.Size = New System.Drawing.Size(32, 32)
        Me.Button_4.TabIndex = 5
        Me.Button_4.Text = "4"
        Me.Button_4.UseVisualStyleBackColor = True
        '
        'Button_3
        '
        Me.Button_3.Location = New System.Drawing.Point(89, 153)
        Me.Button_3.Name = "Button_3"
        Me.Button_3.Size = New System.Drawing.Size(32, 32)
        Me.Button_3.TabIndex = 10
        Me.Button_3.Text = "3"
        Me.Button_3.UseVisualStyleBackColor = True
        '
        'Button_2
        '
        Me.Button_2.Location = New System.Drawing.Point(51, 153)
        Me.Button_2.Name = "Button_2"
        Me.Button_2.Size = New System.Drawing.Size(32, 32)
        Me.Button_2.TabIndex = 9
        Me.Button_2.Text = "2"
        Me.Button_2.UseVisualStyleBackColor = True
        '
        'Button_1
        '
        Me.Button_1.Location = New System.Drawing.Point(13, 153)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(32, 32)
        Me.Button_1.TabIndex = 8
        Me.Button_1.Text = "1"
        Me.Button_1.UseVisualStyleBackColor = True
        '
        'Button_0
        '
        Me.Button_0.Location = New System.Drawing.Point(51, 191)
        Me.Button_0.Name = "Button_0"
        Me.Button_0.Size = New System.Drawing.Size(32, 32)
        Me.Button_0.TabIndex = 11
        Me.Button_0.Text = "0"
        Me.Button_0.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {"Dollars", "Yens", "Lliures", "Esterlines", "Dracmes "})
        Me.ComboBox.Location = New System.Drawing.Point(127, 39)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox.TabIndex = 13
        '
        'Button_Comma
        '
        Me.Button_Comma.Location = New System.Drawing.Point(89, 191)
        Me.Button_Comma.Name = "Button_Comma"
        Me.Button_Comma.Size = New System.Drawing.Size(32, 32)
        Me.Button_Comma.TabIndex = 14
        Me.Button_Comma.Text = ","
        Me.Button_Comma.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(13, 39)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(32, 32)
        Me.Button_Delete.TabIndex = 15
        Me.Button_Delete.Text = "C"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_DeleteLast
        '
        Me.Button_DeleteLast.Location = New System.Drawing.Point(51, 39)
        Me.Button_DeleteLast.Name = "Button_DeleteLast"
        Me.Button_DeleteLast.Size = New System.Drawing.Size(70, 32)
        Me.Button_DeleteLast.TabIndex = 16
        Me.Button_DeleteLast.Text = "⌫"
        Me.Button_DeleteLast.UseVisualStyleBackColor = True
        '
        'Button_Convert
        '
        Me.Button_Convert.Location = New System.Drawing.Point(127, 77)
        Me.Button_Convert.Name = "Button_Convert"
        Me.Button_Convert.Size = New System.Drawing.Size(108, 32)
        Me.Button_Convert.TabIndex = 17
        Me.Button_Convert.Text = "Convertir"
        Me.Button_Convert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 230)
        Me.Controls.Add(Me.Button_Convert)
        Me.Controls.Add(Me.Button_DeleteLast)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Comma)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Button_0)
        Me.Controls.Add(Me.Button_3)
        Me.Controls.Add(Me.Button_2)
        Me.Controls.Add(Me.Button_1)
        Me.Controls.Add(Me.Button_6)
        Me.Controls.Add(Me.Button_5)
        Me.Controls.Add(Me.Button_4)
        Me.Controls.Add(Me.Button_9)
        Me.Controls.Add(Me.Button_8)
        Me.Controls.Add(Me.Button_7)
        Me.Controls.Add(Me.TextBox_Converted)
        Me.Controls.Add(Me.TextBox_Input)
        Me.Name = "Form1"
        Me.Text = "Pablo González"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Input As TextBox
    Friend WithEvents TextBox_Converted As TextBox
    Friend WithEvents Button_7 As Button
    Friend WithEvents Button_8 As Button
    Friend WithEvents Button_9 As Button
    Friend WithEvents Button_6 As Button
    Friend WithEvents Button_5 As Button
    Friend WithEvents Button_4 As Button
    Friend WithEvents Button_3 As Button
    Friend WithEvents Button_2 As Button
    Friend WithEvents Button_1 As Button
    Friend WithEvents Button_0 As Button
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Button_Comma As Button
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_DeleteLast As Button
    Friend WithEvents Button_Convert As Button
End Class
