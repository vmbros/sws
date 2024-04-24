Imports System.Data.SqlClient
Public Class cDBnew


    Public Property Servidor As String = "RCMTL-SBO"
    Public Property Db As String = "Recmetal"
    Public Property Usuario As String = "RecmetalSoftwareUser"
    Public Property Password As String = "RcmtlS0ft"
    Dim conn As SqlConnection


    Public Sub New()

    End Sub


    Public Function StrConn()
        'Return "server=" & servidor & ";uid=" & usuario & ";pwd=" & password & ";database=" & db
        Dim conexion As String
        conexion = "Data Source=" + Servidor + ";Initial Catalog=" + Db + ";User ID=" + Usuario + ";Password=" + Password
        Return conexion
    End Function


    Public Sub Conectar()
        conn = New SqlConnection(StrConn())
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function Comando(ByVal comandoStr As String) As SqlCommand
        Dim com As SqlCommand
        com = New SqlCommand(comandoStr, conn)
        Return com
    End Function

    Public Sub Desconectar()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Public Function Query(ByVal comando As String) As ArrayList
        Dim result As New ArrayList()
        Dim Command As SqlCommand
        Dim dr As SqlDataReader
        Command = New SqlCommand(comando, conn)
        Try
            dr = Command.ExecuteReader
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
        Dim fa, lastInsertId As Integer
        Dim Command As SqlCommand
        Command = New SqlCommand(comando, conn)
        Try
            fa = Command.ExecuteNonQuery
            'command.CommandText = "SELECT @@Identity"
            Command.CommandText = "SELECT SCOPE_IDENTITY()"
            If IsNumeric(Command.ExecuteScalar) Then
                lastInsertId = Command.ExecuteScalar
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.ToString)
        End Try

        Return fa
    End Function
    Public Function Scalar(ByVal comando As String) As Integer
        Dim fa As Integer
        Dim Command As SqlCommand
        Command = New SqlCommand(comando, conn)
        fa = Command.ExecuteScalar
        Return fa
    End Function
    Public Function queryGetField(ByVal comando As String) As String
        Dim result As New ArrayList()
        Dim Command As SqlCommand
        Dim dr As SqlDataReader
        Dim id As String = "0"
        Command = New SqlCommand(comando, conn)
        Try
            dr = Command.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr(0).ToString = "" Then
                    id = "0"
                Else
                    id = dr(0).ToString
                End If

            Else
                id = "0" 'No hay datos
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If dr Is Nothing Then
            'Do nothing
        Else
            If dr.IsClosed = False Then
                dr.Close()
            End If

        End If



        Return id
    End Function
    Public Function queryLastTicket(ByVal comando As String) As Integer
        Dim result As New ArrayList()
        Dim Command As SqlCommand
        Dim dr As SqlDataReader
        Dim id As Integer
        Command = New SqlCommand(comando, conn)
        Try
            dr = Command.ExecuteReader
            dr.Read()
            If IsNumeric(dr(0)) Then
                id = dr(0)
            Else
                id = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If dr Is Nothing Then
            'Do nothing
        Else
            If dr.IsClosed = False Then
                dr.Close()
            End If

        End If


        Return id
    End Function
End Class

