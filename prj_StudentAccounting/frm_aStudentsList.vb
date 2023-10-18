﻿Imports MySql.Data.MySqlClient

Public Class frm_aStudentsList
    Dim id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 2

        id = CInt(dgv_TotalStudents.CurrentRow.Cells(0).Value)
        txtEstudentID.Text = dgv_TotalStudents.CurrentRow.Cells(1).Value
        txtElastname.Text = dgv_TotalStudents.CurrentRow.Cells(2).Value
        txtEfirstname.Text = dgv_TotalStudents.CurrentRow.Cells(3).Value
        txtEmiddlename.Text = dgv_TotalStudents.CurrentRow.Cells(4).Value
        cmbEgender.Text = dgv_TotalStudents.CurrentRow.Cells(5).Value
        cmbEprogram.Text = dgv_TotalStudents.CurrentRow.Cells(6).Value
        cmbEyearlevel.Text = dgv_TotalStudents.CurrentRow.Cells(7).Value
        dtEbirthdate.Value = Format(Convert.ToDateTime(dgv_TotalStudents.CurrentRow.Cells(8).Value), "yyyy,MMM,dd")
        txtEmobileno.Text = dgv_TotalStudents.CurrentRow.Cells(9).Value
        txtEemailadd.Text = dgv_TotalStudents.CurrentRow.Cells(10).Value
        txtEaddress.Text = dgv_TotalStudents.CurrentRow.Cells(11).Value

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        TabControl1.SelectedIndex = 0

        Dim yrno As Integer
        If cmbYearlevel.Text = "1st Year" Then
            yrno = 1
        ElseIf cmbYearlevel.Text = "2nd Year" Then
            yrno = 2
        ElseIf cmbYearlevel.Text = "3rd Year" Then
            yrno = 3
        ElseIf cmbYearlevel.Text = "4th Year" Then
            yrno = 4
        End If

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminAddStudent"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studentid", txtStudentID.Text)
                .Parameters.AddWithValue("@p_lastname", txtLastname.Text)
                .Parameters.AddWithValue("@p_firstname", txtFirstname.Text)
                .Parameters.AddWithValue("@p_middlename", txtMiddlename.Text)
                .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                .Parameters.AddWithValue("@p_birthdate", dtBirthdate.Value)
                .Parameters.AddWithValue("@p_mobileno", txtMobileno.Text)
                .Parameters.AddWithValue("@p_emailadd", txtEmailadd.Text)
                .Parameters.AddWithValue("@p_address", txtAddress.Text)
                .Parameters.AddWithValue("@p_yearlevel", yrno)
                .Parameters.AddWithValue("@p_program", cmbProgram.Text)
                .Parameters.AddWithValue("@p_photoPath", studentPhotoPath)
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Student Successfully Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtStudentID.Clear()
            txtLastname.Clear()
            txtFirstname.Clear()
            txtMiddlename.Clear()
            txtMobileno.Clear()
            txtEmailadd.Clear()
            txtAddress.Clear()
            dtBirthdate.Value = Now()
            cmbGender.SelectedIndex = -1
            cmbProgram.SelectedIndex = -1
            cmbYearlevel.SelectedIndex = -1

            funcDisplayAllStudents()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        TabControl1.SelectedIndex = 0

        Dim yrno As Integer
        If cmbEyearlevel.Text = "1st Year" Then
            yrno = 1
        ElseIf cmbEyearlevel.Text = "2nd Year" Then
            yrno = 2
        ElseIf cmbEyearlevel.Text = "3rd Year" Then
            yrno = 3
        ElseIf cmbEyearlevel.Text = "4th Year" Then
            yrno = 4
        Else
            yrno = CInt(cmbEyearlevel.Text)
        End If

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminEditStudent"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_studentid", txtEstudentID.Text)
                .Parameters.AddWithValue("@p_lastname", txtElastname.Text)
                .Parameters.AddWithValue("@p_firstname", txtEfirstname.Text)
                .Parameters.AddWithValue("@p_middlename", txtEmiddlename.Text)
                .Parameters.AddWithValue("@p_gender", cmbEgender.Text)
                .Parameters.AddWithValue("@p_birthdate", dtEbirthdate.Value)
                .Parameters.AddWithValue("@p_mobileno", txtEmobileno.Text)
                .Parameters.AddWithValue("@p_emailadd", txtEemailadd.Text)
                .Parameters.AddWithValue("@p_address", txtEaddress.Text)
                .Parameters.AddWithValue("@p_yearlevel", yrno)
                .Parameters.AddWithValue("@p_program", cmbEprogram.Text)
                .Parameters.AddWithValue("@p_photoPath", studentPhotoPath)
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Student Info Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            funcDisplayAllStudents()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TabControl1.SelectedIndex = 0
        PictureBox2.Image = Nothing
    End Sub

    Private Sub funcDisplayAllStudents()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayStudents"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_TotalStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_TotalStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_TotalStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_TotalStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_TotalStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_TotalStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
                        dgv_TotalStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_TotalStudents.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_TotalStudents.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        dgv_TotalStudents.Rows(row).Cells(8).Value = Format(Convert.ToDateTime(dataTable.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        dgv_TotalStudents.Rows(row).Cells(9).Value = dataTable.Rows(row).Item("mobileno").ToString
                        dgv_TotalStudents.Rows(row).Cells(10).Value = dataTable.Rows(row).Item("emailadd").ToString
                        dgv_TotalStudents.Rows(row).Cells(11).Value = dataTable.Rows(row).Item("address").ToString
                        dgv_TotalStudents.Rows(row).Cells(12).Value = dataTable.Rows(row).Item("photoPath").ToString
                        row = row + 1
                    End While
                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frm_aStudentsList_Load(sender As Object, e As EventArgs) Handles Me.Load
        funcDisplayAllStudents()
        checkDatabaseConnection()
    End Sub

    Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click
        Try
            With OpenFileDialog1
                .Title = "Select Student Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    PictureBox1.Image = Image.FromFile(.FileName)
                    studentPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnBrowsePic2_Click(sender As Object, e As EventArgs) Handles btnBrowsePic2.Click
        Try
            With OpenFileDialog1
                .Title = "Select Student Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    PictureBox2.Image = Image.FromFile(.FileName)
                    studentPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchStudent"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_lastname", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_TotalStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_TotalStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_TotalStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_TotalStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_TotalStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_TotalStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
                        dgv_TotalStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_TotalStudents.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_TotalStudents.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        row = row + 1
                    End While
                Else
                    txt_search.Clear()
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                txt_search.Clear()
            End With
            sqlDBAdapter.Dispose()
            dataTable.Dispose()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub searchAutoComplete()
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchStudentAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_lastname", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_TotalStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_TotalStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_TotalStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_TotalStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_TotalStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_TotalStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
                        dgv_TotalStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_TotalStudents.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_TotalStudents.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        row = row + 1
                    End While
                Else
                    txt_search.Clear()
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End With
            sqlDBAdapter.Dispose()
            dataTable.Dispose()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If chk_autocomplete.Checked = True Then
            searchAutoComplete()
        Else

        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        funcDisplayAllStudents()
    End Sub
End Class