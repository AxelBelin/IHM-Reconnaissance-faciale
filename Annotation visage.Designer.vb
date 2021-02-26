<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnnotationVisage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mnuOutilsAnnotation = New System.Windows.Forms.MenuStrip()
        Me.ChargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemChargerImageVisage = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnotationDeVisageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemEnregistrer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemComparer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemRetour = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmItemAide = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblResultatAnnotations = New System.Windows.Forms.Label()
        Me.lblLD = New System.Windows.Forms.Label()
        Me.lblLG = New System.Windows.Forms.Label()
        Me.lblBL = New System.Windows.Forms.Label()
        Me.lblLH = New System.Windows.Forms.Label()
        Me.lblBM = New System.Windows.Forms.Label()
        Me.lblBNG = New System.Windows.Forms.Label()
        Me.lblBND = New System.Windows.Forms.Label()
        Me.lblBN = New System.Windows.Forms.Label()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.lblBVG = New System.Windows.Forms.Label()
        Me.lblBVD = New System.Windows.Forms.Label()
        Me.lblY1 = New System.Windows.Forms.Label()
        Me.btnResultatAnnotations = New System.Windows.Forms.Button()
        Me.chkLD = New System.Windows.Forms.CheckBox()
        Me.chkLG = New System.Windows.Forms.CheckBox()
        Me.chkBL = New System.Windows.Forms.CheckBox()
        Me.chkLH = New System.Windows.Forms.CheckBox()
        Me.chkBM = New System.Windows.Forms.CheckBox()
        Me.chkBNG = New System.Windows.Forms.CheckBox()
        Me.chkBND = New System.Windows.Forms.CheckBox()
        Me.chkBN = New System.Windows.Forms.CheckBox()
        Me.chkBVG = New System.Windows.Forms.CheckBox()
        Me.chkBVD = New System.Windows.Forms.CheckBox()
        Me.chkY2 = New System.Windows.Forms.CheckBox()
        Me.chkY1 = New System.Windows.Forms.CheckBox()
        Me.lblExplication = New System.Windows.Forms.Label()
        Me.lblNomImage = New System.Windows.Forms.Label()
        Me.picVisageAnnotation = New System.Windows.Forms.PictureBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.sfdEnregistrerAnnotationsCSV = New System.Windows.Forms.SaveFileDialog()
        Me.ofdChargerAnnotation = New System.Windows.Forms.OpenFileDialog()
        Me.mnuOutilsAnnotation.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.picVisageAnnotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuOutilsAnnotation
        '
        Me.mnuOutilsAnnotation.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuOutilsAnnotation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerToolStripMenuItem, Me.tsmItemEnregistrer, Me.tsmItemComparer, Me.tsmItemRetour, Me.tsmItemAide})
        Me.mnuOutilsAnnotation.Location = New System.Drawing.Point(0, 0)
        Me.mnuOutilsAnnotation.Name = "mnuOutilsAnnotation"
        Me.mnuOutilsAnnotation.Size = New System.Drawing.Size(1367, 28)
        Me.mnuOutilsAnnotation.TabIndex = 0
        Me.mnuOutilsAnnotation.Text = "MenuStrip1"
        '
        'ChargerToolStripMenuItem
        '
        Me.ChargerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmItemChargerImageVisage, Me.AnnotationDeVisageToolStripMenuItem})
        Me.ChargerToolStripMenuItem.Name = "ChargerToolStripMenuItem"
        Me.ChargerToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.ChargerToolStripMenuItem.Text = "Charger / Ouvrir"
        '
        'tsmItemChargerImageVisage
        '
        Me.tsmItemChargerImageVisage.Name = "tsmItemChargerImageVisage"
        Me.tsmItemChargerImageVisage.Size = New System.Drawing.Size(275, 26)
        Me.tsmItemChargerImageVisage.Text = "Annotation de Visage (CSV)"
        '
        'AnnotationDeVisageToolStripMenuItem
        '
        Me.AnnotationDeVisageToolStripMenuItem.Name = "AnnotationDeVisageToolStripMenuItem"
        Me.AnnotationDeVisageToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AnnotationDeVisageToolStripMenuItem.Text = "Charger"
        '
        'tsmItemEnregistrer
        '
        Me.tsmItemEnregistrer.Name = "tsmItemEnregistrer"
        Me.tsmItemEnregistrer.Size = New System.Drawing.Size(94, 24)
        Me.tsmItemEnregistrer.Text = "Enregistrer"
        '
        'tsmItemComparer
        '
        Me.tsmItemComparer.Name = "tsmItemComparer"
        Me.tsmItemComparer.Size = New System.Drawing.Size(137, 24)
        Me.tsmItemComparer.Text = "Comparer Visage"
        '
        'tsmItemRetour
        '
        Me.tsmItemRetour.Name = "tsmItemRetour"
        Me.tsmItemRetour.Size = New System.Drawing.Size(119, 24)
        Me.tsmItemRetour.Text = "Retour Accueil"
        '
        'tsmItemAide
        '
        Me.tsmItemAide.Name = "tsmItemAide"
        Me.tsmItemAide.Size = New System.Drawing.Size(125, 24)
        Me.tsmItemAide.Text = "Besoin d'Aide ?"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblResultatAnnotations)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBNG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBND)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblY2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBVG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBVD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblY1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnResultatAnnotations)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkLD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkLG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBL)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkLH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBM)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBNG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBND)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBVG)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkBVD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkY2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkY1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblExplication)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblNomImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picVisageAnnotation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTitre)
        Me.SplitContainer1.Size = New System.Drawing.Size(1367, 565)
        Me.SplitContainer1.SplitterDistance = 455
        Me.SplitContainer1.TabIndex = 1
        '
        'lblResultatAnnotations
        '
        Me.lblResultatAnnotations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblResultatAnnotations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultatAnnotations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultatAnnotations.Location = New System.Drawing.Point(171, 451)
        Me.lblResultatAnnotations.Name = "lblResultatAnnotations"
        Me.lblResultatAnnotations.Size = New System.Drawing.Size(281, 105)
        Me.lblResultatAnnotations.TabIndex = 34
        '
        'lblLD
        '
        Me.lblLD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLD.Location = New System.Drawing.Point(322, 404)
        Me.lblLD.Name = "lblLD"
        Me.lblLD.Size = New System.Drawing.Size(99, 21)
        Me.lblLD.TabIndex = 33
        '
        'lblLG
        '
        Me.lblLG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLG.Location = New System.Drawing.Point(322, 366)
        Me.lblLG.Name = "lblLG"
        Me.lblLG.Size = New System.Drawing.Size(99, 21)
        Me.lblLG.TabIndex = 32
        '
        'lblBL
        '
        Me.lblBL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBL.Location = New System.Drawing.Point(322, 328)
        Me.lblBL.Name = "lblBL"
        Me.lblBL.Size = New System.Drawing.Size(99, 21)
        Me.lblBL.TabIndex = 31
        '
        'lblLH
        '
        Me.lblLH.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLH.Location = New System.Drawing.Point(322, 292)
        Me.lblLH.Name = "lblLH"
        Me.lblLH.Size = New System.Drawing.Size(99, 21)
        Me.lblLH.TabIndex = 30
        '
        'lblBM
        '
        Me.lblBM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBM.Location = New System.Drawing.Point(322, 255)
        Me.lblBM.Name = "lblBM"
        Me.lblBM.Size = New System.Drawing.Size(99, 21)
        Me.lblBM.TabIndex = 29
        '
        'lblBNG
        '
        Me.lblBNG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBNG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBNG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBNG.Location = New System.Drawing.Point(322, 218)
        Me.lblBNG.Name = "lblBNG"
        Me.lblBNG.Size = New System.Drawing.Size(99, 21)
        Me.lblBNG.TabIndex = 28
        '
        'lblBND
        '
        Me.lblBND.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBND.Location = New System.Drawing.Point(322, 182)
        Me.lblBND.Name = "lblBND"
        Me.lblBND.Size = New System.Drawing.Size(99, 21)
        Me.lblBND.TabIndex = 27
        '
        'lblBN
        '
        Me.lblBN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBN.Location = New System.Drawing.Point(322, 145)
        Me.lblBN.Name = "lblBN"
        Me.lblBN.Size = New System.Drawing.Size(99, 21)
        Me.lblBN.TabIndex = 26
        '
        'lblY2
        '
        Me.lblY2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblY2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY2.Location = New System.Drawing.Point(322, 43)
        Me.lblY2.Name = "lblY2"
        Me.lblY2.Size = New System.Drawing.Size(99, 21)
        Me.lblY2.TabIndex = 25
        '
        'lblBVG
        '
        Me.lblBVG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBVG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBVG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBVG.Location = New System.Drawing.Point(322, 109)
        Me.lblBVG.Name = "lblBVG"
        Me.lblBVG.Size = New System.Drawing.Size(99, 21)
        Me.lblBVG.TabIndex = 24
        '
        'lblBVD
        '
        Me.lblBVD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBVD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBVD.Location = New System.Drawing.Point(322, 79)
        Me.lblBVD.Name = "lblBVD"
        Me.lblBVD.Size = New System.Drawing.Size(99, 23)
        Me.lblBVD.TabIndex = 23
        '
        'lblY1
        '
        Me.lblY1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblY1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY1.Location = New System.Drawing.Point(322, 16)
        Me.lblY1.Name = "lblY1"
        Me.lblY1.Size = New System.Drawing.Size(99, 21)
        Me.lblY1.TabIndex = 22
        '
        'btnResultatAnnotations
        '
        Me.btnResultatAnnotations.Location = New System.Drawing.Point(13, 451)
        Me.btnResultatAnnotations.Name = "btnResultatAnnotations"
        Me.btnResultatAnnotations.Size = New System.Drawing.Size(152, 66)
        Me.btnResultatAnnotations.TabIndex = 13
        Me.btnResultatAnnotations.Text = "Voir résultat des Annotations complet"
        Me.btnResultatAnnotations.UseVisualStyleBackColor = True
        '
        'chkLD
        '
        Me.chkLD.AutoSize = True
        Me.chkLD.Location = New System.Drawing.Point(12, 403)
        Me.chkLD.Name = "chkLD"
        Me.chkLD.Size = New System.Drawing.Size(137, 21)
        Me.chkLD.TabIndex = 12
        Me.chkLD.Text = "Droite des lèvres"
        Me.chkLD.UseVisualStyleBackColor = True
        '
        'chkLG
        '
        Me.chkLG.AutoSize = True
        Me.chkLG.Location = New System.Drawing.Point(12, 365)
        Me.chkLG.Name = "chkLG"
        Me.chkLG.Size = New System.Drawing.Size(149, 21)
        Me.chkLG.TabIndex = 11
        Me.chkLG.Text = "Gauche des lèvres"
        Me.chkLG.UseVisualStyleBackColor = True
        '
        'chkBL
        '
        Me.chkBL.AutoSize = True
        Me.chkBL.Location = New System.Drawing.Point(12, 327)
        Me.chkBL.Name = "chkBL"
        Me.chkBL.Size = New System.Drawing.Size(123, 21)
        Me.chkBL.TabIndex = 10
        Me.chkBL.Text = "Bas des lèvres"
        Me.chkBL.UseVisualStyleBackColor = True
        '
        'chkLH
        '
        Me.chkLH.AutoSize = True
        Me.chkLH.Location = New System.Drawing.Point(12, 291)
        Me.chkLH.Name = "chkLH"
        Me.chkLH.Size = New System.Drawing.Size(129, 21)
        Me.chkLH.TabIndex = 9
        Me.chkLH.Text = "Haut des lèvres"
        Me.chkLH.UseVisualStyleBackColor = True
        '
        'chkBM
        '
        Me.chkBM.AutoSize = True
        Me.chkBM.Location = New System.Drawing.Point(12, 254)
        Me.chkBM.Name = "chkBM"
        Me.chkBM.Size = New System.Drawing.Size(125, 21)
        Me.chkBM.TabIndex = 8
        Me.chkBM.Text = "Bas du menton"
        Me.chkBM.UseVisualStyleBackColor = True
        '
        'chkBNG
        '
        Me.chkBNG.AutoSize = True
        Me.chkBNG.Location = New System.Drawing.Point(12, 217)
        Me.chkBNG.Name = "chkBNG"
        Me.chkBNG.Size = New System.Drawing.Size(165, 21)
        Me.chkBNG.TabIndex = 7
        Me.chkBNG.Text = "Bords du nez gauche"
        Me.chkBNG.UseVisualStyleBackColor = True
        '
        'chkBND
        '
        Me.chkBND.AutoSize = True
        Me.chkBND.Location = New System.Drawing.Point(12, 181)
        Me.chkBND.Name = "chkBND"
        Me.chkBND.Size = New System.Drawing.Size(146, 21)
        Me.chkBND.TabIndex = 6
        Me.chkBND.Text = "Bords du nez droit"
        Me.chkBND.UseVisualStyleBackColor = True
        '
        'chkBN
        '
        Me.chkBN.AutoSize = True
        Me.chkBN.Location = New System.Drawing.Point(12, 144)
        Me.chkBN.Name = "chkBN"
        Me.chkBN.Size = New System.Drawing.Size(101, 21)
        Me.chkBN.TabIndex = 5
        Me.chkBN.Text = "Bas du nez"
        Me.chkBN.UseVisualStyleBackColor = True
        '
        'chkBVG
        '
        Me.chkBVG.AutoSize = True
        Me.chkBVG.Location = New System.Drawing.Point(12, 108)
        Me.chkBVG.Name = "chkBVG"
        Me.chkBVG.Size = New System.Drawing.Size(314, 21)
        Me.chkBVG.TabIndex = 4
        Me.chkBVG.Text = "Bords du visage gauche (aligné sur les yeux)"
        Me.chkBVG.UseVisualStyleBackColor = True
        '
        'chkBVD
        '
        Me.chkBVD.AutoSize = True
        Me.chkBVD.Location = New System.Drawing.Point(12, 78)
        Me.chkBVD.Name = "chkBVD"
        Me.chkBVD.Size = New System.Drawing.Size(295, 21)
        Me.chkBVD.TabIndex = 3
        Me.chkBVD.Text = "Bords du visage droit (aligné sur les yeux)"
        Me.chkBVD.UseVisualStyleBackColor = True
        '
        'chkY2
        '
        Me.chkY2.AutoSize = True
        Me.chkY2.Location = New System.Drawing.Point(12, 42)
        Me.chkY2.Name = "chkY2"
        Me.chkY2.Size = New System.Drawing.Size(149, 21)
        Me.chkY2.TabIndex = 2
        Me.chkY2.Text = "Centre oeil gauche"
        Me.chkY2.UseVisualStyleBackColor = True
        '
        'chkY1
        '
        Me.chkY1.AutoSize = True
        Me.chkY1.Location = New System.Drawing.Point(13, 15)
        Me.chkY1.Name = "chkY1"
        Me.chkY1.Size = New System.Drawing.Size(130, 21)
        Me.chkY1.TabIndex = 1
        Me.chkY1.Text = "Centre oeil droit"
        Me.chkY1.UseVisualStyleBackColor = True
        '
        'lblExplication
        '
        Me.lblExplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplication.Location = New System.Drawing.Point(3, 9)
        Me.lblExplication.Name = "lblExplication"
        Me.lblExplication.Size = New System.Drawing.Size(902, 35)
        Me.lblExplication.TabIndex = 4
        Me.lblExplication.Text = "Cliquez sur la partie du visage que vous souhaitez annoter, puis cochez la case c" &
    "orrespondante"
        '
        'lblNomImage
        '
        Me.lblNomImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomImage.Location = New System.Drawing.Point(221, 58)
        Me.lblNomImage.Name = "lblNomImage"
        Me.lblNomImage.Size = New System.Drawing.Size(477, 23)
        Me.lblNomImage.TabIndex = 3
        '
        'picVisageAnnotation
        '
        Me.picVisageAnnotation.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picVisageAnnotation.Location = New System.Drawing.Point(8, 88)
        Me.picVisageAnnotation.Name = "picVisageAnnotation"
        Me.picVisageAnnotation.Size = New System.Drawing.Size(888, 465)
        Me.picVisageAnnotation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisageAnnotation.TabIndex = 2
        Me.picVisageAnnotation.TabStop = False
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(126, 58)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(72, 27)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Titre :"
        '
        'ofdChargerAnnotation
        '
        Me.ofdChargerAnnotation.FileName = "OpenFileDialog1"
        '
        'frmAnnotationVisage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 593)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuOutilsAnnotation)
        Me.MainMenuStrip = Me.mnuOutilsAnnotation
        Me.Name = "frmAnnotationVisage"
        Me.Text = "Annotation du visage"
        Me.mnuOutilsAnnotation.ResumeLayout(False)
        Me.mnuOutilsAnnotation.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.picVisageAnnotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuOutilsAnnotation As MenuStrip
    Friend WithEvents ChargerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmItemChargerImageVisage As ToolStripMenuItem
    Friend WithEvents AnnotationDeVisageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmItemEnregistrer As ToolStripMenuItem
    Friend WithEvents tsmItemComparer As ToolStripMenuItem
    Friend WithEvents tsmItemRetour As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents chkLD As CheckBox
    Friend WithEvents chkLG As CheckBox
    Friend WithEvents chkBL As CheckBox
    Friend WithEvents chkLH As CheckBox
    Friend WithEvents chkBM As CheckBox
    Friend WithEvents chkBNG As CheckBox
    Friend WithEvents chkBND As CheckBox
    Friend WithEvents chkBN As CheckBox
    Friend WithEvents chkBVG As CheckBox
    Friend WithEvents chkBVD As CheckBox
    Friend WithEvents chkY2 As CheckBox
    Friend WithEvents chkY1 As CheckBox
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnResultatAnnotations As Button
    Friend WithEvents picVisageAnnotation As PictureBox
    Friend WithEvents tsmItemAide As ToolStripMenuItem
    Friend WithEvents lblNomImage As Label
    Friend WithEvents lblExplication As Label
    Friend WithEvents lblBVG As Label
    Friend WithEvents lblBVD As Label
    Friend WithEvents lblY1 As Label
    Friend WithEvents lblBNG As Label
    Friend WithEvents lblBND As Label
    Friend WithEvents lblBN As Label
    Friend WithEvents lblY2 As Label
    Friend WithEvents lblBM As Label
    Friend WithEvents lblLD As Label
    Friend WithEvents lblLG As Label
    Friend WithEvents lblBL As Label
    Friend WithEvents lblLH As Label
    Friend WithEvents lblResultatAnnotations As Label
    Friend WithEvents sfdEnregistrerAnnotationsCSV As SaveFileDialog
    Friend WithEvents ofdChargerAnnotation As OpenFileDialog
End Class
