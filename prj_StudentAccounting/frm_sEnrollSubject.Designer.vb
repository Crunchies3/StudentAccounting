<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sEnrollSubject
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.chk_autocomplete = New System.Windows.Forms.CheckBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_enlist = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnl_Datagrid = New System.Windows.Forms.Panel()
        Me.dgv_enrollSubject = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lvl_studentType = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_programYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_accountNumber = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pnl_Datagrid.SuspendLayout()
        CType(Me.dgv_enrollSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
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
        Me.Panel3.Size = New System.Drawing.Size(27, 643)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1016, 44)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(36, 643)
        Me.Panel4.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(27, 44)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 643)
        Me.Panel2.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.btnAll)
        Me.Panel8.Controls.Add(Me.chk_autocomplete)
        Me.Panel8.Controls.Add(Me.btn_search)
        Me.Panel8.Controls.Add(Me.txt_search)
        Me.Panel8.Controls.Add(Me.btn_enlist)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.pnl_Datagrid)
        Me.Panel8.Location = New System.Drawing.Point(0, 189)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(989, 454)
        Me.Panel8.TabIndex = 3
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.Location = New System.Drawing.Point(382, 47)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(81, 22)
        Me.btnAll.TabIndex = 12
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'chk_autocomplete
        '
        Me.chk_autocomplete.AutoSize = True
        Me.chk_autocomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_autocomplete.Location = New System.Drawing.Point(140, 76)
        Me.chk_autocomplete.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_autocomplete.Name = "chk_autocomplete"
        Me.chk_autocomplete.Size = New System.Drawing.Size(92, 17)
        Me.chk_autocomplete.TabIndex = 11
        Me.chk_autocomplete.Text = "Auto Complete"
        Me.chk_autocomplete.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(297, 48)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(81, 22)
        Me.btn_search.TabIndex = 10
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search.Location = New System.Drawing.Point(140, 50)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(153, 20)
        Me.txt_search.TabIndex = 9
        '
        'btn_enlist
        '
        Me.btn_enlist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_enlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_enlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enlist.ForeColor = System.Drawing.Color.White
        Me.btn_enlist.Location = New System.Drawing.Point(140, 386)
        Me.btn_enlist.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_enlist.Name = "btn_enlist"
        Me.btn_enlist.Size = New System.Drawing.Size(81, 31)
        Me.btn_enlist.TabIndex = 8
        Me.btn_enlist.Text = "Enlist"
        Me.btn_enlist.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(139, 6)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(413, 25)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Showing List of Subject Allowed for Enrollment"
        '
        'pnl_Datagrid
        '
        Me.pnl_Datagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Datagrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnl_Datagrid.Controls.Add(Me.dgv_enrollSubject)
        Me.pnl_Datagrid.Location = New System.Drawing.Point(140, 104)
        Me.pnl_Datagrid.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_Datagrid.Name = "pnl_Datagrid"
        Me.pnl_Datagrid.Padding = New System.Windows.Forms.Padding(1)
        Me.pnl_Datagrid.Size = New System.Drawing.Size(725, 271)
        Me.pnl_Datagrid.TabIndex = 6
        '
        'dgv_enrollSubject
        '
        Me.dgv_enrollSubject.AllowUserToAddRows = False
        Me.dgv_enrollSubject.AllowUserToResizeColumns = False
        Me.dgv_enrollSubject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_enrollSubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_enrollSubject.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_enrollSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_enrollSubject.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_enrollSubject.ColumnHeadersHeight = 35
        Me.dgv_enrollSubject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_enrollSubject.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_enrollSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_enrollSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_enrollSubject.Location = New System.Drawing.Point(1, 1)
        Me.dgv_enrollSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_enrollSubject.Name = "dgv_enrollSubject"
        Me.dgv_enrollSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_enrollSubject.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_enrollSubject.RowHeadersWidth = 51
        Me.dgv_enrollSubject.RowTemplate.Height = 35
        Me.dgv_enrollSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_enrollSubject.Size = New System.Drawing.Size(723, 269)
        Me.dgv_enrollSubject.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 60
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Title"
        Me.Column2.MinimumWidth = 100
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.MinimumWidth = 200
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Units"
        Me.Column4.MinimumWidth = 50
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Program"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "Level"
        Me.Column6.MinimumWidth = 100
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 99)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(989, 90)
        Me.Panel7.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lvl_studentType)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Location = New System.Drawing.Point(140, 38)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(725, 32)
        Me.Panel9.TabIndex = 0
        '
        'lvl_studentType
        '
        Me.lvl_studentType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lvl_studentType.Location = New System.Drawing.Point(454, 8)
        Me.lvl_studentType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvl_studentType.Name = "lvl_studentType"
        Me.lvl_studentType.Size = New System.Drawing.Size(149, 16)
        Me.lvl_studentType.TabIndex = 0
        Me.lvl_studentType.Text = "Old Student"
        Me.lvl_studentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Type"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_programYear)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(140, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(725, 32)
        Me.Panel5.TabIndex = 0
        '
        'lbl_programYear
        '
        Me.lbl_programYear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_programYear.Location = New System.Drawing.Point(451, 8)
        Me.lbl_programYear.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_programYear.Name = "lbl_programYear"
        Me.lbl_programYear.Size = New System.Drawing.Size(130, 16)
        Me.lbl_programYear.TabIndex = 0
        Me.lbl_programYear.Text = "3rd Year"
        Me.lbl_programYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Program"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl_name)
        Me.Panel6.Controls.Add(Me.lbl_accountNumber)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(989, 99)
        Me.Panel6.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lbl_name.Location = New System.Drawing.Point(138, 54)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(537, 37)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Alvez, Cyril Charles"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_accountNumber
        '
        Me.lbl_accountNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_accountNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lbl_accountNumber.Location = New System.Drawing.Point(140, 28)
        Me.lbl_accountNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_accountNumber.Name = "lbl_accountNumber"
        Me.lbl_accountNumber.Size = New System.Drawing.Size(125, 25)
        Me.lbl_accountNumber.TabIndex = 0
        Me.lbl_accountNumber.Text = "134563"
        Me.lbl_accountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_sEnrollSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1052, 687)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_sEnrollSubject"
        Me.Text = "frm_sEnrollSubject"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.pnl_Datagrid.ResumeLayout(False)
        CType(Me.dgv_enrollSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents pnl_Datagrid As Panel
    Friend WithEvents dgv_enrollSubject As DataGridView
    Friend WithEvents lbl_accountNumber As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lvl_studentType As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_programYear As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_enlist As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents chk_autocomplete As CheckBox
    Friend WithEvents btnAll As Button
End Class
