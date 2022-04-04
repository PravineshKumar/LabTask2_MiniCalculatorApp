Public Class Form4
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(1)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Number1 As Double
        Dim Number2 As Double
        Dim Add As Double

        Number1 = txtnum1.Text
        Number2 = txtnum2.Text

        Add = Number1 + Number2
        txtsum.Text = "The Total Sum is : " & Add
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Number1 As Double
        Dim Number2 As Double
        Dim Subs As Double

        Number1 = txtnum1.Text
        Number2 = txtnum2.Text

        Subs = Number1 - Number2
        txtsum.Text = "The Total Substraction is : " & Subs
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim Number1 As Double
        Dim Number2 As Double
        Dim Mul As Double

        Number1 = txtnum1.Text
        Number2 = txtnum2.Text


        Mul = Number1 * Number2
        txtsum.Text = "The Total Mulitiplication is : " & Mul
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim Number1 As Double
        Dim Number2 As Double
        Dim Div As Double

        Number1 = txtnum1.Text
        Number2 = txtnum2.Text

        Div = Number1 / Number2
        txtsum.Text = "The Total Division is : " & Div
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        Form3.Hide()
    End Sub
End Class