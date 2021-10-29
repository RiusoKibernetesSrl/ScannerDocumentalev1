Public Class frmParametriScanner

    Private Sub frmParametriScanner_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitDataSource()
        Dim obj As New Parametri.Parametro
        Dim Dati As Parametri.ParametroDati = obj.ReadXml()
        If Dati IsNot Nothing Then
            cmbScanner.EditValue = Dati.DefaultScanner
            ckFronteRetro.Checked = Dati.FronteRetro
            ckUI.Checked = Dati.UI
            cmbRisoluzioneDpi.EditValue = Dati.RisoluzioneDpi
            cmbRisoluzioneColore.EditValue = Dati.RisoluzioneColore
            txtPortalUrl.Text = Dati.PortalURL
        End If
    End Sub
    Sub InitDataSource()
        Dim Scanner As New Kibernetes.Services.ScannerLibrary.Scanner(Me)
        cmbScanner.Properties.DataSource = Scanner.twain.SourceNames


        Dim clmDpiId As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
        clmDpiId.Caption = "Id"
        clmDpiId.FieldName = "Id"
        clmDpiId.Visible = False
        cmbRisoluzioneDpi.Properties.Columns.Add(clmDpiId)

        Dim clmDpiDescrizione As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
        clmDpiDescrizione.Caption = "Descrizione"
        clmDpiDescrizione.FieldName = "Descrizione"
        clmDpiDescrizione.Width = 150
        cmbRisoluzioneDpi.Properties.Columns.Add(clmDpiDescrizione)

        cmbRisoluzioneDpi.Properties.DataSource = Parametri.ParametroDati.TipoDpiHelper.GetList()
        cmbRisoluzioneDpi.Properties.DisplayMember = "Descrizione"
        cmbRisoluzioneDpi.Properties.ValueMember = "Id"

        cmbRisoluzioneDpi.EditValue = Parametri.ParametroDati.TipoDpi.Centocinquanta

        Dim clmColoreId As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
        clmColoreId.Caption = "Id"
        clmColoreId.FieldName = "Id"
        clmColoreId.Visible = False
        cmbRisoluzioneColore.Properties.Columns.Add(clmColoreId)

        Dim clmColoreDescrizione As New DevExpress.XtraEditors.Controls.LookUpColumnInfo
        clmColoreDescrizione.Caption = "Descrizione"
        clmColoreDescrizione.FieldName = "Descrizione"
        clmColoreDescrizione.Width = 150
        cmbRisoluzioneColore.Properties.Columns.Add(clmColoreDescrizione)

        cmbRisoluzioneColore.Properties.DataSource = Parametri.ParametroDati.TipoColoreHelper.GetList()
        cmbRisoluzioneColore.Properties.DisplayMember = "Descrizione"
        cmbRisoluzioneColore.Properties.ValueMember = "Id"
        cmbRisoluzioneColore.EditValue = Parametri.ParametroDati.TipoColore.BlackAndWhite
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        Dim obj As New Parametri.Parametro
        Dim DatiInsertArgs As New Parametri.ParametroDati
        DatiInsertArgs.DefaultScanner = cmbScanner.EditValue
        Boolean.TryParse(ckFronteRetro.Checked, DatiInsertArgs.FronteRetro)
        Boolean.TryParse(ckUI.Checked, DatiInsertArgs.UI)
        Integer.TryParse(cmbRisoluzioneDpi.EditValue, DatiInsertArgs.RisoluzioneDpi)
        Integer.TryParse(cmbRisoluzioneColore.EditValue, DatiInsertArgs.RisoluzioneColore)
        DatiInsertArgs.PortalURL = txtPortalUrl.Text
        obj.SaveXml(DatiInsertArgs)
        Me.Close()
    End Sub
End Class