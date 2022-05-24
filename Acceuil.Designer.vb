<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CB_NomJoueurs = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_NewGame = New System.Windows.Forms.Button()
        Me.BTN_LeaveGame = New System.Windows.Forms.Button()
        Me.BTN_Scoreboard = New System.Windows.Forms.Button()
        Me.Lbl_Tutorial = New System.Windows.Forms.Label()
        Me.BTN_Options = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_NomJoueurs
        '
        Me.CB_NomJoueurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_NomJoueurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_NomJoueurs.DropDownWidth = 223
        Me.CB_NomJoueurs.FormattingEnabled = True
        Me.CB_NomJoueurs.IntegralHeight = False
        Me.CB_NomJoueurs.Location = New System.Drawing.Point(141, 197)
        Me.CB_NomJoueurs.MaxLength = 15
        Me.CB_NomJoueurs.Name = "CB_NomJoueurs"
        Me.CB_NomJoueurs.Size = New System.Drawing.Size(219, 21)
        Me.CB_NomJoueurs.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 141)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BTN_NewGame
        '
        Me.BTN_NewGame.Location = New System.Drawing.Point(141, 236)
        Me.BTN_NewGame.Name = "BTN_NewGame"
        Me.BTN_NewGame.Size = New System.Drawing.Size(219, 43)
        Me.BTN_NewGame.TabIndex = 2
        Me.BTN_NewGame.Text = "Lancer une partie"
        Me.BTN_NewGame.UseVisualStyleBackColor = True
        '
        'BTN_LeaveGame
        '
        Me.BTN_LeaveGame.Location = New System.Drawing.Point(341, 298)
        Me.BTN_LeaveGame.Name = "BTN_LeaveGame"
        Me.BTN_LeaveGame.Size = New System.Drawing.Size(170, 36)
        Me.BTN_LeaveGame.TabIndex = 3
        Me.BTN_LeaveGame.Text = "Quitter le jeu"
        Me.BTN_LeaveGame.UseVisualStyleBackColor = True
        '
        'BTN_Scoreboard
        '
        Me.BTN_Scoreboard.Location = New System.Drawing.Point(12, 298)
        Me.BTN_Scoreboard.Name = "BTN_Scoreboard"
        Me.BTN_Scoreboard.Size = New System.Drawing.Size(170, 36)
        Me.BTN_Scoreboard.TabIndex = 4
        Me.BTN_Scoreboard.Text = "Afficher le tableau des scores"
        Me.BTN_Scoreboard.UseVisualStyleBackColor = True
        '
        'Lbl_Tutorial
        '
        Me.Lbl_Tutorial.AutoSize = True
        Me.Lbl_Tutorial.Location = New System.Drawing.Point(84, 169)
        Me.Lbl_Tutorial.Name = "Lbl_Tutorial"
        Me.Lbl_Tutorial.Size = New System.Drawing.Size(355, 13)
        Me.Lbl_Tutorial.TabIndex = 5
        Me.Lbl_Tutorial.Text = "Merci de jouer au démineur. Entrez vos initiales avant de lancer une partie"
        '
        'BTN_Options
        '
        Me.BTN_Options.Location = New System.Drawing.Point(188, 298)
        Me.BTN_Options.Name = "BTN_Options"
        Me.BTN_Options.Size = New System.Drawing.Size(147, 36)
        Me.BTN_Options.TabIndex = 6
        Me.BTN_Options.Text = "Options de jeu"
        Me.BTN_Options.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(523, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_Options)
        Me.Controls.Add(Me.Lbl_Tutorial)
        Me.Controls.Add(Me.BTN_Scoreboard)
        Me.Controls.Add(Me.BTN_LeaveGame)
        Me.Controls.Add(Me.BTN_NewGame)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CB_NomJoueurs)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Minesweeper - Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_NomJoueurs As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_NewGame As Button
    Friend WithEvents BTN_LeaveGame As Button
    Friend WithEvents BTN_Scoreboard As Button
    Friend WithEvents Lbl_Tutorial As Label
    Friend WithEvents BTN_Options As Button
End Class
