<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquarto
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
        Me.btnacenderluz = New System.Windows.Forms.ToolStripButton()
        Me.btnapagarluz = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirestoro = New System.Windows.Forms.ToolStripButton()
        Me.btnfecharestoro = New System.Windows.Forms.ToolStripButton()
        Me.sair = New System.Windows.Forms.ToolStripButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnacenderluz, Me.btnapagarluz, Me.btnabrirestoro, Me.btnfecharestoro, Me.sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(157, 733)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnacenderluz
        '
        Me.btnacenderluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnacenderluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_ligada
        Me.btnacenderluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnacenderluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnacenderluz.Name = "btnacenderluz"
        Me.btnacenderluz.Size = New System.Drawing.Size(155, 134)
        Me.btnacenderluz.Text = "Acender Luz"
        '
        'btnapagarluz
        '
        Me.btnapagarluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnapagarluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_desligada
        Me.btnapagarluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnapagarluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnapagarluz.Name = "btnapagarluz"
        Me.btnapagarluz.Size = New System.Drawing.Size(155, 134)
        Me.btnapagarluz.Text = "Apagar Luz"
        '
        'btnabrirestoro
        '
        Me.btnabrirestoro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirestoro.Image = Global.AutomaticHouse.My.Resources.Resources.janelaaberta2
        Me.btnabrirestoro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnabrirestoro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirestoro.Name = "btnabrirestoro"
        Me.btnabrirestoro.Size = New System.Drawing.Size(155, 104)
        Me.btnabrirestoro.Text = "Abrir Estoro"
        '
        'btnfecharestoro
        '
        Me.btnfecharestoro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnfecharestoro.Image = Global.AutomaticHouse.My.Resources.Resources.janelafechada
        Me.btnfecharestoro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnfecharestoro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfecharestoro.Name = "btnfecharestoro"
        Me.btnfecharestoro.Size = New System.Drawing.Size(155, 104)
        Me.btnfecharestoro.Text = "Fechar Estoro"
        '
        'sair
        '
        Me.sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar
        Me.sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(155, 114)
        Me.sair.Text = "Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutomaticHouse.My.Resources.Resources.Quarto_
        Me.PictureBox1.Location = New System.Drawing.Point(150, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1241, 741)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmquarto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmquarto"
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
    Friend WithEvents btnabrirestoro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfecharestoro As System.Windows.Forms.ToolStripButton
    Friend WithEvents sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
