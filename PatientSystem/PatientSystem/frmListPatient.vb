Option Strict On
Option Explicit On

Public Class frmListPatient

    Dim patientRepo As PatientRepository
    Dim ScreenMode As String = "Add"
    Dim patientsDataset As DataSet
    Dim patientTableBindingSource As BindingSource

    Private Sub frmListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        patientRepo = New PatientRepository
        patientTableBindingSource = New BindingSource
        dgvPatients.DataSource = patientTableBindingSource

        btnEdit.Enabled = False
        btnDelete.Enabled = False
        dtpBirthday.Format = DateTimePickerFormat.Custom
        dtpBirthday.CustomFormat = "MM/dd/yyyy"

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM/dd/yyyy"

        If cbSex.Items.Count > 0 Then
            cbSex.SelectedIndex = 0
        End If

        populatePatientsTable()

    End Sub

    Private Sub populatePatientsTable()
        patientsDataset = patientRepo.all()
        patientTableBindingSource.DataSource = patientsDataset.Tables(0)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (validate() = 1) Then
            Exit Sub
        End If
        'Try

        Dim result = patientRepo.add(txtName.Text,
                        cbSex.Text,
                        dtpBirthday.Text,
                        Convert.ToInt32(txtAge.Text),
                        Convert.ToDecimal(txtWeight.Text),
                        Convert.ToDecimal(txtHeight.Text),
                        dtpDate.Text,
                        txtDisease.Text,
                        txtTreatment.Text
                        )


            If result = 1 Then
                lblMsg.Text = "Patient " + txtName.Text + " has been added!"
            Else
                lblMsg.Text = "Could not add patient!"
            End If
            resetForm()
            populatePatientsTable()
        'Catch ex As Exception
        ' MessageBox.Show("An Error has occured" & ex.Message)
        'End Try
    End Sub

    Private Sub resetForm()
        txtName.Text = ""
        cbSex.SelectedIndex = 0
        dtpBirthday.Text = ""
        txtAge.Text = ""
        txtWeight.Text = ""
        txtHeight.Text = ""
        dtpDate.Text = ""
        txtTreatment.Text = ""
        txtDisease.Text = ""
        txtName.Select()
    End Sub

    Private Function validate() As Integer
        Dim result As Integer = 0

        If Not IsNumeric(txtAge.Text) Then
            MessageBox.Show("The age needs to be a number")
            result = 1
        End If

        If Not IsNumeric(txtHeight.Text) Then
            MessageBox.Show("The height needs to be a number")
            result = 1
        End If

        If Not IsNumeric(txtWeight.Text) Then
            MessageBox.Show("The weight needs to be a number")
            result = 1
        End If

        Return result
    End Function


    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub dgvPatients_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPatients.SelectionChanged
        If dgvPatients.SelectedRows.Count > 0 Then
            Dim curIndex As Integer = dgvPatients.CurrentRow.Index

            txtPatientID.Text = dgvPatients.Rows(curIndex).Cells(0).Value.ToString()
            txtName.Text = dgvPatients.Rows(curIndex).Cells(1).Value.ToString()
            cbSex.Text = dgvPatients.Rows(curIndex).Cells(2).Value.ToString()
            dtpBirthday.Value = DateParser.parse(dgvPatients.Rows(curIndex).Cells(3).Value.ToString())
            txtAge.Text = dgvPatients.Rows(curIndex).Cells(4).Value.ToString()
            txtWeight.Text = dgvPatients.Rows(curIndex).Cells(5).Value.ToString()
            txtHeight.Text = dgvPatients.Rows(curIndex).Cells(6).Value.ToString()
            dtpDate.Value = DateParser.parse(dgvPatients.Rows(curIndex).Cells(7).Value.ToString())

            btnEdit.Enabled = True
            ScreenMode = "Edit"
        End If
    End Sub

End Class