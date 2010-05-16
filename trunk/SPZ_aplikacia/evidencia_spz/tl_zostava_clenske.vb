Public Class tl_zostava_clenske
    Dim clenske_do As Integer
    Private Sub tl_zostava_clenske_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'clenske_do_dataset.all_clenovia' table. You can move, or remove it, as needed.
        hlavna_aplikacia.vytvor_all_clenovia()
        clenske_do = Year(Today())
        clenske_do_combo.SelectedText = clenske_do

        Me.all_clenoviaTableAdapter.Fill(Me.clenske_do_dataset.all_clenovia, clenske_do)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub clenske_do_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clenske_do_combo.SelectedIndexChanged
        clenske_do = clenske_do_combo.SelectedItem
        Me.all_clenoviaTableAdapter.Fill(Me.clenske_do_dataset.all_clenovia, clenske_do)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class