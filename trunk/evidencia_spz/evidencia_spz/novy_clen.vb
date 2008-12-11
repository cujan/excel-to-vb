Public Class novy_clen

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_evidenciaDataSet)

    End Sub

    Private Sub novy_clen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        Me.ClenoviaTableAdapter.Fill(Me.Spz_evidenciaDataSet.clenovia)
        Me.ClenoviaBindingSource.AddNew()
    End Sub
End Class