<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.Lbl_Timer = New System.Windows.Forms.Label()
        Me.Lbl_PlayerName = New System.Windows.Forms.Label()
        Me.BTN_Abandon = New System.Windows.Forms.Button()
        Me.Game_Time = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblNbMines = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.LblIsPause = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Timer
        '
        Me.Lbl_Timer.AutoSize = True
        Me.Lbl_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Timer.Location = New System.Drawing.Point(14, 15)
        Me.Lbl_Timer.Name = "Lbl_Timer"
        Me.Lbl_Timer.Size = New System.Drawing.Size(71, 33)
        Me.Lbl_Timer.TabIndex = 64
        Me.Lbl_Timer.Text = "time"
        Me.Lbl_Timer.Visible = False
        '
        'Lbl_PlayerName
        '
        Me.Lbl_PlayerName.AutoSize = True
        Me.Lbl_PlayerName.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayerName.Location = New System.Drawing.Point(265, 15)
        Me.Lbl_PlayerName.Name = "Lbl_PlayerName"
        Me.Lbl_PlayerName.Size = New System.Drawing.Size(65, 33)
        Me.Lbl_PlayerName.TabIndex = 65
        Me.Lbl_PlayerName.Text = "name"
        '
        'BTN_Abandon
        '
        Me.BTN_Abandon.BackColor = System.Drawing.SystemColors.Menu
        Me.BTN_Abandon.Location = New System.Drawing.Point(327, 525)
        Me.BTN_Abandon.Name = "BTN_Abandon"
        Me.BTN_Abandon.Size = New System.Drawing.Size(138, 30)
        Me.BTN_Abandon.TabIndex = 66
        Me.BTN_Abandon.Text = "Abandonner la partie"
        Me.BTN_Abandon.UseVisualStyleBackColor = False
        '
        'Game_Time
        '
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Panel1.TabIndex = 67
        '
        'LblNbMines
        '
        Me.LblNbMines.AutoSize = True
        Me.LblNbMines.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNbMines.Location = New System.Drawing.Point(12, 513)
        Me.LblNbMines.Name = "LblNbMines"
        Me.LblNbMines.Size = New System.Drawing.Size(92, 45)
        Me.LblNbMines.TabIndex = 68
        Me.LblNbMines.Text = "mines"
        '
        'btnPause
        '
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(215, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(44, 35)
        Me.btnPause.TabIndex = 69
        Me.btnPause.Text = "II"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'LblIsPause
        '
        Me.LblIsPause.AutoSize = True
        Me.LblIsPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIsPause.Location = New System.Drawing.Point(111, 21)
        Me.LblIsPause.Name = "LblIsPause"
        Me.LblIsPause.Size = New System.Drawing.Size(98, 20)
        Me.LblIsPause.TabIndex = 70
        Me.LblIsPause.Text = "[EN PAUSE]"
        Me.LblIsPause.Visible = False
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(477, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblIsPause)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.LblNbMines)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_Abandon)
        Me.Controls.Add(Me.Lbl_PlayerName)
        Me.Controls.Add(Me.Lbl_Timer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Jeu"
        Me.Text = "Minesweeper - Partie en cours"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Timer As Label
    Friend WithEvents Lbl_PlayerName As Label
    Friend WithEvents BTN_Abandon As Button
    Friend WithEvents Game_Time As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblNbMines As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents LblIsPause As Label
End Class
