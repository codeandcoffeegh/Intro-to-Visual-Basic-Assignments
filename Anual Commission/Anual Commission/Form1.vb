Public Class annualCommission

    Dim annualCommission As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variables to hold annual sales and commission rate
        Dim annualSale As Double
        Dim commission As Double
        'Converting input from anual sales and commision rate to text
        Double.TryParse(txtAnnualSales.Text, annualSale)
        Double.TryParse(txtCommissionRate.Text.TrimEnd(CChar("%")), commission)
        'Calculating the annual commsion and displaying output to the user
        annualCommission = annualSale * commission
        txtAnnualCommission.Text = annualCommission.ToString("C2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Function to exit program
        Me.Close()
    End Sub
End Class
