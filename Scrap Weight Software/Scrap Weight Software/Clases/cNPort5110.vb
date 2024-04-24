Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Public Class cNPort5110
    Private _IP As String
    Private _port As Integer
    Public Sub New(ByVal IPAddress As String, ByVal Port As Integer)
        _IP = IPAddress
        _port = Port
    End Sub
    Public Function getPeso() As Double
        Dim bytes(1024) As Byte
        Dim strResult As String
        Dim peso As Double
        'Para obtener el peso se utiliza el comando "W"
        ' Connect to a remote device.

        ' Establish the remote endpoint for the socket.
        ' This example uses port 11000 on the local computer.
        'Dim ipHostInfo As IPHostEntry = ipAddress.Parse("192.168.0.121")
        ' Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP As New IPEndPoint(IPAddress.Parse(_IP), _port)

        ' Create a TCP/IP socket.
        Dim sender As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        ' Connect the socket to the remote endpoint.
        sender.Connect(remoteEP)

        ' MessageBox.Show("Socket connected to {0}", sender.RemoteEndPoint.ToString())

        ' Encode the data string into a byte array.
        Dim msg As Byte() = Encoding.ASCII.GetBytes("SI" & vbCr & vbLf)

        Dim bytesSent As Integer = sender.Send(msg)

        ' Receive the response from the remote device.
        'Dim bytesRec As Integer = sender.Receive(bytes)
        Threading.Thread.Sleep(200)

        Dim bytesRec As Integer = sender.Receive(bytes, 24, SocketFlags.None)


        strResult = Encoding.ASCII.GetString(bytes, 0, bytesRec)


        strResult = strResult.Substring(strResult.IndexOf(ChrW(2)) + 1, 7) 'Se extrae el sub string desde el ASCII 2 con un largo de 7: signo + 6 dígitos

        ' Release the socket.
        sender.Shutdown(SocketShutdown.Both)
        sender.Close()


        If IsNumeric(strResult) Then
            strResult = LTrim(strResult)
            strResult = strResult.Replace(".", ",")
            peso = CDbl(strResult)
        Else
            peso = -1
        End If


        Return peso


    End Function
End Class
