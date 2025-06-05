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
    Private Sub btnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        Dim messageAide As String = ""
        messageAide += "=== NIVEAUX DE DIFFICULTÉ ===" & vbCrLf & vbCrLf

        messageAide += "🟢 DÉBUTANT :" & vbCrLf
        messageAide += "• Grille : 4x4 (16 cartes)" & vbCrLf
        messageAide += "• Temps limite : 2 minutes" & vbCrLf
        messageAide += "• Idéal pour commencer" & vbCrLf & vbCrLf

        messageAide += "🟡 INTERMÉDIAIRE :" & vbCrLf
        messageAide += "• Grille : 6x6 (36 cartes)" & vbCrLf
        messageAide += "• Temps limite : 4 minutes" & vbCrLf
        messageAide += "• Difficulté équilibrée" & vbCrLf & vbCrLf

        messageAide += "🔴 EXPERT :" & vbCrLf
        messageAide += "• Grille : 8x8 (64 cartes)" & vbCrLf
        messageAide += "• Temps limite : 6 minutes" & vbCrLf
        messageAide += "• Pour les joueurs expérimentés" & vbCrLf & vbCrLf

        messageAide += "=== SYSTÈME D'INDICES ===" & vbCrLf & vbCrLf
        messageAide += "💡 ACTIVER LES INDICES :" & vbCrLf
        messageAide += "• Révèle brièvement les cartes correspondantes" & vbCrLf
        messageAide += "• Aide à mémoriser les positions" & vbCrLf
        messageAide += "• Utilisable une fois par partie" & vbCrLf & vbCrLf

        messageAide += "⚠️ ATTENTION :" & vbCrLf
        messageAide += "Si vous utilisez les indices, votre score" & vbCrLf
        messageAide += "ne sera PAS enregistré dans le classement !" & vbCrLf & vbCrLf

        messageAide += "=== CONSEILS ===" & vbCrLf
        messageAide += "• Commencez par le niveau Débutant" & vbCrLf
        messageAide += "• Mémorisez les positions des cartes" & vbCrLf
        messageAide += "• Désactivez les indices pour concourir"

        MessageBox.Show(messageAide, "🎮 Aide - Jeu de Memory", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub grpDifficulte_Enter(sender As Object, e As EventArgs) Handles grpDifficulte.Enter

    End Sub
End Class