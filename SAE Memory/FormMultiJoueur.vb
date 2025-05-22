Imports System.Threading.Tasks

Public Class FormMultiJoueur
    ' Variables pour le mode multijoueur
    Private joueursDisponibles As New List(Of String)
    Private joueursSelectionnes As New List(Of String)
    Private scoresJoueurs As New Dictionary(Of String, Integer)
    Private indexJoueurActif As Integer = 0
    Private nbManches As Integer = 3
    Private tempsParManche As Integer = 60
    Private partieEnCours As Boolean = False
    Private cardsRevealed As New List(Of Label)
    Private cardsFound As Integer = 0
    Private tempsRestant As Integer
    Private WithEvents timer As New Timer
    Private difficulte As Integer = 1 ' 0=Facile, 1=Moyen, 2=Difficilee

    Private LblScoreJ1 As Label
    Private LblScoreJ2 As Label

    ' Variables pour stocker les références aux cartes et leurs valeurs
    Private cards As New List(Of Label)
    Private cardValues As New List(Of Integer)
    Private currentCardValue As Integer = -1
    Private fenetreCartes As Form = Nothing

    ' Méthode d'initialisation du formulaire
    Private Sub FormMultiJoueur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerJoueursDisponibles()
        timer.Interval = 1000
        InitialiserInterface()
        MettreAJourListesJoueurs()
        ActiverDesactiverBoutons()
    End Sub

    ' Méthode pour initialiser l'interface utilisateur
    Private Sub InitialiserInterface()
        ComboBox1.Items.AddRange({"Facile", "Moyen", "Difficile"})
        ComboBox1.SelectedIndex = 1

        NumericUpDownManches.Minimum = 1
        NumericUpDownManches.Maximum = 10
        NumericUpDownManches.Value = nbManches

        NumericUpDownTemps.Minimum = 30
        NumericUpDownTemps.Maximum = 120
        NumericUpDownTemps.Value = tempsParManche

        Label1.Text = ""
        Label2.Text = ""
    End Sub

    ' Méthode pour charger les joueurs depuis le module de données
    Private Sub ChargerJoueursDisponibles()
        Try
            SauvegardeJoueur.ChargerDepuisFichier()
            For Each joueur In SauvegardeJoueur.Joueurs
                joueursDisponibles.Add(joueur.Pseudo)
            Next
        Catch ex As Exception
            joueursDisponibles.AddRange({"Joueur 1", "Joueur 2", "Joueur 3"})
            MessageBox.Show("Erreur lors du chargement des joueurs: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Méthode pour mettre à jour les listes de joueurs dans l'interface
    Private Sub MettreAJourListesJoueurs()
        ListBoxJoueursDisponibles.Items.Clear()
        ListBoxJoueursDisponibles.Items.AddRange(joueursDisponibles.ToArray())

        ListBoxJoueursSelectionnes.Items.Clear()
        ListBoxJoueursSelectionnes.Items.AddRange(joueursSelectionnes.ToArray())

        MettreAJourListeScores()
    End Sub

    ' Méthode pour mettre à jour la liste des scores
    Private Sub MettreAJourListeScores()
        lstScores.Items.Clear()
        For Each joueur In joueursSelectionnes
            Dim score As Integer = If(scoresJoueurs.ContainsKey(joueur), scoresJoueurs(joueur), 0)
            lstScores.Items.Add($"{joueur}: {score} carrés")
        Next
    End Sub

    ' Gestion des boutons pour ajouter/retirer des joueurs
    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouterJoueur.Click
        If ListBoxJoueursDisponibles.SelectedIndex >= 0 Then
            Dim joueurSelectionne = ListBoxJoueursDisponibles.SelectedItem.ToString()
            joueursSelectionnes.Add(joueurSelectionne)
            joueursDisponibles.Remove(joueurSelectionne)
            scoresJoueurs(joueurSelectionne) = 0
            MettreAJourListesJoueurs()
            ActiverDesactiverBoutons()
        End If
    End Sub

    Private Sub ButtonRetirer_Click(sender As Object, e As EventArgs) Handles ButtonRetirerJoueur.Click
        If ListBoxJoueursSelectionnes.SelectedIndex >= 0 Then
            Dim joueurSelectionne = ListBoxJoueursSelectionnes.SelectedItem.ToString()
            joueursDisponibles.Add(joueurSelectionne)
            joueursSelectionnes.Remove(joueurSelectionne)
            If scoresJoueurs.ContainsKey(joueurSelectionne) Then scoresJoueurs.Remove(joueurSelectionne)
            MettreAJourListesJoueurs()
            ActiverDesactiverBoutons()
        End If
    End Sub

    ' Méthode pour activer/désactiver les boutons en fonction du contexte
    Private Sub ActiverDesactiverBoutons()
        ButtonCommencer.Enabled = (joueursSelectionnes.Count >= 2 AndAlso Not partieEnCours)
        ButtonAbandonner.Enabled = partieEnCours
        ButtonAjouterJoueur.Enabled = Not partieEnCours
        ButtonRetirerJoueur.Enabled = Not partieEnCours
        NumericUpDownManches.Enabled = Not partieEnCours
        NumericUpDownTemps.Enabled = Not partieEnCours
        ComboBox1.Enabled = Not partieEnCours
        CheckBox1.Enabled = Not partieEnCours
    End Sub

    ' Gestion du bouton pour commencer la partie
    Private Sub ButtonCommencer_Click(sender As Object, e As EventArgs) Handles ButtonCommencer.Click
        If joueursSelectionnes.Count < 2 Then
            MessageBox.Show("Il faut au moins 2 joueurs pour commencer une partie multijoueur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        nbManches = CInt(NumericUpDownManches.Value)
        tempsParManche = CInt(NumericUpDownTemps.Value)
        difficulte = ComboBox1.SelectedIndex

        For Each joueur In joueursSelectionnes
            scoresJoueurs(joueur) = 0
        Next

        If CheckBox1.Checked Then MelangerJoueurs()

        indexJoueurActif = 0
        partieEnCours = True

        InitialiserPlateau()
        AfficherCartesDansNouvelleFenetre()

        Label1.Text = "Joueur actif: " & joueursSelectionnes(indexJoueurActif)
        MettreAJourListeScores()
        ActiverDesactiverBoutons()

        tempsRestant = tempsParManche
        Label2.Text = $"Temps restant: {tempsRestant} secondes"
        timer.Start()
    End Sub

    ' Méthode pour mélanger l'ordre des joueurs
    Private Sub MelangerJoueurs()
        Dim rnd As New Random()
        Dim n As Integer = joueursSelectionnes.Count

        While n > 1
            n -= 1
            Dim k As Integer = rnd.Next(n + 1)
            Dim value As String = joueursSelectionnes(k)
            joueursSelectionnes(k) = joueursSelectionnes(n)
            joueursSelectionnes(n) = value
        End While
    End Sub

    ' Méthode pour initialiser le plateau de jeu
    Private Sub InitialiserPlateau()
        ' Fermer l'ancienne fenêtre de cartes si elle existe
        If fenetreCartes IsNot Nothing Then
            fenetreCartes.Close()
            fenetreCartes.Dispose()
            fenetreCartes = Nothing
        End If

        ' Nettoyer les cartes existantes
        cards.Clear()
        cardValues.Clear()
        cardsRevealed.Clear()
        cardsFound = 0

        ' Définir la taille du plateau selon la difficulté
        Dim lignes, colonnes As Integer
        Select Case difficulte
            Case 0 ' Facile
                lignes = 3
                colonnes = 4
            Case 1 ' Moyen
                lignes = 4
                colonnes = 5
            Case 2 ' Difficile
                lignes = 5
                colonnes = 6
        End Select

        ' Générer les valeurs des cartes (groupes de 4)
        Dim nbCarres As Integer = (lignes * colonnes) \ 4
        Dim values As New List(Of Integer)
        For i As Integer = 1 To nbCarres
            For j As Integer = 1 To 4 ' 4 cartes identiques
                values.Add(i)
            Next
        Next

        ' Mélanger les valeurs
        Dim rnd As New Random()
        For i As Integer = values.Count - 1 To 1 Step -1
            Dim j As Integer = rnd.Next(i + 1)
            Dim temp As Integer = values(j)
            values(j) = values(i)
            values(i) = temp
        Next

        ' Créer les cartes
        For i As Integer = 0 To (lignes * colonnes) - 1
            Dim lbl As New Label()
            lbl.Width = 80
            lbl.Height = 100
            lbl.BackColor = Color.SteelBlue
            lbl.ForeColor = Color.White
            lbl.BorderStyle = BorderStyle.Fixed3D
            lbl.Font = New Font("Arial", 14, FontStyle.Bold)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Tag = i
            AddHandler lbl.Click, AddressOf Card_Click

            cards.Add(lbl)
            cardValues.Add(If(i < values.Count, values(i), 0))
        Next

        currentCardValue = -1
    End Sub

    ' Méthode pour afficher les cartes dans une nouvelle fenêtre
    Private Sub AfficherCartesDansNouvelleFenetre()
        fenetreCartes = New Form()
        fenetreCartes.Text = "Plateau de Jeu"
        fenetreCartes.StartPosition = FormStartPosition.CenterScreen
        fenetreCartes.FormBorderStyle = FormBorderStyle.FixedDialog
        fenetreCartes.MaximizeBox = False
        fenetreCartes.MinimizeBox = False

        ' Création de la bande supérieure (panel)
        Dim bandeHaut As New Panel()
        bandeHaut.Height = 30
        bandeHaut.Dock = DockStyle.Top

        ' Label score J1 (à gauche)
        LblScoreJ1 = New Label()
        LblScoreJ1.Text = $"{joueursSelectionnes(0)} : {scoresJoueurs(joueursSelectionnes(0))} carrés"
        LblScoreJ1.TextAlign = ContentAlignment.MiddleLeft
        LblScoreJ1.Dock = DockStyle.Left
        LblScoreJ1.Width = 100
        LblScoreJ1.BackColor = Color.LightCyan
        LblScoreJ1.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Label temps restant (au centre)
        LblTemps = New Label()
        LblTemps.Text = $"Temps restant: {tempsRestant} secondes"
        LblTemps.TextAlign = ContentAlignment.MiddleCenter
        LblTemps.Dock = DockStyle.Fill
        LblTemps.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Label score J2 (à droite)
        LblScoreJ2 = New Label()
        LblScoreJ2.Text = $"{joueursSelectionnes(1)} : {scoresJoueurs(joueursSelectionnes(1))} carrés"
        LblScoreJ2.TextAlign = ContentAlignment.MiddleRight
        LblScoreJ2.Dock = DockStyle.Right
        LblScoreJ2.Width = 100
        LblScoreJ2.BackColor = Color.LightPink
        LblScoreJ2.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Ajout des labels au panel
        bandeHaut.Controls.Add(LblTemps)
        bandeHaut.Controls.Add(LblScoreJ2)
        bandeHaut.Controls.Add(LblScoreJ1)

        ' Déterminer la taille du plateau selon difficulté
        Dim largeur, hauteur As Integer
        Select Case difficulte
            Case 0
                largeur = 400 : hauteur = 350
            Case 1
                largeur = 550 : hauteur = 450
            Case 2
                largeur = 700 : hauteur = 550
        End Select

        fenetreCartes.ClientSize = New Size(largeur, hauteur + bandeHaut.Height)

        ' Ajout de la bande en haut
        fenetreCartes.Controls.Add(bandeHaut)

        ' Création du TableLayoutPanel pour les cartes
        Dim tableLayout As New TableLayoutPanel()
        tableLayout.Location = New Point(0, bandeHaut.Height)
        tableLayout.Size = New Size(largeur, hauteur)
        tableLayout.Margin = New Padding(0)
        tableLayout.Padding = New Padding(0)
        tableLayout.BackColor = Color.Transparent

        fenetreCartes.Controls.Add(tableLayout)

        ' Lignes et colonnes selon difficulté
        Dim lignes, colonnes As Integer
        Select Case difficulte
            Case 0 : lignes = 3 : colonnes = 4
            Case 1 : lignes = 4 : colonnes = 5
            Case 2 : lignes = 5 : colonnes = 6
        End Select

        tableLayout.ColumnCount = colonnes
        tableLayout.RowCount = lignes

        ' Styles proportionnels
        For i As Integer = 0 To colonnes - 1
            tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
        Next
        For i As Integer = 0 To lignes - 1
            tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
        Next

        ' Ajout des cartes dans le tableLayout
        For i As Integer = 0 To cards.Count - 1
            Dim card = cards(i)
            card.Margin = New Padding(2)
            tableLayout.Controls.Add(card, i Mod colonnes, i \ colonnes)
        Next

        fenetreCartes.Show()
    End Sub


    ' Méthode pour gérer le click sur une carte
    Private Sub Card_Click(sender As Object, e As EventArgs)
        If Not partieEnCours Then Return

        Dim clickedCard As Label = DirectCast(sender, Label)
        If clickedCard.Enabled = False OrElse cardsRevealed.Contains(clickedCard) Then Return

        Dim index As Integer = CInt(clickedCard.Tag)
        Dim cardValue As Integer = cardValues(index)

        ' Afficher la carte avec la couleur du joueur actif
        clickedCard.Text = cardValue.ToString()
        clickedCard.BackColor = playerColors(indexJoueurActif Mod playerColors.Count)
        cardsRevealed.Add(clickedCard)

        If currentCardValue = -1 Then
            currentCardValue = cardValue
        ElseIf currentCardValue <> cardValue Then
            ' Les cartes ne correspondent pas
            timer.Stop()
            Dim retournerTimer As New Timer() With {.Interval = 1000}

            AddHandler retournerTimer.Tick, Sub(s, args)
                                                For Each card In cardsRevealed
                                                    card.Text = ""
                                                    card.BackColor = Color.SteelBlue
                                                Next
                                                cardsRevealed.Clear()
                                                currentCardValue = -1
                                                PasserAuJoueurSuivant()
                                                tempsRestant = tempsParManche
                                                Label2.Text = $"Temps restant: {tempsRestant} secondes"
                                                timer.Start()
                                                CType(s, Timer).Stop()
                                                CType(s, Timer).Dispose()
                                            End Sub

            retournerTimer.Start()
        ElseIf cardsRevealed.Count = 4 Then ' On vérifie maintenant 4 cartes au lieu de 2
            ' Les 4 cartes correspondent
            Dim joueurActif As String = joueursSelectionnes(indexJoueurActif)
            scoresJoueurs(joueurActif) += 1

            For Each card In cardsRevealed
                card.Enabled = False
                card.BackColor = Color.LightGray ' Couleur pour les cartes trouvées
            Next

            cardsRevealed.Clear()
            currentCardValue = -1
            cardsFound += 1

            MettreAJourListeScores()

            ' Vérifier si toutes les paires ont été trouvées
            If cardsFound = cardValues.Count \ 4 Then ' Divisé par 4 maintenant
                FinDeLaPartie()
            Else
                ' Continuer avec le même joueur s'il a trouvé une paire
                Label1.Text = "Joueur actif: " & joueursSelectionnes(indexJoueurActif)
                tempsRestant = tempsParManche
                Label2.Text = $"Temps restant: {tempsRestant} secondes"
            End If
        End If
    End Sub
    ' Méthode pour passer au joueur suivant
    Private Sub PasserAuJoueurSuivant()
        indexJoueurActif = (indexJoueurActif + 1) Mod joueursSelectionnes.Count
        Label1.Text = "Joueur actif: " & joueursSelectionnes(indexJoueurActif)
        ' Changer la couleur du label pour indiquer le joueur actif
        Label1.ForeColor = playerColors(indexJoueurActif Mod playerColors.Count)
    End Sub

    ' Méthode appelée à chaque tick du timer principal
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        tempsRestant -= 1
        LblTemps.Text = $"Temps restant: {tempsRestant} secondes"
        LblScoreJ1.Text = $"{joueursSelectionnes(0)} : {scoresJoueurs(joueursSelectionnes(0))} carrés"
        LblScoreJ2.Text = $"{joueursSelectionnes(1)} : {scoresJoueurs(joueursSelectionnes(1))} carrés"


        If tempsRestant <= 0 Then
            timer.Stop()
            For Each card As Label In cardsRevealed
                card.Text = ""
                card.BackColor = Color.SteelBlue
            Next
            cardsRevealed.Clear()
            currentCardValue = -1
            PasserAuJoueurSuivant()
            tempsRestant = tempsParManche
            timer.Start()
        End If
    End Sub

    ' Méthode pour gérer la fin de la partie
    Private Sub FinDeLaPartie()
        timer.Stop()
        partieEnCours = False

        Dim scoreMax As Integer = If(scoresJoueurs.Count > 0, scoresJoueurs.Values.Max(), 0)
        Dim gagnants = joueursSelectionnes.Where(Function(j) scoresJoueurs(j) = scoreMax).ToList()

        Dim message As String = If(gagnants.Count = 1,
                                $"Le gagnant est {gagnants(0)} avec {scoreMax} carrés trouvés!",
                                $"Il y a une égalité entre: {String.Join(", ", gagnants)} avec {scoreMax} carrés trouvés!")

        MessageBox.Show(message, "Fin de la partie", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Mettre à jour les statistiques des joueurs
        For Each joueur In joueursSelectionnes
            Try
                Dim joueurIndex = SauvegardeJoueur.Joueurs.FindIndex(Function(j) j.Pseudo = joueur)
                If joueurIndex >= 0 Then
                    Dim j = SauvegardeJoueur.Joueurs(joueurIndex)
                    j.NbPartie += 1
                    j.ScoreMax = Math.Max(j.ScoreMax, scoresJoueurs(joueur))
                    SauvegardeJoueur.Joueurs(joueurIndex) = j
                End If
            Catch ex As Exception
                MessageBox.Show("Erreur lors de la mise à jour des statistiques: " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next

        SauvegardeJoueur.SauvegarderDansFichier()
        ActiverDesactiverBoutons()

        ' Fermer la fenêtre des cartes
        If fenetreCartes IsNot Nothing Then
            fenetreCartes.Close()
            fenetreCartes.Dispose()
            fenetreCartes = Nothing
        End If
    End Sub

    ' Méthode pour abandonner la partie
    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click
        If Not partieEnCours Then Return

        If MessageBox.Show("Êtes-vous sûr de vouloir abandonner la partie en cours?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            timer.Stop()
            partieEnCours = False

            ' Fermer la fenêtre des cartes
            If fenetreCartes IsNot Nothing Then
                fenetreCartes.Close()
                fenetreCartes.Dispose()
                fenetreCartes = Nothing
            End If

            cards.Clear()
            cardValues.Clear()
            ActiverDesactiverBoutons()
            MessageBox.Show("La partie a été abandonnée.", "Partie abandonnée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Méthode pour retourner au menu principal
    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        If partieEnCours Then
            If MessageBox.Show("Une partie est en cours. Êtes-vous sûr de vouloir quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            timer.Stop()
        End If

        Me.Close()
    End Sub

    ' Gestionnaire d'événement pour fermeture du formulaire
    Private Sub FormMultiJoueur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If partieEnCours AndAlso e.CloseReason = CloseReason.UserClosing Then
            If MessageBox.Show("Une partie est en cours. Êtes-vous sûr de vouloir quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            Else
                timer.Stop()
            End If
        End If
    End Sub

    ' Gestionnaires pour les changements de configuration
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownManches.ValueChanged
        nbManches = CInt(NumericUpDownManches.Value)
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownTemps.ValueChanged
        tempsParManche = CInt(NumericUpDownTemps.Value)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        difficulte = ComboBox1.SelectedIndex
    End Sub

    Private playerColors As New List(Of Color) From {
    Color.LightBlue,
    Color.LightPink,
    Color.LightGreen,
    Color.LightYellow,
    Color.LightCoral,
    Color.LightSeaGreen
}

End Class