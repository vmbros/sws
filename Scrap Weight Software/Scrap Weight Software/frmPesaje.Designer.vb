<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesaje
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTicketNum = New System.Windows.Forms.TextBox()
        Me.txtPPU = New System.Windows.Forms.TextBox()
        Me.txtSNRUT = New System.Windows.Forms.TextBox()
        Me.txtChoferRUT = New System.Windows.Forms.TextBox()
        Me.txtTranspRUT = New System.Windows.Forms.TextBox()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCompra = New System.Windows.Forms.RadioButton()
        Me.rbVenta = New System.Windows.Forms.RadioButton()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSNNombre = New System.Windows.Forms.TextBox()
        Me.btnChofer = New System.Windows.Forms.Button()
        Me.txtChoferNombre = New System.Windows.Forms.TextBox()
        Me.btnTransportista = New System.Windows.Forms.Button()
        Me.txtTranspNombre = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvPesajes = New System.Windows.Forms.DataGridView()
        Me.dataNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTarePeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTareNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTareCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataFreeTxt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataFotoSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataPesoBrutoSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataEnvSalCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataEnvSalNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataEnvSalPeso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTimeStampSal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataImpurezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCaptura = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtIngreso = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblsalida = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.txtBooking = New System.Windows.Forms.TextBox()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpBoxSalida = New System.Windows.Forms.GroupBox()
        Me.txtEnvSalidaPeso = New System.Windows.Forms.TextBox()
        Me.txtPesoSalida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnvSalida = New System.Windows.Forms.Button()
        Me.txtEnvSalidaNom = New System.Windows.Forms.TextBox()
        Me.txtEnvSalidaCod = New System.Windows.Forms.TextBox()
        Me.txtFreeTxt = New System.Windows.Forms.TextBox()
        Me.txtImpurezas = New System.Windows.Forms.TextBox()
        Me.grpBoxEntrada = New System.Windows.Forms.GroupBox()
        Me.txtLineId = New System.Windows.Forms.TextBox()
        Me.txtItemCod = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtTaraCod = New System.Windows.Forms.TextBox()
        Me.txtTaraDescripcion = New System.Windows.Forms.TextBox()
        Me.btnArticulo = New System.Windows.Forms.Button()
        Me.btnEnvase = New System.Windows.Forms.Button()
        Me.txtTaraPeso = New System.Windows.Forms.TextBox()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgvPesajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpBoxSalida.SuspendLayout()
        Me.grpBoxEntrada.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTicketNum
        '
        Me.txtTicketNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNum.Location = New System.Drawing.Point(154, 8)
        Me.txtTicketNum.Name = "txtTicketNum"
        Me.txtTicketNum.ReadOnly = True
        Me.txtTicketNum.Size = New System.Drawing.Size(50, 22)
        Me.txtTicketNum.TabIndex = 0
        Me.txtTicketNum.TabStop = False
        '
        'txtPPU
        '
        Me.txtPPU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPU.Location = New System.Drawing.Point(100, 36)
        Me.txtPPU.MaxLength = 13
        Me.txtPPU.Name = "txtPPU"
        Me.txtPPU.Size = New System.Drawing.Size(104, 22)
        Me.txtPPU.TabIndex = 1
        '
        'txtSNRUT
        '
        Me.txtSNRUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNRUT.Location = New System.Drawing.Point(100, 64)
        Me.txtSNRUT.Name = "txtSNRUT"
        Me.txtSNRUT.Size = New System.Drawing.Size(104, 22)
        Me.txtSNRUT.TabIndex = 2
        '
        'txtChoferRUT
        '
        Me.txtChoferRUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoferRUT.Location = New System.Drawing.Point(537, 8)
        Me.txtChoferRUT.MaxLength = 10
        Me.txtChoferRUT.Name = "txtChoferRUT"
        Me.txtChoferRUT.Size = New System.Drawing.Size(73, 22)
        Me.txtChoferRUT.TabIndex = 4
        '
        'txtTranspRUT
        '
        Me.txtTranspRUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranspRUT.Location = New System.Drawing.Point(537, 36)
        Me.txtTranspRUT.MaxLength = 10
        Me.txtTranspRUT.Name = "txtTranspRUT"
        Me.txtTranspRUT.Size = New System.Drawing.Size(73, 22)
        Me.txtTranspRUT.TabIndex = 6
        '
        'txtGuia
        '
        Me.txtGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuia.Location = New System.Drawing.Point(723, 65)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(170, 22)
        Me.txtGuia.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "N° Ticket"
        '
        'rbCompra
        '
        Me.rbCompra.AutoSize = True
        Me.rbCompra.Checked = True
        Me.rbCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCompra.Location = New System.Drawing.Point(11, 2)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(73, 20)
        Me.rbCompra.TabIndex = 7
        Me.rbCompra.TabStop = True
        Me.rbCompra.Text = "Entrada"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'rbVenta
        '
        Me.rbVenta.AutoSize = True
        Me.rbVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVenta.Location = New System.Drawing.Point(100, 2)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(65, 20)
        Me.rbVenta.TabIndex = 8
        Me.rbVenta.Text = "Salida"
        Me.rbVenta.UseVisualStyleBackColor = True
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSN.Location = New System.Drawing.Point(12, 67)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(72, 16)
        Me.lblSN.TabIndex = 9
        Me.lblSN.Text = "Proveedor"
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatente.Location = New System.Drawing.Point(12, 38)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(54, 16)
        Me.lblPatente.TabIndex = 10
        Me.lblPatente.Text = "Patente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Chofer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Transportista"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(664, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "N° Guía"
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(100, 93)
        Me.txtObservacion.MaxLength = 255
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(793, 22)
        Me.txtObservacion.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Observación"
        '
        'txtSNNombre
        '
        Me.txtSNNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNNombre.Location = New System.Drawing.Point(243, 64)
        Me.txtSNNombre.Name = "txtSNNombre"
        Me.txtSNNombre.ReadOnly = True
        Me.txtSNNombre.Size = New System.Drawing.Size(396, 22)
        Me.txtSNNombre.TabIndex = 18
        Me.txtSNNombre.TabStop = False
        '
        'btnChofer
        '
        Me.btnChofer.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChofer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChofer.Location = New System.Drawing.Point(616, 9)
        Me.btnChofer.Name = "btnChofer"
        Me.btnChofer.Size = New System.Drawing.Size(22, 22)
        Me.btnChofer.TabIndex = 5
        Me.btnChofer.TabStop = False
        Me.btnChofer.UseVisualStyleBackColor = True
        '
        'txtChoferNombre
        '
        Me.txtChoferNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChoferNombre.Location = New System.Drawing.Point(643, 8)
        Me.txtChoferNombre.Name = "txtChoferNombre"
        Me.txtChoferNombre.ReadOnly = True
        Me.txtChoferNombre.Size = New System.Drawing.Size(250, 22)
        Me.txtChoferNombre.TabIndex = 20
        Me.txtChoferNombre.TabStop = False
        '
        'btnTransportista
        '
        Me.btnTransportista.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnTransportista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransportista.Location = New System.Drawing.Point(616, 36)
        Me.btnTransportista.Name = "btnTransportista"
        Me.btnTransportista.Size = New System.Drawing.Size(22, 22)
        Me.btnTransportista.TabIndex = 7
        Me.btnTransportista.TabStop = False
        Me.btnTransportista.UseVisualStyleBackColor = True
        '
        'txtTranspNombre
        '
        Me.txtTranspNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranspNombre.Location = New System.Drawing.Point(643, 34)
        Me.txtTranspNombre.Name = "txtTranspNombre"
        Me.txtTranspNombre.ReadOnly = True
        Me.txtTranspNombre.Size = New System.Drawing.Size(250, 22)
        Me.txtTranspNombre.TabIndex = 22
        Me.txtTranspNombre.TabStop = False
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(86, 75)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPeso.Size = New System.Drawing.Size(60, 22)
        Me.txtPeso.TabIndex = 29
        Me.txtPeso.TabStop = False
        Me.txtPeso.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Artículo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Envase"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Impurezas"
        '
        'dgvPesajes
        '
        Me.dgvPesajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPesajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataNum, Me.dataItemCode, Me.dataItemName, Me.dataQuantity, Me.dataTarePeso, Me.dataTareNom, Me.dataTareCod, Me.dataFreeTxt, Me.dataTimeStamp, Me.dataFoto, Me.dataFotoSal, Me.dataPesoBrutoSalida, Me.dataEnvSalCod, Me.dataEnvSalNom, Me.dataEnvSalPeso, Me.dataTimeStampSal, Me.dataImpurezas, Me.dataTotal})
        Me.dgvPesajes.Location = New System.Drawing.Point(15, 290)
        Me.dgvPesajes.Name = "dgvPesajes"
        Me.dgvPesajes.ReadOnly = True
        Me.dgvPesajes.Size = New System.Drawing.Size(972, 151)
        Me.dgvPesajes.TabIndex = 36
        Me.dgvPesajes.TabStop = False
        '
        'dataNum
        '
        Me.dataNum.HeaderText = "N°"
        Me.dataNum.Name = "dataNum"
        Me.dataNum.ReadOnly = True
        Me.dataNum.Width = 30
        '
        'dataItemCode
        '
        Me.dataItemCode.HeaderText = "Item"
        Me.dataItemCode.Name = "dataItemCode"
        Me.dataItemCode.ReadOnly = True
        Me.dataItemCode.Width = 50
        '
        'dataItemName
        '
        Me.dataItemName.HeaderText = "Descripción del artículo"
        Me.dataItemName.Name = "dataItemName"
        Me.dataItemName.ReadOnly = True
        Me.dataItemName.Width = 200
        '
        'dataQuantity
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataQuantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.dataQuantity.HeaderText = "Peso bruto"
        Me.dataQuantity.Name = "dataQuantity"
        Me.dataQuantity.ReadOnly = True
        Me.dataQuantity.Width = 80
        '
        'dataTarePeso
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataTarePeso.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataTarePeso.HeaderText = "Envase entrada"
        Me.dataTarePeso.Name = "dataTarePeso"
        Me.dataTarePeso.ReadOnly = True
        Me.dataTarePeso.Width = 80
        '
        'dataTareNom
        '
        Me.dataTareNom.HeaderText = "Nombre de envase"
        Me.dataTareNom.Name = "dataTareNom"
        Me.dataTareNom.ReadOnly = True
        Me.dataTareNom.Visible = False
        '
        'dataTareCod
        '
        Me.dataTareCod.HeaderText = "Código de envase"
        Me.dataTareCod.Name = "dataTareCod"
        Me.dataTareCod.ReadOnly = True
        Me.dataTareCod.Visible = False
        '
        'dataFreeTxt
        '
        Me.dataFreeTxt.HeaderText = "Detalle impurezas"
        Me.dataFreeTxt.Name = "dataFreeTxt"
        Me.dataFreeTxt.ReadOnly = True
        Me.dataFreeTxt.Visible = False
        '
        'dataTimeStamp
        '
        Me.dataTimeStamp.HeaderText = "TimeStamp"
        Me.dataTimeStamp.Name = "dataTimeStamp"
        Me.dataTimeStamp.ReadOnly = True
        Me.dataTimeStamp.Visible = False
        '
        'dataFoto
        '
        Me.dataFoto.HeaderText = "Foto"
        Me.dataFoto.Name = "dataFoto"
        Me.dataFoto.ReadOnly = True
        Me.dataFoto.Visible = False
        Me.dataFoto.Width = 200
        '
        'dataFotoSal
        '
        Me.dataFotoSal.HeaderText = "FotoSalida"
        Me.dataFotoSal.Name = "dataFotoSal"
        Me.dataFotoSal.ReadOnly = True
        Me.dataFotoSal.Visible = False
        '
        'dataPesoBrutoSalida
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.MintCream
        Me.dataPesoBrutoSalida.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataPesoBrutoSalida.HeaderText = "Tara (Bruto)"
        Me.dataPesoBrutoSalida.Name = "dataPesoBrutoSalida"
        Me.dataPesoBrutoSalida.ReadOnly = True
        Me.dataPesoBrutoSalida.Width = 80
        '
        'dataEnvSalCod
        '
        Me.dataEnvSalCod.HeaderText = "Cod. Envase Salida"
        Me.dataEnvSalCod.Name = "dataEnvSalCod"
        Me.dataEnvSalCod.ReadOnly = True
        Me.dataEnvSalCod.Visible = False
        '
        'dataEnvSalNom
        '
        Me.dataEnvSalNom.HeaderText = "Nombre envase salida"
        Me.dataEnvSalNom.Name = "dataEnvSalNom"
        Me.dataEnvSalNom.ReadOnly = True
        Me.dataEnvSalNom.Visible = False
        '
        'dataEnvSalPeso
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.MintCream
        Me.dataEnvSalPeso.DefaultCellStyle = DataGridViewCellStyle10
        Me.dataEnvSalPeso.HeaderText = "Envase salida"
        Me.dataEnvSalPeso.Name = "dataEnvSalPeso"
        Me.dataEnvSalPeso.ReadOnly = True
        Me.dataEnvSalPeso.Width = 80
        '
        'dataTimeStampSal
        '
        Me.dataTimeStampSal.HeaderText = "TimeStampSalida"
        Me.dataTimeStampSal.Name = "dataTimeStampSal"
        Me.dataTimeStampSal.ReadOnly = True
        Me.dataTimeStampSal.Visible = False
        '
        'dataImpurezas
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.MintCream
        Me.dataImpurezas.DefaultCellStyle = DataGridViewCellStyle11
        Me.dataImpurezas.HeaderText = "Impurezas"
        Me.dataImpurezas.Name = "dataImpurezas"
        Me.dataImpurezas.ReadOnly = True
        Me.dataImpurezas.Width = 80
        '
        'dataTotal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Turquoise
        Me.dataTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.dataTotal.HeaderText = "Total"
        Me.dataTotal.Name = "dataTotal"
        Me.dataTotal.ReadOnly = True
        Me.dataTotal.Width = 80
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Peso"
        '
        'btnCaptura
        '
        Me.btnCaptura.BackColor = System.Drawing.Color.DarkRed
        Me.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptura.ForeColor = System.Drawing.Color.White
        Me.btnCaptura.Location = New System.Drawing.Point(887, 185)
        Me.btnCaptura.Name = "btnCaptura"
        Me.btnCaptura.Size = New System.Drawing.Size(83, 71)
        Me.btnCaptura.TabIndex = 18
        Me.btnCaptura.Text = "Capturar Peso"
        Me.btnCaptura.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.Coral
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(574, 446)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(140, 34)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Text = "Guardar Pesaje"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.Coral
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnImprimir.Location = New System.Drawing.Point(718, 446)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(127, 34)
        Me.btnImprimir.TabIndex = 41
        Me.btnImprimir.Text = "Imprimir Ticket"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtIngreso
        '
        Me.txtIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngreso.Location = New System.Drawing.Point(100, 121)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.ReadOnly = True
        Me.txtIngreso.Size = New System.Drawing.Size(134, 22)
        Me.txtIngreso.TabIndex = 42
        Me.txtIngreso.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Ingreso"
        '
        'lblsalida
        '
        Me.lblsalida.AutoSize = True
        Me.lblsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalida.Location = New System.Drawing.Point(247, 124)
        Me.lblsalida.Name = "lblsalida"
        Me.lblsalida.Size = New System.Drawing.Size(47, 16)
        Me.lblsalida.TabIndex = 44
        Me.lblsalida.Text = "Salida"
        '
        'txtSalida
        '
        Me.txtSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalida.Location = New System.Drawing.Point(297, 121)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.ReadOnly = True
        Me.txtSalida.Size = New System.Drawing.Size(125, 22)
        Me.txtSalida.TabIndex = 45
        Me.txtSalida.TabStop = False
        '
        'txtBooking
        '
        Me.txtBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooking.Location = New System.Drawing.Point(537, 121)
        Me.txtBooking.Name = "txtBooking"
        Me.txtBooking.Size = New System.Drawing.Size(102, 22)
        Me.txtBooking.TabIndex = 10
        '
        'txtPO
        '
        Me.txtPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPO.Location = New System.Drawing.Point(723, 121)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(170, 22)
        Me.txtPO.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Booking"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(673, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 16)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "PO N°"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.rbCompra)
        Me.Panel1.Controls.Add(Me.rbVenta)
        Me.Panel1.Location = New System.Drawing.Point(243, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 23)
        Me.Panel1.TabIndex = 50
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkRed
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(850, 446)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(138, 34)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "Buscar Ticket"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(15, 446)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(164, 34)
        Me.btnLimpiar.TabIndex = 52
        Me.btnLimpiar.Text = "Limpiar Formulario"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(100, 8)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(48, 22)
        Me.txtFolio.TabIndex = 54
        Me.txtFolio.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 45)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpBoxSalida)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpBoxEntrada)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnImprimir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGuardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFolio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvPesajes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLimpiar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTranspNombre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnTransportista)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtChoferNombre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBuscar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnChofer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPO)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtBooking)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTranspRUT)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblPatente)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtChoferRUT)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSalida)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPPU)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTicketNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblsalida)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtIngreso)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCaptura)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSNNombre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnProveedor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtObservacion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtGuia)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSNRUT)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Size = New System.Drawing.Size(1136, 483)
        Me.SplitContainer1.SplitterDistance = 142
        Me.SplitContainer1.TabIndex = 55
        '
        'grpBoxSalida
        '
        Me.grpBoxSalida.Controls.Add(Me.txtEnvSalidaPeso)
        Me.grpBoxSalida.Controls.Add(Me.txtPesoSalida)
        Me.grpBoxSalida.Controls.Add(Me.Label2)
        Me.grpBoxSalida.Controls.Add(Me.Label3)
        Me.grpBoxSalida.Controls.Add(Me.btnEnvSalida)
        Me.grpBoxSalida.Controls.Add(Me.txtEnvSalidaNom)
        Me.grpBoxSalida.Controls.Add(Me.txtEnvSalidaCod)
        Me.grpBoxSalida.Controls.Add(Me.Label11)
        Me.grpBoxSalida.Controls.Add(Me.txtFreeTxt)
        Me.grpBoxSalida.Controls.Add(Me.txtImpurezas)
        Me.grpBoxSalida.Location = New System.Drawing.Point(443, 165)
        Me.grpBoxSalida.Name = "grpBoxSalida"
        Me.grpBoxSalida.Size = New System.Drawing.Size(422, 100)
        Me.grpBoxSalida.TabIndex = 56
        Me.grpBoxSalida.TabStop = False
        Me.grpBoxSalida.Text = "Tara"
        '
        'txtEnvSalidaPeso
        '
        Me.txtEnvSalidaPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvSalidaPeso.Location = New System.Drawing.Point(382, 48)
        Me.txtEnvSalidaPeso.Name = "txtEnvSalidaPeso"
        Me.txtEnvSalidaPeso.ReadOnly = True
        Me.txtEnvSalidaPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEnvSalidaPeso.Size = New System.Drawing.Size(36, 22)
        Me.txtEnvSalidaPeso.TabIndex = 40
        Me.txtEnvSalidaPeso.TabStop = False
        '
        'txtPesoSalida
        '
        Me.txtPesoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoSalida.Location = New System.Drawing.Point(95, 75)
        Me.txtPesoSalida.Name = "txtPesoSalida"
        Me.txtPesoSalida.ReadOnly = True
        Me.txtPesoSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPesoSalida.Size = New System.Drawing.Size(60, 22)
        Me.txtPesoSalida.TabIndex = 39
        Me.txtPesoSalida.TabStop = False
        Me.txtPesoSalida.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Envase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Peso"
        '
        'btnEnvSalida
        '
        Me.btnEnvSalida.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnEnvSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnvSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvSalida.Location = New System.Drawing.Point(163, 48)
        Me.btnEnvSalida.Name = "btnEnvSalida"
        Me.btnEnvSalida.Size = New System.Drawing.Size(22, 22)
        Me.btnEnvSalida.TabIndex = 39
        Me.btnEnvSalida.TabStop = False
        Me.btnEnvSalida.UseVisualStyleBackColor = True
        '
        'txtEnvSalidaNom
        '
        Me.txtEnvSalidaNom.Location = New System.Drawing.Point(195, 48)
        Me.txtEnvSalidaNom.Name = "txtEnvSalidaNom"
        Me.txtEnvSalidaNom.ReadOnly = True
        Me.txtEnvSalidaNom.Size = New System.Drawing.Size(181, 22)
        Me.txtEnvSalidaNom.TabIndex = 36
        '
        'txtEnvSalidaCod
        '
        Me.txtEnvSalidaCod.Location = New System.Drawing.Point(96, 48)
        Me.txtEnvSalidaCod.Name = "txtEnvSalidaCod"
        Me.txtEnvSalidaCod.Size = New System.Drawing.Size(61, 22)
        Me.txtEnvSalidaCod.TabIndex = 35
        '
        'txtFreeTxt
        '
        Me.txtFreeTxt.Location = New System.Drawing.Point(163, 20)
        Me.txtFreeTxt.MaxLength = 255
        Me.txtFreeTxt.Name = "txtFreeTxt"
        Me.txtFreeTxt.Size = New System.Drawing.Size(255, 22)
        Me.txtFreeTxt.TabIndex = 17
        '
        'txtImpurezas
        '
        Me.txtImpurezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpurezas.Location = New System.Drawing.Point(96, 20)
        Me.txtImpurezas.Name = "txtImpurezas"
        Me.txtImpurezas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImpurezas.Size = New System.Drawing.Size(61, 22)
        Me.txtImpurezas.TabIndex = 16
        Me.txtImpurezas.Text = "0"
        '
        'grpBoxEntrada
        '
        Me.grpBoxEntrada.Controls.Add(Me.txtLineId)
        Me.grpBoxEntrada.Controls.Add(Me.Label9)
        Me.grpBoxEntrada.Controls.Add(Me.txtItemCod)
        Me.grpBoxEntrada.Controls.Add(Me.Label10)
        Me.grpBoxEntrada.Controls.Add(Me.txtItemName)
        Me.grpBoxEntrada.Controls.Add(Me.txtTaraCod)
        Me.grpBoxEntrada.Controls.Add(Me.txtTaraDescripcion)
        Me.grpBoxEntrada.Controls.Add(Me.btnArticulo)
        Me.grpBoxEntrada.Controls.Add(Me.btnEnvase)
        Me.grpBoxEntrada.Controls.Add(Me.txtTaraPeso)
        Me.grpBoxEntrada.Controls.Add(Me.txtPeso)
        Me.grpBoxEntrada.Controls.Add(Me.Label12)
        Me.grpBoxEntrada.Location = New System.Drawing.Point(15, 165)
        Me.grpBoxEntrada.Name = "grpBoxEntrada"
        Me.grpBoxEntrada.Size = New System.Drawing.Size(422, 100)
        Me.grpBoxEntrada.TabIndex = 55
        Me.grpBoxEntrada.TabStop = False
        Me.grpBoxEntrada.Text = "Bruto"
        '
        'txtLineId
        '
        Me.txtLineId.Location = New System.Drawing.Point(184, 75)
        Me.txtLineId.Name = "txtLineId"
        Me.txtLineId.Size = New System.Drawing.Size(50, 22)
        Me.txtLineId.TabIndex = 39
        Me.txtLineId.Visible = False
        '
        'txtItemCod
        '
        Me.txtItemCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCod.Location = New System.Drawing.Point(85, 20)
        Me.txtItemCod.Name = "txtItemCod"
        Me.txtItemCod.Size = New System.Drawing.Size(61, 22)
        Me.txtItemCod.TabIndex = 12
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(184, 20)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(223, 22)
        Me.txtItemName.TabIndex = 25
        Me.txtItemName.TabStop = False
        '
        'txtTaraCod
        '
        Me.txtTaraCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaraCod.Location = New System.Drawing.Point(85, 48)
        Me.txtTaraCod.Name = "txtTaraCod"
        Me.txtTaraCod.Size = New System.Drawing.Size(61, 22)
        Me.txtTaraCod.TabIndex = 14
        '
        'txtTaraDescripcion
        '
        Me.txtTaraDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaraDescripcion.Location = New System.Drawing.Point(184, 48)
        Me.txtTaraDescripcion.Name = "txtTaraDescripcion"
        Me.txtTaraDescripcion.ReadOnly = True
        Me.txtTaraDescripcion.Size = New System.Drawing.Size(181, 22)
        Me.txtTaraDescripcion.TabIndex = 27
        Me.txtTaraDescripcion.TabStop = False
        '
        'btnArticulo
        '
        Me.btnArticulo.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulo.Location = New System.Drawing.Point(152, 20)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Size = New System.Drawing.Size(22, 22)
        Me.btnArticulo.TabIndex = 13
        Me.btnArticulo.TabStop = False
        Me.btnArticulo.UseVisualStyleBackColor = True
        '
        'btnEnvase
        '
        Me.btnEnvase.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnEnvase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvase.Location = New System.Drawing.Point(152, 48)
        Me.btnEnvase.Name = "btnEnvase"
        Me.btnEnvase.Size = New System.Drawing.Size(22, 22)
        Me.btnEnvase.TabIndex = 15
        Me.btnEnvase.TabStop = False
        Me.btnEnvase.UseVisualStyleBackColor = True
        '
        'txtTaraPeso
        '
        Me.txtTaraPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaraPeso.Location = New System.Drawing.Point(371, 48)
        Me.txtTaraPeso.Name = "txtTaraPeso"
        Me.txtTaraPeso.ReadOnly = True
        Me.txtTaraPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTaraPeso.Size = New System.Drawing.Size(36, 22)
        Me.txtTaraPeso.TabIndex = 30
        Me.txtTaraPeso.TabStop = False
        '
        'btnProveedor
        '
        Me.btnProveedor.BackgroundImage = Global.Scrap_Weight_Software.My.Resources.Resources.Crystal_Clear_action_playlist
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProveedor.Location = New System.Drawing.Point(212, 65)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(22, 22)
        Me.btnProveedor.TabIndex = 3
        Me.btnProveedor.TabStop = False
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 39)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Pesaje"
        '
        'frmPesaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 539)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPesaje"
        Me.ShowIcon = False
        CType(Me.dgvPesajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpBoxSalida.ResumeLayout(False)
        Me.grpBoxSalida.PerformLayout()
        Me.grpBoxEntrada.ResumeLayout(False)
        Me.grpBoxEntrada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTicketNum As System.Windows.Forms.TextBox
    Friend WithEvents txtPPU As System.Windows.Forms.TextBox
    Friend WithEvents txtSNRUT As System.Windows.Forms.TextBox
    Friend WithEvents txtChoferRUT As System.Windows.Forms.TextBox
    Friend WithEvents txtTranspRUT As System.Windows.Forms.TextBox
    Friend WithEvents txtGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbVenta As System.Windows.Forms.RadioButton
    Friend WithEvents lblSN As System.Windows.Forms.Label
    Friend WithEvents lblPatente As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnProveedor As System.Windows.Forms.Button
    Friend WithEvents txtSNNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnChofer As System.Windows.Forms.Button
    Friend WithEvents txtChoferNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnTransportista As System.Windows.Forms.Button
    Friend WithEvents txtTranspNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvPesajes As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCaptura As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblsalida As System.Windows.Forms.Label
    Friend WithEvents txtSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtBooking As System.Windows.Forms.TextBox
    Friend WithEvents txtPO As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFreeTxt As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCod As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents txtTaraDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtTaraPeso As System.Windows.Forms.TextBox
    Friend WithEvents btnEnvase As System.Windows.Forms.Button
    Friend WithEvents btnArticulo As System.Windows.Forms.Button
    Friend WithEvents txtImpurezas As System.Windows.Forms.TextBox
    Friend WithEvents txtTaraCod As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpBoxSalida As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesoSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEnvSalida As System.Windows.Forms.Button
    Friend WithEvents txtEnvSalidaNom As System.Windows.Forms.TextBox
    Friend WithEvents txtEnvSalidaCod As System.Windows.Forms.TextBox
    Friend WithEvents grpBoxEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents txtLineId As System.Windows.Forms.TextBox
    Friend WithEvents txtEnvSalidaPeso As System.Windows.Forms.TextBox
    Friend WithEvents dataNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTarePeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTareNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTareCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataFreeTxt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTimeStamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataFotoSal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataPesoBrutoSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataEnvSalCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataEnvSalNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataEnvSalPeso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTimeStampSal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataImpurezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
