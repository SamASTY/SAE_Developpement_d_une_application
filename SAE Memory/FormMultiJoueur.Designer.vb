<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMultiJoueur
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
        Me.NumericUpDownManches = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownTemps = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxDifficulte = New System.Windows.Forms.ComboBox()
        Me.CheckBoxOrdreAleatoire = New System.Windows.Forms.CheckBox()
        Me.PanelCartes = New System.Windows.Forms.Panel()
        Me.LblTemps = New System.Windows.Forms.Label()
        Me.LblManche = New System.Windows.Forms.Label()
        Me.Lbloptions = New System.Windows.Forms.Label()
        Me.LabelJoueurActif = New System.Windows.Forms.Label()
        Me.LabelTempsRestant = New System.Windows.Forms.Label()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.ButtonCommencer = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.LblJoeurSelectionne = New System.Windows.Forms.Label()
        Me.LblJoeurDispo = New System.Windows.Forms.Label()
        Me.ButtonRetirerJoueur = New System.Windows.Forms.Button()
        Me.ButtonAjouterJoueur = New System.Windows.Forms.Button()
        Me.ListBoxJoueursSelectionnes = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueursDisponibles = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.NumericUpDownManches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTemps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCartes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDownManches
        '
        Me.NumericUpDownManches.Location = New System.Drawing.Point(394, 11)
        Me.NumericUpDownManches.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownManches.Name = "NumericUpDownManches"
        Me.NumericUpDownManches.Size = New System.Drawing.Size(80, 20)
        Me.NumericUpDownManches.TabIndex = 4
        '
        'NumericUpDownTemps
        '
        Me.NumericUpDownTemps.Location = New System.Drawing.Point(233, 11)
        Me.NumericUpDownTemps.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDownTemps.Name = "NumericUpDownTemps"
        Me.NumericUpDownTemps.Size = New System.Drawing.Size(80, 20)
        Me.NumericUpDownTemps.TabIndex = 5
        '
        'ComboBoxDifficulte
        '
        Me.ComboBoxDifficulte.FormattingEnabled = True
        Me.ComboBoxDifficulte.Location = New System.Drawing.Point(11, 507)
        Me.ComboBoxDifficulte.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDifficulte.Name = "ComboBoxDifficulte"
        Me.ComboBoxDifficulte.Size = New System.Drawing.Size(82, 21)
        Me.ComboBoxDifficulte.TabIndex = 6
        '
        'CheckBoxOrdreAleatoire
        '
        Me.CheckBoxOrdreAleatoire.AutoSize = True
        Me.CheckBoxOrdreAleatoire.Location = New System.Drawing.Point(103, 11)
        Me.CheckBoxOrdreAleatoire.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBoxOrdreAleatoire.Name = "CheckBoxOrdreAleatoire"
        Me.CheckBoxOrdreAleatoire.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxOrdreAleatoire.TabIndex = 7
        Me.CheckBoxOrdreAleatoire.Text = "Aleatoire"
        Me.CheckBoxOrdreAleatoire.UseVisualStyleBackColor = True
        '
        'PanelCartes
        '
        Me.PanelCartes.Controls.Add(Me.LblTemps)
        Me.PanelCartes.Controls.Add(Me.LblManche)
        Me.PanelCartes.Controls.Add(Me.Lbloptions)
        Me.PanelCartes.Controls.Add(Me.CheckBoxOrdreAleatoire)
        Me.PanelCartes.Controls.Add(Me.NumericUpDownTemps)
        Me.PanelCartes.Controls.Add(Me.NumericUpDownManches)
        Me.PanelCartes.Location = New System.Drawing.Point(8, 192)
        Me.PanelCartes.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(502, 65)
        Me.PanelCartes.TabIndex = 8
        '
        'LblTemps
        '
        Me.LblTemps.AutoSize = True
        Me.LblTemps.Location = New System.Drawing.Point(185, 15)
        Me.LblTemps.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTemps.Name = "LblTemps"
        Me.LblTemps.Size = New System.Drawing.Size(39, 13)
        Me.LblTemps.TabIndex = 9
        Me.LblTemps.Text = "Temps"
        '
        'LblManche
        '
        Me.LblManche.AutoSize = True
        Me.LblManche.Location = New System.Drawing.Point(343, 12)
        Me.LblManche.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblManche.Name = "LblManche"
        Me.LblManche.Size = New System.Drawing.Size(46, 13)
        Me.LblManche.TabIndex = 8
        Me.LblManche.Text = "Manche"
        '
        'Lbloptions
        '
        Me.Lbloptions.AutoSize = True
        Me.Lbloptions.Location = New System.Drawing.Point(15, 11)
        Me.Lbloptions.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbloptions.Name = "Lbloptions"
        Me.Lbloptions.Size = New System.Drawing.Size(43, 13)
        Me.Lbloptions.TabIndex = 0
        Me.Lbloptions.Text = "Options"
        '
        'LabelJoueurActif
        '
        Me.LabelJoueurActif.AutoSize = True
        Me.LabelJoueurActif.Location = New System.Drawing.Point(17, 22)
        Me.LabelJoueurActif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelJoueurActif.Name = "LabelJoueurActif"
        Me.LabelJoueurActif.Size = New System.Drawing.Size(62, 13)
        Me.LabelJoueurActif.TabIndex = 9
        Me.LabelJoueurActif.Text = "Joueur actif"
        '
        'LabelTempsRestant
        '
        Me.LabelTempsRestant.AutoSize = True
        Me.LabelTempsRestant.Location = New System.Drawing.Point(309, 29)
        Me.LabelTempsRestant.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTempsRestant.Name = "LabelTempsRestant"
        Me.LabelTempsRestant.Size = New System.Drawing.Size(74, 13)
        Me.LabelTempsRestant.TabIndex = 10
        Me.LabelTempsRestant.Text = "Temps restant"
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.Location = New System.Drawing.Point(41, 31)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(81, 56)
        Me.lstScores.TabIndex = 11
        '
        'ButtonCommencer
        '
        Me.ButtonCommencer.Location = New System.Drawing.Point(59, 10)
        Me.ButtonCommencer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCommencer.Name = "ButtonCommencer"
        Me.ButtonCommencer.Size = New System.Drawing.Size(74, 25)
        Me.ButtonCommencer.TabIndex = 12
        Me.ButtonCommencer.Text = "Commencer"
        Me.ButtonCommencer.UseVisualStyleBackColor = True
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Location = New System.Drawing.Point(233, 10)
        Me.ButtonAbandonner.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(71, 25)
        Me.ButtonAbandonner.TabIndex = 13
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(372, 10)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(81, 26)
        Me.ButtonRetour.TabIndex = 14
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 513)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 513)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 512)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(314, 512)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(11, 18)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(291, 26)
        Me.lblTitre.TabIndex = 19
        Me.lblTitre.Text = "MEMORY MULTIJOUEUR"
        '
        'LblJoeurSelectionne
        '
        Me.LblJoeurSelectionne.AutoSize = True
        Me.LblJoeurSelectionne.Location = New System.Drawing.Point(165, 8)
        Me.LblJoeurSelectionne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblJoeurSelectionne.Name = "LblJoeurSelectionne"
        Me.LblJoeurSelectionne.Size = New System.Drawing.Size(90, 13)
        Me.LblJoeurSelectionne.TabIndex = 27
        Me.LblJoeurSelectionne.Text = "Joeur selectionné"
        '
        'LblJoeurDispo
        '
        Me.LblJoeurDispo.AutoSize = True
        Me.LblJoeurDispo.Location = New System.Drawing.Point(6, 8)
        Me.LblJoeurDispo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblJoeurDispo.Name = "LblJoeurDispo"
        Me.LblJoeurDispo.Size = New System.Drawing.Size(83, 13)
        Me.LblJoeurDispo.TabIndex = 26
        Me.LblJoeurDispo.Text = "Joeur disponible"
        '
        'ButtonRetirerJoueur
        '
        Me.ButtonRetirerJoueur.Location = New System.Drawing.Point(181, 88)
        Me.ButtonRetirerJoueur.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRetirerJoueur.Name = "ButtonRetirerJoueur"
        Me.ButtonRetirerJoueur.Size = New System.Drawing.Size(63, 23)
        Me.ButtonRetirerJoueur.TabIndex = 25
        Me.ButtonRetirerJoueur.Text = "Retirer joueur"
        Me.ButtonRetirerJoueur.UseVisualStyleBackColor = True
        '
        'ButtonAjouterJoueur
        '
        Me.ButtonAjouterJoueur.Location = New System.Drawing.Point(41, 88)
        Me.ButtonAjouterJoueur.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAjouterJoueur.Name = "ButtonAjouterJoueur"
        Me.ButtonAjouterJoueur.Size = New System.Drawing.Size(59, 23)
        Me.ButtonAjouterJoueur.TabIndex = 24
        Me.ButtonAjouterJoueur.Text = "Ajouter joueur"
        Me.ButtonAjouterJoueur.UseVisualStyleBackColor = True
        '
        'ListBoxJoueursSelectionnes
        '
        Me.ListBoxJoueursSelectionnes.FormattingEnabled = True
        Me.ListBoxJoueursSelectionnes.Location = New System.Drawing.Point(155, 23)
        Me.ListBoxJoueursSelectionnes.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxJoueursSelectionnes.Name = "ListBoxJoueursSelectionnes"
        Me.ListBoxJoueursSelectionnes.Size = New System.Drawing.Size(122, 56)
        Me.ListBoxJoueursSelectionnes.TabIndex = 23
        '
        'ListBoxJoueursDisponibles
        '
        Me.ListBoxJoueursDisponibles.FormattingEnabled = True
        Me.ListBoxJoueursDisponibles.Location = New System.Drawing.Point(6, 23)
        Me.ListBoxJoueursDisponibles.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxJoueursDisponibles.Name = "ListBoxJoueursDisponibles"
        Me.ListBoxJoueursDisponibles.Size = New System.Drawing.Size(127, 56)
        Me.ListBoxJoueursDisponibles.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBoxJoueursSelectionnes)
        Me.Panel1.Controls.Add(Me.LblJoeurSelectionne)
        Me.Panel1.Controls.Add(Me.ListBoxJoueursDisponibles)
        Me.Panel1.Controls.Add(Me.LblJoeurDispo)
        Me.Panel1.Controls.Add(Me.ButtonAjouterJoueur)
        Me.Panel1.Controls.Add(Me.ButtonRetirerJoueur)
        Me.Panel1.Location = New System.Drawing.Point(9, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 131)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblScore)
        Me.Panel2.Controls.Add(Me.lstScores)
        Me.Panel2.Location = New System.Drawing.Point(355, 42)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 133)
        Me.Panel2.TabIndex = 29
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Location = New System.Drawing.Point(39, 10)
        Me.LblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(74, 13)
        Me.LblScore.TabIndex = 0
        Me.LblScore.Text = "Score et Stats"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelJoueurActif)
        Me.Panel3.Controls.Add(Me.LabelTempsRestant)
        Me.Panel3.Location = New System.Drawing.Point(8, 275)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 65)
        Me.Panel3.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ButtonCommencer)
        Me.Panel4.Controls.Add(Me.ButtonAbandonner)
        Me.Panel4.Controls.Add(Me.ButtonRetour)
        Me.Panel4.Location = New System.Drawing.Point(8, 365)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 45)
        Me.Panel4.TabIndex = 31
        '
        'FormMultiJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 556)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PanelCartes)
        Me.Controls.Add(Me.ComboBoxDifficulte)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMultiJoueur"
        Me.Text = "Form1"
        CType(Me.NumericUpDownManches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTemps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCartes.ResumeLayout(False)
        Me.PanelCartes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDownManches As NumericUpDown
    Friend WithEvents NumericUpDownTemps As NumericUpDown
    Friend WithEvents ComboBoxDifficulte As ComboBox
    Friend WithEvents CheckBoxOrdreAleatoire As CheckBox
    Friend WithEvents PanelCartes As Panel
    Friend WithEvents LabelJoueurActif As Label
    Friend WithEvents LabelTempsRestant As Label
    Friend WithEvents lstScores As ListBox
    Friend WithEvents ButtonCommencer As Button
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblTitre As Label
    Friend WithEvents LblJoeurSelectionne As Label
    Friend WithEvents LblJoeurDispo As Label
    Friend WithEvents ButtonRetirerJoueur As Button
    Friend WithEvents ButtonAjouterJoueur As Button
    Friend WithEvents ListBoxJoueursSelectionnes As ListBox
    Friend WithEvents ListBoxJoueursDisponibles As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTemps As Label
    Friend WithEvents LblManche As Label
    Friend WithEvents Lbloptions As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblScore As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
