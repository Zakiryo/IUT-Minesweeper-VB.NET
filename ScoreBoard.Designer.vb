<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScoreBoard
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreBoard))
        Me.PlayersNames = New System.Windows.Forms.ListBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.CB_PlayersNames = New System.Windows.Forms.ComboBox()
        Me.btnAfficherDetails = New System.Windows.Forms.Button()
        Me.PlayersDiscoverCases = New System.Windows.Forms.ListBox()
        Me.PlayersTime = New System.Windows.Forms.ListBox()
        Me.lblPlayerNames = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChangeSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayersNames
        '
        Me.PlayersNames.FormattingEnabled = True
        Me.PlayersNames.Location = New System.Drawing.Point(12, 38)
        Me.PlayersNames.Name = "PlayersNames"
        Me.PlayersNames.Size = New System.Drawing.Size(108, 251)
        Me.PlayersNames.TabIndex = 0
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(369, 252)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(121, 34)
        Me.btnRetour.TabIndex = 3
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'CB_PlayersNames
        '
        Me.CB_PlayersNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_PlayersNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_PlayersNames.FormattingEnabled = True
        Me.CB_PlayersNames.Location = New System.Drawing.Point(369, 33)
        Me.CB_PlayersNames.Name = "CB_PlayersNames"
        Me.CB_PlayersNames.Size = New System.Drawing.Size(121, 21)
        Me.CB_PlayersNames.TabIndex = 4
        '
        'btnAfficherDetails
        '
        Me.btnAfficherDetails.Location = New System.Drawing.Point(369, 60)
        Me.btnAfficherDetails.Name = "btnAfficherDetails"
        Me.btnAfficherDetails.Size = New System.Drawing.Size(121, 24)
        Me.btnAfficherDetails.TabIndex = 5
        Me.btnAfficherDetails.Text = "Détails des scores"
        Me.btnAfficherDetails.UseVisualStyleBackColor = True
        '
        'PlayersDiscoverCases
        '
        Me.PlayersDiscoverCases.FormattingEnabled = True
        Me.PlayersDiscoverCases.Location = New System.Drawing.Point(126, 38)
        Me.PlayersDiscoverCases.Name = "PlayersDiscoverCases"
        Me.PlayersDiscoverCases.Size = New System.Drawing.Size(108, 251)
        Me.PlayersDiscoverCases.TabIndex = 7
        '
        'PlayersTime
        '
        Me.PlayersTime.FormattingEnabled = True
        Me.PlayersTime.Location = New System.Drawing.Point(240, 38)
        Me.PlayersTime.Name = "PlayersTime"
        Me.PlayersTime.Size = New System.Drawing.Size(108, 251)
        Me.PlayersTime.TabIndex = 8
        '
        'lblPlayerNames
        '
        Me.lblPlayerNames.AutoSize = True
        Me.lblPlayerNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerNames.Location = New System.Drawing.Point(12, 19)
        Me.lblPlayerNames.Name = "lblPlayerNames"
        Me.lblPlayerNames.Size = New System.Drawing.Size(46, 13)
        Me.lblPlayerNames.TabIndex = 9
        Me.lblPlayerNames.Text = "Noms :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Temps :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Meilleur score :"
        '
        'btnChangeSave
        '
        Me.btnChangeSave.Location = New System.Drawing.Point(369, 150)
        Me.btnChangeSave.Name = "btnChangeSave"
        Me.btnChangeSave.Size = New System.Drawing.Size(121, 36)
        Me.btnChangeSave.TabIndex = 12
        Me.btnChangeSave.Text = "Charger un fichier de sauvegarde"
        Me.btnChangeSave.UseVisualStyleBackColor = True
        '
        'ScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(510, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnChangeSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPlayerNames)
        Me.Controls.Add(Me.PlayersTime)
        Me.Controls.Add(Me.PlayersDiscoverCases)
        Me.Controls.Add(Me.btnAfficherDetails)
        Me.Controls.Add(Me.CB_PlayersNames)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.PlayersNames)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ScoreBoard"
        Me.Text = "Minesweeper - Tableau des scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayersNames As ListBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents CB_PlayersNames As ComboBox
    Friend WithEvents btnAfficherDetails As Button
    Friend WithEvents PlayersDiscoverCases As ListBox
    Friend WithEvents PlayersTime As ListBox
    Friend WithEvents lblPlayerNames As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChangeSave As Button
End Class
