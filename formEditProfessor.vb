Public Class formEditProf
    Dim db As New inventory

    Private Sub formEditProf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboProfessor.Text = ""
        loadComboBox()
    End Sub

    Public Sub loadComboBox()
        Dim queryProf = (From professor In db.professors Select professor)

        comboProfessor.DataSource = queryProf.ToArray
        comboProfessor.ValueMember = "id"
        comboProfessor.DisplayMember = "firstName"

        comboProfessor.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub comboProfessor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboProfessor.SelectedIndexChanged
        Try
            Dim selectedProfessor = (From prof In db.professors Where prof.id = CInt(comboProfessor.SelectedValue)
                                     Select prof.firstName, prof.lastName, prof.department)

            txtFirstName.Text = selectedProfessor.First().firstName
            txtLastName.Text = selectedProfessor.First().lastName
            comboDepartment.Text = selectedProfessor.First().department
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim verification As DialogResult = MessageBox.Show("Are you sure you want to delete the selected professor? " _
                      & Environment.NewLine & "This operation cannot be undone!", "Caption", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If verification = DialogResult.Yes Then
            Dim selectedProfessor = (From professor In db.professors Where professor.id = CInt(comboProfessor.SelectedValue)
                        Select professor)
            For Each professorDetail In selectedProfessor
                db.professors.DeleteOnSubmit(professorDetail)
            Next
            Try
                db.SubmitChanges()
                MessageBox.Show("Professor Deleted!")
                loadComboBox()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            ' do nothing
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtFirstName.Text = "" Then
            errValidation.SetError(txtFirstName, "Tag field cannot be empty")
        ElseIf txtLastName.Text = "" Then
            errValidation.SetError(txtLastName, "Description field cannot be empty")
        End If

        Dim selectedProf = (From prof In db.professors Where prof.id = CInt(comboProfessor.SelectedValue)
                                Select prof)

        selectedProf.First().firstName = txtFirstName.Text
        selectedProf.First().lastName = txtLastName.Text
        selectedProf.First().department = comboDepartment.Text

        Try
            db.SubmitChanges()
            MessageBox.Show("Equipment Edited!")
            txtFirstName.Text = ""
            txtLastName.Text = ""
            comboDepartment.SelectedText = ""
            loadComboBox()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class