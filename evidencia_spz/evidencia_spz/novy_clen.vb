Public Class novy_clen

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClenoviaDataSet)

    End Sub

    Private Sub novy_clen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet.statna_prislusnost)
        'TODO: This line of code loads data into the 'TitulDataSet.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet.titul)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)


        'TODO: This line of code loads data into the 'ClenoviaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.ClenoviaDataSet.clenovia)
        'TODO: This line of code loads data into the 'ClenoviaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.ClenoviaDataSet.clenovia)

        Me.ClenoviaBindingSource.AddNew()
    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClenoviaDataSet)
    End Sub

    Private Sub zavri_novy_clen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavri_novy_clen.Click
        Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClenoviaDataSet)
        Me.Hide()
    End Sub
End Class