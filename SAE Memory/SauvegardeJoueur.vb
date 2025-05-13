Imports System.IO

Public Module SauvegardeJoueur

    Dim cheminFichier As String = "joueurs.txt"

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
        ' Trouver le joueur existant ou créer un nouveau
        Dim index As Integer = Joueurs.FindIndex(Function(j) j.Pseudo = P)

        If index >= 0 Then
            ' Mettre à jour le joueur existant
            Dim j = Joueurs(index)
            j.ScoreMax = Math.Max(j.ScoreMax, S)
            j.TempsMin = If(S >= j.ScoreMax, Math.Min(j.TempsMin, tmp), j.TempsMin)
            j.NbPartie += 1
            j.TempsTotalJouer += tmp
            Joueurs(index) = j
        Else
            ' Ajouter un nouveau joueur
            Joueurs.Add(New Joueur With {
            .Pseudo = P,
            .ScoreMax = S,
            .TempsMin = tmp,
            .NbPartie = 1,
            .TempsTotalJouer = tmp
        })
        End If

        ' Mettre à jour le joueur courant
        SauvegardeJoueur.P = P
        SauvegarderDansFichier()
    End Sub
    Public Function ObtenirJoueur(pseudo As String) As Joueur?
        Return Joueurs.FirstOrDefault(Function(j) j.Pseudo = pseudo)
    End Function

    Public Sub SauvegarderDansFichier()
        Dim lignes As New List(Of String)
        For Each j In Joueurs
            lignes.Add($"{j.Pseudo};{j.ScoreMax};{j.TempsMin};{j.NbPartie};{j.TempsTotalJouer}")
        Next
        IO.File.WriteAllLines(cheminFichier, lignes)
    End Sub

    Public Sub ChargerDepuisFichier()
        Joueurs.Clear()
        If IO.File.Exists(cheminFichier) Then
            Dim lignes = IO.File.ReadAllLines(cheminFichier)
            For Each ligne In lignes
                Dim parties = ligne.Split(";"c)
                If parties.Length = 5 Then
                    Joueurs.Add(New Joueur With {
                    .Pseudo = parties(0),
                    .ScoreMax = CInt(parties(1)),
                    .TempsMin = CInt(parties(2)),
                    .NbPartie = CInt(parties(3)),
                    .TempsTotalJouer = CInt(parties(4))
                })
                End If
            Next
        End If
    End Sub



End Module
