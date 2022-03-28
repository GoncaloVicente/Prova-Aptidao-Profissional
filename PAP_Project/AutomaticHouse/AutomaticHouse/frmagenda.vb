Imports System.IO
Imports System.Net.Mail
Public Class frmagenda
    Dim reg As String
    Private Sub AtivaControles()
        Try

            txtAgenda.Enabled = True
            txtAgenda.Show()
            guardar.Enabled = True
            guardar.Show()
            apagar.Enabled = True
            apagar.Show()
            voltar.Enabled = True
            voltar.Show()

        Catch
            Throw
        End Try
    End Sub
    Private Sub frmagenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAgenda.Enabled = False
        txtAgenda.Hide()
        guardar.Enabled = False
        guardar.Hide()
        apagar.Enabled = False
        apagar.Hide()
        voltar.Enabled = False
        voltar.Hide()
        reg = calendario.SelectionRange.Start.Year.ToString & calendario.SelectionRange.Start.Month.ToString & calendario.SelectionRange.Start.Day.ToString
        Try
            If Date.Today = calendario.TodayDate And File.Exists(reg & ".txt") = True Then

                If MessageBox.Show("Existem registros na Agenda para esta data. Deseja ver? ", "Ver Agenda", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    AtivaControles()
                    txtAgenda.Text = File.ReadAllText(reg & ".txt")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardar.Click
        Try
            If txtAgenda.Text = "" Then
                If File.Exists(reg & ".txt") = True Then
                    If MessageBox.Show("Deseja apagar a marcação que está registada para este dia? ", "Apagar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        File.Delete(reg & ".txt")
                    End If
                End If
            Else
                If txtAgenda.Text.Length > 0 Then
                    File.WriteAllText(reg & ".txt", txtAgenda.Text)

                    MessageBox.Show("Marcação registrada com sucesso!", "Marcado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        txtAgenda.Enabled = False
                        txtAgenda.Hide()
                        guardar.Enabled = False
                        guardar.Hide()
                        apagar.Enabled = False
                        apagar.Hide()
                        voltar.Enabled = False
                        voltar.Hide()
                        calendario.Enabled = True
                        calendario.Show()
                    Catch ex As Exception
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim Email_Origem As String = "automatichouse.tgei@gmail.com" ' Email de origem
        Dim Pass_Email_Origem As String = "916906642" ' Pass do email de origem

        Dim mail As New MailMessage
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(Email_Origem, Pass_Email_Origem)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True

        mail = New MailMessage()
        Dim addr() As String = Destinatario.Text.ToString.Split(",")
        Try
            mail.From = New MailAddress(Email_Origem, "AutomaticHouse", System.Text.Encoding.UTF8)
            Dim i As Byte
            For i = 0 To addr.Length - 1
                mail.To.Add(addr(i)) ''Campo Para  
                mail.CC.Add(addr(i)) '' Campo CC
                mail.Bcc.Add(addr(i))  ' Campo BCC
            Next

            mail.Subject = ("Marcação de uma atividade em AutomaticHouse")

            mail.Body = txtAgenda.Text.ToString ' 'Vai buscar a mensagem ao Richtexbox 'mensagem'


            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            SmtpServer.Send(mail)
            mail.Attachments.Clear()

        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click
        Try
            txtAgenda.Enabled = False
            txtAgenda.Hide()
            guardar.Enabled = False
            guardar.Hide()
            apagar.Enabled = False
            apagar.Hide()
            calendario.Enabled = True
            calendario.Show()
            voltar.Enabled = False
            voltar.Hide()
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub apagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apagar.Click
        Try
            If File.Exists(reg & ".txt") = True Then
                If MessageBox.Show("Deseja apagar a marcação que está registada para este dia? ", "Apagar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    File.Delete(reg & ".txt")
                End If
            End If
            txtAgenda.Enabled = False
            txtAgenda.Hide()
            guardar.Enabled = False
            guardar.Hide()
            apagar.Enabled = False
            apagar.Hide()
            voltar.Enabled = False
            voltar.Hide()
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim Email_Origem As String = "automatichouse.tgei@gmail.com" ' Email de origem
        Dim Pass_Email_Origem As String = "916906642" ' Pass do email de origem

        Dim mail As New MailMessage
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(Email_Origem, Pass_Email_Origem)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True

        mail = New MailMessage()
        Dim addr() As String = Destinatario.Text.ToString.Split(",")
        Try
            mail.From = New MailAddress(Email_Origem, "AutomaticHouse", System.Text.Encoding.UTF8)

            Dim i As Byte
            For i = 0 To addr.Length - 1
                mail.To.Add(addr(i)) ''Campo Para  
                mail.CC.Add(addr(i)) '' Campo CC
                mail.Bcc.Add(addr(i))  ' Campo BCC
            Next

            mail.Subject = ("Desmarcação de uma atividade em AutomaticHouse")

            mail.Body = txtAgenda.Text.ToString ' 'Vai buscar a mensagem ao Richtexbox 'mensagem'


            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            SmtpServer.Send(mail)
            mail.Attachments.Clear()

        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sair.Click
        Me.Hide()
        frmprincipal.Show()
    End Sub

    Private Sub calendario_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles calendario.DateChanged
        reg = calendario.SelectionRange.Start.Year.ToString & calendario.SelectionRange.Start.Month.ToString & calendario.SelectionRange.Start.Day.ToString
        Try
            If File.Exists(reg & ".txt") = True Then
                AtivaControles()
                txtAgenda.Text = File.ReadAllText(reg & ".txt")
            Else
                If MessageBox.Show("Deseja registrar marcações para esta data?", "Registrar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    txtAgenda.Text = ""
                    AtivaControles()
                    txtAgenda.Text = "Dia " & calendario.SelectionRange.Start.Day.ToString & "/" & calendario.SelectionRange.Start.Month.ToString & "/" & calendario.SelectionRange.Start.Year.ToString & " - "
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class