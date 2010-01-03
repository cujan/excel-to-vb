Public Class clen_edituj

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.All_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.All_clenoviaDataSet)

    End Sub

    Private Sub clen_edituj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)

        Dim rodnecislo As String = clenovia_all.Label2.Text
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.FillBy_rodnecislo(Me.All_clenoviaDataSet.all_clenovia, rodnecislo)

        'nastavi pociatocnu hodnotu datumu narodenia

        If Datum_narodeniaTextBox.Text = "" Then
            datum_narodeniaDateTimePicker.Checked = False
        Else
            datum_narodeniaDateTimePicker.Value = Datum_narodeniaTextBox.Text

        End If
        'nastavi pociatocnu hodnotu datumu vydania op

        If Datum_vydania_opTextBox.Text = "" Then
            Datum_vydania_opDateTimePicker.Checked = False
        Else
            Datum_vydania_opDateTimePicker.Value = Datum_vydania_opTextBox.Text
        End If
        'nastavi pociatocnu hodnotu datumu vydania pl

        If Datum_vydania_plTextBox.Text = "" Then
            Datum_vydania_plDateTimePicker.Checked = False
        Else
            Datum_vydania_plDateTimePicker.Value = Datum_vydania_plTextBox.Text
        End If
        'nastavi pociatocnu hodnotu datumu vydania zp

        If Datum_vydania_zpTextBox.Text = "" Then
            Datum_vydania_zpDateTimePicker.Checked = False
        Else
            Datum_vydania_zpDateTimePicker.Value = Datum_vydania_zpTextBox.Text
        End If

        'nastavi pociatocnu hodntu combo boxu clen_pz

        If Clen_pzTextBox.Text = "" Then
            clen_pzComboBox.SelectedValue = 0
        Else
            clen_pzComboBox.SelectedValue = Clen_pzTextBox.Text

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim nazov_tabulky As String = Ico_clenoviaTextBox.Text

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("UPDATE""" & nazov_tabulky & """SET  cislo_pl = @cislo_pl, meno = @meno, priezvisko = @priezvisko, datum_narodenia = @datum_narodenia, rodne_cislo = @rodne_cislo, miesto_narodenia = @miesto_narodenia, okres_narodenia = @okres_narodenia, bydlisko = @bydlisko, okres_bydliska = @okres_bydliska, psc = @psc, telefon = @telefon, cislo_op = @cislo_op, datum_vydania_op = @datum_vydania_op, datum_vydania_pl = @datum_vydania_pl, cislo_zp = @cislo_zp, datum_vydania_zp = @datum_vydania_zp, cislo_clenskeho_preukazu_spz = @cislo_clenskeho_preukazu_spz, clen_spz_od = @clen_spz_od, clenske_do = @clenske_do, cislo_dokladu_clenske = @cislo_dokladu_clenske, clen_pz = @clen_pz, skuska_z_polovnictva = @skuska_z_polovnictva, miesto_skusky_z_polovnictva = @miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov = @skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov = @miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva = @vyzsia_skuska_z_polovnictva, miesto_vyzsej_skusky_z_polovnictva = @miesto_vyzsej_skusky_z_polovnictva, brokova_zbran = @brokova_zbran, kontrolne_strelby_brok = @kontrolne_strelby_brok, gulova_zbran = @gulova_zbran, kontrolne_strelby_gula = @kontrolne_strelby_gula, najvyzsie_vyznamenanie = @najvyzsie_vyznamenanie, vyznamenanie_kedy = @vyznamenanie_kedy, udelene_tresty = @udelene_tresty, poznamky = @poznamky, titul_pred_id = @titul_pred_id, titul_za_id = @titul_za_id, narodnost_id = @narodnost_id, statna_prislusnost_id = @statna_prislusnost_id, ico_clenovia = @ico_clenovia WHERE rodne_cislo = @rodne_cislo ", con)
        With com.Parameters
            .AddWithValue("cislo_pl", Cislo_plTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            If datum_narodeniaDateTimePicker.Checked = False Then
                .AddWithValue("datum_narodenia", DBNull.Value)
            Else
                .AddWithValue("datum_narodenia", datum_narodeniaDateTimePicker.Value)
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


            If Clen_spz_odTextBox.Text = "" Then
                .AddWithValue("clen_spz_od", DBNull.Value)

            Else
                .AddWithValue("clen_spz_od", Clen_spz_odTextBox.Text)
            End If

            If Clenske_doTextBox.Text = "" Then
                .AddWithValue("clenske_do", DBNull.Value)
            Else
                .AddWithValue("clenske_do", Clenske_doTextBox.Text)
            End If
            .AddWithValue("cislo_dokladu_clenske", Cislo_dokladu_clenskeTextBox.Text)
            If clen_pzComboBox.SelectedValue = 0 Then
                .AddWithValue("clen_pz", DBNull.Value)
            Else
                .AddWithValue("clen_pz", clen_pzComboBox.SelectedValue)
            End If
            .AddWithValue("skuska_z_polovnictva", Skuska_z_polovnictvaDateTimePicker.Text)
            .AddWithValue("miesto_skusky_z_polovnictva", Miesto_skusky_z_polovnictvaTextBox.Text)

            .AddWithValue("skuska_pre_polovnych_hospodarov", Skuska_pre_polovnych_hospodarovDateTimePicker.Text)
            .AddWithValue("miesto_skusky_pre_polovnych_hospodarov", Miesto_skusky_pre_polovnych_hospodarovTextBox.Text)

            .AddWithValue("vyzsia_skuska_z_polovnictva", Vyzsia_skuska_z_polovnictvaDateTimePicker.Text)
            .AddWithValue("miesto_vyzsej_skusky_z_polovnictva", Miesto_vyzsej_skusky_z_polovnictvaTextBox.Text)
            .AddWithValue("brokova_zbran", Brokova_zbranTextBox.Text)

            If Kontrolne_strelby_brokTextBox.Text = "" Then
                .AddWithValue("kontrolne_strelby_brok", DBNull.Value)
            Else
                .AddWithValue("kontrolne_strelby_brok", Kontrolne_strelby_brokTextBox.Text)
            End If
            .AddWithValue("gulova_zbran", Gulova_zbranTextBox.Text)
            If Kontrolne_strelby_gulaTextBox.Text = "" Then
                .AddWithValue("kontrolne_strelby_gula", DBNull.Value)
            Else
                .AddWithValue("kontrolne_strelby_gula", Kontrolne_strelby_gulaTextBox.Text)
            End If
            .AddWithValue("najvyzsie_vyznamenanie", Najvyzsie_vyznamenanieTextBox.Text)

            .AddWithValue("vyznamenanie_kedy", Vyznamenanie_kedyDateTimePicker.Text)
            .AddWithValue("udelene_tresty", Udelene_trestyTextBox.Text)
            .AddWithValue("poznamky", PoznamkyTextBox.Text)
            If Titul_pred_idTextBox.Text = "" Then
                .AddWithValue("titul_pred_id", DBNull.Value)
            Else
                .AddWithValue("titul_pred_id", Titul_pred_idTextBox.Text)
            End If
            If Titul_za_idTextBox.Text = "" Then
                .AddWithValue("titul_za_id", DBNull.Value)
            Else
                .AddWithValue("titul_za_id", Titul_za_idTextBox.Text)
            End If
            If Narodnost_idTextBox.Text = "" Then
                .AddWithValue("narodnost_id", DBNull.Value)
            Else
                .AddWithValue("narodnost_id", Narodnost_idTextBox.Text)
            End If
            If Statna_prislusnost_idTextBox.Text = "" Then
                .AddWithValue("statna_prislusnost_id", DBNull.Value)
            Else
                .AddWithValue("statna_prislusnost_id", Statna_prislusnost_idTextBox.Text)
            End If
            .AddWithValue("ico_clenovia", Ico_clenoviaTextBox.Text)


        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        hlavna_aplikacia.vytvor_all_clenovia()
        clenovia_all.All_clenoviaTableAdapter.Fill(clenovia_all.All_clenoviaDataSet.all_clenovia)
    End Sub
End Class