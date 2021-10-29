Imports System.ComponentModel
Namespace Parametri

    Public Class ParametroDati

        <ComponentModel.TypeConverter(GetType(IntegerTypeConverter))>
        Public Enum TipoColore
            <Description("Bianco e Nero")>
            BlackAndWhite
            <Description("Grigio")>
            GreyScale
            <Description("A Colore")>
            Colour
        End Enum
        <ComponentModel.TypeConverter(GetType(IntegerTypeConverter))>
        Public Enum TipoDpi
            <Description("75")>
            Settantacinque = 75
            <Description("100")>
            Cento = 100
            <Description("150")>
            Centocinquanta = 150
            <Description("200")>
            Duecento = 200
            <Description("240")>
            Duecentoquaranta = 240
            <Description("300")>
            Trecento = 300
            <Description("400")>
            Quattrocento = 400
            <Description("600")>
            Seicento = 600
            <Description("1200")>
            Milleduecento = 1200
        End Enum
        <Category("Generale"), DisplayName("Abilita Fronte Retro")>
        Property FronteRetro As Boolean
        <Category("Generale"), DisplayName("UI")>
        Property UI As Boolean
        <Category("Generale"), DisplayName("Tipo Scanner")>
        Property DefaultScanner As String

        <Category("Immagine"), DisplayName("Dpi")>
        Property RisoluzioneDpi As TipoDpi = TipoDpi.Centocinquanta
        <Category("Immagine"), DisplayName("Tipo")>
        Property RisoluzioneColore As TipoColore = TipoColore.BlackAndWhite

        <Category("Portal"), DisplayName("URL")>
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
        <System.ComponentModel.DataObject>
        Public Class TipoDpiHelper

            <DataObjectMethodAttribute(DataObjectMethodType.Select, True)>
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

    Public Class RisoluzioneDati
        Property Dpi As Integer
        Property Colore As TipoColore

        Public Enum TipoColore
            BlackAndWhite
            GreyScale
            Colour
        End Enum

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
                    Return "Scala grigio"
                ElseIf Tipo = TipoColore.Colour Then
                    Return "A Colore"
                Else
                    Return Tipo.ToString
                End If
            End Function
        End Class
    End Class

End Namespace

