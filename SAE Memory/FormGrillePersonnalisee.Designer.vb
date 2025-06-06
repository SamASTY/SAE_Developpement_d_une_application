<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrillePersonnalisee
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
        Me.TableLayoutPrevisualisation = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nudTempsMax = New System.Windows.Forms.NumericUpDown()
        Me.nudColonnes = New System.Windows.Forms.NumericUpDown()
        Me.nudCartesParCarre = New System.Windows.Forms.NumericUpDown()
        Me.nudLignes = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.nudTempsMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudColonnes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCartesParCarre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLignes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPrevisualisation
        '
        Me.TableLayoutPrevisualisation.ColumnCount = 2
        Me.TableLayoutPrevisualisation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.Location = New System.Drawing.Point(25, 139)
        Me.TableLayoutPrevisualisation.Name = "TableLayoutPrevisualisation"
        Me.TableLayoutPrevisualisation.RowCount = 2
        Me.TableLayoutPrevisualisation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.Size = New System.Drawing.Size(486, 393)
        Me.TableLayoutPrevisualisation.TabIndex = 1
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(3, 14)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(160, 41)
        Me.btnEnregistrer.TabIndex = 5
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(3, 140)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(160, 41)
        Me.btnRetour.TabIndex = 6
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnLancer
        '
        Me.btnLancer.BackColor = System.Drawing.Color.White
        Me.btnLancer.Location = New System.Drawing.Point(3, 76)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(160, 41)
        Me.btnLancer.TabIndex = 7
        Me.btnLancer.Text = "Lancer"
        Me.btnLancer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.nudTempsMax)
        Me.Panel1.Controls.Add(Me.nudColonnes)
        Me.Panel1.Controls.Add(Me.nudCartesParCarre)
        Me.Panel1.Controls.Add(Me.nudLignes)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 100)
        Me.Panel1.TabIndex = 8
        '
        'nudTempsMax
        '
        Me.nudTempsMax.Location = New System.Drawing.Point(640, 51)
        Me.nudTempsMax.Name = "nudTempsMax"
        Me.nudTempsMax.Size = New System.Drawing.Size(115, 26)
        Me.nudTempsMax.TabIndex = 8
        '
        'nudColonnes
        '
        Me.nudColonnes.Location = New System.Drawing.Point(230, 51)
        Me.nudColonnes.Name = "nudColonnes"
        Me.nudColonnes.Size = New System.Drawing.Size(115, 26)
        Me.nudColonnes.TabIndex = 7
        '
        'nudCartesParCarre
        '
        Me.nudCartesParCarre.Location = New System.Drawing.Point(434, 51)
        Me.nudCartesParCarre.Name = "nudCartesParCarre"
        Me.nudCartesParCarre.Size = New System.Drawing.Size(115, 26)
        Me.nudCartesParCarre.TabIndex = 6
        '
        'nudLignes
        '
        Me.nudLignes.Location = New System.Drawing.Point(33, 51)
        Me.nudLignes.Name = "nudLignes"
        Me.nudLignes.Size = New System.Drawing.Size(115, 26)
        Me.nudLignes.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Numero de ligne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Carte par carrée"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Temps max"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Numero de colonne"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRetour)
        Me.Panel2.Controls.Add(Me.btnEnregistrer)
        Me.Panel2.Controls.Add(Me.btnLancer)
        Me.Panel2.Location = New System.Drawing.Point(555, 251)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 199)
        Me.Panel2.TabIndex = 9
        '
        'FormGrillePersonnalisee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(800, 571)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPrevisualisation)
        Me.Name = "FormGrillePersonnalisee"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudTempsMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudColonnes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCartesParCarre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLignes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPrevisualisation As TableLayoutPanel
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnLancer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudTempsMax As NumericUpDown
    Friend WithEvents nudColonnes As NumericUpDown
    Friend WithEvents nudCartesParCarre As NumericUpDown
    Friend WithEvents nudLignes As NumericUpDown
    Friend WithEvents Panel2 As Panel
End Class
