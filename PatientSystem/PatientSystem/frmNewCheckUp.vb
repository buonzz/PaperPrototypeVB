Option Strict On
Option Explicit On

Public Class frmNewCheckUp

    Public PatientID As Integer
    Dim patientRepo As PatientRepository
    Dim patientDataset As DataSet

    Private Sub frmNewCheckUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientRepo = New PatientRepository
        fetchPatient()
    End Sub

    Private Sub fetchPatient()

        Dim fields() As String = {"id", "name"}
        patientDataset = patientRepo.findByID(PatientID, fields)

        txtPatient.Text = CType(patientDataset.Tables(0).Rows(0)("name"), String)

    End Sub

End Class