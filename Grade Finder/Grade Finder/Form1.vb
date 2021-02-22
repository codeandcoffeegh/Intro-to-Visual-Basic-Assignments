Public Class Form1
    Dim grade As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Double.TryParse(txtGrade.Text, grade)
        Static minSale, maxSale As Double
        Static clickCount As Integer
        clickCount = clickCount + 1
        If clickCount <= 1 Then
            'Checking if the grade = to the first input
            maxSale = grade
            minSale = grade
        Else
            'Finding the max and min grade
            If grade > maxSale Then
                maxSale = grade
            ElseIf grade < minSale Then
                minSale = grade
            End If
        End If
        'converting grades to string and displaying it to the user
        txtMinGrade.Text = minSale.ToString()
        txtMaxGrade.Text = maxSale.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
