Public Class frmPrincipal
    Private acceso As Integer
    Private rutUser As String
    Public ReadOnly Property user As String
        Get
            Return rutUser
        End Get
    End Property



    Public Sub New()    'Constructor por omisión
        InitializeComponent()
    End Sub

    Public Sub New(ByVal nivel As Integer, ByVal rut As String)
        InitializeComponent()
        acceso = nivel
        rutUser = rut

    End Sub

    Private Sub mSalir_Click(sender As Object, e As EventArgs) Handles mSalir.Click
        Application.Exit()
    End Sub


    Private Sub PesajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesajeToolStripMenuItem.Click
        Dim frmPesaje As New frmPesaje
        frmPesaje.MdiParent = Me
        'MessageBox.Show(acceso)
        frmPesaje.user = Me.user
        frmPesaje.Show()
        frmPesaje.txtPPU.Focus()

    End Sub

    Private Sub mArticulos_Click(sender As Object, e As EventArgs) Handles mArticulos.Click
        Dim frmMantenedor As New FrmArticulos
        frmMantenedor.MdiParent = Me
        frmMantenedor.Show()
    End Sub

    Private Sub mChoferes_Click(sender As Object, e As EventArgs) Handles mChoferes.Click
        Dim frmMantenedor As New frmChoferes
        frmMantenedor.MdiParent = Me
        frmMantenedor.Show()
    End Sub

    Private Sub mEnvases_Click(sender As Object, e As EventArgs) Handles mEnvases.Click
        Dim frmMantenedor As New frmEnvases
        frmMantenedor.MdiParent = Me
        frmMantenedor.Show()
    End Sub

    Private Sub mSN_Click(sender As Object, e As EventArgs) Handles mSN.Click
        Dim frmMantenedor As New frmOCRD("")
        frmMantenedor.MdiParent = Me
        frmMantenedor.Show()
    End Sub

    Private Sub mTransportistas_Click(sender As Object, e As EventArgs) Handles mTransportistas.Click
        Dim frmMantenedor As New frmTransportistas
        frmMantenedor.MdiParent = Me
        frmMantenedor.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not acceso = 1) Then
            mUsuario.Enabled = False
            mParametros.Enabled = False
        End If


    End Sub

    Private Sub mUsuario_Click(sender As Object, e As EventArgs) Handles mUsuario.Click
        Dim frmUs As New frmUsuarios()
        frmUs.MdiParent = Me
        frmUs.Show()
    End Sub

    Private Sub mParametros_Click(sender As Object, e As EventArgs) Handles mParametros.Click
        Dim frmParam As New frmParametros()
        frmParam.MdiParent = Me
        frmParam.Show()
    End Sub

    Private Sub mIndicadores_Click(sender As Object, e As EventArgs) Handles mIndicadores.Click
        Dim frmIndic As New frmIndicadores
        frmIndic.MdiParent = Me
        frmIndic.Show()
    End Sub

    Private Sub TicketDetalladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketDetalladoToolStripMenuItem.Click
        Dim respuesta, foliopref As String
        Dim n As New Negocio()
        Dim ListaParametro As New ArrayList()
        ListaParametro = n.recorrerArchivo()
        foliopref = ListaParametro(2).ToString().ToUpper



        respuesta = InputBox("Ingrese número de ticket a buscar: ", "Buscar ticket", "")
        If IsNumeric(respuesta) Then
            Dim frmVisor As New frmTicketViewer(CInt(respuesta), foliopref, "ticketDetalle")
            frmVisor.fReporte = "ticketDetalle"
            frmVisor.WindowState = FormWindowState.Maximized
            frmVisor.MdiParent = Me
            frmVisor.Show()
        End If


    End Sub

    Private Sub ComprasPorProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProductoToolStripMenuItem.Click
        Dim frmvisor As New frmVisor
        frmvisor.op = "producto"
        frmvisor.MdiParent = Me
        frmvisor.Show()
    End Sub

    Private Sub ComprasPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProveedorToolStripMenuItem.Click
        Dim frmvisor As New frmVisor
        frmvisor.op = "proveedor"
        frmvisor.MdiParent = Me
        frmvisor.Show()
    End Sub

    Private Sub ComprasPorFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorFechaToolStripMenuItem.Click
        Dim frmvisor As New frmVisor
        frmvisor.op = "productoResumen"
        frmvisor.MdiParent = Me
        frmvisor.Show()
    End Sub
End Class