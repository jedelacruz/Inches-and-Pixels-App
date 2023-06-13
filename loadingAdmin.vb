Public Class loadingAdmin
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        welcomeAdmin.Show()
        Me.Hide()
    End Sub
End Class