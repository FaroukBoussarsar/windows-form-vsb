Imports DevExpress.XtraEditors
Imports FormationModel


Imports System
Imports System.Data.SqlClient

Public Class frm_editBonL


    Private Sub BON_LIV_EtatLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BON_LIV_ReglerCheckEdit_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BON_LIV_ReglerLabel_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub Remplir()
        Try
            etatb.Etat_bon = "validee"



            EtatbonBindingSource.DataSource = etatb

            ClientBindingSource.DataSource = ClientDAO.getInstance.Find(New LUNA.LunaSearchParameter("CLI_Etat", "Actif", "="))
            ArticleBindingSource.DataSource = ArticleDAO.getInstance.GetAll
            EtatbonBindingSource.DataSource = Etat_bonDAO.getInstance.GetAll


        Catch ex As Exception

        End Try
    End Sub


    Dim bon As New Bon_livraison
    Dim etatb As New Etat_bon
    Dim cli As New Client




    Public Sub Nouveau()

        bon.BON_LIV_Date = Now
        'cli.CLI_NomPren = "passager"
        'cli.CLI_Code = "418"
        'am here

        ' BON_LIV_EtatTextEdit.Text = "validee"
        ' etatb.Etat_bon = "validee"
        '  BON_LIV_EtatTextEdit.EditValue = BON_LIV_EtatTextEdit.Properties.GetKeyValue(0)



        ' EtatbonBindingSource.DataSource = etatb

        'out of here
        'ClientBindingSource.DataSource = cli
        Bon_livraisonBindingSource.DataSource = bon



    End Sub

    Private Sub btn_Fermer_Click(sender As Object, e As EventArgs) Handles btn_Fermer.Click
        Close()

    End Sub

    Dim ligne As Ligne_bon_livraison

    Dim isNew As Boolean = True
    Public Sub Modifier(bn As Bon_livraison)
        bon = bn
        Bon_livraisonBindingSource.DataSource = bon
        LignebonlivraisonBindingSource.DataSource = Ligne_bon_livraisonDAO.getInstance.GetAll
        isNew = False
    End Sub
    'Public Sub Modifier1(bn As Bon_livraison)
    '    bon = bn
    '    Bon_livraisonBindingSource.DataSource = bon
    '    LignebonlivraisonBindingSource.DataSource = Ligne_bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("LG_BON_Liv_NumBon", bon.BON_LIV_Num, "="))
    '    isNew = False
    'End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged






        If e.Column.Equals(colLG_BON_Liv_CodeArt) Then
            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List
                If Not ln.Equals(ligne) AndAlso ln.LG_BON_Liv_CodeArt = ligne.LG_BON_Liv_CodeArt Then
                    XtraMessageBox.Show("Article existe deja")
                    LignebonlivraisonBindingSource.CancelEdit()
                    Return
                End If
            Next


            ligne.LG_BON_Liv_NumOrdre = LignebonlivraisonBindingSource.Count
            ligne.LG_BON_Liv_Qte = 1
            ligne.LG_BON_Liv_PUHT = ligne.ArticleMember.ART_PrixUnitaireHT
            ligne.LG_BON_Liv_Tva = ligne.ArticleMember.ART_TVA
            ligne.LG_BON_Liv_Remise = RemiseSpinEdit.EditValue
            ' ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)
            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)
        End If
        If e.Column.Equals(colLG_BON_Liv_Qte) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article invalide")
                LignebonlivraisonBindingSource.CancelEdit()


            End If



            'formulet total ttc

            '' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * ligne.LG_BON_Liv_Qte
            ' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * (1 - ligne.LG_BON_Liv_Remise / 100) * ligne.LG_BON_Liv_Qte





            'formule puht

            ligne.LG_BON_Liv_PUHT = ligne.LG_BON_Liv_TotalTTC / (1 + ligne.LG_BON_Liv_Tva / 100)

            'formulet puttc
            ''ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva


            ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / ligne.LG_BON_Liv_Qte
            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / (1 - ligne.LG_BON_Liv_Remise / 100)


        End If

        If e.Column.Equals(colLG_BON_Liv_Tva) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article invalide")
                LignebonlivraisonBindingSource.CancelEdit()


            End If


            'formulet total ttc

            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

            ' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * (1 - ligne.LG_BON_Liv_Remise / 100) * ligne.LG_BON_Liv_Qte

            ' ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva






            'formule puht

            ' ligne.LG_BON_Liv_PUHT = ligne.LG_BON_Liv_TotalTTC / (1 + ligne.LG_BON_Liv_Tva / 100)

            'formulet puttc
            ''ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva


            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / ligne.LG_BON_Liv_Qte
            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / (1 - ligne.LG_BON_Liv_Remise / 100)

        End If
        If e.Column.Equals(colLG_BON_Liv_PUHT) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article invalide")
                LignebonlivraisonBindingSource.CancelEdit()


            End If

            'formulet total ttc

            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

            ' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * (1 - ligne.LG_BON_Liv_Remise / 100) * ligne.LG_BON_Liv_Qte

            ' ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva

            'formulet puttc
            ''ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva


            ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / ligne.LG_BON_Liv_Qte
            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / (1 - ligne.LG_BON_Liv_Remise / 100)








        End If
        If e.Column.Equals(colLG_BON_Liv_Remise) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article invalide")
                LignebonlivraisonBindingSource.CancelEdit()


            End If
            'formulet total ttc
            ' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * (1 - ligne.LG_BON_Liv_Remise / 100) * ligne.LG_BON_Liv_Qte

            ' ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva







            'formulet puttc
            ''ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva


            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / ligne.LG_BON_Liv_Qte
            ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / (1 - ligne.LG_BON_Liv_Remise / 100)



            'formule puht

            ligne.LG_BON_Liv_PUHT = ligne.LG_BON_Liv_TotalTTC / (1 + ligne.LG_BON_Liv_Tva / 100)
        End If
        If e.Column.Equals(colLG_BON_Liv_PUTTC) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article invalide")
                LignebonlivraisonBindingSource.CancelEdit()


            End If
            'formulet total ttc
            ' ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * (1 - ligne.LG_BON_Liv_Remise / 100) * ligne.LG_BON_Liv_Qte

            ' ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva







            'formule puht

            ligne.LG_BON_Liv_PUHT = ligne.LG_BON_Liv_TotalTTC / (1 + ligne.LG_BON_Liv_Tva / 100)
            'formulet puttc
            ''ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT + ligne.LG_BON_Liv_Tva


            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / ligne.LG_BON_Liv_Qte
            'ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_TotalTTC / (1 - ligne.LG_BON_Liv_Remise / 100)

        End If

    End Sub

    Private Sub LignebonlivraisonBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles LignebonlivraisonBindingSource.CurrentChanged

        If LignebonlivraisonBindingSource.Current IsNot Nothing Then
            ligne = LignebonlivraisonBindingSource.Current
        End If
    End Sub

    Private Sub GridView1_ValidatingEditor(sender As Object, e As Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor

        If GridView1.FocusedColumn.Equals(colLG_BON_Liv_Qte) Then
            If e.Value < 1 Then
                e.ErrorText = "quantite invalide"
                e.Valid = False
            End If
        End If

    End Sub

    Private Sub GridView1_InvalidValueException(sender As Object, e As Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError


    End Sub
    Public Shared _cn As SqlClient.SqlConnection
    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click

        Try
            ''my code

            'Bon_livraisonBindingSource.DataSource = Bon_livraisonDAO.getInstance.GetAll
            'Dim maxid As String
            'maxid = Bon_livraisonDAO.getInstance.FindID()
            'Dim idd As String = maxid.Substring(5, 5)
            'Dim outputt As String = "BL19/"
            'For index As Integer = 1 To Len(maxid) - 5 - Len(CType(CType(idd + 1, Integer), String))
            '    outputt &= "0"
            'Next
            'outputt &= CType(CType(idd + 1, Integer), String)


            ' BON_LIV_EtatTextEdit.Text = "validee"
            EtatbonBindingSource.EndEdit()
            ' EtatbonBindingSource.DataSource = etatb
            '  etatb.Etat_bon = BON_LIV_EtatTextEdit.Text



            Remplir()

            If isNew Then
                bon.BON_LIV_Num = output()
                If BON_LIV_EtatTextEdit.Text = "validee" Then
                    BON_LIV_EtatTextEdit.EditValue = "2"
                ElseIf BON_LIV_EtatTextEdit.Text = "En Instance" Then
                    BON_LIV_EtatTextEdit.EditValue = "1"
                Else
                    BON_LIV_EtatTextEdit.EditValue = "1"


                End If




            End If







            'Dim maxid As Object
            'Dim strid As String
            'Dim intid As Integer
            'Dim Ris As Integer = 0 'in Ris torno l'id inserito


            'Dim DbCommand As SqlCommand = New SqlCommand()
            'Try
            '    Dim sql As String
            '    DbCommand.Connection = _cn

            '    'DbCommand.Transaction = myTransaction
            '    sql = "Select Max(BON_LIV_Num) as Maxid from bon_livraison"
            '    DbCommand.CommandText = sql
            '    maxid = DbCommand.ExecuteScalar()
            '    If maxid Is DBNull.Value Then
            '        intid = 1
            '    Else    
            '        strid = CType(maxid, String)
            '        intid = CType(strid, String)
            '        intid = intid + 1
            '        btn_Valider.Enabled = False

            '    End If
            '    BON_LIV_NumTextEdit.Text = intid
            '    'txt

            '    DbCommand.Dispose()

            'Catch ex As Exception
            '    XtraMessageBox.Show(ex.Message)
            'End Try
            ''Return Ris



            ''end here
            LignebonlivraisonBindingSource.EndEdit()
            Bon_livraisonBindingSource.EndEdit()

            bon.BON_LIV_Exerc = Now.Year
            bon.BON_LIV_StationOrigine = "001"

            bon.BON_LIV_Montant = 0


            Ligne_bon_livraisonDAO.getInstance.DeleteByBon(bon.BON_LIV_Num)

            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List
                bon.BON_LIV_Montant = bon.BON_LIV_Montant + ln.LG_BON_Liv_TotalTTC

            Next


            If isNew Then
                Bon_livraisonDAO.getInstance.Save(bon)
            Else
                Bon_livraisonDAO.getInstance.Update(bon)

            End If


            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List
                ln.LG_BON_Liv_NumBon = bon.BON_LIV_Num
                ln.LG_BON_Liv_Exerc = bon.BON_LIV_Exerc
                ln.LG_BON_Liv_Unite = "pièce" 'pq??

                Ligne_bon_livraisonDAO.getInstance.Save(ln)

            Next
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        DialogResult = DialogResult.OK


        Close()



    End Sub

    Public Function output() As String
        Try
            Dim maxid As String
            maxid = Bon_livraisonDAO.getInstance.FindID()
            Dim idd As String = maxid.Substring(5, 5)
            Dim outputt As String = "BL19/"
            For index As Integer = 1 To Len(maxid) - 5 - Len(CType(CType(idd + 1, Integer), String))
                outputt &= "0"
            Next
            outputt &= CType(CType(idd + 1, Integer), String)
            Return outputt

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try


    End Function

    Public Sub BON_LIV_NumTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BON_LIV_NumTextEdit.EditValueChanged
        ' Dim sms As String
        'sms = Ligne_bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("LG_BON_Liv_NumBon", bon.BON_LIV_Num, "="))

        ' Bon_livraisonBindingSource.DataSource = Bon_livraisonDAO.getInstance.GetAll







        'bon.BON_LIV_Num = outputt
        If isNew Then
            BON_LIV_NumTextEdit.Text = output()
        End If









    End Sub
    'Private Sub BON_LIV_EtatTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BON_LIV_EtatTextEdit.EditValueChanged
    '    If isNew Then

    '        BON_LIV_EtatTextEdit.EditValue = BON_LIV_EtatTextEdit.Properties.GetKeyValue(0)

    '    End If
    'End Sub


    Private Sub RemiseSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles RemiseSpinEdit.EditValueChanged

    End Sub

    Private Sub frm_editBonL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BON_LIV_EtatTextEdit.EditValue = BON_LIV_EtatTextEdit.Properties.GetKeyValue(0)


        '  BON_LIV_EtatTextEdit.EditValue = "1"

    End Sub

    'Private Sub frm_editBonL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    BON_LIV_EtatTextEdit.EditValue = BON_LIV_EtatTextEdit.Properties.GetKeyValue(0)


    'End Sub
    'Private Sub BON_LIV_EtatTextEdit_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BON_LIV_EtatTextEdit.Popup
    '    BON_LIV_EtatTextEdit.EditValue = BON_LIV_EtatTextEdit.Properties.GetKeyValue(0)
    'End Sub





End Class