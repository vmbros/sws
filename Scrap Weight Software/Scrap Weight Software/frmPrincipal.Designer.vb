<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mInformesCompra = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketDetalladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mInformesVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mParametros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mArticulos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mChoferes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEnvases = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTransportistas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mIndicadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PesajeToolStripMenuItem, Me.InformesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(2550, 44)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mUsuario, Me.ToolStripSeparator3, Me.mSalir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(107, 36)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'mUsuario
        '
        Me.mUsuario.Name = "mUsuario"
        Me.mUsuario.Size = New System.Drawing.Size(336, 36)
        Me.mUsuario.Text = "Administración Usuario"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(333, 6)
        '
        'mSalir
        '
        Me.mSalir.Name = "mSalir"
        Me.mSalir.Size = New System.Drawing.Size(336, 36)
        Me.mSalir.Text = "Salir"
        '
        'PesajeToolStripMenuItem
        '
        Me.PesajeToolStripMenuItem.Name = "PesajeToolStripMenuItem"
        Me.PesajeToolStripMenuItem.Size = New System.Drawing.Size(93, 36)
        Me.PesajeToolStripMenuItem.Text = "Pesaje"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mInformesCompra, Me.mInformesVenta})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(121, 36)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'mInformesCompra
        '
        Me.mInformesCompra.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketDetalladoToolStripMenuItem, Me.ComprasPorProveedorToolStripMenuItem, Me.ComprasPorProductoToolStripMenuItem, Me.ComprasPorFechaToolStripMenuItem})
        Me.mInformesCompra.Name = "mInformesCompra"
        Me.mInformesCompra.Size = New System.Drawing.Size(184, 36)
        Me.mInformesCompra.Text = "Compras"
        '
        'TicketDetalladoToolStripMenuItem
        '
        Me.TicketDetalladoToolStripMenuItem.Name = "TicketDetalladoToolStripMenuItem"
        Me.TicketDetalladoToolStripMenuItem.Size = New System.Drawing.Size(344, 36)
        Me.TicketDetalladoToolStripMenuItem.Text = "Ticket Detallado"
        '
        'ComprasPorProveedorToolStripMenuItem
        '
        Me.ComprasPorProveedorToolStripMenuItem.Name = "ComprasPorProveedorToolStripMenuItem"
        Me.ComprasPorProveedorToolStripMenuItem.Size = New System.Drawing.Size(344, 36)
        Me.ComprasPorProveedorToolStripMenuItem.Text = "Compras por proveedor"
        '
        'ComprasPorProductoToolStripMenuItem
        '
        Me.ComprasPorProductoToolStripMenuItem.Name = "ComprasPorProductoToolStripMenuItem"
        Me.ComprasPorProductoToolStripMenuItem.Size = New System.Drawing.Size(344, 36)
        Me.ComprasPorProductoToolStripMenuItem.Text = "Compras por producto"
        '
        'ComprasPorFechaToolStripMenuItem
        '
        Me.ComprasPorFechaToolStripMenuItem.Name = "ComprasPorFechaToolStripMenuItem"
        Me.ComprasPorFechaToolStripMenuItem.Size = New System.Drawing.Size(389, 36)
        Me.ComprasPorFechaToolStripMenuItem.Text = "Compras por prod Resumen"
        '
        'mInformesVenta
        '
        Me.mInformesVenta.Name = "mInformesVenta"
        Me.mInformesVenta.Size = New System.Drawing.Size(184, 36)
        Me.mInformesVenta.Text = "Ventas"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mParametros, Me.ToolStripSeparator1, Me.mArticulos, Me.mChoferes, Me.mEnvases, Me.mSN, Me.mTransportistas, Me.ToolStripSeparator2, Me.mIndicadores})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(169, 36)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'mParametros
        '
        Me.mParametros.Name = "mParametros"
        Me.mParametros.Size = New System.Drawing.Size(295, 36)
        Me.mParametros.Text = "Parámetros"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(292, 6)
        '
        'mArticulos
        '
        Me.mArticulos.Name = "mArticulos"
        Me.mArticulos.Size = New System.Drawing.Size(295, 36)
        Me.mArticulos.Text = "Artículos"
        '
        'mChoferes
        '
        Me.mChoferes.Name = "mChoferes"
        Me.mChoferes.Size = New System.Drawing.Size(295, 36)
        Me.mChoferes.Text = "Choferes"
        '
        'mEnvases
        '
        Me.mEnvases.Name = "mEnvases"
        Me.mEnvases.Size = New System.Drawing.Size(295, 36)
        Me.mEnvases.Text = "Envases"
        '
        'mSN
        '
        Me.mSN.Name = "mSN"
        Me.mSN.Size = New System.Drawing.Size(295, 36)
        Me.mSN.Text = "Socios de negocios"
        '
        'mTransportistas
        '
        Me.mTransportistas.Name = "mTransportistas"
        Me.mTransportistas.Size = New System.Drawing.Size(295, 36)
        Me.mTransportistas.Text = "Transportistas"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(292, 6)
        '
        'mIndicadores
        '
        Me.mIndicadores.Name = "mIndicadores"
        Me.mIndicadores.Size = New System.Drawing.Size(295, 36)
        Me.mIndicadores.Text = "Indicadores"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(94, 36)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(194, 36)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1103)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(2550, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2550, 1125)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scrap Weigth Software"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mInformesCompra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mInformesVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mParametros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mArticulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mChoferes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mEnvases As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mSN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mTransportistas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mIndicadores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TicketDetalladoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasPorProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasPorProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
