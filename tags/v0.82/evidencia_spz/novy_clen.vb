Public Class novy_clen

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub novy_clen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet1.statna_prislusnost)
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)
        'TODO: This line of code loads data into the 'TitulzaDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.TitulzaDataSet.titul_za)
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet1.titul)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        Me.Titul_predComboBox.SelectedIndex = -1
        Me.Titul_zaComboBox.SelectedIndex = -1
        Me.NarodnostComboBox.SelectedIndex = -1
        Me.Statna_prislusnostComboBox.SelectedIndex = -1
        Me.Clen_pzComboBox.SelectedIndex = -1




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Brokova_zbranCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Datum_narodeniaDateTimePicker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Datum_narodeniaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Kontrolne_strelby_brokTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rodne_cisloTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rodne_cisloTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        

    End Sub

    Private Sub PscTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PscTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        


    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        'Try
        Dim titul As Integer = Titul_predComboBox.SelectedValue
        Dim meno As String = MenoTextBox.Text
        Dim priezvisko As String = PriezviskoTextBox.Text
        Dim titul_za As Integer = Titul_zaComboBox.SelectedValue
        Dim datum_narodenia As String = Datum_narodeniaTextBox.Text
        Dim rodne_cislo As String = Rodne_cisloTextBox.Text
        Dim miesto_narodenia As String = Miesto_narodeniaTextBox.Text
        Dim okres_narodenia As String = Okres_narodeniaTextBox.Text
        Dim cislo_op As String = Cislo_opTextBox.Text
        Dim narodnost As Integer = NarodnostComboBox.SelectedValue
        Dim bydlisko As String = BydliskoTextBox.Text
        Dim okres_bydliska As String = Okres_bydliskaTextBox.Text
        Dim psc As String = PscTextBox.Text
        Dim telefon As String = TelefonTextBox.Text
        Dim datum_vydania_op As String = Datum_vydania_opTextBox.Text
        Dim statna_prislusnost As Integer = Statna_prislusnostComboBox.SelectedValue
        Dim cislo_pl As String = Cislo_plTextBox.Text
        Dim datum_vydania_pl As String = Datum_vydania_plTextBox.Text
        Dim cislo_zp As String = Cislo_zpTextBox.Text
        Dim datum_vydania_zp As String = Datum_vydania_zpTextBox.Text
        Dim cislo_clenskeho_preukazu As String = Cislo_clenskeho_preukazu_spzTextBox.Text
        Dim clen_spz_od As String = Clen_spz_odTextBox.Text
        Dim cislo_dokladu_clenske As String = Cislo_dokladu_clenskeTextBox.Text
        Dim clenske_do As String = Clenske_doTextBox.Text
        Dim clen_pz_id As Integer = Clen_pzComboBox.SelectedValue
        Dim skuska_z_polovnictva As String = Skuska_z_polovnictvaTextBox.Text
        Dim miesto_skusky_z_polovnictva As String = Miesto_skusky_z_polovnictvaTextBox.Text
        Dim skuska_pre_polovnych_hospodarov As String = Skuska_pre_polovnych_hospodarovTextBox.Text
        Dim miesto_skusky_pre_polovnych_hospodarov As String = Miesto_skusky_pre_polovnych_hospodarovTextBox.Text
        Dim vyssia_skuska_z_polovnictva As String = Vyzsia_skuska_z_polovnictvaTextBox.Text
        Dim miesto_vyzssej_skusky As String = Miesto_vyzsia_skuska_z_polovnictvaTextBox.Text
        Dim brokova_zbran As String = Brokova_zbranComboBox.Text
        Dim kontrolne_strelby_brok As String = Kontrolne_strelby_brokTextBox.Text
        Dim gulova_zbran As String = Gulova_zbranComboBox.Text
        Dim kontrolne_strelby_gula As String = Kontrolne_strelby_gulova_zbranTextBox.Text
        Dim najvyzsie_vyznamenanie As String = Najv_vyznamenanieTextBox.Text
        Dim vyznamenanie_kedy As String = Vyznamenany_kedyTextBox.Text
        Dim udelene_tresty As String = Udelene_trestyTextBox.Text
        Dim poznamky As String = PoznamkyTextBox.Text


        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
        con.Open()

        Dim com As New OleDb.OleDbCommand("INSERT INTO clenovia(titul_pred, meno, priezvisko, titul_za, datum_narodenia, rodne_cislo, miesto_narodenia, okres_narodenia, bydlisko, okres_bydliska, psc, telefon, statna_prislusnost, narodnost, cislo_op, datum_vydania_op, cislo_pl, datum_vydania_pl, cislo_zp, datum_vydania_zp, cislo_clenskeho_preukazu_spz, clen_spz_od, clenske_do, cislo_dokladu_clenske, clen_pz_id, skuska_z_polovnictva, miesto_skusky_z_polovnictva, skuska_pre_polovnych_hospodarov, miesto_skusky_pre_polovnych_hospodarov, vyzsia_skuska_z_polovnictva, miesto_vyzsia_skuska_z_polovnictva, brokova_zbran, kontrolne_strelby_brok, gulova_zbran, kontrolne_strelby_gulova_zbran, najv_vyznamenanie, vyznamenany_kedy, udelene_tresty, poznamky) VALUES('" & titul & "', '" & meno & "', '" & priezvisko & "', '" & titul_za & "', '" & datum_narodenia & "', '" & rodne_cislo & "', '" & miesto_narodenia & "', '" & okres_narodenia & "', '" & bydlisko & "', '" & okres_bydliska & "', '" & psc & "', '" & telefon & "', '" & statna_prislusnost & "', '" & narodnost & "', '" & cislo_op & "', '" & datum_vydania_op & "', '" & cislo_pl & "', '" & datum_vydania_pl & "', '" & cislo_zp & "', '" & datum_vydania_zp & "', '" & cislo_clenskeho_preukazu & "', '" & clen_spz_od & "', '" & clenske_do & "', '" & cislo_dokladu_clenske & "', '" & clen_pz_id & "', '" & skuska_z_polovnictva & "', '" & miesto_skusky_z_polovnictva & "', '" & skuska_pre_polovnych_hospodarov & "', '" & miesto_skusky_pre_polovnych_hospodarov & "', '" & vyssia_skuska_z_polovnictva & "', '" & miesto_vyzssej_skusky & "', '" & brokova_zbran & "', '" & kontrolne_strelby_brok & "', '" & gulova_zbran & "', '" & kontrolne_strelby_gula & "', '" & najvyzsie_vyznamenanie & "', '" & vyznamenanie_kedy & "', '" & udelene_tresty & "', '" & poznamky & "')", con)

        com.ExecuteNonQuery()
        con.Close()
        evidencia_clenov.ClenoviaTableAdapter.Fill(evidencia_clenov.Prehlad_clenovDataSet.clenovia)
        Me.Close()
        ' Catch
        'MsgBox("Chyba je, je nam luto. Prosim kontaktujte nas. :-)", MsgBoxStyle.Critical)
        'End Try


    End Sub

    Private Sub Brokova_zbranComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rodne_cisloTextBox_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Rodne_cisloTextBox.Validating
        Dim chyba As String

        If Not kontrola_rc(Rodne_cisloTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(Rodne_cisloTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(Rodne_cisloTextBox, Nothing)
        End If
    End Sub

    Private Sub NarodnostComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarodnostComboBox.SelectedIndexChanged

    End Sub

    Private Sub Clen_pz_idComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Clen_pz_idComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
End Class