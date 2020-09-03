<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ActifLabel As System.Windows.Forms.Label
        Dim CLI_AdresseLabel As System.Windows.Forms.Label
        Dim CLI_CodeLabel As System.Windows.Forms.Label
        Dim CLI_VilleLabel As System.Windows.Forms.Label
        Dim CLI_Tel1Label As System.Windows.Forms.Label
        Dim Clt_CINLabel As System.Windows.Forms.Label
        Dim CLI_NomPrenLabel As System.Windows.Forms.Label
        Dim CLI_MatFiscLabel As System.Windows.Forms.Label
        Dim CLI_ObsLabel As System.Windows.Forms.Label
        Dim CLI_mailLabel As System.Windows.Forms.Label
        Dim CLI_TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditClient))
        Me.CLI_CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLI_VilleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_Tel1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Clt_CINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_NomPrenTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_MatFiscTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_mailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActifCheckEdit = New DevExpress.XtraEditors.ToggleSwitch()
        Me.CLI_AdresseTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CLI_ObsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_Valider = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.CLI_TypeTextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TypeclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTYP_Client = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.TypeclientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ActifLabel = New System.Windows.Forms.Label()
        CLI_AdresseLabel = New System.Windows.Forms.Label()
        CLI_CodeLabel = New System.Windows.Forms.Label()
        CLI_VilleLabel = New System.Windows.Forms.Label()
        CLI_Tel1Label = New System.Windows.Forms.Label()
        Clt_CINLabel = New System.Windows.Forms.Label()
        CLI_NomPrenLabel = New System.Windows.Forms.Label()
        CLI_MatFiscLabel = New System.Windows.Forms.Label()
        CLI_ObsLabel = New System.Windows.Forms.Label()
        CLI_mailLabel = New System.Windows.Forms.Label()
        CLI_TypeLabel = New System.Windows.Forms.Label()
        CType(Me.CLI_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_VilleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_Tel1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clt_CINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_NomPrenTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_MatFiscTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_mailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_AdresseTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeclientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActifLabel
        '
        ActifLabel.AutoSize = True
        ActifLabel.Location = New System.Drawing.Point(510, 225)
        ActifLabel.Name = "ActifLabel"
        ActifLabel.Size = New System.Drawing.Size(39, 17)
        ActifLabel.TabIndex = 1
        ActifLabel.Text = "Actif:"
        AddHandler ActifLabel.Click, AddressOf Me.ActifLabel_Click
        '
        'CLI_AdresseLabel
        '
        CLI_AdresseLabel.AutoSize = True
        CLI_AdresseLabel.Location = New System.Drawing.Point(74, 269)
        CLI_AdresseLabel.Name = "CLI_AdresseLabel"
        CLI_AdresseLabel.Size = New System.Drawing.Size(60, 17)
        CLI_AdresseLabel.TabIndex = 3
        CLI_AdresseLabel.Text = "Adresse"
        '
        'CLI_CodeLabel
        '
        CLI_CodeLabel.AutoSize = True
        CLI_CodeLabel.Location = New System.Drawing.Point(74, 51)
        CLI_CodeLabel.Name = "CLI_CodeLabel"
        CLI_CodeLabel.Size = New System.Drawing.Size(41, 17)
        CLI_CodeLabel.TabIndex = 5
        CLI_CodeLabel.Text = "Code"
        '
        'CLI_VilleLabel
        '
        CLI_VilleLabel.AutoSize = True
        CLI_VilleLabel.Location = New System.Drawing.Point(74, 213)
        CLI_VilleLabel.Name = "CLI_VilleLabel"
        CLI_VilleLabel.Size = New System.Drawing.Size(34, 17)
        CLI_VilleLabel.TabIndex = 7
        CLI_VilleLabel.Text = "Ville"
        AddHandler CLI_VilleLabel.Click, AddressOf Me.CLI_VilleLabel_Click
        '
        'CLI_Tel1Label
        '
        CLI_Tel1Label.AutoSize = True
        CLI_Tel1Label.Location = New System.Drawing.Point(510, 135)
        CLI_Tel1Label.Name = "CLI_Tel1Label"
        CLI_Tel1Label.Size = New System.Drawing.Size(36, 17)
        CLI_Tel1Label.TabIndex = 9
        CLI_Tel1Label.Text = "Tel1"
        '
        'Clt_CINLabel
        '
        Clt_CINLabel.AutoSize = True
        Clt_CINLabel.Location = New System.Drawing.Point(74, 154)
        Clt_CINLabel.Name = "Clt_CINLabel"
        Clt_CINLabel.Size = New System.Drawing.Size(30, 17)
        Clt_CINLabel.TabIndex = 11
        Clt_CINLabel.Text = "CIN"
        '
        'CLI_NomPrenLabel
        '
        CLI_NomPrenLabel.AutoSize = True
        CLI_NomPrenLabel.Location = New System.Drawing.Point(74, 100)
        CLI_NomPrenLabel.Name = "CLI_NomPrenLabel"
        CLI_NomPrenLabel.Size = New System.Drawing.Size(71, 17)
        CLI_NomPrenLabel.TabIndex = 13
        CLI_NomPrenLabel.Text = "Nom Pren"
        '
        'CLI_MatFiscLabel
        '
        CLI_MatFiscLabel.AutoSize = True
        CLI_MatFiscLabel.Location = New System.Drawing.Point(510, 42)
        CLI_MatFiscLabel.Name = "CLI_MatFiscLabel"
        CLI_MatFiscLabel.Size = New System.Drawing.Size(94, 17)
        CLI_MatFiscLabel.TabIndex = 15
        CLI_MatFiscLabel.Text = "Matricule Fisc"
        '
        'CLI_ObsLabel
        '
        CLI_ObsLabel.AutoSize = True
        CLI_ObsLabel.Location = New System.Drawing.Point(510, 269)
        CLI_ObsLabel.Name = "CLI_ObsLabel"
        CLI_ObsLabel.Size = New System.Drawing.Size(85, 17)
        CLI_ObsLabel.TabIndex = 17
        CLI_ObsLabel.Text = "Observation"
        '
        'CLI_mailLabel
        '
        CLI_mailLabel.AutoSize = True
        CLI_mailLabel.Location = New System.Drawing.Point(510, 89)
        CLI_mailLabel.Name = "CLI_mailLabel"
        CLI_mailLabel.Size = New System.Drawing.Size(33, 17)
        CLI_mailLabel.TabIndex = 19
        CLI_mailLabel.Text = "mail"
        '
        'CLI_TypeLabel
        '
        CLI_TypeLabel.AutoSize = True
        CLI_TypeLabel.Location = New System.Drawing.Point(510, 183)
        CLI_TypeLabel.Name = "CLI_TypeLabel"
        CLI_TypeLabel.Size = New System.Drawing.Size(68, 17)
        CLI_TypeLabel.TabIndex = 23
        CLI_TypeLabel.Text = "CLI Type:"
        '
        'CLI_CodeTextEdit
        '
        Me.CLI_CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Code", True))
        Me.CLI_CodeTextEdit.EnterMoveNextControl = True
        Me.CLI_CodeTextEdit.Location = New System.Drawing.Point(177, 48)
        Me.CLI_CodeTextEdit.Name = "CLI_CodeTextEdit"
        Me.CLI_CodeTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_CodeTextEdit.TabIndex = 0
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(FormationModel.Client)
        '
        'CLI_VilleTextEdit
        '
        Me.CLI_VilleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Ville", True))
        Me.CLI_VilleTextEdit.EnterMoveNextControl = True
        Me.CLI_VilleTextEdit.Location = New System.Drawing.Point(177, 208)
        Me.CLI_VilleTextEdit.Name = "CLI_VilleTextEdit"
        Me.CLI_VilleTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_VilleTextEdit.TabIndex = 6
        '
        'CLI_Tel1TextEdit
        '
        Me.CLI_Tel1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Tel1", True))
        Me.CLI_Tel1TextEdit.EnterMoveNextControl = True
        Me.CLI_Tel1TextEdit.Location = New System.Drawing.Point(614, 130)
        Me.CLI_Tel1TextEdit.Name = "CLI_Tel1TextEdit"
        Me.CLI_Tel1TextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_Tel1TextEdit.TabIndex = 5
        '
        'Clt_CINTextEdit
        '
        Me.Clt_CINTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "Clt_CIN", True))
        Me.Clt_CINTextEdit.EnterMoveNextControl = True
        Me.Clt_CINTextEdit.Location = New System.Drawing.Point(177, 151)
        Me.Clt_CINTextEdit.Name = "Clt_CINTextEdit"
        Me.Clt_CINTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.Clt_CINTextEdit.TabIndex = 4
        '
        'CLI_NomPrenTextEdit
        '
        Me.CLI_NomPrenTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_NomPren", True))
        Me.CLI_NomPrenTextEdit.EnterMoveNextControl = True
        Me.CLI_NomPrenTextEdit.Location = New System.Drawing.Point(177, 97)
        Me.CLI_NomPrenTextEdit.Name = "CLI_NomPrenTextEdit"
        Me.CLI_NomPrenTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_NomPrenTextEdit.TabIndex = 2
        '
        'CLI_MatFiscTextEdit
        '
        Me.CLI_MatFiscTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_MatFisc", True))
        Me.CLI_MatFiscTextEdit.EnterMoveNextControl = True
        Me.CLI_MatFiscTextEdit.Location = New System.Drawing.Point(614, 37)
        Me.CLI_MatFiscTextEdit.Name = "CLI_MatFiscTextEdit"
        Me.CLI_MatFiscTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_MatFiscTextEdit.TabIndex = 1
        '
        'CLI_mailTextEdit
        '
        Me.CLI_mailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_mail", True))
        Me.CLI_mailTextEdit.EnterMoveNextControl = True
        Me.CLI_mailTextEdit.Location = New System.Drawing.Point(614, 86)
        Me.CLI_mailTextEdit.Name = "CLI_mailTextEdit"
        Me.CLI_mailTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_mailTextEdit.TabIndex = 3
        '
        'ActifCheckEdit
        '
        Me.ActifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "Actif", True))
        Me.ActifCheckEdit.EnterMoveNextControl = True
        Me.ActifCheckEdit.Location = New System.Drawing.Point(617, 219)
        Me.ActifCheckEdit.Name = "ActifCheckEdit"
        Me.ActifCheckEdit.Properties.OffText = "Non"
        Me.ActifCheckEdit.Properties.OnText = "Oui"
        Me.ActifCheckEdit.Size = New System.Drawing.Size(153, 28)
        Me.ActifCheckEdit.TabIndex = 9
        '
        'CLI_AdresseTextEdit
        '
        Me.CLI_AdresseTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Adresse", True))
        Me.CLI_AdresseTextEdit.Location = New System.Drawing.Point(177, 266)
        Me.CLI_AdresseTextEdit.Name = "CLI_AdresseTextEdit"
        Me.CLI_AdresseTextEdit.Size = New System.Drawing.Size(156, 73)
        Me.CLI_AdresseTextEdit.TabIndex = 8
        '
        'CLI_ObsTextEdit
        '
        Me.CLI_ObsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Obs", True))
        Me.CLI_ObsTextEdit.Location = New System.Drawing.Point(614, 266)
        Me.CLI_ObsTextEdit.Name = "CLI_ObsTextEdit"
        Me.CLI_ObsTextEdit.Size = New System.Drawing.Size(156, 73)
        Me.CLI_ObsTextEdit.TabIndex = 10
        '
        'btn_Valider
        '
        Me.btn_Valider.ImageOptions.Image = CType(resources.GetObject("btn_Valider.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Valider.Location = New System.Drawing.Point(279, 358)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(111, 51)
        Me.btn_Valider.TabIndex = 20
        Me.btn_Valider.Text = "valider"
        '
        'btn_Fermer
        '
        Me.btn_Fermer.ImageOptions.Image = CType(resources.GetObject("btn_Fermer.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Fermer.Location = New System.Drawing.Point(501, 358)
        Me.btn_Fermer.Name = "btn_Fermer"
        Me.btn_Fermer.Size = New System.Drawing.Size(113, 51)
        Me.btn_Fermer.TabIndex = 21
        Me.btn_Fermer.Text = "Fermer"
        '
        'CLI_TypeTextEdit
        '
        Me.CLI_TypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Type", True))
        Me.CLI_TypeTextEdit.EnterMoveNextControl = True
        Me.CLI_TypeTextEdit.Location = New System.Drawing.Point(617, 180)
        Me.CLI_TypeTextEdit.Name = "CLI_TypeTextEdit"
        Me.CLI_TypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CLI_TypeTextEdit.Properties.DataSource = Me.TypeclientBindingSource
        Me.CLI_TypeTextEdit.Properties.DisplayMember = "TYP_Client"
        Me.CLI_TypeTextEdit.Properties.NullText = ""
        Me.CLI_TypeTextEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.CLI_TypeTextEdit.Properties.ValueMember = "TYP_Client"
        Me.CLI_TypeTextEdit.Size = New System.Drawing.Size(153, 22)
        Me.CLI_TypeTextEdit.TabIndex = 7
        '
        'TypeclientBindingSource
        '
        Me.TypeclientBindingSource.DataSource = GetType(FormationModel.Type_client)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTYP_Client})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colTYP_Client
        '
        Me.colTYP_Client.Caption = "Type"
        Me.colTYP_Client.FieldName = "TYP_Client"
        Me.colTYP_Client.Name = "colTYP_Client"
        Me.colTYP_Client.Visible = True
        Me.colTYP_Client.VisibleIndex = 0
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'TypeclientBindingSource1
        '
        Me.TypeclientBindingSource1.DataSource = GetType(FormationModel.Type_client)
        '
        'EditClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(843, 450)
        Me.Controls.Add(CLI_TypeLabel)
        Me.Controls.Add(Me.btn_Fermer)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(CLI_mailLabel)
        Me.Controls.Add(Me.CLI_mailTextEdit)
        Me.Controls.Add(CLI_ObsLabel)
        Me.Controls.Add(CLI_MatFiscLabel)
        Me.Controls.Add(Me.CLI_MatFiscTextEdit)
        Me.Controls.Add(CLI_NomPrenLabel)
        Me.Controls.Add(Me.CLI_NomPrenTextEdit)
        Me.Controls.Add(Clt_CINLabel)
        Me.Controls.Add(Me.Clt_CINTextEdit)
        Me.Controls.Add(CLI_Tel1Label)
        Me.Controls.Add(Me.CLI_Tel1TextEdit)
        Me.Controls.Add(CLI_VilleLabel)
        Me.Controls.Add(Me.CLI_VilleTextEdit)
        Me.Controls.Add(CLI_CodeLabel)
        Me.Controls.Add(Me.CLI_CodeTextEdit)
        Me.Controls.Add(CLI_AdresseLabel)
        Me.Controls.Add(ActifLabel)
        Me.Controls.Add(Me.ActifCheckEdit)
        Me.Controls.Add(Me.CLI_AdresseTextEdit)
        Me.Controls.Add(Me.CLI_ObsTextEdit)
        Me.Controls.Add(Me.CLI_TypeTextEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(861, 497)
        Me.MinimumSize = New System.Drawing.Size(861, 497)
        Me.Name = "EditClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditClient"
        CType(Me.CLI_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_VilleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_Tel1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clt_CINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_NomPrenTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_MatFiscTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_mailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_AdresseTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeclientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents CLI_CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_VilleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_Tel1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Clt_CINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_NomPrenTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_MatFiscTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_mailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActifCheckEdit As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents CLI_AdresseTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CLI_ObsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_Valider As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CLI_TypeTextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TypeclientBindingSource As BindingSource
    Friend WithEvents TypeclientBindingSource1 As BindingSource
    Friend WithEvents colTYP_Client As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
