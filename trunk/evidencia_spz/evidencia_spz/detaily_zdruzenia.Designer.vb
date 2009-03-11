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
        Dim IDLabel As System.Windows.Forms.Label
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
        Me.IDTextBox = New System.Windows.Forms.TextBox
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
        Me.Button1 = New System.Windows.Forms.Button
        IDLabel = New System.Windows.Forms.Label
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
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(75, 82)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(75, 108)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(39, 13)
        NazovLabel.TabIndex = 3
        NazovLabel.Text = "nazov:"
        '
        'SidloLabel
        '
        SidloLabel.AutoSize = True
        SidloLabel.Location = New System.Drawing.Point(75, 134)
        SidloLabel.Name = "SidloLabel"
        SidloLabel.Size = New System.Drawing.Size(31, 13)
        SidloLabel.TabIndex = 5
        SidloLabel.Text = "sidlo:"
        '
        'PredsedaLabel
        '
        PredsedaLabel.AutoSize = True
        PredsedaLabel.Location = New System.Drawing.Point(75, 160)
        PredsedaLabel.Name = "PredsedaLabel"
        PredsedaLabel.Size = New System.Drawing.Size(54, 13)
        PredsedaLabel.TabIndex = 7
        PredsedaLabel.Text = "predseda:"
        '
        'Predseda_telefonLabel
        '
        Predseda_telefonLabel.AutoSize = True
        Predseda_telefonLabel.Location = New System.Drawing.Point(75, 186)
        Predseda_telefonLabel.Name = "Predseda_telefonLabel"
        Predseda_telefonLabel.Size = New System.Drawing.Size(89, 13)
        Predseda_telefonLabel.TabIndex = 9
        Predseda_telefonLabel.Text = "predseda telefon:"
        '
        'Polovnicky_hospodarLabel
        '
        Polovnicky_hospodarLabel.AutoSize = True
        Polovnicky_hospodarLabel.Location = New System.Drawing.Point(75, 212)
        Polovnicky_hospodarLabel.Name = "Polovnicky_hospodarLabel"
        Polovnicky_hospodarLabel.Size = New System.Drawing.Size(108, 13)
        Polovnicky_hospodarLabel.TabIndex = 11
        Polovnicky_hospodarLabel.Text = "polovnicky hospodar:"
        '
        'Polovnicky_hospodar_telefonLabel
        '
        Polovnicky_hospodar_telefonLabel.AutoSize = True
        Polovnicky_hospodar_telefonLabel.Location = New System.Drawing.Point(75, 238)
        Polovnicky_hospodar_telefonLabel.Name = "Polovnicky_hospodar_telefonLabel"
        Polovnicky_hospodar_telefonLabel.Size = New System.Drawing.Size(143, 13)
        Polovnicky_hospodar_telefonLabel.TabIndex = 13
        Polovnicky_hospodar_telefonLabel.Text = "polovnicky hospodar telefon:"
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(75, 264)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(24, 13)
        IcoLabel.TabIndex = 15
        IcoLabel.Text = "ico:"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(75, 290)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(24, 13)
        DicLabel.TabIndex = 17
        DicLabel.Text = "dic:"
        '
        'BankaLabel
        '
        BankaLabel.AutoSize = True
        BankaLabel.Location = New System.Drawing.Point(75, 316)
        BankaLabel.Name = "BankaLabel"
        BankaLabel.Size = New System.Drawing.Size(40, 13)
        BankaLabel.TabIndex = 19
        BankaLabel.Text = "banka:"
        '
        'Cislo_uctuLabel
        '
        Cislo_uctuLabel.AutoSize = True
        Cislo_uctuLabel.Location = New System.Drawing.Point(75, 342)
        Cislo_uctuLabel.Name = "Cislo_uctuLabel"
        Cislo_uctuLabel.Size = New System.Drawing.Size(55, 13)
        Cislo_uctuLabel.TabIndex = 21
        Cislo_uctuLabel.Text = "cislo uctu:"
        '
        'Nazov_polovneho_reviruLabel
        '
        Nazov_polovneho_reviruLabel.AutoSize = True
        Nazov_polovneho_reviruLabel.Location = New System.Drawing.Point(75, 368)
        Nazov_polovneho_reviruLabel.Name = "Nazov_polovneho_reviruLabel"
        Nazov_polovneho_reviruLabel.Size = New System.Drawing.Size(121, 13)
        Nazov_polovneho_reviruLabel.TabIndex = 23
        Nazov_polovneho_reviruLabel.Text = "nazov polovneho reviru:"
        '
        'Chovatelska_oblastLabel
        '
        Chovatelska_oblastLabel.AutoSize = True
        Chovatelska_oblastLabel.Location = New System.Drawing.Point(75, 394)
        Chovatelska_oblastLabel.Name = "Chovatelska_oblastLabel"
        Chovatelska_oblastLabel.Size = New System.Drawing.Size(99, 13)
        Chovatelska_oblastLabel.TabIndex = 25
        Chovatelska_oblastLabel.Text = "chovatelska oblast:"
        '
        'Cislo_reviruLabel
        '
        Cislo_reviruLabel.AutoSize = True
        Cislo_reviruLabel.Location = New System.Drawing.Point(75, 420)
        Cislo_reviruLabel.Name = "Cislo_reviruLabel"
        Cislo_reviruLabel.Size = New System.Drawing.Size(60, 13)
        Cislo_reviruLabel.TabIndex = 27
        Cislo_reviruLabel.Text = "cislo reviru:"
        '
        'VymeraLabel
        '
        VymeraLabel.AutoSize = True
        VymeraLabel.Location = New System.Drawing.Point(75, 446)
        VymeraLabel.Name = "VymeraLabel"
        VymeraLabel.Size = New System.Drawing.Size(44, 13)
        VymeraLabel.TabIndex = 29
        VymeraLabel.Text = "vymera:"
        '
        'LesLabel
        '
        LesLabel.AutoSize = True
        LesLabel.Location = New System.Drawing.Point(75, 472)
        LesLabel.Name = "LesLabel"
        LesLabel.Size = New System.Drawing.Size(23, 13)
        LesLabel.TabIndex = 31
        LesLabel.Text = "les:"
        '
        'JeleniaLabel
        '
        JeleniaLabel.AutoSize = True
        JeleniaLabel.Location = New System.Drawing.Point(75, 498)
        JeleniaLabel.Name = "JeleniaLabel"
        JeleniaLabel.Size = New System.Drawing.Size(40, 13)
        JeleniaLabel.TabIndex = 33
        JeleniaLabel.Text = "jelenia:"
        '
        'SrnciaLabel
        '
        SrnciaLabel.AutoSize = True
        SrnciaLabel.Location = New System.Drawing.Point(75, 524)
        SrnciaLabel.Name = "SrnciaLabel"
        SrnciaLabel.Size = New System.Drawing.Size(38, 13)
        SrnciaLabel.TabIndex = 35
        SrnciaLabel.Text = "srncia:"
        '
        'DiviaciaLabel
        '
        DiviaciaLabel.AutoSize = True
        DiviaciaLabel.Location = New System.Drawing.Point(75, 550)
        DiviaciaLabel.Name = "DiviaciaLabel"
        DiviaciaLabel.Size = New System.Drawing.Size(46, 13)
        DiviaciaLabel.TabIndex = 37
        DiviaciaLabel.Text = "diviacia:"
        '
        'BazantLabel
        '
        BazantLabel.AutoSize = True
        BazantLabel.Location = New System.Drawing.Point(75, 576)
        BazantLabel.Name = "BazantLabel"
        BazantLabel.Size = New System.Drawing.Size(42, 13)
        BazantLabel.TabIndex = 39
        BazantLabel.Text = "bazant:"
        '
        'InaLabel
        '
        InaLabel.AutoSize = True
        InaLabel.Location = New System.Drawing.Point(75, 602)
        InaLabel.Name = "InaLabel"
        InaLabel.Size = New System.Drawing.Size(24, 13)
        InaLabel.TabIndex = 41
        InaLabel.Text = "ina:"
        '
        'StavaceLabel
        '
        StavaceLabel.AutoSize = True
        StavaceLabel.Location = New System.Drawing.Point(75, 628)
        StavaceLabel.Name = "StavaceLabel"
        StavaceLabel.Size = New System.Drawing.Size(48, 13)
        StavaceLabel.TabIndex = 43
        StavaceLabel.Text = "stavace:"
        '
        'SliediceLabel
        '
        SliediceLabel.AutoSize = True
        SliediceLabel.Location = New System.Drawing.Point(75, 654)
        SliediceLabel.Name = "SliediceLabel"
        SliediceLabel.Size = New System.Drawing.Size(45, 13)
        SliediceLabel.TabIndex = 45
        SliediceLabel.Text = "sliedice:"
        '
        'Slovensky_kopovLabel
        '
        Slovensky_kopovLabel.AutoSize = True
        Slovensky_kopovLabel.Location = New System.Drawing.Point(75, 680)
        Slovensky_kopovLabel.Name = "Slovensky_kopovLabel"
        Slovensky_kopovLabel.Size = New System.Drawing.Size(90, 13)
        Slovensky_kopovLabel.TabIndex = 47
        Slovensky_kopovLabel.Text = "slovensky kopov:"
        '
        'Ostatne_duriceLabel
        '
        Ostatne_duriceLabel.AutoSize = True
        Ostatne_duriceLabel.Location = New System.Drawing.Point(75, 706)
        Ostatne_duriceLabel.Name = "Ostatne_duriceLabel"
        Ostatne_duriceLabel.Size = New System.Drawing.Size(77, 13)
        Ostatne_duriceLabel.TabIndex = 49
        Ostatne_duriceLabel.Text = "ostatne durice:"
        '
        'BrlohareLabel
        '
        BrlohareLabel.AutoSize = True
        BrlohareLabel.Location = New System.Drawing.Point(75, 732)
        BrlohareLabel.Name = "BrlohareLabel"
        BrlohareLabel.Size = New System.Drawing.Size(48, 13)
        BrlohareLabel.TabIndex = 51
        BrlohareLabel.Text = "brlohare:"
        '
        'FarbiareLabel
        '
        FarbiareLabel.AutoSize = True
        FarbiareLabel.Location = New System.Drawing.Point(75, 758)
        FarbiareLabel.Name = "FarbiareLabel"
        FarbiareLabel.Size = New System.Drawing.Size(45, 13)
        FarbiareLabel.TabIndex = 53
        FarbiareLabel.Text = "farbiare:"
        '
        'Pes_jeleniaLabel
        '
        Pes_jeleniaLabel.AutoSize = True
        Pes_jeleniaLabel.Location = New System.Drawing.Point(75, 784)
        Pes_jeleniaLabel.Name = "Pes_jeleniaLabel"
        Pes_jeleniaLabel.Size = New System.Drawing.Size(60, 13)
        Pes_jeleniaLabel.TabIndex = 55
        Pes_jeleniaLabel.Text = "pes jelenia:"
        '
        'Pes_diviaciaLabel
        '
        Pes_diviaciaLabel.AutoSize = True
        Pes_diviaciaLabel.Location = New System.Drawing.Point(75, 810)
        Pes_diviaciaLabel.Name = "Pes_diviaciaLabel"
        Pes_diviaciaLabel.Size = New System.Drawing.Size(66, 13)
        Pes_diviaciaLabel.TabIndex = 57
        Pes_diviaciaLabel.Text = "pes diviacia:"
        '
        'Pes_srnciaLabel
        '
        Pes_srnciaLabel.AutoSize = True
        Pes_srnciaLabel.Location = New System.Drawing.Point(75, 836)
        Pes_srnciaLabel.Name = "Pes_srnciaLabel"
        Pes_srnciaLabel.Size = New System.Drawing.Size(58, 13)
        Pes_srnciaLabel.TabIndex = 59
        Pes_srnciaLabel.Text = "pes srncia:"
        '
        'Pes_malaLabel
        '
        Pes_malaLabel.AutoSize = True
        Pes_malaLabel.Location = New System.Drawing.Point(75, 862)
        Pes_malaLabel.Name = "Pes_malaLabel"
        Pes_malaLabel.Size = New System.Drawing.Size(52, 13)
        Pes_malaLabel.TabIndex = 61
        Pes_malaLabel.Text = "pes mala:"
        '
        'Platnost_najomnej_zmluvy_doLabel
        '
        Platnost_najomnej_zmluvy_doLabel.AutoSize = True
        Platnost_najomnej_zmluvy_doLabel.Location = New System.Drawing.Point(75, 889)
        Platnost_najomnej_zmluvy_doLabel.Name = "Platnost_najomnej_zmluvy_doLabel"
        Platnost_najomnej_zmluvy_doLabel.Size = New System.Drawing.Size(142, 13)
        Platnost_najomnej_zmluvy_doLabel.TabIndex = 63
        Platnost_najomnej_zmluvy_doLabel.Text = "platnost najomnej zmluvy do:"
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
        'ZdruzenieBindingNavigatorSaveItem
        '
        Me.ZdruzenieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZdruzenieBindingNavigatorSaveItem.Image = CType(resources.GetObject("ZdruzenieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ZdruzenieBindingNavigatorSaveItem.Name = "ZdruzenieBindingNavigatorSaveItem"
        Me.ZdruzenieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ZdruzenieBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(224, 79)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(224, 105)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NazovTextBox.TabIndex = 4
        '
        'SidloTextBox
        '
        Me.SidloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "sidlo", True))
        Me.SidloTextBox.Location = New System.Drawing.Point(224, 131)
        Me.SidloTextBox.Name = "SidloTextBox"
        Me.SidloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SidloTextBox.TabIndex = 6
        '
        'PredsedaTextBox
        '
        Me.PredsedaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "predseda", True))
        Me.PredsedaTextBox.Location = New System.Drawing.Point(224, 157)
        Me.PredsedaTextBox.Name = "PredsedaTextBox"
        Me.PredsedaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PredsedaTextBox.TabIndex = 8
        '
        'Predseda_telefonTextBox
        '
        Me.Predseda_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "predseda_telefon", True))
        Me.Predseda_telefonTextBox.Location = New System.Drawing.Point(224, 183)
        Me.Predseda_telefonTextBox.Name = "Predseda_telefonTextBox"
        Me.Predseda_telefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Predseda_telefonTextBox.TabIndex = 10
        '
        'Polovnicky_hospodarTextBox
        '
        Me.Polovnicky_hospodarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "polovnicky_hospodar", True))
        Me.Polovnicky_hospodarTextBox.Location = New System.Drawing.Point(224, 209)
        Me.Polovnicky_hospodarTextBox.Name = "Polovnicky_hospodarTextBox"
        Me.Polovnicky_hospodarTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Polovnicky_hospodarTextBox.TabIndex = 12
        '
        'Polovnicky_hospodar_telefonTextBox
        '
        Me.Polovnicky_hospodar_telefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "polovnicky_hospodar_telefon", True))
        Me.Polovnicky_hospodar_telefonTextBox.Location = New System.Drawing.Point(224, 235)
        Me.Polovnicky_hospodar_telefonTextBox.Name = "Polovnicky_hospodar_telefonTextBox"
        Me.Polovnicky_hospodar_telefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Polovnicky_hospodar_telefonTextBox.TabIndex = 14
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(224, 261)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IcoTextBox.TabIndex = 16
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(224, 287)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DicTextBox.TabIndex = 18
        '
        'BankaTextBox
        '
        Me.BankaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "banka", True))
        Me.BankaTextBox.Location = New System.Drawing.Point(224, 313)
        Me.BankaTextBox.Name = "BankaTextBox"
        Me.BankaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankaTextBox.TabIndex = 20
        '
        'Cislo_uctuTextBox
        '
        Me.Cislo_uctuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "cislo_uctu", True))
        Me.Cislo_uctuTextBox.Location = New System.Drawing.Point(224, 339)
        Me.Cislo_uctuTextBox.Name = "Cislo_uctuTextBox"
        Me.Cislo_uctuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_uctuTextBox.TabIndex = 22
        '
        'Nazov_polovneho_reviruTextBox
        '
        Me.Nazov_polovneho_reviruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "nazov_polovneho_reviru", True))
        Me.Nazov_polovneho_reviruTextBox.Location = New System.Drawing.Point(224, 365)
        Me.Nazov_polovneho_reviruTextBox.Name = "Nazov_polovneho_reviruTextBox"
        Me.Nazov_polovneho_reviruTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nazov_polovneho_reviruTextBox.TabIndex = 24
        '
        'Chovatelska_oblastTextBox
        '
        Me.Chovatelska_oblastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "chovatelska_oblast", True))
        Me.Chovatelska_oblastTextBox.Location = New System.Drawing.Point(224, 391)
        Me.Chovatelska_oblastTextBox.Name = "Chovatelska_oblastTextBox"
        Me.Chovatelska_oblastTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Chovatelska_oblastTextBox.TabIndex = 26
        '
        'Cislo_reviruTextBox
        '
        Me.Cislo_reviruTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "cislo_reviru", True))
        Me.Cislo_reviruTextBox.Location = New System.Drawing.Point(224, 417)
        Me.Cislo_reviruTextBox.Name = "Cislo_reviruTextBox"
        Me.Cislo_reviruTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_reviruTextBox.TabIndex = 28
        '
        'VymeraTextBox
        '
        Me.VymeraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "vymera", True))
        Me.VymeraTextBox.Location = New System.Drawing.Point(224, 443)
        Me.VymeraTextBox.Name = "VymeraTextBox"
        Me.VymeraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VymeraTextBox.TabIndex = 30
        '
        'LesTextBox
        '
        Me.LesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "les", True))
        Me.LesTextBox.Location = New System.Drawing.Point(224, 469)
        Me.LesTextBox.Name = "LesTextBox"
        Me.LesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LesTextBox.TabIndex = 32
        '
        'JeleniaTextBox
        '
        Me.JeleniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "jelenia", True))
        Me.JeleniaTextBox.Location = New System.Drawing.Point(224, 495)
        Me.JeleniaTextBox.Name = "JeleniaTextBox"
        Me.JeleniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JeleniaTextBox.TabIndex = 34
        '
        'SrnciaTextBox
        '
        Me.SrnciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "srncia", True))
        Me.SrnciaTextBox.Location = New System.Drawing.Point(224, 521)
        Me.SrnciaTextBox.Name = "SrnciaTextBox"
        Me.SrnciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SrnciaTextBox.TabIndex = 36
        '
        'DiviaciaTextBox
        '
        Me.DiviaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "diviacia", True))
        Me.DiviaciaTextBox.Location = New System.Drawing.Point(224, 547)
        Me.DiviaciaTextBox.Name = "DiviaciaTextBox"
        Me.DiviaciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DiviaciaTextBox.TabIndex = 38
        '
        'BazantTextBox
        '
        Me.BazantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "bazant", True))
        Me.BazantTextBox.Location = New System.Drawing.Point(224, 573)
        Me.BazantTextBox.Name = "BazantTextBox"
        Me.BazantTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BazantTextBox.TabIndex = 40
        '
        'InaTextBox
        '
        Me.InaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ina", True))
        Me.InaTextBox.Location = New System.Drawing.Point(224, 599)
        Me.InaTextBox.Name = "InaTextBox"
        Me.InaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InaTextBox.TabIndex = 42
        '
        'StavaceTextBox
        '
        Me.StavaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "stavace", True))
        Me.StavaceTextBox.Location = New System.Drawing.Point(224, 625)
        Me.StavaceTextBox.Name = "StavaceTextBox"
        Me.StavaceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StavaceTextBox.TabIndex = 44
        '
        'SliediceTextBox
        '
        Me.SliediceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "sliedice", True))
        Me.SliediceTextBox.Location = New System.Drawing.Point(224, 651)
        Me.SliediceTextBox.Name = "SliediceTextBox"
        Me.SliediceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SliediceTextBox.TabIndex = 46
        '
        'Slovensky_kopovTextBox
        '
        Me.Slovensky_kopovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "slovensky_kopov", True))
        Me.Slovensky_kopovTextBox.Location = New System.Drawing.Point(224, 677)
        Me.Slovensky_kopovTextBox.Name = "Slovensky_kopovTextBox"
        Me.Slovensky_kopovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Slovensky_kopovTextBox.TabIndex = 48
        '
        'Ostatne_duriceTextBox
        '
        Me.Ostatne_duriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ostatne_durice", True))
        Me.Ostatne_duriceTextBox.Location = New System.Drawing.Point(224, 703)
        Me.Ostatne_duriceTextBox.Name = "Ostatne_duriceTextBox"
        Me.Ostatne_duriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ostatne_duriceTextBox.TabIndex = 50
        '
        'BrlohareTextBox
        '
        Me.BrlohareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "brlohare", True))
        Me.BrlohareTextBox.Location = New System.Drawing.Point(224, 729)
        Me.BrlohareTextBox.Name = "BrlohareTextBox"
        Me.BrlohareTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BrlohareTextBox.TabIndex = 52
        '
        'FarbiareTextBox
        '
        Me.FarbiareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "farbiare", True))
        Me.FarbiareTextBox.Location = New System.Drawing.Point(224, 755)
        Me.FarbiareTextBox.Name = "FarbiareTextBox"
        Me.FarbiareTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FarbiareTextBox.TabIndex = 54
        '
        'Pes_jeleniaTextBox
        '
        Me.Pes_jeleniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_jelenia", True))
        Me.Pes_jeleniaTextBox.Location = New System.Drawing.Point(224, 781)
        Me.Pes_jeleniaTextBox.Name = "Pes_jeleniaTextBox"
        Me.Pes_jeleniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pes_jeleniaTextBox.TabIndex = 56
        '
        'Pes_diviaciaTextBox
        '
        Me.Pes_diviaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_diviacia", True))
        Me.Pes_diviaciaTextBox.Location = New System.Drawing.Point(224, 807)
        Me.Pes_diviaciaTextBox.Name = "Pes_diviaciaTextBox"
        Me.Pes_diviaciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pes_diviaciaTextBox.TabIndex = 58
        '
        'Pes_srnciaTextBox
        '
        Me.Pes_srnciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_srncia", True))
        Me.Pes_srnciaTextBox.Location = New System.Drawing.Point(224, 833)
        Me.Pes_srnciaTextBox.Name = "Pes_srnciaTextBox"
        Me.Pes_srnciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pes_srnciaTextBox.TabIndex = 60
        '
        'Pes_malaTextBox
        '
        Me.Pes_malaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "pes_mala", True))
        Me.Pes_malaTextBox.Location = New System.Drawing.Point(224, 859)
        Me.Pes_malaTextBox.Name = "Pes_malaTextBox"
        Me.Pes_malaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Pes_malaTextBox.TabIndex = 62
        '
        'Platnost_najomnej_zmluvy_doDateTimePicker
        '
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ZdruzenieBindingSource, "platnost_najomnej_zmluvy_do", True))
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Location = New System.Drawing.Point(224, 885)
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Name = "Platnost_najomnej_zmluvy_doDateTimePicker"
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Platnost_najomnej_zmluvy_doDateTimePicker.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(499, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'detaily_zdruzenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(629, 778)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
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
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
