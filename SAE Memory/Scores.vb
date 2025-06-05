Public Class FormScores
    Dim ordreCroissant As Boolean = False
    Private syncingSelection As Boolean = False


    Private Sub formScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les données depuis le fichier
        SauvegardeJoueur.ChargerDepuisFichier()

        ' Remplir la ComboBox
        cmbJoueurValeur.Items.Clear()
        For Each j As SauvegardeJoueur.Joueur In SauvegardeJoueur.Joueurs
            cmbJoueurValeur.Items.Add(j.Pseudo)
        Next

        ' Afficher tous les joueurs
        AfficherJoueurs()

        ' Sélectionner le joueur actuel s'il existe
        If Not String.IsNullOrEmpty(SauvegardeJoueur.P) Then
            cmbJoueurValeur.SelectedItem = SauvegardeJoueur.P
        End If
    End Sub

    Private Sub AfficherJoueurs()
        lstNoms.Items.Clear()
        lstScores.Items.Clear()
        lstTemps.Items.Clear()
        lstTmpTot.Items.Clear()
        lstNbParties.Items.Clear()

        Dim joueursTries = If(ordreCroissant,
            SauvegardeJoueur.Joueurs.OrderBy(Function(j) j.ScoreMax).ThenBy(Function(j) j.TempsMin),
            SauvegardeJoueur.Joueurs.OrderByDescending(Function(j) j.ScoreMax).ThenBy(Function(j) j.TempsMin)
        )

        For Each j In joueursTries
            lstNoms.Items.Add(j.Pseudo)
            lstScores.Items.Add(j.ScoreMax)
            lstTemps.Items.Add(j.TempsMin & " sec")
            lstTmpTot.Items.Add(j.TempsTotalJouer & " sec")
            lstNbParties.Items.Add(j.NbPartie)
        Next
    End Sub

    Private Sub ListBoxNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNoms.SelectedIndexChanged
        If lstNoms.SelectedIndex >= 0 Then
            Dim pseudo As String = lstNoms.Items(lstNoms.SelectedIndex).ToString()
            cmbJoueurValeur.SelectedItem = pseudo
            AfficherDetailsJoueur(pseudo)
        End If
    End Sub

    Private Sub ComboBoxJoueurValeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJoueurValeur.SelectedIndexChanged
        If cmbJoueurValeur.SelectedIndex >= 0 Then
            Dim pseudo As String = cmbJoueurValeur.SelectedItem.ToString()
            AfficherDetailsJoueur(pseudo)

            ' Sélectionner le joueur dans la ListBox
            Dim index = lstNoms.Items.IndexOf(pseudo)
            If index >= 0 Then
                lstNoms.SelectedIndex = index
            End If
        End If
    End Sub

    Private Sub AfficherDetailsJoueur(pseudo As String)
        Dim joueur = SauvegardeJoueur.ObtenirJoueur(pseudo)
        If joueur.HasValue Then
            lblMaxValeur.Text = joueur.Value.ScoreMax.ToString()
            lblMinValeur.Text = joueur.Value.TempsMin.ToString() & " sec"
        End If
    End Sub

    Private Sub buttonTri_Click(sender As Object, e As EventArgs) Handles btnTri.Click
        ordreCroissant = Not ordreCroissant
        AfficherJoueurs()
    End Sub


    Private Sub buttonRejouer_Click(sender As Object, e As EventArgs) Handles btnRejouer.Click
        If cmbJoueurValeur.SelectedItem Is Nothing Then
            MsgBox("Impossible de rejouer sans avoir rentrer de pseudo !", vbExclamation, "Attention")
            FormAccueil.Show()
            Me.Hide()
            Exit Sub
        End If
        Dim jeuForm As New FormJeu()
        jeuForm.RecupererJoueur(cmbJoueurValeur.SelectedItem.ToString()) ' afaire : attention quand on rejou ca ecrase les données, pas de sauvegarde des meilleur parties
        Me.Close()
        jeuForm.Show()
    End Sub

    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim reponse = MsgBox("Voulez-vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub buttonFermer_Click(sender As Object, e As EventArgs) Handles btnFermer.Click
        Me.Close()
    End Sub



    ' Synchronise une ListBox avec un index spécifique
    Private Sub SyncListBoxSelection(listBox As ListBox, index As Integer)
        If listBox.SelectedIndex <> index Then
            listBox.SelectedIndex = index
        End If
    End Sub

    ' Gère la sélection dans n'importe quelle ListBox
    Private Sub AnyListBox_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles lstNoms.SelectedIndexChanged,
                lstScores.SelectedIndexChanged,
                lstTemps.SelectedIndexChanged,
                lstTmpTot.SelectedIndexChanged,
                lstNbParties.SelectedIndexChanged

        ' Si déjà en train de synchroniser ou aucune sélection, on sort
        If syncingSelection OrElse DirectCast(sender, ListBox).SelectedIndex = -1 Then Return

        syncingSelection = True ' Bloque les appels récursifs

        Try
            ' Récupère l'index sélectionné
            Dim selectedIndex = DirectCast(sender, ListBox).SelectedIndex

            SyncListBoxSelection(lstNoms, selectedIndex)
            SyncListBoxSelection(lstScores, selectedIndex)
            SyncListBoxSelection(lstTemps, selectedIndex)
            SyncListBoxSelection(lstTmpTot, selectedIndex)
            SyncListBoxSelection(lstNbParties, selectedIndex)

            If sender Is lstNoms Then
                Dim pseudo = lstNoms.SelectedItem.ToString()
                cmbJoueurValeur.SelectedItem = pseudo
                AfficherDetailsJoueur(pseudo)
            End If
        Finally
            syncingSelection = False ' Réactive la synchronisation
        End Try
    End Sub

    Private Sub ButtonAffJoueur_Click(sender As Object, e As EventArgs) Handles btnAffJoueur.Click
        ' Vérifier que la ComboBox n'est pas vide
        If String.IsNullOrEmpty(cmbJoueurValeur.Text) Then
            MsgBox("Veuillez sélectionner ou saisir un joueur", vbInformation, "Information")
            Exit Sub
        End If

        Dim pseudo As String = cmbJoueurValeur.Text
        Dim joueurTrouve As Boolean = False
        Dim score As Integer = 0
        Dim temps As Integer = 0
        Dim parties As Integer = 0

        ' Recherche du joueur
        For Each j As SauvegardeJoueur.Joueur In SauvegardeJoueur.Joueurs
            If j.Pseudo = pseudo Then
                score = j.ScoreMax
                temps = j.TempsMin
                parties = j.NbPartie
                joueurTrouve = True
                Exit For
            End If
        Next

        If joueurTrouve Then
            MsgBox($"Le joueur {pseudo} a un meilleur score de {score} " &
               $"pour un temps de {temps} secondes " &
               $"et a joué {parties} parties.",
               vbInformation, "Statistiques")
        Else
            MsgBox($"Le joueur {pseudo} n'a pas été trouvé dans les statistiques.",
               vbExclamation, "Non trouvé")
        End If
    End Sub
End Class