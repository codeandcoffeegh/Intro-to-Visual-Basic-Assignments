Public Class WeeklyPayApp
    'Creating a module scope variable
    Dim sale As Double
    Private Sub btnTax2_Click(sender As Object, e As EventArgs) Handles btnTax2.Click
        'Calculation for 2% tax on total sales
        Dim tax2 As Double
        sale = CDbl(txtTotalSales.Text.Remove(0, 1)) 'removing characters from index 0 to 1
        tax2 = 0.02 * sale 'this is the same as 0.02 * sale
        txtTax.Text = tax2.ToString("C2")
    End Sub

    Private Sub btnTax5_Click(sender As Object, e As EventArgs) Handles btnTax5.Click
        'Calculation for 5% tax on total sales
        Dim tax5 As Double
        sale = CDbl(txtTotalSales.Text.Remove(0, 1))
        tax5 = 0.05 * sale 'this is the same as 0.05 * sale
        txtTax.Text = tax5.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit statement for the exit button
        Me.Close()
    End Sub

    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnAddSale.Click
        Static Dim totalSales As Double
        Double.TryParse(txtSale.Text, sale) 'converting a string to double and storing it in the sales variable
        totalSales = totalSales + sale
        txtTotalSales.Text = totalSales.ToString("C2")
        Static minSale, maxSale As Double
        Static clickCount As Integer
        clickCount = clickCount + 1
        If clickCount <= 1 Then
            'Checking if the sale = to the first input
            maxSale = sale
            minSale = sale
        Else
            'Finding the max and min sale
            If sale > maxSale Then
                maxSale = sale
            ElseIf sale < minSale Then
                minSale = sale
            End If
        End If
        'Displaying counter for sales
        lblclickCount.Text = clickCount.ToString
        txtMax.Text = maxSale.ToString("C2")
        txtMin.Text = minSale.ToString("C2")
    End Sub

End Class