Public Class Form3

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Hide()

        Form4.Show()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Visible = False
    End Sub

    Private Sub btnCC_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Name As String
        Dim Age As Integer

        Name = txt1.Text
        Age = txt2.Text

        txt3.Text = "My Name is: " & Name & ", and Your Age is: " & Age
    End Sub
End Class