Imports System.Data
Imports System.Data.OleDb


Public Class BD
    Dim sda As OleDbCommand
    Dim scb As OleDbCommandBuilder
    Dim dr As OleDbDataReader
    Dim con As OleDbConnection
    Dim dt As DataTable
    Dim comando As String = "SELECT ItemCode, ItemName FROM OITM"

    Function abrirConexion() As OleDbConnection

        Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"
        Dim con As New OleDbConnection(constr)
        con.Open()

        Return con
    End Function


End Class
