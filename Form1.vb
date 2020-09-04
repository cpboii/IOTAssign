Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response


Public Class Form1
    Public mLevel As String

    Private fireConn As New FirebaseConfig() With
    {
        .AuthSecret = "wDqNDipGVNLoy2isuHHCdDdOsOkZNdX4x378NDu7",
        .BasePath = "https://bait2123-iot-projeckkk.firebaseio.com/"
    }

    Private client As IFirebaseClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fireConn)
        Catch ex As Exception
            MessageBox.Show("There was a problem in the internet connection.")
        End Try


        Dim res = client.Get("asgm/")
        Dim newData As New iotReading()
        newData = res.ResultAs(Of iotReading)

        lblHumid.Text = newData.Humidity
        lblTemp.Text = newData.Temp
        lastWaterLbl.Text = newData.lastWatering



        If newData.moisturelevel = "High" Then
            aBtn.Enabled = False
            hBtn.Enabled = True
            lBtn.Enabled = False
            btnWater.Enabled = False

        ElseIf newData.moisturelevel = "Average" Then
            hBtn.Enabled = False
            aBtn.Enabled = True
            lBtn.Enabled = False
            btnWater.Enabled = True
        ElseIf newData.moisturelevel = "Low" Then
            aBtn.Enabled = False
            hBtn.Enabled = False
            lBtn.Enabled = True
            btnWater.Enabled = True
        End If

        mLevel = newData.moisturelevel


    End Sub

    Private Sub btnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        Dim newData As New iotReading() With
        {
        .led = "1",
        .Humidity = lblHumid.Text,
        .Temp = lblTemp.Text,
        .lastWatering = lastWaterLbl.Text,
        .moisturelevel = "High"
        }
        Dim setter = client.Update("asgm", newData)

        'MessageBox.Show("Your plant has been watered successfully!")
        Form2.Show()






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            client = New FireSharp.FirebaseClient(fireConn)
        Catch ex As Exception
            MessageBox.Show("There was a problem in the internet connection.")
        End Try

        Dim res = client.Get("asgm/")
        Dim newData As New iotReading()
        newData = res.ResultAs(Of iotReading)

        If newData.moisturelevel = "High" Then
            aBtn.Enabled = False
            hBtn.Enabled = True
            lBtn.Enabled = False
            btnWater.Enabled = False

        ElseIf newData.moisturelevel = "Average" Then
            hBtn.Enabled = False
            aBtn.Enabled = True
            lBtn.Enabled = False
            btnWater.Enabled = True

        ElseIf newData.moisturelevel = "Low" Then
            aBtn.Enabled = False
            hBtn.Enabled = False
            lBtn.Enabled = True
            btnWater.Enabled = True
        End If

        mLevel = newData.moisturelevel
    End Sub
End Class
