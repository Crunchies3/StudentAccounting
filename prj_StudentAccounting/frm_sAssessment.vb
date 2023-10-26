Imports MySql.Data.MySqlClient
Public Class frm_sAssessment
    Private Sub frm_sAssessment_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLabel()
        displayTable()

    End Sub

    Private Sub loadLabel()
        lbl_accountNumber.Text = "Account No.: " & userID
        lbl_name.Text = "Name: " & studentName
        lbl_dateTime.Text = Date.Now
    End Sub

    Private Sub displayTable()

        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prcDisplayStudentAssessment"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", studID)
            sqlDBAdapter.SelectCommand = command
            dataTable.Clear()
            sqlDBAdapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                dgv_assessment.RowCount = dataTable.Rows.Count
                row = 0
                While Not dataTable.Rows.Count - 1 < row
                    dgv_assessment.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("referenceno").ToString
                    dgv_assessment.Rows(row).Cells(1).Value = "#" & dataTable.Rows(row).Item("description").ToString
                    dgv_assessment.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("amount").ToString
                    row = row + 1
                End While
            End If

        End With

        sqlDBAdapter.Dispose()
        dataTable.Dispose()


    End Sub
End Class