Public Class narodky

    Private Sub narodky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'narodeniny_DataSet.clenovia' table. You can move, or remove it, as needed.
        Dim zaciatok As String


        mesiac.SelectedIndex = Date.Today.Month - 1
        'zaciatok = DateTime.Parse("1." & (mesiac.SelectedIndex + 1).ToString & ".1900")
        'koniec = DateTime.Parse("31." & (mesiac.SelectedIndex + 1).ToString & "." & rok.Text)
        If (mesiac.SelectedIndex + 1 <= 9) And (mesiac.SelectedIndex + 1 >= 1) Then
            zaciatok = "0" & (mesiac.SelectedIndex + 1)
        Else
            zaciatok = mesiac.SelectedIndex + 1
        End If


        Me.clenoviaTableAdapter.Fill(Me.narodeniny_DataSet.clenovia, zaciatok)
        'WHERE     (clenovia.datum_narodenia > ?) AND (clenovia.datum_narodenia < ?)

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub mesiac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mesiac.SelectedIndexChanged
        Dim zaciatok As String

        'rok.Text = Date.Today.Year
        'mesiac.SelectedIndex = Date.Today.Month - 1
        'zaciatok = DateTime.Parse("1." & (mesiac.SelectedIndex + 1).ToString & ".1900")
        'koniec = DateTime.Parse("31." & (mesiac.SelectedIndex + 1).ToString & "." & rok.Text)
        If (mesiac.SelectedIndex + 1 <= 9) And (mesiac.SelectedIndex + 1 >= 1) Then
            zaciatok = "0" & (mesiac.SelectedIndex + 1)
        Else
            zaciatok = mesiac.SelectedIndex + 1
        End If



        Me.clenoviaTableAdapter.Fill(Me.narodeniny_DataSet.clenovia, zaciatok)
        'WHERE     (clenovia.datum_narodenia > ?) AND (clenovia.datum_narodenia < ?)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class