Public Class detaily_zdruzenia

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzenieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub detaily_zdruzenia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Dim id_zdruzenia As Integer = prehlad_zdruzeni.Label1.Text
        Me.ZdruzenieTableAdapter.FillBy_id(Me.ZdruzenieDataSet.zdruzenie, id_zdruzenia)

        'Dim pozicia_zdruzenia As Integer = prehlad_zdruzeni.ZdruzenieBindingSource.Position
        'Me.ZdruzenieBindingSource.Position = pozicia_zdruzenia
        'Me.ZdruzenieBindingSource.Position = prehlad_zdruzeni.Label2.Text - 1

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        prehlad_zdruzeni.prehlad_clenov_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravitButton.Click
        Me.BankaTextBox.ReadOnly = False
        Me.BazantTextBox.ReadOnly = False
        Me.Cislo_reviruTextBox.ReadOnly = False
        Me.Cislo_uctuTextBox.ReadOnly = False
        Me.DicTextBox.ReadOnly = False
        Me.DiviaciaTextBox.ReadOnly = False
        Me.Chovatelska_oblastTextBox.ReadOnly = False
        Me.IcoTextBox.ReadOnly = False
        Me.InaTextBox.ReadOnly = False
        Me.JeleniaTextBox.ReadOnly = False
        Me.LesTextBox.ReadOnly = False
        Me.Nazov_polovneho_reviruTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.Polovnicky_hospodar_telefonTextBox.ReadOnly = False
        Me.Polovnicky_hospodarTextBox.ReadOnly = False
        Me.Predseda_telefonTextBox.ReadOnly = False
        Me.PredsedaTextBox.ReadOnly = False
        Me.SidloTextBox.ReadOnly = False
        Me.VymeraTextBox.ReadOnly = False
        Me.SrnciaTextBox.ReadOnly = False
        Me.Platnost_najomnej_zmluvy_doTextBox.ReadOnly = False

        Me.Stavace_planTextBox.ReadOnly = False
        Me.Stavace_skutocnostTextBox.ReadOnly = False
        Me.Sliedice_planTextBox.ReadOnly = False
        Me.Sliedice_skutocnostTextBox.ReadOnly = False
        Me.Slovensky_kopov_planTextBox.ReadOnly = False
        Me.Slovensky_kopov_skutocnostTextBox.ReadOnly = False
        Me.Ostatne_durice_planTextBox.ReadOnly = False
        Me.Ostatne_durice_skutocnostTextBox.ReadOnly = False
        Me.Brlohare_planTextBox.ReadOnly = False
        Me.Brlohare_skutocnostTextBox.ReadOnly = False
        Me.Farbiare_planTextBox.ReadOnly = False
        Me.Farbiare_skutocnostTextBox.ReadOnly = False
        Me.Pes_jelenia_planTextBox.ReadOnly = False
        Me.Pes_jelenia_skutocnostTextBox.ReadOnly = False
        Me.Pes_diviacia_planTextBox.ReadOnly = False
        Me.Pes_diviacia_skutocnostTextBox.ReadOnly = False
        Me.Pes_srncia_planTextBox.ReadOnly = False
        Me.Pes_srncia_skutocnostTextBox.ReadOnly = False
        Me.Pes_mala_planTextBox.ReadOnly = False
        Me.Pes_mala_skutocnostTextBox.ReadOnly = False

        Me.upravitButton.Visible = False
        Me.ulozButton.Visible = True
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

        Me.BankaTextBox.ReadOnly = True
        Me.BazantTextBox.ReadOnly = True
        Me.Cislo_reviruTextBox.ReadOnly = True
        Me.Cislo_uctuTextBox.ReadOnly = True
        Me.DicTextBox.ReadOnly = True
        Me.DiviaciaTextBox.ReadOnly = True
        Me.Chovatelska_oblastTextBox.ReadOnly = True
        Me.IcoTextBox.ReadOnly = True
        Me.InaTextBox.ReadOnly = True
        Me.JeleniaTextBox.ReadOnly = True
        Me.LesTextBox.ReadOnly = True
        Me.Nazov_polovneho_reviruTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.Polovnicky_hospodar_telefonTextBox.ReadOnly = True
        Me.Polovnicky_hospodarTextBox.ReadOnly = True
        Me.Predseda_telefonTextBox.ReadOnly = True
        Me.PredsedaTextBox.ReadOnly = True
        Me.SidloTextBox.ReadOnly = True
        Me.VymeraTextBox.ReadOnly = True
        Me.SrnciaTextBox.ReadOnly = True
        Me.Platnost_najomnej_zmluvy_doTextBox.ReadOnly = True

        Me.Stavace_planTextBox.ReadOnly = True
        Me.Stavace_skutocnostTextBox.ReadOnly = True
        Me.Sliedice_planTextBox.ReadOnly = True
        Me.Sliedice_skutocnostTextBox.ReadOnly = True
        Me.Slovensky_kopov_planTextBox.ReadOnly = True
        Me.Slovensky_kopov_skutocnostTextBox.ReadOnly = True
        Me.Ostatne_durice_planTextBox.ReadOnly = True
        Me.Ostatne_durice_skutocnostTextBox.ReadOnly = True
        Me.Brlohare_planTextBox.ReadOnly = True
        Me.Brlohare_skutocnostTextBox.ReadOnly = True
        Me.Farbiare_planTextBox.ReadOnly = True
        Me.Farbiare_skutocnostTextBox.ReadOnly = True
        Me.Pes_jelenia_planTextBox.ReadOnly = True
        Me.Pes_jelenia_skutocnostTextBox.ReadOnly = True
        Me.Pes_diviacia_planTextBox.ReadOnly = True
        Me.Pes_diviacia_skutocnostTextBox.ReadOnly = True
        Me.Pes_srncia_planTextBox.ReadOnly = True
        Me.Pes_srncia_skutocnostTextBox.ReadOnly = True
        Me.Pes_mala_planTextBox.ReadOnly = True
        Me.Pes_mala_skutocnostTextBox.ReadOnly = True

        prehlad_zdruzeni.ZdruzenieTableAdapter.Fill(prehlad_zdruzeni.ZdruzenieDataSet.zdruzenie)

        Me.ulozButton.Visible = False
        Me.upravitButton.Visible = True


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub Nazov_polovneho_reviruTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nazov_polovneho_reviruTextBox.TextChanged

    End Sub
End Class