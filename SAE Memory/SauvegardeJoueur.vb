Module SauvegardeJoueur
    Public Structure Joueur
        Public Pseudo As String
        Public ScoreMax As Integer
        Public TempsMin As Integer
        Public NbPartie As Integer
        Public TempsTotalJouer As Integer
    End Structure

    Dim P As String
    Dim S As Integer
    Dim Tmp As Integer
    Dim Joueurs As New List(Of Joueur)

    Public Sub EnregistrerJoueur(P As String, S As Integer, tmp As Integer)
        Dim joueurExist As Joueur? = Joueurs.FirstOrDefault(Function(j) j.Pseudo = P)

        If joueurExist.HasValue Then
            ' Si joueur existe, mettre à jour les données
            Dim joueur As Joueur = joueurExist.Value
            joueur.ScoreMax = Math.Max(joueur.ScoreMax, S)
            joueur.TempsMin = Math.Min(joueur.TempsMin, tmp)
            joueur.NbPartie += 1
            joueur.TempsTotalJouer += tmp

            Joueurs(Joueurs.IndexOf(joueurExist.Value)) = joueur
        Else
            ' Si le joueur n'existe pas, on l'ajoute
            Joueurs.Add(New Joueur With {
                .Pseudo = P,
                .ScoreMax = S,
                .TempsMin = tmp,
                .NbPartie = 1,
                .TempsTotalJouer = tmp
            })
        End If
    End Sub

    Public Sub RecupererScore(Score As Integer)
        S = Score
    End Sub

    Public Sub RecupererTemps(Temps As Integer)
        Tmp = Temps
    End Sub
    Public Sub RecupererPseudo(J As String)
        P = J
    End Sub

End Module
