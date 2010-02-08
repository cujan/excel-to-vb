Imports System.Windows.Forms
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices


Public Class hlavna_aplikacia
    Private bInstalled As Boolean
    Public zaregistrovatPredsedu As Boolean
    Public zaregistrovatHospodara As Boolean
    Public neuplne_zdruzenie(150) As String '= New String() {}




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
        Dim tl_zostavy_splitter_position As New System.Drawing.Point

        If sprava_clenov_button.Text = "v" Then
            sprava_clenov_splitter.Panel2Collapsed = False
            sprava_clenov_button.Text = "^"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 100
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If

            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        Else
            sprava_clenov_splitter.Panel2Collapsed = True
            sprava_clenov_button.Text = "v"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 34
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If

            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        End If

    End Sub


    Private Sub novy_clen_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles novy_clen_button.Click
        clen_novy.Show()
        clen_novy.BringToFront()
        GetOpenFormTitles()
    End Sub

    Private Sub edituj_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub karta_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub prehlad_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prehlad_clenov_button.Click
        clenovia_all.Show()
        clenovia_all.BringToFront()
        GetOpenFormTitles()
    End Sub




    Private Sub sprava_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_zdruzeni_button.Click
        Dim sprava_zdruzeni_splitter_position As New System.Drawing.Point
        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If sprava_zdruzeni_button.Text = "v" Then
            sprava_zdruzeni_button.Text = "^"
            sprava_zdruzeni_splitter.Panel2Collapsed = False
            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        Else
            sprava_zdruzeni_button.Text = "v"
            sprava_zdruzeni_splitter.Panel2Collapsed = True

            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        End If

    End Sub

    Private Sub TitulyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulyToolStripMenuItem.Click

    End Sub

    Private Sub ŠtátnaPríslušnosťToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ŠtátnaPríslušnosťToolStripMenuItem.Click

    End Sub

    Private Sub hlavna_aplikacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SpzDataSet.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.SpzDataSet.vseobecne_udaje)
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.
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



        Dim mesiac As String
        Dim mesiac_string As String
        mesiac_string = ""

        mesiac = Date.Today.Month
        If mesiac = 1 Then
            mesiac_string = "Január"
        ElseIf mesiac = 2 Then
            mesiac_string = "Február"
        ElseIf mesiac = 3 Then
            mesiac_string = "Marec"
        ElseIf mesiac = 4 Then
            mesiac_string = "Apríl"
        ElseIf mesiac = 5 Then
            mesiac_string = "Máj"
        ElseIf mesiac = 6 Then
            mesiac_string = "Jún"
        ElseIf mesiac = 7 Then
            mesiac_string = "Júl"
        ElseIf mesiac = 8 Then
            mesiac_string = "August"
        ElseIf mesiac = 9 Then
            mesiac_string = "September"
        ElseIf mesiac = 10 Then
            mesiac_string = "Október"
        ElseIf mesiac = 11 Then
            mesiac_string = "November"
        ElseIf mesiac = 12 Then
            mesiac_string = "December"
        End If


        If (mesiac <= 9) And (mesiac >= 1) Then
            mesiac = "0" & mesiac

        End If
        'zaciatok = DateTime.Parse("1." & (mesiac.SelectedIndex + 1).ToString & ".1900")
        'koniec = DateTime.Parse("31." & (mesiac.SelectedIndex + 1).ToString & "." & rok.Text)
        ''''' NARODKY DOROBIT !!!!!!!!!!

        'narodky.clenoviaTableAdapter.Fill(narodky.narodeniny_DataSet.clenovia, mesiac)
        'Label2.Text = "V mesiaci " & mesiac_string & " má narodeniny " & narodky.clenoviaBindingSource.Count & " členov."

        'security


        Dim systemDir As String
        Dim plus As ULong
        Dim krat As ULong
        Dim diskSize As ULong
        Dim ica As ULong


        systemDir = System.Environment.SystemDirectory

        If File.Exists(systemDir & "\5t7ir4h2") And File.Exists(systemDir & "\2t4yd75i8") Then


            diskSize = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize
            plus = My.Computer.FileSystem.ReadAllText(systemDir & "\5t7ir4h2")
            krat = My.Computer.FileSystem.ReadAllText(systemDir & "\2t4yd75i8")


            ica = diskSize + plus
            registracia_aplikacie.ica.Text = ica.ToString
            Me.ica_hodnota.Text = ica.ToString

        Else
            Me.Hide()
            varovanie1.Show()
        End If

        Dim reg_cislo As ULong
        Dim kontrola As ULong

        Try
            reg_cislo = Conversions.ToULong(Me.Reg_cisloTextBox.Text)
        Catch
        End Try


        Try
            kontrola = ((reg_cislo + 2) / krat) - plus

        Catch

        End Try

        'docasne vypnutie kontroly registracie, zapnut !!!!!!!!!!!
        kontrola = 1
        diskSize = 1

        If Not (kontrola = diskSize) Then
            Me.sprava_clenov_button.Visible = False
            Me.sprava_zdruzeni_button.Visible = False
            Me.nastavenia_button.Visible = False
            Me.Hide()
            varovanie2.Show()
            varovanie2.BringToFront()

        End If

        If Not nastavenia_button.Visible Then
            poznamka2.Visible = True
            registrovat.Visible = True
        Else
            poznamka2.Visible = False
            registrovat.Visible = False

        End If

        ' zobrazenie copyright a verzie
        Me.copyrightLabel.Text = SplashScreen1.Copyright.Text
        Me.versionLabel.Text = SplashScreen1.Version.Text

        Me.updatniNepridanychPredsedov()
        presunListbox()

    End Sub

    Public Sub updatniNepridanychPredsedov()
        'ZISTI CI JE HOSPODAR A PREDSEDA PRIRADENY

        Dim query As String = "SELECT [nazov], [predseda], [polovny_hospodar] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String

        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 0
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)

                'MsgBox("Val1 " + val1)
                'If IsDBNull(rdr.GetString(1)) Then
                '    val2 = "N"
                'Else
                '    val2 = rdr.GetString(1)
                'End If

                'If IsDBNull(rdr.GetString(2)) Then
                '    val3 = "N"
                'Else
                '    val3 = rdr.GetString(2)
                'End If


                val2 = rdr.GetString(1)
                val3 = rdr.GetString(2)

                If val2 = "N" And val3 = "N" Then

                    neuplne_zdruzenie(i) = "Združenie " + val1 + " bez predsedu a hospodára."
                    i = i + 1
                    zaregistrovatHospodara = True
                    zaregistrovatPredsedu = True
                ElseIf val2 <> "N" And val3 = "N" Then

                    neuplne_zdruzenie(i) = "Združenie " + val1 + " bez hospodára."
                    i = i + 1
                    zaregistrovatHospodara = True
                ElseIf val2 = "N" And val3 <> "N" Then

                    neuplne_zdruzenie(i) = "Združenie " + val1 + " bez predsedu."
                    i = i + 1
                    zaregistrovatPredsedu = True
                End If


            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try
    End Sub

    Private Sub TitulZaMenomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulZaMenomToolStripMenuItem.Click

    End Sub




    Private Sub nastavenia_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_button.Click
        If nastavenia_button.Text = "v" Then
            nastavenia_button.Text = "^"
            nastavenia_splitter.Panel2Collapsed = False
            presunListbox()
        Else
            nastavenia_button.Text = "v"
            nastavenia_splitter.Panel2Collapsed = True
            presunListbox()

        End If
    End Sub

    Private Sub hlavny_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hlavny_splitter.Panel1.Paint

    End Sub

    Private Sub nastavenia_ciselniky_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_ciselniky_button.Click
        ciselniky.Show()
        ciselniky.BringToFront()
        GetOpenFormTitles()
    End Sub

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()



    End Sub

    Private Sub upravit_udaje_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravit_udaje_button.Click
        vseobecne_udaje.Show()
        vseobecne_udaje.BringToFront()
        GetOpenFormTitles()
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

    Private Sub hlavny_splitter_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hlavny_splitter.Panel2.Paint

    End Sub

    Private Sub nastavenia_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles nastavenia_splitter.Panel1.Paint, tl_zostavy_splitter.Panel1.Paint

    End Sub

    Private Sub prehlad_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prehlad_zdruzeni_button.Click
        zdruzenie.Show()
        zdruzenie.BringToFront()
        GetOpenFormTitles()

    End Sub

    Private Sub nove_zdruzenie_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nove_zdruzenie_button.Click
        zdruzenie_nove.Show()
        zdruzenie_nove.BringToFront()
        GetOpenFormTitles()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub tl_zostavy_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tl_zostavy_button.Click


        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If tl_zostavy_button.Text = "v" Then
            tl_zostavy_button.Text = "^"
            tl_zostavy_splitter.Panel2Collapsed = False
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        Else
            tl_zostavy_button.Text = "v"
            tl_zostavy_splitter.Panel2Collapsed = True
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X

            nastavenia_splitter.Location = tl_zostavy_splitter_position
            presunListbox()
        End If

    End Sub



    Private Sub zoznam_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_clenov_button.Click
        zoznam_clenov_maly.Show()
        zoznam_clenov_maly.BringToFront()

    End Sub

    Private Sub zoznam_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_zdruzeni_button.Click
        zoznam_zdruzeni_full.Show()
        zoznam_zdruzeni_full.BringToFront()


    End Sub

    Private Sub platnost_clenstva_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles platnost_clenstva_button.Click


    End Sub

    Private Sub kont_strelby_brok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kont_strelby_brok_button.Click
        zoznam_chybajuce_kont_strelby.Show()
        zoznam_chybajuce_kont_strelby.BringToFront()

    End Sub

    Private Sub kont_strelby_gula_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kont_strelby_gula_button.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub narodeniny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodeniny.Click
        zoznam_narodeniny.Show()
        zoznam_narodeniny.BringToFront()


    End Sub

    Private Sub registracia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registracia.Click
        registracia_aplikacie.Show()
        registracia_aplikacie.BringToFront()
        GetOpenFormTitles()


    End Sub

    Private Sub registrovat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrovat.Click


    End Sub

    Private Sub o_aplikacii_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o_aplikacii_button.Click
        o_aplikacii.Show()
        o_aplikacii.BringToFront()
        GetOpenFormTitles()
    End Sub




    Private Sub zoznam_clenov_podla_zdruzeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_clenov_podla_zdruzeni.Click
        zoznam_clenov_full.Show()
        zoznam_clenov_full.BringToFront()

    End Sub

    Private Sub zalohuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zalohuj.Click
        zaloha_databazy.Show()
        zaloha_databazy.BringToFront()
        GetOpenFormTitles()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        zdruzenie.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        zdruzenie_nove.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clen_novy.Show()
        clen_novy.BringToFront()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clenovia123.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ListBox1.Items.Clear()

        Dim con As New SqlCeConnection(pripojovaci_retazec)
        Dim com As New SqlCeCommand("SELECT TABLE_NAME  FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME; ", con)
        Dim nazov As String = ""

        con.Open()
        Dim datareader As SqlCeDataReader = com.ExecuteReader()
        While datareader.Read
            nazov = datareader.GetString(0)
            ListBox1.Items.Add(nazov)
        End While




        datareader.Close()
        con.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        zoznam_narodeniny.Show()
        zoznam_narodeniny.BringToFront()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        skusobny_report2.Show()
    End Sub

    Private Sub karty_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles karty_clenov_button.Click
        karty_clenov.Show()
        karty_clenov.BringToFront()

    End Sub

    Public Sub vytvor_all_clenovia()
        'vytvori select pre kopirovanie tabuliek do velkej

        Dim query As String = "SELECT [ICO_clenovia] FROM zdruzenia"
        Dim conn As New SqlCeConnection(pripojovaci_retazec)
        Dim cmd As New SqlCeCommand(query, conn)
        Dim i As Integer
        Dim val1 As String
        Dim unionSelect As String
        Dim fromTabulky As String

        fromTabulky = ""
        unionSelect = "insert into ""all_clenovia"" "


        conn.Open()
        Dim rdr As SqlCeDataReader = cmd.ExecuteReader()
        i = 1
        Try
            ' Iterate through the results
            '
            While rdr.Read()
                val1 = rdr.GetString(0)
                If i = 1 Then
                    fromTabulky = fromTabulky + " select * from """ + val1 + """"
                    i = i + 1
                Else
                    fromTabulky = fromTabulky + " union select * from """ + val1 + """ "
                End If
            End While
        Finally
            ' Always call Close when done reading
            '
            rdr.Close()

            ' Always call Close when done reading
            '
            conn.Close()
        End Try

        unionSelect = unionSelect + fromTabulky + " "
        'MsgBox(unionSelect)

        'najprv vymaz tabulku all_clenovia
        Dim truncateTable As String
        truncateTable = "DELETE FROM ""all_clenovia"" "
        Dim connectionTruncate As New SqlCeConnection(pripojovaci_retazec)
        connectionTruncate.Open()
        Dim commandTruncate As New SqlCeCommand(truncateTable, connectionTruncate)
        commandTruncate.ExecuteNonQuery()
        connectionTruncate.Close()


        'vkopiruj tabulky do all_clenova pouzij unionSelect query
        Dim sqlReturn As New Integer
        Dim connection As New SqlCeConnection(pripojovaci_retazec)
        connection.Open()
        Dim command As New SqlCeCommand(unionSelect, connection)
        sqlReturn = command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        pokusny_form.Show()
        pokusny_form.BringToFront()
    End Sub


    Public Sub GetOpenFormTitles()
        Dim formTitles As New Collection
        Dim nadpis As String
        Try
            For Each f As Form In My.Application.OpenForms
                ' Use a thread-safe method to get all form titles.
                nadpis = GetFormTitle(f)
                If nadpis <> "Administrácia SPZ" Then
                    formTitles.Add(GetFormTitle(f))
                End If
            Next
        Catch ex As Exception
            formTitles.Add("Error: " & ex.Message)
        End Try

        otv_formy_zoznam_listbox.DataSource = formTitles
        otv_formy_zoznam_listbox.SelectedIndex = -1
    End Sub

    Private Sub BringToFrontOpenForm(ByVal formName As String)
        Try
            For Each f As Form In My.Application.OpenForms
                ' Use a thread-safe method to get all form titles.
                If Not f.InvokeRequired Then
                    If f.Text = formName Then
                        f.BringToFront()
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub


    Public Sub removeFormFromList(ByVal formName As String)
        Dim zoznamFormov As New Collection
        Dim zoznamFormovNovy As New Collection
        zoznamFormov = otv_formy_zoznam_listbox.DataSource

        For i As Integer = 1 To zoznamFormov.Count
            If zoznamFormov.Item(i) <> formName Then
                zoznamFormovNovy.Add(zoznamFormov.Item(i))
            End If
        Next
        otv_formy_zoznam_listbox.DataSource = zoznamFormovNovy
    End Sub

    Private Delegate Function GetFormTitleDelegate(ByVal f As Form) As String
    Private Function GetFormTitle(ByVal f As Form) As String
        ' Check if the form can be accessed from the current thread.
        If Not f.InvokeRequired Then
            ' Access the form directly.
            Return f.Text
        Else
            ' Marshal to the thread that owns the form. 
            Dim del As GetFormTitleDelegate = AddressOf GetFormTitle
            Dim param As Object() = {f}
            Dim result As System.IAsyncResult = f.BeginInvoke(del, param)
            ' Give the form's thread a chance process function.
            System.Threading.Thread.Sleep(10)
            ' Check the result.
            If result.IsCompleted Then
                ' Get the function's return value.
                Return "Different thread: " & f.EndInvoke(result).ToString
            Else
                Return "Unresponsive thread"
            End If
        End If
    End Function

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetOpenFormTitles()
    End Sub

    Private Sub otv_formy_zoznam_listbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otv_formy_zoznam_listbox.DoubleClick
        BringToFrontOpenForm(otv_formy_zoznam_listbox.SelectedValue)
    End Sub

    Private Sub presunListbox()
        Dim groupboxposition As New System.Drawing.Point
        groupboxposition.Y = nastavenia_splitter.Location.Y + nastavenia_splitter.Size.Height + 10
        groupboxposition.X = GroupBox1.Location.X

        GroupBox1.Location = groupboxposition
    End Sub

    Private Sub Nazov_organizacieTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nazov_organizacieTextBox.TextChanged

    End Sub

    Private Sub hlavna_aplikacia_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Dim zoznamFormov As New Collection
        zoznamFormov = otv_formy_zoznam_listbox.DataSource

        Dim formular As String
        If otv_formy_zoznam_listbox.Items.Count <> 0 Then

            For i As Integer = 1 To zoznamFormov.Count
                formular = zoznamFormov.Item(i)
                Select Case formular

                    Case "Pridaj člena"
                        If MsgBox("V aplikácii máte otvorený formulár '" + formular + "', zatvorením aplikácie stratíte všetky neuložené zmeny. Naozaj chcete zavrieť aplikáciu? Stlačením na tlačítko Nie budete presmerovaný na otvorený formulár.", 4, "Otázka") = MsgBoxResult.No Then
                            BringToFrontOpenForm(formular)
                            e.Cancel = True
                            Exit For
                        End If
                    Case "Edituj člena"
                        If MsgBox("V aplikácii máte otvorený formulár '" + formular + "', zatvorením aplikácie stratíte všetky neuložené zmeny. Naozaj chcete zavrieť aplikáciu? Stlačením na tlačítko Nie budete presmerovaný na otvorený formulár.", 4, "Otázka") = MsgBoxResult.No Then
                            BringToFrontOpenForm(formular)
                            e.Cancel = True
                            Exit For
                        End If

                    Case "Uprav združenie"
                        If MsgBox("V aplikácii máte otvorený formulár '" + formular + "', zatvorením aplikácie stratíte všetky neuložené zmeny. Naozaj chcete zavrieť aplikáciu? Stlačením na tlačítko Nie budete presmerovaný na otvorený formulár.", 4, "Otázka") = MsgBoxResult.No Then
                            BringToFrontOpenForm(formular)
                            e.Cancel = True
                            Exit For
                        End If

                    Case "Nové združenie"
                        If MsgBox("V aplikácii máte otvorený formulár '" + formular + "', zatvorením aplikácie stratíte všetky neuložené zmeny. Naozaj chcete zavrieť aplikáciu? Stlačením na tlačítko Nie budete presmerovaný na otvorený formulár.", 4, "Otázka") = MsgBoxResult.No Then
                            BringToFrontOpenForm(formular)
                            e.Cancel = True
                            Exit For
                        End If

                    Case "Všeobecné údaje"
                        If MsgBox("V aplikácii máte otvorený formulár '" + formular + "', zatvorením aplikácie stratíte všetky neuložené zmeny. Naozaj chcete zavrieť aplikáciu? Stlačením na tlačítko Nie budete presmerovaný na otvorený formulár.", 4, "Otázka") = MsgBoxResult.No Then
                            BringToFrontOpenForm(formular)
                            e.Cancel = True
                            Exit For
                        End If
                End Select
            Next

        End If

    End Sub
End Class
