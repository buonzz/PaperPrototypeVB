Public Class ConnectionStringBuilder
    Public Function getConnectionString() As String
        Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patientsystem.accdb"
        Return cs
    End Function
End Class
