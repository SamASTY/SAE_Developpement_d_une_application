﻿Imports System.IO

Public Class FormMultiJoueur
    ' Variables pour le mode multijoueur
    Private joueursDisponibles As New List(Of String)
    Private joueursSelectionnes As New List(Of String)
    Private scoresJoueurs As New Dictionary(Of String, Integer)
    Private indexJoueurActif As Boolean ' true = J1, false = J2
    Private nbManches As Integer = 3
    Private tempsParManche As Integer = ModuleParametres.TempsPartie
    Private partieEnCours As Boolean = False
    Private cardsRevealed As New List(Of Label)
    Private cardsFound As Integer = 0
    Private tempsRestant As Integer
    Private WithEvents timer As New Timer
    Private difficulte As Integer = 1 ' 0=Facile, 1=Intermediaire, 2=Expert

    Private LblScoreJ1 As Label
    Private LblScoreJ2 As Label
    Private LblTemps As Label

    Private JoueurEnJeu As String

    Private Joueur1 As String
    Private Joueur2 As String

    Private cheminImages As String = Path.Combine(Application.StartupPath, "Images")
    Private cheminVerso As String = Path.Combine(cheminImages, "verso.jpeg")

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
        ActiverDesactiverBoutons()
    End Sub

    ' Méthode pour initialiser l'interface utilisateur
    Private Sub InitialiserInterface()
        ComboBoxDifficulte.Items.AddRange({"Facile", "Intermediaire", "Expert"})
        ComboBoxDifficulte.SelectedIndex = 1
    End Sub

    ' Méthode pour charger les joueurs depuis le module de données
    Private Sub ChargerJoueursDisponibles()
        SauvegardeJoueur.ChargerDepuisFichier()
        For Each joueur In SauvegardeJoueur.Joueurs
            cmbox_Joueur1.Items.Add(joueur.Pseudo)
            cmbox_Joueur2.Items.Add(joueur.Pseudo)
        Next
    End Sub

    ' Méthode pour mettre à jour la liste des scores
    Private Sub MettreAJourListeScores()
        lstScores.Items.Clear()

        If cmbox_Joueur1.SelectedItem IsNot Nothing Then
            Dim joueur1 As String = cmbox_Joueur1.SelectedItem.ToString()
            Dim score1 As Integer = If(scoresJoueurs.ContainsKey(joueur1), scoresJoueurs(joueur1), 0)
            lstScores.Items.Add($"{joueur1}: {score1} carrés")
        End If

        If cmbox_Joueur2.SelectedItem IsNot Nothing Then
            Dim joueur2 As String = cmbox_Joueur2.SelectedItem.ToString()
            Dim score2 As Integer = If(scoresJoueurs.ContainsKey(joueur2), scoresJoueurs(joueur2), 0)
            lstScores.Items.Add($"{joueur2}: {score2} carrés")
        End If

    End Sub

    ' Méthode pour activer/désactiver les boutons en fonction du contexte
    Private Sub ActiverDesactiverBoutons()
        ButtonAbandonner.Enabled = partieEnCours
        ComboBoxDifficulte.Enabled = Not partieEnCours
    End Sub

    ' Gestion du bouton pour commencer la partie
    Private Sub ButtonCommencer_Click(sender As Object, e As EventArgs) Handles ButtonCommencer.Click
        If cmbox_Joueur1.SelectedItem Is Nothing AndAlso cmbox_Joueur2.SelectedItem Is Nothing Then
            MessageBox.Show("Il vous faut 2 joueurs pour commencer une partie multijoueur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Joueur1 = cmbox_Joueur1.SelectedItem.ToString
            Joueur2 = cmbox_Joueur2.SelectedItem.ToString

            difficulte = ComboBoxDifficulte.SelectedIndex

            scoresJoueurs(Joueur1) = 0
            scoresJoueurs(Joueur2) = 0

            indexJoueurActif = True
            partieEnCours = True

            InitialiserPlateau()
            AfficherCartesDansNouvelleFenetre()

            MettreAJourListeScores()
            ActiverDesactiverBoutons()

            tempsRestant = tempsParManche
            timer.Start()
        End If


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

        ' Créer les cartes avec des images
        For i As Integer = 0 To (lignes * colonnes) - 1
            Dim lbl As New Label()
            lbl.Width = 80
            lbl.Height = 100
            lbl.BackColor = Color.White
            lbl.BorderStyle = BorderStyle.FixedSingle
            lbl.Tag = i
            lbl.Image = RedimImg(Image.FromFile(cheminVerso), lbl)
            AddHandler lbl.Click, AddressOf Card_Click

            cards.Add(lbl)
            cardValues.Add(If(i < values.Count, values(i), 0))
        Next

        currentCardValue = -1
    End Sub

    Private Function RedimImg(img As Image, lbl As Label) As Image
        ' Crée une nouvelle bitmap aux dimensions du label
        Dim bmp As New Bitmap(lbl.Width, lbl.Height)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            ' Calcule le ratio pour conserver les proportions
            Dim ratioX As Double = lbl.Width / img.Width
            Dim ratioY As Double = lbl.Height / img.Height
            Dim ratio As Double = Math.Min(ratioX, ratioY)

            Dim newWidth As Integer = CInt(img.Width * ratio)
            Dim newHeight As Integer = CInt(img.Height * ratio)

            ' Positionne l'image au centre
            Dim posX As Integer = (lbl.Width - newWidth) \ 2
            Dim posY As Integer = (lbl.Height - newHeight) \ 2

            ' Dessine l'image redimensionnée
            g.DrawImage(img, posX, posY, newWidth, newHeight)
        End Using

        Return bmp
    End Function

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
        LblScoreJ1.Text = $"{Joueur1} : {scoresJoueurs(Joueur1)} carrés"
        LblScoreJ1.TextAlign = ContentAlignment.MiddleLeft
        LblScoreJ1.Dock = DockStyle.Left
        LblScoreJ1.Width = 100
        LblScoreJ1.BackColor = Color.LightCyan
        LblScoreJ1.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Label temps restant (au centre)
        LblTemps = New Label()
        LblTemps.BackColor = Color.Gray
        LblTemps.ForeColor = Color.LightCyan
        LblTemps.Text = $"Temps : {tempsParManche} s {vbCrLf} Joueur actif: " & If(indexJoueurActif = True, Joueur1, Joueur2)
        LblTemps.TextAlign = ContentAlignment.MiddleCenter
        LblTemps.Dock = DockStyle.Fill
        LblTemps.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Label score J2 (à droite)
        LblScoreJ2 = New Label()
        LblScoreJ2.Text = $"{Joueur2} : {scoresJoueurs(Joueur2)} carrés"
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
    Private Async Sub Card_Click(sender As Object, e As EventArgs)
        If Not partieEnCours Then Return

        Dim clickedCard As Label = DirectCast(sender, Label)
        If clickedCard.Enabled = False OrElse cardsRevealed.Contains(clickedCard) Then Return

        Dim index As Integer = CInt(clickedCard.Tag)
        Dim cardValue As Integer = cardValues(index)

        ' Afficher l'image de la carte
        Dim cheminImage As String = Path.Combine(cheminImages, $"{cardValue}.jpeg")
        If File.Exists(cheminImage) Then
            clickedCard.Image = RedimImg(Image.FromFile(cheminImage), clickedCard)
        Else
            clickedCard.Text = cardValue.ToString()
        End If

        clickedCard.BackColor = playerColors(If(indexJoueurActif = True, 0, 1))
        cardsRevealed.Add(clickedCard)

        If currentCardValue = -1 Then
            currentCardValue = cardValue
        ElseIf currentCardValue <> cardValue Then
            partieEnCours = False
            Await Task.Delay(500)
            partieEnCours = True
            ' Les cartes ne correspondent pas
            For Each card In cardsRevealed
                card.Image = RedimImg(Image.FromFile(cheminVerso), card)
                card.BackColor = Color.White
            Next
            cardsRevealed.Clear()
            currentCardValue = -1
            PasserAuJoueurSuivant()
            tempsRestant = tempsParManche
        ElseIf cardsRevealed.Count = 4 Then
            ' Les 4 cartes correspondent
            Dim joueurActif As String = If(indexJoueurActif = True, Joueur1, Joueur2)
            scoresJoueurs(joueurActif) += 1

            For Each card In cardsRevealed
                card.Enabled = False
                card.BackColor = Color.LightGray
            Next

            cardsRevealed.Clear()
            currentCardValue = -1
            cardsFound += 1

            MettreAJourListeScores()
            LblScoreJ1.Text = $"{Joueur1} : {scoresJoueurs(Joueur1)} carrés"
            LblScoreJ2.Text = $"{Joueur2} : {scoresJoueurs(Joueur2)} carrés"

            If cardsFound = cardValues.Count \ 4 Then
                FinDeLaPartie()
            Else
                tempsRestant = tempsParManche
            End If
        End If
    End Sub

    ' Méthode pour passer au joueur suivant
    Private Sub PasserAuJoueurSuivant()
        indexJoueurActif = Not indexJoueurActif
        JoueurEnJeu = "Joueur actif: " & If(indexJoueurActif = True, Joueur1, Joueur2)
        ' Changer la couleur du label pour indiquer le joueur actif
        LblTemps.ForeColor = playerColors(If(indexJoueurActif = True, 0, 1))
    End Sub

    ' Méthode appelée à chaque tick du timer principal
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        tempsRestant -= 1

        LblScoreJ1.Text = $"{Joueur1} : {scoresJoueurs(Joueur1)} carrés"
        LblScoreJ2.Text = $"{Joueur2} : {scoresJoueurs(Joueur2)} carrés"

        LblTemps.Text = $"Temps : {tempsRestant} s {vbCrLf} Joueur actif: " & If(indexJoueurActif = True, Joueur1, Joueur2)

        If tempsRestant <= 0 Then
            timer.Stop()
            For Each card As Label In cardsRevealed
                card.Text = ""
                card.BackColor = Color.SteelBlue
            Next
            If difficulte = 0 Then
                tempsParManche = 20
            ElseIf difficulte = 1 Then
                tempsParManche = 40
            Else
                tempsParManche = 60
            End If
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


        Dim gagnant As String = If(scoresJoueurs(Joueur1) > scoresJoueurs(Joueur2), Joueur1, Joueur2)
        Dim egalite As Boolean = scoresJoueurs(Joueur1) = scoresJoueurs(Joueur2)

        Dim message As String = If(egalite = False,
                                    $"Le gagnant est {gagnant} avec {scoresJoueurs(gagnant)} carrés trouvés!",
                                    $"Il y a une égalité entre: " & Joueur1 & " et" & Joueur2 & " avec {scoresJoueurs(gagnant)} carrés trouvés!")

        MessageBox.Show(message, "Fin de la partie", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    Private Sub ComboBoxDifficulte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDifficulte.SelectedIndexChanged
        difficulte = ComboBoxDifficulte.SelectedIndex
    End Sub

    Private playerColors As New List(Of Color) From {
        Color.LightBlue,
        Color.LightPink
    }

    Private Sub cmbox_Joueur1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbox_Joueur1.SelectedIndexChanged
        If cmbox_Joueur1.SelectedItem IsNot Nothing AndAlso cmbox_Joueur2.SelectedItem IsNot Nothing Then
            If cmbox_Joueur1.SelectedItem.ToString() = cmbox_Joueur2.SelectedItem.ToString() Then
                MsgBox("Vous ne pouvez pas choisir le même joueur deux fois")
                cmbox_Joueur1.SelectedIndex = -1
                Exit Sub
            End If
        End If

        MettreAJourListeScores()
    End Sub

    Private Sub cmbox_Joueur2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbox_Joueur2.SelectedIndexChanged
        If cmbox_Joueur2.SelectedItem IsNot Nothing AndAlso cmbox_Joueur1.SelectedItem IsNot Nothing Then
            If cmbox_Joueur2.SelectedItem.ToString() = cmbox_Joueur1.SelectedItem.ToString() Then
                MsgBox("Vous ne pouvez pas choisir le même joueur deux fois")
                cmbox_Joueur2.SelectedIndex = -1
                Exit Sub
            End If
        End If

        MettreAJourListeScores()
    End Sub

    Private Sub BtnRegles_Click(sender As Object, e As EventArgs) Handles BtnRegles.Click
        AfficherReglesDuJeu()
    End Sub
    Private Sub AfficherReglesDuJeu()
        Dim regles As String = " RÈGLES DU JEU MULTIJOUEUR - MEMORY CARRÉS 🎮" & vbCrLf & vbCrLf &
                                  "OBJECTIF :" & vbCrLf &
                                  "Trouvez le maximum de carrés (groupes de 4 cartes identiques) en alternant avec votre adversaire." & vbCrLf & vbCrLf &
                                  "PRÉPARATION :" & vbCrLf &
                                  "• Sélectionnez 2 joueurs différents dans les listes déroulantes" & vbCrLf &
                                  "• Choisissez le niveau de difficulté :" & vbCrLf &
                                  "  - Facile : 3x4 cartes (12 cartes), 20 secondes" & vbCrLf &
                                  "  - Moyen : 4x5 cartes (20 cartes), 40 secondes" & vbCrLf &
                                  "  - Difficile : 5x6 cartes (30 cartes), 60 secondes" & vbCrLf & vbCrLf &
                                  "🎯 DÉROULEMENT :" & vbCrLf &
                                  "1. Le premier joueur commence et a un temps limité pour jouer" & vbCrLf &
                                  "2. Cliquez sur les cartes pour les révéler une par une" & vbCrLf &
                                  "3. Vous devez trouver 4 cartes identiques pour former un carré" & vbCrLf &
                                  "4. Si vous trouvez un carré complet, vous gagnez 1 point et continuez" & vbCrLf &
                                  "5. Si vous révélez une carte différente, toutes les cartes se retournent" & vbCrLf &
                                  "6. C'est alors au tour de l'adversaire" & vbCrLf & vbCrLf &
                                  "TEMPS :" & vbCrLf &
                                  "• Chaque joueur dispose d'un temps limité pour son tour" & vbCrLf &
                                  "• Si le temps s'écoule, les cartes se retournent automatiquement" & vbCrLf &
                                  "• C'est au tour du joueur suivant" & vbCrLf & vbCrLf &
                                  "🏆 VICTOIRE :" & vbCrLf &
                                  "• Le joueur qui trouve le plus de carrés gagne la partie" & vbCrLf &
                                  "• En cas d'égalité, c'est un match nul" & vbCrLf & vbCrLf &
                                  "💡 CONSEILS :" & vbCrLf &
                                  "• Mémorisez les positions des cartes révélées" & vbCrLf &
                                  "• Soyez stratégique dans vos choix" & vbCrLf &
                                  "• Utilisez bien votre temps imparti" & vbCrLf & vbCrLf &
                                  "Bonne chance et amusez-vous bien ! 🎉"

        ' Affichage dans une MessageBox avec défilement possible
        MessageBox.Show(regles, "Règles du jeu - Mode Multijoueur", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class