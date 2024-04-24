Imports System.Data
Imports System.Data.OleDb


Public Class frmUsuarios
    Dim sda As OleDbDataAdapter
    Dim scb As OleDbCommandBuilder
    Dim dt As DataTable
    Dim comando As String = "SELECT * From tUsuario"
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection(constr)
        sda = New OleDbDataAdapter(comando, con)
        dt = New DataTable
        sda.Fill(dt)
        With dgvMaestro
            .DataSource = dt





            '.Columns(1).Width = 400
            'Dim col As DataGridViewTextBoxColumn = DirectCast(.Columns(0), DataGridViewTextBoxColumn)
            ''Max. num. of chars columna RUT
            'col.MaxInputLength = 10
            '' Max. num. of chars columna Nombre
            'col = DirectCast(.Columns(1), DataGridViewTextBoxColumn)
            '' Establecemos el nmero mximo de caracteres
            'col.MaxInputLength = 255
            .Columns("rut").ReadOnly = True


            ''.Columns("clave").Visible = False
        End With

        'txtNombre.Focus()
    End Sub

    Private Sub dgvMaestro_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMaestro.CellFormatting

        If e.ColumnIndex = 1 Then

            Dim cell As DataGridViewCell


            cell = dgvMaestro.Rows(e.RowIndex).Cells(e.ColumnIndex)

            If cell.IsInEditMode = False Then

                e.Value = "*******"

                e.FormattingApplied = True

            Else
                e.Value = ""

                e.FormattingApplied = True
            End If


        End If

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        scb = New OleDbCommandBuilder(sda)
        sda.Update(dt)
        frmUsuarios_Load(sender, e)
    End Sub
    Public Sub mostrar(ByVal fpadre As Form)
        Me.Owner = fpadre
    End Sub

    'Private Sub dgvMaestro_DoubleClick(sender As Object, e As EventArgs) Handles dgvMaestro.CellContentDoubleClick
    '    Dim _formInterface As iMantenedores = CType(Me.Owner, iMantenedores)
    '    With dgvMaestro.CurrentRow
    '        _formInterface.iText(.Cells("rut").Value, .Cells("nombre").Value, "Usuarios")
    '        Me.Dispose()
    '        Me.Close()
    '    End With
    'End Sub
End Class