<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGrillePersonnalisee
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
        Me.TableLayoutPrevisualisation = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNbreLigne = New System.Windows.Forms.Label()
        Me.nudLignes = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.nudLignes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPrevisualisation
        '
        Me.TableLayoutPrevisualisation.ColumnCount = 2
        Me.TableLayoutPrevisualisation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.Location = New System.Drawing.Point(16, 90)
        Me.TableLayoutPrevisualisation.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPrevisualisation.Name = "TableLayoutPrevisualisation"
        Me.TableLayoutPrevisualisation.RowCount = 2
        Me.TableLayoutPrevisualisation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPrevisualisation.Size = New System.Drawing.Size(324, 255)
        Me.TableLayoutPrevisualisation.TabIndex = 1
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(4, 51)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(106, 27)
        Me.btnRetour.TabIndex = 6
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnLancer
        '
        Me.btnLancer.BackColor = System.Drawing.Color.White
        Me.btnLancer.Location = New System.Drawing.Point(4, 10)
        Me.btnLancer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(106, 27)
        Me.btnLancer.TabIndex = 7
        Me.btnLancer.Text = "Lancer"
        Me.btnLancer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblNbreLigne)
        Me.Panel1.Controls.Add(Me.nudLignes)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 65)
        Me.Panel1.TabIndex = 8
        '
        'lblNbreLigne
        '
        Me.lblNbreLigne.AutoSize = True
        Me.lblNbreLigne.Location = New System.Drawing.Point(20, 9)
        Me.lblNbreLigne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbreLigne.Name = "lblNbreLigne"
        Me.lblNbreLigne.Size = New System.Drawing.Size(89, 13)
        Me.lblNbreLigne.TabIndex = 9
        Me.lblNbreLigne.Text = "Nombre de lignes"
        '
        'nudLignes
        '
        Me.nudLignes.Location = New System.Drawing.Point(22, 33)
        Me.nudLignes.Margin = New System.Windows.Forms.Padding(2)
        Me.nudLignes.Name = "nudLignes"
        Me.nudLignes.Size = New System.Drawing.Size(76, 20)
        Me.nudLignes.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnRetour)
        Me.Panel2.Controls.Add(Me.btnLancer)
        Me.Panel2.Location = New System.Drawing.Point(370, 169)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(115, 89)
        Me.Panel2.TabIndex = 9
        '
        'FormGrillePersonnalisee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(533, 371)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPrevisualisation)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormGrillePersonnalisee"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudLignes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPrevisualisation As TableLayoutPanel
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnLancer As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNbreLigne As Label
    Friend WithEvents nudLignes As NumericUpDown
    Friend WithEvents Panel2 As Panel
End Class
