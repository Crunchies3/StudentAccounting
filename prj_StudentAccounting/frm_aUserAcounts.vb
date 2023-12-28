Imports MySql.Data.MySqlClient

Public Class frm_aUserAcounts

    Dim who As String = ""
    Private Sub frm_aUserAcounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        funcDisplayAllStudentsAccount()
        funcDisplayAllAdminAccount()
    End Sub

    Private Sub funcDisplayAllStudentsAccount()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminUserAccounts"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", "student")
                .Parameters.AddWithValue("@p_who", "")
                .Parameters.AddWithValue("@p_id", "")
                .Parameters.AddWithValue("@p_pass", "")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_studentAccount.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_studentAccount.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id")
                        dgv_studentAccount.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
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

    Private Sub funcDisplayAllAdminAccount()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminUserAccounts"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", "admin")
                .Parameters.AddWithValue("@p_who", "")
                .Parameters.AddWithValue("@p_id", "")
                .Parameters.AddWithValue("@p_pass", "")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_adminAccount.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_adminAccount.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id")
                        dgv_adminAccount.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("adminid").ToString
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

    Private Sub btn_changePass_student_Click(sender As Object, e As EventArgs) Handles btn_changePass_student.Click
        TabControl1.SelectedIndex = 1
        txt_id.Text = dgv_studentAccount.CurrentRow.Cells(1).Value
        who = "student"

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_id.Clear()
        txt_newPass.Clear()
        txt_confPass.Clear()
        TabControl1.SelectedIndex = 0

    End Sub

    Private Sub btn_saveEdit_Click(sender As Object, e As EventArgs) Handles btn_saveEdit.Click

        If String.IsNullOrEmpty(txt_id.Text) OrElse String.IsNullOrEmpty(txt_newPass.Text) OrElse String.IsNullOrEmpty(txt_confPass.Text) Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_newPass.Text.Length < 6 Then
            MessageBox.Show("Password must contain 6 or more characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_newPass.Text <> txt_confPass.Text Then
            MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                sqlDBAdapter = New MySqlDataAdapter
                dataTable = New DataTable
                With command
                    .Parameters.Clear()
                    .CommandText = "prcAdminUserAccounts"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_type", "change")
                    .Parameters.AddWithValue("@p_who", who)
                    .Parameters.AddWithValue("@p_id", txt_id.Text)
                    .Parameters.AddWithValue("@p_pass", txt_newPass.Text)
                    .ExecuteNonQuery()
                End With
                sqlDBAdapter.Dispose()
                dataTable.Dispose()
                txt_id.Clear()
                txt_newPass.Clear()
                txt_confPass.Clear()
                MessageBox.Show("Password Updated", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TabControl1.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btn_changepass_admin_Click(sender As Object, e As EventArgs) Handles btn_changepass_admin.Click
        TabControl1.SelectedIndex = 1
        txt_id.Text = dgv_adminAccount.CurrentRow.Cells(1).Value
        who = "admin"
    End Sub
End Class