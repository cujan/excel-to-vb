<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edituj_clena
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
        Dim TitulLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim Miesto_narodeniaLabel As System.Windows.Forms.Label
        Dim Okres_narodeniaLabel As System.Windows.Forms.Label
        Dim BydliskoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim Statna_prislusnostLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim Datum_vydania_opLabel As System.Windows.Forms.Label
        Dim Cislo_plLabel As System.Windows.Forms.Label
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
        Dim Kontrolne_strelby_brokova_zbranLabel As System.Windows.Forms.Label
        Dim Gulova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_gulova_zbranLabel As System.Windows.Forms.Label
        Dim Vyznamenanie_IIILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_IILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ZKLabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ineLabel As System.Windows.Forms.Label
        Dim Udelene_trestyLabel As System.Windows.Forms.Label
        Dim PoznamkyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edituj_clena))
        Me.ClenoviaDataSet = New evidencia_spz.clenoviaDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.clenoviaDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.clenoviaDataSetTableAdapters.TableAdapterManager
        Me.ClenoviaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.ClenoviaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TitulComboBox = New System.Windows.Forms.ComboBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Statna_prislusnostComboBox = New System.Windows.Forms.ComboBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_opDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_plDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_zpTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_zpDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_clenskeho_preukazu_spzTextBox = New System.Windows.Forms.TextBox
        Me.Clen_spz_odDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Clenske_doDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Cislo_dokladu_clenskeTextBox = New System.Windows.Forms.TextBox
        Me.Clen_pzTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IIITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ZKTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ineTextBox = New System.Windows.Forms.TextBox
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.zavri_edituj_clena = New System.Windows.Forms.Button
        Me.TitulDataSet = New evidencia_spz.titulDataSet
        Me.TitulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulTableAdapter = New evidencia_spz.titulDataSetTableAdapters.titulTableAdapter
        Me.Statna_prislusnostDataSet = New evidencia_spz.statna_prislusnostDataSet
        Me.StatnaprislusnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statna_prislusnostTableAdapter = New evidencia_spz.statna_prislusnostDataSetTableAdapters.statna_prislusnostTableAdapter
        Me.Brokova_zbranComboBox = New System.Windows.Forms.ComboBox
        Me.Gulova_zbranComboBox = New System.Windows.Forms.ComboBox
        Me.PriezviskoComboBox = New System.Windows.Forms.ComboBox
        TitulLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        PriezviskoLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Miesto_narodeniaLabel = New System.Windows.Forms.Label
        Okres_narodeniaLabel = New System.Windows.Forms.Label
        BydliskoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        Statna_prislusnostLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        Datum_vydania_opLabel = New System.Windows.Forms.Label
        Cislo_plLabel = New System.Windows.Forms.Label
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
        Kontrolne_strelby_brokova_zbranLabel = New System.Windows.Forms.Label
        Gulova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_gulova_zbranLabel = New System.Windows.Forms.Label
        Vyznamenanie_IIILabel = New System.Windows.Forms.Label
        Vyznamenanie_IILabel = New System.Windows.Forms.Label
        Vyznamenanie_ILabel = New System.Windows.Forms.Label
        Vyznamenanie_ZKLabel = New System.Windows.Forms.Label
        Vyznamenanie_ineLabel = New System.Windows.Forms.Label
        Udelene_trestyLabel = New System.Windows.Forms.Label
        PoznamkyLabel = New System.Windows.Forms.Label
        CType(Me.ClenoviaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClenoviaBindingNavigator.SuspendLayout()
        CType(Me.TitulDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulLabel
        '
        TitulLabel.AutoSize = True
        TitulLabel.Location = New System.Drawing.Point(12, 51)
        TitulLabel.Name = "TitulLabel"
        TitulLabel.Size = New System.Drawing.Size(26, 13)
        TitulLabel.TabIndex = 3
        TitulLabel.Text = "titul:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(133, 56)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "meno:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(381, 56)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 7
        PriezviskoLabel.Text = "priezvisko:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(12, 125)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(12, 160)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(90, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "miesto narodenia:"
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(314, 164)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(86, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "okres narodenia:"
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(12, 200)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(48, 13)
        BydliskoLabel.TabIndex = 15
        BydliskoLabel.Text = "bydlisko:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(272, 204)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 17
        PscLabel.Text = "psc:"
        '
        'Statna_prislusnostLabel
        '
        Statna_prislusnostLabel.AutoSize = True
        Statna_prislusnostLabel.Location = New System.Drawing.Point(12, 248)
        Statna_prislusnostLabel.Name = "Statna_prislusnostLabel"
        Statna_prislusnostLabel.Size = New System.Drawing.Size(91, 13)
        Statna_prislusnostLabel.TabIndex = 19
        Statna_prislusnostLabel.Text = "statna prislusnost:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(12, 301)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 21
        Cislo_opLabel.Text = "cislo op:"
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(270, 301)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(94, 13)
        Datum_vydania_opLabel.TabIndex = 23
        Datum_vydania_opLabel.Text = "datum vydania op:"
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(12, 338)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(42, 13)
        Cislo_plLabel.TabIndex = 25
        Cislo_plLabel.Text = "cislo pl:"
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(272, 338)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(90, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "datum vydania pl:"
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(12, 381)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(45, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "cislo zp:"
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(272, 381)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(93, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "datum vydania zp:"
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(12, 443)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(149, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "cislo clenskeho preukazu spz:"
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(12, 489)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(64, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "clen spz od:"
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(12, 538)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(62, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "clenske do:"
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(39, 584)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(112, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "cislo dokladu clenske:"
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(41, 613)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(44, 13)
        Clen_pzLabel.TabIndex = 41
        Clen_pzLabel.Text = "clen pz:"
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(41, 639)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(110, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 43
        Skuska_z_polovnictvaLabel.Text = "skuska z polovnictva:"
        '
        'Miesto_skusky_z_polovnictvaLabel
        '
        Miesto_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(458, 643)
        Miesto_skusky_z_polovnictvaLabel.Name = "Miesto_skusky_z_polovnictvaLabel"
        Miesto_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Miesto_skusky_z_polovnictvaLabel.TabIndex = 45
        Miesto_skusky_z_polovnictvaLabel.Text = "miesto skusky z polovnictva:"
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(42, 670)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(173, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 47
        Skuska_pre_polovnych_hospodarovLabel.Text = "skuska pre polovnych hospodarov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(458, 674)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(205, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 49
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "miesto skusky pre polovnych hospodarov:"
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(42, 708)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Vyzsia_skuska_z_polovnictvaLabel.Text = "vyzsia skuska z polovnictva:"
        '
        'Miesto_vyzsej_skusky_z_polovnictvaLabel
        '
        Miesto_vyzsej_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(458, 711)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Name = "Miesto_vyzsej_skusky_z_polovnictvaLabel"
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(174, 13)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.TabIndex = 53
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Text = "miesto vyzsej skusky z polovnictva:"
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(42, 767)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(78, 13)
        Brokova_zbranLabel.TabIndex = 55
        Brokova_zbranLabel.Text = "brokova zbran:"
        '
        'Kontrolne_strelby_brokova_zbranLabel
        '
        Kontrolne_strelby_brokova_zbranLabel.AutoSize = True
        Kontrolne_strelby_brokova_zbranLabel.Location = New System.Drawing.Point(221, 770)
        Kontrolne_strelby_brokova_zbranLabel.Name = "Kontrolne_strelby_brokova_zbranLabel"
        Kontrolne_strelby_brokova_zbranLabel.Size = New System.Drawing.Size(158, 13)
        Kontrolne_strelby_brokova_zbranLabel.TabIndex = 57
        Kontrolne_strelby_brokova_zbranLabel.Text = "kontrolne strelby brokova zbran:"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(42, 811)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(71, 13)
        Gulova_zbranLabel.TabIndex = 59
        Gulova_zbranLabel.Text = "gulova zbran:"
        '
        'Kontrolne_strelby_gulova_zbranLabel
        '
        Kontrolne_strelby_gulova_zbranLabel.AutoSize = True
        Kontrolne_strelby_gulova_zbranLabel.Location = New System.Drawing.Point(221, 811)
        Kontrolne_strelby_gulova_zbranLabel.Name = "Kontrolne_strelby_gulova_zbranLabel"
        Kontrolne_strelby_gulova_zbranLabel.Size = New System.Drawing.Size(151, 13)
        Kontrolne_strelby_gulova_zbranLabel.TabIndex = 61
        Kontrolne_strelby_gulova_zbranLabel.Text = "kontrolne strelby gulova zbran:"
        '
        'Vyznamenanie_IIILabel
        '
        Vyznamenanie_IIILabel.AutoSize = True
        Vyznamenanie_IIILabel.Location = New System.Drawing.Point(42, 863)
        Vyznamenanie_IIILabel.Name = "Vyznamenanie_IIILabel"
        Vyznamenanie_IIILabel.Size = New System.Drawing.Size(90, 13)
        Vyznamenanie_IIILabel.TabIndex = 63
        Vyznamenanie_IIILabel.Text = "vyznamenanie III:"
        '
        'Vyznamenanie_IILabel
        '
        Vyznamenanie_IILabel.AutoSize = True
        Vyznamenanie_IILabel.Location = New System.Drawing.Point(39, 889)
        Vyznamenanie_IILabel.Name = "Vyznamenanie_IILabel"
        Vyznamenanie_IILabel.Size = New System.Drawing.Size(87, 13)
        Vyznamenanie_IILabel.TabIndex = 65
        Vyznamenanie_IILabel.Text = "vyznamenanie II:"
        '
        'Vyznamenanie_ILabel
        '
        Vyznamenanie_ILabel.AutoSize = True
        Vyznamenanie_ILabel.Location = New System.Drawing.Point(42, 919)
        Vyznamenanie_ILabel.Name = "Vyznamenanie_ILabel"
        Vyznamenanie_ILabel.Size = New System.Drawing.Size(84, 13)
        Vyznamenanie_ILabel.TabIndex = 67
        Vyznamenanie_ILabel.Text = "vyznamenanie I:"
        '
        'Vyznamenanie_ZKLabel
        '
        Vyznamenanie_ZKLabel.AutoSize = True
        Vyznamenanie_ZKLabel.Location = New System.Drawing.Point(42, 952)
        Vyznamenanie_ZKLabel.Name = "Vyznamenanie_ZKLabel"
        Vyznamenanie_ZKLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ZKLabel.TabIndex = 69
        Vyznamenanie_ZKLabel.Text = "vyznamenanie ZK:"
        '
        'Vyznamenanie_ineLabel
        '
        Vyznamenanie_ineLabel.AutoSize = True
        Vyznamenanie_ineLabel.Location = New System.Drawing.Point(42, 984)
        Vyznamenanie_ineLabel.Name = "Vyznamenanie_ineLabel"
        Vyznamenanie_ineLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ineLabel.TabIndex = 71
        Vyznamenanie_ineLabel.Text = "vyznamenanie ine:"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(415, 863)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(76, 13)
        Udelene_trestyLabel.TabIndex = 73
        Udelene_trestyLabel.Text = "udelene tresty:"
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(705, 863)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(58, 13)
        PoznamkyLabel.TabIndex = 75
        PoznamkyLabel.Text = "poznamky:"
        '
        'ClenoviaDataSet
        '
        Me.ClenoviaDataSet.DataSetName = "clenoviaDataSet"
        Me.ClenoviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClenoviaBindingSource
        '
        Me.ClenoviaBindingSource.DataMember = "clenovia"
        Me.ClenoviaBindingSource.DataSource = Me.ClenoviaDataSet
        '
        'ClenoviaTableAdapter
        '
        Me.ClenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clenoviaTableAdapter = Me.ClenoviaTableAdapter
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.clenoviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClenoviaBindingNavigator
        '
        Me.ClenoviaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClenoviaBindingNavigator.BindingSource = Me.ClenoviaBindingSource
        Me.ClenoviaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClenoviaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClenoviaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClenoviaBindingNavigatorSaveItem})
        Me.ClenoviaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClenoviaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClenoviaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClenoviaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClenoviaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClenoviaBindingNavigator.Name = "ClenoviaBindingNavigator"
        Me.ClenoviaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(1016, 25)
        Me.ClenoviaBindingNavigator.TabIndex = 0
        Me.ClenoviaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'ClenoviaBindingNavigatorSaveItem
        '
        Me.ClenoviaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClenoviaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClenoviaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClenoviaBindingNavigatorSaveItem.Name = "ClenoviaBindingNavigatorSaveItem"
        Me.ClenoviaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClenoviaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitulComboBox
        '
        Me.TitulComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul", True))
        Me.TitulComboBox.DataSource = Me.TitulBindingSource
        Me.TitulComboBox.DisplayMember = "titul_skratka"
        Me.TitulComboBox.FormattingEnabled = True
        Me.TitulComboBox.Location = New System.Drawing.Point(44, 48)
        Me.TitulComboBox.Name = "TitulComboBox"
        Me.TitulComboBox.Size = New System.Drawing.Size(83, 21)
        Me.TitulComboBox.TabIndex = 4
        Me.TitulComboBox.ValueMember = "titul_skratka"
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(175, 48)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(79, 122)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 10
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_narodenia", True))
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(108, 157)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_narodenia", True))
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(406, 160)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "bydlisko", True))
        Me.BydliskoTextBox.Location = New System.Drawing.Point(66, 197)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BydliskoTextBox.TabIndex = 16
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(305, 197)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PscTextBox.TabIndex = 18
        '
        'Statna_prislusnostComboBox
        '
        Me.Statna_prislusnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "statna_prislusnost", True))
        Me.Statna_prislusnostComboBox.DataSource = Me.StatnaprislusnostBindingSource
        Me.Statna_prislusnostComboBox.DisplayMember = "skratka"
        Me.Statna_prislusnostComboBox.FormattingEnabled = True
        Me.Statna_prislusnostComboBox.Location = New System.Drawing.Point(108, 240)
        Me.Statna_prislusnostComboBox.Name = "Statna_prislusnostComboBox"
        Me.Statna_prislusnostComboBox.Size = New System.Drawing.Size(75, 21)
        Me.Statna_prislusnostComboBox.TabIndex = 20
        Me.Statna_prislusnostComboBox.ValueMember = "skratka"
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(64, 294)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 22
        '
        'Datum_vydania_opDateTimePicker
        '
        Me.Datum_vydania_opDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_op", True))
        Me.Datum_vydania_opDateTimePicker.Location = New System.Drawing.Point(368, 297)
        Me.Datum_vydania_opDateTimePicker.Name = "Datum_vydania_opDateTimePicker"
        Me.Datum_vydania_opDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_opDateTimePicker.TabIndex = 24
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_pl", True))
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(66, 331)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_plTextBox.TabIndex = 26
        '
        'Datum_vydania_plDateTimePicker
        '
        Me.Datum_vydania_plDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_pl", True))
        Me.Datum_vydania_plDateTimePicker.Location = New System.Drawing.Point(368, 330)
        Me.Datum_vydania_plDateTimePicker.Name = "Datum_vydania_plDateTimePicker"
        Me.Datum_vydania_plDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_plDateTimePicker.TabIndex = 28
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_zp", True))
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(64, 374)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Datum_vydania_zpDateTimePicker
        '
        Me.Datum_vydania_zpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_zp", True))
        Me.Datum_vydania_zpDateTimePicker.Location = New System.Drawing.Point(368, 374)
        Me.Datum_vydania_zpDateTimePicker.Name = "Datum_vydania_zpDateTimePicker"
        Me.Datum_vydania_zpDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_zpDateTimePicker.TabIndex = 32
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_clenskeho_preukazu_spz", True))
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(167, 443)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Clen_spz_odDateTimePicker
        '
        Me.Clen_spz_odDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "clen_spz_od", True))
        Me.Clen_spz_odDateTimePicker.Location = New System.Drawing.Point(167, 489)
        Me.Clen_spz_odDateTimePicker.Name = "Clen_spz_odDateTimePicker"
        Me.Clen_spz_odDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Clen_spz_odDateTimePicker.TabIndex = 36
        '
        'Clenske_doDateTimePicker
        '
        Me.Clenske_doDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "clenske_do", True))
        Me.Clenske_doDateTimePicker.Location = New System.Drawing.Point(167, 534)
        Me.Clenske_doDateTimePicker.Name = "Clenske_doDateTimePicker"
        Me.Clenske_doDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Clenske_doDateTimePicker.TabIndex = 38
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_dokladu_clenske", True))
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(252, 584)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Clen_pzTextBox
        '
        Me.Clen_pzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_pz", True))
        Me.Clen_pzTextBox.Location = New System.Drawing.Point(252, 610)
        Me.Clen_pzTextBox.Name = "Clen_pzTextBox"
        Me.Clen_pzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Clen_pzTextBox.TabIndex = 42
        '
        'Skuska_z_polovnictvaTextBox
        '
        Me.Skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_z_polovnictva", True))
        Me.Skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(252, 636)
        Me.Skuska_z_polovnictvaTextBox.Name = "Skuska_z_polovnictvaTextBox"
        Me.Skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skuska_z_polovnictvaTextBox.TabIndex = 44
        '
        'Miesto_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_skusky_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_z_polovnictva", True))
        Me.Miesto_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(606, 643)
        Me.Miesto_skusky_z_polovnictvaTextBox.Name = "Miesto_skusky_z_polovnictvaTextBox"
        Me.Miesto_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_z_polovnictvaTextBox.TabIndex = 46
        '
        'Skuska_pre_polovnych_hospodarovTextBox
        '
        Me.Skuska_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_pre_polovnych_hospodarov", True))
        Me.Skuska_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(252, 667)
        Me.Skuska_pre_polovnych_hospodarovTextBox.Name = "Skuska_pre_polovnych_hospodarovTextBox"
        Me.Skuska_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skuska_pre_polovnych_hospodarovTextBox.TabIndex = 48
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_pre_polovnych_hospodarov", True))
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(669, 669)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyzsia_skuska_z_polovnictva", True))
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(252, 708)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Name = "Vyzsia_skuska_z_polovnictvaTextBox"
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 52
        '
        'Miesto_vyzsej_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_vyzsej_skusky_z_polovnictva", True))
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(638, 704)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Name = "Miesto_vyzsej_skusky_z_polovnictvaTextBox"
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.TabIndex = 54
        '
        'Kontrolne_strelby_brokova_zbranTextBox
        '
        Me.Kontrolne_strelby_brokova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_brokova_zbran", True))
        Me.Kontrolne_strelby_brokova_zbranTextBox.Location = New System.Drawing.Point(385, 767)
        Me.Kontrolne_strelby_brokova_zbranTextBox.Name = "Kontrolne_strelby_brokova_zbranTextBox"
        Me.Kontrolne_strelby_brokova_zbranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Kontrolne_strelby_brokova_zbranTextBox.TabIndex = 58
        '
        'Kontrolne_strelby_gulova_zbranTextBox
        '
        Me.Kontrolne_strelby_gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_gulova_zbran", True))
        Me.Kontrolne_strelby_gulova_zbranTextBox.Location = New System.Drawing.Point(385, 811)
        Me.Kontrolne_strelby_gulova_zbranTextBox.Name = "Kontrolne_strelby_gulova_zbranTextBox"
        Me.Kontrolne_strelby_gulova_zbranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Kontrolne_strelby_gulova_zbranTextBox.TabIndex = 62
        '
        'Vyznamenanie_IIITextBox
        '
        Me.Vyznamenanie_IIITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_III", True))
        Me.Vyznamenanie_IIITextBox.Location = New System.Drawing.Point(138, 856)
        Me.Vyznamenanie_IIITextBox.Name = "Vyznamenanie_IIITextBox"
        Me.Vyznamenanie_IIITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_IIITextBox.TabIndex = 64
        '
        'Vyznamenanie_IITextBox
        '
        Me.Vyznamenanie_IITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_II", True))
        Me.Vyznamenanie_IITextBox.Location = New System.Drawing.Point(138, 889)
        Me.Vyznamenanie_IITextBox.Name = "Vyznamenanie_IITextBox"
        Me.Vyznamenanie_IITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_IITextBox.TabIndex = 66
        '
        'Vyznamenanie_ITextBox
        '
        Me.Vyznamenanie_ITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_I", True))
        Me.Vyznamenanie_ITextBox.Location = New System.Drawing.Point(138, 919)
        Me.Vyznamenanie_ITextBox.Name = "Vyznamenanie_ITextBox"
        Me.Vyznamenanie_ITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_ITextBox.TabIndex = 68
        '
        'Vyznamenanie_ZKTextBox
        '
        Me.Vyznamenanie_ZKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ZK", True))
        Me.Vyznamenanie_ZKTextBox.Location = New System.Drawing.Point(138, 952)
        Me.Vyznamenanie_ZKTextBox.Name = "Vyznamenanie_ZKTextBox"
        Me.Vyznamenanie_ZKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_ZKTextBox.TabIndex = 70
        '
        'Vyznamenanie_ineTextBox
        '
        Me.Vyznamenanie_ineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ine", True))
        Me.Vyznamenanie_ineTextBox.Location = New System.Drawing.Point(138, 981)
        Me.Vyznamenanie_ineTextBox.Name = "Vyznamenanie_ineTextBox"
        Me.Vyznamenanie_ineTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_ineTextBox.TabIndex = 72
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "udelene_tresty", True))
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(409, 889)
        Me.Udelene_trestyTextBox.Multiline = True
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(200, 112)
        Me.Udelene_trestyTextBox.TabIndex = 74
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "poznamky", True))
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(708, 889)
        Me.PoznamkyTextBox.Multiline = True
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(200, 112)
        Me.PoznamkyTextBox.TabIndex = 76
        '
        'zavri_edituj_clena
        '
        Me.zavri_edituj_clena.Location = New System.Drawing.Point(673, 46)
        Me.zavri_edituj_clena.Name = "zavri_edituj_clena"
        Me.zavri_edituj_clena.Size = New System.Drawing.Size(75, 23)
        Me.zavri_edituj_clena.TabIndex = 77
        Me.zavri_edituj_clena.Text = "Zavrieť"
        Me.zavri_edituj_clena.UseVisualStyleBackColor = True
        '
        'TitulDataSet
        '
        Me.TitulDataSet.DataSetName = "titulDataSet"
        Me.TitulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitulBindingSource
        '
        Me.TitulBindingSource.DataMember = "titul"
        Me.TitulBindingSource.DataSource = Me.TitulDataSet
        '
        'TitulTableAdapter
        '
        Me.TitulTableAdapter.ClearBeforeFill = True
        '
        'Statna_prislusnostDataSet
        '
        Me.Statna_prislusnostDataSet.DataSetName = "statna_prislusnostDataSet"
        Me.Statna_prislusnostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatnaprislusnostBindingSource
        '
        Me.StatnaprislusnostBindingSource.DataMember = "statna_prislusnost"
        Me.StatnaprislusnostBindingSource.DataSource = Me.Statna_prislusnostDataSet
        '
        'Statna_prislusnostTableAdapter
        '
        Me.Statna_prislusnostTableAdapter.ClearBeforeFill = True
        '
        'Brokova_zbranComboBox
        '
        Me.Brokova_zbranComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "brokova_zbran", True))
        Me.Brokova_zbranComboBox.FormattingEnabled = True
        Me.Brokova_zbranComboBox.Items.AddRange(New Object() {"áno", "nie"})
        Me.Brokova_zbranComboBox.Location = New System.Drawing.Point(126, 764)
        Me.Brokova_zbranComboBox.Name = "Brokova_zbranComboBox"
        Me.Brokova_zbranComboBox.Size = New System.Drawing.Size(89, 21)
        Me.Brokova_zbranComboBox.TabIndex = 78
        '
        'Gulova_zbranComboBox
        '
        Me.Gulova_zbranComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "gulova_zbran", True))
        Me.Gulova_zbranComboBox.FormattingEnabled = True
        Me.Gulova_zbranComboBox.Items.AddRange(New Object() {"áno", "nie"})
        Me.Gulova_zbranComboBox.Location = New System.Drawing.Point(126, 808)
        Me.Gulova_zbranComboBox.Name = "Gulova_zbranComboBox"
        Me.Gulova_zbranComboBox.Size = New System.Drawing.Size(89, 21)
        Me.Gulova_zbranComboBox.TabIndex = 79
        '
        'PriezviskoComboBox
        '
        Me.PriezviskoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "priezvisko", True))
        Me.PriezviskoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClenoviaBindingSource, "priezvisko", True))
        Me.PriezviskoComboBox.DataSource = Me.ClenoviaBindingSource
        Me.PriezviskoComboBox.DisplayMember = "priezvisko"
        Me.PriezviskoComboBox.FormattingEnabled = True
        Me.PriezviskoComboBox.Location = New System.Drawing.Point(444, 48)
        Me.PriezviskoComboBox.Name = "PriezviskoComboBox"
        Me.PriezviskoComboBox.Size = New System.Drawing.Size(188, 21)
        Me.PriezviskoComboBox.TabIndex = 80
        Me.PriezviskoComboBox.ValueMember = "priezvisko"
        '
        'edituj_clena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1033, 812)
        Me.Controls.Add(Me.PriezviskoComboBox)
        Me.Controls.Add(Me.Gulova_zbranComboBox)
        Me.Controls.Add(Me.Brokova_zbranComboBox)
        Me.Controls.Add(Me.zavri_edituj_clena)
        Me.Controls.Add(TitulLabel)
        Me.Controls.Add(Me.TitulComboBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Miesto_narodeniaLabel)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Okres_narodeniaLabel)
        Me.Controls.Add(Me.Okres_narodeniaTextBox)
        Me.Controls.Add(BydliskoLabel)
        Me.Controls.Add(Me.BydliskoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(Statna_prislusnostLabel)
        Me.Controls.Add(Me.Statna_prislusnostComboBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Datum_vydania_opLabel)
        Me.Controls.Add(Me.Datum_vydania_opDateTimePicker)
        Me.Controls.Add(Cislo_plLabel)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(Datum_vydania_plLabel)
        Me.Controls.Add(Me.Datum_vydania_plDateTimePicker)
        Me.Controls.Add(Cislo_zpLabel)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Datum_vydania_zpLabel)
        Me.Controls.Add(Me.Datum_vydania_zpDateTimePicker)
        Me.Controls.Add(Cislo_clenskeho_preukazu_spzLabel)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Clen_spz_odLabel)
        Me.Controls.Add(Me.Clen_spz_odDateTimePicker)
        Me.Controls.Add(Clenske_doLabel)
        Me.Controls.Add(Me.Clenske_doDateTimePicker)
        Me.Controls.Add(Cislo_dokladu_clenskeLabel)
        Me.Controls.Add(Me.Cislo_dokladu_clenskeTextBox)
        Me.Controls.Add(Clen_pzLabel)
        Me.Controls.Add(Me.Clen_pzTextBox)
        Me.Controls.Add(Skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Miesto_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Miesto_skusky_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Miesto_vyzsej_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Kontrolne_strelby_brokova_zbranLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_brokova_zbranTextBox)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Kontrolne_strelby_gulova_zbranLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_gulova_zbranTextBox)
        Me.Controls.Add(Vyznamenanie_IIILabel)
        Me.Controls.Add(Me.Vyznamenanie_IIITextBox)
        Me.Controls.Add(Vyznamenanie_IILabel)
        Me.Controls.Add(Me.Vyznamenanie_IITextBox)
        Me.Controls.Add(Vyznamenanie_ILabel)
        Me.Controls.Add(Me.Vyznamenanie_ITextBox)
        Me.Controls.Add(Vyznamenanie_ZKLabel)
        Me.Controls.Add(Me.Vyznamenanie_ZKTextBox)
        Me.Controls.Add(Vyznamenanie_ineLabel)
        Me.Controls.Add(Me.Vyznamenanie_ineTextBox)
        Me.Controls.Add(Udelene_trestyLabel)
        Me.Controls.Add(Me.Udelene_trestyTextBox)
        Me.Controls.Add(PoznamkyLabel)
        Me.Controls.Add(Me.PoznamkyTextBox)
        Me.Controls.Add(Me.ClenoviaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edituj_clena"
        Me.Text = "edituj_clena"
        CType(Me.ClenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
        CType(Me.TitulDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClenoviaDataSet As evidencia_spz.clenoviaDataSet
    Friend WithEvents ClenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClenoviaTableAdapter As evidencia_spz.clenoviaDataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.clenoviaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClenoviaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClenoviaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TitulComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Statna_prislusnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_opDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_plDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_zpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_clenskeho_preukazu_spzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_spz_odDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Clenske_doDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cislo_dokladu_clenskeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_pzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_vyzsej_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IIITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ZKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zavri_edituj_clena As System.Windows.Forms.Button
    Friend WithEvents TitulDataSet As evidencia_spz.titulDataSet
    Friend WithEvents TitulBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitulTableAdapter As evidencia_spz.titulDataSetTableAdapters.titulTableAdapter
    Friend WithEvents Statna_prislusnostDataSet As evidencia_spz.statna_prislusnostDataSet
    Friend WithEvents StatnaprislusnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostTableAdapter As evidencia_spz.statna_prislusnostDataSetTableAdapters.statna_prislusnostTableAdapter
    Friend WithEvents Brokova_zbranComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Gulova_zbranComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriezviskoComboBox As System.Windows.Forms.ComboBox
End Class
