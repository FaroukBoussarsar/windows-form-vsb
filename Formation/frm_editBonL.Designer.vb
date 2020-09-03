<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_editBonL
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
        Dim BON_LIV_CodeClientLabel As System.Windows.Forms.Label
        Dim BON_LIV_DateLabel As System.Windows.Forms.Label
        Dim BON_LIV_EtatLabel As System.Windows.Forms.Label
        Dim BON_LIV_NumLabel As System.Windows.Forms.Label
        Dim BON_LIV_ReglerLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editBonL))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.RemiseSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.BON_LIV_NumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Bon_livraisonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BON_LIV_DateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BON_LIV_ReglerCheckEdit = New DevExpress.XtraEditors.ToggleSwitch()
        Me.BON_LIV_EtatTextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EtatbonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEtat_bon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BON_LIV_CodeClientTextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCLI_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_NomPren = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.LignebonlivraisonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLG_BON_Liv_CodeArt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ArticleRepositoryItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colART_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_Designation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colART_TVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLG_BON_Liv_Qte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colLG_BON_Liv_PUHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colLG_BON_Liv_Tva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colLG_BON_Liv_Remise = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colLG_BON_Liv_NumOrdre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLG_BON_Liv_PUTTC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colLG_BON_Liv_TotalTTC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.ColDesArt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Valider = New DevExpress.XtraEditors.SimpleButton()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        BON_LIV_CodeClientLabel = New System.Windows.Forms.Label()
        BON_LIV_DateLabel = New System.Windows.Forms.Label()
        BON_LIV_EtatLabel = New System.Windows.Forms.Label()
        BON_LIV_NumLabel = New System.Windows.Forms.Label()
        BON_LIV_ReglerLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RemiseSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_NumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bon_livraisonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_ReglerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_EtatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtatbonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BON_LIV_CodeClientTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LignebonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleRepositoryItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BON_LIV_CodeClientLabel
        '
        BON_LIV_CodeClientLabel.AutoSize = True
        BON_LIV_CodeClientLabel.Location = New System.Drawing.Point(391, 41)
        BON_LIV_CodeClientLabel.Name = "BON_LIV_CodeClientLabel"
        BON_LIV_CodeClientLabel.Size = New System.Drawing.Size(41, 17)
        BON_LIV_CodeClientLabel.TabIndex = 0
        BON_LIV_CodeClientLabel.Text = "Client"
        '
        'BON_LIV_DateLabel
        '
        BON_LIV_DateLabel.AutoSize = True
        BON_LIV_DateLabel.Location = New System.Drawing.Point(391, 77)
        BON_LIV_DateLabel.Name = "BON_LIV_DateLabel"
        BON_LIV_DateLabel.Size = New System.Drawing.Size(37, 17)
        BON_LIV_DateLabel.TabIndex = 2
        BON_LIV_DateLabel.Text = "Date"
        '
        'BON_LIV_EtatLabel
        '
        BON_LIV_EtatLabel.AutoSize = True
        BON_LIV_EtatLabel.Location = New System.Drawing.Point(77, 77)
        BON_LIV_EtatLabel.Name = "BON_LIV_EtatLabel"
        BON_LIV_EtatLabel.Size = New System.Drawing.Size(33, 17)
        BON_LIV_EtatLabel.TabIndex = 4
        BON_LIV_EtatLabel.Text = "Etat"
        AddHandler BON_LIV_EtatLabel.Click, AddressOf Me.BON_LIV_EtatLabel_Click
        '
        'BON_LIV_NumLabel
        '
        BON_LIV_NumLabel.AutoSize = True
        BON_LIV_NumLabel.Location = New System.Drawing.Point(77, 41)
        BON_LIV_NumLabel.Name = "BON_LIV_NumLabel"
        BON_LIV_NumLabel.Size = New System.Drawing.Size(17, 17)
        BON_LIV_NumLabel.TabIndex = 6
        BON_LIV_NumLabel.Text = "N"
        '
        'BON_LIV_ReglerLabel
        '
        BON_LIV_ReglerLabel.AutoSize = True
        BON_LIV_ReglerLabel.Location = New System.Drawing.Point(682, 41)
        BON_LIV_ReglerLabel.Name = "BON_LIV_ReglerLabel"
        BON_LIV_ReglerLabel.Size = New System.Drawing.Size(46, 17)
        BON_LIV_ReglerLabel.TabIndex = 8
        BON_LIV_ReglerLabel.Text = "Regler"
        AddHandler BON_LIV_ReglerLabel.Click, AddressOf Me.BON_LIV_ReglerLabel_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(678, 77)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 17)
        Label2.TabIndex = 9
        Label2.Text = "Remise"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.RemiseSpinEdit)
        Me.GroupControl1.Controls.Add(BON_LIV_ReglerLabel)
        Me.GroupControl1.Controls.Add(BON_LIV_NumLabel)
        Me.GroupControl1.Controls.Add(Me.BON_LIV_NumTextEdit)
        Me.GroupControl1.Controls.Add(BON_LIV_EtatLabel)
        Me.GroupControl1.Controls.Add(BON_LIV_DateLabel)
        Me.GroupControl1.Controls.Add(Me.BON_LIV_DateDateEdit)
        Me.GroupControl1.Controls.Add(BON_LIV_CodeClientLabel)
        Me.GroupControl1.Controls.Add(Me.BON_LIV_ReglerCheckEdit)
        Me.GroupControl1.Controls.Add(Me.BON_LIV_EtatTextEdit)
        Me.GroupControl1.Controls.Add(Me.BON_LIV_CodeClientTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1180, 130)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Information"
        '
        'RemiseSpinEdit
        '
        Me.RemiseSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.RemiseSpinEdit.Location = New System.Drawing.Point(730, 74)
        Me.RemiseSpinEdit.Name = "RemiseSpinEdit"
        Me.RemiseSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RemiseSpinEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.RemiseSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RemiseSpinEdit.Properties.Mask.EditMask = "n3"
        Me.RemiseSpinEdit.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.RemiseSpinEdit.Size = New System.Drawing.Size(90, 22)
        Me.RemiseSpinEdit.TabIndex = 4
        '
        'BON_LIV_NumTextEdit
        '
        Me.BON_LIV_NumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Bon_livraisonBindingSource, "BON_LIV_Num", True))
        Me.BON_LIV_NumTextEdit.Enabled = False
        Me.BON_LIV_NumTextEdit.EnterMoveNextControl = True
        Me.BON_LIV_NumTextEdit.Location = New System.Drawing.Point(131, 38)
        Me.BON_LIV_NumTextEdit.Name = "BON_LIV_NumTextEdit"
        Me.BON_LIV_NumTextEdit.Size = New System.Drawing.Size(164, 22)
        Me.BON_LIV_NumTextEdit.TabIndex = 0
        '
        'Bon_livraisonBindingSource
        '
        Me.Bon_livraisonBindingSource.DataSource = GetType(FormationModel.Bon_livraison)
        '
        'BON_LIV_DateDateEdit
        '
        Me.BON_LIV_DateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Bon_livraisonBindingSource, "BON_LIV_Date", True))
        Me.BON_LIV_DateDateEdit.EditValue = Nothing
        Me.BON_LIV_DateDateEdit.EnterMoveNextControl = True
        Me.BON_LIV_DateDateEdit.Location = New System.Drawing.Point(449, 74)
        Me.BON_LIV_DateDateEdit.Name = "BON_LIV_DateDateEdit"
        Me.BON_LIV_DateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BON_LIV_DateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BON_LIV_DateDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.BON_LIV_DateDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.BON_LIV_DateDateEdit.Size = New System.Drawing.Size(164, 22)
        Me.BON_LIV_DateDateEdit.TabIndex = 4
        '
        'BON_LIV_ReglerCheckEdit
        '
        Me.BON_LIV_ReglerCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Bon_livraisonBindingSource, "BON_LIV_Regler", True))
        Me.BON_LIV_ReglerCheckEdit.EnterMoveNextControl = True
        Me.BON_LIV_ReglerCheckEdit.Location = New System.Drawing.Point(730, 35)
        Me.BON_LIV_ReglerCheckEdit.Name = "BON_LIV_ReglerCheckEdit"
        Me.BON_LIV_ReglerCheckEdit.Properties.OffText = "Non"
        Me.BON_LIV_ReglerCheckEdit.Properties.OnText = "Oui"
        Me.BON_LIV_ReglerCheckEdit.Size = New System.Drawing.Size(180, 28)
        Me.BON_LIV_ReglerCheckEdit.TabIndex = 2
        '
        'BON_LIV_EtatTextEdit
        '
        Me.BON_LIV_EtatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Bon_livraisonBindingSource, "BON_LIV_Etat", True))
        Me.BON_LIV_EtatTextEdit.EnterMoveNextControl = True
        Me.BON_LIV_EtatTextEdit.Location = New System.Drawing.Point(131, 74)
        Me.BON_LIV_EtatTextEdit.Name = "BON_LIV_EtatTextEdit"
        Me.BON_LIV_EtatTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BON_LIV_EtatTextEdit.Properties.DataSource = Me.EtatbonBindingSource
        Me.BON_LIV_EtatTextEdit.Properties.DisplayMember = "Etat_bon"
        Me.BON_LIV_EtatTextEdit.Properties.NullText = ""
        Me.BON_LIV_EtatTextEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.BON_LIV_EtatTextEdit.Properties.ValueMember = "Etat_bon_code"
        Me.BON_LIV_EtatTextEdit.Size = New System.Drawing.Size(164, 22)
        Me.BON_LIV_EtatTextEdit.TabIndex = 3
        '
        'EtatbonBindingSource
        '
        Me.EtatbonBindingSource.DataSource = GetType(FormationModel.Etat_bon)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEtat_bon})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colEtat_bon
        '
        Me.colEtat_bon.Caption = "Etat"
        Me.colEtat_bon.FieldName = "Etat_bon"
        Me.colEtat_bon.Name = "colEtat_bon"
        Me.colEtat_bon.Visible = True
        Me.colEtat_bon.VisibleIndex = 0
        '
        'BON_LIV_CodeClientTextEdit
        '
        Me.BON_LIV_CodeClientTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Bon_livraisonBindingSource, "BON_LIV_CodeClient", True))
        Me.BON_LIV_CodeClientTextEdit.EnterMoveNextControl = True
        Me.BON_LIV_CodeClientTextEdit.Location = New System.Drawing.Point(449, 38)
        Me.BON_LIV_CodeClientTextEdit.Name = "BON_LIV_CodeClientTextEdit"
        Me.BON_LIV_CodeClientTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BON_LIV_CodeClientTextEdit.Properties.DataSource = Me.ClientBindingSource
        Me.BON_LIV_CodeClientTextEdit.Properties.DisplayMember = "CLI_NomPren"
        Me.BON_LIV_CodeClientTextEdit.Properties.NullText = ""
        Me.BON_LIV_CodeClientTextEdit.Properties.PopupView = Me.GridView2
        Me.BON_LIV_CodeClientTextEdit.Properties.ValueMember = "CLI_Code"
        Me.BON_LIV_CodeClientTextEdit.Size = New System.Drawing.Size(164, 22)
        Me.BON_LIV_CodeClientTextEdit.TabIndex = 1
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(FormationModel.Client)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCLI_Code, Me.colCLI_NomPren})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCLI_Code
        '
        Me.colCLI_Code.Caption = "Code"
        Me.colCLI_Code.FieldName = "CLI_Code"
        Me.colCLI_Code.Name = "colCLI_Code"
        Me.colCLI_Code.Visible = True
        Me.colCLI_Code.VisibleIndex = 0
        '
        'colCLI_NomPren
        '
        Me.colCLI_NomPren.Caption = "Intitule"
        Me.colCLI_NomPren.FieldName = "CLI_NomPren"
        Me.colCLI_NomPren.Name = "colCLI_NomPren"
        Me.colCLI_NomPren.Visible = True
        Me.colCLI_NomPren.VisibleIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.LignebonlivraisonBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 126)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ArticleRepositoryItemGridLookUpEdit, Me.RepositoryItemComboBox1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemCalcEdit2, Me.RepositoryItemCalcEdit3, Me.RepositoryItemCalcEdit4, Me.RepositoryItemCalcEdit5, Me.RepositoryItemCalcEdit6})
        Me.GridControl1.Size = New System.Drawing.Size(1166, 533)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'LignebonlivraisonBindingSource
        '
        Me.LignebonlivraisonBindingSource.DataSource = GetType(FormationModel.Ligne_bon_livraison)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLG_BON_Liv_CodeArt, Me.colLG_BON_Liv_Qte, Me.colLG_BON_Liv_PUHT, Me.colLG_BON_Liv_Tva, Me.colLG_BON_Liv_Remise, Me.colLG_BON_Liv_NumOrdre, Me.colLG_BON_Liv_PUTTC, Me.colLG_BON_Liv_TotalTTC, Me.ColDesArt})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colLG_BON_Liv_CodeArt
        '
        Me.colLG_BON_Liv_CodeArt.Caption = "Code"
        Me.colLG_BON_Liv_CodeArt.ColumnEdit = Me.ArticleRepositoryItemGridLookUpEdit
        Me.colLG_BON_Liv_CodeArt.FieldName = "LG_BON_Liv_CodeArt"
        Me.colLG_BON_Liv_CodeArt.MinWidth = 25
        Me.colLG_BON_Liv_CodeArt.Name = "colLG_BON_Liv_CodeArt"
        Me.colLG_BON_Liv_CodeArt.Visible = True
        Me.colLG_BON_Liv_CodeArt.VisibleIndex = 1
        Me.colLG_BON_Liv_CodeArt.Width = 106
        '
        'ArticleRepositoryItemGridLookUpEdit
        '
        Me.ArticleRepositoryItemGridLookUpEdit.AutoHeight = False
        Me.ArticleRepositoryItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ArticleRepositoryItemGridLookUpEdit.DataSource = Me.ArticleBindingSource
        Me.ArticleRepositoryItemGridLookUpEdit.DisplayMember = "ART_Code"
        Me.ArticleRepositoryItemGridLookUpEdit.Name = "ArticleRepositoryItemGridLookUpEdit"
        Me.ArticleRepositoryItemGridLookUpEdit.NullText = ""
        Me.ArticleRepositoryItemGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.ArticleRepositoryItemGridLookUpEdit.ValueMember = "ART_Code"
        '
        'ArticleBindingSource
        '
        Me.ArticleBindingSource.DataSource = GetType(FormationModel.Article)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colART_Code, Me.colART_Designation, Me.colART_TVA})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colART_Code
        '
        Me.colART_Code.FieldName = "ART_Code"
        Me.colART_Code.Name = "colART_Code"
        Me.colART_Code.Visible = True
        Me.colART_Code.VisibleIndex = 0
        '
        'colART_Designation
        '
        Me.colART_Designation.FieldName = "ART_Designation"
        Me.colART_Designation.Name = "colART_Designation"
        Me.colART_Designation.Visible = True
        Me.colART_Designation.VisibleIndex = 1
        '
        'colART_TVA
        '
        Me.colART_TVA.FieldName = "ART_TVA"
        Me.colART_TVA.Name = "colART_TVA"
        Me.colART_TVA.Visible = True
        Me.colART_TVA.VisibleIndex = 2
        '
        'colLG_BON_Liv_Qte
        '
        Me.colLG_BON_Liv_Qte.Caption = "Qte"
        Me.colLG_BON_Liv_Qte.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colLG_BON_Liv_Qte.FieldName = "LG_BON_Liv_Qte"
        Me.colLG_BON_Liv_Qte.MinWidth = 25
        Me.colLG_BON_Liv_Qte.Name = "colLG_BON_Liv_Qte"
        Me.colLG_BON_Liv_Qte.Visible = True
        Me.colLG_BON_Liv_Qte.VisibleIndex = 3
        Me.colLG_BON_Liv_Qte.Width = 106
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'colLG_BON_Liv_PUHT
        '
        Me.colLG_BON_Liv_PUHT.Caption = "P.U.HT"
        Me.colLG_BON_Liv_PUHT.ColumnEdit = Me.RepositoryItemCalcEdit2
        Me.colLG_BON_Liv_PUHT.FieldName = "LG_BON_Liv_PUHT"
        Me.colLG_BON_Liv_PUHT.MinWidth = 25
        Me.colLG_BON_Liv_PUHT.Name = "colLG_BON_Liv_PUHT"
        Me.colLG_BON_Liv_PUHT.Visible = True
        Me.colLG_BON_Liv_PUHT.VisibleIndex = 4
        Me.colLG_BON_Liv_PUHT.Width = 103
        '
        'RepositoryItemCalcEdit2
        '
        Me.RepositoryItemCalcEdit2.AutoHeight = False
        Me.RepositoryItemCalcEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit2.Name = "RepositoryItemCalcEdit2"
        '
        'colLG_BON_Liv_Tva
        '
        Me.colLG_BON_Liv_Tva.Caption = "TVA"
        Me.colLG_BON_Liv_Tva.ColumnEdit = Me.RepositoryItemCalcEdit3
        Me.colLG_BON_Liv_Tva.FieldName = "LG_BON_Liv_Tva"
        Me.colLG_BON_Liv_Tva.MinWidth = 25
        Me.colLG_BON_Liv_Tva.Name = "colLG_BON_Liv_Tva"
        Me.colLG_BON_Liv_Tva.Visible = True
        Me.colLG_BON_Liv_Tva.VisibleIndex = 5
        Me.colLG_BON_Liv_Tva.Width = 103
        '
        'RepositoryItemCalcEdit3
        '
        Me.RepositoryItemCalcEdit3.AutoHeight = False
        Me.RepositoryItemCalcEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit3.Name = "RepositoryItemCalcEdit3"
        '
        'colLG_BON_Liv_Remise
        '
        Me.colLG_BON_Liv_Remise.Caption = "Remise"
        Me.colLG_BON_Liv_Remise.ColumnEdit = Me.RepositoryItemCalcEdit4
        Me.colLG_BON_Liv_Remise.FieldName = "LG_BON_Liv_Remise"
        Me.colLG_BON_Liv_Remise.MinWidth = 25
        Me.colLG_BON_Liv_Remise.Name = "colLG_BON_Liv_Remise"
        Me.colLG_BON_Liv_Remise.Visible = True
        Me.colLG_BON_Liv_Remise.VisibleIndex = 6
        Me.colLG_BON_Liv_Remise.Width = 103
        '
        'RepositoryItemCalcEdit4
        '
        Me.RepositoryItemCalcEdit4.AutoHeight = False
        Me.RepositoryItemCalcEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit4.Name = "RepositoryItemCalcEdit4"
        '
        'colLG_BON_Liv_NumOrdre
        '
        Me.colLG_BON_Liv_NumOrdre.Caption = " "
        Me.colLG_BON_Liv_NumOrdre.FieldName = "LG_BON_Liv_NumOrdre"
        Me.colLG_BON_Liv_NumOrdre.MaxWidth = 35
        Me.colLG_BON_Liv_NumOrdre.MinWidth = 35
        Me.colLG_BON_Liv_NumOrdre.Name = "colLG_BON_Liv_NumOrdre"
        Me.colLG_BON_Liv_NumOrdre.OptionsColumn.AllowEdit = False
        Me.colLG_BON_Liv_NumOrdre.OptionsColumn.AllowFocus = False
        Me.colLG_BON_Liv_NumOrdre.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LG_BON_Liv_NumOrdre", "{0}")})
        Me.colLG_BON_Liv_NumOrdre.Visible = True
        Me.colLG_BON_Liv_NumOrdre.VisibleIndex = 0
        Me.colLG_BON_Liv_NumOrdre.Width = 35
        '
        'colLG_BON_Liv_PUTTC
        '
        Me.colLG_BON_Liv_PUTTC.Caption = "P.U.TTC"
        Me.colLG_BON_Liv_PUTTC.ColumnEdit = Me.RepositoryItemCalcEdit5
        Me.colLG_BON_Liv_PUTTC.FieldName = "LG_BON_Liv_PUTTC"
        Me.colLG_BON_Liv_PUTTC.MinWidth = 25
        Me.colLG_BON_Liv_PUTTC.Name = "colLG_BON_Liv_PUTTC"
        Me.colLG_BON_Liv_PUTTC.Visible = True
        Me.colLG_BON_Liv_PUTTC.VisibleIndex = 7
        Me.colLG_BON_Liv_PUTTC.Width = 103
        '
        'RepositoryItemCalcEdit5
        '
        Me.RepositoryItemCalcEdit5.AutoHeight = False
        Me.RepositoryItemCalcEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit5.Name = "RepositoryItemCalcEdit5"
        '
        'colLG_BON_Liv_TotalTTC
        '
        Me.colLG_BON_Liv_TotalTTC.Caption = "TTC"
        Me.colLG_BON_Liv_TotalTTC.ColumnEdit = Me.RepositoryItemCalcEdit6
        Me.colLG_BON_Liv_TotalTTC.FieldName = "LG_BON_Liv_TotalTTC"
        Me.colLG_BON_Liv_TotalTTC.MinWidth = 25
        Me.colLG_BON_Liv_TotalTTC.Name = "colLG_BON_Liv_TotalTTC"
        Me.colLG_BON_Liv_TotalTTC.OptionsColumn.AllowEdit = False
        Me.colLG_BON_Liv_TotalTTC.OptionsColumn.AllowFocus = False
        Me.colLG_BON_Liv_TotalTTC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LG_BON_Liv_TotalTTC", "SUM={0:0.##}")})
        Me.colLG_BON_Liv_TotalTTC.Visible = True
        Me.colLG_BON_Liv_TotalTTC.VisibleIndex = 8
        Me.colLG_BON_Liv_TotalTTC.Width = 108
        '
        'RepositoryItemCalcEdit6
        '
        Me.RepositoryItemCalcEdit6.AutoHeight = False
        Me.RepositoryItemCalcEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit6.Name = "RepositoryItemCalcEdit6"
        '
        'ColDesArt
        '
        Me.ColDesArt.Caption = "Designnaton"
        Me.ColDesArt.FieldName = "ArticleMember.ART_Designation"
        Me.ColDesArt.MinWidth = 25
        Me.ColDesArt.Name = "ColDesArt"
        Me.ColDesArt.OptionsColumn.AllowEdit = False
        Me.ColDesArt.OptionsColumn.AllowFocus = False
        Me.ColDesArt.Visible = True
        Me.ColDesArt.VisibleIndex = 2
        Me.ColDesArt.Width = 106
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btn_Fermer)
        Me.PanelControl1.Controls.Add(Me.btn_Valider)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 653)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1166, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'btn_Fermer
        '
        Me.btn_Fermer.ImageOptions.Image = CType(resources.GetObject("btn_Fermer.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Fermer.Location = New System.Drawing.Point(706, 3)
        Me.btn_Fermer.Name = "btn_Fermer"
        Me.btn_Fermer.Size = New System.Drawing.Size(141, 46)
        Me.btn_Fermer.TabIndex = 23
        Me.btn_Fermer.Text = "Fermer"
        '
        'btn_Valider
        '
        Me.btn_Valider.ImageOptions.Image = CType(resources.GetObject("btn_Valider.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Valider.Location = New System.Drawing.Point(312, 3)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(145, 46)
        Me.btn_Valider.TabIndex = 22
        Me.btn_Valider.Text = "valider"
        '
        'frm_editBonL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 721)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximumSize = New System.Drawing.Size(1210, 768)
        Me.MinimumSize = New System.Drawing.Size(1210, 768)
        Me.Name = "frm_editBonL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bon de livraison"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.RemiseSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_NumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bon_livraisonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_DateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_DateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_ReglerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_EtatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtatbonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BON_LIV_CodeClientTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LignebonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleRepositoryItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LignebonlivraisonBindingSource As BindingSource
    Friend WithEvents colLG_BON_Liv_CodeArt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ArticleRepositoryItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLG_BON_Liv_Qte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colLG_BON_Liv_PUHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colLG_BON_Liv_Tva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colLG_BON_Liv_Remise As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colLG_BON_Liv_NumOrdre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLG_BON_Liv_PUTTC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colLG_BON_Liv_TotalTTC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents ColDesArt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ArticleBindingSource As BindingSource
    Friend WithEvents colART_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_Designation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colART_TVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bon_livraisonBindingSource As BindingSource
    Friend WithEvents BON_LIV_NumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BON_LIV_DateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BON_LIV_ReglerCheckEdit As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BON_LIV_EtatTextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BON_LIV_CodeClientTextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents EtatbonBindingSource As BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Valider As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colEtat_bon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_NomPren As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RemiseSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
