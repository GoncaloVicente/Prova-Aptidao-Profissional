Public Class frmlogin


    Private Sub limpacampos()
        txtutilizador.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub btnentrar_Click(sender As System.Object, e As System.EventArgs) Handles btnentrar.Click
        If txtutilizador.Text = "1" And txtpassword.Text = "1" Then
            frmprincipal.Show()
            Me.Hide()
        ElseIf txtutilizador.Text = "AutomaticHouse" And txtpassword.Text = "1234" Then
            Me.Hide()
            frmprincipal.Show()
        Else
            MsgBox("O nome de utilizador ou a password estão incorretos, por favor tente novamente", MsgBoxStyle.OkOnly, "Utilizador ou Password incorretos")
            limpacampos()
        End If
    End Sub

    Private Sub btnsair_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsair.Click
        Application.Exit()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class