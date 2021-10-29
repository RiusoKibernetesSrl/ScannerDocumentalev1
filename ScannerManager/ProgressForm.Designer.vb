<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressControl1 = New ScannerManager.ProgressControl()
        Me.SuspendLayout()
        '
        'ProgressControl1
        '
        Me.ProgressControl1.Location = New System.Drawing.Point(3, -3)
        Me.ProgressControl1.Maximum = 100
        Me.ProgressControl1.Name = "ProgressControl1"
        Me.ProgressControl1.ProgressText = "Processing folder"
        Me.ProgressControl1.Size = New System.Drawing.Size(355, 57)
        Me.ProgressControl1.TabIndex = 0
        Me.ProgressControl1.Value = 0
        '
        'ProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 57)
        Me.Controls.Add(Me.ProgressControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProgressForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ProgressForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressControl1 As ProgressControl
End Class
