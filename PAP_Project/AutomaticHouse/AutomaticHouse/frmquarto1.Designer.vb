<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquarto1
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnacenderluz = New System.Windows.Forms.ToolStripButton()
        Me.btnapagarluz = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirestoros = New System.Windows.Forms.ToolStripButton()
        Me.btnfecharestoros = New System.Windows.Forms.ToolStripButton()
        Me.Sair = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnacenderluz, Me.btnapagarluz, Me.btnabrirestoros, Me.btnfecharestoros, Me.Sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(152, 733)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutomaticHouse.My.Resources.Resources.Quarto__2
        Me.PictureBox1.Location = New System.Drawing.Point(145, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1237, 741)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnacenderluz
        '
        Me.btnacenderluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnacenderluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_ligada
        Me.btnacenderluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnacenderluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnacenderluz.Name = "btnacenderluz"
        Me.btnacenderluz.Size = New System.Drawing.Size(150, 134)
        Me.btnacenderluz.Text = "Acender Luz"
        '
        'btnapagarluz
        '
        Me.btnapagarluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnapagarluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_desligada
        Me.btnapagarluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnapagarluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnapagarluz.Name = "btnapagarluz"
        Me.btnapagarluz.Size = New System.Drawing.Size(150, 134)
        Me.btnapagarluz.Text = "Apagar Luz"
        '
        'btnabrirestoros
        '
        Me.btnabrirestoros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirestoros.Image = Global.AutomaticHouse.My.Resources.Resources.janelaaberta2
        Me.btnabrirestoros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnabrirestoros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirestoros.Name = "btnabrirestoros"
        Me.btnabrirestoros.Size = New System.Drawing.Size(150, 104)
        Me.btnabrirestoros.Text = "Abrir Estoros"
        '
        'btnfecharestoros
        '
        Me.btnfecharestoros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnfecharestoros.Image = Global.AutomaticHouse.My.Resources.Resources.janelafechada
        Me.btnfecharestoros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnfecharestoros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfecharestoros.Name = "btnfecharestoros"
        Me.btnfecharestoros.Size = New System.Drawing.Size(150, 104)
        Me.btnfecharestoros.Text = "Fechar Estoros"
        '
        'Sair
        '
        Me.Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar
        Me.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(150, 114)
        Me.Sair.Text = "Sair"
        '
        'frmquarto1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmquarto1"
        Me.Text = "Quarto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnacenderluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnapagarluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnabrirestoros As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfecharestoros As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
