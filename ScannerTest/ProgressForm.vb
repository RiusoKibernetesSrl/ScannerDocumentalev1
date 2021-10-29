Public Class ProgressForm
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Public ReadOnly Property ProgressControl() As ProgressControl
        Get
            Return ProgressControl1
        End Get
    End Property

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        CenterToParent()
    End Sub

End Class