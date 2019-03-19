Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmListPatient

    Dim patientDataAdapter As SqlDataAdapter = Nothing
    Dim patientTable As DataTable = Nothing
    Dim patientTableBindingSource As BindingSource = Nothing

    Private Sub frmListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim cn_builder = New ConnectionStringBuilder
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
End Class