Public Class Form3

    Dim player3 As New WMPLib.WindowsMediaPlayer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player3.controls.stop()
        player1.controls.play()
        Form1.Show()
        Me.Close()
        Form1.ProgressBar1.Value = Form1.ProgressBar1.Maximum
        Form1.ProgressBar2.Value = Form1.ProgressBar2.Minimum
        Form1.Timer3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        player3.close()
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player3.URL = My.Application.Info.DirectoryPath & "\[MapleStory BGM] Nautilus.mp3"
        player3.settings.setMode("loop", True)


    End Sub
End Class