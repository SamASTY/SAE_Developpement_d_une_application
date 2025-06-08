Imports System.Drawing.Drawing2D
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
    Dim CarteParSet As Integer
    Dim NbreDeSet As Integer
    Dim NombreTypesCartesDefault As Integer = 10
    Dim TotalCarte As Integer ' cartes totales à afficher
    Dim JeuEnPause As Boolean = False ' évite les clics quand les cartes se retournent
    Dim IndiceUtilsier As Boolean = False
    Public ModePersonnalise As Boolean = False
    Private cardSize As New Size(100, 120) ' Taille de base des cartes
    Private etatCartes As New Dictionary(Of Label, Boolean)

    ' Récupère le pseudo envoyé par l'écran d'accueil
    Public Sub RecupererJoueur(J As String)
        joueurNom = J
    End Sub

    Private Sub FormJeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NettoyerImages()
    End Sub

    ' Bouton "Abandonner" -> retourne à l'accueil si confirmé
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
        TableLayoutPlateau.Dock = DockStyle.Fill

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
        TableLayoutPlateau.AutoSize = False
        TableLayoutPlateau.AutoSizeMode = AutoSizeMode.GrowAndShrink
        AppliquerParametresSelonDifficulte()
        lblTempsValeur.Text = TempsMax
        lblScoreValeur.Text = "0"

        ' Calcul des lignes/colonnes pour la grille
        TotalCarte = Colonnes * Lignes
        CreerPlateauLignesColonnes(Lignes, Colonnes)
    End Sub

    ' Génère la grille avec les cartes aléatoires
    Private Sub CreerPlateauLignesColonnes(lignes As Integer, colonnes As Integer)
        TableLayoutPlateau.SuspendLayout()
        TableLayoutPlateau.Controls.Clear()
        TableLayoutPlateau.RowCount = lignes
        TableLayoutPlateau.ColumnCount = colonnes
        TableLayoutPlateau.RowStyles.Clear()
        TableLayoutPlateau.ColumnStyles.Clear()

        ' Charger l'image verso pour obtenir son ratio
        Dim versoImage As Image = Nothing
        Try
            versoImage = Image.FromFile(ModuleParametres.cheminVerso)
            Dim versoRatio As Single = versoImage.Width / versoImage.Height

            ' Calculer la taille des cartes
            Dim cardWidth As Integer = (TableLayoutPlateau.Width - TableLayoutPlateau.Margin.Horizontal) \ colonnes
            Dim cardHeight As Integer = CInt(cardWidth / versoRatio)

            ' Ajuster si la hauteur totale dépasse l'espace disponible
            Dim totalHeight As Integer = cardHeight * lignes
            If totalHeight > (Me.ClientSize.Height - 200) Then ' 200 pour les autres contrôles
                cardHeight = (Me.ClientSize.Height - 200) \ lignes
                cardWidth = CInt(cardHeight * versoRatio)
            End If

            cardSize = New Size(cardWidth, cardHeight)

            ' Configurer les styles de ligne/colonne
            For i = 0 To lignes - 1
                TableLayoutPlateau.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F / lignes))
            Next
            For j = 0 To colonnes - 1
                TableLayoutPlateau.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F / colonnes))
            Next

            ' Créer les cartes
            Dim cartes As List(Of Integer) = GenererListe()
            CarteRetourne = New List(Of Label)
            CarteGagner = New List(Of Label)

            For i As Integer = 0 To TotalCarte - 1
                Dim lbl As New Label With {
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .Tag = cartes(i),
                    .BackColor = Color.White,
                    .Margin = New Padding(2),
                    .Size = cardSize
                }
                AddHandler lbl.Click, AddressOf Carte_Click
                TableLayoutPlateau.Controls.Add(lbl)
                etatCartes(lbl) = False ' etat verso
            Next

            ' Ajuster la taille totale du TableLayoutPanel
            TableLayoutPlateau.Size = New Size(cardWidth * colonnes, cardHeight * lignes)
            PositionnerTableLayout()

            ' Charger les images verso
            For Each lbl As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
                lbl.Image = RedimensionnerImage(versoImage, cardSize)
            Next
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des images: " & ex.Message)
        Finally
            If versoImage IsNot Nothing Then versoImage.Dispose()
        End Try
        TableLayoutPlateau.ResumeLayout()
    End Sub


    ' Cache les cartes si erreur (mauvais carré)
    Private Sub ResetPlateauErreur()
        compteurCarte = 0
        CarteRetourne.Clear()
        For Each ctrl As Control In TableLayoutPlateau.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                If Not CarteGagner.Contains(lbl) Then
                    lbl.Image = RedimensionnerImage(Image.FromFile(ModuleParametres.cheminVerso), cardSize)
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
                    Path.Combine(ModuleParametres.cheminImages, $"{index}.jpeg"),
                    Path.Combine(ModuleParametres.cheminImages, $"{index}gris.jpeg")
                }

                ' Trouve la première image existante
                Dim cheminImage As String = cheminsPossibles.FirstOrDefault(Function(c) File.Exists(c))

                If cheminImage IsNot Nothing Then
                    label.Image = RedimensionnerImage(Image.FromFile(cheminImage), cardSize)
                Else
                    Debug.WriteLine($"Aucune image trouvée pour la carte {index}")
                    label.BackColor = Color.LightGray
                    label.Text = index.ToString() ' Affiche le numéro si l'image est manquante
                End If
                etatCartes(label) = True ' carte trouve
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
            carte.BorderStyle = BorderStyle.Fixed3D ' effet visuel pour dire : "c'est bon"
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

    Private Sub RedimensionnerToutesLesCartes()
        For Each lbl As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
            If lbl.Tag IsNot Nothing Then
                Dim index As Integer = CInt(lbl.Tag)
                Dim cheminImage As String = Path.Combine(ModuleParametres.cheminImages, $"{index}.jpeg")

                If File.Exists(cheminImage) Then
                    lbl.Image = RedimensionnerImage(Image.FromFile(cheminImage), cardSize)
                Else
                    lbl.Image = RedimensionnerImage(Image.FromFile(ModuleParametres.cheminVerso), cardSize)
                End If
            End If
        Next
    End Sub

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
                Dim chemin As String = Path.Combine(ModuleParametres.cheminImages, nomFichier)

                If File.Exists(chemin) Then
                    carte.Image = Image.FromFile(chemin)
                End If
            End If
        Next

        Await Task.Delay(1000)

        ResetPlateauErreur()

        Timer.Start()
        JeuEnPause = False
    End Sub


    ' Gestion du redimensionnement du formulaire
    Private Sub FormJeu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If TableLayoutPlateau Is Nothing OrElse TableLayoutPlateau.Controls.Count = 0 Then Return

        ' Empêcher un redimensionnement trop petit
        Dim minWidth As Integer = 400
        If Me.ClientSize.Width < minWidth Then
            Me.Width = minWidth + (Me.Width - Me.ClientSize.Width)
            Return
        End If

        ' Calculer la nouvelle taille des cartes
        Dim versoImage As Image = Nothing
        Try
            versoImage = Image.FromFile(ModuleParametres.cheminVerso)
            Dim versoRatio As Single = versoImage.Width / versoImage.Height
            Dim colonnes As Integer = TableLayoutPlateau.ColumnCount
            Dim lignes As Integer = TableLayoutPlateau.RowCount

            ' Calculer la largeur disponible par carte
            Dim cardWidth As Integer = (Me.ClientSize.Width - 40) \ colonnes
            Dim cardHeight As Integer = CInt(cardWidth / versoRatio)

            ' Vérifier que la hauteur totale ne dépasse pas l'espace disponible
            Dim maxHeight As Integer = (Me.ClientSize.Height - 150) \ lignes
            If cardHeight > maxHeight Then
                cardHeight = maxHeight
                cardWidth = CInt(cardHeight * versoRatio)
            End If

            cardSize = New Size(cardWidth, cardHeight)

            ' Mettre à jour le TableLayoutPanel
            For i = 0 To lignes - 1
                TableLayoutPlateau.RowStyles(i).Height = cardHeight
            Next
            For j = 0 To colonnes - 1
                TableLayoutPlateau.ColumnStyles(j).Width = cardWidth
            Next

            TableLayoutPlateau.Size = New Size(cardWidth * colonnes, cardHeight * lignes)
            PositionnerTableLayout()

            ' Redimensionner toutes les images
            For Each lbl As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
                lbl.Size = cardSize

                If lbl.Tag IsNot Nothing Then
                    Dim index As Integer = CInt(lbl.Tag)

                    ' Choisir l’image selon l’état
                    Dim imageAUtiliser As Image
                    If etatCartes.ContainsKey(lbl) AndAlso etatCartes(lbl) = True Then                        ' Face visible
                        Dim cheminImage As String = Path.Combine(ModuleParametres.cheminImages, $"{index}.jpeg")
                        If File.Exists(cheminImage) Then
                            imageAUtiliser = Image.FromFile(cheminImage)
                        Else
                            imageAUtiliser = CType(versoImage.Clone(), Image)
                        End If
                    Else
                        ' Carte cachée (verso)
                        imageAUtiliser = CType(versoImage.Clone(), Image)
                    End If

                    lbl.Image = RedimensionnerImage(imageAUtiliser, cardSize)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Erreur lors du redimensionnement: " & ex.Message)
        Finally
            If versoImage IsNot Nothing Then versoImage.Dispose()
        End Try
    End Sub

    Private Function GetVersoRatio() As Single
        Using img As Image = Image.FromFile(ModuleParametres.cheminVerso)
            Return img.Width / img.Height
        End Using
    End Function

    Private Function CalculerTailleCartes() As Size
        ' Obtenir le ratio de l'image verso
        Dim versoRatio As Single = GetVersoRatio()

        ' Calculer la largeur disponible par colonne
        Dim widthDispo As Integer = (TableLayoutPlateau.Width - (TableLayoutPlateau.ColumnCount * TableLayoutPlateau.Margin.Horizontal)) \ TableLayoutPlateau.ColumnCount
        Dim heightDispo As Integer = (TableLayoutPlateau.Height - (TableLayoutPlateau.RowCount * TableLayoutPlateau.Margin.Vertical)) \ TableLayoutPlateau.RowCount

        ' Calculer la hauteur en fonction du ratio
        Dim cardHeight As Integer = heightDispo
        Dim cardWidth As Integer = CInt(cardHeight * versoRatio)

        ' Si la largeur calculée est trop grande, ajuster
        If cardWidth > widthDispo Then
            cardWidth = widthDispo
            cardHeight = CInt(cardWidth / versoRatio)
        End If

        ' Garder une taille minimale
        cardWidth = Math.Max(cardWidth, 80)
        cardHeight = Math.Max(cardHeight, 60)

        Return New Size(cardWidth, cardHeight)
    End Function


    Private Sub PositionnerTableLayout()
        ' Centrer horizontalement
        Dim posX As Integer = (Me.ClientSize.Width - TableLayoutPlateau.Width) \ 2
        ' Positionner avec une marge en haut
        Dim posY As Integer = 100 ' Ajustez selon votre interface
        TableLayoutPlateau.Location = New Point(posX, posY)
    End Sub

    Private Sub NettoyerImages()
        For Each lbl As Label In TableLayoutPlateau.Controls.OfType(Of Label)()
            If lbl.Image IsNot Nothing Then
                lbl.Image.Dispose()
            End If
        Next
    End Sub

    Private Function RedimensionnerImage(img As Image, targetSize As Size) As Image
        Dim ratioX As Double = targetSize.Width / img.Width
        Dim ratioY As Double = targetSize.Height / img.Height
        Dim ratio As Double = Math.Min(ratioX, ratioY)

        Dim newWidth As Integer = CInt(img.Width * ratio)
        Dim newHeight As Integer = CInt(img.Height * ratio)

        Dim bmp As New Bitmap(targetSize.Width, targetSize.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.Transparent)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            Dim x As Integer = (targetSize.Width - newWidth) \ 2
            Dim y As Integer = (targetSize.Height - newHeight) \ 2
            g.DrawImage(img, x, y, newWidth, newHeight)
        End Using
        Return bmp
    End Function

End Class