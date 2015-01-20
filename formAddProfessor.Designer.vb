<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddProfessor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddProfessor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboDepartment = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errValidateProfessor = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errValidateProfessor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department"
        '
        'comboDepartment
        '
        Me.comboDepartment.FormattingEnabled = True
        Me.comboDepartment.Items.AddRange(New Object() {"Business and Administrative Sciences", "Mathematics and Natural Sciences", "Computer Science and Information Systems", "English Language and Literature", "Humanities and Social Sciences"})
        Me.comboDepartment.Location = New System.Drawing.Point(103, 99)
        Me.comboDepartment.Name = "comboDepartment"
        Me.comboDepartment.Size = New System.Drawing.Size(147, 21)
        Me.comboDepartment.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(103, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(147, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(103, 67)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(147, 20)
        Me.txtLastName.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add Professor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'errValidateProfessor
        '
        Me.errValidateProfessor.ContainerControl = Me
        '
        'formAddProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 200)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.comboDepartment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formAddProfessor"
        Me.Text = "Add Professor"
        CType(Me.errValidateProfessor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents errValidateProfessor As System.Windows.Forms.ErrorProvider
End Class
