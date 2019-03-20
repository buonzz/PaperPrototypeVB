Option Strict On
Option Explicit On
Imports System.Data.SqlClient

Public Class CheckupRepository

    Dim cn_builder As ConnectionStringBuilder

    Public Sub New()
        cn_builder = New ConnectionStringBuilder
    End Sub

    Public Function add(patient_id As Integer, mdate As String) As Integer

        Dim cn As SqlConnection = New SqlConnection(cn_builder.getConnectionString())
        Dim count As Integer

        Try
            cn.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into checkups(patient_id,mdate) values(@patient_id,@mdate)", cn)
            cmd.Parameters.AddWithValue("@patient_id", patient_id)
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
