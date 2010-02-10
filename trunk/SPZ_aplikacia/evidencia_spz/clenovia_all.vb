Public Class clenovia_all

    Private Sub All_clenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All_clenoviaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.All_clenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.All_clenoviaDataSet)

    End Sub

    Private Sub clenovia_all_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        hlavna_aplikacia.vytvor_all_clenovia()


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)


        'TODO: This line of code loads data into the 'All_clenoviaDataSet.all_clenovia' table. You can move, or remove it, as needed.
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)
        Me.All_clenoviaDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub zavriet_kartu_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu_button.Click
        hlavna_aplikacia.removeFormFromList(Me.Text)
        Me.Close()

    End Sub

    Private Sub All_clenoviaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.All_clenoviaBindingSource, "rodne_cislo", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
        Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.All_clenoviaBindingSource, "ico_clenovia", True))
        Label4.Text = Label3.Text
        Label3.DataBindings.Clear()
    End Sub

    Private Sub All_clenoviaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellContentClick

    End Sub

    Private Sub All_clenoviaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles All_clenoviaDataGridView.CellDoubleClick
        clen_edituj.Show()
        clen_edituj.BringToFront()
        hlavna_aplikacia.GetOpenFormTitles()
        Me.priezviskoTextBox.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ico_clenovia As String = Label4.Text
        If Label2.Text <> "Label2" Then
            If MsgBox("Naozaj chete zmazat vybraného člena?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Upozornenie !!!") = MsgBoxResult.Ok Then
                Dim con As New SqlCeConnection(pripojovaci_retazec)
                Dim com As New SqlCeCommand("DELETE FROM """ & ico_clenovia & """ WHERE  rodne_cislo = @rodne_cislo", con)
                com.Parameters.AddWithValue("rodne_cislo", Label2.Text)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            End If
        Else
            MsgBox("Nemáte vybranáho žiadneho člena!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        End If
        hlavna_aplikacia.vytvor_all_clenovia()
        Me.All_clenoviaTableAdapter.Fill(Me.All_clenoviaDataSet.all_clenovia)

    End Sub

    Private Sub priezviskoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles priezviskoTextBox.TextChanged
        Dim priezvisko As String = Me.priezviskoTextBox.Text & "%"
        Me.All_clenoviaTableAdapter.FillBy_priezvisko(Me.All_clenoviaDataSet.all_clenovia, priezvisko)
    End Sub
End Class