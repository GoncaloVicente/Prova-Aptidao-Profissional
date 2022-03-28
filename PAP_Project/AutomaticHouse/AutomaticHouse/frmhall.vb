Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Runtime.InteropServices
Public Class frmhall

    Private Sub frmhall_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        SerialPort1.Close()
        SerialPort1.PortName = "com4" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
    End Sub

    Private Sub btnabrirporta_Click(sender As System.Object, e As System.EventArgs) Handles btnabrirporta.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("1")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnfecharporta_Click(sender As System.Object, e As System.EventArgs) Handles btnfecharporta.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("2")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnacenderluz_Click(sender As System.Object, e As System.EventArgs) Handles btnacenderluz.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("o")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub btnapagarluz_Click(sender As System.Object, e As System.EventArgs) Handles btnapagarluz.Click
        Try
            SerialPort1.Open()
            SerialPort1.Write("p")
            SerialPort1.Close()
        Catch
            MessageBox.Show("A coneção ao arduino falhou, por favor tente novamente. ", "Erro de coneção ao arduino")
        End Try
    End Sub

    Private Sub Sair_Click(sender As System.Object, e As System.EventArgs) Handles Sair.Click
        Me.Close()
        frmprincipal.Show()
    End Sub
End Class
