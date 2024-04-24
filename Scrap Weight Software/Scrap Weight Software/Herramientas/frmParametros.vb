Imports System
Imports System.IO.Ports
Imports System.Data.OleDb

Public Class frmParametros
    Private rutaArchivo As String = "C:\Bascula\swsparam.txt"
    Private rutaFotos As String = "C:\Bascula\imagenes"
    Dim arrText As New ArrayList()
    Dim arrParam() As String

    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ports As String() = SerialPort.GetPortNames

        Dim port As String
        For Each port In ports
            cmbPuerto.Items.Add(port)
        Next port

        'Buscar indicadores
        Dim dr As OleDbDataReader
        Dim conn As OleDbConnection
        Dim command As OleDbCommand
        Dim comando As String = "SELECT id FROM tIndicadores"
        Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"

        conn = New OleDbConnection(constr)
        Command = New OleDbCommand(comando, conn)
        conn.Open()
        dr = Command.ExecuteReader

        If dr.HasRows Then
            While dr.Read()
                cmbIndicador.Items.Add(dr(0))
            End While
        End If
        dr.Close()
        conn.Close()







        'Si se leen el archivo se deja los parametros por defecto en el formulario
        If My.Computer.FileSystem.FileExists(rutaArchivo) Then

            Dim obj As New Negocio()
            'Se lee y extrae el archivo
            arrText = obj.recorrerArchivo()

            cmbTicket.SelectedItem = arrText(0)
            cmbPuerto.SelectedItem = arrText(1)
            txtPrefijo.Text = arrText(2)
            cmbIndicador.Text = arrText(3)
            cmbBits.SelectedItem = arrText(4)


        End If


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim existencia As Boolean

        Try
            'Saber si existe el directorio
            existencia = System.IO.Directory.Exists(rutaFotos)

            'Si no existe se crea
            If Not existencia Then
                My.Computer.FileSystem.CreateDirectory(rutaFotos)
            End If

            'ver si el archivo existe
            If Not My.Computer.FileSystem.FileExists(rutaArchivo) Then

                Dim file1 As System.IO.FileStream
                file1 = System.IO.File.Create(rutaArchivo)
                file1.Close()


            End If

            Dim sw As New System.IO.StreamWriter(rutaArchivo)
            sw.WriteLine("paramTicket=" + cmbTicket.SelectedItem)
            sw.WriteLine("paramPuerto=" + cmbPuerto.SelectedItem)
            sw.WriteLine("paramPrefijo=" + txtPrefijo.Text)
            sw.WriteLine("paramIndicador=" + cmbIndicador.SelectedItem.ToString)
            sw.WriteLine("paramBits=" + cmbBits.SelectedItem)
            sw.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR DE CONFIGURACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class