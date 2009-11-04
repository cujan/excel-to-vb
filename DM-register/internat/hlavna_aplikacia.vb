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
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 110
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

    Private Sub sprava_ubytovanych_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_ubytovanych_button.Click
        Dim prehlad_ubytovanych_splitter_position As New System.Drawing.Point
        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If sprava_ubytovanych_button.Text = "v" Then
            sprava_ubytovanych_button.Text = "^"
            prehlad_ubytovanych_splitter.Panel2Collapsed = False
            prehlad_ubytovanych_splitter_position.Y = prehlad_ubytovanych_splitter.Location.Y + 120
            prehlad_ubytovanych_splitter_position.X = prehlad_ubytovanych_splitter.Location.X
            tl_zostavy_splitter.Location = prehlad_ubytovanych_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 110

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        Else
            sprava_ubytovanych_button.Text = "v"
            prehlad_ubytovanych_splitter.Panel2Collapsed = True

            prehlad_ubytovanych_splitter_position.Y = prehlad_ubytovanych_splitter.Location.Y + 34
            prehlad_ubytovanych_splitter_position.X = prehlad_ubytovanych_splitter.Location.X
            tl_zostavy_splitter.Location = prehlad_ubytovanych_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 120

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        End If


    End Sub

    Private Sub ciselniky_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ciselniky_button.Click
        ciselniky.Show()
        ciselniky.BringToFront()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        evidencia_studentov_button.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        novy_student.Show()
    End Sub

    Private Sub novy_student_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles novy_student_button.Click
        novy_student.Show()
        novy_student.BringToFront()

    End Sub

    Private Sub evidencia_studentov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evidencia_studentov_button.Click
        evidencia_studentov.Show()
        evidencia_studentov.BringToFront()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pokusny.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(pripojovaci_retazec)
    End Sub
End Class
