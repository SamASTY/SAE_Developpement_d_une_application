<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoDebutant = New System.Windows.Forms.RadioButton()
        Me.rdoIntermediaire = New System.Windows.Forms.RadioButton()
        Me.rdoExpert = New System.Windows.Forms.RadioButton()
        Me.btnAvance = New System.Windows.Forms.Button()
        Me.pnlAvance = New System.Windows.Forms.Panel()
        Me.chkCustom = New System.Windows.Forms.CheckBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.grpDifficulte = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkIndice = New System.Windows.Forms.CheckBox()
        Me.btnEnr = New System.Windows.Forms.Button()
        Me.btnAide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlAvance.SuspendLayout()
        Me.grpDifficulte.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDebutant
        '
        Me.rdoDebutant.AutoSize = True
        Me.rdoDebutant.Location = New System.Drawing.Point(5, 25)
        Me.rdoDebutant.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoDebutant.Name = "rdoDebutant"
        Me.rdoDebutant.Size = New System.Drawing.Size(69, 17)
        Me.rdoDebutant.TabIndex = 0
        Me.rdoDebutant.TabStop = True
        Me.rdoDebutant.Text = "Debutant"
        Me.rdoDebutant.UseVisualStyleBackColor = True
        '
        'rdoIntermediaire
        '
        Me.rdoIntermediaire.AutoSize = True
        Me.rdoIntermediaire.Location = New System.Drawing.Point(5, 55)
        Me.rdoIntermediaire.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoIntermediaire.Name = "rdoIntermediaire"
        Me.rdoIntermediaire.Size = New System.Drawing.Size(85, 17)
        Me.rdoIntermediaire.TabIndex = 1
        Me.rdoIntermediaire.TabStop = True
        Me.rdoIntermediaire.Text = "Intermediaire"
        Me.rdoIntermediaire.UseVisualStyleBackColor = True
        '
        'rdoExpert
        '
        Me.rdoExpert.AutoSize = True
        Me.rdoExpert.Location = New System.Drawing.Point(5, 90)
        Me.rdoExpert.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(55, 17)
        Me.rdoExpert.TabIndex = 2
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'btnAvance
        '
        Me.btnAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvance.Location = New System.Drawing.Point(11, 190)
        Me.btnAvance.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(145, 19)
        Me.btnAvance.TabIndex = 3
        Me.btnAvance.Text = "Rajouter vos propres cartes "
        Me.btnAvance.UseVisualStyleBackColor = False
        '
        'pnlAvance
        '
        Me.pnlAvance.AllowDrop = True
        Me.pnlAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAvance.Controls.Add(Me.chkCustom)
        Me.pnlAvance.Location = New System.Drawing.Point(8, 224)
        Me.pnlAvance.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(350, 105)
        Me.pnlAvance.TabIndex = 5
        Me.pnlAvance.Tag = ""
        Me.pnlAvance.Visible = False
        '
        'chkCustom
        '
        Me.chkCustom.AutoSize = True
        Me.chkCustom.Location = New System.Drawing.Point(6, 12)
        Me.chkCustom.Name = "chkCustom"
        Me.chkCustom.Size = New System.Drawing.Size(114, 17)
        Me.chkCustom.TabIndex = 16
        Me.chkCustom.Text = "Deck personnalisé"
        Me.chkCustom.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRetour.Location = New System.Drawing.Point(173, 9)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(91, 38)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'grpDifficulte
        '
        Me.grpDifficulte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpDifficulte.Controls.Add(Me.Label2)
        Me.grpDifficulte.Controls.Add(Me.rdoIntermediaire)
        Me.grpDifficulte.Controls.Add(Me.rdoDebutant)
        Me.grpDifficulte.Controls.Add(Me.rdoExpert)
        Me.grpDifficulte.Location = New System.Drawing.Point(9, 64)
        Me.grpDifficulte.Name = "grpDifficulte"
        Me.grpDifficulte.Size = New System.Drawing.Size(200, 112)
        Me.grpDifficulte.TabIndex = 9
        Me.grpDifficulte.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Difficulté"
        '
        'chkIndice
        '
        Me.chkIndice.AutoSize = True
        Me.chkIndice.Location = New System.Drawing.Point(7, 40)
        Me.chkIndice.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkIndice.Name = "chkIndice"
        Me.chkIndice.Size = New System.Drawing.Size(112, 17)
        Me.chkIndice.TabIndex = 10
        Me.chkIndice.Text = "Activer les Indices"
        Me.chkIndice.UseVisualStyleBackColor = True
        '
        'btnEnr
        '
        Me.btnEnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnr.Location = New System.Drawing.Point(8, 8)
        Me.btnEnr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.Size = New System.Drawing.Size(147, 39)
        Me.btnEnr.TabIndex = 11
        Me.btnEnr.Text = "Enregistrer les parametres"
        Me.btnEnr.UseVisualStyleBackColor = False
        '
        'btnAide
        '
        Me.btnAide.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAide.Location = New System.Drawing.Point(276, 9)
        Me.btnAide.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(82, 38)
        Me.btnAide.TabIndex = 12
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Indice"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chkIndice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(225, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 65)
        Me.Panel1.TabIndex = 14
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(173, 190)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(145, 19)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Supprimer votre deck"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(373, 347)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.btnEnr)
        Me.Controls.Add(Me.grpDifficulte)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.pnlAvance)
        Me.Controls.Add(Me.btnAvance)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "formOptions"
        Me.Text = "formOptions"
        Me.pnlAvance.ResumeLayout(False)
        Me.pnlAvance.PerformLayout()
        Me.grpDifficulte.ResumeLayout(False)
        Me.grpDifficulte.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoDebutant As RadioButton
    Friend WithEvents rdoIntermediaire As RadioButton
    Friend WithEvents rdoExpert As RadioButton
    Friend WithEvents btnAvance As Button
    Friend WithEvents pnlAvance As Panel
    Friend WithEvents btnRetour As Button
    Friend WithEvents grpDifficulte As GroupBox
    Friend WithEvents chkIndice As CheckBox
    Friend WithEvents btnEnr As Button
    Friend WithEvents btnAide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents chkCustom As CheckBox
End Class
