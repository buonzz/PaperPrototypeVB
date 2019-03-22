Option Strict On
Option Explicit On
Imports System.Data.SqlClient

Public Class HistoryRepository
    Dim cn_builder As ConnectionStringBuilder

    Public Sub New()
        cn_builder = New ConnectionStringBuilder
    End Sub

    Public Function add(checkup_id As Integer, patient_id As Integer, disease As String, treatment As String) As Integer

        Dim cn As SqlConnection = New SqlConnection(cn_builder.getConnectionString())
        Dim count As Integer

        Try
            cn.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into checkups(patient_id,checkup_id, disease, treatment) values(@patient_id,@checkup_id,@disease, @treatment)", cn)
            cmd.Parameters.AddWithValue("@patient_id", patient_id)
            cmd.Parameters.AddWithValue("@checkup_id", checkup_id)
            cmd.Parameters.AddWithValue("@disease", disease)
            cmd.Parameters.AddWithValue("@treatment", treatment)

            count = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try

        Return count

    End Function

End Class
