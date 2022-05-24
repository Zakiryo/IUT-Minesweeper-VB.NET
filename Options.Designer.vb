<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Difficulte = New System.Windows.Forms.Label()
        Me.BTN_Save = New System.Windows.Forms.Button()
        Me.btnFacile = New System.Windows.Forms.RadioButton()
        Me.btnMoyen = New System.Windows.Forms.RadioButton()
        Me.btnDifficile = New System.Windows.Forms.RadioButton()
        Me.btnPerso = New System.Windows.Forms.RadioButton()
        Me.LblNbMines = New System.Windows.Forms.Label()
        Me.txtNbMines = New System.Windows.Forms.TextBox()
        Me.LblTheme = New System.Windows.Forms.Label()
        Me.CBTheme = New System.Windows.Forms.ComboBox()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnResetScores = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.LblGridSize = New System.Windows.Forms.Label()
        Me.disabledTime = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options"
        '
        'Lbl_Difficulte
        '
        Me.Lbl_Difficulte.AutoSize = True
        Me.Lbl_Difficulte.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Difficulte.Location = New System.Drawing.Point(12, 58)
        Me.Lbl_Difficulte.Name = "Lbl_Difficulte"
        Me.Lbl_Difficulte.Size = New System.Drawing.Size(44, 16)
        Me.Lbl_Difficulte.TabIndex = 2
        Me.Lbl_Difficulte.Text = "Difficulté"
        '
        'BTN_Save
        '
        Me.BTN_Save.Location = New System.Drawing.Point(179, 128)
        Me.BTN_Save.Name = "BTN_Save"
        Me.BTN_Save.Size = New System.Drawing.Size(182, 39)
        Me.BTN_Save.TabIndex = 3
        Me.BTN_Save.Text = "Sauvegarder les paramètres"
        Me.BTN_Save.UseVisualStyleBackColor = True
        '
        'btnFacile
        '
        Me.btnFacile.AutoSize = True
        Me.btnFacile.Location = New System.Drawing.Point(15, 82)
        Me.btnFacile.Name = "btnFacile"
        Me.btnFacile.Size = New System.Drawing.Size(53, 17)
        Me.btnFacile.TabIndex = 4
        Me.btnFacile.TabStop = True
        Me.btnFacile.Text = "Facile"
        Me.btnFacile.UseVisualStyleBackColor = True
        '
        'btnMoyen
        '
        Me.btnMoyen.AutoSize = True
        Me.btnMoyen.Location = New System.Drawing.Point(15, 105)
        Me.btnMoyen.Name = "btnMoyen"
        Me.btnMoyen.Size = New System.Drawing.Size(57, 17)
        Me.btnMoyen.TabIndex = 5
        Me.btnMoyen.TabStop = True
        Me.btnMoyen.Text = "Moyen"
        Me.btnMoyen.UseVisualStyleBackColor = True
        '
        'btnDifficile
        '
        Me.btnDifficile.AutoSize = True
        Me.btnDifficile.Location = New System.Drawing.Point(15, 128)
        Me.btnDifficile.Name = "btnDifficile"
        Me.btnDifficile.Size = New System.Drawing.Size(59, 17)
        Me.btnDifficile.TabIndex = 6
        Me.btnDifficile.TabStop = True
        Me.btnDifficile.Text = "Difficile"
        Me.btnDifficile.UseVisualStyleBackColor = True
        '
        'btnPerso
        '
        Me.btnPerso.AutoSize = True
        Me.btnPerso.Location = New System.Drawing.Point(15, 151)
        Me.btnPerso.Name = "btnPerso"
        Me.btnPerso.Size = New System.Drawing.Size(85, 17)
        Me.btnPerso.TabIndex = 7
        Me.btnPerso.TabStop = True
        Me.btnPerso.Text = "Personnalisé"
        Me.btnPerso.UseVisualStyleBackColor = True
        '
        'LblNbMines
        '
        Me.LblNbMines.AutoSize = True
        Me.LblNbMines.Location = New System.Drawing.Point(167, 60)
        Me.LblNbMines.Name = "LblNbMines"
        Me.LblNbMines.Size = New System.Drawing.Size(89, 13)
        Me.LblNbMines.TabIndex = 8
        Me.LblNbMines.Text = "Nombre de mines"
        '
        'txtNbMines
        '
        Me.txtNbMines.Location = New System.Drawing.Point(262, 58)
        Me.txtNbMines.MaxLength = 2
        Me.txtNbMines.Name = "txtNbMines"
        Me.txtNbMines.Size = New System.Drawing.Size(40, 20)
        Me.txtNbMines.TabIndex = 9
        '
        'LblTheme
        '
        Me.LblTheme.AutoSize = True
        Me.LblTheme.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTheme.Location = New System.Drawing.Point(435, 57)
        Me.LblTheme.Name = "LblTheme"
        Me.LblTheme.Size = New System.Drawing.Size(40, 16)
        Me.LblTheme.TabIndex = 10
        Me.LblTheme.Text = "Thème"
        '
        'CBTheme
        '
        Me.CBTheme.FormattingEnabled = True
        Me.CBTheme.Location = New System.Drawing.Point(438, 82)
        Me.CBTheme.Name = "CBTheme"
        Me.CBTheme.Size = New System.Drawing.Size(113, 21)
        Me.CBTheme.TabIndex = 11
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(176, 90)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(80, 13)
        Me.LblTime.TabIndex = 12
        Me.LblTime.Text = "Limite de temps"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(262, 90)
        Me.txtTime.MaxLength = 3
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(40, 20)
        Me.txtTime.TabIndex = 13
        '
        'btnResetScores
        '
        Me.btnResetScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetScores.Location = New System.Drawing.Point(438, 116)
        Me.btnResetScores.Name = "btnResetScores"
        Me.btnResetScores.Size = New System.Drawing.Size(121, 41)
        Me.btnResetScores.TabIndex = 14
        Me.btnResetScores.Text = "Supprimer la sauvegarde"
        Me.btnResetScores.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Enabled = False
        Me.HScrollBar1.Location = New System.Drawing.Point(9, 241)
        Me.HScrollBar1.Maximum = 32
        Me.HScrollBar1.Minimum = 8
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(550, 35)
        Me.HScrollBar1.TabIndex = 15
        Me.HScrollBar1.Value = 32
        '
        'LblGridSize
        '
        Me.LblGridSize.AutoSize = True
        Me.LblGridSize.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGridSize.Location = New System.Drawing.Point(254, 212)
        Me.LblGridSize.Name = "LblGridSize"
        Me.LblGridSize.Size = New System.Drawing.Size(72, 29)
        Me.LblGridSize.TabIndex = 17
        Me.LblGridSize.Text = "23 x 23"
        Me.LblGridSize.Visible = False
        '
        'disabledTime
        '
        Me.disabledTime.AutoSize = True
        Me.disabledTime.Location = New System.Drawing.Point(308, 92)
        Me.disabledTime.Name = "disabledTime"
        Me.disabledTime.Size = New System.Drawing.Size(119, 17)
        Me.disabledTime.TabIndex = 18
        Me.disabledTime.Text = "Désactiver le temps"
        Me.disabledTime.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 36)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Annuler et quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(563, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.disabledTime)
        Me.Controls.Add(Me.LblGridSize)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.btnResetScores)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.CBTheme)
        Me.Controls.Add(Me.LblTheme)
        Me.Controls.Add(Me.txtNbMines)
        Me.Controls.Add(Me.LblNbMines)
        Me.Controls.Add(Me.btnPerso)
        Me.Controls.Add(Me.btnDifficile)
        Me.Controls.Add(Me.btnMoyen)
        Me.Controls.Add(Me.btnFacile)
        Me.Controls.Add(Me.BTN_Save)
        Me.Controls.Add(Me.Lbl_Difficulte)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options"
        Me.Text = "Minesweeper - Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_Difficulte As Label
    Friend WithEvents BTN_Save As Button
    Friend WithEvents btnFacile As RadioButton
    Friend WithEvents btnMoyen As RadioButton
    Friend WithEvents btnDifficile As RadioButton
    Friend WithEvents btnPerso As RadioButton
    Friend WithEvents LblNbMines As Label
    Friend WithEvents txtNbMines As TextBox
    Friend WithEvents LblTheme As Label
    Friend WithEvents CBTheme As ComboBox
    Friend WithEvents LblTime As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnResetScores As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents LblGridSize As Label
    Friend WithEvents disabledTime As CheckBox
    Friend WithEvents Button1 As Button
End Class
