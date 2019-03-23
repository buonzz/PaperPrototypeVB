Option Strict On
Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class CheckupRepository

    Dim cn_builder As ConnectionStringBuilder
    Dim cn As OleDb.OleDbConnection
    Dim patientsDataset As DataSet

    Public Sub New()
        cn_builder = New ConnectionStringBuilder
        cn = New OleDbConnection
        cn.ConnectionString = cn_builder.getConnectionString()
    End Sub

    Public Function all() As DataSet

        Dim da As OleDb.OleDbDataAdapter
        Dim sqlstring As String
        Dim ds As DataSet = New DataSet

        cn.Open()
        sqlstring = "SELECT * FROM checkups order by id desc"
        da = New OleDb.OleDbDataAdapter(sqlstring, cn)

        da.Fill(ds, "patientsystem")
        cn.Close()

        Return ds
    End Function

    Public Function add(patient_id As Integer, mdate As String, disease As String, treatment As String) As Integer

        Dim count As Integer

        ' Try
        cn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("insert into checkups(patient_id,mdate, disease,treatment) values(@patient_id,@mdate, @disease, @treatment)", cn)
            cmd.Parameters.AddWithValue("@patient_id", patient_id)
            cmd.Parameters.AddWithValue("@disease", disease)
            cmd.Parameters.AddWithValue("@treatment", treatment)
            cmd.Parameters.AddWithValue("@mdate", mdate)

            count = cmd.ExecuteNonQuery()

        ' Catch ex As Exception
        'Throw ex
        ' Finally
        cn.Close()
        ' End Try

        Return count

    End Function

End Class
