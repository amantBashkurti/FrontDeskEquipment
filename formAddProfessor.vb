Public Class formAddProfessor
    Dim db As New inventory
    Private Sub formAddProfessor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtFirstName.Text = "" Then
                errValidateProfessor.SetError(txtFirstName, "First name cannot be empty")
            ElseIf txtLastName.Text = "" Then
                errValidateProfessor.SetError(txtLastName, "Last name cacnnot be empty")
            ElseIf comboDepartment.SelectedItem.ToString = "" Then
                errValidateProfessor.SetError(comboDepartment, "Department name cannot be empty")
            End If

            If (From prof In db.professors Where prof.firstName.ToUpper() = txtFirstName.Text.ToUpper() _
                                And prof.lastName.ToUpper() = txtLastName.Text.ToUpper() And prof.department.ToUpper() = comboDepartment.Text.ToUpper()
                                 Select prof).Count() > 0 Then
                MessageBox.Show("record already exists")
            Else
                Dim professor As New professor With {
                    .firstName = txtFirstName.Text,
                    .lastName = txtLastName.Text,
                    .department = comboDepartment.SelectedItem.ToString()
                     }
                db.professors.InsertOnSubmit(professor)

                db.SubmitChanges()
                MessageBox.Show("Professor added")
                txtFirstName.Text = ""
                txtLastName.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged
        errValidateProfessor.Clear()
    End Sub

    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        errValidateProfessor.Clear()
    End Sub
End Class