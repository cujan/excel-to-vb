Public Class odberatelia

    Private Sub odberatelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Database1DataSet2.vseobecne_udaje)
        Me.MdiParent = MDIParent1
    End Sub
End Class
