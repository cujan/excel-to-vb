Public Class clen_novy

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub clen_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ObceDataSet.ciselnik_obce' table. You can move, or remove it, as needed.
        Me.Ciselnik_obceTableAdapter.Fill(Me.ObceDataSet.ciselnik_obce)
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)
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
        'nulte poloykz
        Me.titul_predComboBox.SelectedIndex = -1
        Me.titul_zaComboBox.SelectedIndex = -1
        Me.statna_prislusnostComboBox.SelectedIndex = -1
        Me.narodnostComboBox.SelectedIndex = -1


    End Sub

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(Me.Clen_pzComboBox.SelectedValue)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz_clena_button.Click
        Try
            Dim chyba As String
            kontrola_vstupnych_udajov_clena(PriezviskoTextBox.Text, rodne_cisloMaskedTextBox.Text, Clen_spz_odTextBox.Text, Clenske_doTextBox.Text, Kontrolne_strelby_brokTextBox.Text, Kontrolne_strelby_gulaTextBox.Text, MestoComboBox.SelectedValue, Okres_bydliskaListBox.SelectedItem, PscListBox.SelectedItem, chyba)


            If chyba.Length = 0 Then

                Dim ico_zdruzenia As String = Clen_pzComboBox.SelectedValue
                Dim ico_clenovia As String = ico_zdruzenia + "_clenovia"

                Dim con As New SqlCeConnection(pripojovaci_retazec)
                con.Open()

                Dim com As New SqlCeCommand("INSERT INTO """ & ico_zdruzenia & "_clenovia"" (cislo_pl, meno, priezvisko, datum_narodenia, rodne_cislo, miesto_narodenia, okres_narodenia, okres_bydliska, psc, telefon, cislo_op, datum_vydania_op, datum_vydania_pl, cislo_zp, datum_vydania_zp, cislo_clenskeho_preukazu_spz, clen_spz_od, clenske_do, cislo_dokladu_clenske, clen_pz, skuska_z_polovnictva, miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva, miesto_vyzsej_skusky_z_polovnictva, brokova_zbran, kontrolne_strelby_brok, gulova_zbran, kontrolne_strelby_gula, najvyzsie_vyznamenanie, vyznamenanie_kedy, udelene_tresty, poznamky, titul_pred_id, titul_za_id, narodnost_id, statna_prislusnost_id, ico_clenovia, mesto, ulica, ulica_cislo) VALUES (@cislo_pl,@meno,@priezvisko,@datum_narodenia,@rodne_cislo,@miesto_narodenia,@okres_narodenia,@okres_bydliska,@psc,@telefon,@cislo_op,@datum_vydania_op,@datum_vydania_pl,@cislo_zp,@datum_vydania_zp,@cislo_clenskeho_preukazu_spz,@clen_spz_od,@clenske_do,@cislo_dokladu_clenske,@clen_pz,@skuska_z_polovnictva,@miesto_skusky_z_polovnictva,@skuska_pre_polovnych_hospodarov,@miesto_skusky_pre_polovnych_hospodarov,@vyzsia_skuska_z_polovnictva,@miesto_vyzsej_skusky_z_polovnictva,@brokova_zbran,@kontrolne_strelby_brok,@gulova_zbran,@kontrolne_strelby_gula,@najvyzsie_vyznamenanie,@vyznamenanie_kedy,@udelene_tresty,@poznamky,@titul_pred_id,@titul_za_id,@narodnost_id,@statna_prislusnost_id,@ico_clenovia, @mesto, @ulica, @ulica_cislo)", con)

                With com.Parameters
                    .AddWithValue("cislo_pl", Cislo_plTextBox.Text)
                    .AddWithValue("meno", MenoTextBox.Text)
                    .AddWithValue("priezvisko", PriezviskoTextBox.Text)

                    If Datum_narodeniaDateTimePicker.Checked = True Then
                        .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value)
                    Else
                        .AddWithValue("datum_narodenia", DBNull.Value)
                    End If

                    .AddWithValue("rodne_cislo", rodne_cisloMaskedTextBox.Text)
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
                    .AddWithValue("brokova_zbran", Brokova_zbranComboBox.Text)
                    If Kontrolne_strelby_brokTextBox.Text = "" Then
                        .AddWithValue("kontrolne_strelby_brok", DBNull.Value)
                    Else
                        .AddWithValue("kontrolne_strelby_brok", Kontrolne_strelby_brokTextBox.Text)
                    End If
                    .AddWithValue("gulova_zbran", Gulova_zbranComboBox.Text)
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
                    If titul_predComboBox.SelectedValue = 0 Then
                        .AddWithValue("titul_pred_id", DBNull.Value)
                    Else
                        .AddWithValue("titul_pred_id", titul_predComboBox.SelectedValue)
                    End If
                    If titul_zaComboBox.SelectedValue = 0 Then
                        .AddWithValue("titul_za_id", DBNull.Value)
                    Else
                        .AddWithValue("titul_za_id", titul_zaComboBox.SelectedValue)
                    End If
                    If narodnostComboBox.SelectedValue = 0 Then
                        .AddWithValue("narodnost_id", DBNull.Value)
                    Else
                        .AddWithValue("narodnost_id", narodnostComboBox.SelectedValue)
                    End If
                    If statna_prislusnostComboBox.SelectedValue = 0 Then
                        .AddWithValue("statna_prislusnost_id", DBNull.Value)
                    Else
                        .AddWithValue("statna_prislusnost_id", statna_prislusnostComboBox.SelectedValue)
                    End If
                    .AddWithValue("ico_clenovia", ico_clenovia)
                    .AddWithValue("mesto", MestoComboBox.SelectedValue)
                    .AddWithValue("ulica", UlicaTextBox.Text)
                    .AddWithValue("ulica_cislo", Ulica_cisloTextBox.Text)
                End With

                com.ExecuteNonQuery()
                con.Close()

                Dim uz_existuje As Integer
                If predseda_radio.Checked Then
                    Dim con2 As New SqlCeConnection(pripojovaci_retazec)
                    Dim com2 As New SqlCeCommand("SELECT count(*) FROM zdruzenia WHERE ico = @zdruzenie and predseda like 'N' ", con2)
                    With com2.Parameters
                        .AddWithValue("zdruzenie", Clen_pzComboBox.SelectedValue)

                    End With



                    con2.Open()
                    uz_existuje = com2.ExecuteScalar

                    con2.Close()



                    If uz_existuje = 1 Then
                        Dim con1 As New SqlCeConnection(pripojovaci_retazec)
                        Dim com1 As New SqlCeCommand("UPDATE zdruzenia SET  predseda = @predseda, predseda_telefon = @predseda_telefon WHERE ico = @zdruzenie ", con1)
                        With com1.Parameters
                            .AddWithValue("predseda", rodne_cisloMaskedTextBox.Text)
                            .AddWithValue("predseda_telefon", TelefonTextBox.Text)
                            .AddWithValue("zdruzenie", Clen_pzComboBox.SelectedValue)
                        End With
                        con1.Open()
                        com1.ExecuteNonQuery()
                        con1.Close()
                    Else
                        MsgBox("V združení " + Clen_pzComboBox.SelectedValue + " už existuje predseda. Nového predsedu vyberiete v editácii združenia.")
                    End If

                ElseIf hospodar_radio.Checked Then

                    Dim con2 As New SqlCeConnection(pripojovaci_retazec)
                    Dim com2 As New SqlCeCommand("SELECT count(*) FROM zdruzenia WHERE ico = @zdruzenie and polovny_hospodar like 'N' ", con2)
                    With com2.Parameters
                        .AddWithValue("zdruzenie", Clen_pzComboBox.SelectedValue)

                    End With



                    con2.Open()
                    uz_existuje = com2.ExecuteScalar

                    con2.Close()

                    If uz_existuje = 1 Then

                        Dim con1 As New SqlCeConnection(pripojovaci_retazec)
                        Dim com1 As New SqlCeCommand("UPDATE zdruzenia SET  polovny_hospodar = @polovny_hospodar, polovny_hospodar_telefon = @polovny_hospodar_telefon WHERE ico = @zdruzenie ", con1)
                        With com1.Parameters
                            .AddWithValue("polovny_hospodar", rodne_cisloMaskedTextBox.Text)
                            .AddWithValue("polovny_hospodar_telefon", TelefonTextBox.Text)
                            .AddWithValue("zdruzenie", Clen_pzComboBox.SelectedValue)
                        End With
                        con1.Open()
                        com1.ExecuteNonQuery()
                        con1.Close()
                    Else
                        MsgBox("V združení " + Clen_pzComboBox.SelectedValue + " už existuje poľovný hospodár. Nového poľovného hospodára vyberiete v editácii združenia.")
                    End If

                End If

                hlavna_aplikacia.updatniNepridanychPredsedov()
                hlavna_aplikacia.neuplneZdruzenia()
                MsgBox("Člen bol úspešne pridaný. ", MsgBoxStyle.Information)
                hlavna_aplikacia.removeFormFromList(Me.Text)
                Me.Close()
            Else
                MsgBox("Mate chybne vyplnene tieto polia: " + vbNewLine + vbNewLine + chyba, MsgBoxStyle.Critical, "upozornenie")
            End If
        Catch
            MsgBox("chyba")
        End Try
    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()
    End Sub

    Private Sub MestoComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MestoComboBox.Leave
        
    End Sub

    Private Sub MestoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MestoComboBox.SelectedIndexChanged
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT okres, psc FROM ciselnik_obce WHERE obec = @obec", con)
        com.Parameters.AddWithValue("obec", MestoComboBox.SelectedValue)
        Dim psc As String
        Dim okres As String
        Me.Okres_bydliskaListBox.Items.Clear()
        Me.PscListBox.Items.Clear()

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
    End Sub

    Private Sub MestoComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MestoComboBox.TextChanged
        'Dim parameter As String = Me.MestoComboBox.Text & "%"
        'Me.Ciselnik_obceTableAdapter.FillBy_vyhladavanie(Me.ObceDataSet.ciselnik_obce, parameter)
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

    Private Sub Rodne_cisloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rodne_cisloTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim chyba As String

        If Not kontrola_rc(rodne_cisloMaskedTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(rodne_cisloMaskedTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(rodne_cisloMaskedTextBox, Nothing)
        End If
    End Sub

    Private Sub Clen_spz_odTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clen_spz_odTextBox.TextChanged

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

    Private Sub Clenske_doTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clenske_doTextBox.TextChanged

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

    Private Sub Kontrolne_strelby_brokTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kontrolne_strelby_brokTextBox.TextChanged

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

    Private Sub Kontrolne_strelby_gulaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kontrolne_strelby_gulaTextBox.TextChanged
       
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

    Private Sub Okres_bydliskaListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Okres_bydliskaListBox.SelectedIndexChanged

    End Sub

    Private Sub Okres_bydliskaListBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Okres_bydliskaListBox.Validating
        
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Brokova_zbranComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brokova_zbranComboBox.SelectedIndexChanged

        If Brokova_zbranComboBox.SelectedItem = "NIE" Then
            Kontrolne_strelby_brokTextBox.ReadOnly = True
        Else
            Kontrolne_strelby_brokTextBox.ReadOnly = False
        End If

    End Sub

    Private Sub Gulova_zbranComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gulova_zbranComboBox.SelectedIndexChanged
        If Gulova_zbranComboBox.SelectedItem = "NIE" Then
            Kontrolne_strelby_gulaTextBox.ReadOnly = True
        Else
            Kontrolne_strelby_gulaTextBox.ReadOnly = False
        End If
    End Sub

    Private Sub Ulica_cisloLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub narodnostComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnostComboBox.SelectedIndexChanged

    End Sub
End Class