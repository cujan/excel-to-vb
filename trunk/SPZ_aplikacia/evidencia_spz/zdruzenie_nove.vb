Public Class zdruzenie_nove

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub zdruzenie_nove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO zdruzenia (ico, ICO_clenovia, ICO_psy, ICO_trofeje, nazov, sidlo, predseda, predseda_telefon, polovny_hospodar, polovny_hospodar_telefon, dic, banka, cislo_uctu, chovatelska_oblast, cislo_reviru, vymera, les, jelenia, srncia, diviacia, bazant, ina, platnost_najomnej_zmluvy_do, stavace_plan, stavace_skutocnost, sliedice_plan, sliedice_skutocnost, slovensky_kopov_plan, slovensky_kopov_skutocnost, ostatne_durice_plan, ostatne_durice_skutocnost, brlohare_plan, brlohare_skutocnost, farbiare_plan, farbiare_skutocnost, pes_jelenia_plan, pes_jelenia_skutocnost, pes_diviacia_plan, pes_diviacia_skutocnost, pes_srncia_plan, pes_srncia_skutocnost, pes_mala_plan, pes_mala_skutocnost)VALUES (@ico,@ico_clenovia,@ico_psy,@ico_trofeje,@nazov,@sidlo,@predseda,@predseda_telefon,@polovny_hospodar,@polovny_hospodar_telefon,@dic,@banka,@cislo_uctu,@chovatelska_oblast,@cislo_reviru,@vymera,@les,@jelenia,@srncia,@diviacia,@bazant,@ina,@platnost_najomnej_zmluvy_do,@stavace_plan,@stavace_skutocnost,@sliedice_plan,@sliedice_skutocnost,@slovensky_kopov_plan,@slovensky_kopov_skutocnost,@ostatne_durice_plan,@ostatne_durice_skutocnost,@brlohare_plan,@brlohare_skutocnost,@farbiare_plan,@farbiare_skutocnost,@pes_jelenia_plan,@pes_jelenia_skutocnost,@pes_diviacia_plan,@pes_diviacia_skutocnost,@pes_srncia_plan,@pes_srncia_skutocnost,@pes_mala_plan,@pes_mala_skutocnost)", con)


        With com.Parameters

            .AddWithValue("ico", IcoTextBox.Text)
            .AddWithValue("ico_clenovia", ICO_clenoviaTextBox.Text)
            .AddWithValue("ico_psy", ICO_psyTextBox.Text)
            .AddWithValue("ico_trofeje", ICO_trofejeTextBox.Text)
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
        com.ExecuteNonQuery()

        'dynamicke vytvorenie tabulkz clena pre jednotlive zdruzenia
        Dim ico As String = IcoTextBox.Text


        Dim com1 As New SqlCeCommand("CREATE  TABLE """ & ico & "_clenovia""  (cislo_pl  NVARCHAR(45) NOT NULL ,meno  NVARCHAR(45) NULL ,priezvisko  NVARCHAR(45) NULL , datum_narodenia  DATETIME NULL ,rodne_cislo  NVARCHAR(45) NOT NULL ,miesto_narodenia  NVARCHAR(45) NULL ,okres_narodenia  NVARCHAR(45) NULL ,bydlisko  NVARCHAR(45) NULL ,okres_bydliska  NVARCHAR(45) NULL ,psc  NVARCHAR(45) NULL ,telefon  NVARCHAR(45) NULL ,cislo_op  NVARCHAR(45) NULL ,datum_vydania_op  DATETIME NULL ,datum_vydania_pl  DATETIME NULL ,cislo_zp  NVARCHAR(45) NULL ,datum_vydania_zp  DATETIME NULL ,cislo_clenskeho_preukazu_spz  NVARCHAR(45) NULL ,clen_spz_od  INT NULL ,clenske_do  INT NULL ,cislo_dokladu_clenske  NVARCHAR(45) NULL ,clen_pz  INT NULL ,skuska_z_polovnictva  DATETIME NULL ,miesto_skusky_z_polovnictva  NVARCHAR(45) NULL ,skuska_pre_polovnych_hospodarov  DATETIME NULL ,miesto_skusky_pre_polovnych_hospodarov  NVARCHAR(45) NULL ,vyzsia_skuska_z_polovnictva  DATETIME NULL ,miesto_vyzsej_skusky_z_polovnictva  NVARCHAR(45) NULL ,brokova_zbran  NVARCHAR(45) NULL ,kontrolne_strelby_brok  INT NULL ,gulova_zbran  NVARCHAR(45) NULL ,kontrolne_strelby_gula  INT NULL ,najvyzsie_vyznamenanie  NVARCHAR(45) NULL ,vyznamenanie_kedy  DATETIME NULL ,udelene_tresty  NVARCHAR(45) NULL ,poznamky  NVARCHAR(120) NULL ,titul_pred_id  INT NOT NULL ,titul_za_id  INT NOT NULL ,narodnost_id  INT NOT NULL ,statna_prislusnost_id  INT NOT NULL ,ico_clenovia  NVARCHAR(45) NOT NULL ,PRIMARY KEY ( cislo_pl ,  rodne_cislo ))", con)

        com1.ExecuteNonQuery()
        con.Close()
    End Sub
End Class