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
        Me.ComboBoxDifficulte = New System.Windows.Forms.ComboBox()
        Me.PanelCartes = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbloptions = New System.Windows.Forms.Label()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.ButtonCommencer = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblJ2 = New System.Windows.Forms.Label()
        Me.lblJ1 = New System.Windows.Forms.Label()
        Me.cmbox_Joueur2 = New System.Windows.Forms.ComboBox()
        Me.cmbox_Joueur1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblChoix = New System.Windows.Forms.Label()
        Me.BtnRegles = New System.Windows.Forms.Button()
        Me.PanelCartes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxDifficulte
        '
        Me.ComboBoxDifficulte.FormattingEnabled = True
        Me.ComboBoxDifficulte.Location = New System.Drawing.Point(295, 28)
        Me.ComboBoxDifficulte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxDifficulte.Name = "ComboBoxDifficulte"
        Me.ComboBoxDifficulte.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxDifficulte.TabIndex = 6
        '
        'PanelCartes
        '
        Me.PanelCartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelCartes.Controls.Add(Me.Label1)
        Me.PanelCartes.Controls.Add(Me.Lbloptions)
        Me.PanelCartes.Controls.Add(Me.ComboBoxDifficulte)
        Me.PanelCartes.Location = New System.Drawing.Point(12, 286)
        Me.PanelCartes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelCartes.Name = "PanelCartes"
        Me.PanelCartes.Size = New System.Drawing.Size(551, 75)
        Me.PanelCartes.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Choix de la difficulté"
        '
        'Lbloptions
        '
        Me.Lbloptions.AutoSize = True
        Me.Lbloptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbloptions.Location = New System.Drawing.Point(3, 11)
        Me.Lbloptions.Name = "Lbloptions"
        Me.Lbloptions.Size = New System.Drawing.Size(104, 29)
        Me.Lbloptions.TabIndex = 0
        Me.Lbloptions.Text = "Options"
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 20
        Me.lstScores.Location = New System.Drawing.Point(36, 65)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(134, 84)
        Me.lstScores.TabIndex = 11
        '
        'ButtonCommencer
        '
        Me.ButtonCommencer.Location = New System.Drawing.Point(14, 15)
        Me.ButtonCommencer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCommencer.Name = "ButtonCommencer"
        Me.ButtonCommencer.Size = New System.Drawing.Size(111, 39)
        Me.ButtonCommencer.TabIndex = 12
        Me.ButtonCommencer.Text = "Commencer"
        Me.ButtonCommencer.UseVisualStyleBackColor = True
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.Location = New System.Drawing.Point(207, 16)
        Me.ButtonAbandonner.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(107, 39)
        Me.ButtonAbandonner.TabIndex = 13
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(411, 16)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(122, 40)
        Me.ButtonRetour.TabIndex = 14
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(5, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(411, 37)
        Me.lblTitre.TabIndex = 19
        Me.lblTitre.Text = "MEMORY MULTIJOUEUR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblChoix)
        Me.Panel1.Controls.Add(Me.LblJ2)
        Me.Panel1.Controls.Add(Me.lblJ1)
        Me.Panel1.Controls.Add(Me.cmbox_Joueur2)
        Me.Panel1.Controls.Add(Me.cmbox_Joueur1)
        Me.Panel1.Location = New System.Drawing.Point(14, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 201)
        Me.Panel1.TabIndex = 28
        '
        'LblJ2
        '
        Me.LblJ2.AutoSize = True
        Me.LblJ2.Location = New System.Drawing.Point(52, 126)
        Me.LblJ2.Name = "LblJ2"
        Me.LblJ2.Size = New System.Drawing.Size(79, 20)
        Me.LblJ2.TabIndex = 31
        Me.LblJ2.Text = "Joueur 2 :"
        '
        'lblJ1
        '
        Me.lblJ1.AutoSize = True
        Me.lblJ1.Location = New System.Drawing.Point(52, 50)
        Me.lblJ1.Name = "lblJ1"
        Me.lblJ1.Size = New System.Drawing.Size(79, 20)
        Me.lblJ1.TabIndex = 30
        Me.lblJ1.Text = "Joueur 1 :"
        '
        'cmbox_Joueur2
        '
        Me.cmbox_Joueur2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbox_Joueur2.FormattingEnabled = True
        Me.cmbox_Joueur2.Location = New System.Drawing.Point(144, 124)
        Me.cmbox_Joueur2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbox_Joueur2.Name = "cmbox_Joueur2"
        Me.cmbox_Joueur2.Size = New System.Drawing.Size(136, 28)
        Me.cmbox_Joueur2.TabIndex = 29
        '
        'cmbox_Joueur1
        '
        Me.cmbox_Joueur1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbox_Joueur1.FormattingEnabled = True
        Me.cmbox_Joueur1.Location = New System.Drawing.Point(144, 46)
        Me.cmbox_Joueur1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbox_Joueur1.Name = "cmbox_Joueur1"
        Me.cmbox_Joueur1.Size = New System.Drawing.Size(136, 28)
        Me.cmbox_Joueur1.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblScore)
        Me.Panel2.Controls.Add(Me.lstScores)
        Me.Panel2.Location = New System.Drawing.Point(351, 68)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 201)
        Me.Panel2.TabIndex = 29
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(18, 16)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(176, 29)
        Me.LblScore.TabIndex = 0
        Me.LblScore.Text = "Score et Stats"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.ButtonCommencer)
        Me.Panel4.Controls.Add(Me.ButtonAbandonner)
        Me.Panel4.Controls.Add(Me.ButtonRetour)
        Me.Panel4.Location = New System.Drawing.Point(12, 375)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(551, 81)
        Me.Panel4.TabIndex = 31
        '
        'LblChoix
        '
        Me.LblChoix.AutoSize = True
        Me.LblChoix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoix.Location = New System.Drawing.Point(3, 0)
        Me.LblChoix.Name = "LblChoix"
        Me.LblChoix.Size = New System.Drawing.Size(223, 29)
        Me.LblChoix.TabIndex = 32
        Me.LblChoix.Text = "Choix des joueurs"
        '
        'BtnRegles
        '
        Me.BtnRegles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRegles.Location = New System.Drawing.Point(438, 12)
        Me.BtnRegles.Name = "BtnRegles"
        Me.BtnRegles.Size = New System.Drawing.Size(125, 40)
        Me.BtnRegles.TabIndex = 32
        Me.BtnRegles.Text = "Regle du jeu"
        Me.BtnRegles.UseVisualStyleBackColor = False
        '
        'FormMultiJoueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(576, 502)
        Me.Controls.Add(Me.BtnRegles)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.PanelCartes)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormMultiJoueur"
        Me.Text = "Form1"
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
    Friend WithEvents ComboBoxDifficulte As ComboBox
    Friend WithEvents PanelCartes As Panel
    Friend WithEvents lstScores As ListBox
    Friend WithEvents ButtonCommencer As Button
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbloptions As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblScore As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbox_Joueur2 As ComboBox
    Friend WithEvents cmbox_Joueur1 As ComboBox
    Friend WithEvents LblJ2 As Label
    Friend WithEvents lblJ1 As Label
    Friend WithEvents LblChoix As Label
    Friend WithEvents BtnRegles As Button
End Class
