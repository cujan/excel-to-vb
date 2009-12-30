Public Class zdruzenie

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub zdruzenie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        'Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzeniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub ZdruzeniaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ico", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub ZdruzeniaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellContentClick

    End Sub

    Private Sub zavriet_kartu_zdruzenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        Me.Close()
    End Sub

    Private Sub ZdruzeniaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellDoubleClick
        zdruzenie_edituj.Show()
        
    End Sub
End Class