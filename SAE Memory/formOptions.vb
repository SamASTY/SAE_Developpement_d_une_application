Public Class formOptions

    Private difficulteTemp As NiveauDifficulte

    Private Sub formOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        difficulteTemp = ModuleParametres.DifActuelle

        Select Case difficulteTemp
            Case NiveauDifficulte.Debutant
                rdoDebutant.Checked = True
            Case NiveauDifficulte.Intermediaire
                rdoIntermediaire.Checked = True
            Case NiveauDifficulte.Expert
                rdoExpert.Checked = True
        End Select

        chkIndice.Checked = ModuleParametres.IndiceEtat()
    End Sub

    Private Sub rdoDebutant_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDebutant.CheckedChanged
        If rdoDebutant.Checked Then
            difficulteTemp = NiveauDifficulte.Debutant
        End If
    End Sub

    Private Sub rdoIntermediaire_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIntermediaire.CheckedChanged
        If rdoIntermediaire.Checked Then
            difficulteTemp = NiveauDifficulte.Intermediaire
        End If
    End Sub

    Private Sub rdoExpert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExpert.CheckedChanged
        If rdoExpert.Checked Then
            difficulteTemp = NiveauDifficulte.Expert
        End If
    End Sub


    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub


    Private Sub btnAvance_Click(sender As Object, e As EventArgs) Handles btnAvance.Click
        If pnlAvance.Visible Then
            pnlAvance.Hide()
        Else
            pnlAvance.Show()
        End If
    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        ModuleParametres.CocheIndice(chkIndice.Checked)
        ModuleParametres.DifActuelle = difficulteTemp
        MessageBox.Show("Paramètres enregistrés avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class