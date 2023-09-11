'Joshua Makuch
'RCET 3371
'Fall 2023
'Cool Clock
'https://github.com/JoshuaMakuch/S5-CoolClock

Imports System.Configuration
Imports System.Security.AccessControl

Public Class CoolClockForm

    Dim distanceTraveled As Double
    Dim clocks As Double

    'When the user presses the quit button
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    'Every Time the timer clock timer ticks it updates the displayed time to the user's system clock is
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockLabel.Text = TimeOfDay
        Datelabel.Text = DateString
        distanceTraveled = Math.Round((distanceTraveled + 299.792458), 3)
        clocks = clocks + 5000000
        LightspeedLabel.Text = "Distance Light Has Traveled (km) : " & CStr(distanceTraveled)
        ClockSpeedLabel.Text = "How Many Clock Cycles Have Passed Of A 5GHz Clock (Millions): " & CStr(clocks / 1000000)
        ReachedLabel.Text = "Light Has traveled: " & Math.Round((distanceTraveled / 40000), 1) & " Circumferences Of Earth"
    End Sub

End Class


