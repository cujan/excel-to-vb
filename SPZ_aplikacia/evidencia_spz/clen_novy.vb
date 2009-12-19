Public Class clen_novy

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub clen_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.SpzDataSet.statna_prislusnost)
        'TODO: This line of code loads data into the 'SpzDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.SpzDataSet.narodnost)
        'TODO: This line of code loads data into the 'SpzDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.SpzDataSet.titul_za)
        'TODO: This line of code loads data into the 'SpzDataSet.titul_pred' table. You can move, or remove it, as needed.
        Me.Titul_predTableAdapter.Fill(Me.SpzDataSet.titul_pred)
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)
        'TODO: This line of code loads data into the 'SpzDataSet.all_clenovia' table. You can move, or remove it, as needed.
        
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)



        If hlavna_aplikacia.zaregistrovatHospodara And hlavna_aplikacia.zaregistrovatPredsedu Then
            MsgBox("Doteraz nebol priradený predseda a hospodár pre združenie. Ak si prajete aspoň jedného z nich priradiť teraz, kliknite na tlačítko OK.", 4, "Otázka")
            If MsgBoxResult.Yes Then
                Me.label_predseda.Visible = True
                Me.ComboBox_predseda.Visible = True

                Me.ComboBox_predseda.SelectedItem = Me.ComboBox_predseda.Items.Item(1)
                Me.ComboBox_hospodar.SelectedItem = Me.ComboBox_hospodar.Items.Item(1)
            End If
        ElseIf hlavna_aplikacia.zaregistrovatHospodara And Not hlavna_aplikacia.zaregistrovatPredsedu Then
            MsgBox("Doteraz nebol priradený hospodár pre združenie. Ak si ho prajete priradiť teraz, kliknite na tlačítko OK.", 4, "Otázka")
            If MsgBoxResult.Yes Then
                Me.label_predseda.Visible = True
                Me.ComboBox_predseda.Visible = True

                Me.ComboBox_predseda.SelectedItem = Me.ComboBox_predseda.Items.Item(1)
                Me.ComboBox_hospodar.SelectedItem = Me.ComboBox_hospodar.Items.Item(1)
            End If
        ElseIf Not hlavna_aplikacia.zaregistrovatHospodara And hlavna_aplikacia.zaregistrovatPredsedu Then
            MsgBox("Doteraz nebol priradený predseda pre združenie. Ak si ho prajete priradiť teraz, kliknite na tlačítko OK.", 4, "Otázka")
            If MsgBoxResult.Yes Then
                Me.label_hospodar.Visible = True
                Me.ComboBox_hospodar.Visible = True

                Me.ComboBox_predseda.SelectedItem = Me.ComboBox_predseda.Items.Item(1)
                Me.ComboBox_hospodar.SelectedItem = Me.ComboBox_hospodar.Items.Item(1)
            End If
        End If


    End Sub

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Me.Clen_pzComboBox.SelectedValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz_clena_button.Click
        Dim ico_zdruzenia As String = Clen_pzComboBox.SelectedValue
        Dim ico_clenovia As String = ico_zdruzenia + "_clenovia"

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO """ & ico_zdruzenia & "_clenovia"" (cislo_pl, meno, priezvisko, datum_narodenia, rodne_cislo, miesto_narodenia, okres_narodenia, bydlisko, okres_bydliska, psc, telefon, cislo_op, datum_vydania_op, datum_vydania_pl, cislo_zp, datum_vydania_zp, cislo_clenskeho_preukazu_spz, clen_spz_od, clenske_do, cislo_dokladu_clenske, clen_pz, skuska_z_polovnictva, miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva, miesto_vyzsej_skusky_z_polovnictva, brokova_zbran, kontrolne_strelby_brok, gulova_zbran, kontrolne_strelby_gula, najvyzsie_vyznamenanie, vyznamenanie_kedy, udelene_tresty, poznamky, titul_pred_id, titul_za_id, narodnost_id, statna_prislusnost_id, ico_clenovia) VALUES (@cislo_pl,@meno,@priezvisko,@datum_narodenia,@rodne_cislo,@miesto_narodenia,@okres_narodenia,@bydlisko,@okres_bydliska,@psc,@telefon,@cislo_op,@datum_vydania_op,@datum_vydania_pl,@cislo_zp,@datum_vydania_zp,@cislo_clenskeho_preukazu_spz,@clen_spz_od,@clenske_do,@cislo_dokladu_clenske,@clen_pz,@skuska_z_polovnictva,@miesto_skusky_z_polovnictva,@skuska_pre_polovnych_hospodarov,@miesto_skusky_pre_polovnych_hospodarov,@vyzsia_skuska_z_polovnictva,@miesto_vyzsej_skusky_z_polovnictva,@brokova_zbran,@kontrolne_strelby_brok,@gulova_zbran,@kontrolne_strelby_gula,@najvyzsie_vyznamenanie,@vyznamenanie_kedy,@udelene_tresty,@poznamky,@titul_pred_id,@titul_za_id,@narodnost_id,@statna_prislusnost_id,@ico_clenovia)", con)

        With com.Parameters
            .AddWithValue("cislo_pl", Cislo_plTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)

            If Datum_narodeniaDateTimePicker.Checked = True Then
                .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value)
            Else
                .AddWithValue("datum_narodenia", DBNull.Value)
            End If

            .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
            .AddWithValue("miesto_narodenia", Miesto_narodeniaTextBox.Text)
            .AddWithValue("okres_narodenia", Okres_narodeniaTextBox.Text)
            .AddWithValue("bydlisko", BydliskoTextBox.Text)
            .AddWithValue("okres_bydliska", Okres_bydliskaTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("cislo_op", Cislo_opTextBox.Text)

            If Datum_vydania_opDateTimePicker.Checked = True Then
                .AddWithValue("datum_vydania_op", Datum_vydania_opDateTimePicker.Value)
            Else
                .AddWithValue("datum_vydania_op", DBNull.Value)
            End If
            If Datum_vydania_plDateTimePicker.Checked = True Then
                .AddWithValue("datum_vydania_pl", Datum_vydania_plDateTimePicker.Value)
            Else
                .AddWithValue("datum_vydania_pl", DBNull.Value)
            End If
            .AddWithValue("cislo_zp", Cislo_zpTextBox.Text)
            If Datum_vydania_zpDateTimePicker.Checked = True Then
                .AddWithValue("datum_vydania_zp", Datum_vydania_zpDateTimePicker.Value)
            Else
                .AddWithValue("datum_vydania_zp", DBNull.Value)
            End If
            .AddWithValue("cislo_clenskeho_preukazu_spz", Cislo_clenskeho_preukazu_spzTextBox.Text)
            .AddWithValue("clen_spz_od", Clen_spz_odTextBox.Text)
            .AddWithValue("clenske_do", Clenske_doTextBox.Text)
            .AddWithValue("cislo_dokladu_clenske", Cislo_dokladu_clenskeTextBox.Text)
            .AddWithValue("clen_pz", Clen_pzComboBox.SelectedValue)
            If Skuska_z_polovnictvaDateTimePicker.Checked = True Then
                .AddWithValue("skuska_z_polovnictva", Skuska_z_polovnictvaDateTimePicker.Value)
            Else
                .AddWithValue("skuska_z_polovnictva", DBNull.Value)
            End If
            .AddWithValue("miesto_skusky_z_polovnictva", Miesto_skusky_z_polovnictvaTextBox.Text)
            If Skuska_pre_polovnych_hospodarovDateTimePicker.Checked = True Then
                .AddWithValue("skuska_pre_polovnych_hospodarov", Skuska_pre_polovnych_hospodarovDateTimePicker.Value)
            Else
                .AddWithValue("skuska_pre_polovnych_hospodarov", DBNull.Value)
            End If
            .AddWithValue("miesto_skusky_pre_polovnych_hospodarov", Miesto_skusky_pre_polovnych_hospodarovTextBox.Text)
            If Vyzsia_skuska_z_polovnictvaDateTimePicker.Checked = True Then
                .AddWithValue("vyzsia_skuska_z_polovnictva", Vyzsia_skuska_z_polovnictvaDateTimePicker.Value)
            Else
                .AddWithValue("vyzsia_skuska_z_polovnictva", DBNull.Value)
            End If
            .AddWithValue("miesto_vyzsej_skusky_z_polovnictva", Miesto_vyzsej_skusky_z_polovnictvaTextBox.Text)
            .AddWithValue("brokova_zbran", Brokova_zbranTextBox.Text)
            .AddWithValue("kontrolne_strelby_brok", Kontrolne_strelby_brokTextBox.Text)
            .AddWithValue("gulova_zbran", Gulova_zbranTextBox.Text)
            .AddWithValue("kontrolne_strelby_gula", Kontrolne_strelby_gulaTextBox.Text)
            .AddWithValue("najvyzsie_vyznamenanie", Najvyzsie_vyznamenanieTextBox.Text)
            If Vyznamenanie_kedyDateTimePicker.Checked = True Then
                .AddWithValue("vyznamenanie_kedy", Vyznamenanie_kedyDateTimePicker.Value)
            Else
                .AddWithValue("vyznamenanie_kedy", DBNull.Value)
            End If
            .AddWithValue("udelene_tresty", Udelene_trestyTextBox.Text)
            .AddWithValue("poznamky", PoznamkyTextBox.Text)
            .AddWithValue("titul_pred_id", titul_predComboBox.SelectedValue)
            .AddWithValue("titul_za_id", titul_zaComboBox.SelectedValue)
            .AddWithValue("narodnost_id", narodnostComboBox.SelectedValue)
            .AddWithValue("statna_prislusnost_id", statna_prislusnostComboBox.SelectedValue)
            .AddWithValue("ico_clenovia", ico_clenovia)
        End With

        com.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()
    End Sub
End Class