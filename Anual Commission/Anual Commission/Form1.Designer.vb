<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class annualCommission
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
        Me.lblAnnualSales = New System.Windows.Forms.Label()
        Me.lblCommisionRate = New System.Windows.Forms.Label()
        Me.lblAnnualCommission = New System.Windows.Forms.Label()
        Me.txtCommissionRate = New System.Windows.Forms.TextBox()
        Me.txtAnnualSales = New System.Windows.Forms.TextBox()
        Me.txtAnnualCommission = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAnnualSales
        '
        Me.lblAnnualSales.AutoSize = True
        Me.lblAnnualSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnnualSales.Location = New System.Drawing.Point(192, 81)
        Me.lblAnnualSales.Name = "lblAnnualSales"
        Me.lblAnnualSales.Size = New System.Drawing.Size(123, 26)
        Me.lblAnnualSales.TabIndex = 0
        Me.lblAnnualSales.Text = "Annual Sales"
        '
        'lblCommisionRate
        '
        Me.lblCommisionRate.AutoSize = True
        Me.lblCommisionRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommisionRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommisionRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCommisionRate.Location = New System.Drawing.Point(158, 153)
        Me.lblCommisionRate.Name = "lblCommisionRate"
        Me.lblCommisionRate.Size = New System.Drawing.Size(174, 26)
        Me.lblCommisionRate.TabIndex = 1
        Me.lblCommisionRate.Text = "Commission Rate%"
        '
        'lblAnnualCommission
        '
        Me.lblAnnualCommission.AutoSize = True
        Me.lblAnnualCommission.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualCommission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnnualCommission.Location = New System.Drawing.Point(119, 281)
        Me.lblAnnualCommission.Name = "lblAnnualCommission"
        Me.lblAnnualCommission.Size = New System.Drawing.Size(196, 23)
        Me.lblAnnualCommission.TabIndex = 2
        Me.lblAnnualCommission.Text = "Annual Commission"
        '
        'txtCommissionRate
        '
        Me.txtCommissionRate.Location = New System.Drawing.Point(331, 153)
        Me.txtCommissionRate.Name = "txtCommissionRate"
        Me.txtCommissionRate.Size = New System.Drawing.Size(100, 20)
        Me.txtCommissionRate.TabIndex = 3
        '
        'txtAnnualSales
        '
        Me.txtAnnualSales.Location = New System.Drawing.Point(331, 86)
        Me.txtAnnualSales.Name = "txtAnnualSales"
        Me.txtAnnualSales.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualSales.TabIndex = 4
        '
        'txtAnnualCommission
        '
        Me.txtAnnualCommission.Location = New System.Drawing.Point(331, 281)
        Me.txtAnnualCommission.Name = "txtAnnualCommission"
        Me.txtAnnualCommission.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualCommission.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Vodafone ExB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(526, 86)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 91)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calcualte Annual Commision"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(671, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'annualCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAnnualCommission)
        Me.Controls.Add(Me.txtAnnualSales)
        Me.Controls.Add(Me.txtCommissionRate)
        Me.Controls.Add(Me.lblAnnualCommission)
        Me.Controls.Add(Me.lblCommisionRate)
        Me.Controls.Add(Me.lblAnnualSales)
        Me.Name = "annualCommission"
        Me.Text = "Annual Commission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnnualSales As Label
    Friend WithEvents lblCommisionRate As Label
    Friend WithEvents lblAnnualCommission As Label
    Friend WithEvents txtCommissionRate As TextBox
    Friend WithEvents txtAnnualSales As TextBox
    Friend WithEvents txtAnnualCommission As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Button2 As Button
End Class
