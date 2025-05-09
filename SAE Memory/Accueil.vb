Public Class Accueil

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim reponse = MsgBox("Voulez vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBoxPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxPrenom.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonJeu_Click(sender As Object, e As EventArgs) Handles ButtonJeu.Click
        Dim formJeu As New Jeu()
        formJeu.RecupererJoueur("nom")
        formJeu.Show()
        Me.Hide()
    End Sub


End Class