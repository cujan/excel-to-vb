Public Class cenaButtonArray

    Inherits System.Collections.CollectionBase
    Private ReadOnly HostForm As System.Windows.Forms.Form

    Public Function AddNewButton() As System.Windows.Forms.Button
        ' Create a new instance of the Button class.
        Dim aButton As New System.Windows.Forms.Button()
        ' Add the button to the collection's internal list.
        Me.List.Add(aButton)
        ' Add the button to the controls collection of the form 
        ' referenced by the HostForm field.
        HostForm.Controls.Add(aButton)
        ' Set intial properties for the button object.
        aButton.Top = 140 + Count * 25
        aButton.Left = 762
        aButton.Width = 15
        aButton.Height = 22
        aButton.Tag = Me.Count
        aButton.Text = ">"

        AddHandler aButton.Click, AddressOf ClickHandler

        Return aButton
    End Function

    Public Sub New(ByVal host As System.Windows.Forms.Form)
        HostForm = host
        Me.AddNewButton()
    End Sub

    Default Public ReadOnly Property Item(ByVal Index As Integer) As  _
   System.Windows.Forms.Button
        Get
            Return CType(Me.List.Item(Index), System.Windows.Forms.Button)
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

    Public Sub ClickHandler(ByVal sender As Object, ByVal e As  _
    System.EventArgs)
        MessageBox.Show("you have clicked cena button " & CType(CType(sender,  _
           System.Windows.Forms.Button).Tag, String))
    End Sub


End Class


