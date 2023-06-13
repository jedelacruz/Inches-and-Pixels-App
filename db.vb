Imports System.Data.OleDb
Module db

    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public sql As String
    Public dr As OleDbDataReader

    Public Sub con()
        Dim providerVersion As String = "ACE.OLEDB.12.0"

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.ConnectionString = String.Format("Provider=Microsoft.{0}; Data Source={1}\database.mdb", providerVersion, Application.StartupPath)
        cn.Open()
    End Sub



End Module
