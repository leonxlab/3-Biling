Public Class SplashScreen
    Private fadeState As String = "in"
    Private waitCounter As Integer = 0

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        FadeTimer.Start()
    End Sub

    Private Sub FadeTimer_Tick(sender As Object, e As EventArgs) Handles FadeTimer.Tick
        If fadeState = "in" Then
            If Me.Opacity < 1 Then
                Me.Opacity += 0.05
            Else
                fadeState = "wait"
            End If
        ElseIf fadeState = "wait" Then
            waitCounter += 1
            If waitCounter >= 40 Then ' sekitar 2 detik
                fadeState = "out"
            End If
        ElseIf fadeState = "out" Then
            If Me.Opacity > 0 Then
                Me.Opacity -= 0.05
            Else
                FadeTimer.Stop()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub
End Class
