Public Class zoznam_clenov_podla_zdruzenia

    Private Sub zoznam_clenov_podla_zdruzenia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        'TODO: This line of code loads data into the 'Zoznam_clenov_podla_zdruzeniaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Zoznam_clenov_podla_zdruzeniaDataSet.clenovia)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim id_zdruzenia As Integer = Me.ComboBox1.SelectedValue
        Me.ClenoviaTableAdapter.FillBy_podla_zdruzenia(Me.Zoznam_clenov_podla_zdruzeniaDataSet.clenovia, id_zdruzenia)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
            Me.ClenoviaTableAdapter.Fill(Me.Zoznam_clenov_podla_zdruzeniaDataSet.clenovia)
        End If

    End Sub
End Class