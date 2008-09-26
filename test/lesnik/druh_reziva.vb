Public Class druh_reziva

    Private Sub Druh_rezivaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Druh_rezivaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Druh_rezivaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DruhrezivaDataSet1)

    End Sub

    Private Sub druh_reziva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DruhrezivaDataSet1.druh_reziva' table. You can move, or remove it, as needed.
        Me.Druh_rezivaTableAdapter.Fill(Me.DruhrezivaDataSet1.druh_reziva)
        Me.Druh_rezivaBindingSource.AddNew()



    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        If (KodTextBox.Text <> "" And DruRezivaTextBox.Text <> "" And CenaTextBox.Text <> "") Then

            Me.Validate()
            Me.Druh_rezivaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DruhrezivaDataSet1)
            Me.Druh_rezivaBindingSource.AddNew()
        Else
            MsgBox("nemate vyplnene vsetky polia", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class