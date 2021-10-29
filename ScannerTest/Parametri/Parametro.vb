Imports System.Xml.Serialization

Namespace Parametri
    Public Class Parametro

        Public Function ReadXml() As ParametroDati
            Dim ParametroDati As ParametroDati = Nothing
            Dim buffer As Byte() = Nothing
            Dim serConfigurazione As XmlSerializer = New XmlSerializer(GetType(ParametroDati))
            Try
                buffer = System.IO.File.ReadAllBytes(IO.Path.Combine(Kibernetes.Services.ScannerLibrary.Utility.Utils.PathTracciatoDirectory, "ImpostazioniScanner.xml"))
                If buffer IsNot Nothing AndAlso buffer.Length > 0 Then
                    Using ms As New IO.MemoryStream(buffer)
                        ParametroDati = serConfigurazione.Deserialize(ms)
                    End Using
                End If
            Catch ex As Exception
                Throw New Exception("Errore nella lettura del file ImpostazioniScanner.xml")
            End Try
            Return ParametroDati
        End Function

        Sub SaveXml(Dati As ParametroDati)
            If Dati IsNot Nothing Then
                Dim serConfigurazione As XmlSerializer = New XmlSerializer(GetType(ParametroDati))
                Dim Buffer As Byte() = Nothing
                Using ms As New IO.MemoryStream
                    serConfigurazione.Serialize(ms, Dati)
                    Buffer = ms.ToArray()
                End Using
                System.IO.File.WriteAllBytes(IO.Path.Combine(Kibernetes.Services.ScannerLibrary.Utility.Utils.PathTracciatoDirectory, "ImpostazioniScanner.xml"), Buffer)
            End If
        End Sub

    End Class
End Namespace

