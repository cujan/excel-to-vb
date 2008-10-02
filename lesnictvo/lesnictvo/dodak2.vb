Public Class dodak2

    Private Sub Dodaci_listBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub dodak2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pohlad_odberatelDataSet1.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.Pohlad_odberatelDataSet1.odberatelia)
        'TODO: This line of code loads data into the 'Pohlad_drevinaDataSet1.dreviny' table. You can move, or remove it, as needed.
        Me.DrevinyTableAdapter.Fill(Me.Pohlad_drevinaDataSet1.dreviny)
        'TODO: This line of code loads data into the 'Dodaci_listDataSet1.dodaci_list_detaily' table. You can move, or remove it, as needed.
        Me.Dodaci_list_detailyTableAdapter.Fill(Me.Dodaci_listDataSet1.dodaci_list_detaily)
        'TODO: This line of code loads data into the 'Dodaci_listDataSet1.dodaci_list' table. You can move, or remove it, as needed.
        Me.Dodaci_listTableAdapter.Fill(Me.Dodaci_listDataSet1.dodaci_list)


    End Sub


    Private Sub Dodaci_listBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub Dodaci_listBindingNavigator_RefreshItems_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dodaci_listBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dodaci_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dodaci_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dodaci_listDataSet1)

        Me.Dodaci_list_detailyBindingSource.EndEdit()
        Me.Dodaci_list_detailyTableAdapter.Update(Me.Dodaci_listDataSet1.dodaci_list_detaily)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dodaci_list_rezivo_detaily.Show()
    End Sub
End Class