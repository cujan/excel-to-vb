Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()


        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        PictureBox1.Image() = System.Drawing.Image.FromFile(PictureBox1.ImageLocation)
        TextBox1.Text = PictureBox1.ImageLocation
        Label4.Text = PictureBox1.Image.Size.ToString


    End Sub

End Class
