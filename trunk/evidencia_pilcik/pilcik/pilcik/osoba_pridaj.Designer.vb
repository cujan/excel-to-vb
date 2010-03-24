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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ulozButton = New System.Windows.Forms.Button
        Me.PilcikdbDataSet = New pilcik.pilcikdbDataSet
        Me.OsobaTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.osobaTableAdapter
        Me.TableAdapterManager = New pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager
        Me.KurzTableAdapter = New pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
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
        Me.OsobaBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OsobaDataGridView = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitulpredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriezviskoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DatumnarodeniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RodnecisloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CisloopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UlicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PscDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CislopilcickehopreukazuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdkurzuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NazovDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.kurzComboBox = New System.Windows.Forms.ComboBox
        Me.KurzComboDataSet = New pilcik.kurzComboDataSet
        Me.KurzTableAdapter1 = New pilcik.kurzComboDataSetTableAdapters.kurzTableAdapter
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzComboDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titul_predLabel
        '
        Titul_predLabel.AutoSize = True
        Titul_predLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Titul_predLabel.Location = New System.Drawing.Point(28, 21)
        Titul_predLabel.Name = "Titul_predLabel"
        Titul_predLabel.Size = New System.Drawing.Size(32, 13)
        Titul_predLabel.TabIndex = 4
        Titul_predLabel.Text = "Titul"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        PriezviskoLabel.Location = New System.Drawing.Point(97, 21)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(69, 13)
        PriezviskoLabel.TabIndex = 6
        PriezviskoLabel.Text = "Priezvisko:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        MenoLabel.Location = New System.Drawing.Point(303, 21)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(42, 13)
        MenoLabel.TabIndex = 8
        MenoLabel.Text = "Meno:"
        '
        'Datum_narodeniaLabel
        '
        Datum_narodeniaLabel.AutoSize = True
        Datum_narodeniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Datum_narodeniaLabel.Location = New System.Drawing.Point(250, 92)
        Datum_narodeniaLabel.Name = "Datum_narodeniaLabel"
        Datum_narodeniaLabel.Size = New System.Drawing.Size(107, 13)
        Datum_narodeniaLabel.TabIndex = 10
        Datum_narodeniaLabel.Text = "Dátum narodenia:"
        '
        'Rodne_cisloLabel
        '
        Rodne_cisloLabel.AutoSize = True
        Rodne_cisloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Rodne_cisloLabel.Location = New System.Drawing.Point(26, 92)
        Rodne_cisloLabel.Name = "Rodne_cisloLabel"
        Rodne_cisloLabel.Size = New System.Drawing.Size(80, 13)
        Rodne_cisloLabel.TabIndex = 12
        Rodne_cisloLabel.Text = "Rodné číslo:"
        '
        'Cislo_opLabel
        '
        Cislo_opLabel.AutoSize = True
        Cislo_opLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Cislo_opLabel.Location = New System.Drawing.Point(346, 154)
        Cislo_opLabel.Name = "Cislo_opLabel"
        Cislo_opLabel.Size = New System.Drawing.Size(58, 13)
        Cislo_opLabel.TabIndex = 14
        Cislo_opLabel.Text = "Číslo op:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        UlicaLabel.Location = New System.Drawing.Point(6, 16)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(40, 13)
        UlicaLabel.TabIndex = 16
        UlicaLabel.Text = "Ulica:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        MestoLabel.Location = New System.Drawing.Point(6, 80)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(45, 13)
        MestoLabel.TabIndex = 18
        MestoLabel.Text = "Mesto:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        PscLabel.Location = New System.Drawing.Point(228, 80)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(31, 13)
        PscLabel.TabIndex = 20
        PscLabel.Text = "PSČ"
        '
        'Cislo_pilcickeho_preukazuLabel
        '
        Cislo_pilcickeho_preukazuLabel.AutoSize = True
        Cislo_pilcickeho_preukazuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Cislo_pilcickeho_preukazuLabel.Location = New System.Drawing.Point(346, 207)
        Cislo_pilcickeho_preukazuLabel.Name = "Cislo_pilcickeho_preukazuLabel"
        Cislo_pilcickeho_preukazuLabel.Size = New System.Drawing.Size(156, 13)
        Cislo_pilcickeho_preukazuLabel.TabIndex = 22
        Cislo_pilcickeho_preukazuLabel.Text = "Číslo pilčíckeho preukazu"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        EmailLabel.Location = New System.Drawing.Point(346, 255)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 13)
        EmailLabel.TabIndex = 24
        EmailLabel.Text = "E-mail:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        TelefonLabel.Location = New System.Drawing.Point(346, 305)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(54, 13)
        TelefonLabel.TabIndex = 26
        TelefonLabel.Text = "Telefón:"
        '
        'Titul_predTextBox
        '
        Me.Titul_predTextBox.Location = New System.Drawing.Point(29, 37)
        Me.Titul_predTextBox.Name = "Titul_predTextBox"
        Me.Titul_predTextBox.Size = New System.Drawing.Size(49, 20)
        Me.Titul_predTextBox.TabIndex = 0
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(100, 37)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PriezviskoTextBox.TabIndex = 1
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(306, 37)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MenoTextBox.TabIndex = 2
        '
        'Datum_narodeniaDateTimePicker
        '
        Me.Datum_narodeniaDateTimePicker.Checked = False
        Me.Datum_narodeniaDateTimePicker.Location = New System.Drawing.Point(253, 110)
        Me.Datum_narodeniaDateTimePicker.Name = "Datum_narodeniaDateTimePicker"
        Me.Datum_narodeniaDateTimePicker.ShowCheckBox = True
        Me.Datum_narodeniaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Datum_narodeniaDateTimePicker.TabIndex = 4
        '
        'Rodne_cisloTextBox
        '
        Me.Rodne_cisloTextBox.Location = New System.Drawing.Point(31, 111)
        Me.Rodne_cisloTextBox.Name = "Rodne_cisloTextBox"
        Me.Rodne_cisloTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Rodne_cisloTextBox.TabIndex = 3
        '
        'Cislo_opTextBox
        '
        Me.Cislo_opTextBox.Location = New System.Drawing.Point(349, 173)
        Me.Cislo_opTextBox.Name = "Cislo_opTextBox"
        Me.Cislo_opTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_opTextBox.TabIndex = 6
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(9, 32)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(147, 20)
        Me.UlicaTextBox.TabIndex = 0
        '
        'MestoTextBox
        '
        Me.MestoTextBox.Location = New System.Drawing.Point(6, 96)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MestoTextBox.TabIndex = 1
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(212, 96)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PscTextBox.TabIndex = 2
        '
        'Cislo_pilcickeho_preukazuTextBox
        '
        Me.Cislo_pilcickeho_preukazuTextBox.Location = New System.Drawing.Point(349, 223)
        Me.Cislo_pilcickeho_preukazuTextBox.Name = "Cislo_pilcickeho_preukazuTextBox"
        Me.Cislo_pilcickeho_preukazuTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cislo_pilcickeho_preukazuTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(349, 271)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(196, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(349, 321)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(196, 20)
        Me.TelefonTextBox.TabIndex = 9
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
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bydlisko"
        '
        'ulozButton
        '
        Me.ulozButton.Location = New System.Drawing.Point(325, 352)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 11
        Me.ulozButton.Text = "Ulož"
        Me.ulozButton.UseVisualStyleBackColor = True
        '
        'PilcikdbDataSet
        '
        Me.PilcikdbDataSet.DataSetName = "pilcikdbDataSet"
        Me.PilcikdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaTableAdapter
        '
        Me.OsobaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.kurzTableAdapter = Me.KurzTableAdapter
        Me.TableAdapterManager.skusobna_komisiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pilcik.pilcikdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
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
        'OsobaBindingSource1BindingNavigatorSaveItem
        '
        Me.OsobaBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Name = "OsobaBindingSource1BindingNavigatorSaveItem"
        Me.OsobaBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
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
        Me.OsobaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TitulpredDataGridViewTextBoxColumn, Me.PriezviskoDataGridViewTextBoxColumn, Me.MenoDataGridViewTextBoxColumn, Me.DatumnarodeniaDataGridViewTextBoxColumn, Me.RodnecisloDataGridViewTextBoxColumn, Me.CisloopDataGridViewTextBoxColumn, Me.UlicaDataGridViewTextBoxColumn, Me.MestoDataGridViewTextBoxColumn, Me.PscDataGridViewTextBoxColumn, Me.CislopilcickehopreukazuDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonDataGridViewTextBoxColumn, Me.IdkurzuDataGridViewTextBoxColumn, Me.NazovDataGridViewTextBoxColumn})
        Me.OsobaDataGridView.DataSource = Me.BindingSource1
        Me.OsobaDataGridView.Location = New System.Drawing.Point(12, 381)
        Me.OsobaDataGridView.Name = "OsobaDataGridView"
        Me.OsobaDataGridView.ReadOnly = True
        Me.OsobaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OsobaDataGridView.Size = New System.Drawing.Size(907, 300)
        Me.OsobaDataGridView.TabIndex = 32
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitulpredDataGridViewTextBoxColumn
        '
        Me.TitulpredDataGridViewTextBoxColumn.DataPropertyName = "titul_pred"
        Me.TitulpredDataGridViewTextBoxColumn.HeaderText = "titul_pred"
        Me.TitulpredDataGridViewTextBoxColumn.Name = "TitulpredDataGridViewTextBoxColumn"
        Me.TitulpredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriezviskoDataGridViewTextBoxColumn
        '
        Me.PriezviskoDataGridViewTextBoxColumn.DataPropertyName = "priezvisko"
        Me.PriezviskoDataGridViewTextBoxColumn.HeaderText = "priezvisko"
        Me.PriezviskoDataGridViewTextBoxColumn.Name = "PriezviskoDataGridViewTextBoxColumn"
        Me.PriezviskoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenoDataGridViewTextBoxColumn
        '
        Me.MenoDataGridViewTextBoxColumn.DataPropertyName = "meno"
        Me.MenoDataGridViewTextBoxColumn.HeaderText = "meno"
        Me.MenoDataGridViewTextBoxColumn.Name = "MenoDataGridViewTextBoxColumn"
        Me.MenoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatumnarodeniaDataGridViewTextBoxColumn
        '
        Me.DatumnarodeniaDataGridViewTextBoxColumn.DataPropertyName = "datum_narodenia"
        Me.DatumnarodeniaDataGridViewTextBoxColumn.HeaderText = "datum_narodenia"
        Me.DatumnarodeniaDataGridViewTextBoxColumn.Name = "DatumnarodeniaDataGridViewTextBoxColumn"
        Me.DatumnarodeniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RodnecisloDataGridViewTextBoxColumn
        '
        Me.RodnecisloDataGridViewTextBoxColumn.DataPropertyName = "rodne_cislo"
        Me.RodnecisloDataGridViewTextBoxColumn.HeaderText = "rodne_cislo"
        Me.RodnecisloDataGridViewTextBoxColumn.Name = "RodnecisloDataGridViewTextBoxColumn"
        Me.RodnecisloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CisloopDataGridViewTextBoxColumn
        '
        Me.CisloopDataGridViewTextBoxColumn.DataPropertyName = "cislo_op"
        Me.CisloopDataGridViewTextBoxColumn.HeaderText = "cislo_op"
        Me.CisloopDataGridViewTextBoxColumn.Name = "CisloopDataGridViewTextBoxColumn"
        Me.CisloopDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UlicaDataGridViewTextBoxColumn
        '
        Me.UlicaDataGridViewTextBoxColumn.DataPropertyName = "ulica"
        Me.UlicaDataGridViewTextBoxColumn.HeaderText = "ulica"
        Me.UlicaDataGridViewTextBoxColumn.Name = "UlicaDataGridViewTextBoxColumn"
        Me.UlicaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MestoDataGridViewTextBoxColumn
        '
        Me.MestoDataGridViewTextBoxColumn.DataPropertyName = "mesto"
        Me.MestoDataGridViewTextBoxColumn.HeaderText = "mesto"
        Me.MestoDataGridViewTextBoxColumn.Name = "MestoDataGridViewTextBoxColumn"
        Me.MestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PscDataGridViewTextBoxColumn
        '
        Me.PscDataGridViewTextBoxColumn.DataPropertyName = "psc"
        Me.PscDataGridViewTextBoxColumn.HeaderText = "psc"
        Me.PscDataGridViewTextBoxColumn.Name = "PscDataGridViewTextBoxColumn"
        Me.PscDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CislopilcickehopreukazuDataGridViewTextBoxColumn
        '
        Me.CislopilcickehopreukazuDataGridViewTextBoxColumn.DataPropertyName = "cislo_pilcickeho_preukazu"
        Me.CislopilcickehopreukazuDataGridViewTextBoxColumn.HeaderText = "cislo_pilcickeho_preukazu"
        Me.CislopilcickehopreukazuDataGridViewTextBoxColumn.Name = "CislopilcickehopreukazuDataGridViewTextBoxColumn"
        Me.CislopilcickehopreukazuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonDataGridViewTextBoxColumn
        '
        Me.TelefonDataGridViewTextBoxColumn.DataPropertyName = "telefon"
        Me.TelefonDataGridViewTextBoxColumn.HeaderText = "telefon"
        Me.TelefonDataGridViewTextBoxColumn.Name = "TelefonDataGridViewTextBoxColumn"
        Me.TelefonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdkurzuDataGridViewTextBoxColumn
        '
        Me.IdkurzuDataGridViewTextBoxColumn.DataPropertyName = "id_kurzu"
        Me.IdkurzuDataGridViewTextBoxColumn.HeaderText = "id_kurzu"
        Me.IdkurzuDataGridViewTextBoxColumn.Name = "IdkurzuDataGridViewTextBoxColumn"
        Me.IdkurzuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NazovDataGridViewTextBoxColumn
        '
        Me.NazovDataGridViewTextBoxColumn.DataPropertyName = "nazov"
        Me.NazovDataGridViewTextBoxColumn.HeaderText = "nazov"
        Me.NazovDataGridViewTextBoxColumn.Name = "NazovDataGridViewTextBoxColumn"
        Me.NazovDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "osoba"
        Me.BindingSource1.DataSource = Me.PilcikdbDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(625, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(406, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Zmaž člena"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(670, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(670, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(758, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Evidencia osôb"
        '
        'kurzComboBox
        '
        Me.kurzComboBox.DataSource = Me.BindingSource2
        Me.kurzComboBox.DisplayMember = "nazov_spolu"
        Me.kurzComboBox.FormattingEnabled = True
        Me.kurzComboBox.Location = New System.Drawing.Point(511, 109)
        Me.kurzComboBox.Name = "kurzComboBox"
        Me.kurzComboBox.Size = New System.Drawing.Size(270, 21)
        Me.kurzComboBox.TabIndex = 40
        Me.kurzComboBox.ValueMember = "id"
        '
        'KurzComboDataSet
        '
        Me.KurzComboDataSet.DataSetName = "kurzComboDataSet"
        Me.KurzComboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzTableAdapter1
        '
        Me.KurzTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "kurz"
        Me.BindingSource2.DataSource = Me.KurzComboDataSet
        '
        'osoba_pridaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 709)
        Me.Controls.Add(Me.kurzComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OsobaDataGridView)
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
        Me.Name = "osoba_pridaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "osoba_pridaj"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PilcikdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzComboDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KurzTableAdapter As pilcik.pilcikdbDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents kurzComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KurzComboDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzComboDataSet As pilcik.kurzComboDataSet
    Friend WithEvents KurzBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter1 As pilcik.kurzComboDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents KurzBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitulpredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriezviskoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatumnarodeniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RodnecisloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CisloopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UlicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PscDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CislopilcickehopreukazuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdkurzuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NazovDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
End Class
