Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.beZoom = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
        Me.skinGalleryBarItem = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.biAddToAlbum = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
        Me.BarButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
        Me.biCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.biClose = New DevExpress.XtraBars.BarButtonItem()
        Me.biCollage = New DevExpress.XtraBars.BarButtonItem()
        Me.biExportFolder = New DevExpress.XtraBars.BarButtonItem()
        Me.biGenerateData = New DevExpress.XtraBars.BarButtonItem()
        Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.biRemoveFilesFromLibrary = New DevExpress.XtraBars.BarButtonItem()
        Me.biRemoveAlbum = New DevExpress.XtraBars.BarButtonItem()
        Me.biSaveImage = New DevExpress.XtraBars.BarButtonItem()
        Me.biUpload = New DevExpress.XtraBars.BarButtonItem()
        Me.biView = New DevExpress.XtraBars.BarButtonItem()
        Me.biEmail = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbScannerItem = New DevExpress.XtraBars.BarEditItem()
        Me.cmbScanner = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar()
        Me.viewPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.collectionOriginalPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.filtersFilePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.documentiPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.outputPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.impostazioniPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager()
        Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.controlPresenter1 = New DevExpress.Utils.Controls.ControlPresenter()
        Me.libraryPanel = New System.Windows.Forms.UserControl()
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.albumPopupMenu = New DevExpress.XtraBars.PopupMenu()
        Me.folderPopupMenu = New DevExpress.XtraBars.PopupMenu()
        Me.albumsPopupMenu = New DevExpress.XtraBars.PopupMenu()
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.galleryContentPanel = New System.Windows.Forms.Panel()
        Me.galleryPanel = New System.Windows.Forms.Panel()
        Me.mainGallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        Me.galleryItemMenu = New DevExpress.XtraBars.PopupMenu()
        Me.addToLibraryMenu = New DevExpress.XtraBars.PopupMenu()
        Me.imageDialog = New System.Windows.Forms.OpenFileDialog()
        Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbScanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPresenter1.SuspendLayout()
        CType(Me.albumPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.folderPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.albumsPopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.galleryContentPanel.SuspendLayout()
        Me.galleryPanel.SuspendLayout()
        CType(Me.mainGallery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainGallery.SuspendLayout()
        CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.beZoom, Me.skinGalleryBarItem, Me.biAbout, Me.biAddToAlbum, Me.BarButtonGroup1, Me.BarButtonGroup2, Me.BarButtonGroup3, Me.BarButtonGroup4, Me.biCancel, Me.biClose, Me.biCollage, Me.biExportFolder, Me.biGenerateData, Me.biPrint, Me.biRemoveFilesFromLibrary, Me.biRemoveAlbum, Me.biSaveImage, Me.biUpload, Me.biView, Me.biEmail, Me.cmbScannerItem})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 23
        Me.ribbonControl1.MiniToolbars.Add(Me.RibbonMiniToolbar1)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorInQAT = True
        Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
        Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.viewPageCategory})
        Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.documentiPage})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemZoomTrackBar1, Me.cmbScanner})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(1112, 143)
        Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
        Me.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'beZoom
        '
        Me.beZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.beZoom.Edit = Me.RepositoryItemZoomTrackBar1
        Me.beZoom.EditValue = "128"
        Me.beZoom.EditWidth = 200
        Me.beZoom.Id = 2
        Me.beZoom.Name = "beZoom"
        '
        'RepositoryItemZoomTrackBar1
        '
        Me.RepositoryItemZoomTrackBar1.Name = "RepositoryItemZoomTrackBar1"
        '
        'skinGalleryBarItem
        '
        '
        '
        '
        Me.skinGalleryBarItem.Gallery.AllowHoverImages = True
        Me.skinGalleryBarItem.Gallery.FixedHoverImageSize = False
        Me.skinGalleryBarItem.Gallery.ImageSize = New System.Drawing.Size(58, 43)
        Me.skinGalleryBarItem.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
        Me.skinGalleryBarItem.Id = 3
        Me.skinGalleryBarItem.Name = "skinGalleryBarItem"
        '
        'biAbout
        '
        Me.biAbout.Caption = "&About"
        Me.biAbout.Id = 4
        Me.biAbout.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Help_16x16
        Me.biAbout.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Help_32x32
        Me.biAbout.Name = "biAbout"
        '
        'biAddToAlbum
        '
        Me.biAddToAlbum.Caption = "Associa Documento"
        Me.biAddToAlbum.Id = 5
        Me.biAddToAlbum.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.AddToAlbum_16x16
        Me.biAddToAlbum.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.AddToAlbum_32x32
        Me.biAddToAlbum.Name = "biAddToAlbum"
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.Id = 6
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        Me.BarButtonGroup1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'BarButtonGroup2
        '
        Me.BarButtonGroup2.Caption = "BarButtonGroup2"
        Me.BarButtonGroup2.Id = 7
        Me.BarButtonGroup2.Name = "BarButtonGroup2"
        Me.BarButtonGroup2.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'BarButtonGroup3
        '
        Me.BarButtonGroup3.Caption = "BarButtonGroup3"
        Me.BarButtonGroup3.Id = 8
        Me.BarButtonGroup3.Name = "BarButtonGroup3"
        Me.BarButtonGroup3.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'BarButtonGroup4
        '
        Me.BarButtonGroup4.Caption = "BarButtonGroup4"
        Me.BarButtonGroup4.Id = 9
        Me.BarButtonGroup4.Name = "BarButtonGroup4"
        Me.BarButtonGroup4.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'biCancel
        '
        Me.biCancel.Caption = "Annulla"
        Me.biCancel.Id = 10
        Me.biCancel.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Cancel_16x16
        Me.biCancel.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Cancel_32x32
        Me.biCancel.Name = "biCancel"
        '
        'biClose
        '
        Me.biClose.Caption = "Chiudi"
        Me.biClose.Id = 11
        Me.biClose.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Close_16x16
        Me.biClose.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Close_32x32
        Me.biClose.Name = "biClose"
        '
        'biCollage
        '
        Me.biCollage.Caption = "Protocolla"
        Me.biCollage.Id = 12
        Me.biCollage.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Collage_16x16
        Me.biCollage.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Collage_32x32
        Me.biCollage.Name = "biCollage"
        '
        'biExportFolder
        '
        Me.biExportFolder.Caption = "Export"
        Me.biExportFolder.Id = 13
        Me.biExportFolder.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Export_16x16
        Me.biExportFolder.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Export_32x32
        Me.biExportFolder.Name = "biExportFolder"
        '
        'biGenerateData
        '
        Me.biGenerateData.Caption = "Aggiorna Dati"
        Me.biGenerateData.Id = 14
        Me.biGenerateData.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.GenerateData_16x16
        Me.biGenerateData.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.GenerateData_32x32
        Me.biGenerateData.Name = "biGenerateData"
        '
        'biPrint
        '
        Me.biPrint.Caption = "Stampa"
        Me.biPrint.Id = 15
        Me.biPrint.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Print_16x16
        Me.biPrint.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Print_32x32
        Me.biPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.biPrint.Name = "biPrint"
        '
        'biRemoveFilesFromLibrary
        '
        Me.biRemoveFilesFromLibrary.Caption = "Rimuovi"
        Me.biRemoveFilesFromLibrary.Id = 16
        Me.biRemoveFilesFromLibrary.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Remove_16x16
        Me.biRemoveFilesFromLibrary.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Remove_32x32
        Me.biRemoveFilesFromLibrary.Name = "biRemoveFilesFromLibrary"
        '
        'biRemoveAlbum
        '
        Me.biRemoveAlbum.Caption = "Rimuovi Documento"
        Me.biRemoveAlbum.Id = 17
        Me.biRemoveAlbum.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.RemoveAlbum_16x16
        Me.biRemoveAlbum.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.RemoveAlbum_32x32
        Me.biRemoveAlbum.Name = "biRemoveAlbum"
        '
        'biSaveImage
        '
        Me.biSaveImage.Caption = "Salva"
        Me.biSaveImage.Id = 18
        Me.biSaveImage.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Save_16x16
        Me.biSaveImage.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Save_32x32
        Me.biSaveImage.Name = "biSaveImage"
        '
        'biUpload
        '
        Me.biUpload.Caption = "Upload"
        Me.biUpload.Id = 19
        Me.biUpload.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.Upload_16x16
        Me.biUpload.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.Upload_32x32
        Me.biUpload.Name = "biUpload"
        '
        'biView
        '
        Me.biView.Caption = "View"
        Me.biView.Id = 20
        Me.biView.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.View_16x16
        Me.biView.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.View_32x32
        Me.biView.Name = "biView"
        '
        'biEmail
        '
        Me.biEmail.Caption = "E-mail"
        Me.biEmail.Id = 21
        Me.biEmail.ImageOptions.Image = Global.ScannerTest.My.Resources.Resources.EMail_16x16
        Me.biEmail.ImageOptions.LargeImage = Global.ScannerTest.My.Resources.Resources.EMail_32x32
        Me.biEmail.Name = "biEmail"
        '
        'cmbScannerItem
        '
        Me.cmbScannerItem.Caption = "Scanner"
        Me.cmbScannerItem.Edit = Me.cmbScanner
        Me.cmbScannerItem.EditWidth = 200
        Me.cmbScannerItem.Id = 22
        Me.cmbScannerItem.Name = "cmbScannerItem"
        '
        'cmbScanner
        '
        Me.cmbScanner.AutoHeight = False
        Me.cmbScanner.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbScanner.Name = "cmbScanner"
        Me.cmbScanner.NullText = ""
        '
        'RibbonMiniToolbar1
        '
        Me.RibbonMiniToolbar1.Alignment = System.Drawing.ContentAlignment.TopRight
        Me.RibbonMiniToolbar1.ParentControl = Me
        '
        'viewPageCategory
        '
        Me.viewPageCategory.Name = "viewPageCategory"
        Me.viewPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.collectionOriginalPage})
        Me.viewPageCategory.Text = "View"
        Me.viewPageCategory.Visible = False
        '
        'collectionOriginalPage
        '
        Me.collectionOriginalPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.filtersFilePageGroup})
        Me.collectionOriginalPage.Name = "collectionOriginalPage"
        Me.collectionOriginalPage.Text = "Collection"
        Me.collectionOriginalPage.Visible = False
        '
        'filtersFilePageGroup
        '
        Me.filtersFilePageGroup.ItemLinks.Add(Me.biSaveImage)
        Me.filtersFilePageGroup.ItemLinks.Add(Me.biCancel)
        Me.filtersFilePageGroup.ItemLinks.Add(Me.biClose)
        Me.filtersFilePageGroup.Name = "filtersFilePageGroup"
        Me.filtersFilePageGroup.Text = "File"
        '
        'documentiPage
        '
        Me.documentiPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.outputPageGroup, Me.impostazioniPageGroup})
        Me.documentiPage.Name = "documentiPage"
        Me.documentiPage.Text = "Documenti"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.biAddToAlbum)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.biView)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        Me.ribbonPageGroup1.Text = "Generale"
        '
        'outputPageGroup
        '
        Me.outputPageGroup.ItemLinks.Add(Me.biExportFolder)
        Me.outputPageGroup.ItemLinks.Add(Me.biEmail)
        Me.outputPageGroup.ItemLinks.Add(Me.biUpload)
        Me.outputPageGroup.ItemLinks.Add(Me.biPrint)
        Me.outputPageGroup.Name = "outputPageGroup"
        Me.outputPageGroup.ShowCaptionButton = False
        Me.outputPageGroup.Text = "Output"
        '
        'impostazioniPageGroup
        '
        Me.impostazioniPageGroup.AllowTextClipping = False
        Me.impostazioniPageGroup.ItemLinks.Add(Me.cmbScannerItem)
        Me.impostazioniPageGroup.Name = "impostazioniPageGroup"
        Me.impostazioniPageGroup.Text = "Impostazioni"
        '
        'ribbonStatusBar1
        '
        Me.ribbonStatusBar1.ItemLinks.Add(Me.beZoom)
        Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 734)
        Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
        Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.ribbonStatusBar1.Size = New System.Drawing.Size(1112, 31)
        '
        'dockManager1
        '
        Me.dockManager1.Form = Me
        Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1})
        Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
        '
        'dockPanel1
        '
        Me.dockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dockPanel1.ID = New System.Guid("2414890a-089a-485e-ae36-9d17b9c1935f")
        Me.dockPanel1.Location = New System.Drawing.Point(312, 143)
        Me.dockPanel1.Name = "dockPanel1"
        Me.dockPanel1.Options.AllowFloating = False
        Me.dockPanel1.Options.FloatOnDblClick = False
        Me.dockPanel1.Options.ResizeDirection = DevExpress.XtraBars.Docking.Helpers.ResizeDirection.None
        Me.dockPanel1.Options.ShowAutoHideButton = False
        Me.dockPanel1.Options.ShowCloseButton = False
        Me.dockPanel1.Options.ShowMaximizeButton = False
        Me.dockPanel1.OriginalSize = New System.Drawing.Size(800, 200)
        Me.dockPanel1.SavedSizeFactor = 0R
        Me.dockPanel1.Size = New System.Drawing.Size(800, 591)
        Me.dockPanel1.Text = "Preview"
        '
        'DockPanel1_Container
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.DockPanel1_Container, DevExpress.Utils.DefaultBoolean.[Default])
        Me.DockPanel1_Container.Controls.Add(Me.PictureEdit1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(792, 564)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.MenuManager = Me.ribbonControl1
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(792, 564)
        Me.PictureEdit1.TabIndex = 0
        '
        'controlPresenter1
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.controlPresenter1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.controlPresenter1.Controls.Add(Me.libraryPanel)
        Me.controlPresenter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPresenter1.Location = New System.Drawing.Point(0, 143)
        Me.controlPresenter1.Name = "controlPresenter1"
        Me.controlPresenter1.SelectedControl = Me.libraryPanel
        Me.controlPresenter1.SelectedControlIndex = 0
        Me.controlPresenter1.Size = New System.Drawing.Size(1112, 595)
        Me.controlPresenter1.TabIndex = 10
        '
        'libraryPanel
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.libraryPanel, DevExpress.Utils.DefaultBoolean.[Default])
        Me.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.libraryPanel.Location = New System.Drawing.Point(0, 0)
        Me.libraryPanel.Name = "libraryPanel"
        Me.libraryPanel.Size = New System.Drawing.Size(1112, 595)
        Me.libraryPanel.TabIndex = 1
        '
        'albumPopupMenu
        '
        Me.albumPopupMenu.Name = "albumPopupMenu"
        Me.albumPopupMenu.Ribbon = Me.ribbonControl1
        Me.albumPopupMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'folderPopupMenu
        '
        Me.folderPopupMenu.Name = "folderPopupMenu"
        Me.folderPopupMenu.Ribbon = Me.ribbonControl1
        Me.folderPopupMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'albumsPopupMenu
        '
        Me.albumsPopupMenu.Name = "albumsPopupMenu"
        Me.albumsPopupMenu.Ribbon = Me.ribbonControl1
        Me.albumsPopupMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'printPreviewDialog1
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.printPreviewDialog1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.UseAntiAlias = True
        Me.printPreviewDialog1.Visible = False
        '
        'galleryContentPanel
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryContentPanel, DevExpress.Utils.DefaultBoolean.[Default])
        Me.galleryContentPanel.Controls.Add(Me.galleryPanel)
        Me.galleryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.galleryContentPanel.Location = New System.Drawing.Point(0, 143)
        Me.galleryContentPanel.Name = "galleryContentPanel"
        Me.galleryContentPanel.Padding = New System.Windows.Forms.Padding(6)
        Me.galleryContentPanel.Size = New System.Drawing.Size(312, 591)
        Me.galleryContentPanel.TabIndex = 2
        '
        'galleryPanel
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryPanel, DevExpress.Utils.DefaultBoolean.[Default])
        Me.galleryPanel.Controls.Add(Me.mainGallery)
        Me.galleryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.galleryPanel.Location = New System.Drawing.Point(6, 6)
        Me.galleryPanel.Name = "galleryPanel"
        Me.galleryPanel.Size = New System.Drawing.Size(300, 579)
        Me.galleryPanel.TabIndex = 1
        '
        'mainGallery
        '
        Me.mainGallery.Controls.Add(Me.GalleryControlClient1)
        Me.mainGallery.DesignGalleryGroupIndex = 0
        Me.mainGallery.DesignGalleryItemIndex = 0
        Me.mainGallery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGallery.Location = New System.Drawing.Point(0, 0)
        Me.mainGallery.Name = "mainGallery"
        Me.mainGallery.Size = New System.Drawing.Size(300, 579)
        Me.mainGallery.TabIndex = 0
        Me.mainGallery.Text = "galleryControl1"
        '
        'GalleryControlClient1
        '
        Me.defaultToolTipController1.SetAllowHtmlText(Me.GalleryControlClient1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.GalleryControlClient1.GalleryControl = Me.mainGallery
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(279, 575)
        '
        'galleryItemMenu
        '
        Me.galleryItemMenu.Name = "galleryItemMenu"
        Me.galleryItemMenu.Ribbon = Me.ribbonControl1
        Me.galleryItemMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'addToLibraryMenu
        '
        Me.addToLibraryMenu.Name = "addToLibraryMenu"
        Me.addToLibraryMenu.Ribbon = Me.ribbonControl1
        Me.addToLibraryMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'imageDialog
        '
        Me.imageDialog.FileName = "OpenFileDialog1"
        Me.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*"
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 765)
        Me.Controls.Add(Me.galleryContentPanel)
        Me.Controls.Add(Me.dockPanel1)
        Me.Controls.Add(Me.ribbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.ribbonStatusBar1
        Me.Text = "Scanner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbScanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlPresenter1.ResumeLayout(False)
        CType(Me.albumPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.folderPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.albumsPopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.galleryContentPanel.ResumeLayout(False)
        Me.galleryPanel.ResumeLayout(False)
        CType(Me.mainGallery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainGallery.ResumeLayout(False)
        CType(Me.galleryItemMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addToLibraryMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents documentiPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar
    Friend WithEvents dockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents folderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents albumPopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents folderPopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents albumsPopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents printPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents galleryItemMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents addToLibraryMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents imageDialog As OpenFileDialog
    Friend WithEvents beZoom As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
    Friend WithEvents skinGalleryBarItem As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents biAbout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biAddToAlbum As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents BarButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents biCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biCollage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biExportFolder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biGenerateData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biRemoveFilesFromLibrary As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biRemoveAlbum As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biSaveImage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biUpload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents viewPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents collectionOriginalPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents filtersFilePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents biEmail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents outputPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents impostazioniPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmbScannerItem As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmbScanner As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Private libraryPanel As System.Windows.Forms.UserControl
    Friend WithEvents galleryContentPanel As Panel
    Friend WithEvents galleryPanel As Panel
    Friend WithEvents mainGallery As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    Friend WithEvents dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents controlPresenter1 As DevExpress.Utils.Controls.ControlPresenter
End Class
