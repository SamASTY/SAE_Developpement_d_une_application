Imports System.IO

Public Class FormGrillePersonnalisee
    Const colonnes As Integer = 4
    Private Sub FormGrillePersonnalisee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les paramètres actuels
        nudLignes.Value = 4
        ActualiserPrevisualisation()
        nudLignes.Minimum = 2
        nudLignes.Maximum = 10
        ModuleParametres.CochePersonaliser()
    End Sub

    Private Sub nudLignes_ValueChanged(sender As Object, e As EventArgs) Handles nudLignes.ValueChanged
        ActualiserPrevisualisation()
    End Sub

    Private Sub ActualiserPrevisualisation()
        TableLayoutPrevisualisation.Controls.Clear()
        TableLayoutPrevisualisation.RowStyles.Clear()
        TableLayoutPrevisualisation.ColumnStyles.Clear()

        Dim lignes As Integer = CInt(nudLignes.Value)

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

    Private Function Enregistrer() As Boolean
        Dim nbLignes As Integer = CInt(nudLignes.Value)
        Dim totalCartes As Integer = nbLignes * colonnes

        Dim groupesImagesNecessaires As Integer = totalCartes / 4
        Dim imagesDisponibles As Integer = CompterImagesDisponibles()
        Dim versoOK As Boolean = File.Exists(ModuleParametres.cheminVerso)

        If imagesDisponibles < groupesImagesNecessaires OrElse Not versoOK Then
            MessageBox.Show($"Erreur : {groupesImagesNecessaires} images différentes requises." & Environment.NewLine &
                            $"Images disponibles : {imagesDisponibles}, Verso présent : {versoOK}",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ModuleParametres.LignesPersonnalisees = nbLignes
        MessageBox.Show("Configuration enregistrée avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If Not Enregistrer() Then Exit Sub
        Dim formJeu As New FormJeu()
        formJeu.RecupererJoueur(SauvegardeJoueur.P)
        formJeu.ModePersonnalise = True
        Me.Close()
        formJeu.Show()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        ModuleParametres.CochePersonaliser()
        Me.Close()
    End Sub

End Class