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
        Me.LabelJoueurActif = New System.Windows.Forms.Label()
        Me.LabelTempsRestant = New System.Windows.Forms.Label()
        Me.ListBoxScores = New System.Windows.Forms.ListBox()
        Me.ButtonCommencer = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LblJoeurSelectionne = New System.Windows.Forms.Label()
        Me.LblJoeurDispo = New System.Windows.Forms.Label()
        Me.ButtonRetirerJoueur = New System.Windows.Forms.Button()
        Me.ButtonAjouterJoueur = New System.Windows.Forms.Button()
        Me.ListBoxJoueursSelectionnes = New System.Windows.Forms.ListBox()
        Me.ListBoxJoueursDisponibles = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.Lbloptions = New System.Windows.Forms.Label()
        Me.LblManche = New System.Windows.Forms.Label()
        Me.LblTemps = New System.Windows.Forms.Label()
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
        Me.NumericUpDownManches.Location = New System.Drawing.Point(591, 17)
        Me.NumericUpDownManches.Name = "NumericUpDownManches"
        Me.NumericUpDownManches.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDownManches.TabIndex = 4
        '
        'NumericUpDownTemps
        '
        Me.NumericUpDownTemps.Location = New System.Drawing.Point(349, 17)
        Me.NumericUpDownTemps.Name = "NumericUpDownTemps"
        Me.NumericUpDownTemps.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDownTemps.TabIndex = 5
        '
        'ComboBoxDifficulte
        '
        Me.ComboBoxDifficulte.FormattingEnabled = True
        Me.ComboBoxDifficulte.Location = New System.Drawing.Point(17, 780)
        Me.ComboBoxDifficulte.Name = "ComboBoxDifficulte"
        Me.ComboBoxDifficulte.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxDifficulte.TabIndex = 6
        '
        'CheckBoxOrdreAleatoire
        '
        Me.CheckBoxOrdreAleatoire.AutoSize = True
        Me.CheckBoxOrdreAleatoire.Location = New System.Drawing.Point(155, 17)
        Me.CheckBoxOrdreAleatoire.Name = "CheckBoxOrdreAleatoire"
        Me.CheckBoxOrdreAleatoire.Size = New System.Drawing.Size(98, 24)
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
        Me.PanelCartes.Location = New System.Drawing.Point(12, 295)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(753, 100)
        Me.PanelCartes.TabIndex = 8
        '
        'LabelJoueurActif
        '
        Me.LabelJoueurActif.AutoSize = True
        Me.LabelJoueurActif.Location = New System.Drawing.Point(25, 34)
        Me.LabelJoueurActif.Name = "LabelJoueurActif"
        Me.LabelJoueurActif.Size = New System.Drawing.Size(92, 20)
        Me.LabelJoueurActif.TabIndex = 9
        Me.LabelJoueurActif.Text = "Joueur actif"
        '
        'LabelTempsRestant
        '
        Me.LabelTempsRestant.AutoSize = True
        Me.LabelTempsRestant.Location = New System.Drawing.Point(464, 45)
        Me.LabelTempsRestant.Name = "LabelTempsRestant"
        Me.LabelTempsRestant.Size = New System.Drawing.Size(111, 20)
        Me.LabelTempsRestant.TabIndex = 10
        Me.LabelTempsRestant.Text = "Temps restant"
        '
        'ListBoxScores
        '
        Me.ListBoxScores.FormattingEnabled = True
        Me.ListBoxScores.ItemHeight = 20
        Me.ListBoxScores.Location = New System.Drawing.Point(62, 48)
        Me.ListBoxScores.Name = "ListBoxScores"
        Me.ListBoxScores.Size = New System.Drawing.Size(120, 84)
        Me.ListBoxScores.TabIndex = 11
        '
        'ButtonCommencer
        '
        Me.ButtonCommencer.Location = New System.Drawing.Point(88, 16)
        Me.ButtonCommencer.Name = "ButtonCommencer"
        Me.ButtonCommencer.Size = New System.Drawing.Size(111, 39)
        Me.ButtonCommencer.TabIndex = 12
        Me.ButtonCommencer.Text = "Commencer"
        Me.ButtonCommencer.UseVisualStyleBackColor = True
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Location = New System.Drawing.Point(349, 16)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(106, 39)
        Me.ButtonAbandonner.TabIndex = 13
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(558, 15)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(121, 40)
        Me.ButtonRetour.TabIndex = 14
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 789)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 789)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 788)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(471, 787)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(16, 28)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(420, 37)
        Me.LblTitre.TabIndex = 19
        Me.LblTitre.Text = "MEMORY MUTILIJOUEUR"
        '
        'LblJoeurSelectionne
        '
        Me.LblJoeurSelectionne.AutoSize = True
        Me.LblJoeurSelectionne.Location = New System.Drawing.Point(248, 12)
        Me.LblJoeurSelectionne.Name = "LblJoeurSelectionne"
        Me.LblJoeurSelectionne.Size = New System.Drawing.Size(134, 20)
        Me.LblJoeurSelectionne.TabIndex = 27
        Me.LblJoeurSelectionne.Text = "Joeur selectionné"
        '
        'LblJoeurDispo
        '
        Me.LblJoeurDispo.AutoSize = True
        Me.LblJoeurDispo.Location = New System.Drawing.Point(9, 12)
        Me.LblJoeurDispo.Name = "LblJoeurDispo"
        Me.LblJoeurDispo.Size = New System.Drawing.Size(124, 20)
        Me.LblJoeurDispo.TabIndex = 26
        Me.LblJoeurDispo.Text = "Joeur disponible"
        '
        'ButtonRetirerJoueur
        '
        Me.ButtonRetirerJoueur.Location = New System.Drawing.Point(272, 135)
        Me.ButtonRetirerJoueur.Name = "ButtonRetirerJoueur"
        Me.ButtonRetirerJoueur.Size = New System.Drawing.Size(94, 35)
        Me.ButtonRetirerJoueur.TabIndex = 25
        Me.ButtonRetirerJoueur.Text = "Retirer joueur"
        Me.ButtonRetirerJoueur.UseVisualStyleBackColor = True
        '
        'ButtonAjouterJoueur
        '
        Me.ButtonAjouterJoueur.Location = New System.Drawing.Point(62, 135)
        Me.ButtonAjouterJoueur.Name = "ButtonAjouterJoueur"
        Me.ButtonAjouterJoueur.Size = New System.Drawing.Size(88, 35)
        Me.ButtonAjouterJoueur.TabIndex = 24
        Me.ButtonAjouterJoueur.Text = "Ajouter joueur"
        Me.ButtonAjouterJoueur.UseVisualStyleBackColor = True
        '
        'ListBoxJoueursSelectionnes
        '
        Me.ListBoxJoueursSelectionnes.FormattingEnabled = True
        Me.ListBoxJoueursSelectionnes.ItemHeight = 20
        Me.ListBoxJoueursSelectionnes.Location = New System.Drawing.Point(233, 35)
        Me.ListBoxJoueursSelectionnes.Name = "ListBoxJoueursSelectionnes"
        Me.ListBoxJoueursSelectionnes.Size = New System.Drawing.Size(181, 84)
        Me.ListBoxJoueursSelectionnes.TabIndex = 23
        '
        'ListBoxJoueursDisponibles
        '
        Me.ListBoxJoueursDisponibles.FormattingEnabled = True
        Me.ListBoxJoueursDisponibles.ItemHeight = 20
        Me.ListBoxJoueursDisponibles.Location = New System.Drawing.Point(9, 35)
        Me.ListBoxJoueursDisponibles.Name = "ListBoxJoueursDisponibles"
        Me.ListBoxJoueursDisponibles.Size = New System.Drawing.Size(188, 84)
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
        Me.Panel1.Location = New System.Drawing.Point(14, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 201)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblScore)
        Me.Panel2.Controls.Add(Me.ListBoxScores)
        Me.Panel2.Location = New System.Drawing.Point(533, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 204)
        Me.Panel2.TabIndex = 29
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Location = New System.Drawing.Point(58, 15)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(111, 20)
        Me.LblScore.TabIndex = 0
        Me.LblScore.Text = "Score et Stats"
        '
        'Lbloptions
        '
        Me.Lbloptions.AutoSize = True
        Me.Lbloptions.Location = New System.Drawing.Point(22, 17)
        Me.Lbloptions.Name = "Lbloptions"
        Me.Lbloptions.Size = New System.Drawing.Size(64, 20)
        Me.Lbloptions.TabIndex = 0
        Me.Lbloptions.Text = "Options"
        '
        'LblManche
        '
        Me.LblManche.AutoSize = True
        Me.LblManche.Location = New System.Drawing.Point(515, 19)
        Me.LblManche.Name = "LblManche"
        Me.LblManche.Size = New System.Drawing.Size(66, 20)
        Me.LblManche.TabIndex = 8
        Me.LblManche.Text = "Manche"
        '
        'LblTemps
        '
        Me.LblTemps.AutoSize = True
        Me.LblTemps.Location = New System.Drawing.Point(277, 23)
        Me.LblTemps.Name = "LblTemps"
        Me.LblTemps.Size = New System.Drawing.Size(57, 20)
        Me.LblTemps.TabIndex = 9
        Me.LblTemps.Text = "Temps"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LabelJoueurActif)
        Me.Panel3.Controls.Add(Me.LabelTempsRestant)
        Me.Panel3.Location = New System.Drawing.Point(12, 423)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(755, 100)
        Me.Panel3.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ButtonCommencer)
        Me.Panel4.Controls.Add(Me.ButtonAbandonner)
        Me.Panel4.Controls.Add(Me.ButtonRetour)
        Me.Panel4.Location = New System.Drawing.Point(12, 562)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(755, 69)
        Me.Panel4.TabIndex = 31
        '
        'FormMultiJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 855)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PanelCartes)
        Me.Controls.Add(Me.ComboBoxDifficulte)
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
    Friend WithEvents ListBoxScores As ListBox
    Friend WithEvents ButtonCommencer As Button
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LblTitre As Label
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
