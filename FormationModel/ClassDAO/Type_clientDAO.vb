#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 13/06/2019
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Partial Public Class Type_client
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _TYP_Client As String = ""

    <XmlElementAttribute("TYP_Client")>
    Public Property TYP_Client() As String
        Get
            Return _TYP_Client
        End Get
        Set(ByVal value As String)
            _TYP_Client = value
        End Set
    End Property

    Private _TYP_user As String = ""

    <XmlElementAttribute("TYP_user")>
    Public Property TYP_user() As String
        Get
            Return _TYP_user
        End Get
        Set(ByVal value As String)
            _TYP_user = value
        End Set
    End Property

    Private _TYP_station As String = ""

    <XmlElementAttribute("TYP_station")>
    Public Property TYP_station() As String
        Get
            Return _TYP_station
        End Get
        Set(ByVal value As String)
            _TYP_station = value
        End Set
    End Property

    Private _TYP_export As String = ""

    <XmlElementAttribute("TYP_export")>
    Public Property TYP_export() As String
        Get
            Return _TYP_export
        End Get
        Set(ByVal value As String)
            _TYP_export = value
        End Set
    End Property

    Private _TYP_DDm As String = ""

    <XmlElementAttribute("TYP_DDm")>
    Public Property TYP_DDm() As String
        Get
            Return _TYP_DDm
        End Get
        Set(ByVal value As String)
            _TYP_DDm = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Partial Public Class Type_clientDAO
    Inherits LUNA.LunaBaseClassDAO(Of Type_client)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New Type_clientDAO
    Public Shared Function getInstance() As Type_clientDAO
        If IsNothing(Utilisateur) Then
            Return New Type_clientDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As String) As Type_client
        Dim cls As New Type_client

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Type_client where TYP_Client = " & Ap(Id)
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                If Not myReader("TYP_Client") Is DBNull.Value Then
                    cls.TYP_Client = myReader("TYP_Client")
                End If
                If Not myReader("TYP_user") Is DBNull.Value Then
                    cls.TYP_user = myReader("TYP_user")
                End If
                If Not myReader("TYP_station") Is DBNull.Value Then
                    cls.TYP_station = myReader("TYP_station")
                End If
                If Not myReader("TYP_export") Is DBNull.Value Then
                    cls.TYP_export = myReader("TYP_export")
                End If
                If Not myReader("TYP_DDm") Is DBNull.Value Then
                    cls.TYP_DDm = myReader("TYP_DDm")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Type_client) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Type_client("
            sql &= "TYP_Client,"
            sql &= "TYP_user,"
            sql &= "TYP_station,"
            sql &= "TYP_export,"
            sql &= "TYP_DDm"
            sql &= ") VALUES ("
            sql &= Ap(cls.TYP_Client) & ","
            sql &= Ap(cls.TYP_user) & ","
            sql &= Ap(cls.TYP_station) & ","
            sql &= Ap(cls.TYP_export) & ","
            sql &= Ap(cls.TYP_DDm)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Type_client) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Type_client SET "
            sql &= "TYP_user = " & Ap(cls.TYP_user) & ","
            sql &= "TYP_station = " & Ap(cls.TYP_station) & ","
            sql &= "TYP_export = " & Ap(cls.TYP_export) & ","
            sql &= "TYP_DDm = " & Ap(cls.TYP_DDm)
            sql &= " WHERE TYP_Client= " & Ap(cls.TYP_Client)
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
            'Dim Sql As String = "UPDATE Type_client SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Type_client"
            Sql &= " Where TYP_Client = " & Ap(Id)

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

    Public Overrides Sub Delete(ByRef obj As Type_client, Optional ByRef ListaObj As List(Of Type_client) = Nothing)

        DestroyPermanently(obj.TYP_Client)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Type_client)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Type_client)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Type_client)
        Dim Ls As New List(Of Type_client)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT TYP_Client,TYP_user,TYP_station,TYP_export,TYP_DDm from Type_client"
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
                Dim classe As New Type_client
                If Not myReader("TYP_Client") Is DBNull.Value Then classe.TYP_Client = myReader("TYP_Client")
                If Not myReader("TYP_user") Is DBNull.Value Then classe.TYP_user = myReader("TYP_user")
                If Not myReader("TYP_station") Is DBNull.Value Then classe.TYP_station = myReader("TYP_station")
                If Not myReader("TYP_export") Is DBNull.Value Then classe.TYP_export = myReader("TYP_export")
                If Not myReader("TYP_DDm") Is DBNull.Value Then classe.TYP_DDm = myReader("TYP_DDm")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Type_client)
        Dim Ls As New List(Of Type_client)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT TYP_Client,TYP_user,TYP_station,TYP_export,TYP_DDm from Type_client"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Type_client() With {.TYP_Client = "", .TYP_user = "", .TYP_station = "", .TYP_export = "", .TYP_DDm = ""})
            While myReader.Read
                Dim classe As New Type_client
                If Not myReader("TYP_Client") Is DBNull.Value Then classe.TYP_Client = myReader("TYP_Client")
                If Not myReader("TYP_user") Is DBNull.Value Then classe.TYP_user = myReader("TYP_user")
                If Not myReader("TYP_station") Is DBNull.Value Then classe.TYP_station = myReader("TYP_station")
                If Not myReader("TYP_export") Is DBNull.Value Then classe.TYP_export = myReader("TYP_export")
                If Not myReader("TYP_DDm") Is DBNull.Value Then classe.TYP_DDm = myReader("TYP_DDm")
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


