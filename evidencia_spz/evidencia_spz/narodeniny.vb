Public Class narodeniny

    Private Sub narodeniny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'narodeniny_DataSet.clenovia' table. You can move, or remove it, as needed.
        Dim zaciatok As DateTime
        Dim koniec As DateTime
        rok.Text = Date.Today.Year
        mesiac.SelectedIndex = Date.Today.Month - 1
        zaciatok = DateTime.Parse("1." & (mesiac.SelectedIndex + 1).ToString & ".1900")
        koniec = DateTime.Parse("31." & (mesiac.SelectedIndex + 1).ToString & "." & rok.Text)

        Label1.Text = zaciatok.ToUniversalTime
        Me.clenoviaTableAdapter.Fill(Me.narodeniny_DataSet.clenovia)
        'WHERE     (clenovia.datum_narodenia > ?) AND (clenovia.datum_narodenia < ?)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class