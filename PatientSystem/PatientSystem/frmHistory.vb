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


    End Sub
End Class