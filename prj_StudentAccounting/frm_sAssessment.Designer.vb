<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sAssessment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_totalAssessment = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_Datagrid = New System.Windows.Forms.Panel()
        Me.dgv_assessment = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_dateTime = New System.Windows.Forms.Label()
        Me.lbl_accountNumber = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_smallSemester = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_semester = New System.Windows.Forms.Label()
        Me.lbl_program = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnl_Datagrid.SuspendLayout()
        CType(Me.dgv_assessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(28, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Enroll Subjects"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 44)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 505)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1016, 44)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(36, 505)
        Me.Panel4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(27, 44)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 505)
        Me.Panel2.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lbl_totalAssessment)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.pnl_Datagrid)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 167)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(989, 338)
        Me.Panel7.TabIndex = 3
        '
        'lbl_totalAssessment
        '
        Me.lbl_totalAssessment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_totalAssessment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_totalAssessment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_totalAssessment.Location = New System.Drawing.Point(732, 265)
        Me.lbl_totalAssessment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_totalAssessment.Name = "lbl_totalAssessment"
        Me.lbl_totalAssessment.Size = New System.Drawing.Size(133, 15)
        Me.lbl_totalAssessment.TabIndex = 11
        Me.lbl_totalAssessment.Text = "20,949.00"
        Me.lbl_totalAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(139, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Assessment"
        '
        'pnl_Datagrid
        '
        Me.pnl_Datagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Datagrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnl_Datagrid.Controls.Add(Me.dgv_assessment)
        Me.pnl_Datagrid.Location = New System.Drawing.Point(140, 62)
        Me.pnl_Datagrid.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_Datagrid.Name = "pnl_Datagrid"
        Me.pnl_Datagrid.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_Datagrid.Size = New System.Drawing.Size(725, 189)
        Me.pnl_Datagrid.TabIndex = 10
        '
        'dgv_assessment
        '
        Me.dgv_assessment.AllowUserToResizeColumns = False
        Me.dgv_assessment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_assessment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_assessment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_assessment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_assessment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_assessment.ColumnHeadersHeight = 35
        Me.dgv_assessment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_assessment.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_assessment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_assessment.Location = New System.Drawing.Point(1, 1)
        Me.dgv_assessment.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_assessment.Name = "dgv_assessment"
        Me.dgv_assessment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_assessment.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_assessment.RowHeadersWidth = 51
        Me.dgv_assessment.RowTemplate.Height = 35
        Me.dgv_assessment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_assessment.Size = New System.Drawing.Size(723, 187)
        Me.dgv_assessment.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Charge Description"
        Me.Column3.MinimumWidth = 200
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount"
        Me.Column6.MinimumWidth = 100
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lbl_dateTime)
        Me.Panel8.Controls.Add(Me.lbl_accountNumber)
        Me.Panel8.Controls.Add(Me.lbl_name)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(989, 54)
        Me.Panel8.TabIndex = 9
        '
        'lbl_dateTime
        '
        Me.lbl_dateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_dateTime.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lbl_dateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_dateTime.Location = New System.Drawing.Point(700, 28)
        Me.lbl_dateTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_dateTime.Name = "lbl_dateTime"
        Me.lbl_dateTime.Size = New System.Drawing.Size(165, 19)
        Me.lbl_dateTime.TabIndex = 8
        Me.lbl_dateTime.Text = "10/01/2023 13:37:20"
        Me.lbl_dateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_accountNumber
        '
        Me.lbl_accountNumber.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lbl_accountNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_accountNumber.Location = New System.Drawing.Point(140, 28)
        Me.lbl_accountNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_accountNumber.Name = "lbl_accountNumber"
        Me.lbl_accountNumber.Size = New System.Drawing.Size(182, 19)
        Me.lbl_accountNumber.TabIndex = 8
        Me.lbl_accountNumber.Text = "Account No.: 134563"
        Me.lbl_accountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(0, 29)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(989, 20)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "Name: Alvez, Cyril Charles"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_smallSemester)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 93)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(989, 74)
        Me.Panel5.TabIndex = 2
        '
        'lbl_smallSemester
        '
        Me.lbl_smallSemester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_smallSemester.BackColor = System.Drawing.Color.Transparent
        Me.lbl_smallSemester.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_smallSemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_smallSemester.Location = New System.Drawing.Point(0, 46)
        Me.lbl_smallSemester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_smallSemester.Name = "lbl_smallSemester"
        Me.lbl_smallSemester.Size = New System.Drawing.Size(989, 20)
        Me.lbl_smallSemester.TabIndex = 9
        Me.lbl_smallSemester.Text = "FIRST SEMESTER 2023-24"
        Me.lbl_smallSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(0, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(989, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Student Assessment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl_semester)
        Me.Panel6.Controls.Add(Me.lbl_program)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(989, 93)
        Me.Panel6.TabIndex = 1
        '
        'lbl_semester
        '
        Me.lbl_semester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_semester.BackColor = System.Drawing.Color.Transparent
        Me.lbl_semester.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_semester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_semester.Location = New System.Drawing.Point(0, 51)
        Me.lbl_semester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_semester.Name = "lbl_semester"
        Me.lbl_semester.Size = New System.Drawing.Size(989, 27)
        Me.lbl_semester.TabIndex = 13
        Me.lbl_semester.Text = "First Semester 2023-24"
        Me.lbl_semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_program
        '
        Me.lbl_program.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_program.BackColor = System.Drawing.Color.Transparent
        Me.lbl_program.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_program.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_program.Location = New System.Drawing.Point(0, 27)
        Me.lbl_program.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_program.Name = "lbl_program"
        Me.lbl_program.Size = New System.Drawing.Size(989, 20)
        Me.lbl_program.TabIndex = 12
        Me.lbl_program.Text = "Bachelor Of Science In Computer Science"
        Me.lbl_program.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_sAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 549)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_sAssessment"
        Me.Text = "frm_sAssessment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnl_Datagrid.ResumeLayout(False)
        CType(Me.dgv_assessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_smallSemester As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_accountNumber As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_dateTime As Label
    Friend WithEvents pnl_Datagrid As Panel
    Friend WithEvents dgv_assessment As DataGridView
    Friend WithEvents lbl_name As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_totalAssessment As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_program As Label
    Friend WithEvents lbl_semester As Label
End Class
