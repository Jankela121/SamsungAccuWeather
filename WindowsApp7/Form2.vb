﻿Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("test.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
        Form1.TextBox2.Text = "https://www.google.rs/search?q=weather+" & TextBox1.Text
        Form1.WebBrowser1.Navigate("https://www.google.rs/search?q=weather+" & TextBox1.Text)
        CsQuery.CQ.CreateFromUrl("https://www.google.rs/search?q=weather+" & TextBox1.Text)


        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Form1.TextBox2.Text = "https://www.google.rs/search?q=weather+" & TextBox1.Text
            Form1.WebBrowser1.Navigate("https://www.google.rs/search?q=weather+" & TextBox1.Text)
            CsQuery.CQ.CreateFromUrl("https://www.google.rs/search?q=weather+" & TextBox1.Text)

            Me.Close()
        End If
    End Sub
End Class