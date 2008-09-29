<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodaci_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dodaci_list))
        Me.text_odberatel = New System.Windows.Forms.Label
        Me.vybrat_odberatela = New System.Windows.Forms.Button
        Me.text_drevina = New System.Windows.Forms.Label
        Me.drevina = New System.Windows.Forms.Label
        Me.vybrat_drevinu = New System.Windows.Forms.Button
        Me.text_cena = New System.Windows.Forms.Label
        Me.cena = New System.Windows.Forms.Label
        Me.vybrat_cenu = New System.Windows.Forms.Button
        Me.text_mnozstvo = New System.Windows.Forms.Label
        Me.monozstvo = New System.Windows.Forms.TextBox
        Me.text_suma_celkom = New System.Windows.Forms.Label
        Me.suma_celkom = New System.Windows.Forms.Label
        Me.zobrazit_fakturu = New System.Windows.Forms.Button
        Me.zobrazit_ppd = New System.Windows.Forms.Button
        Me.ulozit_dodaci_list = New System.Windows.Forms.Button
        Me.text_cislo_d_listu = New System.Windows.Forms.Label
        Me.cislo_d_listu = New System.Windows.Forms.Label
        Me.OdberateliaDataSet1 = New lesnictvo.odberateliaDataSet1
        Me.OdberateliaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OdberateliaTableAdapter = New lesnictvo.odberateliaDataSet1TableAdapters.odberateliaTableAdapter
        Me.TableAdapterManager = New lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager
        Me.OdberateliaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OdberateliaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NazovComboBox = New System.Windows.Forms.ComboBox
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberateliaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdberateliaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OdberateliaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'text_odberatel
        '
        Me.text_odberatel.AutoSize = True
        Me.text_odberatel.Location = New System.Drawing.Point(54, 42)
        Me.text_odberatel.Name = "text_odberatel"
        Me.text_odberatel.Size = New System.Drawing.Size(58, 13)
        Me.text_odberatel.TabIndex = 0
        Me.text_odberatel.Text = "Odberateľ:"
        '
        'vybrat_odberatela
        '
        Me.vybrat_odberatela.Location = New System.Drawing.Point(461, 37)
        Me.vybrat_odberatela.Name = "vybrat_odberatela"
        Me.vybrat_odberatela.Size = New System.Drawing.Size(134, 23)
        Me.vybrat_odberatela.TabIndex = 1
        Me.vybrat_odberatela.Text = "Vyberte odberateľa"
        Me.vybrat_odberatela.UseVisualStyleBackColor = True
        '
        'text_drevina
        '
        Me.text_drevina.AutoSize = True
        Me.text_drevina.Location = New System.Drawing.Point(47, 71)
        Me.text_drevina.Name = "text_drevina"
        Me.text_drevina.Size = New System.Drawing.Size(65, 13)
        Me.text_drevina.TabIndex = 3
        Me.text_drevina.Text = "Typ dreviny:"
        '
        'drevina
        '
        Me.drevina.AutoSize = True
        Me.drevina.Location = New System.Drawing.Point(118, 71)
        Me.drevina.Name = "drevina"
        Me.drevina.Size = New System.Drawing.Size(44, 13)
        Me.drevina.TabIndex = 4
        Me.drevina.Text = "prázdny"
        '
        'vybrat_drevinu
        '
        Me.vybrat_drevinu.Location = New System.Drawing.Point(461, 66)
        Me.vybrat_drevinu.Name = "vybrat_drevinu"
        Me.vybrat_drevinu.Size = New System.Drawing.Size(134, 23)
        Me.vybrat_drevinu.TabIndex = 5
        Me.vybrat_drevinu.Text = "Vyberte drevinu"
        Me.vybrat_drevinu.UseVisualStyleBackColor = True
        '
        'text_cena
        '
        Me.text_cena.AutoSize = True
        Me.text_cena.Location = New System.Drawing.Point(19, 98)
        Me.text_cena.Name = "text_cena"
        Me.text_cena.Size = New System.Drawing.Size(93, 13)
        Me.text_cena.TabIndex = 6
        Me.text_cena.Text = "Jednotková cena:"
        '
        'cena
        '
        Me.cena.AutoSize = True
        Me.cena.Location = New System.Drawing.Point(119, 98)
        Me.cena.Name = "cena"
        Me.cena.Size = New System.Drawing.Size(44, 13)
        Me.cena.TabIndex = 7
        Me.cena.Text = "prázdny"
        '
        'vybrat_cenu
        '
        Me.vybrat_cenu.Location = New System.Drawing.Point(462, 95)
        Me.vybrat_cenu.Name = "vybrat_cenu"
        Me.vybrat_cenu.Size = New System.Drawing.Size(133, 23)
        Me.vybrat_cenu.TabIndex = 8
        Me.vybrat_cenu.Text = "Vyberte cenu"
        Me.vybrat_cenu.UseVisualStyleBackColor = True
        '
        'text_mnozstvo
        '
        Me.text_mnozstvo.AutoSize = True
        Me.text_mnozstvo.Location = New System.Drawing.Point(294, 97)
        Me.text_mnozstvo.Name = "text_mnozstvo"
        Me.text_mnozstvo.Size = New System.Drawing.Size(56, 13)
        Me.text_mnozstvo.TabIndex = 9
        Me.text_mnozstvo.Text = "Množstvo:"
        '
        'monozstvo
        '
        Me.monozstvo.Location = New System.Drawing.Point(356, 94)
        Me.monozstvo.Name = "monozstvo"
        Me.monozstvo.Size = New System.Drawing.Size(50, 20)
        Me.monozstvo.TabIndex = 10
        Me.monozstvo.Text = "0"
        '
        'text_suma_celkom
        '
        Me.text_suma_celkom.AutoSize = True
        Me.text_suma_celkom.Location = New System.Drawing.Point(38, 147)
        Me.text_suma_celkom.Name = "text_suma_celkom"
        Me.text_suma_celkom.Size = New System.Drawing.Size(74, 13)
        Me.text_suma_celkom.TabIndex = 11
        Me.text_suma_celkom.Text = "Suma celkom:"
        '
        'suma_celkom
        '
        Me.suma_celkom.AutoSize = True
        Me.suma_celkom.Location = New System.Drawing.Point(119, 147)
        Me.suma_celkom.Name = "suma_celkom"
        Me.suma_celkom.Size = New System.Drawing.Size(44, 13)
        Me.suma_celkom.TabIndex = 12
        Me.suma_celkom.Text = "prázdny"
        '
        'zobrazit_fakturu
        '
        Me.zobrazit_fakturu.Location = New System.Drawing.Point(100, 193)
        Me.zobrazit_fakturu.Name = "zobrazit_fakturu"
        Me.zobrazit_fakturu.Size = New System.Drawing.Size(103, 23)
        Me.zobrazit_fakturu.TabIndex = 13
        Me.zobrazit_fakturu.Text = "Zobraziť faktúru"
        Me.zobrazit_fakturu.UseVisualStyleBackColor = True
        '
        'zobrazit_ppd
        '
        Me.zobrazit_ppd.Location = New System.Drawing.Point(218, 193)
        Me.zobrazit_ppd.Name = "zobrazit_ppd"
        Me.zobrazit_ppd.Size = New System.Drawing.Size(142, 23)
        Me.zobrazit_ppd.TabIndex = 14
        Me.zobrazit_ppd.Text = "Zobraziť preukaz pôvodu dreva"
        Me.zobrazit_ppd.UseVisualStyleBackColor = True
        '
        'ulozit_dodaci_list
        '
        Me.ulozit_dodaci_list.Location = New System.Drawing.Point(374, 193)
        Me.ulozit_dodaci_list.Name = "ulozit_dodaci_list"
        Me.ulozit_dodaci_list.Size = New System.Drawing.Size(105, 23)
        Me.ulozit_dodaci_list.TabIndex = 15
        Me.ulozit_dodaci_list.Text = "Uložiť dodací list"
        Me.ulozit_dodaci_list.UseVisualStyleBackColor = True
        '
        'text_cislo_d_listu
        '
        Me.text_cislo_d_listu.AutoSize = True
        Me.text_cislo_d_listu.Location = New System.Drawing.Point(4, 18)
        Me.text_cislo_d_listu.Name = "text_cislo_d_listu"
        Me.text_cislo_d_listu.Size = New System.Drawing.Size(108, 13)
        Me.text_cislo_d_listu.TabIndex = 16
        Me.text_cislo_d_listu.Text = "Číslo dodacieho listu:"
        '
        'cislo_d_listu
        '
        Me.cislo_d_listu.AutoSize = True
        Me.cislo_d_listu.Location = New System.Drawing.Point(119, 18)
        Me.cislo_d_listu.Name = "cislo_d_listu"
        Me.cislo_d_listu.Size = New System.Drawing.Size(44, 13)
        Me.cislo_d_listu.TabIndex = 17
        Me.cislo_d_listu.Text = "prázdny"
        '
        'OdberateliaDataSet1
        '
        Me.OdberateliaDataSet1.DataSetName = "odberateliaDataSet1"
        Me.OdberateliaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OdberateliaBindingSource
        '
        Me.OdberateliaBindingSource.DataMember = "odberatelia"
        Me.OdberateliaBindingSource.DataSource = Me.OdberateliaDataSet1
        '
        'OdberateliaTableAdapter
        '
        Me.OdberateliaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.odberateliaTableAdapter = Me.OdberateliaTableAdapter
        Me.TableAdapterManager.UpdateOrder = lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OdberateliaBindingNavigator
        '
        Me.OdberateliaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OdberateliaBindingNavigator.BindingSource = Me.OdberateliaBindingSource
        Me.OdberateliaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OdberateliaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OdberateliaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.OdberateliaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OdberateliaBindingNavigatorSaveItem})
        Me.OdberateliaBindingNavigator.Location = New System.Drawing.Point(0, 280)
        Me.OdberateliaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OdberateliaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OdberateliaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OdberateliaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OdberateliaBindingNavigator.Name = "OdberateliaBindingNavigator"
        Me.OdberateliaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OdberateliaBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.OdberateliaBindingNavigator.TabIndex = 18
        Me.OdberateliaBindingNavigator.Text = "BindingNavigator1"
        Me.OdberateliaBindingNavigator.Visible = False
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
        'OdberateliaBindingNavigatorSaveItem
        '
        Me.OdberateliaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OdberateliaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OdberateliaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OdberateliaBindingNavigatorSaveItem.Name = "OdberateliaBindingNavigatorSaveItem"
        Me.OdberateliaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OdberateliaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NazovComboBox
        '
        Me.NazovComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OdberateliaBindingSource, "nazov", True))
        Me.NazovComboBox.DataSource = Me.OdberateliaBindingSource
        Me.NazovComboBox.DisplayMember = "nazov"
        Me.NazovComboBox.FormattingEnabled = True
        Me.NazovComboBox.Location = New System.Drawing.Point(122, 42)
        Me.NazovComboBox.Name = "NazovComboBox"
        Me.NazovComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NazovComboBox.TabIndex = 20
        Me.NazovComboBox.ValueMember = "nazov"
        '
        'dodaci_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 305)
        Me.Controls.Add(Me.NazovComboBox)
        Me.Controls.Add(Me.OdberateliaBindingNavigator)
        Me.Controls.Add(Me.cislo_d_listu)
        Me.Controls.Add(Me.text_cislo_d_listu)
        Me.Controls.Add(Me.ulozit_dodaci_list)
        Me.Controls.Add(Me.zobrazit_ppd)
        Me.Controls.Add(Me.zobrazit_fakturu)
        Me.Controls.Add(Me.suma_celkom)
        Me.Controls.Add(Me.text_suma_celkom)
        Me.Controls.Add(Me.monozstvo)
        Me.Controls.Add(Me.text_mnozstvo)
        Me.Controls.Add(Me.vybrat_cenu)
        Me.Controls.Add(Me.cena)
        Me.Controls.Add(Me.text_cena)
        Me.Controls.Add(Me.vybrat_drevinu)
        Me.Controls.Add(Me.drevina)
        Me.Controls.Add(Me.text_drevina)
        Me.Controls.Add(Me.vybrat_odberatela)
        Me.Controls.Add(Me.text_odberatel)
        Me.Name = "dodaci_list"
        Me.Text = "Dodací list"
        CType(Me.OdberateliaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberateliaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdberateliaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OdberateliaBindingNavigator.ResumeLayout(False)
        Me.OdberateliaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_odberatel As System.Windows.Forms.Label
    Friend WithEvents vybrat_odberatela As System.Windows.Forms.Button
    Friend WithEvents text_drevina As System.Windows.Forms.Label
    Friend WithEvents drevina As System.Windows.Forms.Label
    Friend WithEvents vybrat_drevinu As System.Windows.Forms.Button
    Friend WithEvents text_cena As System.Windows.Forms.Label
    Friend WithEvents cena As System.Windows.Forms.Label
    Friend WithEvents vybrat_cenu As System.Windows.Forms.Button
    Friend WithEvents text_mnozstvo As System.Windows.Forms.Label
    Friend WithEvents monozstvo As System.Windows.Forms.TextBox
    Friend WithEvents text_suma_celkom As System.Windows.Forms.Label
    Friend WithEvents suma_celkom As System.Windows.Forms.Label
    Friend WithEvents zobrazit_fakturu As System.Windows.Forms.Button
    Friend WithEvents zobrazit_ppd As System.Windows.Forms.Button
    Friend WithEvents ulozit_dodaci_list As System.Windows.Forms.Button
    Friend WithEvents text_cislo_d_listu As System.Windows.Forms.Label
    Friend WithEvents cislo_d_listu As System.Windows.Forms.Label
    Friend WithEvents OdberateliaDataSet1 As lesnictvo.odberateliaDataSet1
    Friend WithEvents OdberateliaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OdberateliaTableAdapter As lesnictvo.odberateliaDataSet1TableAdapters.odberateliaTableAdapter
    Friend WithEvents TableAdapterManager As lesnictvo.odberateliaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents OdberateliaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OdberateliaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NazovComboBox As System.Windows.Forms.ComboBox
End Class
