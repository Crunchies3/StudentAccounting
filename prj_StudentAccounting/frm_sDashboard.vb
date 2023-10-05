Public Class frm_sDashboard
    Private Sub frm_sDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkDatabaseConnection()

        lbl_accountNumber.Text = "Account Number: " & userID
    End Sub


End Class