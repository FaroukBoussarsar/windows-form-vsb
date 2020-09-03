Imports DevExpress.XtraEditors
Imports FormationModel

Public Class edittaille
    Public artt As New Art_taille
    Dim isNew As Boolean = True

    Public Sub Remplir()


        Try
            Art_tailleBindingSource.DataSource = Art_tailleDAO.getInstance().GetAll

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub Modifer(cl As Art_taille)

        artt = cl
        Art_tailleBindingSource.DataSource = cl
        isNew = False
    End Sub
    Public Sub Nouveau()
        Dim cl As New Art_taille
        'cl.CLI_Etat = "Actif"
        'cl.CLI_Type = "Passager"

        Art_tailleBindingSource.DataSource = cl


    End Sub
    Private Sub edittaille_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Fermer_Click(sender As Object, e As EventArgs) Handles btn_Fermer.Click
        Close()

    End Sub

    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        Try
            Art_tailleBindingSource.EndEdit()
            artt = Art_tailleBindingSource.Current
            ' cli = ClientBindingSource.Current
            '  artt.CLI_Date_Cre = Now
            If isNew Then
                Art_tailleDAO.getInstance.Save(artt)
            Else
                Art_tailleDAO.getInstance.Update(artt)
            End If

            'ClientDAO.getInstance.Save(cli)
            DialogResult = DialogResult.OK

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub edittaille_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult <> DialogResult.OK Then
            artt = Art_tailleDAO.getInstance.Read(artt.taille)

        End If
    End Sub
End Class