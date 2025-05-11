<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formScore
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
        Me.buttonQuitter = New System.Windows.Forms.Button()
        Me.buttonRejouer = New System.Windows.Forms.Button()
        Me.LabelRechercher = New System.Windows.Forms.Label()
        Me.ButtonFermer = New System.Windows.Forms.Button()
        Me.ComboBoxJoueurValeur = New System.Windows.Forms.ComboBox()
        Me.ButtonTri = New System.Windows.Forms.Button()
        Me.ListBoxTempsTotal = New System.Windows.Forms.ListBox()
        Me.ListBoxNbParties = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.ListBoxScores = New System.Windows.Forms.ListBox()
        Me.ListBoxNoms = New System.Windows.Forms.ListBox()
        Me.LabelNbParties = New System.Windows.Forms.Label()
        Me.LabelTempsTotal = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelMaxValeur = New System.Windows.Forms.Label()
        Me.labelMinValeur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonQuitter
        '
        Me.buttonQuitter.Location = New System.Drawing.Point(296, 371)
        Me.buttonQuitter.Name = "buttonQuitter"
        Me.buttonQuitter.Size = New System.Drawing.Size(110, 23)
        Me.buttonQuitter.TabIndex = 7
        Me.buttonQuitter.Text = "Quitter"
        Me.buttonQuitter.UseVisualStyleBackColor = True
        '
        'buttonRejouer
        '
        Me.buttonRejouer.Location = New System.Drawing.Point(24, 371)
        Me.buttonRejouer.Name = "buttonRejouer"
        Me.buttonRejouer.Size = New System.Drawing.Size(110, 23)
        Me.buttonRejouer.TabIndex = 8
        Me.buttonRejouer.Text = "Rejouer"
        Me.buttonRejouer.UseVisualStyleBackColor = True
        '
        'LabelRechercher
        '
        Me.LabelRechercher.AutoSize = True
        Me.LabelRechercher.Location = New System.Drawing.Point(29, 292)
        Me.LabelRechercher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRechercher.Name = "LabelRechercher"
        Me.LabelRechercher.Size = New System.Drawing.Size(63, 13)
        Me.LabelRechercher.TabIndex = 36
        Me.LabelRechercher.Text = "Rechercher"
        '
        'ButtonFermer
        '
        Me.ButtonFermer.Location = New System.Drawing.Point(293, 74)
        Me.ButtonFermer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonFermer.Name = "ButtonFermer"
        Me.ButtonFermer.Size = New System.Drawing.Size(70, 24)
        Me.ButtonFermer.TabIndex = 35
        Me.ButtonFermer.Text = "Fermer"
        Me.ButtonFermer.UseVisualStyleBackColor = True
        '
        'ComboBoxJoueurValeur
        '
        Me.ComboBoxJoueurValeur.FormattingEnabled = True
        Me.ComboBoxJoueurValeur.Location = New System.Drawing.Point(103, 292)
        Me.ComboBoxJoueurValeur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxJoueurValeur.Name = "ComboBoxJoueurValeur"
        Me.ComboBoxJoueurValeur.Size = New System.Drawing.Size(51, 21)
        Me.ComboBoxJoueurValeur.TabIndex = 34
        '
        'ButtonTri
        '
        Me.ButtonTri.Location = New System.Drawing.Point(193, 74)
        Me.ButtonTri.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonTri.Name = "ButtonTri"
        Me.ButtonTri.Size = New System.Drawing.Size(71, 24)
        Me.ButtonTri.TabIndex = 33
        Me.ButtonTri.Text = "Tri"
        Me.ButtonTri.UseVisualStyleBackColor = True
        '
        'ListBoxTempsTotal
        '
        Me.ListBoxTempsTotal.BackColor = System.Drawing.SystemColors.Window
        Me.ListBoxTempsTotal.FormattingEnabled = True
        Me.ListBoxTempsTotal.Location = New System.Drawing.Point(282, 273)
        Me.ListBoxTempsTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxTempsTotal.Name = "ListBoxTempsTotal"
        Me.ListBoxTempsTotal.Size = New System.Drawing.Size(117, 56)
        Me.ListBoxTempsTotal.TabIndex = 32
        '
        'ListBoxNbParties
        '
        Me.ListBoxNbParties.FormattingEnabled = True
        Me.ListBoxNbParties.Location = New System.Drawing.Point(282, 155)
        Me.ListBoxNbParties.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxNbParties.Name = "ListBoxNbParties"
        Me.ListBoxNbParties.Size = New System.Drawing.Size(90, 56)
        Me.ListBoxNbParties.TabIndex = 31
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.Location = New System.Drawing.Point(193, 155)
        Me.ListBoxTemps.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(81, 56)
        Me.ListBoxTemps.TabIndex = 30
        '
        'ListBoxScores
        '
        Me.ListBoxScores.FormattingEnabled = True
        Me.ListBoxScores.Location = New System.Drawing.Point(92, 155)
        Me.ListBoxScores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxScores.Name = "ListBoxScores"
        Me.ListBoxScores.Size = New System.Drawing.Size(81, 56)
        Me.ListBoxScores.TabIndex = 29
        '
        'ListBoxNoms
        '
        Me.ListBoxNoms.FormattingEnabled = True
        Me.ListBoxNoms.Location = New System.Drawing.Point(8, 155)
        Me.ListBoxNoms.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxNoms.Name = "ListBoxNoms"
        Me.ListBoxNoms.Size = New System.Drawing.Size(81, 56)
        Me.ListBoxNoms.TabIndex = 28
        '
        'LabelNbParties
        '
        Me.LabelNbParties.AutoSize = True
        Me.LabelNbParties.Location = New System.Drawing.Point(291, 131)
        Me.LabelNbParties.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNbParties.Name = "LabelNbParties"
        Me.LabelNbParties.Size = New System.Drawing.Size(39, 13)
        Me.LabelNbParties.TabIndex = 27
        Me.LabelNbParties.Text = "Parties"
        '
        'LabelTempsTotal
        '
        Me.LabelTempsTotal.AutoSize = True
        Me.LabelTempsTotal.Location = New System.Drawing.Point(190, 132)
        Me.LabelTempsTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTempsTotal.Name = "LabelTempsTotal"
        Me.LabelTempsTotal.Size = New System.Drawing.Size(39, 13)
        Me.LabelTempsTotal.TabIndex = 26
        Me.LabelTempsTotal.Text = "Temps"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(118, 132)
        Me.LabelScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(35, 13)
        Me.LabelScore.TabIndex = 25
        Me.LabelScore.Text = "Score"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(29, 132)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 24
        Me.LabelNom.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tableau des scores"
        '
        'labelMaxValeur
        '
        Me.labelMaxValeur.AutoSize = True
        Me.labelMaxValeur.Location = New System.Drawing.Point(19, 238)
        Me.labelMaxValeur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelMaxValeur.Name = "labelMaxValeur"
        Me.labelMaxValeur.Size = New System.Drawing.Size(27, 13)
        Me.labelMaxValeur.TabIndex = 37
        Me.labelMaxValeur.Text = "Max"
        '
        'labelMinValeur
        '
        Me.labelMinValeur.AutoSize = True
        Me.labelMinValeur.Location = New System.Drawing.Point(83, 238)
        Me.labelMinValeur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelMinValeur.Name = "labelMinValeur"
        Me.labelMinValeur.Size = New System.Drawing.Size(24, 13)
        Me.labelMinValeur.TabIndex = 38
        Me.labelMinValeur.Text = "Min"
        '
        'formScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 422)
        Me.Controls.Add(Me.labelMinValeur)
        Me.Controls.Add(Me.labelMaxValeur)
        Me.Controls.Add(Me.LabelRechercher)
        Me.Controls.Add(Me.ButtonFermer)
        Me.Controls.Add(Me.ComboBoxJoueurValeur)
        Me.Controls.Add(Me.ButtonTri)
        Me.Controls.Add(Me.ListBoxTempsTotal)
        Me.Controls.Add(Me.ListBoxNbParties)
        Me.Controls.Add(Me.ListBoxTemps)
        Me.Controls.Add(Me.ListBoxScores)
        Me.Controls.Add(Me.ListBoxNoms)
        Me.Controls.Add(Me.LabelNbParties)
        Me.Controls.Add(Me.LabelTempsTotal)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonRejouer)
        Me.Controls.Add(Me.buttonQuitter)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formScore"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonQuitter As Button
    Friend WithEvents buttonRejouer As Button
    Friend WithEvents LabelRechercher As Label
    Friend WithEvents ButtonFermer As Button
    Friend WithEvents ComboBoxJoueurValeur As ComboBox
    Friend WithEvents ButtonTri As Button
    Friend WithEvents ListBoxTempsTotal As ListBox
    Friend WithEvents ListBoxNbParties As ListBox
    Friend WithEvents ListBoxTemps As ListBox
    Friend WithEvents ListBoxScores As ListBox
    Friend WithEvents ListBoxNoms As ListBox
    Friend WithEvents LabelNbParties As Label
    Friend WithEvents LabelTempsTotal As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelMaxValeur As Label
    Friend WithEvents labelMinValeur As Label
End Class
