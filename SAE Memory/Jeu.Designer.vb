<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormJeu
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
        Me.lblJoueur = New System.Windows.Forms.Label()
        Me.lblPseudo = New System.Windows.Forms.Label()
        Me.lblTemps = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTempsValeur = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreValeur = New System.Windows.Forms.Label()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.TableLayoutPlateau = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlJeu = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.pnlJeu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJoueur
        '
        Me.lblJoueur.AutoSize = True
        Me.lblJoueur.Location = New System.Drawing.Point(24, 22)
        Me.lblJoueur.Name = "lblJoueur"
        Me.lblJoueur.Size = New System.Drawing.Size(39, 13)
        Me.lblJoueur.TabIndex = 0
        Me.lblJoueur.Text = "Joueur"
        '
        'lblPseudo
        '
        Me.lblPseudo.AutoSize = True
        Me.lblPseudo.Location = New System.Drawing.Point(78, 22)
        Me.lblPseudo.Name = "lblPseudo"
        Me.lblPseudo.Size = New System.Drawing.Size(58, 13)
        Me.lblPseudo.TabIndex = 1
        Me.lblPseudo.Text = "Nomjoueur"
        '
        'lblTemps
        '
        Me.lblTemps.AutoSize = True
        Me.lblTemps.Location = New System.Drawing.Point(156, 22)
        Me.lblTemps.Name = "lblTemps"
        Me.lblTemps.Size = New System.Drawing.Size(80, 13)
        Me.lblTemps.TabIndex = 2
        Me.lblTemps.Text = "Temps restant :"
        '
        'btnAbandon
        '
        Me.btnAbandon.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAbandon.Location = New System.Drawing.Point(367, 14)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(110, 29)
        Me.btnAbandon.TabIndex = 4
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'lblTempsValeur
        '
        Me.lblTempsValeur.AutoSize = True
        Me.lblTempsValeur.Location = New System.Drawing.Point(245, 22)
        Me.lblTempsValeur.Name = "lblTempsValeur"
        Me.lblTempsValeur.Size = New System.Drawing.Size(13, 13)
        Me.lblTempsValeur.TabIndex = 3
        Me.lblTempsValeur.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(286, 22)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(35, 13)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score"
        '
        'lblScoreValeur
        '
        Me.lblScoreValeur.AutoSize = True
        Me.lblScoreValeur.Location = New System.Drawing.Point(341, 22)
        Me.lblScoreValeur.Name = "lblScoreValeur"
        Me.lblScoreValeur.Size = New System.Drawing.Size(13, 13)
        Me.lblScoreValeur.TabIndex = 12
        Me.lblScoreValeur.Text = "0"
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPause.Location = New System.Drawing.Point(485, 14)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(110, 29)
        Me.btnPause.TabIndex = 14
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'TableLayoutPlateau
        '
        Me.TableLayoutPlateau.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPlateau.ColumnCount = 2
        Me.TableLayoutPlateau.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPlateau.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPlateau.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPlateau.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPlateau.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPlateau.Name = "TableLayoutPlateau"
        Me.TableLayoutPlateau.RowCount = 2
        Me.TableLayoutPlateau.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPlateau.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPlateau.Size = New System.Drawing.Size(601, 708)
        Me.TableLayoutPlateau.TabIndex = 15
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblTempsValeur)
        Me.pnlTop.Controls.Add(Me.lblTemps)
        Me.pnlTop.Controls.Add(Me.btnAbandon)
        Me.pnlTop.Controls.Add(Me.lblScore)
        Me.pnlTop.Controls.Add(Me.lblPseudo)
        Me.pnlTop.Controls.Add(Me.lblJoueur)
        Me.pnlTop.Controls.Add(Me.lblScoreValeur)
        Me.pnlTop.Controls.Add(Me.btnPause)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(601, 64)
        Me.pnlTop.TabIndex = 16
        '
        'pnlJeu
        '
        Me.pnlJeu.Controls.Add(Me.TableLayoutPlateau)
        Me.pnlJeu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJeu.Location = New System.Drawing.Point(0, 64)
        Me.pnlJeu.Name = "pnlJeu"
        Me.pnlJeu.Size = New System.Drawing.Size(601, 708)
        Me.pnlJeu.TabIndex = 15
        '
        'FormJeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 772)
        Me.Controls.Add(Me.pnlJeu)
        Me.Controls.Add(Me.pnlTop)
        Me.Name = "FormJeu"
        Me.Tag = ""
        Me.Text = "Memory"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlJeu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblJoueur As Label
    Friend WithEvents lblPseudo As Label
    Friend WithEvents lblTemps As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents lblTempsValeur As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreValeur As Label
    Friend WithEvents btnPause As Button
    Friend WithEvents TableLayoutPlateau As TableLayoutPanel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlJeu As Panel
End Class
