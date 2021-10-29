<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametriScanner
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnSalva = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ckFronteRetro = New DevExpress.XtraEditors.CheckEdit()
        Me.ckUI = New DevExpress.XtraEditors.CheckEdit()
        Me.cmbScanner = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbRisoluzioneDpi = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbRisoluzioneColore = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtPortalUrl = New DevExpress.XtraEditors.TextEdit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ckFronteRetro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckUI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbScanner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRisoluzioneDpi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRisoluzioneColore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPortalUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalva})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(451, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnSalva
        '
        Me.btnSalva.Image = Global.ScannerTest.My.Resources.Resources.Save_16x16
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(28, 20)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tipo Scanner"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Risoluzione Dpi"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 155)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Portal URL"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(270, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Tipo Immagine"
        '
        'ckFronteRetro
        '
        Me.ckFronteRetro.Location = New System.Drawing.Point(270, 60)
        Me.ckFronteRetro.Name = "ckFronteRetro"
        Me.ckFronteRetro.Properties.Caption = "Fronte Retro"
        Me.ckFronteRetro.Size = New System.Drawing.Size(86, 19)
        Me.ckFronteRetro.TabIndex = 9
        '
        'ckUI
        '
        Me.ckUI.Location = New System.Drawing.Point(400, 60)
        Me.ckUI.Name = "ckUI"
        Me.ckUI.Properties.Caption = "UI"
        Me.ckUI.Size = New System.Drawing.Size(41, 19)
        Me.ckUI.TabIndex = 10
        '
        'cmbScanner
        '
        Me.cmbScanner.Location = New System.Drawing.Point(10, 60)
        Me.cmbScanner.Name = "cmbScanner"
        Me.cmbScanner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbScanner.Properties.NullText = ""
        Me.cmbScanner.Size = New System.Drawing.Size(211, 20)
        Me.cmbScanner.TabIndex = 11
        '
        'cmbRisoluzioneDpi
        '
        Me.cmbRisoluzioneDpi.Location = New System.Drawing.Point(10, 115)
        Me.cmbRisoluzioneDpi.Name = "cmbRisoluzioneDpi"
        Me.cmbRisoluzioneDpi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRisoluzioneDpi.Properties.NullText = ""
        Me.cmbRisoluzioneDpi.Size = New System.Drawing.Size(211, 20)
        Me.cmbRisoluzioneDpi.TabIndex = 12
        '
        'cmbRisoluzioneColore
        '
        Me.cmbRisoluzioneColore.Location = New System.Drawing.Point(270, 115)
        Me.cmbRisoluzioneColore.Name = "cmbRisoluzioneColore"
        Me.cmbRisoluzioneColore.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRisoluzioneColore.Properties.NullText = ""
        Me.cmbRisoluzioneColore.Size = New System.Drawing.Size(151, 20)
        Me.cmbRisoluzioneColore.TabIndex = 13
        '
        'txtPortalUrl
        '
        Me.txtPortalUrl.Location = New System.Drawing.Point(10, 170)
        Me.txtPortalUrl.Name = "txtPortalUrl"
        Me.txtPortalUrl.Size = New System.Drawing.Size(411, 20)
        Me.txtPortalUrl.TabIndex = 15
        '
        'frmParametriScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 219)
        Me.Controls.Add(Me.txtPortalUrl)
        Me.Controls.Add(Me.cmbRisoluzioneColore)
        Me.Controls.Add(Me.cmbRisoluzioneDpi)
        Me.Controls.Add(Me.cmbScanner)
        Me.Controls.Add(Me.ckUI)
        Me.Controls.Add(Me.ckFronteRetro)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmParametriScanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impostazioni Scanner"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ckFronteRetro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckUI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbScanner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRisoluzioneDpi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRisoluzioneColore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPortalUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnSalva As ToolStripMenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckFronteRetro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ckUI As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbScanner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbRisoluzioneDpi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbRisoluzioneColore As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtPortalUrl As DevExpress.XtraEditors.TextEdit
End Class
