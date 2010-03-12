Public Class kurz_novy

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KurzBindingSource.EndEdit()


    End Sub

    Private Sub kurz_novy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PilcikdbDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.PilcikdbDataSet.kurz)
        'TODO: This line of code loads data into the 'Pilcik_dbDataSet.kurz' table. You can move, or remove it, as needed.


    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PilcikdbDataSet)

    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("INSERT INTO kurz (nazov, zaciatok_kurzu, koniec_kurzu) VALUES (@nazov,@zaciatok_kurzu,@koniec_kurzu)", con)

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
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Me.KurzTableAdapter.Fill(Me.PilcikdbDataSet.kurz)

        NazovTextBox.Text = ""
        Zaciatok_kurzuDateTimePicker.Checked = False
        Koniec_kurzuDateTimePicker.Checked = False
    End Sub
End Class