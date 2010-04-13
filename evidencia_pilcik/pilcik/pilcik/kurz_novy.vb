Public Class kurz_novy

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KurzBindingSource.EndEdit()


    End Sub

    Private Sub kurz_novy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub kurz_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Kurz_pocetDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.Kurz_pocetDataSet.kurz)
        Me.MdiParent = hlavna_aplikacia
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzDataGridView.CurrentRow.Selected = Nothing
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()


    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click


        If NazovTextBox.Text <> "" And Zaciatok_kurzuDateTimePicker.Checked = True And Koniec_kurzuDateTimePicker.Checked = True And TypComboBox.Text <> "" And Miesto_konaniaTextBox.Text <> "" Then


            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("INSERT INTO kurz (nazov, zaciatok_kurzu, koniec_kurzu, typ, miesto_konania) VALUES (@nazov,@zaciatok_kurzu,@koniec_kurzu,@typ,@miesto_konania)", con)

            With com.Parameters
                .AddWithValue("nazov", NazovTextBox.Text)
                If Zaciatok_kurzuDateTimePicker.Checked = True Then
                    .AddWithValue("zaciatok_kurzu", Zaciatok_kurzuDateTimePicker.Value.Date)
                Else
                    .AddWithValue("zaciatok_kurzu", DBNull.Value)
                End If
                If Koniec_kurzuDateTimePicker.Checked = True Then
                    .AddWithValue("koniec_kurzu", Zaciatok_kurzuDateTimePicker.Value.Date)
                Else
                    .AddWithValue("koniec_kurzu", DBNull.Value)
                End If
                .AddWithValue("typ", TypComboBox.Text)
                .AddWithValue("miesto_konania", Miesto_konaniaTextBox.Text)
            End With

            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            Me.KurzTableAdapter.Fill(Me.Kurz_pocetDataSet.kurz)


            NazovTextBox.Text = ""
            Zaciatok_kurzuDateTimePicker.Checked = False
            Koniec_kurzuDateTimePicker.Checked = False
        Else
            MsgBox("Nemáte zadabé všetky údaje")
        End If
    End Sub

    Private Sub KurzDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("Naozaj chcete zmazať vybraný kurz?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim con As New SqlCeConnection(pripojovaci_retazec)
            Dim com As New SqlCeCommand("DELETE FROM kurz WHERE id = @id", con)
            com.Parameters.AddWithValue("id", Label2.Text)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If

    End Sub

    Private Sub Miesto_konaniaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Miesto_konaniaTextBox.TextChanged

    End Sub

    Private Sub KurzDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        kurz_detail.Show()
    End Sub

    Private Sub KurzDataGridView_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KurzBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

    Private Sub KurzDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellContentClick

    End Sub

    Private Sub KurzDataGridView_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles KurzDataGridView.CellDoubleClick
        kurz_detail.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pomocny.Show()
    End Sub
End Class