Imports System.Xml

Module Module_Config

    Dim IsWindowAuthentification As Boolean


    Public Function getChaineConnectFromXML(Optional ByVal ch = "\bases_config.xml") As String
        Dim chaine As String = ""
        Dim nombase As String = ""
        Dim host As String = ""
        Dim login As String = ""
        Dim psw As String = ""
        IsWindowAuthentification = False
        Dim XmlDoc As New XmlDocument()
        XmlDoc.Load(Application.StartupPath & ch)

        Dim element As XmlNodeList
        element = XmlDoc.DocumentElement.GetElementsByTagName("base")

        If element.Count = 0 Then
            Return String.Empty
        End If

        Dim noeud, noeudEnf As XmlNode
        For Each noeud In element
            If noeud.Attributes.Item(0).Value.ToString.Equals("True") Then

                If noeud.Attributes.Item(1).Value.ToString.Equals("windows") Then
                    IsWindowAuthentification = True
                End If

                For Each noeudEnf In noeud.ChildNodes


                    If noeudEnf.LocalName = "nom" Then
                        nombase = noeudEnf.InnerText
                        ' My.Settings.Item("base") = noeudEnf.InnerText

                    End If
                    If noeudEnf.LocalName = "host" Then
                        host = noeudEnf.InnerText
                        '  My.Settings.Item("serveur") = noeudEnf.InnerText

                    End If

                    If noeudEnf.LocalName = "login" Then
                        login = noeudEnf.InnerText
                        '  My.Settings.Item("login") = noeudEnf.InnerText


                    End If
                    If noeudEnf.LocalName = "psw" Then
                        psw = noeudEnf.InnerText
                        '  My.Settings.Item("pass") = noeudEnf.InnerText


                    End If

                Next
            End If
        Next

        If IsWindowAuthentification Then
            chaine = "Data Source=" + host + ";Initial Catalog=" + nombase + ";Connect Timeout=500000;Integrated Security=True"
            ' chaineOledb = "Provider=SQLOLEDB;Data Source=" + host + "; Integrated Security=SSPI;Initial Catalog=" + nombase
            'My.Settings.Item("Type") = True

        Else
            chaine = "Data Source=" + host + ";Initial Catalog=" + nombase + ";Connect Timeout=500000;Persist Security Info=True;User ID=" + login + ";Password=" + psw '+ ";Network Library=dbmssocn"
            'chaineOledb = "Provider=SQLOLEDB;Data Source=" + host + ";Persist Security Info=True;Password=" + psw + ";User ID=" + login + ";Initial Catalog=" + nombase
            ' My.Settings.Item("Type") = False

        End If

        getChaineConnectFromXML = chaine
    End Function


End Module
