Option Strict On
Option Explicit On

Public Class frmHistory
    Public PatientID As Integer
    Dim checkupRepo As CheckupRepository
    Dim checkupDataset As DataSet
    Dim checkupTableBindingSource As BindingSource

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkupRepo = New CheckupRepository
        checkupTableBindingSource = New BindingSource
        dgvCheckups.DataSource = checkupTableBindingSource

        populateTable()
    End Sub

    Private Sub populateTable()
        Dim fields() As String = {"id", "mdate", "disease", "treatment"}
        checkupDataset = checkupRepo.findByPatientID(PatientID, fields)
        checkupTableBindingSource.DataSource = checkupDataset.Tables(0)
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim frm As frmNewCheckUp = New frmNewCheckUp()
        frm.PatientID = PatientID
        frm.Show()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Close()
    End Sub
End Class