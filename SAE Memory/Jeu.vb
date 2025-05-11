Imports System.Drawing.Drawing2D
Imports System.Diagnostics

Public Class Jeu
    Dim joueurNom As String
    Dim cpt As Integer = 0
    Dim TempsMax As Integer = 5
    Dim CarteRetourne As List(Of Label)
    Dim nbMaxCarteRetourner As Integer = 5
    Dim compteurCarte As Integer = 0
    Dim CarteGagner As List(Of Label)

    Public Sub RecupererJoueur(J As String)
        joueurNom = J
    End Sub
    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles ButtonAbandon.Click
        Dim reponse = MsgBox("Voulez-vous vraiment quitter l'application ?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        Else
            Me.Hide()
            Accueil.Show()
        End If
    End Sub
    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Chargement du formulaire score — joueur actuel : " & SauvegardeJoueur.P)
        Timer.Interval = 1000
        LabelTimer.Text = TempsMax
        Timer.Start()
        InitJeu()
        LabelPseudo.Text = joueurNom
    End Sub
    Private Sub InitJeu()
        Dim cartes As List(Of Integer) = GenererListe4X5()
        CarteRetourne = New List(Of Label)
        CarteGagner = New List(Of Label)

        For i As Integer = 1 To 20
            Dim labelName As String = "L_Carte" & i.ToString("00")
            Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)

            If label IsNot Nothing Then
                label.Tag = cartes(i - 1)
                AddHandler label.Click, AddressOf Carte_Click
                'label.Image = My.Resources.noir
                label.Text = label.Tag
            End If
        Next
    End Sub
    Private Sub ResetPlateauErreur()
        For i As Integer = 1 To 20
            Dim labelName As String = "L_Carte" & i.ToString("00")
            Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)
            If label IsNot Nothing AndAlso Not CarteGagner.Any(Function(c) c.Name = label.Name) Then
                label.Image = My.Resources.noir
            End If
        Next
    End Sub

    Private Function GenererListe4X5() As List(Of Integer)
        Dim Paquet As New List(Of Integer)

        For valeur As Integer = 1 To 5
            For i As Integer = 1 To 4
                Paquet.Add(valeur)
            Next
        Next

        MelangePaquet(Paquet)

        Return Paquet
    End Function

    Private Sub MelangePaquet(Paquet As List(Of Integer))
        Dim rng As New Random()

        For i As Integer = 0 To Paquet.Count - 1
            Dim j As Integer = rng.Next(i, Paquet.Count)

            ' Échange les éléments Paquet(i) et Paquet(j)
            Dim temp = Paquet(i)
            Paquet(i) = Paquet(j)
            Paquet(j) = temp
        Next
    End Sub

    Private Sub Carte_Click(sender As Object, e As EventArgs)
        'faire en sorte que la compte pas si la carte est deja retournée
        Dim label As Label = CType(sender, Label)

        If Not (CarteGagner.Contains(label) Or CarteRetourne.Contains(label)) Then
            If label.Tag = 1 Then
                label.Image = My.Resources._1
            ElseIf label.Tag = 2 Then
                label.Image = My.Resources._2
            ElseIf label.Tag = 3 Then
                label.Image = My.Resources._3
            ElseIf label.Tag = 4 Then
                label.Image = My.Resources._4
            ElseIf label.Tag = 5 Then
                label.Image = My.Resources._5
            End If

            compteurCarte += 1


            CarteRetourne.Add(label)

            ' Verification lors de la selection de deux cartes.
            If CarteRetourne.Count >= 2 Then
                Dim valeurRef = CarteRetourne(0).Tag
                For Each carte In CarteRetourne
                    If carte.Tag <> valeurRef Then
                        Task.Delay(500).Wait()
                        ResetPlateauErreur()
                        CarteRetourne.Clear()
                        compteurCarte = 0
                        Return
                    End If
                Next
            End If

            ' Verification du carre
            If CarteRetourne.Count = 4 Then
                CarteGagner.AddRange(CarteRetourne)
                CarteRetourne.Clear()
                compteurCarte = 0
                LabelCompteurScore.Text = (CarteGagner.Count \ 4).ToString()
            End If

            If TousCarteRetournee() Then
                FinDeJeu()
                'fin de jeu avec msg box, pseudo et timing?

            End If
        End If

    End Sub

    Private Sub FinDeJeu()
        ' Calculer le nombre de carrés trouvés (4 cartes = 1 carré)
        Dim nbCarres As Integer = CarteGagner.Count \ 4
        Dim tempsEcoule As Integer = cpt

        ' Enregistrer le joueur
        SauvegardeJoueur.EnregistrerJoueur(joueurNom, nbCarres, tempsEcoule)

        ' Sauvegarder immédiatement dans le fichier
        SauvegardeJoueur.SauvegarderDansFichier()

        ' Afficher le résultat
        MsgBox($"Bravo {joueurNom} ! Vous avez trouvé {nbCarres} carré(s) en {tempsEcoule} secondes.")

        ' Fermer ce formulaire et retourner à l'accueil
        Me.Hide()
        Dim accueil As New Accueil()
        accueil.Show()
    End Sub

    Private Function TousCarteRetournee() As Boolean
        Return CarteGagner.Count() = 20
    End Function

    Private Function CartePareil() As Boolean
        Dim TypeCarte = CarteRetourne(0).Tag
        For i As Integer = 1 To CarteRetourne.Count - 1
            If CarteRetourne(i).Tag <> TypeCarte Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub GriserCarteGagner()
        For Each carte As Label In CarteRetourne
            CarteGagner.Add(carte)
            'carte.Image = My.Resources.noir 'grisser
        Next
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        cpt += 1
        LabelTimer.Text = TempsMax - cpt
        If cpt >= TempsMax Then
            Timer.Stop()
            FinDeJeu()
        End If
    End Sub

End Class