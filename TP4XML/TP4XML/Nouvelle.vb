'==============================
' Fichier : Nouvelle.vb
' Programmeur : Philippe Carpentier-Savard
' Date : Décembre 2011
'==============================

Public Class Nouvelle : Inherits TreeNode

    Private _tags As String
    Private _contenu As String

    ''' <summary>
    ''' Accesseur en lecture et écriture sur les mots-clés
    ''' </summary>
    Public Property Tags As String
        Get
            Return _tags
        End Get
        Set(ByVal value As String)
            _tags = value
        End Set
    End Property

    ''' <summary>
    ''' Accesseur en lecture et écriture sur le contenu
    ''' </summary>
    Public Property Contenu As String
        Get
            Return _contenu
        End Get
        Set(ByVal value As String)
            _contenu = value
        End Set
    End Property

    ''' <summary>
    ''' Constructeur de l'objet
    ''' </summary>
    Public Sub New(ByVal titre As String, ByVal tags As String, ByVal contenu As String)
        MyBase.New(titre.Replace(vbCr, "").Replace(vbLf, ""))
        _tags = tags.Replace(vbCr, "").Replace(vbLf, "")
        _contenu = contenu.Replace(vbCr, "").Replace(vbLf, "")
    End Sub

End Class