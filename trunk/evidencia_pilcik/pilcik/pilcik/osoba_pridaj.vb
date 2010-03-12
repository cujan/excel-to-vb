Public Class osoba_pridaj

    Private Sub osoba_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.MdiParent = hlavna_aplikacia
    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub PriezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriezviskoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("INSERT INTO osoba (titul_pred, priezvisko, meno, datum_narodenia, rodne_cislo, cislo_op, ulica, mesto, psc, cislo_pilcickeho_preukazu, email, telefon, id_kurzu) VALUES   (@titul_pred, @priezvisko, @meno, @datum_narodenia, @rodne_cislo, @cislo_op, @ulica, @mesto, @psc, @cislo_pilcickeho_preukazu, @email, @telefon, @id_kurzu)", con)

        With com.Parameters
            .AddWithValue("titul_pred", Titul_predTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value.Date)
            .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
            .AddWithValue("cislo_op", Cislo_opTextBox.Text)
            .AddWithValue("ulica", UlicaTextBox.Text)
            .AddWithValue("mesto", MestoTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("cislo_pilcickeho_preukazu", Cislo_pilcickeho_preukazuTextBox.Text)
            .AddWithValue("email", EmailTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            If Id_kurzTextBox.Text <> "" Then
                .AddWithValue("id_kurzu", Id_kurzTextBox.Text)
            Else
                .AddWithValue("id_kurzu", DBNull.Value)
            End If
        End With
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Me.OsobaTableAdapter.Fill(PilcikdbDataSet.osoba)
    End Sub

    Private Sub OsobaBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub
End Class