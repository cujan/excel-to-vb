Public Class odberatelia

    Private Sub OdberatelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberatelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberatelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub

    Private Sub odberatelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OdberateliaDataSet1.odberatel' table. You can move, or remove it, as needed.
        Me.OdberatelTableAdapter.Fill(Me.OdberateliaDataSet1.odberatel)
        Me.OdberatelBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.OdberatelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub
End Class