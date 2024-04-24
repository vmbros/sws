'Code Starts here ….
'Import Systems which we are gonna use in our code
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

'frmMain is the name of our form ….
'Here starts our main form code …..

Public Class indicador
    Dim myPort As Array
    Public _peso As Double
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Public Property peso As String
        Get
            SerialPort1.PortName = "COM3"
            SerialPort1.BaudRate = "4800"
            SerialPort1.Parity = IO.Ports.Parity.None
            SerialPort1.StopBits = IO.Ports.StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.Open()
            'btnConnect.Enabled = False
            'btnDisconnect.Enabled = True


            Return _peso
        End Get
        Set(value As String)
            _peso = CDbl(value)
        End Set
    End Property

    'Page Load Code Starts Here….
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        cmbBaud.Items.Add(2400)
        cmbBaud.Items.Add(4800)
        cmbBaud.Items.Add(9600)
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)
        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)
        cmbBaud.Text = cmbBaud.Items.Item(0)
        cboRomana.Items.Add("ME")
        cboRomana.Items.Add("MC")
        cboRomana.Items.Add("FE")
        btnDisconnect.Enabled = False
    End Sub
    'Page Load Code Ends Here ….

    'Connect Button Code Starts Here ….
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text
        SerialPort1.BaudRate = cmbBaud.Text
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Open()
        btnConnect.Enabled = False
        btnDisconnect.Enabled = True
    End Sub
    'Connect Button Code Ends Here ….

    'Disconnect Button Code Starts Here ….
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
    End Sub
    'Disconnect Button Code Ends Here ….

    'Send Button Code Starts Here ….

    'Send Button Code Ends Here ….

    'Serial Port Receiving Code Starts Here ….
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub
    'Serial Port Receiving Code Ends Here ….

    'Serial Port Receiving Code(Invoke) Starts Here ….
    Private Sub ReceivedText(ByVal [text] As String)
        Dim data As String
        Dim largo As Integer
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            data = [text]
            If cboRomana.Text = "FE" Then
                largo = 8
            Else
                largo = 12
            End If
            Me.rtbReceived.Text = data.Substring(0, largo - 1)
            Me._peso = rtbReceived.Text.Substring(2, 6)

            SerialPort1.Close()
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False


        End If
    End Sub
    'Serial Port Receiving Code(Invoke) Ends Here ….


    'Com Port Change Warning Code Starts Here ….
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    'Com Port Change Warning Code Ends Here ….

    'Baud Rate Change Warning Code Starts Here ….
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    'Baud Rate Change Warning Code Ends Here ….

End Class
'Whole Code Ends Here ….
