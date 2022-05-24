Module GameControls
    Private cases(Form1.nbCells, Form1.nbCells) As Button
    Private nbClick As Integer = 0
    Private cellSize As Double = Jeu.Panel1.Height / Form1.nbCells
    Private gameStarted As Boolean = False

    Public Sub placeCellsAndMines(nbMines As Integer) 'Préparation de la grille de jeu et placement aléatoire des mines
        Dim a As Integer
        Dim b As Integer
        For y As Integer = 1 To Form1.nbCells
            For x As Integer = 1 To Form1.nbCells
                cases(x, y) = New Button()
                cases(x, y).Location = New Point(a, b)
                AddHandler cases(x, y).MouseDown, AddressOf clickOnCase
                cases(x, y).Height = cellSize
                cases(x, y).Width = cellSize
                cases(x, y).FlatStyle = FlatStyle.Flat
                cases(x, y).BackColor = Color.Blue
                cases(x, y).Tag = "Empty"
                Jeu.Panel1.Controls.Add(cases(x, y))
                a += cellSize
            Next
            a = 0
            b += cellSize
        Next
        For i As Integer = 1 To nbMines
            Dim coordX As Integer = CInt(Int((Form1.nbCells * Rnd()) + 1))
            Dim coordY As Integer = CInt(Int((Form1.nbCells * Rnd()) + 1))
            cases(coordX, coordY).Tag = "Mined"
        Next
    End Sub

    Private Function isMine(x As Integer, y As Integer) 'Vérifie si une case donnée contient une mine
        If cases(x, y).Tag = "Mined" Or cases(x, y).Tag = "MarkedMine" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function getNbAdjacentMines(cell As Button) 'Renvoi le nombre de mines avoisinant une case donnée
        Dim p As Point = cell.Location
        Dim px As Integer = p.X / cellSize + 1
        Dim py As Integer = p.Y / cellSize + 1
        Dim nbAdjaccentMines As Integer = 0
        For dx As Integer = -1 To 1
            For dy As Integer = -1 To 1
                Dim x As Integer = px + dx
                Dim y As Integer = py + dy
                If x > Form1.nbCells Or y > Form1.nbCells Or x < 1 Or y < 1 Then
                    Continue For
                End If
                If isMine(x, y) Then
                    nbAdjaccentMines += 1
                End If
            Next
        Next
        cell.Tag = "Discover"
        Return nbAdjaccentMines
    End Function

    Private Sub discoverAroundCases(cell As Button) 'Découvre toutes les cases avoisinantes une case donnée
        Dim p As Point = cell.Location
        Dim px As Integer = p.X / cellSize + 1
        Dim py As Integer = p.Y / cellSize + 1
        Dim nbAdjaccentMines As Integer = 0
        For dx As Integer = -1 To 1
            For dy As Integer = -1 To 1
                Dim x As Integer = px + dx
                Dim y As Integer = py + dy
                If x > Form1.nbCells Or y > Form1.nbCells Or x < 1 Or y < 1 Then
                    Continue For
                End If
                cases(x, y).Text = getNbAdjacentMines(cases(x, y))
                cases(x, y).BackColor = Color.SkyBlue
                cases(x, y).Tag = "Discover"
            Next
        Next
    End Sub

    Private Function getNbZeroInGrid() As Integer 'Retourne le nombre de cases vides révélées présentes sur la grille
        Dim nbZero As Integer = 0
        For Each Button As Control In Jeu.Panel1.Controls
            If Button.Text = "0" Then
                nbZero += 1
            End If
        Next
        Return nbZero
    End Function

    Private Function getNbMaskedCases() As Integer 'Retourne le nombre de cases masquées présentes sur la grille
        Dim nbMaskedCases As Integer = 0
        For Each Button As Control In Jeu.Panel1.Controls
            If Button.Tag = "Empty" Then
                nbMaskedCases += 1
            End If
        Next
        Return nbMaskedCases
    End Function

    Private Function getNbDiscoveredCases() As Integer 'Retourne le nombre de cases révélées présentes sur la grille
        Dim nbDiscovredCases As Integer = 0
        For Each Button As Control In Jeu.Panel1.Controls
            If Button.Tag = "Discover" Then
                nbDiscovredCases += 1
            End If
        Next
        Return nbDiscovredCases
    End Function

    Private Sub MarkCase(cases As Button) 'Marque et démarque une case selon plusieurs scénarios
        Select Case cases.Tag
            Case "Discover"
                Exit Sub
            Case "Marked"
                cases.Tag = "Empty"
                cases.Text = ""
                cases.BackColor = Color.Blue
                Exit Sub
            Case "MarkedMine"
                cases.Tag = "Mined"
                cases.Text = ""
                cases.BackColor = Color.Blue
                Exit Sub
            Case "Mined"
                cases.Tag = "MarkedMine"
                cases.Text = "X"
                cases.BackColor = Color.BlueViolet
            Case "Empty"
                cases.Tag = "Marked"
                cases.Text = "X"
                cases.BackColor = Color.BlueViolet
        End Select
    End Sub

    Private Sub DiscoverCase(cases As Button)
        Select Case cases.Tag
            Case "Mined" 'Si le joueur perd la partie
                If Options.isTimeActive = True Then
                    Jeu.Game_Time.Stop()
                    setPartyTime(Jeu.gameTime - CInt(Jeu.Lbl_Timer.Text))
                    MsgBox("Vous avez perdu. Vous avez joué pendant " & getPartyTime() & " secondes et découvert " & getNbDiscoveredCases() & " cases.")
                    savePlayerInformations()
                    resetNbDiscoveredCases()
                    Application.Restart()
                    Exit Sub
                Else
                    MsgBox("Vous avez perdu et découvert " & getNbDiscoveredCases() & " cases.")
                    Application.Restart()
                    Exit Sub
                End If

            Case "Empty"
                setNbDiscoveredCases(getNbDiscoveredCases())
            Case "Marked"
                Exit Sub
            Case "MarkedMine"
                Exit Sub
        End Select

        cases.Text = getNbAdjacentMines(cases) 'Marquer la case avec le nombre de mines adjacentes

        If getNbAdjacentMines(cases) = 0 Then 'S'il n'y a pas de mines ajacentes, découvrir les cases autour
            discoverAroundCases(cases)
        End If
        cases.BackColor = Color.SkyBlue
        cases.Tag = "Discover"

        For i As Integer = 0 To getNbZeroInGrid() 'Découvrir les cases autour de toutes celles sur la grille n'ayant aucune mine adjacente
            For Each Button As Control In Jeu.Panel1.Controls
                If Button.Text = "0" Then
                    discoverAroundCases(Button)
                End If
            Next
        Next

        If getNbMaskedCases() = 0 Then 'Si le joueur gagne la partie
            If Options.isTimeActive = True Then 'Si le compteur de temps est activé
                Jeu.Game_Time.Stop()
                setPartyTime(Jeu.gameTime - CInt(Jeu.Lbl_Timer.Text))
                MsgBox("Vous avez gagné! Vous avez joué pendant " & getPartyTime() & " secondes et découvert " & getNbDiscoveredCases() & " cases.")
                savePlayerInformations()
                resetNbDiscoveredCases()
                Application.Restart()
            Else 'Si le joueur est en mode entraînement
                MsgBox("Vous avez gagné et découvert " & getNbDiscoveredCases() & " cases.")
                Application.Restart()
                Exit Sub
            End If

        End If

        For Each Button As Control In Jeu.Panel1.Controls 'Remplace tous les 0 par des cases vides
            If Button.Text = "0" Then
                Button.Text = " "
            End If
        Next
    End Sub

    Private Sub clickOnCase(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If Not gameStarted Then
            gameStarted = True
        End If

        If gameStarted And Not Jeu.Game_Time.Enabled Then
            If Options.isTimeActive = True Then
                Jeu.displayTimer(sender, e)
            End If
        End If

        If e.Button = MouseButtons.Left Then
            DiscoverCase(sender)
        End If

        If e.Button = MouseButtons.Right Then
            MarkCase(sender)
        End If
    End Sub
End Module
