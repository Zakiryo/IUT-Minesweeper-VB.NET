Public Class ScoreBoard
    Dim reader As System.IO.StreamReader
    Dim Spliter() As String
    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reader = My.Computer.FileSystem.OpenTextFileReader(Form1.filename)
        While Not reader.EndOfStream
            Spliter = reader.ReadLine().Split(",")
            PlayersNames.Items.Add(Spliter(0))
            PlayersDiscoverCases.Items.Add(Spliter(1) & " cases")
            PlayersTime.Items.Add(Spliter(2) & " secondes")
            CB_PlayersNames.Items.Add(Spliter(0))
        End While
        reader.Close()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnAfficherDetails_Click(sender As Object, e As EventArgs) Handles btnAfficherDetails.Click
        reader = My.Computer.FileSystem.OpenTextFileReader(Form1.filename)
        While Not reader.EndOfStream
            Spliter = reader.ReadLine().Split(",")
            If Spliter(0) = CB_PlayersNames.SelectedItem Then
                MsgBox("Nom : " & Spliter(0) & vbCrLf &
                       "Meilleur nombre de cases révélées : " & Spliter(1) & vbCrLf &
                       "Meilleur temps de partie : " & Spliter(2) & " secondes" & vbCrLf &
                       "Nombre de partie(s) jouée(s) : " & Spliter(3) & vbCrLf &
                       "Temps de jeu cumulé : " & Spliter(4) & " secondes")
            End If
        End While
        reader.Close()
    End Sub

    Private Sub btnChangeSave_Click(sender As Object, e As EventArgs) Handles btnChangeSave.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Title = "Charger un fichier de sauvegarde..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "Fichier de sauvegarde|*.txt*"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = Nothing Then
            Exit Sub
        End If
        Form1.filename = OpenFileDialog1.FileName
        If isCorrectFile() = True Then
            Me.Controls.Clear()
            InitializeComponent()
            ScoreBoard_Load(e, e)
            Refresh()
            Exit Sub
        Else
            Form1.filename = "PlayersInfo.txt"
            MsgBox("Désolé le fichier n'a pas le bon format. Il doit être au format :" & vbCrLf & "'Chaîne de caractères,Nombre,Nombre,Nombre,Nombre'.")
            Exit Sub
        End If
        Form1.filename = OpenFileDialog1.FileName
    End Sub

    Private Function isCorrectFile() As Boolean
        reader = My.Computer.FileSystem.OpenTextFileReader(Form1.filename)
        While Not reader.EndOfStream
            If Not reader.ReadLine().Contains(",") Then
                Return False
                Exit Function
            End If
            Spliter = reader.ReadLine().Split(",")
            If Not IsNumeric(Spliter(0)) And IsNumeric(Spliter(1)) And IsNumeric(Spliter(2)) And IsNumeric(Spliter(3)) And IsNumeric(Spliter(4)) Then
                Return True
            End If
        End While
        Return True
    End Function
End Class
