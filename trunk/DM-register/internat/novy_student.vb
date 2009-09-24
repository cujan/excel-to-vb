Public Class novy_student

    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub novy_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SkupinaDataSet.skupina' table. You can move, or remove it, as needed.
        Me.SkupinaTableAdapter.Fill(Me.SkupinaDataSet.skupina)

        Dim priezvisko As String = PriezviskoTextBox.Text
        Dim meno As String = MenoTextBox.Text
        Dim datum_narodenia As Date = Datum_narodeniaDateTimePicker.Text
        Dim miesto_narodenia As String = Miesto_narodeniaTextBox.Text
        Dim rodne_cislo As String = Rodne_cisloTextBox.Text
        Dim bydlisko As String = BydliskoTextBox.Text
        Dim telefon As String = TelefonTextBox.Text
        Dim cislo_op As String = Cislo_opTextBox.Text
        Dim op_vydal As String = Op_vydalTextBox.Text
        Dim op_datum_vydania As Date = Op_vydany_dnaDateTimePicker.Text
        Dim skola_odkial_prichadza As String = Skola_odkial_prichadzaTextBox.Text
        Dim skola_ktoru_navstevuje As String = Skola_ktoru_bude_navstevovatTextBox.Text
        Dim studijny_odbor As String = Studijny_odborTextBox.Text
        Dim vzdialenost_bydlisko_internat As String = Vzdialenost_bydlisko_internatTextBox.Text
        Dim zaluby As String = ZalubyTextBox.Text
        Dim zz_meno As String = Zz_menoTextBox.Text
        Dim zz_priezvisko As String = Zz_priezviskoTextBox.Text
        Dim zz_datum_narodenia As Date = Zz_datum_narodeniaDateTimePicker.Text
        Dim zz_povolanie As String = Zz_povolanieTextBox.Text
        Dim zz_adresa_zamestnavatela As String = Zz_adresa_zamestnavatelaTextBox.Text
        Dim zz_telefon As String = Zz_telefonTextBox.Text
        Dim zz_poznamka As String = Zz_poznamkaTextBox.Text
        Dim id_skupina As Integer = skupinaComboBox.SelectedValue

    End Sub
End Class