Imports System.Data
Imports System.Data.OleDb


Public Class FrmArticulos
    Dim sda As OleDbDataAdapter
    Dim scb As OleDbCommandBuilder
    Dim dt As DataTable
    Dim comando As String = "SELECT ItemCode as cod, ItemName as Nombre FROM OITM"
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"
    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim con As New SqlConnection("Data Source=C:\Bascula\Bascula.accdb;Initial Catalog=Bascula; integrated security=true")
        Dim con As New OleDbConnection(constr)
        sda = New OleDbDataAdapter(comando, con)
        dt = New DataTable
        sda.Fill(dt)
        With dgvMaestro
            .DataSource = dt
            .Columns(1).Width = 400
            Dim col As DataGridViewTextBoxColumn = DirectCast(.Columns(0), DataGridViewTextBoxColumn)
            'Max. num. of chars columna RUT
            col.MaxInputLength = 10
            ' Max. num. of chars columna Nombre
            col = DirectCast(.Columns(1), DataGridViewTextBoxColumn)
            ' Establecemos el nmero mximo de caracteres
            col.MaxInputLength = 255
            .Columns(0).ReadOnly = True
        End With
        
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        scb = New OleDbCommandBuilder(sda)
        sda.Update(dt)
        frmArticulos_Load(sender, e)
    End Sub
    Public Sub mostrar(ByVal fpadre As Form)
        Me.Owner = fpadre
    End Sub

    Private Sub dgvMaestro_DoubleClick(sender As Object, e As EventArgs) Handles dgvMaestro.CellContentDoubleClick
        If Not (Me.Owner Is Nothing) Then
            Try
                Dim _formInterface As iMantenedores = CType(Me.Owner, iMantenedores)
                With dgvMaestro.CurrentRow
                    _formInterface.iText(.Cells("cod").Value, .Cells("Nombre").Value, "Articulos")
                    Me.Dispose()
                    Me.Close()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR DE CONFIGURACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        'If txtNombre.TextLength > 0 Then
        Dim con As New OleDbConnection(constr)
        Dim texto As String
        If txtNombre.Text = "" Then
            texto = comando
        Else
            texto = comando & " WHERE ItemName LIKE '%" & txtNombre.Text & "%'"
        End If
        sda = New OleDbDataAdapter(texto, con)
        'sda = New OleDbDataAdapter(comando & " WHERE ChoferNom LIKE '%" & txtNombre.Text & "%'", con)
        dt = New DataTable
        sda.Fill(dt)
        With dgvMaestro
            .DataSource = dt
            .Columns(1).Width = 400
        End With
        ' End If
    End Sub
End Class