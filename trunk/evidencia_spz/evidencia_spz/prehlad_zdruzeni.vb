Public Class prehlad_zdruzeni

    Private Sub karta_clena_tlac_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles karta_clena_tlac_button.Click


    End Sub

    Private Sub button_report_zoznam_clenov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_report_zoznam_clenov.Click


    End Sub

    Private Sub zavriet_kartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu.Click
        Me.Close()

    End Sub

    Private Sub prehlad_clenov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        'evidencia_clenov.Show()
        'evidencia_clenov.BringToFront()
    End Sub

    Private Sub prehlad_clenov_splitter_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles prehlad_clenov_splitter.Panel2.Paint

    End Sub
End Class