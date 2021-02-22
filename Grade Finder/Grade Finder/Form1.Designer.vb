<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtMinGrade = New System.Windows.Forms.TextBox()
        Me.lblMinGrade = New System.Windows.Forms.Label()
        Me.txtMaxGrade = New System.Windows.Forms.TextBox()
        Me.lblMaxGrade = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(373, 144)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade.TabIndex = 0
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGrade.Location = New System.Drawing.Point(220, 147)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(52, 21)
        Me.lblGrade.TabIndex = 1
        Me.lblGrade.Text = "Grade"
        '
        'txtMinGrade
        '
        Me.txtMinGrade.Location = New System.Drawing.Point(373, 210)
        Me.txtMinGrade.Name = "txtMinGrade"
        Me.txtMinGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtMinGrade.TabIndex = 2
        '
        'lblMinGrade
        '
        Me.lblMinGrade.AutoSize = True
        Me.lblMinGrade.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinGrade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMinGrade.Location = New System.Drawing.Point(220, 217)
        Me.lblMinGrade.Name = "lblMinGrade"
        Me.lblMinGrade.Size = New System.Drawing.Size(83, 21)
        Me.lblMinGrade.TabIndex = 3
        Me.lblMinGrade.Text = "Min Grade"
        '
        'txtMaxGrade
        '
        Me.txtMaxGrade.Location = New System.Drawing.Point(373, 284)
        Me.txtMaxGrade.Name = "txtMaxGrade"
        Me.txtMaxGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxGrade.TabIndex = 4
        '
        'lblMaxGrade
        '
        Me.lblMaxGrade.AutoSize = True
        Me.lblMaxGrade.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxGrade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMaxGrade.Location = New System.Drawing.Point(220, 284)
        Me.lblMaxGrade.Name = "lblMaxGrade"
        Me.lblMaxGrade.Size = New System.Drawing.Size(85, 21)
        Me.lblMaxGrade.TabIndex = 5
        Me.lblMaxGrade.Text = "Max Grade"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Navy
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(596, 144)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 56)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(673, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMaxGrade)
        Me.Controls.Add(Me.txtMaxGrade)
        Me.Controls.Add(Me.lblMinGrade)
        Me.Controls.Add(Me.txtMinGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtGrade)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Grade Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtMinGrade As TextBox
    Friend WithEvents lblMinGrade As Label
    Friend WithEvents txtMaxGrade As TextBox
    Friend WithEvents lblMaxGrade As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Button2 As Button
End Class
