'==============================
' Fichier : FrmNouvelle.vb
' Programmeur : Philippe Carpentier-Savard
' Date : Décembre 2011
'==============================

Public Class FrmNouvelle

    Private _tags As String
    Private _contenu As String
    Private _modifier As Boolean
    Private _nouvelleModif As Boolean

    ''' <summary>
    ''' Accesseur en lecture sur les mots-clés modifiés
    ''' </summary>
    Public ReadOnly Property Tags As String
        Get
            Return _tags
        End Get
    End Property

    ''' <summary>
    ''' Accesseur en lecture sur le contenu modifié
    ''' </summary>
    Public ReadOnly Property Contenu As String
        Get
            Return _contenu
        End Get
    End Property

    ''' <summary>
    ''' Accesseur en lecture sur le booléen indiquant si la nouvelle a été modifiée
    ''' </summary>
    Public ReadOnly Property NouvelleModif As Boolean
        Get
            Return _nouvelleModif
        End Get
    End Property

    ''' <summary>
    ''' Constructeur du formulaire, s'active en mode visionnement ou édition selon
    ''' le booléen passé en entrée
    ''' </summary>
    Public Sub New(ByRef nouvelle As Nouvelle, Optional ByVal modifier As Boolean = False)

        InitializeComponent()

        If modifier Then
            Me.Text = "Modifier une nouvelle"
            txtTags.ReadOnly = False
            txtContenu.ReadOnly = False
            btnAccepter.Visible = True
            btnAccepter.Enabled = True
            btnRetour.Text = "Annuler"
        End If

        _modifier = modifier
        txtTitre.Text = nouvelle.Text
        txtTags.Text = nouvelle.Tags
        txtContenu.Text = nouvelle.Contenu

        _nouvelleModif = False

        ActiveControl = Nothing

    End Sub

    Private Sub txtTags_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTags.TextChanged

        If String.IsNullOrEmpty(txtTags.Text.Trim) Then
            MessageBox.Show("Vous devez entrer au moins un mot-clé.", "Champ vide",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf _modifier AndAlso Not _nouvelleModif Then : _nouvelleModif = True
        End If

    End Sub

    Private Sub txtContenu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContenu.TextChanged

        If String.IsNullOrEmpty(txtTags.Text.Trim) Then
            MessageBox.Show("Vous devez entrer au moins un mot.", "Contenu vide",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf _modifier AndAlso Not _nouvelleModif Then : _nouvelleModif = True
        End If

    End Sub

    Private Sub btnAccepter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccepter.Click
        If _modifier Then
            _tags = txtTags.Text
            _contenu = txtContenu.Text
        End If
    End Sub

    Private Sub btnRetour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetour.Click
        If _nouvelleModif Then
            Dim annuler = MessageBox.Show("Voulez-vous vraiment annuler vos modifications?", "Nouvelle modifiée",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If annuler = DialogResult.No Then Return
        End If

        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub FrmNouvelle_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ActiveControl = Nothing
    End Sub
End Class