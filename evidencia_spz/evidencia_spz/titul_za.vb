Public Class titul_za

    Private Sub Titul_zaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_zaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Titul_zaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TitulzaDataSet)

    End Sub

    Private Sub titul_za_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TitulzaDataSet.titul_za' table. You can move, or remove it, as needed.
        Me.Titul_zaTableAdapter.Fill(Me.TitulzaDataSet.titul_za)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)
    End Sub
End Class