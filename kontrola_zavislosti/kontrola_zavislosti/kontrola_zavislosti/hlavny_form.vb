Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class hlavny_form
    Private bInstalled As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim message_text As String
        Try
            'Dim oApp As Object = CreateObject("Access.Application")
            Dim oApp As Object = CreateObject("Microsoft.ACE.OLEDB.12.0")
            bInstalled = True
            message_text = "Aplikácia AccessRuntime nájdená :-)"
            hotovo.Visible = True
            ' Label2.Text = bInstalled.ToString
        Catch
            bInstalled = False
            message_text = "Aplikácia AccessRuntime nenájdená :-("
            'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Label1.Text = message_text
        'bInstalled = False
        If Not bInstalled Then
            'MessageBox.Show("Runtime Access 2007.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.Visible = False
            Label1.Visible = False
            Label3.Visible = True
            Label2.Visible = True
            Label2.BringToFront()

            instaluj.Visible = True
            zavriet.Visible = True
            'kontrola_verzii.Show()
            'kontrola_verzii.BringToFront()

            'Else
            '    'Me.Visible = False
            '    Me.Hide()
            '    kontrola_verzii.Show()
            '    kontrola_verzii.BringToFront()
            '    'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub instaluj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instaluj.Click
        Process.Start("AccessRuntime.exe")
        'Me.Close()
    End Sub

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("http://www.microsoft.com/downloads/details.aspx?familyid=d9ae78d9-9dc6-4b38-9fa6-2c745a175aed&displaylang=en")
    End Sub

    Private Sub hotovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hotovo.Click
        Me.Close()
    End Sub
End Class
