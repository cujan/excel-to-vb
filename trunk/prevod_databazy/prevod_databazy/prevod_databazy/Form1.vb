Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pripojenie pre sdf
        Dim con As New SqlCeConnection(pripojovaci_retazec_sdf)
        con.Open()
        Dim com As New SqlCeCommand("select * from zdruzenia", con)
        com.ExecuteNonQuery()
        con.Close()
        'pripojenie pre accdb
        Dim con1 As New OleDb.OleDbConnection(pripojovaci_retazec_accdb)
        con.Open()

        Dim com1 As New OleDb.OleDbCommand("DELETE FROM clenovia WHERE id = 1", con1)

        com.ExecuteNonQuery()
        con.Close()
    End Sub
End Class
