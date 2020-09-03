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

Partial Public Class Client
    Inherits LUNA.LunaBaseClass
    '******IMPORTANT: Write your code in the Class object that use this Partial Class.
    '******So you can replace DAOClass and EntityClass without lost your code

    Public Sub New()

    End Sub

#Region "Database Field Map"

    Private _CLI_Code As String = ""

    <XmlElementAttribute("CLI_Code")>
    Public Property CLI_Code() As String
        Get
            Return _CLI_Code
        End Get
        Set(ByVal value As String)
            _CLI_Code = value
        End Set
    End Property

    Private _CLI_NomPren As String = ""

    <XmlElementAttribute("CLI_NomPren")>
    Public Property CLI_NomPren() As String
        Get
            Return _CLI_NomPren
        End Get
        Set(ByVal value As String)
            _CLI_NomPren = value
        End Set
    End Property

    Private _CLI_MatFisc As String = ""

    <XmlElementAttribute("CLI_MatFisc")>
    Public Property CLI_MatFisc() As String
        Get
            Return _CLI_MatFisc
        End Get
        Set(ByVal value As String)
            _CLI_MatFisc = value
        End Set
    End Property

    Private _CLI_Date_Cre As DateTime = Nothing

    <XmlElementAttribute("CLI_Date_Cre")>
    Public Property CLI_Date_Cre() As DateTime
        Get
            Return _CLI_Date_Cre
        End Get
        Set(ByVal value As DateTime)
            _CLI_Date_Cre = value
        End Set
    End Property

    Private _CLI_Industrielle As Boolean = False

    <XmlElementAttribute("CLI_Industrielle")>
    Public Property CLI_Industrielle() As Boolean
        Get
            Return _CLI_Industrielle
        End Get
        Set(ByVal value As Boolean)
            _CLI_Industrielle = value
        End Set
    End Property

    Private _CLI_Fodec As Integer = 0

    <XmlElementAttribute("CLI_Fodec")>
    Public Property CLI_Fodec() As Integer
        Get
            Return _CLI_Fodec
        End Get
        Set(ByVal value As Integer)
            _CLI_Fodec = value
        End Set
    End Property

    Private _CLI_DC As Integer = 0

    <XmlElementAttribute("CLI_DC")>
    Public Property CLI_DC() As Integer
        Get
            Return _CLI_DC
        End Get
        Set(ByVal value As Integer)
            _CLI_DC = value
        End Set
    End Property

    Private _CLI_Exonoration As String = ""

    <XmlElementAttribute("CLI_Exonoration")>
    Public Property CLI_Exonoration() As String
        Get
            Return _CLI_Exonoration
        End Get
        Set(ByVal value As String)
            _CLI_Exonoration = value
        End Set
    End Property

    Private _CLI_Timbre As Boolean = False

    <XmlElementAttribute("CLI_Timbre")>
    Public Property CLI_Timbre() As Boolean
        Get
            Return _CLI_Timbre
        End Get
        Set(ByVal value As Boolean)
            _CLI_Timbre = value
        End Set
    End Property

    Private _CLI_Solde As Decimal = Nothing

    <XmlElementAttribute("CLI_Solde")>
    Public Property CLI_Solde() As Decimal
        Get
            Return _CLI_Solde
        End Get
        Set(ByVal value As Decimal)
            _CLI_Solde = value
        End Set
    End Property

    Private _CLI_Type As String = ""

    <XmlElementAttribute("CLI_Type")>
    Public Property CLI_Type() As String
        Get
            Return _CLI_Type
        End Get
        Set(ByVal value As String)
            _CLI_Type = value
        End Set
    End Property

    Private _CLI_Etat As String = ""

    <XmlElementAttribute("CLI_Etat")>
    Public Property CLI_Etat() As String
        Get
            Return _CLI_Etat
        End Get
        Set(ByVal value As String)
            _CLI_Etat = value
        End Set
    End Property

    Private _CLI_TauxRemGlob As Decimal = Nothing

    <XmlElementAttribute("CLI_TauxRemGlob")>
    Public Property CLI_TauxRemGlob() As Decimal
        Get
            Return _CLI_TauxRemGlob
        End Get
        Set(ByVal value As Decimal)
            _CLI_TauxRemGlob = value
        End Set
    End Property

    Private _CLI_Localite As String = ""

    <XmlElementAttribute("CLI_Localite")>
    Public Property CLI_Localite() As String
        Get
            Return _CLI_Localite
        End Get
        Set(ByVal value As String)
            _CLI_Localite = value
        End Set
    End Property

    Private _CLI_Adresse As String = ""

    <XmlElementAttribute("CLI_Adresse")>
    Public Property CLI_Adresse() As String
        Get
            Return _CLI_Adresse
        End Get
        Set(ByVal value As String)
            _CLI_Adresse = value
        End Set
    End Property

    Private _CLI_Ville As String = ""

    <XmlElementAttribute("CLI_Ville")>
    Public Property CLI_Ville() As String
        Get
            Return _CLI_Ville
        End Get
        Set(ByVal value As String)
            _CLI_Ville = value
        End Set
    End Property

    Private _CLI_CodePostale As String = ""

    <XmlElementAttribute("CLI_CodePostale")>
    Public Property CLI_CodePostale() As String
        Get
            Return _CLI_CodePostale
        End Get
        Set(ByVal value As String)
            _CLI_CodePostale = value
        End Set
    End Property

    Private _CLI_Tel1 As String = ""

    <XmlElementAttribute("CLI_Tel1")>
    Public Property CLI_Tel1() As String
        Get
            Return _CLI_Tel1
        End Get
        Set(ByVal value As String)
            _CLI_Tel1 = value
        End Set
    End Property

    Private _CLI_Tel2 As String = ""

    <XmlElementAttribute("CLI_Tel2")>
    Public Property CLI_Tel2() As String
        Get
            Return _CLI_Tel2
        End Get
        Set(ByVal value As String)
            _CLI_Tel2 = value
        End Set
    End Property

    Private _CLI_Fax As String = ""

    <XmlElementAttribute("CLI_Fax")>
    Public Property CLI_Fax() As String
        Get
            Return _CLI_Fax
        End Get
        Set(ByVal value As String)
            _CLI_Fax = value
        End Set
    End Property

    Private _CLI_mail As String = ""

    <XmlElementAttribute("CLI_mail")>
    Public Property CLI_mail() As String
        Get
            Return _CLI_mail
        End Get
        Set(ByVal value As String)
            _CLI_mail = value
        End Set
    End Property

    Private _CLI_SiteWeb As String = ""

    <XmlElementAttribute("CLI_SiteWeb")>
    Public Property CLI_SiteWeb() As String
        Get
            Return _CLI_SiteWeb
        End Get
        Set(ByVal value As String)
            _CLI_SiteWeb = value
        End Set
    End Property

    Private _CLI_Obs As String = ""

    <XmlElementAttribute("CLI_Obs")>
    Public Property CLI_Obs() As String
        Get
            Return _CLI_Obs
        End Get
        Set(ByVal value As String)
            _CLI_Obs = value
        End Set
    End Property

    Private _CLI_Station As String = ""

    <XmlElementAttribute("CLI_Station")>
    Public Property CLI_Station() As String
        Get
            Return _CLI_Station
        End Get
        Set(ByVal value As String)
            _CLI_Station = value
        End Set
    End Property

    Private _CLI_User As String = ""

    <XmlElementAttribute("CLI_User")>
    Public Property CLI_User() As String
        Get
            Return _CLI_User
        End Get
        Set(ByVal value As String)
            _CLI_User = value
        End Set
    End Property

    Private _CLI_Pers_Contact As String = ""

    <XmlElementAttribute("CLI_Pers_Contact")>
    Public Property CLI_Pers_Contact() As String
        Get
            Return _CLI_Pers_Contact
        End Get
        Set(ByVal value As String)
            _CLI_Pers_Contact = value
        End Set
    End Property

    Private _CLI_PC_Tel1 As String = ""

    <XmlElementAttribute("CLI_PC_Tel1")>
    Public Property CLI_PC_Tel1() As String
        Get
            Return _CLI_PC_Tel1
        End Get
        Set(ByVal value As String)
            _CLI_PC_Tel1 = value
        End Set
    End Property

    Private _CLI_PC_Tel2 As String = ""

    <XmlElementAttribute("CLI_PC_Tel2")>
    Public Property CLI_PC_Tel2() As String
        Get
            Return _CLI_PC_Tel2
        End Get
        Set(ByVal value As String)
            _CLI_PC_Tel2 = value
        End Set
    End Property

    Private _CLI_PC_Email As String = ""

    <XmlElementAttribute("CLI_PC_Email")>
    Public Property CLI_PC_Email() As String
        Get
            Return _CLI_PC_Email
        End Get
        Set(ByVal value As String)
            _CLI_PC_Email = value
        End Set
    End Property

    Private _CLI_Exo_Num As String = ""

    <XmlElementAttribute("CLI_Exo_Num")>
    Public Property CLI_Exo_Num() As String
        Get
            Return _CLI_Exo_Num
        End Get
        Set(ByVal value As String)
            _CLI_Exo_Num = value
        End Set
    End Property

    Private _CLI_Exo_Valable As DateTime = Nothing

    <XmlElementAttribute("CLI_Exo_Valable")>
    Public Property CLI_Exo_Valable() As DateTime
        Get
            Return _CLI_Exo_Valable
        End Get
        Set(ByVal value As DateTime)
            _CLI_Exo_Valable = value
        End Set
    End Property

    Private _CLI_Type_Reg As String = ""

    <XmlElementAttribute("CLI_Type_Reg")>
    Public Property CLI_Type_Reg() As String
        Get
            Return _CLI_Type_Reg
        End Get
        Set(ByVal value As String)
            _CLI_Type_Reg = value
        End Set
    End Property

    Private _CLI_Exeno As Boolean = False

    <XmlElementAttribute("CLI_Exeno")>
    Public Property CLI_Exeno() As Boolean
        Get
            Return _CLI_Exeno
        End Get
        Set(ByVal value As Boolean)
            _CLI_Exeno = value
        End Set
    End Property

    Private _CLI_ValiditeTraite As String = ""

    <XmlElementAttribute("CLI_ValiditeTraite")>
    Public Property CLI_ValiditeTraite() As String
        Get
            Return _CLI_ValiditeTraite
        End Get
        Set(ByVal value As String)
            _CLI_ValiditeTraite = value
        End Set
    End Property

    Private _CLI_CodeRep As Integer = 0

    <XmlElementAttribute("CLI_CodeRep")>
    Public Property CLI_CodeRep() As Integer
        Get
            Return _CLI_CodeRep
        End Get
        Set(ByVal value As Integer)
            _CLI_CodeRep = value
        End Set
    End Property

    Private _CLI_export As Boolean = False

    <XmlElementAttribute("CLI_export")>
    Public Property CLI_export() As Boolean
        Get
            Return _CLI_export
        End Get
        Set(ByVal value As Boolean)
            _CLI_export = value
        End Set
    End Property

    Private _CLI_DDm As DateTime = Nothing

    <XmlElementAttribute("CLI_DDm")>
    Public Property CLI_DDm() As DateTime
        Get
            Return _CLI_DDm
        End Get
        Set(ByVal value As DateTime)
            _CLI_DDm = value
        End Set
    End Property

    Private _CLI_Forfetaire As Boolean = False

    <XmlElementAttribute("CLI_Forfetaire")>
    Public Property CLI_Forfetaire() As Boolean
        Get
            Return _CLI_Forfetaire
        End Get
        Set(ByVal value As Boolean)
            _CLI_Forfetaire = value
        End Set
    End Property

    Private _Cli_Debit As Decimal = Nothing

    <XmlElementAttribute("Cli_Debit")>
    Public Property Cli_Debit() As Decimal
        Get
            Return _Cli_Debit
        End Get
        Set(ByVal value As Decimal)
            _Cli_Debit = value
        End Set
    End Property

    Private _Cli_Credit As Decimal = Nothing

    <XmlElementAttribute("Cli_Credit")>
    Public Property Cli_Credit() As Decimal
        Get
            Return _Cli_Credit
        End Get
        Set(ByVal value As Decimal)
            _Cli_Credit = value
        End Set
    End Property

    Private _Cli_EX As String = ""

    <XmlElementAttribute("Cli_EX")>
    Public Property Cli_EX() As String
        Get
            Return _Cli_EX
        End Get
        Set(ByVal value As String)
            _Cli_EX = value
        End Set
    End Property

    Private _Num_Fidelite As String = ""

    <XmlElementAttribute("Num_Fidelite")>
    Public Property Num_Fidelite() As String
        Get
            Return _Num_Fidelite
        End Get
        Set(ByVal value As String)
            _Num_Fidelite = value
        End Set
    End Property

    Private _Clt_Fidelite As Boolean = False

    <XmlElementAttribute("Clt_Fidelite")>
    Public Property Clt_Fidelite() As Boolean
        Get
            Return _Clt_Fidelite
        End Get
        Set(ByVal value As Boolean)
            _Clt_Fidelite = value
        End Set
    End Property

    Private _Clt_Epoux As String = ""

    <XmlElementAttribute("Clt_Epoux")>
    Public Property Clt_Epoux() As String
        Get
            Return _Clt_Epoux
        End Get
        Set(ByVal value As String)
            _Clt_Epoux = value
        End Set
    End Property

    Private _Clt_Epouse As String = ""

    <XmlElementAttribute("Clt_Epouse")>
    Public Property Clt_Epouse() As String
        Get
            Return _Clt_Epouse
        End Get
        Set(ByVal value As String)
            _Clt_Epouse = value
        End Set
    End Property

    Private _Clt_Epouse_Tel As String = ""

    <XmlElementAttribute("Clt_Epouse_Tel")>
    Public Property Clt_Epouse_Tel() As String
        Get
            Return _Clt_Epouse_Tel
        End Get
        Set(ByVal value As String)
            _Clt_Epouse_Tel = value
        End Set
    End Property

    Private _Clt_Epoux_Tel As String = ""

    <XmlElementAttribute("Clt_Epoux_Tel")>
    Public Property Clt_Epoux_Tel() As String
        Get
            Return _Clt_Epoux_Tel
        End Get
        Set(ByVal value As String)
            _Clt_Epoux_Tel = value
        End Set
    End Property

    Private _Clt_CIN_ville As String = ""

    <XmlElementAttribute("Clt_CIN_ville")>
    Public Property Clt_CIN_ville() As String
        Get
            Return _Clt_CIN_ville
        End Get
        Set(ByVal value As String)
            _Clt_CIN_ville = value
        End Set
    End Property

    Private _Clt_CIN_Date As DateTime = Nothing

    <XmlElementAttribute("Clt_CIN_Date")>
    Public Property Clt_CIN_Date() As DateTime

        Get
            Return _Clt_CIN_Date
        End Get
        Set(ByVal value As DateTime)
            _Clt_CIN_Date = value
        End Set
    End Property

    Private _Clt_CIN As String = ""

    <XmlElementAttribute("Clt_CIN")>
    Public Property Clt_CIN() As String
        Get
            Return _Clt_CIN
        End Get
        Set(ByVal value As String)
            _Clt_CIN = value
        End Set
    End Property
