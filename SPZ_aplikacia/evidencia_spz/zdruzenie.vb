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
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)



    End Sub

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzeniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub ZdruzeniaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellContentClick

    End Sub
End Class