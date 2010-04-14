Public Class osoba_pridaj

    Private Sub osoba_pridaj_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub osoba_pridaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = hlavna_aplikacia
        'TODO: This line of code loads data into the 'PilcikdbDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
        'TODO: This line of code loads data into the 'KurzComboDataSet.kurz' table. You can move, or remove it, as needed.
        
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        'Me.OsobaDataGridView.CurrentCell = Nothing
        Label5.BringToFront()

    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PriezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriezviskoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click



        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("INSERT INTO osoba (titul_pred, priezvisko, meno, datum_narodenia, rodne_cislo, cislo_op, ulica, mesto, psc, cislo_pilcickeho_preukazu, email, telefon) VALUES   (@titul_pred, @priezvisko, @meno, @datum_narodenia, @rodne_cislo, @cislo_op, @ulica, @mesto, @psc, @cislo_pilcickeho_preukazu, @email, @telefon)", con)

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

        End With
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)

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


        
    End Sub

    Private Sub OsobaBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource1BindingNavigatorSaveItem.Click
       

    End Sub

    Private Sub OsobaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub OsobaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim priezvisko As String = Label4.Text
        If Label4.Text <> "" Then
            If MsgBox("Naozaj chcete zmazať vybraného člena - " + priezvisko + "? Zmaže sa aj ako účastník všetkých kurzov!!!", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM osoba WHERE id = @id", con)
                Dim com1 As New SqlCeCommand("DELETE FROM clenovia_kurzu WHERE clen_id = @id", con)
                com.Parameters.AddWithValue("id", Label2.Text)
                com1.Parameters.AddWithValue("id", Label2.Text)
                con.Open()
                com.ExecuteNonQuery()
                com1.ExecuteNonQuery()
                con.Close()
                Me.OsobaTableAdapter.Fill(Me.PilcikdbDataSet.osoba)
            End If
        Else
            MsgBox("Nemáte vybraného žiadneho člena.")
        End If

    End Sub

    Private Sub KurzDataGridView_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        'Label4.Text = Label3.Text
        'Label3.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub OsobaBindingSource2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingSource2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource2.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub OsobaDataGridView_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellClick
        'nacitanie id
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
        'nacitanie prieyviska
        Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OsobaBindingSource2, "priezvisko", True))
        Label6.Text = Label4.Text
        Label4.DataBindings.Clear()
    End Sub

    Private Sub OsobaDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellContentClick

    End Sub

    Private Sub OsobaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles OsobaDataGridView.CellDoubleClick
        osoba_detail.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim priezvisko As String = TextBox1.Text & "%"
        Me.OsobaTableAdapter.FillBy_priezvisko(Me.PilcikdbDataSet.osoba, priezvisko)
    End Sub
End Class