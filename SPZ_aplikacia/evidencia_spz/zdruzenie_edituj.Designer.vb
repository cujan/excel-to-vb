﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zdruzenie_edituj
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
        Dim IcoLabel As System.Windows.Forms.Label
        Dim ICO_clenoviaLabel As System.Windows.Forms.Label
        Dim ICO_psyLabel As System.Windows.Forms.Label
        Dim ICO_trofejeLabel As System.Windows.Forms.Label
        Dim NazovLabel As System.Windows.Forms.Label
        Dim SidloLabel As System.Windows.Forms.Label
        Dim PredsedaLabel As System.Windows.Forms.Label
        Dim Predseda_telefonLabel As System.Windows.Forms.Label
        Dim Polovny_hospodarLabel As System.Windows.Forms.Label
        Dim Polovny_hospodar_telefonLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim BankaLabel As System.Windows.Forms.Label
        Dim Cislo_uctuLabel As System.Windows.Forms.Label
        Dim Chovatelska_oblastLabel As System.Windows.Forms.Label
        Dim Cislo_reviruLabel As System.Windows.Forms.Label
        Dim VymeraLabel As System.Windows.Forms.Label
        Dim LesLabel As System.Windows.Forms.Label
        Dim JeleniaLabel As System.Windows.Forms.Label
        Dim SrnciaLabel As System.Windows.Forms.Label
        Dim DiviaciaLabel As System.Windows.Forms.Label
        Dim BazantLabel As System.Windows.Forms.Label
        Dim InaLabel As System.Windows.Forms.Label
        Dim Platnost_najomnej_zmluvy_doLabel As System.Windows.Forms.Label
        Dim Stavace_planLabel As System.Windows.Forms.Label
        Dim Stavace_skutocnostLabel As System.Windows.Forms.Label
        Dim Sliedice_planLabel As System.Windows.Forms.Label
        Dim Sliedice_skutocnostLabel As System.Windows.Forms.Label
        Dim Slovensky_kopov_planLabel As System.Windows.Forms.Label
        Dim Slovensky_kopov_skutocnostLabel As System.Windows.Forms.Label
        Dim Ostatne_durice_planLabel As System.Windows.Forms.Label
        Dim Ostatne_durice_skutocnostLabel As System.Windows.Forms.Label
        Dim Brlohare_planLabel As System.Windows.Forms.Label
        Dim Brlohare_skutocnostLabel As System.Windows.Forms.Label
        Dim Farbiare_planLabel As System.Windows.Forms.Label
        Dim Farbiare_skutocnostLabel As System.Windows.Forms.Label
        Dim Pes_jelenia_planLabel As System.Windows.Forms.Label
        Dim Pes_jelenia_skutocnostLabel As System.Windows.Forms.Label
        Dim Pes_diviacia_planLabel As System.Windows.Forms.Label
        Dim Pes_diviacia_skutocnostLabel As System.Windows.Forms.Label
        Dim Pes_srncia_planLabel As System.Windows.Forms.Label
        Dim Pes_srncia_skutocnostLabel As System.Windows.Forms.Label
        Dim Pes_mala_planLabel As System.Windows.Forms.Label
        Dim Pes_mala_skutocnostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zdruzenie_edituj))
        Me.ZdruzeniaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ZdruzeniaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpzDataSet = New evidencia_spz.spzDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ZdruzeniaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.ICO_clenoviaTextBox = New System.Windows.Forms.TextBox
        Me.ICO_psyTextBox = New System.Windows.Forms.TextBox
        Me.ICO_trofejeTextBox = New System.Windows.Forms.TextBox
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.SidloTextBox = New System.Windows.Forms.TextBox
        Me.PredsedaTextBox = New System.Windows.Forms.TextBox
        Me.Predseda_telefonTextBox = New System.Windows.Forms.TextBox
        Me.Polovny_hospodarTextBox = New System.Windows.Forms.TextBox
        Me.Polovny_hospodar_telefonTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.BankaTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_uctuTextBox = New System.Windows.Forms.TextBox
        Me.Chovatelska_oblastTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_reviruTextBox = New System.Windows.Forms.TextBox
        Me.VymeraTextBox = New System.Windows.Forms.TextBox
        Me.LesTextBox = New System.Windows.Forms.TextBox
        Me.JeleniaTextBox = New System.Windows.Forms.TextBox
        Me.SrnciaTextBox = New System.Windows.Forms.TextBox
        Me.DiviaciaTextBox = New System.Windows.Forms.TextBox
        Me.BazantTextBox = New System.Windows.Forms.TextBox
        Me.InaTextBox = New System.Windows.Forms.TextBox
        Me.Platnost_najomnej_zmluvy_doTextBox = New System.Windows.Forms.TextBox
        Me.Stavace_planTextBox = New System.Windows.Forms.TextBox
        Me.Stavace_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Sliedice_planTextBox = New System.Windows.Forms.TextBox
        Me.Sliedice_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Slovensky_kopov_planTextBox = New System.Windows.Forms.TextBox
        Me.Slovensky_kopov_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Ostatne_durice_planTextBox = New System.Windows.Forms.TextBox
        Me.Ostatne_durice_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Brlohare_planTextBox = New System.Windows.Forms.TextBox
        Me.Brlohare_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Farbiare_planTextBox = New System.Windows.Forms.TextBox
        Me.Farbiare_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Pes_jelenia_planTextBox = New System.Windows.Forms.TextBox
        Me.Pes_jelenia_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Pes_diviacia_planTextBox = New System.Windows.Forms.TextBox
        Me.Pes_diviacia_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Pes_srncia_planTextBox = New System.Windows.Forms.TextBox
        Me.Pes_srncia_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Pes_mala_planTextBox = New System.Windows.Forms.TextBox
        Me.Pes_mala_skutocnostTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ZdruzeniaTableAdapter = New evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
        Me.predsedaComboBox = New System.Windows.Forms.ComboBox
        Me.AllclenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_clenoviaDataSet = New evidencia_spz.all_clenoviaDataSet
        Me.All_clenoviaTableAdapter = New evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
        Me.hospodarComboBox = New System.Windows.Forms.ComboBox
        Me.AllclenoviaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospodarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospodarDataSet = New evidencia_spz.hospodarDataSet
        Me.All_clenoviaTableAdapter1 = New evidencia_spz.hospodarDataSetTableAdapters.all_clenoviaTableAdapter
        Me.PredsedaDataSet = New evidencia_spz.predsedaDataSet
        Me.AllclenoviaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.All_clenoviaTableAdapter2 = New evidencia_spz.predsedaDataSetTableAdapters.all_clenoviaTableAdapter
        IcoLabel = New System.Windows.Forms.Label
        ICO_clenoviaLabel = New System.Windows.Forms.Label
        ICO_psyLabel = New System.Windows.Forms.Label
        ICO_trofejeLabel = New System.Windows.Forms.Label
        NazovLabel = New System.Windows.Forms.Label
        SidloLabel = New System.Windows.Forms.Label
        PredsedaLabel = New System.Windows.Forms.Label
        Predseda_telefonLabel = New System.Windows.Forms.Label
        Polovny_hospodarLabel = New System.Windows.Forms.Label
        Polovny_hospodar_telefonLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        BankaLabel = New System.Windows.Forms.Label
        Cislo_uctuLabel = New System.Windows.Forms.Label
        Chovatelska_oblastLabel = New System.Windows.Forms.Label
        Cislo_reviruLabel = New System.Windows.Forms.Label
        VymeraLabel = New System.Windows.Forms.Label
        LesLabel = New System.Windows.Forms.Label
        JeleniaLabel = New System.Windows.Forms.Label
        SrnciaLabel = New System.Windows.Forms.Label
        DiviaciaLabel = New System.Windows.Forms.Label
        BazantLabel = New System.Windows.Forms.Label
        InaLabel = New System.Windows.Forms.Label
        Platnost_najomnej_zmluvy_doLabel = New System.Windows.Forms.Label
        Stavace_planLabel = New System.Windows.Forms.Label
        Stavace_skutocnostLabel = New System.Windows.Forms.Label
        Sliedice_planLabel = New System.Windows.Forms.Label
        Sliedice_skutocnostLabel = New System.Windows.Forms.Label
        Slovensky_kopov_planLabel = New System.Windows.Forms.Label
        Slovensky_kopov_skutocnostLabel = New System.Windows.Forms.Label
        Ostatne_durice_planLabel = New System.Windows.Forms.Label
        Ostatne_durice_skutocnostLabel = New System.Windows.Forms.Label
        Brlohare_planLabel = New System.Windows.Forms.Label
        Brlohare_skutocnostLabel = New System.Windows.Forms.Label
        Farbiare_planLabel = New System.Windows.Forms.Label
        Farbiare_skutocnostLabel = New System.Windows.Forms.Label
        Pes_jelenia_planLabel = New System.Windows.Forms.Label
        Pes_jelenia_skutocnostLabel = New System.Windows.Forms.Label
        Pes_diviacia_planLabel = New System.Windows.Forms.Label
        Pes_diviacia_skutocnostLabel = New System.Windows.Forms.Label
        Pes_srncia_planLabel = New System.Windows.Forms.Label
        Pes_srncia_skutocnostLabel = New System.Windows.Forms.Label
        Pes_mala_planLabel = New System.Windows.Forms.Label
        Pes_mala_skutocnostLabel = New System.Windows.Forms.Label
        CType(Me.ZdruzeniaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZdruzeniaBindingNavigator.SuspendLayout()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllclenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllclenoviaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospodarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospodarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PredsedaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllclenoviaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(65, 64)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(24, 13)
        IcoLabel.TabIndex = 1
        IcoLabel.Text = "ico:"
        '
        'ICO_clenoviaLabel
        '
        ICO_clenoviaLabel.AutoSize = True
        ICO_clenoviaLabel.Location = New System.Drawing.Point(65, 90)
        ICO_clenoviaLabel.Name = "ICO_clenoviaLabel"
        ICO_clenoviaLabel.Size = New System.Drawing.Size(71, 13)
        ICO_clenoviaLabel.TabIndex = 3
        ICO_clenoviaLabel.Text = "ICO clenovia:"
        '
        'ICO_psyLabel
        '
        ICO_psyLabel.AutoSize = True
        ICO_psyLabel.Location = New System.Drawing.Point(65, 116)
        ICO_psyLabel.Name = "ICO_psyLabel"
        ICO_psyLabel.Size = New System.Drawing.Size(47, 13)
        ICO_psyLabel.TabIndex = 5
        ICO_psyLabel.Text = "ICO psy:"
        '
        'ICO_trofejeLabel
        '
        ICO_trofejeLabel.AutoSize = True
        ICO_trofejeLabel.Location = New System.Drawing.Point(65, 142)
        ICO_trofejeLabel.Name = "ICO_trofejeLabel"
        ICO_trofejeLabel.Size = New System.Drawing.Size(60, 13)
        ICO_trofejeLabel.TabIndex = 7
        ICO_trofejeLabel.Text = "ICO trofeje:"
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(65, 168)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 9
        NazovLabel.Text = "nazov:"
        '
        'SidloLabel
        '
        SidloLabel.AutoSize = True
        SidloLabel.Location = New System.Drawing.Point(65, 194)
        SidloLabel.Name = "SidloLabel"
        SidloLabel.Size = New System.Drawing.Size(31, 13)
        SidloLabel.TabIndex = 11
        SidloLabel.Text = "sidlo:"
        '
        'PredsedaLabel
        '
        PredsedaLabel.AutoSize = True
        PredsedaLabel.Location = New System.Drawing.Point(65, 220)
        PredsedaLabel.Name = "PredsedaLabel"
        PredsedaLabel.Size = New System.Drawing.Size(54, 13)
        PredsedaLabel.TabIndex = 13
        PredsedaLabel.Text = "predseda:"
        '
        'Predseda_telefonLabel
        '
        Predseda_telefonLabel.AutoSize = True
        Predseda_telefonLabel.Location = New System.Drawing.Point(65, 246)
        Predseda_telefonLabel.Name = "Predseda_telefonLabel"
        Predseda_telefonLabel.Size = New System.Drawing.Size(89, 13)
        Predseda_telefonLabel.TabIndex = 15
        Predseda_telefonLabel.Text = "predseda telefon:"
        '
        'Polovny_hospodarLabel
        '
        Polovny_hospodarLabel.AutoSize = True
        Polovny_hospodarLabel.Location = New System.Drawing.Point(65, 272)
        Polovny_hospodarLabel.Name = "Polovny_hospodarLabel"
        Polovny_hospodarLabel.Size = New System.Drawing.Size(94, 13)
        Polovny_hospodarLabel.TabIndex = 17
        Polovny_hospodarLabel.Text = "polovny hospodar:"
        '
        'Polovny_hospodar_telefonLabel
        '
        Polovny_hospodar_telefonLabel.AutoSize = True
        Polovny_hospodar_telefonLabel.Location = New System.Drawing.Point(65, 298)
        Polovny_hospodar_telefonLabel.Name = "Polovny_hospodar_telefonLabel"
        Polovny_hospodar_telefonLabel.Size = New System.Drawing.Size(129, 13)
        Polovny_hospodar_telefonLabel.TabIndex = 19
        Polovny_hospodar_telefonLabel.Text = "polovny hospodar telefon:"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(65, 324)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(24, 13)
        DicLabel.TabIndex = 21
        DicLabel.Text = "dic:"
        '
        'BankaLabel
        '
        BankaLabel.AutoSize = True
        BankaLabel.Location = New System.Drawing.Point(65, 350)
        BankaLabel.Name = "BankaLabel"
        BankaLabel.Size = New System.Drawing.Size(40, 13)
        BankaLabel.TabIndex = 23
        BankaLabel.Text = "banka:"
        '
        'Cislo_uctuLabel
        '
        Cislo_uctuLabel.AutoSize = True
        Cislo_uctuLabel.Location = New System.Drawing.Point(65, 376)
        Cislo_uctuLabel.Name = "Cislo_uctuLabel"
        Cislo_uctuLabel.Size = New System.Drawing.Size(55, 13)
        Cislo_uctuLabel.TabIndex = 25
        Cislo_uctuLabel.Text = "cislo uctu:"
        '
        'Chovatelska_oblastLabel
        '
        Chovatelska_oblastLabel.AutoSize = True
        Chovatelska_oblastLabel.Location = New System.Drawing.Point(65, 402)
        Chovatelska_oblastLabel.Name = "Chovatelska_oblastLabel"
        Chovatelska_oblastLabel.Size = New System.Drawing.Size(99, 13)
        Chovatelska_oblastLabel.TabIndex = 27
        Chovatelska_oblastLabel.Text = "chovatelska oblast:"
        '
        'Cislo_reviruLabel
        '
        Cislo_reviruLabel.AutoSize = True
        Cislo_reviruLabel.Location = New System.Drawing.Point(65, 428)
        Cislo_reviruLabel.Name = "Cislo_reviruLabel"
        Cislo_reviruLabel.Size = New System.Drawing.Size(60, 13)
        Cislo_reviruLabel.TabIndex = 29
        Cislo_reviruLabel.Text = "cislo reviru:"
        '
        'VymeraLabel
        '
        VymeraLabel.AutoSize = True
        VymeraLabel.Location = New System.Drawing.Point(65, 454)
        VymeraLabel.Name = "VymeraLabel"
        VymeraLabel.Size = New System.Drawing.Size(44, 13)
        VymeraLabel.TabIndex = 31
        VymeraLabel.Text = "vymera:"
        '
        'LesLabel
        '
        LesLabel.AutoSize = True
        LesLabel.Location = New System.Drawing.Point(65, 480)
        LesLabel.Name = "LesLabel"
        LesLabel.Size = New System.Drawing.Size(23, 13)
        LesLabel.TabIndex = 33
        LesLabel.Text = "les:"
        '
        'JeleniaLabel
        '
        JeleniaLabel.AutoSize = True
        JeleniaLabel.Location = New System.Drawing.Point(65, 506)
        JeleniaLabel.Name = "JeleniaLabel"
        JeleniaLabel.Size = New System.Drawing.Size(40, 13)
        JeleniaLabel.TabIndex = 35
        JeleniaLabel.Text = "jelenia:"
        '
        'SrnciaLabel
        '
        SrnciaLabel.AutoSize = True
        SrnciaLabel.Location = New System.Drawing.Point(65, 532)
        SrnciaLabel.Name = "SrnciaLabel"
        SrnciaLabel.Size = New System.Drawing.Size(38, 13)
        SrnciaLabel.TabIndex = 37
        SrnciaLabel.Text = "srncia:"
        '
        'DiviaciaLabel
        '
        DiviaciaLabel.AutoSize = True
        DiviaciaLabel.Location = New System.Drawing.Point(65, 558)
        DiviaciaLabel.Name = "DiviaciaLabel"
        DiviaciaLabel.Size = New System.Drawing.Size(46, 13)
        DiviaciaLabel.TabIndex = 39
        DiviaciaLabel.Text = "diviacia:"
        '
        'BazantLabel
        '
        BazantLabel.AutoSize = True
        BazantLabel.Location = New System.Drawing.Point(65, 584)
        BazantLabel.Name = "BazantLabel"
        BazantLabel.Size = New System.Drawing.Size(42, 13)
        BazantLabel.TabIndex = 41
        BazantLabel.Text = "bazant:"
        '
        'InaLabel
        '
        InaLabel.AutoSize = True
        InaLabel.Location = New System.Drawing.Point(65, 610)
        InaLabel.Name = "InaLabel"
        InaLabel.Size = New System.Drawing.Size(24, 13)
        InaLabel.TabIndex = 43
        InaLabel.Text = "ina:"
        '
        'Platnost_najomnej_zmluvy_doLabel
        '
        Platnost_najomnej_zmluvy_doLabel.AutoSize = True
        Platnost_najomnej_zmluvy_doLabel.Location = New System.Drawing.Point(65, 636)
        Platnost_najomnej_zmluvy_doLabel.Name = "Platnost_najomnej_zmluvy_doLabel"
        Platnost_najomnej_zmluvy_doLabel.Size = New System.Drawing.Size(142, 13)
        Platnost_najomnej_zmluvy_doLabel.TabIndex = 45
        Platnost_najomnej_zmluvy_doLabel.Text = "platnost najomnej zmluvy do:"
        '
        'Stavace_planLabel
        '
        Stavace_planLabel.AutoSize = True
        Stavace_planLabel.Location = New System.Drawing.Point(65, 662)
        Stavace_planLabel.Name = "Stavace_planLabel"
        Stavace_planLabel.Size = New System.Drawing.Size(71, 13)
        Stavace_planLabel.TabIndex = 47
        Stavace_planLabel.Text = "stavace plan:"
        '
        'Stavace_skutocnostLabel
        '
        Stavace_skutocnostLabel.AutoSize = True
        Stavace_skutocnostLabel.Location = New System.Drawing.Point(65, 688)
        Stavace_skutocnostLabel.Name = "Stavace_skutocnostLabel"
        Stavace_skutocnostLabel.Size = New System.Drawing.Size(103, 13)
        Stavace_skutocnostLabel.TabIndex = 49
        Stavace_skutocnostLabel.Text = "stavace skutocnost:"
        '
        'Sliedice_planLabel
        '
        Sliedice_planLabel.AutoSize = True
        Sliedice_planLabel.Location = New System.Drawing.Point(65, 714)
        Sliedice_planLabel.Name = "Sliedice_planLabel"
        Sliedice_planLabel.Size = New System.Drawing.Size(68, 13)
        Sliedice_planLabel.TabIndex = 51
        Sliedice_planLabel.Text = "sliedice plan:"
        '
        'Sliedice_skutocnostLabel
        '
        Sliedice_skutocnostLabel.AutoSize = True
        Sliedice_skutocnostLabel.Location = New System.Drawing.Point(65, 740)
        Sliedice_skutocnostLabel.Name = "Sliedice_skutocnostLabel"
        Sliedice_skutocnostLabel.Size = New System.Drawing.Size(100, 13)
        Sliedice_skutocnostLabel.TabIndex = 53
        Sliedice_skutocnostLabel.Text = "sliedice skutocnost:"
        '
        'Slovensky_kopov_planLabel
        '
        Slovensky_kopov_planLabel.AutoSize = True
        Slovensky_kopov_planLabel.Location = New System.Drawing.Point(65, 766)
        Slovensky_kopov_planLabel.Name = "Slovensky_kopov_planLabel"
        Slovensky_kopov_planLabel.Size = New System.Drawing.Size(113, 13)
        Slovensky_kopov_planLabel.TabIndex = 55
        Slovensky_kopov_planLabel.Text = "slovensky kopov plan:"
        '
        'Slovensky_kopov_skutocnostLabel
        '
        Slovensky_kopov_skutocnostLabel.AutoSize = True
        Slovensky_kopov_skutocnostLabel.Location = New System.Drawing.Point(65, 792)
        Slovensky_kopov_skutocnostLabel.Name = "Slovensky_kopov_skutocnostLabel"
        Slovensky_kopov_skutocnostLabel.Size = New System.Drawing.Size(145, 13)
        Slovensky_kopov_skutocnostLabel.TabIndex = 57
        Slovensky_kopov_skutocnostLabel.Text = "slovensky kopov skutocnost:"
        '
        'Ostatne_durice_planLabel
        '
        Ostatne_durice_planLabel.AutoSize = True
        Ostatne_durice_planLabel.Location = New System.Drawing.Point(65, 818)
        Ostatne_durice_planLabel.Name = "Ostatne_durice_planLabel"
        Ostatne_durice_planLabel.Size = New System.Drawing.Size(100, 13)
        Ostatne_durice_planLabel.TabIndex = 59
        Ostatne_durice_planLabel.Text = "ostatne durice plan:"
        '
        'Ostatne_durice_skutocnostLabel
        '
        Ostatne_durice_skutocnostLabel.AutoSize = True
        Ostatne_durice_skutocnostLabel.Location = New System.Drawing.Point(65, 844)
        Ostatne_durice_skutocnostLabel.Name = "Ostatne_durice_skutocnostLabel"
        Ostatne_durice_skutocnostLabel.Size = New System.Drawing.Size(132, 13)
        Ostatne_durice_skutocnostLabel.TabIndex = 61
        Ostatne_durice_skutocnostLabel.Text = "ostatne durice skutocnost:"
        '
        'Brlohare_planLabel
        '
        Brlohare_planLabel.AutoSize = True
        Brlohare_planLabel.Location = New System.Drawing.Point(65, 870)
        Brlohare_planLabel.Name = "Brlohare_planLabel"
        Brlohare_planLabel.Size = New System.Drawing.Size(71, 13)
        Brlohare_planLabel.TabIndex = 63
        Brlohare_planLabel.Text = "brlohare plan:"
        '
        'Brlohare_skutocnostLabel
        '
        Brlohare_skutocnostLabel.AutoSize = True
        Brlohare_skutocnostLabel.Location = New System.Drawing.Point(65, 896)
        Brlohare_skutocnostLabel.Name = "Brlohare_skutocnostLabel"
        Brlohare_skutocnostLabel.Size = New System.Drawing.Size(103, 13)
        Brlohare_skutocnostLabel.TabIndex = 65
        Brlohare_skutocnostLabel.Text = "brlohare skutocnost:"
        '
        'Farbiare_planLabel
        '
        Farbiare_planLabel.AutoSize = True
        Farbiare_planLabel.Location = New System.Drawing.Point(65, 922)
        Farbiare_planLabel.Name = "Farbiare_planLabel"
        Farbiare_planLabel.Size = New System.Drawing.Size(68, 13)
        Farbiare_planLabel.TabIndex = 67
        Farbiare_planLabel.Text = "farbiare plan:"
        '
        'Farbiare_skutocnostLabel
        '
        Farbiare_skutocnostLabel.AutoSize = True
        Farbiare_skutocnostLabel.Location = New System.Drawing.Point(65, 948)
        Farbiare_skutocnostLabel.Name = "Farbiare_skutocnostLabel"
        Farbiare_skutocnostLabel.Size = New System.Drawing.Size(100, 13)
        Farbiare_skutocnostLabel.TabIndex = 69
        Farbiare_skutocnostLabel.Text = "farbiare skutocnost:"
        '
        'Pes_jelenia_planLabel
        '
        Pes_jelenia_planLabel.AutoSize = True
        Pes_jelenia_planLabel.Location = New System.Drawing.Point(65, 974)
        Pes_jelenia_planLabel.Name = "Pes_jelenia_planLabel"
        Pes_jelenia_planLabel.Size = New System.Drawing.Size(83, 13)
        Pes_jelenia_planLabel.TabIndex = 71
        Pes_jelenia_planLabel.Text = "pes jelenia plan:"
        '
        'Pes_jelenia_skutocnostLabel
        '
        Pes_jelenia_skutocnostLabel.AutoSize = True
        Pes_jelenia_skutocnostLabel.Location = New System.Drawing.Point(65, 1000)
        Pes_jelenia_skutocnostLabel.Name = "Pes_jelenia_skutocnostLabel"
        Pes_jelenia_skutocnostLabel.Size = New System.Drawing.Size(115, 13)
        Pes_jelenia_skutocnostLabel.TabIndex = 73
        Pes_jelenia_skutocnostLabel.Text = "pes jelenia skutocnost:"
        '
        'Pes_diviacia_planLabel
        '
        Pes_diviacia_planLabel.AutoSize = True
        Pes_diviacia_planLabel.Location = New System.Drawing.Point(65, 1026)
        Pes_diviacia_planLabel.Name = "Pes_diviacia_planLabel"
        Pes_diviacia_planLabel.Size = New System.Drawing.Size(89, 13)
        Pes_diviacia_planLabel.TabIndex = 75
        Pes_diviacia_planLabel.Text = "pes diviacia plan:"
        '
        'Pes_diviacia_skutocnostLabel
        '
        Pes_diviacia_skutocnostLabel.AutoSize = True
        Pes_diviacia_skutocnostLabel.Location = New System.Drawing.Point(65, 1052)
        Pes_diviacia_skutocnostLabel.Name = "Pes_diviacia_skutocnostLabel"
        Pes_diviacia_skutocnostLabel.Size = New System.Drawing.Size(121, 13)
        Pes_diviacia_skutocnostLabel.TabIndex = 77
        Pes_diviacia_skutocnostLabel.Text = "pes diviacia skutocnost:"
        '
        'Pes_srncia_planLabel
        '
        Pes_srncia_planLabel.AutoSize = True
        Pes_srncia_planLabel.Location = New System.Drawing.Point(65, 1078)
        Pes_srncia_planLabel.Name = "Pes_srncia_planLabel"
        Pes_srncia_planLabel.Size = New System.Drawing.Size(81, 13)
        Pes_srncia_planLabel.TabIndex = 79
        Pes_srncia_planLabel.Text = "pes srncia plan:"
        '
        'Pes_srncia_skutocnostLabel
        '
        Pes_srncia_skutocnostLabel.AutoSize = True
        Pes_srncia_skutocnostLabel.Location = New System.Drawing.Point(65, 1104)
        Pes_srncia_skutocnostLabel.Name = "Pes_srncia_skutocnostLabel"
        Pes_srncia_skutocnostLabel.Size = New System.Drawing.Size(113, 13)
        Pes_srncia_skutocnostLabel.TabIndex = 81
        Pes_srncia_skutocnostLabel.Text = "pes srncia skutocnost:"
        '
        'Pes_mala_planLabel
        '
        Pes_mala_planLabel.AutoSize = True
        Pes_mala_planLabel.Location = New System.Drawing.Point(65, 1130)
        Pes_mala_planLabel.Name = "Pes_mala_planLabel"
        Pes_mala_planLabel.Size = New System.Drawing.Size(75, 13)
        Pes_mala_planLabel.TabIndex = 83
        Pes_mala_planLabel.Text = "pes mala plan:"
        '
        'Pes_mala_skutocnostLabel
        '
        Pes_mala_skutocnostLabel.AutoSize = True
        Pes_mala_skutocnostLabel.Location = New System.Drawing.Point(65, 1156)
        Pes_mala_skutocnostLabel.Name = "Pes_mala_skutocnostLabel"
        Pes_mala_skutocnostLabel.Size = New System.Drawing.Size(107, 13)
        Pes_mala_skutocnostLabel.TabIndex = 85
        Pes_mala_skutocnostLabel.Text = "pes mala skutocnost:"
        '
        'ZdruzeniaBindingNavigator
        '
        Me.ZdruzeniaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ZdruzeniaBindingNavigator.BindingSource = Me.ZdruzeniaBindingSource
        Me.ZdruzeniaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ZdruzeniaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ZdruzeniaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ZdruzeniaBindingNavigatorSaveItem})
        Me.ZdruzeniaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ZdruzeniaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ZdruzeniaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ZdruzeniaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ZdruzeniaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ZdruzeniaBindingNavigator.Name = "ZdruzeniaBindingNavigator"
        Me.ZdruzeniaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ZdruzeniaBindingNavigator.Size = New System.Drawing.Size(741, 25)
        Me.ZdruzeniaBindingNavigator.TabIndex = 0
        Me.ZdruzeniaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ZdruzeniaBindingSource
        '
        Me.ZdruzeniaBindingSource.DataMember = "zdruzenia"
        Me.ZdruzeniaBindingSource.DataSource = Me.SpzDataSet
        '
        'SpzDataSet
        '
        Me.SpzDataSet.DataSetName = "spzDataSet"
        Me.SpzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ZdruzeniaBindingNavigatorSaveItem
        '
        Me.ZdruzeniaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZdruzeniaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZdruzeniaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZdruzeniaBindingNavigatorSaveItem.Name = "ZdruzeniaBindingNavigatorSaveItem"
        Me.ZdruzeniaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ZdruzeniaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(216, 61)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.ReadOnly = True
        Me.IcoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IcoTextBox.TabIndex = 2
        '
        'ICO_clenoviaTextBox
        '
        Me.ICO_clenoviaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ICO_clenovia", True))
        Me.ICO_clenoviaTextBox.Location = New System.Drawing.Point(216, 87)
        Me.ICO_clenoviaTextBox.Name = "ICO_clenoviaTextBox"
        Me.ICO_clenoviaTextBox.ReadOnly = True
        Me.ICO_clenoviaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ICO_clenoviaTextBox.TabIndex = 4
        '
        'ICO_psyTextBox
        '
        Me.ICO_psyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ICO_psy", True))
        Me.ICO_psyTextBox.Location = New System.Drawing.Point(216, 113)
        Me.ICO_psyTextBox.Name = "ICO_psyTextBox"
        Me.ICO_psyTextBox.ReadOnly = True
        Me.ICO_psyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ICO_psyTextBox.TabIndex = 6
        '
        'ICO_trofejeTextBox
        '
        Me.ICO_trofejeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ICO_trofeje", True))
        Me.ICO_trofejeTextBox.Location = New System.Drawing.Point(216, 139)
        Me.ICO_trofejeTextBox.Name = "ICO_trofejeTextBox"
        Me.ICO_trofejeTextBox.ReadOnly = True
        Me.ICO_trofejeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ICO_trofejeTextBox.TabIndex = 8
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(216, 165)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NazovTextBox.TabIndex = 10
        '
        'SidloTextBox
        '
        Me.SidloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "sidlo", True))
        Me.SidloTextBox.Location = New System.Drawing.Point(216, 191)
        Me.SidloTextBox.Name = "SidloTextBox"
        Me.SidloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SidloTextBox.TabIndex = 12
        '
        'PredsedaTextBox
        '
        Me.PredsedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "predseda", True))
        Me.PredsedaTextBox.Location = New System.Drawing.Point(216, 217)
        Me.PredsedaTextBox.Name = "PredsedaTextBox"
        Me.PredsedaTextBox.ReadOnly = True
        Me.PredsedaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PredsedaTextBox.TabIndex = 14
        '
        'Predseda_telefonTextBox
        '
        Me.Predseda_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "predseda_telefon", True))
        Me.Predseda_telefonTextBox.Location = New System.Drawing.Point(216, 243)
        Me.Predseda_telefonTextBox.Name = "Predseda_telefonTextBox"
        Me.Predseda_telefonTextBox.ReadOnly = True
        Me.Predseda_telefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Predseda_telefonTextBox.TabIndex = 16
        '
        'Polovny_hospodarTextBox
        '
        Me.Polovny_hospodarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "polovny_hospodar", True))
        Me.Polovny_hospodarTextBox.Location = New System.Drawing.Point(216, 269)
        Me.Polovny_hospodarTextBox.Name = "Polovny_hospodarTextBox"
        Me.Polovny_hospodarTextBox.ReadOnly = True
        Me.Polovny_hospodarTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Polovny_hospodarTextBox.TabIndex = 18
        '
        'Polovny_hospodar_telefonTextBox
        '
        Me.Polovny_hospodar_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "polovny_hospodar_telefon", True))
        Me.Polovny_hospodar_telefonTextBox.Location = New System.Drawing.Point(216, 295)
        Me.Polovny_hospodar_telefonTextBox.Name = "Polovny_hospodar_telefonTextBox"
        Me.Polovny_hospodar_telefonTextBox.ReadOnly = True
        Me.Polovny_hospodar_telefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Polovny_hospodar_telefonTextBox.TabIndex = 20
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(216, 321)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DicTextBox.TabIndex = 22
        '
        'BankaTextBox
        '
        Me.BankaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "banka", True))
        Me.BankaTextBox.Location = New System.Drawing.Point(216, 347)
        Me.BankaTextBox.Name = "BankaTextBox"
        Me.BankaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BankaTextBox.TabIndex = 24
        '
        'Cislo_uctuTextBox
        '
        Me.Cislo_uctuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "cislo_uctu", True))
        Me.Cislo_uctuTextBox.Location = New System.Drawing.Point(216, 373)
        Me.Cislo_uctuTextBox.Name = "Cislo_uctuTextBox"
        Me.Cislo_uctuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cislo_uctuTextBox.TabIndex = 26
        '
        'Chovatelska_oblastTextBox
        '
        Me.Chovatelska_oblastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "chovatelska_oblast", True))
        Me.Chovatelska_oblastTextBox.Location = New System.Drawing.Point(216, 399)
        Me.Chovatelska_oblastTextBox.Name = "Chovatelska_oblastTextBox"
        Me.Chovatelska_oblastTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Chovatelska_oblastTextBox.TabIndex = 28
        '
        'Cislo_reviruTextBox
        '
        Me.Cislo_reviruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "cislo_reviru", True))
        Me.Cislo_reviruTextBox.Location = New System.Drawing.Point(216, 425)
        Me.Cislo_reviruTextBox.Name = "Cislo_reviruTextBox"
        Me.Cislo_reviruTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cislo_reviruTextBox.TabIndex = 30
        '
        'VymeraTextBox
        '
        Me.VymeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "vymera", True))
        Me.VymeraTextBox.Location = New System.Drawing.Point(216, 451)
        Me.VymeraTextBox.Name = "VymeraTextBox"
        Me.VymeraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VymeraTextBox.TabIndex = 32
        '
        'LesTextBox
        '
        Me.LesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "les", True))
        Me.LesTextBox.Location = New System.Drawing.Point(216, 477)
        Me.LesTextBox.Name = "LesTextBox"
        Me.LesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LesTextBox.TabIndex = 34
        '
        'JeleniaTextBox
        '
        Me.JeleniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "jelenia", True))
        Me.JeleniaTextBox.Location = New System.Drawing.Point(216, 503)
        Me.JeleniaTextBox.Name = "JeleniaTextBox"
        Me.JeleniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JeleniaTextBox.TabIndex = 36
        '
        'SrnciaTextBox
        '
        Me.SrnciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "srncia", True))
        Me.SrnciaTextBox.Location = New System.Drawing.Point(216, 529)
        Me.SrnciaTextBox.Name = "SrnciaTextBox"
        Me.SrnciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SrnciaTextBox.TabIndex = 38
        '
        'DiviaciaTextBox
        '
        Me.DiviaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "diviacia", True))
        Me.DiviaciaTextBox.Location = New System.Drawing.Point(216, 555)
        Me.DiviaciaTextBox.Name = "DiviaciaTextBox"
        Me.DiviaciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiviaciaTextBox.TabIndex = 40
        '
        'BazantTextBox
        '
        Me.BazantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "bazant", True))
        Me.BazantTextBox.Location = New System.Drawing.Point(216, 581)
        Me.BazantTextBox.Name = "BazantTextBox"
        Me.BazantTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BazantTextBox.TabIndex = 42
        '
        'InaTextBox
        '
        Me.InaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ina", True))
        Me.InaTextBox.Location = New System.Drawing.Point(216, 607)
        Me.InaTextBox.Name = "InaTextBox"
        Me.InaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InaTextBox.TabIndex = 44
        '
        'Platnost_najomnej_zmluvy_doTextBox
        '
        Me.Platnost_najomnej_zmluvy_doTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "platnost_najomnej_zmluvy_do", True))
        Me.Platnost_najomnej_zmluvy_doTextBox.Location = New System.Drawing.Point(216, 633)
        Me.Platnost_najomnej_zmluvy_doTextBox.Name = "Platnost_najomnej_zmluvy_doTextBox"
        Me.Platnost_najomnej_zmluvy_doTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Platnost_najomnej_zmluvy_doTextBox.TabIndex = 46
        '
        'Stavace_planTextBox
        '
        Me.Stavace_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "stavace_plan", True))
        Me.Stavace_planTextBox.Location = New System.Drawing.Point(216, 659)
        Me.Stavace_planTextBox.Name = "Stavace_planTextBox"
        Me.Stavace_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stavace_planTextBox.TabIndex = 48
        '
        'Stavace_skutocnostTextBox
        '
        Me.Stavace_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "stavace_skutocnost", True))
        Me.Stavace_skutocnostTextBox.Location = New System.Drawing.Point(216, 685)
        Me.Stavace_skutocnostTextBox.Name = "Stavace_skutocnostTextBox"
        Me.Stavace_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stavace_skutocnostTextBox.TabIndex = 50
        '
        'Sliedice_planTextBox
        '
        Me.Sliedice_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "sliedice_plan", True))
        Me.Sliedice_planTextBox.Location = New System.Drawing.Point(216, 711)
        Me.Sliedice_planTextBox.Name = "Sliedice_planTextBox"
        Me.Sliedice_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sliedice_planTextBox.TabIndex = 52
        '
        'Sliedice_skutocnostTextBox
        '
        Me.Sliedice_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "sliedice_skutocnost", True))
        Me.Sliedice_skutocnostTextBox.Location = New System.Drawing.Point(216, 737)
        Me.Sliedice_skutocnostTextBox.Name = "Sliedice_skutocnostTextBox"
        Me.Sliedice_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sliedice_skutocnostTextBox.TabIndex = 54
        '
        'Slovensky_kopov_planTextBox
        '
        Me.Slovensky_kopov_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "slovensky_kopov_plan", True))
        Me.Slovensky_kopov_planTextBox.Location = New System.Drawing.Point(216, 763)
        Me.Slovensky_kopov_planTextBox.Name = "Slovensky_kopov_planTextBox"
        Me.Slovensky_kopov_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Slovensky_kopov_planTextBox.TabIndex = 56
        '
        'Slovensky_kopov_skutocnostTextBox
        '
        Me.Slovensky_kopov_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "slovensky_kopov_skutocnost", True))
        Me.Slovensky_kopov_skutocnostTextBox.Location = New System.Drawing.Point(216, 789)
        Me.Slovensky_kopov_skutocnostTextBox.Name = "Slovensky_kopov_skutocnostTextBox"
        Me.Slovensky_kopov_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Slovensky_kopov_skutocnostTextBox.TabIndex = 58
        '
        'Ostatne_durice_planTextBox
        '
        Me.Ostatne_durice_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ostatne_durice_plan", True))
        Me.Ostatne_durice_planTextBox.Location = New System.Drawing.Point(216, 815)
        Me.Ostatne_durice_planTextBox.Name = "Ostatne_durice_planTextBox"
        Me.Ostatne_durice_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ostatne_durice_planTextBox.TabIndex = 60
        '
        'Ostatne_durice_skutocnostTextBox
        '
        Me.Ostatne_durice_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ostatne_durice_skutocnost", True))
        Me.Ostatne_durice_skutocnostTextBox.Location = New System.Drawing.Point(216, 841)
        Me.Ostatne_durice_skutocnostTextBox.Name = "Ostatne_durice_skutocnostTextBox"
        Me.Ostatne_durice_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ostatne_durice_skutocnostTextBox.TabIndex = 62
        '
        'Brlohare_planTextBox
        '
        Me.Brlohare_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "brlohare_plan", True))
        Me.Brlohare_planTextBox.Location = New System.Drawing.Point(216, 867)
        Me.Brlohare_planTextBox.Name = "Brlohare_planTextBox"
        Me.Brlohare_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Brlohare_planTextBox.TabIndex = 64
        '
        'Brlohare_skutocnostTextBox
        '
        Me.Brlohare_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "brlohare_skutocnost", True))
        Me.Brlohare_skutocnostTextBox.Location = New System.Drawing.Point(216, 893)
        Me.Brlohare_skutocnostTextBox.Name = "Brlohare_skutocnostTextBox"
        Me.Brlohare_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Brlohare_skutocnostTextBox.TabIndex = 66
        '
        'Farbiare_planTextBox
        '
        Me.Farbiare_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "farbiare_plan", True))
        Me.Farbiare_planTextBox.Location = New System.Drawing.Point(216, 919)
        Me.Farbiare_planTextBox.Name = "Farbiare_planTextBox"
        Me.Farbiare_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Farbiare_planTextBox.TabIndex = 68
        '
        'Farbiare_skutocnostTextBox
        '
        Me.Farbiare_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "farbiare_skutocnost", True))
        Me.Farbiare_skutocnostTextBox.Location = New System.Drawing.Point(216, 945)
        Me.Farbiare_skutocnostTextBox.Name = "Farbiare_skutocnostTextBox"
        Me.Farbiare_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Farbiare_skutocnostTextBox.TabIndex = 70
        '
        'Pes_jelenia_planTextBox
        '
        Me.Pes_jelenia_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_jelenia_plan", True))
        Me.Pes_jelenia_planTextBox.Location = New System.Drawing.Point(216, 971)
        Me.Pes_jelenia_planTextBox.Name = "Pes_jelenia_planTextBox"
        Me.Pes_jelenia_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_jelenia_planTextBox.TabIndex = 72
        '
        'Pes_jelenia_skutocnostTextBox
        '
        Me.Pes_jelenia_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_jelenia_skutocnost", True))
        Me.Pes_jelenia_skutocnostTextBox.Location = New System.Drawing.Point(216, 997)
        Me.Pes_jelenia_skutocnostTextBox.Name = "Pes_jelenia_skutocnostTextBox"
        Me.Pes_jelenia_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_jelenia_skutocnostTextBox.TabIndex = 74
        '
        'Pes_diviacia_planTextBox
        '
        Me.Pes_diviacia_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_diviacia_plan", True))
        Me.Pes_diviacia_planTextBox.Location = New System.Drawing.Point(216, 1023)
        Me.Pes_diviacia_planTextBox.Name = "Pes_diviacia_planTextBox"
        Me.Pes_diviacia_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_diviacia_planTextBox.TabIndex = 76
        '
        'Pes_diviacia_skutocnostTextBox
        '
        Me.Pes_diviacia_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_diviacia_skutocnost", True))
        Me.Pes_diviacia_skutocnostTextBox.Location = New System.Drawing.Point(216, 1049)
        Me.Pes_diviacia_skutocnostTextBox.Name = "Pes_diviacia_skutocnostTextBox"
        Me.Pes_diviacia_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_diviacia_skutocnostTextBox.TabIndex = 78
        '
        'Pes_srncia_planTextBox
        '
        Me.Pes_srncia_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_srncia_plan", True))
        Me.Pes_srncia_planTextBox.Location = New System.Drawing.Point(216, 1075)
        Me.Pes_srncia_planTextBox.Name = "Pes_srncia_planTextBox"
        Me.Pes_srncia_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_srncia_planTextBox.TabIndex = 80
        '
        'Pes_srncia_skutocnostTextBox
        '
        Me.Pes_srncia_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_srncia_skutocnost", True))
        Me.Pes_srncia_skutocnostTextBox.Location = New System.Drawing.Point(216, 1101)
        Me.Pes_srncia_skutocnostTextBox.Name = "Pes_srncia_skutocnostTextBox"
        Me.Pes_srncia_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_srncia_skutocnostTextBox.TabIndex = 82
        '
        'Pes_mala_planTextBox
        '
        Me.Pes_mala_planTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_mala_plan", True))
        Me.Pes_mala_planTextBox.Location = New System.Drawing.Point(216, 1127)
        Me.Pes_mala_planTextBox.Name = "Pes_mala_planTextBox"
        Me.Pes_mala_planTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_mala_planTextBox.TabIndex = 84
        '
        'Pes_mala_skutocnostTextBox
        '
        Me.Pes_mala_skutocnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "pes_mala_skutocnost", True))
        Me.Pes_mala_skutocnostTextBox.Location = New System.Drawing.Point(216, 1153)
        Me.Pes_mala_skutocnostTextBox.Name = "Pes_mala_skutocnostTextBox"
        Me.Pes_mala_skutocnostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pes_mala_skutocnostTextBox.TabIndex = 86
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "uloz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ZdruzeniaTableAdapter
        '
        Me.ZdruzeniaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._123_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager._456_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager.all_clenoviaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.narodnostTableAdapter = Nothing
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Nothing
        Me.TableAdapterManager.titul_predTableAdapter = Nothing
        Me.TableAdapterManager.titul_zaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        Me.TableAdapterManager.zdruzeniaTableAdapter = Me.ZdruzeniaTableAdapter
        '
        'predsedaComboBox
        '
        Me.predsedaComboBox.DataSource = Me.AllclenoviaBindingSource2
        Me.predsedaComboBox.DisplayMember = "priezvisko"
        Me.predsedaComboBox.FormattingEnabled = True
        Me.predsedaComboBox.Location = New System.Drawing.Point(379, 220)
        Me.predsedaComboBox.Name = "predsedaComboBox"
        Me.predsedaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.predsedaComboBox.TabIndex = 88
        Me.predsedaComboBox.ValueMember = "rodne_cislo"
        '
        'AllclenoviaBindingSource
        '
        Me.AllclenoviaBindingSource.DataMember = "all_clenovia"
        Me.AllclenoviaBindingSource.DataSource = Me.All_clenoviaDataSet
        '
        'All_clenoviaDataSet
        '
        Me.All_clenoviaDataSet.DataSetName = "all_clenoviaDataSet"
        Me.All_clenoviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'All_clenoviaTableAdapter
        '
        Me.All_clenoviaTableAdapter.ClearBeforeFill = True
        '
        'hospodarComboBox
        '
        Me.hospodarComboBox.DataSource = Me.AllclenoviaBindingSource1
        Me.hospodarComboBox.DisplayMember = "priezvisko"
        Me.hospodarComboBox.FormattingEnabled = True
        Me.hospodarComboBox.Location = New System.Drawing.Point(379, 272)
        Me.hospodarComboBox.Name = "hospodarComboBox"
        Me.hospodarComboBox.Size = New System.Drawing.Size(121, 21)
        Me.hospodarComboBox.TabIndex = 89
        Me.hospodarComboBox.ValueMember = "rodne_cislo"
        '
        'AllclenoviaBindingSource1
        '
        Me.AllclenoviaBindingSource1.DataMember = "all_clenovia"
        Me.AllclenoviaBindingSource1.DataSource = Me.HospodarDataSetBindingSource
        '
        'HospodarDataSetBindingSource
        '
        Me.HospodarDataSetBindingSource.DataSource = Me.HospodarDataSet
        Me.HospodarDataSetBindingSource.Position = 0
        '
        'HospodarDataSet
        '
        Me.HospodarDataSet.DataSetName = "hospodarDataSet"
        Me.HospodarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'All_clenoviaTableAdapter1
        '
        Me.All_clenoviaTableAdapter1.ClearBeforeFill = True
        '
        'PredsedaDataSet
        '
        Me.PredsedaDataSet.DataSetName = "predsedaDataSet"
        Me.PredsedaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllclenoviaBindingSource2
        '
        Me.AllclenoviaBindingSource2.DataMember = "all_clenovia"
        Me.AllclenoviaBindingSource2.DataSource = Me.PredsedaDataSet
        '
        'All_clenoviaTableAdapter2
        '
        Me.All_clenoviaTableAdapter2.ClearBeforeFill = True
        '
        'zdruzenie_edituj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(758, 776)
        Me.Controls.Add(Me.hospodarComboBox)
        Me.Controls.Add(Me.predsedaComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(ICO_clenoviaLabel)
        Me.Controls.Add(Me.ICO_clenoviaTextBox)
        Me.Controls.Add(ICO_psyLabel)
        Me.Controls.Add(Me.ICO_psyTextBox)
        Me.Controls.Add(ICO_trofejeLabel)
        Me.Controls.Add(Me.ICO_trofejeTextBox)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(SidloLabel)
        Me.Controls.Add(Me.SidloTextBox)
        Me.Controls.Add(PredsedaLabel)
        Me.Controls.Add(Me.PredsedaTextBox)
        Me.Controls.Add(Predseda_telefonLabel)
        Me.Controls.Add(Me.Predseda_telefonTextBox)
        Me.Controls.Add(Polovny_hospodarLabel)
        Me.Controls.Add(Me.Polovny_hospodarTextBox)
        Me.Controls.Add(Polovny_hospodar_telefonLabel)
        Me.Controls.Add(Me.Polovny_hospodar_telefonTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(BankaLabel)
        Me.Controls.Add(Me.BankaTextBox)
        Me.Controls.Add(Cislo_uctuLabel)
        Me.Controls.Add(Me.Cislo_uctuTextBox)
        Me.Controls.Add(Chovatelska_oblastLabel)
        Me.Controls.Add(Me.Chovatelska_oblastTextBox)
        Me.Controls.Add(Cislo_reviruLabel)
        Me.Controls.Add(Me.Cislo_reviruTextBox)
        Me.Controls.Add(VymeraLabel)
        Me.Controls.Add(Me.VymeraTextBox)
        Me.Controls.Add(LesLabel)
        Me.Controls.Add(Me.LesTextBox)
        Me.Controls.Add(JeleniaLabel)
        Me.Controls.Add(Me.JeleniaTextBox)
        Me.Controls.Add(SrnciaLabel)
        Me.Controls.Add(Me.SrnciaTextBox)
        Me.Controls.Add(DiviaciaLabel)
        Me.Controls.Add(Me.DiviaciaTextBox)
        Me.Controls.Add(BazantLabel)
        Me.Controls.Add(Me.BazantTextBox)
        Me.Controls.Add(InaLabel)
        Me.Controls.Add(Me.InaTextBox)
        Me.Controls.Add(Platnost_najomnej_zmluvy_doLabel)
        Me.Controls.Add(Me.Platnost_najomnej_zmluvy_doTextBox)
        Me.Controls.Add(Stavace_planLabel)
        Me.Controls.Add(Me.Stavace_planTextBox)
        Me.Controls.Add(Stavace_skutocnostLabel)
        Me.Controls.Add(Me.Stavace_skutocnostTextBox)
        Me.Controls.Add(Sliedice_planLabel)
        Me.Controls.Add(Me.Sliedice_planTextBox)
        Me.Controls.Add(Sliedice_skutocnostLabel)
        Me.Controls.Add(Me.Sliedice_skutocnostTextBox)
        Me.Controls.Add(Slovensky_kopov_planLabel)
        Me.Controls.Add(Me.Slovensky_kopov_planTextBox)
        Me.Controls.Add(Slovensky_kopov_skutocnostLabel)
        Me.Controls.Add(Me.Slovensky_kopov_skutocnostTextBox)
        Me.Controls.Add(Ostatne_durice_planLabel)
        Me.Controls.Add(Me.Ostatne_durice_planTextBox)
        Me.Controls.Add(Ostatne_durice_skutocnostLabel)
        Me.Controls.Add(Me.Ostatne_durice_skutocnostTextBox)
        Me.Controls.Add(Brlohare_planLabel)
        Me.Controls.Add(Me.Brlohare_planTextBox)
        Me.Controls.Add(Brlohare_skutocnostLabel)
        Me.Controls.Add(Me.Brlohare_skutocnostTextBox)
        Me.Controls.Add(Farbiare_planLabel)
        Me.Controls.Add(Me.Farbiare_planTextBox)
        Me.Controls.Add(Farbiare_skutocnostLabel)
        Me.Controls.Add(Me.Farbiare_skutocnostTextBox)
        Me.Controls.Add(Pes_jelenia_planLabel)
        Me.Controls.Add(Me.Pes_jelenia_planTextBox)
        Me.Controls.Add(Pes_jelenia_skutocnostLabel)
        Me.Controls.Add(Me.Pes_jelenia_skutocnostTextBox)
        Me.Controls.Add(Pes_diviacia_planLabel)
        Me.Controls.Add(Me.Pes_diviacia_planTextBox)
        Me.Controls.Add(Pes_diviacia_skutocnostLabel)
        Me.Controls.Add(Me.Pes_diviacia_skutocnostTextBox)
        Me.Controls.Add(Pes_srncia_planLabel)
        Me.Controls.Add(Me.Pes_srncia_planTextBox)
        Me.Controls.Add(Pes_srncia_skutocnostLabel)
        Me.Controls.Add(Me.Pes_srncia_skutocnostTextBox)
        Me.Controls.Add(Pes_mala_planLabel)
        Me.Controls.Add(Me.Pes_mala_planTextBox)
        Me.Controls.Add(Pes_mala_skutocnostLabel)
        Me.Controls.Add(Me.Pes_mala_skutocnostTextBox)
        Me.Controls.Add(Me.ZdruzeniaBindingNavigator)
        Me.Name = "zdruzenie_edituj"
        Me.Text = "zdruzenie_edituj"
        CType(Me.ZdruzeniaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZdruzeniaBindingNavigator.ResumeLayout(False)
        Me.ZdruzeniaBindingNavigator.PerformLayout()
        CType(Me.ZdruzeniaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpzDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllclenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.All_clenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllclenoviaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospodarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospodarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PredsedaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllclenoviaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SpzDataSet As evidencia_spz.spzDataSet
    Friend WithEvents ZdruzeniaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzeniaTableAdapter As evidencia_spz.spzDataSetTableAdapters.zdruzeniaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spzDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ZdruzeniaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZdruzeniaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ICO_clenoviaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ICO_psyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ICO_trofejeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SidloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PredsedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Predseda_telefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Polovny_hospodarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Polovny_hospodar_telefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_uctuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Chovatelska_oblastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_reviruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VymeraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JeleniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SrnciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiviaciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BazantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Platnost_najomnej_zmluvy_doTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stavace_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Stavace_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sliedice_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sliedice_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slovensky_kopov_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slovensky_kopov_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ostatne_durice_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ostatne_durice_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brlohare_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brlohare_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Farbiare_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Farbiare_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_jelenia_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_jelenia_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_diviacia_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_diviacia_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_srncia_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_srncia_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_mala_planTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_mala_skutocnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents predsedaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents All_clenoviaDataSet As evidencia_spz.all_clenoviaDataSet
    Friend WithEvents AllclenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents All_clenoviaTableAdapter As evidencia_spz.all_clenoviaDataSetTableAdapters.all_clenoviaTableAdapter
    Friend WithEvents hospodarComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HospodarDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HospodarDataSet As evidencia_spz.hospodarDataSet
    Friend WithEvents AllclenoviaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents All_clenoviaTableAdapter1 As evidencia_spz.hospodarDataSetTableAdapters.all_clenoviaTableAdapter
    Friend WithEvents PredsedaDataSet As evidencia_spz.predsedaDataSet
    Friend WithEvents AllclenoviaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents All_clenoviaTableAdapter2 As evidencia_spz.predsedaDataSetTableAdapters.all_clenoviaTableAdapter
End Class
