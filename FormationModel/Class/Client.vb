#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 12/06/2019
#End Region

Public Class Client

#Region "Logic Field"

#End Region
    Private _Actif As Boolean
    Public Property Actif() As Boolean
        Get
            If CLI_Etat = "Actif" Then
                Return True
            Else
                Return False


            End If
        End Get
        Set(ByVal value As Boolean)
            If value Then
                _CLI_Etat = "Actif"
            Else
                _CLI_Etat = "Bloquer"
            End If


        End Set
    End Property


#Region "Method"

#End Region

End Class

Public Class ClientDAO

#Region "Method"

#End Region

End Class

