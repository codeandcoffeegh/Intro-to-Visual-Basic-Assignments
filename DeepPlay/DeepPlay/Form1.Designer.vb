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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblRegularWage = New System.Windows.Forms.Label()
        Me.lblGoalsScored = New System.Windows.Forms.Label()
        Me.lblMatchesPlayed = New System.Windows.Forms.Label()
        Me.lblCleanSheets = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtRegularWage = New System.Windows.Forms.TextBox()
        Me.txtWeeklyGoals = New System.Windows.Forms.TextBox()
        Me.txtWeeklyMatches = New System.Windows.Forms.TextBox()
        Me.txtCleanSheets = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Information = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMaxWage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinWage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddPlayer = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstName.Location = New System.Drawing.Point(12, 33)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(78, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLastName.Location = New System.Drawing.Point(11, 76)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(77, 16)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(11, 130)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(59, 16)
        Me.lblPosition.TabIndex = 2
        Me.lblPosition.Text = "Position"
        '
        'lblRegularWage
        '
        Me.lblRegularWage.AutoSize = True
        Me.lblRegularWage.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegularWage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRegularWage.Location = New System.Drawing.Point(12, 182)
        Me.lblRegularWage.Name = "lblRegularWage"
        Me.lblRegularWage.Size = New System.Drawing.Size(98, 16)
        Me.lblRegularWage.TabIndex = 3
        Me.lblRegularWage.Text = "Regular Wage"
        '
        'lblGoalsScored
        '
        Me.lblGoalsScored.AutoSize = True
        Me.lblGoalsScored.Location = New System.Drawing.Point(6, 16)
        Me.lblGoalsScored.Name = "lblGoalsScored"
        Me.lblGoalsScored.Size = New System.Drawing.Size(223, 16)
        Me.lblGoalsScored.TabIndex = 4
        Me.lblGoalsScored.Text = "No of Goals Scored In The Week"
        '
        'lblMatchesPlayed
        '
        Me.lblMatchesPlayed.AutoSize = True
        Me.lblMatchesPlayed.Location = New System.Drawing.Point(6, 68)
        Me.lblMatchesPlayed.Name = "lblMatchesPlayed"
        Me.lblMatchesPlayed.Size = New System.Drawing.Size(249, 16)
        Me.lblMatchesPlayed.TabIndex = 5
        Me.lblMatchesPlayed.Text = "No of Matches Played For The Week"
        '
        'lblCleanSheets
        '
        Me.lblCleanSheets.AutoSize = True
        Me.lblCleanSheets.Location = New System.Drawing.Point(6, 115)
        Me.lblCleanSheets.Name = "lblCleanSheets"
        Me.lblCleanSheets.Size = New System.Drawing.Size(261, 16)
        Me.lblCleanSheets.TabIndex = 6
        Me.lblCleanSheets.Text = "Number of Clean Sheets for The Week"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 33)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 19)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 76)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 19)
        Me.txtLastName.TabIndex = 8
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(130, 130)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(100, 19)
        Me.txtPosition.TabIndex = 9
        '
        'txtRegularWage
        '
        Me.txtRegularWage.Location = New System.Drawing.Point(130, 182)
        Me.txtRegularWage.Name = "txtRegularWage"
        Me.txtRegularWage.Size = New System.Drawing.Size(100, 19)
        Me.txtRegularWage.TabIndex = 10
        '
        'txtWeeklyGoals
        '
        Me.txtWeeklyGoals.Location = New System.Drawing.Point(9, 37)
        Me.txtWeeklyGoals.Name = "txtWeeklyGoals"
        Me.txtWeeklyGoals.Size = New System.Drawing.Size(100, 23)
        Me.txtWeeklyGoals.TabIndex = 11
        '
        'txtWeeklyMatches
        '
        Me.txtWeeklyMatches.Location = New System.Drawing.Point(9, 85)
        Me.txtWeeklyMatches.Name = "txtWeeklyMatches"
        Me.txtWeeklyMatches.Size = New System.Drawing.Size(100, 23)
        Me.txtWeeklyMatches.TabIndex = 12
        '
        'txtCleanSheets
        '
        Me.txtCleanSheets.Location = New System.Drawing.Point(9, 132)
        Me.txtCleanSheets.Name = "txtCleanSheets"
        Me.txtCleanSheets.Size = New System.Drawing.Size(100, 23)
        Me.txtCleanSheets.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Information)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(15, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 185)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Players"
        '
        'Information
        '
        Me.Information.FormattingEnabled = True
        Me.Information.ItemHeight = 15
        Me.Information.Location = New System.Drawing.Point(6, 20)
        Me.Information.Name = "Information"
        Me.Information.Size = New System.Drawing.Size(682, 154)
        Me.Information.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMaxWage)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMinWage)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblGoalsScored)
        Me.GroupBox2.Controls.Add(Me.txtWeeklyGoals)
        Me.GroupBox2.Controls.Add(Me.lblMatchesPlayed)
        Me.GroupBox2.Controls.Add(Me.txtWeeklyMatches)
        Me.GroupBox2.Controls.Add(Me.txtCleanSheets)
        Me.GroupBox2.Controls.Add(Me.lblCleanSheets)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(289, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 234)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'txtMaxWage
        '
        Me.txtMaxWage.Location = New System.Drawing.Point(143, 186)
        Me.txtMaxWage.Name = "txtMaxWage"
        Me.txtMaxWage.Size = New System.Drawing.Size(100, 23)
        Me.txtMaxWage.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Highest Wages"
        '
        'txtMinWage
        '
        Me.txtMinWage.Location = New System.Drawing.Point(9, 186)
        Me.txtMinWage.Name = "txtMinWage"
        Me.txtMinWage.Size = New System.Drawing.Size(100, 23)
        Me.txtMinWage.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Lowest Wages"
        '
        'btnAddPlayer
        '
        Me.btnAddPlayer.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAddPlayer.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlayer.ForeColor = System.Drawing.Color.Snow
        Me.btnAddPlayer.Location = New System.Drawing.Point(641, 27)
        Me.btnAddPlayer.Name = "btnAddPlayer"
        Me.btnAddPlayer.Size = New System.Drawing.Size(136, 68)
        Me.btnAddPlayer.TabIndex = 1
        Me.btnAddPlayer.Text = "Add Player"
        Me.btnAddPlayer.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkGreen
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(641, 131)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 70)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkGreen
        Me.btnClear.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(720, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 48)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.DarkGreen
        Me.btnRemove.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRemove.Location = New System.Drawing.Point(720, 307)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(68, 53)
        Me.btnRemove.TabIndex = 16
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkGreen
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(720, 420)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 51)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddPlayer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRegularWage)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblRegularWage)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DeepPlay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblRegularWage As Label
    Friend WithEvents lblGoalsScored As Label
    Friend WithEvents lblMatchesPlayed As Label
    Friend WithEvents lblCleanSheets As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtRegularWage As TextBox
    Friend WithEvents txtWeeklyGoals As TextBox
    Friend WithEvents txtWeeklyMatches As TextBox
    Friend WithEvents txtCleanSheets As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Information As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddPlayer As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtMaxWage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMinWage As TextBox
    Friend WithEvents Label1 As Label
End Class
