Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frm_sEnrollSubject
    Dim id As integer
    Dim sid As Integer

    Private Sub frm_sEnrollSubject_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcLoadLabels()
        funcDisplaySubject()
    End Sub

    Private Sub funcLoadLabels()
        lbl_accountNumber.Text = userID
        lbl_name.Text = studentName
        If studentProgram Then
    End Sub

    Private Sub funcDisplaySubject()
        'diria ibutang ang code para i display ang mga available subjects. dapat ang ipakita lang na subject is ka level. example 3rd year student
        'dapat pang 3rd year rapud na subject ang i display

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplaySubjectByYearLevel"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studentid", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrollSubject.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrollSubject.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrollSubject.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_enrollSubject.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_enrollSubject.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_enrollSubject.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrollSubject.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("level").ToString
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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchSubject"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_title", txt_search.Text)
                .Parameters.AddWithValue("@p_studentid", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrollSubject.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrollSubject.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrollSubject.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_enrollSubject.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_enrollSubject.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_enrollSubject.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrollSubject.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("level").ToString
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

    Private Sub searchStudentAutoComplete()
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcSearchSubjectAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_title", txt_search.Text)
                .Parameters.AddWithValue("@p_studentid", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrollSubject.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrollSubject.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrollSubject.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_enrollSubject.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_enrollSubject.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_enrollSubject.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrollSubject.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("level").ToString
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
            searchStudentAutoComplete()
        Else

        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        funcDisplaySubject()
    End Sub

    Private Sub getStudentIdAndSid()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prcStudentSubjIdAndSid"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studentid", userID)
                .Parameters.AddWithValue("@p_title", dgv_enrollSubject.CurrentRow.Cells(1).Value)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    row = 0
                    id = CInt(dataTable.Rows(row).Item("id").ToString)
                    sid = CInt(dataTable.Rows(row).Item("bid").ToString)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub btn_enlist_Click(sender As Object, e As EventArgs) Handles btn_enlist.Click
        getStudentIdAndSid()
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcStudentEnlistSubject"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_stid", id)
                .Parameters.AddWithValue("@p_sid", sid)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Subject Enlisted", "Enlist Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        funcDisplaySubject()
    End Sub

End Class