Public Class novy_student

    Private Sub StudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub novy_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        Dim priezvisko As String = PriezviskoTextBox.Text
        Dim meno As String = MenoTextBox.Text



        If Datum_narodeniaTextBox.Text = "" Then
           datum_narodenia as nul 
        End If


        Dim miesto_narodenia As String = Miesto_narodeniaTextBox.Text
        Dim rodne_cislo As String = Rodne_cisloTextBox.Text
        Dim bydlisko As String = BydliskoTextBox.Text
        Dim telefon As String = TelefonTextBox.Text
        Dim cislo_op As String = Cislo_opTextBox.Text
        Dim op_vydal As String = Op_vydalTextBox.Text
        Dim op_datum_vydania As Date = Op_vydany_dnaTextBox.Text
        Dim skola_odkial_prichadza As String = Skola_odkial_prichadzaTextBox.Text
        Dim skola_ktoru_navstevuje As String = Skola_ktoru_bude_navstevovatTextBox.Text
        Dim studijny_odbor As String = Studijny_odborTextBox.Text
        Dim vzdialenost_bydlisko_internat As String = Vzdialenost_bydlisko_internatTextBox.Text
        Dim zaluby As String = ZalubyTextBox.Text
        Dim zz_meno As String = Zz_menoTextBox.Text
        Dim zz_priezvisko As String = Zz_priezviskoTextBox.Text
        Dim zz_datum_narodenia As Date = Zz_datum_narodeniaTextBox.Text
        Dim zz_povolanie As String = Zz_povolanieTextBox.Text
        Dim zz_adresa_zamestnavatela As String = Zz_adresa_zamestnavatelaTextBox.Text
        Dim zz_telefon As String = Zz_telefonTextBox.Text
        Dim zz_poznamka As String = Zz_poznamkaTextBox.Text
        Dim id_skupina As Integer = skupinaComboBox.SelectedValue


        Dim con As New SqlCeConnection("Data Source=|DataDirectory|\db_internat.sdf")
        con.Open()

        Dim com As New SqlCeCommand("INSERT INTO student (priezvisko, meno, datum_narodenia, miesto_narodenia, rodne_cislo, bydlisko, telefon, cislo_op, op_vydal, op_vydany_dna, skola_odkial_prichadza, skola_ktoru_bude_navstevovat, studijny_odbor, vzdialenost_bydlisko_internat, zaluby, zz_meno, zz_priezvisko, zz_datum_narodenia, zz_povolanie, zz_adresa_zamestnavatela, zz_telefon, zz_poznamka, id_skupina) VALUES ('" & priezvisko & "','" & meno & "','" & datum_narodenia & "','" & miesto_narodenia & "','" & rodne_cislo & "','" & bydlisko & "','" & telefon & "','" & cislo_op & "','" & op_vydal & "','" & op_datum_vydania & "','" & skola_odkial_prichadza & "','" & skola_ktoru_navstevuje & "','" & studijny_odbor & "','" & vzdialenost_bydlisko_internat & "','" & zaluby & "','" & zz_meno & "','" & zz_priezvisko & "','" & zz_datum_narodenia & "','" & zz_povolanie & "','" & zz_adresa_zamestnavatela & "','" & zz_telefon & "','" & zz_poznamka & "','" & id_skupina & "')", con)
        'Dim com As New SqlCeCommand("INSERT INTO student (priezvisko) VALUES ('" & priezvisko & "')", con)
        com.ExecuteNonQuery()
        con.Close()




    End Sub

    Private Sub Datum_narodeniaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datum_narodeniaDateTimePicker.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hlaska As String = Datum_narodeniaDateTimePicker.Text
        MsgBox(hlaska)
    End Sub
End Class