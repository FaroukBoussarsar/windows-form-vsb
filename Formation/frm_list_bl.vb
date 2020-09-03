Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports FormationModel

Public Class frm_list_bl
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        DateEditDu.EditValue = Now
        DateEditAu.EditValue = Now

    End Sub

    Public Sub Remplir()
        Try

            BonlivraisonBindingSource.DataSource = Bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("convert(date, BON_LIV_Date,103)", DateEditAu.EditValue, "<="), New LUNA.LunaSearchParameter("convert(date, BON_LIV_Date,103)", DateEditDu.EditValue, ">="))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub





    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub


    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Select Case e.Button.Properties.Caption

            Case "Nouveau"


                Dim frm As New frm_editBonL
                frm.Remplir()
                frm.Nouveau()

                ' frm.ShowDialog()
                If frm.ShowDialog() = DialogResult.OK Then
                    Remplir()
                    frm.Close()


                End If



            Case "Modifer"






                Try
                    Dim frm As New frm_editBonL
                    Dim b As Bon_livraison = Bon_livraisonDAO.getInstance.Read(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
                    frm.Remplir()
                    frm.Modifier(b)
                    If frm.ShowDialog() = DialogResult.OK Then

                        Remplir()


                    End If

                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message)
                End Try


                'Dim frm As New frm_editBonL
                'frm.Remplir()
                'Dim sss As Client = ClientBindingSource.Current
                'frm.Modifer(ClientBindingSource.Current)

                ''frm.ShowDialog()
                'If frm.ShowDialog() <> DialogResult.OK Then
                '    ClientBindingSource.Remove(ClientBindingSource.Current)

                '    ClientBindingSource.Add(frm.cli)
                '    GridView1.RefreshData()

                'End If

            Case "Info"

                Dim rpt As New etat_bl(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
                rpt.ShowPreviewMarginLines = False
                rpt.ShowPrintMarginsWarning = False
                rpt.ShowPrintStatusDialog = False
                rpt.ShowPreview()



                'If XtraMessageBox.Show("voulez-vous supprimer Client ", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                '    Try
                '        ClientBindingSource.Remove(ClientBindingSource.Current)
                '        ClientDAO.getInstance().Delete(CType(ClientBindingSource.Current, Client).CLI_Code)
                '    Catch ex As Exception
                '        XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End Try



                'End If

            Case "Fermer"
                Close()


        End Select
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Remplir()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim frm As New frm_editBonL
            Dim b As Bon_livraison = Bon_livraisonDAO.getInstance.Read(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
            frm.Remplir()
            frm.Modifier(b)
            If frm.ShowDialog() = DialogResult.OK Then

                Remplir()


            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frm_list_bl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class