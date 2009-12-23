Public Class zdruzenie_edituj

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzeniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub zdruzenie_edituj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Dim ico As String = zdruzenie.Label2.Text
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.FillBy_podlaico(Me.SpzDataSet.zdruzenia, ico)

        'vybratie clenov konkretneho zdruzenia
        Dim nazovtabulky As String = """" + ico + "_clenovia"""
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT priezvisko, rodne_cislo FROM " & nazovtabulky, con)
        Dim priezvisko As String = ""
        Dim rc As String = ""
        con.Open()
        Dim datareader As SqlCeDataReader = com.ExecuteReader

        While datareader.Read
            priezvisko = datareader.GetString(0)
            rc = datareader.GetString(1)
            Me.ComboBox1.Items.Add(priezvisko)

        End While


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("Update zdruzenia SET ico = @ico, ICO_clenovia = @ICO_clenovia, ICO_psy = @ICO_psy, ICO_trofeje = @ICO_trofeje, nazov = @nazov, sidlo = @sidlo, predseda = @predseda, predseda_telefon = @predseda_telefon, polovny_hospodar = @polovny_hospodar, polovny_hospodar_telefon = @polovny_hospodar_telefon, dic = @dic, banka = @banka, cislo_uctu = @cislo_uctu, chovatelska_oblast = @chovatelska_oblast, cislo_reviru = @cislo_reviru, vymera = @vymera, les = @les, jelenia = @jelenia, srncia = @srncia, diviacia = @diviacia, bazant = @bazant, ina = @ina, platnost_najomnej_zmluvy_do = @platnost_najomnej_zmluvy_do,stavace_plan = @stavace_plan, stavace_skutocnost = @stavace_skutocnost, sliedice_plan = @sliedice_plan, sliedice_skutocnost = @sliedice_skutocnost, slovensky_kopov_plan = @slovensky_kopov_plan, slovensky_kopov_skutocnost = @slovensky_kopov_skutocnost, ostatne_durice_plan = @ostatne_durice_plan, ostatne_durice_skutocnost = @ostatne_durice_skutocnost, brlohare_plan = @brlohare_plan, brlohare_skutocnost = @brlohare_skutocnost, farbiare_plan = @farbiare_plan, farbiare_skutocnost = @farbiare_skutocnost, pes_jelenia_plan = @pes_jelenia_plan, pes_jelenia_skutocnost = @pes_jelenia_skutocnost, pes_diviacia_plan = @pes_diviacia_plan, pes_diviacia_skutocnost = @pes_diviacia_skutocnost, pes_srncia_plan = @pes_srncia_plan, pes_srncia_skutocnost = @pes_srncia_skutocnost, pes_mala_plan = @pes_mala_plan, pes_mala_skutocnost = @pes_mala_skutocnost WHERE ico = @ico", con)
        ' With com.Parameters
        '.AddWithValue("cislo_pl", Cislo_plTextBox.Text)

        With com.Parameters
            .AddWithValue("ico", IcoTextBox.Text)
            .AddWithValue("ICO_clenovia", ICO_clenoviaTextBox.Text)
            .AddWithValue("ICO_psy", ICO_psyTextBox.Text)
            .AddWithValue("ICO_trofeje", ICO_trofejeTextBox.Text)
            .AddWithValue("nazov", NazovTextBox.Text)
            .AddWithValue("sidlo", SidloTextBox.Text)
            .AddWithValue("predseda", PredsedaTextBox.Text)
            .AddWithValue("predseda_telefon", Predseda_telefonTextBox.Text)
            .AddWithValue("polovny_hospodar", Polovny_hospodarTextBox.Text)
            .AddWithValue("polovny_hospodar_telefon", Polovny_hospodar_telefonTextBox.Text)
            .AddWithValue("dic", DicTextBox.Text)
            .AddWithValue("banka", BankaTextBox.Text)
            .AddWithValue("cislo_uctu", Cislo_uctuTextBox.Text)
            .AddWithValue("chovatelska_oblast", Chovatelska_oblastTextBox.Text)
            .AddWithValue("cislo_reviru", Cislo_reviruTextBox.Text)
            .AddWithValue("vymera", VymeraTextBox.Text)
            .AddWithValue("les", LesTextBox.Text)
            .AddWithValue("jelenia", JeleniaTextBox.Text)
            .AddWithValue("srncia", SrnciaTextBox.Text)
            .AddWithValue("diviacia", DiviaciaTextBox.Text)
            .AddWithValue("bazant", BazantTextBox.Text)
            .AddWithValue("ina", InaTextBox.Text)
            .AddWithValue("platnost_najomnej_zmluvy_do", Platnost_najomnej_zmluvy_doTextBox.Text)
            .AddWithValue("stavace_plan", Stavace_planTextBox.Text)
            .AddWithValue("stavace_skutocnost", Stavace_skutocnostTextBox.Text)
            .AddWithValue("sliedice_plan", Sliedice_planTextBox.Text)
            .AddWithValue("sliedice_skutocnost", Sliedice_skutocnostTextBox.Text)
            .AddWithValue("slovensky_kopov_plan", Slovensky_kopov_planTextBox.Text)
            .AddWithValue("slovensky_kopov_skutocnost", Slovensky_kopov_skutocnostTextBox.Text)
            .AddWithValue("ostatne_durice_plan", Ostatne_durice_planTextBox.Text)
            .AddWithValue("ostatne_durice_skutocnost", Ostatne_durice_skutocnostTextBox.Text)
            .AddWithValue("brlohare_plan", Brlohare_planTextBox.Text)
            .AddWithValue("brlohare_skutocnost", Brlohare_skutocnostTextBox.Text)
            .AddWithValue("farbiare_plan", Farbiare_planTextBox.Text)
            .AddWithValue("farbiare_skutocnost", Farbiare_skutocnostTextBox.Text)
            .AddWithValue("pes_jelenia_plan", Pes_jelenia_planTextBox.Text)
            .AddWithValue("pes_jelenia_skutocnost", Pes_jelenia_skutocnostTextBox.Text)
            .AddWithValue("pes_diviacia_plan", Pes_diviacia_planTextBox.Text)
            .AddWithValue("pes_diviacia_skutocnost", Pes_diviacia_skutocnostTextBox.Text)
            .AddWithValue("pes_srncia_plan", Pes_srncia_planTextBox.Text)
            .AddWithValue("pes_srncia_skutocnost", Pes_srncia_skutocnostTextBox.Text)
            .AddWithValue("pes_mala_plan", Pes_mala_planTextBox.Text)
            .AddWithValue("pes_mala_skutocnost", Pes_mala_skutocnostTextBox.Text)
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub
End Class