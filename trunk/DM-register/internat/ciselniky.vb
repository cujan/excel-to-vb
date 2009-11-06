Public Class ciselniky

    Private Sub ciselniky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub zavriet_kartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu.Click
        Me.Close()


    End Sub

    Private Sub vychovavatelia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vychovavatelia.Click
        vychovavatel.Show()
        vychovavatel.BringToFront()

    End Sub

    Private Sub skupiny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skupiny.Click
        skupina.Show()
        skupina.BringToFront()


    End Sub


    Private Sub titul_pred_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titul_pred_button.Click
        titul_pred.Show()
        titul_pred.BringToFront()

    End Sub

    Private Sub typ_ubytovania_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typ_ubytovania_button.Click
        typ_ubytovania.Show()
        typ_ubytovania.BringToFront()

    End Sub

    Private Sub typ_izby_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typ_izby_button.Click
        typ_izby.Show()
        typ_izby.BringToFront()

    End Sub
End Class