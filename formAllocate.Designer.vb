<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAllocate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAllocate))
        Me.comboProfessor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboClass = New System.Windows.Forms.ComboBox()
        Me.comboEquipment = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'comboProfessor
        '
        Me.comboProfessor.FormattingEnabled = True
        Me.comboProfessor.Location = New System.Drawing.Point(41, 34)
        Me.comboProfessor.Name = "comboProfessor"
        Me.comboProfessor.Size = New System.Drawing.Size(214, 21)
        Me.comboProfessor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Professor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Class"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select Equipment"
        '
        'comboClass
        '
        Me.comboClass.FormattingEnabled = True
        Me.comboClass.Location = New System.Drawing.Point(41, 86)
        Me.comboClass.Name = "comboClass"
        Me.comboClass.Size = New System.Drawing.Size(214, 21)
        Me.comboClass.TabIndex = 4
        '
        'comboEquipment
        '
        Me.comboEquipment.FormattingEnabled = True
        Me.comboEquipment.Location = New System.Drawing.Point(41, 138)
        Me.comboEquipment.Name = "comboEquipment"
        Me.comboEquipment.Size = New System.Drawing.Size(214, 21)
        Me.comboEquipment.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Allocate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comment"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(41, 184)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(214, 83)
        Me.txtComment.TabIndex = 8
        '
        'formAllocate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(297, 333)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboEquipment)
        Me.Controls.Add(Me.comboClass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboProfessor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formAllocate"
        Me.Text = "Allocate Equipment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboProfessor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboClass As System.Windows.Forms.ComboBox
    Friend WithEvents comboEquipment As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
End Class
