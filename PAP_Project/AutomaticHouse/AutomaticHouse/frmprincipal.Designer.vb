<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.sair = New System.Windows.Forms.PictureBox()
        Me.agenda = New System.Windows.Forms.PictureBox()
        Me.lbhora = New System.Windows.Forms.Label()
        Me.lbdata = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.camaras = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.temp = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.camaras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(423, 217)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(318, 356)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(581, 398)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(725, 424)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Location = New System.Drawing.Point(980, 296)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 39)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'sair
        '
        Me.sair.BackColor = System.Drawing.Color.Transparent
        Me.sair.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.seta_para_baixo2
        Me.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar
        Me.sair.Location = New System.Drawing.Point(308, 620)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(112, 109)
        Me.sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.sair.TabIndex = 5
        Me.sair.TabStop = False
        '
        'agenda
        '
        Me.agenda.BackColor = System.Drawing.Color.Transparent
        Me.agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.agenda.Image = Global.AutomaticHouse.My.Resources.Resources.graphics_agenda_6079151
        Me.agenda.Location = New System.Drawing.Point(22, 620)
        Me.agenda.Name = "agenda"
        Me.agenda.Size = New System.Drawing.Size(121, 109)
        Me.agenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.agenda.TabIndex = 7
        Me.agenda.TabStop = False
        '
        'lbhora
        '
        Me.lbhora.AutoSize = True
        Me.lbhora.BackColor = System.Drawing.Color.Transparent
        Me.lbhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbhora.Location = New System.Drawing.Point(45, 87)
        Me.lbhora.Name = "lbhora"
        Me.lbhora.Size = New System.Drawing.Size(0, 29)
        Me.lbhora.TabIndex = 8
        '
        'lbdata
        '
        Me.lbdata.AutoSize = True
        Me.lbdata.BackColor = System.Drawing.Color.Transparent
        Me.lbdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdata.ForeColor = System.Drawing.Color.Transparent
        Me.lbdata.Location = New System.Drawing.Point(45, 42)
        Me.lbdata.Name = "lbdata"
        Me.lbdata.Size = New System.Drawing.Size(66, 29)
        Me.lbdata.TabIndex = 9
        Me.lbdata.Text = "Data"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'camaras
        '
        Me.camaras.BackColor = System.Drawing.Color.Transparent
        Me.camaras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.camaras.Image = Global.AutomaticHouse.My.Resources.Resources.camara1
        Me.camaras.Location = New System.Drawing.Point(162, 620)
        Me.camaras.Name = "camaras"
        Me.camaras.Size = New System.Drawing.Size(121, 109)
        Me.camaras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.camaras.TabIndex = 6
        Me.camaras.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(45, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Temperatura"
        '
        'temp
        '
        Me.temp.Location = New System.Drawing.Point(230, 117)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(40, 21)
        Me.temp.TabIndex = 11
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.VICENTE_AUTOMATIC_HOUSE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.temp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbdata)
        Me.Controls.Add(Me.lbhora)
        Me.Controls.Add(Me.agenda)
        Me.Controls.Add(Me.camaras)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmprincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.camaras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents sair As System.Windows.Forms.PictureBox
    Friend WithEvents agenda As System.Windows.Forms.PictureBox
    Friend WithEvents lbhora As System.Windows.Forms.Label
    Friend WithEvents lbdata As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents camaras As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents temp As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
