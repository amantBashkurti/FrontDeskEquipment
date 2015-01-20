Public Class formEditEquipment
    Dim db As New inventory

    Private Sub formEditEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboEquipment.SelectedValue = ""
        loadComboBox()

    End Sub

    Private Sub comboEquipment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboEquipment.SelectedIndexChanged
        Try
            Dim selectedEquipment = (From c In db.equipments Where c.id = CInt(comboEquipment.SelectedValue)
                                     Select c.tag, c.name)
            txtTag.Text = selectedEquipment.First().tag
            txtName.Text = selectedEquipment.First().name
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtTag.Text = "" Then
            errValidation.SetError(txtTag, "Tag field cannot be empty")
        ElseIf txtName.Text = "" Then
            errValidation.SetError(txtName, "Description field cannot be empty")
        Else
            Dim selectedEquipment = (From Equipment In db.equipments Where Equipment.id = CInt(comboEquipment.SelectedValue)
                                    Select Equipment)

            selectedEquipment.First().tag = txtTag.Text
            selectedEquipment.First().name = txtName.Text

            Try
                db.SubmitChanges()
                MessageBox.Show("Equipment Edited!")
                txtName.Text = ""
                txtTag.Text = ""
                loadComboBox()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    ' Function that populates the combobox. 
    Public Sub loadComboBox()
        Dim queryEquipments = (From Equipment In db.equipments
                     Select Equipment)

        comboEquipment.DataSource = queryEquipments.ToArray

        comboEquipment.ValueMember = "id"
        comboEquipment.DisplayMember = "tag"
        comboEquipment.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub txtTag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTag.TextChanged
        errValidation.Clear()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        errValidation.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim verification As DialogResult = MessageBox.Show("Are you sure you want to delete the selected Equipment? " _
                      & Environment.NewLine & "This operation cannot be undone!", "Caption", _
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If verification = DialogResult.Yes Then
            Dim selectedEquipment = (From Equipment In db.equipments Where Equipment.id = CInt(comboEquipment.SelectedValue)
                        Select Equipment)
            For Each EquipmentDetail In selectedEquipment
                db.equipments.DeleteOnSubmit(EquipmentDetail)
            Next
            Try
                db.SubmitChanges()
                MessageBox.Show("Equipment Deleted!")
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