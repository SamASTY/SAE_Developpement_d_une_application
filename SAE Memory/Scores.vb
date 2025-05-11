Public Class formScore
    Dim ordreCroissant As Boolean = False

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
        Me.Close()
        Dim jeuForm As New Jeu()
        jeuForm.Show()
    End Sub

    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs) Handles buttonQuitter.Click
        Dim reponse = MsgBox("Voulez-vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class