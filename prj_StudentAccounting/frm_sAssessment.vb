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
            .CommandText = "prcStudentFinalSubjectStatus"
            .CommandType = CommandType.StoredProcedure
            sqlDBAdapter.SelectCommand = command
            dataTable.Clear()
            sqlDBAdapter.Fill(dataTable)

            If dataTable.Rows(0).Item("subjStatus") = True Then
                With command

                    Dim totalUnits As Integer = 0
                    Dim totalAss As Double = 0
                    Dim perUnitFee As Double = 0

                    .Parameters.Clear()
                    .CommandText = "prcGetTotalUnits"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", userID)
                    sqlDBAdapter.SelectCommand = command
                    dataTable.Clear()
                    sqlDBAdapter.Fill(dataTable)

                    totalUnits = dataTable.Rows(0).Item("totalunits")


                    .Parameters.Clear()
                    .CommandText = "prcDisplayStudentAssessment"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", studID)
                    sqlDBAdapter.SelectCommand = command
                    sqlDBAdapter.Fill(dataTable)

                    perUnitFee = dataTable.Rows(1).Item("amount")

                    dataTable.Rows(1)("amount") = totalUnits * (dataTable.Rows(1).Item("amount"))

                    If dataTable.Rows.Count > 0 Then
                        dgv_assessment.RowCount = dataTable.Rows.Count - 1
                        row = 1

                        While Not dataTable.Rows.Count - 1 < row

                            If row = 1 Then
                                totalAss = totalAss + dataTable.Rows(row).Item("amount")
                                dgv_assessment.Rows(row - 1).Cells(0).Value = dataTable.Rows(row).Item("description") & " (" & perUnitFee & " X " & totalUnits & ")".ToString
                                dgv_assessment.Rows(row - 1).Cells(1).Value = "₱ " & dataTable.Rows(row).Item("amount").ToString
                                row = row + 1
                            Else
                                totalAss = totalAss + dataTable.Rows(row).Item("amount")
                                dgv_assessment.Rows(row - 1).Cells(0).Value = dataTable.Rows(row).Item("description").ToString
                                dgv_assessment.Rows(row - 1).Cells(1).Value = "₱ " & dataTable.Rows(row).Item("amount").ToString
                                row = row + 1
                            End If

                        End While
                    End If

                    lbl_totalAssessment.Text = "₱ " & totalAss
                End With
            Else
                MessageBox.Show("Atleast submit 1 finalsubject to display shenanigans", "Submit a Final Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End With

        sqlDBAdapter.Dispose()
        dataTable.Dispose()


    End Sub
End Class