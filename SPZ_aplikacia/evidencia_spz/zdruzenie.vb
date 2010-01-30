Public Class zdruzenie

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub zdruzenie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)
        'TODO: This line of code loads data into the 'SpzDataSet.zdruzenia' table. You can move, or remove it, as needed.
        'Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        ZdruzeniaDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub ZdruzeniaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzeniaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzeniaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SpzDataSet)

    End Sub

    Private Sub ZdruzeniaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzeniaBindingSource, "ico", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub ZdruzeniaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellContentClick

    End Sub

    Private Sub zavriet_kartu_zdruzenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()
    End Sub

    Private Sub ZdruzeniaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzeniaDataGridView.CellDoubleClick
        zdruzenie_edituj.Show()
        zdruzenie_edituj.BringToFront()
        hlavna_aplikacia.GetOpenFormTitles()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If Label2.Text <> "Label2" Then
            If MsgBox("Naozaj chete zmazat vybrane zdruzenie?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Upozornenie !!!") = MsgBoxResult.Ok Then
                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM zdruzenia WHERE ico = @ico", con)
                com.Parameters.AddWithValue("ico", Label2.Text)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            End If
        Else
            MsgBox("Nemate vybrane ziadne zdruzenie!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
        Me.ZdruzeniaTableAdapter.Fill(Me.SpzDataSet.zdruzenia)


    End Sub
End Class