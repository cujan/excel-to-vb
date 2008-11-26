Public Class forma_pre_button2

    Private Sub forma_pre_button2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Hlavna_plocha
        Me.Location = Hlavna_plocha.SplitContainer1.Location
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub
End Class