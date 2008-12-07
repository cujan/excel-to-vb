Public Class dodaci_list_rezivo

    Private Sub Dodaci_list_rezivoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub dodaci_list_rezivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dodaci_list_rezivoDataSet1.dodaci_list_rezivo_detaily' table. You can move, or remove it, as needed.
        Me.Dodaci_list_rezivo_detailyTableAdapter.Fill(Me.Dodaci_list_rezivoDataSet1.dodaci_list_rezivo_detaily)
        'TODO: This line of code loads data into the 'Dodaci_list_rezivoDataSet1.dodaci_list_rezivo' table. You can move, or remove it, as needed.
        Me.Dodaci_list_rezivoTableAdapter.Fill(Me.Dodaci_list_rezivoDataSet1.dodaci_list_rezivo)

    End Sub

    Private Sub Dodaci_list_rezivoBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dodaci_list_rezivoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dodaci_list_rezivoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dodaci_list_rezivoDataSet1)

        Me.Dodaci_list_rezivo_detailyBindingSource.EndEdit()
        Me.Dodaci_list_rezivo_detailyTableAdapter.Update(Me.Dodaci_list_rezivoDataSet1.dodaci_list_rezivo_detaily)

    End Sub
End Class