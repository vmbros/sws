Imports System.Data
Imports System.Data.OleDb
Imports Scrap_Weight_Software

Public Class Negocio
    Dim com As OleDbCommand
    Dim dr As OleDbDataReader
    Dim comando As String
    Dim dt As DataTable
    Dim cn As New BD
    Private rutaArchivo As String = "C:\Bascula\swsparam.txt"
    Public Function validarUsuario(ByVal r As String, ByVal p As String)

        Try
            comando = "SELECT * FROM tUsuario WHERE rut='" + r + "' and clave ='" + p + "'and activo = true"
            com = New OleDbCommand(comando, cn.abrirConexion())
            dr = com.ExecuteReader()


            If dr.Read() Then
                Dim bool As Boolean

                bool = dr.GetBoolean(6)
                If (bool = True) Then

                    If dr.GetBoolean(5) = True Then
                        'administrador'
                        Return 1
                    Else
                        Return 2
                    End If
                Else
                    Return 3
                End If
            Else
                Return 4
            End If
            Return 3
        Catch ex As Exception
            MessageBox.Show("Favor, contacte al administrador por el siguiente error: " + ex.Message)

        End Try
        Return False
    End Function


    Public Function recorrerArchivo()
        Dim arrParam() As String
        Dim arrText As New ArrayList()

        Dim sr As New System.IO.StreamReader(rutaArchivo)
        Dim sLine As String
        Do
            sLine = sr.ReadLine()
            If Not sLine Is Nothing Then
                arrParam = Split(sLine, "=")
                arrText.Add(arrParam(1))
                ''MessageBox.Show(sLine)
            End If
        Loop Until sLine Is Nothing
        sr.Close()
        Return arrText
    End Function
End Class
