Imports System.ComponentModel
Imports System.Globalization


Public Class IntegerTypeConverter
    Inherits ComponentModel.TypeConverter

    Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
        If sourceType = GetType(String) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, value As Object) As Object
        If value Is Nothing Then
            Return 0
        End If
        If String.IsNullOrEmpty(value) Then
            Return 0
        End If
        Return Integer.Parse(value.ToString)
    End Function

    Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destinationType As Type) As Object
        Return MyBase.ConvertTo(context, culture, value, destinationType)
    End Function


End Class
