<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class novy_clen
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
        Dim Miesto_skusky_z__polovnictvaLabel As System.Windows.Forms.Label
        Dim Skuska_pre_polovnych_hospodarovLabel As System.Windows.Forms.Label
        Dim Miesto_skusky_pre_polovnych_hospodarovLabel As System.Windows.Forms.Label
        Dim Vyzsia_skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Miesto_vyzsia_skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Brokova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_brokLabel As System.Windows.Forms.Label
        Dim Gulova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_gulova_zbranLabel As System.Windows.Forms.Label
        Dim Vyznamenanie_IIILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_IILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ILabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ZKLabel As System.Windows.Forms.Label
        Dim Vyznamenanie_ineLabel As System.Windows.Forms.Label
        Dim Udelene_trestyLabel As System.Windows.Forms.Label
        Dim PoznamkyLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim NarodnostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(novy_clen))
        Me.Spz_evidenciaDataSet = New evidencia_spz.spz_evidenciaDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.spz_evidenciaDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spz_evidenciaDataSetTableAdapters.TableAdapterManager
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
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_zpTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_clenskeho_preukazu_spzTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_dokladu_clenskeTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_z__polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Brokova_zbranCheckBox = New System.Windows.Forms.CheckBox
        Me.Gulova_zbranCheckBox = New System.Windows.Forms.CheckBox
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TitulComboBox = New System.Windows.Forms.ComboBox
        Me.TitulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulDataSet1 = New evidencia_spz.titulDataSet1
        Me.TitulTableAdapter = New evidencia_spz.titulDataSet1TableAdapters.titulTableAdapter
        Me.Statna_prislusnostComboBox = New System.Windows.Forms.ComboBox
        Me.StatnaprislusnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatnaprislusnostDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statna_prislusnostDataSet1 = New evidencia_spz.statna_prislusnostDataSet1
        Me.Statna_prislusnostTableAdapter = New evidencia_spz.statna_prislusnostDataSet1TableAdapters.statna_prislusnostTableAdapter
        Me.NarodnostComboBox = New System.Windows.Forms.ComboBox
        Me.NarodnostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarodnostDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NarodnostDataSet = New evidencia_spz.narodnostDataSet
        Me.NarodnostTableAdapter = New evidencia_spz.narodnostDataSetTableAdapters.narodnostTableAdapter
        Me.ZdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieDataSet = New evidencia_spz.zdruzenieDataSet
        Me.ZdruzenieTableAdapter = New evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
        Me.Clen_pzComboBox = New System.Windows.Forms.ComboBox
        Me.ZdruzenieBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datum_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_opTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_plTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_zpTextBox = New System.Windows.Forms.TextBox
        Me.Clen_spz_odTextBox = New System.Windows.Forms.TextBox
        Me.Clenske_doTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IIITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ZKTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ineTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
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
        Miesto_skusky_z__polovnictvaLabel = New System.Windows.Forms.Label
        Skuska_pre_polovnych_hospodarovLabel = New System.Windows.Forms.Label
        Miesto_skusky_pre_polovnych_hospodarovLabel = New System.Windows.Forms.Label
        Vyzsia_skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Miesto_vyzsia_skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Brokova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_brokLabel = New System.Windows.Forms.Label
        Gulova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_gulova_zbranLabel = New System.Windows.Forms.Label
        Vyznamenanie_IIILabel = New System.Windows.Forms.Label
        Vyznamenanie_IILabel = New System.Windows.Forms.Label
        Vyznamenanie_ILabel = New System.Windows.Forms.Label
        Vyznamenanie_ZKLabel = New System.Windows.Forms.Label
        Vyznamenanie_ineLabel = New System.Windows.Forms.Label
        Udelene_trestyLabel = New System.Windows.Forms.Label
        PoznamkyLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        NarodnostLabel = New System.Windows.Forms.Label
        CType(Me.Spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClenoviaBindingNavigator.SuspendLayout()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatnaprislusnostDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statna_prislusnostDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NarodnostDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulLabel
        '
        TitulLabel.AutoSize = True
        TitulLabel.Location = New System.Drawing.Point(12, 63)
        TitulLabel.Name = "TitulLabel"
        TitulLabel.Size = New System.Drawing.Size(30, 13)
        TitulLabel.TabIndex = 3
        TitulLabel.Text = "Titul:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(148, 63)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(37, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "Meno:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(343, 63)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(58, 13)
        PriezviskoLabel.TabIndex = 7
        PriezviskoLabel.Text = "Priezvisko:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(12, 122)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(68, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "Rodné číslo:"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(12, 185)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "Miesto narodenia:"
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(316, 189)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(88, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "Okres narodenia:"
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(12, 238)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(49, 13)
        BydliskoLabel.TabIndex = 15
        BydliskoLabel.Text = "Bydlisko:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(316, 238)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(31, 13)
        PscLabel.TabIndex = 17
        PscLabel.Text = "PSČ:"
        '
        'Statna_prislusnostLabel
        '
        Statna_prislusnostLabel.AutoSize = True
        Statna_prislusnostLabel.Location = New System.Drawing.Point(12, 297)
        Statna_prislusnostLabel.Name = "Statna_prislusnostLabel"
        Statna_prislusnostLabel.Size = New System.Drawing.Size(96, 13)
        Statna_prislusnostLabel.TabIndex = 19
        Statna_prislusnostLabel.Text = "Štátna príslušnosť:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(12, 349)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(52, 13)
        Cislo_opLabel.TabIndex = 21
        Cislo_opLabel.Text = "Číslo OP:"
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(316, 350)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(99, 13)
        Datum_vydania_opLabel.TabIndex = 23
        Datum_vydania_opLabel.Text = "Dátum vydania OP:"
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(12, 394)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(50, 13)
        Cislo_plLabel.TabIndex = 25
        Cislo_plLabel.Text = "Číslo PL:"
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(316, 405)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(97, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "Dátum vydania PL:"
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(12, 446)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(51, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "Číslo ZP:"
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(316, 446)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(98, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "Dátum vydania ZP:"
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(12, 505)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(157, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "Číslo členského preukazu SPZ:"
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(106, 538)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(70, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "Člen SPZ od:"
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(401, 542)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(63, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "Členské do:"
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(58, 576)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(115, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "Číslo dokladu členské:"
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(403, 576)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(48, 13)
        Clen_pzLabel.TabIndex = 41
        Clen_pzLabel.Text = "Člen PZ:"
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(59, 635)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(116, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 43
        Skuska_z_polovnictvaLabel.Text = "Skúška z poľovníctva:"
        '
        'Miesto_skusky_z__polovnictvaLabel
        '
        Miesto_skusky_z__polovnictvaLabel.AutoSize = True
        Miesto_skusky_z__polovnictvaLabel.Location = New System.Drawing.Point(392, 638)
        Miesto_skusky_z__polovnictvaLabel.Name = "Miesto_skusky_z__polovnictvaLabel"
        Miesto_skusky_z__polovnictvaLabel.Size = New System.Drawing.Size(150, 13)
        Miesto_skusky_z__polovnictvaLabel.TabIndex = 45
        Miesto_skusky_z__polovnictvaLabel.Text = "Miesto skúšky z  poľovníctva:"
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(540, 723)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(177, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 47
        Skuska_pre_polovnych_hospodarovLabel.Text = "Skúška pre poľovných hospodárov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(540, 748)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(208, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 49
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "Miesto skúšky pre poľovných hospodárov:"
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(540, 775)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(147, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Vyzsia_skuska_z_polovnictvaLabel.Text = "Vyžšia skúška z poľovníctva:"
        '
        'Miesto_vyzsia_skuska_z_polovnictvaLabel
        '
        Miesto_vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(540, 800)
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Name = "Miesto_vyzsia_skuska_z_polovnictvaLabel"
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(179, 13)
        Miesto_vyzsia_skuska_z_polovnictvaLabel.TabIndex = 53
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Text = "Miesto vyžšej skúšky z poľovníctva:"
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(58, 697)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(79, 13)
        Brokova_zbranLabel.TabIndex = 55
        Brokova_zbranLabel.Text = "Broková zbraň:"
        '
        'Kontrolne_strelby_brokLabel
        '
        Kontrolne_strelby_brokLabel.AutoSize = True
        Kontrolne_strelby_brokLabel.Location = New System.Drawing.Point(58, 726)
        Kontrolne_strelby_brokLabel.Name = "Kontrolne_strelby_brokLabel"
        Kontrolne_strelby_brokLabel.Size = New System.Drawing.Size(114, 13)
        Kontrolne_strelby_brokLabel.TabIndex = 57
        Kontrolne_strelby_brokLabel.Text = "Kontrolné streľby brok:"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(58, 753)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(75, 13)
        Gulova_zbranLabel.TabIndex = 59
        Gulova_zbranLabel.Text = "Guľová zbraň:"
        '
        'Kontrolne_strelby_gulova_zbranLabel
        '
        Kontrolne_strelby_gulova_zbranLabel.AutoSize = True
        Kontrolne_strelby_gulova_zbranLabel.Location = New System.Drawing.Point(58, 782)
        Kontrolne_strelby_gulova_zbranLabel.Name = "Kontrolne_strelby_gulova_zbranLabel"
        Kontrolne_strelby_gulova_zbranLabel.Size = New System.Drawing.Size(156, 13)
        Kontrolne_strelby_gulova_zbranLabel.TabIndex = 61
        Kontrolne_strelby_gulova_zbranLabel.Text = "Kontrolné streľby guľová zbraň:"
        '
        'Vyznamenanie_IIILabel
        '
        Vyznamenanie_IIILabel.AutoSize = True
        Vyznamenanie_IIILabel.Location = New System.Drawing.Point(52, 855)
        Vyznamenanie_IIILabel.Name = "Vyznamenanie_IIILabel"
        Vyznamenanie_IIILabel.Size = New System.Drawing.Size(91, 13)
        Vyznamenanie_IIILabel.TabIndex = 63
        Vyznamenanie_IIILabel.Text = "Vyznamenanie III:"
        '
        'Vyznamenanie_IILabel
        '
        Vyznamenanie_IILabel.AutoSize = True
        Vyznamenanie_IILabel.Location = New System.Drawing.Point(52, 881)
        Vyznamenanie_IILabel.Name = "Vyznamenanie_IILabel"
        Vyznamenanie_IILabel.Size = New System.Drawing.Size(88, 13)
        Vyznamenanie_IILabel.TabIndex = 65
        Vyznamenanie_IILabel.Text = "Vyznamenanie II:"
        '
        'Vyznamenanie_ILabel
        '
        Vyznamenanie_ILabel.AutoSize = True
        Vyznamenanie_ILabel.Location = New System.Drawing.Point(52, 907)
        Vyznamenanie_ILabel.Name = "Vyznamenanie_ILabel"
        Vyznamenanie_ILabel.Size = New System.Drawing.Size(85, 13)
        Vyznamenanie_ILabel.TabIndex = 67
        Vyznamenanie_ILabel.Text = "Vyznamenanie I:"
        '
        'Vyznamenanie_ZKLabel
        '
        Vyznamenanie_ZKLabel.AutoSize = True
        Vyznamenanie_ZKLabel.Location = New System.Drawing.Point(52, 933)
        Vyznamenanie_ZKLabel.Name = "Vyznamenanie_ZKLabel"
        Vyznamenanie_ZKLabel.Size = New System.Drawing.Size(96, 13)
        Vyznamenanie_ZKLabel.TabIndex = 69
        Vyznamenanie_ZKLabel.Text = "Vyznamenanie ZK:"
        '
        'Vyznamenanie_ineLabel
        '
        Vyznamenanie_ineLabel.AutoSize = True
        Vyznamenanie_ineLabel.Location = New System.Drawing.Point(52, 959)
        Vyznamenanie_ineLabel.Name = "Vyznamenanie_ineLabel"
        Vyznamenanie_ineLabel.Size = New System.Drawing.Size(96, 13)
        Vyznamenanie_ineLabel.TabIndex = 71
        Vyznamenanie_ineLabel.Text = "Vyznamenanie ine:"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(540, 855)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(78, 13)
        Udelene_trestyLabel.TabIndex = 73
        Udelene_trestyLabel.Text = "Udelené tresty:"
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(540, 910)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(59, 13)
        PoznamkyLabel.TabIndex = 75
        PoznamkyLabel.Text = "Poznámky:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(307, 122)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(91, 13)
        Datum_narodeniaLabel.TabIndex = 79
        Datum_narodeniaLabel.Text = "Dátum narodenia:"
        '
        'NarodnostLabel
        '
        NarodnostLabel.AutoSize = True
        NarodnostLabel.Location = New System.Drawing.Point(316, 297)
        NarodnostLabel.Name = "NarodnostLabel"
        NarodnostLabel.Size = New System.Drawing.Size(60, 13)
        NarodnostLabel.TabIndex = 80
        NarodnostLabel.Text = "Národnosť:"
        '
        'Spz_evidenciaDataSet
        '
        Me.Spz_evidenciaDataSet.DataSetName = "spz_evidenciaDataSet"
        Me.Spz_evidenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClenoviaBindingSource
        '
        Me.ClenoviaBindingSource.DataMember = "clenovia"
        Me.ClenoviaBindingSource.DataSource = Me.Spz_evidenciaDataSet
        '
        'ClenoviaTableAdapter
        '
        Me.ClenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clenoviaTableAdapter = Me.ClenoviaTableAdapter
        Me.TableAdapterManager.statna_prislusnostTableAdapter = Nothing
        Me.TableAdapterManager.titulTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spz_evidenciaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zdruzenieTableAdapter = Nothing
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
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(760, 25)
        Me.ClenoviaBindingNavigator.TabIndex = 0
        Me.ClenoviaBindingNavigator.Text = "BindingNavigator1"
        Me.ClenoviaBindingNavigator.Visible = False
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
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(191, 56)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(146, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "priezvisko", True))
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(406, 55)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 8
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(88, 115)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 10
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_narodenia", True))
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(108, 182)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_narodenia", True))
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(421, 182)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "bydlisko", True))
        Me.BydliskoTextBox.Location = New System.Drawing.Point(108, 231)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BydliskoTextBox.TabIndex = 16
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(421, 231)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PscTextBox.TabIndex = 18
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(108, 343)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 22
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_pl", True))
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(108, 398)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_plTextBox.TabIndex = 26
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_zp", True))
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(108, 439)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_clenskeho_preukazu_spz", True))
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(176, 502)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_dokladu_clenske", True))
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(176, 569)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Miesto_skusky_z__polovnictvaTextBox
        '
        Me.Miesto_skusky_z__polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_z _polovnictva", True))
        Me.Miesto_skusky_z__polovnictvaTextBox.Location = New System.Drawing.Point(543, 632)
        Me.Miesto_skusky_z__polovnictvaTextBox.Name = "Miesto_skusky_z__polovnictvaTextBox"
        Me.Miesto_skusky_z__polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_z__polovnictvaTextBox.TabIndex = 46
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_pre_polovnych_hospodarov", True))
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(751, 745)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Miesto_vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_vyzsia_skuska_z_polovnictva", True))
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(751, 797)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Name = "Miesto_vyzsia_skuska_z_polovnictvaTextBox"
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 54
        '
        'Brokova_zbranCheckBox
        '
        Me.Brokova_zbranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClenoviaBindingSource, "brokova_zbran", True))
        Me.Brokova_zbranCheckBox.Location = New System.Drawing.Point(269, 692)
        Me.Brokova_zbranCheckBox.Name = "Brokova_zbranCheckBox"
        Me.Brokova_zbranCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Brokova_zbranCheckBox.TabIndex = 56
        Me.Brokova_zbranCheckBox.UseVisualStyleBackColor = True
        '
        'Gulova_zbranCheckBox
        '
        Me.Gulova_zbranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClenoviaBindingSource, "gulova_zbran", True))
        Me.Gulova_zbranCheckBox.Location = New System.Drawing.Point(269, 748)
        Me.Gulova_zbranCheckBox.Name = "Gulova_zbranCheckBox"
        Me.Gulova_zbranCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Gulova_zbranCheckBox.TabIndex = 60
        Me.Gulova_zbranCheckBox.UseVisualStyleBackColor = True
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "udelene_tresty", True))
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(751, 852)
        Me.Udelene_trestyTextBox.Multiline = True
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(200, 42)
        Me.Udelene_trestyTextBox.TabIndex = 74
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "poznamky", True))
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(751, 903)
        Me.PoznamkyTextBox.Multiline = True
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(200, 60)
        Me.PoznamkyTextBox.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Koniec"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Ulož"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TitulComboBox
        '
        Me.TitulComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul", True))
        Me.TitulComboBox.DataSource = Me.TitulBindingSource
        Me.TitulComboBox.DisplayMember = "skratka"
        Me.TitulComboBox.FormattingEnabled = True
        Me.TitulComboBox.Location = New System.Drawing.Point(44, 55)
        Me.TitulComboBox.Name = "TitulComboBox"
        Me.TitulComboBox.Size = New System.Drawing.Size(79, 21)
        Me.TitulComboBox.TabIndex = 79
        Me.TitulComboBox.ValueMember = "skratka"
        '
        'TitulBindingSource
        '
        Me.TitulBindingSource.DataMember = "titul"
        Me.TitulBindingSource.DataSource = Me.TitulDataSet1BindingSource
        '
        'TitulDataSet1BindingSource
        '
        Me.TitulDataSet1BindingSource.DataSource = Me.TitulDataSet1
        Me.TitulDataSet1BindingSource.Position = 0
        '
        'TitulDataSet1
        '
        Me.TitulDataSet1.DataSetName = "titulDataSet1"
        Me.TitulDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitulTableAdapter
        '
        Me.TitulTableAdapter.ClearBeforeFill = True
        '
        'Statna_prislusnostComboBox
        '
        Me.Statna_prislusnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "statna_prislusnost", True))
        Me.Statna_prislusnostComboBox.DataSource = Me.StatnaprislusnostBindingSource
        Me.Statna_prislusnostComboBox.DisplayMember = "nazov"
        Me.Statna_prislusnostComboBox.FormattingEnabled = True
        Me.Statna_prislusnostComboBox.Location = New System.Drawing.Point(114, 289)
        Me.Statna_prislusnostComboBox.Name = "Statna_prislusnostComboBox"
        Me.Statna_prislusnostComboBox.Size = New System.Drawing.Size(194, 21)
        Me.Statna_prislusnostComboBox.TabIndex = 82
        Me.Statna_prislusnostComboBox.ValueMember = "nazov"
        '
        'StatnaprislusnostBindingSource
        '
        Me.StatnaprislusnostBindingSource.DataMember = "statna_prislusnost"
        Me.StatnaprislusnostBindingSource.DataSource = Me.StatnaprislusnostDataSet1BindingSource
        '
        'StatnaprislusnostDataSet1BindingSource
        '
        Me.StatnaprislusnostDataSet1BindingSource.DataSource = Me.Statna_prislusnostDataSet1
        Me.StatnaprislusnostDataSet1BindingSource.Position = 0
        '
        'Statna_prislusnostDataSet1
        '
        Me.Statna_prislusnostDataSet1.DataSetName = "statna_prislusnostDataSet1"
        Me.Statna_prislusnostDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Statna_prislusnostTableAdapter
        '
        Me.Statna_prislusnostTableAdapter.ClearBeforeFill = True
        '
        'NarodnostComboBox
        '
        Me.NarodnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "narodnost", True))
        Me.NarodnostComboBox.DataSource = Me.NarodnostBindingSource
        Me.NarodnostComboBox.DisplayMember = "nazov"
        Me.NarodnostComboBox.FormattingEnabled = True
        Me.NarodnostComboBox.Location = New System.Drawing.Point(421, 289)
        Me.NarodnostComboBox.Name = "NarodnostComboBox"
        Me.NarodnostComboBox.Size = New System.Drawing.Size(200, 21)
        Me.NarodnostComboBox.TabIndex = 83
        Me.NarodnostComboBox.ValueMember = "nazov"
        '
        'NarodnostBindingSource
        '
        Me.NarodnostBindingSource.DataMember = "narodnost"
        Me.NarodnostBindingSource.DataSource = Me.NarodnostDataSetBindingSource
        '
        'NarodnostDataSetBindingSource
        '
        Me.NarodnostDataSetBindingSource.DataSource = Me.NarodnostDataSet
        Me.NarodnostDataSetBindingSource.Position = 0
        '
        'NarodnostDataSet
        '
        Me.NarodnostDataSet.DataSetName = "narodnostDataSet"
        Me.NarodnostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NarodnostTableAdapter
        '
        Me.NarodnostTableAdapter.ClearBeforeFill = True
        '
        'ZdruzenieBindingSource
        '
        Me.ZdruzenieBindingSource.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource.DataSource = Me.ZdruzenieDataSet
        '
        'ZdruzenieDataSet
        '
        Me.ZdruzenieDataSet.DataSetName = "zdruzenieDataSet"
        Me.ZdruzenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzenieTableAdapter
        '
        Me.ZdruzenieTableAdapter.ClearBeforeFill = True
        '
        'Clen_pzComboBox
        '
        Me.Clen_pzComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_pz", True))
        Me.Clen_pzComboBox.DataSource = Me.ZdruzenieBindingSource1
        Me.Clen_pzComboBox.DisplayMember = "nazov"
        Me.Clen_pzComboBox.FormattingEnabled = True
        Me.Clen_pzComboBox.Location = New System.Drawing.Point(469, 576)
        Me.Clen_pzComboBox.Name = "Clen_pzComboBox"
        Me.Clen_pzComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Clen_pzComboBox.TabIndex = 84
        Me.Clen_pzComboBox.ValueMember = "nazov"
        '
        'ZdruzenieBindingSource1
        '
        Me.ZdruzenieBindingSource1.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource1.DataSource = Me.ZdruzenieDataSetBindingSource
        '
        'ZdruzenieDataSetBindingSource
        '
        Me.ZdruzenieDataSetBindingSource.DataSource = Me.ZdruzenieDataSet
        Me.ZdruzenieDataSetBindingSource.Position = 0
        '
        'Datum_narodeniaTextBox
        '
        Me.Datum_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_narodenia", True))
        Me.Datum_narodeniaTextBox.Location = New System.Drawing.Point(406, 115)
        Me.Datum_narodeniaTextBox.Name = "Datum_narodeniaTextBox"
        Me.Datum_narodeniaTextBox.Size = New System.Drawing.Size(168, 20)
        Me.Datum_narodeniaTextBox.TabIndex = 85
        Me.Datum_narodeniaTextBox.Tag = ""
        '
        'Datum_vydania_opTextBox
        '
        Me.Datum_vydania_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_op", True))
        Me.Datum_vydania_opTextBox.Location = New System.Drawing.Point(421, 346)
        Me.Datum_vydania_opTextBox.Name = "Datum_vydania_opTextBox"
        Me.Datum_vydania_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_opTextBox.TabIndex = 86
        '
        'Datum_vydania_plTextBox
        '
        Me.Datum_vydania_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_pl", True))
        Me.Datum_vydania_plTextBox.Location = New System.Drawing.Point(421, 398)
        Me.Datum_vydania_plTextBox.Name = "Datum_vydania_plTextBox"
        Me.Datum_vydania_plTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_plTextBox.TabIndex = 87
        '
        'Datum_vydania_zpTextBox
        '
        Me.Datum_vydania_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_zp", True))
        Me.Datum_vydania_zpTextBox.Location = New System.Drawing.Point(420, 446)
        Me.Datum_vydania_zpTextBox.Name = "Datum_vydania_zpTextBox"
        Me.Datum_vydania_zpTextBox.Size = New System.Drawing.Size(201, 20)
        Me.Datum_vydania_zpTextBox.TabIndex = 88
        '
        'Clen_spz_odTextBox
        '
        Me.Clen_spz_odTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_spz_od", True))
        Me.Clen_spz_odTextBox.Location = New System.Drawing.Point(176, 539)
        Me.Clen_spz_odTextBox.Name = "Clen_spz_odTextBox"
        Me.Clen_spz_odTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Clen_spz_odTextBox.TabIndex = 89
        '
        'Clenske_doTextBox
        '
        Me.Clenske_doTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clenske_do", True))
        Me.Clenske_doTextBox.Location = New System.Drawing.Point(470, 539)
        Me.Clenske_doTextBox.Name = "Clenske_doTextBox"
        Me.Clenske_doTextBox.Size = New System.Drawing.Size(151, 20)
        Me.Clenske_doTextBox.TabIndex = 90
        '
        'Skuska_z_polovnictvaTextBox
        '
        Me.Skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_z_polovnictva", True))
        Me.Skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(176, 635)
        Me.Skuska_z_polovnictvaTextBox.Name = "Skuska_z_polovnictvaTextBox"
        Me.Skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skuska_z_polovnictvaTextBox.TabIndex = 91
        '
        'Kontrolne_strelby_brokTextBox
        '
        Me.Kontrolne_strelby_brokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_brok", True))
        Me.Kontrolne_strelby_brokTextBox.Location = New System.Drawing.Point(269, 726)
        Me.Kontrolne_strelby_brokTextBox.Name = "Kontrolne_strelby_brokTextBox"
        Me.Kontrolne_strelby_brokTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Kontrolne_strelby_brokTextBox.TabIndex = 92
        '
        'Kontrolne_strelby_gulova_zbranTextBox
        '
        Me.Kontrolne_strelby_gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_gulova_zbran", True))
        Me.Kontrolne_strelby_gulova_zbranTextBox.Location = New System.Drawing.Point(269, 782)
        Me.Kontrolne_strelby_gulova_zbranTextBox.Name = "Kontrolne_strelby_gulova_zbranTextBox"
        Me.Kontrolne_strelby_gulova_zbranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Kontrolne_strelby_gulova_zbranTextBox.TabIndex = 93
        '
        'Skuska_pre_polovnych_hospodarovTextBox
        '
        Me.Skuska_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_pre_polovnych_hospodarov", True))
        Me.Skuska_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(751, 720)
        Me.Skuska_pre_polovnych_hospodarovTextBox.Name = "Skuska_pre_polovnych_hospodarovTextBox"
        Me.Skuska_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Skuska_pre_polovnych_hospodarovTextBox.TabIndex = 94
        '
        'Vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyzsia_skuska_z_polovnictva", True))
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(751, 771)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Name = "Vyzsia_skuska_z_polovnictvaTextBox"
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 95
        '
        'Vyznamenanie_IIITextBox
        '
        Me.Vyznamenanie_IIITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_III", True))
        Me.Vyznamenanie_IIITextBox.Location = New System.Drawing.Point(263, 855)
        Me.Vyznamenanie_IIITextBox.Name = "Vyznamenanie_IIITextBox"
        Me.Vyznamenanie_IIITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_IIITextBox.TabIndex = 96
        '
        'Vyznamenanie_IITextBox
        '
        Me.Vyznamenanie_IITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_II", True))
        Me.Vyznamenanie_IITextBox.Location = New System.Drawing.Point(263, 878)
        Me.Vyznamenanie_IITextBox.Name = "Vyznamenanie_IITextBox"
        Me.Vyznamenanie_IITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Vyznamenanie_IITextBox.TabIndex = 97
        '
        'Vyznamenanie_ITextBox
        '
        Me.Vyznamenanie_ITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_I", True))
        Me.Vyznamenanie_ITextBox.Location = New System.Drawing.Point(263, 903)
        Me.Vyznamenanie_ITextBox.Name = "Vyznamenanie_ITextBox"
        Me.Vyznamenanie_ITextBox.Size = New System.Drawing.Size(201, 20)
        Me.Vyznamenanie_ITextBox.TabIndex = 98
        '
        'Vyznamenanie_ZKTextBox
        '
        Me.Vyznamenanie_ZKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ZK", True))
        Me.Vyznamenanie_ZKTextBox.Location = New System.Drawing.Point(263, 930)
        Me.Vyznamenanie_ZKTextBox.Name = "Vyznamenanie_ZKTextBox"
        Me.Vyznamenanie_ZKTextBox.Size = New System.Drawing.Size(201, 20)
        Me.Vyznamenanie_ZKTextBox.TabIndex = 99
        '
        'Vyznamenanie_ineTextBox
        '
        Me.Vyznamenanie_ineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ine", True))
        Me.Vyznamenanie_ineTextBox.Location = New System.Drawing.Point(263, 952)
        Me.Vyznamenanie_ineTextBox.Name = "Vyznamenanie_ineTextBox"
        Me.Vyznamenanie_ineTextBox.Size = New System.Drawing.Size(201, 20)
        Me.Vyznamenanie_ineTextBox.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(581, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "DD.MM.RRRR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(638, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "DD.MM.RRRR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(638, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "DD.MM.RRRR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(638, 453)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "DD.MM.RRRR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(627, 546)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "DD.MM.RRRR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 710)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "DD.MM.RRRR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(390, 766)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "DD.MM.RRRR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(872, 697)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "DD.MM.RRRR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(384, 839)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "DD.MM.RRRR"
        '
        'novy_clen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1292, 812)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Vyznamenanie_ineTextBox)
        Me.Controls.Add(Me.Vyznamenanie_ZKTextBox)
        Me.Controls.Add(Me.Vyznamenanie_ITextBox)
        Me.Controls.Add(Me.Vyznamenanie_IITextBox)
        Me.Controls.Add(Me.Vyznamenanie_IIITextBox)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Me.Kontrolne_strelby_gulova_zbranTextBox)
        Me.Controls.Add(Me.Kontrolne_strelby_brokTextBox)
        Me.Controls.Add(Me.Skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Clenske_doTextBox)
        Me.Controls.Add(Me.Clen_spz_odTextBox)
        Me.Controls.Add(Me.Datum_vydania_zpTextBox)
        Me.Controls.Add(Me.Datum_vydania_plTextBox)
        Me.Controls.Add(Me.Datum_vydania_opTextBox)
        Me.Controls.Add(Me.Datum_narodeniaTextBox)
        Me.Controls.Add(Me.Clen_pzComboBox)
        Me.Controls.Add(Me.NarodnostComboBox)
        Me.Controls.Add(Me.Statna_prislusnostComboBox)
        Me.Controls.Add(NarodnostLabel)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.TitulComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TitulLabel)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
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
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Datum_vydania_opLabel)
        Me.Controls.Add(Cislo_plLabel)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(Datum_vydania_plLabel)
        Me.Controls.Add(Cislo_zpLabel)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Datum_vydania_zpLabel)
        Me.Controls.Add(Cislo_clenskeho_preukazu_spzLabel)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Clen_spz_odLabel)
        Me.Controls.Add(Clenske_doLabel)
        Me.Controls.Add(Cislo_dokladu_clenskeLabel)
        Me.Controls.Add(Me.Cislo_dokladu_clenskeTextBox)
        Me.Controls.Add(Clen_pzLabel)
        Me.Controls.Add(Skuska_z_polovnictvaLabel)
        Me.Controls.Add(Miesto_skusky_z__polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z__polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Miesto_skusky_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Miesto_vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Me.Brokova_zbranCheckBox)
        Me.Controls.Add(Kontrolne_strelby_brokLabel)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Me.Gulova_zbranCheckBox)
        Me.Controls.Add(Kontrolne_strelby_gulova_zbranLabel)
        Me.Controls.Add(Vyznamenanie_IIILabel)
        Me.Controls.Add(Vyznamenanie_IILabel)
        Me.Controls.Add(Vyznamenanie_ILabel)
        Me.Controls.Add(Vyznamenanie_ZKLabel)
        Me.Controls.Add(Vyznamenanie_ineLabel)
        Me.Controls.Add(Udelene_trestyLabel)
        Me.Controls.Add(Me.Udelene_trestyTextBox)
        Me.Controls.Add(PoznamkyLabel)
        Me.Controls.Add(Me.PoznamkyTextBox)
        Me.Controls.Add(Me.ClenoviaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "novy_clen"
        Me.Text = "novy_clen"
        CType(Me.Spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
        CType(Me.TitulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatnaprislusnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatnaprislusnostDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statna_prislusnostDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NarodnostDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Spz_evidenciaDataSet As evidencia_spz.spz_evidenciaDataSet
    Friend WithEvents ClenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClenoviaTableAdapter As evidencia_spz.spz_evidenciaDataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spz_evidenciaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_clenskeho_preukazu_spzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_dokladu_clenskeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_z__polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brokova_zbranCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Gulova_zbranCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TitulComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TitulDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitulDataSet1 As evidencia_spz.titulDataSet1
    Friend WithEvents TitulBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitulTableAdapter As evidencia_spz.titulDataSet1TableAdapters.titulTableAdapter
    Friend WithEvents Statna_prislusnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatnaprislusnostDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostDataSet1 As evidencia_spz.statna_prislusnostDataSet1
    Friend WithEvents StatnaprislusnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statna_prislusnostTableAdapter As evidencia_spz.statna_prislusnostDataSet1TableAdapters.statna_prislusnostTableAdapter
    Friend WithEvents NarodnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NarodnostDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NarodnostDataSet As evidencia_spz.narodnostDataSet
    Friend WithEvents NarodnostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NarodnostTableAdapter As evidencia_spz.narodnostDataSetTableAdapters.narodnostTableAdapter
    Friend WithEvents ZdruzenieDataSet As evidencia_spz.zdruzenieDataSet
    Friend WithEvents ZdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieTableAdapter As evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
    Friend WithEvents Clen_pzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ZdruzenieBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Datum_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_spz_odTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clenske_doTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IIITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ZKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
