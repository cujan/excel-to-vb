Public Class novy_clen

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_evidenciaDataSet)

    End Sub

    Private Sub novy_clen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        'TODO: This line of code loads data into the 'NarodnostDataSet.narodnost' table. You can move, or remove it, as needed.
        Me.NarodnostTableAdapter.Fill(Me.NarodnostDataSet.narodnost)
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet1.statna_prislusnost)
        'TODO: This line of code loads data into the 'TitulDataSet1.titul' table. You can move, or remove it, as needed.
        Me.TitulTableAdapter.Fill(Me.TitulDataSet1.titul)
        'TODO: This line of code loads data into the 'Spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

        Me.ClenoviaTableAdapter.Fill(Me.Spz_evidenciaDataSet.clenovia)
        Me.ClenoviaBindingSource.AddNew()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_evidenciaDataSet)
        MsgBox("Novy clen bol uspesne pridany", MsgBoxStyle.OkOnly)
        Me.ClenoviaBindingSource.AddNew()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Brokova_zbranCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Brokova_zbranCheckBox.CheckedChanged
        


    End Sub

    Private Sub Datum_narodeniaDateTimePicker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Datum_narodeniaDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Kontrolne_strelby_brokTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kontrolne_strelby_brokTextBox.TextChanged

    End Sub
End Class