Public Class frmVisor
    Dim opcion As String

    Public Property op As String



    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click


        If op = "producto" Then
            Dim report As New rptInformeComprasFecha
            Dim fechaIni, fechaFin As Date

            fechaIni = dtpIni.Value.Date
            fechaFin = dtpFin.Value.Date


            report.SetParameterValue("@FechaIni", fechaIni)
            report.SetParameterValue("@FechaFin", fechaFin)
            crv1.ReportSource = report
        ElseIf op = "productoResumen" Then
            Dim report As New rptInformeComprasFechaResumen
            Dim fechaIni, fechaFin As Date

            fechaIni = dtpIni.Value.Date
            fechaFin = dtpFin.Value.Date


            report.SetParameterValue("@FechaIni", fechaIni)
            report.SetParameterValue("@FechaFin", fechaFin)
            crv1.ReportSource = report
        Else
            Dim report As New rptInformeComprasProveedor
            Dim fechaIni, fechaFin As Date

            fechaIni = dtpIni.Value.Date
            fechaFin = dtpFin.Value.Date


            report.SetParameterValue("@FechaIni", fechaIni)
            report.SetParameterValue("@FechaFin", fechaFin)
            crv1.ReportSource = report

        End If
        
    End Sub

    Private Sub frmVisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class