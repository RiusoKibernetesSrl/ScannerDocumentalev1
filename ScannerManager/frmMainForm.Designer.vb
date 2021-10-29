<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
        Me.btnAssociaDocumento = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbScannerItem = New DevExpress.XtraBars.BarEditItem()
        Me.cmbScanner = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnInviaAlProtocollo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSepara = New DevExpress.XtraBars.BarButtonItem()
        Me.btnElimina = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSvuotaTutto = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.mainGallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbScanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.mainGallery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainGallery.SuspendLayout()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.PopupMenu1
        Me.RibbonControl.ExpandCollapseItem.AllowDrawArrow = False
        Me.RibbonControl.ExpandCollapseItem.AllowDrawArrowInMenu = False
        Me.RibbonControl.ExpandCollapseItem.AllowRightClickInMenu = False
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonGroup1, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonGroup2, Me.BarButtonGroup3, Me.BarButtonGroup4, Me.btnAssociaDocumento, Me.cmbScannerItem, Me.btnInviaAlProtocollo, Me.btnSepara, Me.btnElimina, Me.btnSvuotaTutto})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 20
        Me.RibbonControl.MiniToolbars.Add(Me.RibbonMiniToolbar1)
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.cmbScanner})
        Me.RibbonControl.Size = New System.Drawing.Size(1112, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.Id = 2
        Me.BarButtonGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "View"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Rimuovi"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonGroup2
        '
        Me.BarButtonGroup2.Caption = "BarButtonGroup2"
        Me.BarButtonGroup2.Id = 5
        Me.BarButtonGroup2.Name = "BarButtonGroup2"
        '
        'BarButtonGroup3
        '
        Me.BarButtonGroup3.Caption = "BarButtonGroup3"
        Me.BarButtonGroup3.Id = 6
        Me.BarButtonGroup3.Name = "BarButtonGroup3"
        '
        'BarButtonGroup4
        '
        Me.BarButtonGroup4.Caption = "BarButtonGroup4"
        Me.BarButtonGroup4.Id = 7
        Me.BarButtonGroup4.Name = "BarButtonGroup4"
        '
        'btnAssociaDocumento
        '
        Me.btnAssociaDocumento.Caption = "Avvia Scansione"
        Me.btnAssociaDocumento.Id = 8
        Me.btnAssociaDocumento.ImageOptions.Image = CType(resources.GetObject("btnAssociaDocumento.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAssociaDocumento.ImageOptions.LargeImage = CType(resources.GetObject("btnAssociaDocumento.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAssociaDocumento.Name = "btnAssociaDocumento"
        '
        'cmbScannerItem
        '
        Me.cmbScannerItem.Caption = "Scanner"
        Me.cmbScannerItem.Edit = Me.cmbScanner
        Me.cmbScannerItem.EditWidth = 200
        Me.cmbScannerItem.Id = 15
        Me.cmbScannerItem.Name = "cmbScannerItem"
        '
        'cmbScanner
        '
        Me.cmbScanner.AutoHeight = False
        Me.cmbScanner.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbScanner.Name = "cmbScanner"
        Me.cmbScanner.NullText = ""
        '
        'btnInviaAlProtocollo
        '
        Me.btnInviaAlProtocollo.Caption = "Invia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al Protocollo"
        Me.btnInviaAlProtocollo.Id = 16
        Me.btnInviaAlProtocollo.ImageOptions.Image = CType(resources.GetObject("btnInviaAlProtocollo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInviaAlProtocollo.ImageOptions.LargeImage = CType(resources.GetObject("btnInviaAlProtocollo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnInviaAlProtocollo.Name = "btnInviaAlProtocollo"
        '
        'btnSepara
        '
        Me.btnSepara.Caption = "Separa"
        Me.btnSepara.Enabled = False
        Me.btnSepara.Id = 17
        Me.btnSepara.ImageOptions.Image = CType(resources.GetObject("btnSepara.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSepara.ImageOptions.LargeImage = CType(resources.GetObject("btnSepara.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSepara.Name = "btnSepara"
        '
        'btnElimina
        '
        Me.btnElimina.Caption = "Elimina"
        Me.btnElimina.Enabled = False
        Me.btnElimina.Id = 18
        Me.btnElimina.ImageOptions.Image = CType(resources.GetObject("btnElimina.ImageOptions.Image"), System.Drawing.Image)
        Me.btnElimina.ImageOptions.LargeImage = CType(resources.GetObject("btnElimina.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnElimina.Name = "btnElimina"
        '
        'btnSvuotaTutto
        '
        Me.btnSvuotaTutto.Caption = "Svuota Tutto"
        Me.btnSvuotaTutto.Id = 19
        Me.btnSvuotaTutto.ImageOptions.Image = CType(resources.GetObject("btnSvuotaTutto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSvuotaTutto.ImageOptions.LargeImage = CType(resources.GetObject("btnSvuotaTutto.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSvuotaTutto.Name = "btnSvuotaTutto"
        '
        'RibbonMiniToolbar1
        '
        Me.RibbonMiniToolbar1.ItemLinks.Add(Me.BarButtonGroup1)
        Me.RibbonMiniToolbar1.ItemLinks.Add(Me.BarButtonGroup2)
        Me.RibbonMiniToolbar1.ItemLinks.Add(Me.BarButtonGroup3)
        Me.RibbonMiniToolbar1.ItemLinks.Add(Me.BarButtonGroup4)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Gestione Documenti"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAssociaDocumento)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnInviaAlProtocollo)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Gestione Documenti"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSepara)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnElimina)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSvuotaTutto)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Sessione Corrente"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cmbScannerItem)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Impostazioni"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 738)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1112, 31)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.mainGallery)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 143)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(312, 595)
        Me.PanelControl1.TabIndex = 2
        '
        'mainGallery
        '
        Me.mainGallery.AllowDrop = True
        Me.mainGallery.Controls.Add(Me.GalleryControlClient1)
        Me.mainGallery.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.mainGallery.Gallery.ClearSelectionOnClickEmptySpace = True
        Me.mainGallery.Gallery.ImageSize = New System.Drawing.Size(128, 128)
        Me.mainGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
        Me.mainGallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
        Me.mainGallery.Gallery.ShowItemText = True
        Me.mainGallery.Location = New System.Drawing.Point(2, 2)
        Me.mainGallery.Name = "mainGallery"
        Me.mainGallery.Size = New System.Drawing.Size(308, 591)
        Me.mainGallery.TabIndex = 0
        Me.mainGallery.Text = "GalleryControl1"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.mainGallery
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(287, 587)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("3edabcd4-76ce-48f3-900d-8b3fb7c4715a")
        Me.DockPanel1.Location = New System.Drawing.Point(312, 143)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowAutoHideButton = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.Options.ShowMaximizeButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(800, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(800, 595)
        Me.DockPanel1.Text = "Preview"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.PictureEdit1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(791, 568)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.MenuManager = Me.RibbonControl
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(791, 568)
        Me.PictureEdit1.TabIndex = 0
        '
        'frmMainForm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 769)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.Name = "frmMainForm"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Scanner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbScanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.mainGallery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainGallery.ResumeLayout(False)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents mainGallery As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents RibbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents btnAssociaDocumento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmbScannerItem As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmbScanner As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnInviaAlProtocollo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSepara As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnElimina As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSvuotaTutto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
