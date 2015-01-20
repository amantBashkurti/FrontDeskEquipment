Public Class formEditClassroom
    Private db As New inventory

    Private Sub formEditClassroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboClasses.SelectedValue = ""
        loadComboBox()

    End Sub

    Private Sub comboClasses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboClasses.SelectedIndexChanged
        Try
            Dim selectedClassroom = (From c In db.classrooms Where c.id = CInt(comboClasses.SelectedValue)
                                     Select c.tag, c.description)

            txtTag.Text = selectedClassroom.First().tag
            txtDescription.Text = selectedClassroom.First().description
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtTag.Text = "" Then
            errValidation.SetError(txtTag, "Tag field cannot be empty")
        ElseIf txtDescription.Text = "" Then
            errValidation.SetError(txtDescription, "Description field cannot be empty")
        Else
            Dim selectedClassroom = (From classroom In db.classrooms Where classroom.id = CInt(comboClasses.SelectedValue)
                                    Select classroom)

            selectedClassroom.First().tag = txtTag.Text
            selectedClassroom.First().description = txtDescription.Text

            Try
                db.SubmitChanges()
                MessageBox.Show("Class Edited!")
                txtDescription.Text = ""
                txtTag.Text = ""
                loadComboBox()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    ' Function that populates the combobox. 
    Public Sub loadComboBox()
        Dim queryClassrooms = (From classroom In db.classrooms
                     Select classroom)

        comboClasses.DataSource = queryClassrooms.ToArray

        comboClasses.ValueMember = "id"
        comboClasses.DisplayMember = "tag"
        comboClasses.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub txtTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTag.TextChanged
        errValidation.Clear()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        errValidation.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim verification As DialogResult = MessageBox.Show("Are you sure you want to delete the selected classroom? " _
                      & Environment.NewLine & "This operation cannot be undone!", "Caption", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If verification = DialogResult.Yes Then
            Dim selectedClassroom = (From classroom In db.classrooms Where classroom.id = CInt(comboClasses.SelectedValue)
                        Select classroom)
            For Each classroomDetail In selectedClassroom
                db.classrooms.DeleteOnSubmit(classroomDetail)
            Next
            Try
                db.SubmitChanges()
                MessageBox.Show("Class Deleted!")
                loadComboBox()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            ' do nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class