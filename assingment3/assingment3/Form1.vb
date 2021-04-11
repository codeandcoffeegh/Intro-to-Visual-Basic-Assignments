Imports System.Drawing.Printing
Imports System.Data.DataTable
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MeExit()
    End Sub

    Private Sub MeExit()
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Data Grid View System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MeExit()
    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents cmbGender As ComboBox

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txt.text = ""
            End If
        Next txt
        cmbGender.Text = ""
    End Sub

    Friend WithEvents btnSave As Button

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        DataGridView1.Rows.Add(txtStudent_ID.Text, txtFirstName.Text, txtSurname.Text, txtDateOfBirth.Text, cmbGender.Text, txtAddress.Text, txtMobile.Text, txtEmail.Text)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        DataGridView1.Rows.Add(txtStudent_ID.Text, txtFirstName.Text, txtSurname.Text, txtDateOfBirth.Text, cmbGender.Text, txtAddress.Text, txtMobile.Text, txtEmail.Text)
    End Sub

    Private bitmap As Bitmap

    Private Sub iPrint()
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        iPrint()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        iPrint()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveToExcel()
    End Sub

    Private Sub SaveToExcel()
        Dim excel As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            worksheet = workbook.ActiveSheet

            worksheet.Name = "Imported from DataGridView"

            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1

            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                worksheet.Cells(cellRowIndex, cellColumnIndex) = DataGridView1.Columns(j).HeaderText
                cellColumnIndex += 1
            Next
            cellColumnIndex = 1
            cellRowIndex = 1

            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    worksheet.Cells(cellRowIndex, cellColumnIndex) = DataGridView1.Rows(i).Cells(j).Value.ToString()
                    cellColumnIndex = +1
                Next
                cellColumnIndex = 1
                cellRowIndex += 1
            Next
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 2

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Export successful")
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveToExcel()
    End Sub
End Class