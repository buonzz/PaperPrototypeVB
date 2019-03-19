Public Class frmMenu
    Private Sub btnManagePatient_Click(sender As Object, e As EventArgs) Handles btnManagePatient.Click
        Dim frm As frmListPatient = New frmListPatient
        frm.Show()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Application.Exit()
    End Sub
End Class
