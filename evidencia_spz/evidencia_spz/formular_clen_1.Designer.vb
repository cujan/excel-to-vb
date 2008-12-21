<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formular_clen_1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formular_clen_1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TitulTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Statna_prislusnostTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_opDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_plDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_zpTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_zpDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_clenskeho_preukazu_spzTextBox = New System.Windows.Forms.TextBox
        Me.Clen_spz_odDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Clen_pzTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_skusky_z__polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.evidencia_spz.My.Resources.Resources.formular_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(796, 521)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.PrintToolStripButton, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Náhľad"
        '
        'PrintForm1
        '
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'TitulTextBox
        '
        Me.TitulTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TitulTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TitulTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TitulTextBox.Location = New System.Drawing.Point(101, 37)
        Me.TitulTextBox.Name = "TitulTextBox"
        Me.TitulTextBox.ReadOnly = True
        Me.TitulTextBox.Size = New System.Drawing.Size(43, 13)
        Me.TitulTextBox.TabIndex = 24
        '
        'MenoTextBox
        '
        Me.MenoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MenoTextBox.Location = New System.Drawing.Point(152, 37)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.ReadOnly = True
        Me.MenoTextBox.Size = New System.Drawing.Size(77, 13)
        Me.MenoTextBox.TabIndex = 26
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(235, 37)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.ReadOnly = True
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(118, 13)
        Me.PriezviskoTextBox.TabIndex = 28
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(226, 89)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.ReadOnly = True
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(117, 13)
        Me.Rodne_cisloTextBox.TabIndex = 30
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(226, 65)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.ReadOnly = True
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(174, 13)
        Me.Miesto_narodeniaTextBox.TabIndex = 32
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(45, 89)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.ReadOnly = True
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(124, 13)
        Me.Okres_narodeniaTextBox.TabIndex = 34
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BydliskoTextBox.Location = New System.Drawing.Point(101, 115)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.ReadOnly = True
        Me.BydliskoTextBox.Size = New System.Drawing.Size(198, 13)
        Me.BydliskoTextBox.TabIndex = 36
        '
        'PscTextBox
        '
        Me.PscTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PscTextBox.Location = New System.Drawing.Point(305, 115)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.ReadOnly = True
        Me.PscTextBox.Size = New System.Drawing.Size(80, 13)
        Me.PscTextBox.TabIndex = 38
        '
        'Statna_prislusnostTextBox
        '
        Me.Statna_prislusnostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Statna_prislusnostTextBox.Location = New System.Drawing.Point(248, 150)
        Me.Statna_prislusnostTextBox.Name = "Statna_prislusnostTextBox"
        Me.Statna_prislusnostTextBox.ReadOnly = True
        Me.Statna_prislusnostTextBox.Size = New System.Drawing.Size(117, 13)
        Me.Statna_prislusnostTextBox.TabIndex = 40
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(63, 175)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.ReadOnly = True
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(117, 13)
        Me.Cislo_opTextBox.TabIndex = 42
        '
        'Datum_vydania_opDateTimePicker
        '
        Me.Datum_vydania_opDateTimePicker.Location = New System.Drawing.Point(248, 176)
        Me.Datum_vydania_opDateTimePicker.Name = "Datum_vydania_opDateTimePicker"
        Me.Datum_vydania_opDateTimePicker.Size = New System.Drawing.Size(158, 20)
        Me.Datum_vydania_opDateTimePicker.TabIndex = 44
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(63, 199)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.ReadOnly = True
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(117, 13)
        Me.Cislo_plTextBox.TabIndex = 46
        '
        'Datum_vydania_plDateTimePicker
        '
        Me.Datum_vydania_plDateTimePicker.Location = New System.Drawing.Point(248, 200)
        Me.Datum_vydania_plDateTimePicker.Name = "Datum_vydania_plDateTimePicker"
        Me.Datum_vydania_plDateTimePicker.Size = New System.Drawing.Size(158, 20)
        Me.Datum_vydania_plDateTimePicker.TabIndex = 48
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(63, 223)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.ReadOnly = True
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(117, 13)
        Me.Cislo_zpTextBox.TabIndex = 50
        '
        'Datum_vydania_zpDateTimePicker
        '
        Me.Datum_vydania_zpDateTimePicker.Location = New System.Drawing.Point(248, 225)
        Me.Datum_vydania_zpDateTimePicker.Name = "Datum_vydania_zpDateTimePicker"
        Me.Datum_vydania_zpDateTimePicker.Size = New System.Drawing.Size(158, 20)
        Me.Datum_vydania_zpDateTimePicker.TabIndex = 52
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(248, 338)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.ReadOnly = True
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(158, 13)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 54
        '
        'Clen_spz_odDateTimePicker
        '
        Me.Clen_spz_odDateTimePicker.Location = New System.Drawing.Point(87, 338)
        Me.Clen_spz_odDateTimePicker.Name = "Clen_spz_odDateTimePicker"
        Me.Clen_spz_odDateTimePicker.Size = New System.Drawing.Size(134, 20)
        Me.Clen_spz_odDateTimePicker.TabIndex = 56
        '
        'Clen_pzTextBox
        '
        Me.Clen_pzTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Clen_pzTextBox.Location = New System.Drawing.Point(472, 338)
        Me.Clen_pzTextBox.Name = "Clen_pzTextBox"
        Me.Clen_pzTextBox.ReadOnly = True
        Me.Clen_pzTextBox.Size = New System.Drawing.Size(275, 13)
        Me.Clen_pzTextBox.TabIndex = 62
        '
        'Skuska_z_polovnictvaDateTimePicker
        '
        Me.Skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(114, 311)
        Me.Skuska_z_polovnictvaDateTimePicker.Name = "Skuska_z_polovnictvaDateTimePicker"
        Me.Skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(120, 20)
        Me.Skuska_z_polovnictvaDateTimePicker.TabIndex = 64
        '
        'Miesto_skusky_z__polovnictvaTextBox
        '
        Me.Miesto_skusky_z__polovnictvaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Miesto_skusky_z__polovnictvaTextBox.Location = New System.Drawing.Point(238, 311)
        Me.Miesto_skusky_z__polovnictvaTextBox.Name = "Miesto_skusky_z__polovnictvaTextBox"
        Me.Miesto_skusky_z__polovnictvaTextBox.ReadOnly = True
        Me.Miesto_skusky_z__polovnictvaTextBox.Size = New System.Drawing.Size(168, 13)
        Me.Miesto_skusky_z__polovnictvaTextBox.TabIndex = 66
        '
        'Vyzsia_skuska_z_polovnictvaDateTimePicker
        '
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(558, 312)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Name = "Vyzsia_skuska_z_polovnictvaDateTimePicker"
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.TabIndex = 68
        '
        'Miesto_vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(682, 312)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Name = "Miesto_vyzsia_skuska_z_polovnictvaTextBox"
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(105, 13)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 70
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Tlačiť do súboru"
        '
        'formular_clen_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 521)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaDateTimePicker)
        Me.Controls.Add(Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Skuska_z_polovnictvaDateTimePicker)
        Me.Controls.Add(Me.Miesto_skusky_z__polovnictvaTextBox)
        Me.Controls.Add(Me.Datum_vydania_opDateTimePicker)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(Me.Datum_vydania_plDateTimePicker)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Me.Datum_vydania_zpDateTimePicker)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Me.Clen_spz_odDateTimePicker)
        Me.Controls.Add(Me.Clen_pzTextBox)
        Me.Controls.Add(Me.TitulTextBox)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Me.Okres_narodeniaTextBox)
        Me.Controls.Add(Me.BydliskoTextBox)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(Me.Statna_prislusnostTextBox)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formular_clen_1"
        Me.Text = "Tlačová forma člena 1/2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents TitulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Statna_prislusnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_opDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_plDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_zpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_clenskeho_preukazu_spzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_spz_odDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Clen_pzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_skusky_z__polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
