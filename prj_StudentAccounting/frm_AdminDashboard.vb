Public Class frm_AdminDashboard

    Dim button As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button = 1
        responsive()

        With frm_aDashboard_v2
            .TopLevel = False
            pnl_main.Controls.Add(frm_aDashboard_v2)
            .BringToFront()
            .Show()
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

            Case 4


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

    End Sub

    Private Sub frm_AdminDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
        End With
    End Sub
End Class