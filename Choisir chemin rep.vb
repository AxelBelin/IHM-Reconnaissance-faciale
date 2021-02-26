Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Public Class frmSelectionChemin
    'Sélectionner un dossier dans un Folder Browser Dialog '
    Private Sub btnChoisirChemin_Click(sender As Object, e As EventArgs) Handles btnChoisirChemin.Click
        fbdChoisirCheminProjet.ShowDialog()
        If (fbdChoisirCheminProjet.ShowDialog() = DialogResult.OK) Then
            txtCheminProjet.Text = fbdChoisirCheminProjet.SelectedPath
        End If
    End Sub

    Private Sub btnConfirmerChemin_Click(sender As Object, e As EventArgs) Handles btnConfirmerChemin.Click
        If txtCheminProjet.Text = "" Then  'Si aucun dossier n'est sélectionné '
            MsgBox("Aucun dossier n'est sélectionné, veuillez en choisir un")
        Else 'Création d'un fichier csv puis ouverture de la page d'acceuil de l'application (Page de bienvenue) '
            Dim cheminProjet As String = txtCheminProjet.Text + "\Ratios.csv"
            My.Computer.FileSystem.WriteAllText(cheminProjet, "Ratio Lèvre; Ratio Nez; Ratio Visage; Ratio Yeux; Nom Fichier" + Chr(10), True)
            frmAccueil.Show()
            Me.Hide()
        End If
    End Sub
End Class