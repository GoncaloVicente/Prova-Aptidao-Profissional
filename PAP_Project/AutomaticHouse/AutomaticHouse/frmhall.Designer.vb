<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhall))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnabrirporta = New System.Windows.Forms.ToolStripButton()
        Me.btnfecharporta = New System.Windows.Forms.ToolStripButton()
        Me.btnacenderluz = New System.Windows.Forms.ToolStripButton()
        Me.btnapagarluz = New System.Windows.Forms.ToolStripButton()
        Me.Sair = New System.Windows.Forms.ToolStripButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnabrirporta, Me.btnfecharporta, Me.btnacenderluz, Me.btnapagarluz, Me.Sair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(149, 733)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnabrirporta
        '
        Me.btnabrirporta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirporta.Image = Global.AutomaticHouse.My.Resources.Resources.chaveabrir
        Me.btnabrirporta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnabrirporta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirporta.Name = "btnabrirporta"
        Me.btnabrirporta.Size = New System.Drawing.Size(147, 134)
        Me.btnabrirporta.Text = "Abrir Porta"
        '
        'btnfecharporta
        '
        Me.btnfecharporta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnfecharporta.Image = CType(resources.GetObject("btnfecharporta.Image"), System.Drawing.Image)
        Me.btnfecharporta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnfecharporta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnfecharporta.Name = "btnfecharporta"
        Me.btnfecharporta.Size = New System.Drawing.Size(147, 134)
        Me.btnfecharporta.Text = "Fechar Porta"
        '
        'btnacenderluz
        '
        Me.btnacenderluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnacenderluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_ligada
        Me.btnacenderluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnacenderluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnacenderluz.Name = "btnacenderluz"
        Me.btnacenderluz.Size = New System.Drawing.Size(147, 134)
        Me.btnacenderluz.Text = "Acender Luz"
        '
        'btnapagarluz
        '
        Me.btnapagarluz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnapagarluz.Image = Global.AutomaticHouse.My.Resources.Resources.lampada_desligada
        Me.btnapagarluz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnapagarluz.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnapagarluz.Name = "btnapagarluz"
        Me.btnapagarluz.Size = New System.Drawing.Size(147, 134)
        Me.btnapagarluz.Text = "Apagar Luz"
        '
        'Sair
        '
        Me.Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Sair.Image = Global.AutomaticHouse.My.Resources.Resources.fechar
        Me.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(147, 114)
        Me.Sair.Text = "Sair"
        '
        'frmhall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AutomaticHouse.My.Resources.Resources.Hall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmhall"
        Me.Text = "Hall"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnabrirporta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnfecharporta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnacenderluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnapagarluz As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
