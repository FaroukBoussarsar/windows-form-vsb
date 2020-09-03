Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Grid
Imports FormationModel

Public Class EditClient
    Dim isNew As Boolean = True
    Private Sub CLI_VilleLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActifLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Remplir()


        Try
            TypeclientBindingSource.DataSource = Type_clientDAO.getInstance().GetAll

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub Modifer(cl As Client)

        cli = cl
        ClientBindingSource.DataSource = cl
        isNew = False
    End Sub
    Public Sub Nouveau()
        Dim cl As New Client
        cl.CLI_Etat = "Actif"
        cl.CLI_Type = "Passager"

        ClientBindingSource.DataSource = cl


    End Sub

    Private Sub TypeclientBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TypeclientBindingSource.CurrentChanged

    End Sub

    Private Sub btn_Fermer_Click(sender As Object, e As EventArgs) Handles btn_Fermer.Click
        Close()

    End Sub


    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function

    Public cli As New Client
    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        Try

            DxErrorProvider1.ClearErrors()

            If String.IsNullOrEmpty(CLI_CodeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(CLI_CodeTextEdit, "code obligatoire")
                ClientBindingSource.CancelEdit()

            End If
            If Not IsNumeric(Clt_CINTextEdit.EditValue) Then
                DxErrorProvider1.SetError(Clt_CINTextEdit, "seulement des nombre")
                ClientBindingSource.CancelEdit()

            End If
            If Not IsNumeric(CLI_Tel1TextEdit.EditValue) Then
                DxErrorProvider1.SetError(CLI_Tel1TextEdit, "seulement des nombre")
                ClientBindingSource.CancelEdit()

            End If
            If Not IsEmail(CLI_mailTextEdit.EditValue) Then
                DxErrorProvider1.SetError(CLI_mailTextEdit, "Email valide svp")
                ClientBindingSource.CancelEdit()
            End If



            If DxErrorProvider1.HasErrors Then

                Return
            End If


            ClientBindingSource.EndEdit()
            cli = ClientBindingSource.Current
            cli = ClientBindingSource.Current
            cli.CLI_Date_Cre = Now
            If isNew Then
                ClientDAO.getInstance.Save(cli)
            Else
                ClientDAO.getInstance.Update(cli)
            End If

            'ClientDAO.getInstance.Save(cli)
            DialogResult = DialogResult.OK
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult <> DialogResult.OK Then
            cli = ClientDAO.getInstance.Read(cli.CLI_Code)

        End If
    End Sub

    'Private Sub Clt_CINTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles Clt_CINTextEdit.EditValueChanged
    '    'If Not IsNumeric(Clt_CINTextEdit.EditValue) Then
    '    '    DxErrorProvider1.SetError(Clt_CINTextEdit, "number please")
    '    '    ClientBindingSource.CancelEdit()
    '    'End If

    '    'If GridView1.FocusedColumn.Equals(colLG_BON_Liv_Qte) Then
    '    If Clt_CINTextEdit.Equals(Clt_CINTextEdit) Then


    '        If e.Value < 1 Then
    '            e.ErrorText = "quantite invalide"
    '            e.Valid = False
    '        End If
    '    End If
    '    'If Clt_CINTextEdit.Text = Clt_CINTextEdit.EditValue Then

    '    '    If e.Value < 1 Then
    '    '        e.ErrorText = "quantite invalide"
    '    '        e.Valid = False
    '    '    End If
    '    'End If
    'End Sub
End Class