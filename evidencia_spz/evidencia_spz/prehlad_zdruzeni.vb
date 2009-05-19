Public Class prehlad_zdruzeni

    Private Sub karta_clena_tlac_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles karta_clena_tlac_button.Click


    End Sub

    Private Sub button_report_zoznam_clenov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_report_zoznam_clenov.Click


    End Sub

    Private Sub zavriet_kartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu.Click
        Me.Close()

    End Sub

    Private Sub prehlad_clenov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        'evidencia_clenov.Show()
        'evidencia_clenov.BringToFront()

        Me.ZdruzenieDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub prehlad_clenov_splitter_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles prehlad_clenov_splitter.Panel2.Paint

    End Sub

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzenieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub ZdruzenieDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzenieDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ID", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub ZdruzenieDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzenieDataGridView.CellContentClick

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If MsgBox("Naozaj chete zmazat zaznam?", MsgBoxStyle.OkCancel, "POZOR!!!") = MsgBoxResult.Ok Then
            Me.ZdruzenieBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ZdruzenieBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)
        End If



        'Me.ZdruzenieBindingSource.RemoveCurrent()
        'Me.Validate()
        'Me.ZdruzenieBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub prehlad_clenov_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles prehlad_clenov_splitter.Panel1.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ZdruzenieDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZdruzenieDataGridView.CellDoubleClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ZdruzenieBindingSource, "ID", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()

        detaily_zdruzenia.Show()
        detaily_zdruzenia.BringToFront()

    End Sub

    Private Sub ZdruzenieDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZdruzenieDataGridView.Click

    End Sub

    Private Sub hladajTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hladajTextBox.TextChanged
        Dim hladane_zdruzenie As String = hladajTextBox.Text
        Me.ZdruzenieTableAdapter.FillBy_hladaj_zdruzenie(Me.ZdruzenieDataSet.zdruzenie, hladane_zdruzenie)

    End Sub
End Class