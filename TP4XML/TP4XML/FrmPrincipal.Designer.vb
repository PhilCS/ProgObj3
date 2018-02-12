<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.btnVisionner = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.btnRecherche = New System.Windows.Forms.Button()
        Me.btnReinit = New System.Windows.Forms.Button()
        Me.gbTags = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbTags.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(397, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.SauvegarderToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir un fichier..."
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SauvegarderToolStripMenuItem.Text = "Enregistrer sous..."
        '
        'tv
        '
        Me.tv.BackColor = System.Drawing.SystemColors.Control
        Me.tv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tv.HideSelection = False
        Me.tv.Location = New System.Drawing.Point(13, 37)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(371, 229)
        Me.tv.TabIndex = 1
        '
        'btnVisionner
        '
        Me.btnVisionner.Enabled = False
        Me.btnVisionner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisionner.Location = New System.Drawing.Point(12, 328)
        Me.btnVisionner.Name = "btnVisionner"
        Me.btnVisionner.Size = New System.Drawing.Size(121, 35)
        Me.btnVisionner.TabIndex = 2
        Me.btnVisionner.Text = "Visionner"
        Me.btnVisionner.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Enabled = False
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(138, 328)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(121, 35)
        Me.btnModifier.TabIndex = 3
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.Location = New System.Drawing.Point(264, 328)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(121, 35)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'txtTags
        '
        Me.txtTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTags.Location = New System.Drawing.Point(6, 15)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.Size = New System.Drawing.Size(199, 22)
        Me.txtTags.TabIndex = 5
        '
        'btnRecherche
        '
        Me.btnRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecherche.Location = New System.Drawing.Point(211, 14)
        Me.btnRecherche.Name = "btnRecherche"
        Me.btnRecherche.Size = New System.Drawing.Size(75, 24)
        Me.btnRecherche.TabIndex = 6
        Me.btnRecherche.Text = "Rechercher"
        Me.btnRecherche.UseVisualStyleBackColor = True
        '
        'btnReinit
        '
        Me.btnReinit.Location = New System.Drawing.Point(291, 14)
        Me.btnReinit.Name = "btnReinit"
        Me.btnReinit.Size = New System.Drawing.Size(75, 24)
        Me.btnReinit.TabIndex = 7
        Me.btnReinit.Text = "Réinitialiser"
        Me.btnReinit.UseVisualStyleBackColor = True
        '
        'gbTags
        '
        Me.gbTags.Controls.Add(Me.btnReinit)
        Me.gbTags.Controls.Add(Me.txtTags)
        Me.gbTags.Controls.Add(Me.btnRecherche)
        Me.gbTags.Enabled = False
        Me.gbTags.Location = New System.Drawing.Point(12, 273)
        Me.gbTags.Name = "gbTags"
        Me.gbTags.Size = New System.Drawing.Size(373, 44)
        Me.gbTags.TabIndex = 8
        Me.gbTags.TabStop = False
        Me.gbTags.Text = "Mots-clés"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 375)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnVisionner)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbTags)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Text = "Éditeur de nouvelles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbTags.ResumeLayout(False)
        Me.gbTags.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SauvegarderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tv As System.Windows.Forms.TreeView
    Friend WithEvents btnVisionner As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents txtTags As System.Windows.Forms.TextBox
    Friend WithEvents btnRecherche As System.Windows.Forms.Button
    Friend WithEvents btnReinit As System.Windows.Forms.Button
    Friend WithEvents gbTags As System.Windows.Forms.GroupBox

End Class
