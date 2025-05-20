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
        Me.lblJsp = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.grpDifficulte = New System.Windows.Forms.GroupBox()
        Me.pnlAvance.SuspendLayout()
        Me.grpDifficulte.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDebutant
        '
        Me.rdoDebutant.AutoSize = True
        Me.rdoDebutant.Location = New System.Drawing.Point(5, 25)
        Me.rdoDebutant.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rdoIntermediaire.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rdoExpert.Margin = New System.Windows.Forms.Padding(2)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(55, 17)
        Me.rdoExpert.TabIndex = 2
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'btnAvance
        '
        Me.btnAvance.Location = New System.Drawing.Point(46, 154)
        Me.btnAvance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(56, 19)
        Me.btnAvance.TabIndex = 3
        Me.btnAvance.Text = "Avances"
        Me.btnAvance.UseVisualStyleBackColor = True
        '
        'pnlAvance
        '
        Me.pnlAvance.Controls.Add(Me.lblDepot)
        Me.pnlAvance.Location = New System.Drawing.Point(46, 178)
        Me.pnlAvance.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(470, 105)
        Me.pnlAvance.TabIndex = 5
        Me.pnlAvance.Tag = ""
        Me.pnlAvance.Visible = False
        '
        'lblDepot
        '
        Me.lblDepot.AutoSize = True
        Me.lblDepot.Location = New System.Drawing.Point(12, 15)
        Me.lblDepot.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepot.Name = "lblDepot"
        Me.lblDepot.Size = New System.Drawing.Size(145, 13)
        Me.lblDepot.TabIndex = 0
        Me.lblDepot.Text = "Ici on met le drag and drop  ?"
        '
        'lblJsp
        '
        Me.lblJsp.AutoSize = True
        Me.lblJsp.Location = New System.Drawing.Point(416, 100)
        Me.lblJsp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJsp.Name = "lblJsp"
        Me.lblJsp.Size = New System.Drawing.Size(117, 13)
        Me.lblJsp.TabIndex = 6
        Me.lblJsp.Text = "Jsp ce qu'on mettrait ici"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(442, 318)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(91, 26)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(46, 318)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(91, 26)
        Me.btnJouer.TabIndex = 8
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'grpDifficulte
        '
        Me.grpDifficulte.Controls.Add(Me.rdoIntermediaire)
        Me.grpDifficulte.Controls.Add(Me.rdoDebutant)
        Me.grpDifficulte.Controls.Add(Me.rdoExpert)
        Me.grpDifficulte.Location = New System.Drawing.Point(46, 24)
        Me.grpDifficulte.Name = "grpDifficulte"
        Me.grpDifficulte.Size = New System.Drawing.Size(200, 112)
        Me.grpDifficulte.TabIndex = 9
        Me.grpDifficulte.TabStop = False
        Me.grpDifficulte.Text = "Difficulte"
        '
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.grpDifficulte)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblJsp)
        Me.Controls.Add(Me.pnlAvance)
        Me.Controls.Add(Me.btnAvance)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents lblJsp As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnJouer As Button
    Friend WithEvents grpDifficulte As GroupBox
End Class
