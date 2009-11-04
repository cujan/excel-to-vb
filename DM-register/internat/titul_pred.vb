Public Class titul_pred

    Private Sub Titul_predBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titul_predBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Titul_predBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Titul_predDataSet)

    End Sub

    Private Sub titul_pred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Titul_predDataSet.titul_pred' table. You can move, or remove it, as needed.
        Me.Titul_predTableAdapter.Fill(Me.Titul_predDataSet.titul_pred)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        ciselniky.ciselniky_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim skratka As String = skratkaTextBox.Text
        Dim nazov As String = nazovTextBox.Text

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        con.Open()

        Dim com As New SqlCeCommand("insert into titul_pred (skratka, nazov) values (@skratka,@nazov)", con)

        With com.Parameters
            .AddWithValue("skratka", skratka)
            .AddWithValue("nazov", nazov)
        End With


        com.ExecuteNonQuery()
        con.Close()

        Me.Titul_predTableAdapter.Fill(Me.Titul_predDataSet.titul_pred)
    End Sub

    Private Sub zavriet_podkartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_podkartu.Click
        Me.Close()

    End Sub
End Class