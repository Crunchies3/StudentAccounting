Imports MySql.Data.MySqlClient

Public Class frm_AdminDashboard

    Dim button As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim refreshList As frm_aDashboard_v2 = DirectCast(Application.OpenForms("frm_aDashboard_v2"), frm_aDashboard_v2)
        refreshList.DashboardStudentsAndDisplayables()

        button = 1
        responsive()

        With frm_aDashboard_v2
            .TopLevel = False
            pnl_main.Controls.Add(frm_aDashboard_v2)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub responsive()
        Select Case button
            Case 1
                frm_aDashboard_v2.Size = pnl_main.Size
                frm_aDashboard_v2.Location = New Point(0, 0)
                frm_aDashboard_v2.Show()
            Case 2
                frm_aStudentsList.Size = pnl_main.Size
                frm_aStudentsList.Location = New Point(0, 0)
                frm_aStudentsList.Show()

            Case 3
                frm_aTeacher.Size = pnl_main.Size
                frm_aTeacher.Location = New Point(0, 0)
                frm_aTeacher.Show()

            Case 4
                frm_aSubjects.Size = pnl_main.Size
                frm_aSubjects.Location = New Point(0, 0)
                frm_aSubjects.Show()
            Case 5
                frm_aFees.Size = pnl_main.Size
                frm_aFees.Location = New Point(0, 0)
                frm_aFees.Show()
            Case 6
                frm_aRecords.Size = pnl_main.Size
                frm_aRecords.Location = New Point(0, 0)
                frm_aRecords.Show()
            Case 7
                frm_aUserAcounts.Size = pnl_main.Size
                frm_aUserAcounts.Show()
                frm_aUserAcounts.Location = New Point(0, 0)


        End Select
    End Sub

    Private Sub frm_AdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        button = 1
        responsive()

        With frm_aDashboard_v2
            .TopLevel = False
            pnl_main.Controls.Add(frm_aDashboard_v2)
            .BringToFront()
            .Show()
        End With

        funcInitAdminDetail()

    End Sub

    Private Sub funcInitAdminDetail()
        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcAdminGetDetails"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", adminUserID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                adminName = dataTable.Rows(0).Item("fullname").ToString
            End With

            Dim word As String() = adminName.Split(New Char() {" "c})
            Dim adminLast = word(0) & " " & word(1) 
            adminLast = adminLast.Substring(0, word(0).Length + 2)

            sqlDBAdapter.Dispose()
            dataTable.Dispose()


            btn_profile.Text = adminLast & "."

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub frm_AdminDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        funcInitAdminDetail()
        responsive()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        button = 2
        responsive()

        With frm_aStudentsList
            .TopLevel = False
            pnl_main.Controls.Add(frm_aStudentsList)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        button = 3
        responsive()

        With frm_aTeacher
            .TopLevel = False
            pnl_main.Controls.Add(frm_aTeacher)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub frm_AdminDashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frm_adminLogin.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        button = 4
        responsive()

        With frm_aSubjects
            .TopLevel = False
            pnl_main.Controls.Add(frm_aSubjects)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        button = 5
        responsive()

        With frm_aFees
            .TopLevel = False
            pnl_main.Controls.Add(frm_aFees)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        button = 6
        responsive()

        With frm_aRecords
            .TopLevel = False
            pnl_main.Controls.Add(frm_aRecords)
            .frm_load()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        frm_adminLogin.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        button = 7
        responsive()

        With frm_aUserAcounts
            .TopLevel = False
            pnl_main.Controls.Add(frm_aUserAcounts)
            .BringToFront()
            .Show()
            .TabControl1.SelectedIndex = 0
        End With
    End Sub
End Class