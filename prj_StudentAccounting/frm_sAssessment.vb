Public Class frm_sAssessment
    Private Sub frm_sAssessment_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_accountNumber.Text = "Account No.: " & userID
        lbl_name.Text = "Name: " & studentName
        lbl_dateTime.Text = Date.Now
    End Sub
End Class