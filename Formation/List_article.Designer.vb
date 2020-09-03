<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_article
    Inherits DevExpress.XtraEditors.XtraForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.RadialMenu1 = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ArticleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colART_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_Designation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_PrixUnitaireHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_Marque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_TVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_Couleur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemColorPickEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit()
        Me.colART_TAILLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_DateCr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_QteStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_Poid_Qte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto_Path = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGraphicsEdit1 = New Formation.GraphicsEditor.RepositoryItemGraphicsEdit()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.RepositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorPickEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGraphicsEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.Name = "RadialMenu1"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Nouveau", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Modifer", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Supprimer", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Fermer", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(12, 668)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(982, 68)
        Me.WindowsUIButtonPanel1.TabIndex = 1
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ArticleBindingSource1
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1, Me.RepositoryItemColorEdit1, Me.RepositoryItemGraphicsEdit1, Me.RepositoryItemColorPickEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(982, 610)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ArticleBindingSource1
        '
        Me.ArticleBindingSource1.DataSource = GetType(FormationModel.Article)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colART_Code, Me.colART_Designation, Me.colART_PrixUnitaireHT, Me.colART_Marque, Me.colART_TVA, Me.colART_Couleur, Me.colART_TAILLE, Me.colART_DateCr, Me.colART_QteStock, Me.colART_Poid_Qte, Me.colphoto_Path})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colART_Code
        '
        Me.colART_Code.Caption = "Code"
        Me.colART_Code.FieldName = "ART_Code"
        Me.colART_Code.MinWidth = 25
        Me.colART_Code.Name = "colART_Code"
        Me.colART_Code.Visible = True
        Me.colART_Code.VisibleIndex = 0
        Me.colART_Code.Width = 94
        '
        'colART_Designation
        '
        Me.colART_Designation.Caption = "Designation"
        Me.colART_Designation.FieldName = "ART_Designation"
        Me.colART_Designation.MinWidth = 25
        Me.colART_Designation.Name = "colART_Designation"
        Me.colART_Designation.Visible = True
        Me.colART_Designation.VisibleIndex = 1
        Me.colART_Designation.Width = 94
        '
        'colART_PrixUnitaireHT
        '
        Me.colART_PrixUnitaireHT.Caption = "PU.H.T"
        Me.colART_PrixUnitaireHT.FieldName = "ART_PrixUnitaireHT"
        Me.colART_PrixUnitaireHT.MinWidth = 25
        Me.colART_PrixUnitaireHT.Name = "colART_PrixUnitaireHT"
        Me.colART_PrixUnitaireHT.Visible = True
        Me.colART_PrixUnitaireHT.VisibleIndex = 6
        Me.colART_PrixUnitaireHT.Width = 94
        '
        'colART_Marque
        '
        Me.colART_Marque.Caption = "Marque"
        Me.colART_Marque.FieldName = "ART_Marque"
        Me.colART_Marque.MinWidth = 25
        Me.colART_Marque.Name = "colART_Marque"
        Me.colART_Marque.Visible = True
        Me.colART_Marque.VisibleIndex = 2
        Me.colART_Marque.Width = 94
        '
        'colART_TVA
        '
        Me.colART_TVA.Caption = "TVA"
        Me.colART_TVA.FieldName = "ART_TVA"
        Me.colART_TVA.MinWidth = 25
        Me.colART_TVA.Name = "colART_TVA"
        Me.colART_TVA.Visible = True
        Me.colART_TVA.VisibleIndex = 7
        Me.colART_TVA.Width = 94
        '
        'colART_Couleur
        '
        Me.colART_Couleur.Caption = "Couleur"
        Me.colART_Couleur.ColumnEdit = Me.RepositoryItemColorPickEdit1
        Me.colART_Couleur.FieldName = "ART_Couleur"
        Me.colART_Couleur.MinWidth = 25
        Me.colART_Couleur.Name = "colART_Couleur"
        Me.colART_Couleur.Visible = True
        Me.colART_Couleur.VisibleIndex = 4
        Me.colART_Couleur.Width = 94
        '
        'RepositoryItemColorPickEdit1
        '
        Me.RepositoryItemColorPickEdit1.AutoHeight = False
        Me.RepositoryItemColorPickEdit1.AutomaticColor = System.Drawing.Color.Black
        Me.RepositoryItemColorPickEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorPickEdit1.Name = "RepositoryItemColorPickEdit1"
        '
        'colART_TAILLE
        '
        Me.colART_TAILLE.Caption = "Taille"
        Me.colART_TAILLE.FieldName = "ART_TAILLE"
        Me.colART_TAILLE.MinWidth = 25
        Me.colART_TAILLE.Name = "colART_TAILLE"
        Me.colART_TAILLE.Visible = True
        Me.colART_TAILLE.VisibleIndex = 8
        Me.colART_TAILLE.Width = 94
        '
        'colART_DateCr
        '
        Me.colART_DateCr.Caption = "Date.creation"
        Me.colART_DateCr.FieldName = "ART_DateCr"
        Me.colART_DateCr.MinWidth = 25
        Me.colART_DateCr.Name = "colART_DateCr"
        Me.colART_DateCr.Visible = True
        Me.colART_DateCr.VisibleIndex = 10
        Me.colART_DateCr.Width = 94
        '
        'colART_QteStock
        '
        Me.colART_QteStock.Caption = "Qte"
        Me.colART_QteStock.FieldName = "ART_QteStock"
        Me.colART_QteStock.MinWidth = 25
        Me.colART_QteStock.Name = "colART_QteStock"
        Me.colART_QteStock.Visible = True
        Me.colART_QteStock.VisibleIndex = 5
        Me.colART_QteStock.Width = 94
        '
        'colART_Poid_Qte
        '
        Me.colART_Poid_Qte.Caption = "Poid Qte"
        Me.colART_Poid_Qte.FieldName = "ART_Poid_Qte"
        Me.colART_Poid_Qte.MinWidth = 25
        Me.colART_Poid_Qte.Name = "colART_Poid_Qte"
        Me.colART_Poid_Qte.Visible = True
        Me.colART_Poid_Qte.VisibleIndex = 9
        Me.colART_Poid_Qte.Width = 94
        '
        'colphoto_Path
        '
        Me.colphoto_Path.FieldName = "photo_Path"
        Me.colphoto_Path.MinWidth = 25
        Me.colphoto_Path.Name = "colphoto_Path"
        Me.colphoto_Path.Visible = True
        Me.colphoto_Path.VisibleIndex = 3
        Me.colphoto_Path.Width = 94
        '
        'RepositoryItemGraphicsEdit1
        '
        Me.RepositoryItemGraphicsEdit1.Name = "RepositoryItemGraphicsEdit1"
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'RepositoryItemColorEdit1
        '
        Me.RepositoryItemColorEdit1.AutoHeight = False
        Me.RepositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorEdit1.Name = "RepositoryItemColorEdit1"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "photo_Path"
        Me.GridColumn1.MinWidth = 25
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 11
        Me.GridColumn1.Width = 94
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "photo_Path"
        Me.GridColumn2.MinWidth = 25
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 11
        Me.GridColumn2.Width = 94
        '
        'List_article
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 739)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Name = "List_article"
        Me.Text = "Article"
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorPickEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGraphicsEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadialMenu1 As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents ArticleBindingSource1 As BindingSource
    Friend WithEvents colART_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_Designation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_PrixUnitaireHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_Marque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_TVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_Couleur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_TAILLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_DateCr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_QteStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_Poid_Qte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto_Path As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents RepositoryItemGraphicsEdit1 As GraphicsEditor.RepositoryItemGraphicsEdit
    Friend WithEvents RepositoryItemColorPickEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit
End Class
