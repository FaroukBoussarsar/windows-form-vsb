<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edittaille
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
        Dim TailleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edittaille))
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Art_tailleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TailleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Valider = New DevExpress.XtraEditors.SimpleButton()
        TailleLabel = New System.Windows.Forms.Label()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Art_tailleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TailleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TailleLabel
        '
        TailleLabel.AutoSize = True
        TailleLabel.Location = New System.Drawing.Point(159, 70)
        TailleLabel.Name = "TailleLabel"
        TailleLabel.Size = New System.Drawing.Size(41, 17)
        TailleLabel.TabIndex = 1
        TailleLabel.Text = "taille:"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Art_tailleBindingSource
        '
        Me.Art_tailleBindingSource.DataSource = GetType(FormationModel.Art_taille)
        '
        'TailleTextEdit
        '
        Me.TailleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Art_tailleBindingSource, "taille", True))
        Me.TailleTextEdit.Location = New System.Drawing.Point(206, 67)
        Me.TailleTextEdit.Name = "TailleTextEdit"
        Me.TailleTextEdit.Size = New System.Drawing.Size(125, 22)
        Me.TailleTextEdit.TabIndex = 2
        '
        'btn_Fermer
        '
        Me.btn_Fermer.ImageOptions.Image = CType(resources.GetObject("btn_Fermer.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Fermer.Location = New System.Drawing.Point(287, 148)
        Me.btn_Fermer.Name = "btn_Fermer"
        Me.btn_Fermer.Size = New System.Drawing.Size(113, 51)
        Me.btn_Fermer.TabIndex = 23
        Me.btn_Fermer.Text = "Fermer"
        '
        'btn_Valider
        '
        Me.btn_Valider.ImageOptions.Image = CType(resources.GetObject("btn_Valider.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Valider.Location = New System.Drawing.Point(65, 148)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(111, 51)
        Me.btn_Valider.TabIndex = 22
        Me.btn_Valider.Text = "valider"
        '
        'edittaille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 211)
        Me.Controls.Add(Me.btn_Fermer)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(TailleLabel)
        Me.Controls.Add(Me.TailleTextEdit)
        Me.Name = "edittaille"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edittaille"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Art_tailleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TailleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents TailleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Art_tailleBindingSource As BindingSource
    Friend WithEvents btn_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Valider As DevExpress.XtraEditors.SimpleButton
End Class
