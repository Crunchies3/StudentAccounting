<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_StudentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.pnl_buttons = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_studentname = New System.Windows.Forms.Panel()
        Me.pnl_menuicon = New System.Windows.Forms.Panel()
        Me.pnl_header = New System.Windows.Forms.Panel()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.pnl_menu.SuspendLayout()
        Me.pnl_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.Controls.Add(Me.pnl_buttons)
        Me.pnl_menu.Controls.Add(Me.pnl_studentname)
        Me.pnl_menu.Controls.Add(Me.pnl_menuicon)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(265, 679)
        Me.pnl_menu.TabIndex = 0
        '
        'pnl_buttons
        '
        Me.pnl_buttons.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnl_buttons.Controls.Add(Me.Button6)
        Me.pnl_buttons.Controls.Add(Me.Button5)
        Me.pnl_buttons.Controls.Add(Me.Button3)
        Me.pnl_buttons.Controls.Add(Me.Button2)
        Me.pnl_buttons.Controls.Add(Me.Button1)
        Me.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_buttons.Location = New System.Drawing.Point(0, 162)
        Me.pnl_buttons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_buttons.Name = "pnl_buttons"
        Me.pnl_buttons.Size = New System.Drawing.Size(265, 517)
        Me.pnl_buttons.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(37, 442)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(182, 31)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "LOGOUT"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(37, 136)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 31)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "ASSESSMENT"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(37, 100)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 31)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "ENROLL SUBJECT"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(37, 64)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 31)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "SUBJECTS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnl_studentname
        '
        Me.pnl_studentname.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnl_studentname.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_studentname.Location = New System.Drawing.Point(0, 39)
        Me.pnl_studentname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_studentname.Name = "pnl_studentname"
        Me.pnl_studentname.Size = New System.Drawing.Size(265, 123)
        Me.pnl_studentname.TabIndex = 2
        '
        'pnl_menuicon
        '
        Me.pnl_menuicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnl_menuicon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_menuicon.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menuicon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_menuicon.Name = "pnl_menuicon"
        Me.pnl_menuicon.Size = New System.Drawing.Size(265, 39)
        Me.pnl_menuicon.TabIndex = 1
        '
        'pnl_header
        '
        Me.pnl_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnl_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_header.Location = New System.Drawing.Point(265, 0)
        Me.pnl_header.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_header.Name = "pnl_header"
        Me.pnl_header.Size = New System.Drawing.Size(1179, 39)
        Me.pnl_header.TabIndex = 2
        '
        'pnl_main
        '
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_main.Location = New System.Drawing.Point(265, 39)
        Me.pnl_main.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(1179, 640)
        Me.pnl_main.TabIndex = 4
        '
        'frm_StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1444, 679)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.pnl_header)
        Me.Controls.Add(Me.pnl_menu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_menu.ResumeLayout(False)
        Me.pnl_buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_menu As Panel
    Friend WithEvents pnl_buttons As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnl_studentname As Panel
    Friend WithEvents pnl_menuicon As Panel
    Friend WithEvents pnl_header As Panel
    Friend WithEvents pnl_main As Panel
End Class
