<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditClassroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditClassroom))
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboClasses = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(147, 104)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(185, 100)
        Me.txtDescription.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Classroom Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Classrom Tag"
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(147, 58)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(185, 20)
        Me.txtTag.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select Classroom"
        '
        'comboClasses
        '
        Me.comboClasses.DisplayMember = "Test"
        Me.comboClasses.FormattingEnabled = True
        Me.comboClasses.Location = New System.Drawing.Point(147, 28)
        Me.comboClasses.Name = "comboClasses"
        Me.comboClasses.Size = New System.Drawing.Size(185, 21)
        Me.comboClasses.TabIndex = 9
        Me.comboClasses.ValueMember = "Select Classroom"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Submit Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 227)
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
        Me.Button3.Location = New System.Drawing.Point(13, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'formEditClassroom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 262)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboClasses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEditClassroom"
        Me.Text = "Edit Classroom"
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboClasses As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
