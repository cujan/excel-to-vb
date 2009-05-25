Public Class generacia_registracii

    Private Sub generuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generuj.Click

        Dim krat As ULong
        krat = 3691
        Dim ica As ULong
        ica = ica_textbox.Text
        reg_cislo.Text = krat * ica

    End Sub
End Class
