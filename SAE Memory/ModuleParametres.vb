Module ModuleParametres
    Public Enum NiveauDifficulte
        Debutant = 0
        Intermediaire = 1
        Expert = 2
    End Enum

    Public ReadOnly Difficulte() As String = {"Debutant", "Intermediaire", "Expert"}

    ' Difficulte par défaut
    Public DifActuelle As String = Difficulte(NiveauDifficulte.Debutant)

    ' Temps en secondes
    Public Const TempsMaxDebutant As Integer = 90
    Public Const TempsMaxIntermediaire As Integer = 60
    Public Const TempsMaxExpert As Integer = 30

    ' Nombre de cartes par set (4 pour le moments)
    Public Const CarteParSetDebutant As Integer = 4
    Public Const CarteParSetIntermediaire As Integer = 4
    Public Const CarteParSetExpert As Integer = 4

    ' Nombre de sets (lignes)
    Public Const NbreDeSetDebutant As Integer = 4 ' corrige ici pour que ça soit 4 lignes (exemple)
    Public Const NbreDeSetIntermediaire As Integer = 5
    Public Const NbreDeSetExpert As Integer = 6

    Public Function NombrePairesParDifficulte(niveau As NiveauDifficulte) As Integer
        Select Case niveau
            Case NiveauDifficulte.Debutant
                Return 8  ' 8 paires = 16 cartes
            Case NiveauDifficulte.Intermediaire
                Return 12 ' 12 paires = 24 cartes
            Case NiveauDifficulte.Expert
                Return 14 ' 14 paires = 28 cartes
            Case Else
                Return 8 'par defaut si erreur
        End Select
    End Function

    Dim Triche As Boolean = False
End Module
