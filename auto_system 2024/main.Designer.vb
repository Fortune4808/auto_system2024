<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.userCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.recordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.homeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.delBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.fetchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.profile_id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.mobileNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.submitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.selectPictureBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.passport = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.closeBtn)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 47)
        Me.Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.BorderRadius = 10
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(56, 47)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.Maroon
        Me.closeBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeBtn.HoverState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(708, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(55, 47)
        Me.closeBtn.TabIndex = 1
        Me.closeBtn.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.userCount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.recordBtn)
        Me.Panel2.Controls.Add(Me.homeBtn)
        Me.Panel2.Location = New System.Drawing.Point(-2, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 47)
        Me.Panel2.TabIndex = 1
        '
        'userCount
        '
        Me.userCount.AutoSize = True
        Me.userCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userCount.ForeColor = System.Drawing.Color.Maroon
        Me.userCount.Location = New System.Drawing.Point(707, 17)
        Me.userCount.Name = "userCount"
        Me.userCount.Size = New System.Drawing.Size(14, 13)
        Me.userCount.TabIndex = 6
        Me.userCount.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "USERS COUNT"
        '
        'recordBtn
        '
        Me.recordBtn.BorderRadius = 5
        Me.recordBtn.CheckedState.Parent = Me.recordBtn
        Me.recordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recordBtn.CustomImages.Parent = Me.recordBtn
        Me.recordBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.recordBtn.ForeColor = System.Drawing.Color.White
        Me.recordBtn.HoverState.Parent = Me.recordBtn
        Me.recordBtn.Location = New System.Drawing.Point(148, 7)
        Me.recordBtn.Name = "recordBtn"
        Me.recordBtn.ShadowDecoration.Parent = Me.recordBtn
        Me.recordBtn.Size = New System.Drawing.Size(125, 32)
        Me.recordBtn.TabIndex = 3
        Me.recordBtn.Text = "VIEW RECORD"
        '
        'homeBtn
        '
        Me.homeBtn.BorderRadius = 5
        Me.homeBtn.CheckedState.Parent = Me.homeBtn
        Me.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeBtn.CustomImages.Parent = Me.homeBtn
        Me.homeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.homeBtn.ForeColor = System.Drawing.Color.White
        Me.homeBtn.HoverState.Parent = Me.homeBtn
        Me.homeBtn.Location = New System.Drawing.Point(14, 7)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.ShadowDecoration.Parent = Me.homeBtn
        Me.homeBtn.Size = New System.Drawing.Size(125, 32)
        Me.homeBtn.TabIndex = 2
        Me.homeBtn.Text = "HOME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.delBtn)
        Me.GroupBox1.Controls.Add(Me.fetchBtn)
        Me.GroupBox1.Controls.Add(Me.profile_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 103)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROFILE ID"
        '
        'delBtn
        '
        Me.delBtn.BorderRadius = 5
        Me.delBtn.CheckedState.Parent = Me.delBtn
        Me.delBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delBtn.CustomImages.Parent = Me.delBtn
        Me.delBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.delBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.delBtn.ForeColor = System.Drawing.Color.White
        Me.delBtn.HoverState.Parent = Me.delBtn
        Me.delBtn.Location = New System.Drawing.Point(155, 59)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.ShadowDecoration.Parent = Me.delBtn
        Me.delBtn.Size = New System.Drawing.Size(125, 32)
        Me.delBtn.TabIndex = 5
        Me.delBtn.Text = "DELETE"
        '
        'fetchBtn
        '
        Me.fetchBtn.BorderRadius = 5
        Me.fetchBtn.CheckedState.Parent = Me.fetchBtn
        Me.fetchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetchBtn.CustomImages.Parent = Me.fetchBtn
        Me.fetchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fetchBtn.ForeColor = System.Drawing.Color.White
        Me.fetchBtn.HoverState.Parent = Me.fetchBtn
        Me.fetchBtn.Location = New System.Drawing.Point(15, 59)
        Me.fetchBtn.Name = "fetchBtn"
        Me.fetchBtn.ShadowDecoration.Parent = Me.fetchBtn
        Me.fetchBtn.Size = New System.Drawing.Size(125, 32)
        Me.fetchBtn.TabIndex = 4
        Me.fetchBtn.Text = "FETCH"
        '
        'profile_id
        '
        Me.profile_id.BackColor = System.Drawing.Color.Transparent
        Me.profile_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id.FocusedState.Parent = Me.profile_id
        Me.profile_id.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.profile_id.ForeColor = System.Drawing.Color.Black
        Me.profile_id.FormattingEnabled = True
        Me.profile_id.HoverState.Parent = Me.profile_id
        Me.profile_id.ItemHeight = 30
        Me.profile_id.ItemsAppearance.Parent = Me.profile_id
        Me.profile_id.Location = New System.Drawing.Point(12, 17)
        Me.profile_id.Name = "profile_id"
        Me.profile_id.ShadowDecoration.Parent = Me.profile_id
        Me.profile_id.Size = New System.Drawing.Size(714, 36)
        Me.profile_id.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.clearBtn)
        Me.GroupBox2.Controls.Add(Me.mobileNo)
        Me.GroupBox2.Controls.Add(Me.submitBtn)
        Me.GroupBox2.Controls.Add(Me.email)
        Me.GroupBox2.Controls.Add(Me.fullName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 281)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REGISTRATION"
        '
        'clearBtn
        '
        Me.clearBtn.BorderRadius = 5
        Me.clearBtn.CheckedState.Parent = Me.clearBtn
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBtn.CustomImages.Parent = Me.clearBtn
        Me.clearBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.HoverState.Parent = Me.clearBtn
        Me.clearBtn.Location = New System.Drawing.Point(177, 209)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.ShadowDecoration.Parent = Me.clearBtn
        Me.clearBtn.Size = New System.Drawing.Size(140, 46)
        Me.clearBtn.TabIndex = 6
        Me.clearBtn.Text = "CLEAR"
        '
        'mobileNo
        '
        Me.mobileNo.BorderRadius = 5
        Me.mobileNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mobileNo.DefaultText = ""
        Me.mobileNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mobileNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mobileNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobileNo.DisabledState.Parent = Me.mobileNo
        Me.mobileNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mobileNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobileNo.FocusedState.Parent = Me.mobileNo
        Me.mobileNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mobileNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mobileNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mobileNo.HoverState.Parent = Me.mobileNo
        Me.mobileNo.Location = New System.Drawing.Point(16, 143)
        Me.mobileNo.Name = "mobileNo"
        Me.mobileNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mobileNo.PlaceholderText = "PHONE NUMBER"
        Me.mobileNo.SelectedText = ""
        Me.mobileNo.ShadowDecoration.Parent = Me.mobileNo
        Me.mobileNo.Size = New System.Drawing.Size(463, 49)
        Me.mobileNo.TabIndex = 2
        '
        'submitBtn
        '
        Me.submitBtn.BorderRadius = 5
        Me.submitBtn.CheckedState.Parent = Me.submitBtn
        Me.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitBtn.CustomImages.Parent = Me.submitBtn
        Me.submitBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.submitBtn.ForeColor = System.Drawing.Color.White
        Me.submitBtn.HoverState.Parent = Me.submitBtn
        Me.submitBtn.Location = New System.Drawing.Point(16, 209)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.ShadowDecoration.Parent = Me.submitBtn
        Me.submitBtn.Size = New System.Drawing.Size(140, 46)
        Me.submitBtn.TabIndex = 5
        Me.submitBtn.Text = "SUBMIT"
        '
        'email
        '
        Me.email.BorderRadius = 5
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.DefaultText = ""
        Me.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.DisabledState.Parent = Me.email
        Me.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.FocusedState.Parent = Me.email
        Me.email.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.HoverState.Parent = Me.email
        Me.email.Location = New System.Drawing.Point(16, 88)
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.PlaceholderText = "EMAIL ADDRESS"
        Me.email.SelectedText = ""
        Me.email.ShadowDecoration.Parent = Me.email
        Me.email.Size = New System.Drawing.Size(463, 49)
        Me.email.TabIndex = 1
        '
        'fullName
        '
        Me.fullName.BorderRadius = 5
        Me.fullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullName.DefaultText = ""
        Me.fullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullName.DisabledState.Parent = Me.fullName
        Me.fullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullName.FocusedState.Parent = Me.fullName
        Me.fullName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullName.HoverState.Parent = Me.fullName
        Me.fullName.Location = New System.Drawing.Point(16, 33)
        Me.fullName.Name = "fullName"
        Me.fullName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullName.PlaceholderText = "FULLNAME"
        Me.fullName.SelectedText = ""
        Me.fullName.ShadowDecoration.Parent = Me.fullName
        Me.fullName.Size = New System.Drawing.Size(463, 49)
        Me.fullName.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.selectPictureBtn)
        Me.GroupBox3.Controls.Add(Me.passport)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(520, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 281)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PASSPORT"
        '
        'selectPictureBtn
        '
        Me.selectPictureBtn.CheckedState.Parent = Me.selectPictureBtn
        Me.selectPictureBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectPictureBtn.CustomImages.Parent = Me.selectPictureBtn
        Me.selectPictureBtn.FillColor = System.Drawing.Color.Gray
        Me.selectPictureBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.selectPictureBtn.ForeColor = System.Drawing.Color.White
        Me.selectPictureBtn.HoverState.Parent = Me.selectPictureBtn
        Me.selectPictureBtn.Location = New System.Drawing.Point(6, 226)
        Me.selectPictureBtn.Name = "selectPictureBtn"
        Me.selectPictureBtn.ShadowDecoration.Parent = Me.selectPictureBtn
        Me.selectPictureBtn.Size = New System.Drawing.Size(215, 45)
        Me.selectPictureBtn.TabIndex = 6
        Me.selectPictureBtn.Text = "SELECT PASSPORT"
        '
        'passport
        '
        Me.passport.BackgroundImage = CType(resources.GetObject("passport.BackgroundImage"), System.Drawing.Image)
        Me.passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passport.Location = New System.Drawing.Point(7, 19)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(212, 201)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 0
        Me.passport.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 504)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents recordBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents homeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents userCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents profile_id As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents delBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fetchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents submitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fullName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents mobileNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents selectPictureBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents passport As System.Windows.Forms.PictureBox
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
End Class
