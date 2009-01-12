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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edituj_clena))
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
        Dim Clen_pzLabel As System.Windows.Forms.Label
        Me.Spz_evidenciaDataSet = New evidencia_spz.spz_evidenciaDataSet
        Me.ClenoviaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClenoviaTableAdapter = New evidencia_spz.spz_evidenciaDataSetTableAdapters.clenoviaTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spz_evidenciaDataSetTableAdapters.TableAdapterManager
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
        Me.TitulComboBox = New System.Windows.Forms.ComboBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.Okres_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.BydliskoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Statna_prislusnostComboBox = New System.Windows.Forms.ComboBox
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
        Me.Skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_z__polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Skuska_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox = New System.Windows.Forms.TextBox
        Me.Vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox = New System.Windows.Forms.TextBox
        Me.Brokova_zbranCheckBox = New System.Windows.Forms.CheckBox
        Me.Kontrolne_strelby_brokTextBox = New System.Windows.Forms.TextBox
        Me.Gulova_zbranCheckBox = New System.Windows.Forms.CheckBox
        Me.Kontrolne_strelby_gulova_zbranTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IIITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_IITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ITextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ZKTextBox = New System.Windows.Forms.TextBox
        Me.Vyznamenanie_ineTextBox = New System.Windows.Forms.TextBox
        Me.Udelene_trestyTextBox = New System.Windows.Forms.TextBox
        Me.PoznamkyTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaTextBox = New System.Windows.Forms.TextBox
        Me.NarodnostComboBox = New System.Windows.Forms.ComboBox
        Me.Clen_pzTextBox = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Clen_pzLabel = New System.Windows.Forms.Label
        CType(Me.Spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClenoviaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ClenoviaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClenoviaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClenoviaBindingNavigatorSaveItem})
        Me.ClenoviaBindingNavigator.Location = New System.Drawing.Point(0, 860)
        Me.ClenoviaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClenoviaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClenoviaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClenoviaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClenoviaBindingNavigator.Name = "ClenoviaBindingNavigator"
        Me.ClenoviaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClenoviaBindingNavigator.Size = New System.Drawing.Size(735, 25)
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
        TitulLabel.Location = New System.Drawing.Point(12, 64)
        TitulLabel.Name = "TitulLabel"
        TitulLabel.Size = New System.Drawing.Size(26, 13)
        TitulLabel.TabIndex = 3
        TitulLabel.Text = "titul:"
        '
        'TitulComboBox
        '
        Me.TitulComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "titul", True))
        Me.TitulComboBox.FormattingEnabled = True
        Me.TitulComboBox.Location = New System.Drawing.Point(44, 56)
        Me.TitulComboBox.Name = "TitulComboBox"
        Me.TitulComboBox.Size = New System.Drawing.Size(80, 21)
        Me.TitulComboBox.TabIndex = 4
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(130, 64)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 5
        MenoLabel.Text = "meno:"
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(172, 57)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MenoTextBox.TabIndex = 6
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(299, 64)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 7
        PriezviskoLabel.Text = "priezvisko:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(12, 116)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 9
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "rodne_cislo", True))
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(79, 113)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Rodne_cisloTextBox.TabIndex = 10
        '
        'Miesto_narodeniaLabel
        '
        Miesto_narodeniaLabel.AutoSize = True
        Miesto_narodeniaLabel.Location = New System.Drawing.Point(12, 161)
        Miesto_narodeniaLabel.Name = "Miesto_narodeniaLabel"
        Miesto_narodeniaLabel.Size = New System.Drawing.Size(90, 13)
        Miesto_narodeniaLabel.TabIndex = 11
        Miesto_narodeniaLabel.Text = "miesto narodenia:"
        '
        'Miesto_narodeniaTextBox
        '
        Me.Miesto_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_narodenia", True))
        Me.Miesto_narodeniaTextBox.Location = New System.Drawing.Point(108, 154)
        Me.Miesto_narodeniaTextBox.Name = "Miesto_narodeniaTextBox"
        Me.Miesto_narodeniaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Miesto_narodeniaTextBox.TabIndex = 12
        '
        'Okres_narodeniaLabel
        '
        Okres_narodeniaLabel.AutoSize = True
        Okres_narodeniaLabel.Location = New System.Drawing.Point(235, 161)
        Okres_narodeniaLabel.Name = "Okres_narodeniaLabel"
        Okres_narodeniaLabel.Size = New System.Drawing.Size(86, 13)
        Okres_narodeniaLabel.TabIndex = 13
        Okres_narodeniaLabel.Text = "okres narodenia:"
        '
        'Okres_narodeniaTextBox
        '
        Me.Okres_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "okres_narodenia", True))
        Me.Okres_narodeniaTextBox.Location = New System.Drawing.Point(327, 154)
        Me.Okres_narodeniaTextBox.Name = "Okres_narodeniaTextBox"
        Me.Okres_narodeniaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Okres_narodeniaTextBox.TabIndex = 14
        '
        'BydliskoLabel
        '
        BydliskoLabel.AutoSize = True
        BydliskoLabel.Location = New System.Drawing.Point(12, 207)
        BydliskoLabel.Name = "BydliskoLabel"
        BydliskoLabel.Size = New System.Drawing.Size(48, 13)
        BydliskoLabel.TabIndex = 15
        BydliskoLabel.Text = "bydlisko:"
        '
        'BydliskoTextBox
        '
        Me.BydliskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "bydlisko", True))
        Me.BydliskoTextBox.Location = New System.Drawing.Point(66, 200)
        Me.BydliskoTextBox.Name = "BydliskoTextBox"
        Me.BydliskoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BydliskoTextBox.TabIndex = 16
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(206, 207)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 17
        PscLabel.Text = "psc:"
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(239, 200)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PscTextBox.TabIndex = 18
        '
        'Statna_prislusnostLabel
        '
        Statna_prislusnostLabel.AutoSize = True
        Statna_prislusnostLabel.Location = New System.Drawing.Point(12, 245)
        Statna_prislusnostLabel.Name = "Statna_prislusnostLabel"
        Statna_prislusnostLabel.Size = New System.Drawing.Size(91, 13)
        Statna_prislusnostLabel.TabIndex = 19
        Statna_prislusnostLabel.Text = "statna prislusnost:"
        '
        'Statna_prislusnostComboBox
        '
        Me.Statna_prislusnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "statna_prislusnost", True))
        Me.Statna_prislusnostComboBox.FormattingEnabled = True
        Me.Statna_prislusnostComboBox.Location = New System.Drawing.Point(109, 237)
        Me.Statna_prislusnostComboBox.Name = "Statna_prislusnostComboBox"
        Me.Statna_prislusnostComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Statna_prislusnostComboBox.TabIndex = 20
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(12, 296)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 21
        Cislo_opLabel.Text = "cislo op:"
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_op", True))
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(66, 293)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_opTextBox.TabIndex = 22
        '
        'Datum_vydania_opLabel
        '
        Datum_vydania_opLabel.AutoSize = True
        Datum_vydania_opLabel.Location = New System.Drawing.Point(202, 296)
        Datum_vydania_opLabel.Name = "Datum_vydania_opLabel"
        Datum_vydania_opLabel.Size = New System.Drawing.Size(94, 13)
        Datum_vydania_opLabel.TabIndex = 23
        Datum_vydania_opLabel.Text = "datum vydania op:"
        '
        'Datum_vydania_opTextBox
        '
        Me.Datum_vydania_opTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_op", True))
        Me.Datum_vydania_opTextBox.Location = New System.Drawing.Point(302, 289)
        Me.Datum_vydania_opTextBox.Name = "Datum_vydania_opTextBox"
        Me.Datum_vydania_opTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Datum_vydania_opTextBox.TabIndex = 24
        '
        'Cislo_plLabel
        '
        Cislo_plLabel.AutoSize = True
        Cislo_plLabel.Location = New System.Drawing.Point(12, 329)
        Cislo_plLabel.Name = "Cislo_plLabel"
        Cislo_plLabel.Size = New System.Drawing.Size(42, 13)
        Cislo_plLabel.TabIndex = 25
        Cislo_plLabel.Text = "cislo pl:"
        '
        'Cislo_plTextBox
        '
        Me.Cislo_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_pl", True))
        Me.Cislo_plTextBox.Location = New System.Drawing.Point(66, 322)
        Me.Cislo_plTextBox.Name = "Cislo_plTextBox"
        Me.Cislo_plTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_plTextBox.TabIndex = 26
        '
        'Datum_vydania_plLabel
        '
        Datum_vydania_plLabel.AutoSize = True
        Datum_vydania_plLabel.Location = New System.Drawing.Point(202, 329)
        Datum_vydania_plLabel.Name = "Datum_vydania_plLabel"
        Datum_vydania_plLabel.Size = New System.Drawing.Size(90, 13)
        Datum_vydania_plLabel.TabIndex = 27
        Datum_vydania_plLabel.Text = "datum vydania pl:"
        '
        'Datum_vydania_plTextBox
        '
        Me.Datum_vydania_plTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_pl", True))
        Me.Datum_vydania_plTextBox.Location = New System.Drawing.Point(302, 326)
        Me.Datum_vydania_plTextBox.Name = "Datum_vydania_plTextBox"
        Me.Datum_vydania_plTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Datum_vydania_plTextBox.TabIndex = 28
        '
        'Cislo_zpLabel
        '
        Cislo_zpLabel.AutoSize = True
        Cislo_zpLabel.Location = New System.Drawing.Point(12, 361)
        Cislo_zpLabel.Name = "Cislo_zpLabel"
        Cislo_zpLabel.Size = New System.Drawing.Size(45, 13)
        Cislo_zpLabel.TabIndex = 29
        Cislo_zpLabel.Text = "cislo zp:"
        '
        'Cislo_zpTextBox
        '
        Me.Cislo_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_zp", True))
        Me.Cislo_zpTextBox.Location = New System.Drawing.Point(66, 354)
        Me.Cislo_zpTextBox.Name = "Cislo_zpTextBox"
        Me.Cislo_zpTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_zpTextBox.TabIndex = 30
        '
        'Datum_vydania_zpLabel
        '
        Datum_vydania_zpLabel.AutoSize = True
        Datum_vydania_zpLabel.Location = New System.Drawing.Point(202, 361)
        Datum_vydania_zpLabel.Name = "Datum_vydania_zpLabel"
        Datum_vydania_zpLabel.Size = New System.Drawing.Size(93, 13)
        Datum_vydania_zpLabel.TabIndex = 31
        Datum_vydania_zpLabel.Text = "datum vydania zp:"
        '
        'Datum_vydania_zpTextBox
        '
        Me.Datum_vydania_zpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_vydania_zp", True))
        Me.Datum_vydania_zpTextBox.Location = New System.Drawing.Point(302, 354)
        Me.Datum_vydania_zpTextBox.Name = "Datum_vydania_zpTextBox"
        Me.Datum_vydania_zpTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Datum_vydania_zpTextBox.TabIndex = 32
        '
        'Cislo_clenskeho_preukazu_spzLabel
        '
        Cislo_clenskeho_preukazu_spzLabel.AutoSize = True
        Cislo_clenskeho_preukazu_spzLabel.Location = New System.Drawing.Point(12, 406)
        Cislo_clenskeho_preukazu_spzLabel.Name = "Cislo_clenskeho_preukazu_spzLabel"
        Cislo_clenskeho_preukazu_spzLabel.Size = New System.Drawing.Size(149, 13)
        Cislo_clenskeho_preukazu_spzLabel.TabIndex = 33
        Cislo_clenskeho_preukazu_spzLabel.Text = "cislo clenskeho preukazu spz:"
        '
        'Cislo_clenskeho_preukazu_spzTextBox
        '
        Me.Cislo_clenskeho_preukazu_spzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_clenskeho_preukazu_spz", True))
        Me.Cislo_clenskeho_preukazu_spzTextBox.Location = New System.Drawing.Point(167, 399)
        Me.Cislo_clenskeho_preukazu_spzTextBox.Name = "Cislo_clenskeho_preukazu_spzTextBox"
        Me.Cislo_clenskeho_preukazu_spzTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_clenskeho_preukazu_spzTextBox.TabIndex = 34
        '
        'Clen_spz_odLabel
        '
        Clen_spz_odLabel.AutoSize = True
        Clen_spz_odLabel.Location = New System.Drawing.Point(12, 439)
        Clen_spz_odLabel.Name = "Clen_spz_odLabel"
        Clen_spz_odLabel.Size = New System.Drawing.Size(64, 13)
        Clen_spz_odLabel.TabIndex = 35
        Clen_spz_odLabel.Text = "clen spz od:"
        '
        'Clen_spz_odTextBox
        '
        Me.Clen_spz_odTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_spz_od", True))
        Me.Clen_spz_odTextBox.Location = New System.Drawing.Point(82, 432)
        Me.Clen_spz_odTextBox.Name = "Clen_spz_odTextBox"
        Me.Clen_spz_odTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Clen_spz_odTextBox.TabIndex = 36
        '
        'Clenske_doLabel
        '
        Clenske_doLabel.AutoSize = True
        Clenske_doLabel.Location = New System.Drawing.Point(209, 439)
        Clenske_doLabel.Name = "Clenske_doLabel"
        Clenske_doLabel.Size = New System.Drawing.Size(62, 13)
        Clenske_doLabel.TabIndex = 37
        Clenske_doLabel.Text = "clenske do:"
        '
        'Clenske_doTextBox
        '
        Me.Clenske_doTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clenske_do", True))
        Me.Clenske_doTextBox.Location = New System.Drawing.Point(277, 432)
        Me.Clenske_doTextBox.Name = "Clenske_doTextBox"
        Me.Clenske_doTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Clenske_doTextBox.TabIndex = 38
        '
        'Cislo_dokladu_clenskeLabel
        '
        Cislo_dokladu_clenskeLabel.AutoSize = True
        Cislo_dokladu_clenskeLabel.Location = New System.Drawing.Point(12, 472)
        Cislo_dokladu_clenskeLabel.Name = "Cislo_dokladu_clenskeLabel"
        Cislo_dokladu_clenskeLabel.Size = New System.Drawing.Size(112, 13)
        Cislo_dokladu_clenskeLabel.TabIndex = 39
        Cislo_dokladu_clenskeLabel.Text = "cislo dokladu clenske:"
        '
        'Cislo_dokladu_clenskeTextBox
        '
        Me.Cislo_dokladu_clenskeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "cislo_dokladu_clenske", True))
        Me.Cislo_dokladu_clenskeTextBox.Location = New System.Drawing.Point(130, 465)
        Me.Cislo_dokladu_clenskeTextBox.Name = "Cislo_dokladu_clenskeTextBox"
        Me.Cislo_dokladu_clenskeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cislo_dokladu_clenskeTextBox.TabIndex = 40
        '
        'Skuska_z_polovnictvaLabel
        '
        Skuska_z_polovnictvaLabel.AutoSize = True
        Skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(14, 527)
        Skuska_z_polovnictvaLabel.Name = "Skuska_z_polovnictvaLabel"
        Skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(110, 13)
        Skuska_z_polovnictvaLabel.TabIndex = 41
        Skuska_z_polovnictvaLabel.Text = "skuska z polovnictva:"
        '
        'Skuska_z_polovnictvaTextBox
        '
        Me.Skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_z_polovnictva", True))
        Me.Skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(130, 520)
        Me.Skuska_z_polovnictvaTextBox.Name = "Skuska_z_polovnictvaTextBox"
        Me.Skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Skuska_z_polovnictvaTextBox.TabIndex = 42
        '
        'Miesto_skusky_z__polovnictvaLabel
        '
        Miesto_skusky_z__polovnictvaLabel.AutoSize = True
        Miesto_skusky_z__polovnictvaLabel.Location = New System.Drawing.Point(257, 527)
        Miesto_skusky_z__polovnictvaLabel.Name = "Miesto_skusky_z__polovnictvaLabel"
        Miesto_skusky_z__polovnictvaLabel.Size = New System.Drawing.Size(145, 13)
        Miesto_skusky_z__polovnictvaLabel.TabIndex = 43
        Miesto_skusky_z__polovnictvaLabel.Text = "miesto skusky z  polovnictva:"
        '
        'Miesto_skusky_z__polovnictvaTextBox
        '
        Me.Miesto_skusky_z__polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_z _polovnictva", True))
        Me.Miesto_skusky_z__polovnictvaTextBox.Location = New System.Drawing.Point(408, 520)
        Me.Miesto_skusky_z__polovnictvaTextBox.Name = "Miesto_skusky_z__polovnictvaTextBox"
        Me.Miesto_skusky_z__polovnictvaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Miesto_skusky_z__polovnictvaTextBox.TabIndex = 44
        '
        'Skuska_pre_polovnych_hospodarovLabel
        '
        Skuska_pre_polovnych_hospodarovLabel.AutoSize = True
        Skuska_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(12, 561)
        Skuska_pre_polovnych_hospodarovLabel.Name = "Skuska_pre_polovnych_hospodarovLabel"
        Skuska_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(173, 13)
        Skuska_pre_polovnych_hospodarovLabel.TabIndex = 45
        Skuska_pre_polovnych_hospodarovLabel.Text = "skuska pre polovnych hospodarov:"
        '
        'Skuska_pre_polovnych_hospodarovTextBox
        '
        Me.Skuska_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "skuska_pre_polovnych_hospodarov", True))
        Me.Skuska_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(191, 554)
        Me.Skuska_pre_polovnych_hospodarovTextBox.Name = "Skuska_pre_polovnych_hospodarovTextBox"
        Me.Skuska_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Skuska_pre_polovnych_hospodarovTextBox.TabIndex = 46
        '
        'Miesto_skusky_pre_polovnych_hospodarovLabel
        '
        Miesto_skusky_pre_polovnych_hospodarovLabel.AutoSize = True
        Miesto_skusky_pre_polovnych_hospodarovLabel.Location = New System.Drawing.Point(318, 557)
        Miesto_skusky_pre_polovnych_hospodarovLabel.Name = "Miesto_skusky_pre_polovnych_hospodarovLabel"
        Miesto_skusky_pre_polovnych_hospodarovLabel.Size = New System.Drawing.Size(205, 13)
        Miesto_skusky_pre_polovnych_hospodarovLabel.TabIndex = 47
        Miesto_skusky_pre_polovnych_hospodarovLabel.Text = "miesto skusky pre polovnych hospodarov:"
        '
        'Miesto_skusky_pre_polovnych_hospodarovTextBox
        '
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_skusky_pre_polovnych_hospodarov", True))
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Location = New System.Drawing.Point(529, 550)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Name = "Miesto_skusky_pre_polovnych_hospodarovTextBox"
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Miesto_skusky_pre_polovnych_hospodarovTextBox.TabIndex = 48
        '
        'Vyzsia_skuska_z_polovnictvaLabel
        '
        Vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(12, 587)
        Vyzsia_skuska_z_polovnictvaLabel.Name = "Vyzsia_skuska_z_polovnictvaLabel"
        Vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(142, 13)
        Vyzsia_skuska_z_polovnictvaLabel.TabIndex = 49
        Vyzsia_skuska_z_polovnictvaLabel.Text = "vyzsia skuska z polovnictva:"
        '
        'Vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyzsia_skuska_z_polovnictva", True))
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(191, 587)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Name = "Vyzsia_skuska_z_polovnictvaTextBox"
        Me.Vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 50
        '
        'Miesto_vyzsia_skuska_z_polovnictvaLabel
        '
        Miesto_vyzsia_skuska_z_polovnictvaLabel.AutoSize = True
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Location = New System.Drawing.Point(318, 594)
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Name = "Miesto_vyzsia_skuska_z_polovnictvaLabel"
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Size = New System.Drawing.Size(175, 13)
        Miesto_vyzsia_skuska_z_polovnictvaLabel.TabIndex = 51
        Miesto_vyzsia_skuska_z_polovnictvaLabel.Text = "miesto vyzsia skuska z polovnictva:"
        '
        'Miesto_vyzsia_skuska_z_polovnictvaTextBox
        '
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "miesto_vyzsia_skuska_z_polovnictva", True))
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Location = New System.Drawing.Point(529, 594)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Name = "Miesto_vyzsia_skuska_z_polovnictvaTextBox"
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox.TabIndex = 52
        '
        'Brokova_zbranLabel
        '
        Brokova_zbranLabel.AutoSize = True
        Brokova_zbranLabel.Location = New System.Drawing.Point(14, 647)
        Brokova_zbranLabel.Name = "Brokova_zbranLabel"
        Brokova_zbranLabel.Size = New System.Drawing.Size(78, 13)
        Brokova_zbranLabel.TabIndex = 53
        Brokova_zbranLabel.Text = "brokova zbran:"
        '
        'Brokova_zbranCheckBox
        '
        Me.Brokova_zbranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClenoviaBindingSource, "brokova_zbran", True))
        Me.Brokova_zbranCheckBox.Location = New System.Drawing.Point(98, 642)
        Me.Brokova_zbranCheckBox.Name = "Brokova_zbranCheckBox"
        Me.Brokova_zbranCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Brokova_zbranCheckBox.TabIndex = 54
        Me.Brokova_zbranCheckBox.Text = "CheckBox1"
        Me.Brokova_zbranCheckBox.UseVisualStyleBackColor = True
        '
        'Kontrolne_strelby_brokLabel
        '
        Kontrolne_strelby_brokLabel.AutoSize = True
        Kontrolne_strelby_brokLabel.Location = New System.Drawing.Point(225, 647)
        Kontrolne_strelby_brokLabel.Name = "Kontrolne_strelby_brokLabel"
        Kontrolne_strelby_brokLabel.Size = New System.Drawing.Size(111, 13)
        Kontrolne_strelby_brokLabel.TabIndex = 55
        Kontrolne_strelby_brokLabel.Text = "kontrolne strelby brok:"
        '
        'Kontrolne_strelby_brokTextBox
        '
        Me.Kontrolne_strelby_brokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_brok", True))
        Me.Kontrolne_strelby_brokTextBox.Location = New System.Drawing.Point(355, 640)
        Me.Kontrolne_strelby_brokTextBox.Name = "Kontrolne_strelby_brokTextBox"
        Me.Kontrolne_strelby_brokTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Kontrolne_strelby_brokTextBox.TabIndex = 56
        '
        'Gulova_zbranLabel
        '
        Gulova_zbranLabel.AutoSize = True
        Gulova_zbranLabel.Location = New System.Drawing.Point(14, 686)
        Gulova_zbranLabel.Name = "Gulova_zbranLabel"
        Gulova_zbranLabel.Size = New System.Drawing.Size(71, 13)
        Gulova_zbranLabel.TabIndex = 57
        Gulova_zbranLabel.Text = "gulova zbran:"
        '
        'Gulova_zbranCheckBox
        '
        Me.Gulova_zbranCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClenoviaBindingSource, "gulova_zbran", True))
        Me.Gulova_zbranCheckBox.Location = New System.Drawing.Point(98, 686)
        Me.Gulova_zbranCheckBox.Name = "Gulova_zbranCheckBox"
        Me.Gulova_zbranCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.Gulova_zbranCheckBox.TabIndex = 58
        Me.Gulova_zbranCheckBox.Text = "CheckBox1"
        Me.Gulova_zbranCheckBox.UseVisualStyleBackColor = True
        '
        'Kontrolne_strelby_gulova_zbranLabel
        '
        Kontrolne_strelby_gulova_zbranLabel.AutoSize = True
        Kontrolne_strelby_gulova_zbranLabel.Location = New System.Drawing.Point(225, 686)
        Kontrolne_strelby_gulova_zbranLabel.Name = "Kontrolne_strelby_gulova_zbranLabel"
        Kontrolne_strelby_gulova_zbranLabel.Size = New System.Drawing.Size(151, 13)
        Kontrolne_strelby_gulova_zbranLabel.TabIndex = 59
        Kontrolne_strelby_gulova_zbranLabel.Text = "kontrolne strelby gulova zbran:"
        '
        'Kontrolne_strelby_gulova_zbranTextBox
        '
        Me.Kontrolne_strelby_gulova_zbranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "kontrolne_strelby_gulova_zbran", True))
        Me.Kontrolne_strelby_gulova_zbranTextBox.Location = New System.Drawing.Point(382, 679)
        Me.Kontrolne_strelby_gulova_zbranTextBox.Name = "Kontrolne_strelby_gulova_zbranTextBox"
        Me.Kontrolne_strelby_gulova_zbranTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Kontrolne_strelby_gulova_zbranTextBox.TabIndex = 60
        '
        'Vyznamenanie_IIILabel
        '
        Vyznamenanie_IIILabel.AutoSize = True
        Vyznamenanie_IIILabel.Location = New System.Drawing.Point(12, 740)
        Vyznamenanie_IIILabel.Name = "Vyznamenanie_IIILabel"
        Vyznamenanie_IIILabel.Size = New System.Drawing.Size(90, 13)
        Vyznamenanie_IIILabel.TabIndex = 61
        Vyznamenanie_IIILabel.Text = "vyznamenanie III:"
        '
        'Vyznamenanie_IIITextBox
        '
        Me.Vyznamenanie_IIITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_III", True))
        Me.Vyznamenanie_IIITextBox.Location = New System.Drawing.Point(113, 736)
        Me.Vyznamenanie_IIITextBox.Name = "Vyznamenanie_IIITextBox"
        Me.Vyznamenanie_IIITextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyznamenanie_IIITextBox.TabIndex = 62
        '
        'Vyznamenanie_IILabel
        '
        Vyznamenanie_IILabel.AutoSize = True
        Vyznamenanie_IILabel.Location = New System.Drawing.Point(12, 769)
        Vyznamenanie_IILabel.Name = "Vyznamenanie_IILabel"
        Vyznamenanie_IILabel.Size = New System.Drawing.Size(87, 13)
        Vyznamenanie_IILabel.TabIndex = 63
        Vyznamenanie_IILabel.Text = "vyznamenanie II:"
        '
        'Vyznamenanie_IITextBox
        '
        Me.Vyznamenanie_IITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_II", True))
        Me.Vyznamenanie_IITextBox.Location = New System.Drawing.Point(113, 762)
        Me.Vyznamenanie_IITextBox.Name = "Vyznamenanie_IITextBox"
        Me.Vyznamenanie_IITextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyznamenanie_IITextBox.TabIndex = 64
        '
        'Vyznamenanie_ILabel
        '
        Vyznamenanie_ILabel.AutoSize = True
        Vyznamenanie_ILabel.Location = New System.Drawing.Point(12, 795)
        Vyznamenanie_ILabel.Name = "Vyznamenanie_ILabel"
        Vyznamenanie_ILabel.Size = New System.Drawing.Size(84, 13)
        Vyznamenanie_ILabel.TabIndex = 65
        Vyznamenanie_ILabel.Text = "vyznamenanie I:"
        '
        'Vyznamenanie_ITextBox
        '
        Me.Vyznamenanie_ITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_I", True))
        Me.Vyznamenanie_ITextBox.Location = New System.Drawing.Point(113, 788)
        Me.Vyznamenanie_ITextBox.Name = "Vyznamenanie_ITextBox"
        Me.Vyznamenanie_ITextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyznamenanie_ITextBox.TabIndex = 66
        '
        'Vyznamenanie_ZKLabel
        '
        Vyznamenanie_ZKLabel.AutoSize = True
        Vyznamenanie_ZKLabel.Location = New System.Drawing.Point(12, 821)
        Vyznamenanie_ZKLabel.Name = "Vyznamenanie_ZKLabel"
        Vyznamenanie_ZKLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ZKLabel.TabIndex = 67
        Vyznamenanie_ZKLabel.Text = "vyznamenanie ZK:"
        '
        'Vyznamenanie_ZKTextBox
        '
        Me.Vyznamenanie_ZKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ZK", True))
        Me.Vyznamenanie_ZKTextBox.Location = New System.Drawing.Point(113, 814)
        Me.Vyznamenanie_ZKTextBox.Name = "Vyznamenanie_ZKTextBox"
        Me.Vyznamenanie_ZKTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyznamenanie_ZKTextBox.TabIndex = 68
        '
        'Vyznamenanie_ineLabel
        '
        Vyznamenanie_ineLabel.AutoSize = True
        Vyznamenanie_ineLabel.Location = New System.Drawing.Point(12, 847)
        Vyznamenanie_ineLabel.Name = "Vyznamenanie_ineLabel"
        Vyznamenanie_ineLabel.Size = New System.Drawing.Size(95, 13)
        Vyznamenanie_ineLabel.TabIndex = 69
        Vyznamenanie_ineLabel.Text = "vyznamenanie ine:"
        '
        'Vyznamenanie_ineTextBox
        '
        Me.Vyznamenanie_ineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "vyznamenanie_ine", True))
        Me.Vyznamenanie_ineTextBox.Location = New System.Drawing.Point(113, 840)
        Me.Vyznamenanie_ineTextBox.Name = "Vyznamenanie_ineTextBox"
        Me.Vyznamenanie_ineTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Vyznamenanie_ineTextBox.TabIndex = 70
        '
        'Udelene_trestyLabel
        '
        Udelene_trestyLabel.AutoSize = True
        Udelene_trestyLabel.Location = New System.Drawing.Point(275, 743)
        Udelene_trestyLabel.Name = "Udelene_trestyLabel"
        Udelene_trestyLabel.Size = New System.Drawing.Size(76, 13)
        Udelene_trestyLabel.TabIndex = 71
        Udelene_trestyLabel.Text = "udelene tresty:"
        '
        'Udelene_trestyTextBox
        '
        Me.Udelene_trestyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "udelene_tresty", True))
        Me.Udelene_trestyTextBox.Location = New System.Drawing.Point(486, 740)
        Me.Udelene_trestyTextBox.Multiline = True
        Me.Udelene_trestyTextBox.Name = "Udelene_trestyTextBox"
        Me.Udelene_trestyTextBox.Size = New System.Drawing.Size(237, 68)
        Me.Udelene_trestyTextBox.TabIndex = 72
        '
        'PoznamkyLabel
        '
        PoznamkyLabel.AutoSize = True
        PoznamkyLabel.Location = New System.Drawing.Point(275, 821)
        PoznamkyLabel.Name = "PoznamkyLabel"
        PoznamkyLabel.Size = New System.Drawing.Size(58, 13)
        PoznamkyLabel.TabIndex = 73
        PoznamkyLabel.Text = "poznamky:"
        '
        'PoznamkyTextBox
        '
        Me.PoznamkyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "poznamky", True))
        Me.PoznamkyTextBox.Location = New System.Drawing.Point(486, 818)
        Me.PoznamkyTextBox.Multiline = True
        Me.PoznamkyTextBox.Name = "PoznamkyTextBox"
        Me.PoznamkyTextBox.Size = New System.Drawing.Size(237, 42)
        Me.PoznamkyTextBox.TabIndex = 74
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(206, 120)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(89, 13)
        Datum_narodeniaLabel.TabIndex = 75
        Datum_narodeniaLabel.Text = "datum narodenia:"
        '
        'Datum_narodeniaTextBox
        '
        Me.Datum_narodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "datum_narodenia", True))
        Me.Datum_narodeniaTextBox.Location = New System.Drawing.Point(302, 113)
        Me.Datum_narodeniaTextBox.Name = "Datum_narodeniaTextBox"
        Me.Datum_narodeniaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Datum_narodeniaTextBox.TabIndex = 76
        '
        'NarodnostLabel
        '
        NarodnostLabel.AutoSize = True
        NarodnostLabel.Location = New System.Drawing.Point(255, 245)
        NarodnostLabel.Name = "NarodnostLabel"
        NarodnostLabel.Size = New System.Drawing.Size(57, 13)
        NarodnostLabel.TabIndex = 77
        NarodnostLabel.Text = "narodnost:"
        '
        'NarodnostComboBox
        '
        Me.NarodnostComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "narodnost", True))
        Me.NarodnostComboBox.FormattingEnabled = True
        Me.NarodnostComboBox.Location = New System.Drawing.Point(318, 237)
        Me.NarodnostComboBox.Name = "NarodnostComboBox"
        Me.NarodnostComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NarodnostComboBox.TabIndex = 78
        '
        'Clen_pzLabel
        '
        Clen_pzLabel.AutoSize = True
        Clen_pzLabel.Location = New System.Drawing.Point(318, 406)
        Clen_pzLabel.Name = "Clen_pzLabel"
        Clen_pzLabel.Size = New System.Drawing.Size(44, 13)
        Clen_pzLabel.TabIndex = 79
        Clen_pzLabel.Text = "clen pz:"
        '
        'Clen_pzTextBox
        '
        Me.Clen_pzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "clen_pz", True))
        Me.Clen_pzTextBox.Location = New System.Drawing.Point(372, 403)
        Me.Clen_pzTextBox.Name = "Clen_pzTextBox"
        Me.Clen_pzTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Clen_pzTextBox.TabIndex = 80
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClenoviaBindingSource
        Me.ComboBox1.DisplayMember = "priezvisko"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(362, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 81
        Me.ComboBox1.ValueMember = "priezvisko"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 37)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Vyberte clena podla priezviska"
        '
        'edituj_clena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(752, 812)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.Controls.Add(Me.Datum_vydania_opTextBox)
        Me.Controls.Add(Cislo_plLabel)
        Me.Controls.Add(Me.Cislo_plTextBox)
        Me.Controls.Add(Datum_vydania_plLabel)
        Me.Controls.Add(Me.Datum_vydania_plTextBox)
        Me.Controls.Add(Cislo_zpLabel)
        Me.Controls.Add(Me.Cislo_zpTextBox)
        Me.Controls.Add(Datum_vydania_zpLabel)
        Me.Controls.Add(Me.Datum_vydania_zpTextBox)
        Me.Controls.Add(Cislo_clenskeho_preukazu_spzLabel)
        Me.Controls.Add(Me.Cislo_clenskeho_preukazu_spzTextBox)
        Me.Controls.Add(Clen_spz_odLabel)
        Me.Controls.Add(Me.Clen_spz_odTextBox)
        Me.Controls.Add(Clenske_doLabel)
        Me.Controls.Add(Me.Clenske_doTextBox)
        Me.Controls.Add(Cislo_dokladu_clenskeLabel)
        Me.Controls.Add(Me.Cislo_dokladu_clenskeTextBox)
        Me.Controls.Add(Skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Miesto_skusky_z__polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_skusky_z__polovnictvaTextBox)
        Me.Controls.Add(Skuska_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Skuska_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Miesto_skusky_pre_polovnych_hospodarovLabel)
        Me.Controls.Add(Me.Miesto_skusky_pre_polovnych_hospodarovTextBox)
        Me.Controls.Add(Vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Miesto_vyzsia_skuska_z_polovnictvaLabel)
        Me.Controls.Add(Me.Miesto_vyzsia_skuska_z_polovnictvaTextBox)
        Me.Controls.Add(Brokova_zbranLabel)
        Me.Controls.Add(Me.Brokova_zbranCheckBox)
        Me.Controls.Add(Kontrolne_strelby_brokLabel)
        Me.Controls.Add(Me.Kontrolne_strelby_brokTextBox)
        Me.Controls.Add(Gulova_zbranLabel)
        Me.Controls.Add(Me.Gulova_zbranCheckBox)
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
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaTextBox)
        Me.Controls.Add(NarodnostLabel)
        Me.Controls.Add(Me.NarodnostComboBox)
        Me.Controls.Add(Clen_pzLabel)
        Me.Controls.Add(Me.Clen_pzTextBox)
        Me.Controls.Add(Me.ClenoviaBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edituj_clena"
        Me.Text = "edituj_clena"
        CType(Me.Spz_evidenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClenoviaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClenoviaBindingNavigator.ResumeLayout(False)
        Me.ClenoviaBindingNavigator.PerformLayout()
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
    Friend WithEvents TitulComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Okres_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BydliskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Statna_prislusnostComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents Skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_z__polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Skuska_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_skusky_pre_polovnych_hospodarovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Miesto_vyzsia_skuska_z_polovnictvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Brokova_zbranCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Kontrolne_strelby_brokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gulova_zbranCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Kontrolne_strelby_gulova_zbranTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IIITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_IITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ZKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vyznamenanie_ineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Udelene_trestyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PoznamkyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NarodnostComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Clen_pzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
