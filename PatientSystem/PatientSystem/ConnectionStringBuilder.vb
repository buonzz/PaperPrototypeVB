Public Class ConnectionStringBuilder
    Public Function getConnectionString() As String
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = 'patientsystem.mdb'"
        Return cs
    End Function
End Class
