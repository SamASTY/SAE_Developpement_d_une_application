<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rdoDebutant = New System.Windows.Forms.RadioButton()
        Me.rdoIntermediaire = New System.Windows.Forms.RadioButton()
        Me.rdoExpert = New System.Windows.Forms.RadioButton()
        Me.btnAvance = New System.Windows.Forms.Button()
        Me.lblDifficulte = New System.Windows.Forms.Label()
        Me.pnlAvance = New System.Windows.Forms.Panel()
        Me.lblDepot = New System.Windows.Forms.Label()
        Me.lblJsp = New System.Windows.Forms.Label()
        Me.pnlAvance.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoDebutant
        '
        Me.rdoDebutant.AutoSize = True
        Me.rdoDebutant.Location = New System.Drawing.Point(47, 82)
        Me.rdoDebutant.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.rdoIntermediaire.Location = New System.Drawing.Point(47, 112)
        Me.rdoIntermediaire.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.rdoExpert.Location = New System.Drawing.Point(47, 147)
        Me.rdoExpert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(55, 17)
        Me.rdoExpert.TabIndex = 2
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'btnAvance
        '
        Me.btnAvance.Location = New System.Drawing.Point(47, 216)
        Me.btnAvance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(56, 19)
        Me.btnAvance.TabIndex = 3
        Me.btnAvance.Text = "Avances"
        Me.btnAvance.UseVisualStyleBackColor = True
        '
        'lblDifficulte
        '
        Me.lblDifficulte.AutoSize = True
        Me.lblDifficulte.Location = New System.Drawing.Point(45, 58)
        Me.lblDifficulte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDifficulte.Name = "lblDifficulte"
        Me.lblDifficulte.Size = New System.Drawing.Size(48, 13)
        Me.lblDifficulte.TabIndex = 4
        Me.lblDifficulte.Text = "Difficulte"
        '
        'pnlAvance
        '
        Me.pnlAvance.Controls.Add(Me.lblDepot)
        Me.pnlAvance.Location = New System.Drawing.Point(47, 240)
        Me.pnlAvance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(470, 105)
        Me.pnlAvance.TabIndex = 5
        Me.pnlAvance.Tag = ""
        '
        'lblDepot
        '
        Me.lblDepot.AutoSize = True
        Me.lblDepot.Location = New System.Drawing.Point(321, 44)
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
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblJsp)
        Me.Controls.Add(Me.pnlAvance)
        Me.Controls.Add(Me.lblDifficulte)
        Me.Controls.Add(Me.btnAvance)
        Me.Controls.Add(Me.rdoExpert)
        Me.Controls.Add(Me.rdoIntermediaire)
        Me.Controls.Add(Me.rdoDebutant)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formOptions"
        Me.Text = "formOptions"
        Me.pnlAvance.ResumeLayout(False)
        Me.pnlAvance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoDebutant As RadioButton
    Friend WithEvents rdoIntermediaire As RadioButton
    Friend WithEvents rdoExpert As RadioButton
    Friend WithEvents btnAvance As Button
    Friend WithEvents lblDifficulte As Label
    Friend WithEvents pnlAvance As Panel
    Friend WithEvents lblDepot As Label
    Friend WithEvents lblJsp As Label
End Class
