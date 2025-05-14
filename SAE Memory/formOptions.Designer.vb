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
        Me.radioButtonDebutant = New System.Windows.Forms.RadioButton()
        Me.radioButtonIntermediaire = New System.Windows.Forms.RadioButton()
        Me.radioButtonExpert = New System.Windows.Forms.RadioButton()
        Me.buttonAvance = New System.Windows.Forms.Button()
        Me.labelDifficulte = New System.Windows.Forms.Label()
        Me.panelAvance = New System.Windows.Forms.Panel()
        Me.labelDragNDrop = New System.Windows.Forms.Label()
        Me.labelDragNDropx = New System.Windows.Forms.Label()
        Me.panelAvance.SuspendLayout()
        Me.SuspendLayout()
        '
        'radioButtonDebutant
        '
        Me.radioButtonDebutant.AutoSize = True
        Me.radioButtonDebutant.Location = New System.Drawing.Point(63, 101)
        Me.radioButtonDebutant.Name = "radioButtonDebutant"
        Me.radioButtonDebutant.Size = New System.Drawing.Size(82, 20)
        Me.radioButtonDebutant.TabIndex = 0
        Me.radioButtonDebutant.TabStop = True
        Me.radioButtonDebutant.Text = "Debutant"
        Me.radioButtonDebutant.UseVisualStyleBackColor = True
        '
        'radioButtonIntermediaire
        '
        Me.radioButtonIntermediaire.AutoSize = True
        Me.radioButtonIntermediaire.Location = New System.Drawing.Point(63, 138)
        Me.radioButtonIntermediaire.Name = "radioButtonIntermediaire"
        Me.radioButtonIntermediaire.Size = New System.Drawing.Size(106, 20)
        Me.radioButtonIntermediaire.TabIndex = 1
        Me.radioButtonIntermediaire.TabStop = True
        Me.radioButtonIntermediaire.Text = "Intermediaire"
        Me.radioButtonIntermediaire.UseVisualStyleBackColor = True
        '
        'radioButtonExpert
        '
        Me.radioButtonExpert.AutoSize = True
        Me.radioButtonExpert.Location = New System.Drawing.Point(63, 181)
        Me.radioButtonExpert.Name = "radioButtonExpert"
        Me.radioButtonExpert.Size = New System.Drawing.Size(66, 20)
        Me.radioButtonExpert.TabIndex = 2
        Me.radioButtonExpert.TabStop = True
        Me.radioButtonExpert.Text = "Expert"
        Me.radioButtonExpert.UseVisualStyleBackColor = True
        '
        'buttonAvance
        '
        Me.buttonAvance.Location = New System.Drawing.Point(63, 266)
        Me.buttonAvance.Name = "buttonAvance"
        Me.buttonAvance.Size = New System.Drawing.Size(75, 23)
        Me.buttonAvance.TabIndex = 3
        Me.buttonAvance.Text = "Avances"
        Me.buttonAvance.UseVisualStyleBackColor = True
        '
        'labelDifficulte
        '
        Me.labelDifficulte.AutoSize = True
        Me.labelDifficulte.Location = New System.Drawing.Point(60, 71)
        Me.labelDifficulte.Name = "labelDifficulte"
        Me.labelDifficulte.Size = New System.Drawing.Size(57, 16)
        Me.labelDifficulte.TabIndex = 4
        Me.labelDifficulte.Text = "Difficulte"
        '
        'panelAvance
        '
        Me.panelAvance.Controls.Add(Me.labelDragNDropx)
        Me.panelAvance.Location = New System.Drawing.Point(63, 295)
        Me.panelAvance.Name = "panelAvance"
        Me.panelAvance.Size = New System.Drawing.Size(627, 129)
        Me.panelAvance.TabIndex = 5
        Me.panelAvance.Tag = ""
        '
        'labelDragNDrop
        '
        Me.labelDragNDrop.AutoSize = True
        Me.labelDragNDrop.Location = New System.Drawing.Point(555, 123)
        Me.labelDragNDrop.Name = "labelDragNDrop"
        Me.labelDragNDrop.Size = New System.Drawing.Size(145, 16)
        Me.labelDragNDrop.TabIndex = 6
        Me.labelDragNDrop.Text = "Jsp ce qu'on mettrait ici"
        '
        'labelDragNDropx
        '
        Me.labelDragNDropx.AutoSize = True
        Me.labelDragNDropx.Location = New System.Drawing.Point(428, 54)
        Me.labelDragNDropx.Name = "labelDragNDropx"
        Me.labelDragNDropx.Size = New System.Drawing.Size(178, 16)
        Me.labelDragNDropx.TabIndex = 0
        Me.labelDragNDropx.Text = "Ici on met le drag and drop  ?"
        '
        'formOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelDragNDrop)
        Me.Controls.Add(Me.panelAvance)
        Me.Controls.Add(Me.labelDifficulte)
        Me.Controls.Add(Me.buttonAvance)
        Me.Controls.Add(Me.radioButtonExpert)
        Me.Controls.Add(Me.radioButtonIntermediaire)
        Me.Controls.Add(Me.radioButtonDebutant)
        Me.Name = "formOptions"
        Me.Text = "formOptions"
        Me.panelAvance.ResumeLayout(False)
        Me.panelAvance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioButtonDebutant As RadioButton
    Friend WithEvents radioButtonIntermediaire As RadioButton
    Friend WithEvents radioButtonExpert As RadioButton
    Friend WithEvents buttonAvance As Button
    Friend WithEvents labelDifficulte As Label
    Friend WithEvents panelAvance As Panel
    Friend WithEvents labelDragNDropx As Label
    Friend WithEvents labelDragNDrop As Label
End Class
