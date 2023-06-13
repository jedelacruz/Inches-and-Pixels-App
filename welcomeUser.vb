Public Class welcomeUser
    Private Sub welcomeUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form2 As New userPanel()
        form2.Show()
    End Sub


End Class