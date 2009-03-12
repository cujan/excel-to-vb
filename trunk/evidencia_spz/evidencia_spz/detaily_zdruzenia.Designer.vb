<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detaily_zdruzenia
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
        Dim NazovLabel As System.Windows.Forms.Label
        Dim SidloLabel As System.Windows.Forms.Label
        Dim PredsedaLabel As System.Windows.Forms.Label
        Dim Predseda_telefonLabel As System.Windows.Forms.Label
        Dim Polovnicky_hospodarLabel As System.Windows.Forms.Label
        Dim Polovnicky_hospodar_telefonLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim BankaLabel As System.Windows.Forms.Label
        Dim Cislo_uctuLabel As System.Windows.Forms.Label
        Dim Nazov_polovneho_reviruLabel As System.Windows.Forms.Label
        Dim Chovatelska_oblastLabel As System.Windows.Forms.Label
        Dim Cislo_reviruLabel As System.Windows.Forms.Label
        Dim VymeraLabel As System.Windows.Forms.Label
        Dim LesLabel As System.Windows.Forms.Label
        Dim JeleniaLabel As System.Windows.Forms.Label
        Dim SrnciaLabel As System.Windows.Forms.Label
        Dim DiviaciaLabel As System.Windows.Forms.Label
        Dim BazantLabel As System.Windows.Forms.Label
        Dim InaLabel As System.Windows.Forms.Label
        Dim StavaceLabel As System.Windows.Forms.Label
        Dim SliediceLabel As System.Windows.Forms.Label
        Dim Slovensky_kopovLabel As System.Windows.Forms.Label
        Dim Ostatne_duriceLabel As System.Windows.Forms.Label
        Dim BrlohareLabel As System.Windows.Forms.Label
        Dim FarbiareLabel As System.Windows.Forms.Label
        Dim Pes_jeleniaLabel As System.Windows.Forms.Label
        Dim Pes_diviaciaLabel As System.Windows.Forms.Label
        Dim Pes_srnciaLabel As System.Windows.Forms.Label
        Dim Pes_malaLabel As System.Windows.Forms.Label
        Dim Platnost_najomnej_zmluvy_doLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detaily_zdruzenia))
        Me.ZdruzenieDataSet = New evidencia_spz.zdruzenieDataSet
        Me.ZdruzenieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZdruzenieTableAdapter = New evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
        Me.TableAdapterManager = New evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager
        Me.ZdruzenieBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ZdruzenieBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.SidloTextBox = New System.Windows.Forms.TextBox
        Me.PredsedaTextBox = New System.Windows.Forms.TextBox
        Me.Predseda_telefonTextBox = New System.Windows.Forms.TextBox
        Me.Polovnicky_hospodarTextBox = New System.Windows.Forms.TextBox
        Me.Polovnicky_hospodar_telefonTextBox = New System.Windows.Forms.TextBox
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.BankaTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_uctuTextBox = New System.Windows.Forms.TextBox
        Me.Nazov_polovneho_reviruTextBox = New System.Windows.Forms.TextBox
        Me.Chovatelska_oblastTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_reviruTextBox = New System.Windows.Forms.TextBox
        Me.VymeraTextBox = New System.Windows.Forms.TextBox
        Me.LesTextBox = New System.Windows.Forms.TextBox
        Me.JeleniaTextBox = New System.Windows.Forms.TextBox
        Me.SrnciaTextBox = New System.Windows.Forms.TextBox
        Me.DiviaciaTextBox = New System.Windows.Forms.TextBox
        Me.BazantTextBox = New System.Windows.Forms.TextBox
        Me.InaTextBox = New System.Windows.Forms.TextBox
        Me.StavaceTextBox = New System.Windows.Forms.TextBox
        Me.SliediceTextBox = New System.Windows.Forms.TextBox
        Me.Slovensky_kopovTextBox = New System.Windows.Forms.TextBox
        Me.Ostatne_duriceTextBox = New System.Windows.Forms.TextBox
        Me.BrlohareTextBox = New System.Windows.Forms.TextBox
        Me.FarbiareTextBox = New System.Windows.Forms.TextBox
        Me.Pes_jeleniaTextBox = New System.Windows.Forms.TextBox
        Me.Pes_diviaciaTextBox = New System.Windows.Forms.TextBox
        Me.Pes_srnciaTextBox = New System.Windows.Forms.TextBox
        Me.Pes_malaTextBox = New System.Windows.Forms.TextBox
        Me.Platnost_najomnej_zmluvy_doDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.upravitButton = New System.Windows.Forms.Button
        Me.ulozButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        NazovLabel = New System.Windows.Forms.Label
        SidloLabel = New System.Windows.Forms.Label
        PredsedaLabel = New System.Windows.Forms.Label
        Predseda_telefonLabel = New System.Windows.Forms.Label
        Polovnicky_hospodarLabel = New System.Windows.Forms.Label
        Polovnicky_hospodar_telefonLabel = New System.Windows.Forms.Label
        IcoLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        BankaLabel = New System.Windows.Forms.Label
        Cislo_uctuLabel = New System.Windows.Forms.Label
        Nazov_polovneho_reviruLabel = New System.Windows.Forms.Label
        Chovatelska_oblastLabel = New System.Windows.Forms.Label
        Cislo_reviruLabel = New System.Windows.Forms.Label
        VymeraLabel = New System.Windows.Forms.Label
        LesLabel = New System.Windows.Forms.Label
        JeleniaLabel = New System.Windows.Forms.Label
        SrnciaLabel = New System.Windows.Forms.Label
        DiviaciaLabel = New System.Windows.Forms.Label
        BazantLabel = New System.Windows.Forms.Label
        InaLabel = New System.Windows.Forms.Label
        StavaceLabel = New System.Windows.Forms.Label
        SliediceLabel = New System.Windows.Forms.Label
        Slovensky_kopovLabel = New System.Windows.Forms.Label
        Ostatne_duriceLabel = New System.Windows.Forms.Label
        BrlohareLabel = New System.Windows.Forms.Label
        FarbiareLabel = New System.Windows.Forms.Label
        Pes_jeleniaLabel = New System.Windows.Forms.Label
        Pes_diviaciaLabel = New System.Windows.Forms.Label
        Pes_srnciaLabel = New System.Windows.Forms.Label
        Pes_malaLabel = New System.Windows.Forms.Label
        Platnost_najomnej_zmluvy_doLabel = New System.Windows.Forms.Label
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZdruzenieBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ZdruzenieBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(147, 59)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(38, 13)
        NazovLabel.TabIndex = 3
        NazovLabel.Text = "Názov"
        '
        'SidloLabel
        '
        SidloLabel.AutoSize = True
        SidloLabel.Location = New System.Drawing.Point(387, 59)
        SidloLabel.Name = "SidloLabel"
        SidloLabel.Size = New System.Drawing.Size(32, 13)
        SidloLabel.TabIndex = 5
        SidloLabel.Text = "Sídlo"
        '
        'PredsedaLabel
        '
        PredsedaLabel.AutoSize = True
        PredsedaLabel.Location = New System.Drawing.Point(133, 134)
        PredsedaLabel.Name = "PredsedaLabel"
        PredsedaLabel.Size = New System.Drawing.Size(52, 13)
        PredsedaLabel.TabIndex = 7
        PredsedaLabel.Text = "Predseda"
        '
        'Predseda_telefonLabel
        '
        Predseda_telefonLabel.AutoSize = True
        Predseda_telefonLabel.Location = New System.Drawing.Point(394, 134)
        Predseda_telefonLabel.Name = "Predseda_telefonLabel"
        Predseda_telefonLabel.Size = New System.Drawing.Size(25, 13)
        Predseda_telefonLabel.TabIndex = 9
        Predseda_telefonLabel.Text = "Tel."
        '
        'Polovnicky_hospodarLabel
        '
        Polovnicky_hospodarLabel.AutoSize = True
        Polovnicky_hospodarLabel.Location = New System.Drawing.Point(111, 160)
        Polovnicky_hospodarLabel.Name = "Polovnicky_hospodarLabel"
        Polovnicky_hospodarLabel.Size = New System.Drawing.Size(74, 13)
        Polovnicky_hospodarLabel.TabIndex = 11
        Polovnicky_hospodarLabel.Text = "Poľ. hospodár"
        '
        'Polovnicky_hospodar_telefonLabel
        '
        Polovnicky_hospodar_telefonLabel.AutoSize = True
        Polovnicky_hospodar_telefonLabel.Location = New System.Drawing.Point(394, 160)
        Polovnicky_hospodar_telefonLabel.Name = "Polovnicky_hospodar_telefonLabel"
        Polovnicky_hospodar_telefonLabel.Size = New System.Drawing.Size(25, 13)
        Polovnicky_hospodar_telefonLabel.TabIndex = 13
        Polovnicky_hospodar_telefonLabel.Text = "Tel."
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(160, 85)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(25, 13)
        IcoLabel.TabIndex = 15
        IcoLabel.Text = "IČO"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(394, 85)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(25, 13)
        DicLabel.TabIndex = 17
        DicLabel.Text = "DIČ"
        '
        'BankaLabel
        '
        BankaLabel.AutoSize = True
        BankaLabel.Location = New System.Drawing.Point(148, 109)
        BankaLabel.Name = "BankaLabel"
        BankaLabel.Size = New System.Drawing.Size(38, 13)
        BankaLabel.TabIndex = 19
        BankaLabel.Text = "Banka"
        '
        'Cislo_uctuLabel
        '
        Cislo_uctuLabel.AutoSize = True
        Cislo_uctuLabel.Location = New System.Drawing.Point(364, 109)
        Cislo_uctuLabel.Name = "Cislo_uctuLabel"
        Cislo_uctuLabel.Size = New System.Drawing.Size(55, 13)
        Cislo_uctuLabel.TabIndex = 21
        Cislo_uctuLabel.Text = "Číslo účtu"
        '
        'Nazov_polovneho_reviruLabel
        '
        Nazov_polovneho_reviruLabel.AutoSize = True
        Nazov_polovneho_reviruLabel.Location = New System.Drawing.Point(61, 206)
        Nazov_polovneho_reviruLabel.Name = "Nazov_polovneho_reviruLabel"
        Nazov_polovneho_reviruLabel.Size = New System.Drawing.Size(124, 13)
        Nazov_polovneho_reviruLabel.TabIndex = 23
        Nazov_polovneho_reviruLabel.Text = "Názov poľovného revíru"
        '
        'Chovatelska_oblastLabel
        '
        Chovatelska_oblastLabel.AutoSize = True
        Chovatelska_oblastLabel.Location = New System.Drawing.Point(86, 232)
        Chovatelska_oblastLabel.Name = "Chovatelska_oblastLabel"
        Chovatelska_oblastLabel.Size = New System.Drawing.Size(100, 13)
        Chovatelska_oblastLabel.TabIndex = 25
        Chovatelska_oblastLabel.Text = "Chovateľská oblasť"
        '
        'Cislo_reviruLabel
        '
        Cislo_reviruLabel.AutoSize = True
        Cislo_reviruLabel.Location = New System.Drawing.Point(357, 206)
        Cislo_reviruLabel.Name = "Cislo_reviruLabel"
        Cislo_reviruLabel.Size = New System.Drawing.Size(62, 13)
        Cislo_reviruLabel.TabIndex = 27
        Cislo_reviruLabel.Text = "Číslo revíru"
        '
        'VymeraLabel
        '
        VymeraLabel.AutoSize = True
        VymeraLabel.Location = New System.Drawing.Point(377, 232)
        VymeraLabel.Name = "VymeraLabel"
        VymeraLabel.Size = New System.Drawing.Size(42, 13)
        VymeraLabel.TabIndex = 29
        VymeraLabel.Text = "Výmera"
        '
        'LesLabel
        '
        LesLabel.AutoSize = True
        LesLabel.Location = New System.Drawing.Point(160, 258)
        LesLabel.Name = "LesLabel"
        LesLabel.Size = New System.Drawing.Size(24, 13)
        LesLabel.TabIndex = 31
        LesLabel.Text = "Les"
        '
        'JeleniaLabel
        '
        JeleniaLabel.AutoSize = True
        JeleniaLabel.Location = New System.Drawing.Point(145, 338)
        JeleniaLabel.Name = "JeleniaLabel"
        JeleniaLabel.Size = New System.Drawing.Size(40, 13)
        JeleniaLabel.TabIndex = 33
        JeleniaLabel.Text = "Jelenia"
        '
        'SrnciaLabel
        '
        SrnciaLabel.AutoSize = True
        SrnciaLabel.Location = New System.Drawing.Point(147, 364)
        SrnciaLabel.Name = "SrnciaLabel"
        SrnciaLabel.Size = New System.Drawing.Size(37, 13)
        SrnciaLabel.TabIndex = 35
        SrnciaLabel.Text = "Srnčia"
        '
        'DiviaciaLabel
        '
        DiviaciaLabel.AutoSize = True
        DiviaciaLabel.Location = New System.Drawing.Point(141, 390)
        DiviaciaLabel.Name = "DiviaciaLabel"
        DiviaciaLabel.Size = New System.Drawing.Size(45, 13)
        DiviaciaLabel.TabIndex = 37
        DiviaciaLabel.Text = "Diviačia"
        '
        'BazantLabel
        '
        BazantLabel.AutoSize = True
        BazantLabel.Location = New System.Drawing.Point(145, 416)
        BazantLabel.Name = "BazantLabel"
        BazantLabel.Size = New System.Drawing.Size(40, 13)
        BazantLabel.TabIndex = 39
        BazantLabel.Text = "Bažant"
        '
        'InaLabel
        '
        InaLabel.AutoSize = True
        InaLabel.Location = New System.Drawing.Point(160, 442)
        InaLabel.Name = "InaLabel"
        InaLabel.Size = New System.Drawing.Size(22, 13)
        InaLabel.TabIndex = 41
        InaLabel.Text = "Iná"
        '
        'StavaceLabel
        '
        StavaceLabel.AutoSize = True
        StavaceLabel.Location = New System.Drawing.Point(137, 525)
        StavaceLabel.Name = "StavaceLabel"
        StavaceLabel.Size = New System.Drawing.Size(47, 13)
        StavaceLabel.TabIndex = 43
        StavaceLabel.Text = "Stavače"
        '
        'SliediceLabel
        '
        SliediceLabel.AutoSize = True
        SliediceLabel.Location = New System.Drawing.Point(141, 551)
        SliediceLabel.Name = "SliediceLabel"
        SliediceLabel.Size = New System.Drawing.Size(44, 13)
        SliediceLabel.TabIndex = 45
        SliediceLabel.Text = "Sliediče"
        '
        'Slovensky_kopovLabel
        '
        Slovensky_kopovLabel.AutoSize = True
        Slovensky_kopovLabel.Location = New System.Drawing.Point(97, 577)
        Slovensky_kopovLabel.Name = "Slovensky_kopovLabel"
        Slovensky_kopovLabel.Size = New System.Drawing.Size(89, 13)
        Slovensky_kopovLabel.TabIndex = 47
        Slovensky_kopovLabel.Text = "Slovenský kopov"
        '
        'Ostatne_duriceLabel
        '
        Ostatne_duriceLabel.AutoSize = True
        Ostatne_duriceLabel.Location = New System.Drawing.Point(109, 603)
        Ostatne_duriceLabel.Name = "Ostatne_duriceLabel"
        Ostatne_duriceLabel.Size = New System.Drawing.Size(76, 13)
        Ostatne_duriceLabel.TabIndex = 49
        Ostatne_duriceLabel.Text = "Ostatné duriče"
        '
        'BrlohareLabel
        '
        BrlohareLabel.AutoSize = True
        BrlohareLabel.Location = New System.Drawing.Point(137, 629)
        BrlohareLabel.Name = "BrlohareLabel"
        BrlohareLabel.Size = New System.Drawing.Size(49, 13)
        BrlohareLabel.TabIndex = 51
        BrlohareLabel.Text = "Brloháče"
        '
        'FarbiareLabel
        '
        FarbiareLabel.AutoSize = True
        FarbiareLabel.Location = New System.Drawing.Point(139, 655)
        FarbiareLabel.Name = "FarbiareLabel"
        FarbiareLabel.Size = New System.Drawing.Size(45, 13)
        FarbiareLabel.TabIndex = 53
        FarbiareLabel.Text = "Farbiare"
        '
        'Pes_jeleniaLabel
        '
        Pes_jeleniaLabel.AutoSize = True
        Pes_jeleniaLabel.Location = New System.Drawing.Point(128, 681)
        Pes_jeleniaLabel.Name = "Pes_jeleniaLabel"
        Pes_jeleniaLabel.Size = New System.Drawing.Size(58, 13)
        Pes_jeleniaLabel.TabIndex = 55
        Pes_jeleniaLabel.Text = "Pes jelenia"
        '
        'Pes_diviaciaLabel
        '
        Pes_diviaciaLabel.AutoSize = True
        Pes_diviaciaLabel.Location = New System.Drawing.Point(122, 707)
        Pes_diviaciaLabel.Name = "Pes_diviaciaLabel"
        Pes_diviaciaLabel.Size = New System.Drawing.Size(64, 13)
        Pes_diviaciaLabel.TabIndex = 57
        Pes_diviaciaLabel.Text = "Pes diviačia"
        '
        'Pes_srnciaLabel
        '
        Pes_srnciaLabel.AutoSize = True
        Pes_srnciaLabel.Location = New System.Drawing.Point(126, 733)
        Pes_srnciaLabel.Name = "Pes_srnciaLabel"
        Pes_srnciaLabel.Size = New System.Drawing.Size(56, 13)
        Pes_srnciaLabel.TabIndex = 59
        Pes_srnciaLabel.Text = "Pes srnčia"
        '
        'Pes_malaLabel
        '
        Pes_malaLabel.AutoSize = True
        Pes_malaLabel.Location = New System.Drawing.Point(132, 759)
        Pes_malaLabel.Name = "Pes_malaLabel"
        Pes_malaLabel.Size = New System.Drawing.Size(50, 13)
        Pes_malaLabel.TabIndex = 61
        Pes_malaLabel.Text = "Pes malá"
        '
        'Platnost_najomnej_zmluvy_doLabel
        '
        Platnost_najomnej_zmluvy_doLabel.AutoSize = True
        Platnost_najomnej_zmluvy_doLabel.Location = New System.Drawing.Point(59, 784)
        Platnost_najomnej_zmluvy_doLabel.Name = "Platnost_najomnej_zmluvy_doLabel"
        Platnost_najomnej_zmluvy_doLabel.Size = New System.Drawing.Size(126, 13)
        Platnost_najomnej_zmluvy_doLabel.TabIndex = 63
        Platnost_najomnej_zmluvy_doLabel.Text = "Platnosť nájomnej zmluvy"
        '
        'ZdruzenieDataSet
        '
        Me.ZdruzenieDataSet.DataSetName = "zdruzenieDataSet"
        Me.ZdruzenieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZdruzenieBindingSource
        '
        Me.ZdruzenieBindingSource.DataMember = "zdruzenie"
        Me.ZdruzenieBindingSource.DataSource = Me.ZdruzenieDataSet
        '
        'ZdruzenieTableAdapter
        '
        Me.ZdruzenieTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.zdruzenieTableAdapter = Me.ZdruzenieTableAdapter
        '
        'ZdruzenieBindingNavigator
        '
        Me.ZdruzenieBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ZdruzenieBindingNavigator.BindingSource = Me.ZdruzenieBindingSource
        Me.ZdruzenieBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ZdruzenieBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ZdruzenieBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ZdruzenieBindingNavigatorSaveItem})
        Me.ZdruzenieBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ZdruzenieBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ZdruzenieBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ZdruzenieBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ZdruzenieBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ZdruzenieBindingNavigator.Name = "ZdruzenieBindingNavigator"
        Me.ZdruzenieBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ZdruzenieBindingNavigator.Size = New System.Drawing.Size(629, 25)
        Me.ZdruzenieBindingNavigator.TabIndex = 0
        Me.ZdruzenieBindingNavigator.Text = "BindingNavigator1"
        Me.ZdruzenieBindingNavigator.Visible = False
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(33, 22)
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
        'ZdruzenieBindingNavigatorSaveItem
        '
        Me.ZdruzenieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZdruzenieBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZdruzenieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZdruzenieBindingNavigatorSaveItem.Name = "ZdruzenieBindingNavigatorSaveItem"
        Me.ZdruzenieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ZdruzenieBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(191, 56)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.ReadOnly = True
        Me.NazovTextBox.Size = New System.Drawing.Size(130, 20)
        Me.NazovTextBox.TabIndex = 4
        '
        'SidloTextBox
        '
        Me.SidloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "sidlo", True))
        Me.SidloTextBox.Location = New System.Drawing.Point(425, 56)
        Me.SidloTextBox.Name = "SidloTextBox"
        Me.SidloTextBox.ReadOnly = True
        Me.SidloTextBox.Size = New System.Drawing.Size(97, 20)
        Me.SidloTextBox.TabIndex = 6
        '
        'PredsedaTextBox
        '
        Me.PredsedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "predseda", True))
        Me.PredsedaTextBox.Location = New System.Drawing.Point(191, 131)
        Me.PredsedaTextBox.Name = "PredsedaTextBox"
        Me.PredsedaTextBox.ReadOnly = True
        Me.PredsedaTextBox.Size = New System.Drawing.Size(130, 20)
        Me.PredsedaTextBox.TabIndex = 8
        '
        'Predseda_telefonTextBox
        '
        Me.Predseda_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "predseda_telefon", True))
        Me.Predseda_telefonTextBox.Location = New System.Drawing.Point(425, 131)
        Me.Predseda_telefonTextBox.Name = "Predseda_telefonTextBox"
        Me.Predseda_telefonTextBox.ReadOnly = True
        Me.Predseda_telefonTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Predseda_telefonTextBox.TabIndex = 10
        '
        'Polovnicky_hospodarTextBox
        '
        Me.Polovnicky_hospodarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "polovnicky_hospodar", True))
        Me.Polovnicky_hospodarTextBox.Location = New System.Drawing.Point(191, 157)
        Me.Polovnicky_hospodarTextBox.Name = "Polovnicky_hospodarTextBox"
        Me.Polovnicky_hospodarTextBox.ReadOnly = True
        Me.Polovnicky_hospodarTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Polovnicky_hospodarTextBox.TabIndex = 12
        '
        'Polovnicky_hospodar_telefonTextBox
        '
        Me.Polovnicky_hospodar_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "polovnicky_hospodar_telefon", True))
        Me.Polovnicky_hospodar_telefonTextBox.Location = New System.Drawing.Point(425, 157)
        Me.Polovnicky_hospodar_telefonTextBox.Name = "Polovnicky_hospodar_telefonTextBox"
        Me.Polovnicky_hospodar_telefonTextBox.ReadOnly = True
        Me.Polovnicky_hospodar_telefonTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Polovnicky_hospodar_telefonTextBox.TabIndex = 14
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(191, 82)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.ReadOnly = True
        Me.IcoTextBox.Size = New System.Drawing.Size(130, 20)
        Me.IcoTextBox.TabIndex = 16
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(425, 82)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.ReadOnly = True
        Me.DicTextBox.Size = New System.Drawing.Size(97, 20)
        Me.DicTextBox.TabIndex = 18
        '
        'BankaTextBox
        '
        Me.BankaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "banka", True))
        Me.BankaTextBox.Location = New System.Drawing.Point(191, 106)
        Me.BankaTextBox.Name = "BankaTextBox"
        Me.BankaTextBox.ReadOnly = True
        Me.BankaTextBox.Size = New System.Drawing.Size(130, 20)
        Me.BankaTextBox.TabIndex = 20
        '
        'Cislo_uctuTextBox
        '
        Me.Cislo_uctuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "cislo_uctu", True))
        Me.Cislo_uctuTextBox.Location = New System.Drawing.Point(425, 106)
        Me.Cislo_uctuTextBox.Name = "Cislo_uctuTextBox"
        Me.Cislo_uctuTextBox.ReadOnly = True
        Me.Cislo_uctuTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Cislo_uctuTextBox.TabIndex = 22
        '
        'Nazov_polovneho_reviruTextBox
        '
        Me.Nazov_polovneho_reviruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "nazov_polovneho_reviru", True))
        Me.Nazov_polovneho_reviruTextBox.Location = New System.Drawing.Point(191, 203)
        Me.Nazov_polovneho_reviruTextBox.Name = "Nazov_polovneho_reviruTextBox"
        Me.Nazov_polovneho_reviruTextBox.ReadOnly = True
        Me.Nazov_polovneho_reviruTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Nazov_polovneho_reviruTextBox.TabIndex = 24
        '
        'Chovatelska_oblastTextBox
        '
        Me.Chovatelska_oblastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "chovatelska_oblast", True))
        Me.Chovatelska_oblastTextBox.Location = New System.Drawing.Point(191, 229)
        Me.Chovatelska_oblastTextBox.Name = "Chovatelska_oblastTextBox"
        Me.Chovatelska_oblastTextBox.ReadOnly = True
        Me.Chovatelska_oblastTextBox.Size = New System.Drawing.Size(130, 20)
        Me.Chovatelska_oblastTextBox.TabIndex = 26
        '
        'Cislo_reviruTextBox
        '
        Me.Cislo_reviruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "cislo_reviru", True))
        Me.Cislo_reviruTextBox.Location = New System.Drawing.Point(425, 203)
        Me.Cislo_reviruTextBox.Name = "Cislo_reviruTextBox"
        Me.Cislo_reviruTextBox.ReadOnly = True
        Me.Cislo_reviruTextBox.Size = New System.Drawing.Size(97, 20)
        Me.Cislo_reviruTextBox.TabIndex = 28
        '
        'VymeraTextBox
        '
        Me.VymeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "vymera", True))
        Me.VymeraTextBox.Location = New System.Drawing.Point(425, 229)
        Me.VymeraTextBox.Name = "VymeraTextBox"
        Me.VymeraTextBox.ReadOnly = True
        Me.VymeraTextBox.Size = New System.Drawing.Size(97, 20)
        Me.VymeraTextBox.TabIndex = 30
        '
        'LesTextBox
        '
        Me.LesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "les", True))
        Me.LesTextBox.Location = New System.Drawing.Point(191, 255)
        Me.LesTextBox.Name = "LesTextBox"
        Me.LesTextBox.ReadOnly = True
        Me.LesTextBox.Size = New System.Drawing.Size(130, 20)
        Me.LesTextBox.TabIndex = 32
        '
        'JeleniaTextBox
        '
        Me.JeleniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "jelenia", True))
        Me.JeleniaTextBox.Location = New System.Drawing.Point(190, 335)
        Me.JeleniaTextBox.Name = "JeleniaTextBox"
        Me.JeleniaTextBox.ReadOnly = True
        Me.JeleniaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.JeleniaTextBox.TabIndex = 34
        '
        'SrnciaTextBox
        '
        Me.SrnciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "srncia", True))
        Me.SrnciaTextBox.Location = New System.Drawing.Point(190, 361)
        Me.SrnciaTextBox.Name = "SrnciaTextBox"
        Me.SrnciaTextBox.ReadOnly = True
        Me.SrnciaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.SrnciaTextBox.TabIndex = 36
        '
        'DiviaciaTextBox
        '
        Me.DiviaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "diviacia", True))
        Me.DiviaciaTextBox.Location = New System.Drawing.Point(191, 387)
        Me.DiviaciaTextBox.Name = "DiviaciaTextBox"
        Me.DiviaciaTextBox.ReadOnly = True
        Me.DiviaciaTextBox.Size = New System.Drawing.Size(130, 20)
        Me.DiviaciaTextBox.TabIndex = 38
        '
        'BazantTextBox
        '
        Me.BazantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "bazant", True))
        Me.BazantTextBox.Location = New System.Drawing.Point(190, 413)
        Me.BazantTextBox.Name = "BazantTextBox"
        Me.BazantTextBox.ReadOnly = True
        Me.BazantTextBox.Size = New System.Drawing.Size(131, 20)
        Me.BazantTextBox.TabIndex = 40
        '
        'InaTextBox
        '
        Me.InaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ina", True))
        Me.InaTextBox.Location = New System.Drawing.Point(191, 439)
        Me.InaTextBox.Name = "InaTextBox"
        Me.InaTextBox.ReadOnly = True
        Me.InaTextBox.Size = New System.Drawing.Size(130, 20)
        Me.InaTextBox.TabIndex = 42
        '
        'StavaceTextBox
        '
        Me.StavaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "stavace", True))
        Me.StavaceTextBox.Location = New System.Drawing.Point(191, 522)
        Me.StavaceTextBox.Name = "StavaceTextBox"
        Me.StavaceTextBox.ReadOnly = True
        Me.StavaceTextBox.Size = New System.Drawing.Size(129, 20)
        Me.StavaceTextBox.TabIndex = 44
        '
        'SliediceTextBox
        '
        Me.SliediceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "sliedice", True))
        Me.SliediceTextBox.Location = New System.Drawing.Point(191, 548)
        Me.SliediceTextBox.Name = "SliediceTextBox"
        Me.SliediceTextBox.ReadOnly = True
        Me.SliediceTextBox.Size = New System.Drawing.Size(130, 20)
        Me.SliediceTextBox.TabIndex = 46
        '
        'Slovensky_kopovTextBox
        '
        Me.Slovensky_kopovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "slovensky_kopov", True))
        Me.Slovensky_kopovTextBox.Location = New System.Drawing.Point(190, 574)
        Me.Slovensky_kopovTextBox.Name = "Slovensky_kopovTextBox"
        Me.Slovensky_kopovTextBox.ReadOnly = True
        Me.Slovensky_kopovTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Slovensky_kopovTextBox.TabIndex = 48
        '
        'Ostatne_duriceTextBox
        '
        Me.Ostatne_duriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ostatne_durice", True))
        Me.Ostatne_duriceTextBox.Location = New System.Drawing.Point(190, 600)
        Me.Ostatne_duriceTextBox.Name = "Ostatne_duriceTextBox"
        Me.Ostatne_duriceTextBox.ReadOnly = True
        Me.Ostatne_duriceTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Ostatne_duriceTextBox.TabIndex = 50
        '
        'BrlohareTextBox
        '
        Me.BrlohareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "brlohare", True))
        Me.BrlohareTextBox.Location = New System.Drawing.Point(190, 626)
        Me.BrlohareTextBox.Name = "BrlohareTextBox"
        Me.BrlohareTextBox.ReadOnly = True
        Me.BrlohareTextBox.Size = New System.Drawing.Size(131, 20)
        Me.BrlohareTextBox.TabIndex = 52
        '
        'FarbiareTextBox
        '
        Me.FarbiareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "farbiare", True))
        Me.FarbiareTextBox.Location = New System.Drawing.Point(190, 652)
        Me.FarbiareTextBox.Name = "FarbiareTextBox"
        Me.FarbiareTextBox.ReadOnly = True
        Me.FarbiareTextBox.Size = New System.Drawing.Size(131, 20)
        Me.FarbiareTextBox.TabIndex = 54
        '
        'Pes_jeleniaTextBox
        '
        Me.Pes_jeleniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_jelenia", True))
        Me.Pes_jeleniaTextBox.Location = New System.Drawing.Point(190, 678)
        Me.Pes_jeleniaTextBox.Name = "Pes_jeleniaTextBox"
        Me.Pes_jeleniaTextBox.ReadOnly = True
        Me.Pes_jeleniaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Pes_jeleniaTextBox.TabIndex = 56
        '
        'Pes_diviaciaTextBox
        '
        Me.Pes_diviaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_diviacia", True))
        Me.Pes_diviaciaTextBox.Location = New System.Drawing.Point(190, 704)
        Me.Pes_diviaciaTextBox.Name = "Pes_diviaciaTextBox"
        Me.Pes_diviaciaTextBox.ReadOnly = True
        Me.Pes_diviaciaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Pes_diviaciaTextBox.TabIndex = 58
        '
        'Pes_srnciaTextBox
        '
        Me.Pes_srnciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_srncia", True))
        Me.Pes_srnciaTextBox.Location = New System.Drawing.Point(190, 730)
        Me.Pes_srnciaTextBox.Name = "Pes_srnciaTextBox"
        Me.Pes_srnciaTextBox.ReadOnly = True
        Me.Pes_srnciaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Pes_srnciaTextBox.TabIndex = 60
        '
        'Pes_malaTextBox
        '
        Me.Pes_malaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_mala", True))
        Me.Pes_malaTextBox.Location = New System.Drawing.Point(190, 756)
        Me.Pes_malaTextBox.Name = "Pes_malaTextBox"
        Me.Pes_malaTextBox.ReadOnly = True
        Me.Pes_malaTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Pes_malaTextBox.TabIndex = 62
        '
        'Platnost_najomnej_zmluvy_doDateTimePicker
        '
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ZdruzenieBindingSource, "platnost_najomnej_zmluvy_do", True))
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Location = New System.Drawing.Point(191, 780)
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Name = "Platnost_najomnej_zmluvy_doDateTimePicker"
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Size = New System.Drawing.Size(130, 20)
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.TabIndex = 64
        '
        'upravitButton
        '
        Me.upravitButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.upravitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upravitButton.Location = New System.Drawing.Point(151, 6)
        Me.upravitButton.Name = "upravitButton"
        Me.upravitButton.Size = New System.Drawing.Size(136, 23)
        Me.upravitButton.TabIndex = 65
        Me.upravitButton.Text = "Upraviť detajly združenia"
        Me.upravitButton.UseVisualStyleBackColor = False
        '
        'ulozButton
        '
        Me.ulozButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ulozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulozButton.Location = New System.Drawing.Point(293, 7)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 66
        Me.ulozButton.Text = "Uložiť"
        Me.ulozButton.UseVisualStyleBackColor = False
        Me.ulozButton.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(374, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Zavrieť kartu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Zver"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Psy"
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 54
        Me.LineShape1.X2 = 554
        Me.LineShape1.Y1 = 185
        Me.LineShape1.Y2 = 186
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(629, 812)
        Me.ShapeContainer1.TabIndex = 70
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 54
        Me.LineShape3.X2 = 554
        Me.LineShape3.Y1 = 507
        Me.LineShape3.Y2 = 508
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 54
        Me.LineShape2.X2 = 554
        Me.LineShape2.Y1 = 323
        Me.LineShape2.Y2 = 324
        '
        'detaily_zdruzenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(629, 812)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.upravitButton)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(SidloLabel)
        Me.Controls.Add(Me.SidloTextBox)
        Me.Controls.Add(PredsedaLabel)
        Me.Controls.Add(Me.PredsedaTextBox)
        Me.Controls.Add(Predseda_telefonLabel)
        Me.Controls.Add(Me.Predseda_telefonTextBox)
        Me.Controls.Add(Polovnicky_hospodarLabel)
        Me.Controls.Add(Me.Polovnicky_hospodarTextBox)
        Me.Controls.Add(Polovnicky_hospodar_telefonLabel)
        Me.Controls.Add(Me.Polovnicky_hospodar_telefonTextBox)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(BankaLabel)
        Me.Controls.Add(Me.BankaTextBox)
        Me.Controls.Add(Cislo_uctuLabel)
        Me.Controls.Add(Me.Cislo_uctuTextBox)
        Me.Controls.Add(Nazov_polovneho_reviruLabel)
        Me.Controls.Add(Me.Nazov_polovneho_reviruTextBox)
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
        Me.Controls.Add(StavaceLabel)
        Me.Controls.Add(Me.StavaceTextBox)
        Me.Controls.Add(SliediceLabel)
        Me.Controls.Add(Me.SliediceTextBox)
        Me.Controls.Add(Slovensky_kopovLabel)
        Me.Controls.Add(Me.Slovensky_kopovTextBox)
        Me.Controls.Add(Ostatne_duriceLabel)
        Me.Controls.Add(Me.Ostatne_duriceTextBox)
        Me.Controls.Add(BrlohareLabel)
        Me.Controls.Add(Me.BrlohareTextBox)
        Me.Controls.Add(FarbiareLabel)
        Me.Controls.Add(Me.FarbiareTextBox)
        Me.Controls.Add(Pes_jeleniaLabel)
        Me.Controls.Add(Me.Pes_jeleniaTextBox)
        Me.Controls.Add(Pes_diviaciaLabel)
        Me.Controls.Add(Me.Pes_diviaciaTextBox)
        Me.Controls.Add(Pes_srnciaLabel)
        Me.Controls.Add(Me.Pes_srnciaTextBox)
        Me.Controls.Add(Pes_malaLabel)
        Me.Controls.Add(Me.Pes_malaTextBox)
        Me.Controls.Add(Platnost_najomnej_zmluvy_doLabel)
        Me.Controls.Add(Me.Platnost_najomnej_zmluvy_doDateTimePicker)
        Me.Controls.Add(Me.ZdruzenieBindingNavigator)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "detaily_zdruzenia"
        Me.Text = "detaily_zdruzenia"
        CType(Me.ZdruzenieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZdruzenieBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ZdruzenieBindingNavigator.ResumeLayout(False)
        Me.ZdruzenieBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZdruzenieDataSet As evidencia_spz.zdruzenieDataSet
    Friend WithEvents ZdruzenieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZdruzenieTableAdapter As evidencia_spz.zdruzenieDataSetTableAdapters.zdruzenieTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.zdruzenieDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ZdruzenieBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ZdruzenieBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SidloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PredsedaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Predseda_telefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Polovnicky_hospodarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Polovnicky_hospodar_telefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BankaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_uctuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nazov_polovneho_reviruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Chovatelska_oblastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_reviruTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VymeraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JeleniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SrnciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiviaciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BazantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StavaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SliediceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Slovensky_kopovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ostatne_duriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrlohareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FarbiareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_jeleniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_diviaciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_srnciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pes_malaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Platnost_najomnej_zmluvy_doDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents upravitButton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
