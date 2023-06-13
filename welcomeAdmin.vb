Public Class welcomeAdmin

    Private Sub welcomeAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form2 As New adminPanel()
        form2.Show()
    End Sub

End Class