Public Class statna_prislusnost

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub statna_prislusnost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Statna_prislusnostDataSet1.statna_prislusnost' table. You can move, or remove it, as needed.
        Me.Statna_prislusnostTableAdapter.Fill(Me.Statna_prislusnostDataSet1.statna_prislusnost)

    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Statna_prislusnostBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statna_prislusnostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Statna_prislusnostDataSet1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Statna_prislusnostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Statna_prislusnostDataSet1)
    End Sub
End Class