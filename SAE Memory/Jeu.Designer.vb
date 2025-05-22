<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
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
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblPseudo = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTempsValeur = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValeur = New System.Windows.Forms.Label()
        Me.GroupBoxPlateau = New System.Windows.Forms.GroupBox()
        Me.Label05 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label04 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label08 = New System.Windows.Forms.Label()
        Me.Label07 = New System.Windows.Forms.Label()
        Me.Label06 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label09 = New System.Windows.Forms.Label()
        Me.Label03 = New System.Windows.Forms.Label()
        Me.Label02 = New System.Windows.Forms.Label()
        Me.Label01 = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.GroupBoxPlateau.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = True
        Me.lblJoueur.Location = New System.Drawing.Point(32, 27)
        Me.lblJoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(48, 16)
        Me.lblJoueur.TabIndex = 0
        Me.lblJoueur.Text = "Joueur"
        '
        'lblPseudo
        '
        Me.lblPseudo.AutoSize = True
        Me.lblPseudo.Location = New System.Drawing.Point(104, 27)
        Me.lblPseudo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPseudo.Name = "lblPseudo"
        Me.lblPseudo.Size = New System.Drawing.Size(73, 16)
        Me.lblPseudo.TabIndex = 1
        Me.lblPseudo.Text = "Nomjoueur"
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Location = New System.Drawing.Point(208, 27)
        Me.lblTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(99, 16)
        Me.lblTemps.TabIndex = 2
        Me.lblTemps.Text = "Temps restant :"
        '
        'btnAbandon
        '
        Me.btnAbandon.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAbandon.Location = New System.Drawing.Point(489, 17)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(147, 36)
        Me.btnAbandon.TabIndex = 4
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'lblTempsValeur
        '
        Me.lblTempsValeur.AutoSize = True
        Me.lblTempsValeur.Location = New System.Drawing.Point(327, 27)
        Me.lblTempsValeur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTempsValeur.Name = "lblTempsValeur"
        Me.lblTempsValeur.Size = New System.Drawing.Size(14, 16)
        Me.lblTempsValeur.TabIndex = 3
        Me.lblTempsValeur.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(381, 27)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(43, 16)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score"
        '
        'lblScoreValeur
        '
        Me.lblScoreValeur.AutoSize = True
        Me.lblScoreValeur.Location = New System.Drawing.Point(455, 27)
        Me.lblScoreValeur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScoreValeur.Name = "lblScoreValeur"
        Me.lblScoreValeur.Size = New System.Drawing.Size(14, 16)
        Me.lblScoreValeur.TabIndex = 12
        Me.lblScoreValeur.Text = "0"
        '
        'GroupBoxPlateau
        '
        Me.GroupBoxPlateau.Controls.Add(Me.Label05)
        Me.GroupBoxPlateau.Controls.Add(Me.Label18)
        Me.GroupBoxPlateau.Controls.Add(Me.Label04)
        Me.GroupBoxPlateau.Controls.Add(Me.Label17)
        Me.GroupBoxPlateau.Controls.Add(Me.Label16)
        Me.GroupBoxPlateau.Controls.Add(Me.Label20)
        Me.GroupBoxPlateau.Controls.Add(Me.Label19)
        Me.GroupBoxPlateau.Controls.Add(Me.Label13)
        Me.GroupBoxPlateau.Controls.Add(Me.Label12)
        Me.GroupBoxPlateau.Controls.Add(Me.Label11)
        Me.GroupBoxPlateau.Controls.Add(Me.Label15)
        Me.GroupBoxPlateau.Controls.Add(Me.Label14)
        Me.GroupBoxPlateau.Controls.Add(Me.Label08)
        Me.GroupBoxPlateau.Controls.Add(Me.Label07)
        Me.GroupBoxPlateau.Controls.Add(Me.Label06)
        Me.GroupBoxPlateau.Controls.Add(Me.Label10)
        Me.GroupBoxPlateau.Controls.Add(Me.Label09)
        Me.GroupBoxPlateau.Controls.Add(Me.Label03)
        Me.GroupBoxPlateau.Controls.Add(Me.Label02)
        Me.GroupBoxPlateau.Controls.Add(Me.Label01)
        Me.GroupBoxPlateau.Location = New System.Drawing.Point(1, 60)
        Me.GroupBoxPlateau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxPlateau.Name = "GroupBoxPlateau"
        Me.GroupBoxPlateau.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxPlateau.Size = New System.Drawing.Size(792, 869)
        Me.GroupBoxPlateau.TabIndex = 13
        Me.GroupBoxPlateau.TabStop = False
        '
        'Label05
        '
        Me.Label05.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label05.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label05.Location = New System.Drawing.Point(641, 21)
        Me.Label05.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label05.Name = "Label05"
        Me.Label05.Size = New System.Drawing.Size(139, 193)
        Me.Label05.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label18.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label18.Location = New System.Drawing.Point(325, 655)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 193)
        Me.Label18.TabIndex = 37
        '
        'Label04
        '
        Me.Label04.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label04.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label04.Location = New System.Drawing.Point(484, 21)
        Me.Label04.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label04.Name = "Label04"
        Me.Label04.Size = New System.Drawing.Size(139, 193)
        Me.Label04.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label17.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label17.Location = New System.Drawing.Point(171, 655)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(139, 193)
        Me.Label17.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label16.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Location = New System.Drawing.Point(12, 655)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 193)
        Me.Label16.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label20.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label20.Location = New System.Drawing.Point(641, 655)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(139, 193)
        Me.Label20.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label19.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label19.Location = New System.Drawing.Point(484, 655)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(139, 193)
        Me.Label19.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label13.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label13.Location = New System.Drawing.Point(325, 441)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 193)
        Me.Label13.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label12.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label12.Location = New System.Drawing.Point(171, 441)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 193)
        Me.Label12.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label11.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label11.Location = New System.Drawing.Point(12, 441)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 193)
        Me.Label11.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label15.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label15.Location = New System.Drawing.Point(641, 441)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 193)
        Me.Label15.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label14.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Location = New System.Drawing.Point(484, 441)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 193)
        Me.Label14.TabIndex = 33
        '
        'Label08
        '
        Me.Label08.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label08.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label08.Location = New System.Drawing.Point(325, 230)
        Me.Label08.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label08.Name = "Label08"
        Me.Label08.Size = New System.Drawing.Size(139, 193)
        Me.Label08.TabIndex = 27
        '
        'Label07
        '
        Me.Label07.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label07.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label07.Location = New System.Drawing.Point(171, 230)
        Me.Label07.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label07.Name = "Label07"
        Me.Label07.Size = New System.Drawing.Size(139, 193)
        Me.Label07.TabIndex = 26
        '
        'Label06
        '
        Me.Label06.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label06.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label06.Location = New System.Drawing.Point(12, 230)
        Me.Label06.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label06.Name = "Label06"
        Me.Label06.Size = New System.Drawing.Size(139, 193)
        Me.Label06.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Location = New System.Drawing.Point(641, 230)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 193)
        Me.Label10.TabIndex = 29
        '
        'Label09
        '
        Me.Label09.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label09.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label09.Location = New System.Drawing.Point(484, 230)
        Me.Label09.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label09.Name = "Label09"
        Me.Label09.Size = New System.Drawing.Size(139, 193)
        Me.Label09.TabIndex = 28
        '
        'Label03
        '
        Me.Label03.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label03.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label03.Location = New System.Drawing.Point(329, 21)
        Me.Label03.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label03.Name = "Label03"
        Me.Label03.Size = New System.Drawing.Size(139, 193)
        Me.Label03.TabIndex = 22
        '
        'Label02
        '
        Me.Label02.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label02.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label02.Location = New System.Drawing.Point(175, 21)
        Me.Label02.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label02.Name = "Label02"
        Me.Label02.Size = New System.Drawing.Size(139, 193)
        Me.Label02.TabIndex = 21
        '
        'Label01
        '
        Me.Label01.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label01.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label01.Location = New System.Drawing.Point(16, 21)
        Me.Label01.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label01.Name = "Label01"
        Me.Label01.Size = New System.Drawing.Size(139, 193)
        Me.Label01.TabIndex = 20
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPause.Location = New System.Drawing.Point(647, 17)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(147, 36)
        Me.btnPause.TabIndex = 14
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 950)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.GroupBoxPlateau)
        Me.Controls.Add(Me.lblScoreValeur)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.lblTempsValeur)
        Me.Controls.Add(Me.lblTemps)
        Me.Controls.Add(Me.lblPseudo)
        Me.Controls.Add(Me.lblJoueur)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormJeu"
        Me.Tag = ""
        Me.Text = "Memory"
        Me.GroupBoxPlateau.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblPseudo As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents lblTempsValeur As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreValeur As Label
    Friend WithEvents GroupBoxPlateau As GroupBox
    Friend WithEvents Label05 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label04 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label08 As Label
    Friend WithEvents Label07 As Label
    Friend WithEvents Label06 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label09 As Label
    Friend WithEvents Label03 As Label
    Friend WithEvents Label02 As Label
    Friend WithEvents Label01 As Label
    Friend WithEvents btnPause As Button
End Class
