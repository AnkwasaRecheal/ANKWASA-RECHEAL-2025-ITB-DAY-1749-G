Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if the username is "Accounts" and password is "pass123"
        If txtUserName.Text = "Accounts" And txtPassword.Text = "pass123" Then
            ' Navigate to the second form (dataform) if successful
            Dim dataForm As New dataform()
            dataForm.Show()
            Me.Hide()  ' Hide the login form
        Else
            ' Display message box for incorrect credentials
            MessageBox.Show("Incorrect username/password")
        End If
    End Sub
End Class
