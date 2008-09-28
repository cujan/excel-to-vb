Public Class odberatelia

    Private Sub odberatelia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OdberateliaDataSet1.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.OdberateliaDataSet1.odberatelia)
        Me.MdiParent = MDIParent1
        Me.OdberateliaBindingSource.AddNew()
        UlicaTextBox.ReadOnly = False
        MestoTextBox.ReadOnly = False
        PscTextBox.ReadOnly = False
        Cislo_uctuTextBox.ReadOnly = False
        DicTextBox.ReadOnly = False
        IcoTextBox.ReadOnly = False


    End Sub

    Private Sub OdberateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UlicaTextBox.ReadOnly = False Then
            Me.Validate()
            Me.OdberateliaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)
        Else
            varovanie.Show()
            varovanie.varovanie_text.Text = "Nemôžete uložiť zmeny skôr ako ste stlačili tlačítko Upraviť."
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        UlicaTextBox.ReadOnly = False
        MestoTextBox.ReadOnly = False
        PscTextBox.ReadOnly = False
        Cislo_uctuTextBox.ReadOnly = False
        DicTextBox.ReadOnly = False
        IcoTextBox.ReadOnly = False
        

    End Sub

    Private Sub NazovComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NazovComboBox.SelectedIndexChanged
        UlicaTextBox.ReadOnly = True
        MestoTextBox.ReadOnly = True
        PscTextBox.ReadOnly = True
        Cislo_uctuTextBox.ReadOnly = True
        DicTextBox.ReadOnly = True
        IcoTextBox.ReadOnly = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.OdberateliaBindingSource.RemoveCurrent()
    End Sub
End Class
