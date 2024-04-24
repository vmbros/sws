Public Class frmComPort

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ReceiveSerialData("COM1", "4800")
        TextBox2.Text = TextBox1.Text.Length
    End Sub

    Public Function ReceiveSerialData(ByVal Puerto As String, ByVal baud As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            com1 = My.Computer.Ports.OpenSerialPort(Puerto)
            com1.BaudRate = baud
            'com1.Parity = IO.Ports.Parity.None
            'com1.DataBits = 8
            'com1.StopBits = IO.Ports.StopBits.One

            com1.ReadTimeout = 10000
            Do
                Dim Incoming As String = com1.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return returnStr
    End Function
End Class