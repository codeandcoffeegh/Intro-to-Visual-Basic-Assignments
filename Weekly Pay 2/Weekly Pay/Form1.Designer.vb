<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeeklyPay2
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
        Me.txtWeeklyPay = New System.Windows.Forms.TextBox()
        Me.txtPercentageIncrease = New System.Windows.Forms.TextBox()
        Me.lblWeeklyPay = New System.Windows.Forms.Label()
        Me.lblPercentageIncrease = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNewPay = New System.Windows.Forms.TextBox()
        Me.lblNewPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtWeeklyPay
        '
        Me.txtWeeklyPay.Location = New System.Drawing.Point(299, 77)
        Me.txtWeeklyPay.Name = "txtWeeklyPay"
        Me.txtWeeklyPay.Size = New System.Drawing.Size(100, 20)
        Me.txtWeeklyPay.TabIndex = 0
        Me.txtWeeklyPay.Text = "0.00"
        '
        'txtPercentageIncrease
        '
        Me.txtPercentageIncrease.Location = New System.Drawing.Point(299, 157)
        Me.txtPercentageIncrease.Name = "txtPercentageIncrease"
        Me.txtPercentageIncrease.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentageIncrease.TabIndex = 1
        Me.txtPercentageIncrease.Text = "0%"
        '
        'lblWeeklyPay
        '
        Me.lblWeeklyPay.AutoSize = True
        Me.lblWeeklyPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyPay.Location = New System.Drawing.Point(126, 77)
        Me.lblWeeklyPay.Name = "lblWeeklyPay"
        Me.lblWeeklyPay.Size = New System.Drawing.Size(90, 20)
        Me.lblWeeklyPay.TabIndex = 2
        Me.lblWeeklyPay.Text = "Weekly Pay"
        '
        'lblPercentageIncrease
        '
        Me.lblPercentageIncrease.AutoSize = True
        Me.lblPercentageIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentageIncrease.Location = New System.Drawing.Point(126, 157)
        Me.lblPercentageIncrease.Name = "lblPercentageIncrease"
        Me.lblPercentageIncrease.Size = New System.Drawing.Size(155, 20)
        Me.lblPercentageIncrease.TabIndex = 3
        Me.lblPercentageIncrease.Text = "Percentage increase"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Lime
        Me.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(553, 142)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(129, 48)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(669, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 43)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtNewPay
        '
        Me.txtNewPay.Location = New System.Drawing.Point(299, 254)
        Me.txtNewPay.Name = "txtNewPay"
        Me.txtNewPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPay.TabIndex = 6
        Me.txtNewPay.Text = "$0.00"
        '
        'lblNewPay
        '
        Me.lblNewPay.AutoSize = True
        Me.lblNewPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPay.Location = New System.Drawing.Point(126, 254)
        Me.lblNewPay.Name = "lblNewPay"
        Me.lblNewPay.Size = New System.Drawing.Size(69, 20)
        Me.lblNewPay.TabIndex = 7
        Me.lblNewPay.Text = "New pay"
        '
        'frmWeeklyPay2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNewPay)
        Me.Controls.Add(Me.txtNewPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPercentageIncrease)
        Me.Controls.Add(Me.lblWeeklyPay)
        Me.Controls.Add(Me.txtPercentageIncrease)
        Me.Controls.Add(Me.txtWeeklyPay)
        Me.Name = "frmWeeklyPay2"
        Me.Text = "Weekly Pay2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWeeklyPay As TextBox
    Friend WithEvents txtPercentageIncrease As TextBox
    Friend WithEvents lblWeeklyPay As Label
    Friend WithEvents lblPercentageIncrease As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNewPay As TextBox
    Friend WithEvents lblNewPay As Label
End Class
