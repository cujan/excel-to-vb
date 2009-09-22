Public Class vychovavatel

    Private Sub VychovavatelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VychovavatelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VychovavatelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VychovavatelDataSet)

    End Sub

    Private Sub vychovavatel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VychovavatelDataSet.vychovavatel' table. You can move, or remove it, as needed.
        Me.VychovavatelTableAdapter.Fill(Me.VychovavatelDataSet.vychovavatel)

    End Sub
End Class