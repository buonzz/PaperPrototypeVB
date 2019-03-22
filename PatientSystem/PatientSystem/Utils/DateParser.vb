Imports System.Globalization

Public Class DateParser
    Public Shared Function parse(input As String) As DateTime
        Dim C_Date As DateTime = DateTime.ParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture)
        Return C_Date
    End Function
End Class
