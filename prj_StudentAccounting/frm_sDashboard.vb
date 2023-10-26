Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class frm_sDashboard
    Private Sub frm_sDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        displayLabels()
        displayTransactionHistory()

    End Sub
    Private Sub displayTransactionHistory()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayStudentTransactionHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", studID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    dgv_transactionHistory.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_transactionHistory.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("referenceno").ToString
                        dgv_transactionHistory.Rows(row).Cells(1).Value = "#" & dataTable.Rows(row).Item("description").ToString
                        dgv_transactionHistory.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("amount").ToString
                        dgv_transactionHistory.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("transactiondate").ToString
                        row = row + 1
                    End While
                End If

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        End Try
    End Sub

    Private Sub displayLabels()
        lbl_accountNumber.Text = "Account Number: " & userID

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcGetStudentTotalAssessment"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_totalAssessment.Text = dataTable.Rows(0).Item("totalAssessment").ToString
            End With

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayBalances"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)


                lbl_totalPayment.Text = "P " & dataTable.Rows(0).Item("totalpayment").ToString
                lbl_currentBalance.Text = "P " & dataTable.Rows(0).Item("totalbalance").ToString
                lbl_perExam.Text = "P " & dataTable.Rows(0).Item("totalassessment") / 8.0

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


End Class