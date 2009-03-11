Public Class detaily_zdruzenia

    Private Sub ZdruzenieBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZdruzenieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

    End Sub

    Private Sub detaily_zdruzenia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ZdruzenieDataSet.zdruzenie' table. You can move, or remove it, as needed.
        Me.ZdruzenieTableAdapter.Fill(Me.ZdruzenieDataSet.zdruzenie)

        Dim pozicia_zdruzenia As Integer = prehlad_zdruzeni.ZdruzenieBindingSource.Position
        Me.ZdruzenieBindingSource.Position = pozicia_zdruzenia

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        prehlad_zdruzeni.prehlad_clenov_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravitButton.Click
        Me.BankaTextBox.ReadOnly = False
        Me.BazantTextBox.ReadOnly = False
        Me.BrlohareTextBox.ReadOnly = False
        Me.Cislo_reviruTextBox.ReadOnly = False
        Me.Cislo_uctuTextBox.ReadOnly = False
        Me.DicTextBox.ReadOnly = False
        Me.DiviaciaTextBox.ReadOnly = False
        Me.Chovatelska_oblastTextBox.ReadOnly = False
        Me.FarbiareTextBox.ReadOnly = False
        Me.IcoTextBox.ReadOnly = False
        Me.InaTextBox.ReadOnly = False
        Me.JeleniaTextBox.ReadOnly = False
        Me.LesTextBox.ReadOnly = False
        Me.Nazov_polovneho_reviruTextBox.ReadOnly = False
        Me.NazovTextBox.ReadOnly = False
        Me.Ostatne_duriceTextBox.ReadOnly = False
        Me.Pes_diviaciaTextBox.ReadOnly = False
        Me.Pes_jeleniaTextBox.ReadOnly = False
        Me.Pes_malaTextBox.ReadOnly = False
        Me.Pes_srnciaTextBox.ReadOnly = False
        Me.Polovnicky_hospodar_telefonTextBox.ReadOnly = False
        Me.Polovnicky_hospodarTextBox.ReadOnly = False
        Me.Predseda_telefonTextBox.ReadOnly = False
        Me.PredsedaTextBox.ReadOnly = False
        Me.SidloTextBox.ReadOnly = False
        Me.SliediceTextBox.ReadOnly = False
        Me.Slovensky_kopovTextBox.ReadOnly = False
        Me.SrnciaTextBox.ReadOnly = False
        Me.StavaceTextBox.ReadOnly = False
        Me.VymeraTextBox.ReadOnly = False

        Me.upravitButton.Visible = False
        Me.ulozButton.Visible = True
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.ZdruzenieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZdruzenieDataSet)

        Me.ulozButton.Visible = False
        Me.upravitButton.Visible = True

        Me.BankaTextBox.ReadOnly = True
        Me.BazantTextBox.ReadOnly = True
        Me.BrlohareTextBox.ReadOnly = True
        Me.Cislo_reviruTextBox.ReadOnly = True
        Me.Cislo_uctuTextBox.ReadOnly = True
        Me.DicTextBox.ReadOnly = True
        Me.DiviaciaTextBox.ReadOnly = True
        Me.Chovatelska_oblastTextBox.ReadOnly = True
        Me.FarbiareTextBox.ReadOnly = True
        Me.IcoTextBox.ReadOnly = True
        Me.InaTextBox.ReadOnly = True
        Me.JeleniaTextBox.ReadOnly = True
        Me.LesTextBox.ReadOnly = True
        Me.Nazov_polovneho_reviruTextBox.ReadOnly = True
        Me.NazovTextBox.ReadOnly = True
        Me.Ostatne_duriceTextBox.ReadOnly = True
        Me.Pes_diviaciaTextBox.ReadOnly = True
        Me.Pes_jeleniaTextBox.ReadOnly = True
        Me.Pes_malaTextBox.ReadOnly = True
        Me.Pes_srnciaTextBox.ReadOnly = True
        Me.Polovnicky_hospodar_telefonTextBox.ReadOnly = True
        Me.Polovnicky_hospodarTextBox.ReadOnly = True
        Me.Predseda_telefonTextBox.ReadOnly = True
        Me.PredsedaTextBox.ReadOnly = True
        Me.SidloTextBox.ReadOnly = True
        Me.SliediceTextBox.ReadOnly = True
        Me.Slovensky_kopovTextBox.ReadOnly = True
        Me.SrnciaTextBox.ReadOnly = True
        Me.StavaceTextBox.ReadOnly = True
        Me.VymeraTextBox.ReadOnly = True
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub Nazov_polovneho_reviruTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nazov_polovneho_reviruTextBox.TextChanged

    End Sub
End Class