Public Class dodaci_list
    Dim cena_button_array As cenaButtonArray
    Dim rezivo_button_array As rezivoButtonArray
    Dim cena_textbox_array As cenaTextboxArray
    Dim rezivo_textbox_array As rezivoTextboxArray
    Dim jednotka_d_textbox_array As jednotkaDTextboxArray

    Private Sub dodaci_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OdberateliaDataSet1.odberatelia' table. You can move, or remove it, as needed.
        Me.OdberateliaTableAdapter.Fill(Me.OdberateliaDataSet1.odberatelia)
        Me.MdiParent = MDIParent1
    End Sub

    Private Sub OdberateliaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdberateliaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OdberateliaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OdberateliaDataSet1)

    End Sub


    Private Sub pridaj_riadok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pridaj_riadok.Click
        cena_button_array.AddNewButton()
        rezivo_button_array.AddNewButton()
        cena_textbox_array.AddNewTextbox()
        rezivo_textbox_array.AddNewTextbox()
        jednotka_d_textbox_array.AddNewTextbox()


    End Sub

    Private Sub odober_riadok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odober_riadok.Click
        cena_button_array.Remove()
        rezivo_button_array.Remove()
        cena_textbox_array.Remove()
        rezivo_textbox_array.Remove()
        jednotka_d_textbox_array.Remove()


    End Sub
End Class