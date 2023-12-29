Imports MySql.Data.MySqlClient

Public Class frm_adminLogin
    Dim admin_username As String
    Dim admin_password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin_username = txt_username.Text
        admin_password = txt_password.Text

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcLoginAdmin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", admin_username)
                .Parameters.AddWithValue("@p_password", admin_password)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
            End With

            If dataTable.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                adminUserID = admin_username
                frm_AdminDashboard.Show()
                Me.Hide()
            End If

            sqlDBAdapter.Dispose()
            dataTable.Dispose()



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub frm_adminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_loginStudent.Show()
    End Sub
End Class