Public Class novy_student

    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub novy_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Typ_ubytovaniaDataSet.typ_ubytovania' table. You can move, or remove it, as needed.
        Me.Typ_ubytovaniaTableAdapter.Fill(Me.Typ_ubytovaniaDataSet.typ_ubytovania)
        'TODO: This line of code loads data into the 'Typ_izbyDataSet.typ_izby' table. You can move, or remove it, as needed.
        Me.Typ_izbyTableAdapter.Fill(Me.Typ_izbyDataSet.typ_izby)
        'TODO: This line of code loads data into the 'StudentDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.StudentDataSet.student)
        'TODO: This line of code loads data into the 'Db_internatDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Db_internatDataSet.student)
        'TODO: This line of code loads data into the 'SkupinaDataSet.skupina' table. You can move, or remove it, as needed.
        Me.SkupinaTableAdapter.Fill(Me.SkupinaDataSet.skupina)


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()

    End Sub

    Private Sub uloz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uloz.Click

        'Datum_narodeniaTextBox.Text = Datum_narodeniaDateTimePicker.Text
        'Op_vydany_dnaTextBox.Text = Op_vydany_dnaDateTimePicker.Text
        'Zz_datum_narodeniaTextBox.Text = Zz_datum_narodeniaDateTimePicker.Text


        


        Dim con As New SqlCeConnection("Data Source=|DataDirectory|\db_internat.sdf")
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO student (priezvisko, meno, datum_narodenia, miesto_narodenia, rodne_cislo, bydlisko, telefon, cislo_op, op_vydal, op_vydany_dna, skola_odkial_prichadza, skola_ktoru_bude_navstevovat, studijny_odbor, vzdialenost_bydlisko_internat, zaluby, zz_meno, zz_priezvisko, zz_datum_narodenia, zz_povolanie, zz_adresa_zamestnavatela, zz_telefon, zz_poznamka, id_skupina,zaciatok_ubytovania,id_typ_izby,id_typ_ubytovania) VALUES (@priezvisko,@meno,@datum_narodenia,@miesto_narodenia,@rodne_cislo,@bydlisko,@telefon,@cislo_op,@op_vydal,@op_datum_vydania,@skola_odkial_prichadza,@skola_ktoru_navstevuje,@studijny_odbor,@vzdialenost_bydlisko_internat,@zaluby,@zz_meno,@zz_priezvisko,@zz_datum_narodenia,@zz_povolanie,@zz_adresa_zamestnavatela,@zz_telefon,@zz_poznamka,@id_skupina,@zaciatok_ubytovania,@id_typ_izby,@id_typ_ubytovania)", con)


        With com.Parameters



            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)


            If Datum_narodeniaDateTimePicker.Checked = True Then
                .AddWithValue("datum_narodenia", Datum_narodeniaDateTimePicker.Value)
            Else
                .AddWithValue("datum_narodenia", DBNull.Value)
            End If

            .AddWithValue("miesto_narodenia", Miesto_narodeniaTextBox.Text)
            .AddWithValue("rodne_cislo", Rodne_cisloTextBox.Text)
            .AddWithValue("bydlisko", BydliskoTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("cislo_op", Cislo_opTextBox.Text)
            .AddWithValue("op_vydal", Op_vydalTextBox.Text)


            If Op_vydany_dnaDateTimePicker.Checked = True Then
                .AddWithValue("op_datum_vydania", Op_vydany_dnaDateTimePicker.Value)
            Else
                .AddWithValue("op_datum_vydania", DBNull.Value)
            End If

            .AddWithValue("skola_odkial_prichadza", Skola_odkial_prichadzaTextBox.Text)
            .AddWithValue("skola_ktoru_navstevuje", Skola_ktoru_bude_navstevovatTextBox.Text)
            .AddWithValue("studijny_odbor", Studijny_odborTextBox.Text)
            .AddWithValue("vzdialenost_bydlisko_internat", Vzdialenost_bydlisko_internatTextBox.Text)
            .AddWithValue("zaluby", ZalubyTextBox.Text)
            .AddWithValue("zz_meno", Zz_menoTextBox.Text)
            .AddWithValue("zz_priezvisko", Zz_priezviskoTextBox.Text)


            If Zz_datum_narodeniaDateTimePicker.Checked = True Then
                .AddWithValue("zz_datum_narodenia", Zz_datum_narodeniaDateTimePicker.Value)
            Else
                .AddWithValue("zz_datum_narodenia", DBNull.Value)
            End If

            .AddWithValue("zz_povolanie", Zz_povolanieTextBox.Text)
            .AddWithValue("zz_adresa_zamestnavatela", Zz_adresa_zamestnavatelaTextBox.Text)
            .AddWithValue("zz_telefon", Zz_telefonTextBox.Text)
            .AddWithValue("zz_poznamka", Zz_poznamkaTextBox.Text)
            .AddWithValue("id_skupina", skupinaComboBox.SelectedValue)


            If Zaciatok_ubytovaniaDateTimePicker.Checked = True Then
                .AddWithValue("zaciatok_ubytovania", Zaciatok_ubytovaniaDateTimePicker.Value)
            Else
                .AddWithValue("zaciatok_ubytovania", DBNull.Value)
            End If

            .AddWithValue("id_typ_izby", Id_typ_izbyComboBox.SelectedValue)
            .AddWithValue("id_typ_ubytovania", Id_typ_ubytovaniaComboBox.SelectedValue)

        End With

        com.ExecuteNonQuery()
        con.Close()




    End Sub

    Private Sub Datum_narodeniaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datum_narodeniaDateTimePicker.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim hlaska As String = Datum_narodeniaDateTimePicker.Text
        MsgBox(hlaska)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub
End Class