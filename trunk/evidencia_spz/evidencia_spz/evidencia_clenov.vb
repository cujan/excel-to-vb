Public Class evidencia_clenov

    Private Sub ClenoviaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub evidencia_clenov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClenoviaDataSet1.clenovia' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Spz_evidenciaDataSet.clenovia' table. You can move, or remove it, as needed.
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub button_report_zoznam_clenov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_report_zoznam_clenov.Click
        zoznam_clenov_report.Show()
        zoznam_clenov_report.BringToFront()
    End Sub

    Private Sub ClenoviaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub
End Class