<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectionChemin
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
        Me.txtCheminProjet = New System.Windows.Forms.TextBox()
        Me.lblBienvenue = New System.Windows.Forms.Label()
        Me.btnChoisirChemin = New System.Windows.Forms.Button()
        Me.btnConfirmerChemin = New System.Windows.Forms.Button()
        Me.fbdChoisirCheminProjet = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'txtCheminProjet
        '
        Me.txtCheminProjet.Location = New System.Drawing.Point(80, 132)
        Me.txtCheminProjet.Name = "txtCheminProjet"
        Me.txtCheminProjet.Size = New System.Drawing.Size(1084, 22)
        Me.txtCheminProjet.TabIndex = 0
        '
        'lblBienvenue
        '
        Me.lblBienvenue.AutoSize = True
        Me.lblBienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenue.Location = New System.Drawing.Point(47, 9)
        Me.lblBienvenue.Name = "lblBienvenue"
        Me.lblBienvenue.Size = New System.Drawing.Size(1153, 29)
        Me.lblBienvenue.TabIndex = 1
        Me.lblBienvenue.Text = "Bienvenue, veuillez selectionner un chemin dans lequel les coordonnées des images" &
    " seront sauvegardées"
        '
        'btnChoisirChemin
        '
        Me.btnChoisirChemin.Location = New System.Drawing.Point(80, 208)
        Me.btnChoisirChemin.Name = "btnChoisirChemin"
        Me.btnChoisirChemin.Size = New System.Drawing.Size(121, 23)
        Me.btnChoisirChemin.TabIndex = 2
        Me.btnChoisirChemin.Text = "Chosir Chemin"
        Me.btnChoisirChemin.UseVisualStyleBackColor = True
        '
        'btnConfirmerChemin
        '
        Me.btnConfirmerChemin.Location = New System.Drawing.Point(1084, 208)
        Me.btnConfirmerChemin.Name = "btnConfirmerChemin"
        Me.btnConfirmerChemin.Size = New System.Drawing.Size(80, 23)
        Me.btnConfirmerChemin.TabIndex = 3
        Me.btnConfirmerChemin.Text = "Confirmer"
        Me.btnConfirmerChemin.UseVisualStyleBackColor = True
        '
        'frmSelectionChemin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 278)
        Me.Controls.Add(Me.btnConfirmerChemin)
        Me.Controls.Add(Me.btnChoisirChemin)
        Me.Controls.Add(Me.lblBienvenue)
        Me.Controls.Add(Me.txtCheminProjet)
        Me.Name = "frmSelectionChemin"
        Me.Text = "Veuillez séléctionner un répertoire projet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCheminProjet As TextBox
    Friend WithEvents lblBienvenue As Label
    Friend WithEvents btnChoisirChemin As Button
    Friend WithEvents btnConfirmerChemin As Button
    Friend WithEvents fbdChoisirCheminProjet As FolderBrowserDialog
End Class
