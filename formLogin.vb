Public Class formLogin
    Dim db As New inventory
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text = "" Then
                errValidate.SetError(txtUsername, "Please enter username")
            ElseIf txtPassword.Text = "" Then
                errValidate.SetError(txtPassword, "Please enter password")
            Else
                Dim username = txtUsername.Text
                Dim password = txtPassword.Text
                Dim hashedPassword = getSHA1Hash(password)

                If (From user In db.userinventories Where user.username Like username Select user).Count < 1 Then
                    MessageBox.Show("Wrong username/password")
                Else
                    Dim queryUser = (From user In db.userinventories Where user.username Like username Select user)
                    If queryUser.First().password = hashedPassword Then
                        Dim myMainForm As MainForm = New MainForm(queryUser.First().id)
                        myMainForm.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Wrong username/password")
                    End If

                End If
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

End Class