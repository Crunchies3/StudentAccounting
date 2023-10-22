Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class frm_sDashboard
    Private Sub frm_sDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()

        lbl_accountNumber.Text = "Account Number: " & userID

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayBalances"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                lbl_totalAssessment.Text = "P " & dataTable.Rows(0).Item("totalassessment").ToString
                lbl_totalPayment.Text = "P " & dataTable.Rows(0).Item("totalpayment").ToString
                lbl_currentBalance.Text = "P " & dataTable.Rows(0).Item("totalbalance").ToString
                lbl_perExam.Text = "P " & dataTable.Rows(0).Item("totalassessment") / 8

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub


End Class