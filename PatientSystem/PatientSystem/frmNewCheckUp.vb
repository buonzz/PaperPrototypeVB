Option Strict On
Option Explicit On

Public Class frmNewCheckUp

    Public PatientID As Integer
    Dim patientRepo As PatientRepository
    Dim checkupRepo As CheckupRepository
    Dim patientDataset As DataSet

    Private Sub frmNewCheckUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientRepo = New PatientRepository
        checkupRepo = New CheckupRepository

        fetchPatient()
    End Sub

    Private Sub fetchPatient()

        Dim fields() As String = {"id", "name"}
        patientDataset = patientRepo.findByID(PatientID, fields)

        txtPatient.Text = CType(patientDataset.Tables(0).Rows(0)("name"), String)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("MM\/dd\/yyyy")
        checkupRepo.add(PatientID, strDate, txtDisease.Text, txtTreatment.Text)
    End Sub
End Class