Imports System.IO
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Partial Public Class Form1
    Inherits RibbonForm
    Public Shared HoverSkinImageSize As New Size(116, 86)
    Public Shared SkinImageSize As New Size(58, 43)

    Private Scanner As Kibernetes.Services.ScannerLibrary.Scanner
    Public Sub New()
        InitializeComponent()
        Scanner = New Kibernetes.Services.ScannerLibrary.Scanner(Me)
        InitSkins()
        InitParametri()
        InitiScanner()
        SelectDefaultPage()
        LoadData()
        '  AddHandler Scanner.twain.ScanningComplete, AddressOf ScanningComplete
        'Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(Form1).Assembly)
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    '    SplashScreenManager.CloseForm()
    'End Sub  

    Protected ReadOnly Property ViewDataFile() As String
        Get
            Return System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Tracciato"), "FileScannerrizzati.xml")
        End Get
    End Property
    Private Sub InitSkins()
        ' SkinHelper.InitSkinGallery(skinGalleryBarItem, True)
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
    End Sub
    Private Sub SelectDefaultPage()
        ribbonControl1.SelectedPage = documentiPage
    End Sub
    Private Sub ScanningComplete()
        'Scanner.QrTrovato = True
        'Scanner.QrTrovatoPrecedente = False
        'If Scanner.IsPrintable = False Then
        '    Exit Sub
        'End If
        'mainGallery.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
        'mainGallery.Gallery.ImageSize = New Size(180, 120)
        'mainGallery.Gallery.ShowItemText = True

        'If Scanner.noQR IsNot Nothing Then
        '    Scanner.lstDocumenti.Add(Scanner.noQR)
        '    Scanner.noQR = Nothing
        'End If

        'Scanner.SerializzaListaFile()
        'LoadData()
        'Enabled = True
        'Scanner.IsPrintable = False
    End Sub
    Public Sub InitParametri()
        Kibernetes.Services.ScannerLibrary.Utility.Utils.CreateConfigurationFileScanner()
    End Sub
    Private Sub InitiScanner()
        cmbScanner.DataSource = Scanner.twain.SourceNames
        Dim obj As New Parametri.Parametro
        Dim ParametroDati = obj.ReadXml

        If ParametroDati IsNot Nothing AndAlso ParametroDati.DefaultScanner IsNot Nothing Then
            cmbScannerItem.EditValue = ParametroDati.DefaultScanner
        Else
            If Scanner.twain.SourceNames IsNot Nothing AndAlso Scanner.twain.SourceNames.Count = 1 Then
                cmbScannerItem.EditValue = Scanner.twain.SourceNames.Item(0)
            End If
        End If
    End Sub
    Private viewData_Renamed As ScannerViewerData
    Protected ReadOnly Property ViewData() As ScannerViewerData
        Get
            If viewData_Renamed Is Nothing Then
                viewData_Renamed = New ScannerViewerData()
            End If
            Return viewData_Renamed
        End Get
    End Property
    Private Sub LoadData()
        For Each t In Scanner.lstDocumenti
            Dim group1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            group1.Caption = t.Descrizione

            If t.AnnoProtocollo = 0 AndAlso t.NumeroProtocollo = 0 Then
                'Dim btnProtocolloDaAssociare As New SimpleButton
                'btnProtocolloDaAssociare.Width = 200
                'btnProtocolloDaAssociare.Text = t.Descrizione
                'group1.CaptionControl = btnProtocolloDaAssociare
                'AddHandler btnProtocolloDaAssociare.Click, AddressOf ProtocolloDaAssociare
            End If

            mainGallery.Gallery.Groups.Add(group1)
            Dim cnt As Integer = 0
            For Each tk In t.lstImage
                cnt += 1
                group1.Items.Add(New GalleryItem(tk, String.Format("Pagina {0} di {1}", cnt, t.lstImage.Count), t.DataScansione))
            Next
        Next
        ''ViewData.Clear()
        'Dim forceProcess As Boolean = False
        'If File.Exists(ViewDataFile) Then
        '    ViewData.RestoreLayoutFromXml(ViewDataFile)
        'End If
        'If ViewData.FirstRun Then
        '    forceProcess = True
        'End If
        'UpdateMainGalleryContent(forceProcess)
    End Sub
    Private Sub OnMainTabSelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles controlPresenter1.SelectedControlChanged
        If controlPresenter1.SelectedControl IsNot libraryPanel Then
            ShowViewCategory()
        Else
            HideViewCategory()
        End If
    End Sub
    Private Sub ShowViewCategory()
        If controlPresenter1.SelectedControl.Tag IsNot Nothing Then
            Return
        End If
        viewPageCategory.Visible = True
        collectionOriginalPage.Visible = False
        Dim ribbonPage As RibbonPage = CType((CType(collectionOriginalPage, ICloneable)).Clone(), RibbonPage)
        ribbonPage.Visible = True
        ribbonPage.Text = controlPresenter1.SelectedControl.Text
        viewPageCategory.Pages.Add(ribbonPage)
        ribbonPage.Tag = controlPresenter1.SelectedControl
        controlPresenter1.SelectedControl.Tag = ribbonPage
        ribbonControl1.SelectedPage = ribbonPage
    End Sub
    Private Sub HideViewCategory()
        If viewPageCategory.Pages.Count = 1 Then
            viewPageCategory.Visible = False
        End If
    End Sub
    Private Sub UpdateMainGalleryContent(ByVal forceProcess As Boolean)
        ' ScrollToFile(Path.Path, True)
        ' UpdateItemsEnabledState()
    End Sub
    Private Sub ScrollToFile(ByVal fileName As String, ByVal bAnimated As Boolean)
        mainGallery.Gallery.ScrollTo(GetGalleryItemByTag(fileName), bAnimated)
    End Sub
    Private Function GetGalleryItemByTag(ByVal tag As Object) As GalleryItem
        For Each group As GalleryItemGroup In mainGallery.Gallery.Groups
            For Each item As GalleryItem In group.Items
                If item.Tag Is tag Then
                    Return item
                End If
            Next item
        Next group
        Return Nothing
    End Function
    Private Sub impostazioniPageGroup_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs) Handles impostazioniPageGroup.CaptionButtonClick
        Dim saveCursor As Cursor = Cursor.Current
        Try
            Cursor.Current = Cursors.WaitCursor
            Using obj As New frmParametriScanner
                obj.ShowDialog()
            End Using
        Finally
            Cursor.Current = saveCursor
        End Try
    End Sub

    Private Sub biAddToAlbum_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles biAddToAlbum.ItemClick
        Dim obj As New Parametri.Parametro
        Dim ParametroDati = obj.ReadXml

        If ParametroDati Is Nothing Then
            XtraMessageBox.Show(Me, "È neccesario configurare nelle opzioni i parametri dello Scanner !!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Scanner.twain.SelectSource(cmbScannerItem.EditValue)
        Dim _settings As New Kibernetes.Services.ScannerLibrary.ScannerSetting
        _settings.ShowTwainUI = ParametroDati.UI
        _settings.UseDuplex = ParametroDati.FronteRetro
        _settings.UseDocumentFeeder = True
        _settings.ShowProgressIndicatorUI = True
        _settings.UseAutoFeeder = True
        _settings.ShouldTransferAllPages = True

        Try
            Scanner.StartScanning(_settings)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Enabled = True
        End Try
    End Sub
End Class

Public Class PhotoViewerSplashScreen
    Inherits DemoSplashScreen
    Public Sub New()
        DemoText = "PhotoViewer"
        ProductText = "The XtraBars Suite"
    End Sub
End Class
