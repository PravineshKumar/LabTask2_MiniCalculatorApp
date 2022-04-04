Public Class Form1
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim message As String

        message = " This Application is Designed by Pravinesh Kumaradeva, 10DDT20F1079, JTMK "

        MessageBox.Show(message, "Verification")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim frm As New Form1
        frm.Show()

        Me.Close()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        Form3.Show()
    End Sub
End Class
