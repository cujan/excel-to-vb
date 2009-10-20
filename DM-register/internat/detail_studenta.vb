Public Class detail_studenta

    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub detail_studenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.student' table. You can move, or remove it, as needed.
        Dim id_clena As Integer = evidencia_studentov.Label1.Text
        Me.StudentTableAdapter.FillBy_id(Me.StudentDataSet.student, id_clena)

    End Sub

    Private Sub editujButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editujButton.Click
        PriezviskoTextBox.ReadOnly = False
        MenoTextBox.ReadOnly = False

        Miesto_narodeniaTextBox.ReadOnly = False
        Rodne_cisloTextBox.ReadOnly = False
        BydliskoTextBox.ReadOnly = False
        TelefonTextBox.ReadOnly = False
        Cislo_opTextBox.ReadOnly = False
        Op_vydalTextBox.ReadOnly = False

        Skola_odkial_prichadzaTextBox.ReadOnly = False
        Skola_ktoru_bude_navstevovatTextBox.ReadOnly = False
        Studijny_odborTextBox.ReadOnly = False
        Vzdialenost_bydlisko_internatTextBox.ReadOnly = False
        ZalubyTextBox.ReadOnly = False
        Zz_menoTextBox.ReadOnly = False
        Zz_priezviskoTextBox.ReadOnly = False

        Zz_povolanieTextBox.ReadOnly = False
        Zz_adresa_zamestnavatelaTextBox.ReadOnly = False
        Zz_telefonTextBox.ReadOnly = False
        Zz_poznamkaTextBox.ReadOnly = False
        Id_skupinaTextBox.ReadOnly = False


        ulozButton.Visible = True

    End Sub

    Private Sub zatvorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zatvorButton.Click
        Me.Close()
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click

        Dim id_studenta As Integer = evidencia_studentov.Label1.Text


        Dim con As New SqlCeConnection(connectionString:="Data Source=|DataDirectory|\db_internat.sdf")
        con.Open()
        Dim com As New SqlCeCommand("UPDATE    student SET  priezvisko = @p1, meno = @p2, datum_narodenia = @p3, miesto_narodenia = @p4, rodne_cislo = @p5, bydlisko = @p6, telefon = @p7, cislo_op = @p8, op_vydal = @p9, op_vydany_dna = @p10, skola_odkial_prichadza = @p11, skola_ktoru_bude_navstevovat = @p12, studijny_odbor = @p13, vzdialenost_bydlisko_internat = @p14, zaluby = @p15, zz_meno = @p16, zz_priezvisko = @p17, zz_datum_narodenia = @p18, zz_povolanie = @p19, zz_adresa_zamestnavatela = @p20, zz_telefon = @p21, zz_poznamka = @p22,  id_skupina = @p24 WHERE     (id = @p25)", con)

        With com.Parameters
            .AddWithValue("p1", PriezviskoTextBox.Text)
            .AddWithValue("p2", MenoTextBox.Text)
            .AddWithValue("p3", DBNull.Value)
            .AddWithValue("p4", Miesto_narodeniaTextBox.Text)
            .AddWithValue("p5", Rodne_cisloTextBox.Text)
            .AddWithValue("p6", BydliskoTextBox.Text)
            .AddWithValue("p7", TelefonTextBox.Text)
            .AddWithValue("p8", Cislo_opTextBox.Text)
            .AddWithValue("p9", Op_vydalTextBox.Text)
            .AddWithValue("p10", DBNull.Value)
            .AddWithValue("p11", DBNull.Value)
            .AddWithValue("p12", DBNull.Value)
            .AddWithValue("p13", DBNull.Value)
            .AddWithValue("p14", DBNull.Value)
            .AddWithValue("p15", DBNull.Value)
            .AddWithValue("p16", DBNull.Value)
            .AddWithValue("p17", DBNull.Value)
            .AddWithValue("p18", DBNull.Value)
            .AddWithValue("p19", DBNull.Value)
            .AddWithValue("p20", DBNull.Value)
            .AddWithValue("p21", DBNull.Value)
            .AddWithValue("p22", DBNull.Value)
            '.AddWithValue("p23", DBNull.Value) to je parameter pre foto
            .AddWithValue("p24", DBNull.Value)
            .AddWithValue("p25", id_studenta)

        End With


        com.ExecuteNonQuery()
        con.Close()
    End Sub
End Class