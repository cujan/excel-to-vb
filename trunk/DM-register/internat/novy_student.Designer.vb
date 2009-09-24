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
        Me.SkupinaDataSet = New internat.skupinaDataSet
        Me.SkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkupinaTableAdapter = New internat.skupinaDataSetTableAdapters.skupinaTableAdapter
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
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(95, 60)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 3
        PriezviskoLabel.Text = "priezvisko:"
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(252, 57)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 4
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(95, 86)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "meno:"
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(252, 83)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(95, 113)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(89, 13)
        Datum_narodeniaLabel.TabIndex = 7
        Datum_narodeniaLabel.Text = "datum narodenia:"
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(252, 109)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 8
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(95, 138)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(90, 13)
        Miesto_narodeniaLabel.TabIndex = 9
        Miesto_narodeniaLabel.Text = "miesto narodenia:"
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(252, 135)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 10
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(95, 164)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 11
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(252, 161)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 12
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(95, 190)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(48, 13)
        BydliskoLabel.TabIndex = 13
        BydliskoLabel.Text = "bydlisko:"
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.Location = New System.Drawing.Point(252, 187)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BydliskoTextBox.TabIndex = 14
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(95, 216)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 15
        TelefonLabel.Text = "telefon:"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(252, 213)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 16
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(95, 242)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 17
        Cislo_opLabel.Text = "cislo op:"
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(252, 239)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 18
        '
        'Op_vydalLabel
        '
        Op_vydalLabel.AutoSize = True
        Op_vydalLabel.Location = New System.Drawing.Point(95, 268)
        Op_vydalLabel.Name = "Op_vydalLabel"
        Op_vydalLabel.Size = New System.Drawing.Size(50, 13)
        Op_vydalLabel.TabIndex = 19
        Op_vydalLabel.Text = "op vydal:"
        '
        'Op_vydalTextBox
        '
        Me.Op_vydalTextBox.Location = New System.Drawing.Point(252, 265)
        Me.Op_vydalTextBox.Name = "Op_vydalTextBox"
        Me.Op_vydalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Op_vydalTextBox.TabIndex = 20
        '
        'Op_vydany_dnaLabel
        '
        Op_vydany_dnaLabel.AutoSize = True
        Op_vydany_dnaLabel.Location = New System.Drawing.Point(95, 295)
        Op_vydany_dnaLabel.Name = "Op_vydany_dnaLabel"
        Op_vydany_dnaLabel.Size = New System.Drawing.Size(80, 13)
        Op_vydany_dnaLabel.TabIndex = 21
        Op_vydany_dnaLabel.Text = "op vydany dna:"
        '
        'Op_vydany_dnaDateTimePicker
        '
        Me.Op_vydany_dnaDateTimePicker.Location = New System.Drawing.Point(252, 291)
        Me.Op_vydany_dnaDateTimePicker.Name = "Op_vydany_dnaDateTimePicker"
        Me.Op_vydany_dnaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Op_vydany_dnaDateTimePicker.TabIndex = 22
        '
        'Skola_odkial_prichadzaLabel
        '
        Skola_odkial_prichadzaLabel.AutoSize = True
        Skola_odkial_prichadzaLabel.Location = New System.Drawing.Point(95, 320)
        Skola_odkial_prichadzaLabel.Name = "Skola_odkial_prichadzaLabel"
        Skola_odkial_prichadzaLabel.Size = New System.Drawing.Size(115, 13)
        Skola_odkial_prichadzaLabel.TabIndex = 23
        Skola_odkial_prichadzaLabel.Text = "skola odkial prichadza:"
        '
        'Skola_odkial_prichadzaTextBox
        '
        Me.Skola_odkial_prichadzaTextBox.Location = New System.Drawing.Point(252, 317)
        Me.Skola_odkial_prichadzaTextBox.Name = "Skola_odkial_prichadzaTextBox"
        Me.Skola_odkial_prichadzaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skola_odkial_prichadzaTextBox.TabIndex = 24
        '
        'Skola_ktoru_bude_navstevovatLabel
        '
        Skola_ktoru_bude_navstevovatLabel.AutoSize = True
        Skola_ktoru_bude_navstevovatLabel.Location = New System.Drawing.Point(95, 346)
        Skola_ktoru_bude_navstevovatLabel.Name = "Skola_ktoru_bude_navstevovatLabel"
        Skola_ktoru_bude_navstevovatLabel.Size = New System.Drawing.Size(151, 13)
        Skola_ktoru_bude_navstevovatLabel.TabIndex = 25
        Skola_ktoru_bude_navstevovatLabel.Text = "skola ktoru bude navstevovat:"
        '
        'Skola_ktoru_bude_navstevovatTextBox
        '
        Me.Skola_ktoru_bude_navstevovatTextBox.Location = New System.Drawing.Point(252, 343)
        Me.Skola_ktoru_bude_navstevovatTextBox.Name = "Skola_ktoru_bude_navstevovatTextBox"
        Me.Skola_ktoru_bude_navstevovatTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skola_ktoru_bude_navstevovatTextBox.TabIndex = 26
        '
        'Studijny_odborLabel
        '
        Studijny_odborLabel.AutoSize = True
        Studijny_odborLabel.Location = New System.Drawing.Point(95, 372)
        Studijny_odborLabel.Name = "Studijny_odborLabel"
        Studijny_odborLabel.Size = New System.Drawing.Size(75, 13)
        Studijny_odborLabel.TabIndex = 27
        Studijny_odborLabel.Text = "studijny odbor:"
        '
        'Studijny_odborTextBox
        '
        Me.Studijny_odborTextBox.Location = New System.Drawing.Point(252, 369)
        Me.Studijny_odborTextBox.Name = "Studijny_odborTextBox"
        Me.Studijny_odborTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Studijny_odborTextBox.TabIndex = 28
        '
        'Vzdialenost_bydlisko_internatLabel
        '
        Vzdialenost_bydlisko_internatLabel.AutoSize = True
        Vzdialenost_bydlisko_internatLabel.Location = New System.Drawing.Point(95, 398)
        Vzdialenost_bydlisko_internatLabel.Name = "Vzdialenost_bydlisko_internatLabel"
        Vzdialenost_bydlisko_internatLabel.Size = New System.Drawing.Size(142, 13)
        Vzdialenost_bydlisko_internatLabel.TabIndex = 29
        Vzdialenost_bydlisko_internatLabel.Text = "vzdialenost bydlisko internat:"
        '
        'Vzdialenost_bydlisko_internatTextBox
        '
        Me.Vzdialenost_bydlisko_internatTextBox.Location = New System.Drawing.Point(252, 395)
        Me.Vzdialenost_bydlisko_internatTextBox.Name = "Vzdialenost_bydlisko_internatTextBox"
        Me.Vzdialenost_bydlisko_internatTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vzdialenost_bydlisko_internatTextBox.TabIndex = 30
        '
        'ZalubyLabel
        '
        ZalubyLabel.AutoSize = True
        ZalubyLabel.Location = New System.Drawing.Point(95, 424)
        ZalubyLabel.Name = "ZalubyLabel"
        ZalubyLabel.Size = New System.Drawing.Size(40, 13)
        ZalubyLabel.TabIndex = 31
        ZalubyLabel.Text = "zaluby:"
        '
        'ZalubyTextBox
        '
        Me.ZalubyTextBox.Location = New System.Drawing.Point(252, 421)
        Me.ZalubyTextBox.Name = "ZalubyTextBox"
        Me.ZalubyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ZalubyTextBox.TabIndex = 32
        '
        'Zz_menoLabel
        '
        Zz_menoLabel.AutoSize = True
        Zz_menoLabel.Location = New System.Drawing.Point(95, 450)
        Zz_menoLabel.Name = "Zz_menoLabel"
        Zz_menoLabel.Size = New System.Drawing.Size(49, 13)
        Zz_menoLabel.TabIndex = 33
        Zz_menoLabel.Text = "zz meno:"
        '
        'Zz_menoTextBox
        '
        Me.Zz_menoTextBox.Location = New System.Drawing.Point(252, 447)
        Me.Zz_menoTextBox.Name = "Zz_menoTextBox"
        Me.Zz_menoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_menoTextBox.TabIndex = 34
        '
        'Zz_priezviskoLabel
        '
        Zz_priezviskoLabel.AutoSize = True
        Zz_priezviskoLabel.Location = New System.Drawing.Point(95, 476)
        Zz_priezviskoLabel.Name = "Zz_priezviskoLabel"
        Zz_priezviskoLabel.Size = New System.Drawing.Size(70, 13)
        Zz_priezviskoLabel.TabIndex = 35
        Zz_priezviskoLabel.Text = "zz priezvisko:"
        '
        'Zz_priezviskoTextBox
        '
        Me.Zz_priezviskoTextBox.Location = New System.Drawing.Point(252, 473)
        Me.Zz_priezviskoTextBox.Name = "Zz_priezviskoTextBox"
        Me.Zz_priezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_priezviskoTextBox.TabIndex = 36
        '
        'Zz_datum_narodeniaLabel
        '
        Zz_datum_narodeniaLabel.AutoSize = True
        Zz_datum_narodeniaLabel.Location = New System.Drawing.Point(95, 503)
        Zz_datum_narodeniaLabel.Name = "Zz_datum_narodeniaLabel"
        Zz_datum_narodeniaLabel.Size = New System.Drawing.Size(102, 13)
        Zz_datum_narodeniaLabel.TabIndex = 37
        Zz_datum_narodeniaLabel.Text = "zz datum narodenia:"
        '
        'Zz_datum_narodeniaDateTimePicker
        '
        Me.Zz_datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(252, 499)
        Me.Zz_datum_narodeniaDateTimePicker.Name = "Zz_datum_narodeniaDateTimePicker"
        Me.Zz_datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Zz_datum_narodeniaDateTimePicker.TabIndex = 38
        '
        'Zz_povolanieLabel
        '
        Zz_povolanieLabel.AutoSize = True
        Zz_povolanieLabel.Location = New System.Drawing.Point(95, 528)
        Zz_povolanieLabel.Name = "Zz_povolanieLabel"
        Zz_povolanieLabel.Size = New System.Drawing.Size(69, 13)
        Zz_povolanieLabel.TabIndex = 39
        Zz_povolanieLabel.Text = "zz povolanie:"
        '
        'Zz_povolanieTextBox
        '
        Me.Zz_povolanieTextBox.Location = New System.Drawing.Point(252, 525)
        Me.Zz_povolanieTextBox.Name = "Zz_povolanieTextBox"
        Me.Zz_povolanieTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_povolanieTextBox.TabIndex = 40
        '
        'Zz_adresa_zamestnavatelaLabel
        '
        Zz_adresa_zamestnavatelaLabel.AutoSize = True
        Zz_adresa_zamestnavatelaLabel.Location = New System.Drawing.Point(95, 554)
        Zz_adresa_zamestnavatelaLabel.Name = "Zz_adresa_zamestnavatelaLabel"
        Zz_adresa_zamestnavatelaLabel.Size = New System.Drawing.Size(132, 13)
        Zz_adresa_zamestnavatelaLabel.TabIndex = 41
        Zz_adresa_zamestnavatelaLabel.Text = "zz adresa zamestnavatela:"
        '
        'Zz_adresa_zamestnavatelaTextBox
        '
        Me.Zz_adresa_zamestnavatelaTextBox.Location = New System.Drawing.Point(252, 551)
        Me.Zz_adresa_zamestnavatelaTextBox.Name = "Zz_adresa_zamestnavatelaTextBox"
        Me.Zz_adresa_zamestnavatelaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_adresa_zamestnavatelaTextBox.TabIndex = 42
        '
        'Zz_telefonLabel
        '
        Zz_telefonLabel.AutoSize = True
        Zz_telefonLabel.Location = New System.Drawing.Point(95, 580)
        Zz_telefonLabel.Name = "Zz_telefonLabel"
        Zz_telefonLabel.Size = New System.Drawing.Size(55, 13)
        Zz_telefonLabel.TabIndex = 43
        Zz_telefonLabel.Text = "zz telefon:"
        '
        'Zz_telefonTextBox
        '
        Me.Zz_telefonTextBox.Location = New System.Drawing.Point(252, 577)
        Me.Zz_telefonTextBox.Name = "Zz_telefonTextBox"
        Me.Zz_telefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_telefonTextBox.TabIndex = 44
        '
        'Zz_poznamkaLabel
        '
        Zz_poznamkaLabel.AutoSize = True
        Zz_poznamkaLabel.Location = New System.Drawing.Point(95, 606)
        Zz_poznamkaLabel.Name = "Zz_poznamkaLabel"
        Zz_poznamkaLabel.Size = New System.Drawing.Size(72, 13)
        Zz_poznamkaLabel.TabIndex = 45
        Zz_poznamkaLabel.Text = "zz poznamka:"
        '
        'Zz_poznamkaTextBox
        '
        Me.Zz_poznamkaTextBox.Location = New System.Drawing.Point(252, 603)
        Me.Zz_poznamkaTextBox.Name = "Zz_poznamkaTextBox"
        Me.Zz_poznamkaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Zz_poznamkaTextBox.TabIndex = 46
        '
        'Id_skupinaLabel
        '
        Id_skupinaLabel.AutoSize = True
        Id_skupinaLabel.Location = New System.Drawing.Point(95, 632)
        Id_skupinaLabel.Name = "Id_skupinaLabel"
        Id_skupinaLabel.Size = New System.Drawing.Size(58, 13)
        Id_skupinaLabel.TabIndex = 47
        Id_skupinaLabel.Text = "id skupina:"
        '
        'skupinaComboBox
        '
        Me.skupinaComboBox.DataSource = Me.SkupinaBindingSource
        Me.skupinaComboBox.DisplayMember = "nazov_skupiny"
        Me.skupinaComboBox.FormattingEnabled = True
        Me.skupinaComboBox.Location = New System.Drawing.Point(252, 632)
        Me.skupinaComboBox.Name = "skupinaComboBox"
        Me.skupinaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.skupinaComboBox.TabIndex = 48
        Me.skupinaComboBox.ValueMember = "id"
        '
        'SkupinaDataSet
        '
        Me.SkupinaDataSet.DataSetName = "skupinaDataSet"
        Me.SkupinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkupinaBindingSource
        '
        Me.SkupinaBindingSource.DataMember = "skupina"
        Me.SkupinaBindingSource.DataSource = Me.SkupinaDataSet
        '
        'SkupinaTableAdapter
        '
        Me.SkupinaTableAdapter.ClearBeforeFill = True
        '
        'novy_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 745)
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
        Me.Name = "novy_student"
        Me.Text = "novy_student"
        CType(Me.SkupinaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
