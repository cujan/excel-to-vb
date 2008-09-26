<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vseobecne_udaje
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
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim Cislo_uctuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vseobecne_udaje))
        Me.Vseobecne_udajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vseobecne_udajeDataSet1 = New lesnictvo.vseobecne_udajeDataSet1
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
        Me.Vseobecne_udajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NazovTextBox = New System.Windows.Forms.TextBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.Cislo_uctuTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Vseobecne_udajeTableAdapter = New lesnictvo.vseobecne_udajeDataSet1TableAdapters.vseobecne_udajeTableAdapter
        Me.TableAdapterManager = New lesnictvo.vseobecne_udajeDataSet1TableAdapters.TableAdapterManager
        Me.Database1DataSet1 = New lesnictvo.Database1DataSet1
        Me.Vseobecne_udajeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vseobecne_udajeTableAdapter1 = New lesnictvo.Database1DataSet1TableAdapters.vseobecne_udajeTableAdapter
        Me.TableAdapterManager1 = New lesnictvo.Database1DataSet1TableAdapters.TableAdapterManager
        Me.Vseobecne_udajeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        NazovLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        IcoLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        Cislo_uctuLabel = New System.Windows.Forms.Label
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vseobecne_udajeBindingNavigator.SuspendLayout()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NazovLabel
        '
        NazovLabel.AutoSize = True
        NazovLabel.Location = New System.Drawing.Point(36, 58)
        NazovLabel.Name = "NazovLabel"
        NazovLabel.Size = New System.Drawing.Size(95, 13)
        NazovLabel.TabIndex = 3
        NazovLabel.Text = "Názov organizácie"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(36, 97)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(31, 13)
        UlicaLabel.TabIndex = 5
        UlicaLabel.Text = "Ulica"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(36, 136)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(36, 13)
        MestoLabel.TabIndex = 7
        MestoLabel.Text = "Mesto"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(36, 175)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(28, 13)
        PscLabel.TabIndex = 9
        PscLabel.Text = "PSČ"
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(36, 214)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(25, 13)
        IcoLabel.TabIndex = 11
        IcoLabel.Text = "IČO"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(36, 253)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(25, 13)
        DicLabel.TabIndex = 13
        DicLabel.Text = "DIČ"
        '
        'Cislo_uctuLabel
        '
        Cislo_uctuLabel.AutoSize = True
        Cislo_uctuLabel.Location = New System.Drawing.Point(36, 292)
        Cislo_uctuLabel.Name = "Cislo_uctuLabel"
        Cislo_uctuLabel.Size = New System.Drawing.Size(55, 13)
        Cislo_uctuLabel.TabIndex = 15
        Cislo_uctuLabel.Text = "Číslo účtu"
        '
        'Vseobecne_udajeBindingNavigator
        '
        Me.Vseobecne_udajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vseobecne_udajeBindingNavigator.BindingSource = Me.Vseobecne_udajeBindingSource
        Me.Vseobecne_udajeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vseobecne_udajeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vseobecne_udajeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vseobecne_udajeBindingNavigatorSaveItem})
        Me.Vseobecne_udajeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vseobecne_udajeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vseobecne_udajeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vseobecne_udajeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vseobecne_udajeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vseobecne_udajeBindingNavigator.Name = "Vseobecne_udajeBindingNavigator"
        Me.Vseobecne_udajeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vseobecne_udajeBindingNavigator.Size = New System.Drawing.Size(612, 25)
        Me.Vseobecne_udajeBindingNavigator.TabIndex = 0
        Me.Vseobecne_udajeBindingNavigator.Text = "BindingNavigator1"
        Me.Vseobecne_udajeBindingNavigator.Visible = False
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
        'Vseobecne_udajeBindingSource
        '
        Me.Vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"
        Me.Vseobecne_udajeBindingSource.DataSource = Me.Vseobecne_udajeDataSet1
        '
        'Vseobecne_udajeDataSet1
        '
        Me.Vseobecne_udajeDataSet1.DataSetName = "vseobecne_udajeDataSet1"
        Me.Vseobecne_udajeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Vseobecne_udajeBindingNavigatorSaveItem
        '
        Me.Vseobecne_udajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vseobecne_udajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Name = "Vseobecne_udajeBindingNavigatorSaveItem"
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovTextBox
        '
        Me.NazovTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "nazov", True))
        Me.NazovTextBox.Location = New System.Drawing.Point(39, 74)
        Me.NazovTextBox.Name = "NazovTextBox"
        Me.NazovTextBox.Size = New System.Drawing.Size(483, 20)
        Me.NazovTextBox.TabIndex = 4
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(39, 113)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(148, 20)
        Me.UlicaTextBox.TabIndex = 6
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "Mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(39, 152)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(148, 20)
        Me.MestoTextBox.TabIndex = 8
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(39, 191)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PscTextBox.TabIndex = 10
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(39, 230)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.Size = New System.Drawing.Size(148, 20)
        Me.IcoTextBox.TabIndex = 12
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(39, 269)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(148, 20)
        Me.DicTextBox.TabIndex = 14
        '
        'Cislo_uctuTextBox
        '
        Me.Cislo_uctuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "cislo_uctu", True))
        Me.Cislo_uctuTextBox.Location = New System.Drawing.Point(39, 308)
        Me.Cislo_uctuTextBox.Name = "Cislo_uctuTextBox"
        Me.Cislo_uctuTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cislo_uctuTextBox.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Ulož zmeny"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vseobecne_udajeTableAdapter
        '
        Me.Vseobecne_udajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = lesnictvo.vseobecne_udajeDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Me.Vseobecne_udajeTableAdapter
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vseobecne_udajeBindingSource1
        '
        Me.Vseobecne_udajeBindingSource1.DataMember = "vseobecne_udaje"
        Me.Vseobecne_udajeBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Vseobecne_udajeTableAdapter1
        '
        Me.Vseobecne_udajeTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = lesnictvo.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.vseobecne_udajeTableAdapter = Me.Vseobecne_udajeTableAdapter1
        '
        'Vseobecne_udajeDataGridView
        '
        Me.Vseobecne_udajeDataGridView.AutoGenerateColumns = False
        Me.Vseobecne_udajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vseobecne_udajeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Vseobecne_udajeDataGridView.DataSource = Me.Vseobecne_udajeBindingSource1
        Me.Vseobecne_udajeDataGridView.Location = New System.Drawing.Point(473, 165)
        Me.Vseobecne_udajeDataGridView.Name = "Vseobecne_udajeDataGridView"
        Me.Vseobecne_udajeDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.Vseobecne_udajeDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nazov"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nazov"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'vseobecne_udaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 470)
        Me.Controls.Add(Me.Vseobecne_udajeDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NazovLabel)
        Me.Controls.Add(Me.NazovTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(Cislo_uctuLabel)
        Me.Controls.Add(Me.Cislo_uctuTextBox)
        Me.Controls.Add(Me.Vseobecne_udajeBindingNavigator)
        Me.Name = "vseobecne_udaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Všeobecné údaje"
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vseobecne_udajeBindingNavigator.ResumeLayout(False)
        Me.Vseobecne_udajeBindingNavigator.PerformLayout()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vseobecne_udajeDataSet1 As lesnictvo.vseobecne_udajeDataSet1
    Friend WithEvents Vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vseobecne_udajeTableAdapter As lesnictvo.vseobecne_udajeDataSet1TableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.vseobecne_udajeDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Vseobecne_udajeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Vseobecne_udajeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazovTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cislo_uctuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet1 As lesnictvo.Database1DataSet1
    Friend WithEvents Vseobecne_udajeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Vseobecne_udajeTableAdapter1 As lesnictvo.Database1DataSet1TableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents TableAdapterManager1 As lesnictvo.Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Vseobecne_udajeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
