Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frm_sEnrollSubject
    Private Sub frm_sEnrollSubject_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcLoadLabels()
        funcDisplaySubject()
    End Sub

    Private Sub funcLoadLabels()
        lbl_accountNumber.Text = userID
        lbl_name.Text = studentName
    End Sub

    Private Sub funcDisplaySubject()
        'diria ibutang ang code para i display ang mga available subjects. dapat ang ipakita lang na subject is ka level. example 3rd year student
        'dapat pang 3rd year rapud na subject ang i display

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplaySubjectByYearLevel"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_studentid", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    dgv_enrollSubject.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_enrollSubject.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_enrollSubject.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("title").ToString
                        dgv_enrollSubject.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("description").ToString
                        dgv_enrollSubject.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("units").ToString
                        dgv_enrollSubject.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_enrollSubject.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("level").ToString
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


End Class