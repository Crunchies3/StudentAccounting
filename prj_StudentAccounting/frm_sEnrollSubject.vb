Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class frm_sEnrollSubject
    Private Sub frm_sEnrollSubject_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()
        funcLoadLabels()
    End Sub

    Private Sub funcLoadLabels()
        lbl_accountNumber.Text = userID
        lbl_name.Text = studentName
    End Sub

    Private Sub funcDisplaySubject()
        'diria ibutang ang code para i display ang mga available subjects. dapat ang ipakita lang na subject is ka level. example 3rd year student
        'dapat pang 3rd year rapud na subject ang i display


    End Sub


End Class