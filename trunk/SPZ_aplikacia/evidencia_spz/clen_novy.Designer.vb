﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clen_novy
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
        Dim Cislo_plLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim Miesto_narodeniaLabel As System.Windows.Forms.Label
        Dim Okres_narodeniaLabel As System.Windows.Forms.Label
        Dim Okres_bydliskaLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim Datum_vydania_opLabel As System.Windows.Forms.Label
        Dim Datum_vydania_plLabel As System.Windows.Forms.Label
        Dim Cislo_zpLabel As System.Windows.Forms.Label
        Dim Datum_vydania_zpLabel As System.Windows.Forms.Label
        Dim Cislo_clenskeho_preukazu_spzLabel As System.Windows.Forms.Label
        Dim Clen_spz_odLabel As System.Windows.Forms.Label
        Dim Clenske_doLabel As System.Windows.Forms.Label
        Dim Cislo_dokladu_clenskeLabel As System.Windows.Forms.Label
        Dim Clen_pzLabel As System.Windows.Forms.Label
        Dim Skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Miesto_skusky_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Skuska_pre_polovnych_hospodarovLabel As System.Windows.Forms.Label
        Dim Miesto_skusky_pre_polovnych_hospodarovLabel As System.Windows.Forms.Label
        Dim Vyzsia_skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Miesto_vyzsej_skusky_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Brokova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_brokLabel As System.Windows.Forms.Label
        Dim Gulova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_gulaLabel As System.Windows.Forms.Label
        Dim Najvyzsie_vyznamenanieLabel As System.Windows.Forms.Label
        Dim Vyznamenanie_kedyLabel As System.Windows.Forms.Label
        Dim Udelene_trestyLabel As System.Windows.Forms.Label
        Dim PoznamkyLabel As System.Windows.Forms.Label
        Dim Titul_pred_idLabel As System.Windows.Forms.Label
        Dim Titul_za_idLabel As System.Windows.Forms.Label
        Dim Narodnost_idLabel As System.Windows.Forms.Label
        Dim Statna_prislusnost_idLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim Ulica_cisloLabel As System.Windows.Forms.Label
        Dim PscLabel1 As System.Windows.Forms.Label
        Dim Okres_bydliskaLabel1 As System.Windows.Forms.Label
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_opDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Datum_vydania_plDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_zpTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_zpDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_clenskeho_preukazu_spzTextBox = New System.Windows.Forms.TextBox
        Me.Clen_spz_odTextBox = New System.Windows.Forms.TextBox
        Me.Clenske_doTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_dokladu_clenskeTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_gulaTextBox = New System.Windows.Forms.TextBox
        Me.Najvyzsie_vyznamenanieTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_kedyDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.Clen_pzComboBox = New System.Windows.Forms.ComboBox
        Me.ZdruzeniaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpzDataSet = New evidencia_spz.spzDataSet
        Me.ZdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzeniaTableAdapter = New evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.uloz_clena_button = New System.Windows.Forms.Button
        Me.zavriet_kartu_button = New System.Windows.Forms.Button
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Okres_bydliskaComboBox = New System.Windows.Forms.ComboBox
        Me.PscComboBox = New System.Windows.Forms.ComboBox
        Me.titul_predComboBox = New System.Windows.Forms.ComboBox
        Me.TitulpredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.titul_zaComboBox = New System.Windows.Forms.ComboBox
        Me.TitulzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titul_predTableAdapter = New evidencia_spz.spzDataSetTableAdapters.titul_predTableAdapter
        Me.Titul_zaTableAdapter = New evidencia_spz.spzDataSetTableAdapters.titul_zaTableAdapter
        Me.narodnostComboBox = New System.Windows.Forms.ComboBox
        Me.NarodnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarodnostTableAdapter = New evidencia_spz.spzDataSetTableAdapters.narodnostTableAdapter
        Me.statna_prislusnostComboBox = New System.Windows.Forms.ComboBox
        Me.StatnaprislusnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statna_prislusnostTableAdapter = New evidencia_spz.spzDataSetTableAdapters.statna_prislusnostTableAdapter
        Me.label_predseda = New System.Windows.Forms.Label
        Me.label_hospodar = New System.Windows.Forms.Label
        Me.ComboBox_predseda = New System.Windows.Forms.ComboBox
        Me.ComboBox_hospodar = New System.Windows.Forms.ComboBox
        Me.All_clenoviaDataSet = New evidencia_spz.all_clenoviaDataSet
        Me.All_clenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_clenoviaTableAdapter = New evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager
        Me.MestoComboBox = New System.Windows.Forms.ComboBox
        Me.CiselnikobceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObceDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObceDataSet = New evidencia_spz.obceDataSet
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.Ulica_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Ciselnik_obceTableAdapter = New evidencia_spz.obceDataSetTableAdapters.ciselnik_obceTableAdapter
        Me.Okres_bydliskaListBox = New System.Windows.Forms.ListBox
        Me.PscListBox = New System.Windows.Forms.ListBox
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Brokova_zbranComboBox = New System.Windows.Forms.ComboBox
        Me.Gulova_zbranComboBox = New System.Windows.Forms.ComboBox
        Me.rodne_cisloMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Cislo_plLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        PriezviskoLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Miesto_narodeniaLabel = New System.Windows.Forms.Label
        Okres_narodeniaLabel = New System.Windows.Forms.Label
        Okres_bydliskaLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        Datum_vydania_opLabel = New System.Windows.Forms.Label
        Datum_vydania_plLabel = New System.Windows.Forms.Label
        Cislo_zpLabel = New System.Windows.Forms.Label
        Datum_vydania_zpLabel = New System.Windows.Forms.Label
        Cislo_clenskeho_preukazu_spzLabel = New System.Windows.Forms.Label
        Clen_spz_odLabel = New System.Windows.Forms.Label
        Clenske_doLabel = New System.Windows.Forms.Label
        Cislo_dokladu_clenskeLabel = New System.Windows.Forms.Label
        Clen_pzLabel = New System.Windows.Forms.Label
        Skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Miesto_skusky_z_polovnictvaLabel = New System.Windows.Forms.Label
        Skuska_pre_polovnych_hospodarovLabel = New System.Windows.Forms.Label
        Miesto_skusky_pre_polovnych_hospodarovLabel = New System.Windows.Forms.Label
        Vyzsia_skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Miesto_vyzsej_skusky_z_polovnictvaLabel = New System.Windows.Forms.Label
        Brokova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_brokLabel = New System.Windows.Forms.Label
        Gulova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_gulaLabel = New System.Windows.Forms.Label
        Najvyzsie_vyznamenanieLabel = New System.Windows.Forms.Label
        Vyznamenanie_kedyLabel = New System.Windows.Forms.Label
        Udelene_trestyLabel = New System.Windows.Forms.Label
        PoznamkyLabel = New System.Windows.Forms.Label
        Titul_pred_idLabel = New System.Windows.Forms.Label
        Titul_za_idLabel = New System.Windows.Forms.Label
        Narodnost_idLabel = New System.Windows.Forms.Label
        Statna_prislusnost_idLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        Ulica_cisloLabel = New System.Windows.Forms.Label
        PscLabel1 = New System.Windows.Forms.Label
        Okres_bydliskaLabel1 = New System.Windows.Forms.Label
        CType(Me.ZdruzeniaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiselnikobceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObceDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(144, 325)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(50, 13)
        Cislo_plLabel.TabIndex = 1
        Cislo_plLabel.Text = "Číslo PL:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(155, 57)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(37, 13)
        MenoLabel.TabIndex = 3
        MenoLabel.Text = "Meno:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(136, 83)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(58, 13)
        PriezviskoLabel.TabIndex = 5
        PriezviskoLabel.Text = "Priezvisko:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(467, 58)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(80, 13)
        Datum_narodeniaLabel.TabIndex = 7
        Datum_narodeniaLabel.Text = "Dát. narodenia:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(479, 135)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(68, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "Rodné číslo:"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(456, 83)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "Miesto narodenia:"
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(467, 109)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(80, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "Okr. narodenia:"
        '
        'Okres_bydliskaLabel
        '
        Okres_bydliskaLabel.AutoSize = True
        Okres_bydliskaLabel.Location = New System.Drawing.Point(11, 42)
        Okres_bydliskaLabel.Name = "Okres_bydliskaLabel"
        Okres_bydliskaLabel.Size = New System.Drawing.Size(71, 13)
        Okres_bydliskaLabel.TabIndex = 17
        Okres_bydliskaLabel.Text = "Okr. bydliska:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(199, 46)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(31, 13)
        PscLabel.TabIndex = 19
        PscLabel.Text = "PSČ:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(519, 213)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(28, 13)
        TelefonLabel.TabIndex = 21
        TelefonLabel.Text = "Tel.:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(140, 299)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(52, 13)
        Cislo_opLabel.TabIndex = 23
        Cislo_opLabel.Text = "Číslo OP:"
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(448, 299)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(99, 13)
        Datum_vydania_opLabel.TabIndex = 25
        Datum_vydania_opLabel.Text = "Dátum vydania OP:"
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(450, 325)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(97, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "Dátum vydania PL:"
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(142, 351)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(51, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "Číslo ZP:"
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(449, 351)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(98, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "Dátum vydania ZP:"
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(74, 423)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(119, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "Číslo čl. preukazu SPZ:"
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(123, 449)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(70, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "Člen SPZ od:"
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(129, 475)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(63, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "Členske do:"
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(447, 423)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(100, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "Číslo dokl. členské:"
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(146, 396)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(48, 13)
        Clen_pzLabel.TabIndex = 41
        Clen_pzLabel.Text = "Člen PZ:"
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(78, 523)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(116, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 43
        Skuska_z_polovnictvaLabel.Text = "Skúška z poľovníctva:"
        '
        'Miesto_skusky_z_polovnictvaLabel
        '
        Miesto_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(400, 523)
        Miesto_skusky_z_polovnictvaLabel.Name = "Miesto_skusky_z_polovnictvaLabel"
        Miesto_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(147, 13)
        Miesto_skusky_z_polovnictvaLabel.TabIndex = 45
        Miesto_skusky_z_polovnictvaLabel.Text = "Miesto skúšky z poľovníctva:"
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(50, 549)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(142, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 47
        Skuska_pre_polovnych_hospodarovLabel.Text = "Skúška pre poľ hospodárov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(374, 549)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(173, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 49
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "Miesto skúšky pre poľ. hospodáov:"
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(47, 575)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(147, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Vyzsia_skuska_z_polovnictvaLabel.Text = "Vyššia skúška z poľovníctva:"
        '
        'Miesto_vyzsej_skusky_z_polovnictvaLabel
        '
        Miesto_vyzsej_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(368, 575)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Name = "Miesto_vyzsej_skusky_z_polovnictvaLabel"
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(179, 13)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.TabIndex = 53
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Text = "Miesto vyššej skúšky z poľovníctva:"
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(114, 621)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(79, 13)
        Brokova_zbranLabel.TabIndex = 55
        Brokova_zbranLabel.Text = "Broková zbraň:"
        '
        'Kontrolne_strelby_brokLabel
        '
        Kontrolne_strelby_brokLabel.AutoSize = True
        Kontrolne_strelby_brokLabel.Location = New System.Drawing.Point(453, 621)
        Kontrolne_strelby_brokLabel.Name = "Kontrolne_strelby_brokLabel"
        Kontrolne_strelby_brokLabel.Size = New System.Drawing.Size(94, 13)
        Kontrolne_strelby_brokLabel.TabIndex = 57
        Kontrolne_strelby_brokLabel.Text = "Kont. streľby brok:"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(118, 647)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(75, 13)
        Gulova_zbranLabel.TabIndex = 59
        Gulova_zbranLabel.Text = "Guľová zbraň:"
        '
        'Kontrolne_strelby_gulaLabel
        '
        Kontrolne_strelby_gulaLabel.AutoSize = True
        Kontrolne_strelby_gulaLabel.Location = New System.Drawing.Point(452, 647)
        Kontrolne_strelby_gulaLabel.Name = "Kontrolne_strelby_gulaLabel"
        Kontrolne_strelby_gulaLabel.Size = New System.Drawing.Size(95, 13)
        Kontrolne_strelby_gulaLabel.TabIndex = 61
        Kontrolne_strelby_gulaLabel.Text = "Kont. streľby guľa:"
        '
        'Najvyzsie_vyznamenanieLabel
        '
        Najvyzsie_vyznamenanieLabel.AutoSize = True
        Najvyzsie_vyznamenanieLabel.Location = New System.Drawing.Point(67, 673)
        Najvyzsie_vyznamenanieLabel.Name = "Najvyzsie_vyznamenanieLabel"
        Najvyzsie_vyznamenanieLabel.Size = New System.Drawing.Size(126, 13)
        Najvyzsie_vyznamenanieLabel.TabIndex = 63
        Najvyzsie_vyznamenanieLabel.Text = "Najvyššie vyznamenanie:"
        '
        'Vyznamenanie_kedyLabel
        '
        Vyznamenanie_kedyLabel.AutoSize = True
        Vyznamenanie_kedyLabel.Location = New System.Drawing.Point(442, 676)
        Vyznamenanie_kedyLabel.Name = "Vyznamenanie_kedyLabel"
        Vyznamenanie_kedyLabel.Size = New System.Drawing.Size(105, 13)
        Vyznamenanie_kedyLabel.TabIndex = 65
        Vyznamenanie_kedyLabel.Text = "Vyznamenanie kedy:"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(114, 699)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(78, 13)
        Udelene_trestyLabel.TabIndex = 67
        Udelene_trestyLabel.Text = "Udelené tresty:"
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(133, 725)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(59, 13)
        PoznamkyLabel.TabIndex = 69
        PoznamkyLabel.Text = "Poznámky:"
        '
        'Titul_pred_idLabel
        '
        Titul_pred_idLabel.AutoSize = True
        Titul_pred_idLabel.Location = New System.Drawing.Point(140, 109)
        Titul_pred_idLabel.Name = "Titul_pred_idLabel"
        Titul_pred_idLabel.Size = New System.Drawing.Size(54, 13)
        Titul_pred_idLabel.TabIndex = 71
        Titul_pred_idLabel.Text = "Titul pred:"
        '
        'Titul_za_idLabel
        '
        Titul_za_idLabel.AutoSize = True
        Titul_za_idLabel.Location = New System.Drawing.Point(149, 134)
        Titul_za_idLabel.Name = "Titul_za_idLabel"
        Titul_za_idLabel.Size = New System.Drawing.Size(44, 13)
        Titul_za_idLabel.TabIndex = 73
        Titul_za_idLabel.Text = "Titul za:"
        '
        'Narodnost_idLabel
        '
        Narodnost_idLabel.AutoSize = True
        Narodnost_idLabel.Location = New System.Drawing.Point(487, 161)
        Narodnost_idLabel.Name = "Narodnost_idLabel"
        Narodnost_idLabel.Size = New System.Drawing.Size(60, 13)
        Narodnost_idLabel.TabIndex = 75
        Narodnost_idLabel.Text = "Národnosť:"
        '
        'Statna_prislusnost_idLabel
        '
        Statna_prislusnost_idLabel.AutoSize = True
        Statna_prislusnost_idLabel.Location = New System.Drawing.Point(469, 188)
        Statna_prislusnost_idLabel.Name = "Statna_prislusnost_idLabel"
        Statna_prislusnost_idLabel.Size = New System.Drawing.Size(78, 13)
        Statna_prislusnost_idLabel.TabIndex = 77
        Statna_prislusnost_idLabel.Text = "Št. príslušnosť:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(154, 161)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(39, 13)
        MestoLabel.TabIndex = 0
        MestoLabel.Text = "Mesto:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(48, 20)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(34, 13)
        UlicaLabel.TabIndex = 0
        UlicaLabel.Text = "Ulica:"
        '
        'Ulica_cisloLabel
        '
        Ulica_cisloLabel.AutoSize = True
        Ulica_cisloLabel.Location = New System.Drawing.Point(181, 19)
        Ulica_cisloLabel.Name = "Ulica_cisloLabel"
        Ulica_cisloLabel.Size = New System.Drawing.Size(49, 13)
        Ulica_cisloLabel.TabIndex = 0
        Ulica_cisloLabel.Text = "Ul. číslo:"
        AddHandler Ulica_cisloLabel.Click, AddressOf Me.Ulica_cisloLabel_Click
        '
        'PscLabel1
        '
        PscLabel1.AutoSize = True
        PscLabel1.Location = New System.Drawing.Point(744, 157)
        PscLabel1.Name = "PscLabel1"
        PscLabel1.Size = New System.Drawing.Size(27, 13)
        PscLabel1.TabIndex = 0
        PscLabel1.Text = "psc:"
        '
        'Okres_bydliskaLabel1
        '
        Okres_bydliskaLabel1.AutoSize = True
        Okres_bydliskaLabel1.Location = New System.Drawing.Point(749, 209)
        Okres_bydliskaLabel1.Name = "Okres_bydliskaLabel1"
        Okres_bydliskaLabel1.Size = New System.Drawing.Size(77, 13)
        Okres_bydliskaLabel1.TabIndex = 2
        Okres_bydliskaLabel1.Text = "okres bydliska:"
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(198, 322)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_plTextBox.TabIndex = 2
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(198, 54)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.MenoTextBox.TabIndex = 4
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(199, 80)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PriezviskoTextBox.TabIndex = 6
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Checked = False
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(551, 54)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.ShowCheckBox = True
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 8
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(551, 80)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(551, 106)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(551, 210)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(140, 20)
        Me.TelefonTextBox.TabIndex = 22
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(198, 296)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_opTextBox.TabIndex = 24
        '
        'Datum_vydania_opDateTimePicker
        '
        Me.Datum_vydania_opDateTimePicker.Checked = False
        Me.Datum_vydania_opDateTimePicker.Location = New System.Drawing.Point(551, 295)
        Me.Datum_vydania_opDateTimePicker.Name = "Datum_vydania_opDateTimePicker"
        Me.Datum_vydania_opDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_opDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_opDateTimePicker.TabIndex = 26
        '
        'Datum_vydania_plDateTimePicker
        '
        Me.Datum_vydania_plDateTimePicker.Checked = False
        Me.Datum_vydania_plDateTimePicker.Location = New System.Drawing.Point(551, 321)
        Me.Datum_vydania_plDateTimePicker.Name = "Datum_vydania_plDateTimePicker"
        Me.Datum_vydania_plDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_plDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_plDateTimePicker.TabIndex = 28
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(198, 348)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Datum_vydania_zpDateTimePicker
        '
        Me.Datum_vydania_zpDateTimePicker.Checked = False
        Me.Datum_vydania_zpDateTimePicker.Location = New System.Drawing.Point(551, 347)
        Me.Datum_vydania_zpDateTimePicker.Name = "Datum_vydania_zpDateTimePicker"
        Me.Datum_vydania_zpDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_zpDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_zpDateTimePicker.TabIndex = 32
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(198, 420)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Clen_spz_odTextBox
        '
        Me.Clen_spz_odTextBox.Location = New System.Drawing.Point(198, 446)
        Me.Clen_spz_odTextBox.Name = "Clen_spz_odTextBox"
        Me.Clen_spz_odTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Clen_spz_odTextBox.TabIndex = 36
        '
        'Clenske_doTextBox
        '
        Me.Clenske_doTextBox.Location = New System.Drawing.Point(198, 472)
        Me.Clenske_doTextBox.Name = "Clenske_doTextBox"
        Me.Clenske_doTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Clenske_doTextBox.TabIndex = 38
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(551, 420)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Skuska_z_polovnictvaDateTimePicker
        '
        Me.Skuska_z_polovnictvaDateTimePicker.Checked = False
        Me.Skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(198, 519)
        Me.Skuska_z_polovnictvaDateTimePicker.Name = "Skuska_z_polovnictvaDateTimePicker"
        Me.Skuska_z_polovnictvaDateTimePicker.ShowCheckBox = True
        Me.Skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Skuska_z_polovnictvaDateTimePicker.TabIndex = 44
        '
        'Miesto_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(551, 520)
        Me.Miesto_skusky_z_polovnictvaTextBox.Name = "Miesto_skusky_z_polovnictvaTextBox"
        Me.Miesto_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_skusky_z_polovnictvaTextBox.TabIndex = 46
        '
        'Skuska_pre_polovnych_hospodarovDateTimePicker
        '
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Checked = False
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Location = New System.Drawing.Point(198, 545)
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Name = "Skuska_pre_polovnych_hospodarovDateTimePicker"
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.ShowCheckBox = True
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.TabIndex = 48
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(551, 546)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Vyzsia_skuska_z_polovnictvaDateTimePicker
        '
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Checked = False
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(198, 571)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Name = "Vyzsia_skuska_z_polovnictvaDateTimePicker"
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.ShowCheckBox = True
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.TabIndex = 52
        '
        'Miesto_vyzsej_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(551, 572)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Name = "Miesto_vyzsej_skusky_z_polovnictvaTextBox"
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.TabIndex = 54
        '
        'Kontrolne_strelby_brokTextBox
        '
        Me.Kontrolne_strelby_brokTextBox.Location = New System.Drawing.Point(551, 618)
        Me.Kontrolne_strelby_brokTextBox.Name = "Kontrolne_strelby_brokTextBox"
        Me.Kontrolne_strelby_brokTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Kontrolne_strelby_brokTextBox.TabIndex = 58
        '
        'Kontrolne_strelby_gulaTextBox
        '
        Me.Kontrolne_strelby_gulaTextBox.Location = New System.Drawing.Point(551, 644)
        Me.Kontrolne_strelby_gulaTextBox.Name = "Kontrolne_strelby_gulaTextBox"
        Me.Kontrolne_strelby_gulaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Kontrolne_strelby_gulaTextBox.TabIndex = 62
        '
        'Najvyzsie_vyznamenanieTextBox
        '
        Me.Najvyzsie_vyznamenanieTextBox.Location = New System.Drawing.Point(198, 670)
        Me.Najvyzsie_vyznamenanieTextBox.Name = "Najvyzsie_vyznamenanieTextBox"
        Me.Najvyzsie_vyznamenanieTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Najvyzsie_vyznamenanieTextBox.TabIndex = 64
        '
        'Vyznamenanie_kedyDateTimePicker
        '
        Me.Vyznamenanie_kedyDateTimePicker.Checked = False
        Me.Vyznamenanie_kedyDateTimePicker.Location = New System.Drawing.Point(551, 669)
        Me.Vyznamenanie_kedyDateTimePicker.Name = "Vyznamenanie_kedyDateTimePicker"
        Me.Vyznamenanie_kedyDateTimePicker.ShowCheckBox = True
        Me.Vyznamenanie_kedyDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Vyznamenanie_kedyDateTimePicker.TabIndex = 66
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(198, 696)
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Udelene_trestyTextBox.TabIndex = 68
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(198, 722)
        Me.PoznamkyTextBox.Multiline = True
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(493, 78)
        Me.PoznamkyTextBox.TabIndex = 70
        '
        'Clen_pzComboBox
        '
        Me.Clen_pzComboBox.DataSource = Me.ZdruzeniaBindingSource1
        Me.Clen_pzComboBox.DisplayMember = "nazov"
        Me.Clen_pzComboBox.FormattingEnabled = True
        Me.Clen_pzComboBox.Location = New System.Drawing.Point(198, 393)
        Me.Clen_pzComboBox.Name = "Clen_pzComboBox"
        Me.Clen_pzComboBox.Size = New System.Drawing.Size(140, 21)
        Me.Clen_pzComboBox.TabIndex = 82
        Me.Clen_pzComboBox.ValueMember = "ico"
        '
        'ZdruzeniaBindingSource1
        '
        Me.ZdruzeniaBindingSource1.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource1.DataSource = Me.SpzDataSet
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzeniaBindingSource
        '
        Me.ZdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource.DataSource = Me.SpzDataSet
        '
        'ZdruzeniaTableAdapter
        '
        Me.ZdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(573, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "zobraz ico"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'uloz_clena_button
        '
        Me.uloz_clena_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.uloz_clena_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz_clena_button.Location = New System.Drawing.Point(309, 4)
        Me.uloz_clena_button.Name = "uloz_clena_button"
        Me.uloz_clena_button.Size = New System.Drawing.Size(75, 23)
        Me.uloz_clena_button.TabIndex = 84
        Me.uloz_clena_button.Text = "Uložiť"
        Me.uloz_clena_button.UseVisualStyleBackColor = False
        '
        'zavriet_kartu_button
        '
        Me.zavriet_kartu_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu_button.Location = New System.Drawing.Point(390, 4)
        Me.zavriet_kartu_button.Name = "zavriet_kartu_button"
        Me.zavriet_kartu_button.Size = New System.Drawing.Size(90, 23)
        Me.zavriet_kartu_button.TabIndex = 85
        Me.zavriet_kartu_button.Text = "Zavrieť kartu"
        Me.zavriet_kartu_button.UseVisualStyleBackColor = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 66
        Me.LineShape1.X2 = 750
        Me.LineShape1.Y1 = 281
        Me.LineShape1.Y2 = 281
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(973, 841)
        Me.ShapeContainer1.TabIndex = 86
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 66
        Me.LineShape2.X2 = 750
        Me.LineShape2.Y1 = 611
        Me.LineShape2.Y2 = 611
        '
        'Okres_bydliskaComboBox
        '
        Me.Okres_bydliskaComboBox.FormattingEnabled = True
        Me.Okres_bydliskaComboBox.Location = New System.Drawing.Point(832, 206)
        Me.Okres_bydliskaComboBox.Name = "Okres_bydliskaComboBox"
        Me.Okres_bydliskaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Okres_bydliskaComboBox.TabIndex = 3
        '
        'PscComboBox
        '
        Me.PscComboBox.FormattingEnabled = True
        Me.PscComboBox.Location = New System.Drawing.Point(777, 154)
        Me.PscComboBox.Name = "PscComboBox"
        Me.PscComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PscComboBox.TabIndex = 1
        '
        'titul_predComboBox
        '
        Me.titul_predComboBox.DataSource = Me.TitulpredBindingSource
        Me.titul_predComboBox.DisplayMember = "skratka"
        Me.titul_predComboBox.FormattingEnabled = True
        Me.titul_predComboBox.Location = New System.Drawing.Point(199, 105)
        Me.titul_predComboBox.Name = "titul_predComboBox"
        Me.titul_predComboBox.Size = New System.Drawing.Size(121, 21)
        Me.titul_predComboBox.TabIndex = 87
        Me.titul_predComboBox.ValueMember = "id"
        '
        'TitulpredBindingSource
        '
        Me.TitulpredBindingSource.DataMember = "titul_pred"
        Me.TitulpredBindingSource.DataSource = Me.SpzDataSet
        '
        'titul_zaComboBox
        '
        Me.titul_zaComboBox.DataSource = Me.TitulzaBindingSource
        Me.titul_zaComboBox.DisplayMember = "skratka"
        Me.titul_zaComboBox.FormattingEnabled = True
        Me.titul_zaComboBox.Location = New System.Drawing.Point(199, 131)
        Me.titul_zaComboBox.Name = "titul_zaComboBox"
        Me.titul_zaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.titul_zaComboBox.TabIndex = 88
        Me.titul_zaComboBox.ValueMember = "id"
        '
        'TitulzaBindingSource
        '
        Me.TitulzaBindingSource.DataMember = "titul_za"
        Me.TitulzaBindingSource.DataSource = Me.SpzDataSet
        '
        'Titul_predTableAdapter
        '
        Me.Titul_predTableAdapter.ClearBeforeFill = True
        '
        'Titul_zaTableAdapter
        '
        Me.Titul_zaTableAdapter.ClearBeforeFill = True
        '
        'narodnostComboBox
        '
        Me.narodnostComboBox.DataSource = Me.NarodnostBindingSource
        Me.narodnostComboBox.DisplayMember = "skratka"
        Me.narodnostComboBox.FormattingEnabled = True
        Me.narodnostComboBox.Location = New System.Drawing.Point(551, 158)
        Me.narodnostComboBox.Name = "narodnostComboBox"
        Me.narodnostComboBox.Size = New System.Drawing.Size(121, 21)
        Me.narodnostComboBox.TabIndex = 89
        Me.narodnostComboBox.ValueMember = "id"
        '
        'NarodnostBindingSource
        '
        Me.NarodnostBindingSource.DataMember = "narodnost"
        Me.NarodnostBindingSource.DataSource = Me.SpzDataSet
        '
        'NarodnostTableAdapter
        '
        Me.NarodnostTableAdapter.ClearBeforeFill = True
        '
        'statna_prislusnostComboBox
        '
        Me.statna_prislusnostComboBox.DataSource = Me.StatnaprislusnostBindingSource
        Me.statna_prislusnostComboBox.DisplayMember = "skratka"
        Me.statna_prislusnostComboBox.FormattingEnabled = True
        Me.statna_prislusnostComboBox.Location = New System.Drawing.Point(551, 185)
        Me.statna_prislusnostComboBox.Name = "statna_prislusnostComboBox"
        Me.statna_prislusnostComboBox.Size = New System.Drawing.Size(121, 21)
        Me.statna_prislusnostComboBox.TabIndex = 90
        Me.statna_prislusnostComboBox.ValueMember = "id"
        '
        'StatnaprislusnostBindingSource
        '
        Me.StatnaprislusnostBindingSource.DataMember = "statna_prislusnost"
        Me.StatnaprislusnostBindingSource.DataSource = Me.SpzDataSet
        '
        'Statna_prislusnostTableAdapter
        '
        Me.Statna_prislusnostTableAdapter.ClearBeforeFill = True
        '
        'label_predseda
        '
        Me.label_predseda.AutoSize = True
        Me.label_predseda.Location = New System.Drawing.Point(426, 449)
        Me.label_predseda.Name = "label_predseda"
        Me.label_predseda.Size = New System.Drawing.Size(119, 13)
        Me.label_predseda.TabIndex = 91
        Me.label_predseda.Text = "Je predseda združenia?"
        Me.label_predseda.Visible = False
        '
        'label_hospodar
        '
        Me.label_hospodar.AutoSize = True
        Me.label_hospodar.Location = New System.Drawing.Point(426, 475)
        Me.label_hospodar.Name = "label_hospodar"
        Me.label_hospodar.Size = New System.Drawing.Size(119, 13)
        Me.label_hospodar.TabIndex = 92
        Me.label_hospodar.Text = "Je hospodár združenia?"
        Me.label_hospodar.Visible = False
        '
        'ComboBox_predseda
        '
        Me.ComboBox_predseda.FormattingEnabled = True
        Me.ComboBox_predseda.Items.AddRange(New Object() {"Áno", "Nie"})
        Me.ComboBox_predseda.Location = New System.Drawing.Point(551, 446)
        Me.ComboBox_predseda.Name = "ComboBox_predseda"
        Me.ComboBox_predseda.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_predseda.TabIndex = 93
        Me.ComboBox_predseda.Visible = False
        '
        'ComboBox_hospodar
        '
        Me.ComboBox_hospodar.FormattingEnabled = True
        Me.ComboBox_hospodar.Items.AddRange(New Object() {"Áno", "Nie"})
        Me.ComboBox_hospodar.Location = New System.Drawing.Point(551, 472)
        Me.ComboBox_hospodar.Name = "ComboBox_hospodar"
        Me.ComboBox_hospodar.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_hospodar.TabIndex = 94
        Me.ComboBox_hospodar.Visible = False
        '
        'All_clenoviaDataSet
        '
        Me.All_clenoviaDataSet.DataSetName = "all_clenoviaDataSet"
        Me.All_clenoviaDataSet.EnforceConstraints = False
        Me.All_clenoviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'All_clenoviaBindingSource
        '
        Me.All_clenoviaBindingSource.DataMember = "all_clenovia"
        Me.All_clenoviaBindingSource.DataSource = Me.All_clenoviaDataSet
        '
        'All_clenoviaTableAdapter
        '
        Me.All_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.all_clenoviaTableAdapter = Me.All_clenoviaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MestoComboBox
        '
        Me.MestoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MestoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MestoComboBox.DataSource = Me.CiselnikobceBindingSource
        Me.MestoComboBox.DisplayMember = "obec"
        Me.MestoComboBox.FormattingEnabled = True
        Me.MestoComboBox.Location = New System.Drawing.Point(198, 156)
        Me.MestoComboBox.Name = "MestoComboBox"
        Me.MestoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MestoComboBox.TabIndex = 1
        Me.MestoComboBox.ValueMember = "obec"
        '
        'CiselnikobceBindingSource
        '
        Me.CiselnikobceBindingSource.DataMember = "ciselnik_obce"
        Me.CiselnikobceBindingSource.DataSource = Me.ObceDataSetBindingSource
        '
        'ObceDataSetBindingSource
        '
        Me.ObceDataSetBindingSource.DataSource = Me.ObceDataSet
        Me.ObceDataSetBindingSource.Position = 0
        '
        'ObceDataSet
        '
        Me.ObceDataSet.DataSetName = "obceDataSet"
        Me.ObceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(86, 16)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(87, 20)
        Me.UlicaTextBox.TabIndex = 1
        '
        'Ulica_cisloTextBox
        '
        Me.Ulica_cisloTextBox.Location = New System.Drawing.Point(231, 17)
        Me.Ulica_cisloTextBox.Name = "Ulica_cisloTextBox"
        Me.Ulica_cisloTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Ulica_cisloTextBox.TabIndex = 1
        '
        'Ciselnik_obceTableAdapter
        '
        Me.Ciselnik_obceTableAdapter.ClearBeforeFill = True
        '
        'Okres_bydliskaListBox
        '
        Me.Okres_bydliskaListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.All_clenoviaBindingSource, "okres_bydliska", True))
        Me.Okres_bydliskaListBox.FormattingEnabled = True
        Me.Okres_bydliskaListBox.Location = New System.Drawing.Point(86, 42)
        Me.Okres_bydliskaListBox.Name = "Okres_bydliskaListBox"
        Me.Okres_bydliskaListBox.Size = New System.Drawing.Size(87, 43)
        Me.Okres_bydliskaListBox.TabIndex = 1
        '
        'PscListBox
        '
        Me.PscListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.All_clenoviaBindingSource, "psc", True))
        Me.PscListBox.FormattingEnabled = True
        Me.PscListBox.Location = New System.Drawing.Point(231, 42)
        Me.PscListBox.Name = "PscListBox"
        Me.PscListBox.Size = New System.Drawing.Size(55, 43)
        Me.PscListBox.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Brokova_zbranComboBox
        '
        Me.Brokova_zbranComboBox.FormattingEnabled = True
        Me.Brokova_zbranComboBox.Items.AddRange(New Object() {"NIE", "ÁNO"})
        Me.Brokova_zbranComboBox.Location = New System.Drawing.Point(201, 620)
        Me.Brokova_zbranComboBox.Name = "Brokova_zbranComboBox"
        Me.Brokova_zbranComboBox.Size = New System.Drawing.Size(62, 21)
        Me.Brokova_zbranComboBox.TabIndex = 1
        '
        'Gulova_zbranComboBox
        '
        Me.Gulova_zbranComboBox.FormattingEnabled = True
        Me.Gulova_zbranComboBox.Items.AddRange(New Object() {"NIE", "ÁNO"})
        Me.Gulova_zbranComboBox.Location = New System.Drawing.Point(201, 644)
        Me.Gulova_zbranComboBox.Name = "Gulova_zbranComboBox"
        Me.Gulova_zbranComboBox.Size = New System.Drawing.Size(62, 21)
        Me.Gulova_zbranComboBox.TabIndex = 1
        '
        'rodne_cisloMaskedTextBox
        '
        Me.rodne_cisloMaskedTextBox.Culture = New System.Globalization.CultureInfo("")
        Me.rodne_cisloMaskedTextBox.Location = New System.Drawing.Point(551, 132)
        Me.rodne_cisloMaskedTextBox.Mask = "000000/0000"
        Me.rodne_cisloMaskedTextBox.Name = "rodne_cisloMaskedTextBox"
        Me.rodne_cisloMaskedTextBox.Size = New System.Drawing.Size(76, 20)
        Me.rodne_cisloMaskedTextBox.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Okres_bydliskaListBox)
        Me.GroupBox1.Controls.Add(UlicaLabel)
        Me.GroupBox1.Controls.Add(Me.PscListBox)
        Me.GroupBox1.Controls.Add(Me.UlicaTextBox)
        Me.GroupBox1.Controls.Add(PscLabel)
        Me.GroupBox1.Controls.Add(Me.Ulica_cisloTextBox)
        Me.GroupBox1.Controls.Add(Ulica_cisloLabel)
        Me.GroupBox1.Controls.Add(Okres_bydliskaLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(114, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 88)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adresa"
        '
        'clen_novy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(973, 841)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rodne_cisloMaskedTextBox)
        Me.Controls.Add(Me.Gulova_zbranComboBox)
        Me.Controls.Add(Me.Brokova_zbranComboBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoComboBox)
        Me.Controls.Add(Me.ComboBox_hospodar)
        Me.Controls.Add(Me.ComboBox_predseda)
        Me.Controls.Add(Me.label_hospodar)
        Me.Controls.Add(Me.label_predseda)
        Me.Controls.Add(Me.statna_prislusnostComboBox)
        Me.Controls.Add(Me.narodnostComboBox)
        Me.Controls.Add(Me.titul_zaComboBox)
        Me.Controls.Add(Me.titul_predComboBox)
        Me.Controls.Add(Me.zavriet_kartu_button)
        Me.Controls.Add(Me.uloz_clena_button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Clen_pzComboBox)
        Me.Controls.Add(Cislo_plLabel)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaDateTimePicker)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Miesto_narodeniaLabel)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Okres_narodeniaLabel)
        Me.Controls.Add(Me.Okres_narodeniaTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Datum_vydania_opLabel)
        Me.Controls.Add(Me.Datum_vydania_opDateTimePicker)
        Me.Controls.Add(Datum_vydania_plLabel)
        Me.Controls.Add(Me.Datum_vydania_plDateTimePicker)
        Me.Controls.Add(Cislo_zpLabel)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Datum_vydania_zpLabel)
        Me.Controls.Add(Me.Datum_vydania_zpDateTimePicker)
        Me.Controls.Add(Cislo_clenskeho_preukazu_spzLabel)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Clen_spz_odLabel)
        Me.Controls.Add(Me.Clen_spz_odTextBox)
        Me.Controls.Add(Clenske_doLabel)
        Me.Controls.Add(Me.Clenske_doTextBox)
        Me.Controls.Add(Cislo_dokladu_clenskeLabel)
        Me.Controls.Add(Me.Cislo_dokladu_clenskeTextBox)
        Me.Controls.Add(Clen_pzLabel)
        Me.Controls.Add(Skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Skuska_z_polovnictvaDateTimePicker)
        Me.Controls.Add(Miesto_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovDateTimePicker)
        Me.Controls.Add(Miesto_skusky_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaDateTimePicker)
        Me.Controls.Add(Miesto_vyzsej_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Kontrolne_strelby_brokLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_brokTextBox)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Kontrolne_strelby_gulaLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_gulaTextBox)
        Me.Controls.Add(Najvyzsie_vyznamenanieLabel)
        Me.Controls.Add(Me.Najvyzsie_vyznamenanieTextBox)
        Me.Controls.Add(Vyznamenanie_kedyLabel)
        Me.Controls.Add(Me.Vyznamenanie_kedyDateTimePicker)
        Me.Controls.Add(Udelene_trestyLabel)
        Me.Controls.Add(Me.Udelene_trestyTextBox)
        Me.Controls.Add(PoznamkyLabel)
        Me.Controls.Add(Me.PoznamkyTextBox)
        Me.Controls.Add(Titul_pred_idLabel)
        Me.Controls.Add(Titul_za_idLabel)
        Me.Controls.Add(Narodnost_idLabel)
        Me.Controls.Add(Statna_prislusnost_idLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clen_novy"
        Me.Text = "Pridaj člena"
        CType(Me.ZdruzeniaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_clenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiselnikobceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObceDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_opDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datum_vydania_plDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_zpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_clenskeho_preukazu_spzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_spz_odTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clenske_doTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_dokladu_clenskeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Miesto_vyzsej_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_gulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Najvyzsie_vyznamenanieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_kedyDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_pzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents ZdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzeniaTableAdapter As evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ZdruzeniaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents uloz_clena_button As System.Windows.Forms.Button
    Friend WithEvents zavriet_kartu_button As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents titul_predComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents titul_zaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TitulpredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_predTableAdapter As evidencia_spz.spzDataSetTableAdapters.titul_predTableAdapter
    Friend WithEvents TitulzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Titul_zaTableAdapter As evidencia_spz.spzDataSetTableAdapters.titul_zaTableAdapter
    Friend WithEvents narodnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NarodnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NarodnostTableAdapter As evidencia_spz.spzDataSetTableAdapters.narodnostTableAdapter
    Friend WithEvents statna_prislusnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatnaprislusnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostTableAdapter As evidencia_spz.spzDataSetTableAdapters.statna_prislusnostTableAdapter
    Friend WithEvents label_predseda As System.Windows.Forms.Label
    Friend WithEvents label_hospodar As System.Windows.Forms.Label
    Friend WithEvents ComboBox_predseda As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_hospodar As System.Windows.Forms.ComboBox
    Friend WithEvents All_clenoviaDataSet As evidencia_spz.all_clenoviaDataSet
    Friend WithEvents All_clenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents All_clenoviaTableAdapter As evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.all_clenoviaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MestoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ulica_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObceDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObceDataSet As evidencia_spz.obceDataSet
    Friend WithEvents CiselnikobceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ciselnik_obceTableAdapter As evidencia_spz.obceDataSetTableAdapters.ciselnik_obceTableAdapter
    Friend WithEvents Okres_bydliskaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PscComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Okres_bydliskaListBox As System.Windows.Forms.ListBox
    Friend WithEvents PscListBox As System.Windows.Forms.ListBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Gulova_zbranComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Brokova_zbranComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rodne_cisloMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
