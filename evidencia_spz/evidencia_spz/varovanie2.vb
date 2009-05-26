Public Class varovanie2

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        Me.Close()

    End Sub

    Private Sub zaregistrovat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zaregistrovat.Click
        registracia_aplikacie.Show()
        registracia_aplikacie.BringToFront()
        Me.Close()
    End Sub
End Class