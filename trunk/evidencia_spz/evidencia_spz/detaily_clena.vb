Public Class detaily_clena

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub detaily_clena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
        'TODO: This line of code loads data into the 'PrehladDataSet.clenovia' table. You can move, or remove it, as needed.
        Dim pozicia As Integer = evidencia_clenov.ClenoviaBindingSource.Position
        Me.ClenoviaBindingSource.Position = pozicia

    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prehlad_clenovDataSet)

    End Sub
End Class