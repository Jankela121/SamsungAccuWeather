Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("test.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
        Form1.WebBrowser1.Navigate("https://www.google.rs/search?q=weather+" & TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class