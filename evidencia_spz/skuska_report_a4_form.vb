Public Class skuska_report_a4_form

    Private Sub skuska_report_a4_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'kontrolne_strelby_gulaDataSet1.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'spz_clenovia_report_a4.clenovia' table. You can move, or remove it, as needed.
        Me.clenoviaTableAdapter.Fill(Me.spz_clenovia_report_a4.clenovia)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load
        ReportViewer1.DocumentMapWidth = 150
        ReportViewer1.ZoomPercent = 75%

    End Sub
End Class