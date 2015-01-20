<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditProf))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboProfessor = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.comboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Professor"
        '
        'comboProfessor
        '
        Me.comboProfessor.FormattingEnabled = True
        Me.comboProfessor.Location = New System.Drawing.Point(139, 19)
        Me.comboProfessor.Name = "comboProfessor"
        Me.comboProfessor.Size = New System.Drawing.Size(163, 21)
        Me.comboProfessor.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(139, 59)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(139, 99)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(163, 20)
        Me.txtLastName.TabIndex = 3
        '
        'comboDepartment
        '
        Me.comboDepartment.FormattingEnabled = True
        Me.comboDepartment.Location = New System.Drawing.Point(139, 140)
        Me.comboDepartment.Name = "comboDepartment"
        Me.comboDepartment.Size = New System.Drawing.Size(163, 21)
        Me.comboDepartment.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Departmnet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(35, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'errValidation
        '
        Me.errValidation.ContainerControl = Me
        '
        'formEditProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 262)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboDepartment)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.comboProfessor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEditProf"
        Me.Text = "Edit Professor"
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboProfessor As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents comboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
End Class
