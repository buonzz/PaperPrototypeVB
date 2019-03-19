Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class frmListPatient

    Dim patientDataAdapter As SqlDataAdapter = Nothing
    Dim patientTable As DataTable = Nothing
    Dim patientTableBindingSource As BindingSource = Nothing
    Dim cn_builder As ConnectionStringBuilder
    Dim patientRepo As PatientRepository

    Private Sub frmListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn_builder = New ConnectionStringBuilder
        patientTable = New DataTable()
        patientTableBindingSource = New BindingSource
        patientRepo = New PatientRepository

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
                    patientTable.Clear()
                    sda.Fill(patientTable)
                    patientTableBindingSource.DataSource = patientTable
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            Dim result = patientRepo.add(txtName.Text,
                        txtSex.Text,
                        txtBirthday.Text,
                        Convert.ToInt32(txtAge.Text),
                        Convert.ToDecimal(txtWeight.Text),
                        Convert.ToDecimal(txtHeight.Text),
                        txtDate.Text
                        )


            If result = 1 Then
                lblMsg.Text = "Patient " + txtName.Text + " has been added!"
            Else
                lblMsg.Text = "Could not add patient!"
            End If
            resetForm()
        Catch ex As Exception
            lblMsg.Text = "Error --> " + ex.Message
        End Try
        PopulatePatientsTable()
    End Sub

    Private Sub resetForm()
        txtName.Text = ""
        txtSex.Text = ""
        txtBirthday.Text = ""
        txtAge.Text = ""
        txtWeight.Text = ""
        txtHeight.Text = ""
        txtDate.Text = ""
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
End Class