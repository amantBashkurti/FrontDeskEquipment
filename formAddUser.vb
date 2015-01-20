Public Class formAddUser
    Dim db As New inventory

    Private Sub btnCancelAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAddUser.Click
        Me.Close()
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        Try
            If txtFullName.Text = "" Then
                errUserValidation.SetError(txtFullName, "Full name cannot be blank")
            ElseIf txtUsername.Text = "" Then
                errUserValidation.SetError(txtUsername, "Username cannot be blank")
            ElseIf txtPassword.Text = "" Then
                errUserValidation.SetError(txtPassword, "Password cannot be blank")
            ElseIf txtPasswordVerify.Text = "" Then
                errUserValidation.SetError(txtPasswordVerify, "Please re-enter password")
            End If

            If Equals(txtPassword.Text, txtPasswordVerify.Text) = False Then
                errUserValidation.SetError(txtPasswordVerify, "Passwords do not match")
            End If
            Dim hashedPassword = getSHA1Hash(txtPassword.Text)

            If (From user In db.userinventories Where user.username.ToUpper() = txtUsername.Text.ToUpper
                              Select user).Count() > 0 Then
                MessageBox.Show("record already exists")
            Else
                Dim user As New userinventory With {
                        .fullname = txtFullName.Text,
                        .username = txtUsername.Text,
                        .password = hashedPassword,
                        .userType = comboUserType.SelectedItem.ToString()
                    }
                db.userinventories.InsertOnSubmit(user)

                db.SubmitChanges()
                MessageBox.Show("User Added")
                txtFullName.Text = ""
                txtPassword.Text = ""
                txtUsername.Text = ""
                txtPasswordVerify.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged
        errUserValidation.Clear()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        errUserValidation.Clear()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        errUserValidation.Clear()
    End Sub

    Private Sub txtPasswordVerify_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordVerify.TextChanged
        errUserValidation.Clear()
    End Sub

    Private Sub formAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboUserType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class