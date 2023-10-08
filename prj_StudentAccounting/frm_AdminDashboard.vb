Public Class frm_AdminDashboard

    Dim button As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button = 1
        responsive()

        With frm_aDashBoard
            .TopLevel = False
            pnl_main.Controls.Add(frm_aDashBoard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub responsive()
        Select Case button
            Case 1
                frm_aDashBoard.Size = pnl_main.Size
                frm_aDashBoard.Location = New Point(0, 0)
                frm_aDashBoard.Show()
            Case 2
                frm_sSubjects.Size = pnl_main.Size
                frm_sSubjects.Location = New Point(0, 0)
                frm_sSubjects.Show()

            Case 3
                frm_sEnrollSubject.Size = pnl_main.Size
                frm_sEnrollSubject.Location = New Point(0, 0)
                frm_sEnrollSubject.Show()
            Case 4
                frm_sAssessment.Size = pnl_main.Size
                frm_sAssessment.Location = New Point(0, 0)
                frm_sAssessment.Show()

        End Select
    End Sub

    Private Sub frm_AdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

        button = 1
        responsive()

        With frm_aDashBoard
            .TopLevel = False
            pnl_main.Controls.Add(frm_aDashBoard)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub frm_AdminDashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        responsive()

    End Sub
End Class