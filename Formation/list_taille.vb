Imports DevExpress.XtraEditors

Imports FormationModel

Public Class list_taille
    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Public Sub Remplir()
        Try
            ArttailleBindingSource.DataSource = Art_tailleDAO.getInstance().GetAll


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub list_taille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir()

    End Sub
    Dim tail As Art_taille
    'Private Sub ArttailleBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ArttailleBindingSource.CurrentChanged
    '    If ArttailleBindingSource.Current IsNot Nothing Then
    '        tail = ArttailleBindingSource.Current
    '    End If
    'End Sub
    Dim isNew As Boolean = True
    'Private Sub btn_Valider_Click(sender As Object, e As EventArgs)
    '    Try
    '        ArttailleBindingSource.EndEdit()
    '        If isNew Then
    '            Art_tailleDAO.getInstance.Save(tail)
    '        Else
    '            Art_tailleDAO.getInstance.Update(tail)

    '        End If
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message)

    '    End Try
    '    Dim frm1 As New EditArticle
    '    frm1.Remplir()
    '    ArttailleBindingSource.DataSource = Art_tailleDAO.getInstance().GetAll




    '    DialogResult = DialogResult.OK




    '    ArttailleBindingSource.DataSource = Art_tailleDAO.getInstance().GetAll
    '    Close()
    '    ArttailleBindingSource.DataSource = Art_tailleDAO.getInstance().GetAll
    'End Sub

    'Private Sub btn_Fermer_Click(sender As Object, e As EventArgs)
    '    Dim frm1 As New EditArticle
    '    frm1.Remplir()
    '    Close()

    'End Sub

    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    If XtraMessageBox.Show("voulez-vous supprimer Client ", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '        Try




    '            Try
    '                ArttailleBindingSource.Remove(ArttailleBindingSource.Current)
    '                Art_tailleDAO.getInstance().Delete(CType(ArttailleBindingSource.Current, Art_taille).taille)
    '            Catch ex As Exception
    '                XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try

    '        Catch ex As Exception
    '            XtraMessageBox.Show("client is in use", "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    End If
    'End Sub

    Private Sub WindowsUIButtonPanel1_Click_1(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click

    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Select Case e.Button.Properties.Caption

            Case "Nouveau"


                Dim frm As New edittaille
                frm.Remplir()
                frm.Nouveau()

                ' frm.ShowDialog()
                If frm.ShowDialog() = DialogResult.OK Then
                    Remplir()
                    frm.Close()


                End If



            'Case "Modifier"






            '    Try
            '        Dim frm As New edittaille
            '        Dim b As Art_taille = Art_tailleDAO.getInstance.Read(CType(ArttailleBindingSource.Current, Art_taille).taille)
            '        frm.Remplir()
            '        frm.Modifer(b)
            '        If frm.ShowDialog() = DialogResult.OK Then

            '            Remplir()


            '        End If

            '    Catch ex As Exception
            '        XtraMessageBox.Show(ex.Message)
            '    End Try


            '    'Dim frm As New frm_editBonL
            '    'frm.Remplir()
            '    'Dim sss As Client = ClientBindingSource.Current
            '    'frm.Modifer(ClientBindingSource.Current)

            '    ''frm.ShowDialog()
            '    'If frm.ShowDialog() <> DialogResult.OK Then
            '    '    ClientBindingSource.Remove(ClientBindingSource.Current)

            '    '    ClientBindingSource.Add(frm.cli)
            '    '    GridView1.RefreshData()

            '    'End If

            Case "Supprimer"

                'Dim rpt As New etat_bl(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
                'rpt.ShowPreviewMarginLines = False
                'rpt.ShowPrintMarginsWarning = False
                'rpt.ShowPrintStatusDialog = False
                'rpt.ShowPreview()



                If XtraMessageBox.Show("voulez-vous supprimer Client ", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try

                        Art_tailleDAO.getInstance().Delete(CType(ArttailleBindingSource.Current, Art_taille).taille)
                        ArttailleBindingSource.Remove(ArttailleBindingSource.Current)
                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try



                End If

            Case "Fermer"
                Close()


        End Select
    End Sub


End Class