Public Class skusobny_report

    Private Sub skusobny_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'all_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.all_clenoviaTableAdapter.Fill(Me.all_clenoviaDataSet.all_clenovia)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class