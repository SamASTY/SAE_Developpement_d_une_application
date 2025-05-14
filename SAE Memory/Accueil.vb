Public Class Accueil

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim reponse = MsgBox("Voulez vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBoxPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxPrenom.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) AndAlso ButtonJeu.Enabled Then
            ButtonJeu.PerformClick()
        End If
    End Sub

    Private Sub ButtonJeu_Click(sender As Object, e As EventArgs) Handles ButtonJeu.Click
        SauvegardeJoueur.ChargerDepuisFichier()
        SauvegardeJoueur.P = ComboBoxPrenom.Text
        Dim formJeu As New Jeu()
        formJeu.RecupererJoueur(ComboBoxPrenom.Text)
        Me.Hide()
        ConfigurerRetourAccueil(formJeu)
        formJeu.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxPrenom.Items.Clear()
        For Each j In SauvegardeJoueur.Joueurs
            ComboBoxPrenom.Items.Add(j.Pseudo)
        Next
    End Sub

    Private Sub ComboBoxPrenom_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxPrenom.TextChanged
        ButtonJeu.Enabled = (ComboBoxPrenom.Text.Length >= 3)
    End Sub

    Private Sub ComboBoxPrenom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPrenom.SelectedIndexChanged

    End Sub

    Private Sub ButtonScores_Click(sender As Object, e As EventArgs) Handles ButtonScores.Click
        Dim FScore As New formScore()
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
                                        ComboBoxPrenom.Focus()
                                    End Sub
    End Sub

    Private Sub buttonOptions_Click(sender As Object, e As EventArgs) Handles buttonOptions.Click

    End Sub
End Class