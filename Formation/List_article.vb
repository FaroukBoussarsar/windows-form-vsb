Imports DevExpress.XtraEditors
Imports Formation.GraphicsEditor
Imports FormationModel

Public Class List_article

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Public Sub Remplir()
        Try

            ArticleBindingSource1.DataSource = ArticleDAO.getInstance.GetAll


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Remplir1()
        Try

            ArticleBindingSource1.DataSource = ArticleDAO.getInstance().Find(New LUNA.LunaSearchParameter("ART_Code", "", "<>"))


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Function Showimg()
    '    Dim imageByte As Byte()
    '    Remplir()

    '    For Each ln As Article In ArticleBindingSource1.List

    '        Dim path As String = ln.photo_Path
    '        If ln.photo_Path <> "" Then
    '            Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
    '            Dim imageConverter As New ImageConverter()
    '            imageByte = DirectCast(imageConverter.ConvertTo(image, GetType(Byte())), Byte())
    '            'ln.ART_Image = imageByte

    '            CType(ArticleBindingSource1.Current, Article).ART_Image = imageByte

    '        End If



    '    Next
    'End Function
    Private Sub List_article_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Showimg()
        Dim repItemGraphicsEdit As New RepositoryItemGraphicsEdit()
        repItemGraphicsEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        GridView1.Columns("photo_Path").ColumnEdit = repItemGraphicsEdit

        Remplir1()



    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick

        Select Case e.Button.Properties.Caption
            Case "Nouveau"


                Dim frm As New EditArticle
                frm.Remplir()
                frm.Nouveau()
                'frm.ShowDialog()
                If frm.ShowDialog() = DialogResult.OK Then
                    ArticleBindingSource1.Add(frm.art)
                    GridView1.RefreshData()

                End If

            Case "Modifer"
                'test
                'Dim frm2 As New EditArticle
                ' frm2.ART_CodeTextEdit.Enabled = False

                ' If GridView1.GetFocusedDataRow Is Nothing Then
                '  Return
                ' End If
                '  Return

                '     End If
                Dim frm As New EditArticle
                frm.ART_CodeTextEdit.Enabled = False
                frm.Remplir()
                Dim sss As Article = ArticleBindingSource1.Current
                frm.Modifer(ArticleBindingSource1.Current)

                'frm.ShowDialog()
                If frm.ShowDialog() <> DialogResult.OK Then
                    ArticleBindingSource1.Remove(ArticleBindingSource1.Current)

                    ArticleBindingSource1.Add(frm.art)
                    GridView1.RefreshData()

                End If

            Case "Supprimer"
                'If GridView1.GetFocusedDataRow Is Nothing Then
                '    Return

                ' End If
                If XtraMessageBox.Show("voulez-vous supprimer Client ", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then




                    Try

                        ArticleDAO.getInstance().Delete(CType(ArticleBindingSource1.Current, Article).ART_Code)
                        ArticleBindingSource1.Remove(ArticleBindingSource1.Current)
                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    XtraMessageBox.Show("cient is in use")
                End If




            Case "Fermer"
                Close()
        End Select
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim frm As New EditArticle
        frm.ART_CodeTextEdit.Enabled = False
        frm.Remplir()
        Dim sss As Article = ArticleBindingSource1.Current
        frm.Modifer(ArticleBindingSource1.Current)

        'frm.ShowDialog()
        If frm.ShowDialog() <> DialogResult.OK Then
            ArticleBindingSource1.Remove(ArticleBindingSource1.Current)

            ArticleBindingSource1.Add(frm.art)
            GridView1.RefreshData()

        End If
    End Sub


End Class