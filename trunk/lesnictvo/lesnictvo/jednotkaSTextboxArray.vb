Public Class jednotkaSTextboxArray
    Inherits System.Collections.CollectionBase
    Private ReadOnly HostForm As System.Windows.Forms.Form

    Public Function AddNewTextbox() As System.Windows.Forms.TextBox
        ' Create a new instance of the Button class.
        Dim aTextbox As New System.Windows.Forms.TextBox()

        ' Add the button to the collection's internal list.
        Me.List.Add(aTextbox)
        ' Add the button to the controls collection of the form 
        ' referenced by the HostForm field.
        HostForm.Controls.Add(aTextbox)
        ' Set intial properties for the button object.
        aTextbox.Top = 140 + Count * 25
        aTextbox.Left = 465
        aTextbox.Width = 50
        aTextbox.Height = 22
        aTextbox.Tag = Me.Count
        aTextbox.Text = "0"

        '       AddHandler aTextbox.Click, AddressOf ClickHandler

        Return aTextbox
    End Function

    Public Sub New(ByVal host As System.Windows.Forms.Form)
        HostForm = host
        Me.AddNewTextbox()
    End Sub

    Default Public ReadOnly Property Item(ByVal Index As Integer) As  _
   System.Windows.Forms.TextBox
        Get
            Return CType(Me.List.Item(Index), System.Windows.Forms.TextBox)
        End Get
    End Property

    Public Sub Remove()
        ' Check to be sure there is a button to remove.
        If Me.Count > 0 Then
            ' Remove the last button added to the array from the host form 
            ' controls collection. Note the use of the default property in 
            ' accessing the array.
            HostForm.Controls.Remove(Me(Me.Count - 1))
            Me.List.RemoveAt(Me.Count - 1)
        End If
    End Sub
End Class
