'==============================
' Fichier : Categorie.vb
' Programmeur : Philippe Carpentier-Savard
' Date : Décembre 2011
'==============================

Public Class Categorie : Inherits TreeNode

    Private _noeuds As New List(Of TreeNode)

    ''' <summary>
    ''' Accesseur par référence sur la liste des noeuds enfants
    ''' </summary>
    Public ReadOnly Property ListeNoeuds As List(Of TreeNode)
        Get
            Return _noeuds
        End Get
    End Property

    ''' <summary>
    ''' Constructeur de l'objet
    ''' </summary>
    Public Sub New(ByVal nom As String)
        MyBase.New(nom.Replace(vbCr, "").Replace(vbLf, ""))
    End Sub

End Class