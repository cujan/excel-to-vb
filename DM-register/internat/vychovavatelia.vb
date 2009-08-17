Public Class vychovavatelia

    Private Sub VychovavateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VychovavateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VychovavateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VychovavateliaDataSet)
        Me.VychovavateliaTableAdapter.Fill(Me.VychovavateliaDataSet.vychovavatelia)
    End Sub

    Private Sub vychovavatelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VychovavateliaDataSet.vychovavatelia' table. You can move, or remove it, as needed.
        Me.VychovavateliaTableAdapter.Fill(Me.VychovavateliaDataSet.vychovavatelia)

    End Sub
End Class
