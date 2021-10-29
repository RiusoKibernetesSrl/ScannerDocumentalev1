Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Repository

Public Class frmParametri

    Private PathFileScanner As String = IO.Path.Combine(Kibernetes.Services.ScannerLibrary.Utility.Utils.PathTracciatoDirectory, "ParametriScanner.xml")
    Public Sub New()
        InitializeComponent()
        'CreateImpostazioni()
        PropertyGridControl1.SelectedObject = New Parametri.ParametroDati
        Using reader As New StreamReader(PathFileScanner, False)
            Dim serializer As New XmlSerializer(PropertyGridControl1.SelectedObject.GetType())
            PropertyGridControl1.SelectedObject = serializer.Deserialize(reader)
            reader.Close()
        End Using
        'Dim obj As New Parametri.Parametro
        'Dim PrametroDati As Parametri.ParametroDati = obj.ReadXml()

        'If PrametroDati Is Nothing Then
        '    Salvataggio()
        'Else
        '    Using reader As New StreamReader(PathFileScanner, False)
        '        Dim serializer As New XmlSerializer(PropertyGridControl1.SelectedObject.GetType())
        '        PropertyGridControl1.SelectedObject = serializer.Deserialize(reader)
        '        reader.Close()
        '    End Using
        'End If
    End Sub
    Private Sub CreateImpostazioni()
        Dim cgwImpostazioni As New CategoryRow("Impostazioni Scanner")
        PropertyGridControl1.Rows.Add(cgwImpostazioni)

        Dim rowFronteRetro As New EditorRow("FronteRetro")
        Dim rckFronteRetro As New RepositoryItemCheckEdit
        rowFronteRetro.Properties.Caption = "Fronte Retro"
        rckFronteRetro.Name = "ckFronteRetro"
        rowFronteRetro.Properties.RowEdit = rckFronteRetro
        cgwImpostazioni.ChildRows.Add(rowFronteRetro)

        Dim rowUI As New EditorRow("UI")
        rowUI.Properties.Caption = "UI"
        Dim rckUI As New RepositoryItemCheckEdit
        rckUI.Name = "ckUI"
        rowUI.Properties.RowEdit = rckUI
        cgwImpostazioni.ChildRows.Add(rowUI)

        Dim rowDefaultScanner As New EditorRow("DefaultScanner")
        rowDefaultScanner.Properties.Caption = "Default Scanner"
        Dim rckDefaultScanner As New RepositoryItemComboBox

        Try
            rckDefaultScanner.Items.BeginUpdate()
            Dim Scanner As New Kibernetes.Services.ScannerLibrary.Scanner(Me)
            For i As Integer = 0 To Scanner.twain.SourceNames.Count - 1
                rckDefaultScanner.Items.Add(Scanner.twain.SourceNames.Item(i))
            Next
        Catch ex As Exception
        Finally
            rckDefaultScanner.Items.EndUpdate()
        End Try

        rckDefaultScanner.Name = "cmbDefaultScanner"
        rowDefaultScanner.Properties.RowEdit = rckDefaultScanner
        cgwImpostazioni.ChildRows.Add(rowDefaultScanner)

        Dim rowPortalURL As New EditorRow("PortalURL")
        rowPortalURL.Properties.Caption = "Portal URL"
        cgwImpostazioni.ChildRows.Add(rowPortalURL)

        Dim cwwRisoluzioni As New CategoryRow("Impostazioni Risoluzioni")
        PropertyGridControl1.Rows.Add(cwwRisoluzioni)
        Dim rowDpi As New EditorRow("RisoluzioneDpi")
        rowDpi.Properties.Caption = "Risoluzione (dpi)"

        Dim rckDpi As New RepositoryItemLookUpEdit

        Try
            rckDpi.BeginUpdate()
            Dim clmDpiId As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
            clmDpiId.Caption = "Id"
            clmDpiId.FieldName = "Id"
            clmDpiId.Visible = False
            rckDpi.Columns.Add(clmDpiId)

            Dim clmDpiDescrizione As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
            clmDpiDescrizione.Caption = "Descrizione"
            clmDpiDescrizione.FieldName = "Descrizione"
            clmDpiDescrizione.Width = 150
            rckDpi.Columns.Add(clmDpiDescrizione)

            rckDpi.DataSource = Parametri.ParametroDati.TipoDpiHelper.GetList()
            rckDpi.DisplayMember = "Descrizione"
            rckDpi.ValueMember = "Id"
        Catch ex As Exception
        Finally
            rckDpi.EndUpdate()
        End Try

        rckDpi.Name = "cmbDpi"
        rowDpi.Properties.RowEdit = rckDpi
        rowDpi.Properties.Value = Parametri.ParametroDati.TipoDpi.Duecento
        cwwRisoluzioni.ChildRows.Add(rowDpi)

        Dim rowColore As New EditorRow("RisoluzioneColore")
        rowColore.Properties.Caption = "Tipo Immagine"

        Dim rckColore As New RepositoryItemLookUpEdit
        Try
            rckColore.BeginUpdate()
            Dim clmColoreId As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
            clmColoreId.Caption = "Id"
            clmColoreId.FieldName = "Id"
            clmColoreId.Visible = False
            rckColore.Columns.Add(clmColoreId)

            Dim clmColoreDescrizione As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
            clmColoreDescrizione.Caption = "Descrizione"
            clmColoreDescrizione.FieldName = "Descrizione"
            clmColoreDescrizione.Width = 150
            rckColore.Columns.Add(clmColoreDescrizione)

            rckColore.DataSource = Parametri.ParametroDati.TipoColoreHelper.GetList()
            rckColore.DisplayMember = "Descrizione"
            rckColore.ValueMember = "Id"
        Catch ex As Exception
        Finally
            rckColore.EndUpdate()
        End Try

        rckColore.Name = "cmbColore"
        rowColore.Properties.RowEdit = rckColore
        rowColore.Properties.Value = Parametri.ParametroDati.TipoColore.BlackAndWhite
        cwwRisoluzioni.ChildRows.Add(rowColore)
    End Sub
    Private Sub Salvataggio()
        Using writer As New StreamWriter(PathFileScanner, False)
            Dim serializer As New XmlSerializer(PropertyGridControl1.SelectedObject.GetType())
            serializer.Serialize(writer, PropertyGridControl1.SelectedObject)
            writer.Close()
        End Using
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        Salvataggio()
        Me.Close()
    End Sub
End Class