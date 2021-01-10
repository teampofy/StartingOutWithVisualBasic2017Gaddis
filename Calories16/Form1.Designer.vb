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
        Me.btnCalculateCalories = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalCaloriesConsumed = New System.Windows.Forms.Label()
        Me.txtNumberOfCookies = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculateCalories
        '
        Me.btnCalculateCalories.Location = New System.Drawing.Point(384, 80)
        Me.btnCalculateCalories.Name = "btnCalculateCalories"
        Me.btnCalculateCalories.Size = New System.Drawing.Size(153, 23)
        Me.btnCalculateCalories.TabIndex = 0
        Me.btnCalculateCalories.Text = "Calculate Calories"
        Me.btnCalculateCalories.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Calories Consumed:"
        '
        'lblTotalCaloriesConsumed
        '
        Me.lblTotalCaloriesConsumed.AutoSize = True
        Me.lblTotalCaloriesConsumed.Location = New System.Drawing.Point(381, 143)
        Me.lblTotalCaloriesConsumed.Name = "lblTotalCaloriesConsumed"
        Me.lblTotalCaloriesConsumed.Size = New System.Drawing.Size(20, 17)
        Me.lblTotalCaloriesConsumed.TabIndex = 2
        Me.lblTotalCaloriesConsumed.Text = "..."
        '
        'txtNumberOfCookies
        '
        Me.txtNumberOfCookies.Location = New System.Drawing.Point(196, 81)
        Me.txtNumberOfCookies.Name = "txtNumberOfCookies"
        Me.txtNumberOfCookies.Size = New System.Drawing.Size(167, 22)
        Me.txtNumberOfCookies.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNumberOfCookies)
        Me.Controls.Add(Me.lblTotalCaloriesConsumed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculateCalories)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculateCalories As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalCaloriesConsumed As Label
    Friend WithEvents txtNumberOfCookies As TextBox
End Class
