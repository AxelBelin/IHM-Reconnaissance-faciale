<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccueil))
        Me.pbAccueil = New System.Windows.Forms.PictureBox()
        Me.btnSelectionnerImage = New System.Windows.Forms.Button()
        Me.ofdSelectionImage = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pbAccueil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAccueil
        '
        Me.pbAccueil.Image = CType(resources.GetObject("pbAccueil.Image"), System.Drawing.Image)
        Me.pbAccueil.Location = New System.Drawing.Point(138, 12)
        Me.pbAccueil.Name = "pbAccueil"
        Me.pbAccueil.Size = New System.Drawing.Size(774, 463)
        Me.pbAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAccueil.TabIndex = 0
        Me.pbAccueil.TabStop = False
        '
        'btnSelectionnerImage
        '
        Me.btnSelectionnerImage.Location = New System.Drawing.Point(411, 503)
        Me.btnSelectionnerImage.Name = "btnSelectionnerImage"
        Me.btnSelectionnerImage.Size = New System.Drawing.Size(196, 67)
        Me.btnSelectionnerImage.TabIndex = 2
        Me.btnSelectionnerImage.Text = "Importer une image"
        Me.btnSelectionnerImage.UseVisualStyleBackColor = True
        '
        'ofdSelectionImage
        '
        Me.ofdSelectionImage.FileName = "OpenFileDialog1"
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 616)
        Me.Controls.Add(Me.btnSelectionnerImage)
        Me.Controls.Add(Me.pbAccueil)
        Me.Name = "frmAccueil"
        Me.Text = "Accueil Annotation et Reconnaissance faciale"
        CType(Me.pbAccueil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbAccueil As PictureBox
    Friend WithEvents btnSelectionnerImage As Button
    Friend WithEvents ofdSelectionImage As OpenFileDialog
End Class
