Public Class Form1
    Public sayi, i, fakt As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sayi = TextBox1.Text
        fakt = 1
        For i = 1 To sayi
            fakt = fakt * i

        Next
        Form2.ShowDialog()


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'e.Handled = Char.IsLetter(e.KeyChar)

    End Sub
    Public a, carpim As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.TextLength

        Form2.ShowDialog()

    End Sub
End Class
