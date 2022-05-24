Public Class Options
    Public isTimeActive As Boolean
    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        If btnFacile.Checked Then
            Form1.nbCells = 8
        End If
        If btnMoyen.Checked Then
            Form1.nbCells = 14
        End If
        If btnDifficile.Checked Then
            Form1.nbCells = 20
        End If

        If (txtNbMines.Text <> "") AndAlso (IsNumeric(txtNbMines.Text) And CInt(txtNbMines.Text) < Form1.nbCells * Form1.nbCells And CInt(txtNbMines.Text) > 0) Then
            Jeu.nbMine = CInt(txtNbMines.Text)
        End If

        Select Case CBTheme.SelectedItem
            Case "Clair"
                Jeu.BackColor = Color.White
            Case "Sombre"
                Jeu.BackColor = Color.Black
                For Each Label As Control In Jeu.Controls
                    Label.ForeColor = Color.White
                Next
            Case "Bleu"
                Jeu.BackColor = Color.Blue
        End Select

        If (txtTime.Text <> "") AndAlso (IsNumeric(txtTime.Text) And CInt(txtTime.Text) > 0) Then
            Jeu.gameTime = CInt(txtTime.Text)
            Jeu.remainingGameTime = CInt(txtTime.Text)
        End If

        If btnPerso.Checked = True Then
            Form1.nbCells = HScrollBar1.Value
        End If

        If disabledTime.Checked = True Then
            isTimeActive = False
        Else
            isTimeActive = True
        End If
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBTheme.Items.Add("Clair")
        CBTheme.Items.Add("Sombre")
        CBTheme.Items.Add("Bleu")
    End Sub

    Private Sub btnResetScores_Click(sender As Object, e As EventArgs) Handles btnResetScores.Click
        If IO.File.ReadAllText(Form1.filename).Length = 0 Then
            MsgBox("Il n'y a déjà aucune donnée de sauvegarde.")
            Exit Sub
        End If
        If MsgBox("Souhaitez-vous vraiment écraser toutes les données ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            IO.File.WriteAllText(Form1.filename, "")
            resetAllInformations()
            MsgBox("Données supprimées avec succès.")
            Application.Restart()
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        LblGridSize.Text = HScrollBar1.Value & " x " & HScrollBar1.Value
    End Sub

    Private Sub btnPerso_CheckedChanged(sender As Object, e As EventArgs) Handles btnPerso.CheckedChanged
        HScrollBar1.Enabled = True
        LblGridSize.Visible = True
        If btnPerso.Checked = False Then
            HScrollBar1.Enabled = False
            LblGridSize.Visible = False
        End If
    End Sub

    Private Sub disabledTime_CheckedChanged(sender As Object, e As EventArgs) Handles disabledTime.CheckedChanged
        If disabledTime.Checked = True Then
            txtTime.Enabled = False
            If MsgBox("Attention ! En désactivant la limite de temps, votre score ne sera pas enregistré. Continuer ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                disabledTime.Checked = False
                txtTime.Enabled = True
            End If
        End If

        If disabledTime.Checked = False Then
            txtTime.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Les changements ne seront pas pris en compte. Quitter ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class