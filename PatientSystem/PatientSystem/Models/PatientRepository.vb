Option Strict On
Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class PatientRepository

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
        sqlstring = "SELECT * FROM patients order by id desc"
        da = New OleDb.OleDbDataAdapter(sqlstring, cn)

        da.Fill(ds, "patientsystem")
        cn.Close()

        Return ds
    End Function

    Public Function add(name As String, sex As String, birthday As String,
                        age As Integer, weight As Double, height As Double,
                        mdate As String, disease As String, treatment As String) As Integer

        Dim patient_added As Integer
        Dim new_patient_id As Integer = 0


        'Try
        cn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("insert into patients(name,sex,birthday,age,weight,height,mdate) values(@name,@sex,@birthday,@age,@weight,@height,@mdate)", cn)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@weight", weight)
            cmd.Parameters.AddWithValue("@height", height)
            cmd.Parameters.AddWithValue("@mdate", mdate)

            new_patient_id = Convert.ToInt32(cmd.ExecuteNonQuery())

            If new_patient_id > 0 Then
                patient_added = 1
            End If

            ' if the patient is added, then enter new entries to the checkup repo
            If patient_added = 1 Then
                Dim checkupRepo As CheckupRepository = New CheckupRepository()
                checkupRepo.add(new_patient_id, mdate, disease, treatment)
            End If
        'Catch ex As Exception
        ' Throw ex
        'Finally
        cn.Close()
        ' End Try

        Return patient_added

    End Function

    Public Function edit(name As String, sex As String, birthday As String,
                        age As Integer, weight As Double, height As Double,
                        mdate As String, disease As String, treatment As String, id As Integer) As Integer

        Dim count As Integer

        Try
            cn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("update patients set name= @name ,sex = @sex, birthday = @birthday, age = @age, weight = @weight, height = @height, mdate = @mdate where id=@id", cn)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@sex", sex)
            cmd.Parameters.AddWithValue("@birthday", birthday)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@weight", weight)
            cmd.Parameters.AddWithValue("@height", height)
            cmd.Parameters.AddWithValue("@mdate", mdate)
            cmd.Parameters.AddWithValue("@id", id)

            count = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            cn.Close()
        End Try

        Return count

    End Function

    Public Function delete(id As Integer) As Integer

        Dim count As Integer
        cn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("delete from patients where id=@id", cn)
            cmd.Parameters.AddWithValue("@id", id)
        count = cmd.ExecuteNonQuery()
        cn.Close()
        Return count
    End Function


    Public Function findByID(id As Integer, fields As String()) As DataSet

        Dim da As OleDb.OleDbDataAdapter
        Dim sqlstring As String
        Dim ds As DataSet = New DataSet
        Dim sqlfields As String = String.Join(",", fields)



        cn.Open()
        sqlstring = "SELECT " & sqlfields & " FROM patients where id=" & id
        da = New OleDb.OleDbDataAdapter(sqlstring, cn)

        da.Fill(ds, "patientsystem")
        cn.Close()

        Return ds
    End Function

End Class
