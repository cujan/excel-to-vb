<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registracia_aplikacie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registracia_aplikacie))
        Dim Reg_cisloLabel As System.Windows.Forms.Label
        Me.Spz_vseobecne_udaje = New evidencia_spz.spz_vseobecne_udaje
        Me.Vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vseobecne_udajeTableAdapter = New evidencia_spz.spz_vseobecne_udajeTableAdapters.vseobecne_udajeTableAdapter
        Me.TableAdapterManager = New evidencia_spz.spz_vseobecne_udajeTableAdapters.TableAdapterManager
        Me.Vseobecne_udajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Vseobecne_udajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Reg_cisloTextBox = New System.Windows.Forms.TextBox
        Reg_cisloLabel = New System.Windows.Forms.Label
        CType(Me.Spz_vseobecne_udaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vseobecne_udajeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Spz_vseobecne_udaje
        '
        Me.Spz_vseobecne_udaje.DataSetName = "spz_vseobecne_udaje"
        Me.Spz_vseobecne_udaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vseobecne_udajeBindingSource
        '
        Me.Vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"
        Me.Vseobecne_udajeBindingSource.DataSource = Me.Spz_vseobecne_udaje
        '
        'Vseobecne_udajeTableAdapter
        '
        Me.Vseobecne_udajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = evidencia_spz.spz_vseobecne_udajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Me.Vseobecne_udajeTableAdapter
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
        Me.Vseobecne_udajeBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.Vseobecne_udajeBindingNavigator.TabIndex = 0
        Me.Vseobecne_udajeBindingNavigator.Text = "BindingNavigator1"
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
        'Vseobecne_udajeBindingNavigatorSaveItem
        '
        Me.Vseobecne_udajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vseobecne_udajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Name = "Vseobecne_udajeBindingNavigatorSaveItem"
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Reg_cisloLabel
        '
        Reg_cisloLabel.AutoSize = True
        Reg_cisloLabel.Location = New System.Drawing.Point(82, 68)
        Reg_cisloLabel.Name = "Reg_cisloLabel"
        Reg_cisloLabel.Size = New System.Drawing.Size(49, 13)
        Reg_cisloLabel.TabIndex = 1
        Reg_cisloLabel.Text = "reg cislo:"
        '
        'Reg_cisloTextBox
        '
        Me.Reg_cisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "reg_cislo", True))
        Me.Reg_cisloTextBox.Location = New System.Drawing.Point(137, 65)
        Me.Reg_cisloTextBox.Name = "Reg_cisloTextBox"
        Me.Reg_cisloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Reg_cisloTextBox.TabIndex = 2
        '
        'registracia_aplikacie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 290)
        Me.Controls.Add(Reg_cisloLabel)
        Me.Controls.Add(Me.Reg_cisloTextBox)
        Me.Controls.Add(Me.Vseobecne_udajeBindingNavigator)
        Me.Name = "registracia_aplikacie"
        Me.Text = "registracia_aplikacie"
        CType(Me.Spz_vseobecne_udaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vseobecne_udajeBindingNavigator.ResumeLayout(False)
        Me.Vseobecne_udajeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Spz_vseobecne_udaje As evidencia_spz.spz_vseobecne_udaje
    Friend WithEvents Vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vseobecne_udajeTableAdapter As evidencia_spz.spz_vseobecne_udajeTableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents TableAdapterManager As evidencia_spz.spz_vseobecne_udajeTableAdapters.TableAdapterManager
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
    Friend WithEvents Reg_cisloTextBox As System.Windows.Forms.TextBox
End Class
