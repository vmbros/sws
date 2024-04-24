'Imports SAPbouiCOM
Imports SAPbobsCOM

Public Class cDraftInvoice
    Public WithEvents SBO_Application As SAPbouiCOM.Application
    Public oCompany As SAPbobsCOM.Company
    'Private WithEvents SBO_Application As SAPbouiCOM.Application
    Dim Catalogo As String
    Dim _CardCode As String = ""
    Dim _Comments As String = ""
    Dim _JournalMemo As String = ""
    Dim _TicketPref As String = ""
    Dim _TicketNum As String = ""
    Dim _Viaje As String = ""
    Dim _Booking As String = ""
    Dim _Despachador As String = ""
    Dim _TipoCont As String = ""
    Dim _MedidaCont As String = ""
    Dim _FreeTxt As String = ""
    Dim _CondEmb As String = ""
    Dim _DUS As String = ""
    Dim _PrecioFlete As String = ""




    Dim _DueDate, _DocDate As Date
    Dim _ItemCode, _Contenedor, _Sello As String
    Dim _Quantity As Double
    Dim _BaseEntry, _BaseLine As Integer
    Dim _BaseType As Integer = 17
    Dim _Gw, _Nw, _Tare As String
    Dim _RUTdvr, _NombreDvr, _PPU, _PPURampla, _RUTTransporte, _NombreTransporte As String
    Dim _txtLoose, _txtBriquette As String
    Dim oDetail As New List(Of cDraftInvoiceDetail)


    Public Property Series As Integer = 63
    Public Property CardCode As String
        Get
            Return _CardCode
        End Get
        Set(ByVal value As String)
            _CardCode = value
        End Set
    End Property
    Public Property DueDate As Date
        Get
            Return _DueDate
        End Get
        Set(ByVal value As Date)
            _DueDate = value
        End Set
    End Property
    Public Property DocDate As Date
        Get
            Return _DocDate
        End Get
        Set(ByVal value As Date)
            _DocDate = value
        End Set
    End Property

    Public Property Comments As String
        Get
            Return _Comments
        End Get
        Set(ByVal value As String)
            If value.Length > 250 Then
                _Comments = value.Substring(0, 249)
            Else
                _Comments = value.ToString
            End If

        End Set
    End Property
    Public Property JournalMemo As String
        Get
            Return _JournalMemo
        End Get
        Set(ByVal value As String)
            _JournalMemo = value
        End Set
    End Property
    Public Property TicketPref As String   'Prefijo del ticket
        Get
            Return _TicketPref
        End Get
        Set(ByVal value As String)
            If value.Length > 10 Then
                _TicketPref = value.Substring(0, 10)
            Else
                _TicketPref = value.ToString
            End If

        End Set
    End Property
    Public Property TicketNum As Integer      'Nro de Ticket
        Get
            Return _TicketNum
        End Get
        Set(ByVal value As Integer)
            _TicketNum = value
        End Set
    End Property
    Public Property Viaje As String     'Viaje
        Get
            Return _Viaje
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Viaje = value.Substring(0, 20)
            Else
                _Viaje = value.ToString
            End If
        End Set
    End Property
    Public Property Booking As String    'Booking
        Get
            Return _Booking
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Booking = value.Substring(0, 20)
            Else
                _Booking = value.ToString
            End If
        End Set
    End Property
    Public Property Despachador As String 'Despachador
        Get
            Return _Despachador
        End Get
        Set(ByVal value As String)
            If value.Length > 100 Then
                _Despachador = value.Substring(0, 100)
            Else
                _Despachador = value
            End If
        End Set
    End Property
    Public Property TipoCont As String 'Tipo Contened
        Get
            Return _TipoCont
        End Get
        Set(ByVal value As String)
            If value.Length > 10 Then
                _TipoCont = value.Substring(0, 10)
            Else
                _TipoCont = value
            End If
        End Set
    End Property
    Public Property MedidaCont As String 'Tipo Contened
        Get
            Return _MedidaCont
        End Get
        Set(ByVal value As String)
            If value.Length > 10 Then
                _MedidaCont = value.Substring(0, 10)
            Else
                _MedidaCont = value
            End If
        End Set
    End Property
    Public Property ItemCode As String
        Get
            Return _ItemCode
        End Get
        Set(ByVal value As String)
            _ItemCode = value
        End Set
    End Property
    Public Property Quantity As Double
        Get
            Return _Quantity
        End Get
        Set(ByVal value As Double)
            _Quantity = value
        End Set
    End Property
    Public Property Contenedor As String
        Get
            Return _Contenedor
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Contenedor = value.Substring(0, 20)
            Else
                _Contenedor = value
            End If
        End Set
    End Property
    Public Property Sello As String
        Get
            Return _Sello
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Sello = value.Substring(0, 20)
            Else
                _Sello = value
            End If
        End Set
    End Property
    Public Property BaseEntry As Integer
        Get
            Return _BaseEntry
        End Get
        Set(ByVal value As Integer)
            _BaseEntry = value
        End Set
    End Property
    Public Property BaseLine As Integer
        Get
            Return _BaseLine
        End Get
        Set(ByVal value As Integer)
            _BaseLine = value
        End Set
    End Property
    Public Property BaseType As Integer
        Get
            Return _BaseType
        End Get
        Set(ByVal value As Integer)
            _BaseType = value
        End Set
    End Property
    Public Property FreeTxt As String
        Get
            Return _FreeTxt
        End Get
        Set(ByVal value As String)
            If value.Length > 100 Then
                _FreeTxt = value.Substring(0, 100)
            Else
                _FreeTxt = value
            End If
        End Set
    End Property
    Public Property GW As String
        Get
            Return _gw
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Gw = value.Substring(0, 20)
            Else
                _Gw = value
            End If
        End Set
    End Property
    Public Property NW As String
        Get
            Return _nw
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Nw = value.Substring(0, 20)
            Else
                _Nw = value
            End If
        End Set
    End Property
    Public Property Tare As String
        Get
            Return _tare
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _Tare = value.Substring(0, 20)
            Else
                _Tare = value
            End If
        End Set
    End Property
    Public Property CondEmb As String
        Get
            Return _CondEmb
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _CondEmb = value.Substring(0, 20)
            Else
                _CondEmb = value
            End If
        End Set
    End Property
    Public Property DUS As String
        Get
            Return _DUS
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _DUS = value.Substring(0, 20)
            Else
                _DUS = value
            End If
        End Set
    End Property
    Public Property RUTChofer As String
        Get
            Return _RUTdvr
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _RUTdvr = value.Substring(0, 20)
            Else
                _RUTdvr = value
            End If
        End Set
    End Property
    Public Property NombreChofer As String
        Get
            Return _NombreDvr
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _NombreDvr = value.Substring(0, 20)
            Else
                _NombreDvr = value
            End If
        End Set
    End Property
    Public Property PPU As String
        Get
            Return _PPU
        End Get
        Set(ByVal value As String)
            _PPU = value
        End Set
    End Property
    Public Property PPURampla As String
        Get
            Return _PPURampla
        End Get
        Set(ByVal value As String)
            _PPURampla = value
        End Set
    End Property
    Public Property TxtLoose As String
        Get
            Return _txtLoose
        End Get
        Set(ByVal value As String)
            If value.Length > 50 Then
                _txtLoose = value.Substring(0, 50)
            Else
                _txtLoose = value
            End If
        End Set
    End Property
    Public Property TxtBriquette As String
        Get
            Return _txtBriquette
        End Get
        Set(ByVal value As String)
            If value.Length > 50 Then
                _txtBriquette = value.Substring(0, 50)
            Else
                _txtBriquette = value
            End If
        End Set
    End Property
    Public Property RUTTransporte As String
        Get
            Return _RUTTransporte
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _RUTTransporte = value.Substring(0, 20)
            Else
                _RUTTransporte = value
            End If
        End Set
    End Property
    Public Property NombreTransporte As String
        Get
            Return _NombreTransporte
        End Get
        Set(ByVal value As String)
            If value.Length > 100 Then
                _NombreTransporte = value.Substring(0, 100)
            Else
                _NombreTransporte = value
            End If
        End Set
    End Property


    Public Property PrecioFlete As String
        Get
            Return _PrecioFlete
        End Get
        Set(ByVal value As String)
            If value.Length > 20 Then
                _PrecioFlete = value.Substring(0, 20)
            Else
                _PrecioFlete = value
            End If
        End Set
    End Property

    Public Sub agregaItem(ByVal almacen As String, ByVal itemcode As String, ByVal kg As Double, ByVal ticketPref As String, ByVal ticketNum As Integer)
        oDetail.Add(New cDraftInvoiceDetail(almacen, itemcode, kg, ticketPref, ticketNum))
    End Sub
    Public Function sync() As Integer


        'Dim oCompany As SAPbobsCOM.Company
        Dim lRetCode, lErrCode As Long
        Dim sErrMsg As String

        '------------------------------------------------------------------------------------------
        Dim SboGuiApi As SAPbouiCOM.SboGuiApi
        Dim sConnectionString As String

        SboGuiApi = New SAPbouiCOM.SboGuiApi()

        '// by following the steps specified above, the following
        '// statment should be suficient for either development or run mode

        'sConnectionString = Environment.GetCommandLineArgs(1)
        sConnectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056"

        '// connect to a running SBO Application
        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object
        'SBO_Application = SboGuiApi.GetApplication()
        'Catalogo = SBO_Application.Company.DatabaseName
        Catalogo = "Recmetal" ' RECMETAL_2015
        '------------------------------------------------------------------------------------------




        'Instantiate a Company object
        oCompany = New SAPbobsCOM.Company
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2017 'Tipo de BD
        oCompany.Server = "RCMTL-SBO"
        oCompany.CompanyDB = "Recmetal" ' RECMETAL_2015
        oCompany.UserName = "manager"
        oCompany.Password = "admin"
        oCompany.language = BoSuppLangs.ln_Spanish_La
        oCompany.UseTrusted = False

        lRetCode = oCompany.Connect()
        'Check Return Code
        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
        End If



        Dim oDraftInvoice As SAPbobsCOM.Documents

        oDraftInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oDrafts)
        oDraftInvoice.DocObjectCode = BoObjectTypes.oPurchaseInvoices

        ' set the business partner code
        oDraftInvoice.CardCode = _CardCode
        ' set the documents due date - mandatory
        oDraftInvoice.DocDueDate = _DueDate
        oDraftInvoice.Series = _Series
        oDraftInvoice.Comments = _Comments
        oDraftInvoice.JournalMemo = _JournalMemo
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC01").Value = _TicketPref     'Destino
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC02").Value = _TicketNum       'Nave
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC03").Value = _Viaje      'Viaje
        ' oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC04").Value = _Booking     'Booking
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC06").Value = _RUTdvr      'RUT Chofer
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC05").Value = _NombreDvr     'Nombre Chofer
        If _PPU.Length < 1 Then _PPU = ""
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC07").Value = _PPU          'PPU Camión
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC08").Value = _PPURampla     'PPU Rampla
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC09").Value = _CondEmb     'Condiciones de embarque (INCOTERMS)
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC12").Value = _Despachador      'Despachador
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC13").Value = _TipoCont + " " + _MedidaCont  'Tipo Contenedor
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC14").Value = _txtBriquette    'Texto Briquetas
        'oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC17").Value = _txtLoose    'Texto Loose
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC22").Value = _RUTTransporte    'RUT Transportista
        oDraftInvoice.UserFields.Fields.Item("U_FLEX_ENC23").Value = _NombreTransporte    'Nombre Transportista
        'oDraftInvoice.UserFields.Fields.Item("U_DUS").Value = _DUS      'N° de DUS

        ''
        ' First line (no need to add line)
        Dim contador As Integer = 0
        For Each detalle As cDraftInvoiceDetail In oDetail
            If contador > 0 Then
                oDraftInvoice.Lines.Add()
            End If
            oDraftInvoice.Lines.ItemCode = detalle._ItemCode
            oDraftInvoice.Lines.Quantity = detalle._kg
            oDraftInvoice.Lines.TaxLiable = BoYesNoEnum.tYES
            If detalle._TicketPref.Length > 1 Then
                oDraftInvoice.Lines.UserFields.Fields.Item("U_TicketPref").Value = detalle._TicketPref
            End If
            If detalle._TicketNum > 0 Then
                oDraftInvoice.Lines.UserFields.Fields.Item("U_TicketNum").Value = detalle._TicketNum
            End If
            oDraftInvoice.Lines.WarehouseCode = detalle._almacen
            oDraftInvoice.Lines.WTLiable = BoYesNoEnum.tYES
            oDraftInvoice.Lines.TaxCode = detalle.TaxCode
            contador += 1

        Next



        ''-------------- REF --------------------------
        'oDeliveryDoc.Lines.BaseEntry = 543
        'oDeliveryDoc.Lines.BaseLine = 0 'Copy first line
        'oDeliveryDoc.Lines.BaseType = 17 '
        ''-------------- /REF --------------------------


        ' Adding the new order document
        Dim RetVal As Long
        Dim DocKey As Integer
        ' Add Order to the database
        RetVal = oDraftInvoice.Add()
        ' Check if Add method succeeded
        If RetVal <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MessageBox.Show(lErrCode & " " & sErrMsg & ";  Code: " & lErrCode)
            DocKey = 0
        Else
            'MsgBox("Entrega N° " & oCompany.GetNewObjectKey & " creada.")
            DocKey = CInt(oCompany.GetNewObjectKey)

        End If

        ' txtDocNum.Text = oCompany.GetNewObjectKey

        If oCompany.Connected = True Then
            oCompany.Disconnect()
        End If

        Return DocKey

    End Function

    Public Sub SetApplication()

        '*******************************************************************
        '// Use an SboGuiApi object to establish the connection
        '// with the application and return an initialized appliction object
        '*******************************************************************

        Dim SboGuiApi As SAPbobsCOM.SBObob
        Dim sConnectionString As String

        SboGuiApi = New SAPbobsCOM.SBObob

        '// by following the steps specified above, the following
        '// statment should be suficient for either development or run mode

        'sConnectionString = Environment.GetCommandLineArgs(1)
        sConnectionString = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056"

        '// connect to a running SBO Application
        SboGuiApi.Connect(sConnectionString)

        '// get an initialized application object
        'SBO_Application = SboGuiApi.GetApplication()
        'Catalogo = SBO_Application.Company.DatabaseName
        Catalogo = "Recmetal" ' RECMETAL_2015
    End Sub

End Class
