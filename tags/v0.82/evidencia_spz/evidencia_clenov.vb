﻿Public Class evidencia_clenov

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub evidencia_clenov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)
        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
        'TODO: This line of code loads data into the 'Pohlad_zdruzenieDataSet1.zdruzenie' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Prehlad_clenovDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
        'TODO: This line of code loads data into the 'PrehladDataSet.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ClenoviaDataSet1.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        'hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        prehlad_clenov.prehlad_clenov_splitter.Panel2.Controls.Add(Me)
        Me.ClenoviaDataGridView.CurrentCell = Nothing


        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub HladajToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' Me.ClenoviaTableAdapter.hladaj(Me.Spz_evidenciaDataSet.clenovia)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub HladajToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Me.ClenoviaTableAdapter.hladaj(Me.Spz_evidenciaDataSet.clenovia)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub HladajToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Me.ClenoviaTableAdapter.hladaj(Me.Spz_evidenciaDataSet.clenovia)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub button_report_zoznam_clenov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        zoznam_clenov_report.Show()
        zoznam_clenov_report.BringToFront()
    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ClenoviaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    

    

    Private Sub BindingNavigatorPositionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClenoviaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Prehlad_clenovDataSet)

    End Sub

    Private Sub ClenoviaDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    'Private Sub ClenoviaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    'Dim aktualna_pozicia As Integer = Me.ClenoviaBindingSource.Position + 1



    '   Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "id", True))
    '  Label2.Text = Label1.Text
    ' Label1.DataBindings.Clear()
    '
    '   detaily_clena.Show()
    '  detaily_clena.BringToFront()

    'End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Try
            Dim id_clena As Integer = Me.Label1.Text
            'podmienka na zmazanie zaznamu
            If MsgBox("Naozaj chcete zmazat zaznam?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
                con.Open()

                Dim com As New OleDb.OleDbCommand("DELETE FROM clenovia WHERE id =" & id_clena, con)

                com.ExecuteNonQuery()
                con.Close()
                Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
            End If
        Catch
            MsgBox("Nemate vybraneho clena!!!", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub karta_clena_tlac_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tlacovy_vystup_clen_1.Show()
        tlacovy_vystup_clen_1.BringToFront()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ClenoviaDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClenoviaDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClenoviaBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()

    End Sub




    Private Sub ClenoviaDataGridView_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClenoviaDataGridView.CellContentClick

    End Sub

    Private Sub ClenoviaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClenoviaDataGridView.CellDoubleClick

        detaily_clena.Show()
        detaily_clena.BringToFront()
    End Sub

    Private Sub hladajButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim hladany_retazec As String = hladajTextBox1.Text
        Me.ClenoviaTableAdapter.FillBy_hladaj_priezvisko(Me.Prehlad_clenovDataSet.clenovia, hladany_retazec)

    End Sub

    Private Sub hladajTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hladajTextBox1.TextChanged
        Dim hladany_retazec As String = hladajTextBox1.Text
        Me.ClenoviaTableAdapter.FillBy_hladaj_priezvisko(Me.Prehlad_clenovDataSet.clenovia, hladany_retazec)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index_zdruzenia As Integer = ComboBox1.SelectedValue
        Me.ClenoviaTableAdapter.FillBy_podla_zdruzenia(Me.Prehlad_clenovDataSet.clenovia, index_zdruzenia)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
            Me.ClenoviaTableAdapter.Fill(Me.Prehlad_clenovDataSet.clenovia)
        End If

    End Sub
End Class