<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class novy_student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim Miesto_narodeniaLabel As System.Windows.Forms.Label
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim BydliskoLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim Op_vydalLabel As System.Windows.Forms.Label
        Dim Op_vydany_dnaLabel As System.Windows.Forms.Label
        Dim Skola_odkial_prichadzaLabel As System.Windows.Forms.Label
        Dim Skola_ktoru_bude_navstevovatLabel As System.Windows.Forms.Label
        Dim Studijny_odborLabel As System.Windows.Forms.Label
        Dim Vzdialenost_bydlisko_internatLabel As System.Windows.Forms.Label
        Dim ZalubyLabel As System.Windows.Forms.Label
        Dim Zz_menoLabel As System.Windows.Forms.Label
        Dim Zz_priezviskoLabel As System.Windows.Forms.Label
        Dim Zz_datum_narodeniaLabel As System.Windows.Forms.Label
        Dim Zz_povolanieLabel As System.Windows.Forms.Label
        Dim Zz_adresa_zamestnavatelaLabel As System.Windows.Forms.Label
        Dim Zz_telefonLabel As System.Windows.Forms.Label
        Dim Zz_poznamkaLabel As System.Windows.Forms.Label
        Dim Id_skupinaLabel As System.Windows.Forms.Label
        Dim Zaciatok_ubytovaniaLabel As System.Windows.Forms.Label
        Dim Id_typ_izbyLabel1 As System.Windows.Forms.Label
        Dim Id_typ_ubytovaniaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(novy_student))
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Op_vydalTextBox = New System.Windows.Forms.TextBox
        Me.Op_vydany_dnaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Skola_odkial_prichadzaTextBox = New System.Windows.Forms.TextBox
        Me.Skola_ktoru_bude_navstevovatTextBox = New System.Windows.Forms.TextBox
        Me.Studijny_odborTextBox = New System.Windows.Forms.TextBox
        Me.Vzdialenost_bydlisko_internatTextBox = New System.Windows.Forms.TextBox
        Me.ZalubyTextBox = New System.Windows.Forms.TextBox
        Me.Zz_menoTextBox = New System.Windows.Forms.TextBox
        Me.Zz_priezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Zz_datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Zz_povolanieTextBox = New System.Windows.Forms.TextBox
        Me.Zz_adresa_zamestnavatelaTextBox = New System.Windows.Forms.TextBox
        Me.Zz_telefonTextBox = New System.Windows.Forms.TextBox
        Me.Zz_poznamkaTextBox = New System.Windows.Forms.TextBox
        Me.skupinaComboBox = New System.Windows.Forms.ComboBox
        Me.SkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkupinaDataSet = New internat.skupinaDataSet
        Me.SkupinaTableAdapter = New internat.skupinaDataSetTableAdapters.skupinaTableAdapter
        Me.zavriet_kartu_button = New System.Windows.Forms.Button
        Me.uloz = New System.Windows.Forms.Button
        Me.Db_internatDataSet = New internat.db_internatDataSet
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New internat.db_internatDataSetTableAdapters.studentTableAdapter
        Me.TableAdapterManager = New internat.db_internatDataSetTableAdapters.TableAdapterManager
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.zz_label = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.StudentDataSet = New internat.studentDataSet
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter1 = New internat.studentDataSetTableAdapters.studentTableAdapter
        Me.TableAdapterManager1 = New internat.studentDataSetTableAdapters.TableAdapterManager
        Me.Zaciatok_ubytovaniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Id_typ_izbyComboBox = New System.Windows.Forms.ComboBox
        Me.TypizbyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Typ_izbyDataSet = New internat.typ_izbyDataSet
        Me.Id_typ_ubytovaniaComboBox = New System.Windows.Forms.ComboBox
        Me.TypubytovaniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Typ_ubytovaniaDataSet = New internat.typ_ubytovaniaDataSet
        Me.Typ_izbyTableAdapter = New internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
        Me.Typ_ubytovaniaTableAdapter = New internat.typ_ubytovaniaDataSetTableAdapters.typ_ubytovaniaTableAdapter
        PriezviskoLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        Miesto_narodeniaLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        BydliskoLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        Op_vydalLabel = New System.Windows.Forms.Label
        Op_vydany_dnaLabel = New System.Windows.Forms.Label
        Skola_odkial_prichadzaLabel = New System.Windows.Forms.Label
        Skola_ktoru_bude_navstevovatLabel = New System.Windows.Forms.Label
        Studijny_odborLabel = New System.Windows.Forms.Label
        Vzdialenost_bydlisko_internatLabel = New System.Windows.Forms.Label
        ZalubyLabel = New System.Windows.Forms.Label
        Zz_menoLabel = New System.Windows.Forms.Label
        Zz_priezviskoLabel = New System.Windows.Forms.Label
        Zz_datum_narodeniaLabel = New System.Windows.Forms.Label
        Zz_povolanieLabel = New System.Windows.Forms.Label
        Zz_adresa_zamestnavatelaLabel = New System.Windows.Forms.Label
        Zz_telefonLabel = New System.Windows.Forms.Label
        Zz_poznamkaLabel = New System.Windows.Forms.Label
        Id_skupinaLabel = New System.Windows.Forms.Label
        Zaciatok_ubytovaniaLabel = New System.Windows.Forms.Label
        Id_typ_izbyLabel1 = New System.Windows.Forms.Label
        Id_typ_ubytovaniaLabel1 = New System.Windows.Forms.Label
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_internatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypizbyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypubytovaniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Typ_ubytovaniaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(216, 97)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(58, 13)
        PriezviskoLabel.TabIndex = 3
        PriezviskoLabel.Text = "Priezvisko:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(237, 71)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(37, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "Meno:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(183, 124)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Datum_narodeniaLabel.TabIndex = 7
        Datum_narodeniaLabel.Text = "Dátum narodenia:"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(183, 257)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Miesto_narodeniaLabel.TabIndex = 9
        Miesto_narodeniaLabel.Text = "Miesto narodenia:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(206, 283)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(68, 13)
        Rodne_cisloLabel.TabIndex = 11
        Rodne_cisloLabel.Text = "Rodné číslo:"
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(225, 149)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(49, 13)
        BydliskoLabel.TabIndex = 13
        BydliskoLabel.Text = "Bydlisko:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(228, 175)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 15
        TelefonLabel.Text = "Telefón:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(526, 257)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(52, 13)
        Cislo_opLabel.TabIndex = 17
        Cislo_opLabel.Text = "Číslo OP:"
        '
        'Op_vydalLabel
        '
        Op_vydalLabel.AutoSize = True
        Op_vydalLabel.Location = New System.Drawing.Point(525, 283)
        Op_vydalLabel.Name = "Op_vydalLabel"
        Op_vydalLabel.Size = New System.Drawing.Size(53, 13)
        Op_vydalLabel.TabIndex = 19
        Op_vydalLabel.Text = "OP vydal:"
        '
        'Op_vydany_dnaLabel
        '
        Op_vydany_dnaLabel.AutoSize = True
        Op_vydany_dnaLabel.Location = New System.Drawing.Point(495, 310)
        Op_vydany_dnaLabel.Name = "Op_vydany_dnaLabel"
        Op_vydany_dnaLabel.Size = New System.Drawing.Size(83, 13)
        Op_vydany_dnaLabel.TabIndex = 21
        Op_vydany_dnaLabel.Text = "OP vydaný dňa:"
        '
        'Skola_odkial_prichadzaLabel
        '
        Skola_odkial_prichadzaLabel.AutoSize = True
        Skola_odkial_prichadzaLabel.Location = New System.Drawing.Point(194, 386)
        Skola_odkial_prichadzaLabel.Name = "Skola_odkial_prichadzaLabel"
        Skola_odkial_prichadzaLabel.Size = New System.Drawing.Size(80, 13)
        Skola_odkial_prichadzaLabel.TabIndex = 23
        Skola_odkial_prichadzaLabel.Text = "Súčasná škola:"
        '
        'Skola_ktoru_bude_navstevovatLabel
        '
        Skola_ktoru_bude_navstevovatLabel.AutoSize = True
        Skola_ktoru_bude_navstevovatLabel.Location = New System.Drawing.Point(462, 386)
        Skola_ktoru_bude_navstevovatLabel.Name = "Skola_ktoru_bude_navstevovatLabel"
        Skola_ktoru_bude_navstevovatLabel.Size = New System.Drawing.Size(115, 13)
        Skola_ktoru_bude_navstevovatLabel.TabIndex = 25
        Skola_ktoru_bude_navstevovatLabel.Text = "Predchádzajúca škola:"
        '
        'Studijny_odborLabel
        '
        Studijny_odborLabel.AutoSize = True
        Studijny_odborLabel.Location = New System.Drawing.Point(197, 412)
        Studijny_odborLabel.Name = "Studijny_odborLabel"
        Studijny_odborLabel.Size = New System.Drawing.Size(77, 13)
        Studijny_odborLabel.TabIndex = 27
        Studijny_odborLabel.Text = "Štúdijný odbor:"
        '
        'Vzdialenost_bydlisko_internatLabel
        '
        Vzdialenost_bydlisko_internatLabel.AutoSize = True
        Vzdialenost_bydlisko_internatLabel.Location = New System.Drawing.Point(112, 306)
        Vzdialenost_bydlisko_internatLabel.Name = "Vzdialenost_bydlisko_internatLabel"
        Vzdialenost_bydlisko_internatLabel.Size = New System.Drawing.Size(162, 13)
        Vzdialenost_bydlisko_internatLabel.TabIndex = 29
        Vzdialenost_bydlisko_internatLabel.Text = "Vzdialenosť od trvalého bydliska:"
        '
        'ZalubyLabel
        '
        ZalubyLabel.AutoSize = True
        ZalubyLabel.Location = New System.Drawing.Point(230, 438)
        ZalubyLabel.Name = "ZalubyLabel"
        ZalubyLabel.Size = New System.Drawing.Size(44, 13)
        ZalubyLabel.TabIndex = 31
        ZalubyLabel.Text = "Záľuby:"
        '
        'Zz_menoLabel
        '
        Zz_menoLabel.AutoSize = True
        Zz_menoLabel.Location = New System.Drawing.Point(237, 541)
        Zz_menoLabel.Name = "Zz_menoLabel"
        Zz_menoLabel.Size = New System.Drawing.Size(37, 13)
        Zz_menoLabel.TabIndex = 33
        Zz_menoLabel.Text = "Meno:"
        '
        'Zz_priezviskoLabel
        '
        Zz_priezviskoLabel.AutoSize = True
        Zz_priezviskoLabel.Location = New System.Drawing.Point(519, 541)
        Zz_priezviskoLabel.Name = "Zz_priezviskoLabel"
        Zz_priezviskoLabel.Size = New System.Drawing.Size(58, 13)
        Zz_priezviskoLabel.TabIndex = 35
        Zz_priezviskoLabel.Text = "Priezvisko:"
        '
        'Zz_datum_narodeniaLabel
        '
        Zz_datum_narodeniaLabel.AutoSize = True
        Zz_datum_narodeniaLabel.Location = New System.Drawing.Point(183, 568)
        Zz_datum_narodeniaLabel.Name = "Zz_datum_narodeniaLabel"
        Zz_datum_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Zz_datum_narodeniaLabel.TabIndex = 37
        Zz_datum_narodeniaLabel.Text = "Dátum narodenia:"
        '
        'Zz_povolanieLabel
        '
        Zz_povolanieLabel.AutoSize = True
        Zz_povolanieLabel.Location = New System.Drawing.Point(520, 568)
        Zz_povolanieLabel.Name = "Zz_povolanieLabel"
        Zz_povolanieLabel.Size = New System.Drawing.Size(57, 13)
        Zz_povolanieLabel.TabIndex = 39
        Zz_povolanieLabel.Text = "Povolanie:"
        '
        'Zz_adresa_zamestnavatelaLabel
        '
        Zz_adresa_zamestnavatelaLabel.AutoSize = True
        Zz_adresa_zamestnavatelaLabel.Location = New System.Drawing.Point(152, 593)
        Zz_adresa_zamestnavatelaLabel.Name = "Zz_adresa_zamestnavatelaLabel"
        Zz_adresa_zamestnavatelaLabel.Size = New System.Drawing.Size(122, 13)
        Zz_adresa_zamestnavatelaLabel.TabIndex = 41
        Zz_adresa_zamestnavatelaLabel.Text = "Adresa zamestnávateľa:"
        '
        'Zz_telefonLabel
        '
        Zz_telefonLabel.AutoSize = True
        Zz_telefonLabel.Location = New System.Drawing.Point(228, 619)
        Zz_telefonLabel.Name = "Zz_telefonLabel"
        Zz_telefonLabel.Size = New System.Drawing.Size(46, 13)
        Zz_telefonLabel.TabIndex = 43
        Zz_telefonLabel.Text = "Telefón:"
        '
        'Zz_poznamkaLabel
        '
        Zz_poznamkaLabel.AutoSize = True
        Zz_poznamkaLabel.Location = New System.Drawing.Point(517, 593)
        Zz_poznamkaLabel.Name = "Zz_poznamkaLabel"
        Zz_poznamkaLabel.Size = New System.Drawing.Size(60, 13)
        Zz_poznamkaLabel.TabIndex = 45
        Zz_poznamkaLabel.Text = "Poznámka:"
        '
        'Id_skupinaLabel
        '
        Id_skupinaLabel.AutoSize = True
        Id_skupinaLabel.Location = New System.Drawing.Point(528, 412)
        Id_skupinaLabel.Name = "Id_skupinaLabel"
        Id_skupinaLabel.Size = New System.Drawing.Size(49, 13)
        Id_skupinaLabel.TabIndex = 47
        Id_skupinaLabel.Text = "Skupina:"
        '
        'Zaciatok_ubytovaniaLabel
        '
        Zaciatok_ubytovaniaLabel.AutoSize = True
        Zaciatok_ubytovaniaLabel.Location = New System.Drawing.Point(184, 692)
        Zaciatok_ubytovaniaLabel.Name = "Zaciatok_ubytovaniaLabel"
        Zaciatok_ubytovaniaLabel.Size = New System.Drawing.Size(105, 13)
        Zaciatok_ubytovaniaLabel.TabIndex = 0
        Zaciatok_ubytovaniaLabel.Text = "zaciatok ubytovania:"
        '
        'Id_typ_izbyLabel1
        '
        Id_typ_izbyLabel1.AutoSize = True
        Id_typ_izbyLabel1.Location = New System.Drawing.Point(294, 737)
        Id_typ_izbyLabel1.Name = "Id_typ_izbyLabel1"
        Id_typ_izbyLabel1.Size = New System.Drawing.Size(56, 13)
        Id_typ_izbyLabel1.TabIndex = 5
        Id_typ_izbyLabel1.Text = "id typ izby:"
        '
        'Id_typ_ubytovaniaLabel1
        '
        Id_typ_ubytovaniaLabel1.AutoSize = True
        Id_typ_ubytovaniaLabel1.Location = New System.Drawing.Point(260, 773)
        Id_typ_ubytovaniaLabel1.Name = "Id_typ_ubytovaniaLabel1"
        Id_typ_ubytovaniaLabel1.Size = New System.Drawing.Size(90, 13)
        Id_typ_ubytovaniaLabel1.TabIndex = 7
        Id_typ_ubytovaniaLabel1.Text = "id typ ubytovania:"
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(280, 94)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(141, 20)
        Me.PriezviskoTextBox.TabIndex = 4
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(280, 68)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(141, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Checked = False
        Me.Datum_narodeniaDateTimePicker.CustomFormat = "dd MM YYYY"
        Me.Datum_narodeniaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(280, 120)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.ShowCheckBox = True
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(141, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 8
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(280, 254)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 10
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(280, 280)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Rodne_cisloTextBox.TabIndex = 12
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.Location = New System.Drawing.Point(280, 146)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(141, 20)
        Me.BydliskoTextBox.TabIndex = 14
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(280, 172)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(141, 20)
        Me.TelefonTextBox.TabIndex = 16
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(583, 254)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Cislo_opTextBox.TabIndex = 18
        '
        'Op_vydalTextBox
        '
        Me.Op_vydalTextBox.Location = New System.Drawing.Point(583, 280)
        Me.Op_vydalTextBox.Name = "Op_vydalTextBox"
        Me.Op_vydalTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Op_vydalTextBox.TabIndex = 20
        '
        'Op_vydany_dnaDateTimePicker
        '
        Me.Op_vydany_dnaDateTimePicker.Checked = False
        Me.Op_vydany_dnaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Op_vydany_dnaDateTimePicker.Location = New System.Drawing.Point(583, 306)
        Me.Op_vydany_dnaDateTimePicker.Name = "Op_vydany_dnaDateTimePicker"
        Me.Op_vydany_dnaDateTimePicker.ShowCheckBox = True
        Me.Op_vydany_dnaDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.Op_vydany_dnaDateTimePicker.TabIndex = 22
        '
        'Skola_odkial_prichadzaTextBox
        '
        Me.Skola_odkial_prichadzaTextBox.Location = New System.Drawing.Point(280, 383)
        Me.Skola_odkial_prichadzaTextBox.Name = "Skola_odkial_prichadzaTextBox"
        Me.Skola_odkial_prichadzaTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Skola_odkial_prichadzaTextBox.TabIndex = 24
        '
        'Skola_ktoru_bude_navstevovatTextBox
        '
        Me.Skola_ktoru_bude_navstevovatTextBox.Location = New System.Drawing.Point(583, 383)
        Me.Skola_ktoru_bude_navstevovatTextBox.Name = "Skola_ktoru_bude_navstevovatTextBox"
        Me.Skola_ktoru_bude_navstevovatTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Skola_ktoru_bude_navstevovatTextBox.TabIndex = 26
        '
        'Studijny_odborTextBox
        '
        Me.Studijny_odborTextBox.Location = New System.Drawing.Point(280, 409)
        Me.Studijny_odborTextBox.Name = "Studijny_odborTextBox"
        Me.Studijny_odborTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Studijny_odborTextBox.TabIndex = 28
        '
        'Vzdialenost_bydlisko_internatTextBox
        '
        Me.Vzdialenost_bydlisko_internatTextBox.Location = New System.Drawing.Point(280, 303)
        Me.Vzdialenost_bydlisko_internatTextBox.Name = "Vzdialenost_bydlisko_internatTextBox"
        Me.Vzdialenost_bydlisko_internatTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Vzdialenost_bydlisko_internatTextBox.TabIndex = 30
        '
        'ZalubyTextBox
        '
        Me.ZalubyTextBox.Location = New System.Drawing.Point(280, 435)
        Me.ZalubyTextBox.Name = "ZalubyTextBox"
        Me.ZalubyTextBox.Size = New System.Drawing.Size(136, 20)
        Me.ZalubyTextBox.TabIndex = 32
        '
        'Zz_menoTextBox
        '
        Me.Zz_menoTextBox.Location = New System.Drawing.Point(280, 538)
        Me.Zz_menoTextBox.Name = "Zz_menoTextBox"
        Me.Zz_menoTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Zz_menoTextBox.TabIndex = 34
        '
        'Zz_priezviskoTextBox
        '
        Me.Zz_priezviskoTextBox.Location = New System.Drawing.Point(583, 538)
        Me.Zz_priezviskoTextBox.Name = "Zz_priezviskoTextBox"
        Me.Zz_priezviskoTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Zz_priezviskoTextBox.TabIndex = 36
        '
        'Zz_datum_narodeniaDateTimePicker
        '
        Me.Zz_datum_narodeniaDateTimePicker.Checked = False
        Me.Zz_datum_narodeniaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Zz_datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(280, 564)
        Me.Zz_datum_narodeniaDateTimePicker.Name = "Zz_datum_narodeniaDateTimePicker"
        Me.Zz_datum_narodeniaDateTimePicker.ShowCheckBox = True
        Me.Zz_datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(141, 20)
        Me.Zz_datum_narodeniaDateTimePicker.TabIndex = 38
        '
        'Zz_povolanieTextBox
        '
        Me.Zz_povolanieTextBox.Location = New System.Drawing.Point(583, 565)
        Me.Zz_povolanieTextBox.Name = "Zz_povolanieTextBox"
        Me.Zz_povolanieTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Zz_povolanieTextBox.TabIndex = 40
        '
        'Zz_adresa_zamestnavatelaTextBox
        '
        Me.Zz_adresa_zamestnavatelaTextBox.Location = New System.Drawing.Point(280, 590)
        Me.Zz_adresa_zamestnavatelaTextBox.Name = "Zz_adresa_zamestnavatelaTextBox"
        Me.Zz_adresa_zamestnavatelaTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Zz_adresa_zamestnavatelaTextBox.TabIndex = 42
        '
        'Zz_telefonTextBox
        '
        Me.Zz_telefonTextBox.Location = New System.Drawing.Point(280, 616)
        Me.Zz_telefonTextBox.Name = "Zz_telefonTextBox"
        Me.Zz_telefonTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Zz_telefonTextBox.TabIndex = 44
        '
        'Zz_poznamkaTextBox
        '
        Me.Zz_poznamkaTextBox.Location = New System.Drawing.Point(583, 593)
        Me.Zz_poznamkaTextBox.Multiline = True
        Me.Zz_poznamkaTextBox.Name = "Zz_poznamkaTextBox"
        Me.Zz_poznamkaTextBox.Size = New System.Drawing.Size(235, 80)
        Me.Zz_poznamkaTextBox.TabIndex = 46
        '
        'skupinaComboBox
        '
        Me.skupinaComboBox.DataSource = Me.SkupinaBindingSource
        Me.skupinaComboBox.DisplayMember = "nazov_skupiny"
        Me.skupinaComboBox.FormattingEnabled = True
        Me.skupinaComboBox.Location = New System.Drawing.Point(583, 409)
        Me.skupinaComboBox.Name = "skupinaComboBox"
        Me.skupinaComboBox.Size = New System.Drawing.Size(108, 21)
        Me.skupinaComboBox.TabIndex = 48
        Me.skupinaComboBox.ValueMember = "id"
        '
        'SkupinaBindingSource
        '
        Me.SkupinaBindingSource.DataMember = "skupina"
        Me.SkupinaBindingSource.DataSource = Me.SkupinaDataSet
        '
        'SkupinaDataSet
        '
        Me.SkupinaDataSet.DataSetName = "skupinaDataSet"
        Me.SkupinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkupinaTableAdapter
        '
        Me.SkupinaTableAdapter.ClearBeforeFill = True
        '
        'zavriet_kartu_button
        '
        Me.zavriet_kartu_button.BackColor = System.Drawing.Color.CornflowerBlue
        Me.zavriet_kartu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zavriet_kartu_button.Location = New System.Drawing.Point(344, 12)
        Me.zavriet_kartu_button.Name = "zavriet_kartu_button"
        Me.zavriet_kartu_button.Size = New System.Drawing.Size(108, 23)
        Me.zavriet_kartu_button.TabIndex = 49
        Me.zavriet_kartu_button.Text = "Zavrieť kartu"
        Me.zavriet_kartu_button.UseVisualStyleBackColor = False
        '
        'uloz
        '
        Me.uloz.BackColor = System.Drawing.Color.CornflowerBlue
        Me.uloz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.uloz.Location = New System.Drawing.Point(263, 12)
        Me.uloz.Name = "uloz"
        Me.uloz.Size = New System.Drawing.Size(75, 23)
        Me.uloz.TabIndex = 50
        Me.uloz.Text = "Ulož"
        Me.uloz.UseVisualStyleBackColor = False
        '
        'Db_internatDataSet
        '
        Me.Db_internatDataSet.DataSetName = "db_internatDataSet"
        Me.Db_internatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.Db_internatDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.skupinaTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = internat.db_internatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vychovavatelTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 130)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'zz_label
        '
        Me.zz_label.AutoSize = True
        Me.zz_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zz_label.Location = New System.Drawing.Point(40, 495)
        Me.zz_label.Name = "zz_label"
        Me.zz_label.Size = New System.Drawing.Size(155, 20)
        Me.zz_label.TabIndex = 52
        Me.zz_label.Text = "Zákonný zástupca"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(933, 800)
        Me.ShapeContainer1.TabIndex = 53
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 34
        Me.LineShape2.X2 = 695
        Me.LineShape2.Y1 = 523
        Me.LineShape2.Y2 = 523
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 34
        Me.LineShape1.X2 = 695
        Me.LineShape1.Y1 = 243
        Me.LineShape1.Y2 = 243
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "student"
        Me.StudentBindingSource1.DataSource = Me.StudentDataSet
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.studentTableAdapter = Me.StudentTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = internat.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Zaciatok_ubytovaniaDateTimePicker
        '
        Me.Zaciatok_ubytovaniaDateTimePicker.Checked = False
        Me.Zaciatok_ubytovaniaDateTimePicker.Location = New System.Drawing.Point(295, 688)
        Me.Zaciatok_ubytovaniaDateTimePicker.Name = "Zaciatok_ubytovaniaDateTimePicker"
        Me.Zaciatok_ubytovaniaDateTimePicker.ShowCheckBox = True
        Me.Zaciatok_ubytovaniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zaciatok_ubytovaniaDateTimePicker.TabIndex = 1
        '
        'Id_typ_izbyComboBox
        '
        Me.Id_typ_izbyComboBox.DataSource = Me.TypizbyBindingSource
        Me.Id_typ_izbyComboBox.DisplayMember = "typ_izby"
        Me.Id_typ_izbyComboBox.FormattingEnabled = True
        Me.Id_typ_izbyComboBox.Location = New System.Drawing.Point(356, 734)
        Me.Id_typ_izbyComboBox.Name = "Id_typ_izbyComboBox"
        Me.Id_typ_izbyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Id_typ_izbyComboBox.TabIndex = 6
        Me.Id_typ_izbyComboBox.ValueMember = "id"
        '
        'TypizbyBindingSource
        '
        Me.TypizbyBindingSource.DataMember = "typ_izby"
        Me.TypizbyBindingSource.DataSource = Me.Typ_izbyDataSet
        '
        'Typ_izbyDataSet
        '
        Me.Typ_izbyDataSet.DataSetName = "typ_izbyDataSet"
        Me.Typ_izbyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_typ_ubytovaniaComboBox
        '
        Me.Id_typ_ubytovaniaComboBox.DataSource = Me.TypubytovaniaBindingSource
        Me.Id_typ_ubytovaniaComboBox.DisplayMember = "typ_ubytovania"
        Me.Id_typ_ubytovaniaComboBox.FormattingEnabled = True
        Me.Id_typ_ubytovaniaComboBox.Location = New System.Drawing.Point(356, 770)
        Me.Id_typ_ubytovaniaComboBox.Name = "Id_typ_ubytovaniaComboBox"
        Me.Id_typ_ubytovaniaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Id_typ_ubytovaniaComboBox.TabIndex = 8
        Me.Id_typ_ubytovaniaComboBox.ValueMember = "id"
        '
        'TypubytovaniaBindingSource
        '
        Me.TypubytovaniaBindingSource.DataMember = "typ_ubytovania"
        Me.TypubytovaniaBindingSource.DataSource = Me.Typ_ubytovaniaDataSet
        '
        'Typ_ubytovaniaDataSet
        '
        Me.Typ_ubytovaniaDataSet.DataSetName = "typ_ubytovaniaDataSet"
        Me.Typ_ubytovaniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Typ_izbyTableAdapter
        '
        Me.Typ_izbyTableAdapter.ClearBeforeFill = True
        '
        'Typ_ubytovaniaTableAdapter
        '
        Me.Typ_ubytovaniaTableAdapter.ClearBeforeFill = True
        '
        'novy_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(933, 800)
        Me.Controls.Add(Id_typ_ubytovaniaLabel1)
        Me.Controls.Add(Me.Id_typ_ubytovaniaComboBox)
        Me.Controls.Add(Id_typ_izbyLabel1)
        Me.Controls.Add(Me.Id_typ_izbyComboBox)
        Me.Controls.Add(Zaciatok_ubytovaniaLabel)
        Me.Controls.Add(Me.Zaciatok_ubytovaniaDateTimePicker)
        Me.Controls.Add(Me.zz_label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.uloz)
        Me.Controls.Add(Me.zavriet_kartu_button)
        Me.Controls.Add(Me.skupinaComboBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaDateTimePicker)
        Me.Controls.Add(Miesto_narodeniaLabel)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(BydliskoLabel)
        Me.Controls.Add(Me.BydliskoTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Op_vydalLabel)
        Me.Controls.Add(Me.Op_vydalTextBox)
        Me.Controls.Add(Op_vydany_dnaLabel)
        Me.Controls.Add(Me.Op_vydany_dnaDateTimePicker)
        Me.Controls.Add(Skola_odkial_prichadzaLabel)
        Me.Controls.Add(Me.Skola_odkial_prichadzaTextBox)
        Me.Controls.Add(Skola_ktoru_bude_navstevovatLabel)
        Me.Controls.Add(Me.Skola_ktoru_bude_navstevovatTextBox)
        Me.Controls.Add(Studijny_odborLabel)
        Me.Controls.Add(Me.Studijny_odborTextBox)
        Me.Controls.Add(Vzdialenost_bydlisko_internatLabel)
        Me.Controls.Add(Me.Vzdialenost_bydlisko_internatTextBox)
        Me.Controls.Add(ZalubyLabel)
        Me.Controls.Add(Me.ZalubyTextBox)
        Me.Controls.Add(Zz_menoLabel)
        Me.Controls.Add(Me.Zz_menoTextBox)
        Me.Controls.Add(Zz_priezviskoLabel)
        Me.Controls.Add(Me.Zz_priezviskoTextBox)
        Me.Controls.Add(Zz_datum_narodeniaLabel)
        Me.Controls.Add(Me.Zz_datum_narodeniaDateTimePicker)
        Me.Controls.Add(Zz_povolanieLabel)
        Me.Controls.Add(Me.Zz_povolanieTextBox)
        Me.Controls.Add(Zz_adresa_zamestnavatelaLabel)
        Me.Controls.Add(Me.Zz_adresa_zamestnavatelaTextBox)
        Me.Controls.Add(Zz_telefonLabel)
        Me.Controls.Add(Me.Zz_telefonTextBox)
        Me.Controls.Add(Zz_poznamkaLabel)
        Me.Controls.Add(Me.Zz_poznamkaTextBox)
        Me.Controls.Add(Id_skupinaLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "novy_student"
        Me.Text = "novy_student"
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_internatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypizbyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_izbyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypubytovaniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Typ_ubytovaniaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Op_vydalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Op_vydany_dnaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Skola_odkial_prichadzaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skola_ktoru_bude_navstevovatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Studijny_odborTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vzdialenost_bydlisko_internatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZalubyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_menoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_priezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Zz_povolanieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_adresa_zamestnavatelaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_telefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Zz_poznamkaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents skupinaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SkupinaDataSet As internat.skupinaDataSet
    Friend WithEvents SkupinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkupinaTableAdapter As internat.skupinaDataSetTableAdapters.skupinaTableAdapter
    Friend WithEvents zavriet_kartu_button As System.Windows.Forms.Button
    Friend WithEvents uloz As System.Windows.Forms.Button
    Friend WithEvents Db_internatDataSet As internat.db_internatDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As internat.db_internatDataSetTableAdapters.studentTableAdapter
    Friend WithEvents TableAdapterManager As internat.db_internatDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents zz_label As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents StudentDataSet As internat.studentDataSet
    Friend WithEvents StudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter1 As internat.studentDataSetTableAdapters.studentTableAdapter
    Friend WithEvents TableAdapterManager1 As internat.studentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Zaciatok_ubytovaniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_typ_izbyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_typ_ubytovaniaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Typ_izbyDataSet As internat.typ_izbyDataSet
    Friend WithEvents TypizbyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Typ_izbyTableAdapter As internat.typ_izbyDataSetTableAdapters.typ_izbyTableAdapter
    Friend WithEvents Typ_ubytovaniaDataSet As internat.typ_ubytovaniaDataSet
    Friend WithEvents TypubytovaniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Typ_ubytovaniaTableAdapter As internat.typ_ubytovaniaDataSetTableAdapters.typ_ubytovaniaTableAdapter
End Class
