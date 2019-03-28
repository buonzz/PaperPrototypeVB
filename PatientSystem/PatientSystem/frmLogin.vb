Public Class frmLogin
    Dim userRepository As UserRepository

    Public Sub New()


        InitializeComponent()

        userRepository = New UserRepository()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim result As Boolean = userRepository.findByUserPass(txtUsername.Text, txtPassword.Text)
        If result = True Then
            Close()
        Else
            lblMessage.Text = "Invalid User/Pass!"
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class