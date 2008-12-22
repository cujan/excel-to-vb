Public Class formular_clen_1

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.ToolStrip1.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.ToolStrip1.Show()

    End Sub

    Private Sub formular_clen_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.TitulTextBox.Text = karta_clena.TitulTextBox.Text
        Me.MenoTextBox.Text = karta_clena.MenoTextBox.Text
        Me.PriezviskoTextBox.Text = karta_clena.PriezviskoTextBox.Text
        Me.Rodne_cisloTextBox.Text = karta_clena.Rodne_cisloTextBox.Text
        Me.Miesto_narodeniaTextBox.Text = karta_clena.Miesto_narodeniaTextBox.Text
        Me.Okres_narodeniaTextBox.Text = karta_clena.Okres_narodeniaTextBox.Text
        Me.BydliskoTextBox.Text = karta_clena.BydliskoTextBox.Text
        Me.PscTextBox.Text = karta_clena.PscTextBox.Text
        Me.Statna_prislusnostTextBox.Text = karta_clena.Statna_prislusnostTextBox.Text
        Me.Cislo_opTextBox.Text = karta_clena.Cislo_opTextBox.Text
        Me.Datum_vydania_opDateTimePicker.Text = karta_clena.Datum_vydania_opDateTimePicker.Text
        Me.Cislo_plTextBox.Text = karta_clena.Cislo_plTextBox.Text
        Me.Datum_vydania_plDateTimePicker.Text = karta_clena.Datum_vydania_plDateTimePicker.Text
        Me.Cislo_zpTextBox.Text = karta_clena.Cislo_zpTextBox.Text
        Me.Datum_vydania_zpDateTimePicker.Text = karta_clena.Datum_vydania_zpDateTimePicker.Text
        Me.Cislo_clenskeho_preukazu_spzTextBox.Text = karta_clena.Cislo_clenskeho_preukazu_spzTextBox.Text
        Me.Clen_spz_odDateTimePicker.Text = karta_clena.Clen_spz_odDateTimePicker.Text
        Me.Clen_pzTextBox.Text = karta_clena.Clen_pzTextBox.Text
        Me.Skuska_z_polovnictvaDateTimePicker.Text = karta_clena.Skuska_z_polovnictvaDateTimePicker.Text
        Me.Miesto_skusky_z__polovnictvaTextBox.Text = karta_clena.Miesto_skusky_z__polovnictvaTextBox.Text
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Text = karta_clena.Vyzsia_skuska_z_polovnictvaDateTimePicker.Text
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Text = karta_clena.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Text

    End Sub

    

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ToolStrip1.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToFile
        Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.ToolStrip1.Show()
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Me.ToolStrip1.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.Print(me,PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.ToolStrip1.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.ToolStrip1.Hide()
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToFile
        Me.PrintForm1.Print(me,PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
        Me.ToolStrip1.Show()
    End Sub
End Class