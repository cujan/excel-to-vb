<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class osoba_pridaj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(osoba_pridaj))
        Dim Titul_predLabel As System.Windows.Forms.Label
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim Datum_narodeniaLabel As System.Windows.Forms.Label
        Dim Rodne_cisloLabel As System.Windows.Forms.Label
        Dim Cislo_opLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim Cislo_pilcickeho_preukazuLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Id_kurzLabel As System.Windows.Forms.Label
        Me.Pilcik_dbDataSet = New pilcik.pilcik_dbDataSet
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaTableAdapter = New pilcik.pilcik_dbDataSetTableAdapters.osobaTableAdapter
        Me.TableAdapterManager = New pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager
        Me.OsobaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OsobaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OsobaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Titul_predTextBox = New System.Windows.Forms.TextBox
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox
        Me.MenoTextBox = New System.Windows.Forms.TextBox
        Me.Datum_narodeniaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Rodne_cisloTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_opTextBox = New System.Windows.Forms.TextBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_pilcickeho_preukazuTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.Id_kurzTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Titul_predLabel = New System.Windows.Forms.Label
        PriezviskoLabel = New System.Windows.Forms.Label
        MenoLabel = New System.Windows.Forms.Label
        Datum_narodeniaLabel = New System.Windows.Forms.Label
        Rodne_cisloLabel = New System.Windows.Forms.Label
        Cislo_opLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        Cislo_pilcickeho_preukazuLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        Id_kurzLabel = New System.Windows.Forms.Label
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OsobaBindingNavigator.SuspendLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pilcik_dbDataSet
        '
        Me.Pilcik_dbDataSet.DataSetName = "pilcik_dbDataSet"
        Me.Pilcik_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"
        Me.OsobaBindingSource.DataSource = Me.Pilcik_dbDataSet
        '
        'OsobaTableAdapter
        '
        Me.OsobaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kurzTableAdapter = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Me.OsobaTableAdapter
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OsobaBindingNavigator
        '
        Me.OsobaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OsobaBindingNavigator.BindingSource = Me.OsobaBindingSource
        Me.OsobaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OsobaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OsobaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OsobaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OsobaBindingNavigatorSaveItem})
        Me.OsobaBindingNavigator.Location = New System.Drawing.Point(0, 667)
        Me.OsobaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OsobaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OsobaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OsobaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OsobaBindingNavigator.Name = "OsobaBindingNavigator"
        Me.OsobaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OsobaBindingNavigator.Size = New System.Drawing.Size(915, 25)
        Me.OsobaBindingNavigator.TabIndex = 0
        Me.OsobaBindingNavigator.Text = "BindingNavigator1"
        Me.OsobaBindingNavigator.Visible = False
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
        'OsobaBindingNavigatorSaveItem
        '
        Me.OsobaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingNavigatorSaveItem.Name = "OsobaBindingNavigatorSaveItem"
        Me.OsobaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OsobaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OsobaDataGridView
        '
        Me.OsobaDataGridView.AllowUserToAddRows = False
        Me.OsobaDataGridView.AllowUserToDeleteRows = False
        Me.OsobaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OsobaDataGridView.AutoGenerateColumns = False
        Me.OsobaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OsobaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.OsobaDataGridView.DataSource = Me.OsobaBindingSource
        Me.OsobaDataGridView.Location = New System.Drawing.Point(12, 356)
        Me.OsobaDataGridView.Name = "OsobaDataGridView"
        Me.OsobaDataGridView.ReadOnly = True
        Me.OsobaDataGridView.Size = New System.Drawing.Size(899, 308)
        Me.OsobaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "titul_pred"
        Me.DataGridViewTextBoxColumn2.HeaderText = "titul_pred"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn3.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "datum_narodenia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "datum_narodenia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "rodne_cislo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "rodne_cislo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cislo_op"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cislo_op"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn10.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cislo_pilcickeho_preukazu"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cislo_pilcickeho_preukazu"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn12.HeaderText = "email"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "telefon"
        Me.DataGridViewTextBoxColumn13.HeaderText = "telefon"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "id_kurz"
        Me.DataGridViewTextBoxColumn14.HeaderText = "id_kurz"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Titul_predLabel
        '
        Titul_predLabel.AutoSize = True
        Titul_predLabel.Location = New System.Drawing.Point(28, 21)
        Titul_predLabel.Name = "Titul_predLabel"
        Titul_predLabel.Size = New System.Drawing.Size(50, 13)
        Titul_predLabel.TabIndex = 4
        Titul_predLabel.Text = "titul pred:"
        '
        'Titul_predTextBox
        '
        Me.Titul_predTextBox.Location = New System.Drawing.Point(29, 37)
        Me.Titul_predTextBox.Name = "Titul_predTextBox"
        Me.Titul_predTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Titul_predTextBox.TabIndex = 5
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(97, 21)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 6
        PriezviskoLabel.Text = "priezvisko:"
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(100, 37)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 7
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(303, 21)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 8
        MenoLabel.Text = "meno:"
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(306, 37)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 9
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(250, 92)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(89, 13)
        Datum_narodeniaLabel.TabIndex = 10
        Datum_narodeniaLabel.Text = "datum narodenia:"
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(253, 110)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 11
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Location = New System.Drawing.Point(26, 92)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(61, 13)
        Rodne_cisloLabel.TabIndex = 12
        Rodne_cisloLabel.Text = "rodne cislo:"
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(31, 111)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 13
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(487, 92)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 14
        Cislo_opLabel.Text = "cislo op:"
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(490, 111)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 15
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(6, 16)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 16
        UlicaLabel.Text = "ulica:"
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(9, 32)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.UlicaTextBox.TabIndex = 17
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(6, 80)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 18
        MestoLabel.Text = "mesto:"
        '
        'MestoTextBox
        '
        Me.MestoTextBox.Location = New System.Drawing.Point(6, 96)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MestoTextBox.TabIndex = 19
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(228, 80)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 20
        PscLabel.Text = "psc:"
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(212, 96)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PscTextBox.TabIndex = 21
        '
        'Cislo_pilcickeho_preukazuLabel
        '
        Cislo_pilcickeho_preukazuLabel.AutoSize = True
        Cislo_pilcickeho_preukazuLabel.Location = New System.Drawing.Point(487, 138)
        Cislo_pilcickeho_preukazuLabel.Name = "Cislo_pilcickeho_preukazuLabel"
        Cislo_pilcickeho_preukazuLabel.Size = New System.Drawing.Size(129, 13)
        Cislo_pilcickeho_preukazuLabel.TabIndex = 22
        Cislo_pilcickeho_preukazuLabel.Text = "cislo pilcickeho preukazu:"
        '
        'Cislo_pilcickeho_preukazuTextBox
        '
        Me.Cislo_pilcickeho_preukazuTextBox.Location = New System.Drawing.Point(490, 154)
        Me.Cislo_pilcickeho_preukazuTextBox.Name = "Cislo_pilcickeho_preukazuTextBox"
        Me.Cislo_pilcickeho_preukazuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_pilcickeho_preukazuTextBox.TabIndex = 23
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(511, 234)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(514, 250)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 25
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(511, 282)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 26
        TelefonLabel.Text = "telefon:"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(514, 308)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 27
        '
        'Id_kurzLabel
        '
        Id_kurzLabel.AutoSize = True
        Id_kurzLabel.Location = New System.Drawing.Point(597, 21)
        Id_kurzLabel.Name = "Id_kurzLabel"
        Id_kurzLabel.Size = New System.Drawing.Size(41, 13)
        Id_kurzLabel.TabIndex = 28
        Id_kurzLabel.Text = "id kurz:"
        '
        'Id_kurzTextBox
        '
        Me.Id_kurzTextBox.Location = New System.Drawing.Point(600, 37)
        Me.Id_kurzTextBox.Name = "Id_kurzTextBox"
        Me.Id_kurzTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Id_kurzTextBox.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(UlicaLabel)
        Me.GroupBox1.Controls.Add(Me.UlicaTextBox)
        Me.GroupBox1.Controls.Add(MestoLabel)
        Me.GroupBox1.Controls.Add(Me.MestoTextBox)
        Me.GroupBox1.Controls.Add(PscLabel)
        Me.GroupBox1.Controls.Add(Me.PscTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 183)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bydlisko"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(778, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Ulož"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'osoba_pridaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Titul_predLabel)
        Me.Controls.Add(Me.Titul_predTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(Datum_narodeniaLabel)
        Me.Controls.Add(Me.Datum_narodeniaDateTimePicker)
        Me.Controls.Add(Rodne_cisloLabel)
        Me.Controls.Add(Me.Rodne_cisloTextBox)
        Me.Controls.Add(Cislo_opLabel)
        Me.Controls.Add(Me.Cislo_opTextBox)
        Me.Controls.Add(Cislo_pilcickeho_preukazuLabel)
        Me.Controls.Add(Me.Cislo_pilcickeho_preukazuTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Id_kurzLabel)
        Me.Controls.Add(Me.Id_kurzTextBox)
        Me.Controls.Add(Me.OsobaDataGridView)
        Me.Controls.Add(Me.OsobaBindingNavigator)
        Me.Name = "osoba_pridaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "osoba_pridaj"
        CType(Me.Pilcik_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OsobaBindingNavigator.ResumeLayout(False)
        Me.OsobaBindingNavigator.PerformLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pilcik_dbDataSet As pilcik.pilcik_dbDataSet
    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaTableAdapter As pilcik.pilcik_dbDataSetTableAdapters.osobaTableAdapter
    Friend WithEvents TableAdapterManager As pilcik.pilcik_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OsobaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OsobaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OsobaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Titul_predTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Datum_narodeniaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rodne_cisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_opTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_pilcickeho_preukazuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_kurzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
