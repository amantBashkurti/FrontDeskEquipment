Public Class formAllocate
    Dim db As New inventory
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadComboBox("comboProfessor")
        loadComboBox("comboClass")
        loadComboBox("comboEquipment")
    End Sub

    Public Sub loadComboBox(ByVal comboName As String)
        If comboName = "comboClass" Then

            Dim queryClassrooms = (From classroom In db.classrooms Select classroom)

            comboClass.DataSource = queryClassrooms.ToArray
            comboClass.ValueMember = "id"
            comboClass.DisplayMember = "tag"

        ElseIf comboName = "comboProfessor" Then

            Dim queryProfessors = (From professor In db.professors Select professor)

            comboProfessor.DataSource = queryProfessors.ToArray
            comboProfessor.ValueMember = "id"
            comboProfessor.DisplayMember = "firstName"

        ElseIf comboName = "comboEquipment" Then

            Dim queryEquipment = (From equipment In db.equipments Select equipment)

            comboEquipment.DataSource = queryEquipment.ToArray
            comboEquipment.ValueMember = "id"
            comboEquipment.DisplayMember = "tag"

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If (From rec In db.records Where rec.classroomTag.ToUpper() = comboClass.Text.ToUpper() _
                             And rec.equipmentTag.ToUpper() = comboEquipment.Text.ToUpper() _
                             And rec.returned = False Select rec).Count() > 0 Then
                MessageBox.Show("The item has already been taken")
            Else
                Dim record As New record With {
                        .professorName = comboProfessor.Text,
                        .equipmentTag = comboEquipment.Text,
                        .classroomTag = comboClass.Text,
                        .comment = txtComment.Text,
                        .AllocatedTimestamp = DateTime.Now,
                        .returned = 0
                    }
                db.records.InsertOnSubmit(record)
                db.SubmitChanges()
                MessageBox.Show("Record Saved")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class