Public Class Form2
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtUN As String = TextBox1.Text
        Dim txtPW As String = TextBox2.Text

        Dim userUN As String = "userUN"
        Dim userPW As String = "userPW"

        Dim adminUN As String = "adminUN"
        Dim adminPW As String = "adminPW"

        If txtUN.Equals(userUN) And txtPW.Equals(userPW) Then
            loadingUser.Show()
            Me.Hide()
        ElseIf txtUN.Equals(adminUN) And txtPW.Equals(adminPW) Then
            loadingAdmin.Show()
            Me.Hide()
        Else
            invalidAccount.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form2 As New comeAgain()
        form2.Show()
    End Sub
End Class
