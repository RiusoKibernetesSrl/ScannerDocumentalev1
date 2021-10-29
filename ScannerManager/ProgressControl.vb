Imports DevExpress.XtraEditors
Public Class ProgressControl
    Inherits XtraUserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Maximum() As Integer
        Get
            Return ProgressBarControl1.Properties.Maximum
        End Get
        Set(ByVal value As Integer)
            ProgressBarControl1.Properties.Maximum = value
        End Set
    End Property
    Public Property Value() As Integer
        Get
            Return CInt(Fix(ProgressBarControl1.EditValue))
        End Get
        Set(ByVal value As Integer)
            ProgressBarControl1.EditValue = value
        End Set
    End Property
    Public Property ProgressText() As String
        Get
            Return LabelControl1.Text
        End Get
        Set(ByVal value As String)
            LabelControl1.Text = value
        End Set
    End Property

End Class
