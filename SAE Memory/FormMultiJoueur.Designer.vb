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
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.ButtonCommencer = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownManches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTemps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCartes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDownManches
        '
        Me.NumericUpDownManches.Location = New System.Drawing.Point(525, 14)
        Me.NumericUpDownManches.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDownManches.Name = "NumericUpDownManches"
        Me.NumericUpDownManches.Size = New System.Drawing.Size(107, 22)
        Me.NumericUpDownManches.TabIndex = 4
        '
        'NumericUpDownTemps
        '
        Me.NumericUpDownTemps.Location = New System.Drawing.Point(311, 14)
        Me.NumericUpDownTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumericUpDownTemps.Name = "NumericUpDownTemps"
        Me.NumericUpDownTemps.Size = New System.Drawing.Size(107, 22)
        Me.NumericUpDownTemps.TabIndex = 5
        '
        'ComboBoxDifficulte
        '
        Me.ComboBoxDifficulte.FormattingEnabled = True
        Me.ComboBoxDifficulte.Location = New System.Drawing.Point(121, 41)
        Me.ComboBoxDifficulte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxDifficulte.Name = "ComboBoxDifficulte"
        Me.ComboBoxDifficulte.Size = New System.Drawing.Size(108, 24)
        Me.ComboBoxDifficulte.TabIndex = 6
        '
        'CheckBoxOrdreAleatoire
        '
        Me.CheckBoxOrdreAleatoire.AutoSize = True
        Me.CheckBoxOrdreAleatoire.Location = New System.Drawing.Point(137, 14)
        Me.CheckBoxOrdreAleatoire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxOrdreAleatoire.Name = "CheckBoxOrdreAleatoire"
        Me.CheckBoxOrdreAleatoire.Size = New System.Drawing.Size(83, 20)
        Me.CheckBoxOrdreAleatoire.TabIndex = 7
        Me.CheckBoxOrdreAleatoire.Text = "Aleatoire"
        Me.CheckBoxOrdreAleatoire.UseVisualStyleBackColor = True
        '
        'PanelCartes
        '
        Me.PanelCartes.Controls.Add(Me.Label1)
        Me.PanelCartes.Controls.Add(Me.LblTemps)
        Me.PanelCartes.Controls.Add(Me.LblManche)
        Me.PanelCartes.Controls.Add(Me.Lbloptions)
        Me.PanelCartes.Controls.Add(Me.CheckBoxOrdreAleatoire)
        Me.PanelCartes.Controls.Add(Me.NumericUpDownTemps)
        Me.PanelCartes.Controls.Add(Me.NumericUpDownManches)
        Me.PanelCartes.Controls.Add(Me.ComboBoxDifficulte)
        Me.PanelCartes.Location = New System.Drawing.Point(11, 236)
        Me.PanelCartes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(669, 80)
        Me.PanelCartes.TabIndex = 8
        '
        'LblTemps
        '
        Me.LblTemps.AutoSize = True
        Me.LblTemps.Location = New System.Drawing.Point(247, 18)
        Me.LblTemps.Name = "LblTemps"
        Me.LblTemps.Size = New System.Drawing.Size(50, 16)
        Me.LblTemps.TabIndex = 9
        Me.LblTemps.Text = "Temps"
        '
        'LblManche
        '
        Me.LblManche.AutoSize = True
        Me.LblManche.Location = New System.Drawing.Point(457, 15)
        Me.LblManche.Name = "LblManche"
        Me.LblManche.Size = New System.Drawing.Size(55, 16)
        Me.LblManche.TabIndex = 8
        Me.LblManche.Text = "Manche"
        '
        'Lbloptions
        '
        Me.Lbloptions.AutoSize = True
        Me.Lbloptions.Location = New System.Drawing.Point(20, 14)
        Me.Lbloptions.Name = "Lbloptions"
        Me.Lbloptions.Size = New System.Drawing.Size(53, 16)
        Me.Lbloptions.TabIndex = 0
        Me.Lbloptions.Text = "Options"
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 16
        Me.lstScores.Location = New System.Drawing.Point(55, 38)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(107, 68)
        Me.lstScores.TabIndex = 11
        '
        'ButtonCommencer
        '
        Me.ButtonCommencer.Location = New System.Drawing.Point(79, 12)
        Me.ButtonCommencer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCommencer.Name = "ButtonCommencer"
        Me.ButtonCommencer.Size = New System.Drawing.Size(99, 31)
        Me.ButtonCommencer.TabIndex = 12
        Me.ButtonCommencer.Text = "Commencer"
        Me.ButtonCommencer.UseVisualStyleBackColor = True
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Location = New System.Drawing.Point(311, 12)
        Me.ButtonAbandonner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(95, 31)
        Me.ButtonAbandonner.TabIndex = 13
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(496, 12)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(108, 32)
        Me.ButtonRetour.TabIndex = 14
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(15, 22)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(355, 31)
        Me.lblTitre.TabIndex = 19
        Me.lblTitre.Text = "MEMORY MULTIJOUEUR"
        '
        'LblJoeurSelectionne
        '
        Me.LblJoeurSelectionne.AutoSize = True
        Me.LblJoeurSelectionne.Location = New System.Drawing.Point(220, 10)
        Me.LblJoeurSelectionne.Name = "LblJoeurSelectionne"
        Me.LblJoeurSelectionne.Size = New System.Drawing.Size(113, 16)
        Me.LblJoeurSelectionne.TabIndex = 27
        Me.LblJoeurSelectionne.Text = "Joeur selectionné"
        '
        'LblJoeurDispo
        '
        Me.LblJoeurDispo.AutoSize = True
        Me.LblJoeurDispo.Location = New System.Drawing.Point(8, 10)
        Me.LblJoeurDispo.Name = "LblJoeurDispo"
        Me.LblJoeurDispo.Size = New System.Drawing.Size(107, 16)
        Me.LblJoeurDispo.TabIndex = 26
        Me.LblJoeurDispo.Text = "Joeur disponible"
        '
        'ButtonRetirerJoueur
        '
        Me.ButtonRetirerJoueur.Location = New System.Drawing.Point(241, 108)
        Me.ButtonRetirerJoueur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRetirerJoueur.Name = "ButtonRetirerJoueur"
        Me.ButtonRetirerJoueur.Size = New System.Drawing.Size(84, 28)
        Me.ButtonRetirerJoueur.TabIndex = 25
        Me.ButtonRetirerJoueur.Text = "Retirer joueur"
        Me.ButtonRetirerJoueur.UseVisualStyleBackColor = True
        '
        'ButtonAjouterJoueur
        '
        Me.ButtonAjouterJoueur.Location = New System.Drawing.Point(55, 108)
        Me.ButtonAjouterJoueur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAjouterJoueur.Name = "ButtonAjouterJoueur"
        Me.ButtonAjouterJoueur.Size = New System.Drawing.Size(79, 28)
        Me.ButtonAjouterJoueur.TabIndex = 24
        Me.ButtonAjouterJoueur.Text = "Ajouter joueur"
        Me.ButtonAjouterJoueur.UseVisualStyleBackColor = True
        '
        'ListBoxJoueursSelectionnes
        '
        Me.ListBoxJoueursSelectionnes.FormattingEnabled = True
        Me.ListBoxJoueursSelectionnes.ItemHeight = 16
        Me.ListBoxJoueursSelectionnes.Location = New System.Drawing.Point(207, 28)
        Me.ListBoxJoueursSelectionnes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxJoueursSelectionnes.Name = "ListBoxJoueursSelectionnes"
        Me.ListBoxJoueursSelectionnes.Size = New System.Drawing.Size(161, 68)
        Me.ListBoxJoueursSelectionnes.TabIndex = 23
        '
        'ListBoxJoueursDisponibles
        '
        Me.ListBoxJoueursDisponibles.FormattingEnabled = True
        Me.ListBoxJoueursDisponibles.ItemHeight = 16
        Me.ListBoxJoueursDisponibles.Location = New System.Drawing.Point(8, 28)
        Me.ListBoxJoueursDisponibles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxJoueursDisponibles.Name = "ListBoxJoueursDisponibles"
        Me.ListBoxJoueursDisponibles.Size = New System.Drawing.Size(168, 68)
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
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 161)
        Me.Panel1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LblScore)
        Me.Panel2.Controls.Add(Me.lstScores)
        Me.Panel2.Location = New System.Drawing.Point(473, 52)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(208, 164)
        Me.Panel2.TabIndex = 29
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Location = New System.Drawing.Point(52, 12)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(90, 16)
        Me.LblScore.TabIndex = 0
        Me.LblScore.Text = "Score et Stats"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ButtonCommencer)
        Me.Panel4.Controls.Add(Me.ButtonAbandonner)
        Me.Panel4.Controls.Add(Me.ButtonRetour)
        Me.Panel4.Location = New System.Drawing.Point(11, 333)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(671, 57)
        Me.Panel4.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre de"
        '
        'FormMultiJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 402)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.PanelCartes)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDownManches As NumericUpDown
    Friend WithEvents NumericUpDownTemps As NumericUpDown
    Friend WithEvents ComboBoxDifficulte As ComboBox
    Friend WithEvents CheckBoxOrdreAleatoire As CheckBox
    Friend WithEvents PanelCartes As Panel
    Friend WithEvents lstScores As ListBox
    Friend WithEvents ButtonCommencer As Button
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents ButtonRetour As Button
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
End Class
