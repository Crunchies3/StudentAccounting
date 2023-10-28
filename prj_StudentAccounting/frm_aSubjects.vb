Imports MySql.Data.MySqlClient
Public Class frm_aSubjects
    Dim id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 2
        id = CInt(dgv_subjects.CurrentRow.Cells(0).Value)
        txt_eCode.Text = dgv_subjects.CurrentRow.Cells(1).Value
        txt_eTitle.Text = dgv_subjects.CurrentRow.Cells(2).Value
        txt_eDesc.Text = dgv_subjects.CurrentRow.Cells(3).Value
        txt_eUnit.Text = dgv_subjects.CurrentRow.Cells(4).Value
        cmb_eLevel.Text = dgv_subjects.CurrentRow.Cells(5).Value
        cmb_eProgram.Text = dgv_subjects.CurrentRow.Cells(6).Value
        cmb_eSem.Text = dgv_subjects.CurrentRow.Cells(7).Value

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btn_addSub.Click

        If String.IsNullOrEmpty(txt_code.Text) OrElse
           String.IsNullOrEmpty(txt_title.Text) OrElse
           String.IsNullOrEmpty(txt_desc.Text) OrElse
           String.IsNullOrEmpty(txt_unit.Text) OrElse
            cmb_lvl.SelectedIndex = -1 OrElse
            cmb_program.SelectedIndex = -1 OrElse
            cmb_sem.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_code.Text.Length <> 4 Then
            MessageBox.Show("Code must contain 4 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            TabControl1.SelectedIndex = 0

            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAdminAddSubject"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_code", txt_code.Text)
                    .Parameters.AddWithValue("@p_title", txt_title.Text)
                    .Parameters.AddWithValue("@p_description", txt_desc.Text)
                    .Parameters.AddWithValue("@p_units", txt_unit.Text)
                    .Parameters.AddWithValue("@p_level", cmb_lvl.Text)
                    .Parameters.AddWithValue("@p_program", cmb_program.Text)
                    .Parameters.AddWithValue("@p_semester", cmb_sem.Text)
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Subject Added", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_code.Clear()
                txt_title.Clear()
                txt_desc.Clear()
                txt_unit.Clear()
                cmb_lvl.SelectedIndex = -1
                cmb_program.SelectedIndex = -1
                cmb_sem.SelectedIndex = -1


                DisplaySubject()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_cancelAdd.Click
        TabControl1.SelectedIndex = 0
        txt_code.Clear()
        txt_title.Clear()
        txt_desc.Clear()
        txt_unit.Clear()
        cmb_lvl.SelectedIndex = -1
        cmb_program.SelectedIndex = -1
        cmb_sem.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_saveEdit.Click

        If String.IsNullOrEmpty(txt_eCode.Text) OrElse
           String.IsNullOrEmpty(txt_eTitle.Text) OrElse
           String.IsNullOrEmpty(txt_eDesc.Text) OrElse
           String.IsNullOrEmpty(txt_eUnit.Text) OrElse
            cmb_eLevel.SelectedIndex = -1 OrElse
            cmb_eProgram.SelectedIndex = -1 OrElse
            cmb_eSem.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_ecode.Text.Length <> 4 Then
            MessageBox.Show("Code must contain 4 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            TabControl1.SelectedIndex = 0

            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAdminEditSubject"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", id)
                    .Parameters.AddWithValue("@p_code", txt_eCode.Text)
                    .Parameters.AddWithValue("@p_title", txt_eTitle.Text)
                    .Parameters.AddWithValue("@p_description", txt_eDesc.Text)
                    .Parameters.AddWithValue("@p_units", txt_eUnit.Text)
                    .Parameters.AddWithValue("@p_level", cmb_eLevel.Text)
                    .Parameters.AddWithValue("@p_program", cmb_eProgram.Text)
                    .Parameters.AddWithValue("@p_semester", cmb_eSem.Text)
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Subject Info saved", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_eCode.Clear()
                txt_eTitle.Clear()
                txt_eDesc.Clear()
                txt_eUnit.Clear()
                cmb_eLevel.SelectedIndex = -1
                cmb_eProgram.SelectedIndex = -1
                cmb_eSem.SelectedIndex = -1


                DisplaySubject()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancelEdit.Click
        TabControl1.SelectedIndex = 0
        txt_eCode.Clear()
        txt_eTitle.Clear()
        txt_eDesc.Clear()
        txt_eUnit.Clear()
        cmb_eLevel.SelectedIndex = -1
        cmb_eProgram.SelectedIndex = -1
        cmb_eSem.SelectedIndex = -1
    End Sub

    Private Sub frm_aSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        DisplaySubject()
    End Sub

    Private Sub DisplaySubject()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplaySubjects"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If Not dataTable.Rows.Count = 0 Then
                    dgv_subjects.RowCount = dataTable.Rows.Count + 1
                    row = 0

                    While Not dataTable.Rows.Count - 1 < row
                        dgv_subjects.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_subjects.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("code").ToString
                        dgv_subjects.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_subjects.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_subjects.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_subjects.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("level").ToString
                        dgv_subjects.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_subjects.Rows(row).Cells(7).Value = dataTable.Rows(row).Item("semester").ToString
                        row = row + 1
                    End While
                End If

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class