Public Class Form2
    Dim c As Int32
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(Form1.fakt)

        For c = 1 To 10
            Form1.carpim = c * Form1.a
            ListBox2.Items.Add(Form1.carpim)
        Next


    End Sub
End Class