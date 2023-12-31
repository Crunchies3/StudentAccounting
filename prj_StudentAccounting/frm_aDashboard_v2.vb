﻿Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class frm_aDashboard_v2

    Dim access As Boolean = False
    Public id As Integer
    Public studID As String
    Private Shared random As New Random()
    Dim referenceNo As Integer
    Dim ds2 As New DataSet()

    Private Sub createPrintables()
        ds2.Tables.Clear()
        Dim dataTable As New DataTable("ReceiptPrintables")

        dataTable.Columns.Add("studID", GetType(String))
        dataTable.Columns.Add("txtStudentid", GetType(String))
        dataTable.Columns.Add("txtStudentname", GetType(String))
        dataTable.Columns.Add("txtProgram", GetType(String))
        dataTable.Columns.Add("txtYearlevel", GetType(String))
        dataTable.Columns.Add("txtSemester", GetType(String))
        dataTable.Columns.Add("txtReference", GetType(String))
        dataTable.Columns.Add("studentbalance", GetType(String))
        dataTable.Columns.Add("studentperexam", GetType(String))
        dataTable.Columns.Add("transactionType", GetType(String))
        dataTable.Columns.Add("paymentamount", GetType(String))

        Dim row As DataRow = dataTable.NewRow()
        row("studID") = studID
        row("txtStudentid") = txtStudentid.Text
        row("txtStudentname") = txtStudentname.Text
        row("txtProgram") = txtProgram.Text
        row("txtYearlevel") = txtYearlevel.Text
        row("txtSemester") = txtSemester.Text
        row("txtReference") = txtReferenceno.Text
        row("studentbalance") = lbl_StudentTotalBalance.Text
        row("studentperexam") = lbl_StudentPerExam.Text
        row("transactionType") = cmbTransactionType.Text
        row("paymentamount") = txtAmount.Text


        dataTable.Rows.Add(row)
        ds2.Tables.Add(dataTable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_viewPayment.Click
        TabControl1.SelectedIndex = 1
        id = CInt(dgv_enrolledStudents.CurrentRow.Cells(0).Value)
        studID = dgv_enrolledStudents.CurrentRow.Cells(1).Value
        txtStudentid.Text = dgv_enrolledStudents.CurrentRow.Cells(1).Value
        txtStudentname.Text = dgv_enrolledStudents.CurrentRow.Cells(2).Value
        txtProgram.Text = dgv_enrolledStudents.CurrentRow.Cells(4).Value
        txtYearlevel.Text = dgv_enrolledStudents.CurrentRow.Cells(5).Value
        txtSemester.Text = "1"
        PaymentTransactionsAndDisplayables()
    End Sub

    Public Sub PaymentTransactionsAndDisplayables()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayStudentTransactionHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    dgv_transactionHistory.RowCount = dataTable.Rows.Count + 1
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_transactionHistory.Rows(row).Cells(1).Value = "#" & dataTable.Rows(row).Item("referenceno").ToString
                        dgv_transactionHistory.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_transactionHistory.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("amount").ToString
                        row = row + 1
                    End While
                Else
                    dgv_transactionHistory.Rows.Clear()
                End If

            End With

            referenceNo = random.Next(10000, 100000)
            txtReferenceno.Text = referenceNo

            With command
                .Parameters.Clear()
                .CommandText = "prcGetStudentTotalAssessment"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", studID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_TotalAssessment.Text = dataTable.Rows(0).Item("totalAssessment").ToString
            End With

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminPaymentsDisplayables"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_studentAssessment", CDbl(lbl_TotalAssessment.Text))
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_StudentTotalBalance.Text = dataTable.Rows(0).Item("remainingbalance").ToString
                lbl_StudentPerExam.Text = dataTable.Rows(0).Item("perExam").ToString
            End With


            sqlDBAdapter.Dispose()
            dataTable.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub DashboardStudentsAndDisplayables()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayEnrolledStudents"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    dgv_enrolledStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrolledStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrolledStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_enrolledStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_enrolledStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_enrolledStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrolledStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        row = row + 1
                    End While
                End If

            End With

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayStudents"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_totalStudents.Text = dataTable.Rows.Count
            End With

            With command
                .Parameters.Clear()
                .CommandText = "prctotalPayments"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_totalPaymentsReceived.Text = "₱" & dataTable.Rows(0).Item("totalPaymentsReceived").ToString
            End With


            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcGetTotalEnrolledStudent"
                .CommandType = CommandType.StoredProcedure
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_TotalEnrolledStudents.Text = dataTable.Rows(0).Item("total").ToString


            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frm_aDashboard_v2_Load(sender As Object, e As EventArgs) Handles Me.Load
        DashboardStudentsAndDisplayables()
    End Sub

    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click

        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminUpdateStudentBalance"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_totalpayment", CDbl(txtAmount.Text))
                .Parameters.AddWithValue("@p_remainingbalance", CDbl(txtAmount.Text))
                .ExecuteNonQuery()
            End With

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminAddTransactionHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", id)
                .Parameters.AddWithValue("@p_description", cmbTransactionType.Text)
                .Parameters.AddWithValue("@p_amount", CInt(txtAmount.Text))
                .Parameters.AddWithValue("@p_transactiondate", dtTransactionDate.Value)
                .Parameters.AddWithValue("@p_referenceno", txtReferenceno.Text)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Payment Successfully Processed", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PaymentTransactionsAndDisplayables()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        createPrintables()
        ds2.WriteXmlSchema("receipt.xml")
        Dim prntRcpts As New PrintReceipt()
        Dim cr2 As New CrystalReport2
        cr2.SetDataSource(ds2)
        prntRcpts.CrystalReportViewer1.ReportSource = cr2
        prntRcpts.CrystalReportViewer1.Refresh()
        prntRcpts.Show()

    End Sub

    Private Sub DashboardSearchAutoComplete()
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchDashboardAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrolledStudents.RowCount = dataTable.Rows.Count + 1
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrolledStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrolledStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_enrolledStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_enrolledStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_enrolledStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrolledStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        dgv_enrolledStudents.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("semester").ToString
                        row = row + 1
                    End While
                Else
                    txt_search.Clear()
                    MessageBox.Show("Student Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            DashboardSearchAutoComplete()
        Else

        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAdminSearchDashboardEnrolledStudents"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", txt_search.Text)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrolledStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrolledStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrolledStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_enrolledStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("fullname").ToString
                        dgv_enrolledStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_enrolledStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrolledStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("yearlevel").ToString
                        dgv_enrolledStudents.Rows(row).Cells(6).Value = dataTable.Rows(row).Item("semester").ToString
                        row = row + 1
                    End While
                Else
                    txt_search.Clear()
                    MessageBox.Show("Student Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


            End With
            sqlDBAdapter.Dispose()
            dataTable.Dispose()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        DashboardStudentsAndDisplayables()
    End Sub
End Class