Imports System.Data
Imports System.Data.OleDb
Public Class cDB
    Private dr As OleDbDataReader
    Private command As OleDbCommand
    Private conn As OleDbConnection
    Public Property lastInsertId As Integer

    Private constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"

    Public Sub conectar()
        conn = New OleDbConnection(constr)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Public Function query(ByVal comando As String) As ArrayList
        Dim result As New ArrayList()
        command = New OleDbCommand(comando, conn)
        Try
            dr = command.ExecuteReader
            While dr.Read()
                ' Insert each column into a dictionary
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (dr.FieldCount - 1)
                    dict.Add(dr.GetName(count), dr(count))
                Next

                ' Add the dictionary to the ArrayList
                result.Add(dict)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If dr Is Nothing Then
        Else
            If dr.IsClosed = False Then
                dr.Close()
            End If

        End If



        Return result
    End Function
    Public Function nonQuery(ByVal comando As String) As Integer
        Dim fa As Integer
        command = New OleDbCommand(comando, conn)
        Try
            fa = command.ExecuteNonQuery
            command.CommandText = "SELECT @@Identity"
            lastInsertId = command.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.ToString)
        End Try
        
        Return fa
    End Function
    Public Function scalar(ByVal comando As String) As Integer
        Dim fa As Integer
        command = New OleDbCommand(comando, conn)
        fa = command.ExecuteScalar
        Return fa
    End Function

End Class
