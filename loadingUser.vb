Public Class loadingUser
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        welcomeUser.Show()
        Me.Hide()
    End Sub

End Class