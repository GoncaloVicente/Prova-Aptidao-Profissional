<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmagenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAgenda = New System.Windows.Forms.TextBox()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.voltar = New System.Windows.Forms.PictureBox()
        Me.apagar = New System.Windows.Forms.PictureBox()
        Me.guardar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Destinatario = New System.Windows.Forms.Label()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAgenda
        '
        Me.txtAgenda.Location = New System.Drawing.Point(365, 254)
        Me.txtAgenda.Multiline = True
        Me.txtAgenda.Name = "txtAgenda"
        Me.txtAgenda.Size = New System.Drawing.Size(227, 162)
        Me.txtAgenda.TabIndex = 3
        '
        'calendario
        '
        Me.calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario.Location = New System.Drawing.Point(49, 254)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 2
        '
        'sair
        '
        Me.sair.BackColor = System.Drawing.Color.Transparent
        Me.sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar1
        Me.sair.Location = New System.Drawing.Point(598, 381)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(41, 35)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.sair.TabIndex = 8
        Me.sair.TabStop = False
        '
        'voltar
        '
        Me.voltar.BackColor = System.Drawing.Color.Transparent
        Me.voltar.Image = Global.AutomaticHouse.My.Resources.Resources._6980_256x256
        Me.voltar.Location = New System.Drawing.Point(598, 336)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(41, 35)
        Me.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.voltar.TabIndex = 7
        Me.voltar.TabStop = False
        '
        'apagar
        '
        Me.apagar.BackColor = System.Drawing.Color.Transparent
        Me.apagar.Image = Global.AutomaticHouse.My.Resources.Resources.Delete_Icon1
        Me.apagar.Location = New System.Drawing.Point(598, 295)
        Me.apagar.Name = "apagar"
        Me.apagar.Size = New System.Drawing.Size(41, 35)
        Me.apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.apagar.TabIndex = 6
        Me.apagar.TabStop = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.Color.Transparent
        Me.guardar.Image = Global.AutomaticHouse.My.Resources.Resources._1211766742
        Me.guardar.Location = New System.Drawing.Point(598, 254)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(41, 35)
        Me.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.guardar.TabIndex = 5
        Me.guardar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AutomaticHouse.My.Resources.Resources.Agenda
        Me.PictureBox1.Location = New System.Drawing.Point(49, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 455)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Email:"
        '
        'Destinatario
        '
        Me.Destinatario.AutoSize = True
        Me.Destinatario.BackColor = System.Drawing.Color.Transparent
        Me.Destinatario.Location = New System.Drawing.Point(100, 457)
        Me.Destinatario.Name = "Destinatario"
        Me.Destinatario.Size = New System.Drawing.Size(171, 13)
        Me.Destinatario.TabIndex = 35
        Me.Destinatario.Text = "goncalo.vicente11310@gmail.com"
        '
        'frmagenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.agenda_hi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Destinatario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.apagar)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAgenda)
        Me.Controls.Add(Me.calendario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmagenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAgenda As System.Windows.Forms.TextBox
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents guardar As System.Windows.Forms.PictureBox
    Friend WithEvents apagar As System.Windows.Forms.PictureBox
    Friend WithEvents voltar As System.Windows.Forms.PictureBox
    Friend WithEvents sair As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Destinatario As System.Windows.Forms.Label
End Class
