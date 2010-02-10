Public Class clen_edituj

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.All_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.All_clenoviaDataSet)

    End Sub

    Private Sub clen_edituj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.SpzDataSet.statna_prislusnost)
        'TODO: This line of code loads data into the 'SpzDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.SpzDataSet.narodnost)
        'TODO: This line of code loads data into the 'SpzDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.SpzDataSet.titul_za)
        'TODO: This line of code loads data into the 'SpzDataSet.titul_pred' table. You can move, or remove it, as needed.
        Me.Titul_predTableAdapter.Fill(Me.SpzDataSet.titul_pred)
        'TODO: This line of code loads data into the 'ObceDataSet.ciselnik_obce' table. You can move, or remove it, as needed.
        Me.Ciselnik_obceTableAdapter.Fill(Me.ObceDataSet.ciselnik_obce)
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
            clen_pzComboBox.SelectedIndex = -1
        Else
            clen_pzComboBox.SelectedValue = Clen_pzTextBox.Text

        End If

        'nastavi pociatocnu hodnotu skuska z polovnictva

        If Skuska_z_polovnictvaTextBox.Text = "" Then
            Skuska_z_polovnictvaDateTimePicker.Checked = False
        Else
            Skuska_z_polovnictvaDateTimePicker.Value = Skuska_z_polovnictvaTextBox.Text
        End If

        'nastavi pociatocnu hodnotu skuska polovnych hospodarov
        If Skuska_pre_polovnych_hospodarovTextBox.Text = "" Then
            Skuska_pre_polovnych_hospodarovDateTimePicker.Checked = False
        Else
            Skuska_pre_polovnych_hospodarovDateTimePicker.Value = Skuska_pre_polovnych_hospodarovTextBox.Text
        End If

        'nastavi pociatocnu hodnotu vyzsia skuska z polovnictva
        If Vyzsia_skuska_z_polovnictvaTextBox.Text = "" Then
            Vyzsia_skuska_z_polovnictvaDateTimePicker.Checked = False
        Else
            Vyzsia_skuska_z_polovnictvaDateTimePicker.Value = Vyzsia_skuska_z_polovnictvaTextBox.Text
        End If

        'nastavi pociatocnu hodnotu vyznamenanie kedy
        If Vyznamenanie_kedyTextBox.Text = "" Then
            Vyznamenanie_kedyDateTimePicker.Checked = False
        Else
            Vyznamenanie_kedyDateTimePicker.Value = Vyznamenanie_kedyTextBox.Text
        End If

        'nastavi pociatocnu hodnotu titul_pred

        If Titul_pred_idTextBox.Text = "" Then
            Titul_pred_idComboBox.SelectedValue = 0
        Else
            Titul_pred_idComboBox.SelectedValue = Titul_pred_idTextBox.Text

        End If
        'nastavi pociatocnu hodnotu titul_za

        If Titul_za_idTextBox.Text = "" Then
            Titul_za_idComboBox.SelectedValue = 0
        Else
            Titul_za_idComboBox.SelectedValue = Titul_za_idTextBox.Text

        End If
        'nastavi pociatocnu hodnotu narodnost_id

        If Narodnost_idTextBox.Text = "" Then
            Narodnost_idComboBox.SelectedValue = 0
        Else
            Narodnost_idComboBox.SelectedValue = Narodnost_idTextBox.Text

        End If
        'nastavi pociatocnu hodnotu statna_prislusnost_id

        If Statna_prislusnost_idTextBox.Text = "" Then
            Statna_prislusnost_idComboBox.SelectedValue = 0
        Else
            Statna_prislusnost_idComboBox.SelectedValue = Statna_prislusnost_idTextBox.Text

        End If
        'vybere pri nacitani formu aktualnu hodnotu v okres a psc listbox

        If Okres_bydliskaTextBox.Text <> "" Then
            Okres_bydliskaListBox.SelectedIndex = -1
        End If

        If PscTextBox.Text <> "" Then
            PscListBox.SelectedIndex = -1
        End If

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim chyba As String
        kontrola_vstupnych_udajov_clena(PriezviskoTextBox.Text, Rodne_cisloMaskedTextBox.Text, Clen_spz_odTextBox.Text, Clenske_doTextBox.Text, Kontrolne_strelby_brokTextBox.Text, Kontrolne_strelby_gulaTextBox.Text, MestoComboBox.SelectedValue, Okres_bydliskaListBox.SelectedItem, PscListBox.SelectedItem, chyba)


        If chyba.Length = 0 Then

            Dim nazov_tabulky As String = Ico_clenoviaTextBox.Text

            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("UPDATE""" & nazov_tabulky & """SET  cislo_pl = @cislo_pl, meno = @meno, priezvisko = @priezvisko, datum_narodenia = @datum_narodenia, rodne_cislo = @rodne_cislo, miesto_narodenia = @miesto_narodenia, okres_narodenia = @okres_narodenia, okres_bydliska = @okres_bydliska, psc = @psc, telefon = @telefon, cislo_op = @cislo_op, datum_vydania_op = @datum_vydania_op, datum_vydania_pl = @datum_vydania_pl, cislo_zp = @cislo_zp, datum_vydania_zp = @datum_vydania_zp, cislo_clenskeho_preukazu_spz = @cislo_clenskeho_preukazu_spz, clen_spz_od = @clen_spz_od, clenske_do = @clenske_do, cislo_dokladu_clenske = @cislo_dokladu_clenske, clen_pz = @clen_pz, skuska_z_polovnictva = @skuska_z_polovnictva, miesto_skusky_z_polovnictva = @miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov = @skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov = @miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva = @vyzsia_skuska_z_polovnictva, miesto_vyzsej_skusky_z_polovnictva = @miesto_vyzsej_skusky_z_polovnictva, brokova_zbran = @brokova_zbran, kontrolne_strelby_brok = @kontrolne_strelby_brok, gulova_zbran = @gulova_zbran, kontrolne_strelby_gula = @kontrolne_strelby_gula, najvyzsie_vyznamenanie = @najvyzsie_vyznamenanie, vyznamenanie_kedy = @vyznamenanie_kedy, udelene_tresty = @udelene_tresty, poznamky = @poznamky, titul_pred_id = @titul_pred_id, titul_za_id = @titul_za_id, narodnost_id = @narodnost_id, statna_prislusnost_id = @statna_prislusnost_id, ico_clenovia = @ico_clenovia, mesto = @mesto, ulica = @ulica, ulica_cislo = @ulica_cislo WHERE rodne_cislo = @rodne_cislo ", con)
            With com.Parameters
                .AddWithValue("cislo_pl", Cislo_plTextBox.Text)
                .AddWithValue("meno", MenoTextBox.Text)
                .AddWithValue("priezvisko", PriezviskoTextBox.Text)
                If datum_narodeniaDateTimePicker.Checked = False Then
                    .AddWithValue("datum_narodenia", DBNull.Value)
                Else
                    .AddWithValue("datum_narodenia", datum_narodeniaDateTimePicker.Value)
                End If
                .AddWithValue("rodne_cislo", Rodne_cisloMaskedTextBox.Text)
                .AddWithValue("miesto_narodenia", Miesto_narodeniaTextBox.Text)
                .AddWithValue("okres_narodenia", Okres_narodeniaTextBox.Text)
                .AddWithValue("okres_bydliska", Okres_bydliskaListBox.SelectedItem)
                .AddWithValue("psc", PscListBox.SelectedItem)
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


                If Brokova_zbranComboBox.Text = "" Then
                    .AddWithValue("brokova_zbran", DBNull.Value)
                Else
                    .AddWithValue("brokova_zbran", Brokova_zbranComboBox.Text)
                End If
                If Kontrolne_strelby_brokTextBox.Text = "" Then
                    .AddWithValue("kontrolne_strelby_brok", DBNull.Value)
                Else
                    .AddWithValue("kontrolne_strelby_brok", Kontrolne_strelby_brokTextBox.Text)
                End If
                If Gulova_zbranComboBox.Text = "" Then
                    .AddWithValue("gulova_zbran", DBNull.Value)
                Else
                    .AddWithValue("gulova_zbran", Gulova_zbranComboBox.Text)
                End If
                If Kontrolne_strelby_gulaTextBox.Text = "" Then
                    .AddWithValue("kontrolne_strelby_gula", DBNull.Value)
                Else
                    .AddWithValue("kontrolne_strelby_gula", Kontrolne_strelby_gulaTextBox.Text)
                End If
                .AddWithValue("najvyzsie_vyznamenanie", Najvyzsie_vyznamenanieTextBox.Text)

                If Vyznamenanie_kedyDateTimePicker.Checked = True Then
                    .AddWithValue("vyznamenanie_kedy", Vyznamenanie_kedyDateTimePicker.Value)
                Else
                    .AddWithValue("vyznamenanie_kedy", DBNull.Value)
                End If
                .AddWithValue("udelene_tresty", Udelene_trestyTextBox.Text)
                .AddWithValue("poznamky", PoznamkyTextBox.Text)
                If Titul_pred_idComboBox.SelectedValue = 0 Then
                    .AddWithValue("titul_pred_id", DBNull.Value)
                Else
                    .AddWithValue("titul_pred_id", Titul_pred_idComboBox.SelectedValue)
                End If
                If Titul_za_idComboBox.SelectedValue = 0 Then
                    .AddWithValue("titul_za_id", DBNull.Value)
                Else
                    .AddWithValue("titul_za_id", Titul_za_idComboBox.SelectedValue)
                End If
                If Narodnost_idComboBox.SelectedValue = 0 Then
                    .AddWithValue("narodnost_id", DBNull.Value)
                Else
                    .AddWithValue("narodnost_id", Narodnost_idComboBox.SelectedValue)
                End If
                If Statna_prislusnost_idComboBox.SelectedValue = 0 Then
                    .AddWithValue("statna_prislusnost_id", DBNull.Value)
                Else
                    .AddWithValue("statna_prislusnost_id", Statna_prislusnost_idComboBox.SelectedValue)
                End If
                .AddWithValue("ico_clenovia", Ico_clenoviaTextBox.Text)
                If MestoComboBox.SelectedValue = "" Then
                    .AddWithValue("mesto", DBNull.Value)
                Else
                    .AddWithValue("mesto", MestoComboBox.SelectedValue)
                End If
                .AddWithValue("ulica", UlicaTextBox.Text)
                .AddWithValue("ulica_cislo", Ulica_cisloTextBox.Text)

            End With

            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            hlavna_aplikacia.vytvor_all_clenovia()
            clenovia_all.All_clenoviaTableAdapter.Fill(clenovia_all.All_clenoviaDataSet.all_clenovia)
            MsgBox("Člen bol úspešne upravený.")
            hlavna_aplikacia.removeFormFromList(Me.Text)
            Me.Close()
        Else
            MsgBox("Mate chybne vyplnene tieto polia: " + vbNewLine + vbNewLine + chyba, MsgBoxStyle.Critical, "upozornenie")
        End If
    End Sub

    Private Sub MestoComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MestoComboBox.Leave

        If MestoComboBox.SelectedValue = "" Then
            Okres_bydliskaTextBox.Text = ""
            PscTextBox.Text = ""
        End If

    End Sub

    Private Sub MestoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MestoComboBox.SelectedIndexChanged
        If MestoComboBox.SelectedValue <> "" Then
            Okres_bydliskaListBox.Items.Clear()
            PscListBox.Items.Clear()
            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("SELECT okres, psc FROM ciselnik_obce WHERE obec = @obec ", con)
            com.Parameters.AddWithValue("obec", MestoComboBox.SelectedValue)
            Dim psc As String
            Dim okres As String

            con.Open()
            Try
                Dim rdr As SqlCeDataReader = com.ExecuteReader
                While rdr.Read


                    okres = rdr.GetString(0)
                    psc = rdr.GetString(1)



                    Me.PscListBox.Items.Add(psc)
                    Me.Okres_bydliskaListBox.Items.Add(okres)



                End While


                rdr.Close()
                con.Close()
            Catch
                con.Close()
            End Try
        
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Brokova_zbranComboBox.Text)
    End Sub

    Private Sub PriezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriezviskoTextBox.TextChanged

    End Sub

    Private Sub PriezviskoTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PriezviskoTextBox.Validating
        Dim chyba As String
        If Not kontrola_priezviska(PriezviskoTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(PriezviskoTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(PriezviskoTextBox, Nothing)
        End If
    End Sub

    Private Sub Clen_spz_odTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Clen_spz_odTextBox.Validating
        Dim chyba As String

        If Not kontrola_roka(Clen_spz_odTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(Clen_spz_odTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(Clen_spz_odTextBox, Nothing)
        End If
    End Sub

    Private Sub Clenske_doTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Clenske_doTextBox.Validating
        Dim chyba As String

        If Not kontrola_roka(Clenske_doTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(Clenske_doTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(Clenske_doTextBox, Nothing)
        End If
    End Sub

    Private Sub Kontrolne_strelby_brokTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Kontrolne_strelby_brokTextBox.Validating
        Dim chyba As String

        If Not kontrola_roka(Kontrolne_strelby_brokTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(Kontrolne_strelby_brokTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(Kontrolne_strelby_brokTextBox, Nothing)
        End If
    End Sub

    Private Sub Kontrolne_strelby_gulaTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Kontrolne_strelby_gulaTextBox.Validating
        Dim chyba As String

        If Not kontrola_roka(Kontrolne_strelby_gulaTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(Kontrolne_strelby_gulaTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(Kontrolne_strelby_gulaTextBox, Nothing)
        End If
    End Sub

    Private Sub zavriet_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_button.Click
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()

    End Sub

    Private Sub Okres_bydliskaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class