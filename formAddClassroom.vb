Public Class formAddClassroom
    Dim db As New inventory
    Private Sub formAddClassroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddClassroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddClassroom.Click
        If txtTag.Text = "" Then
            errValidation.SetError(txtTag, "Tag field cannot be empty")
        ElseIf txtDescription.Text = "" Then
            errValidation.SetError(txtDescription, "Description field cannot be empty")
        End If
        Try
            If (From c In db.classrooms Where c.tag.ToUpper() = txtTag.Text.ToUpper()
                               Select c).Count() > 0 Then
                MessageBox.Show("record already exists")
            Else
                Dim classroom As New classroom With {
                        .tag = txtTag.Text,
                        .description = txtDescription.Text
                }

                db.classrooms.InsertOnSubmit(classroom)
                db.SubmitChanges()

                MessageBox.Show("Class Added!")
                txtDescription.Text = ""
                txtTag.Text = ""
            End If
        Catch ex As Exception
            ' Handle exception.
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        errValidation.Clear()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        errValidation.Clear()
    End Sub

    Private Sub txtTag_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTag.TextChanged
        errValidation.Clear()
    End Sub
End Class