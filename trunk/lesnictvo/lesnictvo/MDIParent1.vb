Imports System.Windows.Forms

Public Class MDIParent1

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

    Private Sub FileMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub DodávateliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodávateliaToolStripMenuItem.Click
        odberatelia.Show()
    End Sub

    Private Sub VšeobecnéÚdajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VšeobecnéÚdajeToolStripMenuItem.Click
        vseobecne_udaje.Show()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CenníkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenníkToolStripMenuItem.Click


    End Sub

    Private Sub ZoznamDrevínToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoznamDrevínToolStripMenuItem.Click
        zoznam_drevin.Show()

    End Sub

    Private Sub MožnostiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MožnostiToolStripMenuItem.Click
        moznosti.Show()

    End Sub

    Private Sub DodacíListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodacíListToolStripMenuItem.Click
        dodaci_list.Show()

    End Sub

    Private Sub VystavenéFaktúryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VystavenéFaktúryToolStripMenuItem.Click
        vystavene_faktury.Show()

    End Sub

    Private Sub CenníkRezivaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenníkRezivaToolStripMenuItem.Click
        cennik_reziva.Show()
    End Sub

    Private Sub CenníkGuľatinovýchVýrezovToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenníkGuľatinovýchVýrezovToolStripMenuItem.Click
        cennik_vyrezov.Show()
    End Sub

    Private Sub Dodak2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dodak2ToolStripMenuItem.Click
        dodak2.Show()
    End Sub

    Private Sub DodacíListRezivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DodacíListRezivoToolStripMenuItem.Click
        dodaci_list_rezivo.Show()
    End Sub
End Class
