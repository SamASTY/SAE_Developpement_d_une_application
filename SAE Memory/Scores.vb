Public Class formScore
    Private Sub formScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Réinitialiser les éléments de la ComboBox
        comboBoxJoueurValeur.Items.Clear()
        Debug.WriteLine("Nb joueurs : " & SauvegardeJoueur.Joueurs.Count)
        ' Remplir la ComboBox avec les pseudos des joueurs
        For Each j As SauvegardeJoueur.Joueur In SauvegardeJoueur.Joueurs
            Debug.WriteLine("Ajout joueur à ComboBox : " & j.Pseudo)
            comboBoxJoueurValeur.Items.Add(j.Pseudo)
        Next
        ' Sélectionner par défaut le joueur actuel (si son pseudo est déjà défini dans SauvegardeJoueur.P)
        Dim joueur = SauvegardeJoueur.ObtenirJoueur(SauvegardeJoueur.P)

        If joueur.HasValue Then
            comboBoxJoueurValeur.Text = joueur.Value.Pseudo
            labelMaxValeur.Text = joueur.Value.ScoreMax.ToString()
            labelMinValeur.Text = joueur.Value.TempsMin.ToString() & " sec"
            labelNbrePartieValeur.Text = joueur.Value.NbPartie.ToString()
            labelTempsValeur.Text = joueur.Value.TempsTotalJouer.ToString() & " sec"
        End If
    End Sub

    Private Sub comboBoxJoueurValeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxJoueurValeur.SelectedIndexChanged
        ' Récupérer le joueur sélectionné dans la ComboBox
        Dim pseudo As String = comboBoxJoueurValeur.SelectedItem.ToString()
        Dim joueur = SauvegardeJoueur.ObtenirJoueur(pseudo)

        If joueur.HasValue Then
            ' Mettre à jour les informations du joueur dans les labels
            labelMaxValeur.Text = joueur.Value.ScoreMax.ToString()
            labelMinValeur.Text = joueur.Value.TempsMin.ToString() & " sec"
            labelNbrePartieValeur.Text = joueur.Value.NbPartie.ToString()
            labelTempsValeur.Text = joueur.Value.TempsTotalJouer.ToString() & " sec"
        End If
    End Sub

    Private Sub buttonRejouer_Click(sender As Object, e As EventArgs) Handles buttonRejouer.Click
        ' Rejouer la partie
        ' Code pour relancer le jeu ou afficher une nouvelle instance du formulaire
        Me.Close() ' Ferme le formulaire actuel
        Dim jeuForm As New Jeu()
        jeuForm.Show() ' Ouvre le jeu
    End Sub

    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs) Handles buttonQuitter.Click
        ' Quitter l'application
        Dim reponse = MsgBox("Voulez vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
