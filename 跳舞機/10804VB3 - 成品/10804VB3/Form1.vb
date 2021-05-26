Imports System.Runtime.Remoting.Services

Public Class Form1
    Dim index As Integer
    Dim undex As Integer
    Dim caption As Integer
    Dim D As Integer
    Dim G As Integer
    Dim replay As Integer
    Dim RE As Integer




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '按開始圖片輪轉

        Timer1.Enabled = True
        Timer3.Enabled = True
        ProgressBar1.Value = ProgressBar1.Maximum

        Button1.Enabled = False
        Button2.Enabled = False
        Button1.Visible = False
        Button2.Visible = False
        player1.URL = My.Application.Info.DirectoryPath & "\[MapleStory BGM] Ariant (online-audio-converter.com).mp3"
        player1.settings.setMode("loop", True)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        index = Int(0 + Rnd() * (3 - 0 + 1))

        Do
            Randomize()
            index = Int(0 + Rnd() * (3 - 0 + 1))


        Loop While RE = index
        RE = index
        Timer1.Enabled = False
        PictureBox1.Image = ImageList2.Images(index)


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '遊戲說明
        caption = MsgBox("操控方向鍵，讓人物動起來!在限時之內將能量條集滿即獲勝", 64 + 0, "遊戲說明")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If ProgressBar1.Value >= ProgressBar1.Minimum + 1 Then
            ProgressBar1.Value -= 1
        Else
            ProgressBar1.Value = ProgressBar1.Minimum
            Timer3.Enabled = False
            player1.controls.stop()

            Form4.Show()
            Me.Hide()


        End If

        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Timer3.Enabled = False
            player1.controls.stop()
            Form3.Show()
            Me.Hide()
        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Left Then
            D = 1
            undex = 0
            PictureBox2.Image = ImageList1.Images(undex)
        End If
        If e.KeyCode = Keys.Right Then
            D = 2
            undex = 1
            PictureBox2.Image = ImageList1.Images(undex)
        End If
        If e.KeyCode = Keys.Up Then
            D = 3
            undex = 2
            PictureBox2.Image = ImageList1.Images(undex)
        End If
        If e.KeyCode = Keys.Down Then
            D = 4
            undex = 3
            PictureBox2.Image = ImageList1.Images(undex)
        End If

        If index = 0 Then
            If D = 3 Then

                If ProgressBar2.Value < ProgressBar2.Maximum - 4 Then
                    ProgressBar2.Value += 4
                Else
                    ProgressBar2.Value = ProgressBar2.Maximum
                End If



                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sh_pickup02 (1) (online-audio-converter.com).wav", AudioPlayMode.Background)
            Else

                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\cat_like1a (online-audio-converter.com).wav", AudioPlayMode.Background)
            End If
        End If
        If index = 1 Then
            If D = 4 Then


                If ProgressBar2.Value < ProgressBar2.Maximum - 4 Then
                    ProgressBar2.Value += 4
                Else
                    ProgressBar2.Value = ProgressBar2.Maximum
                End If


                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sh_pickup02 (1) (online-audio-converter.com).wav", AudioPlayMode.Background)
            Else

                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\cat_like1a (online-audio-converter.com).wav", AudioPlayMode.Background)
            End If

        End If
        If index = 2 Then
            If D = 1 Then


                If ProgressBar2.Value < ProgressBar2.Maximum - 4 Then
                    ProgressBar2.Value += 4
                Else
                    ProgressBar2.Value = ProgressBar2.Maximum
                End If


                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sh_pickup02 (1) (online-audio-converter.com).wav", AudioPlayMode.Background)
            Else

                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\cat_like1a (online-audio-converter.com).wav", AudioPlayMode.Background)
            End If
        End If
        If index = 3 Then
            If D = 2 Then


                If ProgressBar2.Value < ProgressBar2.Maximum - 4 Then
                    ProgressBar2.Value += 4
                Else
                    ProgressBar2.Value = ProgressBar2.Maximum
                End If


                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\sh_pickup02 (1) (online-audio-converter.com).wav", AudioPlayMode.Background)
            Else

                Timer1.Enabled = True
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\cat_like1a (online-audio-converter.com).wav", AudioPlayMode.Background)
            End If
        End If



    End Sub
End Class