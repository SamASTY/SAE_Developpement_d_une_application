Public Class FormAccueil

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim reponse = MsgBox("Voulez vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBoxPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPrenom.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) AndAlso btnJeu.Enabled Then
            btnJeu.PerformClick()
        End If
    End Sub

    Private Sub ButtonJeu_Click(sender As Object, e As EventArgs) Handles btnJeu.Click
        SauvegardeJoueur.ChargerDepuisFichier()
        SauvegardeJoueur.P = cmbPrenom.Text
        Dim formJeu As New Jeu()
        formJeu.RecupererJoueur(cmbPrenom.Text)
        Me.Hide()
        ConfigurerRetourAccueil(formJeu)
        formJeu.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPrenom.Items.Clear()
        For Each j In SauvegardeJoueur.Joueurs
            cmbPrenom.Items.Add(j.Pseudo)
        Next
    End Sub

    Private Sub ComboBoxPrenom_TextChanged(sender As Object, e As EventArgs) Handles cmbPrenom.TextChanged
        btnJeu.Enabled = (cmbPrenom.Text.Length >= 3)
    End Sub

    Private Sub ComboBoxPrenom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrenom.SelectedIndexChanged

    End Sub

    Private Sub ButtonScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        Dim FScore As New FormScores()
        Me.Hide()
        ConfigurerRetourAccueil(FScore)
        FScore.Show()
    End Sub

    Private Sub Accueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SauvegardeJoueur.SauvegarderDansFichier()
    End Sub

    Private Sub ConfigurerRetourAccueil(form As Form)
        AddHandler form.FormClosed, Sub(s, args)
                                        Me.Show()
                                        cmbPrenom.Focus()
                                    End Sub
    End Sub

    Private Sub buttonOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

    End Sub

End Class