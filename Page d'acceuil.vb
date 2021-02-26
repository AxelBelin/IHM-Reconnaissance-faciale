Public Class frmAccueil
    Private Sub btnSelectionnerImage_Click(sender As Object, e As EventArgs) Handles btnSelectionnerImage.Click
        ofdSelectionImage.Filter = "Png File|*.png |Jpg Files |*.jpg |All Files |*.*" 'Selection d'une image parmi 3 types de fichiers '
        ofdSelectionImage.InitialDirectory = frmSelectionChemin.fbdChoisirCheminProjet.SelectedPath
        If ofdSelectionImage.ShowDialog() = DialogResult.OK Then 'Ouverture de l'image et conserver le nom du fichier dans une variable : nomFichierImage '
            Dim nomFichierImage As String
            nomFichierImage = ofdSelectionImage.FileName
            Dim resultat() As String
            resultat = nomFichierImage.Split("\")
            nomFichierImage = resultat(resultat.Length - 1)
            frmAnnotationVisage.lblNomImage.Text = nomFichierImage
            frmAnnotationVisage.picVisageAnnotation.ImageLocation = ofdSelectionImage.FileName
            Me.Hide()
            frmAnnotationVisage.ShowDialog()
        End If
    End Sub
    'Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
    'Me.Hide()
    'FrmOuvrirImg.ShowDialog()
    'End Sub '
End Class