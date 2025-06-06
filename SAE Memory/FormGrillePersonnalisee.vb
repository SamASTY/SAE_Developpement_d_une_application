Public Class FormGrillePersonnalisee
    Private Sub FormGrillePersonnalisee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les paramètres actuels
        nudLignes.Value = ModuleParametres.LignesPersonnalisees
        nudColonnes.Value = ModuleParametres.ColonnesPersonnalisees
        nudCartesParCarre.Value = ModuleParametres.CartesParCarrePersonnalisees
        nudTempsMax.Value = ModuleParametres.TempsMaxPersonnalise
        ActualiserPrevisualisation()
    End Sub

    Private Sub nudLignes_ValueChanged(sender As Object, e As EventArgs) Handles nudLignes.ValueChanged, nudColonnes.ValueChanged, nudCartesParCarre.ValueChanged
        ActualiserPrevisualisation()
    End Sub

    Private Sub ActualiserPrevisualisation()
        TableLayoutPrevisualisation.Controls.Clear()
        TableLayoutPrevisualisation.RowStyles.Clear()
        TableLayoutPrevisualisation.ColumnStyles.Clear()

        Dim lignes As Integer = CInt(nudLignes.Value)
        Dim colonnes As Integer = CInt(nudColonnes.Value)

        TableLayoutPrevisualisation.RowCount = lignes
        TableLayoutPrevisualisation.ColumnCount = colonnes

        For i As Integer = 0 To lignes - 1
            TableLayoutPrevisualisation.RowStyles.Add(New RowStyle(SizeType.Percent, 100 / lignes))
        Next
        For j As Integer = 0 To colonnes - 1
            TableLayoutPrevisualisation.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100 / colonnes))
        Next

        For i As Integer = 0 To lignes * colonnes - 1
            Dim lbl As New Label With {
                .Dock = DockStyle.Fill,
                .TextAlign = ContentAlignment.MiddleCenter,
                .BorderStyle = BorderStyle.FixedSingle,
                .BackColor = Color.SteelBlue
            }
            TableLayoutPrevisualisation.Controls.Add(lbl)
        Next
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Dim lignes As Integer = CInt(nudLignes.Value)
        Dim colonnes As Integer = CInt(nudColonnes.Value)
        Dim cartesParCarre As Integer = CInt(nudCartesParCarre.Value)
        Dim totalCartes As Integer = lignes * colonnes

        If totalCartes Mod cartesParCarre <> 0 Then
            MsgBox("Le nombre total de cartes doit être divisible par le nombre de cartes par carré.", vbExclamation, "Erreur")
            Exit Sub
        End If

        ModuleParametres.LignesPersonnalisees = lignes
        ModuleParametres.ColonnesPersonnalisees = colonnes
        ModuleParametres.CartesParCarrePersonnalisees = cartesParCarre
        ModuleParametres.TempsMaxPersonnalise = CInt(nudTempsMax.Value)
        ModuleParametres.SauvegarderGrillePersonnalisee()
        MsgBox("Configuration enregistrée avec succès.", MsgBoxStyle.Information, "Confirmation")
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        btnEnregistrer.PerformClick()
        Dim formJeu As New FormJeu()
        formJeu.RecupererJoueur(SauvegardeJoueur.P)
        formJeu.ModePersonnalise = True
        Me.Close()
        formJeu.Show()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class