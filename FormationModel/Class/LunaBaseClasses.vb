#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 01/11/2017
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Namespace LUNA

    Public Enum enLogicOperator
        enAND = 0
        enOR
    End Enum

    Public MustInherit Class LunaBaseClass

        Public Shared _cn As SqlClient.SqlConnection
        Public Shared myTransaction As SqlTransaction
        Protected Shared _ConnectionString As String = String.Empty

        Public Sub ManageError(ByVal ex As Exception)
            Throw New Exception(ex.Message)
        End Sub

    End Class

    Public MustInherit Class LunaBaseClassDAO(Of T)
        Inherits LunaBaseClass

        Public Sub New()

            'By default use ConnectionString in AppSettings
            _ConnectionString = Module_parametrage.ChaineCNX '  Parametrage.connectionString
            OpenDBConnection()
        End Sub

        Public Sub New(ByVal Connection As SqlClient.SqlConnection)
            _cn = Connection
            OpenDBConnection()
        End Sub

        Public Sub New(ByVal ConnectionString As String)
            If ConnectionString.Length <> 0 Then
                _ConnectionString = ConnectionString
                OpenDBConnection()
            End If
        End Sub

        Public MustOverride Function Read(ByVal Id As String) As T
        Public MustOverride Function Save(ByRef obj As T) As Integer
        Public MustOverride Sub Delete(ByVal Id As String)
        Public MustOverride Sub Delete(ByRef obj As T, Optional ByRef ListaObj As List(Of T) = Nothing)
        Public MustOverride Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of T)
        Public MustOverride Function GetAll(Optional ByVal OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of T)

        Protected Function OpenDBConnection() As Integer
            Dim Ris As Integer = 0
            Try
                If _cn Is Nothing Then _cn = New SqlConnection()
                If _cn.ConnectionString.Length = 0 Then _cn.ConnectionString = _ConnectionString
                If _cn.State <> Data.ConnectionState.Open Then _cn.Open()
            Catch ex As Exception
                Ris = 1
            End Try
            Return Ris
        End Function

        Protected Function CloseDbConnection() As Integer
            Dim Ris As Integer = 0
            Try
                If Not _cn Is Nothing Then
                    If _cn.State = ConnectionState.Open Then
                        _cn.Close()
                    End If
                    _cn = Nothing
                End If
            Catch ex As Exception
                Ris = 1
            End Try
            Return Ris
        End Function

        'Public Function Ap(ByVal Testo) As String
        '    Dim str As String = String.Empty
        '    If Not TypeOf Testo Is String And Testo IsNot Nothing Then
        '        str = " " & Testo.ToString
        '    Else
        '        If Testo IsNot Nothing Then
        '            str = Testo.ToString
        '        End If

        '        If Not String.IsNullOrWhiteSpace(str) And Not String.IsNullOrEmpty(str) Then
        '            str = str.Replace("'", "''")
        '            str = " '" & str & "'"
        '        Else
        '            str = "''"
        '        End If

        '    End If
        '    If TypeOf Testo Is DateTime Then
        '        str = Testo.ToString
        '        str = str.Replace("'", "''")
        '        str = " '" & str & "'"
        '        If Testo = DateTime.MinValue Then
        '            str = "NULL"
        '        End If
        '    End If
        '    Return Str
        'End Function
        Public Function Ap(ByVal Testo) As String
            Dim str As String = String.Empty
            If Not TypeOf Testo Is String And Testo IsNot Nothing Then
                str = " " & Testo.ToString
            Else
                If Testo IsNot Nothing Then
                    str = Testo.ToString
                End If

                If Not String.IsNullOrWhiteSpace(str) And Not String.IsNullOrEmpty(str) Then
                    str = str.Replace("'", "''")
                    str = " '" & str & "'"
                Else
                    str = "''"
                End If

            End If
            If TypeOf Testo Is DateTime Then
                str = Testo.ToString
                str = str.Replace("'", "''")
                str = " '" & str & "'"
                If Testo = DateTime.MinValue Then
                    str = "NULL"
                End If
            End If
            If TypeOf Testo Is Decimal Then

                str = Testo.ToString
                str = str.Replace(",", ".")

                str = " '" & str & "'"


            End If
            If TypeOf Testo Is Byte() Then

                str = Testo.ToString


                str = " '" & str & "'"


            End If

            Return str
        End Function

#Region "Serialization Method"
        Public Function ReadSerialize(ByVal PathXMLSerial As String) As T

            Dim cls As T
            Try
                Dim serialize As XmlSerializer = New XmlSerializer(GetType(T))
                Dim deSerialize As IO.FileStream = New IO.FileStream(PathXMLSerial, IO.FileMode.Open)
                cls = serialize.Deserialize(deSerialize)
            Catch ex As Exception
                ManageError(ex)
            End Try

            Return cls
        End Function
        Public Sub SaveSerialize(Obj As T, ByVal PathXML As String)

            Try
                Dim serialize As XmlSerializer = New XmlSerializer(GetType(T))
                Dim Writer As New System.IO.StreamWriter(PathXML)
                serialize.Serialize(Writer, Obj)
                Writer.Close()
            Catch ex As Exception
                ManageError(ex)
            End Try

        End Sub
#End Region

    End Class

    Public Class LunaSearchParameter

        Public Sub New()

        End Sub

        Public Sub New(ByVal FieldName As String, ByVal Value As Object, Optional ByVal SqlOperator As String = "", Optional ByVal LogicOperator As enLogicOperator = enLogicOperator.enAND)
            _FieldName = FieldName
            _Value = Value
            If SqlOperator.Length Then _SqlOperator = SqlOperator
            _LogicOperator = LogicOperator
        End Sub

        Private _SqlOperator As String = " = "
        Public Property SqlOperator As String
            Get
                Return _SqlOperator
            End Get
            Set(ByVal value As String)
                _SqlOperator = value
            End Set
        End Property

        Private _LogicOperator As enLogicOperator = enLogicOperator.enAND
        Public Property LogicOperator As enLogicOperator
            Get
                Return _LogicOperator
            End Get
            Set(ByVal value As enLogicOperator)
                _LogicOperator = value
            End Set
        End Property

        Public ReadOnly Property LogicOperatorStr As String
            Get
                If _LogicOperator = enLogicOperator.enAND Then
                    Return " And "
                Else
                    Return " Or "
                End If
            End Get
        End Property

        Private _FieldName As String
        Public Property FieldName As String
            Get
                Return _FieldName
            End Get
            Set(ByVal value As String)
                _FieldName = value
            End Set
        End Property

        Private _Value
        Public Property Value
            Get
                Return _Value
            End Get
            Set(ByVal value)
                _Value = value
            End Set
        End Property

    End Class

End Namespace

