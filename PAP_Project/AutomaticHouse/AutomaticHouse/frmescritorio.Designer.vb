<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmescritorio
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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnacenderluz = New System.Windows.Forms.ToolStripButton()
        Me.btnapagarluz = New System.Windows.Forms.ToolStripButton()
        Me.btnabrirestoro = New System.Windows.Forms.ToolStripButton()
        Me.btnfecharestoro = New System.Windows.Forms.ToolStripButton()
        Me.Sair = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnacenderluz, Me.btnapagarluz, Me.btnabrirestoro, Me.btnfecharestoro, Me.Sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(158, 733)
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
        Me.btnacenderluz.Size = New System.Drawing.Size(156, 134)
        Me.btnacenderluz.Text = "Acender Luz"
        '
        'btnapagarluz
        '
        Me.btnapagarluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnapagarluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_desligada
        Me.btnapagarluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnapagarluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnapagarluz.Name = "btnapagarluz"
        Me.btnapagarluz.Size = New System.Drawing.Size(156, 134)
        Me.btnapagarluz.Text = "Apagar Luz"
        '
        'btnabrirestoro
        '
        Me.btnabrirestoro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirestoro.Image = Global.AutomaticHouse.My.Resources.Resources.janelaaberta2
        Me.btnabrirestoro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnabrirestoro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirestoro.Name = "btnabrirestoro"
        Me.btnabrirestoro.Size = New System.Drawing.Size(156, 104)
        Me.btnabrirestoro.Text = "Abrir Estoro"
        '
        'btnfecharestoro
        '
        Me.btnfecharestoro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnfecharestoro.Image = Global.AutomaticHouse.My.Resources.Resources.janelafechada
        Me.btnfecharestoro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnfecharestoro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfecharestoro.Name = "btnfecharestoro"
        Me.btnfecharestoro.Size = New System.Drawing.Size(156, 104)
        Me.btnfecharestoro.Text = "Fechar Estoro"
        '
        'Sair
        '
        Me.Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar
        Me.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(156, 114)
        Me.Sair.Text = "Sair"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutomaticHouse.My.Resources.Resources.Escritorio2
        Me.PictureBox1.Location = New System.Drawing.Point(152, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1218, 741)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmescritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1348, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmescritorio"
        Me.Text = "Escritorio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnacenderluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnapagarluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnabrirestoro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfecharestoro As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
