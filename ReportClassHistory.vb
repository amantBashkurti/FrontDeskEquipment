Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportClassHistory
    Private db As New inventory
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("..\..\CrystalReport2.rpt")
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue
        crParameterDiscreteValue.Value = ComboBox1.Text
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("ctag")
        crParameterValues = crParameterFieldDefinition.CurrentValues
        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub ReportClassHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim queryClassrooms = (From classroom In db.classrooms Select classroom)

        ComboBox1.DataSource = queryClassrooms.ToArray
        ComboBox1.ValueMember = "id"
        ComboBox1.DisplayMember = "tag"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class