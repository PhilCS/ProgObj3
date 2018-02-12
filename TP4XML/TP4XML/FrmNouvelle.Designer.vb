<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNouvelle
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblTags = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.txtTags = New System.Windows.Forms.TextBox()
        Me.txtContenu = New System.Windows.Forms.TextBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnAccepter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(44, 12)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(48, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Titre :"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTags
        '
        Me.lblTags.AutoSize = True
        Me.lblTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTags.Location = New System.Drawing.Point(7, 41)
        Me.lblTags.Name = "lblTags"
        Me.lblTags.Size = New System.Drawing.Size(85, 20)
        Me.lblTags.TabIndex = 1
        Me.lblTags.Text = "Mots-clés :"
        Me.lblTags.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contenu :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTitre
        '
        Me.txtTitre.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitre.Location = New System.Drawing.Point(98, 12)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.ReadOnly = True
        Me.txtTitre.Size = New System.Drawing.Size(248, 22)
        Me.txtTitre.TabIndex = 1
        '
        'txtTags
        '
        Me.txtTags.BackColor = System.Drawing.SystemColors.Window
        Me.txtTags.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTags.Location = New System.Drawing.Point(98, 41)
        Me.txtTags.Name = "txtTags"
        Me.txtTags.ReadOnly = True
        Me.txtTags.Size = New System.Drawing.Size(248, 22)
        Me.txtTags.TabIndex = 2
        '
        'txtContenu
        '
        Me.txtContenu.BackColor = System.Drawing.SystemColors.Window
        Me.txtContenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContenu.Location = New System.Drawing.Point(11, 91)
        Me.txtContenu.Multiline = True
        Me.txtContenu.Name = "txtContenu"
        Me.txtContenu.ReadOnly = True
        Me.txtContenu.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContenu.Size = New System.Drawing.Size(335, 118)
        Me.txtContenu.TabIndex = 3
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(224, 219)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(121, 35)
        Me.btnRetour.TabIndex = 5
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'btnAccepter
        '
        Me.btnAccepter.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAccepter.Enabled = False
        Me.btnAccepter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccepter.Location = New System.Drawing.Point(97, 219)
        Me.btnAccepter.Name = "btnAccepter"
        Me.btnAccepter.Size = New System.Drawing.Size(121, 35)
        Me.btnAccepter.TabIndex = 4
        Me.btnAccepter.Text = "Accepter"
        Me.btnAccepter.UseVisualStyleBackColor = True
        Me.btnAccepter.Visible = False
        '
        'FrmNouvelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 265)
        Me.Controls.Add(Me.btnAccepter)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.txtContenu)
        Me.Controls.Add(Me.txtTags)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTags)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmNouvelle"
        Me.Text = "Visionner une nouvelle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblTags As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents txtTags As System.Windows.Forms.TextBox
    Friend WithEvents txtContenu As System.Windows.Forms.TextBox
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents btnAccepter As System.Windows.Forms.Button
End Class
