Imports System.Data.OleDb

Public Class userPanel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con()

        sql = String.Format("INSERT INTO Table1([ID],[Name],[Type],[Size],[Description],[Text]) VALUES({0}, '{1}' ,'{2}','{3}','{4}' ,'{5}' )", TextBox1.Text, TextBox2.Text, ComboBox1.Text, TextBox3.Text, RichTextBox1.Text, RichTextBox2.Text)
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()


        thankYouPage.Show()
        Me.Hide()
    End Sub
End Class
