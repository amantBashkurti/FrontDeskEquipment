Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportProfHistory
    Private db As New inventory

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cryRpt As New ReportDocument
        cryRpt.Load("..\..\profhist.rpt")
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue
        crParameterDiscreteValue.Value = ComboBox1.Text
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("profname")
        crParameterValues = crParameterFieldDefinition.CurrentValues
        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub ReportProfHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim queryProfessors = (From professor In db.professors Select professor)

        ComboBox1.DataSource = queryProfessors.ToArray
        ComboBox1.ValueMember = "id"
        ComboBox1.DisplayMember = "firstName"
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class