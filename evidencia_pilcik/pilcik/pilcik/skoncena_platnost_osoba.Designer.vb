<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skoncena_platnost_osoba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(skoncena_platnost_osoba))
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
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vyprsanie_platnosti_preukazuDataSet = New pilcik.vyprsanie_platnosti_preukazuDataSet
        Me.OsobaTableAdapter = New pilcik.vyprsanie_platnosti_preukazuDataSetTableAdapters.osobaTableAdapter
        Me.TableAdapterManager = New pilcik.vyprsanie_platnosti_preukazuDataSetTableAdapters.TableAdapterManager
        Me.priezvisko = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OsobaBindingNavigator.SuspendLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vyprsanie_platnosti_preukazuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OsobaBindingNavigator
        '
        Me.OsobaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OsobaBindingNavigator.BindingSource = Me.OsobaBindingSource
        Me.OsobaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OsobaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OsobaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OsobaBindingNavigatorSaveItem})
        Me.OsobaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OsobaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OsobaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OsobaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OsobaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OsobaBindingNavigator.Name = "OsobaBindingNavigator"
        Me.OsobaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OsobaBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.OsobaBindingNavigator.TabIndex = 0
        Me.OsobaBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'OsobaBindingNavigatorSaveItem
        '
        Me.OsobaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingNavigatorSaveItem.Name = "OsobaBindingNavigatorSaveItem"
        Me.OsobaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OsobaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OsobaDataGridView
        '
        Me.OsobaDataGridView.AutoGenerateColumns = False
        Me.OsobaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OsobaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.priezvisko})
        Me.OsobaDataGridView.DataSource = Me.OsobaBindingSource
        Me.OsobaDataGridView.Location = New System.Drawing.Point(12, 51)
        Me.OsobaDataGridView.Name = "OsobaDataGridView"
        Me.OsobaDataGridView.Size = New System.Drawing.Size(845, 362)
        Me.OsobaDataGridView.TabIndex = 1
        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"
        Me.OsobaBindingSource.DataSource = Me.Vyprsanie_platnosti_preukazuDataSet
        '
        'Vyprsanie_platnosti_preukazuDataSet
        '
        Me.Vyprsanie_platnosti_preukazuDataSet.DataSetName = "vyprsanie_platnosti_preukazuDataSet"
        Me.Vyprsanie_platnosti_preukazuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaTableAdapter
        '
        Me.OsobaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.c_typ_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.clenovia_kurzuTableAdapter = Nothing
        Me.TableAdapterManager.kurzTableAdapter = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Me.OsobaTableAdapter
        Me.TableAdapterManager.skusobna_komisiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pilcik.vyprsanie_platnosti_preukazuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Nothing
        '
        'priezvisko
        '
        Me.priezvisko.DataPropertyName = "priezvisko"
        Me.priezvisko.HeaderText = "priezvisko"
        Me.priezvisko.Name = "priezvisko"
        '
        'skoncena_platnost_osoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 414)
        Me.Controls.Add(Me.OsobaDataGridView)
        Me.Controls.Add(Me.OsobaBindingNavigator)
        Me.Name = "skoncena_platnost_osoba"
        Me.Text = "skoncena_platnost_osoba"
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OsobaBindingNavigator.ResumeLayout(False)
        Me.OsobaBindingNavigator.PerformLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vyprsanie_platnosti_preukazuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vyprsanie_platnosti_preukazuDataSet As pilcik.vyprsanie_platnosti_preukazuDataSet
    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaTableAdapter As pilcik.vyprsanie_platnosti_preukazuDataSetTableAdapters.osobaTableAdapter
    Friend WithEvents TableAdapterManager As pilcik.vyprsanie_platnosti_preukazuDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents priezvisko As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
