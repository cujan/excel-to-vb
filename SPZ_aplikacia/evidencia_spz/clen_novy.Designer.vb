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
        Dim BydliskoLabel As System.Windows.Forms.Label
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
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.Okres_bydliskaTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
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
        Me.Brokova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokTextBox = New System.Windows.Forms.TextBox
        Me.Gulova_zbranTextBox = New System.Windows.Forms.TextBox
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
        Cislo_plLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        PriezviskoLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Miesto_narodeniaLabel = New System.Windows.Forms.Label
        Okres_narodeniaLabel = New System.Windows.Forms.Label
        BydliskoLabel = New System.Windows.Forms.Label
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
        CType(Me.ZdruzeniaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(150, 309)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(42, 13)
        Cislo_plLabel.TabIndex = 1
        Cislo_plLabel.Text = "cislo pl:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(156, 65)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 3
        MenoLabel.Text = "meno:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(136, 91)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 5
        PriezviskoLabel.Text = "priezvisko:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(456, 66)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(89, 13)
        Datum_narodeniaLabel.TabIndex = 7
        Datum_narodeniaLabel.Text = "datum narodenia:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(484, 143)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(455, 91)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(90, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "miesto narodenia:"
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(459, 117)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(86, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "okres narodenia:"
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(144, 169)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(48, 13)
        BydliskoLabel.TabIndex = 15
        BydliskoLabel.Text = "bydlisko:"
        '
        'Okres_bydliskaLabel
        '
        Okres_bydliskaLabel.AutoSize = True
        Okres_bydliskaLabel.Location = New System.Drawing.Point(115, 195)
        Okres_bydliskaLabel.Name = "Okres_bydliskaLabel"
        Okres_bydliskaLabel.Size = New System.Drawing.Size(77, 13)
        Okres_bydliskaLabel.TabIndex = 17
        Okres_bydliskaLabel.Text = "okres bydliska:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(165, 221)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 19
        PscLabel.Text = "psc:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(503, 221)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 21
        TelefonLabel.Text = "telefon:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(146, 283)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 23
        Cislo_opLabel.Text = "cislo op:"
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(451, 283)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(94, 13)
        Datum_vydania_opLabel.TabIndex = 25
        Datum_vydania_opLabel.Text = "datum vydania op:"
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(455, 309)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(90, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "datum vydania pl:"
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(147, 335)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(45, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "cislo zp:"
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(452, 335)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(93, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "datum vydania zp:"
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(43, 412)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(149, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "cislo clenskeho preukazu spz:"
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(126, 438)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(64, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "clen spz od:"
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(130, 464)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(62, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "clenske do:"
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(433, 412)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(112, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "cislo dokladu clenske:"
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(148, 385)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(44, 13)
        Clen_pzLabel.TabIndex = 41
        Clen_pzLabel.Text = "clen pz:"
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(80, 517)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(110, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 43
        Skuska_z_polovnictvaLabel.Text = "skuska z polovnictva:"
        '
        'Miesto_skusky_z_polovnictvaLabel
        '
        Miesto_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(403, 517)
        Miesto_skusky_z_polovnictvaLabel.Name = "Miesto_skusky_z_polovnictvaLabel"
        Miesto_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Miesto_skusky_z_polovnictvaLabel.TabIndex = 45
        Miesto_skusky_z_polovnictvaLabel.Text = "miesto skusky z polovnictva:"
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(19, 543)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(173, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 47
        Skuska_pre_polovnych_hospodarovLabel.Text = "skuska pre polovnych hospodarov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(340, 543)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(205, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 49
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "miesto skusky pre polovnych hospodarov:"
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(50, 569)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Vyzsia_skuska_z_polovnictvaLabel.Text = "vyzsia skuska z polovnictva:"
        '
        'Miesto_vyzsej_skusky_z_polovnictvaLabel
        '
        Miesto_vyzsej_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(372, 569)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Name = "Miesto_vyzsej_skusky_z_polovnictvaLabel"
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(174, 13)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.TabIndex = 53
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Text = "miesto vyzsej skusky z polovnictva:"
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(114, 629)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(78, 13)
        Brokova_zbranLabel.TabIndex = 55
        Brokova_zbranLabel.Text = "brokova zbran:"
        '
        'Kontrolne_strelby_brokLabel
        '
        Kontrolne_strelby_brokLabel.AutoSize = True
        Kontrolne_strelby_brokLabel.Location = New System.Drawing.Point(433, 629)
        Kontrolne_strelby_brokLabel.Name = "Kontrolne_strelby_brokLabel"
        Kontrolne_strelby_brokLabel.Size = New System.Drawing.Size(111, 13)
        Kontrolne_strelby_brokLabel.TabIndex = 57
        Kontrolne_strelby_brokLabel.Text = "kontrolne strelby brok:"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(121, 655)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(71, 13)
        Gulova_zbranLabel.TabIndex = 59
        Gulova_zbranLabel.Text = "gulova zbran:"
        '
        'Kontrolne_strelby_gulaLabel
        '
        Kontrolne_strelby_gulaLabel.AutoSize = True
        Kontrolne_strelby_gulaLabel.Location = New System.Drawing.Point(435, 655)
        Kontrolne_strelby_gulaLabel.Name = "Kontrolne_strelby_gulaLabel"
        Kontrolne_strelby_gulaLabel.Size = New System.Drawing.Size(110, 13)
        Kontrolne_strelby_gulaLabel.TabIndex = 61
        Kontrolne_strelby_gulaLabel.Text = "kontrolne strelby gula:"
        '
        'Najvyzsie_vyznamenanieLabel
        '
        Najvyzsie_vyznamenanieLabel.AutoSize = True
        Najvyzsie_vyznamenanieLabel.Location = New System.Drawing.Point(66, 681)
        Najvyzsie_vyznamenanieLabel.Name = "Najvyzsie_vyznamenanieLabel"
        Najvyzsie_vyznamenanieLabel.Size = New System.Drawing.Size(124, 13)
        Najvyzsie_vyznamenanieLabel.TabIndex = 63
        Najvyzsie_vyznamenanieLabel.Text = "najvyzsie vyznamenanie:"
        '
        'Vyznamenanie_kedyLabel
        '
        Vyznamenanie_kedyLabel.AutoSize = True
        Vyznamenanie_kedyLabel.Location = New System.Drawing.Point(435, 681)
        Vyznamenanie_kedyLabel.Name = "Vyznamenanie_kedyLabel"
        Vyznamenanie_kedyLabel.Size = New System.Drawing.Size(104, 13)
        Vyznamenanie_kedyLabel.TabIndex = 65
        Vyznamenanie_kedyLabel.Text = "vyznamenanie kedy:"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(110, 707)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(76, 13)
        Udelene_trestyLabel.TabIndex = 67
        Udelene_trestyLabel.Text = "udelene tresty:"
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(134, 733)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(58, 13)
        PoznamkyLabel.TabIndex = 69
        PoznamkyLabel.Text = "poznamky:"
        '
        'Titul_pred_idLabel
        '
        Titul_pred_idLabel.AutoSize = True
        Titul_pred_idLabel.Location = New System.Drawing.Point(126, 117)
        Titul_pred_idLabel.Name = "Titul_pred_idLabel"
        Titul_pred_idLabel.Size = New System.Drawing.Size(61, 13)
        Titul_pred_idLabel.TabIndex = 71
        Titul_pred_idLabel.Text = "titul pred id:"
        '
        'Titul_za_idLabel
        '
        Titul_za_idLabel.AutoSize = True
        Titul_za_idLabel.Location = New System.Drawing.Point(139, 143)
        Titul_za_idLabel.Name = "Titul_za_idLabel"
        Titul_za_idLabel.Size = New System.Drawing.Size(51, 13)
        Titul_za_idLabel.TabIndex = 73
        Titul_za_idLabel.Text = "titul za id:"
        '
        'Narodnost_idLabel
        '
        Narodnost_idLabel.AutoSize = True
        Narodnost_idLabel.Location = New System.Drawing.Point(477, 172)
        Narodnost_idLabel.Name = "Narodnost_idLabel"
        Narodnost_idLabel.Size = New System.Drawing.Size(68, 13)
        Narodnost_idLabel.TabIndex = 75
        Narodnost_idLabel.Text = "narodnost id:"
        '
        'Statna_prislusnost_idLabel
        '
        Statna_prislusnost_idLabel.AutoSize = True
        Statna_prislusnost_idLabel.Location = New System.Drawing.Point(443, 198)
        Statna_prislusnost_idLabel.Name = "Statna_prislusnost_idLabel"
        Statna_prislusnost_idLabel.Size = New System.Drawing.Size(102, 13)
        Statna_prislusnost_idLabel.TabIndex = 77
        Statna_prislusnost_idLabel.Text = "statna prislusnost id:"
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(198, 306)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_plTextBox.TabIndex = 2
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(198, 62)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.MenoTextBox.TabIndex = 4
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(199, 88)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PriezviskoTextBox.TabIndex = 6
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Checked = False
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(551, 62)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.ShowCheckBox = True
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 8
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(551, 140)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Rodne_cisloTextBox.TabIndex = 10
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(551, 88)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(551, 114)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.Location = New System.Drawing.Point(198, 166)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(140, 20)
        Me.BydliskoTextBox.TabIndex = 16
        '
        'Okres_bydliskaTextBox
        '
        Me.Okres_bydliskaTextBox.Location = New System.Drawing.Point(198, 192)
        Me.Okres_bydliskaTextBox.Name = "Okres_bydliskaTextBox"
        Me.Okres_bydliskaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Okres_bydliskaTextBox.TabIndex = 18
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(198, 218)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(140, 20)
        Me.PscTextBox.TabIndex = 20
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(551, 218)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(140, 20)
        Me.TelefonTextBox.TabIndex = 22
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(198, 280)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_opTextBox.TabIndex = 24
        '
        'Datum_vydania_opDateTimePicker
        '
        Me.Datum_vydania_opDateTimePicker.Checked = False
        Me.Datum_vydania_opDateTimePicker.Location = New System.Drawing.Point(551, 279)
        Me.Datum_vydania_opDateTimePicker.Name = "Datum_vydania_opDateTimePicker"
        Me.Datum_vydania_opDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_opDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_opDateTimePicker.TabIndex = 26
        '
        'Datum_vydania_plDateTimePicker
        '
        Me.Datum_vydania_plDateTimePicker.Checked = False
        Me.Datum_vydania_plDateTimePicker.Location = New System.Drawing.Point(551, 305)
        Me.Datum_vydania_plDateTimePicker.Name = "Datum_vydania_plDateTimePicker"
        Me.Datum_vydania_plDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_plDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_plDateTimePicker.TabIndex = 28
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(198, 332)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Datum_vydania_zpDateTimePicker
        '
        Me.Datum_vydania_zpDateTimePicker.Checked = False
        Me.Datum_vydania_zpDateTimePicker.Location = New System.Drawing.Point(551, 331)
        Me.Datum_vydania_zpDateTimePicker.Name = "Datum_vydania_zpDateTimePicker"
        Me.Datum_vydania_zpDateTimePicker.ShowCheckBox = True
        Me.Datum_vydania_zpDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Datum_vydania_zpDateTimePicker.TabIndex = 32
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(198, 409)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Clen_spz_odTextBox
        '
        Me.Clen_spz_odTextBox.Location = New System.Drawing.Point(198, 435)
        Me.Clen_spz_odTextBox.Name = "Clen_spz_odTextBox"
        Me.Clen_spz_odTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Clen_spz_odTextBox.TabIndex = 36
        '
        'Clenske_doTextBox
        '
        Me.Clenske_doTextBox.Location = New System.Drawing.Point(198, 461)
        Me.Clenske_doTextBox.Name = "Clenske_doTextBox"
        Me.Clenske_doTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Clenske_doTextBox.TabIndex = 38
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(551, 409)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Skuska_z_polovnictvaDateTimePicker
        '
        Me.Skuska_z_polovnictvaDateTimePicker.Checked = False
        Me.Skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(198, 513)
        Me.Skuska_z_polovnictvaDateTimePicker.Name = "Skuska_z_polovnictvaDateTimePicker"
        Me.Skuska_z_polovnictvaDateTimePicker.ShowCheckBox = True
        Me.Skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Skuska_z_polovnictvaDateTimePicker.TabIndex = 44
        '
        'Miesto_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(551, 514)
        Me.Miesto_skusky_z_polovnictvaTextBox.Name = "Miesto_skusky_z_polovnictvaTextBox"
        Me.Miesto_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_skusky_z_polovnictvaTextBox.TabIndex = 46
        '
        'Skuska_pre_polovnych_hospodarovDateTimePicker
        '
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Checked = False
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Location = New System.Drawing.Point(198, 539)
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Name = "Skuska_pre_polovnych_hospodarovDateTimePicker"
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.ShowCheckBox = True
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Skuska_pre_polovnych_hospodarovDateTimePicker.TabIndex = 48
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(551, 540)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Vyzsia_skuska_z_polovnictvaDateTimePicker
        '
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Checked = False
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Location = New System.Drawing.Point(198, 565)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Name = "Vyzsia_skuska_z_polovnictvaDateTimePicker"
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.ShowCheckBox = True
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Vyzsia_skuska_z_polovnictvaDateTimePicker.TabIndex = 52
        '
        'Miesto_vyzsej_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(551, 566)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Name = "Miesto_vyzsej_skusky_z_polovnictvaTextBox"
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.TabIndex = 54
        '
        'Brokova_zbranTextBox
        '
        Me.Brokova_zbranTextBox.Location = New System.Drawing.Point(198, 626)
        Me.Brokova_zbranTextBox.Name = "Brokova_zbranTextBox"
        Me.Brokova_zbranTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Brokova_zbranTextBox.TabIndex = 56
        '
        'Kontrolne_strelby_brokTextBox
        '
        Me.Kontrolne_strelby_brokTextBox.Location = New System.Drawing.Point(551, 626)
        Me.Kontrolne_strelby_brokTextBox.Name = "Kontrolne_strelby_brokTextBox"
        Me.Kontrolne_strelby_brokTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Kontrolne_strelby_brokTextBox.TabIndex = 58
        '
        'Gulova_zbranTextBox
        '
        Me.Gulova_zbranTextBox.Location = New System.Drawing.Point(198, 652)
        Me.Gulova_zbranTextBox.Name = "Gulova_zbranTextBox"
        Me.Gulova_zbranTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Gulova_zbranTextBox.TabIndex = 60
        '
        'Kontrolne_strelby_gulaTextBox
        '
        Me.Kontrolne_strelby_gulaTextBox.Location = New System.Drawing.Point(551, 652)
        Me.Kontrolne_strelby_gulaTextBox.Name = "Kontrolne_strelby_gulaTextBox"
        Me.Kontrolne_strelby_gulaTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Kontrolne_strelby_gulaTextBox.TabIndex = 62
        '
        'Najvyzsie_vyznamenanieTextBox
        '
        Me.Najvyzsie_vyznamenanieTextBox.Location = New System.Drawing.Point(198, 678)
        Me.Najvyzsie_vyznamenanieTextBox.Name = "Najvyzsie_vyznamenanieTextBox"
        Me.Najvyzsie_vyznamenanieTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Najvyzsie_vyznamenanieTextBox.TabIndex = 64
        '
        'Vyznamenanie_kedyDateTimePicker
        '
        Me.Vyznamenanie_kedyDateTimePicker.Checked = False
        Me.Vyznamenanie_kedyDateTimePicker.Location = New System.Drawing.Point(551, 677)
        Me.Vyznamenanie_kedyDateTimePicker.Name = "Vyznamenanie_kedyDateTimePicker"
        Me.Vyznamenanie_kedyDateTimePicker.ShowCheckBox = True
        Me.Vyznamenanie_kedyDateTimePicker.Size = New System.Drawing.Size(140, 20)
        Me.Vyznamenanie_kedyDateTimePicker.TabIndex = 66
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(198, 704)
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(140, 20)
        Me.Udelene_trestyTextBox.TabIndex = 68
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(198, 730)
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
        Me.Clen_pzComboBox.Location = New System.Drawing.Point(198, 382)
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
        Me.Button1.Location = New System.Drawing.Point(573, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "zobraz ico"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'uloz_clena_button
        '
        Me.uloz_clena_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.uloz_clena_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uloz_clena_button.Location = New System.Drawing.Point(309, 12)
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
        Me.zavriet_kartu_button.Location = New System.Drawing.Point(390, 12)
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
        Me.LineShape1.Y1 = 273
        Me.LineShape1.Y2 = 273
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(955, 808)
        Me.ShapeContainer1.TabIndex = 86
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 66
        Me.LineShape2.X2 = 750
        Me.LineShape2.Y1 = 620
        Me.LineShape2.Y2 = 620
        '
        'titul_predComboBox
        '
        Me.titul_predComboBox.DataSource = Me.TitulpredBindingSource
        Me.titul_predComboBox.DisplayMember = "skratka"
        Me.titul_predComboBox.FormattingEnabled = True
        Me.titul_predComboBox.Location = New System.Drawing.Point(199, 113)
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
        Me.titul_zaComboBox.Location = New System.Drawing.Point(199, 139)
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
        Me.narodnostComboBox.Location = New System.Drawing.Point(551, 166)
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
        Me.statna_prislusnostComboBox.Location = New System.Drawing.Point(551, 193)
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
        Me.label_predseda.Location = New System.Drawing.Point(426, 438)
        Me.label_predseda.Name = "label_predseda"
        Me.label_predseda.Size = New System.Drawing.Size(119, 13)
        Me.label_predseda.TabIndex = 91
        Me.label_predseda.Text = "Je predseda združenia?"
        Me.label_predseda.Visible = False
        '
        'label_hospodar
        '
        Me.label_hospodar.AutoSize = True
        Me.label_hospodar.Location = New System.Drawing.Point(426, 464)
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
        Me.ComboBox_predseda.Location = New System.Drawing.Point(551, 435)
        Me.ComboBox_predseda.Name = "ComboBox_predseda"
        Me.ComboBox_predseda.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_predseda.TabIndex = 93
        Me.ComboBox_predseda.Visible = False
        '
        'ComboBox_hospodar
        '
        Me.ComboBox_hospodar.FormattingEnabled = True
        Me.ComboBox_hospodar.Items.AddRange(New Object() {"Áno", "Nie"})
        Me.ComboBox_hospodar.Location = New System.Drawing.Point(551, 461)
        Me.ComboBox_hospodar.Name = "ComboBox_hospodar"
        Me.ComboBox_hospodar.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox_hospodar.TabIndex = 94
        Me.ComboBox_hospodar.Visible = False
        '
        'clen_novy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(972, 800)
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
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Miesto_narodeniaLabel)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Okres_narodeniaLabel)
        Me.Controls.Add(Me.Okres_narodeniaTextBox)
        Me.Controls.Add(BydliskoLabel)
        Me.Controls.Add(Me.BydliskoTextBox)
        Me.Controls.Add(Okres_bydliskaLabel)
        Me.Controls.Add(Me.Okres_bydliskaTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
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
        Me.Controls.Add(Me.Brokova_zbranTextBox)
        Me.Controls.Add(Kontrolne_strelby_brokLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_brokTextBox)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Me.Gulova_zbranTextBox)
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
        Me.Text = "clen_novy"
        CType(Me.ZdruzeniaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulpredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_bydliskaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Brokova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gulova_zbranTextBox As System.Windows.Forms.TextBox
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
End Class
