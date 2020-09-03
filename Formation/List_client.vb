Imports DevExpress.XtraEditors

Imports FormationModel

Public Class List_Client

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Public Sub Remplir()
        Try
            ClientBindingSource.DataSource = ClientDAO.getInstance().GetAll


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub


    Private Sub List_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir()



    End Sub

    Public Function mawjoud(e As String) As Boolean
        Try
            Dim Ls As New List(Of Bon_livraison)
            Ls = Bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("BON_LIV_CodeClient", e, "=")).ToList

            If Ls.Count = 0 Then
                Return False
            Else
                Return True

            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try


    End Function


    'Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick

    'End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Select Case e.Button.Properties.Caption

            Case "Nouveau"
            

                Dim frm As New EditClient
                frm.Remplir()
                frm.Nouveau()
                'frm.ShowDialog()
                If frm.ShowDialog() = DialogResult.OK Then
                    ClientBindingSource.Add(frm.cli)
                    GridView1.RefreshData()

                End If

            Case "Modifer"
                ' If GridView1.GetFocusedDataRow Is Nothing Then
                '  Return
                ' End If
                '  Return


                '     End If
                Dim frm As New EditClient
                frm.CLI_CodeTextEdit.Enabled = False
                frm.Remplir()
                Dim sss As Client = ClientBindingSource.Current
                frm.Modifer(ClientBindingSource.Current)

                'frm.ShowDialog()
                If frm.ShowDialog() <> DialogResult.OK Then
                    ClientBindingSource.Remove(ClientBindingSource.Current)

                    ClientBindingSource.Add(frm.cli)
                    GridView1.RefreshData()

                End If

            Case "Supprimer"
                'If GridView1.GetFocusedDataRow Is Nothing Then
                '    Return

                ' End If
                If XtraMessageBox.Show("voulez-vous supprimer Client ", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        If Not mawjoud(CType(ClientBindingSource.Current, Client).CLI_Code) Then



                            Try

                                ClientDAO.getInstance().Delete(CType(ClientBindingSource.Current, Client).CLI_Code)
                                ClientBindingSource.Remove(ClientBindingSource.Current)
                            Catch ex As Exception
                                XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            XtraMessageBox.Show("cient is in use")
                        End If
                    Catch ex As Exception
                        XtraMessageBox.Show("client is in use", "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If

            Case "Fermer"
                Close()


        End Select
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim frm As New EditClient
        frm.Remplir()
        Dim sss As Client = ClientBindingSource.Current
        frm.Modifer(ClientBindingSource.Current)

        'frm.ShowDialog()
        If frm.ShowDialog() <> DialogResult.OK Then
            ClientBindingSource.Remove(ClientBindingSource.Current)

            ClientBindingSource.Add(frm.cli)
            GridView1.RefreshData()

        End If
    End Sub
End Class