Imports MySql.Data.MySqlClient

Public Class frm_aStudentsList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedIndex = 0
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
                    dgv_TotalStudents.RowCount = dataTable.Rows.Count
                    row = 0
                    While Not dataTable.Rows.Count - 1 < row
                        dgv_TotalStudents.Rows(row).Cells(0).Value = dataTable.Rows(row).Item("id").ToString
                        dgv_TotalStudents.Rows(row).Cells(1).Value = dataTable.Rows(row).Item("studentid").ToString
                        dgv_TotalStudents.Rows(row).Cells(2).Value = dataTable.Rows(row).Item("Fullname").ToString
                        dgv_TotalStudents.Rows(row).Cells(3).Value = dataTable.Rows(row).Item("gender").ToString
                        dgv_TotalStudents.Rows(row).Cells(4).Value = dataTable.Rows(row).Item("program").ToString
                        dgv_TotalStudents.Rows(row).Cells(5).Value = dataTable.Rows(row).Item("yearlevel").ToString
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

    Private Sub frm_aStudentsList_Load(sender As Object, e As EventArgs) Handles Me.Load
        funcDisplayAllStudents()
    End Sub
End Class