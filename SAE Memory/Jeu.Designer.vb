<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPseudo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAbandon = New System.Windows.Forms.Button()
        Me.GroupBoxPlateau = New System.Windows.Forms.GroupBox()
        Me.L_Carte20 = New System.Windows.Forms.Label()
        Me.L_Carte15 = New System.Windows.Forms.Label()
        Me.L_Carte10 = New System.Windows.Forms.Label()
        Me.L_Carte05 = New System.Windows.Forms.Label()
        Me.L_Carte19 = New System.Windows.Forms.Label()
        Me.L_Carte14 = New System.Windows.Forms.Label()
        Me.L_Carte09 = New System.Windows.Forms.Label()
        Me.L_Carte04 = New System.Windows.Forms.Label()
        Me.L_Carte18 = New System.Windows.Forms.Label()
        Me.L_Carte13 = New System.Windows.Forms.Label()
        Me.L_Carte08 = New System.Windows.Forms.Label()
        Me.L_Carte03 = New System.Windows.Forms.Label()
        Me.L_Carte17 = New System.Windows.Forms.Label()
        Me.L_Carte12 = New System.Windows.Forms.Label()
        Me.L_Carte07 = New System.Windows.Forms.Label()
        Me.L_Carte02 = New System.Windows.Forms.Label()
        Me.L_Carte16 = New System.Windows.Forms.Label()
        Me.L_Carte11 = New System.Windows.Forms.Label()
        Me.L_Carte06 = New System.Windows.Forms.Label()
        Me.L_Carte01 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.LabelCompteurScore = New System.Windows.Forms.Label()
        Me.GroupBoxPlateau.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Joueur"
        '
        'LabelPseudo
        '
        Me.LabelPseudo.AutoSize = True
        Me.LabelPseudo.Location = New System.Drawing.Point(93, 22)
        Me.LabelPseudo.Name = "LabelPseudo"
        Me.LabelPseudo.Size = New System.Drawing.Size(58, 13)
        Me.LabelPseudo.TabIndex = 1
        Me.LabelPseudo.Text = "Nomjoueur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Temps restant :"
        '
        'ButtonAbandon
        '
        Me.ButtonAbandon.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonAbandon.Location = New System.Drawing.Point(525, 22)
        Me.ButtonAbandon.Name = "ButtonAbandon"
        Me.ButtonAbandon.Size = New System.Drawing.Size(110, 29)
        Me.ButtonAbandon.TabIndex = 4
        Me.ButtonAbandon.Text = "Abandon"
        Me.ButtonAbandon.UseVisualStyleBackColor = False
        '
        'GroupBoxPlateau
        '
        Me.GroupBoxPlateau.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte20)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte15)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte10)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte05)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte19)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte14)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte09)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte04)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte18)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte13)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte08)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte03)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte17)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte12)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte07)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte02)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte16)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte11)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte06)
        Me.GroupBoxPlateau.Controls.Add(Me.L_Carte01)
        Me.GroupBoxPlateau.Location = New System.Drawing.Point(26, 58)
        Me.GroupBoxPlateau.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxPlateau.Name = "GroupBoxPlateau"
        Me.GroupBoxPlateau.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxPlateau.Size = New System.Drawing.Size(614, 539)
        Me.GroupBoxPlateau.TabIndex = 10
        Me.GroupBoxPlateau.TabStop = False
        '
        'L_Carte20
        '
        Me.L_Carte20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte20.Location = New System.Drawing.Point(499, 412)
        Me.L_Carte20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte20.Name = "L_Carte20"
        Me.L_Carte20.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte20.TabIndex = 28
        '
        'L_Carte15
        '
        Me.L_Carte15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte15.Location = New System.Drawing.Point(499, 280)
        Me.L_Carte15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte15.Name = "L_Carte15"
        Me.L_Carte15.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte15.TabIndex = 27
        '
        'L_Carte10
        '
        Me.L_Carte10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte10.Location = New System.Drawing.Point(499, 148)
        Me.L_Carte10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte10.Name = "L_Carte10"
        Me.L_Carte10.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte10.TabIndex = 26
        '
        'L_Carte05
        '
        Me.L_Carte05.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte05.Location = New System.Drawing.Point(499, 22)
        Me.L_Carte05.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte05.Name = "L_Carte05"
        Me.L_Carte05.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte05.TabIndex = 25
        '
        'L_Carte19
        '
        Me.L_Carte19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte19.Location = New System.Drawing.Point(381, 412)
        Me.L_Carte19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte19.Name = "L_Carte19"
        Me.L_Carte19.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte19.TabIndex = 24
        '
        'L_Carte14
        '
        Me.L_Carte14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte14.Location = New System.Drawing.Point(381, 280)
        Me.L_Carte14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte14.Name = "L_Carte14"
        Me.L_Carte14.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte14.TabIndex = 23
        '
        'L_Carte09
        '
        Me.L_Carte09.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte09.Location = New System.Drawing.Point(381, 148)
        Me.L_Carte09.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte09.Name = "L_Carte09"
        Me.L_Carte09.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte09.TabIndex = 22
        '
        'L_Carte04
        '
        Me.L_Carte04.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte04.Location = New System.Drawing.Point(381, 22)
        Me.L_Carte04.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte04.Name = "L_Carte04"
        Me.L_Carte04.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte04.TabIndex = 21
        '
        'L_Carte18
        '
        Me.L_Carte18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte18.Location = New System.Drawing.Point(260, 412)
        Me.L_Carte18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte18.Name = "L_Carte18"
        Me.L_Carte18.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte18.TabIndex = 20
        '
        'L_Carte13
        '
        Me.L_Carte13.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte13.Location = New System.Drawing.Point(260, 280)
        Me.L_Carte13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte13.Name = "L_Carte13"
        Me.L_Carte13.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte13.TabIndex = 19
        '
        'L_Carte08
        '
        Me.L_Carte08.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte08.Location = New System.Drawing.Point(260, 148)
        Me.L_Carte08.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte08.Name = "L_Carte08"
        Me.L_Carte08.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte08.TabIndex = 18
        '
        'L_Carte03
        '
        Me.L_Carte03.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte03.Location = New System.Drawing.Point(260, 22)
        Me.L_Carte03.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte03.Name = "L_Carte03"
        Me.L_Carte03.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte03.TabIndex = 17
        '
        'L_Carte17
        '
        Me.L_Carte17.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte17.Location = New System.Drawing.Point(136, 412)
        Me.L_Carte17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte17.Name = "L_Carte17"
        Me.L_Carte17.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte17.TabIndex = 16
        '
        'L_Carte12
        '
        Me.L_Carte12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte12.Location = New System.Drawing.Point(136, 280)
        Me.L_Carte12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte12.Name = "L_Carte12"
        Me.L_Carte12.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte12.TabIndex = 15
        '
        'L_Carte07
        '
        Me.L_Carte07.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte07.Location = New System.Drawing.Point(136, 148)
        Me.L_Carte07.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte07.Name = "L_Carte07"
        Me.L_Carte07.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte07.TabIndex = 14
        '
        'L_Carte02
        '
        Me.L_Carte02.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte02.Location = New System.Drawing.Point(136, 22)
        Me.L_Carte02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte02.Name = "L_Carte02"
        Me.L_Carte02.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte02.TabIndex = 13
        '
        'L_Carte16
        '
        Me.L_Carte16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte16.Location = New System.Drawing.Point(14, 412)
        Me.L_Carte16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte16.Name = "L_Carte16"
        Me.L_Carte16.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte16.TabIndex = 12
        '
        'L_Carte11
        '
        Me.L_Carte11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte11.Location = New System.Drawing.Point(14, 280)
        Me.L_Carte11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte11.Name = "L_Carte11"
        Me.L_Carte11.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte11.TabIndex = 11
        '
        'L_Carte06
        '
        Me.L_Carte06.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte06.Location = New System.Drawing.Point(14, 148)
        Me.L_Carte06.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte06.Name = "L_Carte06"
        Me.L_Carte06.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte06.TabIndex = 10
        '
        'L_Carte01
        '
        Me.L_Carte01.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.L_Carte01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Carte01.Location = New System.Drawing.Point(14, 22)
        Me.L_Carte01.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.L_Carte01.Name = "L_Carte01"
        Me.L_Carte01.Size = New System.Drawing.Size(97, 108)
        Me.L_Carte01.TabIndex = 9
        '
        'Timer
        '
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(355, 22)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(13, 13)
        Me.LabelTimer.TabIndex = 3
        Me.LabelTimer.Text = "0"
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Location = New System.Drawing.Point(416, 22)
        Me.LabelScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(35, 13)
        Me.LabelScore.TabIndex = 11
        Me.LabelScore.Text = "Score"
        '
        'LabelCompteurScore
        '
        Me.LabelCompteurScore.AutoSize = True
        Me.LabelCompteurScore.Location = New System.Drawing.Point(456, 22)
        Me.LabelCompteurScore.Name = "LabelCompteurScore"
        Me.LabelCompteurScore.Size = New System.Drawing.Size(13, 13)
        Me.LabelCompteurScore.TabIndex = 12
        Me.LabelCompteurScore.Text = "0"
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 626)
        Me.Controls.Add(Me.LabelCompteurScore)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.ButtonAbandon)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelPseudo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxPlateau)
        Me.Name = "Jeu"
        Me.Text = "Form2"
        Me.GroupBoxPlateau.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelPseudo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAbandon As Button
    Friend WithEvents L_Carte01 As Label
    Friend WithEvents GroupBoxPlateau As GroupBox
    Friend WithEvents L_Carte20 As Label
    Friend WithEvents L_Carte15 As Label
    Friend WithEvents L_Carte10 As Label
    Friend WithEvents L_Carte05 As Label
    Friend WithEvents L_Carte19 As Label
    Friend WithEvents L_Carte14 As Label
    Friend WithEvents L_Carte09 As Label
    Friend WithEvents L_Carte04 As Label
    Friend WithEvents L_Carte18 As Label
    Friend WithEvents L_Carte13 As Label
    Friend WithEvents L_Carte08 As Label
    Friend WithEvents L_Carte03 As Label
    Friend WithEvents L_Carte17 As Label
    Friend WithEvents L_Carte12 As Label
    Friend WithEvents L_Carte07 As Label
    Friend WithEvents L_Carte02 As Label
    Friend WithEvents L_Carte16 As Label
    Friend WithEvents L_Carte11 As Label
    Friend WithEvents L_Carte06 As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents LabelScore As Label
    Friend WithEvents LabelCompteurScore As Label
End Class
