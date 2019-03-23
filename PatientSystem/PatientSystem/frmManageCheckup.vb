Option Strict On
Option Explicit On

Public Class frmManageCheckup

    Dim patientRepo As PatientRepository
    Dim patientsDataset As DataSet
    Dim patientTableBindingSource As BindingSource

    Private Sub frmManageCheckup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientRepo = New PatientRepository
        patientTableBindingSource = New BindingSource
        dgvPatients.DataSource = patientTableBindingSource
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If IsNumeric(txtPatientID.Text) Then
            patientsDataset = patientRepo.findByID(Convert.ToInt32(txtPatientID.Text))
            patientTableBindingSource.DataSource = patientsDataset.Tables(0)
            If patientsDataset.Tables(0).Rows.Count = 0 Then
                lblMessage.Text = "Patient ID not found!"
            Else
                dgvPatients.Rows(0).Selected = True
            End If
        Else
            lblMessage.Text = "Please Input a valid Patient ID"
        End If

    End Sub


End Class