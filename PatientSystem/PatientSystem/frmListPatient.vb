Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmListPatient

    Dim patientDataAdapter As SqlDataAdapter = Nothing
    Dim patientTable As DataTable = Nothing
    Dim patientTableBindingSource As BindingSource = Nothing
    Dim cn_builder As ConnectionStringBuilder

    Private Sub frmListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn_builder = New ConnectionStringBuilder
        patientTable = New DataTable()
        patientTableBindingSource = New BindingSource
        dgvPatients.DataSource = patientTableBindingSource
        PopulatePatientsTable()
    End Sub

    ''' <summary>
    ''' Fills a DataTable with data from table [patients] and binds it to
    ''' the DataGridView column.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulatePatientsTable()

        'Creates the ConnectionString. In production this would more likely come from App.config
        Dim conxnString As String = cn_builder.getConnectionString()

        'The SQL command that gets the data. In production this would more likely be a 
        'stored procedure or Entity data model.
        Dim cmdString As String = "SELECT [id], [name], [sex], [birthday], [age], [weight], [height], [mdate] FROM [patients];"

        'Typical connection, command, adapter pattern within 'Using' blocks to properly Dispose
        'the resources when done.
        Using conxn As New SqlConnection(conxnString)
            Using cmd As New SqlCommand(cmdString, conxn)
                Using sda As New SqlDataAdapter(cmd)
                    sda.Fill(patientTable)
                    patientTableBindingSource.DataSource = patientTable
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim cn As SqlConnection = New SqlConnection(cn_builder.getConnectionString())

        Try
            cn.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into patients(name,sex,birthday,age,weight,height,mdate) values(@name,@sex,@birthday,@age,@weight,@height,@mdate)", cn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@sex", txtSex.Text)
            cmd.Parameters.AddWithValue("@birthday", txtBirthday.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@weight", txtWeight.Text)
            cmd.Parameters.AddWithValue("@height", txtHeight.Text)
            cmd.Parameters.AddWithValue("@mdate", txtDate.Text)

            Dim count = cmd.ExecuteNonQuery()

            If count = 1 Then
                lblMsg.Text = "Patient [" + txtName.Text + "] has been added!"
            Else
                lblMsg.Text = "Could not add patient!"
            End If

        Catch ex As Exception
            lblMsg.Text = "Error --> " + ex.Message
        Finally
            cn.Close()
        End Try

    End Sub
End Class