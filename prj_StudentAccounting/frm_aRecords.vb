Imports MySql.Data.MySqlClient
Public Class frm_aRecords
    Private Sub frm_aRecords_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcDisplayAllStudents()

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
                    dgv_studentList.RowCount = dataTable.Rows.Count + 1
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_studentList.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_studentList.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("lastname").ToString & ", " & dataTable.Rows(row).Item("firstname").ToString & " " & (dataTable.Rows(row).Item("middlename").ToString).Substring(0, 1) & "."
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
End Class