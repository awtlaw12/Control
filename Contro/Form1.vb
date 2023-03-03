Public Class Form1
    Private Const V As Boolean = True


    Private Sub btnShipCharge_Click(sender As Object, e As EventArgs) Handles btnShipCharge.Click
        Dim shipCharge As Integer
        If rdtTogo.Checked Then
            shipCharge = 20
        ElseIf rdtNigeria.Checked Then
            shipCharge = 35
        ElseIf rdtBenin.Checked Then
            shipCharge = 30
        Else
            shipCharge = 28
        End If
        If rdtOvernight.Checked Then
            shipCharge = shipCharge + 10
        End If
        txtResults.Text = shipCharge.ToString(“C2”)

    End Sub





    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Display a message box to confirm whether the user wants to exit
        Dim msgResponse As MsgBoxResult, Cancel
        msgResponse = MsgBox("Are you sure you want to exit?", vbQuestion + vbYesNo, "Confirm Exit")

        ' If the user clicks No, cancel the form closing event
        If msgResponse = vbNo Then
            Cancel = True
        ElseIf msgResponse = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
