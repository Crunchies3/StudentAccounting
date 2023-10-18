Imports MySql.Data.MySqlClient
Public Class User

    Protected userId As String = ""
    Protected userName As String = ""
    Protected currentDate As String = ""
    Public Sub SetUserId(p_userId As String)
        userId = p_userId
    End Sub

    Public Function GetUserId() As String
        Return userId
    End Function

    Public Sub SetUserPassword(p_password As String)

    End Sub

    Public Sub SetUserName(p_username As String)
        userName = p_username
    End Sub

    Public Function GetUserName() As String
        Return userName
    End Function

    Public Sub SetCurrentDate(p_currentDate As String)
        currentDate = p_currentDate
    End Sub

    Public Function GetCurrentDate() As String
        Return currentDate
    End Function

End Class

Public Class Student
    Inherits User

    Protected yearLevel As String
    Protected program As String
    Protected totalAssessment As Integer
    Protected totalPayment As Integer
    Protected remainingBalance As Integer
    Protected perExam As Integer

    Public Sub SetYearLevel(p_yearlevel As String)
        yearLevel = p_yearlevel
    End Sub

    Public Function GetYearLevel() As String
        Return yearLevel
    End Function

    Public Sub SetProgram(p_program As String)
        program = p_program
    End Sub





End Class
