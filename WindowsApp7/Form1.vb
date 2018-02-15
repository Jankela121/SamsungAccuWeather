Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Dim month As String
        Dim nighttime As String
        Dim dayoftheweek As String
        dayoftheweek = Today.DayOfWeek
        Form2.Show()
        Label5.Text = Today.Date
#Region "Lines of code for changing day of the week labels"
        If dayoftheweek = 1 Then
            Label12.Text = "TUE"
            Label20.Text = "WED"
            Label23.Text = "THU"
            Label26.Text = "FRI"
            Label29.Text = "SAT"
            Label17.Text = "SUN"
        End If
        If dayoftheweek = 2 Then
            Label12.Text = "WED"
            Label20.Text = "THU"
            Label23.Text = "FRI"
            Label26.Text = "SAT"
            Label29.Text = "SUN"
            Label17.Text = "MON"
        End If
        If dayoftheweek = 3 Then
            Label12.Text = "THU"
            Label20.Text = "FRI"
            Label23.Text = "SAT"
            Label26.Text = "SUN"
            Label29.Text = "MON"
            Label17.Text = "TUE"
        End If
        If dayoftheweek = 4 Then
            Label12.Text = "FRI"
            Label20.Text = "SAT"
            Label23.Text = "SUN"
            Label26.Text = "MON"
            Label29.Text = "TUE"
            Label17.Text = "WED"
        End If
        If dayoftheweek = 5 Then
            Label12.Text = "SAT"
            Label20.Text = "SUN"
            Label23.Text = "MON"
            Label26.Text = "TUE"
            Label29.Text = "WED"
            Label17.Text = "THU"
        End If
        If dayoftheweek = 6 Then
            Label12.Text = "SUN"
            Label20.Text = "MON"
            Label23.Text = "TUE"
            Label26.Text = "WED"
            Label29.Text = "THU"
            Label17.Text = "FRI"
        End If
        If dayoftheweek = 7 Then
            Label12.Text = "MON"
            Label20.Text = "TUE"
            Label23.Text = "WED"
            Label26.Text = "THU"
            Label29.Text = "FRI"
            Label17.Text = "SAT"
        End If
#End Region
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            Label1.Text = WebBrowser1.Document.GetElementById("wob_loc").InnerText
            Label2.Text = WebBrowser1.Document.GetElementById("wob_tm").InnerText
            Label4.Text = WebBrowser1.Document.GetElementById("wob_dc").InnerText
        Catch ex As Exception
            MessageBox.Show("Please type a city into the search box. You can try again by clicking the search button in the up right corner of the window")
        End Try

        Dim p As String
        Dim t As String
        t = TimeOfDay.Hour
        Try
            p = WebBrowser1.Document.GetElementById("wob_tci").GetAttribute("src")
        Catch ex As Exception
        End Try
        TextBox1.Text = p
        If p = "https://ssl.gstatic.com/onebox/weather/64/rain.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_09)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_05)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/partly_cloudy.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_02)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_02)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/snow_s_rain.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_13)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_13)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/snow.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_10)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_10)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/cloudy.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_03)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_03)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/snow_light.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_14)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_14)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/sunny.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_01)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_01)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/sunny_s_cloudy.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_02)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_02)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/thunderstorms.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_07)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_07)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/snow_s_rain.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_07)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_13)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/fog.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_04)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_04)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/rain_light.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_06)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_06)
            End If
        End If
        If p = "https://ssl.gstatic.com/onebox/weather/64/rain_heavy.png" Then
            If t > 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_night_weather_fs_09)
            End If
            If t <= 18 Then
                Me.BackgroundImage = New Bitmap(My.Resources.ic_day_weather_fs_09)
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox15_Click_1(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        About.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Process.Start(TextBox2.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Process.Start("https://www.accuweather.com/en/world/satellite")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        MessageBox.Show("The function of this button is to show all the added locations and see it's forecast. Feature not implemented.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
