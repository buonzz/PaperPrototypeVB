Option Strict On
Option Explicit On

Public Class frmListPatient

    Dim patientRepo As PatientRepository
    Dim ScreenMode As String = "Add"
    Dim patientsDataset As DataSet

    Private Sub frmListPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        patientRepo = New PatientRepository

        btnEdit.Enabled = False
        btnDelete.Enabled = False
        dtpBirthday.Format = DateTimePickerFormat.Custom
        dtpBirthday.CustomFormat = "MM/dd/yyyy"

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM/dd/yyyy"

    End Sub

    Private Sub populatePatientsTable()
        patientRepo.all(patientsDataset)
        dgvPatients.DataSource = patientsDataset.Tables(0)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

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
        'Catch ex As Exception
        'lblMsg.Text = "Error --> " + ex.Message
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