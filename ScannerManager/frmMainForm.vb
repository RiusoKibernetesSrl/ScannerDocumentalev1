Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports Kibernetes.Services.ScannerLibrary
Imports TwainDotNet

Public Class frmMainForm
    Inherits RibbonForm

    Private Scanner As Kibernetes.Services.ScannerLibrary.Scanner

    Public Sub New()
        Try
            InitializeComponent()
            'https://www.devexpress.com/Support/Center/Question/Details/Q223217/where-i-can-find-a-complete-list-of-skin-names
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
            Scanner = New Kibernetes.Services.ScannerLibrary.Scanner(Me)
            InitProgressForm()
            InitConfigurazioni()
            InitiScanner()
            AddHandler Scanner.twain.ScanningComplete, AddressOf ScanningComplete
            If Scanner.lstDocumenti IsNot Nothing Then
                LoadData()
            End If
        Catch ex As Exception
            System.IO.File.WriteAllText("error.txt", ex.Message + " " + ex.StackTrace)
        End Try

    End Sub


    Public Sub InitProgressForm()
        Dim pf As New ProgressForm()
        pf.ProgressControl.Maximum = 800
        pf.ProgressControl.ProgressText = "Caricamento in corso..."
        pf.Show(Me)

        For i = 0 To 1000
            pf.ProgressControl.Value += 1
            Application.DoEvents()
        Next
        pf.Close()
    End Sub
    Public Sub InitConfigurazioni()
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

    Private Sub btnAssociaDocumento_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAssociaDocumento.ItemClick
        Dim obj As New Parametri.Parametro
        Dim ParametroDati = obj.ReadXml

        If ParametroDati Is Nothing Then
            XtraMessageBox.Show(Me, "È neccesario configurare nelle opzioni i parametri dello Scanner !!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Scanner.twain.SelectSource(cmbScannerItem.EditValue)
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

    Private Sub ScanningComplete()
        Scanner.QrTrovato = False
        Scanner.QrTrovatoPrecedente = False
        If Scanner.IsPrintable = False Then
            Exit Sub
        End If
        mainGallery.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
        mainGallery.Gallery.ImageSize = New Size(180, 120)
        mainGallery.Gallery.ShowItemText = True

        If Scanner.noQR IsNot Nothing Then
            Scanner.lstDocumenti.Add(Scanner.noQR)

        End If
        Scanner.noQR = Nothing
        Scanner.SerializzaListaFile()
        LoadData()
        Enabled = True
        Scanner.IsPrintable = False
    End Sub

    Private Sub OnMainGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs) Handles mainGallery.Gallery.ItemClick
        btnElimina.Enabled = True
        btnSepara.Enabled = True
        btnSvuotaTutto.Enabled = True
        PictureEdit1.Image = e.Item.Image
    End Sub


    Public Sub LoadData()
        mainGallery.Gallery.Groups.Clear()
        If Scanner.lstDocumenti IsNot Nothing AndAlso Scanner.lstDocumenti.Count > 0 Then
            For Each t In Scanner.lstDocumenti
                btnSvuotaTutto.Enabled = True
                Dim group1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
                group1.Caption = t.Descrizione

                If t.AnnoProtocollo = 0 AndAlso t.NumeroProtocollo = 0 Then
                    Dim btnProtocolloDaAssociare As New SimpleButton
                    btnProtocolloDaAssociare.Width = 200
                    btnProtocolloDaAssociare.Text = t.Descrizione
                    btnProtocolloDaAssociare.Tag = t.guid
                    group1.CaptionControl = btnProtocolloDaAssociare
                    AddHandler btnProtocolloDaAssociare.Click, AddressOf ProtocolloDaAssociare
                End If
                group1.Tag = t.guid
                mainGallery.Gallery.Groups.Add(group1)
                Dim cnt As Integer = 0
                For Each tk In t.lstImage
                    cnt += 1
                    Dim gt As New GalleryItem(New GalleryItem(Scanner.byteArrayToImage(tk.image), String.Format("Pagina {0} di {1}", cnt, t.lstImage.Count), t.DataScansione))
                    gt.Tag = tk.guid
                    group1.Items.Add(gt)
                Next
            Next
        Else
            PictureEdit1.Image = Nothing
            btnSepara.Enabled = False
            btnElimina.Enabled = False
            btnSvuotaTutto.Enabled = False
        End If

    End Sub

    Private Sub ProtocolloDaAssociare(sender As Object, e As EventArgs)
        Dim btn = TryCast(sender, SimpleButton)

        Dim saveCursor As Cursor = Cursor.Current
        Try
            Cursor.Current = Cursors.WaitCursor
            Using obj As New frmProtocollazione(Scanner, btn.Tag)
                AddHandler obj.FormClosed, AddressOf obj_ProtocollazioneClosed
                obj.ShowDialog()
            End Using
        Finally
            Cursor.Current = saveCursor
        End Try
    End Sub

    Private Sub obj_ProtocollazioneClosed(sender As Object, e As FormClosedEventArgs)
        LoadData()
    End Sub

    Private Sub RibbonPageGroup3_CaptionButtonClick(sender As Object, e As RibbonPageGroupEventArgs) Handles RibbonPageGroup3.CaptionButtonClick

        Dim saveCursor As Cursor = Cursor.Current
        Try
            Cursor.Current = Cursors.WaitCursor
            Using obj As New frmImpostazioniScanner
                obj.ShowDialog()
            End Using
        Finally
            InitiScanner()
            Cursor.Current = saveCursor
        End Try
    End Sub

    Private Sub btnInviaAlProtocollo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnInviaAlProtocollo.ItemClick


        Dim saveCursor As Cursor = Cursor.Current
        Try
            If Scanner.lstDocumenti IsNot Nothing AndAlso Scanner.lstDocumenti.Count > 0 Then
                If XtraMessageBox.Show(Me, "Sei sicuro di voler inviare i Documenti al Protocollo ?", Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim obj As New Parametri.Parametro
                    Dim ParametroDati = obj.ReadXml
                    If Not String.IsNullOrEmpty(ParametroDati.PortalURL) Then
                        Scanner.InviaAlProtocollo(ParametroDati.PortalURL)
                        LoadData()
                    Else
                        Throw New Exception("Url Portale obbligatoria")
                    End If

                End If
            End If
        Finally
            Cursor.Current = saveCursor
        End Try

    End Sub


    Property dragItemHitInfo As Ribbon.ViewInfo.RibbonHitInfo
    Private Sub mainGallery_MouseDown(sender As Object, e As MouseEventArgs) Handles mainGallery.MouseDown
        Try
            Dim gc As GalleryControl = TryCast(sender, GalleryControl)
            Dim hInfo As Ribbon.ViewInfo.RibbonHitInfo = gc.CalcHitInfo(e.Location)
            If hInfo.InGalleryItem Then
                dragItemHitInfo = hInfo
                Return
            End If
        Catch ex As Exception

        End Try
        dragItemHitInfo = Nothing
    End Sub

    Private Sub mainGallery_MouseMove(sender As Object, e As MouseEventArgs) Handles mainGallery.MouseMove
        Dim gc As GalleryControl = TryCast(sender, GalleryControl)
        If e.Button <> MouseButtons.Left OrElse Control.ModifierKeys <> Keys.None OrElse dragItemHitInfo Is Nothing Then Return
        Dim dragSize As Size = SystemInformation.DragSize
        Dim dragRect As Rectangle = New Rectangle(dragItemHitInfo.HitPoint.X - dragSize.Width / 2, dragItemHitInfo.HitPoint.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height)
        If Not (dragRect.Contains(e.Location)) Then gc.DoDragDrop(dragItemHitInfo.GalleryItem, DragDropEffects.Move)

    End Sub

    Private Sub mainGallery_DragOver(sender As Object, e As DragEventArgs) Handles mainGallery.DragOver
        If e.Data.GetDataPresent(GetType(GalleryItem)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub mainGallery_DragDrop(sender As Object, e As DragEventArgs) Handles mainGallery.DragDrop

        Cursor = Cursors.WaitCursor
        Cursor.Show()
        Try
            If Not (e.Data.GetDataPresent(GetType(GalleryItem))) Then Return
            Dim draggedItem As GalleryItem = TryCast(e.Data.GetData(GetType(GalleryItem)), GalleryItem)
            Dim galControl As GalleryControl = CType(sender, GalleryControl)
            Dim hitInfo As Ribbon.ViewInfo.RibbonHitInfo = galControl.CalcHitInfo(galControl.PointToClient(New Point(e.X, e.Y)))
            If hitInfo.InGalleryGroup Then
                Dim tag_partenza = draggedItem.GalleryGroup.Tag
                Dim tag_destinazione = hitInfo.GalleryItemGroup.Tag
                If Scanner.SpostaElemento(tag_partenza, tag_destinazione, draggedItem.Tag) Then
                    Scanner.SerializzaListaFile()
                    LoadData()
                End If
            End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnElimina_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnElimina.ItemClick

        Cursor = Cursors.WaitCursor
        Cursor.Show()
        Try
            If Scanner.lstDocumenti IsNot Nothing AndAlso Scanner.lstDocumenti.Count > 0 Then
                If XtraMessageBox.Show(Me, "Sei sicuro di voler eliminare l'elemento selezionato?", Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim item = mainGallery.Gallery.GetCheckedItem()
                    If item IsNot Nothing Then
                        Dim tag_group = item.GalleryGroup.Tag
                        Dim item_group = item.Tag
                        If Scanner.EliminaElemento(tag_group, item_group) Then
                            PictureEdit1.Image = Nothing
                            LoadData()
                        End If
                    End If

                End If
            End If

        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnSvuotaTutto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSvuotaTutto.ItemClick

        Cursor = Cursors.WaitCursor
        Cursor.Show()
        Try
            If Scanner.lstDocumenti IsNot Nothing AndAlso Scanner.lstDocumenti.Count > 0 Then
                If XtraMessageBox.Show(Me, "Sei sicuro di voler eliminare tutti i documenti?", Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Scanner.SvuotaTutto()
                    PictureEdit1.Image = Nothing
                    LoadData()
                End If
            End If

        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnSepara_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSepara.ItemClick

        Cursor = Cursors.WaitCursor
        Cursor.Show()
        Try
            If Scanner.lstDocumenti IsNot Nothing AndAlso Scanner.lstDocumenti.Count > 0 Then
                If XtraMessageBox.Show(Me, "Sei sicuro di voler creare un nuovo documento?", Text, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim item = mainGallery.Gallery.GetCheckedItem()
                    If item IsNot Nothing Then
                        Dim tag_group = item.GalleryGroup.Tag
                        Dim item_group = item.Tag
                        If Scanner.CreaNuovoGruppo(tag_group, item_group) Then
                            PictureEdit1.Image = Nothing
                            LoadData()
                        End If
                    End If
                End If
            End If

        Finally
            Cursor = Cursors.Default
        End Try


    End Sub
End Class