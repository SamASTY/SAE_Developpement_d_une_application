Imports System.IO
Imports System.Text.RegularExpressions
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
            btnAvance.Text = "Masquer les options avancées"
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

    ' Systeme de Drag and Drop pour le panel
    Private Sub pnlAvance_DragDrop(sender As Object, e As DragEventArgs) Handles pnlAvance.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        Dim regex As New Regex("^\d+\.jpeg$", RegexOptions.IgnoreCase)
        Dim dossierCustom As String = Path.Combine(Application.StartupPath, "Custom")

        ' Créer le dossier "Custom" en cas de bug d'import
        If Not Directory.Exists(dossierCustom) Then
            Directory.CreateDirectory(dossierCustom)
        End If

        For Each file In files
            Dim fileName As String = Path.GetFileName(file)

            If regex.IsMatch(fileName) Then
                Dim destPath As String = Path.Combine(dossierCustom, fileName)

                Try
                    System.IO.File.Copy(file, destPath, True) ' True = écrase si déjà présent
                    MessageBox.Show("Fichier copié : " & fileName, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Erreur lors de la copie : " & ex.Message)
                End Try
            Else
                MessageBox.Show("Nom de fichier invalide (attendu : chiffre.jpeg) → " & fileName, "Fichier ignoré", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
    End Sub

    Private Sub pnlAvance_DragEnter(sender As Object, e As DragEventArgs) Handles pnlAvance.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    ' reset le deck
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim dossierCustom As String = Path.Combine(Application.StartupPath, "Custom")

        If Directory.Exists(dossierCustom) Then
            Try
                ' Supprimer tous les fichiers du dossier
                For Each filePath In Directory.GetFiles(dossierCustom, "*.jpeg")
                    File.Delete(filePath)
                Next
                MessageBox.Show("Le dossier 'Custom' a été vidé avec succès.", "Réinitialisation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erreur lors du nettoyage : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Le dossier 'Custom' n'existe pas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chkCustom_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustom.CheckedChanged
        Dim dossierCustom As String = "custom/images"

        If chkCustom.Checked Then
            If IO.Directory.Exists(dossierCustom) AndAlso IO.Directory.GetFiles(dossierCustom, "*.png").Length > 0 Then
                ModuleParametres.dossierImages = dossierCustom
            Else
                MessageBox.Show("Le dossier 'custom/images' est vide ou n'existe pas.")
                chkCustom.Checked = False
                ModuleParametres.dossierImages = "images"
            End If
        Else
            ModuleParametres.dossierImages = "images"
        End If
    End Sub
End Class