#End Region

#Region "Embedded Class"

#End Region

End Class

Partial Public Class ClientDAO
    Inherits LUNA.LunaBaseClassDAO(Of Client)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Connection As Data.SqlClient.SqlConnection)
        MyBase.New(Connection)
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        MyBase.New(ConnectionString)
    End Sub

    Private Shared Utilisateur As New ClientDAO
    Public Shared Function getInstance() As ClientDAO
        If IsNothing(Utilisateur) Then
            Return New ClientDAO
        Else

            Return Utilisateur

        End If

    End Function

    Public Overrides Function Read(Id As String) As Client
        Dim cls As New Client

        Try
            Dim myCommand As SqlCommand = _cn.CreateCommand()
            myCommand.CommandText = "set language french;SELECT * FROM Client where CLI_Code = " & Ap(Id)
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Read()
            If myReader.HasRows Then
                cls.CLI_Code = myReader("CLI_Code")
                cls.CLI_NomPren = myReader("CLI_NomPren")
                If Not myReader("CLI_MatFisc") Is DBNull.Value Then
                    cls.CLI_MatFisc = myReader("CLI_MatFisc")
                End If
                If Not myReader("CLI_Date_Cre") Is DBNull.Value Then
                    cls.CLI_Date_Cre = myReader("CLI_Date_Cre")
                End If
                If Not myReader("CLI_Industrielle") Is DBNull.Value Then
                    cls.CLI_Industrielle = myReader("CLI_Industrielle")
                End If
                If Not myReader("CLI_Fodec") Is DBNull.Value Then
                    cls.CLI_Fodec = myReader("CLI_Fodec")
                End If
                If Not myReader("CLI_DC") Is DBNull.Value Then
                    cls.CLI_DC = myReader("CLI_DC")
                End If
                If Not myReader("CLI_Exonoration") Is DBNull.Value Then
                    cls.CLI_Exonoration = myReader("CLI_Exonoration")
                End If
                If Not myReader("CLI_Timbre") Is DBNull.Value Then
                    cls.CLI_Timbre = myReader("CLI_Timbre")
                End If
                If Not myReader("CLI_Solde") Is DBNull.Value Then
                    cls.CLI_Solde = myReader("CLI_Solde")
                End If
                If Not myReader("CLI_Type") Is DBNull.Value Then
                    cls.CLI_Type = myReader("CLI_Type")
                End If
                If Not myReader("CLI_Etat") Is DBNull.Value Then
                    cls.CLI_Etat = myReader("CLI_Etat")
                End If
                If Not myReader("CLI_TauxRemGlob") Is DBNull.Value Then
                    cls.CLI_TauxRemGlob = myReader("CLI_TauxRemGlob")
                End If
                If Not myReader("CLI_Localite") Is DBNull.Value Then
                    cls.CLI_Localite = myReader("CLI_Localite")
                End If
                If Not myReader("CLI_Adresse") Is DBNull.Value Then
                    cls.CLI_Adresse = myReader("CLI_Adresse")
                End If
                If Not myReader("CLI_Ville") Is DBNull.Value Then
                    cls.CLI_Ville = myReader("CLI_Ville")
                End If
                If Not myReader("CLI_CodePostale") Is DBNull.Value Then
                    cls.CLI_CodePostale = myReader("CLI_CodePostale")
                End If
                If Not myReader("CLI_Tel1") Is DBNull.Value Then
                    cls.CLI_Tel1 = myReader("CLI_Tel1")
                End If
                If Not myReader("CLI_Tel2") Is DBNull.Value Then
                    cls.CLI_Tel2 = myReader("CLI_Tel2")
                End If
                If Not myReader("CLI_Fax") Is DBNull.Value Then
                    cls.CLI_Fax = myReader("CLI_Fax")
                End If
                If Not myReader("CLI_mail") Is DBNull.Value Then
                    cls.CLI_mail = myReader("CLI_mail")
                End If
                If Not myReader("CLI_SiteWeb") Is DBNull.Value Then
                    cls.CLI_SiteWeb = myReader("CLI_SiteWeb")
                End If
                If Not myReader("CLI_Obs") Is DBNull.Value Then
                    cls.CLI_Obs = myReader("CLI_Obs")
                End If
                If Not myReader("CLI_Station") Is DBNull.Value Then
                    cls.CLI_Station = myReader("CLI_Station")
                End If
                If Not myReader("CLI_User") Is DBNull.Value Then
                    cls.CLI_User = myReader("CLI_User")
                End If
                If Not myReader("CLI_Pers_Contact") Is DBNull.Value Then
                    cls.CLI_Pers_Contact = myReader("CLI_Pers_Contact")
                End If
                If Not myReader("CLI_PC_Tel1") Is DBNull.Value Then
                    cls.CLI_PC_Tel1 = myReader("CLI_PC_Tel1")
                End If
                If Not myReader("CLI_PC_Tel2") Is DBNull.Value Then
                    cls.CLI_PC_Tel2 = myReader("CLI_PC_Tel2")
                End If
                If Not myReader("CLI_PC_Email") Is DBNull.Value Then
                    cls.CLI_PC_Email = myReader("CLI_PC_Email")
                End If
                If Not myReader("CLI_Exo_Num") Is DBNull.Value Then
                    cls.CLI_Exo_Num = myReader("CLI_Exo_Num")
                End If
                If Not myReader("CLI_Exo_Valable") Is DBNull.Value Then
                    cls.CLI_Exo_Valable = myReader("CLI_Exo_Valable")
                End If
                If Not myReader("CLI_Type_Reg") Is DBNull.Value Then
                    cls.CLI_Type_Reg = myReader("CLI_Type_Reg")
                End If
                If Not myReader("CLI_Exeno") Is DBNull.Value Then
                    cls.CLI_Exeno = myReader("CLI_Exeno")
                End If
                If Not myReader("CLI_ValiditeTraite") Is DBNull.Value Then
                    cls.CLI_ValiditeTraite = myReader("CLI_ValiditeTraite")
                End If
                If Not myReader("CLI_CodeRep") Is DBNull.Value Then
                    cls.CLI_CodeRep = myReader("CLI_CodeRep")
                End If
                If Not myReader("CLI_export") Is DBNull.Value Then
                    cls.CLI_export = myReader("CLI_export")
                End If
                If Not myReader("CLI_DDm") Is DBNull.Value Then
                    cls.CLI_DDm = myReader("CLI_DDm")
                End If
                If Not myReader("CLI_Forfetaire") Is DBNull.Value Then
                    cls.CLI_Forfetaire = myReader("CLI_Forfetaire")
                End If
                If Not myReader("Cli_Debit") Is DBNull.Value Then
                    cls.Cli_Debit = myReader("Cli_Debit")
                End If
                If Not myReader("Cli_Credit") Is DBNull.Value Then
                    cls.Cli_Credit = myReader("Cli_Credit")
                End If
                If Not myReader("Cli_EX") Is DBNull.Value Then
                    cls.Cli_EX = myReader("Cli_EX")
                End If
                If Not myReader("Num_Fidelite") Is DBNull.Value Then
                    cls.Num_Fidelite = myReader("Num_Fidelite")
                End If
                If Not myReader("Clt_Fidelite") Is DBNull.Value Then
                    cls.Clt_Fidelite = myReader("Clt_Fidelite")
                End If
                If Not myReader("Clt_Epoux") Is DBNull.Value Then
                    cls.Clt_Epoux = myReader("Clt_Epoux")
                End If
                If Not myReader("Clt_Epouse") Is DBNull.Value Then
                    cls.Clt_Epouse = myReader("Clt_Epouse")
                End If
                If Not myReader("Clt_Epouse_Tel") Is DBNull.Value Then
                    cls.Clt_Epouse_Tel = myReader("Clt_Epouse_Tel")
                End If
                If Not myReader("Clt_Epoux_Tel") Is DBNull.Value Then
                    cls.Clt_Epoux_Tel = myReader("Clt_Epoux_Tel")
                End If
                If Not myReader("Clt_CIN_ville") Is DBNull.Value Then
                    cls.Clt_CIN_ville = myReader("Clt_CIN_ville")
                End If
                If Not myReader("Clt_CIN_Date") Is DBNull.Value Then
                    cls.Clt_CIN_Date = myReader("Clt_CIN_Date")
                End If
                If Not myReader("Clt_CIN") Is DBNull.Value Then
                    cls.Clt_CIN = myReader("Clt_CIN")
                End If
            End If
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return cls
    End Function


    Public Overrides Function Save(ByRef cls As Client) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;INSERT INTO Client("
            sql &= "CLI_Code,"
            sql &= "CLI_NomPren,"
            sql &= "CLI_MatFisc,"
            sql &= "CLI_Date_Cre,"
            sql &= "CLI_Industrielle,"
            sql &= "CLI_Fodec,"
            sql &= "CLI_DC,"
            sql &= "CLI_Exonoration,"
            sql &= "CLI_Timbre,"
            sql &= "CLI_Solde,"
            sql &= "CLI_Type,"
            sql &= "CLI_Etat,"
            sql &= "CLI_TauxRemGlob,"
            sql &= "CLI_Localite,"
            sql &= "CLI_Adresse,"
            sql &= "CLI_Ville,"
            sql &= "CLI_CodePostale,"
            sql &= "CLI_Tel1,"
            sql &= "CLI_Tel2,"
            sql &= "CLI_Fax,"
            sql &= "CLI_mail,"
            sql &= "CLI_SiteWeb,"
            sql &= "CLI_Obs,"
            sql &= "CLI_Station,"
            sql &= "CLI_User,"
            sql &= "CLI_Pers_Contact,"
            sql &= "CLI_PC_Tel1,"
            sql &= "CLI_PC_Tel2,"
            sql &= "CLI_PC_Email,"
            sql &= "CLI_Exo_Num,"
            sql &= "CLI_Exo_Valable,"
            sql &= "CLI_Type_Reg,"
            sql &= "CLI_Exeno,"
            sql &= "CLI_ValiditeTraite,"
            sql &= "CLI_CodeRep,"
            sql &= "CLI_export,"
            sql &= "CLI_DDm,"
            sql &= "CLI_Forfetaire,"
            sql &= "Cli_Debit,"
            sql &= "Cli_Credit,"
            sql &= "Cli_EX,"
            sql &= "Num_Fidelite,"
            sql &= "Clt_Fidelite,"
            sql &= "Clt_Epoux,"
            sql &= "Clt_Epouse,"
            sql &= "Clt_Epouse_Tel,"
            sql &= "Clt_Epoux_Tel,"
            sql &= "Clt_CIN_ville,"
            sql &= "Clt_CIN_Date,"
            sql &= "Clt_CIN"
            sql &= ") VALUES ("
            sql &= Ap(cls.CLI_Code) & ","
            sql &= Ap(cls.CLI_NomPren) & ","
            sql &= Ap(cls.CLI_MatFisc) & ","
            sql &= Ap(cls.CLI_Date_Cre) & ","
            sql &= IIf(cls.CLI_Industrielle, -1, 0) & ","
            sql &= Ap(cls.CLI_Fodec) & ","
            sql &= Ap(cls.CLI_DC) & ","
            sql &= Ap(cls.CLI_Exonoration) & ","
            sql &= IIf(cls.CLI_Timbre, -1, 0) & ","
            sql &= Ap(cls.CLI_Solde) & ","
            sql &= Ap(cls.CLI_Type) & ","
            sql &= Ap(cls.CLI_Etat) & ","
            sql &= Ap(cls.CLI_TauxRemGlob) & ","
            sql &= Ap(cls.CLI_Localite) & ","
            sql &= Ap(cls.CLI_Adresse) & ","
            sql &= Ap(cls.CLI_Ville) & ","
            sql &= Ap(cls.CLI_CodePostale) & ","
            sql &= Ap(cls.CLI_Tel1) & ","
            sql &= Ap(cls.CLI_Tel2) & ","
            sql &= Ap(cls.CLI_Fax) & ","
            sql &= Ap(cls.CLI_mail) & ","
            sql &= Ap(cls.CLI_SiteWeb) & ","
            sql &= Ap(cls.CLI_Obs) & ","
            sql &= Ap(cls.CLI_Station) & ","
            sql &= Ap(cls.CLI_User) & ","
            sql &= Ap(cls.CLI_Pers_Contact) & ","
            sql &= Ap(cls.CLI_PC_Tel1) & ","
            sql &= Ap(cls.CLI_PC_Tel2) & ","
            sql &= Ap(cls.CLI_PC_Email) & ","
            sql &= Ap(cls.CLI_Exo_Num) & ","
            sql &= Ap(cls.CLI_Exo_Valable) & ","
            sql &= Ap(cls.CLI_Type_Reg) & ","
            sql &= IIf(cls.CLI_Exeno, -1, 0) & ","
            sql &= Ap(cls.CLI_ValiditeTraite) & ","
            sql &= Ap(cls.CLI_CodeRep) & ","
            sql &= IIf(cls.CLI_export, -1, 0) & ","
            sql &= Ap(cls.CLI_DDm) & ","
            sql &= IIf(cls.CLI_Forfetaire, -1, 0) & ","
            sql &= Ap(cls.Cli_Debit) & ","
            sql &= Ap(cls.Cli_Credit) & ","
            sql &= Ap(cls.Cli_EX) & ","
            sql &= Ap(cls.Num_Fidelite) & ","
            sql &= IIf(cls.Clt_Fidelite, -1, 0) & ","
            sql &= Ap(cls.Clt_Epoux) & ","
            sql &= Ap(cls.Clt_Epouse) & ","
            sql &= Ap(cls.Clt_Epouse_Tel) & ","
            sql &= Ap(cls.Clt_Epoux_Tel) & ","
            sql &= Ap(cls.Clt_CIN_ville) & ","
            sql &= Ap(cls.Clt_CIN_Date) & ","
            sql &= Ap(cls.Clt_CIN)
            sql &= ")"
            DbCommand.CommandText = sql
            DbCommand.ExecuteNonQuery()

            DbCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ris
    End Function


    Public Function Update(ByRef cls As Client) As Integer

        Dim Ris As Integer = 0 'in Ris torno l'id inserito

        Dim DbCommand As SqlCommand = New SqlCommand()
        Try
            Dim sql As String
            DbCommand.Connection = _cn
            'DbCommand.Transaction = myTransaction
            sql = "set language french;UPDATE Client SET "
            sql &= "CLI_NomPren = " & Ap(cls.CLI_NomPren) & ","
            sql &= "CLI_MatFisc = " & Ap(cls.CLI_MatFisc) & ","
            sql &= "CLI_Date_Cre = " & Ap(cls.CLI_Date_Cre) & ","
            sql &= "CLI_Industrielle = " & IIf(cls.CLI_Industrielle, "'true'", "'False'") & ","
            sql &= "CLI_Fodec = " & Ap(cls.CLI_Fodec) & ","
            sql &= "CLI_DC = " & Ap(cls.CLI_DC) & ","
            sql &= "CLI_Exonoration = " & Ap(cls.CLI_Exonoration) & ","
            sql &= "CLI_Timbre = " & IIf(cls.CLI_Timbre, "'true'", "'False'") & ","
            sql &= "CLI_Solde = " & Ap(cls.CLI_Solde) & ","
            sql &= "CLI_Type = " & Ap(cls.CLI_Type) & ","
            sql &= "CLI_Etat = " & Ap(cls.CLI_Etat) & ","
            sql &= "CLI_TauxRemGlob = " & Ap(cls.CLI_TauxRemGlob) & ","
            sql &= "CLI_Localite = " & Ap(cls.CLI_Localite) & ","
            sql &= "CLI_Adresse = " & Ap(cls.CLI_Adresse) & ","
            sql &= "CLI_Ville = " & Ap(cls.CLI_Ville) & ","
            sql &= "CLI_CodePostale = " & Ap(cls.CLI_CodePostale) & ","
            sql &= "CLI_Tel1 = " & Ap(cls.CLI_Tel1) & ","
            sql &= "CLI_Tel2 = " & Ap(cls.CLI_Tel2) & ","
            sql &= "CLI_Fax = " & Ap(cls.CLI_Fax) & ","
            sql &= "CLI_mail = " & Ap(cls.CLI_mail) & ","
            sql &= "CLI_SiteWeb = " & Ap(cls.CLI_SiteWeb) & ","
            sql &= "CLI_Obs = " & Ap(cls.CLI_Obs) & ","
            sql &= "CLI_Station = " & Ap(cls.CLI_Station) & ","
            sql &= "CLI_User = " & Ap(cls.CLI_User) & ","
            sql &= "CLI_Pers_Contact = " & Ap(cls.CLI_Pers_Contact) & ","
            sql &= "CLI_PC_Tel1 = " & Ap(cls.CLI_PC_Tel1) & ","
            sql &= "CLI_PC_Tel2 = " & Ap(cls.CLI_PC_Tel2) & ","
            sql &= "CLI_PC_Email = " & Ap(cls.CLI_PC_Email) & ","
            sql &= "CLI_Exo_Num = " & Ap(cls.CLI_Exo_Num) & ","
            sql &= "CLI_Exo_Valable = " & Ap(cls.CLI_Exo_Valable) & ","
            sql &= "CLI_Type_Reg = " & Ap(cls.CLI_Type_Reg) & ","
            sql &= "CLI_Exeno = " & IIf(cls.CLI_Exeno, "'true'", "'False'") & ","
            sql &= "CLI_ValiditeTraite = " & Ap(cls.CLI_ValiditeTraite) & ","
            sql &= "CLI_CodeRep = " & Ap(cls.CLI_CodeRep) & ","
            sql &= "CLI_export = " & IIf(cls.CLI_export, "'true'", "'False'") & ","
            sql &= "CLI_DDm = " & Ap(cls.CLI_DDm) & ","
            sql &= "CLI_Forfetaire = " & IIf(cls.CLI_Forfetaire, "'true'", "'False'") & ","
            sql &= "Cli_Debit = " & Ap(cls.Cli_Debit) & ","
            sql &= "Cli_Credit = " & Ap(cls.Cli_Credit) & ","
            sql &= "Cli_EX = " & Ap(cls.Cli_EX) & ","
            sql &= "Num_Fidelite = " & Ap(cls.Num_Fidelite) & ","
            sql &= "Clt_Fidelite = " & IIf(cls.Clt_Fidelite, "'true'", "'False'") & ","
            sql &= "Clt_Epoux = " & Ap(cls.Clt_Epoux) & ","
            sql &= "Clt_Epouse = " & Ap(cls.Clt_Epouse) & ","
            sql &= "Clt_Epouse_Tel = " & Ap(cls.Clt_Epouse_Tel) & ","
            sql &= "Clt_Epoux_Tel = " & Ap(cls.Clt_Epoux_Tel) & ","
            sql &= "Clt_CIN_ville = " & Ap(cls.Clt_CIN_ville) & ","
            sql &= "Clt_CIN_Date = " & Ap(cls.Clt_CIN_Date) & ","
            sql &= "Clt_CIN = " & Ap(cls.Clt_CIN)
            sql &= " WHERE CLI_Code= " & Ap(cls.CLI_Code)
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
            'Dim Sql As String = "UPDATE Client SET DELETED=True "
            Dim Sql As String = "set language french;DELETE FROM Client"
            Sql &= " Where CLI_Code = " & Ap(Id)

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

    Public Overrides Sub Delete(ByRef obj As Client, Optional ByRef ListaObj As List(Of Client) = Nothing)

        DestroyPermanently(obj.CLI_Code)
        If Not ListaObj Is Nothing Then ListaObj.Remove(obj)

    End Sub

    Public Overloads Function Find(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Client)
        Return FindReal(OrderBy, Parameter)
    End Function

    Public Overrides Function Find(ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Client)
        Return FindReal("", Parameter)
    End Function

    Private Function FindReal(ByVal OrderBy As String, ByVal ParamArray Parameter() As LUNA.LunaSearchParameter) As IEnumerable(Of Client)
        Dim Ls As New List(Of Client)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;  SELECT CLI_Code,CLI_NomPren,CLI_MatFisc,CLI_Date_Cre,CLI_Industrielle,CLI_Fodec,CLI_DC,CLI_Exonoration,CLI_Timbre,CLI_Solde,CLI_Type,CLI_Etat,CLI_TauxRemGlob,CLI_Localite,CLI_Adresse,CLI_Ville,CLI_CodePostale,CLI_Tel1,CLI_Tel2,CLI_Fax,CLI_mail,CLI_SiteWeb,CLI_Obs,CLI_Station,CLI_User,CLI_Pers_Contact,CLI_PC_Tel1,CLI_PC_Tel2,CLI_PC_Email,CLI_Exo_Num,CLI_Exo_Valable,CLI_Type_Reg,CLI_Exeno,CLI_ValiditeTraite,CLI_CodeRep,CLI_export,CLI_DDm,CLI_Forfetaire,Cli_Debit,Cli_Credit,Cli_EX,Num_Fidelite,Clt_Fidelite,Clt_Epoux,Clt_Epouse,Clt_Epouse_Tel,Clt_Epoux_Tel,Clt_CIN_ville,Clt_CIN_Date,Clt_CIN from Client"
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
                Dim classe As New Client
                If Not myReader("CLI_Code") Is DBNull.Value Then classe.CLI_Code = myReader("CLI_Code")
                If Not myReader("CLI_NomPren") Is DBNull.Value Then classe.CLI_NomPren = myReader("CLI_NomPren")
                If Not myReader("CLI_MatFisc") Is DBNull.Value Then classe.CLI_MatFisc = myReader("CLI_MatFisc")
                If Not myReader("CLI_Date_Cre") Is DBNull.Value Then classe.CLI_Date_Cre = myReader("CLI_Date_Cre")
                If Not myReader("CLI_Industrielle") Is DBNull.Value Then classe.CLI_Industrielle = myReader("CLI_Industrielle")
                If Not myReader("CLI_Fodec") Is DBNull.Value Then classe.CLI_Fodec = myReader("CLI_Fodec")
                If Not myReader("CLI_DC") Is DBNull.Value Then classe.CLI_DC = myReader("CLI_DC")
                If Not myReader("CLI_Exonoration") Is DBNull.Value Then classe.CLI_Exonoration = myReader("CLI_Exonoration")
                If Not myReader("CLI_Timbre") Is DBNull.Value Then classe.CLI_Timbre = myReader("CLI_Timbre")
                If Not myReader("CLI_Solde") Is DBNull.Value Then classe.CLI_Solde = myReader("CLI_Solde")
                If Not myReader("CLI_Type") Is DBNull.Value Then classe.CLI_Type = myReader("CLI_Type")
                If Not myReader("CLI_Etat") Is DBNull.Value Then classe.CLI_Etat = myReader("CLI_Etat")
                If Not myReader("CLI_TauxRemGlob") Is DBNull.Value Then classe.CLI_TauxRemGlob = myReader("CLI_TauxRemGlob")
                If Not myReader("CLI_Localite") Is DBNull.Value Then classe.CLI_Localite = myReader("CLI_Localite")
                If Not myReader("CLI_Adresse") Is DBNull.Value Then classe.CLI_Adresse = myReader("CLI_Adresse")
                If Not myReader("CLI_Ville") Is DBNull.Value Then classe.CLI_Ville = myReader("CLI_Ville")
                If Not myReader("CLI_CodePostale") Is DBNull.Value Then classe.CLI_CodePostale = myReader("CLI_CodePostale")
                If Not myReader("CLI_Tel1") Is DBNull.Value Then classe.CLI_Tel1 = myReader("CLI_Tel1")
                If Not myReader("CLI_Tel2") Is DBNull.Value Then classe.CLI_Tel2 = myReader("CLI_Tel2")
                If Not myReader("CLI_Fax") Is DBNull.Value Then classe.CLI_Fax = myReader("CLI_Fax")
                If Not myReader("CLI_mail") Is DBNull.Value Then classe.CLI_mail = myReader("CLI_mail")
                If Not myReader("CLI_SiteWeb") Is DBNull.Value Then classe.CLI_SiteWeb = myReader("CLI_SiteWeb")
                If Not myReader("CLI_Obs") Is DBNull.Value Then classe.CLI_Obs = myReader("CLI_Obs")
                If Not myReader("CLI_Station") Is DBNull.Value Then classe.CLI_Station = myReader("CLI_Station")
                If Not myReader("CLI_User") Is DBNull.Value Then classe.CLI_User = myReader("CLI_User")
                If Not myReader("CLI_Pers_Contact") Is DBNull.Value Then classe.CLI_Pers_Contact = myReader("CLI_Pers_Contact")
                If Not myReader("CLI_PC_Tel1") Is DBNull.Value Then classe.CLI_PC_Tel1 = myReader("CLI_PC_Tel1")
                If Not myReader("CLI_PC_Tel2") Is DBNull.Value Then classe.CLI_PC_Tel2 = myReader("CLI_PC_Tel2")
                If Not myReader("CLI_PC_Email") Is DBNull.Value Then classe.CLI_PC_Email = myReader("CLI_PC_Email")
                If Not myReader("CLI_Exo_Num") Is DBNull.Value Then classe.CLI_Exo_Num = myReader("CLI_Exo_Num")
                If Not myReader("CLI_Exo_Valable") Is DBNull.Value Then classe.CLI_Exo_Valable = myReader("CLI_Exo_Valable")
                If Not myReader("CLI_Type_Reg") Is DBNull.Value Then classe.CLI_Type_Reg = myReader("CLI_Type_Reg")
                If Not myReader("CLI_Exeno") Is DBNull.Value Then classe.CLI_Exeno = myReader("CLI_Exeno")
                If Not myReader("CLI_ValiditeTraite") Is DBNull.Value Then classe.CLI_ValiditeTraite = myReader("CLI_ValiditeTraite")
                If Not myReader("CLI_CodeRep") Is DBNull.Value Then classe.CLI_CodeRep = myReader("CLI_CodeRep")
                If Not myReader("CLI_export") Is DBNull.Value Then classe.CLI_export = myReader("CLI_export")
                If Not myReader("CLI_DDm") Is DBNull.Value Then classe.CLI_DDm = myReader("CLI_DDm")
                If Not myReader("CLI_Forfetaire") Is DBNull.Value Then classe.CLI_Forfetaire = myReader("CLI_Forfetaire")
                If Not myReader("Cli_Debit") Is DBNull.Value Then classe.Cli_Debit = myReader("Cli_Debit")
                If Not myReader("Cli_Credit") Is DBNull.Value Then classe.Cli_Credit = myReader("Cli_Credit")
                If Not myReader("Cli_EX") Is DBNull.Value Then classe.Cli_EX = myReader("Cli_EX")
                If Not myReader("Num_Fidelite") Is DBNull.Value Then classe.Num_Fidelite = myReader("Num_Fidelite")
                If Not myReader("Clt_Fidelite") Is DBNull.Value Then classe.Clt_Fidelite = myReader("Clt_Fidelite")
                If Not myReader("Clt_Epoux") Is DBNull.Value Then classe.Clt_Epoux = myReader("Clt_Epoux")
                If Not myReader("Clt_Epouse") Is DBNull.Value Then classe.Clt_Epouse = myReader("Clt_Epouse")
                If Not myReader("Clt_Epouse_Tel") Is DBNull.Value Then classe.Clt_Epouse_Tel = myReader("Clt_Epouse_Tel")
                If Not myReader("Clt_Epoux_Tel") Is DBNull.Value Then classe.Clt_Epoux_Tel = myReader("Clt_Epoux_Tel")
                If Not myReader("Clt_CIN_ville") Is DBNull.Value Then classe.Clt_CIN_ville = myReader("Clt_CIN_ville")
                If Not myReader("Clt_CIN_Date") Is DBNull.Value Then classe.Clt_CIN_Date = myReader("Clt_CIN_Date")
                If Not myReader("Clt_CIN") Is DBNull.Value Then classe.Clt_CIN = myReader("Clt_CIN")
                Ls.Add(classe)
            End While
            myReader.Close()
            myCommand.Dispose()

        Catch ex As Exception
            ManageError(ex)
        End Try
        Return Ls
    End Function

    Public Overrides Function GetAll(Optional OrderByField As String = "", Optional ByVal AddEmptyItem As Boolean = False) As IEnumerable(Of Client)
        Dim Ls As New List(Of Client)
        Try

            Dim myCommand As SqlCommand = _cn.CreateCommand()
            Dim sql As String
            sql = "set language french;SELECT CLI_Code,CLI_NomPren,CLI_MatFisc,CLI_Date_Cre,CLI_Industrielle,CLI_Fodec,CLI_DC,CLI_Exonoration,CLI_Timbre,CLI_Solde,CLI_Type,CLI_Etat,CLI_TauxRemGlob,CLI_Localite,CLI_Adresse,CLI_Ville,CLI_CodePostale,CLI_Tel1,CLI_Tel2,CLI_Fax,CLI_mail,CLI_SiteWeb,CLI_Obs,CLI_Station,CLI_User,CLI_Pers_Contact,CLI_PC_Tel1,CLI_PC_Tel2,CLI_PC_Email,CLI_Exo_Num,CLI_Exo_Valable,CLI_Type_Reg,CLI_Exeno,CLI_ValiditeTraite,CLI_CodeRep,CLI_export,CLI_DDm,CLI_Forfetaire,Cli_Debit,Cli_Credit,Cli_EX,Num_Fidelite,Clt_Fidelite,Clt_Epoux,Clt_Epouse,Clt_Epouse_Tel,Clt_Epoux_Tel,Clt_CIN_ville,Clt_CIN_Date,Clt_CIN from Client"
            If OrderByField.Length Then
                sql &= " ORDER BY " & OrderByField
            End If

            myCommand.CommandText = sql
            ' myCommand.Transaction = myTransaction
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            If AddEmptyItem Then Ls.Add(New Client() With {.CLI_Code = "", .CLI_NomPren = "", .CLI_MatFisc = "", .CLI_Date_Cre = Nothing, .CLI_Industrielle = False, .CLI_Fodec = 0, .CLI_DC = 0, .CLI_Exonoration = "", .CLI_Timbre = False, .CLI_Solde = Nothing, .CLI_Type = "", .CLI_Etat = "", .CLI_TauxRemGlob = Nothing, .CLI_Localite = "", .CLI_Adresse = "", .CLI_Ville = "", .CLI_CodePostale = "", .CLI_Tel1 = "", .CLI_Tel2 = "", .CLI_Fax = "", .CLI_mail = "", .CLI_SiteWeb = "", .CLI_Obs = "", .CLI_Station = "", .CLI_User = "", .CLI_Pers_Contact = "", .CLI_PC_Tel1 = "", .CLI_PC_Tel2 = "", .CLI_PC_Email = "", .CLI_Exo_Num = "", .CLI_Exo_Valable = Nothing, .CLI_Type_Reg = "", .CLI_Exeno = False, .CLI_ValiditeTraite = "", .CLI_CodeRep = 0, .CLI_export = False, .CLI_DDm = Nothing, .CLI_Forfetaire = False, .Cli_Debit = Nothing, .Cli_Credit = Nothing, .Cli_EX = "", .Num_Fidelite = "", .Clt_Fidelite = False, .Clt_Epoux = "", .Clt_Epouse = "", .Clt_Epouse_Tel = "", .Clt_Epoux_Tel = "", .Clt_CIN_ville = "", .Clt_CIN_Date = Nothing, .Clt_CIN = ""})
            While myReader.Read
                Dim classe As New Client
                If Not myReader("CLI_Code") Is DBNull.Value Then classe.CLI_Code = myReader("CLI_Code")
                If Not myReader("CLI_NomPren") Is DBNull.Value Then classe.CLI_NomPren = myReader("CLI_NomPren")
                If Not myReader("CLI_MatFisc") Is DBNull.Value Then classe.CLI_MatFisc = myReader("CLI_MatFisc")
                If Not myReader("CLI_Date_Cre") Is DBNull.Value Then classe.CLI_Date_Cre = myReader("CLI_Date_Cre")
                If Not myReader("CLI_Industrielle") Is DBNull.Value Then classe.CLI_Industrielle = myReader("CLI_Industrielle")
                If Not myReader("CLI_Fodec") Is DBNull.Value Then classe.CLI_Fodec = myReader("CLI_Fodec")
                If Not myReader("CLI_DC") Is DBNull.Value Then classe.CLI_DC = myReader("CLI_DC")
                If Not myReader("CLI_Exonoration") Is DBNull.Value Then classe.CLI_Exonoration = myReader("CLI_Exonoration")
                If Not myReader("CLI_Timbre") Is DBNull.Value Then classe.CLI_Timbre = myReader("CLI_Timbre")
                If Not myReader("CLI_Solde") Is DBNull.Value Then classe.CLI_Solde = myReader("CLI_Solde")
                If Not myReader("CLI_Type") Is DBNull.Value Then classe.CLI_Type = myReader("CLI_Type")
                If Not myReader("CLI_Etat") Is DBNull.Value Then classe.CLI_Etat = myReader("CLI_Etat")
                If Not myReader("CLI_TauxRemGlob") Is DBNull.Value Then classe.CLI_TauxRemGlob = myReader("CLI_TauxRemGlob")
                If Not myReader("CLI_Localite") Is DBNull.Value Then classe.CLI_Localite = myReader("CLI_Localite")
                If Not myReader("CLI_Adresse") Is DBNull.Value Then classe.CLI_Adresse = myReader("CLI_Adresse")
                If Not myReader("CLI_Ville") Is DBNull.Value Then classe.CLI_Ville = myReader("CLI_Ville")
                If Not myReader("CLI_CodePostale") Is DBNull.Value Then classe.CLI_CodePostale = myReader("CLI_CodePostale")
                If Not myReader("CLI_Tel1") Is DBNull.Value Then classe.CLI_Tel1 = myReader("CLI_Tel1")
                If Not myReader("CLI_Tel2") Is DBNull.Value Then classe.CLI_Tel2 = myReader("CLI_Tel2")
                If Not myReader("CLI_Fax") Is DBNull.Value Then classe.CLI_Fax = myReader("CLI_Fax")
                If Not myReader("CLI_mail") Is DBNull.Value Then classe.CLI_mail = myReader("CLI_mail")
                If Not myReader("CLI_SiteWeb") Is DBNull.Value Then classe.CLI_SiteWeb = myReader("CLI_SiteWeb")
                If Not myReader("CLI_Obs") Is DBNull.Value Then classe.CLI_Obs = myReader("CLI_Obs")
                If Not myReader("CLI_Station") Is DBNull.Value Then classe.CLI_Station = myReader("CLI_Station")
                If Not myReader("CLI_User") Is DBNull.Value Then classe.CLI_User = myReader("CLI_User")
                If Not myReader("CLI_Pers_Contact") Is DBNull.Value Then classe.CLI_Pers_Contact = myReader("CLI_Pers_Contact")
                If Not myReader("CLI_PC_Tel1") Is DBNull.Value Then classe.CLI_PC_Tel1 = myReader("CLI_PC_Tel1")
                If Not myReader("CLI_PC_Tel2") Is DBNull.Value Then classe.CLI_PC_Tel2 = myReader("CLI_PC_Tel2")
                If Not myReader("CLI_PC_Email") Is DBNull.Value Then classe.CLI_PC_Email = myReader("CLI_PC_Email")
                If Not myReader("CLI_Exo_Num") Is DBNull.Value Then classe.CLI_Exo_Num = myReader("CLI_Exo_Num")
                If Not myReader("CLI_Exo_Valable") Is DBNull.Value Then classe.CLI_Exo_Valable = myReader("CLI_Exo_Valable")
                If Not myReader("CLI_Type_Reg") Is DBNull.Value Then classe.CLI_Type_Reg = myReader("CLI_Type_Reg")
                If Not myReader("CLI_Exeno") Is DBNull.Value Then classe.CLI_Exeno = myReader("CLI_Exeno")
                If Not myReader("CLI_ValiditeTraite") Is DBNull.Value Then classe.CLI_ValiditeTraite = myReader("CLI_ValiditeTraite")
                If Not myReader("CLI_CodeRep") Is DBNull.Value Then classe.CLI_CodeRep = myReader("CLI_CodeRep")
                If Not myReader("CLI_export") Is DBNull.Value Then classe.CLI_export = myReader("CLI_export")
                If Not myReader("CLI_DDm") Is DBNull.Value Then classe.CLI_DDm = myReader("CLI_DDm")
                If Not myReader("CLI_Forfetaire") Is DBNull.Value Then classe.CLI_Forfetaire = myReader("CLI_Forfetaire")
                If Not myReader("Cli_Debit") Is DBNull.Value Then classe.Cli_Debit = myReader("Cli_Debit")
                If Not myReader("Cli_Credit") Is DBNull.Value Then classe.Cli_Credit = myReader("Cli_Credit")
                If Not myReader("Cli_EX") Is DBNull.Value Then classe.Cli_EX = myReader("Cli_EX")
                If Not myReader("Num_Fidelite") Is DBNull.Value Then classe.Num_Fidelite = myReader("Num_Fidelite")
                If Not myReader("Clt_Fidelite") Is DBNull.Value Then classe.Clt_Fidelite = myReader("Clt_Fidelite")
                If Not myReader("Clt_Epoux") Is DBNull.Value Then classe.Clt_Epoux = myReader("Clt_Epoux")
                If Not myReader("Clt_Epouse") Is DBNull.Value Then classe.Clt_Epouse = myReader("Clt_Epouse")
                If Not myReader("Clt_Epouse_Tel") Is DBNull.Value Then classe.Clt_Epouse_Tel = myReader("Clt_Epouse_Tel")
                If Not myReader("Clt_Epoux_Tel") Is DBNull.Value Then classe.Clt_Epoux_Tel = myReader("Clt_Epoux_Tel")
                If Not myReader("Clt_CIN_ville") Is DBNull.Value Then classe.Clt_CIN_ville = myReader("Clt_CIN_ville")
                If Not myReader("Clt_CIN_Date") Is DBNull.Value Then classe.Clt_CIN_Date = myReader("Clt_CIN_Date")
                If Not myReader("Clt_CIN") Is DBNull.Value Then classe.Clt_CIN = myReader("Clt_CIN")
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


