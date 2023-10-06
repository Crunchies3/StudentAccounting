Public Class frm_sAssessment


    Private Sub frm_sAssessment_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        lbl_accountNumber.Text = "Account No.: " & userID
        lbl_name.Text = "Name: " & studentName
        lbl_dateTime.Text = currentDate
    End Sub
End Class