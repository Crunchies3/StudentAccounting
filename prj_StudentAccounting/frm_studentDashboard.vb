﻿Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

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

        funcInitializeUserInfo()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        button = 2
        responsive()

        With frm_sSubjects
            .TopLevel = False
            pnl_main.Controls.Add(frm_sSubjects)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'kung pisliton ang button 3 kay iyang i check na dapat ang balance sa student kay
        ' -1000.00 para ma open. pero kung dili less than 0 mag hatag dapat ug messagebox na moingon na mobayad daan 
        ' sa cashier para maka open enroll subject na part


        button = 3
        responsive()

        With frm_sEnrollSubject
            .TopLevel = False
            pnl_main.Controls.Add(frm_sEnrollSubject)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub button5_click(sender As Object, e As EventArgs) Handles Button5.Click
        button = 4
        responsive()
        currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")

        With frm_sAssessment
            .TopLevel = False
            pnl_main.Controls.Add(frm_sAssessment)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub frm_StudentDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        responsive()


    End Sub

    Private Sub responsive()
        Select Case button
            Case 1
                frm_sDashboard.Size = pnl_main.Size
                frm_sDashboard.Location = New Point(0, 0)
                frm_sDashboard.Show()
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        userID = ""
        studentName = ""
        frm_loginStudent.Show()
        Me.Dispose()
    End Sub

    Private Sub frm_StudentDashboard_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        userID = ""
        studentName = ""
        frm_loginStudent.Show()
    End Sub


    Private Sub funcInitializeUserInfo()

        Try
            sqlDBAdapter = New MySqlDataAdapter
            dataTable = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcGetStudentInfo"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", userID)
                sqlDBAdapter.SelectCommand = command
                dataTable.Clear()
                sqlDBAdapter.Fill(dataTable)

                studentName = dataTable.Rows(0).Item("fullname").ToString
                studentProgram = dataTable.Rows(0).Item("program").ToString
                studentYearLevel = dataTable.Rows(0).Item("yearlevel").ToString

            End With

            sqlDBAdapter.Dispose()
            dataTable.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

End Class