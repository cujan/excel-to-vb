Imports System.Windows.Forms

Public Class hlavna_aplikacia



   

    Private Sub nastavenia_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_button.Click
        If nastavenia_button.Text = "v" Then
            nastavenia_button.Text = "^"
            nastavenia_splitter.Panel2Collapsed = False
        Else
            nastavenia_button.Text = "v"
            nastavenia_splitter.Panel2Collapsed = True
        End If
    End Sub

    Private Sub tl_zostavy_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tl_zostavy_button.Click
        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If tl_zostavy_button.Text = "v" Then
            tl_zostavy_button.Text = "^"
            tl_zostavy_splitter.Panel2Collapsed = False
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 165
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        Else
            tl_zostavy_button.Text = "v"
            tl_zostavy_splitter.Panel2Collapsed = True
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X

            nastavenia_splitter.Location = tl_zostavy_splitter_position

        End If
    End Sub
End Class
