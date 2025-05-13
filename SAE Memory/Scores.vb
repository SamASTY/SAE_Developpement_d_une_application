Public Class formScore
    Dim ordreCroissant As Boolean = False
    Private syncingSelection As Boolean = False


    Private Sub formScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les données depuis le fichier
        SauvegardeJoueur.ChargerDepuisFichier()

        ' Remplir la ComboBox
        ComboBoxJoueurValeur.Items.Clear()
        For Each j As SauvegardeJoueur.Joueur In SauvegardeJoueur.Joueurs
            ComboBoxJoueurValeur.Items.Add(j.Pseudo)
        Next

        ' Afficher tous les joueurs
        AfficherJoueurs()

        ' Sélectionner le joueur actuel s'il existe
        If Not String.IsNullOrEmpty(SauvegardeJoueur.P) Then
            ComboBoxJoueurValeur.SelectedItem = SauvegardeJoueur.P
        End If
    End Sub

    Private Sub AfficherJoueurs()
        ListBoxNoms.Items.Clear()
        ListBoxScores.Items.Clear()
        ListBoxTemps.Items.Clear()
        ListBoxNbParties.Items.Clear()

        Dim joueursTries = If(ordreCroissant,
            SauvegardeJoueur.Joueurs.OrderBy(Function(j) j.ScoreMax).ThenBy(Function(j) j.TempsMin),
            SauvegardeJoueur.Joueurs.OrderByDescending(Function(j) j.ScoreMax).ThenBy(Function(j) j.TempsMin)
        )

        For Each j In joueursTries
            ListBoxNoms.Items.Add(j.Pseudo)
            ListBoxScores.Items.Add(j.ScoreMax)
            ListBoxTemps.Items.Add(j.TempsMin & " sec")
            ListBoxNbParties.Items.Add(j.NbPartie)
        Next
    End Sub

    Private Sub ListBoxNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNoms.SelectedIndexChanged
        If ListBoxNoms.SelectedIndex >= 0 Then
            Dim pseudo As String = ListBoxNoms.Items(ListBoxNoms.SelectedIndex).ToString()
            ComboBoxJoueurValeur.SelectedItem = pseudo
            AfficherDetailsJoueur(pseudo)
        End If
    End Sub

    Private Sub ComboBoxJoueurValeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJoueurValeur.SelectedIndexChanged
        If ComboBoxJoueurValeur.SelectedIndex >= 0 Then
            Dim pseudo As String = ComboBoxJoueurValeur.SelectedItem.ToString()
            AfficherDetailsJoueur(pseudo)

            ' Sélectionner le joueur dans la ListBox
            Dim index = ListBoxNoms.Items.IndexOf(pseudo)
            If index >= 0 Then
                ListBoxNoms.SelectedIndex = index
            End If
        End If
    End Sub

    Private Sub AfficherDetailsJoueur(pseudo As String)
        Dim joueur = SauvegardeJoueur.ObtenirJoueur(pseudo)
        If joueur.HasValue Then
            labelMaxValeur.Text = joueur.Value.ScoreMax.ToString()
            labelMinValeur.Text = joueur.Value.TempsMin.ToString() & " sec"
            LabelNbParties.Text = joueur.Value.NbPartie.ToString()
            LabelTempsTotal.Text = joueur.Value.TempsTotalJouer.ToString() & " sec"
        End If
    End Sub

    Private Sub ButtonTri_Click(sender As Object, e As EventArgs) Handles ButtonTri.Click
        ordreCroissant = Not ordreCroissant
        AfficherJoueurs()
    End Sub


    Private Sub buttonRejouer_Click(sender As Object, e As EventArgs) Handles buttonRejouer.Click
        Dim jeuForm As New Jeu()
        jeuForm.RecupererJoueur(ComboBoxJoueurValeur.SelectedItem.ToString()) ' afaire : attention quand on rejou ca ecrase les données, pas de sauvegarde des meilleur parties
        Me.Close()
        jeuForm.Show()
    End Sub

    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs) Handles buttonQuitter.Click
        Dim reponse = MsgBox("Voulez-vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ButtonFermer_Click(sender As Object, e As EventArgs) Handles ButtonFermer.Click
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
        Handles ListBoxNoms.SelectedIndexChanged,
                ListBoxScores.SelectedIndexChanged,
                ListBoxTemps.SelectedIndexChanged,
                ListBoxNbParties.SelectedIndexChanged

        ' Si déjà en train de synchroniser ou aucune sélection, on sort
        If syncingSelection OrElse DirectCast(sender, ListBox).SelectedIndex = -1 Then Return

        syncingSelection = True ' Bloque les appels récursifs

        Try
            ' Récupère l'index sélectionné
            Dim selectedIndex = DirectCast(sender, ListBox).SelectedIndex

            SyncListBoxSelection(ListBoxNoms, selectedIndex)
            SyncListBoxSelection(ListBoxScores, selectedIndex)
            SyncListBoxSelection(ListBoxTemps, selectedIndex)
            SyncListBoxSelection(ListBoxNbParties, selectedIndex)

            If sender Is ListBoxNoms Then
                Dim pseudo = ListBoxNoms.SelectedItem.ToString()
                ComboBoxJoueurValeur.SelectedItem = pseudo
                AfficherDetailsJoueur(pseudo)
            End If
        Finally
            syncingSelection = False ' Réactive la synchronisation
        End Try
    End Sub

    Private Sub ButtonAffJoueur_Click(sender As Object, e As EventArgs) Handles ButtonAffJoueur.Click
        ' Vérifier que la ComboBox n'est pas vide
        If String.IsNullOrEmpty(ComboBoxJoueurValeur.Text) Then
            MsgBox("Veuillez sélectionner ou saisir un joueur", vbInformation, "Information")
            Exit Sub
        End If

        Dim pseudo As String = ComboBoxJoueurValeur.Text
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