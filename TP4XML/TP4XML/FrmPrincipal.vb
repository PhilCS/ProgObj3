'==============================
' Fichier : FrmPrincipal.vb
' Programmeur : Philippe Carpentier-Savard
' Date : Décembre 2011
'==============================

Imports System.IO
Imports System.Text

Public Class FrmPrincipal

    Private _nomFlux As String
    Private _categories As List(Of Categorie)   'Les instances absolues des enfants de chaque obj. Categorie sont stockées dans sa liste-membre
    '                                            "_noeuds" alors que ce qui est visible est référencé dans la collection Nodes de celui-ci.
    '                                            La raison de ce choix est qu'un objet TreeNode ne possède pas de propriété "Visible" pour
    '                                            faciliter l'affichage sélectif, qu'il ne peut avoir plusieurs noeuds parents, et que créer
    '                                            un arbre temporaire gaspille des ressources inutilement.
    Private _fichierOuvert As Boolean
    Private _fichierModif As Boolean

    ''' <summary>
    ''' Ajoute une catégorie du fichier XML à la liste _categories;
    ''' Traite ainsi récursivement ses sous-catégories
    ''' </summary>
    Private Sub AjoutCategorie(ByRef cat As XElement, Optional ByRef parent As Categorie = Nothing)

        Dim uneCategorie As New Categorie(cat.Name.LocalName)

        For Each noeud In cat.Elements
            If noeud.Name.LocalName = "news" Then : AjoutNouvelle(noeud, uneCategorie)
            Else : AjoutCategorie(noeud, uneCategorie) : End If
        Next

        If parent Is Nothing Then : _categories.Add(uneCategorie)
        Else : parent.ListeNoeuds.Add(uneCategorie) : End If

    End Sub

    ''' <summary>
    ''' Ajoute une nouvelle du fichier XML à la catégorie passée en référence
    ''' </summary>
    Private Sub AjoutNouvelle(ByRef noeud As XElement, ByRef parent As Categorie)
        Dim news = New Nouvelle(noeud.Element("title").Value,
                                noeud.Element("tags").Value,
                                noeud.Element("body").Value)
        parent.ListeNoeuds.Add(news)
    End Sub

    ''' <summary>
    ''' Actualise le TreeView avec les données de la liste _categories;
    ''' Si un vecteur de chaînes est passée en entrée, seulement les
    ''' nouvelles ayant des mots-clés correspondants seront affichées en
    ''' entrée, ainsi que leurs catégories parentes.
    ''' </summary>
    Private Sub Affichage(Optional ByVal tagsRecherche() As String = Nothing)

        tv.SelectedNode = Nothing
        EtatBouttons(False)

        tv.BeginUpdate()

        'Nettoyage récursif des branches visibles
        If tv.TopNode IsNot Nothing Then
            While tv.TopNode.Nodes.Count > 0 : NettoyageRecursif(tv.TopNode.LastNode) : End While
            tv.TopNode.Remove()
        End If

        tv.Enabled = True
        tv.BackColor = SystemColors.Window

        Dim racine As New TreeNode(_nomFlux)

        For Each noeud In _categories
            AffichageRecursif(noeud, tagsRecherche)
            If tagsRecherche Is Nothing OrElse noeud.GetNodeCount(False) > 0 Then _
                racine.Nodes.Add(noeud)
        Next

        tv.Nodes.Add(racine)

        'Tout développer lors d'une recherche
        If tagsRecherche IsNot Nothing Then : tv.ExpandAll()
        Else
            tv.CollapseAll()
            tv.TopNode.Expand()
        End If

        tv.EndUpdate()
        gbTags.Enabled = True

    End Sub

    ''' <summary>
    ''' Decends jusqu'aux feuilles du noeud passé en entrée, et remonte en
    ''' retirant tous les enfants de celui-ci
    ''' </summary>
    Private Sub NettoyageRecursif(ByRef noeud As TreeNode)

        If TypeOf noeud Is Categorie Then _
            While noeud.Nodes.Count > 0 : NettoyageRecursif(noeud.LastNode) : End While
        noeud.Remove()

    End Sub

    ''' <summary>
    ''' Complément de la méthode Affichage; Construit l'arbre de références
    ''' des enfants du noeud passé en entrée pour affichage ultérieur dans
    ''' le TreeView. Si un vecteur de chaînes est passé en entrée, tous les
    ''' articles ne contenant pas les mots-clés seront omis, ainsi que les
    ''' catégories vides.
    ''' </summary>
    Private Sub AffichageRecursif(ByRef noeud As Categorie,
                                  ByRef tagsRecherche() As String)

        For Each sousNoeud In noeud.ListeNoeuds

            If TypeOf sousNoeud Is Nouvelle Then
                Dim found = 0

                If tagsRecherche IsNot Nothing Then
                    For Each tagRecherche As String In tagsRecherche
                        For Each tagNouvelle As String In CType(sousNoeud, Nouvelle).Tags.Trim.Split(CChar(" "))
                            If tagNouvelle = tagRecherche Then found += 1
                        Next
                    Next
                End If

                If tagsRecherche Is Nothing OrElse found = tagsRecherche.Length Then _
                    noeud.Nodes.Add(sousNoeud)

            ElseIf TypeOf sousNoeud Is Categorie Then
                AffichageRecursif(CType(sousNoeud, Categorie), tagsRecherche)

                'On n'ajoute pas les catégories vides lors d'une recherche par mots-clés
                If tagsRecherche Is Nothing OrElse CType(sousNoeud, Categorie).GetNodeCount(False) > 0 Then _
                    noeud.Nodes.Add(sousNoeud)
            End If

        Next

    End Sub

    ''' <summary>
    ''' Change l'état des boutons Visionner et Modifier
    ''' </summary>
    Private Sub EtatBouttons(ByVal etat As Boolean)
        If etat Then
            btnVisionner.Enabled = True
            btnModifier.Enabled = True
        Else
            btnVisionner.Enabled = False
            btnModifier.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Traire récursivement les enfants du noeud passé en entrée en écrivant
    ''' dans l'objet SteamWriter leurs données sous une structure XML.
    ''' </summary>
    Private Sub SauvegardeRecursive(ByRef noeud As TreeNode, ByRef sw As StreamWriter)

        If TypeOf noeud Is Categorie Then

            sw.WriteLine("<" + noeud.Text + ">")
            If noeud.Nodes.Count > 0 Then
                For Each sousNoeud As TreeNode In noeud.Nodes
                    SauvegardeRecursive(sousNoeud, sw)
                Next
            End If
            sw.WriteLine("</" + noeud.Text + ">")

        ElseIf TypeOf noeud Is Nouvelle Then
            sw.WriteLine("<news>" + vbCrLf +
                         "<title>" + noeud.Text + vbCrLf +
                         "</title>" + vbCrLf +
                         "<tags>" + CType(noeud, Nouvelle).Tags + vbCrLf +
                         "</tags>" + vbCrLf +
                         "<body>" + CType(noeud, Nouvelle).Contenu + vbCrLf +
                         "</body>" + vbCrLf +
                         "</news>")
        End If

    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirToolStripMenuItem.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Fichier XML (*.xml)|*.xml"
        ofd.DefaultExt = ".xml"

        If ofd.ShowDialog() = DialogResult.OK Then
            _categories = New List(Of Categorie)

            Dim fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
            Dim doc = XDocument.Load(fs)

            _nomFlux = doc.Element("feed").Nodes.OfType(Of XText).FirstOrDefault.Value.Replace(vbCr, "").Replace(vbLf, "")

            For Each cat In doc.Element("feed").Elements
                AjoutCategorie(cat)
            Next

            fs.Close()
            _fichierOuvert = True
            Affichage()
        End If

    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SauvegarderToolStripMenuItem.Click
        If Not _fichierOuvert Then : MessageBox.Show("Il n'y a aucun document d'ouvert.", "Erreur",
                                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Fichier XML (*.xml)|*.xml"
            sfd.DefaultExt = ".xml"

            If sfd.ShowDialog() = DialogResult.OK Then

                Dim sw As New StreamWriter(sfd.FileName)

                sw.WriteLine("<feed>" + _nomFlux)
                For Each noeud In _categories
                    SauvegardeRecursive(CType(noeud, TreeNode), sw)
                Next
                sw.WriteLine("</feed>")

                sw.Close()

            End If
        End If

    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click

        If _fichierModif Then
            Dim resultat = MessageBox.Show("Les modifications apportées aux nouvelles n'ont pas encore été enregistrées. " +
                                           "Voulez-vous vraiment quitter?", "Fichier non enregistré",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultat = DialogResult.No Then Return
        End If
        Application.Exit()

    End Sub

    Private Sub btnRecherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecherche.Click
        Dim tags = txtTags.Text.ToLower.Trim
        Affichage(If(String.IsNullOrEmpty(tags), Nothing, tags.Split(CChar(" "))))
    End Sub

    Private Sub btnReinit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReinit.Click
        txtTags.Clear()
        Affichage()
    End Sub

    Private Sub tv_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv.AfterSelect
        If TypeOf tv.SelectedNode Is Nouvelle Then : EtatBouttons(True)
        Else : EtatBouttons(False) : End If
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Dim frmN = New FrmNouvelle(CType(tv.SelectedNode, Nouvelle), True)
        If frmN.ShowDialog() = DialogResult.OK AndAlso frmN.NouvelleModif Then
            CType(tv.SelectedNode, Nouvelle).Tags = frmN.Tags
            CType(tv.SelectedNode, Nouvelle).Contenu = frmN.Contenu
            _fichierModif = True
        End If

        frmN.Dispose()
    End Sub

    Private Sub btnVisionner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisionner.Click
        Dim frmN = New FrmNouvelle(CType(tv.SelectedNode, Nouvelle))
        frmN.ShowDialog()
        frmN.Dispose()
    End Sub

End Class
