Imports FormationModel

Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Module_parametrage.ChaineCNX = getChaineConnectFromXML()



    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        Dim frm As New List_Client()
        frm.MdiParent = Me
        frm.Show()

    End Sub

    'Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

    '    Dim frm As New frm_list_bl

    '    frm.MdiParent = Me
    '    frm.Show()
    'End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim frm As New List_article
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim frm As New frm_list_bl

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim frm As New list_taille

        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
