<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddEquipment))
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.errValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(71, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Equipment Tag"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.Location = New System.Drawing.Point(232, 212)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(109, 23)
        Me.btnAddEquipment.TabIndex = 4
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(156, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(185, 20)
        Me.txtName.TabIndex = 0
        '
        'formAddEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 262)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddEquipment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formAddEquipment"
        Me.Text = "Add New Equipment"
        CType(Me.errValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddEquipment As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents errValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class
