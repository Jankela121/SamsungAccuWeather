Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month As String
        Dim nighttime As String
        Form2.Show()

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Label1.Text = WebBrowser1.Document.GetElementById("wob_loc").InnerText
        Label2.Text = WebBrowser1.Document.GetElementById("wob_tm").InnerText
        Label4.Text = WebBrowser1.Document.GetElementById("wob_dc").InnerText
        Dim p As String
        Dim t As String
        t = TimeOfDay.Hour
        p = WebBrowser1.Document.GetElementById("wob_tci").GetAttribute("src")
        TextBox1.Text = p
        If p = "https://ssl.gstatic.com/onebox/weather/64/rain.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap("C:\Program Files (x86)\AccuWeather\Resources\ic_night_weather_fs_09.jpg")
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap("C:\Program Files (x86)\AccuWeather\Resources\ic_day_weather_fs_05.jpg")
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/partly_cloudy.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap("C:\Program Files (x86)\AccuWeather\Resources\ic_night_weather_fs_02.jpg")
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap("C:\Program Files (x86)\AccuWeather\Resources\ic_day_weather_fs_02.jpg")
            End If
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_BackgroundImageChanged(sender As Object, e As EventArgs) Handles MyBase.BackgroundImageChanged

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Form2.Show()
    End Sub
End Class
