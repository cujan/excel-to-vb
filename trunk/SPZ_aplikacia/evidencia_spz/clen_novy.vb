Public Class clen_novy

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub clen_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)
        'TODO: This line of code loads data into the 'SpzDataSet.all_clenovia' table. You can move, or remove it, as needed.
        

    End Sub

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Me.Clen_pzComboBox.SelectedValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ico_zdruzenia As String = Clen_pzComboBox.SelectedValue

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO """ & ico_zdruzenia & "_clenovia"" (cislo_pl, meno, priezvisko, datum_narodenia, rodne_cislo, miesto_narodenia, okres_narodenia, bydlisko, okres_bydliska, psc, telefon, cislo_op, datum_vydania_op, datum_vydania_pl, cislo_zp, datum_vydania_zp, cislo_clenskeho_preukazu_spz, clen_spz_od, clenske_do, cislo_dokladu_clenske, clen_pz, skuska_z_polovnictva, miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva, miesto_vyzsej_skusky_z_polovnictva, brokova_zbran, kontrolne_strelby_brok, gulova_zbran, kontrolne_strelby_gula, najvyzsie_vyznamenanie, vyznamenanie_kedy, udelene_tresty, poznamky, titul_pred_id, titul_za_id, narodnost_id, statna_prislusnost_id) VALUES (@cislo_pl,@meno,@priezvisko,@datum_narodenia,@rodne_cislo,@miesto_narodenia,@okres_narodenia,@bydlisko,@okres_bydliska,@psc,@telefon,@cislo_op,@datum_vydania_op,@datum_vydania_pl,@cislo_zp,@datum_vydania_zp,@cislo_clenskeho_preukazu_spz,@clen_spz_od,@clenske_do,@cislo_dokladu_clenske,@clen_pz,@skuska_z_polovnictva,@miesto_skusky_z_polovnictva,@skuska_pre_polovnych_hospodarov,@miesto_skusky_pre_polovnych_hospodarov,@vyzsia_skuska_z_polovnictva,@miesto_vyzsej_skusky_z_polovnictva,@brokova_zbran,@kontrolne_strelby_brok,@gulova_zbran,@kontrolne_strelby_gula,@najvyzsie_vyznamenanie,@vyznamenanie_kedy,@udelene_tresty,@poznamky,@titul_pred_id,@titul_za_id,@narodnost_id,@statna_prislusnost_id)", con)

        With com.Parameters
            .AddWithValue("cislo_pl", Cislo_plTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value)
            .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
            .AddWithValue("miesto_narodenia", Miesto_narodeniaTextBox.Text)
            .AddWithValue("okres_narodenia", Okres_narodeniaTextBox.Text)
            .AddWithValue("bydlisko", BydliskoTextBox.Text)
            .AddWithValue("okres_bydliska", Okres_bydliskaTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("cislo_op", Cislo_opTextBox.Text)
            .AddWithValue("datum_vydania_op", Datum_vydania_opDateTimePicker.Value)
            .AddWithValue("datum_vydania_pl", Datum_vydania_plDateTimePicker.Value)
            .AddWithValue("cislo_zp", Cislo_zpTextBox.Text)
            .AddWithValue("datum_vydania_zp", Datum_vydania_zpDateTimePicker.Value)
            .AddWithValue("cislo_clenskeho_preukazu_spz", Cislo_clenskeho_preukazu_spzTextBox.Text)
            .AddWithValue("clen_spz_od", Clen_spz_odTextBox.Text)
            .AddWithValue("clenske_do", Clenske_doTextBox.Text)
            .AddWithValue("cislo_dokladu_clenske", Cislo_dokladu_clenskeTextBox.Text)
            .AddWithValue("clen_pz", Clen_pzComboBox.SelectedValue)
            .AddWithValue("skuska_z_polovnictva", Skuska_z_polovnictvaDateTimePicker.Value)
            .AddWithValue("miesto_skusky_z_polovnictva", Miesto_skusky_z_polovnictvaTextBox.Text)
            .AddWithValue("skuska_pre_polovnych_hospodarov", Skuska_pre_polovnych_hospodarovDateTimePicker.Value)
            .AddWithValue("miesto_skusky_pre_polovnych_hospodarov", Miesto_skusky_pre_polovnych_hospodarovTextBox.Text)
            .AddWithValue("vyzsia_skuska_z_polovnictva", Vyzsia_skuska_z_polovnictvaDateTimePicker.Value)
            .AddWithValue("miesto_vyzsej_skusky_z_polovnictva", Miesto_vyzsej_skusky_z_polovnictvaTextBox.Text)
            .AddWithValue("brokova_zbran", Brokova_zbranTextBox.Text)
            .AddWithValue("kontrolne_strelby_brok", Kontrolne_strelby_brokTextBox.Text)
            .AddWithValue("gulova_zbran", Gulova_zbranTextBox.Text)
            .AddWithValue("kontrolne_strelby_gula", Kontrolne_strelby_gulaTextBox.Text)
            .AddWithValue("najvyzsie_vyznamenanie", Najvyzsie_vyznamenanieTextBox.Text)
            .AddWithValue("vyznamenanie_kedy", Vyznamenanie_kedyDateTimePicker.Value)
            .AddWithValue("udelene_tresty", Udelene_trestyTextBox.Text)
            .AddWithValue("poznamky", PoznamkyTextBox.Text)
            .AddWithValue("titul_pred_id", Titul_pred_idTextBox.Text)
            .AddWithValue("titul_za_id", Titul_za_idTextBox.Text)
            .AddWithValue("narodnost_id", Narodnost_idTextBox.Text)
            .AddWithValue("statna_prislusnost_id", Statna_prislusnost_idTextBox.Text)

        End With

        com.ExecuteNonQuery()
        con.Close()
    End Sub
End Class