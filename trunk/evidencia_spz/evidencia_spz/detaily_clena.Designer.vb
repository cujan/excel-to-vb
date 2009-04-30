<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detaily_clena
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
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim Miesto_narodeniaLabel As System.Windows.Forms.Label
        Dim Okres_narodeniaLabel As System.Windows.Forms.Label
        Dim BydliskoLabel As System.Windows.Forms.Label
        Dim Statna_prislusnostLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim Datum_vydania_opLabel As System.Windows.Forms.Label
        Dim Cislo_plLabel As System.Windows.Forms.Label
        Dim Datum_vydania_plLabel As System.Windows.Forms.Label
        Dim Cislo_zpLabel As System.Windows.Forms.Label
        Dim Cislo_clenskeho_preukazu_spzLabel As System.Windows.Forms.Label
        Dim Clen_spz_odLabel As System.Windows.Forms.Label
        Dim Clenske_doLabel As System.Windows.Forms.Label
        Dim Cislo_dokladu_clenskeLabel As System.Windows.Forms.Label
        Dim Clen_pzLabel As System.Windows.Forms.Label
        Dim Skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Miesto_skusky_z__polovnictvaLabel As System.Windows.Forms.Label
        Dim Skuska_pre_polovnych_hospodarovLabel As System.Windows.Forms.Label
        Dim Vyzsia_skuska_z_polovnictvaLabel As System.Windows.Forms.Label
        Dim Brokova_zbranLabel As System.Windows.Forms.Label
        Dim Kontrolne_strelby_brokLabel As System.Windows.Forms.Label
        Dim Gulova_zbranLabel As System.Windows.Forms.Label
        Dim Udelene_trestyLabel As System.Windows.Forms.Label
        Dim PoznamkyLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim NarodnostLabel As System.Windows.Forms.Label
        Dim Okres_bydliskaLabel As System.Windows.Forms.Label
        Dim Najv_vyznamenanieLabel As System.Windows.Forms.Label
        Dim Vyznamenany_kedyLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detaily_clena))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Prehlad_clenovDataSet = New evidencia_spz.prehlad_clenovDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.prehlad_clenovDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager
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
        Me.Titul_predTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Statna_prislusnostTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_opTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_plTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_plTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_zpTextBox = New System.Windows.Forms.TextBox
        Me.Datum_vydania_zpTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_clenskeho_preukazu_spzTextBox = New System.Windows.Forms.TextBox
        Me.Clen_spz_odTextBox = New System.Windows.Forms.TextBox
        Me.Clenske_doTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_dokladu_clenskeTextBox = New System.Windows.Forms.TextBox
        Me.Clen_pzTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_z__polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Brokova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokTextBox = New System.Windows.Forms.TextBox
        Me.Gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.NarodnostTextBox = New System.Windows.Forms.TextBox
        Me.Okres_bydliskaTextBox = New System.Windows.Forms.TextBox
        Me.Najv_vyznamenanieTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenany_kedyTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.Titul_zaTextBox = New System.Windows.Forms.TextBox
        Me.upravbutton = New System.Windows.Forms.Button
        Me.ulozButton = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Label5 = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Miesto_narodeniaLabel = New System.Windows.Forms.Label
        Okres_narodeniaLabel = New System.Windows.Forms.Label
        BydliskoLabel = New System.Windows.Forms.Label
        Statna_prislusnostLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        Datum_vydania_opLabel = New System.Windows.Forms.Label
        Cislo_plLabel = New System.Windows.Forms.Label
        Datum_vydania_plLabel = New System.Windows.Forms.Label
        Cislo_zpLabel = New System.Windows.Forms.Label
        Cislo_clenskeho_preukazu_spzLabel = New System.Windows.Forms.Label
        Clen_spz_odLabel = New System.Windows.Forms.Label
        Clenske_doLabel = New System.Windows.Forms.Label
        Cislo_dokladu_clenskeLabel = New System.Windows.Forms.Label
        Clen_pzLabel = New System.Windows.Forms.Label
        Skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Miesto_skusky_z__polovnictvaLabel = New System.Windows.Forms.Label
        Skuska_pre_polovnych_hospodarovLabel = New System.Windows.Forms.Label
        Vyzsia_skuska_z_polovnictvaLabel = New System.Windows.Forms.Label
        Brokova_zbranLabel = New System.Windows.Forms.Label
        Kontrolne_strelby_brokLabel = New System.Windows.Forms.Label
        Gulova_zbranLabel = New System.Windows.Forms.Label
        Udelene_trestyLabel = New System.Windows.Forms.Label
        PoznamkyLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        NarodnostLabel = New System.Windows.Forms.Label
        Okres_bydliskaLabel = New System.Windows.Forms.Label
        Najv_vyznamenanieLabel = New System.Windows.Forms.Label
        Vyznamenany_kedyLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        CType(Me.Prehlad_clenovDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClenoviaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(339, 71)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(22, 13)
        Rodne_cisloLabel.TabIndex = 11
        Rodne_cisloLabel.Text = "RČ"
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(125, 101)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(62, 13)
        Miesto_narodeniaLabel.TabIndex = 13
        Miesto_narodeniaLabel.Text = "Narodený v"
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(326, 101)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(35, 13)
        Okres_narodeniaLabel.TabIndex = 15
        Okres_narodeniaLabel.Text = "Okres"
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(139, 180)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(46, 13)
        BydliskoLabel.TabIndex = 17
        BydliskoLabel.Text = "Bydlisko"
        '
        'Statna_prislusnostLabel
        '
        Statna_prislusnostLabel.AutoSize = True
        Statna_prislusnostLabel.Location = New System.Drawing.Point(112, 128)
        Statna_prislusnostLabel.Name = "Statna_prislusnostLabel"
        Statna_prislusnostLabel.Size = New System.Drawing.Size(75, 13)
        Statna_prislusnostLabel.TabIndex = 21
        Statna_prislusnostLabel.Text = "Št. príslušnosť"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(138, 154)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(49, 13)
        Cislo_opLabel.TabIndex = 23
        Cislo_opLabel.Text = "Číslo OP"
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(302, 154)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(59, 13)
        Datum_vydania_opLabel.TabIndex = 25
        Datum_vydania_opLabel.Text = "OP vydaný"
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(138, 299)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(47, 13)
        Cislo_plLabel.TabIndex = 27
        Cislo_plLabel.Text = "Číslo PL"
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(281, 299)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(78, 13)
        Datum_vydania_plLabel.TabIndex = 29
        Datum_vydania_plLabel.Text = "Dátum vydania"
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(137, 325)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(48, 13)
        Cislo_zpLabel.TabIndex = 31
        Cislo_zpLabel.Text = "Číslo ZP"
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(69, 351)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(116, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 35
        Cislo_clenskeho_preukazu_spzLabel.Text = "Číslo čl. preukazu SPZ"
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(292, 351)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(67, 13)
        Clen_spz_odLabel.TabIndex = 37
        Clen_spz_odLabel.Text = "Člen SPZ od"
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(299, 377)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(60, 13)
        Clenske_doLabel.TabIndex = 39
        Clenske_doLabel.Text = "Členské do"
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(71, 377)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(112, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 41
        Cislo_dokladu_clenskeLabel.Text = "Číslo dokladu členské"
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(136, 403)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(45, 13)
        Clen_pzLabel.TabIndex = 43
        Clen_pzLabel.Text = "Člen PZ"
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(72, 454)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(113, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 45
        Skuska_z_polovnictvaLabel.Text = "Skúška z poľovníctva"
        '
        'Miesto_skusky_z__polovnictvaLabel
        '
        Miesto_skusky_z__polovnictvaLabel.AutoSize = True
        Miesto_skusky_z__polovnictvaLabel.Location = New System.Drawing.Point(285, 454)
        Miesto_skusky_z__polovnictvaLabel.Name = "Miesto_skusky_z__polovnictvaLabel"
        Miesto_skusky_z__polovnictvaLabel.Size = New System.Drawing.Size(74, 13)
        Miesto_skusky_z__polovnictvaLabel.TabIndex = 47
        Miesto_skusky_z__polovnictvaLabel.Text = "Miesto skúšky"
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(43, 480)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(142, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 49
        Skuska_pre_polovnych_hospodarovLabel.Text = "Skúška pre poľ. hospodárov"
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(39, 506)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(144, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 53
        Vyzsia_skuska_z_polovnictvaLabel.Text = "Vyššia skúška z poľovníctva"
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(107, 531)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(76, 13)
        Brokova_zbranLabel.TabIndex = 57
        Brokova_zbranLabel.Text = "Broková zbraň"
        '
        'Kontrolne_strelby_brokLabel
        '
        Kontrolne_strelby_brokLabel.AutoSize = True
        Kontrolne_strelby_brokLabel.Location = New System.Drawing.Point(251, 531)
        Kontrolne_strelby_brokLabel.Name = "Kontrolne_strelby_brokLabel"
        Kontrolne_strelby_brokLabel.Size = New System.Drawing.Size(111, 13)
        Kontrolne_strelby_brokLabel.TabIndex = 59
        Kontrolne_strelby_brokLabel.Text = "Kontrolné streľby brok"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(109, 557)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(72, 13)
        Gulova_zbranLabel.TabIndex = 61
        Gulova_zbranLabel.Text = "Guľová zbraň"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(105, 634)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(75, 13)
        Udelene_trestyLabel.TabIndex = 75
        Udelene_trestyLabel.Text = "Udelené tresty"
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(127, 689)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(56, 13)
        PoznamkyLabel.TabIndex = 77
        PoznamkyLabel.Text = "Poznámky"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(99, 75)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(88, 13)
        Datum_narodeniaLabel.TabIndex = 79
        Datum_narodeniaLabel.Text = "Dátum narodenia"
        '
        'NarodnostLabel
        '
        NarodnostLabel.AutoSize = True
        NarodnostLabel.Location = New System.Drawing.Point(305, 128)
        NarodnostLabel.Name = "NarodnostLabel"
        NarodnostLabel.Size = New System.Drawing.Size(57, 13)
        NarodnostLabel.TabIndex = 81
        NarodnostLabel.Text = "Národnosť"
        '
        'Okres_bydliskaLabel
        '
        Okres_bydliskaLabel.AutoSize = True
        Okres_bydliskaLabel.Location = New System.Drawing.Point(326, 206)
        Okres_bydliskaLabel.Name = "Okres_bydliskaLabel"
        Okres_bydliskaLabel.Size = New System.Drawing.Size(35, 13)
        Okres_bydliskaLabel.TabIndex = 83
        Okres_bydliskaLabel.Text = "Okres"
        '
        'Najv_vyznamenanieLabel
        '
        Najv_vyznamenanieLabel.AutoSize = True
        Najv_vyznamenanieLabel.Location = New System.Drawing.Point(63, 608)
        Najv_vyznamenanieLabel.Name = "Najv_vyznamenanieLabel"
        Najv_vyznamenanieLabel.Size = New System.Drawing.Size(123, 13)
        Najv_vyznamenanieLabel.TabIndex = 85
        Najv_vyznamenanieLabel.Text = "Najvyššie vyznamenanie"
        '
        'Vyznamenany_kedyLabel
        '
        Vyznamenany_kedyLabel.AutoSize = True
        Vyznamenany_kedyLabel.Location = New System.Drawing.Point(319, 608)
        Vyznamenany_kedyLabel.Name = "Vyznamenany_kedyLabel"
        Vyznamenany_kedyLabel.Size = New System.Drawing.Size(38, 13)
        Vyznamenany_kedyLabel.TabIndex = 87
        Vyznamenany_kedyLabel.Text = "Dátum"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(144, 232)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(43, 13)
        TelefonLabel.TabIndex = 89
        TelefonLabel.Text = "Telefón"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(281, 325)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 93
        Label1.Text = "Dátum vydania"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(285, 480)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(74, 13)
        Label2.TabIndex = 94
        Label2.Text = "Miesto skúšky"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(285, 506)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 13)
        Label3.TabIndex = 95
        Label3.Text = "Miesto skúšky"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(249, 557)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(112, 13)
        Label4.TabIndex = 96
        Label4.Text = "Kontrolné streľby guľa"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(383, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zavrieť kartu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Prehlad_clenovDataSet
        '
        Me.Prehlad_clenovDataSet.DataSetName = "prehlad_clenovDataSet"
        Me.Prehlad_clenovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClenoviaBindingSource
        '
        Me.ClenoviaBindingSource.DataMember = "clenovia"
        Me.ClenoviaBindingSource.DataSource = Me.Prehlad_clenovDataSet
        '
        'ClenoviaTableAdapter
        '
        Me.ClenoviaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clenoviaTableAdapter = Me.ClenoviaTableAdapter
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(782, 25)
        Me.ClenoviaBindingNavigator.TabIndex = 2
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
        'Titul_predTextBox
        '
        Me.Titul_predTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul_pred", True))
        Me.Titul_predTextBox.Location = New System.Drawing.Point(126, 42)
        Me.Titul_predTextBox.Name = "Titul_predTextBox"
        Me.Titul_predTextBox.ReadOnly = True
        Me.Titul_predTextBox.Size = New System.Drawing.Size(59, 20)
        Me.Titul_predTextBox.TabIndex = 6
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(191, 42)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.ReadOnly = True
        Me.MenoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MenoTextBox.TabIndex = 8
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "priezvisko", True))
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(297, 42)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.ReadOnly = True
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(155, 20)
        Me.PriezviskoTextBox.TabIndex = 10
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(367, 68)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.ReadOnly = True
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(85, 20)
        Me.Rodne_cisloTextBox.TabIndex = 12
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_narodenia", True))
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(191, 98)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.ReadOnly = True
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 14
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_narodenia", True))
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(367, 94)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.ReadOnly = True
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(85, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 16
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "bydlisko", True))
        Me.BydliskoTextBox.Location = New System.Drawing.Point(191, 177)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.ReadOnly = True
        Me.BydliskoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.BydliskoTextBox.TabIndex = 18
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(191, 203)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.ReadOnly = True
        Me.PscTextBox.Size = New System.Drawing.Size(76, 20)
        Me.PscTextBox.TabIndex = 20
        '
        'Statna_prislusnostTextBox
        '
        Me.Statna_prislusnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "statna_prislusnost", True))
        Me.Statna_prislusnostTextBox.Location = New System.Drawing.Point(191, 125)
        Me.Statna_prislusnostTextBox.Name = "Statna_prislusnostTextBox"
        Me.Statna_prislusnostTextBox.ReadOnly = True
        Me.Statna_prislusnostTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Statna_prislusnostTextBox.TabIndex = 22
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(191, 151)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.ReadOnly = True
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Cislo_opTextBox.TabIndex = 24
        '
        'Datum_vydania_opTextBox
        '
        Me.Datum_vydania_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_op", True))
        Me.Datum_vydania_opTextBox.Location = New System.Drawing.Point(367, 151)
        Me.Datum_vydania_opTextBox.Name = "Datum_vydania_opTextBox"
        Me.Datum_vydania_opTextBox.ReadOnly = True
        Me.Datum_vydania_opTextBox.Size = New System.Drawing.Size(74, 20)
        Me.Datum_vydania_opTextBox.TabIndex = 26
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_pl", True))
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(189, 296)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.ReadOnly = True
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Cislo_plTextBox.TabIndex = 28
        '
        'Datum_vydania_plTextBox
        '
        Me.Datum_vydania_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_pl", True))
        Me.Datum_vydania_plTextBox.Location = New System.Drawing.Point(365, 296)
        Me.Datum_vydania_plTextBox.Name = "Datum_vydania_plTextBox"
        Me.Datum_vydania_plTextBox.ReadOnly = True
        Me.Datum_vydania_plTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Datum_vydania_plTextBox.TabIndex = 30
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_zp", True))
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(189, 322)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.ReadOnly = True
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Cislo_zpTextBox.TabIndex = 32
        '
        'Datum_vydania_zpTextBox
        '
        Me.Datum_vydania_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_zp", True))
        Me.Datum_vydania_zpTextBox.Location = New System.Drawing.Point(365, 322)
        Me.Datum_vydania_zpTextBox.Name = "Datum_vydania_zpTextBox"
        Me.Datum_vydania_zpTextBox.ReadOnly = True
        Me.Datum_vydania_zpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Datum_vydania_zpTextBox.TabIndex = 34
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_clenskeho_preukazu_spz", True))
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(189, 348)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.ReadOnly = True
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 36
        '
        'Clen_spz_odTextBox
        '
        Me.Clen_spz_odTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_spz_od", True))
        Me.Clen_spz_odTextBox.Location = New System.Drawing.Point(365, 348)
        Me.Clen_spz_odTextBox.Name = "Clen_spz_odTextBox"
        Me.Clen_spz_odTextBox.ReadOnly = True
        Me.Clen_spz_odTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Clen_spz_odTextBox.TabIndex = 38
        '
        'Clenske_doTextBox
        '
        Me.Clenske_doTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clenske_do", True))
        Me.Clenske_doTextBox.Location = New System.Drawing.Point(365, 377)
        Me.Clenske_doTextBox.Name = "Clenske_doTextBox"
        Me.Clenske_doTextBox.ReadOnly = True
        Me.Clenske_doTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Clenske_doTextBox.TabIndex = 40
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_dokladu_clenske", True))
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(189, 374)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.ReadOnly = True
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 42
        '
        'Clen_pzTextBox
        '
        Me.Clen_pzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_pz", True))
        Me.Clen_pzTextBox.Location = New System.Drawing.Point(189, 400)
        Me.Clen_pzTextBox.Name = "Clen_pzTextBox"
        Me.Clen_pzTextBox.ReadOnly = True
        Me.Clen_pzTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Clen_pzTextBox.TabIndex = 44
        '
        'Skuska_z_polovnictvaTextBox
        '
        Me.Skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_z_polovnictva", True))
        Me.Skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(189, 451)
        Me.Skuska_z_polovnictvaTextBox.Name = "Skuska_z_polovnictvaTextBox"
        Me.Skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Skuska_z_polovnictvaTextBox.TabIndex = 46
        '
        'Miesto_skusky_z__polovnictvaTextBox
        '
        Me.Miesto_skusky_z__polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_z _polovnictva", True))
        Me.Miesto_skusky_z__polovnictvaTextBox.Location = New System.Drawing.Point(365, 451)
        Me.Miesto_skusky_z__polovnictvaTextBox.Name = "Miesto_skusky_z__polovnictvaTextBox"
        Me.Miesto_skusky_z__polovnictvaTextBox.ReadOnly = True
        Me.Miesto_skusky_z__polovnictvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Miesto_skusky_z__polovnictvaTextBox.TabIndex = 48
        '
        'Skuska_pre_polovnych_hospodarovTextBox
        '
        Me.Skuska_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_pre_polovnych_hospodarov", True))
        Me.Skuska_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(189, 477)
        Me.Skuska_pre_polovnych_hospodarovTextBox.Name = "Skuska_pre_polovnych_hospodarovTextBox"
        Me.Skuska_pre_polovnych_hospodarovTextBox.ReadOnly = True
        Me.Skuska_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Skuska_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_pre_polovnych_hospodarov", True))
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(365, 477)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.ReadOnly = True
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 52
        '
        'Vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyzsia_skuska_z_polovnictva", True))
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(189, 503)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Name = "Vyzsia_skuska_z_polovnictvaTextBox"
        Me.Vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 54
        '
        'Miesto_vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_vyzsia_skuska_z_polovnictva", True))
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(365, 503)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Name = "Miesto_vyzsia_skuska_z_polovnictvaTextBox"
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.ReadOnly = True
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 56
        '
        'Brokova_zbranTextBox
        '
        Me.Brokova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "brokova_zbran", True))
        Me.Brokova_zbranTextBox.Location = New System.Drawing.Point(189, 528)
        Me.Brokova_zbranTextBox.Name = "Brokova_zbranTextBox"
        Me.Brokova_zbranTextBox.ReadOnly = True
        Me.Brokova_zbranTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Brokova_zbranTextBox.TabIndex = 58
        '
        'Kontrolne_strelby_brokTextBox
        '
        Me.Kontrolne_strelby_brokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_brok", True))
        Me.Kontrolne_strelby_brokTextBox.Location = New System.Drawing.Point(365, 528)
        Me.Kontrolne_strelby_brokTextBox.Name = "Kontrolne_strelby_brokTextBox"
        Me.Kontrolne_strelby_brokTextBox.ReadOnly = True
        Me.Kontrolne_strelby_brokTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kontrolne_strelby_brokTextBox.TabIndex = 60
        '
        'Gulova_zbranTextBox
        '
        Me.Gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "gulova_zbran", True))
        Me.Gulova_zbranTextBox.Location = New System.Drawing.Point(189, 554)
        Me.Gulova_zbranTextBox.Name = "Gulova_zbranTextBox"
        Me.Gulova_zbranTextBox.ReadOnly = True
        Me.Gulova_zbranTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Gulova_zbranTextBox.TabIndex = 62
        '
        'Kontrolne_strelby_gulova_zbranTextBox
        '
        Me.Kontrolne_strelby_gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_gulova_zbran", True))
        Me.Kontrolne_strelby_gulova_zbranTextBox.Location = New System.Drawing.Point(366, 554)
        Me.Kontrolne_strelby_gulova_zbranTextBox.Name = "Kontrolne_strelby_gulova_zbranTextBox"
        Me.Kontrolne_strelby_gulova_zbranTextBox.ReadOnly = True
        Me.Kontrolne_strelby_gulova_zbranTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kontrolne_strelby_gulova_zbranTextBox.TabIndex = 64
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "udelene_tresty", True))
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(187, 631)
        Me.Udelene_trestyTextBox.Multiline = True
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.ReadOnly = True
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(276, 52)
        Me.Udelene_trestyTextBox.TabIndex = 76
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "poznamky", True))
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(189, 689)
        Me.PoznamkyTextBox.Multiline = True
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.ReadOnly = True
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(274, 76)
        Me.PoznamkyTextBox.TabIndex = 78
        '
        'Datum_narodeniaTextBox
        '
        Me.Datum_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_narodenia", True))
        Me.Datum_narodeniaTextBox.Location = New System.Drawing.Point(191, 72)
        Me.Datum_narodeniaTextBox.Name = "Datum_narodeniaTextBox"
        Me.Datum_narodeniaTextBox.ReadOnly = True
        Me.Datum_narodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Datum_narodeniaTextBox.TabIndex = 80
        '
        'NarodnostTextBox
        '
        Me.NarodnostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "narodnost", True))
        Me.NarodnostTextBox.Location = New System.Drawing.Point(367, 125)
        Me.NarodnostTextBox.Name = "NarodnostTextBox"
        Me.NarodnostTextBox.ReadOnly = True
        Me.NarodnostTextBox.Size = New System.Drawing.Size(85, 20)
        Me.NarodnostTextBox.TabIndex = 82
        '
        'Okres_bydliskaTextBox
        '
        Me.Okres_bydliskaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_bydliska", True))
        Me.Okres_bydliskaTextBox.Location = New System.Drawing.Point(367, 203)
        Me.Okres_bydliskaTextBox.Name = "Okres_bydliskaTextBox"
        Me.Okres_bydliskaTextBox.ReadOnly = True
        Me.Okres_bydliskaTextBox.Size = New System.Drawing.Size(74, 20)
        Me.Okres_bydliskaTextBox.TabIndex = 84
        '
        'Najv_vyznamenanieTextBox
        '
        Me.Najv_vyznamenanieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "najv_vyznamenanie", True))
        Me.Najv_vyznamenanieTextBox.Location = New System.Drawing.Point(187, 605)
        Me.Najv_vyznamenanieTextBox.Name = "Najv_vyznamenanieTextBox"
        Me.Najv_vyznamenanieTextBox.ReadOnly = True
        Me.Najv_vyznamenanieTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Najv_vyznamenanieTextBox.TabIndex = 86
        '
        'Vyznamenany_kedyTextBox
        '
        Me.Vyznamenany_kedyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenany_kedy", True))
        Me.Vyznamenany_kedyTextBox.Location = New System.Drawing.Point(363, 605)
        Me.Vyznamenany_kedyTextBox.Name = "Vyznamenany_kedyTextBox"
        Me.Vyznamenany_kedyTextBox.ReadOnly = True
        Me.Vyznamenany_kedyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenany_kedyTextBox.TabIndex = 88
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(191, 229)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.ReadOnly = True
        Me.TelefonTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TelefonTextBox.TabIndex = 90
        '
        'Titul_zaTextBox
        '
        Me.Titul_zaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul_za", True))
        Me.Titul_zaTextBox.Location = New System.Drawing.Point(458, 42)
        Me.Titul_zaTextBox.Name = "Titul_zaTextBox"
        Me.Titul_zaTextBox.ReadOnly = True
        Me.Titul_zaTextBox.Size = New System.Drawing.Size(71, 20)
        Me.Titul_zaTextBox.TabIndex = 92
        '
        'upravbutton
        '
        Me.upravbutton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.upravbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upravbutton.Location = New System.Drawing.Point(179, 11)
        Me.upravbutton.Name = "upravbutton"
        Me.upravbutton.Size = New System.Drawing.Size(117, 23)
        Me.upravbutton.TabIndex = 97
        Me.upravbutton.Text = "Uprav detaily clena"
        Me.upravbutton.UseVisualStyleBackColor = False
        '
        'ulozButton
        '
        Me.ulozButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ulozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulozButton.Location = New System.Drawing.Point(302, 11)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 98
        Me.ulozButton.Text = "Uloz zmeny"
        Me.ulozButton.UseVisualStyleBackColor = False
        Me.ulozButton.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(782, 778)
        Me.ShapeContainer1.TabIndex = 99
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 59
        Me.LineShape2.X2 = 607
        Me.LineShape2.Y1 = 434
        Me.LineShape2.Y2 = 434
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 59
        Me.LineShape1.X2 = 607
        Me.LineShape1.Y1 = 270
        Me.LineShape1.Y2 = 270
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Psč:"
        '
        'detaily_clena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(782, 778)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.upravbutton)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Titul_predTextBox)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Miesto_narodeniaLabel)
        Me.Controls.Add(Me.Miesto_narodeniaTextBox)
        Me.Controls.Add(Okres_narodeniaLabel)
        Me.Controls.Add(Me.Okres_narodeniaTextBox)
        Me.Controls.Add(BydliskoLabel)
        Me.Controls.Add(Me.BydliskoTextBox)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(Statna_prislusnostLabel)
        Me.Controls.Add(Me.Statna_prislusnostTextBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Datum_vydania_opLabel)
        Me.Controls.Add(Me.Datum_vydania_opTextBox)
        Me.Controls.Add(Cislo_plLabel)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(Datum_vydania_plLabel)
        Me.Controls.Add(Me.Datum_vydania_plTextBox)
        Me.Controls.Add(Cislo_zpLabel)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Me.Datum_vydania_zpTextBox)
        Me.Controls.Add(Cislo_clenskeho_preukazu_spzLabel)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Clen_spz_odLabel)
        Me.Controls.Add(Me.Clen_spz_odTextBox)
        Me.Controls.Add(Clenske_doLabel)
        Me.Controls.Add(Me.Clenske_doTextBox)
        Me.Controls.Add(Cislo_dokladu_clenskeLabel)
        Me.Controls.Add(Me.Cislo_dokladu_clenskeTextBox)
        Me.Controls.Add(Clen_pzLabel)
        Me.Controls.Add(Me.Clen_pzTextBox)
        Me.Controls.Add(Skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Miesto_skusky_z__polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z__polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Me.Brokova_zbranTextBox)
        Me.Controls.Add(Kontrolne_strelby_brokLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_brokTextBox)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Me.Gulova_zbranTextBox)
        Me.Controls.Add(Me.Kontrolne_strelby_gulova_zbranTextBox)
        Me.Controls.Add(Udelene_trestyLabel)
        Me.Controls.Add(Me.Udelene_trestyTextBox)
        Me.Controls.Add(PoznamkyLabel)
        Me.Controls.Add(Me.PoznamkyTextBox)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaTextBox)
        Me.Controls.Add(NarodnostLabel)
        Me.Controls.Add(Me.NarodnostTextBox)
        Me.Controls.Add(Okres_bydliskaLabel)
        Me.Controls.Add(Me.Okres_bydliskaTextBox)
        Me.Controls.Add(Najv_vyznamenanieLabel)
        Me.Controls.Add(Me.Najv_vyznamenanieTextBox)
        Me.Controls.Add(Vyznamenany_kedyLabel)
        Me.Controls.Add(Me.Vyznamenany_kedyTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Me.Titul_zaTextBox)
        Me.Controls.Add(Me.ClenoviaBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "detaily_clena"
        Me.Text = "Detaily člena"
        CType(Me.Prehlad_clenovDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Prehlad_clenovDataSet As evidencia_spz.prehlad_clenovDataSet
    Friend WithEvents ClenoviaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClenoviaTableAdapter As evidencia_spz.prehlad_clenovDataSetTableAdapters.clenoviaTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.prehlad_clenovDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Titul_predTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Statna_prislusnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_plTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_vydania_zpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_clenskeho_preukazu_spzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_spz_odTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clenske_doTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_dokladu_clenskeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Clen_pzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_z__polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brokova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NarodnostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_bydliskaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Najv_vyznamenanieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenany_kedyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Titul_zaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents upravbutton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
