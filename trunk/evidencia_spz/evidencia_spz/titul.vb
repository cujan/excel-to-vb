Public Class titul

    Private Sub TitulBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet1)

    End Sub

    Private Sub titul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet1.titul)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.TitulBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulDataSet1)
    End Sub
End Class