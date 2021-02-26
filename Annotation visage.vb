Imports System.Drawing.Text
Imports System.IO
Imports System.Text
Public Class frmAnnotationVisage
    Dim a, b As Integer
    Dim y1x, y2x, bvgx, bvdx, bnx, bngx, bndx, bmx, lhx, blx, lgx, ldx, y1y, y2y, bvgy, bvdy, bny, bngy, bndy, bmy, lhy, bly, lgy, ldy As Integer

    'Charger les coordonnées d'un fichier csv correpondant à l'image importée '
    Private Sub tsmItemChargerImageVisage_Click(sender As Object, e As EventArgs) Handles tsmItemChargerImageVisage.Click
        ofdChargerAnnotation.Filter = "Excel File|*.csv |All Files |*.*" 'Type de fichier défini en .CSV ou Excel File (format des fichiers d'annotation) '
        ofdChargerAnnotation.InitialDirectory = frmSelectionChemin.fbdChoisirCheminProjet.SelectedPath
        If ofdChargerAnnotation.ShowDialog() = DialogResult.OK Then
            Dim StreamReader As New StreamReader(ofdChargerAnnotation.FileName)
            Dim ligne1 As String = StreamReader.ReadLine
            Dim ligne2 As String = StreamReader.ReadLine
            Dim Coordonnées() As String = ligne2.Split(";")
            picVisageAnnotation.ImageLocation = frmSelectionChemin.txtCheminProjet.Text + "\" + Coordonnées(0)
            lblNomImage.Text = Coordonnées(0)
            y1x = Coordonnées(1)
            y1y = Coordonnées(2)
            bvgx = Coordonnées(3)
            bvgy = Coordonnées(4)
            bvdx = Coordonnées(5)
            bvdy = Coordonnées(6)
            bnx = Coordonnées(7)
            bny = Coordonnées(8)
            bngx = Coordonnées(9)
            bngy = Coordonnées(10)
            bndx = Coordonnées(11)
            bndy = Coordonnées(12)
            bmx = Coordonnées(13)
            bmy = Coordonnées(14)
            lhx = Coordonnées(15)
            lhy = Coordonnées(16)
            blx = Coordonnées(17)
            bly = Coordonnées(18)
            lgx = Coordonnées(19)
            lgy = Coordonnées(20)
            ldx = Coordonnées(21)
            ldy = Coordonnées(22)
            y2x = Coordonnées(23)
            y2y = Coordonnées(24)
            lblY2.Text = CStr(y1x) + "," + CStr(y1y)
            lblY1.Text = CStr(y2x) + "," + CStr(y2y)
            lblBVG.Text = CStr(bvgx) + "," + CStr(bvgy)
            lblBVD.Text = CStr(bvdx) + "," + CStr(bvdy)
            lblBN.Text = CStr(bnx) + "," + CStr(bny)
            lblLH.Text = CStr(lhx) + "," + CStr(lhy)
            lblBL.Text = CStr(blx) + "," + CStr(bly)
            lblLG.Text = CStr(lgx) + "," + CStr(lgy)
            lblLD.Text = CStr(ldx) + "," + CStr(ldy)
            lblBNG.Text = CStr(bngx) + "," + CStr(bngy)
            lblBND.Text = CStr(bndx) + "," + CStr(bndy)
            lblBM.Text = CStr(bmx) + "," + CStr(bmy)
            StreamReader.Dispose()
        End If
    End Sub

    Private Sub tsmItemComparer_Click(sender As Object, e As EventArgs) Handles tsmItemComparer.Click
        frmComparerVisages.pbImageProjetActuel.ImageLocation = picVisageAnnotation.ImageLocation
        frmComparerVisages.pbImageProjetActuel.Image = picVisageAnnotation.Image
        frmComparerVisages.lblNomImageProjetActuel.Text = lblNomImage.Text

        'Calculs des ratios d'une image annotée '
        Dim moyYeuxx, moyYeuxy As Integer
        ratioLevre = Math.Sqrt((blx - lhx) * (blx - lhx) + (bly - lhy) * (bly - lhy)) / Math.Sqrt((ldx - lgx) * (ldx - lgx) + (ldy - lgy) * (ldy - lgy))
        ratioLevre = Math.Round(ratioLevre, 3)

        moyYeuxx = Math.Abs(y2x + y1x) / 2
        moyYeuxy = Math.Abs(y2y + y1y) / 2

        ratioNez = Math.Sqrt((moyYeuxx - bnx) * (moyYeuxx - bnx) + (moyYeuxy - bny) * (moyYeuxy - bny)) / Math.Sqrt((bngx - bndx) * (bngx - bndx) + (bngy - bndy) * (bngy - bndy))
        ratioNez = Math.Round(ratioNez, 3)

        ratioVisage = Math.Sqrt((moyYeuxx - bmx) * (moyYeuxx - bmx) + (moyYeuxy) * (moyYeuxy)) / Math.Sqrt((bvgx - bvdx) * (bvgx - bvdx) + (bvdy - bvdy) * (bvdy - bvdy))
        ratioVisage = Math.Round(ratioVisage, 3)

        ratioYeux = Math.Sqrt((bvgx - bvdx) * (bvgx - bvdx) + (bvgy - bvdy) * (bvgy - bvdy)) / Math.Sqrt((y1x - y2x) * (y1x - y2x) + (y1y - y2y) * (y1y - y2y))
        ratioYeux = Math.Round(ratioYeux, 3)

        Dim cheminCSV As String = frmSelectionChemin.txtCheminProjet.Text + "\Ratios.csv"
        My.Computer.FileSystem.WriteAllText(cheminCSV, CStr(ratioLevre) + ";" + CStr(ratioNez) + ";" + CStr(ratioVisage) + ";" + CStr(ratioYeux) + ";" + lblNomImage.Text + Chr(10), True)
        Dim ratioLevre2, ratioNez2, ratioVisage2, ratioYeux2 As Integer
        Dim nomImageRessemblance As String
        Dim StreamReader2 As New StreamReader(cheminCSV) ' Lecture du fichier csv spécifié '
        Dim ressemblance As Double = 20 'Ressemblance : minimun fixé à 20 '
        Dim ligne1 As String = StreamReader2.ReadLine 'Pour Lire la première ligne du fichier. La premiere ligne est inutile au calcul de ressemblance, il s'agit de l'entete du fichier (on ne l'utilise pas) '
        For i As Integer = 1 To 3 'boucle pour comparer les distances. Il est possible de mettre plus que 3 lignes dans la boucle '
            Dim ligne As String = StreamReader2.ReadLine
            Dim Ratios() As String = ligne.Split(";")
            ' Pour le formet jpeg : Message d'erreur crash de l'appli pas de conversion en Integer possible pour l'indice de Ratio '
            ratioLevre2 = Ratios(0)
            ratioNez2 = Ratios(1)
            ratioVisage2 = Ratios(2)
            ratioYeux2 = Ratios(3)
            nomImageRessemblance = Ratios(4)
            Dim distance As Double = ((ratioLevre - ratioLevre2) ^ 2 + (ratioNez - ratioNez2) ^ 2 + (ratioVisage - ratioVisage2) ^ 2 + (ratioYeux - ratioYeux2) ^ 2)
            If distance < ressemblance Then
                ressemblance = distance
            End If
            frmComparerVisages.lblNomImageTrouvee.Text = nomImageRessemblance
            frmComparerVisages.pbImageTrouvee.ImageLocation = frmSelectionChemin.txtCheminProjet.Text + "\" + nomImageRessemblance
            frmComparerVisages.lblResultatComparaison.Text = lblNomImage.Text + " Ressemble le plus a : " + frmComparerVisages.lblNomImageTrouvee.Text
        Next
        Me.Hide()
        frmComparerVisages.Show()
    End Sub

    'Calculs des ratios pour les afficher dans le label correspondant : lblResultatAnnotations '
    Private Sub btnResultatAnnotations_Click(sender As Object, e As EventArgs) Handles btnResultatAnnotations.Click
        Dim moyYeuxx, moyYeuxy As Integer
        ratioLevre = Math.Sqrt((blx - lhx) * (blx - lhx) + (bly - lhy) * (bly - lhy)) / Math.Sqrt((ldx - lgx) * (ldx - lgx) + (ldy - lgy) * (ldy - lgy))
        ratioLevre = Math.Round(ratioLevre, 3)
        moyYeuxx = Math.Abs(y2x + y1x) / 2
        moyYeuxy = Math.Abs(y2y + y1y) / 2
        ratioNez = Math.Sqrt((moyYeuxx - bnx) * (moyYeuxx - bnx) + (moyYeuxy - bny) * (moyYeuxy - bny)) / Math.Sqrt((bngx - bndx) * (bngx - bndx) + (bngy - bndy) * (bngy - bndy))
        ratioNez = Math.Round(ratioNez, 3)
        ratioVisage = Math.Sqrt((moyYeuxx - bmx) * (moyYeuxx - bmx) + (moyYeuxy) * (moyYeuxy)) / Math.Sqrt((bvgx - bvdx) * (bvgx - bvdx) + (bvdy - bvdy) * (bvdy - bvdy))
        ratioVisage = Math.Round(ratioVisage, 3)
        ratioYeux = Math.Sqrt((bvgx - bvdx) * (bvgx - bvdx) + (bvgy - bvdy) * (bvgy - bvdy)) / Math.Sqrt((y1x - y2x) * (y1x - y2x) + (y1y - y2y) * (y1y - y2y))
        ratioYeux = Math.Round(ratioYeux, 3)
        lblResultatAnnotations.Text = "Le ratio lèvre est " + CStr(ratioLevre) + Chr(10) + "Le ratio nez est " + CStr(ratioNez) + Chr(10) + "Le ratio visage est " + CStr(ratioVisage) + Chr(10) + "Le ratio yeux est " + CStr(ratioYeux)
    End Sub
    Dim aString, bString As String
    Dim ratioLevre, ratioNez, ratioVisage, ratioYeux As Double
    Private Sub tsmItemRetour_Click(sender As Object, e As EventArgs) Handles tsmItemRetour.Click

        'Vider les labels pour nettoyer la fenetre et réinitialiser les données '
        lblY2.Text = ""
        lblY1.Text = ""
        lblBVG.Text = ""
        lblBVD.Text = ""
        lblBN.Text = ""
        lblLH.Text = ""
        lblBL.Text = ""
        lblLG.Text = ""
        lblLD.Text = ""
        lblBNG.Text = ""
        lblBND.Text = ""
        lblBM.Text = ""
        lblResultatAnnotations.Text = ""
        Me.Hide()
        frmAccueil.Show()
    End Sub

    'Private Sub Btntest_Click(sender As Object, e As EventArgs) Handles btntest.Click
    'lblY2.Text = ""
    'lblY1.Text = ""
    'lblBVG.Text = ""
    'lblBVD.Text = ""
    'lblBN.Text = ""
    'lblLH.Text = ""
    'lblBL.Text = ""
    'lblLG.Text = ""
    'lblLD.Text = ""
    'lblBNG.Text = ""
    'lblBND.Text = ""
    'lblBM.Text = ""
    'lblResultatAnnotations.Text = ""

    'Me.Hide()
    'FrmOuvrirImg.Show()
    'End Sub '

    'Aide Utilisateur pour comprendre l'utilisation de l'interface '
    Private Sub tsmItemAide_Click(sender As Object, e As EventArgs) Handles tsmItemAide.Click
        MessageBox.Show("Commencez par lire les noms des points à annoter à gauche de la fenetre, puis pour chaque point d'annotation :
                        cliquez sur la partie du visage correspondante avant de cocher la case associée. Recommencez pour tous les points.
                        Une fois tous les points annotés cliquez sur le bouton en bas à gauche pour visualiser les coordonnées de tous les annotations du visage.")
    End Sub

    'Afficher les coordonnées du click sur un point de l'image dans le label correspondant '
    Private Sub picVisageAnnotation_MouseDown(sender As Object, e As MouseEventArgs) Handles picVisageAnnotation.MouseDown
        a = e.X
        b = e.Y
    End Sub
    Private Sub chkY1_Click(sender As Object, e As EventArgs) Handles chkY1.Click
        lblY1.Enabled = 1
        y2x = a
        y2y = b
        aString = CStr(a)
        bString = CStr(b)
        lblY1.Text = aString + "," + bString
    End Sub

    Private Sub chkY2_Click(sender As Object, e As EventArgs) Handles chkY2.Click
        lblY2.Enabled = 1
        y1x = a
        y1y = b
        aString = CStr(a)
        bString = CStr(b)
        lblY2.Text = aString + "," + bString
    End Sub

    Private Sub chkBVG_Click(sender As Object, e As EventArgs) Handles chkBVG.Click
        lblBVG.Enabled = 1
        bvgx = a
        bvgy = b
        aString = CStr(a)
        bString = CStr(b)
        lblBVG.Text = aString + "," + bString
    End Sub

    Private Sub chkBVD_Click(sender As Object, e As EventArgs) Handles chkBVD.Click
        lblBVD.Enabled = 1
        bvdx = a
        bvdy = b
        aString = CStr(a)
        bString = CStr(b)
        lblBVD.Text = aString + "," + bString
    End Sub

    Private Sub chkBN_Click(sender As Object, e As EventArgs) Handles chkBN.Click
        lblBN.Enabled = 1
        bnx = a
        bny = b
        aString = CStr(a)
        bString = CStr(b)
        lblBN.Text = aString + "," + bString
    End Sub

    Private Sub chkBNG_Click(sender As Object, e As EventArgs) Handles chkBNG.Click
        lblBNG.Enabled = 1
        bngx = a
        bngy = b
        aString = CStr(a)
        bString = CStr(b)
        lblBNG.Text = aString + "," + bString
    End Sub

    Private Sub chkBND_Click(sender As Object, e As EventArgs) Handles chkBND.Click
        lblBND.Enabled = 1
        bndx = a
        bndy = b
        aString = CStr(a)
        bString = CStr(b)
        lblBND.Text = aString + "," + bString
    End Sub

    Private Sub chkBM_Click(sender As Object, e As EventArgs) Handles chkBM.Click
        lblBM.Enabled = 1
        bnx = a
        bny = b
        aString = CStr(a)
        bString = CStr(b)
        lblBM.Text = aString + "," + bString
    End Sub

    Private Sub chkLH_Click(sender As Object, e As EventArgs) Handles chkLH.Click
        lblLH.Enabled = 1
        lhx = a
        lhy = b
        aString = CStr(a)
        bString = CStr(b)
        lblLH.Text = aString + "," + bString
    End Sub

    Private Sub chkBL_Click(sender As Object, e As EventArgs) Handles chkBL.Click
        lblBL.Enabled = 1
        blx = a
        bly = b
        aString = CStr(a)
        bString = CStr(b)
        lblBL.Text = aString + "," + bString
    End Sub

    Private Sub chkLG_Click(sender As Object, e As EventArgs) Handles chkLG.Click
        lblLG.Enabled = 1
        lgx = a
        lgy = b
        aString = CStr(a)
        bString = CStr(b)
        lblLG.Text = aString + "," + bString
    End Sub

    Private Sub chkLD_Click(sender As Object, e As EventArgs) Handles chkLD.Click
        lblLD.Enabled = 1
        ldx = a
        ldy = b
        aString = CStr(a)
        bString = CStr(b)
        lblLD.Text = aString + "," + bString
    End Sub

    Dim CoordonnéesVisage, enteteFichier As String

    'Enregistrement des coordonnées de l'image annotée dans un fichier csv '
    Private Sub tsmItemEnregistrer_Click(sender As Object, e As EventArgs) Handles tsmItemEnregistrer.Click
        sfdEnregistrerAnnotationsCSV.InitialDirectory = frmSelectionChemin.fbdChoisirCheminProjet.SelectedPath
        enteteFichier = ("imagefile;Y1.x;Y1.y;BVG.x;BVG.y; BVD.x; BVD.y; BN.x; BN.y; BNG.x;BNG.y; BND.x;BND.y; BM.x; BM.y; LH.x;LH.y; BL.x;BL.y; LG.X;LG.y; LD.x;LD.y;Y2.x;Y2.y")
        CoordonnéesVisage = (lblNomImage.Text + ";" + CStr(y1x) + ";" + CStr(y1y) + ";" + CStr(bvgx) + ";" + CStr(bvgy) + ";" + CStr(bvdx) + ";" + CStr(bvdy) + ";" + CStr(bnx) + ";" + CStr(bny) + ";" + CStr(bngx) + ";" + CStr(bngy) + ";" + CStr(bndx) + ";" + CStr(bndy) + ";" + CStr(bnx) + ";" + CStr(bny) + ";" + CStr(lhx) + ";" + CStr(lhy) + ";" + CStr(blx) + ";" + CStr(bly) + ";" + CStr(lgx) + ";" + CStr(lgy) + ";" + CStr(ldx) + ";" + CStr(ldy)) + ";" + CStr(y2x) + ";" + CStr(y2y)
        sfdEnregistrerAnnotationsCSV.Filter = "Fichier excel|*.csv"
        If sfdEnregistrerAnnotationsCSV.ShowDialog() = DialogResult.OK Then
            Dim StreamW As New StreamWriter(sfdEnregistrerAnnotationsCSV.FileName)
            StreamW.WriteLine(enteteFichier)
            StreamW.WriteLine(CoordonnéesVisage)
            StreamW.Dispose()
        End If
    End Sub
End Class