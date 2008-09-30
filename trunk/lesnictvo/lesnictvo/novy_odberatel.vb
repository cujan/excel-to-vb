Public Class novy_odberatel

    Private Sub OdberateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub

    Private Sub novy_odberatel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OdberateliaDataSet1.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.OdberateliaDataSet1.odberatelia)
        Me.OdberateliaBindingSource.AddNew()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)
        Me.Close()
        odberatelia.OdberateliaBindingNavigator.Refresh()
        odberatelia.OdberateliaDataGridView.Refresh()
    End Sub
End Class