Public Class Form1
    Dim wages As Double
    Dim totalNumberOfGoals, totalNumberOfMatches, totalNumberOfCleenSheets, totalWages As Double

    Dim firstName, lastName, position As String
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Static minimumPlayerWage, maximumPlayerWage As Double
        Static count As Integer
        count = count + 1
        If count <= 1 Then
            maximumPlayerWage = wages
            minimumPlayerWage = wages
        Else
            If wages > maximumPlayerWage Then
                maximumPlayerWage = wages
            ElseIf wages < minimumPlayerWage Then
                minimumPlayerWage = wages
            End If
        End If
        txtMinWage.Text = minimumPlayerWage.ToString()
        txtMaxWage.Text = maximumPlayerWage.ToString()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddPlayer.Click
        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        position = txtPosition.Text


        Dim noOfGoals, noOfMatches, noofcleanSheets As Double

        Double.TryParse(txtWeeklyGoals.Text, noOfGoals)
        Double.TryParse(txtWeeklyMatches.Text, noOfMatches)
        Double.TryParse(txtRegularWage.Text, wages)
        Double.TryParse(txtCleanSheets.Text, noofcleanSheets)

        totalNumberOfGoals = (noOfGoals * 2000)
        totalNumberOfMatches = (0.05 / 100) * wages


        If position = "defender" Then
            totalNumberOfCleenSheets = (0.07 / 100) * wages
        ElseIf position = "goalkeeper" Then
            totalNumberOfCleenSheets = (0.07 / 100) * wages
        End If

        Information.Items.Add(firstName & "       " & lastName & "       " & position & "           
" & " " & wages.ToString("C2") & " " & totalNumberOfGoals.ToString("C2") & "          " & totalNumberOfMatches.ToString("C2") & "             " & totalNumberOfCleenSheets.ToString("C2"))
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPosition.Clear()
        txtRegularWage.Clear()
        txtWeeklyGoals.Clear()
        txtCleanSheets.Clear()
        txtWeeklyMatches.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Information.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Information.Items.RemoveAt(Information.SelectedIndex)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Information.Items.Add("First Name||" & " " & "lastName||" & " " & "Position||" & " " & "Wages||" & " " & "Goals Bonus($)|| " & " " & "Matches Bonus($)|| " & " " & "Cleansheets($)" & " " & "Total Wages")
    End Sub
End Class
