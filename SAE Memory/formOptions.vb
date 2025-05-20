Public Class formOptions
    Private Sub formOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdoDebutant.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        FormAccueil.Show()
    End Sub

    Private Sub rdoDebutant_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDebutant.CheckedChanged
        If rdoDebutant.Checked Then
            ModuleParametres.Difficulté = "Debutant"
        End If
    End Sub

    Private Sub rdoIntermediaire_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIntermediaire.CheckedChanged
        If rdoIntermediaire.Checked Then
            ModuleParametres.Difficulté = "Intermediaire"
        End If
    End Sub

    Private Sub rdoExpert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExpert.CheckedChanged
        If rdoExpert.Checked Then
            ModuleParametres.Difficulté = "Expert"
        End If
    End Sub

    Private Sub btnAvance_Click(sender As Object, e As EventArgs) Handles btnAvance.Click
        If pnlAvance.Visible Then
            pnlAvance.Hide()
        Else
            pnlAvance.Show()
        End If
    End Sub

End Class