Imports CrystalDecisions.Shared
Public Class frmTicketViewer
    Dim ticketnum As Integer
    Dim folioPref As String = ""
    Dim _reporte As String
    Public Property fReporte As String
    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As New Negocio()
        Dim ListaParametro As ArrayList
        ListaParametro = n.recorrerArchivo()

        _reporte = ListaParametro(0).ToString()
        If fReporte = "ticketDetalle" Then
            _reporte = "ticketDetalle"
        End If



        If IsNumeric(ticketnum) Then
            If _reporte = "ticketDetalle" Then
                Dim report As New rptTicketDetalle
                report.DataSourceConnections.Item(0).SetLogon("Admin", "PV3ra.2012")
                report.SetParameterValue("TicketNum", ticketnum)
                CrystalReportViewer1.ReportSource = report
            ElseIf _reporte = "ticketTermico" Then
                'Dim report As New rptTicketPesajeParciales
                Dim report As New rptTicketTermico
                report.DataSourceConnections.Item(0).SetLogon("Admin", "PV3ra.2012")
                report.SetParameterValue("@TicketNum", ticketnum)
                CrystalReportViewer1.ReportSource = report
            Else
                Dim report As New rptTicketCarta
                report.DataSourceConnections.Item(0).SetLogon("Admin", "PV3ra.2012")
                report.SetParameterValue("@TicketNum", ticketnum)
                CrystalReportViewer1.ReportSource = report

            End If

            'Comentar si se trabaja sin conexion
            'If Not IO.File.Exists("\\192.168.0.102\Anexos\Ticket\" & folioPref & ticketnum.ToString & ".pdf") Then
            '    Try
            '        Dim reportDetalle As New rptTicketDetalle
            '        reportDetalle.DataSourceConnections.Item(0).SetLogon("Admin", "PV3ra.2012")
            '        reportDetalle.SetParameterValue("TicketNum", ticketnum)
            '        Dim CrExportOptions As ExportOptions
            '        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            '        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
            '        CrDiskFileDestinationOptions.DiskFileName = "\\192.168.0.102\Anexos\Ticket\" & folioPref & ticketnum.ToString & ".pdf"
            '        CrExportOptions = reportDetalle.ExportOptions
            '        With CrExportOptions
            '            .ExportDestinationType = ExportDestinationType.DiskFile
            '            .ExportFormatType = ExportFormatType.PortableDocFormat
            '            .DestinationOptions = CrDiskFileDestinationOptions
            '            .FormatOptions = CrFormatTypeOptions
            '        End With
            '        reportDetalle.Export()
            '    Catch ex As Exception
            '        MessageBox.Show(ex.ToString)
            '    End Try
            'End If

        End If
    End Sub
    Public Sub New(ByVal ticket As Integer, ByVal FolPref As String, ByVal reporte As String)
        ticketnum = ticket
        folioPref = FolPref
        _reporte = reporte
        InitializeComponent()
    End Sub
End Class