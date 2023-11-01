Imports MySql.Data.MySqlClient
Public Class frm_aFees

    Dim id As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 2
        id = CInt(dgv_Fees.CurrentRow.Cells(0).Value)
        txt_editDescription.Text = dgv_Fees.CurrentRow.Cells(1).Value
        txt_editAmount.Text = dgv_Fees.CurrentRow.Cells(2).Value
    End Sub

    Private Sub FeesFunc(type As String)

        If type = "edit" Or type = "delete" Then
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminFees"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_description", txt_editDescription.Text)
                .Parameters.AddWithValue("@p_amount", txt_editAmount.Text)
                .Parameters.AddWithValue("@p_type", type)
                .ExecuteNonQuery()

            End With

        ElseIf type = "add" Then

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminFees"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_description", txt_description.Text)
                .Parameters.AddWithValue("@p_amount", txt_amount.Text)
                .Parameters.AddWithValue("@p_type", type)
                .ExecuteNonQuery()

            End With
        End If



    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddFees.Click

        If String.IsNullOrEmpty(txt_description.Text) OrElse
           String.IsNullOrEmpty(txt_amount.Text) Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TabControl1.SelectedIndex = 0
            Try
                FeesFunc("add")
                MessageBox.Show("Fee Added", "Add Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_amount.Clear()
                txt_description.Clear()

                DisplayFees()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If String.IsNullOrEmpty(txt_editDescription.Text) OrElse
           String.IsNullOrEmpty(txt_editAmount.Text) Then
            MessageBox.Show("Please fill in all required fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TabControl1.SelectedIndex = 0
            Try
                FeesFunc("edit")
                MessageBox.Show("Fee Edited", "Edit Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_amount.Clear()
                txt_description.Clear()

                DisplayFees()

            Catch ex As Exception
                MessageBox.Show("" & ex.Message)
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub frm_aFees_Load(sender As Object, e As EventArgs) Handles Me.Load

        checkDatabaseConnection()
        DisplayFees()

    End Sub

    Private Sub DisplayFees()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayFees"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If Not dataTable.Rows.Count = 0 Then
                    dgv_Fees.RowCount = dataTable.Rows.Count
                    row = 0

                    While Not dataTable.Rows.Count - 1 < row
                        dgv_Fees.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id")
                        dgv_Fees.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_Fees.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("amount").ToString
                        row = row + 1
                    End While
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
                .CommandText = "prcAdminSearchFees"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_description", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_Fees.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_Fees.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_Fees.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_Fees.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("amount").ToString
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

    Private Sub FeesSearchAutoComplete()
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchFeesAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_description", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_Fees.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_Fees.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_Fees.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_Fees.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("amount").ToString
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
            FeesSearchAutoComplete()
        Else

        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DisplayFees()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        TabControl1.SelectedIndex = 0
        Try

            FeesFunc("delete")
            MessageBox.Show("Fee  Removed", "Remove Fee", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DisplayFees()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class