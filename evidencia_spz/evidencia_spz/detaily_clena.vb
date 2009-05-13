Public Class detaily_clena

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub detaily_clena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet1.statna_prislusnost)
        'TODO: This line of code loads data into the 'TitulzaDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.TitulzaDataSet.titul_za)
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet1.titul)
        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'PrehladDataSet.clenovia' table. You can move, or remove it, as needed.
        Dim id_clena As Integer = evidencia_clenov.Label1.Text
        Me.ClenoviaTableAdapter1.Fill(Me.DetailClenaDataSet.clenovia, id_clena)


        'Me.ClenoviaBindingSource.Position = pozicia

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        prehlad_clenov.prehlad_clenov_splitter.Panel2.Controls.Add(Me)
        'titul pred
        Dim start_value_titul_pred As Integer
        If Titul_predTextBox.Text = "" Then
            start_value_titul_pred = 0
        Else
            start_value_titul_pred = Titul_predTextBox.Text
        End If
        Me.Titul_predComboBox.SelectedValue = start_value_titul_pred
        'titul za
        Dim start_value_titul_za As Integer
        If Titul_zaTextBox.Text = "" Then
            start_value_titul_za = 0
        Else
            start_value_titul_za = Titul_zaTextBox.Text
        End If
        Me.Titul_zaComboBox.SelectedValue = start_value_titul_za
        'statna prislusnost
        Dim start_value_statna_prislusnost As Integer
        If Statna_prislusnostTextBox.Text = "" Then
            start_value_statna_prislusnost = 0
        Else
            start_value_statna_prislusnost = Statna_prislusnostTextBox.Text
        End If
        Me.Statna_prislusnostComboBox.SelectedValue = start_value_statna_prislusnost
        'narodnost
        Dim start_value_narodnost As Integer
        If NarodnostTextBox.Text = "" Then
            start_value_narodnost = 0
        Else
            start_value_narodnost = NarodnostTextBox.Text
        End If
        Me.NarodnostComboBox.SelectedValue = start_value_narodnost
        'zdruzenie
        Dim start_value_zdruzenie As Integer
        If Clen_pzTextBox.Text = "" Then
            start_value_zdruzenie = 0
        Else
            start_value_zdruzenie = Clen_pzTextBox.Text
        End If
        Me.Clen_pzComboBox.SelectedValue = start_value_zdruzenie
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
        Me.Miesto_skusky_z_polovnictvaTextBox.ReadOnly = False
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
        Me.Titul_predComboBox.Enabled = True
        Me.Titul_zaComboBox.Enabled = True
        Me.Statna_prislusnostComboBox.Enabled = True
        Me.NarodnostComboBox.Enabled = True
        Me.Clen_pzComboBox.Enabled = True

        Me.upravbutton.Visible = False
        Me.ulozButton.Visible = True
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        'Me.Validate()
        'Me.ClenoviaBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Prehlad_clenovDataSet)

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
        Me.Miesto_skusky_z_polovnictvaTextBox.ReadOnly = True
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
        Me.Titul_predComboBox.Enabled = False
        Me.Titul_zaComboBox.Enabled = False
        Me.Statna_prislusnostComboBox.Enabled = False
        Me.NarodnostComboBox.Enabled = False
        Me.Clen_pzComboBox.Enabled = False


        Dim id_clena As Integer = evidencia_clenov.Label1.Text
        Try

            Dim titul_pred As Integer
            If Titul_predTextBox.Text = "" Then
                titul_pred = Nothing
            Else
                titul_pred = Titul_predTextBox.Text
            End If



            Dim meno As String = MenoTextBox.Text
            Dim priezvisko As String = PriezviskoTextBox.Text

            Dim titul_za As Integer
            If Titul_zaTextBox.Text = "" Then
                titul_za = Nothing
            Else
                titul_za = Titul_zaTextBox.Text
            End If

            Dim datum_narodenia As String = Datum_narodeniaTextBox.Text
            Dim rodne_cislo As String = Rodne_cisloTextBox.Text
            Dim miesto_narodenia As String = Miesto_narodeniaTextBox.Text
            Dim okres_narodenia As String = Okres_narodeniaTextBox.Text
            Dim cislo_op As String = Cislo_opTextBox.Text

            Dim narodnost As Integer
            If NarodnostTextBox.Text = "" Then
                narodnost = Nothing
            Else
                narodnost = NarodnostTextBox.Text
            End If

            Dim bydlisko As String = BydliskoTextBox.Text
            Dim okres_bydliska As String = Okres_bydliskaTextBox.Text
            Dim psc As String = PscTextBox.Text
            Dim telefon As String = TelefonTextBox.Text
            Dim datum_vydania_op As String = Datum_vydania_opTextBox.Text

            Dim statna_prislusnost As Integer
            If Statna_prislusnostTextBox.Text = "" Then
                statna_prislusnost = Nothing
            Else
                statna_prislusnost = Statna_prislusnostTextBox.Text
            End If

            Dim cislo_pl As String = Cislo_plTextBox.Text
            Dim datum_vydania_pl As String = Datum_vydania_plTextBox.Text
            Dim cislo_zp As String = Cislo_zpTextBox.Text
            Dim datum_vydania_zp As String = Datum_vydania_zpTextBox.Text
            Dim cislo_clenskeho_preukazu As String = Cislo_clenskeho_preukazu_spzTextBox.Text
            Dim clen_spz_od As String = Clen_spz_odTextBox.Text
            Dim cislo_dokladu_clenske As String = Cislo_dokladu_clenskeTextBox.Text
            Dim clenske_do As String = Clenske_doTextBox.Text

            Dim clen_pz_id As Integer
            If Clen_pzTextBox.Text = "" Then
                clen_pz_id = Nothing
            Else
                clen_pz_id = Clen_pzTextBox.Text
            End If

            Dim skuska_z_polovnictva As String = Skuska_z_polovnictvaTextBox.Text
            Dim miesto_skusky_z_polovnictva As String = Miesto_skusky_z_polovnictvaTextBox.Text
            Dim skuska_pre_polovnych_hospodarov As String = Skuska_pre_polovnych_hospodarovTextBox.Text
            Dim miesto_skusky_pre_polovnych_hospodarov As String = Miesto_skusky_pre_polovnych_hospodarovTextBox.Text
            Dim vyssia_skuska_z_polovnictva As String = Vyzsia_skuska_z_polovnictvaTextBox.Text
            Dim miesto_vyzssej_skusky As String = Miesto_vyzsia_skuska_z_polovnictvaTextBox.Text
            Dim brokova_zbran As String = Brokova_zbranTextBox.Text
            Dim kontrolne_strelby_brok As String = Kontrolne_strelby_brokTextBox.Text
            Dim gulova_zbran As String = Gulova_zbranTextBox.Text
            Dim kontrolne_strelby_gula As String = Kontrolne_strelby_gulova_zbranTextBox.Text
            Dim najvyzsie_vyznamenanie As String = Najv_vyznamenanieTextBox.Text
            Dim vyznamenanie_kedy As String = Vyznamenany_kedyTextBox.Text
            Dim udelene_tresty As String = Udelene_trestyTextBox.Text
            Dim poznamky As String = PoznamkyTextBox.Text


            Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
            con.Open()

            Dim com As New OleDb.OleDbCommand("UPDATE clenovia SET titul_pred ='" & titul_pred & "', meno ='" & meno & "', priezvisko ='" & priezvisko & "', titul_za ='" & titul_za & "', datum_narodenia ='" & datum_narodenia & "', rodne_cislo ='" & rodne_cislo & "', miesto_narodenia ='" & miesto_narodenia & "', okres_narodenia ='" & okres_narodenia & "', bydlisko ='" & bydlisko & "', okres_bydliska ='" & okres_bydliska & "', psc ='" & psc & "', telefon ='" & telefon & "', statna_prislusnost ='" & statna_prislusnost & "', narodnost ='" & narodnost & "', cislo_op ='" & cislo_op & "', datum_vydania_op ='" & datum_vydania_op & "', cislo_pl ='" & cislo_pl & "', datum_vydania_pl ='" & datum_vydania_pl & "', cislo_zp ='" & cislo_zp & "', datum_vydania_zp ='" & datum_vydania_zp & "', cislo_clenskeho_preukazu_spz ='" & cislo_clenskeho_preukazu & "', clen_spz_od ='" & clen_spz_od & "', clenske_do ='" & clenske_do & "', cislo_dokladu_clenske ='" & cislo_dokladu_clenske & "', clen_pz_id ='" & clen_pz_id & "', skuska_z_polovnictva ='" & skuska_z_polovnictva & "', miesto_skusky_z_polovnictva ='" & miesto_skusky_z_polovnictva & "', skuska_pre_polovnych_hospodarov ='" & skuska_pre_polovnych_hospodarov & "', miesto_skusky_pre_polovnych_hospodarov ='" & miesto_skusky_pre_polovnych_hospodarov & "', vyzsia_skuska_z_polovnictva ='" & vyssia_skuska_z_polovnictva & "', miesto_vyzsia_skuska_z_polovnictva ='" & miesto_vyzssej_skusky & "', brokova_zbran ='" & brokova_zbran & "', kontrolne_strelby_brok ='" & kontrolne_strelby_brok & "', gulova_zbran ='" & gulova_zbran & "', kontrolne_strelby_gulova_zbran ='" & kontrolne_strelby_gula & "', najv_vyznamenanie ='" & najvyzsie_vyznamenanie & "', vyznamenany_kedy ='" & vyznamenanie_kedy & "', udelene_tresty ='" & udelene_tresty & "', poznamky ='" & poznamky & "' WHERE id =" & id_clena, con)

            com.ExecuteNonQuery()
            con.Close()
            evidencia_clenov.ClenoviaTableAdapter.Fill(evidencia_clenov.Prehlad_clenovDataSet.clenovia)

        Catch
            MsgBox("chyba :-)", MsgBoxStyle.OkOnly)
        End Try





    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub FillToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Titul_predComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Titul_predComboBox.Leave
        If Titul_predComboBox.Text = "" Then
            Me.Titul_predTextBox.Text = "0"
        End If
    End Sub

    Private Sub Titul_predComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_predComboBox.SelectedIndexChanged


        If Titul_predComboBox.SelectedValue <> 0 Then
            Me.Titul_predTextBox.Text = Titul_predComboBox.SelectedValue
        End If


    End Sub

    Private Sub Titul_zaComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Titul_zaComboBox.Leave
        If Titul_zaComboBox.Text = "" Then
            Me.Titul_zaTextBox.Text = "0"
        End If
    End Sub

    Private Sub Titul_zaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_zaComboBox.SelectedIndexChanged
        If Titul_zaComboBox.SelectedValue <> 0 Then
            Me.Titul_zaTextBox.Text = Titul_zaComboBox.SelectedValue
        End If
    End Sub

    Private Sub Statna_prislusnostComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Statna_prislusnostComboBox.Leave
        If Statna_prislusnostComboBox.Text = "" Then
            Me.Statna_prislusnostTextBox.Text = "0"
        End If
    End Sub

    Private Sub Statna_prislusnostComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statna_prislusnostComboBox.SelectedIndexChanged
        If Statna_prislusnostComboBox.SelectedValue <> 0 Then
            Me.Statna_prislusnostTextBox.Text = Statna_prislusnostComboBox.SelectedValue
        End If
    End Sub

    Private Sub NarodnostComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NarodnostComboBox.Leave
        If NarodnostComboBox.Text = "" Then
            Me.NarodnostTextBox.Text = "0"
        End If
    End Sub

    Private Sub NarodnostComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarodnostComboBox.SelectedIndexChanged
        If NarodnostComboBox.SelectedValue <> 0 Then
            Me.NarodnostTextBox.Text = NarodnostComboBox.SelectedValue
        End If
    End Sub

    Private Sub Clen_pzComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Clen_pzComboBox.Leave
        If Clen_pzComboBox.Text = "" Then
            Me.Clen_pzTextBox.Text = "0"
        End If
    End Sub

    Private Sub Clen_pzComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clen_pzComboBox.SelectedIndexChanged
        If Clen_pzComboBox.SelectedValue <> 0 Then
            Me.Clen_pzTextBox.Text = Clen_pzComboBox.SelectedValue
        End If
    End Sub
End Class