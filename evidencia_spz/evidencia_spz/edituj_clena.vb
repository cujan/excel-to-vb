Public Class edituj_clena

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClenoviaDataSet)

    End Sub

    Private Sub edituj_clena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PohladpriezviskoDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter1.Fill(Me.PohladpriezviskoDataSet.clenovia)
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet.statna_prislusnost)
        'TODO: This line of code loads data into the 'TitulDataSet.titul' table. You can move, or remove it, as needed.

        Me.TitulTableAdapter.Fill(Me.TitulDataSet.titul)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)


        'TODO: This line of code loads data into the 'ClenoviaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.ClenoviaDataSet.clenovia)

    End Sub

    Private Sub zavri_edituj_clena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavri_edituj_clena.Click

        Me.Close()

    End Sub

    Private Sub PriezviskoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClenoviaDataSet)
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ClenoviaBindingSource.Position = Me.ComboBox1.SelectedIndex
    End Sub
End Class