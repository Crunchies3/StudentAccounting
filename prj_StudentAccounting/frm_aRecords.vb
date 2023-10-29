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

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        displayStudentInfo()
        displayStudentSubject()



    End Sub

    Private Sub displayStudentAssessment()


        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        With command

            Dim totalUnits As Integer = 0
            Dim perUnitFee As Double = 0
            Dim totalAss As Double = 0

            .Parameters.Clear()
            .CommandText = "prcGetTotalUnits"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
            sqlDBAdapter.SelectCommand = command
            dataTable.Clear()
            sqlDBAdapter.Fill(dataTable)

            totalUnits = dataTable.Rows(0).Item("totalunits")


            .Parameters.Clear()
            .CommandText = "prcDisplayStudentAssessment"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
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
            lbl_totalAssessment.Text = "Total Assessment: ₱ " & totalAss
        End With

        sqlDBAdapter.Dispose()
        dataTable.Dispose()

    End Sub

    Private Sub displayStudentSubject()

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayRecords"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
                .Parameters.AddWithValue("@p_type", "subject")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                If Not dataTable.Rows.Count = 0 Then
                    dgv_subjects.RowCount = dataTable.Rows.Count + 1
                    row = 0

                    While Not dataTable.Rows.Count - 1 < row
                        dgv_subjects.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("code").ToString
                        dgv_subjects.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_subjects.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_subjects.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_subjects.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("semester").ToString
                        row = row + 1
                    End While

                    displayStudentAssessment()

                Else
                    dgv_subjects.Rows.Clear()
                    dgv_assessment.Rows.Clear()
                    lbl_totalAssessment.Text = "Total Assessment:"


                End If

            End With

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try



    End Sub

    Private Sub displayStudentInfo()

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayRecords"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
                .Parameters.AddWithValue("@p_type", "info")
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                txt_id.Text = dataTable.Rows(0).Item("studentid").ToString
                txt_L.Text = dataTable.Rows(0).Item("lastname").ToString
                txt_F.Text = dataTable.Rows(0).Item("firstname").ToString
                txt_M.Text = dataTable.Rows(0).Item("middlename").ToString
                txt_birth.Text = dataTable.Rows(0).Item("birthdate").ToString
                txt_Gender.Text = dataTable.Rows(0).Item("gender").ToString
                txt_mobile.Text = dataTable.Rows(0).Item("mobileno").ToString
                txt_email.Text = dataTable.Rows(0).Item("emailadd").ToString
                txt_year.Text = dataTable.Rows(0).Item("yearlevel").ToString
                txt_program.Text = dataTable.Rows(0).Item("program").ToString
                txt_status.Text = dataTable.Rows(0).Item("status").ToString
            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class