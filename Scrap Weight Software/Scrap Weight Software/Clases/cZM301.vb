
Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text


Public Class cZM301
    Private _IP As String
    Private _port As Integer
    Public Sub New(ByVal IPAddress As String, ByVal Port As Integer)
        _IP = IPAddress
        _port = Port
    End Sub
    Public Function getPeso() As Integer
        Dim bytes(1024) As Byte
        Dim strResult As String
        Dim peso As Integer
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
        Dim msg As Byte() = Encoding.ASCII.GetBytes("W" & vbCr)

        Dim bytesSent As Integer = sender.Send(msg)

        ' Receive the response from the remote device.
        Dim bytesRec As Integer = sender.Receive(bytes)
        strResult = Encoding.ASCII.GetString(bytes, 0, bytesRec)





        ' Release the socket.
        sender.Shutdown(SocketShutdown.Both)
        sender.Close()


        strResult = strResult.Substring(1, 8)
        If IsNumeric(strResult) Then
            peso = CInt(strResult)
        Else
            peso = -1
        End If


        Return peso


    End Function

End Class
