Module SaveControls
    Private PlayersInfo As System.IO.StreamWriter
    Private lines() As String = IO.File.ReadAllLines(Form1.filename)
    Private Name As String = Form1.CB_NomJoueurs.Text
    Private nbDiscoveredCases As Integer = 0
    Private partyTime As Integer
    Private nbGamePlayed As Integer
    Private totalGameTime As Integer

    Public Sub setNbDiscoveredCases(nb As Integer)
        nbDiscoveredCases = nb
    End Sub

    Public Sub resetNbDiscoveredCases()
        nbDiscoveredCases = 0
    End Sub

    Public Sub resetAllInformations()
        nbDiscoveredCases = 0
        partyTime = 0
        nbGamePlayed = 0
        totalGameTime = 0
    End Sub

    Public Sub setPartyTime(pTime As Integer)
        partyTime = pTime
    End Sub

    Public Function getPartyTime() As Integer
        Return partyTime
    End Function

    Public Function getNbDiscoveredCases() As Integer
        Return nbDiscoveredCases
    End Function

    Public Sub savePlayerInformations()
        nbDiscoveredCases += 1
        For i As Integer = 0 To lines.Length - 1 'Vérification de l'existence du joueur dans la sauvegarde
            If lines(i).Contains(Name) Then
                Dim Spliter() As String = lines(i).Split(",")
                nbGamePlayed = Spliter(3) + 1
                totalGameTime = Spliter(4) + partyTime
                If nbDiscoveredCases > Spliter(2) Then
                    lines(i) = Spliter(0) & "," & nbDiscoveredCases & "," & partyTime & "," & nbGamePlayed & "," & totalGameTime
                Else
                    lines(i) = Spliter(0) & "," & Spliter(1) & "," & Spliter(2) & "," & nbGamePlayed & "," & totalGameTime
                End If
                IO.File.WriteAllLines(Form1.filename, lines)
                Exit Sub
            End If
        Next

        PlayersInfo = My.Computer.FileSystem.OpenTextFileWriter(Form1.filename, True) 'Sauvegarde des infos du nouveau joueur
        PlayersInfo.WriteLine(Name & "," & nbDiscoveredCases & "," & partyTime & "," & nbGamePlayed + 1 & "," & totalGameTime + partyTime)
        PlayersInfo.Close()
    End Sub
End Module
