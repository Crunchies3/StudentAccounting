Imports MySql.Data.MySqlClient
Public Class frm_aRecords
    Public Sub frm_load()
        checkDatabaseConnection()
        funcDisplayAllStudents()
        clearLabels()
    End Sub

    Private Sub clearLabels()
        txt_birth.Clear()
        txt_email.Clear()
        txt_F.Clear()
        txt_Gender.Clear()
        txt_id.Clear()
        txt_L.Clear()
        txt_M.Clear()
        txt_mobile.Clear()
        txt_program.Clear()
        txt_status.Clear()
        txt_year.Clear()
        dgv_subjects.Rows.Clear()
        dgv_assessment.Rows.Clear()
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
        displayStudentAssessment()


    End Sub

    Private Sub displayStudentAssessment()


        sqlDBAdapter = New MySqlDataAdapter
        Dim dataTableAssessment As New DataTable

        With command

            Dim totalUnits As Integer = 0
            Dim perUnitFee As Double = 0
            Dim totalAss As Double = 0

            .Parameters.Clear()
            .CommandText = "prcGetTotalUnits"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
            sqlDBAdapter.SelectCommand = command
            dataTableAssessment.Clear()
            sqlDBAdapter.Fill(dataTableAssessment)

            totalUnits = dataTableAssessment.Rows(0).Item("totalunits")

            If totalUnits = 0 Then
                Return
            End If

            .Parameters.Clear()
            .CommandText = "prcDisplayStudentAssessment"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
            sqlDBAdapter.SelectCommand = command
            sqlDBAdapter.Fill(dataTableAssessment)

            perUnitFee = dataTableAssessment.Rows(1).Item("amount")

            dataTableAssessment.Rows(1)("amount") = totalUnits * (dataTableAssessment.Rows(1).Item("amount"))

            If dataTableAssessment.Rows.Count > 0 Then
                dgv_assessment.RowCount = dataTableAssessment.Rows.Count - 1
                row = 1

                While Not dataTableAssessment.Rows.Count - 1 < row

                    If row = 1 Then
                        totalAss = totalAss + dataTableAssessment.Rows(row).Item("amount")
                        dgv_assessment.Rows(row - 1).Cells(0).Value = dataTableAssessment.Rows(row).Item("description") & " (" & perUnitFee & " X " & totalUnits & ")".ToString
                        dgv_assessment.Rows(row - 1).Cells(1).Value = "₱ " & dataTableAssessment.Rows(row).Item("amount").ToString
                        row = row + 1
                    Else
                        totalAss = totalAss + dataTableAssessment.Rows(row).Item("amount")
                        dgv_assessment.Rows(row - 1).Cells(0).Value = dataTableAssessment.Rows(row).Item("description").ToString
                        dgv_assessment.Rows(row - 1).Cells(1).Value = "₱ " & dataTableAssessment.Rows(row).Item("amount").ToString
                        row = row + 1
                    End If
                End While
            End If

            lbl_totalAssessment.Text = "Total Assessment: ₱ " & totalAss
        End With
        ds.Tables.Add(dataTableAssessment)
        sqlDBAdapter.Dispose()
        dataTableAssessment.Dispose()

    End Sub

    Private Sub displayStudentSubject()

        Try
            sqlDBAdapter = New MySqlDataAdapter
            Dim dataTableSubject As New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayRecords"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
                .Parameters.AddWithValue("@p_type", "subject")
                sqlDBAdapter.SelectCommand = command
                dataTableSubject.Clear()
                sqlDBAdapter.Fill(dataTableSubject)

                If Not dataTableSubject.Rows.Count = 0 Then
                    dgv_subjects.RowCount = dataTableSubject.Rows.Count + 1
                    row = 0

                    While Not dataTableSubject.Rows.Count - 1 < row
                        dgv_subjects.Rows(row).Cells(0).Value = dataTableSubject.Rows(row).Item("code").ToString
                        dgv_subjects.Rows(row).Cells(1).Value = dataTableSubject.Rows(row).Item("title").ToString
                        dgv_subjects.Rows(row).Cells(2).Value = dataTableSubject.Rows(row).Item("description").ToString
                        dgv_subjects.Rows(row).Cells(3).Value = dataTableSubject.Rows(row).Item("units").ToString
                        dgv_subjects.Rows(row).Cells(4).Value = dataTableSubject.Rows(row).Item("semester").ToString
                        row = row + 1
                    End While

                Else
                    dgv_subjects.Rows.Clear()
                    dgv_assessment.Rows.Clear()
                    lbl_totalAssessment.Text = "Total Assessment:"

                End If


            End With
            ds.Tables.Add(dataTableSubject)
            sqlDBAdapter.Dispose()
            dataTableSubject.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try



    End Sub

    Private Sub displayStudentInfo()

        Try
            sqlDBAdapter = New MySqlDataAdapter
            Dim datatableinfo As New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminDisplayRecords"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", dgv_studentList.CurrentRow.Cells(0).Value)
                .Parameters.AddWithValue("@p_type", "info")
                sqlDBAdapter.SelectCommand = command
                datatableinfo.Clear()
                sqlDBAdapter.Fill(datatableinfo)

                txt_id.Text = datatableinfo.Rows(0).Item("studentid").ToString
                txt_L.Text = datatableinfo.Rows(0).Item("lastname").ToString
                txt_F.Text = datatableinfo.Rows(0).Item("firstname").ToString
                txt_M.Text = datatableinfo.Rows(0).Item("middlename").ToString
                txt_birth.Text = datatableinfo.Rows(0).Item("birthdate").ToString
                txt_Gender.Text = datatableinfo.Rows(0).Item("gender").ToString
                txt_mobile.Text = datatableinfo.Rows(0).Item("mobileno").ToString
                txt_email.Text = datatableinfo.Rows(0).Item("emailadd").ToString
                txt_year.Text = datatableinfo.Rows(0).Item("yearlevel").ToString
                txt_program.Text = datatableinfo.Rows(0).Item("program").ToString
                txt_status.Text = datatableinfo.Rows(0).Item("status").ToString

                Label3.Text = "Student ID: " & datatableinfo.Rows(0).Item("studentid").ToString
            End With
            ds.Tables.Add(datatableinfo)
            sqlDBAdapter.Dispose()
            datatableinfo.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        ds.WriteXmlSchema("print.xml")
        Dim prntfrm As New PrintForm
        Dim cr As New CrystalReport1
        cr.SetDataSource(ds)
        prntfrm.CrystalReportViewer1.ReportSource = cr
        prntfrm.CrystalReportViewer1.Refresh()
        prntfrm.Show()
    End Sub
End Class