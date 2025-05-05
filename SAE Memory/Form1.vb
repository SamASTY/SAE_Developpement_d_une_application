Public Class Form1

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim reponse = MsgBox("Voulez vous vraiment quitter l'application?", vbYesNo)
        If reponse = vbYes Then
            End
        End If
    End Sub
End Class