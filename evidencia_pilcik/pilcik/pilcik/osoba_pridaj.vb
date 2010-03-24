Public Class osoba_pridaj

    Private Sub osoba_pridaj_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub osoba_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter1.Fill(Me.KurzComboDataSet.kurz)
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.PilcikdbDataSet.kurz)
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.MdiParent = hlavna_aplikacia
        Me.OsobaDataGridView.CurrentRow.Selected = Nothing
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        kurzComboBox.SelectedIndex = -1

    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PriezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriezviskoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click

        If Label3.Text <> "" Then

            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("INSERT INTO osoba (titul_pred, priezvisko, meno, datum_narodenia, rodne_cislo, cislo_op, ulica, mesto, psc, cislo_pilcickeho_preukazu, email, telefon, id_kurzu) VALUES   (@titul_pred, @priezvisko, @meno, @datum_narodenia, @rodne_cislo, @cislo_op, @ulica, @mesto, @psc, @cislo_pilcickeho_preukazu, @email, @telefon, @id_kurzu)", con)

            With com.Parameters
                .AddWithValue("titul_pred", Titul_predTextBox.Text)
                .AddWithValue("priezvisko", PriezviskoTextBox.Text)
                .AddWithValue("meno", MenoTextBox.Text)
                If Datum_narodeniaDateTimePicker.Checked = True Then
                    .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value.Date)
                Else
                    .AddWithValue("datum_narodenia", DBNull.Value)
                End If
                .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
                .AddWithValue("cislo_op", Cislo_opTextBox.Text)
                .AddWithValue("ulica", UlicaTextBox.Text)
                .AddWithValue("mesto", MestoTextBox.Text)
                .AddWithValue("psc", PscTextBox.Text)
                .AddWithValue("cislo_pilcickeho_preukazu", Cislo_pilcickeho_preukazuTextBox.Text)
                .AddWithValue("email", EmailTextBox.Text)
                .AddWithValue("telefon", TelefonTextBox.Text)
                .AddWithValue("id_kurzu", kurzComboBox.SelectedValue)
            End With
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            Me.OsobaTableAdapter.Fill(PilcikdbDataSet.osoba)
            'vymayanie udajov z policok
            Titul_predTextBox.Text = ""
            PriezviskoTextBox.Text = ""
            MenoTextBox.Text = ""
            Rodne_cisloTextBox.Text = ""
            Datum_narodeniaDateTimePicker.Checked = False
            UlicaTextBox.Text = ""
            MestoTextBox.Text = ""
            PscTextBox.Text = ""
            Cislo_opTextBox.Text = ""
            Cislo_pilcickeho_preukazuTextBox.Text = ""
            EmailTextBox.Text = ""
            TelefonTextBox.Text = ""
            kurzComboBox.SelectedIndex = -1

        Else
            MsgBox("Nemate vybraty kurz")
        End If
    End Sub

    Private Sub OsobaBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub OsobaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellClick
        
    End Sub

    Private Sub OsobaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Naozaj chcete zmazať vybraného člena?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("DELETE FROM osoba WHERE id = @id", con)
            com.Parameters.AddWithValue("id", Label2.Text)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

        End If
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        Me.OsobaDataGridView.CurrentRow.Selected = Nothing
    End Sub

    Private Sub KurzDataGridView_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Label4.Text = Label3.Text
        Label3.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class