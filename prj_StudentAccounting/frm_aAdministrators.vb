Imports MySql.Data.MySqlClient

Public Class frm_aAdministrators

    Dim id As Integer

    Private Sub frm_aAdministrators_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcDisplayAllAdmin()
    End Sub

    Private Sub funcDisplayAllAdmin()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayAdmins"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_adminList.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_adminList.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id")
                        dgv_adminList.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("adminid").ToString
                        dgv_adminList.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_adminList.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_adminList.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btn_addAdmin_Click(sender As Object, e As EventArgs) Handles btn_addAdmin.Click

        If String.IsNullOrEmpty(txt_adminId.Text) OrElse
           String.IsNullOrEmpty(txtLastname.Text) OrElse
           String.IsNullOrEmpty(txtFirstname.Text) OrElse
           String.IsNullOrEmpty(txtMiddlename.Text) Then

            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_adminId.Text.Length <> 6 Then
            MessageBox.Show("Admin ID must contain 6 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                TabControl1.SelectedIndex = 0
                adminFunc("add")
                MessageBox.Show("Administrator Successfully Added", "Add Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtFirstname.Clear()
                txtLastname.Clear()
                txtMiddlename.Clear()


                funcDisplayAllAdmin()


            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminCreateAdmin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_adminId.Text)
                .ExecuteNonQuery()
            End With
            sqlDBAdapter.Dispose()
            dataTable.Dispose()
            txt_adminId.Clear()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub

    Private Sub adminFunc(type As String)

        If type = "edit" Or type = "delete" Then
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminAdministrator"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", type)
                .Parameters.AddWithValue("@p_adminid", txt_eAdminid.Text)
                .Parameters.AddWithValue("@p_last", txt_eLast.Text)
                .Parameters.AddWithValue("@p_first", txt_eFirst.Text)
                .Parameters.AddWithValue("@p_middle", txt_eMiddle.Text)
                .Parameters.AddWithValue("@p_id", id)
                .ExecuteNonQuery()

            End With
        ElseIf type = "add" Then

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminAdministrator"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", type)
                .Parameters.AddWithValue("@p_adminid", txt_adminId.Text)
                .Parameters.AddWithValue("@p_last", txtLastname.Text)
                .Parameters.AddWithValue("@p_first", txtFirstname.Text)
                .Parameters.AddWithValue("@p_middle", txtMiddlename.Text)
                .Parameters.AddWithValue("@p_id", id)

                .ExecuteNonQuery()

            End With
        End If
    End Sub

    Private Sub btn_cancelAdd_Click(sender As Object, e As EventArgs) Handles btn_cancelAdd.Click
        TabControl1.SelectedIndex = 0
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMiddlename.Clear()
        txt_adminId.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If String.IsNullOrEmpty(txt_eAdminid.Text) OrElse
           String.IsNullOrEmpty(txt_eLast.Text) OrElse
           String.IsNullOrEmpty(txt_eFirst.Text) OrElse
           String.IsNullOrEmpty(txt_eMiddle.Text) Then

            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txt_eAdminid.Text.Length <> 6 Then
            MessageBox.Show("Admin ID must contain 6 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                TabControl1.SelectedIndex = 0
                adminFunc("edit")
                MessageBox.Show("Administrator Info Updated", "Edit Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)

                funcDisplayAllAdmin()


            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TabControl1.SelectedIndex = 2
        id = CInt(dgv_adminList.CurrentRow.Cells(0).Value)
        txt_eAdminid.Text = dgv_adminList.CurrentRow.Cells(1).Value
        txt_eLast.Text = dgv_adminList.CurrentRow.Cells(2).Value
        txt_eFirst.Text = dgv_adminList.CurrentRow.Cells(3).Value
        txt_eMiddle.Text = dgv_adminList.CurrentRow.Cells(4).Value

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedIndex = 0
        Try
            adminFunc("delete")
            MessageBox.Show("Administrator Info Removed", "Remove Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            funcDisplayAllAdmin()

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
                .CommandText = "prcAdminSearchAdminList"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                .Parameters.AddWithValue("@p_type", "all")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_adminList.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_adminList.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_adminList.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("adminid").ToString
                        dgv_adminList.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_adminList.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_adminList.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
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
                .CommandText = "prcAdminSearchAdminList"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                .Parameters.AddWithValue("@p_type", "auto")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_adminList.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_adminList.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_adminList.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("adminid").ToString
                        dgv_adminList.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("lastname").ToString
                        dgv_adminList.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("firstname").ToString
                        dgv_adminList.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("middlename").ToString
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
        funcDisplayAllAdmin()
    End Sub
End Class