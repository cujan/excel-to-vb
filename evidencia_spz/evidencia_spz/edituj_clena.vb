Public Class edituj_clena

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_evidenciaDataSet)

    End Sub

    Private Sub edituj_clena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pohlad_priezviskoDataSet1.clenovia' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        Me.ClenoviaTableAdapter1.Fill(Me.Pohlad_priezviskoDataSet1.clenovia)
        'TODO: This line of code loads data into the 'Spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Spz_evidenciaDataSet.clenovia)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ClenoviaBindingSource.Position = Me.ComboBox1.SelectedIndex
    End Sub

    Private Sub Brokova_zbranCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brokova_zbranCheckBox.CheckedChanged

    End Sub
End Class