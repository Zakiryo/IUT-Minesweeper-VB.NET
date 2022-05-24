Public Class Form1
    Dim reader As System.IO.StreamReader
    Public filename As String = "PlayersInfo.txt"
    Public nbCells As Integer = 8
    Private Sub BTN_NewGame_Click(sender As Object, e As EventArgs) Handles BTN_NewGame.Click
        If CB_NomJoueurs.Text.Length < 3 Then
            MsgBox("Merci d'entrer un nom d'au moins 3 lettres.")
            Exit Sub
        End If
        If CB_NomJoueurs.Text.Contains(",") Then
            MsgBox("Pour le bien du système de sauvegarde, merci de ne pas utiliser un nom contenant de virgule.")
            Exit Sub
        End If
        Me.Hide()
        Jeu.Show()
    End Sub

    Private Sub BTN_LeaveGame_Click(sender As Object, e As EventArgs) Handles BTN_LeaveGame.Click
        If MsgBox("Voulez-vous vraiment quitter le jeu ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        reader = My.Computer.FileSystem.OpenTextFileReader(filename)
        While Not reader.EndOfStream
            Dim Spliter = reader.ReadLine().Split(",")
            CB_NomJoueurs.Items.Add(Spliter(0))
        End While
        reader.Close()
        If Options.disabledTime.Checked = False Then
            Options.isTimeActive = True
        End If
    End Sub

    Private Sub BTN_Options_Click(sender As Object, e As EventArgs) Handles BTN_Options.Click
        Me.Hide()
        Options.Show()
    End Sub

    Private Sub BTN_Scoreboard_Click(sender As Object, e As EventArgs) Handles BTN_Scoreboard.Click
        Me.Hide()
        ScoreBoard.Show()
    End Sub
End Class
