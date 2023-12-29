Imports MySql.Data.MySqlClient

Public Class frm_aTeacher
    Dim Tid As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnEditTeacher.Click
        TabControl1.SelectedIndex = 2
        EtxtTfirstname.Clear()

        Tid = CInt(dgv_teacherTable.CurrentRow.Cells(0).Value)
        EtxtTeacherID.Text = dgv_teacherTable.CurrentRow.Cells(1).Value

        'Splitting fullname to lastname, firstname, middleInitial'
        Dim fullname As String = dgv_teacherTable.CurrentRow.Cells(2).Value
        Dim nameParts() As String = fullname.Split(","c)
        EtxtTlastname.Text = nameParts(0).Trim()
        Dim firstAndMiddleName As String = nameParts(1).Trim()
        Dim firstAndMiddleNameParts() As String = firstAndMiddleName.Split(" "c)
        For i As Integer = 0 To firstAndMiddleNameParts.Length - 1
            If firstAndMiddleNameParts(i).Length = 1 Then
                EtxtTmiddlename.Text = firstAndMiddleNameParts(i).Trim()
            Else
                EtxtTfirstname.Text &= firstAndMiddleNameParts(i).Trim() & " "
            End If
        Next
        EtxtTfirstname.Text = EtxtTfirstname.Text.Trim()
        '---------------------------------------------------------'

        EdtTbirthdate.Value = Format(Convert.ToDateTime(dgv_teacherTable.CurrentRow.Cells(3).Value), "yyyy,MMM,dd")
        EcmbTgender.Text = dgv_teacherTable.CurrentRow.Cells(4).Value
        EtxtTmobileno.Text = dgv_teacherTable.CurrentRow.Cells(5).Value
        EtxtTemailadd.Text = dgv_teacherTable.CurrentRow.Cells(6).Value
        EtxtTaddress.Text = dgv_teacherTable.CurrentRow.Cells(7).Value
        teacherPhotoPath = dgv_teacherTable.CurrentRow.Cells(8).Value



    End Sub
    Private Sub teacherFunc(type As String)

        If type = "edit" Or type = "delete" Then
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminTeacher"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", Tid)
                .Parameters.AddWithValue("@p_teacherid", EtxtTeacherID.Text)
                .Parameters.AddWithValue("@p_fullname", EtxtTlastname.Text & ", " & EtxtTfirstname.Text & " " & If(EtxtTmiddlename.Text.Length > 0, EtxtTmiddlename.Text.Substring(0, 1), ""))
                .Parameters.AddWithValue("@p_gender", EcmbTgender.Text)
                .Parameters.AddWithValue("@p_birthdate", EdtTbirthdate.Value)
                .Parameters.AddWithValue("@p_mobileno", EtxtTmobileno.Text)
                .Parameters.AddWithValue("@p_emailadd", EtxtTemailadd.Text)
                .Parameters.AddWithValue("@p_address", EtxtTaddress.Text)
                .Parameters.AddWithValue("@p_photoPath", teacherPhotoPath)
                .Parameters.AddWithValue("@p_type", type)
                .ExecuteNonQuery()

            End With

        ElseIf type = "add" Then

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminTeacher"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", Tid)
                .Parameters.AddWithValue("@p_teacherid", txtTeacherID.Text)
                .Parameters.AddWithValue("@p_fullname", txtTlastname.Text & ", " & txtTfirstname.Text & " " & If(txtTmiddlename.Text.Length > 0, txtTmiddlename.Text.Substring(0, 1), ""))
                .Parameters.AddWithValue("@p_gender", cmbTgender.Text)
                .Parameters.AddWithValue("@p_birthdate", dtTbirthdate.Value)
                .Parameters.AddWithValue("@p_mobileno", txtTmobileno.Text)
                .Parameters.AddWithValue("@p_emailadd", txtTemailadd.Text)
                .Parameters.AddWithValue("@p_address", txtTaddress.Text)
                .Parameters.AddWithValue("@p_photoPath", teacherPhotoPath)
                .Parameters.AddWithValue("@p_type", type)
                .ExecuteNonQuery()

            End With
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddTeacher.Click

        If String.IsNullOrEmpty(txtTeacherID.Text) OrElse
          String.IsNullOrEmpty(txtTlastname.Text) OrElse
          String.IsNullOrEmpty(txtTfirstname.Text) OrElse
          String.IsNullOrEmpty(txtTmobileno.Text) OrElse
          String.IsNullOrEmpty(txtTaddress.Text) OrElse
          String.IsNullOrEmpty(txtTemailadd.Text) OrElse
           cmbTgender.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TabControl1.SelectedIndex = 0
            Try
                teacherFunc("add")
                MessageBox.Show("Teacher Successfully Added", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtTeacherID.Clear()
                txtTlastname.Clear()
                txtTfirstname.Clear()
                txtTmiddlename.Clear()
                txtTmobileno.Clear()
                txtTemailadd.Clear()
                txtTaddress.Clear()
                dtTbirthdate.Value = Now()
                cmbTgender.SelectedIndex = -1


                funcDisplayAllTeachers()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSaveEditTeacher.Click

        If String.IsNullOrEmpty(EtxtTeacherID.Text) OrElse
          String.IsNullOrEmpty(EtxtTlastname.Text) OrElse
          String.IsNullOrEmpty(EtxtTfirstname.Text) OrElse
          String.IsNullOrEmpty(EtxtTmobileno.Text) OrElse
          String.IsNullOrEmpty(EtxtTaddress.Text) OrElse
          String.IsNullOrEmpty(EtxtTemailadd.Text) OrElse
           EcmbTgender.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TabControl1.SelectedIndex = 0
            Try
                teacherFunc("edit")
                MessageBox.Show("Teacher Details Successfully Edited", "Edit Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information)

                EtxtTeacherID.Clear()
                EtxtTlastname.Clear()
                EtxtTfirstname.Clear()
                EtxtTmiddlename.Clear()
                EtxtTmobileno.Clear()
                EtxtTemailadd.Clear()
                EtxtTaddress.Clear()
                EdtTbirthdate.Value = Now()
                EcmbTgender.SelectedIndex = -1


                funcDisplayAllTeachers()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub funcDisplayAllTeachers()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayTeachers"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_teacherTable.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_teacherTable.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id")
                        dgv_teacherTable.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("teacherid").ToString
                        dgv_teacherTable.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_teacherTable.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(dataTable.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        dgv_teacherTable.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_teacherTable.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("mobileno").ToString
                        dgv_teacherTable.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("emailadd").ToString
                        dgv_teacherTable.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("address").ToString
                        dgv_teacherTable.Rows(row).Cells(8).Value = teacherPhotoPath
                        row = row + 1
                    End While
                End If

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
                .CommandText = "prcAdminSearchTeacherAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_teacherTable.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_teacherTable.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_teacherTable.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("teacherid").ToString
                        dgv_teacherTable.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_teacherTable.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(dataTable.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        dgv_teacherTable.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_teacherTable.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("mobileno").ToString
                        dgv_teacherTable.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("emailadd").ToString
                        dgv_teacherTable.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("address").ToString
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
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchTeacher"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_teacherTable.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_teacherTable.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_teacherTable.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("teacherid").ToString
                        dgv_teacherTable.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_teacherTable.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(dataTable.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        dgv_teacherTable.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_teacherTable.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("mobileno").ToString
                        dgv_teacherTable.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("emailadd").ToString
                        dgv_teacherTable.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("address").ToString
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

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If chk_autocomplete.Checked = True Then
            searchAutoComplete()
        Else

        End If
    End Sub

    Private Sub frm_aTeacher_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcDisplayAllTeachers()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        funcDisplayAllTeachers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            With OpenFileDialog1
                .Title = "Select Teacher Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    PictureBox1.Image = Image.FromFile(.FileName)
                    teacherPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            With OpenFileDialog1
                .Title = "Select Teacher Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    PictureBox2.Image = Image.FromFile(.FileName)
                    teacherPhotoPath = .FileName
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        TabControl1.SelectedIndex = 0
        Try

            teacherFunc("delete")
            MessageBox.Show("Teacher  Removed", "Remove Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information)

            funcDisplayAllTeachers()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class