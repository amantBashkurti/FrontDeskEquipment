<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddClassroom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddClassroom))
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAddClassroom = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(156, 41)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(185, 20)
        Me.txtTag.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Classrom Tag"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Classroom Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(156, 87)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(185, 100)
        Me.txtDescription.TabIndex = 3
        '
        'btnAddClassroom
        '
        Me.btnAddClassroom.Location = New System.Drawing.Point(232, 212)
        Me.btnAddClassroom.Name = "btnAddClassroom"
        Me.btnAddClassroom.Size = New System.Drawing.Size(109, 23)
        Me.btnAddClassroom.TabIndex = 4
        Me.btnAddClassroom.Text = "Add Classroom"
        Me.btnAddClassroom.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(156, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(57, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'errValidation
        '
        Me.errValidation.ContainerControl = Me
        '
        'formAddEquipmet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 262)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddClassroom)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formAddEquipmet"
        Me.Text = "Add New Classroom"
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnAddClassroom As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
End Class
