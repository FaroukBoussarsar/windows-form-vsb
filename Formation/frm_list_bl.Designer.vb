<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_list_bl
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BonlivraisonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBON_LIV_CodeClient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Etat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Montant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Num = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEditAu = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditDu = New DevExpress.XtraEditors.DateEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DateEditAu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditAu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BonlivraisonBindingSource
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(12, 133)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1})
        Me.GridControl1.Size = New System.Drawing.Size(982, 471)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BonlivraisonBindingSource
        '
        Me.BonlivraisonBindingSource.DataSource = GetType(FormationModel.Bon_livraison)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBON_LIV_CodeClient, Me.colBON_LIV_Date, Me.colBON_LIV_Etat, Me.colBON_LIV_Montant, Me.colBON_LIV_Num})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colBON_LIV_CodeClient
        '
        Me.colBON_LIV_CodeClient.Caption = "Client"
        Me.colBON_LIV_CodeClient.FieldName = "Clientmember.CLI_NomPren"
        Me.colBON_LIV_CodeClient.MinWidth = 25
        Me.colBON_LIV_CodeClient.Name = "colBON_LIV_CodeClient"
        Me.colBON_LIV_CodeClient.Visible = True
        Me.colBON_LIV_CodeClient.VisibleIndex = 2
        Me.colBON_LIV_CodeClient.Width = 94
        '
        'colBON_LIV_Date
        '
        Me.colBON_LIV_Date.Caption = "Date"
        Me.colBON_LIV_Date.FieldName = "BON_LIV_Date"
        Me.colBON_LIV_Date.MinWidth = 25
        Me.colBON_LIV_Date.Name = "colBON_LIV_Date"
        Me.colBON_LIV_Date.Visible = True
        Me.colBON_LIV_Date.VisibleIndex = 1
        Me.colBON_LIV_Date.Width = 94
        '
        'colBON_LIV_Etat
        '
        Me.colBON_LIV_Etat.Caption = "Etat"
        Me.colBON_LIV_Etat.FieldName = "BON_LIV_Etat"
        Me.colBON_LIV_Etat.MinWidth = 25
        Me.colBON_LIV_Etat.Name = "colBON_LIV_Etat"
        Me.colBON_LIV_Etat.Visible = True
        Me.colBON_LIV_Etat.VisibleIndex = 4
        Me.colBON_LIV_Etat.Width = 94
        '
        'colBON_LIV_Montant
        '
        Me.colBON_LIV_Montant.Caption = "Montant"
        Me.colBON_LIV_Montant.FieldName = "BON_LIV_Montant"
        Me.colBON_LIV_Montant.MinWidth = 25
        Me.colBON_LIV_Montant.Name = "colBON_LIV_Montant"
        Me.colBON_LIV_Montant.Visible = True
        Me.colBON_LIV_Montant.VisibleIndex = 3
        Me.colBON_LIV_Montant.Width = 94
        '
        'colBON_LIV_Num
        '
        Me.colBON_LIV_Num.Caption = "N"
        Me.colBON_LIV_Num.FieldName = "BON_LIV_Num"
        Me.colBON_LIV_Num.MinWidth = 25
        Me.colBON_LIV_Num.Name = "colBON_LIV_Num"
        Me.colBON_LIV_Num.Visible = True
        Me.colBON_LIV_Num.VisibleIndex = 0
        Me.colBON_LIV_Num.Width = 94
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Nouveau", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Modifer", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Info", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Fermer", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(12, 657)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(982, 61)
        Me.WindowsUIButtonPanel1.TabIndex = 3
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.DateEditAu)
        Me.GroupControl1.Controls.Add(Me.DateEditDu)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(982, 115)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Recherche"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(463, 47)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(94, 29)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Actualiser"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(174, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 22)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Au"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 22)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Du"
        '
        'DateEditAu
        '
        Me.DateEditAu.EditValue = Nothing
        Me.DateEditAu.Location = New System.Drawing.Point(201, 54)
        Me.DateEditAu.Name = "DateEditAu"
        Me.DateEditAu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditAu.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditAu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditAu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditAu.Size = New System.Drawing.Size(125, 22)
        Me.DateEditAu.TabIndex = 1
        '
        'DateEditDu
        '
        Me.DateEditDu.EditValue = Nothing
        Me.DateEditDu.Location = New System.Drawing.Point(33, 54)
        Me.DateEditDu.Name = "DateEditDu"
        Me.DateEditDu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDu.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditDu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditDu.Size = New System.Drawing.Size(125, 22)
        Me.DateEditDu.TabIndex = 0
        '
        'frm_list_bl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_list_bl"
        Me.Text = "Bon de livraison"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.DateEditAu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditAu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditAu As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditDu As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BonlivraisonBindingSource As BindingSource
    Friend WithEvents colBON_LIV_CodeClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Etat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Montant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Num As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
