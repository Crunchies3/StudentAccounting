<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdminDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_buttons = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_logo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnl_main = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.pnl_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnl_buttons)
        Me.Panel1.Controls.Add(Me.pnl_logo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 725)
        Me.Panel1.TabIndex = 0
        '
        'pnl_buttons
        '
        Me.pnl_buttons.Controls.Add(Me.Button1)
        Me.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_buttons.Location = New System.Drawing.Point(0, 221)
        Me.pnl_buttons.Name = "pnl_buttons"
        Me.pnl_buttons.Size = New System.Drawing.Size(253, 504)
        Me.pnl_buttons.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(30, 71)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "DASHBOARD"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnl_logo
        '
        Me.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_logo.Location = New System.Drawing.Point(0, 53)
        Me.pnl_logo.Name = "pnl_logo"
        Me.pnl_logo.Size = New System.Drawing.Size(253, 168)
        Me.pnl_logo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 53)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(253, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1076, 53)
        Me.Panel3.TabIndex = 1
        '
        'pnl_main
        '
        Me.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_main.Location = New System.Drawing.Point(253, 53)
        Me.pnl_main.Name = "pnl_main"
        Me.pnl_main.Size = New System.Drawing.Size(1076, 672)
        Me.pnl_main.TabIndex = 2
        '
        'frm_AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 725)
        Me.Controls.Add(Me.pnl_main)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_AdminDashboard"
        Me.Text = "frm_AdminDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.pnl_buttons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnl_buttons As Panel
    Friend WithEvents pnl_logo As Panel
    Friend WithEvents pnl_main As Panel
    Friend WithEvents Button1 As Button
End Class
