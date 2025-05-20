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
        Dim formJeu As New FormJeu()
        formJeu.RecupererJoueur(cmbPrenom.Text)
        Me.Hide()
        ConfigurerRetourAccueil(formJeu)
        formJeu.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnMultijoueur = New Button()
        BtnMultijoueur.Text = "Multijoueur"
        BtnMultijoueur.Size = New Size(120, 40)
        BtnMultijoueur.Location = New Point(300, 150) ' Ajustez la position selon votre layout
        Me.Controls.Add(BtnMultijoueur)
        PseudoCmb()
    End Sub

    Private Sub PseudoCmb()
        ChargerDepuisFichier()
        cmbPrenom.Items.Clear()

        Dim joueursTries = Joueurs.OrderBy(Function(j) j.Pseudo)
        For Each j In joueursTries
            cmbPrenom.Items.Add(j.Pseudo)
        Next
    End Sub

    Private Sub ComboBoxPrenom_TextChanged(sender As Object, e As EventArgs) Handles cmbPrenom.TextChanged
        btnJeu.Enabled = (cmbPrenom.Text.Length >= 3)
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
                                        Me.PseudoCmb()
                                        Me.Show()
                                        cmbPrenom.Focus()
                                    End Sub
    End Sub

    Private Sub buttonOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Me.Hide()
        formOptions.Show()
    End Sub


    Private Sub btnMultiJoueur_Click(sender As Object, e As EventArgs) Handles BtnMultijoueur.Click
        Dim formMulti As New FormMultiJoueur()
        Me.Hide()
        ConfigurerRetourAccueil(formMulti)
        formMulti.Show()
    End Sub
End Class