#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 12/06/2019
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Partial Public Class Ligne_bon_livraison
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _LG_BON_Liv_NumBon As String = ""

    <XmlElementAttribute("LG_BON_Liv_NumBon")>
    Public Property LG_BON_Liv_NumBon() As String
        Get
            Return _LG_BON_Liv_NumBon
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_NumBon = value
        End Set
    End Property

    Private _LG_BON_Liv_Exerc As String = ""

    <XmlElementAttribute("LG_BON_Liv_Exerc")>
    Public Property LG_BON_Liv_Exerc() As String
        Get
            Return _LG_BON_Liv_Exerc
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_Exerc = value
        End Set
    End Property

    Private _LG_BON_Liv_CodeArt As String = ""

    <XmlElementAttribute("LG_BON_Liv_CodeArt")>
    Public Property LG_BON_Liv_CodeArt() As String
        Get
            Return _LG_BON_Liv_CodeArt
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_CodeArt = value
        End Set
    End Property

    Private _LG_BON_Liv_Qte As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_Qte")>
    Public Property LG_BON_Liv_Qte() As Decimal
        Get
            Return _LG_BON_Liv_Qte
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_Qte = value
        End Set
    End Property

    Private _LG_BON_Liv_Unite As String = ""

    <XmlElementAttribute("LG_BON_Liv_Unite")>
    Public Property LG_BON_Liv_Unite() As String
        Get
            Return _LG_BON_Liv_Unite
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_Unite = value
        End Set
    End Property

    Private _LG_BON_Liv_PUHT As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_PUHT")>
    Public Property LG_BON_Liv_PUHT() As Decimal
        Get
            Return _LG_BON_Liv_PUHT
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_PUHT = value
        End Set
    End Property

    Private _LG_BON_Liv_Tva As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_Tva")>
    Public Property LG_BON_Liv_Tva() As Decimal
        Get
            Return _LG_BON_Liv_Tva
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_Tva = value
        End Set
    End Property

    Private _LG_BON_Liv_Netht As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_Netht")>
    Public Property LG_BON_Liv_Netht() As Decimal
        Get
            Return _LG_BON_Liv_Netht
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_Netht = value
        End Set
    End Property

    Private _LG_BON_Liv_Remise As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_Remise")>
    Public Property LG_BON_Liv_Remise() As Decimal
        Get
            Return _LG_BON_Liv_Remise
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_Remise = value
        End Set
    End Property

    Private _LG_BON_Liv_station As String = ""

    <XmlElementAttribute("LG_BON_Liv_station")>
    Public Property LG_BON_Liv_station() As String
        Get
            Return _LG_BON_Liv_station
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_station = value
        End Set
    End Property

    Private _LG_BON_Liv_User As String = ""

    <XmlElementAttribute("LG_BON_Liv_User")>
    Public Property LG_BON_Liv_User() As String
        Get
            Return _LG_BON_Liv_User
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_User = value
        End Set
    End Property

    Private _LG_BON_Liv_NumOrdre As Integer = 0

    <XmlElementAttribute("LG_BON_Liv_NumOrdre")>
    Public Property LG_BON_Liv_NumOrdre() As Integer
        Get
            Return _LG_BON_Liv_NumOrdre
        End Get
        Set(ByVal value As Integer)
            _LG_BON_Liv_NumOrdre = value
        End Set
    End Property

    Private _LG_BON_Liv_Tarif As String = ""

    <XmlElementAttribute("LG_BON_Liv_Tarif")>
    Public Property LG_BON_Liv_Tarif() As String
        Get
            Return _LG_BON_Liv_Tarif
        End Get
        Set(ByVal value As String)
            _LG_BON_Liv_Tarif = value
        End Set
    End Property

    Private _LG_BON_Liv_QtePiece As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_QtePiece")>
    Public Property LG_BON_Liv_QtePiece() As Decimal
        Get
            Return _LG_BON_Liv_QtePiece
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_QtePiece = value
        End Set
    End Property

    Private _LG_BON_Liv_export As Boolean = False

    <XmlElementAttribute("LG_BON_Liv_export")>
    Public Property LG_BON_Liv_export() As Boolean
        Get
            Return _LG_BON_Liv_export
        End Get
        Set(ByVal value As Boolean)
            _LG_BON_Liv_export = value
        End Set
    End Property

    Private _LG_BON_Liv_DDm As DateTime = Nothing

    <XmlElementAttribute("LG_BON_Liv_DDm")>
    Public Property LG_BON_Liv_DDm() As DateTime
        Get
            Return _LG_BON_Liv_DDm
        End Get
        Set(ByVal value As DateTime)
            _LG_BON_Liv_DDm = value
        End Set
    End Property

    Private _LG_BON_LIV_BE As String = ""

    <XmlElementAttribute("LG_BON_LIV_BE")>
    Public Property LG_BON_LIV_BE() As String
        Get
            Return _LG_BON_LIV_BE
        End Get
        Set(ByVal value As String)
            _LG_BON_LIV_BE = value
        End Set
    End Property

    Private _LG_BON_LIV_BE_Exercice As String = ""

    <XmlElementAttribute("LG_BON_LIV_BE_Exercice")>
    Public Property LG_BON_LIV_BE_Exercice() As String
        Get
            Return _LG_BON_LIV_BE_Exercice
        End Get
        Set(ByVal value As String)
            _LG_BON_LIV_BE_Exercice = value
        End Set
    End Property

    Private _LG_BON_Liv_PUTTC As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_PUTTC")>
    Public Property LG_BON_Liv_PUTTC() As Decimal
        Get
            Return _LG_BON_Liv_PUTTC
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_PUTTC = value
        End Set
    End Property

    Private _LG_BON_Liv_TotalTTC As Decimal = Nothing

    <XmlElementAttribute("LG_BON_Liv_TotalTTC")>
    Public Property LG_BON_Liv_TotalTTC() As Decimal
        Get
            Return _LG_BON_Liv_TotalTTC
        End Get
        Set(ByVal value As Decimal)
            _LG_BON_Liv_TotalTTC = value
        End Set
    End Property

    Private _Cout_charge As Decimal = Nothing

    <XmlElementAttribute("Cout_charge")>
    Public Property Cout_charge() As Decimal
        Get
            Return _Cout_charge
        End Get
        Set(ByVal value As Decimal)
            _Cout_charge = value
        End Set
    End Property

    Private _CMP_Globale As Decimal = Nothing

    <XmlElementAttribute("CMP_Globale")>
    Public Property CMP_Globale() As Decimal
        Get
            Return _CMP_Globale
        End Get
        Set(ByVal value As Decimal)
            _CMP_Globale = value
        End Set
    End Property

    Private _CMP_Res As Decimal = Nothing

    <XmlElementAttribute("CMP_Res")>
    Public Property CMP_Res() As Decimal
        Get
            Return _CMP_Res
        End Get
        Set(ByVal value As Decimal)
            _CMP_Res = value
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

    Private _CMP_Article As Decimal = Nothing

    <XmlElementAttribute("CMP_Article")>
    Public Property CMP_Article() As Decimal
        Get
            Return _CMP_Article
        End Get
        Set(ByVal value As Decimal)
            _CMP_Article = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Partial Public Class Ligne_bon_livraisonDAO
    Inherits LUNA.LunaBaseClassDAO(Of Ligne_bon_livraison)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New Ligne_bon_livraisonDAO
    Public Shared Function getInstance() As Ligne_bon_livraisonDAO
        If IsNothing(Utilisateur) Then
            Return New Ligne_bon_livraisonDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As String) As Ligne_bon_livraison
        Dim cls As New Ligne_bon_livraison

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Ligne_bon_livraison where LG_BON_Liv_NumBon = " & Ap(Id)
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.LG_BON_Liv_NumBon = myReader("LG_BON_Liv_NumBon")
                cls.LG_BON_Liv_Exerc = myReader("LG_BON_Liv_Exerc")
                cls.LG_BON_Liv_CodeArt = myReader("LG_BON_Liv_CodeArt")
                cls.LG_BON_Liv_Qte = myReader("LG_BON_Liv_Qte")
                cls.LG_BON_Liv_Unite = myReader("LG_BON_Liv_Unite")
                If Not myReader("LG_BON_Liv_PUHT") Is DBNull.Value Then
                    cls.LG_BON_Liv_PUHT = myReader("LG_BON_Liv_PUHT")
                End If
                If Not myReader("LG_BON_Liv_Tva") Is DBNull.Value Then
                    cls.LG_BON_Liv_Tva = myReader("LG_BON_Liv_Tva")
                End If
                If Not myReader("LG_BON_Liv_Netht") Is DBNull.Value Then
                    cls.LG_BON_Liv_Netht = myReader("LG_BON_Liv_Netht")
                End If
                If Not myReader("LG_BON_Liv_Remise") Is DBNull.Value Then
                    cls.LG_BON_Liv_Remise = myReader("LG_BON_Liv_Remise")
                End If
                If Not myReader("LG_BON_Liv_station") Is DBNull.Value Then
                    cls.LG_BON_Liv_station = myReader("LG_BON_Liv_station")
                End If
                If Not myReader("LG_BON_Liv_User") Is DBNull.Value Then
                    cls.LG_BON_Liv_User = myReader("LG_BON_Liv_User")
                End If
                If Not myReader("LG_BON_Liv_NumOrdre") Is DBNull.Value Then
                    cls.LG_BON_Liv_NumOrdre = myReader("LG_BON_Liv_NumOrdre")
                End If
                If Not myReader("LG_BON_Liv_Tarif") Is DBNull.Value Then
                    cls.LG_BON_Liv_Tarif = myReader("LG_BON_Liv_Tarif")
                End If
                If Not myReader("LG_BON_Liv_QtePiece") Is DBNull.Value Then
                    cls.LG_BON_Liv_QtePiece = myReader("LG_BON_Liv_QtePiece")
                End If
                If Not myReader("LG_BON_Liv_export") Is DBNull.Value Then
                    cls.LG_BON_Liv_export = myReader("LG_BON_Liv_export")
                End If
                If Not myReader("LG_BON_Liv_DDm") Is DBNull.Value Then
                    cls.LG_BON_Liv_DDm = myReader("LG_BON_Liv_DDm")
                End If
                If Not myReader("LG_BON_LIV_BE") Is DBNull.Value Then
                    cls.LG_BON_LIV_BE = myReader("LG_BON_LIV_BE")
                End If
                If Not myReader("LG_BON_LIV_BE_Exercice") Is DBNull.Value Then
                    cls.LG_BON_LIV_BE_Exercice = myReader("LG_BON_LIV_BE_Exercice")
                End If
                If Not myReader("LG_BON_Liv_PUTTC") Is DBNull.Value Then
                    cls.LG_BON_Liv_PUTTC = myReader("LG_BON_Liv_PUTTC")
                End If
                If Not myReader("LG_BON_Liv_TotalTTC") Is DBNull.Value Then
                    cls.LG_BON_Liv_TotalTTC = myReader("LG_BON_Liv_TotalTTC")
                End If
                If Not myReader("Cout_charge") Is DBNull.Value Then
                    cls.Cout_charge = myReader("Cout_charge")
                End If
                If Not myReader("CMP_Globale") Is DBNull.Value Then
                    cls.CMP_Globale = myReader("CMP_Globale")
                End If
                If Not myReader("CMP_Res") Is DBNull.Value Then
                    cls.CMP_Res = myReader("CMP_Res")
                End If
                If Not myReader("CRPonderer") Is DBNull.Value Then
                    cls.CRPonderer = myReader("CRPonderer")
                End If
                If Not myReader("CMP_Article") Is DBNull.Value Then
                    cls.CMP_Article = myReader("CMP_Article")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Ligne_bon_livraison) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Ligne_bon_livraison("
            sql &= "LG_BON_Liv_NumBon,"
            sql &= "LG_BON_Liv_Exerc,"
            sql &= "LG_BON_Liv_CodeArt,"
            sql &= "LG_BON_Liv_Qte,"
            sql &= "LG_BON_Liv_Unite,"
            sql &= "LG_BON_Liv_PUHT,"
            sql &= "LG_BON_Liv_Tva,"
            sql &= "LG_BON_Liv_Netht,"
            sql &= "LG_BON_Liv_Remise,"
            sql &= "LG_BON_Liv_station,"
            sql &= "LG_BON_Liv_User,"
            sql &= "LG_BON_Liv_NumOrdre,"
            sql &= "LG_BON_Liv_Tarif,"
            sql &= "LG_BON_Liv_QtePiece,"
            sql &= "LG_BON_Liv_export,"
            sql &= "LG_BON_Liv_DDm,"
            sql &= "LG_BON_LIV_BE,"
            sql &= "LG_BON_LIV_BE_Exercice,"
            sql &= "LG_BON_Liv_PUTTC,"
            sql &= "LG_BON_Liv_TotalTTC,"
            sql &= "Cout_charge,"
            sql &= "CMP_Globale,"
            sql &= "CMP_Res,"
            sql &= "CRPonderer,"
            sql &= "CMP_Article"
            sql &= ") VALUES ("
            sql &= Ap(cls.LG_BON_Liv_NumBon) & ","
            sql &= Ap(cls.LG_BON_Liv_Exerc) & ","
            sql &= Ap(cls.LG_BON_Liv_CodeArt) & ","
            sql &= Ap(cls.LG_BON_Liv_Qte) & ","
            sql &= Ap(cls.LG_BON_Liv_Unite) & ","
            sql &= Ap(cls.LG_BON_Liv_PUHT) & ","
            sql &= Ap(cls.LG_BON_Liv_Tva) & ","
            sql &= Ap(cls.LG_BON_Liv_Netht) & ","
            sql &= Ap(cls.LG_BON_Liv_Remise) & ","
            sql &= Ap(cls.LG_BON_Liv_station) & ","
            sql &= Ap(cls.LG_BON_Liv_User) & ","
            sql &= Ap(cls.LG_BON_Liv_NumOrdre) & ","
            sql &= Ap(cls.LG_BON_Liv_Tarif) & ","
            sql &= Ap(cls.LG_BON_Liv_QtePiece) & ","
            sql &= IIf(cls.LG_BON_Liv_export, -1, 0) & ","
            sql &= Ap(cls.LG_BON_Liv_DDm) & ","
            sql &= Ap(cls.LG_BON_LIV_BE) & ","
            sql &= Ap(cls.LG_BON_LIV_BE_Exercice) & ","
            sql &= Ap(cls.LG_BON_Liv_PUTTC) & ","
            sql &= Ap(cls.LG_BON_Liv_TotalTTC) & ","
            sql &= Ap(cls.Cout_charge) & ","
            sql &= Ap(cls.CMP_Globale) & ","
            sql &= Ap(cls.CMP_Res) & ","
            sql &= Ap(cls.CRPonderer) & ","
            sql &= Ap(cls.CMP_Article)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Ligne_bon_livraison) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Ligne_bon_livraison SET "
            sql &= "LG_BON_Liv_Exerc = " & Ap(cls.LG_BON_Liv_Exerc) & ","
            sql &= "LG_BON_Liv_CodeArt = " & Ap(cls.LG_BON_Liv_CodeArt) & ","
            sql &= "LG_BON_Liv_Qte = " & Ap(cls.LG_BON_Liv_Qte) & ","
            sql &= "LG_BON_Liv_Unite = " & Ap(cls.LG_BON_Liv_Unite) & ","
            sql &= "LG_BON_Liv_PUHT = " & Ap(cls.LG_BON_Liv_PUHT) & ","
            sql &= "LG_BON_Liv_Tva = " & Ap(cls.LG_BON_Liv_Tva) & ","
            sql &= "LG_BON_Liv_Netht = " & Ap(cls.LG_BON_Liv_Netht) & ","
            sql &= "LG_BON_Liv_Remise = " & Ap(cls.LG_BON_Liv_Remise) & ","
            sql &= "LG_BON_Liv_station = " & Ap(cls.LG_BON_Liv_station) & ","
            sql &= "LG_BON_Liv_User = " & Ap(cls.LG_BON_Liv_User) & ","
            sql &= "LG_BON_Liv_NumOrdre = " & Ap(cls.LG_BON_Liv_NumOrdre) & ","
            sql &= "LG_BON_Liv_Tarif = " & Ap(cls.LG_BON_Liv_Tarif) & ","
            sql &= "LG_BON_Liv_QtePiece = " & Ap(cls.LG_BON_Liv_QtePiece) & ","
            sql &= "LG_BON_Liv_export = " & IIf(cls.LG_BON_Liv_export, "'true'", "'False'") & ","
            sql &= "LG_BON_Liv_DDm = " & Ap(cls.LG_BON_Liv_DDm) & ","
            sql &= "LG_BON_LIV_BE = " & Ap(cls.LG_BON_LIV_BE) & ","
            sql &= "LG_BON_LIV_BE_Exercice = " & Ap(cls.LG_BON_LIV_BE_Exercice) & ","
            sql &= "LG_BON_Liv_PUTTC = " & Ap(cls.LG_BON_Liv_PUTTC) & ","
            sql &= "LG_BON_Liv_TotalTTC = " & Ap(cls.LG_BON_Liv_TotalTTC) & ","
            sql &= "Cout_charge = " & Ap(cls.Cout_charge) & ","
            sql &= "CMP_Globale = " & Ap(cls.CMP_Globale) & ","
            sql &= "CMP_Res = " & Ap(cls.CMP_Res) & ","
            sql &= "CRPonderer = " & Ap(cls.CRPonderer) & ","
            sql &= "CMP_Article = " & Ap(cls.CMP_Article)
            sql &= " WHERE LG_BON_Liv_NumBon= " & Ap(cls.LG_BON_Liv_NumBon)
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
            'Dim Sql As String = "UPDATE Ligne_bon_livraison SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Ligne_bon_livraison"
            Sql &= " Where LG_BON_Liv_NumBon = " & Ap(Id)

            'UpdateCommand.Transaction = myTransaction
            UpdateCommand.CommandText = Sql
            UpdateCommand.ExecuteNonQuery()
            UpdateCommand.Dispose()
        Catch ex As Exception
            ManageError(ex)
        End Try
    End Sub
    Public Sub DeleteByBon(Id As String)
        Try

            Dim UpdateCommand As SqlCommand = New SqlCommand()
            UpdateCommand.Connection = _cn

            '******IMPORTANT: You can use this commented instruction to make a logical delete .
            '******Replace DELETED Field with your logic deleted field name.
            'Dim Sql As String = "UPDATE Ligne_bon_livraison SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Ligne_bon_livraison"
            Sql &= " Where LG_BON_Liv_NumBon = " & Ap(Id)

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

    Public Overrides Sub Delete(ByRef obj As Ligne_bon_livraison, Optional ByRef ListaObj As List(Of Ligne_bon_livraison) = Nothing)

        DestroyPermanently(obj.LG_BON_Liv_NumBon)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ligne_bon_livraison)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ligne_bon_livraison)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Ligne_bon_livraison)
        Dim Ls As New List(Of Ligne_bon_livraison)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT LG_BON_Liv_NumBon,LG_BON_Liv_Exerc,LG_BON_Liv_CodeArt,LG_BON_Liv_Qte,LG_BON_Liv_Unite,LG_BON_Liv_PUHT,LG_BON_Liv_Tva,LG_BON_Liv_Netht,LG_BON_Liv_Remise,LG_BON_Liv_station,LG_BON_Liv_User,LG_BON_Liv_NumOrdre,LG_BON_Liv_Tarif,LG_BON_Liv_QtePiece,LG_BON_Liv_export,LG_BON_Liv_DDm,LG_BON_LIV_BE,LG_BON_LIV_BE_Exercice,LG_BON_Liv_PUTTC,LG_BON_Liv_TotalTTC,Cout_charge,CMP_Globale,CMP_Res,CRPonderer,CMP_Article from Ligne_bon_livraison"
            For Each Par As LUNA.LunaSearchParameter In Parameter
                If Not Par Is Nothing Then
                    If sql.IndexOf("WHERE") = -1 Then sql &= " WHERE " Else sql &= " " & Par.LogicOperatorStr & " "
                    sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
                End If
            Next

            If OrderBy.Length Then sql &= " ORDER BY " & OrderBy

            myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read
                Dim classe As New Ligne_bon_livraison
                If Not myReader("LG_BON_Liv_NumBon") Is DBNull.Value Then classe.LG_BON_Liv_NumBon = myReader("LG_BON_Liv_NumBon")
                If Not myReader("LG_BON_Liv_Exerc") Is DBNull.Value Then classe.LG_BON_Liv_Exerc = myReader("LG_BON_Liv_Exerc")
                If Not myReader("LG_BON_Liv_CodeArt") Is DBNull.Value Then classe.LG_BON_Liv_CodeArt = myReader("LG_BON_Liv_CodeArt")
                If Not myReader("LG_BON_Liv_Qte") Is DBNull.Value Then classe.LG_BON_Liv_Qte = myReader("LG_BON_Liv_Qte")
                If Not myReader("LG_BON_Liv_Unite") Is DBNull.Value Then classe.LG_BON_Liv_Unite = myReader("LG_BON_Liv_Unite")
                If Not myReader("LG_BON_Liv_PUHT") Is DBNull.Value Then classe.LG_BON_Liv_PUHT = myReader("LG_BON_Liv_PUHT")
                If Not myReader("LG_BON_Liv_Tva") Is DBNull.Value Then classe.LG_BON_Liv_Tva = myReader("LG_BON_Liv_Tva")
                If Not myReader("LG_BON_Liv_Netht") Is DBNull.Value Then classe.LG_BON_Liv_Netht = myReader("LG_BON_Liv_Netht")
                If Not myReader("LG_BON_Liv_Remise") Is DBNull.Value Then classe.LG_BON_Liv_Remise = myReader("LG_BON_Liv_Remise")
                If Not myReader("LG_BON_Liv_station") Is DBNull.Value Then classe.LG_BON_Liv_station = myReader("LG_BON_Liv_station")
                If Not myReader("LG_BON_Liv_User") Is DBNull.Value Then classe.LG_BON_Liv_User = myReader("LG_BON_Liv_User")
                If Not myReader("LG_BON_Liv_NumOrdre") Is DBNull.Value Then classe.LG_BON_Liv_NumOrdre = myReader("LG_BON_Liv_NumOrdre")
                If Not myReader("LG_BON_Liv_Tarif") Is DBNull.Value Then classe.LG_BON_Liv_Tarif = myReader("LG_BON_Liv_Tarif")
                If Not myReader("LG_BON_Liv_QtePiece") Is DBNull.Value Then classe.LG_BON_Liv_QtePiece = myReader("LG_BON_Liv_QtePiece")
                If Not myReader("LG_BON_Liv_export") Is DBNull.Value Then classe.LG_BON_Liv_export = myReader("LG_BON_Liv_export")
                If Not myReader("LG_BON_Liv_DDm") Is DBNull.Value Then classe.LG_BON_Liv_DDm = myReader("LG_BON_Liv_DDm")
                If Not myReader("LG_BON_LIV_BE") Is DBNull.Value Then classe.LG_BON_LIV_BE = myReader("LG_BON_LIV_BE")
                If Not myReader("LG_BON_LIV_BE_Exercice") Is DBNull.Value Then classe.LG_BON_LIV_BE_Exercice = myReader("LG_BON_LIV_BE_Exercice")
                If Not myReader("LG_BON_Liv_PUTTC") Is DBNull.Value Then classe.LG_BON_Liv_PUTTC = myReader("LG_BON_Liv_PUTTC")
                If Not myReader("LG_BON_Liv_TotalTTC") Is DBNull.Value Then classe.LG_BON_Liv_TotalTTC = myReader("LG_BON_Liv_TotalTTC")
                If Not myReader("Cout_charge") Is DBNull.Value Then classe.Cout_charge = myReader("Cout_charge")
                If Not myReader("CMP_Globale") Is DBNull.Value Then classe.CMP_Globale = myReader("CMP_Globale")
                If Not myReader("CMP_Res") Is DBNull.Value Then classe.CMP_Res = myReader("CMP_Res")
                If Not myReader("CRPonderer") Is DBNull.Value Then classe.CRPonderer = myReader("CRPonderer")
                If Not myReader("CMP_Article") Is DBNull.Value Then classe.CMP_Article = myReader("CMP_Article")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Ligne_bon_livraison)
        Dim Ls As New List(Of Ligne_bon_livraison)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT LG_BON_Liv_NumBon,LG_BON_Liv_Exerc,LG_BON_Liv_CodeArt,LG_BON_Liv_Qte,LG_BON_Liv_Unite,LG_BON_Liv_PUHT,LG_BON_Liv_Tva,LG_BON_Liv_Netht,LG_BON_Liv_Remise,LG_BON_Liv_station,LG_BON_Liv_User,LG_BON_Liv_NumOrdre,LG_BON_Liv_Tarif,LG_BON_Liv_QtePiece,LG_BON_Liv_export,LG_BON_Liv_DDm,LG_BON_LIV_BE,LG_BON_LIV_BE_Exercice,LG_BON_Liv_PUTTC,LG_BON_Liv_TotalTTC,Cout_charge,CMP_Globale,CMP_Res,CRPonderer,CMP_Article from Ligne_bon_livraison"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Ligne_bon_livraison() With {.LG_BON_Liv_NumBon = "", .LG_BON_Liv_Exerc = "", .LG_BON_Liv_CodeArt = "", .LG_BON_Liv_Qte = Nothing, .LG_BON_Liv_Unite = "", .LG_BON_Liv_PUHT = Nothing, .LG_BON_Liv_Tva = Nothing, .LG_BON_Liv_Netht = Nothing, .LG_BON_Liv_Remise = Nothing, .LG_BON_Liv_station = "", .LG_BON_Liv_User = "", .LG_BON_Liv_NumOrdre = 0, .LG_BON_Liv_Tarif = "", .LG_BON_Liv_QtePiece = Nothing, .LG_BON_Liv_export = False, .LG_BON_Liv_DDm = Nothing, .LG_BON_LIV_BE = "", .LG_BON_LIV_BE_Exercice = "", .LG_BON_Liv_PUTTC = Nothing, .LG_BON_Liv_TotalTTC = Nothing, .Cout_charge = Nothing, .CMP_Globale = Nothing, .CMP_Res = Nothing, .CRPonderer = Nothing, .CMP_Article = Nothing})
            While myReader.Read
                Dim classe As New Ligne_bon_livraison
                If Not myReader("LG_BON_Liv_NumBon") Is DBNull.Value Then classe.LG_BON_Liv_NumBon = myReader("LG_BON_Liv_NumBon")
                If Not myReader("LG_BON_Liv_Exerc") Is DBNull.Value Then classe.LG_BON_Liv_Exerc = myReader("LG_BON_Liv_Exerc")
                If Not myReader("LG_BON_Liv_CodeArt") Is DBNull.Value Then classe.LG_BON_Liv_CodeArt = myReader("LG_BON_Liv_CodeArt")
                If Not myReader("LG_BON_Liv_Qte") Is DBNull.Value Then classe.LG_BON_Liv_Qte = myReader("LG_BON_Liv_Qte")
                If Not myReader("LG_BON_Liv_Unite") Is DBNull.Value Then classe.LG_BON_Liv_Unite = myReader("LG_BON_Liv_Unite")
                If Not myReader("LG_BON_Liv_PUHT") Is DBNull.Value Then classe.LG_BON_Liv_PUHT = myReader("LG_BON_Liv_PUHT")
                If Not myReader("LG_BON_Liv_Tva") Is DBNull.Value Then classe.LG_BON_Liv_Tva = myReader("LG_BON_Liv_Tva")
                If Not myReader("LG_BON_Liv_Netht") Is DBNull.Value Then classe.LG_BON_Liv_Netht = myReader("LG_BON_Liv_Netht")
                If Not myReader("LG_BON_Liv_Remise") Is DBNull.Value Then classe.LG_BON_Liv_Remise = myReader("LG_BON_Liv_Remise")
                If Not myReader("LG_BON_Liv_station") Is DBNull.Value Then classe.LG_BON_Liv_station = myReader("LG_BON_Liv_station")
                If Not myReader("LG_BON_Liv_User") Is DBNull.Value Then classe.LG_BON_Liv_User = myReader("LG_BON_Liv_User")
                If Not myReader("LG_BON_Liv_NumOrdre") Is DBNull.Value Then classe.LG_BON_Liv_NumOrdre = myReader("LG_BON_Liv_NumOrdre")
                If Not myReader("LG_BON_Liv_Tarif") Is DBNull.Value Then classe.LG_BON_Liv_Tarif = myReader("LG_BON_Liv_Tarif")
                If Not myReader("LG_BON_Liv_QtePiece") Is DBNull.Value Then classe.LG_BON_Liv_QtePiece = myReader("LG_BON_Liv_QtePiece")
                If Not myReader("LG_BON_Liv_export") Is DBNull.Value Then classe.LG_BON_Liv_export = myReader("LG_BON_Liv_export")
                If Not myReader("LG_BON_Liv_DDm") Is DBNull.Value Then classe.LG_BON_Liv_DDm = myReader("LG_BON_Liv_DDm")
                If Not myReader("LG_BON_LIV_BE") Is DBNull.Value Then classe.LG_BON_LIV_BE = myReader("LG_BON_LIV_BE")
                If Not myReader("LG_BON_LIV_BE_Exercice") Is DBNull.Value Then classe.LG_BON_LIV_BE_Exercice = myReader("LG_BON_LIV_BE_Exercice")
                If Not myReader("LG_BON_Liv_PUTTC") Is DBNull.Value Then classe.LG_BON_Liv_PUTTC = myReader("LG_BON_Liv_PUTTC")
                If Not myReader("LG_BON_Liv_TotalTTC") Is DBNull.Value Then classe.LG_BON_Liv_TotalTTC = myReader("LG_BON_Liv_TotalTTC")
                If Not myReader("Cout_charge") Is DBNull.Value Then classe.Cout_charge = myReader("Cout_charge")
                If Not myReader("CMP_Globale") Is DBNull.Value Then classe.CMP_Globale = myReader("CMP_Globale")
                If Not myReader("CMP_Res") Is DBNull.Value Then classe.CMP_Res = myReader("CMP_Res")
                If Not myReader("CRPonderer") Is DBNull.Value Then classe.CRPonderer = myReader("CRPonderer")
                If Not myReader("CMP_Article") Is DBNull.Value Then classe.CMP_Article = myReader("CMP_Article")
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


