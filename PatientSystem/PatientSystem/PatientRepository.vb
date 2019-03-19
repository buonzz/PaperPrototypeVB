Option Strict On
Option Explicit On
Imports System.Data.SqlClient

Public Class PatientRepository

    Dim cn_builder As ConnectionStringBuilder

    Public Sub New()
        cn_builder = New ConnectionStringBuilder
    End Sub

    Public Function add(name As String, sex As String, birthday As String,
                        age As Integer, weight As Double, height As Double, mdate As String) As Integer

        Dim cn As SqlConnection = New SqlConnection(cn_builder.getConnectionString())
        Dim count As Integer

        Try
            cn.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into patients(name,sex,birthday,age,weight,height,mdate) values(@name,@sex,@birthday,@age,@weight,@height,@mdate)", cn)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@weight", weight)
            cmd.Parameters.AddWithValue("@height", height)
            cmd.Parameters.AddWithValue("@mdate", mdate)

            count = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try

        Return count

    End Function
End Class
