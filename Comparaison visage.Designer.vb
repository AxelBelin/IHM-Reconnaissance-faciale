<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComparerVisages
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbImageProjetActuel = New System.Windows.Forms.PictureBox()
        Me.pbImageTrouvee = New System.Windows.Forms.PictureBox()
        Me.lblNomImageProjetActuel = New System.Windows.Forms.Label()
        Me.lblNomImageTrouvee = New System.Windows.Forms.Label()
        Me.lblResultatComparaison = New System.Windows.Forms.Label()
        Me.btnRetourAnnotationImage = New System.Windows.Forms.Button()
        CType(Me.pbImageProjetActuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImageTrouvee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImageProjetActuel
        '
        Me.pbImageProjetActuel.Location = New System.Drawing.Point(2, 33)
        Me.pbImageProjetActuel.Name = "pbImageProjetActuel"
        Me.pbImageProjetActuel.Size = New System.Drawing.Size(517, 441)
        Me.pbImageProjetActuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImageProjetActuel.TabIndex = 0
        Me.pbImageProjetActuel.TabStop = False
        '
        'pbImageTrouvee
        '
        Me.pbImageTrouvee.Location = New System.Drawing.Point(525, 33)
        Me.pbImageTrouvee.Name = "pbImageTrouvee"
        Me.pbImageTrouvee.Size = New System.Drawing.Size(507, 441)
        Me.pbImageTrouvee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImageTrouvee.TabIndex = 1
        Me.pbImageTrouvee.TabStop = False
        '
        'lblNomImageProjetActuel
        '
        Me.lblNomImageProjetActuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomImageProjetActuel.Location = New System.Drawing.Point(12, 489)
        Me.lblNomImageProjetActuel.Name = "lblNomImageProjetActuel"
        Me.lblNomImageProjetActuel.Size = New System.Drawing.Size(485, 37)
        Me.lblNomImageProjetActuel.TabIndex = 2
        '
        'lblNomImageTrouvee
        '
        Me.lblNomImageTrouvee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNomImageTrouvee.Location = New System.Drawing.Point(537, 489)
        Me.lblNomImageTrouvee.Name = "lblNomImageTrouvee"
        Me.lblNomImageTrouvee.Size = New System.Drawing.Size(485, 37)
        Me.lblNomImageTrouvee.TabIndex = 3
        '
        'lblResultatComparaison
        '
        Me.lblResultatComparaison.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultatComparaison.Location = New System.Drawing.Point(223, 551)
        Me.lblResultatComparaison.Name = "lblResultatComparaison"
        Me.lblResultatComparaison.Size = New System.Drawing.Size(589, 70)
        Me.lblResultatComparaison.TabIndex = 4
        '
        'btnRetourAnnotationImage
        '
        Me.btnRetourAnnotationImage.Location = New System.Drawing.Point(859, 563)
        Me.btnRetourAnnotationImage.Name = "btnRetourAnnotationImage"
        Me.btnRetourAnnotationImage.Size = New System.Drawing.Size(163, 55)
        Me.btnRetourAnnotationImage.TabIndex = 5
        Me.btnRetourAnnotationImage.Text = "Retour page d'annotation visage"
        Me.btnRetourAnnotationImage.UseVisualStyleBackColor = True
        '
        'frmComparerVisages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 630)
        Me.Controls.Add(Me.btnRetourAnnotationImage)
        Me.Controls.Add(Me.lblResultatComparaison)
        Me.Controls.Add(Me.lblNomImageTrouvee)
        Me.Controls.Add(Me.lblNomImageProjetActuel)
        Me.Controls.Add(Me.pbImageTrouvee)
        Me.Controls.Add(Me.pbImageProjetActuel)
        Me.Name = "frmComparerVisages"
        Me.Text = "Comparaison avec le visage le plus proche"
        CType(Me.pbImageProjetActuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImageTrouvee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbImageProjetActuel As PictureBox
    Friend WithEvents pbImageTrouvee As PictureBox
    Friend WithEvents lblNomImageProjetActuel As Label
    Friend WithEvents lblNomImageTrouvee As Label
    Friend WithEvents lblResultatComparaison As Label
    Friend WithEvents btnRetourAnnotationImage As Button
End Class
