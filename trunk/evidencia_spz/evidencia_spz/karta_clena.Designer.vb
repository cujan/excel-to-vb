<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karta_clena
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(karta_clena))
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
        Me.ClenoviaDataSet = New evidencia_spz.clenoviaDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.clenoviaDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.clenoviaDataSetTableAdapters.TableAdapterManager
        Me.ClenoviaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ClenoviaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
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
        Me.Miesto_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Brokova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.TitulComboBox = New System.Windows.Forms.ComboBox
        Me.Statna_prislusnostComboBox = New System.Windows.Forms.ComboBox
        Me.Vyznamenanie_ineTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ZKTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IIITextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Kontrolne_strelby_brokova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
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
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(1141, 25)
        Me.ClenoviaBindingNavigator.TabIndex = 0
        Me.ClenoviaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ClenoviaBindingNavigatorSaveItem
        '
        Me.ClenoviaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClenoviaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClenoviaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClenoviaBindingNavigatorSaveItem.Name = "ClenoviaBindingNavigatorSaveItem"
        Me.ClenoviaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ClenoviaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitulLabel
        '
        TitulLabel.AutoSize = True
        TitulLabel.Location = New System.Drawing.Point(50, 45)
        TitulLabel.Name = "TitulLabel"
        TitulLabel.Size = New System.Drawing.Size(30, 13)
        TitulLabel.TabIndex = 3
        TitulLabel.Text = "Titul:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(166, 45)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "meno:"
        AddHandler MenoLabel.Click, AddressOf Me.MenoLabel_Click
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(208, 38)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(414, 45)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 7
        PriezviskoLabel.Text = "priezvisko:"
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "priezvisko", True))
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(477, 38)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 8
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(50, 104)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(147, 101)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 10
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(51, 141)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(90, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "miesto narodenia:"
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_narodenia", True))
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(147, 138)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(353, 145)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(86, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "okres narodenia:"
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_narodenia", True))
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(445, 138)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(51, 218)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(48, 13)
        BydliskoLabel.TabIndex = 15
        BydliskoLabel.Text = "bydlisko:"
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "bydlisko", True))
        Me.BydliskoTextBox.Location = New System.Drawing.Point(105, 211)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BydliskoTextBox.TabIndex = 16
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(311, 214)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 17
        PscLabel.Text = "psc:"
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(344, 207)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PscTextBox.TabIndex = 18
        '
        'Statna_prislusnostLabel
        '
        Statna_prislusnostLabel.AutoSize = True
        Statna_prislusnostLabel.Location = New System.Drawing.Point(51, 251)
        Statna_prislusnostLabel.Name = "Statna_prislusnostLabel"
        Statna_prislusnostLabel.Size = New System.Drawing.Size(91, 13)
        Statna_prislusnostLabel.TabIndex = 19
        Statna_prislusnostLabel.Text = "statna prislusnost:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(50, 304)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 21
        Cislo_opLabel.Text = "cislo op:"
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(102, 301)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 22
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(308, 308)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(94, 13)
        Datum_vydania_opLabel.TabIndex = 23
        Datum_vydania_opLabel.Text = "datum vydania op:"
        '
        'Datum_vydania_opDateTimePicker
        '
        Me.Datum_vydania_opDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_op", True))
        Me.Datum_vydania_opDateTimePicker.Location = New System.Drawing.Point(408, 301)
        Me.Datum_vydania_opDateTimePicker.Name = "Datum_vydania_opDateTimePicker"
        Me.Datum_vydania_opDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_opDateTimePicker.TabIndex = 24
        Me.Datum_vydania_opDateTimePicker.Value = New Date(2008, 11, 29, 0, 0, 0, 0)
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(50, 334)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(42, 13)
        Cislo_plLabel.TabIndex = 25
        Cislo_plLabel.Text = "cislo pl:"
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_pl", True))
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(102, 334)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_plTextBox.TabIndex = 26
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(308, 337)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(90, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "datum vydania pl:"
        '
        'Datum_vydania_plDateTimePicker
        '
        Me.Datum_vydania_plDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_pl", True))
        Me.Datum_vydania_plDateTimePicker.Location = New System.Drawing.Point(408, 334)
        Me.Datum_vydania_plDateTimePicker.Name = "Datum_vydania_plDateTimePicker"
        Me.Datum_vydania_plDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_plDateTimePicker.TabIndex = 28
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(50, 373)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(45, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "cislo zp:"
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_zp", True))
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(101, 370)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(311, 377)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(93, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "datum vydania zp:"
        '
        'Datum_vydania_zpDateTimePicker
        '
        Me.Datum_vydania_zpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "datum_vydania_zp", True))
        Me.Datum_vydania_zpDateTimePicker.Location = New System.Drawing.Point(408, 370)
        Me.Datum_vydania_zpDateTimePicker.Name = "Datum_vydania_zpDateTimePicker"
        Me.Datum_vydania_zpDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_vydania_zpDateTimePicker.TabIndex = 32
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(50, 433)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(149, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "cislo clenskeho preukazu spz:"
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_clenskeho_preukazu_spz", True))
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(205, 426)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(51, 470)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(64, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "clen spz od:"
        '
        'Clen_spz_odDateTimePicker
        '
        Me.Clen_spz_odDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "clen_spz_od", True))
        Me.Clen_spz_odDateTimePicker.Location = New System.Drawing.Point(121, 466)
        Me.Clen_spz_odDateTimePicker.Name = "Clen_spz_odDateTimePicker"
        Me.Clen_spz_odDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Clen_spz_odDateTimePicker.TabIndex = 36
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(51, 503)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(62, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "clenske do:"
        '
        'Clenske_doDateTimePicker
        '
        Me.Clenske_doDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClenoviaBindingSource, "clenske_do", True))
        Me.Clenske_doDateTimePicker.Location = New System.Drawing.Point(119, 499)
        Me.Clenske_doDateTimePicker.Name = "Clenske_doDateTimePicker"
        Me.Clenske_doDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Clenske_doDateTimePicker.TabIndex = 38
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(51, 540)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(112, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "cislo dokladu clenske:"
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_dokladu_clenske", True))
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(169, 533)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(51, 567)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(44, 13)
        Clen_pzLabel.TabIndex = 41
        Clen_pzLabel.Text = "clen pz:"
        '
        'Clen_pzTextBox
        '
        Me.Clen_pzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_pz", True))
        Me.Clen_pzTextBox.Location = New System.Drawing.Point(102, 564)
        Me.Clen_pzTextBox.Name = "Clen_pzTextBox"
        Me.Clen_pzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Clen_pzTextBox.TabIndex = 42
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(50, 631)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(110, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 43
        Skuska_z_polovnictvaLabel.Text = "skuska z polovnictva:"
        '
        'Miesto_skusky_z_polovnictvaLabel
        '
        Miesto_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(435, 631)
        Miesto_skusky_z_polovnictvaLabel.Name = "Miesto_skusky_z_polovnictvaLabel"
        Miesto_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Miesto_skusky_z_polovnictvaLabel.TabIndex = 45
        Miesto_skusky_z_polovnictvaLabel.Text = "miesto skusky z polovnictva:"
        '
        'Miesto_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_skusky_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_z_polovnictva", True))
        Me.Miesto_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(646, 628)
        Me.Miesto_skusky_z_polovnictvaTextBox.Name = "Miesto_skusky_z_polovnictvaTextBox"
        Me.Miesto_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_z_polovnictvaTextBox.TabIndex = 46
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(50, 662)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(173, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 47
        Skuska_pre_polovnych_hospodarovLabel.Text = "skuska pre polovnych hospodarov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(435, 662)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(205, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 49
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "miesto skusky pre polovnych hospodarov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_pre_polovnych_hospodarov", True))
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(646, 659)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 50
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(51, 693)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Vyzsia_skuska_z_polovnictvaLabel.Text = "vyzsia skuska z polovnictva:"
        '
        'Miesto_vyzsej_skusky_z_polovnictvaLabel
        '
        Miesto_vyzsej_skusky_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Location = New System.Drawing.Point(435, 693)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Name = "Miesto_vyzsej_skusky_z_polovnictvaLabel"
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Size = New System.Drawing.Size(174, 13)
        Miesto_vyzsej_skusky_z_polovnictvaLabel.TabIndex = 53
        Miesto_vyzsej_skusky_z_polovnictvaLabel.Text = "miesto vyzsej skusky z polovnictva:"
        '
        'Miesto_vyzsej_skusky_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_vyzsej_skusky_z_polovnictva", True))
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Location = New System.Drawing.Point(646, 687)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Name = "Miesto_vyzsej_skusky_z_polovnictvaTextBox"
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox.TabIndex = 54
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(50, 786)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(78, 13)
        Brokova_zbranLabel.TabIndex = 55
        Brokova_zbranLabel.Text = "brokova zbran:"
        '
        'Brokova_zbranTextBox
        '
        Me.Brokova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "brokova_zbran", True))
        Me.Brokova_zbranTextBox.Location = New System.Drawing.Point(138, 779)
        Me.Brokova_zbranTextBox.Name = "Brokova_zbranTextBox"
        Me.Brokova_zbranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Brokova_zbranTextBox.TabIndex = 56
        '
        'Kontrolne_strelby_brokova_zbranLabel
        '
        Kontrolne_strelby_brokova_zbranLabel.AutoSize = True
        Kontrolne_strelby_brokova_zbranLabel.Location = New System.Drawing.Point(354, 786)
        Kontrolne_strelby_brokova_zbranLabel.Name = "Kontrolne_strelby_brokova_zbranLabel"
        Kontrolne_strelby_brokova_zbranLabel.Size = New System.Drawing.Size(158, 13)
        Kontrolne_strelby_brokova_zbranLabel.TabIndex = 57
        Kontrolne_strelby_brokova_zbranLabel.Text = "kontrolne strelby brokova zbran:"
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(51, 818)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(71, 13)
        Gulova_zbranLabel.TabIndex = 59
        Gulova_zbranLabel.Text = "gulova zbran:"
        '
        'Gulova_zbranTextBox
        '
        Me.Gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "gulova_zbran", True))
        Me.Gulova_zbranTextBox.Location = New System.Drawing.Point(138, 815)
        Me.Gulova_zbranTextBox.Name = "Gulova_zbranTextBox"
        Me.Gulova_zbranTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Gulova_zbranTextBox.TabIndex = 60
        '
        'Kontrolne_strelby_gulova_zbranLabel
        '
        Kontrolne_strelby_gulova_zbranLabel.AutoSize = True
        Kontrolne_strelby_gulova_zbranLabel.Location = New System.Drawing.Point(354, 822)
        Kontrolne_strelby_gulova_zbranLabel.Name = "Kontrolne_strelby_gulova_zbranLabel"
        Kontrolne_strelby_gulova_zbranLabel.Size = New System.Drawing.Size(151, 13)
        Kontrolne_strelby_gulova_zbranLabel.TabIndex = 61
        Kontrolne_strelby_gulova_zbranLabel.Text = "kontrolne strelby gulova zbran:"
        '
        'Vyznamenanie_IIILabel
        '
        Vyznamenanie_IIILabel.AutoSize = True
        Vyznamenanie_IIILabel.Location = New System.Drawing.Point(51, 877)
        Vyznamenanie_IIILabel.Name = "Vyznamenanie_IIILabel"
        Vyznamenanie_IIILabel.Size = New System.Drawing.Size(90, 13)
        Vyznamenanie_IIILabel.TabIndex = 63
        Vyznamenanie_IIILabel.Text = "vyznamenanie III:"
        '
        'Vyznamenanie_IILabel
        '
        Vyznamenanie_IILabel.AutoSize = True
        Vyznamenanie_IILabel.Location = New System.Drawing.Point(51, 903)
        Vyznamenanie_IILabel.Name = "Vyznamenanie_IILabel"
        Vyznamenanie_IILabel.Size = New System.Drawing.Size(87, 13)
        Vyznamenanie_IILabel.TabIndex = 65
        Vyznamenanie_IILabel.Text = "vyznamenanie II:"
        '
        'Vyznamenanie_ILabel
        '
        Vyznamenanie_ILabel.AutoSize = True
        Vyznamenanie_ILabel.Location = New System.Drawing.Point(51, 926)
        Vyznamenanie_ILabel.Name = "Vyznamenanie_ILabel"
        Vyznamenanie_ILabel.Size = New System.Drawing.Size(84, 13)
        Vyznamenanie_ILabel.TabIndex = 67
        Vyznamenanie_ILabel.Text = "vyznamenanie I:"
        '
        'Vyznamenanie_ZKLabel
        '
        Vyznamenanie_ZKLabel.AutoSize = True
        Vyznamenanie_ZKLabel.Location = New System.Drawing.Point(51, 952)
        Vyznamenanie_ZKLabel.Name = "Vyznamenanie_ZKLabel"
        Vyznamenanie_ZKLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ZKLabel.TabIndex = 69
        Vyznamenanie_ZKLabel.Text = "vyznamenanie ZK:"
        '
        'Vyznamenanie_ineLabel
        '
        Vyznamenanie_ineLabel.AutoSize = True
        Vyznamenanie_ineLabel.Location = New System.Drawing.Point(50, 978)
        Vyznamenanie_ineLabel.Name = "Vyznamenanie_ineLabel"
        Vyznamenanie_ineLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ineLabel.TabIndex = 71
        Vyznamenanie_ineLabel.Text = "vyznamenanie ine:"
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(50, 1020)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(76, 13)
        Udelene_trestyLabel.TabIndex = 73
        Udelene_trestyLabel.Text = "udelene tresty:"
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "udelene_tresty", True))
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(261, 1017)
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Udelene_trestyTextBox.TabIndex = 74
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(50, 1046)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(58, 13)
        PoznamkyLabel.TabIndex = 75
        PoznamkyLabel.Text = "poznamky:"
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "poznamky", True))
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(261, 1043)
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PoznamkyTextBox.TabIndex = 76
        '
        'TitulComboBox
        '
        Me.TitulComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul", True))
        Me.TitulComboBox.FormattingEnabled = True
        Me.TitulComboBox.Items.AddRange(New Object() {"Ing.", "Mgr."})
        Me.TitulComboBox.Location = New System.Drawing.Point(82, 37)
        Me.TitulComboBox.Name = "TitulComboBox"
        Me.TitulComboBox.Size = New System.Drawing.Size(78, 21)
        Me.TitulComboBox.TabIndex = 77
        '
        'Statna_prislusnostComboBox
        '
        Me.Statna_prislusnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "statna_prislusnost", True))
        Me.Statna_prislusnostComboBox.FormattingEnabled = True
        Me.Statna_prislusnostComboBox.Items.AddRange(New Object() {"SR", "CZ", "PL"})
        Me.Statna_prislusnostComboBox.Location = New System.Drawing.Point(148, 243)
        Me.Statna_prislusnostComboBox.Name = "Statna_prislusnostComboBox"
        Me.Statna_prislusnostComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Statna_prislusnostComboBox.TabIndex = 78
        '
        'Vyznamenanie_ineTextBox
        '
        Me.Vyznamenanie_ineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ine", True))
        Me.Vyznamenanie_ineTextBox.Location = New System.Drawing.Point(261, 978)
        Me.Vyznamenanie_ineTextBox.Name = "Vyznamenanie_ineTextBox"
        Me.Vyznamenanie_ineTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenanie_ineTextBox.TabIndex = 79
        '
        'Vyznamenanie_ZKTextBox
        '
        Me.Vyznamenanie_ZKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ZK", True))
        Me.Vyznamenanie_ZKTextBox.Location = New System.Drawing.Point(261, 952)
        Me.Vyznamenanie_ZKTextBox.Name = "Vyznamenanie_ZKTextBox"
        Me.Vyznamenanie_ZKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenanie_ZKTextBox.TabIndex = 80
        '
        'Vyznamenanie_ITextBox
        '
        Me.Vyznamenanie_ITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_I", True))
        Me.Vyznamenanie_ITextBox.Location = New System.Drawing.Point(261, 926)
        Me.Vyznamenanie_ITextBox.Name = "Vyznamenanie_ITextBox"
        Me.Vyznamenanie_ITextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenanie_ITextBox.TabIndex = 81
        '
        'Vyznamenanie_IITextBox
        '
        Me.Vyznamenanie_IITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_II", True))
        Me.Vyznamenanie_IITextBox.Location = New System.Drawing.Point(261, 900)
        Me.Vyznamenanie_IITextBox.Name = "Vyznamenanie_IITextBox"
        Me.Vyznamenanie_IITextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenanie_IITextBox.TabIndex = 82
        '
        'Vyznamenanie_IIITextBox
        '
        Me.Vyznamenanie_IIITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_III", True))
        Me.Vyznamenanie_IIITextBox.Location = New System.Drawing.Point(261, 877)
        Me.Vyznamenanie_IIITextBox.Name = "Vyznamenanie_IIITextBox"
        Me.Vyznamenanie_IIITextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyznamenanie_IIITextBox.TabIndex = 83
        '
        'Kontrolne_strelby_gulova_zbranTextBox
        '
        Me.Kontrolne_strelby_gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_gulova_zbran", True))
        Me.Kontrolne_strelby_gulova_zbranTextBox.Location = New System.Drawing.Point(518, 822)
        Me.Kontrolne_strelby_gulova_zbranTextBox.Name = "Kontrolne_strelby_gulova_zbranTextBox"
        Me.Kontrolne_strelby_gulova_zbranTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kontrolne_strelby_gulova_zbranTextBox.TabIndex = 84
        '
        'Kontrolne_strelby_brokova_zbranTextBox
        '
        Me.Kontrolne_strelby_brokova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_brokova_zbran", True))
        Me.Kontrolne_strelby_brokova_zbranTextBox.Location = New System.Drawing.Point(518, 786)
        Me.Kontrolne_strelby_brokova_zbranTextBox.Name = "Kontrolne_strelby_brokova_zbranTextBox"
        Me.Kontrolne_strelby_brokova_zbranTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kontrolne_strelby_brokova_zbranTextBox.TabIndex = 85
        '
        'Vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyzsia_skuska_z_polovnictva", True))
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(229, 690)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Name = "Vyzsia_skuska_z_polovnictvaTextBox"
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 86
        '
        'Skuska_pre_polovnych_hospodarovTextBox
        '
        Me.Skuska_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_pre_polovnych_hospodarov", True))
        Me.Skuska_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(229, 662)
        Me.Skuska_pre_polovnych_hospodarovTextBox.Name = "Skuska_pre_polovnych_hospodarovTextBox"
        Me.Skuska_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Skuska_pre_polovnych_hospodarovTextBox.TabIndex = 87
        '
        'Skuska_z_polovnictvaTextBox
        '
        Me.Skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_z_polovnictva", True))
        Me.Skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(229, 631)
        Me.Skuska_z_polovnictvaTextBox.Name = "Skuska_z_polovnictvaTextBox"
        Me.Skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Skuska_z_polovnictvaTextBox.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 635)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "napr. 28.10.1980"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(624, 789)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "napr. 28.10.1980"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 877)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "napr. 28.10.1980"
        '
        'evidencia_clenov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1158, 778)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Me.Kontrolne_strelby_brokova_zbranTextBox)
        Me.Controls.Add(Me.Kontrolne_strelby_gulova_zbranTextBox)
        Me.Controls.Add(Me.Vyznamenanie_IIITextBox)
        Me.Controls.Add(Me.Vyznamenanie_IITextBox)
        Me.Controls.Add(Me.Vyznamenanie_ITextBox)
        Me.Controls.Add(Me.Vyznamenanie_ZKTextBox)
        Me.Controls.Add(Me.Vyznamenanie_ineTextBox)
        Me.Controls.Add(Me.Statna_prislusnostComboBox)
        Me.Controls.Add(Me.TitulComboBox)
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
        Me.Controls.Add(Miesto_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Miesto_skusky_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Miesto_vyzsej_skusky_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_vyzsej_skusky_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Me.Brokova_zbranTextBox)
        Me.Controls.Add(Kontrolne_strelby_brokova_zbranLabel)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Me.Gulova_zbranTextBox)
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
        Me.Name = "evidencia_clenov"
        Me.Text = "evidencia_clenov"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClenoviaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
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
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Miesto_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_vyzsej_skusky_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brokova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitulComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Statna_prislusnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Vyznamenanie_ineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ZKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IIITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kontrolne_strelby_brokova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
