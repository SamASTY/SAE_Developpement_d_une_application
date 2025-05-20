Module ModuleParametres
    Public Enum NiveauDifficulte
        Debutant = 0
        Intermediaire = 1
        Expert = 2
    End Enum

    Public ReadOnly Difficulte() As String = {"Debutant", "Intermediaire", "Expert"}

    ' Difficulte par défaut
    Public DifActuelle As String = Difficulte(NiveauDifficulte.Debutant)

    Public Const TempsMaxDebutant As Integer = 90
    Public Const TempsMaxIntermediaire As Integer = 60
    Public Const TempsMaxExpert As Integer = 30



End Module
