Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class hlavna_aplikacia
    Private bInstalled As Boolean

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub sprava_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_clenov_button.Click
        Dim sprava_clenov_splitter_position As New System.Drawing.Point
        Dim sprava_zdruzeni_splitter_position As New System.Drawing.Point

        If sprava_clenov_button.Text = "v" Then
            sprava_clenov_splitter.Panel2Collapsed = False
            sprava_clenov_button.Text = "^"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 154
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 154
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If

            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            nastavenia_splitter.Location = sprava_zdruzeni_splitter_position

        Else
            sprava_clenov_splitter.Panel2Collapsed = True
            sprava_clenov_button.Text = "v"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 34
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 154
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            nastavenia_splitter.Location = sprava_zdruzeni_splitter_position

        End If

    End Sub


    Private Sub novy_clen_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles novy_clen_button.Click
        novy_clen.Show()
        novy_clen.BringToFront()

    End Sub

    Private Sub edituj_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edituj_clena_button.Click
        edituj_clena.Show()
        edituj_clena.BringToFront()

    End Sub

    Private Sub karta_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles karta_clena_button.Click
        karta_clena.Show()
        karta_clena.BringToFront()

    End Sub

    Private Sub prehlad_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prehlad_clenov_button.Click
        prehlad_clenov.Show()
        prehlad_clenov.BringToFront()

    End Sub


    Private Sub sprava_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_zdruzeni_button.Click
        Dim sprava_zdruzeni_splitter_position As New System.Drawing.Point

        If sprava_zdruzeni_button.Text = "v" Then
            sprava_zdruzeni_button.Text = "^"
            sprava_zdruzeni_splitter.Panel2Collapsed = False
            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 154
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            nastavenia_splitter.Location = sprava_zdruzeni_splitter_position
        Else
            sprava_zdruzeni_button.Text = "v"
            sprava_zdruzeni_splitter.Panel2Collapsed = True

            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            nastavenia_splitter.Location = sprava_zdruzeni_splitter_position

        End If

    End Sub

    Private Sub TitulyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulyToolStripMenuItem.Click
        titul.Show()
    End Sub

    Private Sub ŠtátnaPríslušnosťToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ŠtátnaPríslušnosťToolStripMenuItem.Click
        statna_prislusnost.Show()
    End Sub

    Private Sub hlavna_aplikacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Spz_vseobecne_udaje.vseobecne_udaje)
        Try
            'Dim oApp As Object = CreateObject("Access.Application")
            Dim oApp As Object = CreateObject("Microsoft.ACE.OLEDB.12.0")
            bInstalled = True
            ' Label2.Text = bInstalled.ToString
        Catch
            bInstalled = False
            'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If Not bInstalled Then
            'MessageBox.Show("Runtime Access 2007.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.Visible = False
            Me.Hide()
            kontrola_verzii.Show()
            kontrola_verzii.BringToFront()
            'Else
            '    'Me.Visible = False
            '    Me.Hide()
            '    kontrola_verzii.Show()
            '    kontrola_verzii.BringToFront()
            '    'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub TitulZaMenomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulZaMenomToolStripMenuItem.Click
        titul_za.Show()
    End Sub




    Private Sub nastavenia_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_button.Click
        If nastavenia_button.Text = "v" Then
            nastavenia_button.Text = "^"
            nastavenia_splitter.Panel2Collapsed = False
        Else
            nastavenia_button.Text = "v"
            nastavenia_splitter.Panel2Collapsed = True

        End If
    End Sub

    Private Sub hlavny_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hlavny_splitter.Panel1.Paint

    End Sub

    Private Sub nastavenia_ciselniky_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_ciselniky_button.Click
        ciselniky.Show()
        ciselniky.BringToFront()
    End Sub

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_vseobecne_udaje)

    End Sub

    Private Sub upravit_udaje_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravit_udaje_button.Click
        vseobecne_udaje.Show()
        vseobecne_udaje.BringToFront()

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim url As String
        url = Label1.Text
        If url.Contains("http") Or url.Contains("HTTP") Then
            url = url
        Else
            url = "http://" & url
        End If
        Shell("explorer.exe " & url)

    End Sub
End Class
