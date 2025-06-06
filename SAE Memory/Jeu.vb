Imports System.IO
Imports System.Text
Imports SAE_Memory.ModuleParametres

Public Class FormJeu
    ' Variables globales
    Dim Lignes As Integer = 1
    Const Colonnes As Integer = 4
    Dim joueurNom As String
    Dim cpt As Integer = 0 ' compteur de secondes
    Const TempsMax As Integer = 60
    Dim CarteRetourne As List(Of Label) ' cartes cliquées en cours
    Dim compteurCarte As Integer = 0 ' compte le nombre de clics en cours
    Dim CarteGagner As List(Of Label) ' cartes validées
    Public cheminImages As String = Path.Combine(Application.StartupPath, "Images")
    Public cheminVerso As String = Path.Combine(cheminImages, "verso.jpeg")
    Dim CarteParSet As Integer
    Dim NbreDeSet As Integer
    Dim NombreTypesCartesDefault As Integer = 10
    Dim TotalCarte As Integer ' cartes totales à afficher
    Dim JeuEnPause As Boolean = False ' évite les clics quand les cartes se retournent
    Dim IndiceUtilsier As Boolean = False
    Public ModePersonnalise As Boolean = False

    ' Récupère le pseudo envoyé par l'écran d’accueil
    Public Sub RecupererJoueur(J As String)
        joueurNom = J
    End Sub

    ' Bouton "Abandonner" -> retourne à l’accueil si confirmé
    Private Sub ButtonAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Dim reponse = MsgBox("Voulez-vous revenir à l'accueil ?", vbYesNo)
        If reponse = vbYes Then
            Me.Close()
        End If
    End Sub

    ' Chargement du formulaire de jeu
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Chargement du formulaire score — joueur actuel : " & SauvegardeJoueur.P)
        Timer.Interval = 1000
        InitJeu()
        lblPseudo.Text = joueurNom
        ModePersonnalise = ModuleParametres.PersonaliserEtat()
        Timer.Start()
        If ModuleParametres.IndiceEtat() Then
            pnlIndice.Show()
            pnlScore.Hide()
        Else
            pnlIndice.Hide()
            pnlScore.Show()
        End If

    End Sub

    ' Applique les paramètres en fonction de la difficulté sélectionnée
    Private Sub AppliquerParametresSelonDifficulte()
        If ModePersonnalise Then
            Lignes = ModuleParametres.LignesPersonnalisees
        Else
            Select Case DifActuelle
                Case NiveauDifficulte.Debutant
                    Lignes = 3
                Case NiveauDifficulte.Intermediaire
                    Lignes = 4
                Case NiveauDifficulte.Expert
                    Lignes = 5
            End Select
        End If

        ' Chaque set correspond à une ligne
        NbreDeSet = Lignes
        ' Chaque carte doit être répétée Colonnes fois (4)
        CarteParSet = Colonnes
    End Sub

    ' Démarre une nouvelle partie (plateau, timer, score, etc.)
    Private Sub InitJeu()
        AppliquerParametresSelonDifficulte()
        lblTempsValeur.Text = TempsMax
        lblScoreValeur.Text = "0"

        ' Calcul des lignes/colonnes pour la grille
        TotalCarte = Colonnes * Lignes
        AfficherContenuDossierImages()
        CreerPlateauLignesColonnes(Lignes, Colonnes)
    End Sub

    ' Génère la grille avec les cartes aléatoires
    Private Sub CreerPlateauLignesColonnes(lignes As Integer, colonnes As Integer)

        TableLayoutPlateau.Controls.Clear()
        TableLayoutPlateau.RowCount = lignes
        TableLayoutPlateau.ColumnCount = colonnes
        TableLayoutPlateau.RowStyles.Clear()
        TableLayoutPlateau.ColumnStyles.Clear()

        For i = 0 To lignes - 1
            TableLayoutPlateau.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
        Next
        For j = 0 To colonnes - 1
            TableLayoutPlateau.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
        Next

        Dim cartes As List(Of Integer) = GenererListe()
        CarteRetourne = New List(Of Label)
        CarteGagner = New List(Of Label)

        For i As Integer = 0 To TotalCarte - 1
            Dim lbl As New Label With {
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .BorderStyle = BorderStyle.FixedSingle,
            .Tag = cartes(i),
            .BackColor = Color.White
        }
            AddHandler lbl.Click, AddressOf Carte_Click
            TableLayoutPlateau.Controls.Add(lbl)
        Next

        Application.DoEvents()
        For Each lbl As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
            lbl.Image = RedimImg(Image.FromFile(cheminVerso), lbl)
        Next
    End Sub

    ' Cache les cartes si erreur (mauvais carré)
    Private Sub ResetPlateauErreur()
        compteurCarte = 0
        CarteRetourne.Clear()
        For Each ctrl As Control In TableLayoutPlateau.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                If Not CarteGagner.Contains(lbl) Then
                    lbl.Image = RedimImg(Image.FromFile(cheminVerso), lbl)
                End If
            End If
        Next
    End Sub

    ' Prépare la liste des cartes mélangées
    Private Function GenererListe() As List(Of Integer)
        Dim Paquet As New List(Of Integer)
        Dim repetitionsParCarte As Integer = Colonnes ' Toujours 4 répétitions par type de carte

        ' Pour chaque type de carte nécessaire (nombre de types = nombre de lignes)
        For valeur As Integer = 1 To Lignes
            ' Ajoute 4 exemplaires de chaque carte
            For i As Integer = 1 To repetitionsParCarte
                Paquet.Add(valeur)
            Next
        Next

        MelangePaquet(Paquet)
        Debug.WriteLine($"Cartes générées ({Lignes} types × {Colonnes} exemplaires): " & String.Join(", ", Paquet))

        Return Paquet
    End Function

    ' Mélange les cartes
    Private Sub MelangePaquet(Paquet As List(Of Integer))
        Dim rng As New Random()

        For i As Integer = 0 To Paquet.Count - 1
            Dim j As Integer = rng.Next(i, Paquet.Count)
            Dim temp = Paquet(i)
            Paquet(i) = Paquet(j)
            Paquet(j) = temp
        Next
    End Sub

    ' Clique sur une carte
    Private Async Sub Carte_Click(sender As Object, e As EventArgs)
        Dim label As Label = CType(sender, Label)

        If JeuEnPause = False Then
            If Not (CarteGagner.Contains(label) Or CarteRetourne.Contains(label)) Then
                Dim index As Integer = CInt(label.Tag)
                Dim cheminsPossibles As New List(Of String) From {
                Path.Combine(cheminImages, $"{index}.jpeg"),
                Path.Combine(cheminImages, $"{index}gris.jpeg")
            }

                ' Trouve la première image existante
                Dim cheminImage As String = cheminsPossibles.FirstOrDefault(Function(c) File.Exists(c))

                If cheminImage IsNot Nothing Then
                    label.Image = RedimImg(Image.FromFile(cheminImage), label)
                Else
                    Debug.WriteLine($"Aucune image trouvée pour la carte {index}")
                    label.BackColor = Color.LightGray
                    label.Text = index.ToString() ' Affiche le numéro si l'image est manquante
                End If

                compteurCarte += 1
                CarteRetourne.Add(label)

                If CartePareil() Then
                    Carree()
                Else
                    JeuEnPause = True
                    Await Task.Delay(500)
                    ResetPlateauErreur()
                    JeuEnPause = False
                    CarteRetourne.Clear()
                End If
            End If
        End If
    End Sub

    ' Quand toutes les cartes sont trouvées OU temps écoulé
    Private Sub FinDeJeu()
        Dim nbCarres As Integer = CarteGagner.Count \ CarteParSet
        Dim tempsEcoule As Integer = cpt

        If IndiceUtilsier Then
            MsgBox($"Bravo {joueurNom} ! Vous avez trouvé {nbCarres} carré(s) en {tempsEcoule} secondes.{vbCrLf}Cependant vous avez utilisé un indice, votre score ne sera pas enregistré")
            Dim A As New FormAccueil()
            Me.Close()
        Else
            SauvegardeJoueur.EnregistrerJoueur(joueurNom, nbCarres, tempsEcoule)
            SauvegardeJoueur.SauvegarderDansFichier()

            MsgBox($"Bravo {joueurNom} ! Vous avez trouvé {nbCarres} carré(s) en {tempsEcoule} secondes.")
            Dim A As New FormAccueil()
            Me.Close()
        End If

    End Sub

    ' Vérifie si toutes les cartes ont été trouvées
    Private Function TousCarteRetournee() As Boolean
        If CarteGagner IsNot Nothing Then
            Return CarteGagner.Count() = TotalCarte
        End If
        Return False
    End Function

    ' Applique le style de "carte trouvée"
    Private Sub GriserCarteGagner()
        For Each carte As Label In CarteRetourne
            CarteGagner.Add(carte)
            carte.BackColor = Color.FromArgb(220, 220, 220) ' gris clair sans cacher l'image
            carte.BorderStyle = BorderStyle.Fixed3D ' effet visuel pour dire : "c’est bon"
            carte.Enabled = False
        Next
    End Sub

    ' Action quand un carré valide est trouvé
    Private Sub Carree()
        If CarteRetourne.Count = CarteParSet Then
            GriserCarteGagner()
            CarteRetourne.Clear()
            compteurCarte = 0
            lblScoreValeur.Text = (CarteGagner.Count \ CarteParSet).ToString()
            ResetPlateauErreur()
        End If
    End Sub

    ' Vérifie si les cartes retournées sont toutes pareilles
    Private Function CartePareil() As Boolean
        If CarteRetourne.Count = 0 Then Return False
        Dim TypeCarte = CarteRetourne(0).Tag
        For i As Integer = 1 To CarteRetourne.Count - 1
            If CarteRetourne(i).Tag <> TypeCarte Then
                CarteRetourne.Clear()
                Return False
            End If
        Next
        Return True
    End Function

    ' Tick du timer (chaque seconde)
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        cpt += 1
        lblTempsValeur.Text = TempsMax - cpt
        If cpt >= TempsMax Or TousCarteRetournee() Then
            Timer.Stop()
            FinDeJeu()
        End If
    End Sub

    ' Redimensionne une image pour s'adapter à une case
    Private Function RedimImg(img As Image, lbl As Label) As Image
        Dim bmp As New Bitmap(lbl.Width, lbl.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, New Rectangle(0, 0, lbl.Width, lbl.Height))
        End Using
        Return bmp
    End Function

    ' Pause / Reprise du jeu
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        If Timer.Enabled Then
            Timer.Stop()
            JeuEnPause = True
            btnPause.Text = "Reprendre"
        Else
            Timer.Start()
            JeuEnPause = False
            btnPause.Text = "Pause"
        End If
    End Sub

    Private Async Sub btnIndice_Click(sender As Object, e As EventArgs) Handles btnIndice.Click
        IndiceUtilsier = True

        If JeuEnPause Then Exit Sub

        JeuEnPause = True
        Timer.Stop()

        ResetPlateauErreur()

        For Each carte As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
            If Not CarteGagner.Contains(carte) Then
                Dim index As Integer = CInt(carte.Tag)
                Dim nomFichier As String = $"{index}.jpeg"
                Dim chemin As String = Path.Combine(cheminImages, nomFichier)

                If File.Exists(chemin) Then
                    carte.Image = RedimImg(Image.FromFile(chemin), carte)
                End If
            End If
        Next

        Await Task.Delay(1000)

        ResetPlateauErreur()

        Timer.Start()
        JeuEnPause = False
    End Sub

    ' Fonction qui affiche le contenu du dossier Images
    Public Sub AfficherContenuDossierImages()
        Try
            ' Vérifie si le dossier existe
            If Directory.Exists(cheminImages) Then
                ' Récupère tous les fichiers du dossier
                Dim fichiers() As String = Directory.GetFiles(cheminImages)
                Dim message As New StringBuilder()

                message.AppendLine($"Contenu du dossier Images ({cheminImages}):")
                message.AppendLine("----------------------------------")

                ' Ajoute chaque fichier au message
                For Each fichier As String In fichiers
                    message.AppendLine(Path.GetFileName(fichier))
                Next

                ' Affiche le résultat
                MessageBox.Show(message.ToString(), "Contenu du dossier Images")
            Else
                MessageBox.Show($"Le dossier Images n'existe pas à l'emplacement : {cheminImages}", "Erreur")
            End If
        Catch ex As Exception
            MessageBox.Show($"Erreur lors de la lecture du dossier : {ex.Message}", "Erreur")
        End Try
    End Sub

End Class
