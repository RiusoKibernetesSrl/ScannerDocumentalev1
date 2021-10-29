Imports DevExpress.XtraEditors

Public Class frmProtocollazione

    Dim _Guid As String
    Dim _Scanner As Kibernetes.Services.ScannerLibrary.Scanner
    Public Sub New(Scanner As Kibernetes.Services.ScannerLibrary.Scanner, Guid As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        _Scanner = Scanner
        _Guid = Guid
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        If String.IsNullOrEmpty(txtNumero.Text) Then
            XtraMessageBox.Show(Me, "Il Numero è obbligatorio !!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtAnno.Text) Then
            XtraMessageBox.Show(Me, "L'Anno è obbligatorio !!!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim NumeroProtocollo As Integer = 0
        Dim AnnoProtocollo As Integer = 0
        Integer.TryParse(txtNumero.Text, NumeroProtocollo)
        Integer.TryParse(txtAnno.Text, AnnoProtocollo)
        If String.IsNullOrEmpty(_Guid) = False AndAlso NumeroProtocollo > 0 AndAlso AnnoProtocollo > 0 Then
            _Scanner.AggiornaDatiDocumento(_Guid, AnnoProtocollo, NumeroProtocollo)
        End If



        Me.Close()

    End Sub
End Class