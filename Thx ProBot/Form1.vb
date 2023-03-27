Public Class tax
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time As String = TextBox1.Text
        time = time.Replace("k", "0000").Replace("m", "00000")
        Dim tax As Integer = Math.Floor(Double.Parse(time) * (20) / (19) + (1))
        MessageBox.Show(tax)
    End Sub
End Class
