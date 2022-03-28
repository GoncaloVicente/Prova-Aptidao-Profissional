Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmprincipal
    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Dim receivedData As String = ""
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmquarto1.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        frmquarto.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        frmhall.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        frmescritorio.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        frmcozinha.Show()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sair.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles camaras.Click
        System.Diagnostics.Process.Start("http://www.ispyconnect.com/monitor/app/summary")
    End Sub

    Private Sub informacoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agenda.Click
        frmagenda.Show()
    End Sub

    Private Sub frmprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Timer2.Enabled = True
        lbdata.Text = Today
        lbhora.Text = TimeString

        SerialPort1.Close()
        SerialPort1.PortName = "com3" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!

        temp.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbhora.Text = TimeString
    End Sub


    Function ReceiveSerialData() As String

        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        SerialPort1.Open()
        receivedData = ReceiveSerialData()
        temp.Text = receivedData
        Dim valor As String = receivedData
        Dim substrtemp As String = valor.Substring(0, 4)
        temp.Text = substrtemp
        SerialPort1.Close()
    End Sub
End Class