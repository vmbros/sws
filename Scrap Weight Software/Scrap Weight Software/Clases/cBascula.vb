
Imports System.IO.Ports
Public Class cBascula
    Dim com As SerialPort
    Public Property PortName As String
    Public Property BaudRate As String

    'Public Function CapturarPeso() As Integer
    '    'Dim com As New SerialPort
    '    Dim result As String = ""
    '    Dim peso As Integer = 0
    '    com = New SerialPort
    '    com.PortName = PortName
    '    com.BaudRate = BaudRate
    '    Try
    '        com.Open()
    '    Catch ex As Exception
    '        MessageBox.Show("com.Open(): " + ex.Message)
    '    End Try

    '    Dim buf(15) As Byte
    '    Dim pesoB(8) As Byte
    '    Dim i As Integer
    '    MessageBox.Show("buf=read()")
    '    buf = Leer(16)
    '    MessageBox.Show("Antes de cerrar")
    '    Try
    '        com.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    '    For i = 0 To 15
    '        If CInt(buf(i).ToString) = 43 Then
    '            Array.Copy(buf, i, pesoB, 0, 8)
    '            i = 15
    '        End If
    '    Next

    '    For i = 1 To 7
    '        result += Chr(pesoB(i))
    '    Next
    '    MessageBox.Show(result)
    '    If Chr(pesoB(0)) = "-" Then
    '        peso = CInt(result) * -1
    '    Else
    '        peso = CInt(result)
    '    End If
    '    Return peso
    'End Function
    'Private Function Leer(ByVal count As Integer) As Byte()
    '    Dim buffer(count - 1) As Byte
    '    Dim readBytes As Integer
    '    Dim totalReadBytes As Integer
    '    Dim offset As Integer
    '    Dim remaining As Integer = count

    '    Try
    '        Do
    '            readBytes = com.Read(buffer, offset, remaining)
    '            offset += readBytes
    '            remaining -= readBytes
    '            totalReadBytes += readBytes
    '        Loop While remaining > 0 AndAlso readBytes > 0
    '    Catch ex As TimeoutException
    '        ReDim Preserve buffer(totalReadBytes - 1)
    '    End Try

    '    Return buffer

    'End Function


    Public Function CapturarPeso() As Integer
        'Dim com As New SerialPort
        Dim result As String = ""
        Dim peso As Integer = 0
        Dim strPeso As String
        com = New SerialPort
        com.PortName = PortName
        com.BaudRate = BaudRate
        Try
            com.Open()
        Catch ex As Exception
            MessageBox.Show("com.Open(): " + ex.Message)
            Return 0
        End Try

        'Dim buf(15) As Byte
        'Dim pesoB(8) As Byte
        'Dim i As Integer

        'MessageBox.Show("buf=read()")
        result = Leer()
        'MessageBox.Show("Antes de cerrar")
        Try
            com.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
        
        'MessageBox.Show(result.Substring(1, 7))
        'MessageBox.Show(".Length" + result.Length.ToString + "; 0:" + result.Substring(0, 1) + "; 1:" + result.Substring(1, 1))
        'For i = 0 To result.Length - 1
        '    MessageBox.Show(i.ToString + ": " + result(i))
        'Next
        strPeso = result.Substring(1, 7)
        If IsNumeric(strPeso) Then
            If result(0) = "-" Then
                peso = CInt(strPeso) * -1
            Else
                peso = CInt(strPeso)
            End If
        End If
      'MessageBox.Show("peso:" + peso.ToString)
        Return peso
    End Function
    Private Function Leer() As String
        Dim az As String = "0"

        Try
            com.ReadTimeout = 200
            az = com.ReadLine
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return az
    End Function



    Public Function CapturarPesoMetales() As Integer
        Dim com As New SerialPort
        Dim result As String = ""
        Dim peso As Integer = 0
        com.PortName = PortName
        com.BaudRate = BaudRate
        com.Open()
        Dim buf(25) As Byte
        Dim pesoB(11) As Byte
        Dim i As Integer

        buf = Read(com, 26)
        com.Close()
        For i = 0 To 25
            If CInt(buf(i).ToString) = 2 Then
                Array.Copy(buf, i, pesoB, 0, 11)
                i = 25
            End If
        Next

        For i = 2 To 7
            result += Chr(pesoB(i))
        Next
        If Chr(pesoB(1)) = "-" Then
            peso = CInt(result) * -1
        Else
            peso = CInt(result)
        End If
        Return peso
    End Function
    Private Function Read(ByVal port As SerialPort, ByVal count As Integer) As Byte()
        Dim buffer(count - 1) As Byte
        Dim readBytes As Integer
        Dim totalReadBytes As Integer
        Dim offset As Integer
        Dim remaining As Integer = count

        Try
            Do
                readBytes = port.Read(buffer, offset, remaining)
                offset += readBytes
                remaining -= readBytes
                totalReadBytes += readBytes
            Loop While remaining > 0 AndAlso readBytes > 0
        Catch ex As TimeoutException
            ReDim Preserve buffer(totalReadBytes - 1)
        End Try

        Return buffer

    End Function

End Class
