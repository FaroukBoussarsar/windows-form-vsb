#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 30/06/2019
#End Region

Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.SqlClient

Partial Public Class Art_taille
Inherits LUNA.LunaBaseClass
'******IMPORTANT: Write your code in the Class object that use this Partial Class.
'******So you can replace DAOClass and EntityClass without lost your code

Public Sub New()

End Sub

#Region "Database Field Map"

Private _taille as string = "" 

<XmlElementAttribute("taille")> _
Public property taille() as string
Get
	Return _taille
End Get
Set (byval value as string)
	_taille= value
End Set
End property 
#End Region

#Region "Embedded Class"

#End Region

End Class 

Partial Public  Class Art_tailleDAO
Inherits LUNA.LunaBaseClassDAO(Of Art_taille)

Public Sub New()
	MyBase.New()
End Sub

Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
	MyBase.New(Connection)
End Sub

Public Sub New(ByVal ConnectionString As string)
	MyBase.New(ConnectionString)
End Sub

 Private Shared Utilisateur As New Art_tailleDAO
  Public Shared Function getInstance() As Art_tailleDAO
	If IsNothing(Utilisateur) Then
	  Return New Art_tailleDAO
Else

Return Utilisateur

 End If

 End Function

Public Overrides Function Read(Id as string) as Art_taille
Dim cls as new Art_taille

Try
Dim myCommand As SqlCommand = _cn.CreateCommand()
myCommand.CommandText = "set language french;SELECT * FROM Art_taille where taille = " & Ap(Id)
     myCommand.Transaction = myTransaction
Dim myReader As SqlDataReader = myCommand.ExecuteReader()
myReader.Read()
if myReader.HasRows then
	if not myReader("taille") is DBNull.Value then
		cls.taille= myReader("taille")
	end if
End If
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return cls
End Function


Public Overrides Function Save(byRef cls as Art_taille) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
	Try
		Dim sql As String
		DbCommand.Connection = _cn
		DbCommand.Transaction = myTransaction
			sql = "set language french;INSERT INTO Art_taille("
			sql &= "taille"
				sql &= ") VALUES ("
	sql &= ap(cls.taille)
				sql &= ")"
		DbCommand.CommandText = sql
		DbCommand.ExecuteNonQuery()

		DbCommand.Dispose()

	Catch ex As Exception
		ManageError(ex)
	End Try
Return Ris
End Function


Public  Function Update(byRef cls as Art_taille) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
	Try
		Dim sql As String
		DbCommand.Connection = _cn
		DbCommand.Transaction = myTransaction
			sql = "set language french;UPDATE Art_taille SET "
				sql &= " WHERE taille= " & Ap(cls.taille)
		DbCommand.CommandText = sql
		DbCommand.ExecuteNonQuery()

		DbCommand.Dispose()

	Catch ex As Exception
		ManageError(ex)
	End Try
Return Ris
End Function


Private Sub DestroyPermanently(Id as string) 
Try

Dim UpdateCommand As SqlCommand = New SqlCommand()
UpdateCommand.Connection = _cn

'******IMPORTANT: You can use this commented instruction to make a logical delete .
'******Replace DELETED Field with your logic deleted field name.
'Dim Sql As String = "UPDATE Art_taille SET DELETED=True "
Dim Sql As String = "set language french;DELETE FROM Art_taille"
Sql &= " Where taille = " & Ap(Id) 

		UpdateCommand.Transaction = myTransaction
UpdateCommand.CommandText = Sql
UpdateCommand.ExecuteNonQuery()
UpdateCommand.Dispose()
Catch ex As Exception
	ManageError(ex)
End Try
End Sub

Public Overrides Sub Delete(Id as string) 

DestroyPermanently (Id)

End Sub

Public Overrides Sub Delete(byref obj as Art_taille, Optional ByRef ListaObj as List (of Art_taille) = Nothing)

DestroyPermanently (obj.taille)
If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

End Sub

Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Art_taille)
Return FindReal(OrderBy, Parameter)
End Function

Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Art_taille)
Return FindReal("", Parameter)
End Function

Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Art_taille)
Dim Ls As New List(Of Art_taille)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;  SELECT taille from Art_taille"
For Each Par As LUNA.LunaSearchParameter In Parameter
	If Not Par Is Nothing Then
		If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		Sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
	End if
Next

If OrderBy.Length Then Sql &= " ORDER BY " & OrderBy

myCommand.CommandText = sql
 myCommand.Transaction = myTransaction
Dim myReader As SqlDataReader = myCommand.ExecuteReader()
while myReader.Read
	Dim classe as new Art_taille
	if not myReader("taille") is DBNull.Value then classe.taille = myReader("taille")
	Ls.Add(classe)
end while
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Art_taille)
Dim Ls As New List(Of Art_taille)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;SELECT taille from Art_taille"
If OrderByField.Length Then
	Sql &= " ORDER BY " & OrderByField
End If

myCommand.CommandText = sql
 myCommand.Transaction = myTransaction
Dim myReader As SqlDataReader = myCommand.ExecuteReader()
If AddEmptyItem Then Ls.Add(New  Art_taille() With {.taille = "" })
while myReader.Read
	Dim classe as new Art_taille
	if not myReader("taille") is DBNull.Value then classe.taille = myReader("taille")
	Ls.Add(classe)
end while
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function
End Class


