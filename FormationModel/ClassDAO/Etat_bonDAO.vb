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

Partial Public Class Etat_bon
Inherits LUNA.LunaBaseClass
'******IMPORTANT: Write your code in the Class object that use this Partial Class.
'******So you can replace DAOClass and EntityClass without lost your code

Public Sub New()

End Sub

#Region "Database Field Map"

Private _Etat_bon_code as string = "" 

<XmlElementAttribute("Etat_bon_code")> _
Public property Etat_bon_code() as string
Get
	Return _Etat_bon_code
End Get
Set (byval value as string)
	_Etat_bon_code= value
End Set
End property 

Private _Etat_bon as string = "" 

<XmlElementAttribute("Etat_bon")> _
Public property Etat_bon() as string
Get
	Return _Etat_bon
End Get
Set (byval value as string)
	_Etat_bon= value
End Set
End property 
#End Region

#Region "Embedded Class"

#End Region

End Class 

Partial Public  Class Etat_bonDAO
Inherits LUNA.LunaBaseClassDAO(Of Etat_bon)

Public Sub New()
	MyBase.New()
End Sub

Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
	MyBase.New(Connection)
End Sub

Public Sub New(ByVal ConnectionString As string)
	MyBase.New(ConnectionString)
End Sub

 Private Shared Utilisateur As New Etat_bonDAO
  Public Shared Function getInstance() As Etat_bonDAO
	If IsNothing(Utilisateur) Then
	  Return New Etat_bonDAO
Else

Return Utilisateur

 End If

 End Function

Public Overrides Function Read(Id as string) as Etat_bon
Dim cls as new Etat_bon

Try
Dim myCommand As SqlCommand = _cn.CreateCommand()
myCommand.CommandText = "set language french;SELECT * FROM Etat_bon where Etat_bon_code = " & Ap(Id)
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
myReader.Read()
if myReader.HasRows then
	if not myReader("Etat_bon_code") is DBNull.Value then
		cls.Etat_bon_code= myReader("Etat_bon_code")
	end if
	if not myReader("Etat_bon") is DBNull.Value then
		cls.Etat_bon= myReader("Etat_bon")
	end if
End If
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return cls
End Function


Public Overrides Function Save(byRef cls as Etat_bon) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
	Try
		Dim sql As String
		DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Etat_bon("
			sql &= "Etat_bon_code,"
			sql &= "Etat_bon"
				sql &= ") VALUES ("
	sql &= ap(cls.Etat_bon_code) & ","
	sql &= ap(cls.Etat_bon)
				sql &= ")"
		DbCommand.CommandText = sql
		DbCommand.ExecuteNonQuery()

		DbCommand.Dispose()

	Catch ex As Exception
		ManageError(ex)
	End Try
Return Ris
End Function


Public  Function Update(byRef cls as Etat_bon) as Integer

Dim Ris as integer=0 'in Ris torno l'id inserito

Dim DbCommand As SqlCommand = New SqlCommand()
	Try
		Dim sql As String
		DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Etat_bon SET "
			sql &= "Etat_bon = " & ap(cls.Etat_bon)
				sql &= " WHERE Etat_bon_code= " & Ap(cls.Etat_bon_code)
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
'Dim Sql As String = "UPDATE Etat_bon SET DELETED=True "
Dim Sql As String = "set language french;DELETE FROM Etat_bon"
Sql &= " Where Etat_bon_code = " & Ap(Id)

            'UpdateCommand.Transaction = myTransaction
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

Public Overrides Sub Delete(byref obj as Etat_bon, Optional ByRef ListaObj as List (of Etat_bon) = Nothing)

DestroyPermanently (obj.Etat_bon_code)
If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

End Sub

Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Etat_bon)
Return FindReal(OrderBy, Parameter)
End Function

Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Etat_bon)
Return FindReal("", Parameter)
End Function

Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) as iEnumerable(Of Etat_bon)
Dim Ls As New List(Of Etat_bon)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;  SELECT Etat_bon_code,Etat_bon from Etat_bon"
For Each Par As LUNA.LunaSearchParameter In Parameter
	If Not Par Is Nothing Then
		If Sql.IndexOf("WHERE") = -1 Then Sql &= " WHERE " Else Sql &=  " " & Par.LogicOperatorStr & " "
		Sql &= Par.FieldName & " " & Par.SqlOperator & " " & Ap(Par.Value)
	End if
Next

If OrderBy.Length Then Sql &= " ORDER BY " & OrderBy

myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
while myReader.Read
	Dim classe as new Etat_bon
	if not myReader("Etat_bon_code") is DBNull.Value then classe.Etat_bon_code = myReader("Etat_bon_code")
	if not myReader("Etat_bon") is DBNull.Value then classe.Etat_bon = myReader("Etat_bon")
	Ls.Add(classe)
end while
myReader.Close()
myCommand.Dispose()

Catch ex As Exception
	ManageError(ex)
End Try
Return Ls
End Function

Public Overrides Function GetAll(Optional OrderByField as string = "", Optional ByVal AddEmptyItem As Boolean = False) as iEnumerable(Of Etat_bon)
Dim Ls As New List(Of Etat_bon)
Try

Dim myCommand As SqlCommand = _cn.CreateCommand()
Dim sql As String 
sql ="set language french;SELECT Etat_bon_code,Etat_bon from Etat_bon"
If OrderByField.Length Then
	Sql &= " ORDER BY " & OrderByField
End If

myCommand.CommandText = sql
            'myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
If AddEmptyItem Then Ls.Add(New  Etat_bon() With {.Etat_bon_code = "" ,.Etat_bon = "" })
while myReader.Read
	Dim classe as new Etat_bon
	if not myReader("Etat_bon_code") is DBNull.Value then classe.Etat_bon_code = myReader("Etat_bon_code")
	if not myReader("Etat_bon") is DBNull.Value then classe.Etat_bon = myReader("Etat_bon")
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


