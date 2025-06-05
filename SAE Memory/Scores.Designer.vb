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
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.btnTri = New System.Windows.Forms.Button()
        Me.lblTableauScores = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstTmpTot = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMinValeur = New System.Windows.Forms.Label()
        Me.lblMaxValeur = New System.Windows.Forms.Label()
        Me.lstNbParties = New System.Windows.Forms.ListBox()
        Me.lstTemps = New System.Windows.Forms.ListBox()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lstNoms = New System.Windows.Forms.ListBox()
        Me.lblNbParties = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAffJoueur = New System.Windows.Forms.Button()
        Me.lblRechercher = New System.Windows.Forms.Label()
        Me.cmbJoueurValeur = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(444, 571)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(165, 35)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRejouer
        '
        Me.btnRejouer.Location = New System.Drawing.Point(36, 571)
        Me.btnRejouer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(165, 35)
        Me.btnRejouer.TabIndex = 8
        Me.btnRejouer.Text = "Rejouer"
        Me.btnRejouer.UseVisualStyleBackColor = True
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(586, 24)
        Me.btnFermer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(105, 38)
        Me.btnFermer.TabIndex = 35
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'btnTri
        '
        Me.btnTri.Location = New System.Drawing.Point(460, 24)
        Me.btnTri.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTri.Name = "btnTri"
        Me.btnTri.Size = New System.Drawing.Size(107, 38)
        Me.btnTri.TabIndex = 33
        Me.btnTri.Text = "Tri"
        Me.btnTri.UseVisualStyleBackColor = True
        '
        'lblTableauScores
        '
        Me.lblTableauScores.AutoSize = True
        Me.lblTableauScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableauScores.Location = New System.Drawing.Point(12, 20)
        Me.lblTableauScores.Name = "lblTableauScores"
        Me.lblTableauScores.Size = New System.Drawing.Size(314, 37)
        Me.lblTableauScores.TabIndex = 23
        Me.lblTableauScores.Text = "Tableau des scores"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lstTmpTot)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblMinValeur)
        Me.Panel1.Controls.Add(Me.lblMaxValeur)
        Me.Panel1.Controls.Add(Me.lstNbParties)
        Me.Panel1.Controls.Add(Me.lstTemps)
        Me.Panel1.Controls.Add(Me.lstScores)
        Me.Panel1.Controls.Add(Me.lstNoms)
        Me.Panel1.Controls.Add(Me.lblNbParties)
        Me.Panel1.Controls.Add(Me.lblTemps)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.lblNom)
        Me.Panel1.Location = New System.Drawing.Point(12, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 301)
        Me.Panel1.TabIndex = 40
        '
        'lstTmpTot
        '
        Me.lstTmpTot.FormattingEnabled = True
        Me.lstTmpTot.ItemHeight = 20
        Me.lstTmpTot.Location = New System.Drawing.Point(434, 63)
        Me.lstTmpTot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTmpTot.Name = "lstTmpTot"
        Me.lstTmpTot.Size = New System.Drawing.Size(121, 164)
        Me.lstTmpTot.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Temps total jouer"
        '
        'lblMinValeur
        '
        Me.lblMinValeur.AutoSize = True
        Me.lblMinValeur.Location = New System.Drawing.Point(119, 243)
        Me.lblMinValeur.Name = "lblMinValeur"
        Me.lblMinValeur.Size = New System.Drawing.Size(34, 20)
        Me.lblMinValeur.TabIndex = 51
        Me.lblMinValeur.Text = "Min"
        '
        'lblMaxValeur
        '
        Me.lblMaxValeur.AutoSize = True
        Me.lblMaxValeur.Location = New System.Drawing.Point(23, 243)
        Me.lblMaxValeur.Name = "lblMaxValeur"
        Me.lblMaxValeur.Size = New System.Drawing.Size(38, 20)
        Me.lblMaxValeur.TabIndex = 50
        Me.lblMaxValeur.Text = "Max"
        '
        'lstNbParties
        '
        Me.lstNbParties.FormattingEnabled = True
        Me.lstNbParties.ItemHeight = 20
        Me.lstNbParties.Location = New System.Drawing.Point(574, 63)
        Me.lstNbParties.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNbParties.Name = "lstNbParties"
        Me.lstNbParties.Size = New System.Drawing.Size(133, 164)
        Me.lstNbParties.TabIndex = 49
        '
        'lstTemps
        '
        Me.lstTemps.FormattingEnabled = True
        Me.lstTemps.ItemHeight = 20
        Me.lstTemps.Location = New System.Drawing.Point(279, 63)
        Me.lstTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTemps.Name = "lstTemps"
        Me.lstTemps.Size = New System.Drawing.Size(120, 164)
        Me.lstTemps.TabIndex = 48
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 20
        Me.lstScores.Location = New System.Drawing.Point(140, 63)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(120, 164)
        Me.lstScores.TabIndex = 47
        '
        'lstNoms
        '
        Me.lstNoms.FormattingEnabled = True
        Me.lstNoms.ItemHeight = 20
        Me.lstNoms.Location = New System.Drawing.Point(2, 63)
        Me.lstNoms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstNoms.Name = "lstNoms"
        Me.lstNoms.Size = New System.Drawing.Size(120, 164)
        Me.lstNoms.TabIndex = 46
        '
        'lblNbParties
        '
        Me.lblNbParties.AutoSize = True
        Me.lblNbParties.Location = New System.Drawing.Point(570, 27)
        Me.lblNbParties.Name = "lblNbParties"
        Me.lblNbParties.Size = New System.Drawing.Size(148, 20)
        Me.lblNbParties.TabIndex = 45
        Me.lblNbParties.Text = "Nombres de Parties"
        '
        'lblTemps
        '
        Me.lblTemps.Location = New System.Drawing.Point(279, 13)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(124, 51)
        Me.lblTemps.TabIndex = 44
        Me.lblTemps.Text = "Temps de la meilleurs partie"
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(141, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(110, 51)
        Me.lblScore.TabIndex = 43
        Me.lblScore.Text = "Score de la meilleurs partie"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(4, 27)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(42, 20)
        Me.lblNom.TabIndex = 42
        Me.lblNom.Text = "Nom"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAffJoueur)
        Me.Panel2.Controls.Add(Me.lblRechercher)
        Me.Panel2.Controls.Add(Me.cmbJoueurValeur)
        Me.Panel2.Location = New System.Drawing.Point(20, 455)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 55)
        Me.Panel2.TabIndex = 41
        '
        'btnAffJoueur
        '
        Me.btnAffJoueur.Location = New System.Drawing.Point(359, 14)
        Me.btnAffJoueur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAffJoueur.Name = "btnAffJoueur"
        Me.btnAffJoueur.Size = New System.Drawing.Size(89, 31)
        Me.btnAffJoueur.TabIndex = 42
        Me.btnAffJoueur.Text = "Afficher"
        Me.btnAffJoueur.UseVisualStyleBackColor = True
        '
        'lblRechercher
        '
        Me.lblRechercher.AutoSize = True
        Me.lblRechercher.Location = New System.Drawing.Point(15, 19)
        Me.lblRechercher.Name = "lblRechercher"
        Me.lblRechercher.Size = New System.Drawing.Size(92, 20)
        Me.lblRechercher.TabIndex = 41
        Me.lblRechercher.Text = "Rechercher"
        '
        'cmbJoueurValeur
        '
        Me.cmbJoueurValeur.FormattingEnabled = True
        Me.cmbJoueurValeur.Location = New System.Drawing.Point(200, 17)
        Me.cmbJoueurValeur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbJoueurValeur.Name = "cmbJoueurValeur"
        Me.cmbJoueurValeur.Size = New System.Drawing.Size(106, 28)
        Me.cmbJoueurValeur.TabIndex = 40
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(745, 649)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnTri)
        Me.Controls.Add(Me.lblTableauScores)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormScores"
        Me.Text = "Scores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnRejouer As Button
    Friend WithEvents btnFermer As Button
    Friend WithEvents btnTri As Button
    Friend WithEvents lblTableauScores As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lstTmpTot As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMinValeur As Label
    Friend WithEvents lblMaxValeur As Label
    Friend WithEvents lstNbParties As ListBox
    Friend WithEvents lstTemps As ListBox
    Friend WithEvents lstScores As ListBox
    Friend WithEvents lstNoms As ListBox
    Friend WithEvents lblNbParties As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAffJoueur As Button
    Friend WithEvents lblRechercher As Label
    Friend WithEvents cmbJoueurValeur As ComboBox
End Class
