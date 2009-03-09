Public Class detaily_zdruzenia

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzenieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub detaily_zdruzenia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)

        Dim pozicia_zdruzenia As Integer = prehlad_zdruzeni.ZdruzenieBindingSource.Position
        Me.ZdruzenieBindingSource.Position = pozicia_zdruzenia
    End Sub
End Class