Imports System.Data.SqlClient

Public Class ConnectionStringBuilder
    Public Function getConnectionString() As String

        'An often overlooked gem, SqlConnectionStringBuilder simplifies creating a connection
        Dim csb As SqlConnectionStringBuilder = New SqlConnectionStringBuilder()
        csb.DataSource = ".\SQLEXPRESS"
        csb.InitialCatalog = "PatientSystem"
        csb.IntegratedSecurity = True
        Return csb.ConnectionString

    End Function
End Class
