Public Class typ_izby

    Private Sub Typ_izbyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_izbyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Typ_izbyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Typ_izbyDataSet)

    End Sub

    Private Sub typ_izby_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Typ_izbyDataSet.typ_izby' table. You can move, or remove it, as needed.
        Me.Typ_izbyTableAdapter.Fill(Me.Typ_izbyDataSet.typ_izby)

    End Sub

    Private Sub vlozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vlozButton.Click
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()
        Dim com As New SqlCeCommand("insert into typ_izby (typ_izby) values (@typ_izby)", con)

        com.Parameters.AddWithValue("typ_izby", typizbyTextBox.Text)

        com.ExecuteNonQuery()
        con.Close()

        Me.Typ_izbyTableAdapter.Fill(Me.Typ_izbyDataSet.typ_izby)
    End Sub
End Class