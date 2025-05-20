<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.cmbPrenom = New System.Windows.Forms.ComboBox()
        Me.lblPseudo = New System.Windows.Forms.Label()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnJeu = New System.Windows.Forms.Button()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.BtnMultijoueur = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbPrenom
        '
        Me.cmbPrenom.FormattingEnabled = True
        Me.cmbPrenom.Location = New System.Drawing.Point(151, 91)
        Me.cmbPrenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbPrenom.Name = "cmbPrenom"
        Me.cmbPrenom.Size = New System.Drawing.Size(180, 28)
        Me.cmbPrenom.TabIndex = 0
        '
        'lblPseudo
        '
        Me.lblPseudo.AutoSize = True
        Me.lblPseudo.Location = New System.Drawing.Point(74, 95)
        Me.lblPseudo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPseudo.Name = "lblPseudo"
        Me.lblPseudo.Size = New System.Drawing.Size(71, 20)
        Me.lblPseudo.TabIndex = 1
        Me.lblPseudo.Text = "Pseudo :"
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(356, 88)
        Me.btnScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(112, 35)
        Me.btnScores.TabIndex = 2
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(356, 268)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(112, 35)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnJeu
        '
        Me.btnJeu.Enabled = False
        Me.btnJeu.Location = New System.Drawing.Point(29, 268)
        Me.btnJeu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnJeu.Name = "btnJeu"
        Me.btnJeu.Size = New System.Drawing.Size(112, 35)
        Me.btnJeu.TabIndex = 4
        Me.btnJeu.Text = "Jouer"
        Me.btnJeu.UseVisualStyleBackColor = True
        '
        'lblMemory
        '
        Me.lblMemory.AutoSize = True
        Me.lblMemory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemory.Location = New System.Drawing.Point(12, 5)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(198, 55)
        Me.lblMemory.TabIndex = 5
        Me.lblMemory.Text = "Memory"
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(190, 268)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(112, 35)
        Me.btnOptions.TabIndex = 6
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'BtnMultijoueur
        '
        Me.BtnMultijoueur.Location = New System.Drawing.Point(22, 334)
        Me.BtnMultijoueur.Name = "BtnMultijoueur"
        Me.BtnMultijoueur.Size = New System.Drawing.Size(143, 37)
        Me.BtnMultijoueur.TabIndex = 7
        Me.BtnMultijoueur.Text = "Multijoueur"
        Me.BtnMultijoueur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMultijoueur.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 383)
        Me.Controls.Add(Me.BtnMultijoueur)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.btnJeu)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.lblPseudo)
        Me.Controls.Add(Me.cmbPrenom)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPrenom As ComboBox
    Friend WithEvents lblPseudo As Label
    Friend WithEvents btnScores As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnJeu As Button
    Friend WithEvents lblMemory As Label
    Friend WithEvents btnOptions As Button
    Friend WithEvents BtnMultijoueur As Button
End Class
