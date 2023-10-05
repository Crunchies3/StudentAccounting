Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frm_sEnrollSubject
    Private Sub frm_sEnrollSubject_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcLoadLabels()
    End Sub

    Private Sub funcLoadLabels()
        lbl_accountNumber.Text = userID
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcGetName"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                lbl_name.Text = dataTable.Rows(0).Item("fullname").ToString

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub funcDisplaySubject()
        'diria ibutang ang code para i display ang mga available subjects. dapat ang ipakita lang na subject is ka level. example 3rd year student
        'dapat pang 3rd year rapud na subject ang i display


    End Sub


End Class