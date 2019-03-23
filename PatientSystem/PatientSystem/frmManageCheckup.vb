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
        Dim fields() As String = {"id", "name", "mdate"}

        If IsNumeric(txtPatientID.Text) Then
            patientsDataset = patientRepo.findByID(Convert.ToInt32(txtPatientID.Text), fields)
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

    Private Sub btnCheckHistory_Click(sender As Object, e As EventArgs) Handles btnCheckHistory.Click
        Dim patientID As Integer

        If dgvPatients.SelectedRows.Count > 0 Then
            patientID = Convert.ToInt32(dgvPatients.Rows(dgvPatients.CurrentRow.Index).Cells(0).Value.ToString())
            Dim frm As frmHistory = New frmHistory()
            frm.PatientID = patientID
            frm.Show()
        End If
    End Sub
End Class