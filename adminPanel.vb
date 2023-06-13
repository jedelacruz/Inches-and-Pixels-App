Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class adminPanel
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dt As DataTable
        Dim da As OleDbDataAdapter

        sql = String.Format("SELECT * FROM Table1")
        da = New OleDbDataAdapter(sql, cn)
        dt = New DataTable
        da.Fill(dt)
        UserView.DataSource = dt.Copy
        dt.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con()
        sql = String.Format("DELETE FROM Table1 WHERE [ID] = {0}", TextBox1.Text)
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub adminPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form2 As New Form2()
        form2.Show()
    End Sub

End Class