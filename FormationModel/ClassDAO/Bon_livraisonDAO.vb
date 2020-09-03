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

Partial Public Class Bon_livraison
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _BON_LIV_Num As String = ""

    <XmlElementAttribute("BON_LIV_Num")>
    Public Property BON_LIV_Num() As String
        Get
            Return _BON_LIV_Num
        End Get
        Set(ByVal value As String)
            _BON_LIV_Num = value
        End Set
    End Property

    Private _BON_LIV_Exerc As String = ""

    <XmlElementAttribute("BON_LIV_Exerc")>
    Public Property BON_LIV_Exerc() As String
        Get
            Return _BON_LIV_Exerc
        End Get
        Set(ByVal value As String)
            _BON_LIV_Exerc = value
        End Set
    End Property

    Private _BON_LIV_Date As DateTime = Nothing

    <XmlElementAttribute("BON_LIV_Date")>
    Public Property BON_LIV_Date() As DateTime
        Get
            Return _BON_LIV_Date
        End Get
        Set(ByVal value As DateTime)
            _BON_LIV_Date = value
        End Set
    End Property

    Private _BON_LIV_CodeClient As String = ""

    <XmlElementAttribute("BON_LIV_CodeClient")>
    Public Property BON_LIV_CodeClient() As String
        Get
            Return _BON_LIV_CodeClient
        End Get
        Set(ByVal value As String)
            _BON_LIV_CodeClient = value
        End Set
    End Property

    Private _BON_LIV_StationOrigine As String = ""

    <XmlElementAttribute("BON_LIV_StationOrigine")>
    Public Property BON_LIV_StationOrigine() As String
        Get
            Return _BON_LIV_StationOrigine
        End Get
        Set(ByVal value As String)
            _BON_LIV_StationOrigine = value
        End Set
    End Property

    Private _BON_LIV_Etat As String = ""

    <XmlElementAttribute("BON_LIV_Etat")>
    Public Property BON_LIV_Etat() As String
        Get
            Return _BON_LIV_Etat
        End Get
        Set(ByVal value As String)
            _BON_LIV_Etat = value
        End Set
    End Property

    Private _BON_LIV_Station As String = ""

    <XmlElementAttribute("BON_LIV_Station")>
    Public Property BON_LIV_Station() As String
        Get
            Return _BON_LIV_Station
        End Get
        Set(ByVal value As String)
            _BON_LIV_Station = value
        End Set
    End Property

    Private _BON_LIV_User As String = ""

    <XmlElementAttribute("BON_LIV_User")>
    Public Property BON_LIV_User() As String
        Get
            Return _BON_LIV_User
        End Get
        Set(ByVal value As String)
            _BON_LIV_User = value
        End Set
    End Property

    Private _BON_LIV_Montant As Decimal = Nothing

    <XmlElementAttribute("BON_LIV_Montant")>
    Public Property BON_LIV_Montant() As Decimal
        Get
            Return _BON_LIV_Montant
        End Get
        Set(ByVal value As Decimal)
            _BON_LIV_Montant = value
        End Set
    End Property

    Private _BON_LIV_Regler As Boolean = False

    <XmlElementAttribute("BON_LIV_Regler")>
    Public Property BON_LIV_Regler() As Boolean
        Get
            Return _BON_LIV_Regler
        End Get
        Set(ByVal value As Boolean)
            _BON_LIV_Regler = value
        End Set
    End Property

    Private _BON_LIV_export As Boolean = False

    <XmlElementAttribute("BON_LIV_export")>
    Public Property BON_LIV_export() As Boolean
        Get
            Return _BON_LIV_export
        End Get
        Set(ByVal value As Boolean)
            _BON_LIV_export = value
        End Set
    End Property

    Private _BON_LIV_DDm As DateTime = Nothing

    <XmlElementAttribute("BON_LIV_DDm")>
    Public Property BON_LIV_DDm() As DateTime
        Get
            Return _BON_LIV_DDm
        End Get
        Set(ByVal value As DateTime)
            _BON_LIV_DDm = value
        End Set
    End Property

    Private _BON_LIV_Transporteur As String = ""

    <XmlElementAttribute("BON_LIV_Transporteur")>
    Public Property BON_LIV_Transporteur() As String
        Get
            Return _BON_LIV_Transporteur
        End Get
        Set(ByVal value As String)
            _BON_LIV_Transporteur = value
        End Set
    End Property

    Private _BON_LIV_Vehicule As String = ""

    <XmlElementAttribute("BON_LIV_Vehicule")>
    Public Property BON_LIV_Vehicule() As String
        Get
            Return _BON_LIV_Vehicule
        End Get
        Set(ByVal value As String)
            _BON_LIV_Vehicule = value
        End Set
    End Property

    Private _BON_LIV_Type As String = ""

    <XmlElementAttribute("BON_LIV_Type")>
    Public Property BON_LIV_Type() As String
        Get
            Return _BON_LIV_Type
        End Get
        Set(ByVal value As String)
            _BON_LIV_Type = value
        End Set
    End Property

    Private _BON_LIV_Tarif As String = ""

    <XmlElementAttribute("BON_LIV_Tarif")>
    Public Property BON_LIV_Tarif() As String
        Get
            Return _BON_LIV_Tarif
        End Get
        Set(ByVal value As String)
            _BON_LIV_Tarif = value
        End Set
    End Property

    Private _BON_isTTC As Boolean = False

    <XmlElementAttribute("BON_isTTC")>
    Public Property BON_isTTC() As Boolean
        Get
            Return _BON_isTTC
        End Get
        Set(ByVal value As Boolean)
            _BON_isTTC = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Partial Public Class Bon_livraisonDAO
    Inherits LUNA.LunaBaseClassDAO(Of Bon_livraison)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New Bon_livraisonDAO
    Public Shared Function getInstance() As Bon_livraisonDAO
        If IsNothing(Utilisateur) Then
            Return New Bon_livraisonDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As String) As Bon_livraison
        Dim cls As New Bon_livraison

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Bon_livraison where BON_LIV_Num = " & Ap(Id)
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.BON_LIV_Num = myReader("BON_LIV_Num")
                cls.BON_LIV_Exerc = myReader("BON_LIV_Exerc")
                cls.BON_LIV_Date = myReader("BON_LIV_Date")
                cls.BON_LIV_CodeClient = myReader("BON_LIV_CodeClient")
                cls.BON_LIV_StationOrigine = myReader("BON_LIV_StationOrigine")
                If Not myReader("BON_LIV_Etat") Is DBNull.Value Then
                    cls.BON_LIV_Etat = myReader("BON_LIV_Etat")
                End If
                If Not myReader("BON_LIV_Station") Is DBNull.Value Then
                    cls.BON_LIV_Station = myReader("BON_LIV_Station")
                End If
                If Not myReader("BON_LIV_User") Is DBNull.Value Then
                    cls.BON_LIV_User = myReader("BON_LIV_User")
                End If
                If Not myReader("BON_LIV_Montant") Is DBNull.Value Then
                    cls.BON_LIV_Montant = myReader("BON_LIV_Montant")
                End If
                If Not myReader("BON_LIV_Regler") Is DBNull.Value Then
                    cls.BON_LIV_Regler = myReader("BON_LIV_Regler")
                End If
                If Not myReader("BON_LIV_export") Is DBNull.Value Then
                    cls.BON_LIV_export = myReader("BON_LIV_export")
                End If
                If Not myReader("BON_LIV_DDm") Is DBNull.Value Then
                    cls.BON_LIV_DDm = myReader("BON_LIV_DDm")
                End If
                If Not myReader("BON_LIV_Transporteur") Is DBNull.Value Then
                    cls.BON_LIV_Transporteur = myReader("BON_LIV_Transporteur")
                End If
                If Not myReader("BON_LIV_Vehicule") Is DBNull.Value Then
                    cls.BON_LIV_Vehicule = myReader("BON_LIV_Vehicule")
                End If
                If Not myReader("BON_LIV_Type") Is DBNull.Value Then
                    cls.BON_LIV_Type = myReader("BON_LIV_Type")
                End If
                If Not myReader("BON_LIV_Tarif") Is DBNull.Value Then
                    cls.BON_LIV_Tarif = myReader("BON_LIV_Tarif")
                End If
                If Not myReader("BON_isTTC") Is DBNull.Value Then
                    cls.BON_isTTC = myReader("BON_isTTC")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Bon_livraison) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Bon_livraison("
            sql &= "BON_LIV_Num,"
            sql &= "BON_LIV_Exerc,"
            sql &= "BON_LIV_Date,"
            sql &= "BON_LIV_CodeClient,"
            sql &= "BON_LIV_StationOrigine,"
            sql &= "BON_LIV_Etat,"
            sql &= "BON_LIV_Station,"
            sql &= "BON_LIV_User,"
            sql &= "BON_LIV_Montant,"
            sql &= "BON_LIV_Regler,"
            sql &= "BON_LIV_export,"
            sql &= "BON_LIV_DDm,"
            sql &= "BON_LIV_Transporteur,"
            sql &= "BON_LIV_Vehicule,"
            sql &= "BON_LIV_Type,"
            sql &= "BON_LIV_Tarif,"
            sql &= "BON_isTTC"
            sql &= ") VALUES ("
            sql &= Ap(cls.BON_LIV_Num) & ","
            sql &= Ap(cls.BON_LIV_Exerc) & ","
            sql &= Ap(cls.BON_LIV_Date) & ","
            sql &= Ap(cls.BON_LIV_CodeClient) & ","
            sql &= Ap(cls.BON_LIV_StationOrigine) & ","
            sql &= Ap(cls.BON_LIV_Etat) & ","
            sql &= Ap(cls.BON_LIV_Station) & ","
            sql &= Ap(cls.BON_LIV_User) & ","
            sql &= Ap(cls.BON_LIV_Montant) & ","
            sql &= IIf(cls.BON_LIV_Regler, -1, 0) & ","
            sql &= IIf(cls.BON_LIV_export, -1, 0) & ","
            sql &= Ap(cls.BON_LIV_DDm) & ","
            sql &= Ap(cls.BON_LIV_Transporteur) & ","
            sql &= Ap(cls.BON_LIV_Vehicule) & ","
            sql &= Ap(cls.BON_LIV_Type) & ","
            sql &= Ap(cls.BON_LIV_Tarif) & ","
            sql &= IIf(cls.BON_isTTC, -1, 0)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Bon_livraison) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Bon_livraison SET "
            sql &= "BON_LIV_Exerc = " & Ap(cls.BON_LIV_Exerc) & ","
            sql &= "BON_LIV_Date = " & Ap(cls.BON_LIV_Date) & ","
            sql &= "BON_LIV_CodeClient = " & Ap(cls.BON_LIV_CodeClient) & ","
            sql &= "BON_LIV_StationOrigine = " & Ap(cls.BON_LIV_StationOrigine) & ","
            sql &= "BON_LIV_Etat = " & Ap(cls.BON_LIV_Etat) & ","
            sql &= "BON_LIV_Station = " & Ap(cls.BON_LIV_Station) & ","
            sql &= "BON_LIV_User = " & Ap(cls.BON_LIV_User) & ","
            sql &= "BON_LIV_Montant = " & Ap(cls.BON_LIV_Montant) & ","
            sql &= "BON_LIV_Regler = " & IIf(cls.BON_LIV_Regler, "'true'", "'False'") & ","
            sql &= "BON_LIV_export = " & IIf(cls.BON_LIV_export, "'true'", "'False'") & ","
            sql &= "BON_LIV_DDm = " & Ap(cls.BON_LIV_DDm) & ","
            sql &= "BON_LIV_Transporteur = " & Ap(cls.BON_LIV_Transporteur) & ","
            sql &= "BON_LIV_Vehicule = " & Ap(cls.BON_LIV_Vehicule) & ","
            sql &= "BON_LIV_Type = " & Ap(cls.BON_LIV_Type) & ","
            sql &= "BON_LIV_Tarif = " & Ap(cls.BON_LIV_Tarif) & ","
            sql &= "BON_isTTC = " & IIf(cls.BON_isTTC, "'true'", "'False'")
            sql &= " WHERE BON_LIV_Num= " & Ap(cls.BON_LIV_Num)
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
            'Dim Sql As String = "UPDATE Bon_livraison SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Bon_livraison"
            Sql &= " Where BON_LIV_Num = " & Ap(Id)

            '	UpdateCommand.Transaction = myTransaction
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

    Public Overrides Sub Delete(ByRef obj As Bon_livraison, Optional ByRef ListaObj As List(Of Bon_livraison) = Nothing)

        DestroyPermanently(obj.BON_LIV_Num)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Bon_livraison)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Bon_livraison)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Bon_livraison)
        Dim Ls As New List(Of Bon_livraison)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT BON_LIV_Num,BON_LIV_Exerc,BON_LIV_Date,BON_LIV_CodeClient,BON_LIV_StationOrigine,BON_LIV_Etat,BON_LIV_Station,BON_LIV_User,BON_LIV_Montant,BON_LIV_Regler,BON_LIV_export,BON_LIV_DDm,BON_LIV_Transporteur,BON_LIV_Vehicule,BON_LIV_Type,BON_LIV_Tarif,BON_isTTC from Bon_livraison"
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
                Dim classe As New Bon_livraison
                If Not myReader("BON_LIV_Num") Is DBNull.Value Then classe.BON_LIV_Num = myReader("BON_LIV_Num")
                If Not myReader("BON_LIV_Exerc") Is DBNull.Value Then classe.BON_LIV_Exerc = myReader("BON_LIV_Exerc")
                If Not myReader("BON_LIV_Date") Is DBNull.Value Then classe.BON_LIV_Date = myReader("BON_LIV_Date")
                If Not myReader("BON_LIV_CodeClient") Is DBNull.Value Then classe.BON_LIV_CodeClient = myReader("BON_LIV_CodeClient")
                If Not myReader("BON_LIV_StationOrigine") Is DBNull.Value Then classe.BON_LIV_StationOrigine = myReader("BON_LIV_StationOrigine")
                If Not myReader("BON_LIV_Etat") Is DBNull.Value Then classe.BON_LIV_Etat = myReader("BON_LIV_Etat")
                If Not myReader("BON_LIV_Station") Is DBNull.Value Then classe.BON_LIV_Station = myReader("BON_LIV_Station")
                If Not myReader("BON_LIV_User") Is DBNull.Value Then classe.BON_LIV_User = myReader("BON_LIV_User")
                If Not myReader("BON_LIV_Montant") Is DBNull.Value Then classe.BON_LIV_Montant = myReader("BON_LIV_Montant")
                If Not myReader("BON_LIV_Regler") Is DBNull.Value Then classe.BON_LIV_Regler = myReader("BON_LIV_Regler")
                If Not myReader("BON_LIV_export") Is DBNull.Value Then classe.BON_LIV_export = myReader("BON_LIV_export")
                If Not myReader("BON_LIV_DDm") Is DBNull.Value Then classe.BON_LIV_DDm = myReader("BON_LIV_DDm")
                If Not myReader("BON_LIV_Transporteur") Is DBNull.Value Then classe.BON_LIV_Transporteur = myReader("BON_LIV_Transporteur")
                If Not myReader("BON_LIV_Vehicule") Is DBNull.Value Then classe.BON_LIV_Vehicule = myReader("BON_LIV_Vehicule")
                If Not myReader("BON_LIV_Type") Is DBNull.Value Then classe.BON_LIV_Type = myReader("BON_LIV_Type")
                If Not myReader("BON_LIV_Tarif") Is DBNull.Value Then classe.BON_LIV_Tarif = myReader("BON_LIV_Tarif")
                If Not myReader("BON_isTTC") Is DBNull.Value Then classe.BON_isTTC = myReader("BON_isTTC")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    'hello i am here
    Public Function FindID() As String
        Dim Ls As New List(Of Bon_livraison)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT BON_LIV_Num,BON_LIV_Exerc,BON_LIV_Date,BON_LIV_CodeClient,BON_LIV_StationOrigine,BON_LIV_Etat,BON_LIV_Station,BON_LIV_User,BON_LIV_Montant,BON_LIV_Regler,BON_LIV_export,BON_LIV_DDm,BON_LIV_Transporteur,BON_LIV_Vehicule,BON_LIV_Type,BON_LIV_Tarif,BON_isTTC from Bon_livraison"




            myCommand.CommandText = sql
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read
                Dim classe As New Bon_livraison
                If Not myReader("BON_LIV_Num") Is DBNull.Value Then classe.BON_LIV_Num = myReader("BON_LIV_Num")
                If Not myReader("BON_LIV_Exerc") Is DBNull.Value Then classe.BON_LIV_Exerc = myReader("BON_LIV_Exerc")
                If Not myReader("BON_LIV_Date") Is DBNull.Value Then classe.BON_LIV_Date = myReader("BON_LIV_Date")
                If Not myReader("BON_LIV_CodeClient") Is DBNull.Value Then classe.BON_LIV_CodeClient = myReader("BON_LIV_CodeClient")
                If Not myReader("BON_LIV_StationOrigine") Is DBNull.Value Then classe.BON_LIV_StationOrigine = myReader("BON_LIV_StationOrigine")
                If Not myReader("BON_LIV_Etat") Is DBNull.Value Then classe.BON_LIV_Etat = myReader("BON_LIV_Etat")
                If Not myReader("BON_LIV_Station") Is DBNull.Value Then classe.BON_LIV_Station = myReader("BON_LIV_Station")
                If Not myReader("BON_LIV_User") Is DBNull.Value Then classe.BON_LIV_User = myReader("BON_LIV_User")
                If Not myReader("BON_LIV_Montant") Is DBNull.Value Then classe.BON_LIV_Montant = myReader("BON_LIV_Montant")
                If Not myReader("BON_LIV_Regler") Is DBNull.Value Then classe.BON_LIV_Regler = myReader("BON_LIV_Regler")
                If Not myReader("BON_LIV_export") Is DBNull.Value Then classe.BON_LIV_export = myReader("BON_LIV_export")
                If Not myReader("BON_LIV_DDm") Is DBNull.Value Then classe.BON_LIV_DDm = myReader("BON_LIV_DDm")
                If Not myReader("BON_LIV_Transporteur") Is DBNull.Value Then classe.BON_LIV_Transporteur = myReader("BON_LIV_Transporteur")
                If Not myReader("BON_LIV_Vehicule") Is DBNull.Value Then classe.BON_LIV_Vehicule = myReader("BON_LIV_Vehicule")
                If Not myReader("BON_LIV_Type") Is DBNull.Value Then classe.BON_LIV_Type = myReader("BON_LIV_Type")
                If Not myReader("BON_LIV_Tarif") Is DBNull.Value Then classe.BON_LIV_Tarif = myReader("BON_LIV_Tarif")
                If Not myReader("BON_isTTC") Is DBNull.Value Then classe.BON_isTTC = myReader("BON_isTTC")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        If Ls.Count = 0 Then
            Return "BL19/00000"
        Else

            Return Ls.Max(Function(p As Bon_livraison) p.BON_LIV_Num)
        End If


    End Function


    'hello i am out





    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Bon_livraison)
        Dim Ls As New List(Of Bon_livraison)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT BON_LIV_Num,BON_LIV_Exerc,BON_LIV_Date,BON_LIV_CodeClient,BON_LIV_StationOrigine,BON_LIV_Etat,BON_LIV_Station,BON_LIV_User,BON_LIV_Montant,BON_LIV_Regler,BON_LIV_export,BON_LIV_DDm,BON_LIV_Transporteur,BON_LIV_Vehicule,BON_LIV_Type,BON_LIV_Tarif,BON_isTTC from Bon_livraison"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Bon_livraison() With {.BON_LIV_Num = "", .BON_LIV_Exerc = "", .BON_LIV_Date = Nothing, .BON_LIV_CodeClient = "", .BON_LIV_StationOrigine = "", .BON_LIV_Etat = "", .BON_LIV_Station = "", .BON_LIV_User = "", .BON_LIV_Montant = Nothing, .BON_LIV_Regler = False, .BON_LIV_export = False, .BON_LIV_DDm = Nothing, .BON_LIV_Transporteur = "", .BON_LIV_Vehicule = "", .BON_LIV_Type = "", .BON_LIV_Tarif = "", .BON_isTTC = False})
            While myReader.Read
                Dim classe As New Bon_livraison
                If Not myReader("BON_LIV_Num") Is DBNull.Value Then classe.BON_LIV_Num = myReader("BON_LIV_Num")
                If Not myReader("BON_LIV_Exerc") Is DBNull.Value Then classe.BON_LIV_Exerc = myReader("BON_LIV_Exerc")
                If Not myReader("BON_LIV_Date") Is DBNull.Value Then classe.BON_LIV_Date = myReader("BON_LIV_Date")
                If Not myReader("BON_LIV_CodeClient") Is DBNull.Value Then classe.BON_LIV_CodeClient = myReader("BON_LIV_CodeClient")
                If Not myReader("BON_LIV_StationOrigine") Is DBNull.Value Then classe.BON_LIV_StationOrigine = myReader("BON_LIV_StationOrigine")
                If Not myReader("BON_LIV_Etat") Is DBNull.Value Then classe.BON_LIV_Etat = myReader("BON_LIV_Etat")
                If Not myReader("BON_LIV_Station") Is DBNull.Value Then classe.BON_LIV_Station = myReader("BON_LIV_Station")
                If Not myReader("BON_LIV_User") Is DBNull.Value Then classe.BON_LIV_User = myReader("BON_LIV_User")
                If Not myReader("BON_LIV_Montant") Is DBNull.Value Then classe.BON_LIV_Montant = myReader("BON_LIV_Montant")
                If Not myReader("BON_LIV_Regler") Is DBNull.Value Then classe.BON_LIV_Regler = myReader("BON_LIV_Regler")
                If Not myReader("BON_LIV_export") Is DBNull.Value Then classe.BON_LIV_export = myReader("BON_LIV_export")
                If Not myReader("BON_LIV_DDm") Is DBNull.Value Then classe.BON_LIV_DDm = myReader("BON_LIV_DDm")
                If Not myReader("BON_LIV_Transporteur") Is DBNull.Value Then classe.BON_LIV_Transporteur = myReader("BON_LIV_Transporteur")
                If Not myReader("BON_LIV_Vehicule") Is DBNull.Value Then classe.BON_LIV_Vehicule = myReader("BON_LIV_Vehicule")
                If Not myReader("BON_LIV_Type") Is DBNull.Value Then classe.BON_LIV_Type = myReader("BON_LIV_Type")
                If Not myReader("BON_LIV_Tarif") Is DBNull.Value Then classe.BON_LIV_Tarif = myReader("BON_LIV_Tarif")
                If Not myReader("BON_isTTC") Is DBNull.Value Then classe.BON_isTTC = myReader("BON_isTTC")
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


