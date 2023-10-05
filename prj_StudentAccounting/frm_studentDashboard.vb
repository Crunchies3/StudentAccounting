Public Class frm_StudentDashboard

    Dim button As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button = 1
        responsive()

        With frm_sDashboard
            .TopLevel = False
            pnl_main.Controls.Add(frm_sDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub frm_StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button = 1
        responsive()

        With frm_sDashboard
            .TopLevel = False
            pnl_main.Controls.Add(frm_sDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    button = 2
    '    responsive()

    '    With frm_sSubjects
    '        .TopLevel = False
    '        pnl_main.Controls.Add(frm_sSubjects)
    '        .BringToFront()
    '        .Show()
    '    End With
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    button = 3
    '    responsive()

    '    With frm_sEnrollSubject
    '        .TopLevel = False
    '        pnl_main.Controls.Add(frm_sEnrollSubject)
    '        .BringToFront()
    '        .Show()
    '    End With
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    button = 4
    '    responsive()

    '    With frm_sAssessment
    '        .TopLevel = False
    '        pnl_main.Controls.Add(frm_sAssessment)
    '        .BringToFront()
    '        .Show()
    '    End With
    'End Sub

    Private Sub frm_StudentDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        responsive()


    End Sub

    Private Sub responsive()
        Select Case button
            Case 1
                frm_sDashboard.Size = pnl_main.Size
                frm_sDashboard.Location = New Point(0, 0)
                frm_sDashboard.Show()
                'Case 2
                '    frm_sSubjects.Size = pnl_main.Size
                '    frm_sSubjects.Location = New Point(0, 0)
                '    frm_sSubjects.Show()

                'Case 3
                '    frm_sEnrollSubject.Size = pnl_main.Size
                '    frm_sEnrollSubject.Location = New Point(0, 0)
                '    frm_sEnrollSubject.Show()
                'Case 4
                '    frm_sAssessment.Size = pnl_main.Size
                '    frm_sAssessment.Location = New Point(0, 0)
                '    frm_sAssessment.Show()

        End Select
    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    frm_loginStudent.Show()
    '    Me.Dispose()
    'End Sub

    'Private Sub frm_StudentDashboard_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    frm_loginStudent.Show()
    'End Sub


End Class