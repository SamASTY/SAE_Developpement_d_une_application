Public Module SauvegardeJoueur
    Public Structure Joueur
        Public Pseudo As String
        Public ScoreMax As Integer
        Public TempsMin As Integer
        Public NbPartie As Integer
        Public TempsTotalJouer As Integer
    End Structure

    Public P As String
    Public S As Integer
    Public Tmp As Integer
    Public Joueurs As New List(Of Joueur)

    Public Sub EnregistrerJoueur(P As String, S As Integer, tmp As Integer)
        Dim joueurExist As Joueur? = Joueurs.FirstOrDefault(Function(j) j.Pseudo = P)

        If joueurExist.HasValue Then
            ' Si joueur existe, mettre à jour les données
            Dim joueur As Joueur = joueurExist.Value
            joueur.ScoreMax = Math.Max(joueur.ScoreMax, S)
            joueur.TempsMin = Math.Min(joueur.TempsMin, tmp)
            joueur.NbPartie += 1
            joueur.TempsTotalJouer += tmp

            Dim index As Integer = Joueurs.FindIndex(Function(j) j.Pseudo = P)
            If index >= 0 Then
                Joueurs(index) = joueur
            End If
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
    Public Function ObtenirJoueur(pseudo As String) As Joueur?
        Return Joueurs.FirstOrDefault(Function(j) j.Pseudo = pseudo)
    End Function

End Module
