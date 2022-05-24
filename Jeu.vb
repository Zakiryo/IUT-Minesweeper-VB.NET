Public Class Jeu
    Public gameTime As Integer = 60
    Public remainingGameTime As Integer = gameTime
    Public nbMine As Integer = 10
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_PlayerName.Text = Form1.CB_NomJoueurs.Text
        LblNbMines.Text = nbMine & " mines"
        If Options.isTimeActive = False Then
            Lbl_Timer.Text = "Training"
            Lbl_Timer.Visible = True
            btnPause.Enabled = False
        End If
        placeCellsAndMines(nbMine)
    End Sub

    Private Sub BTN_Abandon_Click(sender As Object, e As EventArgs) Handles BTN_Abandon.Click
        If MsgBox("Souhaitez-vous vraiment abandonner la partie ?" & vbCrLf & "Votre score ne sera pas pris en compte.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Public Sub displayTimer(sender As Object, e As EventArgs) Handles Game_Time.Tick
        Lbl_Timer.Visible = True
        remainingGameTime -= 1
        Lbl_Timer.Text = remainingGameTime
        If remainingGameTime = 0 Then
            Game_Time.Stop()
            MsgBox("Temps écoulé. Vous avez joué pendant " & getPartyTime() & " secondes et découvert " & getNbDiscoveredCases() & " cases.")
            setPartyTime(CInt(Lbl_Timer.Text))
            savePlayerInformations()
            resetNbDiscoveredCases()
            Application.Restart()
        End If
        Game_Time.Interval = 1000
        Game_Time.Start()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If Game_Time.Enabled = True Then
            Game_Time.Stop()
            Panel1.Enabled = False
            LblIsPause.Visible = True
            btnPause.Text = "▶"
        Else
            Game_Time.Start()
            Panel1.Enabled = True
            LblIsPause.Visible = False
            btnPause.Text = "II"
        End If
    End Sub

End Class
