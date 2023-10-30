Imports MySql.Data.MySqlClient
Public Class frm_sSubjects
    Private Sub frm_sSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        prcDisplaySubject()

    End Sub

    Public Sub prcDisplaySubject()

        'Diria ibutang ang code para i display ang subject na gi enroll sa isa ka student
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDsiplaySubjectCurrentlyEnrolled"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If Not dataTable.Rows.Count = 0 Then
                    dgv_subjects.RowCount = dataTable.Rows.Count
                    row = 0

                    While Not dataTable.Rows.Count - 1 < row
                        dgv_subjects.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_subjects.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_subjects.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_subjects.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_subjects.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("semester").ToString
                        dgv_subjects.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("status").ToString
                        row = row + 1
                    End While
                End If

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcStudentSubmitFinalSubjects"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_sid", CInt(dgv_subjects.CurrentRow.Cells(0).Value))
                .Parameters.AddWithValue("@p_stid", userID)
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Subject Submitted As Final", "Subject Finalized", MessageBoxButtons.OK, MessageBoxIcon.Information)
            prcDisplaySubject()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim status As String = dgv_subjects.CurrentRow.Cells(5).Value

        Try
            If status <> "final" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcStudentRemoveEnlistedTempSubject"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_sid", CInt(dgv_subjects.CurrentRow.Cells(0).Value))
                    .Parameters.AddWithValue("@p_stid", userID)
                    .Parameters.AddWithValue("@p_status", status)
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Subject Removed", "Remove Temporary Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Subject is Final and can't be removed", "Can't Remove Subject", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            prcDisplaySubject()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
            End Try


    End Sub
End Class