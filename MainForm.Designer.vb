<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfessorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportProfHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportClassHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.txtDateTime = New System.Windows.Forms.Label()
        Me.dataGridAllocated = New System.Windows.Forms.DataGridView()
        Me.ProfessorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentTagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassroomTagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReturnedTimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblLoggedUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecordBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dataGridAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageToolStripMenuItem, Me.RepToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassesToolStripMenuItem, Me.EquipmentToolStripMenuItem, Me.ProfessorsToolStripMenuItem, Me.UsersToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ClassesToolStripMenuItem.Text = "Classes"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EditToolStripMenuItem.Text = "Edit/Delete"
        '
        'EquipmentToolStripMenuItem
        '
        Me.EquipmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditToolStripMenuItem1})
        Me.EquipmentToolStripMenuItem.Name = "EquipmentToolStripMenuItem"
        Me.EquipmentToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EquipmentToolStripMenuItem.Text = "Equipment"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.EditToolStripMenuItem1.Text = "Edit/Delete"
        '
        'ProfessorsToolStripMenuItem
        '
        Me.ProfessorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.EditToolStripMenuItem2})
        Me.ProfessorsToolStripMenuItem.Name = "ProfessorsToolStripMenuItem"
        Me.ProfessorsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ProfessorsToolStripMenuItem.Text = "Professors"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(132, 22)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(132, 22)
        Me.EditToolStripMenuItem2.Text = "Edit/Delete"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.EditUserToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AddUserToolStripMenuItem.Text = "Add"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EditUserToolStripMenuItem.Text = "Edit/Delete"
        '
        'RepToolStripMenuItem
        '
        Me.RepToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportProfHistoryToolStripMenuItem, Me.ReportClassHistoryToolStripMenuItem})
        Me.RepToolStripMenuItem.Name = "RepToolStripMenuItem"
        Me.RepToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.RepToolStripMenuItem.Text = "Reports"
        '
        'ReportProfHistoryToolStripMenuItem
        '
        Me.ReportProfHistoryToolStripMenuItem.Name = "ReportProfHistoryToolStripMenuItem"
        Me.ReportProfHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportProfHistoryToolStripMenuItem.Text = "Report Prof History"
        '
        'ReportClassHistoryToolStripMenuItem
        '
        Me.ReportClassHistoryToolStripMenuItem.Name = "ReportClassHistoryToolStripMenuItem"
        Me.ReportClassHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportClassHistoryToolStripMenuItem.Text = "Report Class History"
        '
        'timerDateTime
        '
        Me.timerDateTime.Enabled = True
        Me.timerDateTime.Interval = 500
        '
        'txtDateTime
        '
        Me.txtDateTime.AutoSize = True
        Me.txtDateTime.Location = New System.Drawing.Point(9, 301)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(56, 13)
        Me.txtDateTime.TabIndex = 5
        Me.txtDateTime.Text = "Date Time"
        Me.txtDateTime.Visible = False
        '
        'dataGridAllocated
        '
        Me.dataGridAllocated.AllowUserToAddRows = False
        Me.dataGridAllocated.AllowUserToDeleteRows = False
        Me.dataGridAllocated.AllowUserToResizeColumns = False
        Me.dataGridAllocated.AllowUserToResizeRows = False
        Me.dataGridAllocated.AutoGenerateColumns = False
        Me.dataGridAllocated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridAllocated.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProfessorNameDataGridViewTextBoxColumn, Me.EquipmentTagDataGridViewTextBoxColumn, Me.ClassroomTagDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.ReturnedDataGridViewCheckBoxColumn, Me.ReturnedTimestampDataGridViewTextBoxColumn})
        Me.dataGridAllocated.DataSource = Me.RecordBindingSource
        Me.dataGridAllocated.Location = New System.Drawing.Point(12, 84)
        Me.dataGridAllocated.Name = "dataGridAllocated"
        Me.dataGridAllocated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataGridAllocated.Size = New System.Drawing.Size(744, 159)
        Me.dataGridAllocated.TabIndex = 6
        '
        'ProfessorNameDataGridViewTextBoxColumn
        '
        Me.ProfessorNameDataGridViewTextBoxColumn.DataPropertyName = "professorName"
        Me.ProfessorNameDataGridViewTextBoxColumn.HeaderText = "professorName"
        Me.ProfessorNameDataGridViewTextBoxColumn.Name = "ProfessorNameDataGridViewTextBoxColumn"
        '
        'EquipmentTagDataGridViewTextBoxColumn
        '
        Me.EquipmentTagDataGridViewTextBoxColumn.DataPropertyName = "equipmentTag"
        Me.EquipmentTagDataGridViewTextBoxColumn.HeaderText = "equipmentTag"
        Me.EquipmentTagDataGridViewTextBoxColumn.Name = "EquipmentTagDataGridViewTextBoxColumn"
        '
        'ClassroomTagDataGridViewTextBoxColumn
        '
        Me.ClassroomTagDataGridViewTextBoxColumn.DataPropertyName = "classroomTag"
        Me.ClassroomTagDataGridViewTextBoxColumn.HeaderText = "classroomTag"
        Me.ClassroomTagDataGridViewTextBoxColumn.Name = "ClassroomTagDataGridViewTextBoxColumn"
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AllocatedTimestamp"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AllocatedTimestamp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ReturnedDataGridViewCheckBoxColumn
        '
        Me.ReturnedDataGridViewCheckBoxColumn.DataPropertyName = "returned"
        Me.ReturnedDataGridViewCheckBoxColumn.HeaderText = "returned"
        Me.ReturnedDataGridViewCheckBoxColumn.Name = "ReturnedDataGridViewCheckBoxColumn"
        '
        'ReturnedTimestampDataGridViewTextBoxColumn
        '
        Me.ReturnedTimestampDataGridViewTextBoxColumn.DataPropertyName = "returnedTimestamp"
        Me.ReturnedTimestampDataGridViewTextBoxColumn.HeaderText = "returnedTimestamp"
        Me.ReturnedTimestampDataGridViewTextBoxColumn.Name = "ReturnedTimestampDataGridViewTextBoxColumn"
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataSource = GetType(WindowsApplication1.record)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Allocate Equipment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 295)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblLoggedUser
        '
        Me.lblLoggedUser.AutoSize = True
        Me.lblLoggedUser.Location = New System.Drawing.Point(429, 301)
        Me.lblLoggedUser.Name = "lblLoggedUser"
        Me.lblLoggedUser.Size = New System.Drawing.Size(29, 13)
        Me.lblLoggedUser.TabIndex = 8
        Me.lblLoggedUser.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "List of Allocated Equipments:"
        '
        'RecordBindingSource1
        '
        Me.RecordBindingSource1.DataSource = GetType(WindowsApplication1.record)
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(40, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Deallocate Selected Item"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(766, 317)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoggedUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dataGridAllocated)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 355)
        Me.MinimumSize = New System.Drawing.Size(562, 355)
        Me.Name = "MainForm"
        Me.Text = "Equipment Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dataGridAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfessorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timerDateTime As System.Windows.Forms.Timer
    Friend WithEvents txtDateTime As System.Windows.Forms.Label
    Friend WithEvents dataGridAllocated As System.Windows.Forms.DataGridView
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AllocatedTimestampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblLoggedUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RecordBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessorNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EquipmentTagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassroomTagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReturnedTimestampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportProfHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportClassHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
