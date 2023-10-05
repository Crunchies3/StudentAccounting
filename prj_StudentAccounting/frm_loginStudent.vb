Imports MySql.Data.MySqlClient

Public Class frm_loginStudent

    Dim username As String
    Dim password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        username = txt_username.Text
        password = txt_password.Text

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcLogin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", username)
                .Parameters.AddWithValue("@p_password", password)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
            End With

            If dataTable.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                userID = username
                frm_StudentDashboard.Show()
                Me.Hide()
            End If

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub

    Private Sub frm_loginStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()

    End Sub
End Class