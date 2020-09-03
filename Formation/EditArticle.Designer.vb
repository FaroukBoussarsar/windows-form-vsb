<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditArticle
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
        Dim Photo_PathLabel As System.Windows.Forms.Label
        Dim ART_CouleurLabel As System.Windows.Forms.Label
        Dim ART_CodeLabel As System.Windows.Forms.Label
        Dim ART_DesignationLabel As System.Windows.Forms.Label
        Dim ART_MarqueLabel As System.Windows.Forms.Label
        Dim ART_QteStockLabel As System.Windows.Forms.Label
        Dim ART_PrixUnitaireHTLabel As System.Windows.Forms.Label
        Dim ART_TVALabel As System.Windows.Forms.Label
        Dim ART_TAILLELabel As System.Windows.Forms.Label
        Dim ART_Poid_QteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditArticle))
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.btn_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Valider = New DevExpress.XtraEditors.SimpleButton()
        Me.Photo_PathTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ART_CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ART_DesignationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ART_MarqueTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.ART_CouleurTextEdit = New DevExpress.XtraEditors.ColorPickEdit()
        Me.ART_PrixUnitaireHTSpinEdit = New DevExpress.XtraEditors.CalcEdit()
        Me.ART_QteStockSpinEdit = New DevExpress.XtraEditors.CalcEdit()
        Me.ART_Poid_QteTextEdit = New DevExpress.XtraEditors.CalcEdit()
        Me.ART_TVASpinEdit = New DevExpress.XtraEditors.CalcEdit()
        Me.ART_TAILLETextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ArttailleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coltaille = New DevExpress.XtraGrid.Columns.GridColumn()
        Photo_PathLabel = New System.Windows.Forms.Label()
        ART_CouleurLabel = New System.Windows.Forms.Label()
        ART_CodeLabel = New System.Windows.Forms.Label()
        ART_DesignationLabel = New System.Windows.Forms.Label()
        ART_MarqueLabel = New System.Windows.Forms.Label()
        ART_QteStockLabel = New System.Windows.Forms.Label()
        ART_PrixUnitaireHTLabel = New System.Windows.Forms.Label()
        ART_TVALabel = New System.Windows.Forms.Label()
        ART_TAILLELabel = New System.Windows.Forms.Label()
        ART_Poid_QteLabel = New System.Windows.Forms.Label()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo_PathTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_MarqueTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_CouleurTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_PrixUnitaireHTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_QteStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_Poid_QteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_TVASpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ART_TAILLETextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArttailleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Photo_PathLabel
        '
        Photo_PathLabel.AutoSize = True
        Photo_PathLabel.Location = New System.Drawing.Point(456, 290)
        Photo_PathLabel.Name = "Photo_PathLabel"
        Photo_PathLabel.Size = New System.Drawing.Size(77, 17)
        Photo_PathLabel.TabIndex = 24
        Photo_PathLabel.Text = "photo Path"
        '
        'ART_CouleurLabel
        '
        ART_CouleurLabel.AutoSize = True
        ART_CouleurLabel.Location = New System.Drawing.Point(52, 217)
        ART_CouleurLabel.Name = "ART_CouleurLabel"
        ART_CouleurLabel.Size = New System.Drawing.Size(55, 17)
        ART_CouleurLabel.TabIndex = 25
        ART_CouleurLabel.Text = "Couleur"
        '
        'ART_CodeLabel
        '
        ART_CodeLabel.AutoSize = True
        ART_CodeLabel.Location = New System.Drawing.Point(52, 32)
        ART_CodeLabel.Name = "ART_CodeLabel"
        ART_CodeLabel.Size = New System.Drawing.Size(40, 17)
        ART_CodeLabel.TabIndex = 26
        ART_CodeLabel.Text = "Code"
        '
        'ART_DesignationLabel
        '
        ART_DesignationLabel.AutoSize = True
        ART_DesignationLabel.Location = New System.Drawing.Point(52, 87)
        ART_DesignationLabel.Name = "ART_DesignationLabel"
        ART_DesignationLabel.Size = New System.Drawing.Size(79, 17)
        ART_DesignationLabel.TabIndex = 27
        ART_DesignationLabel.Text = "Designation"
        '
        'ART_MarqueLabel
        '
        ART_MarqueLabel.AutoSize = True
        ART_MarqueLabel.Location = New System.Drawing.Point(52, 277)
        ART_MarqueLabel.Name = "ART_MarqueLabel"
        ART_MarqueLabel.Size = New System.Drawing.Size(53, 17)
        ART_MarqueLabel.TabIndex = 28
        ART_MarqueLabel.Text = "Marque"
        '
        'ART_QteStockLabel
        '
        ART_QteStockLabel.AutoSize = True
        ART_QteStockLabel.Location = New System.Drawing.Point(464, 32)
        ART_QteStockLabel.Name = "ART_QteStockLabel"
        ART_QteStockLabel.Size = New System.Drawing.Size(69, 17)
        ART_QteStockLabel.TabIndex = 30
        ART_QteStockLabel.Text = "Qte Stock"
        '
        'ART_PrixUnitaireHTLabel
        '
        ART_PrixUnitaireHTLabel.AutoSize = True
        ART_PrixUnitaireHTLabel.Location = New System.Drawing.Point(464, 100)
        ART_PrixUnitaireHTLabel.Name = "ART_PrixUnitaireHTLabel"
        ART_PrixUnitaireHTLabel.Size = New System.Drawing.Size(50, 17)
        ART_PrixUnitaireHTLabel.TabIndex = 31
        ART_PrixUnitaireHTLabel.Text = "PU.H.T"
        '
        'ART_TVALabel
        '
        ART_TVALabel.AutoSize = True
        ART_TVALabel.Location = New System.Drawing.Point(464, 229)
        ART_TVALabel.Name = "ART_TVALabel"
        ART_TVALabel.Size = New System.Drawing.Size(32, 17)
        ART_TVALabel.TabIndex = 32
        ART_TVALabel.Text = "TVA"
        '
        'ART_TAILLELabel
        '
        ART_TAILLELabel.AutoSize = True
        ART_TAILLELabel.Location = New System.Drawing.Point(57, 157)
        ART_TAILLELabel.Name = "ART_TAILLELabel"
        ART_TAILLELabel.Size = New System.Drawing.Size(50, 17)
        ART_TAILLELabel.TabIndex = 33
        ART_TAILLELabel.Text = "TAILLE"
        '
        'ART_Poid_QteLabel
        '
        ART_Poid_QteLabel.AutoSize = True
        ART_Poid_QteLabel.Location = New System.Drawing.Point(464, 166)
        ART_Poid_QteLabel.Name = "ART_Poid_QteLabel"
        ART_Poid_QteLabel.Size = New System.Drawing.Size(98, 17)
        ART_Poid_QteLabel.TabIndex = 34
        ART_Poid_QteLabel.Text = "Poid Qte en kg"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'btn_Fermer
        '
        Me.btn_Fermer.ImageOptions.Image = CType(resources.GetObject("btn_Fermer.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Fermer.Location = New System.Drawing.Point(470, 387)
        Me.btn_Fermer.Name = "btn_Fermer"
        Me.btn_Fermer.Size = New System.Drawing.Size(113, 51)
        Me.btn_Fermer.TabIndex = 11
        Me.btn_Fermer.Text = "Fermer"
        '
        'btn_Valider
        '
        Me.btn_Valider.ImageOptions.Image = CType(resources.GetObject("btn_Valider.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Valider.Location = New System.Drawing.Point(248, 387)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(111, 51)
        Me.btn_Valider.TabIndex = 10
        Me.btn_Valider.Text = "valider"
        '
        'Photo_PathTextEdit
        '
        Me.Photo_PathTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "photo_Path", True))
        Me.Photo_PathTextEdit.Location = New System.Drawing.Point(562, 289)
        Me.Photo_PathTextEdit.Name = "Photo_PathTextEdit"
        Me.Photo_PathTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.Photo_PathTextEdit.TabIndex = 9
        '
        'ArticleBindingSource
        '
        Me.ArticleBindingSource.DataSource = GetType(FormationModel.Article)
        '
        'ART_CodeTextEdit
        '
        Me.ART_CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_Code", True))
        Me.ART_CodeTextEdit.Location = New System.Drawing.Point(132, 31)
        Me.ART_CodeTextEdit.Name = "ART_CodeTextEdit"
        Me.ART_CodeTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_CodeTextEdit.TabIndex = 0
        '
        'ART_DesignationTextEdit
        '
        Me.ART_DesignationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_Designation", True))
        Me.ART_DesignationTextEdit.Location = New System.Drawing.Point(132, 86)
        Me.ART_DesignationTextEdit.Name = "ART_DesignationTextEdit"
        Me.ART_DesignationTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_DesignationTextEdit.TabIndex = 1
        '
        'ART_MarqueTextEdit
        '
        Me.ART_MarqueTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_Marque", True))
        Me.ART_MarqueTextEdit.Location = New System.Drawing.Point(132, 276)
        Me.ART_MarqueTextEdit.Name = "ART_MarqueTextEdit"
        Me.ART_MarqueTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_MarqueTextEdit.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(768, 285)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 29)
        Me.SimpleButton1.TabIndex = 35
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'ART_CouleurTextEdit
        '
        Me.ART_CouleurTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_Couleur", True))
        Me.ART_CouleurTextEdit.EditValue = System.Drawing.Color.Empty
        Me.ART_CouleurTextEdit.Location = New System.Drawing.Point(132, 216)
        Me.ART_CouleurTextEdit.Name = "ART_CouleurTextEdit"
        Me.ART_CouleurTextEdit.Properties.AutomaticColor = System.Drawing.Color.Black
        Me.ART_CouleurTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_CouleurTextEdit.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ART_CouleurTextEdit.Properties.ColorDialogOptions.ShowTabs = DevExpress.XtraEditors.ShowTabs.HSBModel
        Me.ART_CouleurTextEdit.Properties.ShowCustomColors = False
        Me.ART_CouleurTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ART_CouleurTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_CouleurTextEdit.TabIndex = 3
        '
        'ART_PrixUnitaireHTSpinEdit
        '
        Me.ART_PrixUnitaireHTSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_PrixUnitaireHT", True))
        Me.ART_PrixUnitaireHTSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ART_PrixUnitaireHTSpinEdit.Location = New System.Drawing.Point(565, 97)
        Me.ART_PrixUnitaireHTSpinEdit.Name = "ART_PrixUnitaireHTSpinEdit"
        Me.ART_PrixUnitaireHTSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_PrixUnitaireHTSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ART_PrixUnitaireHTSpinEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_PrixUnitaireHTSpinEdit.TabIndex = 6
        '
        'ART_QteStockSpinEdit
        '
        Me.ART_QteStockSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_QteStock", True))
        Me.ART_QteStockSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ART_QteStockSpinEdit.Location = New System.Drawing.Point(565, 29)
        Me.ART_QteStockSpinEdit.Name = "ART_QteStockSpinEdit"
        Me.ART_QteStockSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_QteStockSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ART_QteStockSpinEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_QteStockSpinEdit.TabIndex = 5
        '
        'ART_Poid_QteTextEdit
        '
        Me.ART_Poid_QteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_Poid_Qte", True))
        Me.ART_Poid_QteTextEdit.Location = New System.Drawing.Point(565, 163)
        Me.ART_Poid_QteTextEdit.Name = "ART_Poid_QteTextEdit"
        Me.ART_Poid_QteTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_Poid_QteTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ART_Poid_QteTextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_Poid_QteTextEdit.TabIndex = 7
        '
        'ART_TVASpinEdit
        '
        Me.ART_TVASpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_TVA", True))
        Me.ART_TVASpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ART_TVASpinEdit.Location = New System.Drawing.Point(565, 226)
        Me.ART_TVASpinEdit.Name = "ART_TVASpinEdit"
        Me.ART_TVASpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_TVASpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ART_TVASpinEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_TVASpinEdit.TabIndex = 8
        '
        'ART_TAILLETextEdit
        '
        Me.ART_TAILLETextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ArticleBindingSource, "ART_TAILLE", True))
        Me.ART_TAILLETextEdit.Location = New System.Drawing.Point(132, 154)
        Me.ART_TAILLETextEdit.Name = "ART_TAILLETextEdit"
        Me.ART_TAILLETextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ART_TAILLETextEdit.Properties.DataSource = Me.ArttailleBindingSource
        Me.ART_TAILLETextEdit.Properties.DisplayMember = "taille"
        Me.ART_TAILLETextEdit.Properties.NullText = ""
        Me.ART_TAILLETextEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ART_TAILLETextEdit.Properties.ValueMember = "taille"
        Me.ART_TAILLETextEdit.Size = New System.Drawing.Size(200, 22)
        Me.ART_TAILLETextEdit.TabIndex = 2
        '
        'ArttailleBindingSource
        '
        Me.ArttailleBindingSource.DataSource = GetType(FormationModel.Art_taille)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltaille})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'coltaille
        '
        Me.coltaille.Caption = "taille"
        Me.coltaille.FieldName = "taille"
        Me.coltaille.Name = "coltaille"
        Me.coltaille.Visible = True
        Me.coltaille.VisibleIndex = 0
        '
        'EditArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(843, 450)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(ART_Poid_QteLabel)
        Me.Controls.Add(ART_TAILLELabel)
        Me.Controls.Add(ART_TVALabel)
        Me.Controls.Add(ART_PrixUnitaireHTLabel)
        Me.Controls.Add(ART_QteStockLabel)
        Me.Controls.Add(ART_MarqueLabel)
        Me.Controls.Add(Me.ART_MarqueTextEdit)
        Me.Controls.Add(ART_DesignationLabel)
        Me.Controls.Add(Me.ART_DesignationTextEdit)
        Me.Controls.Add(ART_CodeLabel)
        Me.Controls.Add(Me.ART_CodeTextEdit)
        Me.Controls.Add(ART_CouleurLabel)
        Me.Controls.Add(Photo_PathLabel)
        Me.Controls.Add(Me.Photo_PathTextEdit)
        Me.Controls.Add(Me.btn_Fermer)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.ART_CouleurTextEdit)
        Me.Controls.Add(Me.ART_PrixUnitaireHTSpinEdit)
        Me.Controls.Add(Me.ART_QteStockSpinEdit)
        Me.Controls.Add(Me.ART_Poid_QteTextEdit)
        Me.Controls.Add(Me.ART_TVASpinEdit)
        Me.Controls.Add(Me.ART_TAILLETextEdit)
        Me.MaximumSize = New System.Drawing.Size(861, 497)
        Me.MinimumSize = New System.Drawing.Size(861, 497)
        Me.Name = "EditArticle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditArticle"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo_PathTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_MarqueTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_CouleurTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_PrixUnitaireHTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_QteStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_Poid_QteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_TVASpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ART_TAILLETextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArttailleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents ArticleBindingSource As BindingSource
    Friend WithEvents ART_MarqueTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ART_DesignationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ART_CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Photo_PathTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Valider As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents ART_CouleurTextEdit As DevExpress.XtraEditors.ColorPickEdit
    Friend WithEvents ART_PrixUnitaireHTSpinEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ART_QteStockSpinEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ART_Poid_QteTextEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ART_TVASpinEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ART_TAILLETextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ArttailleBindingSource As BindingSource
    Friend WithEvents coltaille As DevExpress.XtraGrid.Columns.GridColumn
End Class
