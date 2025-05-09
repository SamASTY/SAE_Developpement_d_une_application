Imports System.Drawing.Drawing2D

Public Class Jeu
    Dim Joueur As String
    Dim cpt As Integer = 0
    Dim TempsMax As Integer = 60
    Dim CarteRetourne As List(Of Label)
    Dim nbMaxCarteRetourner As Integer = 5
    Dim compteurCarte As Integer = 0
    Dim CarteGagner As List(Of Label)

    Public Sub RecupererJoueur(J As String)
        Joueur = J
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
        Timer.Interval = 1000
        LabelTimer.Text = TempsMax
        Timer.Start()
        InitJeu()
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

        For valeur As Integer = 1 To 4
            For i As Integer = 1 To 5
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
            End If

            compteurCarte += 1

            Label3.Text = compteurCarte

            CarteRetourne.Add(label)
            If nbMaxCarteRetourner = compteurCarte Then
                If CartePareil() Then
                    GriserCarteGagner()
                Else
                    ResetPlateauErreur()
                End If
                compteurCarte = 0
                CarteRetourne.Clear()
            End If

            If TousCarteRetournee() Then
                FinDeJeu()
                'fin de jeu avec msg box, pseudo et timing?

            End If
        End If

    End Sub

    Private Sub FinDeJeu()
        SauvegardeJoueur.RecupererTemps(cpt)
        SauvegardeJoueur.RecupererScore(CarteGagner.Count)
        SauvegardeJoueur.RecupererPseudo(Joueur)
        MsgBox("Bravo" & Joueur & " ! Vous avez réussi à trouver " & CarteGagner.Count & " cartes en " & cpt & " secondes.")
        Me.Hide()
        Accueil.Show()
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