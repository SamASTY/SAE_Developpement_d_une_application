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
        Me.comboBoxJoueurValeur = New System.Windows.Forms.ComboBox()
        Me.labelJoueur = New System.Windows.Forms.Label()
        Me.labelMin = New System.Windows.Forms.Label()
        Me.labelMax = New System.Windows.Forms.Label()
        Me.labelNbrePartie = New System.Windows.Forms.Label()
        Me.labelTemps = New System.Windows.Forms.Label()
        Me.buttonQuitter = New System.Windows.Forms.Button()
        Me.buttonRejouer = New System.Windows.Forms.Button()
        Me.labelNbrePartieValeur = New System.Windows.Forms.Label()
        Me.labelTempsValeur = New System.Windows.Forms.Label()
        Me.labelMinValeur = New System.Windows.Forms.Label()
        Me.labelMaxValeur = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBoxJoueurValeur
        '
        Me.comboBoxJoueurValeur.FormattingEnabled = True
        Me.comboBoxJoueurValeur.Location = New System.Drawing.Point(89, 24)
        Me.comboBoxJoueurValeur.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxJoueurValeur.Name = "comboBoxJoueurValeur"
        Me.comboBoxJoueurValeur.Size = New System.Drawing.Size(94, 21)
        Me.comboBoxJoueurValeur.TabIndex = 0
        '
        'labelJoueur
        '
        Me.labelJoueur.AutoSize = True
        Me.labelJoueur.Location = New System.Drawing.Point(35, 27)
        Me.labelJoueur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelJoueur.Name = "labelJoueur"
        Me.labelJoueur.Size = New System.Drawing.Size(48, 13)
        Me.labelJoueur.TabIndex = 1
        Me.labelJoueur.Text = "Joueur  :"
        '
        'labelMin
        '
        Me.labelMin.AutoSize = True
        Me.labelMin.Location = New System.Drawing.Point(35, 85)
        Me.labelMin.Name = "labelMin"
        Me.labelMin.Size = New System.Drawing.Size(30, 13)
        Me.labelMin.TabIndex = 2
        Me.labelMin.Text = "Min :"
        '
        'labelMax
        '
        Me.labelMax.AutoSize = True
        Me.labelMax.Location = New System.Drawing.Point(35, 60)
        Me.labelMax.Name = "labelMax"
        Me.labelMax.Size = New System.Drawing.Size(33, 13)
        Me.labelMax.TabIndex = 3
        Me.labelMax.Text = "Max :"
        '
        'labelNbrePartie
        '
        Me.labelNbrePartie.AutoSize = True
        Me.labelNbrePartie.Location = New System.Drawing.Point(35, 111)
        Me.labelNbrePartie.Name = "labelNbrePartie"
        Me.labelNbrePartie.Size = New System.Drawing.Size(39, 13)
        Me.labelNbrePartie.TabIndex = 4
        Me.labelNbrePartie.Text = "Parties"
        '
        'labelTemps
        '
        Me.labelTemps.AutoSize = True
        Me.labelTemps.Location = New System.Drawing.Point(35, 139)
        Me.labelTemps.Name = "labelTemps"
        Me.labelTemps.Size = New System.Drawing.Size(77, 13)
        Me.labelTemps.TabIndex = 5
        Me.labelTemps.Text = "Temps de jeu :"
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
        'labelNbrePartieValeur
        '
        Me.labelNbrePartieValeur.AutoSize = True
        Me.labelNbrePartieValeur.Location = New System.Drawing.Point(84, 111)
        Me.labelNbrePartieValeur.Name = "labelNbrePartieValeur"
        Me.labelNbrePartieValeur.Size = New System.Drawing.Size(10, 13)
        Me.labelNbrePartieValeur.TabIndex = 11
        Me.labelNbrePartieValeur.Text = ","
        Me.labelNbrePartieValeur.Visible = False
        '
        'labelTempsValeur
        '
        Me.labelTempsValeur.AutoSize = True
        Me.labelTempsValeur.Location = New System.Drawing.Point(118, 139)
        Me.labelTempsValeur.Name = "labelTempsValeur"
        Me.labelTempsValeur.Size = New System.Drawing.Size(10, 13)
        Me.labelTempsValeur.TabIndex = 12
        Me.labelTempsValeur.Text = ","
        Me.labelTempsValeur.Visible = False
        '
        'labelMinValeur
        '
        Me.labelMinValeur.AutoSize = True
        Me.labelMinValeur.Location = New System.Drawing.Point(71, 85)
        Me.labelMinValeur.Name = "labelMinValeur"
        Me.labelMinValeur.Size = New System.Drawing.Size(10, 13)
        Me.labelMinValeur.TabIndex = 13
        Me.labelMinValeur.Text = ","
        Me.labelMinValeur.Visible = False
        '
        'labelMaxValeur
        '
        Me.labelMaxValeur.AutoSize = True
        Me.labelMaxValeur.Location = New System.Drawing.Point(71, 60)
        Me.labelMaxValeur.Name = "labelMaxValeur"
        Me.labelMaxValeur.Size = New System.Drawing.Size(10, 13)
        Me.labelMaxValeur.TabIndex = 14
        Me.labelMaxValeur.Text = ","
        Me.labelMaxValeur.Visible = False
        '
        'formScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 422)
        Me.Controls.Add(Me.labelMaxValeur)
        Me.Controls.Add(Me.labelMinValeur)
        Me.Controls.Add(Me.labelTempsValeur)
        Me.Controls.Add(Me.labelNbrePartieValeur)
        Me.Controls.Add(Me.buttonRejouer)
        Me.Controls.Add(Me.buttonQuitter)
        Me.Controls.Add(Me.labelTemps)
        Me.Controls.Add(Me.labelNbrePartie)
        Me.Controls.Add(Me.labelMax)
        Me.Controls.Add(Me.labelMin)
        Me.Controls.Add(Me.labelJoueur)
        Me.Controls.Add(Me.comboBoxJoueurValeur)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formScore"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboBoxJoueurValeur As ComboBox
    Friend WithEvents labelJoueur As Label
    Friend WithEvents labelMin As Label
    Friend WithEvents labelMax As Label
    Friend WithEvents labelNbrePartie As Label
    Friend WithEvents labelTemps As Label
    Friend WithEvents buttonQuitter As Button
    Friend WithEvents buttonRejouer As Button
    Friend WithEvents labelNbrePartieValeur As Label
    Friend WithEvents labelTempsValeur As Label
    Friend WithEvents labelMinValeur As Label
    Friend WithEvents labelMaxValeur As Label
End Class
