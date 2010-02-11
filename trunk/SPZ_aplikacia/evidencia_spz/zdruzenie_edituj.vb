Public Class zdruzenie_edituj

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzeniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub zdruzenie_edituj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        'naplnenie tabulkz all_clenovia cerstvymi udajmi
        'vytvori select pre kopirovanie tabuliek do velkej

        Dim query As String = "SELECT [ICO_clenovia] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim unionSelect As String
        Dim fromTabulky As String

        fromTabulky = ""
        unionSelect = "insert into ""all_clenovia"" "


        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 1
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                If i = 1 Then
                    fromTabulky = fromTabulky + " select * from """ + val1 + """"
                    i = i + 1
                Else
                    fromTabulky = fromTabulky + " union select * from """ + val1 + """ "
                End If
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        unionSelect = unionSelect + fromTabulky + " "
        'MsgBox(unionSelect)

        'najprv vymaz tabulku all_clenovia
        Dim truncateTable As String
        truncateTable = "DELETE FROM ""all_clenovia"" "
        Dim connectionTruncate As New SqlCeConnection(pripojovaci_retazec)
        connectionTruncate.Open()
        Dim commandTruncate As New SqlCeCommand(truncateTable, connectionTruncate)
        commandTruncate.ExecuteNonQuery()
        connectionTruncate.Close()


        'vkopiruj tabulky do all_clenova pouzij unionSelect query
        Dim sqlReturn As New Integer
        Dim connection As New SqlCeConnection(pripojovaci_retazec)
        connection.Open()
        Dim command As New SqlCeCommand(unionSelect, connection)
        sqlReturn = command.ExecuteNonQuery()
        connection.Close()




        
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)
        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Dim ico As String = zdruzenie.Label2.Text
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.FillBy_podlaico(Me.SpzDataSet.zdruzenia, ico)
        'TODO: This line of code loads data into the 'HospodarDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Dim ico_clena As String = Me.ICO_clenoviaTextBox.Text
        Me.All_clenoviaTableAdapter1.Fill(Me.HospodarDataSet.all_clenovia, ico_clena)
        'TODO: This line of code loads data into the 'PredsedaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter2.Fill(Me.PredsedaDataSet.all_clenovia, ico_clena)

        Dim startovacia_premenna_predseda As String
        startovacia_premenna_predseda = PredsedaTextBox.Text
        predsedaComboBox.SelectedValue = startovacia_premenna_predseda
        Dim startovacia_premenna_hospodar As String
        startovacia_premenna_hospodar = Polovny_hospodarTextBox.Text
        hospodarComboBox.SelectedValue = startovacia_premenna_hospodar


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

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
            If VymeraTextBox.Text <> "" Then
                .AddWithValue("vymera", VymeraTextBox.Text)
            Else
                .AddWithValue("vymera", DBNull.Value)
            End If
            .AddWithValue("les", LesTextBox.Text)
            If JeleniaTextBox.Text <> "" Then
                .AddWithValue("jelenia", JeleniaTextBox.Text)
            Else
                .AddWithValue("jelenia", DBNull.Value)
            End If
            If SrnciaTextBox.Text <> "" Then
                .AddWithValue("srncia", SrnciaTextBox.Text)
            Else
                .AddWithValue("srncia", DBNull.Value)
            End If
            If DiviaciaTextBox.Text <> "" Then
                .AddWithValue("diviacia", DiviaciaTextBox.Text)
            Else
                .AddWithValue("diviacia", DBNull.Value)
            End If
            If BazantTextBox.Text <> "" Then
                .AddWithValue("bazant", BazantTextBox.Text)
            Else
                .AddWithValue("bazant", DBNull.Value)
            End If
            If InaTextBox.Text <> "" Then
                .AddWithValue("ina", InaTextBox.Text)
            Else
                .AddWithValue("ina", DBNull.Value)
            End If
            If Platnost_najomnej_zmluvy_doTextBox.Text <> "" Then
                .AddWithValue("platnost_najomnej_zmluvy_do", Platnost_najomnej_zmluvy_doTextBox.Text)
            Else
                .AddWithValue("platnost_najomnej_zmluvy_do", DBNull.Value)
            End If
            If Stavace_planTextBox.Text <> "" Then
                .AddWithValue("stavace_plan", Stavace_planTextBox.Text)
            Else
                .AddWithValue("stavace_plan", DBNull.Value)
            End If
            If Stavace_skutocnostTextBox.Text <> "" Then
                .AddWithValue("stavace_skutocnost", Stavace_skutocnostTextBox.Text)
            Else
                .AddWithValue("stavace_skutocnost", DBNull.Value)
            End If
            If Sliedice_planTextBox.Text <> "" Then
                .AddWithValue("sliedice_plan", Sliedice_planTextBox.Text)
            Else
                .AddWithValue("sliedice_plan", DBNull.Value)
            End If
            If Sliedice_skutocnostTextBox.Text <> "" Then
                .AddWithValue("sliedice_skutocnost", Sliedice_skutocnostTextBox.Text)
            Else
                .AddWithValue("sliedice_skutocnost", DBNull.Value)
            End If
            If Slovensky_kopov_planTextBox.Text <> "" Then
                .AddWithValue("slovensky_kopov_plan", Slovensky_kopov_planTextBox.Text)
            Else
                .AddWithValue("slovensky_kopov_plan", DBNull.Value)
            End If
            If Slovensky_kopov_skutocnostTextBox.Text <> "" Then
                .AddWithValue("slovensky_kopov_skutocnost", Slovensky_kopov_skutocnostTextBox.Text)
            Else
                .AddWithValue("slovensky_kopov_skutocnost", DBNull.Value)
            End If
            If Ostatne_durice_planTextBox.Text <> "" Then
                .AddWithValue("ostatne_durice_plan", Ostatne_durice_planTextBox.Text)
            Else
                .AddWithValue("ostatne_durice_plan", DBNull.Value)
            End If
            If Ostatne_durice_skutocnostTextBox.Text <> "" Then
                .AddWithValue("ostatne_durice_skutocnost", Ostatne_durice_skutocnostTextBox.Text)
            Else
                .AddWithValue("ostatne_durice_skutocnost", DBNull.Value)
            End If
            If Brlohare_planTextBox.Text <> "" Then
                .AddWithValue("brlohare_plan", Brlohare_planTextBox.Text)
            Else
                .AddWithValue("brlohare_plan", DBNull.Value)
            End If
            If Brlohare_skutocnostTextBox.Text <> "" Then
                .AddWithValue("brlohare_skutocnost", Brlohare_skutocnostTextBox.Text)
            Else
                .AddWithValue("brlohare_skutocnost", DBNull.Value)
            End If
            If Farbiare_planTextBox.Text <> "" Then
                .AddWithValue("farbiare_plan", Farbiare_planTextBox.Text)
            Else
                .AddWithValue("farbiare_plan", DBNull.Value)
            End If
            If Farbiare_skutocnostTextBox.Text <> "" Then
                .AddWithValue("farbiare_skutocnost", Farbiare_skutocnostTextBox.Text)
            Else
                .AddWithValue("farbiare_skutocnost", DBNull.Value)
            End If
            If Pes_jelenia_planTextBox.Text <> "" Then
                .AddWithValue("pes_jelenia_plan", Pes_jelenia_planTextBox.Text)
            Else
                .AddWithValue("pes_jelenia_plan", DBNull.Value)
            End If
            If Pes_jelenia_skutocnostTextBox.Text <> "" Then
                .AddWithValue("pes_jelenia_skutocnost", Pes_jelenia_skutocnostTextBox.Text)
            Else
                .AddWithValue("pes_jelenia_skutocnost", DBNull.Value)
            End If
            If Pes_diviacia_planTextBox.Text <> "" Then
                .AddWithValue("pes_diviacia_plan", Pes_diviacia_planTextBox.Text)
            Else
                .AddWithValue("pes_diviacia_plan", DBNull.Value)
            End If
            If Pes_diviacia_skutocnostTextBox.Text <> "" Then
                .AddWithValue("pes_diviacia_skutocnost", Pes_diviacia_skutocnostTextBox.Text)
            Else
                .AddWithValue("pes_diviacia_skutocnost", DBNull.Value)
            End If
            If Pes_srncia_planTextBox.Text <> "" Then
                .AddWithValue("pes_srncia_plan", Pes_srncia_planTextBox.Text)
            Else
                .AddWithValue("pes_srncia_plan", DBNull.Value)
            End If
            If Pes_srncia_skutocnostTextBox.Text <> "" Then
                .AddWithValue("pes_srncia_skutocnost", Pes_srncia_skutocnostTextBox.Text)
            Else
                .AddWithValue("pes_srncia_skutocnost", DBNull.Value)
            End If
            If Pes_mala_planTextBox.Text <> "" Then
                .AddWithValue("pes_mala_plan", Pes_mala_planTextBox.Text)
            Else
                .AddWithValue("pes_mala_plan", DBNull.Value)
            End If
            If Pes_mala_skutocnostTextBox.Text <> "" Then
                .AddWithValue("pes_mala_skutocnost", Pes_mala_skutocnostTextBox.Text)
            Else
                .AddWithValue("pes_mala_skutocnost", DBNull.Value)
            End If
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        zdruzenie.ZdruzeniaTableAdapter.Fill(zdruzenie.SpzDataSet.zdruzenia)
        MsgBox("Združenie úspešne upravené.")
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()

    End Sub

    Private Sub predsedaComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles predsedaComboBox.Leave
        PredsedaTextBox.Text = predsedaComboBox.SelectedValue
        If predsedaComboBox.SelectedValue = 0 Then
            Predseda_telefonTextBox.Text = ""
        End If
        

    End Sub

    Private Sub predsedaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles predsedaComboBox.SelectedIndexChanged
        PredsedaTextBox.Text = predsedaComboBox.SelectedValue

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT telefon FROM all_clenovia WHERE rodne_cislo = @rodne_cislo", con)
        com.Parameters.AddWithValue("rodne_cislo", predsedaComboBox.SelectedValue)
        con.Open()
        Dim telefon As String

        Try
            Dim rdr As SqlCeDataReader = com.ExecuteReader
            While rdr.Read
                telefon = rdr.GetString(0)
                Me.Predseda_telefonTextBox.Text = telefon
            End While
            rdr.Close()
            con.Close()

        Catch

            con.Close()
            Me.Predseda_telefonTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub hospodarComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles hospodarComboBox.Leave
        Polovny_hospodarTextBox.Text = hospodarComboBox.SelectedValue

        If hospodarComboBox.SelectedValue = 0 Then
            Polovny_hospodarTextBox.Text = ""

        End If

    End Sub

    Private Sub hospodarComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hospodarComboBox.SelectedIndexChanged
        Polovny_hospodarTextBox.Text = hospodarComboBox.SelectedValue

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT telefon FROM all_clenovia WHERE rodne_cislo = @rodne_cislo", con)
        com.Parameters.AddWithValue("rodne_cislo", hospodarComboBox.SelectedValue)
        con.Open()
        Dim telefon As String

        Try
            Dim rdr As SqlCeDataReader = com.ExecuteReader
            While rdr.Read
                telefon = rdr.GetString(0)
                Me.Polovny_hospodar_telefonTextBox.Text = telefon
            End While
            rdr.Close()
            con.Close()

        Catch

            con.Close()
            Me.Polovny_hospodar_telefonTextBox.Text = ""
        End Try
    End Sub

    Private Sub zavriet_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_button.Click
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()
    End Sub

    Private Sub Sliedice_skutocnostLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class