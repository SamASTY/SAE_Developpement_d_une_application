Public Class FormJeu
    Dim joueurNom As String
    Dim cpt As Integer = 0
    Dim TempsMax As Integer = 50
    Dim CarteRetourne As List(Of Label)
    Dim compteurCarte As Integer = 0
    Dim CarteGagner As List(Of Label)
    Public cheminImages As String = System.IO.Path.Combine(Application.StartupPath, "Images")
    Dim CarteParSet As Integer = 4 ' 4 = carree, 2 = paires etc
    Dim NbreDeSet As Integer = 5 ' nombre de set de carte
    Dim TotalCarte As Integer = 20 ' nombre de cartes a deviner
    Public Sub RecupererJoueur(J As String)
        joueurNom = J
    End Sub
    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim reponse = MsgBox("Voulez-vous revenir à l'accueil ?", vbYesNo)
        If reponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Chargement du formulaire score — joueur actuel : " & SauvegardeJoueur.P)
        Timer.Interval = 1000
        Select Case ModuleParametres.Difficulté
            Case "Debutant"
                TempsMax = ModuleParametres.TempsMaxDebutant
            Case "Intermediaire"
                TempsMax = ModuleParametres.TempsMaxIntermediaire
            Case "Expert"
                TempsMax = ModuleParametres.TempsMaxExpert
        End Select
        lblTempsValeur.Text = TempsMax
        Timer.Start()
        InitJeu()
        lblPseudo.Text = joueurNom
    End Sub
    Private Sub InitJeu()
        'Initialisation des Listes de cartes
        Dim cartes As List(Of Integer) = GenererListe4X5()
        CarteRetourne = New List(Of Label)
        CarteGagner = New List(Of Label)

        'Affectations des valeurs au cartes
        For i As Integer = 1 To TotalCarte
            Dim labelName As String = "Label" & i.ToString("00")
            Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)

            If label IsNot Nothing Then
                label.Tag = cartes(i - 1)
                AddHandler label.Click, AddressOf Carte_Click
                Dim cheminComplet As String = System.IO.Path.Combine(cheminImages, "noir.jpeg")
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(cheminComplet), label)
                label.Text = label.Tag ' a enlever quand les test seront fini
            End If
        Next
    End Sub
    Private Sub ResetPlateauErreur()
        'Reinitialisation du plateau de jeu durant le jeu
        For i As Integer = 1 To TotalCarte
            Dim labelName As String = "Label" & i.ToString("00")
            Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)
            If label IsNot Nothing AndAlso Not CarteGagner.Any(Function(c) c.Name = label.Name) Then
                Dim cheminComplet As String = System.IO.Path.Combine(cheminImages, "noir.jpeg")
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(cheminComplet), label)
            End If
        Next
    End Sub

    Private Function GenererListe4X5() As List(Of Integer)
        'Génération des cartes
        Dim Paquet As New List(Of Integer)

        For valeur As Integer = 1 To NbreDeSet
            For i As Integer = 1 To CarteParSet
                Paquet.Add(valeur)
            Next
        Next

        'Mélange des cartes
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
        Dim label As Label = CType(sender, Label)

        If Not (CarteGagner.Contains(label) Or CarteRetourne.Contains(label)) Then
            Dim chemin1 As String = System.IO.Path.Combine(cheminImages, "1.jpeg")
            Dim chemin2 As String = System.IO.Path.Combine(cheminImages, "2.jpeg")
            Dim chemin3 As String = System.IO.Path.Combine(cheminImages, "3.jpeg")
            Dim chemin4 As String = System.IO.Path.Combine(cheminImages, "4.jpeg")
            Dim chemin5 As String = System.IO.Path.Combine(cheminImages, "5.jpeg")
            If label.Tag = 1 Then
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin1), label)
            ElseIf label.Tag = 2 Then
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin2), label)
            ElseIf label.Tag = 3 Then
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin3), label)
            ElseIf label.Tag = 4 Then
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin4), label)
            ElseIf label.Tag = 5 Then
                label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin5), label)
            End If

            compteurCarte += 1


            CarteRetourne.Add(label)

            If Not (CartePareil()) Then
                Task.Delay(500).Wait()
                ResetPlateauErreur()
            End If

            Carree()

            ' Verification du carre
            'faire une fonction

        End If

    End Sub

    Private Sub FinDeJeu()
        ' Calculer le nombre de carrés trouvés (4 cartes = 1 carré)
        Dim nbCarres As Integer = CarteGagner.Count \ CarteParSet
        Dim tempsEcoule As Integer = cpt

        ' Enregistrer le joueur
        SauvegardeJoueur.EnregistrerJoueur(joueurNom, nbCarres, tempsEcoule)

        ' Sauvegarder immédiatement dans le fichier
        SauvegardeJoueur.SauvegarderDansFichier()

        ' Afficher le résultat
        MsgBox($"Bravo {joueurNom} ! Vous avez trouvé {nbCarres} carré(s) en {tempsEcoule} secondes.")

        ' Fermer ce formulaire et retourner à l'accueil
        Dim A As New FormAccueil()
        Me.Close()
    End Sub

    Private Function TousCarteRetournee() As Boolean
        Return CarteGagner.Count() = TotalCarte
    End Function

    Private Sub Carree()
        If CarteRetourne.Count = CarteParSet Then
            GriserCarteGagner()
            CarteRetourne.Clear()
            compteurCarte = 0
            lblScoreValeur.Text = (CarteGagner.Count \ 4).ToString()
            ResetPlateauErreur()
        End If
    End Sub

    Private Function CartePareil() As Boolean
        Dim TypeCarte = CarteRetourne(0).Tag
        For i As Integer = 1 To CarteRetourne.Count - 1
            If CarteRetourne(i).Tag <> TypeCarte Then
                CarteRetourne.Clear()
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub GriserCarteGagner()
        For Each carte As Label In CarteRetourne
            CarteGagner.Add(carte)
            'carte.Image = My.Resources.noir 'grisser
            For i As Integer = 1 To TotalCarte
                Dim labelName As String = "Label" & i.ToString("00")
                Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)
                If label IsNot Nothing AndAlso CarteRetourne.Contains(label) Then
                    Dim chemin1 As String = System.IO.Path.Combine(cheminImages, "1gris.jpeg")
                    Dim chemin2 As String = System.IO.Path.Combine(cheminImages, "2gris.jpeg")
                    Dim chemin3 As String = System.IO.Path.Combine(cheminImages, "3gris.jpeg")
                    Dim chemin4 As String = System.IO.Path.Combine(cheminImages, "4gris.jpeg")
                    Dim chemin5 As String = System.IO.Path.Combine(cheminImages, "5gris.jpeg")
                    If label.Tag = 1 Then
                        label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin1), label)
                    ElseIf label.Tag = 2 Then
                        label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin2), label)
                    ElseIf label.Tag = 3 Then
                        label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin3), label)
                    ElseIf label.Tag = 4 Then
                        label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin4), label)
                    ElseIf label.Tag = 5 Then
                        label.Image = RedimensionnerImagePourLabel(Image.FromFile(chemin5), label)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        cpt += 1
        lblTempsValeur.Text = TempsMax - cpt
        If cpt >= TempsMax Or TousCarteRetournee() Then
            Timer.Stop()
            FinDeJeu()
        End If
    End Sub

    Private Function RedimensionnerImagePourLabel(img As Image, lbl As Label) As Image
        Dim bmp As New Bitmap(lbl.Width, lbl.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, New Rectangle(0, 0, lbl.Width, lbl.Height))
        End Using
        Return bmp
    End Function

    ' Met en pause le timer
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If Timer.Enabled Then
            Timer.Stop()
            btnPause.Text = "Reprendre"
        Else
            Timer.Start()
            btnPause.Text = "Pause"
        End If
    End Sub
End Class