Public Class chybajuce_kontrolne_strelby_brok

    Private Sub chybajuce_kontrolne_strelby_brok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kontrolne_strelby_brokDataSet1.clenovia' table. You can move, or remove it, as needed.
        Dim rok As String
        rok = Date.Today.Year.ToString
        Me.clenoviaTableAdapter.Fill(Me.Kontrolne_strelby_brokDataSet1.clenovia, rok)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class