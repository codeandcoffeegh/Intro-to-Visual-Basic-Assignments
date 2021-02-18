<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyPayApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.btnAddSale = New System.Windows.Forms.Button()
        Me.btnTax2 = New System.Windows.Forms.Button()
        Me.btnTax5 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblclickCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weekly Sales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lowest Weekly Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Highest Weekly Sales"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(298, 177)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(69, 20)
        Me.txtTax.TabIndex = 5
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(298, 120)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(69, 20)
        Me.txtTotalSales.TabIndex = 6
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(298, 58)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(69, 20)
        Me.txtSale.TabIndex = 7
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(323, 259)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(66, 20)
        Me.txtMin.TabIndex = 8
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(323, 317)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(66, 20)
        Me.txtMax.TabIndex = 9
        '
        'btnAddSale
        '
        Me.btnAddSale.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnAddSale.Location = New System.Drawing.Point(558, 61)
        Me.btnAddSale.Name = "btnAddSale"
        Me.btnAddSale.Size = New System.Drawing.Size(88, 40)
        Me.btnAddSale.TabIndex = 11
        Me.btnAddSale.Text = "Add Sale"
        Me.btnAddSale.UseVisualStyleBackColor = False
        '
        'btnTax2
        '
        Me.btnTax2.Location = New System.Drawing.Point(558, 145)
        Me.btnTax2.Name = "btnTax2"
        Me.btnTax2.Size = New System.Drawing.Size(88, 38)
        Me.btnTax2.TabIndex = 12
        Me.btnTax2.Text = "2% Tax"
        Me.btnTax2.UseVisualStyleBackColor = True
        '
        'btnTax5
        '
        Me.btnTax5.Location = New System.Drawing.Point(558, 219)
        Me.btnTax5.Name = "btnTax5"
        Me.btnTax5.Size = New System.Drawing.Size(88, 37)
        Me.btnTax5.TabIndex = 13
        Me.btnTax5.Text = "5% Tax"
        Me.btnTax5.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(669, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 42)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblclickCount
        '
        Me.lblclickCount.AutoSize = True
        Me.lblclickCount.Location = New System.Drawing.Point(558, 288)
        Me.lblclickCount.Name = "lblclickCount"
        Me.lblclickCount.Size = New System.Drawing.Size(39, 13)
        Me.lblclickCount.TabIndex = 15
        Me.lblclickCount.Text = "Label6"
        '
        'WeeklyPayApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblclickCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTax5)
        Me.Controls.Add(Me.btnTax2)
        Me.Controls.Add(Me.btnAddSale)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WeeklyPayApp"
        Me.Text = "WeeklyPayApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents btnAddSale As Button
    Friend WithEvents btnTax2 As Button
    Friend WithEvents btnTax5 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblclickCount As Label
End Class
