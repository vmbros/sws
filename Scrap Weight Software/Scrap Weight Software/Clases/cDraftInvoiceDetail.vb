Public Class cDraftInvoiceDetail
    Public _kg As Double
    Public _almacen As String
    Public _ItemCode As String
    Public _TicketPref As String
    Public _TicketNum As Integer
    Public TaxCode As String = "IVA"
    Public WtLiable As String = "Y"
    Public Sub New(ByVal almacen As String, ByVal itemcode As String, ByVal kg As Double, ByVal ticketPref As String, ByVal ticketNum As Integer)
        _almacen = almacen
        _kg = kg
        _ItemCode = itemcode
        If Not IsNothing(ticketPref) Then
            _TicketPref = ticketPref
        End If
        If ticketNum > 0 Then
            _TicketNum = ticketNum
        Else
            _TicketNum = Nothing
        End If

    End Sub

    Public Property kg As Double
        Get
            Return _kg
        End Get
        Set(value As Double)
            _kg = kg
        End Set
    End Property


End Class
