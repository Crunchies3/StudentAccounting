Imports MySql.Data.MySqlClient
Public Class frm_sSubjects
    Private Sub frm_sSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        prcDisplaySubject()

    End Sub

    Private Sub prcDisplaySubject()

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

                dgv_subjects.RowCount = dataTable.Rows.Count
                row = 0

                While Not dataTable.Rows.Count - 1 < row
                    dgv_subjects.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                    dgv_subjects.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                    dgv_subjects.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                    dgv_subjects.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                    dgv_subjects.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("semester").ToString
                    row = row + 1
                End While


            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class