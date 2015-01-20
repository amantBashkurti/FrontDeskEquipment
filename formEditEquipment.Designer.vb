<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditEquipment))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboEquipment = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(147, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(185, 20)
        Me.txtName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Equipment Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Equipment Tag"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(147, 65)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(185, 20)
        Me.txtTag.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select Equipment"
        '
        'comboEquipment
        '
        Me.comboEquipment.DisplayMember = "Test"
        Me.comboEquipment.FormattingEnabled = True
        Me.comboEquipment.Location = New System.Drawing.Point(147, 28)
        Me.comboEquipment.Name = "comboEquipment"
        Me.comboEquipment.Size = New System.Drawing.Size(185, 21)
        Me.comboEquipment.TabIndex = 9
        Me.comboEquipment.ValueMember = "Select Classroom"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Submit Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'errValidation
        '
        Me.errValidation.ContainerControl = Me
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(12, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'formEditEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 207)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboEquipment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEditEquipment"
        Me.Text = "Edit Equipment"
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboEquipment As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
