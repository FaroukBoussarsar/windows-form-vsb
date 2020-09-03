#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 14/06/2019
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Partial Public Class Article
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _ART_Code As String = ""

    <XmlElementAttribute("ART_Code")>
    Public Property ART_Code() As String
        Get
            Return _ART_Code
        End Get
        Set(ByVal value As String)
            _ART_Code = value
        End Set
    End Property

    Private _ART_Designation As String = ""

    <XmlElementAttribute("ART_Designation")>
    Public Property ART_Designation() As String
        Get
            Return _ART_Designation
        End Get
        Set(ByVal value As String)
            _ART_Designation = value
        End Set
    End Property

    Private _ART_PrixUnitaireHT As Decimal = Nothing

    <XmlElementAttribute("ART_PrixUnitaireHT")>
    Public Property ART_PrixUnitaireHT() As Decimal
        Get
            Return _ART_PrixUnitaireHT
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixUnitaireHT = value
        End Set
    End Property

    Private _ART_CodeBar As String = ""

    <XmlElementAttribute("ART_CodeBar")>
    Public Property ART_CodeBar() As String
        Get
            Return _ART_CodeBar
        End Get
        Set(ByVal value As String)
            _ART_CodeBar = value
        End Set
    End Property

    Private _ART_DesgCourte As String = ""

    <XmlElementAttribute("ART_DesgCourte")>
    Public Property ART_DesgCourte() As String
        Get
            Return _ART_DesgCourte
        End Get
        Set(ByVal value As String)
            _ART_DesgCourte = value
        End Set
    End Property

    Private _ART_Famille As String = ""

    <XmlElementAttribute("ART_Famille")>
    Public Property ART_Famille() As String
        Get
            Return _ART_Famille
        End Get
        Set(ByVal value As String)
            _ART_Famille = value
        End Set
    End Property

    Private _ART_Marque As String = ""

    <XmlElementAttribute("ART_Marque")>
    Public Property ART_Marque() As String
        Get
            Return _ART_Marque
        End Get
        Set(ByVal value As String)
            _ART_Marque = value
        End Set
    End Property

    Private _ART_MargeB As Decimal = Nothing

    <XmlElementAttribute("ART_MargeB")>
    Public Property ART_MargeB() As Decimal
        Get
            Return _ART_MargeB
        End Get
        Set(ByVal value As Decimal)
            _ART_MargeB = value
        End Set
    End Property

    Private _ART_PrixUnitaireHTVA As Decimal = Nothing

    <XmlElementAttribute("ART_PrixUnitaireHTVA")>
    Public Property ART_PrixUnitaireHTVA() As Decimal
        Get
            Return _ART_PrixUnitaireHTVA
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixUnitaireHTVA = value
        End Set
    End Property

    Private _ART_TypePrixUnitaireHTVA As String = ""

    <XmlElementAttribute("ART_TypePrixUnitaireHTVA")>
    Public Property ART_TypePrixUnitaireHTVA() As String
        Get
            Return _ART_TypePrixUnitaireHTVA
        End Get
        Set(ByVal value As String)
            _ART_TypePrixUnitaireHTVA = value
        End Set
    End Property

    Private _ART_TVA As Decimal = Nothing

    <XmlElementAttribute("ART_TVA")>
    Public Property ART_TVA() As Decimal
        Get
            Return _ART_TVA
        End Get
        Set(ByVal value As Decimal)
            _ART_TVA = value
        End Set
    End Property

    Private _ART_Couleur As String = ""

    <XmlElementAttribute("ART_Couleur")>
    Public Property ART_Couleur() As String
        Get
            Return _ART_Couleur
        End Get
        Set(ByVal value As String)
            _ART_Couleur = value
        End Set
    End Property

    Private _ART_User As String = ""

    <XmlElementAttribute("ART_User")>
    Public Property ART_User() As String
        Get
            Return _ART_User
        End Get
        Set(ByVal value As String)
            _ART_User = value
        End Set
    End Property

    Private _ART_Station As String = ""

    <XmlElementAttribute("ART_Station")>
    Public Property ART_Station() As String
        Get
            Return _ART_Station
        End Get
        Set(ByVal value As String)
            _ART_Station = value
        End Set
    End Property

    Private _ART_QTEmin As Decimal = Nothing

    <XmlElementAttribute("ART_QTEmin")>
    Public Property ART_QTEmin() As Decimal
        Get
            Return _ART_QTEmin
        End Get
        Set(ByVal value As Decimal)
            _ART_QTEmin = value
        End Set
    End Property

    Private _ART_Fodec As Integer = 0

    <XmlElementAttribute("ART_Fodec")>
    Public Property ART_Fodec() As Integer
        Get
            Return _ART_Fodec
        End Get
        Set(ByVal value As Integer)
            _ART_Fodec = value
        End Set
    End Property

    Private _ART_DC As Integer = 0

    <XmlElementAttribute("ART_DC")>
    Public Property ART_DC() As Integer
        Get
            Return _ART_DC
        End Get
        Set(ByVal value As Integer)
            _ART_DC = value
        End Set
    End Property

    Private _ART_QTEmax As Decimal = Nothing

    <XmlElementAttribute("ART_QTEmax")>
    Public Property ART_QTEmax() As Decimal
        Get
            Return _ART_QTEmax
        End Get
        Set(ByVal value As Decimal)
            _ART_QTEmax = value
        End Set
    End Property

    Private _ART_TAILLE As String = ""

    <XmlElementAttribute("ART_TAILLE")>
    Public Property ART_TAILLE() As String
        Get
            Return _ART_TAILLE
        End Get
        Set(ByVal value As String)
            _ART_TAILLE = value
        End Set
    End Property

    Private _ART_QteDeclaree As Decimal = Nothing

    <XmlElementAttribute("ART_QteDeclaree")>
    Public Property ART_QteDeclaree() As Decimal
        Get
            Return _ART_QteDeclaree
        End Get
        Set(ByVal value As Decimal)
            _ART_QteDeclaree = value
        End Set
    End Property

    Private _ART_Prix_AchatFactReel As Decimal = Nothing

    <XmlElementAttribute("ART_Prix_AchatFactReel")>
    Public Property ART_Prix_AchatFactReel() As Decimal
        Get
            Return _ART_Prix_AchatFactReel
        End Get
        Set(ByVal value As Decimal)
            _ART_Prix_AchatFactReel = value
        End Set
    End Property

    Private _ART_Image As Byte() = Nothing

    <XmlElementAttribute("ART_Image")>
    Public Property ART_Image() As Byte()
        Get
            Return _ART_Image
        End Get
        Set(ByVal value As Byte())
            _ART_Image = value
        End Set
    End Property

    Private _ART_DateCr As DateTime = Nothing

    <XmlElementAttribute("ART_DateCr")>
    Public Property ART_DateCr() As DateTime
        Get
            Return _ART_DateCr
        End Get
        Set(ByVal value As DateTime)
            _ART_DateCr = value
        End Set
    End Property

    Private _ART_QteStock As Decimal = Nothing

    <XmlElementAttribute("ART_QteStock")>
    Public Property ART_QteStock() As Decimal
        Get
            Return _ART_QteStock
        End Get
        Set(ByVal value As Decimal)
            _ART_QteStock = value
        End Set
    End Property

    Private _ART_NumSerie As String = ""

    <XmlElementAttribute("ART_NumSerie")>
    Public Property ART_NumSerie() As String
        Get
            Return _ART_NumSerie
        End Get
        Set(ByVal value As String)
            _ART_NumSerie = value
        End Set
    End Property

    Private _ART_IsTaktile As Boolean = False

    <XmlElementAttribute("ART_IsTaktile")>
    Public Property ART_IsTaktile() As Boolean
        Get
            Return _ART_IsTaktile
        End Get
        Set(ByVal value As Boolean)
            _ART_IsTaktile = value
        End Set
    End Property

    Private _ART_PrixGros1 As Decimal = Nothing

    <XmlElementAttribute("ART_PrixGros1")>
    Public Property ART_PrixGros1() As Decimal
        Get
            Return _ART_PrixGros1
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixGros1 = value
        End Set
    End Property

    Private _ART_QtePrixGros1 As Decimal = Nothing

    <XmlElementAttribute("ART_QtePrixGros1")>
    Public Property ART_QtePrixGros1() As Decimal
        Get
            Return _ART_QtePrixGros1
        End Get
        Set(ByVal value As Decimal)
            _ART_QtePrixGros1 = value
        End Set
    End Property

    Private _ART_PrixGros2 As Decimal = Nothing

    <XmlElementAttribute("ART_PrixGros2")>
    Public Property ART_PrixGros2() As Decimal
        Get
            Return _ART_PrixGros2
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixGros2 = value
        End Set
    End Property

    Private _ART_QtePrixGros2 As Decimal = Nothing

    <XmlElementAttribute("ART_QtePrixGros2")>
    Public Property ART_QtePrixGros2() As Decimal
        Get
            Return _ART_QtePrixGros2
        End Get
        Set(ByVal value As Decimal)
            _ART_QtePrixGros2 = value
        End Set
    End Property

    Private _ART_PrixGros3 As Decimal = Nothing

    <XmlElementAttribute("ART_PrixGros3")>
    Public Property ART_PrixGros3() As Decimal
        Get
            Return _ART_PrixGros3
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixGros3 = value
        End Set
    End Property

    Private _ART_QteGros3 As Decimal = Nothing

    <XmlElementAttribute("ART_QteGros3")>
    Public Property ART_QteGros3() As Decimal
        Get
            Return _ART_QteGros3
        End Get
        Set(ByVal value As Decimal)
            _ART_QteGros3 = value
        End Set
    End Property

    Private _ART_CoulBN As String = ""

    <XmlElementAttribute("ART_CoulBN")>
    Public Property ART_CoulBN() As String
        Get
            Return _ART_CoulBN
        End Get
        Set(ByVal value As String)
            _ART_CoulBN = value
        End Set
    End Property

    Private _ART_PrixUnitaireHTRes As Decimal = Nothing

    <XmlElementAttribute("ART_PrixUnitaireHTRes")>
    Public Property ART_PrixUnitaireHTRes() As Decimal
        Get
            Return _ART_PrixUnitaireHTRes
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixUnitaireHTRes = value
        End Set
    End Property

    Private _ART_PrixUnitaireHTGlobale As Decimal = Nothing

    <XmlElementAttribute("ART_PrixUnitaireHTGlobale")>
    Public Property ART_PrixUnitaireHTGlobale() As Decimal
        Get
            Return _ART_PrixUnitaireHTGlobale
        End Get
        Set(ByVal value As Decimal)
            _ART_PrixUnitaireHTGlobale = value
        End Set
    End Property

    Private _ART_export As Boolean = False

    <XmlElementAttribute("ART_export")>
    Public Property ART_export() As Boolean
        Get
            Return _ART_export
        End Get
        Set(ByVal value As Boolean)
            _ART_export = value
        End Set
    End Property

    Private _ART_ddm As DateTime = Nothing

    <XmlElementAttribute("ART_ddm")>
    Public Property ART_ddm() As DateTime
        Get
            Return _ART_ddm
        End Get
        Set(ByVal value As DateTime)
            _ART_ddm = value
        End Set
    End Property

    Private _PrixSolde As Decimal = Nothing

    <XmlElementAttribute("PrixSolde")>
    Public Property PrixSolde() As Decimal
        Get
            Return _PrixSolde
        End Get
        Set(ByVal value As Decimal)
            _PrixSolde = value
        End Set
    End Property

    Private _TauxSolde As Decimal = Nothing

    <XmlElementAttribute("TauxSolde")>
    Public Property TauxSolde() As Decimal
        Get
            Return _TauxSolde
        End Get
        Set(ByVal value As Decimal)
            _TauxSolde = value
        End Set
    End Property

    Private _ART_Equivalence As String = ""

    <XmlElementAttribute("ART_Equivalence")>
    Public Property ART_Equivalence() As String
        Get
            Return _ART_Equivalence
        End Get
        Set(ByVal value As String)
            _ART_Equivalence = value
        End Set
    End Property

    Private _Regularisation As String = ""

    <XmlElementAttribute("Regularisation")>
    Public Property Regularisation() As String
        Get
            Return _Regularisation
        End Get
        Set(ByVal value As String)
            _Regularisation = value
        End Set
    End Property

    Private _ART_Cout_charge As Decimal = Nothing

    <XmlElementAttribute("ART_Cout_charge")>
    Public Property ART_Cout_charge() As Decimal
        Get
            Return _ART_Cout_charge
        End Get
        Set(ByVal value As Decimal)
            _ART_Cout_charge = value
        End Set
    End Property

    Private _ART_codeSerie As String = ""

    <XmlElementAttribute("ART_codeSerie")>
    Public Property ART_codeSerie() As String
        Get
            Return _ART_codeSerie
        End Get
        Set(ByVal value As String)
            _ART_codeSerie = value
        End Set
    End Property

    Private _CRPonderer As Decimal = Nothing

    <XmlElementAttribute("CRPonderer")>
    Public Property CRPonderer() As Decimal
        Get
            Return _CRPonderer
        End Get
        Set(ByVal value As Decimal)
            _CRPonderer = value
        End Set
    End Property

    Private _QTE_Restante As Decimal = Nothing

    <XmlElementAttribute("QTE_Restante")>
    Public Property QTE_Restante() As Decimal
        Get
            Return _QTE_Restante
        End Get
        Set(ByVal value As Decimal)
            _QTE_Restante = value
        End Set
    End Property

    Private _Coeff_charge As Decimal = Nothing

    <XmlElementAttribute("Coeff_charge")>
    Public Property Coeff_charge() As Decimal
        Get
            Return _Coeff_charge
        End Get
        Set(ByVal value As Decimal)
            _Coeff_charge = value
        End Set
    End Property

    Private _Charge_tot_coeff As Decimal = Nothing

    <XmlElementAttribute("Charge_tot_coeff")>
    Public Property Charge_tot_coeff() As Decimal
        Get
            Return _Charge_tot_coeff
        End Get
        Set(ByVal value As Decimal)
            _Charge_tot_coeff = value
        End Set
    End Property

    Private _Type_Produit As String = ""

    <XmlElementAttribute("Type_Produit")>
    Public Property Type_Produit() As String
        Get
            Return _Type_Produit
        End Get
        Set(ByVal value As String)
            _Type_Produit = value
        End Set
    End Property

    Private _Type_service As String = ""

    <XmlElementAttribute("Type_service")>
    Public Property Type_service() As String
        Get
            Return _Type_service
        End Get
        Set(ByVal value As String)
            _Type_service = value
        End Set
    End Property

    Private _is_bloquer As Boolean = False

    <XmlElementAttribute("is_bloquer")>
    Public Property is_bloquer() As Boolean
        Get
            Return _is_bloquer
        End Get
        Set(ByVal value As Boolean)
            _is_bloquer = value
        End Set
    End Property

    Private _ART_CodeFrs As String = ""

    <XmlElementAttribute("ART_CodeFrs")>
    Public Property ART_CodeFrs() As String
        Get
            Return _ART_CodeFrs
        End Get
        Set(ByVal value As String)
            _ART_CodeFrs = value
        End Set
    End Property

    Private _ART_Fournisseur As String = ""

    <XmlElementAttribute("ART_Fournisseur")>
    Public Property ART_Fournisseur() As String
        Get
            Return _ART_Fournisseur
        End Get
        Set(ByVal value As String)
            _ART_Fournisseur = value
        End Set
    End Property

    Private _ART_Poid_Qte As String = ""

    <XmlElementAttribute("ART_Poid_Qte")>
    Public Property ART_Poid_Qte() As String
        Get
            Return _ART_Poid_Qte
        End Get
        Set(ByVal value As String)
            _ART_Poid_Qte = value
        End Set
    End Property

    Private _Emp_Code As String = ""

    <XmlElementAttribute("Emp_Code")>
    Public Property Emp_Code() As String
        Get
            Return _Emp_Code
        End Get
        Set(ByVal value As String)
            _Emp_Code = value
        End Set
    End Property

    Private _Touche_Balance As String = ""

    <XmlElementAttribute("Touche_Balance")>
    Public Property Touche_Balance() As String
        Get
            Return _Touche_Balance
        End Get
        Set(ByVal value As String)
            _Touche_Balance = value
        End Set
    End Property

    Private _Type_Balance As String = ""

    <XmlElementAttribute("Type_Balance")>
    Public Property Type_Balance() As String
        Get
            Return _Type_Balance
        End Get
        Set(ByVal value As String)
            _Type_Balance = value
        End Set
    End Property

    Private _Anc_cout As Decimal = Nothing

    <XmlElementAttribute("Anc_cout")>
    Public Property Anc_cout() As Decimal
        Get
            Return _Anc_cout
        End Get
        Set(ByVal value As Decimal)
            _Anc_cout = value
        End Set
    End Property

    Private _Art_Session As Boolean = False

    <XmlElementAttribute("Art_Session")>
    Public Property Art_Session() As Boolean
        Get
            Return _Art_Session
        End Get
        Set(ByVal value As Boolean)
            _Art_Session = value
        End Set
    End Property

    Private _Art_Prom As Boolean = False

    <XmlElementAttribute("Art_Prom")>
    Public Property Art_Prom() As Boolean
        Get
            Return _Art_Prom
        End Get
        Set(ByVal value As Boolean)
            _Art_Prom = value
        End Set
    End Property

    Private _Art_NbProm As Decimal = Nothing

    <XmlElementAttribute("Art_NbProm")>
    Public Property Art_NbProm() As Decimal
        Get
            Return _Art_NbProm
        End Get
        Set(ByVal value As Decimal)
            _Art_NbProm = value
        End Set
    End Property

    Private _Art_TauxProm As Decimal = Nothing

    <XmlElementAttribute("Art_TauxProm")>
    Public Property Art_TauxProm() As Decimal
        Get
            Return _Art_TauxProm
        End Get
        Set(ByVal value As Decimal)
            _Art_TauxProm = value
        End Set
    End Property

    Private _Remise_Fidelite As Decimal = Nothing

    <XmlElementAttribute("Remise_Fidelite")>
    Public Property Remise_Fidelite() As Decimal
        Get
            Return _Remise_Fidelite
        End Get
        Set(ByVal value As Decimal)
            _Remise_Fidelite = value
        End Set
    End Property

    Private _photo_Path As String = ""

    <XmlElementAttribute("photo_Path")>
    Public Property photo_Path() As String
        Get
            Return _photo_Path
        End Get
        Set(ByVal value As String)
            _photo_Path = value
        End Set
    End Property

    Private _ddm As DateTime = Nothing

    <XmlElementAttribute("ddm")>
    Public Property ddm() As DateTime
        Get
            Return _ddm
        End Get
        Set(ByVal value As DateTime)
            _ddm = value
        End Set
    End Property

    Private _export As Boolean = False

    <XmlElementAttribute("export")>
    Public Property export() As Boolean
        Get
            Return _export
        End Get
        Set(ByVal value As Boolean)
            _export = value
        End Set
    End Property

    Private _Ecrivain As String = ""

    <XmlElementAttribute("Ecrivain")>
    Public Property Ecrivain() As String
        Get
            Return _Ecrivain
        End Get
        Set(ByVal value As String)
            _Ecrivain = value
        End Set
    End Property

    Private _Collection As String = ""

    <XmlElementAttribute("Collection")>
    Public Property Collection() As String
        Get
            Return _Collection
        End Get
        Set(ByVal value As String)
            _Collection = value
        End Set
    End Property

    Private _is_Calcul_inverse As Boolean = False

    <XmlElementAttribute("is_Calcul_inverse")>
    Public Property is_Calcul_inverse() As Boolean
        Get
            Return _is_Calcul_inverse
        End Get
        Set(ByVal value As Boolean)
            _is_Calcul_inverse = value
        End Set
    End Property

    Private _is_Tacktil As Boolean = False

    <XmlElementAttribute("is_Tacktil")>
    Public Property is_Tacktil() As Boolean
        Get
            Return _is_Tacktil
        End Get
        Set(ByVal value As Boolean)
            _is_Tacktil = value
        End Set
    End Property

    Private _is_Peremption As Boolean = False

    <XmlElementAttribute("is_Peremption")>
    Public Property is_Peremption() As Boolean
        Get
            Return _is_Peremption
        End Get
        Set(ByVal value As Boolean)
            _is_Peremption = value
        End Set
    End Property

    Private _Nbr_Jour_Peremption As Integer = 0

    <XmlElementAttribute("Nbr_Jour_Peremption")>
    Public Property Nbr_Jour_Peremption() As Integer
        Get
            Return _Nbr_Jour_Peremption
        End Get
        Set(ByVal value As Integer)
            _Nbr_Jour_Peremption = value
        End Set
    End Property

    Private _is_Promo_Qte_Prix As Boolean = False

    <XmlElementAttribute("is_Promo_Qte_Prix")>
    Public Property is_Promo_Qte_Prix() As Boolean
        Get
            Return _is_Promo_Qte_Prix
        End Get
        Set(ByVal value As Boolean)
            _is_Promo_Qte_Prix = value
        End Set
    End Property

    Private _ART_CodeFrs2 As String = ""

    <XmlElementAttribute("ART_CodeFrs2")>
    Public Property ART_CodeFrs2() As String
        Get
            Return _ART_CodeFrs2
        End Get
        Set(ByVal value As String)
            _ART_CodeFrs2 = value
        End Set
    End Property

    Private _ART_ChezFrs2 As String = ""

    <XmlElementAttribute("ART_ChezFrs2")>
    Public Property ART_ChezFrs2() As String
        Get
            Return _ART_ChezFrs2
        End Get
        Set(ByVal value As String)
            _ART_ChezFrs2 = value
        End Set
    End Property

    Private _ART_CodeFrs3 As String = ""

    <XmlElementAttribute("ART_CodeFrs3")>
    Public Property ART_CodeFrs3() As String
        Get
            Return _ART_CodeFrs3
        End Get
        Set(ByVal value As String)
            _ART_CodeFrs3 = value
        End Set
    End Property

    Private _ART_ChezFrs3 As String = ""

    <XmlElementAttribute("ART_ChezFrs3")>
    Public Property ART_ChezFrs3() As String
        Get
            Return _ART_ChezFrs3
        End Get
        Set(ByVal value As String)
            _ART_ChezFrs3 = value
        End Set
    End Property

    Private _is_AlertStock As Boolean = False

    <XmlElementAttribute("is_AlertStock")>
    Public Property is_AlertStock() As Boolean
        Get
            Return _is_AlertStock
        End Get
        Set(ByVal value As Boolean)
            _is_AlertStock = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Partial Public Class ArticleDAO
    Inherits LUNA.LunaBaseClassDAO(Of Article)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New ArticleDAO
    Public Shared Function getInstance() As ArticleDAO
        If IsNothing(Utilisateur) Then
            Return New ArticleDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As String) As Article
        Dim cls As New Article

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Article where ART_Code = " & Ap(Id)
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.ART_Code = myReader("ART_Code")
                If Not myReader("ART_Designation") Is DBNull.Value Then
                    cls.ART_Designation = myReader("ART_Designation")
                End If
                If Not myReader("ART_PrixUnitaireHT") Is DBNull.Value Then
                    cls.ART_PrixUnitaireHT = myReader("ART_PrixUnitaireHT")
                End If
                If Not myReader("ART_CodeBar") Is DBNull.Value Then
                    cls.ART_CodeBar = myReader("ART_CodeBar")
                End If
                If Not myReader("ART_DesgCourte") Is DBNull.Value Then
                    cls.ART_DesgCourte = myReader("ART_DesgCourte")
                End If
                If Not myReader("ART_Famille") Is DBNull.Value Then
                    cls.ART_Famille = myReader("ART_Famille")
                End If
                If Not myReader("ART_Marque") Is DBNull.Value Then
                    cls.ART_Marque = myReader("ART_Marque")
                End If
                If Not myReader("ART_MargeB") Is DBNull.Value Then
                    cls.ART_MargeB = myReader("ART_MargeB")
                End If
                If Not myReader("ART_PrixUnitaireHTVA") Is DBNull.Value Then
                    cls.ART_PrixUnitaireHTVA = myReader("ART_PrixUnitaireHTVA")
                End If
                If Not myReader("ART_TypePrixUnitaireHTVA") Is DBNull.Value Then
                    cls.ART_TypePrixUnitaireHTVA = myReader("ART_TypePrixUnitaireHTVA")
                End If
                If Not myReader("ART_TVA") Is DBNull.Value Then
                    cls.ART_TVA = myReader("ART_TVA")
                End If
                If Not myReader("ART_Couleur") Is DBNull.Value Then
                    cls.ART_Couleur = myReader("ART_Couleur")
                End If
                If Not myReader("ART_User") Is DBNull.Value Then
                    cls.ART_User = myReader("ART_User")
                End If
                If Not myReader("ART_Station") Is DBNull.Value Then
                    cls.ART_Station = myReader("ART_Station")
                End If
                If Not myReader("ART_QTEmin") Is DBNull.Value Then
                    cls.ART_QTEmin = myReader("ART_QTEmin")
                End If
                If Not myReader("ART_Fodec") Is DBNull.Value Then
                    cls.ART_Fodec = myReader("ART_Fodec")
                End If
                If Not myReader("ART_DC") Is DBNull.Value Then
                    cls.ART_DC = myReader("ART_DC")
                End If
                If Not myReader("ART_QTEmax") Is DBNull.Value Then
                    cls.ART_QTEmax = myReader("ART_QTEmax")
                End If
                If Not myReader("ART_TAILLE") Is DBNull.Value Then
                    cls.ART_TAILLE = myReader("ART_TAILLE")
                End If
                If Not myReader("ART_QteDeclaree") Is DBNull.Value Then
                    cls.ART_QteDeclaree = myReader("ART_QteDeclaree")
                End If
                If Not myReader("ART_Prix_AchatFactReel") Is DBNull.Value Then
                    cls.ART_Prix_AchatFactReel = myReader("ART_Prix_AchatFactReel")
                End If
                If Not myReader("ART_Image") Is DBNull.Value Then
                    cls.ART_Image = myReader("ART_Image")
                End If
                If Not myReader("ART_DateCr") Is DBNull.Value Then
                    cls.ART_DateCr = myReader("ART_DateCr")
                End If
                If Not myReader("ART_QteStock") Is DBNull.Value Then
                    cls.ART_QteStock = myReader("ART_QteStock")
                End If
                If Not myReader("ART_NumSerie") Is DBNull.Value Then
                    cls.ART_NumSerie = myReader("ART_NumSerie")
                End If
                If Not myReader("ART_IsTaktile") Is DBNull.Value Then
                    cls.ART_IsTaktile = myReader("ART_IsTaktile")
                End If
                If Not myReader("ART_PrixGros1") Is DBNull.Value Then
                    cls.ART_PrixGros1 = myReader("ART_PrixGros1")
                End If
                If Not myReader("ART_QtePrixGros1") Is DBNull.Value Then
                    cls.ART_QtePrixGros1 = myReader("ART_QtePrixGros1")
                End If
                If Not myReader("ART_PrixGros2") Is DBNull.Value Then
                    cls.ART_PrixGros2 = myReader("ART_PrixGros2")
                End If
                If Not myReader("ART_QtePrixGros2") Is DBNull.Value Then
                    cls.ART_QtePrixGros2 = myReader("ART_QtePrixGros2")
                End If
                If Not myReader("ART_PrixGros3") Is DBNull.Value Then
                    cls.ART_PrixGros3 = myReader("ART_PrixGros3")
                End If
                If Not myReader("ART_QteGros3") Is DBNull.Value Then
                    cls.ART_QteGros3 = myReader("ART_QteGros3")
                End If
                If Not myReader("ART_CoulBN") Is DBNull.Value Then
                    cls.ART_CoulBN = myReader("ART_CoulBN")
                End If
                If Not myReader("ART_PrixUnitaireHTRes") Is DBNull.Value Then
                    cls.ART_PrixUnitaireHTRes = myReader("ART_PrixUnitaireHTRes")
                End If
                If Not myReader("ART_PrixUnitaireHTGlobale") Is DBNull.Value Then
                    cls.ART_PrixUnitaireHTGlobale = myReader("ART_PrixUnitaireHTGlobale")
                End If
                If Not myReader("ART_export") Is DBNull.Value Then
                    cls.ART_export = myReader("ART_export")
                End If
                If Not myReader("ART_ddm") Is DBNull.Value Then
                    cls.ART_ddm = myReader("ART_ddm")
                End If
                If Not myReader("PrixSolde") Is DBNull.Value Then
                    cls.PrixSolde = myReader("PrixSolde")
                End If
                If Not myReader("TauxSolde") Is DBNull.Value Then
                    cls.TauxSolde = myReader("TauxSolde")
                End If
                If Not myReader("ART_Equivalence") Is DBNull.Value Then
                    cls.ART_Equivalence = myReader("ART_Equivalence")
                End If
                If Not myReader("Regularisation") Is DBNull.Value Then
                    cls.Regularisation = myReader("Regularisation")
                End If
                If Not myReader("ART_Cout_charge") Is DBNull.Value Then
                    cls.ART_Cout_charge = myReader("ART_Cout_charge")
                End If
                If Not myReader("ART_codeSerie") Is DBNull.Value Then
                    cls.ART_codeSerie = myReader("ART_codeSerie")
                End If
                If Not myReader("CRPonderer") Is DBNull.Value Then
                    cls.CRPonderer = myReader("CRPonderer")
                End If
                If Not myReader("QTE_Restante") Is DBNull.Value Then
                    cls.QTE_Restante = myReader("QTE_Restante")
                End If
                If Not myReader("Coeff_charge") Is DBNull.Value Then
                    cls.Coeff_charge = myReader("Coeff_charge")
                End If
                If Not myReader("Charge_tot_coeff") Is DBNull.Value Then
                    cls.Charge_tot_coeff = myReader("Charge_tot_coeff")
                End If
                If Not myReader("Type_Produit") Is DBNull.Value Then
                    cls.Type_Produit = myReader("Type_Produit")
                End If
                If Not myReader("Type_service") Is DBNull.Value Then
                    cls.Type_service = myReader("Type_service")
                End If
                If Not myReader("is_bloquer") Is DBNull.Value Then
                    cls.is_bloquer = myReader("is_bloquer")
                End If
                If Not myReader("ART_CodeFrs") Is DBNull.Value Then
                    cls.ART_CodeFrs = myReader("ART_CodeFrs")
                End If
                If Not myReader("ART_Fournisseur") Is DBNull.Value Then
                    cls.ART_Fournisseur = myReader("ART_Fournisseur")
                End If
                If Not myReader("ART_Poid_Qte") Is DBNull.Value Then
                    cls.ART_Poid_Qte = myReader("ART_Poid_Qte")
                End If
                If Not myReader("Emp_Code") Is DBNull.Value Then
                    cls.Emp_Code = myReader("Emp_Code")
                End If
                If Not myReader("Touche_Balance") Is DBNull.Value Then
                    cls.Touche_Balance = myReader("Touche_Balance")
                End If
                If Not myReader("Type_Balance") Is DBNull.Value Then
                    cls.Type_Balance = myReader("Type_Balance")
                End If
                If Not myReader("Anc_cout") Is DBNull.Value Then
                    cls.Anc_cout = myReader("Anc_cout")
                End If
                If Not myReader("Art_Session") Is DBNull.Value Then
                    cls.Art_Session = myReader("Art_Session")
                End If
                If Not myReader("Art_Prom") Is DBNull.Value Then
                    cls.Art_Prom = myReader("Art_Prom")
                End If
                If Not myReader("Art_NbProm") Is DBNull.Value Then
                    cls.Art_NbProm = myReader("Art_NbProm")
                End If
                If Not myReader("Art_TauxProm") Is DBNull.Value Then
                    cls.Art_TauxProm = myReader("Art_TauxProm")
                End If
                If Not myReader("Remise_Fidelite") Is DBNull.Value Then
                    cls.Remise_Fidelite = myReader("Remise_Fidelite")
                End If
                If Not myReader("photo_Path") Is DBNull.Value Then
                    cls.photo_Path = myReader("photo_Path")
                End If
                If Not myReader("ddm") Is DBNull.Value Then
                    cls.ddm = myReader("ddm")
                End If
                If Not myReader("export") Is DBNull.Value Then
                    cls.export = myReader("export")
                End If
                If Not myReader("Ecrivain") Is DBNull.Value Then
                    cls.Ecrivain = myReader("Ecrivain")
                End If
                If Not myReader("Collection") Is DBNull.Value Then
                    cls.Collection = myReader("Collection")
                End If
                If Not myReader("is_Calcul_inverse") Is DBNull.Value Then
                    cls.is_Calcul_inverse = myReader("is_Calcul_inverse")
                End If
                If Not myReader("is_Tacktil") Is DBNull.Value Then
                    cls.is_Tacktil = myReader("is_Tacktil")
                End If
                If Not myReader("is_Peremption") Is DBNull.Value Then
                    cls.is_Peremption = myReader("is_Peremption")
                End If
                If Not myReader("Nbr_Jour_Peremption") Is DBNull.Value Then
                    cls.Nbr_Jour_Peremption = myReader("Nbr_Jour_Peremption")
                End If
                If Not myReader("is_Promo_Qte_Prix") Is DBNull.Value Then
                    cls.is_Promo_Qte_Prix = myReader("is_Promo_Qte_Prix")
                End If
                If Not myReader("ART_CodeFrs2") Is DBNull.Value Then
                    cls.ART_CodeFrs2 = myReader("ART_CodeFrs2")
                End If
                If Not myReader("ART_ChezFrs2") Is DBNull.Value Then
                    cls.ART_ChezFrs2 = myReader("ART_ChezFrs2")
                End If
                If Not myReader("ART_CodeFrs3") Is DBNull.Value Then
                    cls.ART_CodeFrs3 = myReader("ART_CodeFrs3")
                End If
                If Not myReader("ART_ChezFrs3") Is DBNull.Value Then
                    cls.ART_ChezFrs3 = myReader("ART_ChezFrs3")
                End If
                If Not myReader("is_AlertStock") Is DBNull.Value Then
                    cls.is_AlertStock = myReader("is_AlertStock")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Article) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Article("
            sql &= "ART_Code,"
            sql &= "ART_Designation,"
            sql &= "ART_PrixUnitaireHT,"
            sql &= "ART_CodeBar,"
            sql &= "ART_DesgCourte,"
            sql &= "ART_Famille,"
            sql &= "ART_Marque,"
            sql &= "ART_MargeB,"
            sql &= "ART_PrixUnitaireHTVA,"
            sql &= "ART_TypePrixUnitaireHTVA,"
            sql &= "ART_TVA,"
            sql &= "ART_Couleur,"
            sql &= "ART_User,"
            sql &= "ART_Station,"
            sql &= "ART_QTEmin,"
            sql &= "ART_Fodec,"
            sql &= "ART_DC,"
            sql &= "ART_QTEmax,"
            sql &= "ART_TAILLE,"
            sql &= "ART_QteDeclaree,"
            sql &= "ART_Prix_AchatFactReel,"
            sql &= "ART_Image,"
            sql &= "ART_DateCr,"
            sql &= "ART_QteStock,"
            sql &= "ART_NumSerie,"
            sql &= "ART_IsTaktile,"
            sql &= "ART_PrixGros1,"
            sql &= "ART_QtePrixGros1,"
            sql &= "ART_PrixGros2,"
            sql &= "ART_QtePrixGros2,"
            sql &= "ART_PrixGros3,"
            sql &= "ART_QteGros3,"
            sql &= "ART_CoulBN,"
            sql &= "ART_PrixUnitaireHTRes,"
            sql &= "ART_PrixUnitaireHTGlobale,"
            sql &= "ART_export,"
            sql &= "ART_ddm,"
            sql &= "PrixSolde,"
            sql &= "TauxSolde,"
            sql &= "ART_Equivalence,"
            sql &= "Regularisation,"
            sql &= "ART_Cout_charge,"
            sql &= "ART_codeSerie,"
            sql &= "CRPonderer,"
            sql &= "QTE_Restante,"
            sql &= "Coeff_charge,"
            sql &= "Charge_tot_coeff,"
            sql &= "Type_Produit,"
            sql &= "Type_service,"
            sql &= "is_bloquer,"
            sql &= "ART_CodeFrs,"
            sql &= "ART_Fournisseur,"
            sql &= "ART_Poid_Qte,"
            sql &= "Emp_Code,"
            sql &= "Touche_Balance,"
            sql &= "Type_Balance,"
            sql &= "Anc_cout,"
            sql &= "Art_Session,"
            sql &= "Art_Prom,"
            sql &= "Art_NbProm,"
            sql &= "Art_TauxProm,"
            sql &= "Remise_Fidelite,"
            sql &= "photo_Path,"
            sql &= "ddm,"
            sql &= "export,"
            sql &= "Ecrivain,"
            sql &= "Collection,"
            sql &= "is_Calcul_inverse,"
            sql &= "is_Tacktil,"
            sql &= "is_Peremption,"
            sql &= "Nbr_Jour_Peremption,"
            sql &= "is_Promo_Qte_Prix,"
            sql &= "ART_CodeFrs2,"
            sql &= "ART_ChezFrs2,"
            sql &= "ART_CodeFrs3,"
            sql &= "ART_ChezFrs3,"
            sql &= "is_AlertStock"
            sql &= ") VALUES ("
            sql &= Ap(cls.ART_Code) & ","
            sql &= Ap(cls.ART_Designation) & ","
            sql &= Ap(cls.ART_PrixUnitaireHT) & ","
            sql &= Ap(cls.ART_CodeBar) & ","
            sql &= Ap(cls.ART_DesgCourte) & ","
            sql &= Ap(cls.ART_Famille) & ","
            sql &= Ap(cls.ART_Marque) & ","
            sql &= Ap(cls.ART_MargeB) & ","
            sql &= Ap(cls.ART_PrixUnitaireHTVA) & ","
            sql &= Ap(cls.ART_TypePrixUnitaireHTVA) & ","
            sql &= Ap(cls.ART_TVA) & ","
            sql &= Ap(cls.ART_Couleur) & ","
            sql &= Ap(cls.ART_User) & ","
            sql &= Ap(cls.ART_Station) & ","
            sql &= Ap(cls.ART_QTEmin) & ","
            sql &= Ap(cls.ART_Fodec) & ","
            sql &= Ap(cls.ART_DC) & ","
            sql &= Ap(cls.ART_QTEmax) & ","
            sql &= Ap(cls.ART_TAILLE) & ","
            sql &= Ap(cls.ART_QteDeclaree) & ","
            sql &= Ap(cls.ART_Prix_AchatFactReel) & ","
            sql &= Ap(cls.ART_Image) & ","
            sql &= Ap(cls.ART_DateCr) & ","
            sql &= Ap(cls.ART_QteStock) & ","
            sql &= Ap(cls.ART_NumSerie) & ","
            sql &= IIf(cls.ART_IsTaktile, -1, 0) & ","
            sql &= Ap(cls.ART_PrixGros1) & ","
            sql &= Ap(cls.ART_QtePrixGros1) & ","
            sql &= Ap(cls.ART_PrixGros2) & ","
            sql &= Ap(cls.ART_QtePrixGros2) & ","
            sql &= Ap(cls.ART_PrixGros3) & ","
            sql &= Ap(cls.ART_QteGros3) & ","
            sql &= Ap(cls.ART_CoulBN) & ","
            sql &= Ap(cls.ART_PrixUnitaireHTRes) & ","
            sql &= Ap(cls.ART_PrixUnitaireHTGlobale) & ","
            sql &= IIf(cls.ART_export, -1, 0) & ","
            sql &= Ap(cls.ART_ddm) & ","
            sql &= Ap(cls.PrixSolde) & ","
            sql &= Ap(cls.TauxSolde) & ","
            sql &= Ap(cls.ART_Equivalence) & ","
            sql &= Ap(cls.Regularisation) & ","
            sql &= Ap(cls.ART_Cout_charge) & ","
            sql &= Ap(cls.ART_codeSerie) & ","
            sql &= Ap(cls.CRPonderer) & ","
            sql &= Ap(cls.QTE_Restante) & ","
            sql &= Ap(cls.Coeff_charge) & ","
            sql &= Ap(cls.Charge_tot_coeff) & ","
            sql &= Ap(cls.Type_Produit) & ","
            sql &= Ap(cls.Type_service) & ","
            sql &= IIf(cls.is_bloquer, -1, 0) & ","
            sql &= Ap(cls.ART_CodeFrs) & ","
            sql &= Ap(cls.ART_Fournisseur) & ","
            sql &= Ap(cls.ART_Poid_Qte) & ","
            sql &= Ap(cls.Emp_Code) & ","
            sql &= Ap(cls.Touche_Balance) & ","
            sql &= Ap(cls.Type_Balance) & ","
            sql &= Ap(cls.Anc_cout) & ","
            sql &= IIf(cls.Art_Session, -1, 0) & ","
            sql &= IIf(cls.Art_Prom, -1, 0) & ","
            sql &= Ap(cls.Art_NbProm) & ","
            sql &= Ap(cls.Art_TauxProm) & ","
            sql &= Ap(cls.Remise_Fidelite) & ","
            sql &= Ap(cls.photo_Path) & ","
            sql &= Ap(cls.ddm) & ","
            sql &= IIf(cls.export, -1, 0) & ","
            sql &= Ap(cls.Ecrivain) & ","
            sql &= Ap(cls.Collection) & ","
            sql &= IIf(cls.is_Calcul_inverse, -1, 0) & ","
            sql &= IIf(cls.is_Tacktil, -1, 0) & ","
            sql &= IIf(cls.is_Peremption, -1, 0) & ","
            sql &= Ap(cls.Nbr_Jour_Peremption) & ","
            sql &= IIf(cls.is_Promo_Qte_Prix, -1, 0) & ","
            sql &= Ap(cls.ART_CodeFrs2) & ","
            sql &= Ap(cls.ART_ChezFrs2) & ","
            sql &= Ap(cls.ART_CodeFrs3) & ","
            sql &= Ap(cls.ART_ChezFrs3) & ","
            sql &= IIf(cls.is_AlertStock, -1, 0)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Article) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Article SET "
            sql &= "ART_Designation = " & Ap(cls.ART_Designation) & ","
            sql &= "ART_PrixUnitaireHT = " & Ap(cls.ART_PrixUnitaireHT) & ","
            sql &= "ART_CodeBar = " & Ap(cls.ART_CodeBar) & ","
            sql &= "ART_DesgCourte = " & Ap(cls.ART_DesgCourte) & ","
            sql &= "ART_Famille = " & Ap(cls.ART_Famille) & ","
            sql &= "ART_Marque = " & Ap(cls.ART_Marque) & ","
            sql &= "ART_MargeB = " & Ap(cls.ART_MargeB) & ","
            sql &= "ART_PrixUnitaireHTVA = " & Ap(cls.ART_PrixUnitaireHTVA) & ","
            sql &= "ART_TypePrixUnitaireHTVA = " & Ap(cls.ART_TypePrixUnitaireHTVA) & ","
            sql &= "ART_TVA = " & Ap(cls.ART_TVA) & ","
            sql &= "ART_Couleur = " & Ap(cls.ART_Couleur) & ","
            sql &= "ART_User = " & Ap(cls.ART_User) & ","
            sql &= "ART_Station = " & Ap(cls.ART_Station) & ","
            sql &= "ART_QTEmin = " & Ap(cls.ART_QTEmin) & ","
            sql &= "ART_Fodec = " & Ap(cls.ART_Fodec) & ","
            sql &= "ART_DC = " & Ap(cls.ART_DC) & ","
            sql &= "ART_QTEmax = " & Ap(cls.ART_QTEmax) & ","
            sql &= "ART_TAILLE = " & Ap(cls.ART_TAILLE) & ","
            sql &= "ART_QteDeclaree = " & Ap(cls.ART_QteDeclaree) & ","
            sql &= "ART_Prix_AchatFactReel = " & Ap(cls.ART_Prix_AchatFactReel) & ","
            sql &= "ART_Image = " & Ap(cls.ART_Image) & ","
            sql &= "ART_DateCr = " & Ap(cls.ART_DateCr) & ","
            sql &= "ART_QteStock = " & Ap(cls.ART_QteStock) & ","
            sql &= "ART_NumSerie = " & Ap(cls.ART_NumSerie) & ","
            sql &= "ART_IsTaktile = " & IIf(cls.ART_IsTaktile, "'true'", "'False'") & ","
            sql &= "ART_PrixGros1 = " & Ap(cls.ART_PrixGros1) & ","
            sql &= "ART_QtePrixGros1 = " & Ap(cls.ART_QtePrixGros1) & ","
            sql &= "ART_PrixGros2 = " & Ap(cls.ART_PrixGros2) & ","
            sql &= "ART_QtePrixGros2 = " & Ap(cls.ART_QtePrixGros2) & ","
            sql &= "ART_PrixGros3 = " & Ap(cls.ART_PrixGros3) & ","
            sql &= "ART_QteGros3 = " & Ap(cls.ART_QteGros3) & ","
            sql &= "ART_CoulBN = " & Ap(cls.ART_CoulBN) & ","
            sql &= "ART_PrixUnitaireHTRes = " & Ap(cls.ART_PrixUnitaireHTRes) & ","
            sql &= "ART_PrixUnitaireHTGlobale = " & Ap(cls.ART_PrixUnitaireHTGlobale) & ","
            sql &= "ART_export = " & IIf(cls.ART_export, "'true'", "'False'") & ","
            sql &= "ART_ddm = " & Ap(cls.ART_ddm) & ","
            sql &= "PrixSolde = " & Ap(cls.PrixSolde) & ","
            sql &= "TauxSolde = " & Ap(cls.TauxSolde) & ","
            sql &= "ART_Equivalence = " & Ap(cls.ART_Equivalence) & ","
            sql &= "Regularisation = " & Ap(cls.Regularisation) & ","
            sql &= "ART_Cout_charge = " & Ap(cls.ART_Cout_charge) & ","
            sql &= "ART_codeSerie = " & Ap(cls.ART_codeSerie) & ","
            sql &= "CRPonderer = " & Ap(cls.CRPonderer) & ","
            sql &= "QTE_Restante = " & Ap(cls.QTE_Restante) & ","
            sql &= "Coeff_charge = " & Ap(cls.Coeff_charge) & ","
            sql &= "Charge_tot_coeff = " & Ap(cls.Charge_tot_coeff) & ","
            sql &= "Type_Produit = " & Ap(cls.Type_Produit) & ","
            sql &= "Type_service = " & Ap(cls.Type_service) & ","
            sql &= "is_bloquer = " & IIf(cls.is_bloquer, "'true'", "'False'") & ","
            sql &= "ART_CodeFrs = " & Ap(cls.ART_CodeFrs) & ","
            sql &= "ART_Fournisseur = " & Ap(cls.ART_Fournisseur) & ","
            sql &= "ART_Poid_Qte = " & Ap(cls.ART_Poid_Qte) & ","
            sql &= "Emp_Code = " & Ap(cls.Emp_Code) & ","
            sql &= "Touche_Balance = " & Ap(cls.Touche_Balance) & ","
            sql &= "Type_Balance = " & Ap(cls.Type_Balance) & ","
            sql &= "Anc_cout = " & Ap(cls.Anc_cout) & ","
            sql &= "Art_Session = " & IIf(cls.Art_Session, "'true'", "'False'") & ","
            sql &= "Art_Prom = " & IIf(cls.Art_Prom, "'true'", "'False'") & ","
            sql &= "Art_NbProm = " & Ap(cls.Art_NbProm) & ","
            sql &= "Art_TauxProm = " & Ap(cls.Art_TauxProm) & ","
            sql &= "Remise_Fidelite = " & Ap(cls.Remise_Fidelite) & ","
            sql &= "photo_Path = " & Ap(cls.photo_Path) & ","
            sql &= "ddm = " & Ap(cls.ddm) & ","
            sql &= "export = " & IIf(cls.export, "'true'", "'False'") & ","
            sql &= "Ecrivain = " & Ap(cls.Ecrivain) & ","
            sql &= "Collection = " & Ap(cls.Collection) & ","
            sql &= "is_Calcul_inverse = " & IIf(cls.is_Calcul_inverse, "'true'", "'False'") & ","
            sql &= "is_Tacktil = " & IIf(cls.is_Tacktil, "'true'", "'False'") & ","
            sql &= "is_Peremption = " & IIf(cls.is_Peremption, "'true'", "'False'") & ","
            sql &= "Nbr_Jour_Peremption = " & Ap(cls.Nbr_Jour_Peremption) & ","
            sql &= "is_Promo_Qte_Prix = " & IIf(cls.is_Promo_Qte_Prix, "'true'", "'False'") & ","
            sql &= "ART_CodeFrs2 = " & Ap(cls.ART_CodeFrs2) & ","
            sql &= "ART_ChezFrs2 = " & Ap(cls.ART_ChezFrs2) & ","
            sql &= "ART_CodeFrs3 = " & Ap(cls.ART_CodeFrs3) & ","
            sql &= "ART_ChezFrs3 = " & Ap(cls.ART_ChezFrs3) & ","
            sql &= "is_AlertStock = " & IIf(cls.is_AlertStock, "'true'", "'False'")
            sql &= " WHERE ART_Code= " & Ap(cls.ART_Code)
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Private Sub DestroyPermanently(Id As String)
        Try

            Dim UpdateCommand As SqlCommand = New SqlCommand()
            UpdateCommand.Connection = _cn

            '******IMPORTANT: You can use this commented instruction to make a logical delete .
            '******Replace DELETED Field with your logic deleted field name.
            'Dim Sql As String = "UPDATE Article SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Article"
            Sql &= " Where ART_Code = " & Ap(Id)

            'UpdateCommand.Transaction = myTransaction
            UpdateCommand.CommandText = Sql
            UpdateCommand.ExecuteNonQuery()
            UpdateCommand.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub

    Public Overrides Sub Delete(Id As String)

        DestroyPermanently(Id)

    End Sub

    Public Overrides Sub Delete(ByRef obj As Article, Optional ByRef ListaObj As List(Of Article) = Nothing)

        DestroyPermanently(obj.ART_Code)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Article)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Article)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Article)
        Dim Ls As New List(Of Article)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT ART_Code,ART_Designation,ART_PrixUnitaireHT,ART_CodeBar,ART_DesgCourte,ART_Famille,ART_Marque,ART_MargeB,ART_PrixUnitaireHTVA,ART_TypePrixUnitaireHTVA,ART_TVA,ART_Couleur,ART_User,ART_Station,ART_QTEmin,ART_Fodec,ART_DC,ART_QTEmax,ART_TAILLE,ART_QteDeclaree,ART_Prix_AchatFactReel,ART_Image,ART_DateCr,ART_QteStock,ART_NumSerie,ART_IsTaktile,ART_PrixGros1,ART_QtePrixGros1,ART_PrixGros2,ART_QtePrixGros2,ART_PrixGros3,ART_QteGros3,ART_CoulBN,ART_PrixUnitaireHTRes,ART_PrixUnitaireHTGlobale,ART_export,ART_ddm,PrixSolde,TauxSolde,ART_Equivalence,Regularisation,ART_Cout_charge,ART_codeSerie,CRPonderer,QTE_Restante,Coeff_charge,Charge_tot_coeff,Type_Produit,Type_service,is_bloquer,ART_CodeFrs,ART_Fournisseur,ART_Poid_Qte,Emp_Code,Touche_Balance,Type_Balance,Anc_cout,Art_Session,Art_Prom,Art_NbProm,Art_TauxProm,Remise_Fidelite,photo_Path,ddm,export,Ecrivain,Collection,is_Calcul_inverse,is_Tacktil,is_Peremption,Nbr_Jour_Peremption,is_Promo_Qte_Prix,ART_CodeFrs2,ART_ChezFrs2,ART_CodeFrs3,ART_ChezFrs3,is_AlertStock from Article"
            For Each Par As LUNA.LunaSearchParameter In Parameter
                If Not Par Is Nothing Then
                    If sql.IndexOf("WHERE") = -1 Then sql &= " WHERE " Else sql &= " " & Par.LogicOperatorStr & " "
                    sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
                End If
            Next

            If OrderBy.Length Then sql &= " ORDER BY " & OrderBy

            myCommand.CommandText = sql
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read
                Dim classe As New Article
                If Not myReader("ART_Code") Is DBNull.Value Then classe.ART_Code = myReader("ART_Code")
                If Not myReader("ART_Designation") Is DBNull.Value Then classe.ART_Designation = myReader("ART_Designation")
                If Not myReader("ART_PrixUnitaireHT") Is DBNull.Value Then classe.ART_PrixUnitaireHT = myReader("ART_PrixUnitaireHT")
                If Not myReader("ART_CodeBar") Is DBNull.Value Then classe.ART_CodeBar = myReader("ART_CodeBar")
                If Not myReader("ART_DesgCourte") Is DBNull.Value Then classe.ART_DesgCourte = myReader("ART_DesgCourte")
                If Not myReader("ART_Famille") Is DBNull.Value Then classe.ART_Famille = myReader("ART_Famille")
                If Not myReader("ART_Marque") Is DBNull.Value Then classe.ART_Marque = myReader("ART_Marque")
                If Not myReader("ART_MargeB") Is DBNull.Value Then classe.ART_MargeB = myReader("ART_MargeB")
                If Not myReader("ART_PrixUnitaireHTVA") Is DBNull.Value Then classe.ART_PrixUnitaireHTVA = myReader("ART_PrixUnitaireHTVA")
                If Not myReader("ART_TypePrixUnitaireHTVA") Is DBNull.Value Then classe.ART_TypePrixUnitaireHTVA = myReader("ART_TypePrixUnitaireHTVA")
                If Not myReader("ART_TVA") Is DBNull.Value Then classe.ART_TVA = myReader("ART_TVA")
                If Not myReader("ART_Couleur") Is DBNull.Value Then classe.ART_Couleur = myReader("ART_Couleur")
                If Not myReader("ART_User") Is DBNull.Value Then classe.ART_User = myReader("ART_User")
                If Not myReader("ART_Station") Is DBNull.Value Then classe.ART_Station = myReader("ART_Station")
                If Not myReader("ART_QTEmin") Is DBNull.Value Then classe.ART_QTEmin = myReader("ART_QTEmin")
                If Not myReader("ART_Fodec") Is DBNull.Value Then classe.ART_Fodec = myReader("ART_Fodec")
                If Not myReader("ART_DC") Is DBNull.Value Then classe.ART_DC = myReader("ART_DC")
                If Not myReader("ART_QTEmax") Is DBNull.Value Then classe.ART_QTEmax = myReader("ART_QTEmax")
                If Not myReader("ART_TAILLE") Is DBNull.Value Then classe.ART_TAILLE = myReader("ART_TAILLE")
                If Not myReader("ART_QteDeclaree") Is DBNull.Value Then classe.ART_QteDeclaree = myReader("ART_QteDeclaree")
                If Not myReader("ART_Prix_AchatFactReel") Is DBNull.Value Then classe.ART_Prix_AchatFactReel = myReader("ART_Prix_AchatFactReel")
                If Not myReader("ART_Image") Is DBNull.Value Then classe.ART_Image = myReader("ART_Image")
                If Not myReader("ART_DateCr") Is DBNull.Value Then classe.ART_DateCr = myReader("ART_DateCr")
                If Not myReader("ART_QteStock") Is DBNull.Value Then classe.ART_QteStock = myReader("ART_QteStock")
                If Not myReader("ART_NumSerie") Is DBNull.Value Then classe.ART_NumSerie = myReader("ART_NumSerie")
                If Not myReader("ART_IsTaktile") Is DBNull.Value Then classe.ART_IsTaktile = myReader("ART_IsTaktile")
                If Not myReader("ART_PrixGros1") Is DBNull.Value Then classe.ART_PrixGros1 = myReader("ART_PrixGros1")
                If Not myReader("ART_QtePrixGros1") Is DBNull.Value Then classe.ART_QtePrixGros1 = myReader("ART_QtePrixGros1")
                If Not myReader("ART_PrixGros2") Is DBNull.Value Then classe.ART_PrixGros2 = myReader("ART_PrixGros2")
                If Not myReader("ART_QtePrixGros2") Is DBNull.Value Then classe.ART_QtePrixGros2 = myReader("ART_QtePrixGros2")
                If Not myReader("ART_PrixGros3") Is DBNull.Value Then classe.ART_PrixGros3 = myReader("ART_PrixGros3")
                If Not myReader("ART_QteGros3") Is DBNull.Value Then classe.ART_QteGros3 = myReader("ART_QteGros3")
                If Not myReader("ART_CoulBN") Is DBNull.Value Then classe.ART_CoulBN = myReader("ART_CoulBN")
                If Not myReader("ART_PrixUnitaireHTRes") Is DBNull.Value Then classe.ART_PrixUnitaireHTRes = myReader("ART_PrixUnitaireHTRes")
                If Not myReader("ART_PrixUnitaireHTGlobale") Is DBNull.Value Then classe.ART_PrixUnitaireHTGlobale = myReader("ART_PrixUnitaireHTGlobale")
                If Not myReader("ART_export") Is DBNull.Value Then classe.ART_export = myReader("ART_export")
                If Not myReader("ART_ddm") Is DBNull.Value Then classe.ART_ddm = myReader("ART_ddm")
                If Not myReader("PrixSolde") Is DBNull.Value Then classe.PrixSolde = myReader("PrixSolde")
                If Not myReader("TauxSolde") Is DBNull.Value Then classe.TauxSolde = myReader("TauxSolde")
                If Not myReader("ART_Equivalence") Is DBNull.Value Then classe.ART_Equivalence = myReader("ART_Equivalence")
                If Not myReader("Regularisation") Is DBNull.Value Then classe.Regularisation = myReader("Regularisation")
                If Not myReader("ART_Cout_charge") Is DBNull.Value Then classe.ART_Cout_charge = myReader("ART_Cout_charge")
                If Not myReader("ART_codeSerie") Is DBNull.Value Then classe.ART_codeSerie = myReader("ART_codeSerie")
                If Not myReader("CRPonderer") Is DBNull.Value Then classe.CRPonderer = myReader("CRPonderer")
                If Not myReader("QTE_Restante") Is DBNull.Value Then classe.QTE_Restante = myReader("QTE_Restante")
                If Not myReader("Coeff_charge") Is DBNull.Value Then classe.Coeff_charge = myReader("Coeff_charge")
                If Not myReader("Charge_tot_coeff") Is DBNull.Value Then classe.Charge_tot_coeff = myReader("Charge_tot_coeff")
                If Not myReader("Type_Produit") Is DBNull.Value Then classe.Type_Produit = myReader("Type_Produit")
                If Not myReader("Type_service") Is DBNull.Value Then classe.Type_service = myReader("Type_service")
                If Not myReader("is_bloquer") Is DBNull.Value Then classe.is_bloquer = myReader("is_bloquer")
                If Not myReader("ART_CodeFrs") Is DBNull.Value Then classe.ART_CodeFrs = myReader("ART_CodeFrs")
                If Not myReader("ART_Fournisseur") Is DBNull.Value Then classe.ART_Fournisseur = myReader("ART_Fournisseur")
                If Not myReader("ART_Poid_Qte") Is DBNull.Value Then classe.ART_Poid_Qte = myReader("ART_Poid_Qte")
                If Not myReader("Emp_Code") Is DBNull.Value Then classe.Emp_Code = myReader("Emp_Code")
                If Not myReader("Touche_Balance") Is DBNull.Value Then classe.Touche_Balance = myReader("Touche_Balance")
                If Not myReader("Type_Balance") Is DBNull.Value Then classe.Type_Balance = myReader("Type_Balance")
                If Not myReader("Anc_cout") Is DBNull.Value Then classe.Anc_cout = myReader("Anc_cout")
                If Not myReader("Art_Session") Is DBNull.Value Then classe.Art_Session = myReader("Art_Session")
                If Not myReader("Art_Prom") Is DBNull.Value Then classe.Art_Prom = myReader("Art_Prom")
                If Not myReader("Art_NbProm") Is DBNull.Value Then classe.Art_NbProm = myReader("Art_NbProm")
                If Not myReader("Art_TauxProm") Is DBNull.Value Then classe.Art_TauxProm = myReader("Art_TauxProm")
                If Not myReader("Remise_Fidelite") Is DBNull.Value Then classe.Remise_Fidelite = myReader("Remise_Fidelite")
                If Not myReader("photo_Path") Is DBNull.Value Then classe.photo_Path = myReader("photo_Path")
                If Not myReader("ddm") Is DBNull.Value Then classe.ddm = myReader("ddm")
                If Not myReader("export") Is DBNull.Value Then classe.export = myReader("export")
                If Not myReader("Ecrivain") Is DBNull.Value Then classe.Ecrivain = myReader("Ecrivain")
                If Not myReader("Collection") Is DBNull.Value Then classe.Collection = myReader("Collection")
                If Not myReader("is_Calcul_inverse") Is DBNull.Value Then classe.is_Calcul_inverse = myReader("is_Calcul_inverse")
                If Not myReader("is_Tacktil") Is DBNull.Value Then classe.is_Tacktil = myReader("is_Tacktil")
                If Not myReader("is_Peremption") Is DBNull.Value Then classe.is_Peremption = myReader("is_Peremption")
                If Not myReader("Nbr_Jour_Peremption") Is DBNull.Value Then classe.Nbr_Jour_Peremption = myReader("Nbr_Jour_Peremption")
                If Not myReader("is_Promo_Qte_Prix") Is DBNull.Value Then classe.is_Promo_Qte_Prix = myReader("is_Promo_Qte_Prix")
                If Not myReader("ART_CodeFrs2") Is DBNull.Value Then classe.ART_CodeFrs2 = myReader("ART_CodeFrs2")
                If Not myReader("ART_ChezFrs2") Is DBNull.Value Then classe.ART_ChezFrs2 = myReader("ART_ChezFrs2")
                If Not myReader("ART_CodeFrs3") Is DBNull.Value Then classe.ART_CodeFrs3 = myReader("ART_CodeFrs3")
                If Not myReader("ART_ChezFrs3") Is DBNull.Value Then classe.ART_ChezFrs3 = myReader("ART_ChezFrs3")
                If Not myReader("is_AlertStock") Is DBNull.Value Then classe.is_AlertStock = myReader("is_AlertStock")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Article)
        Dim Ls As New List(Of Article)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT ART_Code,ART_Designation,ART_PrixUnitaireHT,ART_CodeBar,ART_DesgCourte,ART_Famille,ART_Marque,ART_MargeB,ART_PrixUnitaireHTVA,ART_TypePrixUnitaireHTVA,ART_TVA,ART_Couleur,ART_User,ART_Station,ART_QTEmin,ART_Fodec,ART_DC,ART_QTEmax,ART_TAILLE,ART_QteDeclaree,ART_Prix_AchatFactReel,ART_Image,ART_DateCr,ART_QteStock,ART_NumSerie,ART_IsTaktile,ART_PrixGros1,ART_QtePrixGros1,ART_PrixGros2,ART_QtePrixGros2,ART_PrixGros3,ART_QteGros3,ART_CoulBN,ART_PrixUnitaireHTRes,ART_PrixUnitaireHTGlobale,ART_export,ART_ddm,PrixSolde,TauxSolde,ART_Equivalence,Regularisation,ART_Cout_charge,ART_codeSerie,CRPonderer,QTE_Restante,Coeff_charge,Charge_tot_coeff,Type_Produit,Type_service,is_bloquer,ART_CodeFrs,ART_Fournisseur,ART_Poid_Qte,Emp_Code,Touche_Balance,Type_Balance,Anc_cout,Art_Session,Art_Prom,Art_NbProm,Art_TauxProm,Remise_Fidelite,photo_Path,ddm,export,Ecrivain,Collection,is_Calcul_inverse,is_Tacktil,is_Peremption,Nbr_Jour_Peremption,is_Promo_Qte_Prix,ART_CodeFrs2,ART_ChezFrs2,ART_CodeFrs3,ART_ChezFrs3,is_AlertStock from Article"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Article() With {.ART_Code = "", .ART_Designation = "", .ART_PrixUnitaireHT = Nothing, .ART_CodeBar = "", .ART_DesgCourte = "", .ART_Famille = "", .ART_Marque = "", .ART_MargeB = Nothing, .ART_PrixUnitaireHTVA = Nothing, .ART_TypePrixUnitaireHTVA = "", .ART_TVA = Nothing, .ART_Couleur = "", .ART_User = "", .ART_Station = "", .ART_QTEmin = Nothing, .ART_Fodec = 0, .ART_DC = 0, .ART_QTEmax = Nothing, .ART_TAILLE = "", .ART_QteDeclaree = Nothing, .ART_Prix_AchatFactReel = Nothing, .ART_Image = Nothing, .ART_DateCr = Nothing, .ART_QteStock = Nothing, .ART_NumSerie = "", .ART_IsTaktile = False, .ART_PrixGros1 = Nothing, .ART_QtePrixGros1 = Nothing, .ART_PrixGros2 = Nothing, .ART_QtePrixGros2 = Nothing, .ART_PrixGros3 = Nothing, .ART_QteGros3 = Nothing, .ART_CoulBN = "", .ART_PrixUnitaireHTRes = Nothing, .ART_PrixUnitaireHTGlobale = Nothing, .ART_export = False, .ART_ddm = Nothing, .PrixSolde = Nothing, .TauxSolde = Nothing, .ART_Equivalence = "", .Regularisation = "", .ART_Cout_charge = Nothing, .ART_codeSerie = "", .CRPonderer = Nothing, .QTE_Restante = Nothing, .Coeff_charge = Nothing, .Charge_tot_coeff = Nothing, .Type_Produit = "", .Type_service = "", .is_bloquer = False, .ART_CodeFrs = "", .ART_Fournisseur = "", .ART_Poid_Qte = "", .Emp_Code = "", .Touche_Balance = "", .Type_Balance = "", .Anc_cout = Nothing, .Art_Session = False, .Art_Prom = False, .Art_NbProm = Nothing, .Art_TauxProm = Nothing, .Remise_Fidelite = Nothing, .photo_Path = "", .ddm = Nothing, .export = False, .Ecrivain = "", .Collection = "", .is_Calcul_inverse = False, .is_Tacktil = False, .is_Peremption = False, .Nbr_Jour_Peremption = 0, .is_Promo_Qte_Prix = False, .ART_CodeFrs2 = "", .ART_ChezFrs2 = "", .ART_CodeFrs3 = "", .ART_ChezFrs3 = "", .is_AlertStock = False})
            While myReader.Read
                Dim classe As New Article
                If Not myReader("ART_Code") Is DBNull.Value Then classe.ART_Code = myReader("ART_Code")
                If Not myReader("ART_Designation") Is DBNull.Value Then classe.ART_Designation = myReader("ART_Designation")
                If Not myReader("ART_PrixUnitaireHT") Is DBNull.Value Then classe.ART_PrixUnitaireHT = myReader("ART_PrixUnitaireHT")
                If Not myReader("ART_CodeBar") Is DBNull.Value Then classe.ART_CodeBar = myReader("ART_CodeBar")
                If Not myReader("ART_DesgCourte") Is DBNull.Value Then classe.ART_DesgCourte = myReader("ART_DesgCourte")
                If Not myReader("ART_Famille") Is DBNull.Value Then classe.ART_Famille = myReader("ART_Famille")
                If Not myReader("ART_Marque") Is DBNull.Value Then classe.ART_Marque = myReader("ART_Marque")
                If Not myReader("ART_MargeB") Is DBNull.Value Then classe.ART_MargeB = myReader("ART_MargeB")
                If Not myReader("ART_PrixUnitaireHTVA") Is DBNull.Value Then classe.ART_PrixUnitaireHTVA = myReader("ART_PrixUnitaireHTVA")
                If Not myReader("ART_TypePrixUnitaireHTVA") Is DBNull.Value Then classe.ART_TypePrixUnitaireHTVA = myReader("ART_TypePrixUnitaireHTVA")
                If Not myReader("ART_TVA") Is DBNull.Value Then classe.ART_TVA = myReader("ART_TVA")
                If Not myReader("ART_Couleur") Is DBNull.Value Then classe.ART_Couleur = myReader("ART_Couleur")
                If Not myReader("ART_User") Is DBNull.Value Then classe.ART_User = myReader("ART_User")
                If Not myReader("ART_Station") Is DBNull.Value Then classe.ART_Station = myReader("ART_Station")
                If Not myReader("ART_QTEmin") Is DBNull.Value Then classe.ART_QTEmin = myReader("ART_QTEmin")
                If Not myReader("ART_Fodec") Is DBNull.Value Then classe.ART_Fodec = myReader("ART_Fodec")
                If Not myReader("ART_DC") Is DBNull.Value Then classe.ART_DC = myReader("ART_DC")
                If Not myReader("ART_QTEmax") Is DBNull.Value Then classe.ART_QTEmax = myReader("ART_QTEmax")
                If Not myReader("ART_TAILLE") Is DBNull.Value Then classe.ART_TAILLE = myReader("ART_TAILLE")
                If Not myReader("ART_QteDeclaree") Is DBNull.Value Then classe.ART_QteDeclaree = myReader("ART_QteDeclaree")
                If Not myReader("ART_Prix_AchatFactReel") Is DBNull.Value Then classe.ART_Prix_AchatFactReel = myReader("ART_Prix_AchatFactReel")
                If Not myReader("ART_Image") Is DBNull.Value Then classe.ART_Image = myReader("ART_Image")
                If Not myReader("ART_DateCr") Is DBNull.Value Then classe.ART_DateCr = myReader("ART_DateCr")
                If Not myReader("ART_QteStock") Is DBNull.Value Then classe.ART_QteStock = myReader("ART_QteStock")
                If Not myReader("ART_NumSerie") Is DBNull.Value Then classe.ART_NumSerie = myReader("ART_NumSerie")
                If Not myReader("ART_IsTaktile") Is DBNull.Value Then classe.ART_IsTaktile = myReader("ART_IsTaktile")
                If Not myReader("ART_PrixGros1") Is DBNull.Value Then classe.ART_PrixGros1 = myReader("ART_PrixGros1")
                If Not myReader("ART_QtePrixGros1") Is DBNull.Value Then classe.ART_QtePrixGros1 = myReader("ART_QtePrixGros1")
                If Not myReader("ART_PrixGros2") Is DBNull.Value Then classe.ART_PrixGros2 = myReader("ART_PrixGros2")
                If Not myReader("ART_QtePrixGros2") Is DBNull.Value Then classe.ART_QtePrixGros2 = myReader("ART_QtePrixGros2")
                If Not myReader("ART_PrixGros3") Is DBNull.Value Then classe.ART_PrixGros3 = myReader("ART_PrixGros3")
                If Not myReader("ART_QteGros3") Is DBNull.Value Then classe.ART_QteGros3 = myReader("ART_QteGros3")
                If Not myReader("ART_CoulBN") Is DBNull.Value Then classe.ART_CoulBN = myReader("ART_CoulBN")
                If Not myReader("ART_PrixUnitaireHTRes") Is DBNull.Value Then classe.ART_PrixUnitaireHTRes = myReader("ART_PrixUnitaireHTRes")
                If Not myReader("ART_PrixUnitaireHTGlobale") Is DBNull.Value Then classe.ART_PrixUnitaireHTGlobale = myReader("ART_PrixUnitaireHTGlobale")
                If Not myReader("ART_export") Is DBNull.Value Then classe.ART_export = myReader("ART_export")
                If Not myReader("ART_ddm") Is DBNull.Value Then classe.ART_ddm = myReader("ART_ddm")
                If Not myReader("PrixSolde") Is DBNull.Value Then classe.PrixSolde = myReader("PrixSolde")
                If Not myReader("TauxSolde") Is DBNull.Value Then classe.TauxSolde = myReader("TauxSolde")
                If Not myReader("ART_Equivalence") Is DBNull.Value Then classe.ART_Equivalence = myReader("ART_Equivalence")
                If Not myReader("Regularisation") Is DBNull.Value Then classe.Regularisation = myReader("Regularisation")
                If Not myReader("ART_Cout_charge") Is DBNull.Value Then classe.ART_Cout_charge = myReader("ART_Cout_charge")
                If Not myReader("ART_codeSerie") Is DBNull.Value Then classe.ART_codeSerie = myReader("ART_codeSerie")
                If Not myReader("CRPonderer") Is DBNull.Value Then classe.CRPonderer = myReader("CRPonderer")
                If Not myReader("QTE_Restante") Is DBNull.Value Then classe.QTE_Restante = myReader("QTE_Restante")
                If Not myReader("Coeff_charge") Is DBNull.Value Then classe.Coeff_charge = myReader("Coeff_charge")
                If Not myReader("Charge_tot_coeff") Is DBNull.Value Then classe.Charge_tot_coeff = myReader("Charge_tot_coeff")
                If Not myReader("Type_Produit") Is DBNull.Value Then classe.Type_Produit = myReader("Type_Produit")
                If Not myReader("Type_service") Is DBNull.Value Then classe.Type_service = myReader("Type_service")
                If Not myReader("is_bloquer") Is DBNull.Value Then classe.is_bloquer = myReader("is_bloquer")
                If Not myReader("ART_CodeFrs") Is DBNull.Value Then classe.ART_CodeFrs = myReader("ART_CodeFrs")
                If Not myReader("ART_Fournisseur") Is DBNull.Value Then classe.ART_Fournisseur = myReader("ART_Fournisseur")
                If Not myReader("ART_Poid_Qte") Is DBNull.Value Then classe.ART_Poid_Qte = myReader("ART_Poid_Qte")
                If Not myReader("Emp_Code") Is DBNull.Value Then classe.Emp_Code = myReader("Emp_Code")
                If Not myReader("Touche_Balance") Is DBNull.Value Then classe.Touche_Balance = myReader("Touche_Balance")
                If Not myReader("Type_Balance") Is DBNull.Value Then classe.Type_Balance = myReader("Type_Balance")
                If Not myReader("Anc_cout") Is DBNull.Value Then classe.Anc_cout = myReader("Anc_cout")
                If Not myReader("Art_Session") Is DBNull.Value Then classe.Art_Session = myReader("Art_Session")
                If Not myReader("Art_Prom") Is DBNull.Value Then classe.Art_Prom = myReader("Art_Prom")
                If Not myReader("Art_NbProm") Is DBNull.Value Then classe.Art_NbProm = myReader("Art_NbProm")
                If Not myReader("Art_TauxProm") Is DBNull.Value Then classe.Art_TauxProm = myReader("Art_TauxProm")
                If Not myReader("Remise_Fidelite") Is DBNull.Value Then classe.Remise_Fidelite = myReader("Remise_Fidelite")
                If Not myReader("photo_Path") Is DBNull.Value Then classe.photo_Path = myReader("photo_Path")
                If Not myReader("ddm") Is DBNull.Value Then classe.ddm = myReader("ddm")
                If Not myReader("export") Is DBNull.Value Then classe.export = myReader("export")
                If Not myReader("Ecrivain") Is DBNull.Value Then classe.Ecrivain = myReader("Ecrivain")
                If Not myReader("Collection") Is DBNull.Value Then classe.Collection = myReader("Collection")
                If Not myReader("is_Calcul_inverse") Is DBNull.Value Then classe.is_Calcul_inverse = myReader("is_Calcul_inverse")
                If Not myReader("is_Tacktil") Is DBNull.Value Then classe.is_Tacktil = myReader("is_Tacktil")
                If Not myReader("is_Peremption") Is DBNull.Value Then classe.is_Peremption = myReader("is_Peremption")
                If Not myReader("Nbr_Jour_Peremption") Is DBNull.Value Then classe.Nbr_Jour_Peremption = myReader("Nbr_Jour_Peremption")
                If Not myReader("is_Promo_Qte_Prix") Is DBNull.Value Then classe.is_Promo_Qte_Prix = myReader("is_Promo_Qte_Prix")
                If Not myReader("ART_CodeFrs2") Is DBNull.Value Then classe.ART_CodeFrs2 = myReader("ART_CodeFrs2")
                If Not myReader("ART_ChezFrs2") Is DBNull.Value Then classe.ART_ChezFrs2 = myReader("ART_ChezFrs2")
                If Not myReader("ART_CodeFrs3") Is DBNull.Value Then classe.ART_CodeFrs3 = myReader("ART_CodeFrs3")
                If Not myReader("ART_ChezFrs3") Is DBNull.Value Then classe.ART_ChezFrs3 = myReader("ART_ChezFrs3")
                If Not myReader("is_AlertStock") Is DBNull.Value Then classe.is_AlertStock = myReader("is_AlertStock")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function
End Class


