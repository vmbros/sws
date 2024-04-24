Imports System.Data
Imports System.Data.OleDb
Imports cCamara
Imports System.Threading
Imports System.IO
Imports SAPbobsCOM

' 2020-01-03 Se cambia ruta, usuario y contrasena de camara patio metales
' 2020-02-13 Se cambia acceso a romana de COM1 a NPORT 5110

Public Class frmPesaje
    Implements iMantenedores

    Dim dr As OleDbDataReader
    Dim command As OleDbCommand
    Dim conn As OleDbConnection
    Dim _CardCode As String
    Dim tempId As Integer
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bascula\Bascula.accdb;Jet OLEDB:Database Password=PV3ra.2012;"
    Dim ListaParametro As New ArrayList()
    Dim vCmp As Object

    Public Property user As String
    Private Sub agregarLinea()
        Dim i As Integer
        Dim Peso, Tara, Impurezas, Total As Double
        Dim itemCode, itemName, taraNom, taraCod, timeStamp, detalleImpurezas As String

        'MessageBox.Show(dgvPesajes.RowCount.ToString)
        If Not (IsNumeric(txtPeso.Text)) Then
            txtPeso.Text = 0
        End If
        If Not (IsNumeric(txtTaraPeso.Text)) Then
            txtTaraPeso.Text = 0
        End If
        If Not (IsNumeric(txtImpurezas.Text)) Then
            txtImpurezas.Text = 0
        End If

        Peso = CDbl(txtPeso.Text)
        Tara = CDbl(txtTaraPeso.Text)
        taraCod = txtTaraCod.Text
        taraNom = txtTaraDescripcion.Text
        Impurezas = CDbl(txtImpurezas.Text)
        Total = Peso - Tara - Impurezas
        itemCode = txtItemCod.Text
        itemName = txtItemName.Text
        timeStamp = Now.ToString
        detalleImpurezas = txtFreeTxt.Text

        i = dgvPesajes.RowCount


        Dim nuevaLinea As DataGridViewRow = dgvPesajes.Rows(dgvPesajes.NewRowIndex).Clone

        With nuevaLinea
            .Cells(dataNum.Index).Value = i
            .Cells(dataItemCode.Index).Value = itemCode
            .Cells(dataItemName.Index).Value = itemName
            .Cells(dataQuantity.Index).Value = Peso
            .Cells(dataTarePeso.Index).Value = Tara
            .Cells(dataTareCod.Index).Value = taraCod
            .Cells(dataTareNom.Index).Value = taraNom
            .Cells(dataImpurezas.Index).Value = Impurezas
            .Cells(dataTotal.Index).Value = Total
            .Cells(dataTimeStamp.Index).Value = timeStamp
            .Cells(dataFreeTxt.Index).Value = detalleImpurezas
            .Cells(dataFoto.Index).Value = ""

        End With

        dgvPesajes.Rows.Add(nuevaLinea)

        txtItemCod.Text = ""
        txtItemName.Text = ""
        txtTaraCod.Text = ""
        txtTaraDescripcion.Text = ""
        txtTaraPeso.Text = ""
        txtPeso.Text = ""
        txtImpurezas.Text = ""
        txtFreeTxt.Text = ""
        'BtnTara.Enabled = False


    End Sub

    Private Sub dgvPesajes_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvPesajes.RowsAdded
        Dim i As Integer = 0
        For i = 0 To dgvPesajes.RowCount - 2
            dgvPesajes.Rows(i).Cells(dataNum.Index).Value = i + 1
        Next
        If i > 0 Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub dgvPesajes_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvPesajes.RowsRemoved
        Dim i As Integer = 0
        Dim row As Integer
        Dim foto As String

        row = e.RowIndex
        If row = (dgvPesajes.RowCount - 1) Then
            For i = 0 To dgvPesajes.RowCount - 2
                dgvPesajes.Rows(i).Cells(dataNum.Index).Value = i + 1
            Next
            If i > 0 Then
                btnGuardar.Enabled = True
            Else
                btnGuardar.Enabled = False
            End If


            i = 0
            Dim oDB As New cDB
            oDB.conectar()
            i = oDB.nonQuery("DELETE FROM tTicketDetalle WHERE LineNum=" & row.ToString & " AND Id=" & tempId.ToString)
            oDB.desconectar()

            If i > 0 Then
                Dim oCamara As New cCamara.cCamara
                Dim result As String
                foto = dgvPesajes.Rows(i).Cells(dataFoto.Index).Value
                oCamara.rutaImages = "C:\Bascula\imagenes\"
                result = oCamara.delSnapshot(foto)
                MessageBox.Show(result)
            End If
        End If

    End Sub

    Public Sub iText(ByVal cod As String, ByVal descripcion As String, ByVal op As String, Optional peso As Double = 0, Optional ByVal codigoSN As String = "") Implements iMantenedores.iText
        If op = "Envases" Then
            txtTaraCod.Text = cod
            txtTaraDescripcion.Text = descripcion
            txtTaraPeso.Text = peso
        ElseIf op = "EnvasesSal" Then
            txtEnvSalidaCod.Text = cod
            txtEnvSalidaNom.Text = descripcion
            txtEnvSalidaPeso.Text = peso
        ElseIf op = "Choferes" Then
            txtChoferRUT.Text = cod
            txtChoferNombre.Text = descripcion
        ElseIf op = "Transportistas" Then
            txtTranspRUT.Text = cod
            txtTranspNombre.Text = descripcion
        ElseIf op = "SN" Then
            txtSNRUT.Text = cod
            txtSNNombre.Text = descripcion
            _CardCode = codigoSN
        ElseIf op = "Articulos" Then
            txtItemCod.Text = cod
            txtItemName.Text = descripcion
        End If
    End Sub

    Private Sub btnTara_Click(sender As Object, e As EventArgs) Handles btnEnvase.Click
        Dim frmMaestro As New frmEnvases
        frmMaestro.origen = "Envases"
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnChofer_Click(sender As Object, e As EventArgs) Handles btnChofer.Click
        Dim frmMaestro As New frmChoferes
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnTransportista_Click(sender As Object, e As EventArgs) Handles btnTransportista.Click
        Dim frmMaestro As New frmTransportistas
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Dim filtro As String = "S"
        If rbCompra.Checked = True Then
            filtro = "S"
        ElseIf rbVenta.Checked = True Then
            filtro = "C"
        Else
            MessageBox.Show("Seleccione operación Compra o Venta")
        End If
        Dim frmMaestro As New frmOCRD(filtro)
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnArticulo_Click(sender As Object, e As EventArgs) Handles btnArticulo.Click
        Dim frmMaestro As New FrmArticulos
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnCaptura_Click(sender As Object, e As EventArgs) Handles btnCaptura.Click
        Dim oBascula As New cBascula
        Dim peso As Double
        Dim row As Integer
        Dim tipoRomana As String
        Dim URLcamara As String = ""
        If txtTranspRUT.Text = "" Then
            txtTranspRUT.Text = "PROV"
        End If
        If txtChoferRUT.Text = "" Then
            txtChoferRUT.Text = "PROV"
        End If
        rbCompra.Enabled = False
        rbVenta.Enabled = False
        '-------------------------------------------------------------------------------------------------------------------------
        'código para capturar peso desde romana.
        '-------------------------------------------------------------------------------------------------------------------------
        'oBascula.PortName = ListaParametro(1).ToString().ToUpper
        'oBascula.BaudRate = ListaParametro(4).ToString().ToUpper
        tipoRomana = ListaParametro(5).ToString.ToUpper
        'If oBascula.PortName = "" Then
        '    MessageBox.Show("No se ha configurado el puerto com. Herramientas -> parámetros")
        '    Exit Sub
        'End If

        If tipoRomana = "C" Then
            'URLcamara = "http://192.168.1.66/cgi-bin/admin/presnapview.lua"
            'peso = CDbl(oBascula.CapturarPeso())
            ''If peso = 0 Or (peso Mod 10 <> 0) Then
            ''    'repite si es 0 o no es numérico
            ''    peso = CDbl(oBascula.CapturarPeso())
            ''End If
        ElseIf tipoRomana = "D" Then
            'URLcamara = "http://192.168.1.97/axis-cgi/jpg/image.cgi"
            'URLcamara = "http://192.168.1.97/cgi-bin/encoder?USER=admin&PWD=123456&SNAPSHOT"

            ''*****************************************
            '' si se utiliza COM1
            ''peso = CDbl(oBascula.CapturarPesoMetales)

            ''*************************************************** 
            ''** se utiliza ZM301                               |
            ''**Dim oIndicador As cZM301                        |
            ''**oIndicador = New cZM301("192.168.2.8", 2080)    |
            ''***************************************************
            ' se utiliza NPORT 5110
            Dim oIndicador As cNPort5110

            oIndicador = New cNPort5110("192.168.1.240", 4001)

            peso = oIndicador.getPeso
            If peso = 0 Then
                MessageBox.Show("No hay carga en romana.")
            ElseIf peso < 0 Then
                MessageBox.Show("Error.")
            Else
                'txtPeso.Text = peso.ToString
            End If


        End If


        '-------------------------------------------------------------------------------------------------------------------------


        ''------------------------------------------------------------------------------------------------------------------------
        ''código para peso aleatorio cuando el software no esté conectado a una romana.
        ''-------------------------------------------------------------------------------------------------------------------------
        'peso = 50000
        'URLcamara = "http://192.168.1.56/axis-cgi/jpg/image.cgi"
        'peso = CInt(Math.Ceiling(Rnd() * peso)) + 1
        ''peso = 0
        ''-------------------------------------------------------------------------------------------------------------------------


        If IsNumeric(txtLineId.Text) Then

            'peso = 20000
            'peso = CInt(Math.Ceiling(Rnd() * peso)) + 1


            For Each Control In grpBoxEntrada.Controls
                If (TypeOf Control Is TextBox) Or (TypeOf Control Is Button) Then
                    Control.enabled = False
                    'Control.readonly = True
                End If
            Next


            'Procedimiento para registrar la tara


            txtPesoSalida.Text = peso.ToString
            If CDbl(txtPesoSalida.Text) >= 0 Then
                If Not IsNumeric(txtEnvSalidaPeso.Text) Then
                    txtEnvSalidaPeso.Text = "0"
                    txtEnvSalidaCod.Text = "SE"
                    txtEnvSalidaNom.Text = "Sin envase"
                End If
                If Not IsNumeric(txtImpurezas.Text) Then
                    txtImpurezas.Text = "0"
                End If

                '-------------------------------------------------------------------------------------------------------------------------
                'Actualizar línea de tara en datagridview
                '-------------------------------------------------------------------------------------------------------------------------
                row = txtLineId.Text
                With dgvPesajes.Rows(row)
                    .Cells(dataEnvSalCod.Index).Value = txtEnvSalidaCod.Text
                    .Cells(dataEnvSalNom.Index).Value = txtEnvSalidaNom.Text
                    .Cells(dataEnvSalPeso.Index).Value = txtEnvSalidaPeso.Text
                    .Cells(dataImpurezas.Index).Value = txtImpurezas.Text
                    .Cells(dataFreeTxt.Index).Value = txtFreeTxt.Text
                    .Cells(dataPesoBrutoSalida.Index).Value = txtPesoSalida.Text
                    .Cells(dataTimeStampSal.Index).Value = Now.ToString
                    .Cells(dataTotal.Index).Value = CDbl(.Cells(dataQuantity.Index).Value) - CDbl(.Cells(dataTarePeso.Index).Value) - CDbl(txtImpurezas.Text) - CDbl(txtPesoSalida.Text) + CDbl(txtEnvSalidaPeso.Text)
                End With

                '-------------------------------------------------------------------------------------------------------------------------
                'Actualizar en tabla 
                '-------------------------------------------------------------------------------------------------------------------------
                actualizarLineaEnDB(tempId, row)
                '


                '-------------------------------------------------------------------------------------------------------------------------
                'código para capturar imagen (la línea debe haber sido agregada al dgvPesajes para que actualice la celda foto)
                '-------------------------------------------------------------------------------------------------------------------------
                'Dim t As Thread()
                'Dim tStart As New ThreadStart(AddressOf capturaFoto)
                Dim t = New Thread(Sub() Me.capturaFoto(tempId, row, "S", URLcamara))
                Try
                    't = New Thread(tStart)
                    t.IsBackground = True
                    t.Name = "Capturando imagen"
                    t.Start()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try


                For Each Control In grpBoxEntrada.Controls
                    If (TypeOf Control Is TextBox) Or (TypeOf Control Is Button) Then
                        Control.enabled = True
                        Control.text = ""
                        'Control.readonly = True
                    End If
                Next
                For Each Control In grpBoxSalida.Controls
                    If (TypeOf Control Is TextBox) Or (TypeOf Control Is Button) Then
                        Control.enabled = False
                        'Control.readonly = True
                        Control.text = ""
                    End If
                Next

            Else
                MessageBox.Show("No se puede pesar si la báscula está con pesos negativos.", "Peso en 0")
                'BtnTara.Enabled = False
            End If

        Else
            'MessageBox.Show("capturar peso")

            txtPeso.Text = peso.ToString

            If txtItemCod.Text <> "" And txtItemName.Text <> "" Then
                If CDbl(txtPeso.Text) > 0 Then
                    If Not IsNumeric(txtTaraPeso.Text) Then
                        txtTaraPeso.Text = "0"
                        txtTaraCod.Text = "SE"
                        txtTaraDescripcion.Text = "Sin envase"
                    End If
                    'If Not IsNumeric(txtImpurezas.Text) Then
                    '    txtImpurezas.Text = "0"
                    'End If

                    '-------------------------------------------------------------------------------------------------------------------------
                    'agregar línea de pesaje en datagridview
                    '-------------------------------------------------------------------------------------------------------------------------
                    agregarLinea()

                    '-------------------------------------------------------------------------------------------------------------------------
                    'Guardar en tabla 
                    '-------------------------------------------------------------------------------------------------------------------------
                    If tempId = 0 Then
                        guardarEncabezado()
                        cargaPanelPesajesPendientes()
                    End If

                    row = dgvPesajes.RowCount - 2
                    guardarLineaEnDB(tempId)
                    '


                    '-------------------------------------------------------------------------------------------------------------------------
                    'código para capturar imagen (la línea debe haber sido agregada al dgvPesajes para que actualice la celda foto)
                    '-------------------------------------------------------------------------------------------------------------------------
                    ' Dim t As Thread()
                    'Dim tStart As New ThreadStart(AddressOf capturaFoto)

                    '''Dim t = New Thread(Sub() Me.capturaFoto(tempId, row, "E", URLcamara))
                    '''Try
                    '''    't = New Thread(tStart)
                    '''    t.IsBackground = True
                    '''    t.Name = "Capturando imagen"
                    '''    t.Start()

                    '''Catch ex As Exception
                    '''    MessageBox.Show(ex.ToString)
                    '''End Try
                    '-------------------------------------------------------------------------------------------------------------------------
                Else
                    MessageBox.Show("No se puede pesar si la báscula está en 0.", "Peso en 0")
                    'BtnTara.Enabled = False
                End If
            Else
                MessageBox.Show("Debe seleccionar el artículo que está pesando.", "Falta artículo")
                'BtnTara.Enabled = False
            End If
        End If

    End Sub
    Private Sub capturaFoto(ByVal parent As Integer, ByVal linenum As Integer, ByVal op As String, ByVal URLcamara As String)
        Dim oCamara As New cCamara.cCamara
        Dim result As String
        Dim folioPref, campo As String
        'Static cont As Integer = 0
        oCamara.user = "admin"
        oCamara.pass = "123456"
        oCamara.rutaImages = "C:\Bascula\imagenes\"
        oCamara.rutaCamara = URLcamara
        folioPref = txtFolio.Text + op
        'MessageBox.Show("takesnapshot;id:" + tempId.ToString + ";line:" + linenum.ToString + ";Foliopref:" + folioPref)
        result = oCamara.takeSnapshot(tempId.ToString, linenum.ToString, folioPref)
        'MessageBox.Show("result:" + result)
        If File.Exists(oCamara.rutaImages & result) Then
            ' UPDATE tTicket 
            Dim oDB As New cDB
            Dim fa As Integer
            oDB.conectar()
            If op = "S" Then
                campo = "FotoSal"
            Else
                campo = "foto"
            End If
            fa = oDB.nonQuery("UPDATE tTicketDetalle SET " + campo + "='" + result + "' WHERE id=" + parent.ToString + " AND LineNum=" + linenum.ToString)
            oDB.desconectar()
            If fa > 0 Then
                dgvPesajes.Rows(linenum).Cells(dataFoto.Index).Value = result
            End If
        End If





    End Sub

    Private Sub frmPesaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False ' DESACTIVA ERROR POR SUBPROCESO
        Dim n As New Negocio()

        ListaParametro = n.recorrerArchivo()

        txtFolio.Text = ListaParametro(2).ToString().ToUpper


        If txtIngreso.Text = "" Then
            txtIngreso.Text = Now.ToString
        End If
        txtPO.Enabled = False
        txtBooking.Enabled = False
        ' BtnTara.Enabled = False

        cargaPanelPesajesPendientes()
        rbCompra.Checked = True
        txtPPU.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim insert As String
        Dim ticketNum, fa As Integer
        Dim PPU, Booking, PO, CardCode, ChoferRut, TransportistaRUT, GuiaDespacho As String
        Dim FechaEntrada, FechaSalida, Observaciones, Usuario, Operacion, folio As String
        'Dim GW, NW, Tare As Double
        Dim guardado As Boolean = False


        For Each Control In SplitContainer1.Panel2.Controls

            If (TypeOf Control Is TextBox) Or (TypeOf Control Is Button) Then
                Control.enabled = False
                'Control.readonly = True
            End If
        Next

        btnImprimir.Enabled = True
        btnLimpiar.Enabled = True


        txtSalida.Text = Now.ToString
        PPU = txtPPU.Text
        Booking = txtBooking.Text
        PO = txtPO.Text
        'CardCode = txtSNRUT.Text
        CardCode = _CardCode
        ChoferRut = txtChoferRUT.Text
        TransportistaRUT = txtTranspRUT.Text
        GuiaDespacho = txtGuia.Text
        FechaEntrada = txtIngreso.Text
        FechaSalida = txtSalida.Text
        Observaciones = txtObservacion.Text
        Usuario = user
        folio = txtFolio.Text
        If rbCompra.Checked = True Then
            Operacion = "E"
        Else
            Operacion = "S"
        End If

        Dim oDB As New cDB
        Dim result As ArrayList
        oDB.conectar()
        result = oDB.query("SELECT MAX(TicketNum) as tNum FROM tTicket")
        oDB.desconectar()
        For Each dat As Dictionary(Of String, Object) In result
            If IsNumeric(dat("tNum").ToString) Then
                ticketNum = CInt(dat("tNum").ToString) + 1
            Else
                ticketNum = 1
            End If

            txtTicketNum.Text = ticketNum.ToString
        Next

        'MessageBox.Show("Id:" & tempId.ToString)
        'MessageBox.Show("Ticket:" & ticketNum.ToString)

        fa = actualizaEncabezado(tempId)
        'MessageBox.Show("Filas afectadas:" & fa.ToString)

        If fa > 0 Then
            insert = "UPDATE tTicket SET TicketNum =" & ticketNum.ToString & ",FechaSalida='" & FechaSalida & "' WHERE Id=" & tempId.ToString


            conn = New OleDbConnection(constr)
            command = New OleDbCommand(insert, conn)
            conn.Open()
            fa = command.ExecuteNonQuery
            conn.Close()
            If fa > 0 Then
                btnImprimir_Click(sender, e)
                '***********************   ENVIA A REPO DE TICKETS DE PESAJE  *******************
                'agregarPreliminar(tempId, ticketNum)
                If Operacion = "E" Then
                    ' Si es entrada guarda preliminar para proveedores
                    btnSync_Click(tempId)
                Else
                    'Operacion = S

                    ' agregar entrega en SAP



                End If

                '**************************************************************************
            Else
                MessageBox.Show("No se pudo asignar folio. Favor revise los campos obligatorios.")
            End If

            cargaPanelPesajesPendientes()
        End If


    End Sub


    Private Sub btnSync_Click(ByVal tempId As Integer)
        Dim i, rowCount, syncCount As Integer

        Dim oDB As New cDB
        Dim comando As String


        syncCount = 0

        Dim TicketNum As Integer


        
        oDB.conectar()
        comando = "SELECT TOP 1 Id,TicketNum,PPU,Booking,PO,LicTradNum,ChoferRUT,TransportistaRUT,GuiaDespacho,FechaEntrada,"
        comando += "FechaSalida,Observaciones,Usuario,Operacion,GW,NW,Tare,DocEntrySAP,FolioPref "
        comando += "FROM tTicket INNER JOIN OCRD ON tTicket.CardCode=OCRD.CardCode WHERE id=" + tempId.ToString
        Dim arreglo As New ArrayList
        arreglo = oDB.query(comando)
        oDB.desconectar()

        '**********************************************************************************************
        '*** Armar nonQuery para insertar en servidor remoto
        Dim fechaEntrada, fechaSalida As String
        comando = "INSERT INTO tTicket (Id,TicketNum,PPU,Booking,PO,CardCode,ChoferRUT,TransportistaRUT,GuiaDespacho,FechaEntrada,"
        comando += "FechaSalida,Observaciones,Usuario,Operacion,GW,NW,Tare,DocEntrySAP,FolioPref) VALUES ("
        For Each dat As Dictionary(Of String, Object) In arreglo
            comando += dat("Id").ToString + ","
            comando += dat("TicketNum").ToString + ","
            comando += "'" + dat("PPU").ToString + "',"
            comando += "'" + dat("Booking").ToString + "',"
            comando += "'" + dat("PO").ToString + "',"
            comando += "'" + dat("LicTradNum").ToString + "',"
            comando += "'" + dat("ChoferRUT").ToString + "',"
            comando += "'" + dat("TransportistaRUT").ToString + "',"
            comando += "'" + dat("GuiaDespacho").ToString + "',"

            '**************************************************************************************************************
            'Modificación por fecha de sistema, (se estaba guardadno al revés Mes/dia)
            '**************************************************************************************************************

            comando += "'" + dat("FechaEntrada").ToString + "',"
            'fechaEntrada = dat("FechaEntrada").ToString.Substring(6, 4) + "-" + dat("FechaEntrada").ToString.Substring(3, 2) + "-" + dat("FechaEntrada").ToString.Substring(0, 2) + " " + dat("FechaEntrada").ToString.Substring(11, dat("FechaEntrada").ToString.Length - 11)
            'comando += "'" + fechaEntrada + "',"


            comando += "'" + dat("FechaSalida").ToString + "',"
            'fechaSalida = dat("FechaSalida").ToString.Substring(6, 4) + "-" + dat("FechaSalida").ToString.Substring(3, 2) + "-" + dat("FechaSalida").ToString.Substring(0, 2) + " " + dat("FechaSalida").ToString.Substring(11, dat("FechaSalida").ToString.Length - 11)
            'comando += "'" + fechaSalida + "',"
            '***************************************************************************************************************


            comando += "'" + dat("Observaciones").ToString + "',"
            comando += "'" + dat("Usuario").ToString + "',"
            comando += "'" + dat("Operacion").ToString + "',"
            comando += dat("GW").ToString + ","
            comando += dat("NW").ToString + ","
            comando += dat("Tare").ToString + ","
            comando += dat("DocEntrySAP").ToString + ","
            comando += "'" + dat("FolioPref").ToString + "')"
        Next
        comando += ";SELECT @@IDENTITY;"
        'MessageBox.Show("Enc. " + comando)
        Dim oDBnew As New cDBnew
        oDBnew.Servidor = "RCMTL-SBO"
        oDBnew.Usuario = "recselect1"
        oDBnew.Password = "r3cs3l3ct"
        oDBnew.Db = "swsFull"

        Dim LastInsertId As Integer
        oDBnew.Conectar()
        LastInsertId = oDBnew.Scalar(comando)
        oDBnew.Desconectar()
        If IsNumeric(LastInsertId) Then
            'MessageBox.Show(LastInsertId.ToString)
            '**********************************************************************************************************************************
            '*** Insert detail
            '**********************************************************************************************
            '*** Leer datos desde el servidor local (view) 

            oDB.conectar()
            comando = "SELECT ItemCode,ItemDescription,Peso,TaraCod,TaraNom,TaraPeso,FechaRegistro,Impurezas,FreeTxt,foto,[User],"
            comando += "EnvSCod,EnvSNom,EnvSPeso,PesoSal,FotoSal,UserSalida,FechaRegistroSal "
            comando += "FROM tTicketDetalle WHERE Id=" + tempId.ToString
            'Dim arreglo As New ArrayList
            arreglo.Clear()
            arreglo = oDB.query(comando)
            oDB.desconectar()
            '**********************************************************************************************


            '**********************************************************************************************
            '*** Armar nonQuery para insertar en servidor remoto

            comando = "INSERT INTO tTicketDetalle (AutoId,id,LineNum,ItemCode,ItemDescription,Peso,TaraCod,TaraNom,TaraPeso,FechaRegistro,Impurezas,FreeTxt,foto,[User],"
            comando += "EnvSCod,EnvSNom,EnvSPeso,PesoSal,FotoSal,UserSalida,FechaRegistroSal) VALUES "
            Dim LineNum As Integer = 0
            For Each dat As Dictionary(Of String, Object) In arreglo
                If LineNum > 0 Then comando += ","
                comando += "("
                comando += LastInsertId.ToString + ","
                comando += TicketNum.ToString + ","
                comando += LineNum.ToString + ","
                comando += "'" + dat("ItemCode").ToString + "',"
                comando += "'" + dat("ItemDescription").ToString + "',"
                comando += dat("Peso").ToString + ","
                comando += "'" + dat("TaraCod").ToString + "',"
                comando += "'" + dat("TaraNom").ToString + "',"
                comando += dat("TaraPeso").ToString + ","
                comando += "'" + dat("FechaRegistro").ToString + "',"
                ''comando += dat("FechaRegistro").ToString.Substring(3, 2) + "-"
                ''comando += dat("FechaRegistro").ToString.Substring(0, 2) + " "
                ''comando += dat("FechaRegistro").ToString.Substring(11, dat("FechaEntrada").ToString.Length - 11) + "',"
                'comando += "'" + fechaEntrada + "',"


                comando += dat("Impurezas").ToString + ","
                comando += "'" + dat("FreeTxt").ToString + "',"
                comando += "'" + dat("foto").ToString + "',"
                comando += "'" + dat("User").ToString + "',"
                comando += "'" + dat("EnvSCod").ToString + "',"
                comando += "'" + dat("EnvSNom").ToString + "',"
                comando += dat("EnvSPeso").ToString + ","
                comando += dat("PesoSal").ToString + ","
                comando += "'" + dat("FotoSal").ToString + "',"
                comando += "'" + dat("UserSalida").ToString + "',"
                comando += "'" + dat("FechaRegistroSal").ToString + "'"
                ''comando += dat("FechaRegistroSal").ToString.Substring(3, 2) + "-"
                ''comando += dat("FechaRegistroSal").ToString.Substring(0, 2) + " "
                ''comando += dat("FechaRegistroSal").ToString.Substring(11, dat("FechaEntrada").ToString.Length - 11) + "'"
                'comando += "'" + fechaSalida + "'"
                comando += ")"
                LineNum += 1
            Next
            'MessageBox.Show("det. " + comando)
            oDBnew.Conectar()
            LastInsertId = oDBnew.nonQuery(comando)
            oDBnew.Desconectar()
            If LastInsertId > 0 Then
                MessageBox.Show("Ticket centralizado OK " + LastInsertId.ToString)

            Else
                MessageBox.Show("No hubieron cambios en sección detalles.")
                Exit Sub
            End If



        Else
            MessageBox.Show("Error al insertar encabezado de Ticket N° " + tempId.ToString + ". Se interrumpe el proceso.")
            Exit Sub

        End If




    End Sub


    Private Sub rbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCompra.CheckedChanged
        If rbVenta.Checked = True Then
            txtBooking.Enabled = True
            txtBooking.ReadOnly = False
            txtPO.Enabled = True
            txtPO.ReadOnly = False
            lblSN.Text = "Cliente"
            lblPatente.Text = "Cont. Num."
            grpBoxEntrada.Text = "Tara"
            grpBoxSalida.Text = "Bruto"
        Else
            txtBooking.Enabled = False
            txtBooking.ReadOnly = True
            txtPO.Enabled = False
            txtPO.ReadOnly = True
            lblSN.Text = "Proveedor"
            lblPatente.Text = "Patente"
            grpBoxEntrada.Text = "Bruto"
            grpBoxSalida.Text = "Tara"
        End If
    End Sub

    Private Sub txtSNRUT_Leave(sender As Object, e As EventArgs) Handles txtSNRUT.Leave
        If txtSNRUT.Text = "" Then
            'btnProveedor_Click(sender, e)
        Else
            'buscar por RUT
            Dim oDB As New cDB
            Dim result As ArrayList
            Dim condicion As String

            If rbCompra.Checked Then
                condicion = "CardType='S'"
            Else
                condicion = "CardType='C'"
            End If
            oDB.conectar()
            result = oDB.query("SELECT CardCode,CardName,LicTradNum FROM OCRD WHERE LicTradNum='" & txtSNRUT.Text & "' AND " & condicion)
            oDB.desconectar()

            For Each dat As Dictionary(Of String, Object) In result
                txtSNNombre.Text = dat("CardName").ToString
                _CardCode = dat("CardCode").ToString
            Next


        End If
    End Sub

    'Private Sub txtChoferRUT_Leave(sender As Object, e As EventArgs) Handles txtChoferRUT.Leave
    '    If txtChoferRUT.Text = "" Then
    '        btnChofer_Click(sender, e)
    '    Else
    '        'buscar por RUT
    '    End If
    'End Sub

    'Private Sub txtTranspRUT_Leave(sender As Object, e As EventArgs) Handles txtTranspRUT.Leave
    '    If txtTranspRUT.Text = "" Then
    '        btnTransportista_Click(sender, e)
    '    Else
    '        'buscar por RUT
    '    End If
    'End Sub

    Private Sub txtItemCod_Leave(sender As Object, e As EventArgs) Handles txtItemCod.Leave
        If txtItemCod.Text = "" Then
            ' btnProveedor_Click(sender, e)
        Else
            'buscar por RUT
            Dim oDB As New cDB
            Dim result As ArrayList
            oDB.conectar()
            result = oDB.query("SELECT ItemCode,ItemName FROM OITM WHERE ItemCode='" & txtItemCod.Text & "'")
            oDB.desconectar()

            For Each dat As Dictionary(Of String, Object) In result
                txtItemName.Text = dat("ItemName").ToString
            Next
        End If
    End Sub

    Private Sub txtTaraCod_Leave(sender As Object, e As EventArgs) Handles txtTaraCod.Leave
        If txtTaraCod.Text = "" Then
            ' btnProveedor_Click(sender, e)
        Else
            'buscar por RUT
            Dim oDB As New cDB
            Dim result As ArrayList
            oDB.conectar()
            result = oDB.query("SELECT Cod,Descripcion,Peso FROM tEnvases WHERE Cod='" & txtTaraCod.Text & "'")
            oDB.desconectar()

            For Each dat As Dictionary(Of String, Object) In result
                txtTaraDescripcion.Text = dat("Descripcion").ToString
                txtTaraPeso.Text = dat("Peso").ToString
            Next
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'Dim reportviewer1 As New frmTicketViewer(CInt(txtTicketNum.Text), "ticketTermico")
        Try
            Dim reportviewer1 As New frmTicketViewer(CInt(txtTicketNum.Text), txtFolio.Text, "ticketCarta")
            'reportviewer1.MdiParent = Me.Parent
            reportviewer1.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        '   agregarPreliminar(5849, 4639)

        Dim ticketNum As Integer
        Dim respuesta As String
        respuesta = InputBox("Ingrese número de ticket a buscar: ", "Buscar ticket", "")
        If IsNumeric(respuesta) Then
            ticketNum = CInt(respuesta)
            'MessageBox.Show(ticketNum.ToString)
            Dim frmTicketViewer As New frmTicketViewer(ticketNum, txtFolio.Text, "ticketCarta")
            frmTicketViewer.Show()
        Else
            MessageBox.Show("Ingrese un número válido")
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If btnGuardar.Enabled = False OrElse MessageBox.Show("Existen pesajes parciales registrados, está seguro que desea limpiar el formulario?", "Advertencia", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ctrl As Control
            For Each ctrl In SplitContainer1.Panel2.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                    ctrl.Enabled = True
                ElseIf TypeOf ctrl Is Button Then
                    ctrl.Enabled = True
                End If
            Next
            txtBooking.Enabled = False
            txtBooking.ReadOnly = True
            txtPO.Enabled = False
            txtPO.ReadOnly = True
            lblSN.Text = "Proveedor"
            lblPatente.Text = "Patente"
            limpiaCamposDetalle()
            Panel1.Enabled = True


            dgvPesajes.Rows.Clear()
            _CardCode = ""
            tempId = Nothing
            btnGuardar.Enabled = False
            Me.frmPesaje_Load(sender, e)
        End If
    End Sub
    Private Function guardarEncabezado() As Integer

        Dim insert As String
        Dim fa As Integer
        Dim PPU, Booking, PO, CardCode, ChoferRut, TransportistaRUT, GuiaDespacho As String
        Dim FechaEntrada, FechaSalida, Observaciones, Usuario, Operacion, folio As String
        'Dim GW, NW, Tare As Double

        PPU = txtPPU.Text
        Booking = txtBooking.Text
        PO = txtPO.Text
        CardCode = _CardCode
        ChoferRut = txtChoferRUT.Text
        TransportistaRUT = txtTranspRUT.Text
        GuiaDespacho = txtGuia.Text
        FechaEntrada = txtIngreso.Text
        FechaSalida = txtSalida.Text
        Observaciones = txtObservacion.Text
        Usuario = user
        folio = txtFolio.Text
        If rbCompra.Checked = True Then
            Operacion = "E"
        Else
            Operacion = "S"
        End If

        insert = "INSERT INTO tTicket ( PPU, Booking, PO, CardCode, ChoferRUT, TransportistaRUT, "
        insert += "GuiaDespacho, FechaEntrada,  Observaciones, Usuario, Operacion, GW, NW, Tare,DocEntrySAP,FolioPref)"
        insert += "VALUES ('" & PPU & "','" & Booking & "','" & PO & "','" & CardCode & "','"
        insert += ChoferRut & "','" & TransportistaRUT & "','" & GuiaDespacho & "','" & FechaEntrada & "','"
        insert += Observaciones & "','" & Usuario & "','" & Operacion & "',0,0,0,0,'" & folio & "')"

        Dim oDB As New cDB
        oDB.conectar()
        fa = oDB.nonQuery(insert)
        oDB.desconectar()
        If fa > 0 Then
            tempId = oDB.lastInsertId
        End If
        Return fa

    End Function
    Private Function actualizaEncabezado(ByVal id As Integer) As Integer

        Dim insert As String
        Dim fa As Integer
        Dim PPU, Booking, PO, CardCode, ChoferRut, TransportistaRUT, GuiaDespacho As String
        Dim FechaEntrada, FechaSalida, Observaciones, Usuario, Operacion, folio As String
        'Dim GW, NW, Tare As Double

        PPU = txtPPU.Text
        Booking = txtBooking.Text
        PO = txtPO.Text
        CardCode = _CardCode
        ChoferRut = txtChoferRUT.Text
        TransportistaRUT = txtTranspRUT.Text
        GuiaDespacho = txtGuia.Text
        FechaEntrada = txtIngreso.Text
        FechaSalida = txtSalida.Text
        Observaciones = txtObservacion.Text
        Usuario = user
        folio = txtFolio.Text
        If rbCompra.Checked = True Then
            Operacion = "E"
        Else
            Operacion = "S"
        End If


        insert = "UPDATE tTicket SET PPU='" & PPU & "', Booking='" & Booking & "', PO='" & PO & "', CardCode='" & CardCode & "', ChoferRUT='" & ChoferRut & "', "
        insert += "TransportistaRUT='" & TransportistaRUT & "', GuiaDespacho='" & GuiaDespacho & "', Observaciones='" & Observaciones & "', Usuario='" & Usuario & "' "
        insert += "WHERE Id=" & id.ToString
        'Verbose
        'MessageBox.Show("Consulta:" & insert)

        Dim oDB As New cDB
        oDB.conectar()
        fa = oDB.nonQuery(insert)
        oDB.desconectar()
        Return fa
    End Function
    Private Sub guardarLineaEnDB(ByVal parent As Integer)
        Dim i As Integer
        Dim ItemCode, ItemDescription, TaraCod, TaraNom, timeStamp, FreeTxt, foto As String
        Dim Peso, TaraPeso, Impurezas As Double
        Dim insert As String

        i = dgvPesajes.RowCount - 2

        With dgvPesajes.Rows(i)
            ItemCode = .Cells(dataItemCode.Index).Value
            ItemDescription = .Cells(dataItemName.Index).Value
            Peso = .Cells(dataQuantity.Index).Value
            TaraPeso = .Cells(dataTarePeso.Index).Value
            TaraCod = .Cells(dataTareCod.Index).Value
            TaraNom = .Cells(dataTareNom.Index).Value
            Impurezas = .Cells(dataImpurezas.Index).Value
            timeStamp = .Cells(dataTimeStamp.Index).Value
            FreeTxt = .Cells(dataFreeTxt.Index).Value
            foto = .Cells(dataFoto.Index).Value
        End With
        insert = "INSERT INTO tTicketDetalle ([LineNum],[ItemCode],[ItemDescription],[Peso],[TaraCod],[TaraNom],[TaraPeso],[Impurezas],[FechaRegistro],[id],[FreeTxt],[foto],[User]) VALUES "
        insert += "(" & i.ToString & ",'" & ItemCode & "','" & ItemDescription & "'," & Peso.ToString & ",'" & TaraCod & "','" & TaraNom & "'," & TaraPeso.ToString & ","
        insert += Impurezas.ToString & ",'" & timeStamp & "'," & parent & ",'" & FreeTxt & "','" & foto & "','" & user & "');"

        Dim oDB As New cDB
        oDB.conectar()
        i = oDB.nonQuery(insert)
        oDB.desconectar()
        'If i > 0 Then
        '    setEnabled()
        'End If

    End Sub

    Private Sub actualizarLineaEnDB(ByVal parent As Integer, ByVal LineNum As Integer)
        Dim EnvSCod, EnvSNom, timeStamp, FreeTxt As String
        Dim EnvSPeso, PesoSal, Impurezas As Double
        Dim update As String
        Dim i As Integer


        With dgvPesajes.Rows(LineNum)


            timeStamp = .Cells(dataTimeStamp.Index).Value


            EnvSCod = .Cells(dataEnvSalCod.Index).Value
            EnvSNom = .Cells(dataEnvSalNom.Index).Value
            EnvSPeso = CDbl(.Cells(dataEnvSalPeso.Index).Value)
            Impurezas = CDbl(.Cells(dataImpurezas.Index).Value)
            FreeTxt = .Cells(dataFreeTxt.Index).Value
            PesoSal = CDbl(.Cells(dataPesoBrutoSalida.Index).Value)
            timeStamp = .Cells(dataTimeStampSal.Index).Value
        End With
        update = "UPDATE tTicketDetalle SET [EnvSCod]='" + EnvSCod + "',[EnvSNom] ='" + EnvSNom + "' ,[EnvSPeso]=" + EnvSPeso.ToString + ",[PesoSal]=" + PesoSal.ToString + ","
        update += "[Impurezas]=" + Impurezas.ToString + ",[FreeTxt]='" + FreeTxt + "',[UserSalida]='" + user + "',[FechaRegistroSal]='" + timeStamp + "' "
        update += "WHERE id=" + parent.ToString + " AND LineNum=" + LineNum.ToString


        Dim oDB As New cDB
        oDB.conectar()
        i = oDB.nonQuery(update)
        oDB.desconectar()
        'If i > 0 Then
        '    setEnabled()
        'End If

    End Sub
    '' This delegate enables asynchronous calls for setting
    '' the text property on a TextBox control.
    'Delegate Sub setEnabledCallBack()
    'Private Sub setEnabled()

    '    ' InvokeRequired required compares the thread ID of the
    '    ' calling thread to the thread ID of the creating thread.
    '    ' If these threads are different, it returns true.
    '    If Me.SplitContainer1.Panel1.InvokeRequired Then
    '        Dim d As New setEnabledCallBack(AddressOf setEnabled)
    '        Me.Invoke(d)
    '    Else
    '        Me.SplitContainer1.Panel1.Enabled = True
    '        cargaPanelPesajesPendientes()
    '    End If
    'End Sub

    Private Sub cargaPanelPesajesPendientes()
        Dim ancho, top, left As Integer
        Dim oDB As New cDB
        Dim pendientes As ArrayList

        SplitContainer1.Panel1.Controls.Clear()
        ancho = SplitContainer1.Panel1.Width - 10
        oDB.conectar()
        pendientes = oDB.query("SELECT t.id, sn.CardName, t.PPU FROM tTicket t INNER JOIN OCRD sn ON t.CardCode=sn.CardCode WHERE TicketNum IS NULL")
        oDB.desconectar()


        If pendientes.Count > 0 Then
            left = 5
            top += 10
            For Each dat As Dictionary(Of String, Object) In pendientes
                Dim btn As New Button
                Dim id As Integer
                Dim nombre As String
                id = CInt(dat("id").ToString())
                nombre = dat("PPU").ToString + " - " + dat("CardName").ToString
                btn.Name = "Btn" & id.ToString
                btn.Height = 60
                btn.Width = ancho
                btn.Text = id.ToString & ": " & nombre
                btn.TextAlign = ContentAlignment.MiddleLeft
                btn.Enabled = True
                btn.Top = top
                top += 65
                btn.Left = left
                btn.FlatStyle = FlatStyle.Flat
                btn.BackColor = DefaultBackColor
                AddHandler btn.Click, AddressOf cargaForm
                SplitContainer1.Panel1.Controls.Add(btn)
            Next
        End If

    End Sub

    Private Sub cargaForm(sender As Object, e As EventArgs)
        Dim btn As Button
        Dim id As Integer
        Dim flag As Boolean = True
        btnLimpiar_Click(sender, e)
        btn = sender
        id = btn.Text.Substring(0, btn.Text.IndexOf(":"))
        'MessageBox.Show(id.ToString)
        For Each boton As Object In SplitContainer1.Panel1.Controls
            If TypeOf boton Is Button Then
                boton.BackColor = DefaultBackColor
            End If
        Next
        btn.BackColor = Color.Green

        Dim oDB As New cDB
        Dim result As ArrayList
        oDB.conectar()
        result = oDB.query("SELECT * FROM qTicket WHERE id=" & id.ToString)
        oDB.desconectar()
        txtTicketNum.Text = ""
        For Each dat As Dictionary(Of String, Object) In result
            If flag Then
                tempId = id
                txtPPU.Text = dat("PPU").ToString
                txtSNRUT.Text = dat("LicTradNum").ToString
                txtSNNombre.Text = dat("CardName").ToString
                _CardCode = dat("CardCode").ToString
                If dat("Operacion").ToString = "E" Then
                    rbCompra.Checked = True
                    rbVenta.Checked = False
                Else
                    rbCompra.Checked = False
                    rbVenta.Checked = True
                End If
                Panel1.Enabled = False
                txtChoferRUT.Text = dat("ChoferRUT").ToString
                txtChoferNombre.Text = dat("ChoferNom").ToString
                txtTranspRUT.Text = dat("TransportistaRUT").ToString
                txtTranspNombre.Text = dat("TransportistaNom").ToString
                txtGuia.Text = dat("GuiaDespacho").ToString
                txtObservacion.Text = dat("Observaciones").ToString
                txtIngreso.Text = dat("FechaEntrada").ToString
                txtSalida.Text = dat("FechaSalida").ToString
                txtPO.Text = dat("PO").ToString
                txtBooking.Text = dat("Booking").ToString
                dgvPesajes.Rows.Clear()
                flag = False
            End If

            If IsNumeric(dat("LineNum").ToString) Then


                Dim nuevaLinea As DataGridViewRow = dgvPesajes.Rows(dgvPesajes.NewRowIndex).Clone

                With nuevaLinea
                    .Cells(dataNum.Index).Value = dat("LineNum").ToString
                    .Cells(dataItemCode.Index).Value = dat("ItemCode").ToString
                    .Cells(dataItemName.Index).Value = dat("ItemDescription").ToString
                    .Cells(dataQuantity.Index).Value = dat("Peso").ToString
                    .Cells(dataTarePeso.Index).Value = dat("TaraPeso").ToString
                    .Cells(dataTareCod.Index).Value = dat("TaraCod").ToString
                    .Cells(dataTareNom.Index).Value = dat("TaraNom").ToString
                    .Cells(dataImpurezas.Index).Value = dat("Impurezas").ToString
                    .Cells(dataTotal.Index).Value = CInt(dat("Peso").ToString) - CInt(dat("TaraPeso").ToString) - CInt(dat("Impurezas").ToString) - CInt(dat("PesoSal").ToString) + CInt(dat("EnvSPeso").ToString)
                    .Cells(dataTimeStamp.Index).Value = dat("FechaRegistro").ToString
                    .Cells(dataFoto.Index).Value = dat("foto").ToString
                    .Cells(dataEnvSalCod.Index).Value = dat("EnvSCod").ToString
                    .Cells(dataEnvSalNom.Index).Value = dat("EnvSNom").ToString
                    .Cells(dataEnvSalPeso.Index).Value = dat("EnvSPeso").ToString
                    .Cells(dataPesoBrutoSalida.Index).Value = dat("PesoSal").ToString
                    .Cells(dataFotoSal.Index).Value = dat("FotoSal").ToString

                End With

                dgvPesajes.Rows.Add(nuevaLinea)

            Else
                MessageBox.Show("sin detalle")
            End If

        Next
        limpiaCamposDetalle()

    End Sub

    Private Sub dgvPesajes_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPesajes.RowHeaderMouseDoubleClick
        'MessageBox.Show(e.RowIndex.ToString)
        Dim row As Integer
        row = e.RowIndex
        If dgvPesajes.Rows(row).Cells(dataNum.Index).Value > 0 Then
            txtLineId.Text = row
            With dgvPesajes.Rows(row)
                txtItemCod.Text = .Cells(dataItemCode.Index).Value
                txtItemName.Text = .Cells(dataItemName.Index).Value
                txtTaraCod.Text = .Cells(dataTareCod.Index).Value
                txtTaraDescripcion.Text = .Cells(dataTareNom.Index).Value
                txtTaraPeso.Text = .Cells(dataTarePeso.Index).Value
                txtPeso.Text = .Cells(dataQuantity.Index).Value
            End With

            txtImpurezas.Enabled = True
            txtEnvSalidaCod.Enabled = True
            txtFreeTxt.Enabled = True

        Else
            MessageBox.Show("Debe seleccionar una fila válida.")
        End If
    End Sub

    Private Sub btnEnvSalida_Click(sender As Object, e As EventArgs) Handles btnEnvSalida.Click
        Dim frmMaestro As New frmEnvases
        frmMaestro.origen = "EnvasesSal"
        frmMaestro.mostrar(Me)
        Try
            frmMaestro.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub limpiaCamposDetalle()
        txtTaraCod.Text = ""
        txtTaraDescripcion.Text = ""
        txtTaraPeso.Text = ""
        txtItemCod.Text = ""
        txtItemName.Text = ""
        txtPeso.Text = ""
        txtLineId.Text = ""

        txtImpurezas.Text = ""
        txtFreeTxt.Text = ""
        txtEnvSalidaCod.Text = ""
        txtEnvSalidaNom.Text = ""
        txtEnvSalidaPeso.Text = ""
        txtPesoSalida.Text = ""


    End Sub

    Private Sub txtChoferRUT_Leave(sender As Object, e As EventArgs) Handles txtChoferRUT.Leave
        If txtChoferRUT.Text = "" Then
            ' btnProveedor_Click(sender, e)
        Else
            'buscar por RUT
            Dim oDB As New cDB
            Dim result As ArrayList

            oDB.conectar()
            result = oDB.query("SELECT ChoferRUT,ChoferNom FROM tChofer WHERE ChoferRUT='" & txtChoferRUT.Text & "'")
            oDB.desconectar()

            For Each dat As Dictionary(Of String, Object) In result
                txtChoferNombre.Text = dat("ChoferNom").ToString
            Next
        End If
    End Sub

    Private Sub txtTranspRUT_Leave(sender As Object, e As EventArgs) Handles txtTranspRUT.Leave
        If txtTranspRUT.Text = "" Then
            ' btnProveedor_Click(sender, e)
        Else
            'buscar por RUT
            Dim oDB As New cDB
            Dim result As ArrayList

            oDB.conectar()
            result = oDB.query("SELECT TransportistaRUT,TransportistaNom FROM tTransportista WHERE TransportistaRUT='" & txtTranspRUT.Text & "'")
            oDB.desconectar()

            For Each dat As Dictionary(Of String, Object) In result
                txtTranspNombre.Text = dat("TransportistaNom").ToString
            Next
        End If
    End Sub

    Private Sub agregarPreliminar(ByVal id As Integer, ByVal ticketNum As Integer)


        Dim oDB As New cDB
        Dim result As ArrayList
        Dim flag As Boolean = True
        Dim almacen As String
        Dim Query As String
        Dim neto As Double
        Dim itemCode As String
        Dim dockey As Integer

        Query = "SELECT te.Id, te.PPU, te.CardCode, te.ChoferRUT, c.ChoferNom, te.TransportistaRUT, t.TransportistaNom, "
        Query += "te.GuiaDespacho,te.Observaciones, te.Usuario, te.Operacion, te.DocEntrySAP, te.FolioPref, td.ItemCode, "
        Query += "SUM(td.Peso) AS Peso, SUM(td.TaraPeso) AS TaraPeso, SUM(td.Impurezas) AS Impurezas, SUM(td.EnvSPeso) AS EnvSPeso, "
        Query += "SUM(td.PesoSal) AS PesoSal, td.UserSalida FROM qTicket WHERE id = " + id.ToString
        Query += " Group By  te.Id, te.PPU, te.CardCode, te.ChoferRUT, c.ChoferNom, te.TransportistaRUT, t.TransportistaNom, "
        Query += "te.GuiaDespacho,te.Observaciones, te.Usuario, te.Operacion, te.DocEntrySAP, te.FolioPref, td.ItemCode, td.UserSalida "

        oDB.conectar()
        result = oDB.query(Query)
        oDB.desconectar()


        Dim oDraftInvoice As New cDraftInvoice

        almacen = ListaParametro(6).ToString.ToUpper

        For Each dat As Dictionary(Of String, Object) In result
            neto = CInt(dat("Peso").ToString) - CInt(dat("TaraPeso").ToString) - CInt(dat("Impurezas").ToString) - CInt(dat("PesoSal").ToString) + CInt(dat("EnvSPeso").ToString)
            itemCode = dat("ItemCode").ToString
            With oDraftInvoice
                If flag Then
                    .PPU = dat("PPU").ToString
                    .CardCode = dat("CardCode").ToString
                    .RUTChofer = dat("ChoferRUT").ToString
                    .NombreChofer = dat("ChoferNom").ToString
                    .RUTTransporte = dat("TransportistaRUT").ToString
                    .NombreTransporte = dat("TransportistaNom").ToString
                    .Comments = dat("Observaciones").ToString
                    'txtGuia.Text = dat("GuiaDespacho").ToString
                    .DocDate = Now
                    .DueDate = Now
                    .TicketPref = dat("FolioPref").ToString
                    .TicketNum = ticketNum
                    .agregaItem(almacen, itemCode, neto, .TicketPref, ticketNum)
                    flag = False
                Else

                    neto = CInt(dat("Peso").ToString) - CInt(dat("TaraPeso").ToString) - CInt(dat("Impurezas").ToString) - CInt(dat("PesoSal").ToString) + CInt(dat("EnvSPeso").ToString)
                    .agregaItem(almacen, itemCode, neto, "", 0)

                End If


            End With


            

        Next


        dockey = oDraftInvoice.sync()
        MessageBox.Show("DocKey: " & dockey.ToString)

    End Sub
End Class



