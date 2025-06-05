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
        Me.lblDepot = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.grpDifficulte = New System.Windows.Forms.GroupBox()
        Me.chkIndice = New System.Windows.Forms.CheckBox()
        Me.btnEnr = New System.Windows.Forms.Button()
        Me.btnAide = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlAvance.SuspendLayout()
        Me.grpDifficulte.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDebutant
        '
        Me.rdoDebutant.AutoSize = True
        Me.rdoDebutant.Location = New System.Drawing.Point(8, 39)
        Me.rdoDebutant.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoDebutant.Name = "rdoDebutant"
        Me.rdoDebutant.Size = New System.Drawing.Size(101, 24)
        Me.rdoDebutant.TabIndex = 0
        Me.rdoDebutant.TabStop = True
        Me.rdoDebutant.Text = "Debutant"
        Me.rdoDebutant.UseVisualStyleBackColor = True
        '
        'rdoIntermediaire
        '
        Me.rdoIntermediaire.AutoSize = True
        Me.rdoIntermediaire.Location = New System.Drawing.Point(8, 85)
        Me.rdoIntermediaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoIntermediaire.Name = "rdoIntermediaire"
        Me.rdoIntermediaire.Size = New System.Drawing.Size(127, 24)
        Me.rdoIntermediaire.TabIndex = 1
        Me.rdoIntermediaire.TabStop = True
        Me.rdoIntermediaire.Text = "Intermediaire"
        Me.rdoIntermediaire.UseVisualStyleBackColor = True
        '
        'rdoExpert
        '
        Me.rdoExpert.AutoSize = True
        Me.rdoExpert.Location = New System.Drawing.Point(8, 139)
        Me.rdoExpert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(80, 24)
        Me.rdoExpert.TabIndex = 2
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'btnAvance
        '
        Me.btnAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAvance.Location = New System.Drawing.Point(46, 292)
        Me.btnAvance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(218, 29)
        Me.btnAvance.TabIndex = 3
        Me.btnAvance.Text = "Rajouter vos propres cartes "
        Me.btnAvance.UseVisualStyleBackColor = False
        '
        'pnlAvance
        '
        Me.pnlAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlAvance.Controls.Add(Me.lblDepot)
        Me.pnlAvance.Location = New System.Drawing.Point(12, 345)
        Me.pnlAvance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(525, 161)
        Me.pnlAvance.TabIndex = 5
        Me.pnlAvance.Tag = ""
        Me.pnlAvance.Visible = False
        '
        'lblDepot
        '
        Me.lblDepot.AutoSize = True
        Me.lblDepot.Location = New System.Drawing.Point(18, 22)
        Me.lblDepot.Name = "lblDepot"
        Me.lblDepot.Size = New System.Drawing.Size(214, 20)
        Me.lblDepot.TabIndex = 0
        Me.lblDepot.Text = "Ici on met le drag and drop  ?"
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRetour.Location = New System.Drawing.Point(260, 14)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(136, 58)
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
        Me.grpDifficulte.Location = New System.Drawing.Point(13, 98)
        Me.grpDifficulte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDifficulte.Name = "grpDifficulte"
        Me.grpDifficulte.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDifficulte.Size = New System.Drawing.Size(300, 172)
        Me.grpDifficulte.TabIndex = 9
        Me.grpDifficulte.TabStop = False
        '
        'chkIndice
        '
        Me.chkIndice.AutoSize = True
        Me.chkIndice.Location = New System.Drawing.Point(10, 62)
        Me.chkIndice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIndice.Name = "chkIndice"
        Me.chkIndice.Size = New System.Drawing.Size(162, 24)
        Me.chkIndice.TabIndex = 10
        Me.chkIndice.Text = "Activer les Indices"
        Me.chkIndice.UseVisualStyleBackColor = True
        '
        'btnEnr
        '
        Me.btnEnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnr.Location = New System.Drawing.Point(12, 12)
        Me.btnEnr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.Size = New System.Drawing.Size(220, 60)
        Me.btnEnr.TabIndex = 11
        Me.btnEnr.Text = "Enregistrer les parametres"
        Me.btnEnr.UseVisualStyleBackColor = False
        '
        'btnAide
        '
        Me.btnAide.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAide.Location = New System.Drawing.Point(414, 14)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(123, 58)
        Me.btnAide.TabIndex = 12
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Indice"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chkIndice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(337, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Diifculté"
        '
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(559, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.btnEnr)
        Me.Controls.Add(Me.grpDifficulte)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.pnlAvance)
        Me.Controls.Add(Me.btnAvance)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents lblDepot As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents grpDifficulte As GroupBox
    Friend WithEvents chkIndice As CheckBox
    Friend WithEvents btnEnr As Button
    Friend WithEvents btnAide As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
