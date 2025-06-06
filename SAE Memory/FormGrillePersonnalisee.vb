Public Class FormGrillePersonnalisee
    Private Sub FormGrillePersonnalisee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Charger les paramètres actuels
        nudLignes.Value = 4
        ActualiserPrevisualisation()
        nudLignes.Minimum = 2
        nudLignes.Maximum = 9
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
        Dim colonnes As Integer = lignes * 4

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

    Private Sub Enregistrer()
        Dim lignes As Integer = CInt(nudLignes.Value)
        Dim colonnes As Integer = lignes * 4
        Dim totalCartes As Integer = lignes * colonnes

        ModuleParametres.LignesPersonnalisees = lignes
        MsgBox("Configuration enregistrée avec succès.", MsgBoxStyle.Information, "Confirmation")
    End Sub

    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        Enregistrer()
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