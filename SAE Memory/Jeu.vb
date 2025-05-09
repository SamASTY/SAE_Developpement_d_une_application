Imports System.Drawing.Drawing2D

Public Class Jeu

    Dim cpt As Integer = 0
    Dim TempsMax As Integer = 60
    Dim nbMaxCarteRetourner = 5

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
        Timer1.Interval = 1000
        LabelTimer.Text = TempsMax
        Timer1.Start()

        InitJeu()

    End Sub

    Private Sub InitJeu()
        Dim cartes As List(Of Integer) = GenererListe4X5()

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

    Private Sub ResetPlateau()

        For i As Integer = 1 To 20
            Dim labelName As String = "L_Carte" & i.ToString("00")
            Dim label As Label = CType(GroupBoxPlateau.Controls(labelName), Label)
            If label IsNot Nothing Then
                label.Image = My.Resources.noir
            End If
        Next


        Dim Show As String = Application.StartupPath & "\Images\noir.png"
        Dim Hide As String = Application.StartupPath & "\Images\couleurs.png"
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
        nbMaxCarteRetourner += 1
        Dim label As Label = CType(sender, Label)
        If label.Tag = 1 Then
            label.Image = My.Resources._1
        ElseIf label.Tag = 2 Then
            label.Image = My.Resources._2
        ElseIf label.Tag = 3 Then
            label.Image = My.Resources._3
        ElseIf label.Tag = 4 Then
            label.Image = My.Resources._4
        End If

        'EnregistrerCarte(label)
        'If nbMaxCarteRetourner == 5 Then
        '-CartePareil()
        '-CarteGagner
        'Else
        'ResetPlateau()

        'faire aussi verrif que toutes les cartes sois pas retourner

        'faire verrif que timer diff de 60




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpt += 1
        LabelTimer.Text = TempsMax - cpt
        If cpt >= TempsMax Then
            Timer1.Stop()
            'Stopapp a faire
        End If
    End Sub
End Class