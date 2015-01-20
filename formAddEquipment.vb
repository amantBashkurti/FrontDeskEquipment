Public Class formAddEquipment
    Dim db As New inventory
    Private Sub formAddEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddClassroom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEquipment.Click
        Try
            If txtTag.Text = "" Then
                errValidation.SetError(txtTag, "Tag field cannot be empty")
            ElseIf txtName.Text = "" Then
                errValidation.SetError(txtName, "Name field cannot be empty")
            End If
            If (From eq In db.equipments Where eq.tag.ToUpper() = txtTag.Text.ToUpper
                                  Select eq).Count() > 0 Then
                MessageBox.Show("record already exists")
            Else
                Dim equipment As New equipment With {
                        .tag = txtTag.Text,
                        .name = txtName.Text
                }
                db.equipments.InsertOnSubmit(equipment)


                db.SubmitChanges()
                MessageBox.Show("Equipment Added!")
                txtName.Text = ""
                txtTag.Text = ""
            End If
            Catch
            ' Handle exception.
        End Try

    End Sub

    Private Sub txtTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        errValidation.Clear()
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        errValidation.Clear()
    End Sub
End Class