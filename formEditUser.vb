Public Class formEditUser
    Dim db As New inventory

    Private Sub btnCancelAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelAddUser.Click
        Me.Close()
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

    Private Sub formEditUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboUserType.DropDownStyle = ComboBoxStyle.DropDownList
        comboUsers.SelectedValue = ""
        loadComboBox()
    End Sub

    ' Function that populates the combobox. 
    Public Sub loadComboBox()
        Dim queryUsers = (From userinventory In db.userinventories
                     Select userinventory)

        comboUsers.DataSource = queryUsers.ToArray

        comboUsers.ValueMember = "id"
        comboUsers.DisplayMember = "fullName"
        comboUsers.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click

        Dim verification As DialogResult = MessageBox.Show("Are you sure you want to delete the selected user? " _
                      & Environment.NewLine & "This operation cannot be undone!", "Caption", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If verification = DialogResult.Yes Then
            Dim selectedUser = (From userinventory In db.userinventories Where userinventory.id = CInt(comboUsers.SelectedValue)
                        Select userinventory)
            For Each userDetail In selectedUser
                db.userinventories.DeleteOnSubmit(userDetail)
            Next
            Try
                db.SubmitChanges()
                MessageBox.Show("User Deleted!")
                loadComboBox()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            ' do nothing
        End If
    End Sub

    Private Sub comboUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboUsers.SelectedIndexChanged
        Try
            Dim selectedUser = (From u In db.userinventories Where u.id = CInt(comboUsers.SelectedValue)
                             Select u)

            txtFullName.Text = selectedUser.First().fullname
            txtUsername.Text = selectedUser.First().username
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUser.Click
        Dim selectedUser = (From userinventory In db.userinventories Where userinventory.id = CInt(comboUsers.SelectedValue)
                    Select userinventory)

        If txtFullName.Text = "" Then
            errUserValidation.SetError(txtFullName, "Full name cannot be blank")
        ElseIf txtUsername.Text = "" Then
            errUserValidation.SetError(txtUsername, "Username cannot be blank")
        ElseIf txtPassword.Text = "" Then
            errUserValidation.SetError(txtPassword, "Password cannot be blank")
        ElseIf txtPasswordVerify.Text = "" Then
            errUserValidation.SetError(txtPasswordVerify, "Please re-enter password")
        Else
            If Equals(txtPassword.Text, txtPasswordVerify.Text) = False Then
                errUserValidation.SetError(txtPasswordVerify, "Passwords do not match")
            Else
                Dim hashedPasswordOld = getSHA1Hash(txtOldPassword.Text)
                If Equals(selectedUser.First().password, hashedPasswordOld.ToString) = False Then
                    errUserValidation.SetError(txtOldPassword, "Old password is Incorrect")
                ElseIf Equals(txtPassword.Text, txtPasswordVerify.Text) = False Then
                    errUserValidation.SetError(txtPasswordVerify, "Passwords do not match")
                Else
                    Dim hashedPassword = getSHA1Hash(txtPassword.Text)
                    selectedUser.First().fullName = txtFullName.Text
                    selectedUser.First().username = txtUsername.Text
                    selectedUser.First().password = hashedPassword
                    selectedUser.First().userType = comboUserType.SelectedItem.ToString()
                    Try
                        db.SubmitChanges()
                        MessageBox.Show("User Updated")
                        txtFullName.Text = ""
                        txtPassword.Text = ""
                        txtUsername.Text = ""
                        txtPasswordVerify.Text = ""
                        loadComboBox()
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            End If
        End If


    End Sub

    Private Sub txtOldPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOldPassword.TextChanged
        errUserValidation.Clear()
    End Sub
End Class