#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 12/06/2019
#End Region

Public Class Ligne_bon_livraison

#Region "Logic Field"

    Public ReadOnly Property ArticleMember() As Article
        Get
            Return ArticleDAO.getInstance.Read(LG_BON_Liv_CodeArt)
        End Get
    End Property

    Public ReadOnly Property BonMember() As Bon_livraison
        Get
            Return Bon_livraisonDAO.getInstance.Read(LG_BON_Liv_NumBon)
        End Get
    End Property


#End Region

#Region "Method"

#End Region

End Class

Public Class Ligne_bon_livraisonDAO

#Region "Method"

#End Region

End Class

