Public Class clenovia123

    Private Sub _123_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me._123_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub clenovia123_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet._123_clenovia' table. You can move, or remove it, as needed.
        Me._123_clenoviaTableAdapter.Fill(Me.SpzDataSet._123_clenovia)
        'TODO: This line of code loads data into the 'SpzDataSet._123_clenovia' table. You can move, or remove it, as needed.
        Me._123_clenoviaTableAdapter.Fill(Me.SpzDataSet._123_clenovia)

    End Sub

    Private Sub _123_clenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _123_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me._123_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub
End Class