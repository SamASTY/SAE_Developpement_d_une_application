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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.pnlAvance.SuspendLayout()
        Me.grpDifficulte.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDebutant
        '
        Me.rdoDebutant.AutoSize = True
        Me.rdoDebutant.Location = New System.Drawing.Point(7, 31)
        Me.rdoDebutant.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoDebutant.Name = "rdoDebutant"
        Me.rdoDebutant.Size = New System.Drawing.Size(82, 20)
        Me.rdoDebutant.TabIndex = 0
        Me.rdoDebutant.TabStop = True
        Me.rdoDebutant.Text = "Debutant"
        Me.rdoDebutant.UseVisualStyleBackColor = True
        '
        'rdoIntermediaire
        '
        Me.rdoIntermediaire.AutoSize = True
        Me.rdoIntermediaire.Location = New System.Drawing.Point(7, 68)
        Me.rdoIntermediaire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoIntermediaire.Name = "rdoIntermediaire"
        Me.rdoIntermediaire.Size = New System.Drawing.Size(106, 20)
        Me.rdoIntermediaire.TabIndex = 1
        Me.rdoIntermediaire.TabStop = True
        Me.rdoIntermediaire.Text = "Intermediaire"
        Me.rdoIntermediaire.UseVisualStyleBackColor = True
        '
        'rdoExpert
        '
        Me.rdoExpert.AutoSize = True
        Me.rdoExpert.Location = New System.Drawing.Point(7, 111)
        Me.rdoExpert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(66, 20)
        Me.rdoExpert.TabIndex = 2
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'btnAvance
        '
        Me.btnAvance.Location = New System.Drawing.Point(61, 190)
        Me.btnAvance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(162, 23)
        Me.btnAvance.TabIndex = 3
        Me.btnAvance.Text = "Rajouter vos propres cartes "
        Me.btnAvance.UseVisualStyleBackColor = True
        '
        'pnlAvance
        '
        Me.pnlAvance.Controls.Add(Me.lblDepot)
        Me.pnlAvance.Location = New System.Drawing.Point(61, 219)
        Me.pnlAvance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(403, 129)
        Me.pnlAvance.TabIndex = 5
        Me.pnlAvance.Tag = ""
        Me.pnlAvance.Visible = False
        '
        'lblDepot
        '
        Me.lblDepot.AutoSize = True
        Me.lblDepot.Location = New System.Drawing.Point(16, 18)
        Me.lblDepot.Name = "lblDepot"
        Me.lblDepot.Size = New System.Drawing.Size(178, 16)
        Me.lblDepot.TabIndex = 0
        Me.lblDepot.Text = "Ici on met le drag and drop  ?"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(343, 367)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(121, 32)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'grpDifficulte
        '
        Me.grpDifficulte.Controls.Add(Me.rdoIntermediaire)
        Me.grpDifficulte.Controls.Add(Me.rdoDebutant)
        Me.grpDifficulte.Controls.Add(Me.rdoExpert)
        Me.grpDifficulte.Location = New System.Drawing.Point(61, 30)
        Me.grpDifficulte.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDifficulte.Name = "grpDifficulte"
        Me.grpDifficulte.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDifficulte.Size = New System.Drawing.Size(267, 138)
        Me.grpDifficulte.TabIndex = 9
        Me.grpDifficulte.TabStop = False
        Me.grpDifficulte.Text = "Difficulte"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(345, 98)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(119, 20)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Activer la triche"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 427)
        Me.Controls.Add(Me.CheckBox1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoDebutant As RadioButton
    Friend WithEvents rdoIntermediaire As RadioButton
    Friend WithEvents rdoExpert As RadioButton
    Friend WithEvents btnAvance As Button
    Friend WithEvents pnlAvance As Panel
    Friend WithEvents lblDepot As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents grpDifficulte As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
