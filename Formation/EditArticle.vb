Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports FormationModel

Public Class EditArticle
    Dim isNew As Boolean = True
    Public Sub Remplir()


        Try
            ArttailleBindingSource.DataSource = Art_tailleDAO.getInstance().Find(New LUNA.LunaSearchParameter("taille", "", "<>"))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub Remplir1()


        Try
            ArticleBindingSource.DataSource = ArticleDAO.getInstance.Find(New LUNA.LunaSearchParameter("ART_Code", "", "<>"))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub Modifer(cl As Article)

        art = cl
        ArticleBindingSource.DataSource = cl
        isNew = False
    End Sub
    Public Sub Nouveau()
        Dim ar As New Article
        ' cl.CLI_Etat = "Actif"
        'cl.CLI_Type = "Passager"
        ar.ART_TAILLE = "taille"

        ArticleBindingSource.DataSource = ar


    End Sub
    Private Sub EditArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir()
    End Sub

    Private Sub btn_Fermer_Click(sender As Object, e As EventArgs) Handles btn_Fermer.Click
        Close()

    End Sub
    Public art As New Article
    Dim artaill As New Art_taille
    Private Sub btn_Valider_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click

        Try
            DxErrorProvider1.ClearErrors()

            If String.IsNullOrEmpty(ART_CodeTextEdit.EditValue) Then
                DxErrorProvider1.SetError(ART_CodeTextEdit, "code obligatoire")
                ArticleBindingSource.CancelEdit()

            End If



            If DxErrorProvider1.HasErrors Then

                Return
            End If

            ArticleBindingSource.EndEdit()
            art = ArticleBindingSource.Current
            ' cli = ClientBindingSource.Current
            art.ART_Couleur = art.ART_Couleur.Replace("Color [", "")
            art.ART_Couleur = art.ART_Couleur.Replace("]", "")

            art.ART_DateCr = Now
            '  CType(ArticleBindingSource.Current, Article).ART_Image = imageByte
            '  art.ART_Image = imageByte
            'art.ART_Couleur = ART_CouleurTextEdit.Text.Replace("Color [", "")
            If isNew Then
                ArticleDAO.getInstance.Save(art)
            Else
                ArticleDAO.getInstance.Update(art)
            End If
            DialogResult = DialogResult.OK

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Messafe", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub EditArticle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult <> DialogResult.OK Then
            art = ArticleDAO.getInstance.Read(art.ART_Code)

        End If
    End Sub
    Dim imageByte As Byte()
    Public Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Photo_PathTextEdit.Text = OpenFileDialog1.FileName
            ' art.ART_Image = Photo_PathTextEdit.Text
            ''art.ART_Image = File.ReadAllBytes(Photo_PathTextEdit.Text)
            'Dim path As String = Photo_PathTextEdit.Text
            'Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
            'Dim imageConverter As New ImageConverter()
            'imageByte = DirectCast(imageConverter.ConvertTo(image, GetType(Byte())), Byte())
            '  art.ART_Image = imageByte


            '  CType(ArticleBindingSource.Current, Article).ART_Image = imageByte
        End If

    End Sub

    Private Sub ART_Poid_QteTextEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ART_Poid_QteTextEdit.KeyPress
        'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '    MessageBox.Show("You can only input numbers!")
        'End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub


End Class