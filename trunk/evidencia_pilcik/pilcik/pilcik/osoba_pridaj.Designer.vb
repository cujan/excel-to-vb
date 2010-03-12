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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(osoba_pridaj))
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
        Me.ulozButton = New System.Windows.Forms.Button
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.OsobaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.osobaTableAdapter
        Me.TableAdapterManager = New pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
        Me.OsobaBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OsobaBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OsobaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OsobaBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(97, 21)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 6
        PriezviskoLabel.Text = "priezvisko:"
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
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Location = New System.Drawing.Point(250, 92)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(89, 13)
        Datum_narodeniaLabel.TabIndex = 10
        Datum_narodeniaLabel.Text = "datum narodenia:"
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
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Location = New System.Drawing.Point(487, 92)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(46, 13)
        Cislo_opLabel.TabIndex = 14
        Cislo_opLabel.Text = "cislo op:"
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
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(6, 80)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 18
        MestoLabel.Text = "mesto:"
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
        'Cislo_pilcickeho_preukazuLabel
        '
        Cislo_pilcickeho_preukazuLabel.AutoSize = True
        Cislo_pilcickeho_preukazuLabel.Location = New System.Drawing.Point(487, 138)
        Cislo_pilcickeho_preukazuLabel.Name = "Cislo_pilcickeho_preukazuLabel"
        Cislo_pilcickeho_preukazuLabel.Size = New System.Drawing.Size(129, 13)
        Cislo_pilcickeho_preukazuLabel.TabIndex = 22
        Cislo_pilcickeho_preukazuLabel.Text = "cislo pilcickeho preukazu:"
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
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(511, 282)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 26
        TelefonLabel.Text = "telefon:"
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
        'Titul_predTextBox
        '
        Me.Titul_predTextBox.Location = New System.Drawing.Point(29, 37)
        Me.Titul_predTextBox.Name = "Titul_predTextBox"
        Me.Titul_predTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Titul_predTextBox.TabIndex = 5
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(100, 37)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 7
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(306, 37)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 9
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(253, 110)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 11
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(31, 111)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 13
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(490, 111)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 15
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(9, 32)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.UlicaTextBox.TabIndex = 17
        '
        'MestoTextBox
        '
        Me.MestoTextBox.Location = New System.Drawing.Point(6, 96)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MestoTextBox.TabIndex = 19
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(212, 96)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PscTextBox.TabIndex = 21
        '
        'Cislo_pilcickeho_preukazuTextBox
        '
        Me.Cislo_pilcickeho_preukazuTextBox.Location = New System.Drawing.Point(490, 154)
        Me.Cislo_pilcickeho_preukazuTextBox.Name = "Cislo_pilcickeho_preukazuTextBox"
        Me.Cislo_pilcickeho_preukazuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_pilcickeho_preukazuTextBox.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(514, 250)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 25
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(514, 308)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 27
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
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(778, 250)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 31
        Me.ulozButton.Text = "Ulož"
        Me.ulozButton.UseVisualStyleBackColor = True
        '
        'PilcikdbDataSet
        '
        Me.PilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.PilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaBindingSource1
        '
        Me.OsobaBindingSource1.DataMember = "osoba"
        Me.OsobaBindingSource1.DataSource = Me.PilcikdbDataSet
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
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OsobaBindingSource1BindingNavigator
        '
        Me.OsobaBindingSource1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OsobaBindingSource1BindingNavigator.BindingSource = Me.OsobaBindingSource1
        Me.OsobaBindingSource1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OsobaBindingSource1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OsobaBindingSource1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OsobaBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OsobaBindingSource1BindingNavigatorSaveItem})
        Me.OsobaBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 667)
        Me.OsobaBindingSource1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OsobaBindingSource1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OsobaBindingSource1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OsobaBindingSource1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OsobaBindingSource1BindingNavigator.Name = "OsobaBindingSource1BindingNavigator"
        Me.OsobaBindingSource1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OsobaBindingSource1BindingNavigator.Size = New System.Drawing.Size(923, 25)
        Me.OsobaBindingSource1BindingNavigator.TabIndex = 32
        Me.OsobaBindingSource1BindingNavigator.Text = "BindingNavigator1"
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
        'OsobaBindingSource1BindingNavigatorSaveItem
        '
        Me.OsobaBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Name = "OsobaBindingSource1BindingNavigatorSaveItem"
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
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
        Me.OsobaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.OsobaDataGridView.DataSource = Me.OsobaBindingSource1
        Me.OsobaDataGridView.Location = New System.Drawing.Point(12, 381)
        Me.OsobaDataGridView.Name = "OsobaDataGridView"
        Me.OsobaDataGridView.ReadOnly = True
        Me.OsobaDataGridView.Size = New System.Drawing.Size(899, 283)
        Me.OsobaDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "titul_pred"
        Me.DataGridViewTextBoxColumn15.HeaderText = "titul_pred"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn16.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn17.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "datum_narodenia"
        Me.DataGridViewTextBoxColumn18.HeaderText = "datum_narodenia"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "rodne_cislo"
        Me.DataGridViewTextBoxColumn19.HeaderText = "rodne_cislo"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "cislo_op"
        Me.DataGridViewTextBoxColumn20.HeaderText = "cislo_op"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn22.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn23.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "cislo_pilcickeho_preukazu"
        Me.DataGridViewTextBoxColumn24.HeaderText = "cislo_pilcickeho_preukazu"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn25.HeaderText = "email"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "telefon"
        Me.DataGridViewTextBoxColumn26.HeaderText = "telefon"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "id_kurzu"
        Me.DataGridViewTextBoxColumn27.HeaderText = "id_kurzu"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'osoba_pridaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 692)
        Me.Controls.Add(Me.OsobaDataGridView)
        Me.Controls.Add(Me.OsobaBindingSource1BindingNavigator)
        Me.Controls.Add(Me.ulozButton)
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
        Me.Name = "osoba_pridaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "osoba_pridaj"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OsobaBindingSource1BindingNavigator.ResumeLayout(False)
        Me.OsobaBindingSource1BindingNavigator.PerformLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    
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
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents PilcikdbDataSet As pilcik.pilcikdbDataSet
    Friend WithEvents OsobaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaTableAdapter As pilcik.pilcikdbDataSetTableAdapters.osobaTableAdapter
    Friend WithEvents TableAdapterManager As pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OsobaBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OsobaBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OsobaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
