Public Class cennik_reziva

    Private Sub Druh_rezivaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Druh_rezivaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Druh_rezivaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RezivoDataSet1)

    End Sub

    Private Sub cennik_reziva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RezivoDataSet1.druh_reziva' table. You can move, or remove it, as needed.
        Me.Druh_rezivaTableAdapter.Fill(Me.RezivoDataSet1.druh_reziva)

    End Sub
End Class