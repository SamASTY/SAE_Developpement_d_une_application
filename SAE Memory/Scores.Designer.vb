<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScores
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
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRejouer = New System.Windows.Forms.Button()
        Me.lblRechercher = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.cmbJoueurValeur = New System.Windows.Forms.ComboBox()
        Me.btnTri = New System.Windows.Forms.Button()
        Me.lstTempsTotal = New System.Windows.Forms.ListBox()
        Me.lstNbParties = New System.Windows.Forms.ListBox()
        Me.lstTemps = New System.Windows.Forms.ListBox()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lstNoms = New System.Windows.Forms.ListBox()
        Me.lblNbParties = New System.Windows.Forms.Label()
        Me.lblTempsTotal = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblTableauScores = New System.Windows.Forms.Label()
        Me.lblMaxValeur = New System.Windows.Forms.Label()
        Me.lblMinValeur = New System.Windows.Forms.Label()
        Me.btnAffJoueur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(395, 457)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(147, 28)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRejouer
        '
        Me.btnRejouer.Location = New System.Drawing.Point(32, 457)
        Me.btnRejouer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(147, 28)
        Me.btnRejouer.TabIndex = 8
        Me.btnRejouer.Text = "Rejouer"
        Me.btnRejouer.UseVisualStyleBackColor = True
        '
        'lblRechercher
        '
        Me.lblRechercher.AutoSize = True
        Me.lblRechercher.Location = New System.Drawing.Point(39, 359)
        Me.lblRechercher.Name = "lblRechercher"
        Me.lblRechercher.Size = New System.Drawing.Size(77, 16)
        Me.lblRechercher.TabIndex = 36
        Me.lblRechercher.Text = "Rechercher"
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(391, 91)
        Me.btnFermer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(93, 30)
        Me.btnFermer.TabIndex = 35
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'cmbJoueurValeur
        '
        Me.cmbJoueurValeur.FormattingEnabled = True
        Me.cmbJoueurValeur.Location = New System.Drawing.Point(137, 359)
        Me.cmbJoueurValeur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbJoueurValeur.Name = "cmbJoueurValeur"
        Me.cmbJoueurValeur.Size = New System.Drawing.Size(67, 24)
        Me.cmbJoueurValeur.TabIndex = 34
        '
        'btnTri
        '
        Me.btnTri.Location = New System.Drawing.Point(257, 91)
        Me.btnTri.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTri.Name = "btnTri"
        Me.btnTri.Size = New System.Drawing.Size(95, 30)
        Me.btnTri.TabIndex = 33
        Me.btnTri.Text = "Tri"
        Me.btnTri.UseVisualStyleBackColor = True
        '
        'lstTempsTotal
        '
        Me.lstTempsTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lstTempsTotal.FormattingEnabled = True
        Me.lstTempsTotal.ItemHeight = 16
        Me.lstTempsTotal.Location = New System.Drawing.Point(376, 336)
        Me.lstTempsTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTempsTotal.Name = "lstTempsTotal"
        Me.lstTempsTotal.Size = New System.Drawing.Size(155, 68)
        Me.lstTempsTotal.TabIndex = 32
        '
        'lstNbParties
        '
        Me.lstNbParties.FormattingEnabled = True
        Me.lstNbParties.ItemHeight = 16
        Me.lstNbParties.Location = New System.Drawing.Point(376, 191)
        Me.lstNbParties.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNbParties.Name = "lstNbParties"
        Me.lstNbParties.Size = New System.Drawing.Size(119, 68)
        Me.lstNbParties.TabIndex = 31
        '
        'lstTemps
        '
        Me.lstTemps.FormattingEnabled = True
        Me.lstTemps.ItemHeight = 16
        Me.lstTemps.Location = New System.Drawing.Point(257, 191)
        Me.lstTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTemps.Name = "lstTemps"
        Me.lstTemps.Size = New System.Drawing.Size(107, 68)
        Me.lstTemps.TabIndex = 30
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 16
        Me.lstScores.Location = New System.Drawing.Point(123, 191)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(107, 68)
        Me.lstScores.TabIndex = 29
        '
        'lstNoms
        '
        Me.lstNoms.FormattingEnabled = True
        Me.lstNoms.ItemHeight = 16
        Me.lstNoms.Location = New System.Drawing.Point(11, 191)
        Me.lstNoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNoms.Name = "lstNoms"
        Me.lstNoms.Size = New System.Drawing.Size(107, 68)
        Me.lstNoms.TabIndex = 28
        '
        'lblNbParties
        '
        Me.lblNbParties.AutoSize = True
        Me.lblNbParties.Location = New System.Drawing.Point(388, 161)
        Me.lblNbParties.Name = "lblNbParties"
        Me.lblNbParties.Size = New System.Drawing.Size(49, 16)
        Me.lblNbParties.TabIndex = 27
        Me.lblNbParties.Text = "Parties"
        '
        'lblTempsTotal
        '
        Me.lblTempsTotal.AutoSize = True
        Me.lblTempsTotal.Location = New System.Drawing.Point(253, 162)
        Me.lblTempsTotal.Name = "lblTempsTotal"
        Me.lblTempsTotal.Size = New System.Drawing.Size(50, 16)
        Me.lblTempsTotal.TabIndex = 26
        Me.lblTempsTotal.Text = "Temps"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(157, 162)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(43, 16)
        Me.lblScore.TabIndex = 25
        Me.lblScore.Text = "Score"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(39, 162)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(36, 16)
        Me.lblNom.TabIndex = 24
        Me.lblNom.Text = "Nom"
        '
        'lblTableauScores
        '
        Me.lblTableauScores.AutoSize = True
        Me.lblTableauScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableauScores.Location = New System.Drawing.Point(117, 27)
        Me.lblTableauScores.Name = "lblTableauScores"
        Me.lblTableauScores.Size = New System.Drawing.Size(226, 29)
        Me.lblTableauScores.TabIndex = 23
        Me.lblTableauScores.Text = "Tableau des scores"
        '
        'lblMaxValeur
        '
        Me.lblMaxValeur.AutoSize = True
        Me.lblMaxValeur.Location = New System.Drawing.Point(25, 293)
        Me.lblMaxValeur.Name = "lblMaxValeur"
        Me.lblMaxValeur.Size = New System.Drawing.Size(32, 16)
        Me.lblMaxValeur.TabIndex = 37
        Me.lblMaxValeur.Text = "Max"
        '
        'lblMinValeur
        '
        Me.lblMinValeur.AutoSize = True
        Me.lblMinValeur.Location = New System.Drawing.Point(111, 293)
        Me.lblMinValeur.Name = "lblMinValeur"
        Me.lblMinValeur.Size = New System.Drawing.Size(28, 16)
        Me.lblMinValeur.TabIndex = 38
        Me.lblMinValeur.Text = "Min"
        '
        'btnAffJoueur
        '
        Me.btnAffJoueur.Location = New System.Drawing.Point(225, 359)
        Me.btnAffJoueur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAffJoueur.Name = "btnAffJoueur"
        Me.btnAffJoueur.Size = New System.Drawing.Size(79, 25)
        Me.btnAffJoueur.TabIndex = 39
        Me.btnAffJoueur.Text = "Afficher"
        Me.btnAffJoueur.UseVisualStyleBackColor = True
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 519)
        Me.Controls.Add(Me.btnAffJoueur)
        Me.Controls.Add(Me.lblMinValeur)
        Me.Controls.Add(Me.lblMaxValeur)
        Me.Controls.Add(Me.lblRechercher)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.cmbJoueurValeur)
        Me.Controls.Add(Me.btnTri)
        Me.Controls.Add(Me.lstTempsTotal)
        Me.Controls.Add(Me.lstNbParties)
        Me.Controls.Add(Me.lstTemps)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.lstNoms)
        Me.Controls.Add(Me.lblNbParties)
        Me.Controls.Add(Me.lblTempsTotal)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblTableauScores)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormScores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnRejouer As Button
    Friend WithEvents lblRechercher As Label
    Friend WithEvents btnFermer As Button
    Friend WithEvents cmbJoueurValeur As ComboBox
    Friend WithEvents btnTri As Button
    Friend WithEvents lstTempsTotal As ListBox
    Friend WithEvents lstNbParties As ListBox
    Friend WithEvents lstTemps As ListBox
    Friend WithEvents lstScores As ListBox
    Friend WithEvents lstNoms As ListBox
    Friend WithEvents lblNbParties As Label
    Friend WithEvents lblTempsTotal As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblTableauScores As Label
    Friend WithEvents lblMaxValeur As Label
    Friend WithEvents lblMinValeur As Label
    Friend WithEvents btnAffJoueur As Button
End Class
