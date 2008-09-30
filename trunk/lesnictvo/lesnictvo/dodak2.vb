Public Class dodak2

    Private Sub Dodaci_listBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dodaci_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dodaci_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dodaci_listDataSet1)

    End Sub

    Private Sub dodak2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Drevina_pohladDataSet1.dreviny' table. You can move, or remove it, as needed.
        Me.DrevinyTableAdapter.Fill(Me.Drevina_pohladDataSet1.dreviny)
        'TODO: This line of code loads data into the 'Dodaci_listDataSet1.dodaci_list' table. You can move, or remove it, as needed.
        Me.Dodaci_listTableAdapter.Fill(Me.Dodaci_listDataSet1.dodaci_list)

    End Sub
End Class