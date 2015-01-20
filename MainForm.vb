Public Class MainForm

    Dim db As New inventory
    Private selectedrecord As record
    Public uId As String

    Public Sub New(ByVal userid As String)
        InitializeComponent()
        uId = userid
    End Sub

    Private Sub timerDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerDateTime.Tick
        Dim hour As Integer = DateTime.Now.Hour
        Dim min As Integer = DateTime.Now.Minute
        Dim sec As Integer = DateTime.Now.Second
        Dim dateToday As Integer = DateTime.Now.Day
        Dim year As Integer = DateTime.Now.Year
        Dim month As Integer = DateTime.Now.Month

        txtDateTime.Visible = True
        txtDateTime.Text = month & "/" & dateToday & "/" & year & " - " & hour & ":" & min & ":" & sec

        populateDatagrid()

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        formAddClassroom.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        formEditClassroom.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        formAddUser.Show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem1.Click
        formAddEquipment.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        formEditEquipment.Show()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUserToolStripMenuItem.Click
        formEditUser.Show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        formAddProfessor.Show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click
        formEditProf.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formAllocate.Show()
        dataGridAllocated.Update()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim queryUser = (From user In db.userinventories Where user.id = uId Select user)
        lblLoggedUser.Text = queryUser.First().fullname
        If queryUser.First().userType <> "Administrator" Then
            ManageToolStripMenuItem.Visible = False
        End If



    End Sub


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim newlogin As New formLogin
        newlogin.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dataGridAllocated_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridAllocated.CellMouseClick
        Button2.Enabled = True
        selectedrecord = (From record In db.records Where record.professorName = CStr(dataGridAllocated.Rows(e.RowIndex).Cells(0).Value) _
                      And record.classroomTag = CStr(dataGridAllocated.Rows(e.RowIndex).Cells(2).Value) _
                      And record.equipmentTag = CStr(dataGridAllocated.Rows(e.RowIndex).Cells(1).Value) _
                      And record.comment = CStr(dataGridAllocated.Rows(e.RowIndex).Cells(3).Value)
                         Select record).First()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        selectedrecord.returned = True
        selectedrecord.returnedTimestamp = DateTime.Now
        db.SubmitChanges()
        Button2.Enabled = False
    End Sub

    Private Sub ReportProfHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportProfHistoryToolStripMenuItem.Click
        ReportProfHistory.Show()
    End Sub

    Private Sub ReportClassHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportClassHistoryToolStripMenuItem.Click
        ReportClassHistory.Show()
    End Sub

    Private Sub populateDatagrid()
        Dim queryRecords = (From record In db.records Where record.returned = 0 Select record)
        dataGridAllocated.DataSource = queryRecords
    End Sub
End Class
