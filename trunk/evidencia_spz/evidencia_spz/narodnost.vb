Public Class narodnost

    Private Sub NarodnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarodnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NarodnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NarodnostDataSet)

    End Sub

    Private Sub narodnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)

    End Sub

    Private Sub koniec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniec.Click
        Me.Close()
    End Sub
End Class