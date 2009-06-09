Public Class nove_zdruzenie

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub nove_zdruzenie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)



    End Sub

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            If MsgBox("Naozaj chcete ulozit zdruzenie?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                Dim nazov As String = NazovTextBox.Text
                Dim sidlo As String = SidloTextBox.Text
                Dim predseda As String = PredsedaTextBox.Text
                Dim predseda_telefon As String = Predseda_telefonTextBox.Text
                Dim polovnicky_hospodar As String = Polovnicky_hospodarTextBox.Text
                Dim polovnicky_hospodar_telefon As String = Polovnicky_hospodar_telefonTextBox.Text
                Dim ico As String = IcoTextBox.Text
                Dim dic As String = DicTextBox.Text
                Dim banka As String = BankaTextBox.Text
                Dim cislo_uctu As String = Cislo_uctuTextBox.Text
                Dim nazov_polovneho_reviru As String = Nazov_polovneho_reviruTextBox.Text
                Dim chovatelska_oblast As String = Chovatelska_oblastTextBox.Text
                Dim cislo_reviru As String = Cislo_reviruTextBox.Text
                Dim vymera As String = VymeraTextBox.Text
                Dim les As String = LesTextBox.Text
                Dim jelenia As String = JeleniaTextBox.Text
                Dim srncia As String = SrnciaTextBox.Text
                Dim diviacia As String = DiviaciaTextBox.Text
                Dim bazant As String = BazantTextBox.Text
                Dim ina As String = InaTextBox.Text
                Dim platnost_najomnej_zmluvy As String = Platnost_najomnej_zmluvy_doTextBox.Text

                Dim stavace_plan As Integer = StavacePlanTextBox.Text
                Dim stavace_skutocnost As Integer = Stavace_skutocnostTextBox.Text
                Dim sliedice_plan As Integer = SliedicePlanTextBox.Text
                Dim sliedice_skutocnost As Integer = Sliedice_skutocnostTextBox.Text
                Dim slovensky_kopov_plan As Integer = Slovensky_kopovPlanTextBox.Text
                Dim slovensky_kopov_skutocnost As Integer = Slovensky_kopov_skutocnostTextBox.Text
                Dim ostatne_durice_plan As Integer = Ostatne_duricePlanTextBox.Text
                Dim ostatne_durice_skutocnost As Integer = Ostatne_durice_skutocnostTextBox.Text
                Dim brlohare_plan As Integer = BrloharePlanTextBox.Text
                Dim brlohare_skutocnost As Integer = Brlohare_skutocnostTextBox.Text
                Dim farbiare_plan As Integer = FarbiarePlanTextBox.Text
                Dim farbiare_skutocnost As Integer = Farbiare_skutocnostTextBox.Text
                Dim pes_jelenia_plan As Integer = Pes_jeleniaPlanTextBox.Text
                Dim pes_jelenia_skutocnost As Integer = Pes_jelenia_skutocnostTextBox.Text
                Dim pes_diviacia_plan As Integer = Pes_diviaciaPlanTextBox.Text
                Dim pes_diviacia_skutocnost As Integer = Pes_diviacia_skutocnostTextBox.Text
                Dim pes_srncia_plan As Integer = Pes_srnciaPlanTextBox.Text
                Dim pes_srncia_skutocnost As Integer = Pes_srncia_skutocnostTextBox.Text
                Dim pes_mala_plan As Integer = Pes_malaPlanTextBox.Text
                Dim pes_mala_skutocnost As Integer = Pes_mala_skutocnostTextBox.Text

                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
                con.Open()

                Dim com As New OleDb.OleDbCommand("INSERT INTO zdruzenie(nazov, sidlo, predseda, predseda_telefon, polovnicky_hospodar, polovnicky_hospodar_telefon, ico, dic, banka, cislo_uctu, nazov_polovneho_reviru, chovatelska_oblast, cislo_reviru, vymera, les, jelenia, srncia, diviacia, bazant, ina, platnost_najomnej_zmluvy_do, stavace_plan, stavace_skutocnost, sliedice_plan, sliedice_skutocnost, slovensky_kopov_plan, slovensky_kopov_skutocnost, ostatne_durice_plan, ostatne_durice_skutocnost, brlohare_plan, brlohare_skutocnost, farbiare_plan, farbiare_skutocnost, pes_jelenia_plan, pes_jelenia_skutocnost, pes_diviacia_plan, pes_diviacia_skutocnost, pes_srncia_plan, pes_srncia_skutocnost, pes_mala_plan, pes_mala_skutocnost) VALUES ('" & nazov & "', '" & sidlo & "', '" & predseda & "', '" & predseda_telefon & "', '" & polovnicky_hospodar & "', '" & polovnicky_hospodar_telefon & "', '" & ico & "', '" & dic & "', '" & banka & "', '" & cislo_uctu & "', '" & nazov_polovneho_reviru & "', '" & chovatelska_oblast & "', '" & cislo_reviru & "', '" & vymera & "', '" & les & "', '" & jelenia & "', '" & srncia & "', '" & diviacia & "', '" & bazant & "', '" & ina & "', '" & platnost_najomnej_zmluvy & "','" & stavace_plan & "', '" & stavace_skutocnost & "', '" & sliedice_plan & "', '" & sliedice_skutocnost & "', '" & slovensky_kopov_plan & "', '" & slovensky_kopov_skutocnost & "', '" & ostatne_durice_plan & "', '" & ostatne_durice_skutocnost & "', '" & brlohare_plan & "', '" & brlohare_skutocnost & "', '" & farbiare_plan & "', '" & farbiare_skutocnost & "', '" & pes_jelenia_plan & "','" & pes_jelenia_skutocnost & "', '" & pes_diviacia_plan & "', '" & pes_diviacia_skutocnost & "', '" & pes_srncia_plan & "', '" & pes_srncia_skutocnost & "', '" & pes_mala_plan & "', '" & pes_mala_skutocnost & "')", con)

                com.ExecuteNonQuery()
                con.Close()
                prehlad_zdruzeni.ZdruzenieTableAdapter.Fill(prehlad_zdruzeni.ZdruzenieDataSet.zdruzenie)
                Me.Close()

            End If

        Catch
            MsgBox("nieco nie je v poriadku :-)", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzenieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub NazovTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NazovTextBox.TextChanged

    End Sub

    Private Sub NazovTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NazovTextBox.Validating
        Dim chyba As String

        If Not kontrola_nazvu_zdruzenia(NazovTextBox.Text, chyba) Then
            'nastav a zobraz chybu
            ErrorProvider1.SetError(NazovTextBox, chyba)
        Else
            'zrus(chybu)
            ErrorProvider1.SetError(NazovTextBox, Nothing)
        End If
    End Sub
End Class