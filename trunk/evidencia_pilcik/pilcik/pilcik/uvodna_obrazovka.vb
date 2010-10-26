Public Class uvodna_obrazovka

    Private Sub uvodna_obrazovka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = hlavna_aplikacia
        Me.WindowState = FormWindowState.Maximized

        'pocet evidovanych osob a kurzov
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT COUNT(*) FROM osoba", con)
        Dim com1 As New SqlCeCommand("SELECT COUNT(*) FROM kurz", con)
        con.Open()
        Dim pocet_osob As Integer = com.ExecuteScalar()
        Dim pocet_kurz As Integer = com1.ExecuteScalar()
        con.Close()
        Label4.Text = pocet_osob
        Label5.Text = pocet_kurz
    End Sub

    Private Sub verziaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verziaLabel.Click

    End Sub
End Class