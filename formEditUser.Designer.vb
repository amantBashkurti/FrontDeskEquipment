﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEditUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboUserType = New System.Windows.Forms.ComboBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPasswordVerify = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnCancelAddUser = New System.Windows.Forms.Button()
        Me.errUserValidation = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.comboUsers = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.errUserValidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User Type"
        '
        'comboUserType
        '
        Me.comboUserType.FormattingEnabled = True
        Me.comboUserType.Items.AddRange(New Object() {"User", "Administrator"})
        Me.comboUserType.Location = New System.Drawing.Point(129, 231)
        Me.comboUserType.Name = "comboUserType"
        Me.comboUserType.Size = New System.Drawing.Size(166, 21)
        Me.comboUserType.TabIndex = 4
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(129, 72)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(166, 20)
        Me.txtFullName.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(129, 105)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(166, 20)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(129, 165)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(166, 20)
        Me.txtPassword.TabIndex = 7
        '
        'txtPasswordVerify
        '
        Me.txtPasswordVerify.Location = New System.Drawing.Point(129, 198)
        Me.txtPasswordVerify.Name = "txtPasswordVerify"
        Me.txtPasswordVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordVerify.Size = New System.Drawing.Size(166, 20)
        Me.txtPasswordVerify.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Repeat Password"
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(187, 275)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(107, 23)
        Me.btnEditUser.TabIndex = 10
        Me.btnEditUser.Text = "Submit Changes"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'btnCancelAddUser
        '
        Me.btnCancelAddUser.Location = New System.Drawing.Point(128, 275)
        Me.btnCancelAddUser.Name = "btnCancelAddUser"
        Me.btnCancelAddUser.Size = New System.Drawing.Size(53, 23)
        Me.btnCancelAddUser.TabIndex = 11
        Me.btnCancelAddUser.Text = "Cancel"
        Me.btnCancelAddUser.UseVisualStyleBackColor = True
        '
        'errUserValidation
        '
        Me.errUserValidation.ContainerControl = Me
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDeleteUser.Location = New System.Drawing.Point(25, 275)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteUser.TabIndex = 13
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'comboUsers
        '
        Me.comboUsers.DisplayMember = "Test"
        Me.comboUsers.FormattingEnabled = True
        Me.comboUsers.Location = New System.Drawing.Point(129, 34)
        Me.comboUsers.Name = "comboUsers"
        Me.comboUsers.Size = New System.Drawing.Size(165, 21)
        Me.comboUsers.TabIndex = 15
        Me.comboUsers.ValueMember = "Select Classroom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Select User"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(128, 136)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(166, 20)
        Me.txtOldPassword.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Old Password"
        '
        'formEditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 316)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboUsers)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnCancelAddUser)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPasswordVerify)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.comboUserType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEditUser"
        Me.Text = "Edit User"
        CType(Me.errUserValidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboUserType As System.Windows.Forms.ComboBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordVerify As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnCancelAddUser As System.Windows.Forms.Button
    Friend WithEvents errUserValidation As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents comboUsers As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
