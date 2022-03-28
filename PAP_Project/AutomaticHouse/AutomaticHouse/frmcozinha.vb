Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmcozinha
    Shared _continue As Boolean
    Shared _serialPort As SerialPort

    Private Sub frmcozinha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        SerialPort1.Close()
        SerialPort1.PortName = "com3" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
    End Sub

    Private Sub btnacenderluz_Click(sender As System.Object, e As System.EventArgs) Handles btnacenderluz.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("q")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnapagarluz_Click(sender As System.Object, e As System.EventArgs) Handles btnapagarluz.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("r")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnabrirestoros_Click(sender As System.Object, e As System.EventArgs) Handles btnabrirestoros.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("s")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnfecharestoros_Click(sender As System.Object, e As System.EventArgs) Handles btnfecharestoros.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("t")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub sair_Click(sender As System.Object, e As System.EventArgs) Handles sair.Click
        Me.Close()
    End Sub
End Class