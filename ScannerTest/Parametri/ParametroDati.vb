Imports System.ComponentModel
Namespace Parametri

    Public Class ParametroDati
        Public Enum TipoColore
            BlackAndWhite
            GreyScale
            Colour
        End Enum
        Public Enum TipoDpi
            Settantacinque = 75
            Cento = 100
            Centocinquanta = 150
            Duecento = 200
            Duecentoquaranta = 240
            Trecento = 300
            Quattrocento = 400
            Seicento = 600
            Milleduecento = 1200
        End Enum
        Property FronteRetro As Boolean
        Property UI As Boolean
        Property DefaultScanner As String
        Property RisoluzioneDpi As TipoDpi = TipoDpi.Centocinquanta
        Property RisoluzioneColore As TipoColore = TipoColore.BlackAndWhite
        Property PortalURL As String

        Public Class TipoColoreHelper
            Public Shared Function GetList() As List(Of Object)
                Dim r = New List(Of Object)
                Dim items As Array
                items = System.Enum.GetValues(GetType(TipoColore))
                For Each i In items
                    r.Add(New With {.Id = i, .Descrizione = GetText(i)})
                Next
                Return r
            End Function

            Shared Function GetText(Tipo As TipoColore) As String
                If Tipo = TipoColore.BlackAndWhite Then
                    Return "Bianco e Nero"
                ElseIf Tipo = TipoColore.GreyScale Then
                    Return "Grigio"
                ElseIf Tipo = TipoColore.Colour Then
                    Return "A Colore"
                Else
                    Return Tipo.ToString
                End If
            End Function
        End Class
        Public Class TipoDpiHelper
            Public Shared Function GetList() As List(Of Object)
                Dim r = New List(Of Object)
                Dim items As Array
                items = System.Enum.GetValues(GetType(TipoDpi))
                For Each i In items
                    r.Add(New With {.Id = i, .Descrizione = GetText(i)})
                Next
                Return r
            End Function

            Shared Function GetText(Tipo As TipoDpi) As String
                If Tipo = TipoDpi.Settantacinque Then
                    Return "75"
                ElseIf Tipo = TipoDpi.Cento Then
                    Return "100"
                ElseIf Tipo = TipoDpi.Centocinquanta Then
                    Return "150"
                ElseIf Tipo = TipoDpi.Duecento Then
                    Return "200"
                ElseIf Tipo = TipoDpi.Duecentoquaranta Then
                    Return "240"
                ElseIf Tipo = TipoDpi.Trecento Then
                    Return "300"
                ElseIf Tipo = TipoDpi.Quattrocento Then
                    Return "400"
                ElseIf Tipo = TipoDpi.Seicento Then
                    Return "600"
                ElseIf Tipo = TipoDpi.Milleduecento Then
                    Return "1200"
                Else
                    Return Tipo.ToString
                End If
            End Function
        End Class
    End Class

End Namespace

