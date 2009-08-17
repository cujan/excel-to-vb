Public Class skupiny

    Private Sub skupiny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VychovavateliaDataSet.vychovavatelia' table. You can move, or remove it, as needed.
        Me.VychovavateliaTableAdapter.Fill(Me.VychovavateliaDataSet.vychovavatelia)
        'TODO: This line of code loads data into the 'SkupinaDataSet.skupina' table. You can move, or remove it, as needed.
        Me.SkupinaTableAdapter.Fill(Me.SkupinaDataSet.skupina)

    End Sub
End Class