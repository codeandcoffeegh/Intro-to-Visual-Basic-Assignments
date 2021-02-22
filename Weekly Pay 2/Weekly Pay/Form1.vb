Public Class frmWeeklyPay2
    Dim weeklyPay As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim percentage, newPay, percentageIncrease As Double
        Double.TryParse(txtWeeklyPay.Text, weeklyPay)
        Double.TryParse(txtPercentageIncrease.Text.TrimEnd(CChar("%")), percentage)

        percentageIncrease = weeklyPay * (percentage / 100)
        newPay = percentageIncrease + weeklyPay
        txtNewPay.Text = newPay.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
