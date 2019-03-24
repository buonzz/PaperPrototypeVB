Option Strict On
Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class UserRepository

    Dim cn_builder As ConnectionStringBuilder
    Dim cn As OleDb.OleDbConnection
    Dim usersDataset As DataSet

    Public Sub New()
        cn_builder = New ConnectionStringBuilder
        cn = New OleDbConnection
        cn.ConnectionString = cn_builder.getConnectionString()
    End Sub

    Public Function findByUserPass(username As String, password As String) As Boolean
        Dim count As Integer

        cn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("select count(*) from users where username=@username and password=@password", cn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@passwords", password)

        count = Convert.ToInt32(cmd.ExecuteScalar())
        cn.Close()

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
