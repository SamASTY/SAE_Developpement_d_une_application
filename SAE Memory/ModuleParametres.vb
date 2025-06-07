Imports System.IO

Module ModuleParametres
    Public Enum NiveauDifficulte
        Debutant = 0
        Intermediaire = 1
        Expert = 2
    End Enum

    Public ReadOnly Difficulte() As String = {"Debutant", "Intermediaire", "Expert"}

    Public dossierImages As String = "images"

    Public DifActuelle As NiveauDifficulte = NiveauDifficulte.Debutant

    Public Const TempsPartie As Integer = 60


    Public LignesPersonnalisees As Integer = 4

    Dim Indice As Boolean = False

    Public Sub CocheIndice(Etat As Boolean)
        Indice = Etat
    End Sub

    Public Function IndiceEtat() As Boolean
        Return Indice
    End Function

    Dim Personaliser As Boolean = False

    Public Function PersonaliserEtat() As Boolean
        Return Personaliser
    End Function

    Public Sub CochePersonaliser()
        Personaliser = Not Personaliser
    End Sub



End Module
