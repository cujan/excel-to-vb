Public Class detaily_clena

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub detaily_clena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PrehladDataSet.clenovia' table. You can move, or remove it, as needed.
        Dim id_clena As Integer = evidencia_clenov.Label1.Text
        Me.ClenoviaTableAdapter1.Fill(Me.DetailClenaDataSet.clenovia, id_clena)


        'Me.ClenoviaBindingSource.Position = pozicia

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        prehlad_clenov.prehlad_clenov_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prehlad_clenovDataSet)

    End Sub

    Private Sub uprav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravbutton.Click
        'nastavi readonly u texboxov na true
        Me.Brokova_zbranTextBox.ReadOnly = False
        Me.Cislo_clenskeho_preukazu_spzTextBox.ReadOnly = False
        Me.Cislo_dokladu_clenskeTextBox.ReadOnly = False
        Me.Cislo_opTextBox.ReadOnly = False
        Me.Cislo_plTextBox.ReadOnly = False
        Me.Cislo_zpTextBox.ReadOnly = False
        Me.Clen_spz_odTextBox.ReadOnly = False
        Me.Clenske_doTextBox.ReadOnly = False
        Me.Datum_narodeniaTextBox.ReadOnly = False
        Me.Datum_vydania_opTextBox.ReadOnly = False
        Me.Datum_vydania_plTextBox.ReadOnly = False
        Me.Datum_vydania_zpTextBox.ReadOnly = False
        Me.Gulova_zbranTextBox.ReadOnly = False
        Me.Kontrolne_strelby_brokTextBox.ReadOnly = False
        Me.Kontrolne_strelby_gulova_zbranTextBox.ReadOnly = False
        Me.MenoTextBox.ReadOnly = False
        Me.Miesto_narodeniaTextBox.ReadOnly = False
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.ReadOnly = False
        Me.Miesto_skusky_z__polovnictvaTextBox.ReadOnly = False
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = False
        Me.Najv_vyznamenanieTextBox.ReadOnly = False
        Me.NarodnostTextBox.ReadOnly = False
        Me.Okres_bydliskaTextBox.ReadOnly = False
        Me.Okres_narodeniaTextBox.ReadOnly = False
        Me.BydliskoTextBox.ReadOnly = False
        Me.PoznamkyTextBox.ReadOnly = False
        Me.PriezviskoTextBox.ReadOnly = False
        Me.PscTextBox.ReadOnly = False
        Me.Rodne_cisloTextBox.ReadOnly = False
        Me.Skuska_pre_polovnych_hospodarovTextBox.ReadOnly = False
        Me.Skuska_z_polovnictvaTextBox.ReadOnly = False
        Me.Statna_prislusnostTextBox.ReadOnly = False
        Me.TelefonTextBox.ReadOnly = False
        Me.Titul_predTextBox.ReadOnly = False
        Me.Titul_zaTextBox.ReadOnly = False
        Me.Udelene_trestyTextBox.ReadOnly = False
        Me.Vyznamenany_kedyTextBox.ReadOnly = False
        Me.Vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = False
        Me.Clen_pzTextBox.ReadOnly = False

        Me.upravbutton.Visible = False
        Me.ulozButton.Visible = True
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prehlad_clenovDataSet)

        Me.ulozButton.Visible = False
        Me.upravbutton.Visible = True

        'nastavi readonly u texboxov na true
        Me.Brokova_zbranTextBox.ReadOnly = True
        Me.Cislo_clenskeho_preukazu_spzTextBox.ReadOnly = True
        Me.Cislo_dokladu_clenskeTextBox.ReadOnly = True
        Me.Cislo_opTextBox.ReadOnly = True
        Me.Cislo_plTextBox.ReadOnly = True
        Me.Cislo_zpTextBox.ReadOnly = True
        Me.Clen_spz_odTextBox.ReadOnly = True
        Me.Clenske_doTextBox.ReadOnly = True
        Me.Datum_narodeniaTextBox.ReadOnly = True
        Me.Datum_vydania_opTextBox.ReadOnly = True
        Me.Datum_vydania_plTextBox.ReadOnly = True
        Me.Datum_vydania_zpTextBox.ReadOnly = True
        Me.Gulova_zbranTextBox.ReadOnly = True
        Me.Kontrolne_strelby_brokTextBox.ReadOnly = True
        Me.Kontrolne_strelby_gulova_zbranTextBox.ReadOnly = True
        Me.MenoTextBox.ReadOnly = True
        Me.Miesto_narodeniaTextBox.ReadOnly = True
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.ReadOnly = True
        Me.Miesto_skusky_z__polovnictvaTextBox.ReadOnly = True
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Najv_vyznamenanieTextBox.ReadOnly = True
        Me.NarodnostTextBox.ReadOnly = True
        Me.Okres_bydliskaTextBox.ReadOnly = True
        Me.Okres_narodeniaTextBox.ReadOnly = True
        Me.BydliskoTextBox.ReadOnly = True
        Me.PoznamkyTextBox.ReadOnly = True
        Me.PriezviskoTextBox.ReadOnly = True
        Me.PscTextBox.ReadOnly = True
        Me.Rodne_cisloTextBox.ReadOnly = True
        Me.Skuska_pre_polovnych_hospodarovTextBox.ReadOnly = True
        Me.Skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Statna_prislusnostTextBox.ReadOnly = True
        Me.TelefonTextBox.ReadOnly = True
        Me.Titul_predTextBox.ReadOnly = True
        Me.Titul_zaTextBox.ReadOnly = True
        Me.Udelene_trestyTextBox.ReadOnly = True
        Me.Vyznamenany_kedyTextBox.ReadOnly = True
        Me.Vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Clen_pzTextBox.ReadOnly = True
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub FillToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub
End Class