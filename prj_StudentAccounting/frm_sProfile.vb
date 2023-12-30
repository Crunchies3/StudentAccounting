Imports MySql.Data.MySqlClient

Public Class frm_sProfile
    Private Sub frm_sProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        initLabels()
    End Sub

    Public Sub initLabels()
        lbl_name.Text = studentName
        lbl_studId.Text = userID
        If (studentProgram = "BSCS") Then
            lbl_program.Text = "Bachelor Of Science In Computer Science"
        ElseIf (studentProgram = "BSIT") Then
            lbl_program.Text = "Bachelor Of Science In Information Technology"
        End If

        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcStudentGetProfile"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    txt_mobileNo.Text = dataTable.Rows(0).Item("mobileno").ToString
                    txt_email.Text = dataTable.Rows(0).Item("emailadd").ToString
                End If

            End With
            sqlDBAdapter.Dispose()
            dataTable.Dispose()


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try




    End Sub

    Private Sub btn_submitChanges_Click(sender As Object, e As EventArgs) Handles btn_submitChanges.Click
        sqlDBAdapter = New MySqlDataAdapter
        dataTable = New DataTable

        Try

            If txt_newPass.Text.Length < 6 And txt_newPass.Text.Length <> 0 Then
                MessageBox.Show("Password must contain 6 or more characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf txt_newPass.Text <> txt_confPass.Text Then
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                With command
                    .Parameters.Clear()
                    .CommandText = "prcStudentUpdateInfo"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", userID)
                    .Parameters.AddWithValue("@p_password", txt_currPass.Text)
                    .Parameters.AddWithValue("@p_mobile", txt_mobileNo.Text)
                    .Parameters.AddWithValue("@p_email", txt_email.Text)
                    .Parameters.AddWithValue("@p_newP", txt_newPass.Text)

                    sqlDBAdapter.SelectCommand = command
                    dataTable.Clear()
                    sqlDBAdapter.Fill(dataTable)
                    If dataTable.Rows.Count = 0 Then
                        MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Info Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End With
                sqlDBAdapter.Dispose()
                dataTable.Dispose()

            End If


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub



End Class