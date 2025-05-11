<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.ComboBoxPrenom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonScores = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonJeu = New System.Windows.Forms.Button()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPrenom
        '
        Me.ComboBoxPrenom.FormattingEnabled = True
        Me.ComboBoxPrenom.Location = New System.Drawing.Point(193, 91)
        Me.ComboBoxPrenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxPrenom.Name = "ComboBoxPrenom"
        Me.ComboBoxPrenom.Size = New System.Drawing.Size(180, 28)
        Me.ComboBoxPrenom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pseudo :"
        '
        'ButtonScores
        '
        Me.ButtonScores.Location = New System.Drawing.Point(356, 145)
        Me.ButtonScores.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonScores.Name = "ButtonScores"
        Me.ButtonScores.Size = New System.Drawing.Size(112, 35)
        Me.ButtonScores.TabIndex = 2
        Me.ButtonScores.Text = "Scores"
        Me.ButtonScores.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(51, 145)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(112, 35)
        Me.ButtonQuitter.TabIndex = 3
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonJeu
        '
        Me.ButtonJeu.Enabled = False
        Me.ButtonJeu.Location = New System.Drawing.Point(193, 192)
        Me.ButtonJeu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonJeu.Name = "ButtonJeu"
        Me.ButtonJeu.Size = New System.Drawing.Size(112, 35)
        Me.ButtonJeu.TabIndex = 4
        Me.ButtonJeu.Text = "Jouer"
        Me.ButtonJeu.UseVisualStyleBackColor = True
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.Location = New System.Drawing.Point(12, 5)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(198, 55)
        Me.LblTitre.TabIndex = 5
        Me.LblTitre.Text = "Memory"
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 351)
        Me.Controls.Add(Me.LblTitre)
        Me.Controls.Add(Me.ButtonJeu)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonScores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxPrenom)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Accueil"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPrenom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonScores As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonJeu As Button
    Friend WithEvents LblTitre As Label
End Class
