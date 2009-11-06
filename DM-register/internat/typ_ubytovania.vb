Public Class typ_ubytovania

    Private Sub Typ_ubytovaniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Typ_ubytovaniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Typ_ubytovaniaDataSet)

    End Sub

    Private Sub typ_ubytovania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Typ_ubytovaniaDataSet.typ_ubytovania' table. You can move, or remove it, as needed.
        Me.Typ_ubytovaniaTableAdapter.Fill(Me.Typ_ubytovaniaDataSet.typ_ubytovania)


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub vlozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vlozButton.Click
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()
        Dim com As New SqlCeCommand("insert into typ_ubytovania (typ_ubytovania) values (@typ_ubytovania)", con)
        com.Parameters.AddWithValue("typ_ubytovania", typ_ubytovaniaTextBox.Text)
        com.ExecuteNonQuery()
        con.Close()

        Me.Typ_ubytovaniaTableAdapter.Fill(Me.Typ_ubytovaniaDataSet.typ_ubytovania)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class